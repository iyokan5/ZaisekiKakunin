Imports System.IO
Imports System.Net
Imports System.Text

Public Class Class_ネットワーク
    Public Function 在席情報リスト() As List(Of 在席情報クラス)

        '全体設定
        Dim ルームコード As String = My.Settings.irucaのルームコード

        'APIの呼び出し
        Dim TargetURL As String
        TargetURL = "https://iruca.co/api/rooms/" & ルームコード & "/members/"


        '-------ここからはAPI通信のお約束部分-------
        '指定されたURLへのHTTP通信を生成して呼び出す
        Dim WReq As HttpWebRequest = HttpWebRequest.Create(TargetURL)

        'サーバーからのレスポンスを受け取る
        Dim WRes As HttpWebResponse = WReq.GetResponse()

        'レスポンス・ボディの取得と表示
        'レスポンスのストリームを取得する
        Dim GRS As Stream = WRes.GetResponseStream()

        'レスポンスを読み取る器を用意して
        Dim STR As StreamReader = New StreamReader(GRS)

        '最後までレスポンスを読み込む
        Dim ResHTML As String = STR.ReadToEnd()

        'リソース解放
        GRS.Close()
        STR.Close()
        WRes.Close()
        '-------お約束部分ここまで------------------

        '取得した在席情報（ResHTML）をリスト形式「在席情報」に変換して格納
        Dim 在席情報 As List(Of 在席情報クラス） = Newtonsoft.Json.JsonConvert.DeserializeObject(Of List(Of 在席情報クラス))(ResHTML)

        '結果を返す
        Return 在席情報

    End Function

    Public Sub メンバー情報を更新する（メンバーID As String, 在席状態 As String)

        'ルームコード設定
        Dim ルームコード As String = My.Settings.irucaのルームコード

        '定義
        Dim ターゲットURL As String = "https://iruca.co/api/rooms/" & ルームコード & "/members/" & メンバーID
        Dim PUTする文字列 As String = "{""status"":""" & 在席状態 & """}"
        Dim bytes As Byte() = Encoding.UTF8.GetBytes(PUTする文字列)
        Dim request As HttpWebRequest = CType(WebRequest.Create(ターゲットURL), HttpWebRequest)

        '通信の種類を設定
        request.Method = "PUT"
        request.ContentType = "application/json"
        request.Accept = "application/json"

        '書き込み
        Dim stream As Stream = request.GetRequestStream
        stream.Write(bytes, 0, bytes.Length)
        stream.Close()

        '応答（ここまでして初めて書き込みが完了）
        Dim response As HttpWebResponse = CType(request.GetResponse, HttpWebResponse)
        Dim reader As StreamReader = New StreamReader(response.GetResponseStream)
        response.Close()
        reader.Close()

    End Sub
End Class

Public Class 在席情報クラス
    Public Property message As String
    Public Property created_at As Date
    Public Property updated_at As Date
    Public Property position As Integer
    Public Property id As String
    Public Property room_id As Integer
    Public Property name As String
    Public Property status As String
End Class