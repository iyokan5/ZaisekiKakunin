Public Class Class_Starter

    'クラスForm1から、実体としてのf1を定義
    Public Shared f1 As New Form1

    '自動起動にmain()を設定・・・他のクラスからコントロールも参照できるf1を立ち上げる
    Shared Sub main()

        'Form1を立ち上げ
        Application.Run(f1)

    End Sub

End Class
