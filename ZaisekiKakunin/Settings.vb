
Namespace My

    'このクラスでは設定クラスでの特定のイベントを処理することができます:
    ' SettingChanging イベントは、設定値が変更される前に発生します。
    ' PropertyChanged イベントは、設定値が変更された後に発生します。
    ' SettingsLoaded イベントは、設定値が読み込まれた後に発生します。
    ' SettingsSaving イベントは、設定値が保存される前に発生します。
    Partial Friend NotInheritable Class MySettings

        <Global.System.Configuration.ApplicationScopedSettingAttribute()>
        Public Property btn() As Button
            Get
                Return CType(Me("btn"), Button)
            End Get
            Set(ByVal value As Button)
                Me("btn") = value
            End Set
        End Property

    End Class
End Namespace
