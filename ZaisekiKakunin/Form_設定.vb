Public Class Form_設定

    Dim ini As New Class_ini
    Dim Class_座席ボタン As New Class_座席ボタン


    Private Sub FormSetting_Load(sender As Object, e As EventArgs) Handles Me.Load
        PropertyGrid1.SelectedObject = My.Settings
    End Sub

    Private Sub ButtonOK_Click(sender As Object, e As EventArgs) Handles ButtonOK.Click
        My.Settings.Save()
        Me.Close()
    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        My.Settings.Reload()
        Me.Close()
    End Sub

    Private Sub FixedBtn_設定出力_Click(sender As Object, e As EventArgs) Handles FixedBtn_設定出力.Click

        Dim 設定ファイルパス As String = Application.StartupPath() & "\設定.ini"
        ini.設定ファイル書き込み（設定ファイルパス）

    End Sub



    Private Sub FixedBtn_SeatClear_Click(sender As Object, e As EventArgs) Handles FixedBtn_SeatClear.Click
        'いったん今あるボタンを（あれば）削除
        Class_座席ボタン.すべての座席ボタンを削除する()
    End Sub

    Private Sub FixedBtn_SeatGenerate_Click(sender As Object, e As EventArgs) Handles FixedBtn_SeatGenerate.Click
        Class_座席ボタン.座席を新規に生成する()
    End Sub

    Private Sub FixedBtn_SeatLoad_Click(sender As Object, e As EventArgs) Handles FixedBtn_SeatLoad.Click
        Class_座席ボタン.座席を再生成する("通常")
    End Sub

    Private Sub FixedBtn_フォルダ表示_Click(sender As Object, e As EventArgs) Handles FixedBtn_フォルダ表示.Click
        System.Diagnostics.Process.Start(Application.StartupPath())
    End Sub
End Class