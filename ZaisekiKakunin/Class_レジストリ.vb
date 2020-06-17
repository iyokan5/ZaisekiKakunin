Public Class Class_レジストリ

    '自動起動させるようにする
    Public Sub 自動起動を有効にする()

        'Runキーを開く
        Dim regkey As Microsoft.Win32.RegistryKey =
            Microsoft.Win32.Registry.CurrentUser.OpenSubKey(
            "Software\Microsoft\Windows\CurrentVersion\Run", True)

        '値の名前に製品名、値のデータに実行ファイルのパスを指定し、書き込む
        regkey.SetValue(Application.ProductName, Application.ExecutablePath)

        '閉じる
        regkey.Close()

    End Sub


    '自動起動を解除する
    Public Sub 自動起動を無効にする()

        'Runキーを開く
        Dim regkey As Microsoft.Win32.RegistryKey =
            Microsoft.Win32.Registry.CurrentUser.OpenSubKey(
            "Software\Microsoft\Windows\CurrentVersion\Run", True)

        '値の名前に製品名、値のデータに実行ファイルのパスを指定し、書き込む
        regkey.DeleteValue(Application.ProductName, False)

        '閉じる
        regkey.Close()

    End Sub

End Class
