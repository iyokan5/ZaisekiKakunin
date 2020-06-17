Imports System.ComponentModel
Imports System.IO
Imports System.Net
Imports System.Runtime.InteropServices
Imports System.Runtime.Serialization.Json
Imports System.Text

Public Class Form1

    Dim Class_ini As New Class_ini
    Dim Class_ネットワーク As New Class_ネットワーク
    Dim Class_座席ボタン As New Class_座席ボタン
    Dim class_レジストリ As New Class_レジストリ

    Public span2 As TimeSpan
    Public 前回の時間 As Integer
    Public 前回更新からの経過時間 As Integer
    Public ループカウンター As Integer

    'APIの定義
    <DllImport("user32.dll")>
    Shared Function GetLastInputInfo(ByRef plii As LASTINPUTINFO) As Boolean
    End Function

    <StructLayout(LayoutKind.Sequential)>
    Structure LASTINPUTINFO
        Public cbSize As UInteger
        Public dwTime As UInteger
    End Structure


    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        'ウィンドウの位置とサイズを復元
        If My.Settings.ウィンドウのX座標 <> 0 Then
            Me.Left = My.Settings.ウィンドウのX座標
        End If
        If My.Settings.ウィンドウのY座標 <> 0 Then
            Me.Top = My.Settings.ウィンドウのY座標
        End If
        If My.Settings.ウィンドウの幅 <> 0 Then
            Me.Width = My.Settings.ウィンドウの幅
        End If
        If My.Settings.ウィンドウの高さ <> 0 Then
            Me.Height = My.Settings.ウィンドウの高さ
        End If

        '設定.iniファイルがインストール場所になければ、初期設定モードに入る
        Dim 設定ファイルパス As String = Application.StartupPath() & "\設定.ini"
        If System.IO.File.Exists(設定ファイルパス) = False Then

            '＜＜初期設定モード＞＞
            Class_ini.用意された設定ファイルを新規で読み込む()

            '自動離席判定をOFFに上書き設定（my.settingsの初期値がインストールされない？問題への対応）
            My.Settings.離席判定をするかどうか = False
            My.Settings.離席判定対象のID = "未設定"
            My.Settings.離席判定対象の名前 = "なし"

            'ラベルや設定値を読み込んで表示
            Me.フォーム上のラベルを更新する()

            'ボタン再生成
            Class_座席ボタン.座席を再生成する("通常")

            '自動更新をON
            class_レジストリ.自動起動を有効にする()
            My.Settings.自動起動 = True

        Else

            '＜＜通常運用モード＞＞
            ''設定.iniファイルがあれば通常起動
            Class_ini.設定ファイルから設定をMySettingsに読み込む（設定ファイルパス）

            'ラベルや設定値を読み込んで表示
            Me.フォーム上のラベルを更新する()

            'ボタン再生成
            Class_座席ボタン.座席を再生成する("通常")

            '***　irucaサーバーの登録にあわせてボタンを追加・削除　***
            'irucaから座席情報を取得する

            'Dim 在席情報 As List(Of 在席情報クラス) = 在席情報リスト()

        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        'フォーム上のTimer1プロパティに呼び出し間隔を設定（10秒ごと）

        '設定読み込み
        Dim 離席_分 As Integer = NumericUpDown離席になるまでの時間.Value
        Dim 自席ID As String = My.Settings.離席判定対象のID
        Dim 自動判定 As String = Label自動離席判定.Text

        '無操作時間を調べる
        Dim info As LASTINPUTINFO
        Dim r As Boolean
        info.cbSize = Marshal.SizeOf(info)
        r = GetLastInputInfo(info)
        Dim 無操作時間_ミリ秒 As TimeSpan = New TimeSpan((Environment.TickCount - info.dwTime) * 10000)

        'ラベルを更新
        Label無操作時間.Text = 無操作時間_ミリ秒.ToString("hh\:mm\:ss")

        If 自席ID = "未設定" Then
            Exit Sub
        Else
            '自席IDの状態を調べる
            Dim 状態 As String = Class_座席ボタン.座席の状態を調べる(自席ID)
            Dim 更新時間 As String = Class_座席ボタン.座席の更新時間を調べる(自席ID)

            '無操作時間が1秒以下のとき
            If 無操作時間_ミリ秒.TotalMilliseconds < 1000 Then

                '自席IDの状態が在席じゃないとき、もしくは在席でも～hr前や～日前のときは、在席に切り替える
                If 状態 <> "在席" Or (状態 = "在席" And 更新時間.Contains("分") = False) Then
                    '在席に切り替える
                    Class_ネットワーク.メンバー情報を更新する(自席ID, "在席")
                    '情報更新
                    Class_座席ボタン.座席情報を更新する()
                End If

            End If

            '自動離席切替処理
            If (無操作時間_ミリ秒.TotalSeconds >= (離席_分 * 60)) And
               (無操作時間_ミリ秒.TotalSeconds < ((離席_分 * 60) + 5)) Then

                '離席に切り替える
                Class_ネットワーク.メンバー情報を更新する(自席ID, "離席")
                '情報更新
                Class_座席ボタン.座席情報を更新する()

            End If
        End If

    End Sub




    Private timer2 As Timer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'timer2 = New Timer With {.Interval = 10000, .Enabled = True} '10秒に一回判定
        'AddHandler timer2.Tick, Sub()

        '                            Dim info As LASTINPUTINFO
        '                            Dim r As Boolean

        '                            info.cbSize = Marshal.SizeOf(info)
        '                            r = GetLastInputInfo(info)

        '                            'span は、Windows上で操作をやめたときからの経過時間
        '                            Dim span = New TimeSpan((Environment.TickCount - info.dwTime) * 10000)
        '                            Me.Text = $"無操作時間 = {span.ToString("hh\:mm\:ss")}"

        '                            Dim spanDiff = span2 - span

        '                            Dim 何分で離席と判定するか As Integer = My.Settings.離席になるまでの時間 '分単位
        '                            Dim 無操作時間 As Integer = span.TotalSeconds　'秒単位
        '                            Dim 自席番号 As String = My.Settings.離席判定対象のID

        '                            '自動変更ONで自席設定ができている場合のみ、切替処理をする。
        '                            If My.Settings.離席判定をするかどうか = True And 自席番号 <> "" Then

        '                                If 何分で離席と判定するか * 60 + 10 > 無操作時間 And 無操作時間 > 何分で離席と判定するか * 60 Then
        '                                    '離席に切り替える
        '                                    Class_ネットワーク.メンバー情報を更新する(自席番号, "離席")
        '                                    '情報更新
        '                                    Class_座席ボタン.座席情報を更新する()
        '                                ElseIf spanDiff.TotalMinutes >= 1 Then '前回からの無操作時間の差が1分以上のとき
        '                                    '在席に切り替える
        '                                    Class_ネットワーク.メンバー情報を更新する(自席番号, "在席")
        '                                    '情報更新
        '                                    Class_座席ボタン.座席情報を更新する()
        '                                Else
        '                                    'なにもしない
        '                                End If
        '                            End If

        '                            '自動更新処理
        '                            If CheckBox自動更新.Checked = True Then

        '                                '設定確認
        '                                Dim 更新間隔_分 As Integer = NumericUpDown自動更新間隔.Value
        '                                Dim 更新間隔_ミリ秒 As Integer = 更新間隔_分 * 60 * 1000

        '                                前回更新からの経過時間 = 前回更新からの経過時間 + （Environment.TickCount - 前回の時間）

        '                                If 前回更新からの経過時間 > 更新間隔_ミリ秒 Then
        '                                    '更新する
        '                                    Class_座席ボタン.座席情報を更新する()
        '                                    前回更新からの経過時間 = 0 'リセット
        '                                Else
        '                                    '更新しないでスルー
        '                                End If

        '                            End If

        '                            '次回のループで使用する変数の準備
        '                            span2 = span '次のループのときに使う
        '                            前回の時間 = Environment.TickCount

        '                        End Sub

    End Sub

    Public Sub フォーム上のラベルを更新する()

        Dim 自動離席判定の表示 As String
        If My.Settings.離席判定をするかどうか = True Then
            自動離席判定の表示 = "ON（" & My.Settings.離席になるまでの時間 & "分）"
        Else
            自動離席判定の表示 = "OFF"
        End If

        Label自動離席判定.Text = 自動離席判定の表示
        Label更新対象.Text = My.Settings.離席判定対象の名前
        NumericUpDown離席になるまでの時間.Value = My.Settings.離席になるまでの時間

        Me.Refresh()

    End Sub


    Private Sub FixedBtn_SeatGenerate_Click(sender As Object, e As EventArgs)
        Class_座席ボタン.座席を新規に生成する()
    End Sub


    Private Click_初期クリック位置 As Point

    Public Sub マウスダウン(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            Click_初期クリック位置 = e.Location
        End If
    End Sub

    Public Sub マウスムーブ(sender As Object, e As MouseEventArgs)
        If e.Button = Windows.Forms.MouseButtons.Left Then

            Dim 移動先x = e.X - Click_初期クリック位置.X + sender.location.x
            Dim 移動先y = e.Y - Click_初期クリック位置.Y + sender.location.y

            '10ピクセルごとに吸い付く設定
            移動先x = (移動先x \ 10) * 10
            移動先y = (移動先y \ 10) * 10

            'ボタンを移動
            Dim mp移動先座標 As New Point(移動先x, 移動先y)
            sender.location = mp移動先座標

        End If
    End Sub

    Public Sub ボタンクリック(sender As Object, e As EventArgs)

        Dim btn As Button = CType(sender, Button) '押されたボタンはsenderに渡されてくる
        Dim btnID As String = btn.Name
        Dim btnText As String = btn.Text
        Dim 状態 As String = 文字を取り出す(btnText, "【", "】")

        If 状態 = "在席" Then
            'irukaのデータを離席にする
            Class_ネットワーク.メンバー情報を更新する(btnID, "離席")

        Else
            'irukaのデータを在席にする
            Class_ネットワーク.メンバー情報を更新する(btnID, "在席")

        End If

        'ボタン表示を更新
        Class_座席ボタン.座席情報を更新する()

    End Sub

    Private Sub FixedBtn_SeatLoad_Click(sender As Object, e As EventArgs)
        Class_座席ボタン.座席を再生成する("通常")
    End Sub

    Private Sub FixedBtn_Setting_Click(sender As Object, e As EventArgs) Handles FixedBtn_Setting.Click
        設定フォーム.Show()
        Form_設定.Show()
    End Sub

    Private Sub FixedBtn_更新_Click(sender As Object, e As EventArgs) Handles FixedBtn_更新.Click
        Class_座席ボタン.座席情報を更新する()
    End Sub

    Public Function 文字を取り出す(テキスト As String, 区切り文字1 As String, 区切り文字2 As String) As String

        Dim foundIndex1 As Integer = テキスト.IndexOf(区切り文字1)
        Dim foundIndex2 As Integer = テキスト.IndexOf(区切り文字2）
        Dim 文字 As String = Mid(テキスト, foundIndex1 + 2, foundIndex2 - foundIndex1 - 1)

        Return 文字

    End Function

    Private Function 名前を取り出す(テキスト As String) As String
        Dim foundIndex1 As Integer = テキスト.IndexOf(vbCrLf)
        Dim 文字 As String = Strings.Left(テキスト, foundIndex1)
        Return 文字
    End Function

    Private Sub ToolStripMenuItem取込中_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem取込中.Click
        'どのボタンが押されたか調べる
        Dim source As Control = ContextMenuStrip右クリック.SourceControl
        'irucaの情報を更新
        Class_ネットワーク.メンバー情報を更新する(source.Name, "取込中")
        'ボタン表示を更新
        Class_座席ボタン.座席情報を更新する()
    End Sub

    Private Sub 外出ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 外出ToolStripMenuItem.Click
        'どのボタンが押されたか調べる
        Dim source As Control = ContextMenuStrip右クリック.SourceControl
        'irucaの情報を更新
        Class_ネットワーク.メンバー情報を更新する(source.Name, "外出")
        'ボタン表示を更新
        Class_座席ボタン.座席情報を更新する()
    End Sub

    Private Sub 休暇ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 休暇ToolStripMenuItem.Click
        'どのボタンが押されたか調べる
        Dim source As Control = ContextMenuStrip右クリック.SourceControl
        'irucaの情報を更新
        Class_ネットワーク.メンバー情報を更新する(source.Name, "休暇")
        'ボタン表示を更新
        Class_座席ボタン.座席情報を更新する()
    End Sub

    Private Sub 帰宅ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 帰宅ToolStripMenuItem.Click
        'どのボタンが押されたか調べる
        Dim source As Control = ContextMenuStrip右クリック.SourceControl
        'irucaの情報を更新
        Class_ネットワーク.メンバー情報を更新する(source.Name, "帰宅")
        'ボタン表示を更新
        Class_座席ボタン.座席情報を更新する()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        If CheckBox1.Checked = True Then
            '移動モードにするとき
            Class_座席ボタン.座席を再生成する("移動")
        Else
            '通常モードに戻すとき
            Class_座席ボタン.座席をmysettingsに保存する()
            Class_座席ボタン.座席を再生成する("通常")
        End If

    End Sub

    Private Sub 自動切替ONToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 自動切替ONToolStripMenuItem.Click
        'どのボタンが押されたか調べる
        Dim source As Control = ContextMenuStrip右クリック.SourceControl

        'ラベルを更新
        Label自動離席判定.Text = "ON"
        Dim 名前 As String = 名前を取り出す(source.Text)
        Label更新対象.Text = 名前

        '設定を更新
        My.Settings.離席判定をするかどうか = True
        My.Settings.離席判定対象のID = source.Name
        My.Settings.離席判定対象の名前 = 名前

    End Sub

    Private Sub 自動切替OFFToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 自動切替OFFToolStripMenuItem.Click

        'ラベルを更新
        Label自動離席判定.Text = "OFF"
        Label更新対象.Text = "なし"

        '設定を更新
        My.Settings.離席判定をするかどうか = False
        My.Settings.離席判定対象のID = "未設定"
        My.Settings.離席判定対象の名前 = "なし"
    End Sub


    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        'ウィンドウの位置とサイズを保存
        My.Settings.ウィンドウのX座標 = Me.Location.X
        My.Settings.ウィンドウのY座標 = Me.Location.Y
        My.Settings.ウィンドウの幅 = Me.Size.Width
        My.Settings.ウィンドウの高さ = Me.Size.Height

        'my.settingsを保存（アプリケーションフレームワークが無効のため必要）
        My.Settings.Save()

        'iniファイルを更新
        Dim 設定ファイルパス As String = Application.StartupPath() & "\設定.ini"
        Class_ini.設定ファイル書き込み（設定ファイルパス）

        '終了処理のキャンセル（タスクトレイにしまうため）
        e.Cancel = True
        Me.Visible = False

    End Sub

    Private Sub 終了ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 終了ToolStripMenuItem.Click
        NotifyIcon1.Visible = False
        Application.Exit()
    End Sub

    Private Sub 座席表示ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 座席表示ToolStripMenuItem.Click
        フォームを表示する()
    End Sub
    Private Sub NotifyIcon1_DoubleClick(sender As Object, e As EventArgs) Handles NotifyIcon1.DoubleClick
        フォームを表示する()
    End Sub

    Private Sub NotifyIcon1_Click(sender As Object, e As EventArgs) Handles NotifyIcon1.Click
        フォームを表示する()
    End Sub

    Private Sub フォームを表示する()
        Me.Visible = True ' フォームの表示
        If Me.WindowState = FormWindowState.Minimized Then
            Me.WindowState = FormWindowState.Normal ' 最小化をやめる
        End If
        Me.Activate() ' フォームをアクティブにする
    End Sub

    Private Sub NumericUpDown離席になるまでの時間_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown離席になるまでの時間.ValueChanged
        My.Settings.離席になるまでの時間 = NumericUpDown離席になるまでの時間.Value
    End Sub

    Private Sub NumericUpDown自動更新間隔_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown自動更新間隔.ValueChanged
        My.Settings.自動更新間隔 = NumericUpDown自動更新間隔.Value
    End Sub

End Class





