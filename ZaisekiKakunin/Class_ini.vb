
Imports ZaisekiKakunin.Class_Starter

Public Class Class_ini

    Dim Class_座席ボタン As New Class_座席ボタン

    Declare Function WritePrivateProfileString _
            Lib "KERNEL32.DLL" Alias "WritePrivateProfileStringA" (
                ByVal lpAppName As String,
                ByVal lpKeyName As String,
                ByVal lpString As String,
                ByVal lpFileName As String) As Integer

    Declare Function GetPrivateProfileString _
            Lib "KERNEL32.DLL" Alias "GetPrivateProfileStringA" (
                ByVal lpAppName As String,
                ByVal lpKeyName As String,
                ByVal lpDefault As String,
                ByVal lpReturnedString As String,
                ByVal nSize As Integer,
                ByVal lpFileName As String) As Integer

    Public Function GetIni(ByVal ApName As String,
                           ByVal KeyName As String,
                           ByVal Defaults As String,
                           ByVal Filename As String
                          ) As String
        'INIファイルから参照したいキーの値を取得する  
        'ApName   : セクション名
        'KeyName  : 項目名
        'Default  : 項目が存在しない場合の初期値 
        'FileName : 参照ファイル名
        '****************************************
        Dim strResult As String = Space(65535)
        Call GetPrivateProfileString(ApName, KeyName, Defaults,
                                 strResult, Len(strResult),
                                 Filename)
        GetIni = Microsoft.VisualBasic.Left(strResult,
                                 InStr(strResult, Chr(0)) - 1)
    End Function

    Public Sub PutIni(ByVal ApName As String,
                      ByVal KeyName As String,
                      ByVal Param As String,
                      ByVal Filename As String)
        'INIファイルに新たなキーの値を書込む
        '   ※既存のキーがあれば更新・なければ新規作成する
        'ApName   : セクション名
        'KeyName  : 項目名
        'Param    : 更新する値
        'FileName : 書出ファイル名
        '****************************************
        Call WritePrivateProfileString(ApName, KeyName,
                                       Param, Filename)
    End Sub

    Public Sub 設定ファイル書き込み（設定ファイルパス As String)

        '＜各座席ボタンのテキスト＞
        Dim textForIni As String = ""
        textForIni = My.Settings.各座席ボタンのテキスト.Replace(vbCrLf, "改行")
        textForIni = textForIni.Replace(vbLf, "改行")
        textForIni = textForIni.Replace(vbCr, "改行")
        Call PutIni("BtnInfo", "btnText", textForIni, 設定ファイルパス)

        '＜各座席ボタンのその他のプロパティ＞
        Call PutIni("BtnInfo", "btnCount", My.Settings.各座席ボタンの数, 設定ファイルパス)
        Call PutIni("BtnInfo", "btnFontSize", My.Settings.各座席ボタンのフォントサイズ, 設定ファイルパス)
        Call PutIni("BtnInfo", "btnHeight", My.Settings.各座席ボタンの高さ, 設定ファイルパス)
        Call PutIni("BtnInfo", "btnLocationX", My.Settings.各座席ボタンのX座標, 設定ファイルパス)
        Call PutIni("BtnInfo", "btnLocationY", My.Settings.各座席ボタンのY座標, 設定ファイルパス)
        Call PutIni("BtnInfo", "btnName", My.Settings.各座席ボタンのID, 設定ファイルパス)
        Call PutIni("BtnInfo", "btnWidth", My.Settings.各座席ボタンの幅, 設定ファイルパス)

        '＜離席判定＞
        Call PutIni("UserInfo", "myName", My.Settings.離席判定対象の名前, 設定ファイルパス)
        Call PutIni("UserInfo", "myNumber", My.Settings.離席判定対象のID, 設定ファイルパス)
        Call PutIni("UserInfo", "risekiHantei", My.Settings.離席判定をするかどうか, 設定ファイルパス)
        Call PutIni("UserInfo", "risekiJikan", My.Settings.離席になるまでの時間, 設定ファイルパス)

        '＜自動起動＞
        Call PutIni("AutoStart", "AutoStart", My.Settings.自動起動, 設定ファイルパス)

        '＜自動更新＞
        Call PutIni("AutoUpdate", "AutoUpdate", My.Settings.自動更新をするかどうか, 設定ファイルパス)
        Call PutIni("AutoUpdate", "AutoUpdateTime", My.Settings.自動更新間隔, 設定ファイルパス)

        '＜iruca＞
        Call PutIni("UserInfo", "roomCode", My.Settings.irucaのルームコード, 設定ファイルパス)

    End Sub

    Public Sub 設定ファイルから設定をMySettingsに読み込む(設定ファイルパス As String)

        '＜各座席ボタンのテキスト＞
        My.Settings.各座席ボタンのテキスト = GetIni("BtnInfo", "btnText", "", 設定ファイルパス)
        '   改行コードを元に戻す
        My.Settings.各座席ボタンのテキスト = My.Settings.各座席ボタンのテキスト.Replace("改行", vbCrLf)
        '   半角スペースを元に戻す
        My.Settings.各座席ボタンのテキスト = My.Settings.各座席ボタンのテキスト.Replace("?", " ")

        '＜各座席ボタンのその他のプロパティ＞
        My.Settings.各座席ボタンの数 = GetIni("BtnInfo", "btnCount", 0, 設定ファイルパス)
        My.Settings.各座席ボタンのフォントサイズ = GetIni("BtnInfo", "btnFontSize", 7, 設定ファイルパス)
        My.Settings.各座席ボタンの高さ = GetIni("BtnInfo", "btnHeight", 30, 設定ファイルパス)
        My.Settings.各座席ボタンの幅 = GetIni("BtnInfo", "btnWidth", 110, 設定ファイルパス)
        My.Settings.各座席ボタンのX座標 = GetIni("BtnInfo", "btnLocationX", "", 設定ファイルパス)
        My.Settings.各座席ボタンのY座標 = GetIni("BtnInfo", "btnLocationY", "", 設定ファイルパス)
        My.Settings.各座席ボタンのID = GetIni("BtnInfo", "btnName", "", 設定ファイルパス)

        '＜離席判定対象の名前＞
        My.Settings.離席判定対象の名前 = GetIni("UserInfo", "myName", "", 設定ファイルパス)
        '   半角スペースを元に戻す
        My.Settings.離席判定対象の名前 = My.Settings.離席判定対象の名前.Replace("?", " ")

        '＜離席判定関係のその他のプロパティ＞
        My.Settings.離席判定対象のID = GetIni("UserInfo", "myNumber", "", 設定ファイルパス)
        My.Settings.離席判定をするかどうか = GetIni("UserInfo", "risekiHantei", False, 設定ファイルパス)
        My.Settings.離席になるまでの時間 = GetIni("UserInfo", "risekiJikan", 5, 設定ファイルパス)

        '＜自動起動＞
        My.Settings.自動起動 = GetIni("AutoStart", "AutoStart", True, 設定ファイルパス)

        '＜自動更新＞
        My.Settings.自動更新をするかどうか = GetIni("AutoUpdate", "AutoUpdate", False, 設定ファイルパス)
        My.Settings.自動更新間隔 = GetIni("AutoUpdate", "AutoUpdateTime", 10, 設定ファイルパス)

        '＜iruca＞
        My.Settings.irucaのルームコード = GetIni("UserInfo", "roomCode", "bb4842f5-9956-44eb-8a0d-d7801c685c06", 設定ファイルパス)

    End Sub

    Public Sub 用意された設定ファイルを新規で読み込む()

        'OpenFileDialogクラスのインスタンスを作成
        Dim ofd As New OpenFileDialog()

        'はじめのファイル名を指定する
        'はじめに「ファイル名」で表示される文字列を指定する
        ofd.FileName = "設定.ini"
        'はじめに表示されるフォルダを指定する
        '指定しない（空の文字列）の時は、現在のディレクトリが表示される
        ofd.InitialDirectory = Application.StartupPath()
        '[ファイルの種類]に表示される選択肢を指定する
        '指定しないとすべてのファイルが表示される
        ofd.Filter = "設定ファイル(*.ini)|*.ini"
        '[ファイルの種類]ではじめに選択されるものを指定する
        ofd.FilterIndex = 1
        'タイトルを設定する
        ofd.Title = "開くファイルを選択してください"
        'ダイアログボックスを閉じる前に現在のディレクトリを復元するようにする
        ofd.RestoreDirectory = True

        'ダイアログを表示する
        If ofd.ShowDialog() = DialogResult.OK Then
            'OKボタンがクリックされたとき、選択されたファイル名を表示する
            設定ファイルから設定をMySettingsに読み込む(ofd.FileName)
        End If

    End Sub


End Class
