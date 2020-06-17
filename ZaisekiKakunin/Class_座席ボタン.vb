
Imports ZaisekiKakunin.Class_Starter
Public Class Class_座席ボタン

    Dim Class_ネットワーク As New Class_ネットワーク



    Public Sub 座席を新規に生成する()

        'irucaから座席情報を取得する
        Dim 在席情報 As List(Of 在席情報クラス) = Class_ネットワーク.在席情報リスト()

        '定義
        Dim BUTTON_INTERVAL_YOKO As Integer = 130
        Dim BUTTON_INTERVAL_TATE As Integer = 60
        Dim START_X As Integer = 10
        Dim START_Y As Integer = 20

        Dim 横差分 As Integer = 0
        Dim 縦差分 As Integer = 0

        Dim 人数 As Long = 在席情報.Count

        Dim btn = New Button(人数 - 1) {}
        For i As Integer = 0 To 人数 - 1

            'ボタンのテキスト設定 ・・・　 btnInfoUpdate()からコピー
            Dim ID As String = 在席情報(i).id
            Dim 名前 As String = 在席情報(i).name
            Dim 状態 As String = 在席情報(i).status
            Dim ひとこと As String = 在席情報(i).message
            Dim 更新時間 As Date = 在席情報(i).updated_at
            更新時間 = 更新時間.AddHours(9) '補正処理…なぜかirukaから取得した時刻は9時間遅れている
            Dim 無操作時間 As Long = DateDiff(DateInterval.Minute, 更新時間, Now)
            Dim 時間表示 As String = ""
            If 無操作時間 < 60 Then
                時間表示 = DateDiff(DateInterval.Minute, 更新時間, Now) & "分前"
            ElseIf 無操作時間 > 60 * 24 Then
                時間表示 = DateDiff(DateInterval.Day, 更新時間, Now) & "日前"
            Else
                時間表示 = DateDiff(DateInterval.Hour, 更新時間, Now) & "hr前"
            End If

            Dim ひとこと印 As String = ""
            If ひとこと <> "" Then
                ひとこと印 = "★"
            End If

            Dim BUTTON_TEXT As String = 名前 & vbCrLf & "【" & 状態 & "】" & " " &
                                             時間表示 & ひとこと印 & vbCrLf & "『" & ひとこと & "』"

            'ボタン生成
            btn(i) = New Button
            btn(i).Name = ID
            btn(i).Size = New Size(My.Settings.各座席ボタンの幅, My.Settings.各座席ボタンの高さ)
            btn(i).Font = New Font("MS UI Gothic", My.Settings.各座席ボタンのフォントサイズ)

            'ボタンの背景色を設定
            Select Case 状態
                Case "在席"
                    btn(i).BackColor = Color.GreenYellow
                Case "離席"
                    btn(i).BackColor = Color.Gold
                Case "外出"
                    btn(i).BackColor = Color.WhiteSmoke
                Case "休暇"
                    btn(i).BackColor = Color.LightPink
                Case "取込中"
                    btn(i).BackColor = Color.Tomato
                Case "帰宅"
                    btn(i).BackColor = Color.Violet
            End Select

            横差分 = 横差分 + BUTTON_INTERVAL_YOKO
            If i Mod 5 = 0 Then
                横差分 = 0
                縦差分 = 縦差分 + BUTTON_INTERVAL_TATE
            End If

            btn(i).Location = New Point(START_X + 横差分, START_Y + 縦差分)
            btn(i).Text = BUTTON_TEXT
            btn(i).ContextMenuStrip = f1.ContextMenuStrip右クリック
            f1.ToolTip1.SetToolTip(btn(i), ひとこと)

            AddHandler btn(i).MouseDown, AddressOf f1.マウスダウン
            AddHandler btn(i).MouseMove, AddressOf f1.マウスムーブ
            AddHandler btn(i).Click, AddressOf f1.ボタンクリック

            f1.Controls.Add(btn(i))

        Next
    End Sub


    Public Sub 座席をmysettingsに保存する()

        Dim ButtonCount As Integer = 0 'ボタンの数

        'ボタンの数を調べる
        For Each control As Control In getControls(f1)
            '最初からあるボタンは除外してカウント
            If Strings.Left(control.Name, 5) <> "Fixed" Then
                ButtonCount = ButtonCount + 1
            End If
        Next

        'ボタンの数にあわせて配列を準備
        Dim ButtonName(ButtonCount - 1) As String
        Dim ButtonLocationX(ButtonCount - 1) As String
        Dim ButtonLocationY(ButtonCount - 1) As String
        Dim ButtonText(ButtonCount - 1) As String

        '全ボタンのプロパティを取得
        Dim i As Integer = 0
        For Each control As Control In getControls(f1)
            '最初からあるボタンは除外
            If Strings.Left(control.Name, 5) <> "Fixed" Then
                ButtonName(i) = control.Name
                ButtonLocationX(i) = control.Left
                ButtonLocationY(i) = control.Top
                ButtonText(i) = control.Text
                i = i + 1
            End If
        Next

        '設定（my.setting）に格納
        My.Settings.各座席ボタンの数 = ButtonCount
        My.Settings.各座席ボタンのID = Join(ButtonName, ",")
        My.Settings.各座席ボタンのX座標 = Join(ButtonLocationX, ",")
        My.Settings.各座席ボタンのY座標 = Join(ButtonLocationY, ",")
        My.Settings.各座席ボタンのテキスト = Join(ButtonText, ",")

        '設定を保存
        My.Settings.Save()

    End Sub


    Public Function 座席の状態を調べる(座席ID As String) As String

        For Each control As Control In getControls(f1)
            If control.Name = 座席ID Then
                Return f1.文字を取り出す(control.Text, "【", "】")　'状態
                Exit Function
            End If
        Next
        Return "状態なし"

    End Function

    Public Function 座席の更新時間を調べる(座席ID As String) As String

        For Each control As Control In getControls(f1)
            If control.Name = 座席ID Then
                Return f1.文字を取り出す(control.Text, "】", "前")　'状態
                Exit Function
            End If
        Next
        Return "状態なし"

    End Function


    Public Sub 座席情報を更新する()

        Dim result1 As 在席情報クラス

        'irucaから座席情報を取得する
        Dim 在席情報 As List(Of 在席情報クラス) = Class_ネットワーク.在席情報リスト()

        'いまあるボタン一つづつに対して更新処理
        For Each control As Control In getControls(f1)
            '最初からあるボタンは除外
            If Strings.Left(control.Name, 5) <> "Fixed" Then

                '名前で在席情報の中を検索
                result1 = 在席情報.Find(Function(p) p.id = control.Name)

                'ボタンのテキスト設定
                Dim ID As String = result1.id
                Dim 名前 As String = result1.name
                Dim 状態 As String = result1.status
                Dim ひとこと As String = result1.message
                Dim 更新時間 As Date = result1.updated_at
                更新時間 = 更新時間.AddHours(9) '補正処理…なぜかirukaから取得した時刻は9時間遅れている
                Dim 無操作時間 As Long = DateDiff(DateInterval.Minute, 更新時間, Now)

                Dim ひとこと印 As String = ""
                If ひとこと <> "" Then
                    ひとこと印 = "★"
                End If

                'ボタンの背景色を設定
                Select Case 状態
                    Case "在席"
                        control.BackColor = Color.GreenYellow
                    Case "離席"
                        control.BackColor = Color.Gold
                    Case "外出"
                        control.BackColor = Color.SkyBlue
                    Case "休暇"
                        control.BackColor = Color.LightPink
                    Case "取込中"
                        control.BackColor = Color.Tomato
                    Case "帰宅"
                        control.BackColor = Color.Violet
                End Select

                '時間表示更新
                Dim 時間表示 As String = ""
                If 無操作時間 < 60 Then
                    時間表示 = DateDiff(DateInterval.Minute, 更新時間, Now) & "分前"
                    control.ForeColor = Color.Black
                ElseIf 無操作時間 > 60 * 24 Then
                    時間表示 = DateDiff(DateInterval.Day, 更新時間, Now) & "日前"
                    control.ForeColor = Color.Gray
                    control.BackColor = Color.White
                Else
                    時間表示 = DateDiff(DateInterval.Hour, 更新時間, Now) & "hr前"
                    control.ForeColor = Color.Black
                End If

                'テキスト更新
                Dim BUTTON_TEXT As String = 名前 & vbCrLf & "【" & 状態 & "】" & " " &
                                 時間表示 & ひとこと印 & vbCrLf & vbCrLf & "『" & ひとこと & "』"
                control.Text = BUTTON_TEXT

                'ボタンの他のプロパティ更新
                control.Name = ID
                control.ContextMenuStrip = f1.ContextMenuStrip右クリック
                f1.ToolTip1.SetToolTip(control, ひとこと)

            End If
        Next
    End Sub


    Public Sub 座席を再生成する(モード As String)

        'いったん今あるボタンを（あれば）削除
        すべての座席ボタンを削除する()

        'ボタンの数を,の数からカウントして記録
        Dim 各座席ボタンのID集 As String = My.Settings.各座席ボタンのID
        If 各座席ボタンのID集 Is Nothing Then
            Exit Sub
        End If
        Dim KanmaCount As Integer = 各座席ボタンのID集.Length - 各座席ボタンのID集.Replace(",", "").Length

        '読み込んだデータが空だった場合は途中で抜ける
        If KanmaCount < 1 Then
            Exit Sub
        End If

        Dim ButtonCount As Integer = KanmaCount + 1
        My.Settings.各座席ボタンの数 = ButtonCount

        '配列の復元
        Dim ButtonName() As String = My.Settings.各座席ボタンのID.Split(",")
        Dim ButtonLocationX() As String = My.Settings.各座席ボタンのX座標.Split(",")
        Dim ButtonLocationY() As String = My.Settings.各座席ボタンのY座標.Split(",")
        Dim ButtonText() As String = My.Settings.各座席ボタンのテキスト.Split(",")

        'ボタンの生成
        Dim btn = New Button(ButtonCount) {}
        For i As Integer = 0 To ButtonCount - 1

            btn(i) = New Button
            btn(i).Name = ButtonName(i)
            btn(i).Size = New Size(My.Settings.各座席ボタンの幅, My.Settings.各座席ボタンの高さ)
            btn(i).Font = New Font("MS UI Gothic", My.Settings.各座席ボタンのフォントサイズ)
            btn(i).Location = New Point(CInt(ButtonLocationX(i)), CInt(ButtonLocationY(i)))
            btn(i).Text = ButtonText(i)
            btn(i).TextAlign = ContentAlignment.TopCenter

            If モード = "移動" Then
                btn(i).FlatStyle = FlatStyle.Flat
                AddHandler btn(i).MouseDown, AddressOf f1.マウスダウン
                AddHandler btn(i).MouseMove, AddressOf f1.マウスムーブ
            ElseIf モード = "通常" Then
                btn(i).FlatStyle = FlatStyle.Standard
                AddHandler btn(i).Click, AddressOf f1.ボタンクリック
            End If

            f1.Controls.Add(btn(i))
        Next

        '情報更新
        座席情報を更新する()

        'Refresh()
        f1.Refresh()

    End Sub

    Public Sub すべての座席ボタンを削除する()
        For Each control As Control In getControls(f1)
            '最初からあるボタンは除外
            If Strings.Left(control.Name, 5) <> "Fixed" Then
                f1.Controls.RemoveByKey(control.Name)
            End If
        Next
    End Sub


    'targetの中のコントロールを再帰的にすべて探索（TabPage内もOK！）
    '※ループの中でボタンコントロールに絞り込み
    Public Function getControls(target As Control) As ArrayList
        Dim controls As ArrayList = New ArrayList
        For Each control As Control In target.Controls
            'ボタンコントロールのみリストに追加
            If TypeOf control Is Button Then controls.Add(control)
        Next
        Return controls
    End Function


End Class
