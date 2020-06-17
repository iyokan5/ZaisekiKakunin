
Public Class 設定フォーム

    Dim Class_ini As New Class_ini
    Dim Class_レジストリ As New Class_レジストリ
    Dim Class_座席ボタン As New Class_座席ボタン

    Private Sub 設定フォーム_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        設定フォームラベル更新()

    End Sub

    Public Sub 設定フォームラベル更新()

        Labelルームコード.Text = My.Settings.irucaのルームコード
        Label登録者数.Text = My.Settings.各座席ボタンの数
        NumericUpDown高さ.Value = My.Settings.各座席ボタンの高さ
        NumericUpDown幅.Value = My.Settings.各座席ボタンの幅
        NumericUpDown文字サイズ.Value = My.Settings.各座席ボタンのフォントサイズ
        CheckBox自動起動.Checked = My.Settings.自動起動

    End Sub

    Private Sub Button標準サイズに戻す_Click(sender As Object, e As EventArgs) Handles Button標準サイズに戻す.Click

        NumericUpDown高さ.Value = 35
        NumericUpDown幅.Value = 135
        NumericUpDown文字サイズ.Value = 9

        My.Settings.各座席ボタンの高さ = 35
        My.Settings.各座席ボタンの幅 = 135
        My.Settings.各座席ボタンのフォントサイズ = 9

        Class_座席ボタン.座席を再生成する("通常")

    End Sub

    Private Sub Button座席ボタン更新_Click(sender As Object, e As EventArgs) Handles Button座席ボタン更新.Click

        My.Settings.各座席ボタンの高さ = NumericUpDown高さ.Value
        My.Settings.各座席ボタンの幅 = NumericUpDown幅.Value
        My.Settings.各座席ボタンのフォントサイズ = NumericUpDown文字サイズ.Value

        Class_座席ボタン.座席を再生成する("通常")

    End Sub

    Private Sub Button設定ファイルを読み込む_Click(sender As Object, e As EventArgs) Handles Button設定ファイルを読み込む.Click
        Class_ini.用意された設定ファイルを新規で読み込む()
        Class_座席ボタン.座席を再生成する("通常")
    End Sub



    Private Sub ButtonINI上書保存_Click(sender As Object, e As EventArgs) Handles ButtonINI上書保存.Click
        Dim 設定ファイルパス As String = Application.StartupPath() & "\設定.ini"
        Class_ini.設定ファイル書き込み（設定ファイルパス）
        MessageBox.Show(”設定ファイルを実行ファイルと同じ場所に書き込みました。")
    End Sub

    Private Sub ButtonOK_Click(sender As Object, e As EventArgs) Handles ButtonOK.Click

        '自動起動設定の書き込み（レジストリ）


        If CheckBox自動起動.Checked = True Then
            Class_レジストリ.自動起動を有効にする()
            My.Settings.自動起動 = True
        Else
            Class_レジストリ.自動起動を無効にする()
            My.Settings.自動起動 = False
        End If

        '閉じる
        Me.Close()

    End Sub

    Private Sub Buttonキャンセル_Click(sender As Object, e As EventArgs) Handles Buttonキャンセル.Click
        '閉じる
        Me.Close()
    End Sub

End Class