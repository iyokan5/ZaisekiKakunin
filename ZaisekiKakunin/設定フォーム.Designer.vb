<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 設定フォーム
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Labelルームコードタイトル = New System.Windows.Forms.Label()
        Me.Labelルームコード = New System.Windows.Forms.Label()
        Me.Button設定ファイルを読み込む = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button座席ボタン更新 = New System.Windows.Forms.Button()
        Me.Button標準サイズに戻す = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Buttonすべてリセットする = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label登録者数 = New System.Windows.Forms.Label()
        Me.ButtonINI上書保存 = New System.Windows.Forms.Button()
        Me.ButtonOK = New System.Windows.Forms.Button()
        Me.Buttonキャンセル = New System.Windows.Forms.Button()
        Me.NumericUpDown高さ = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown幅 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown文字サイズ = New System.Windows.Forms.NumericUpDown()
        Me.CheckBox自動起動 = New System.Windows.Forms.CheckBox()
        CType(Me.NumericUpDown高さ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown幅, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown文字サイズ, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Labelルームコードタイトル
        '
        Me.Labelルームコードタイトル.AutoSize = True
        Me.Labelルームコードタイトル.Location = New System.Drawing.Point(10, 186)
        Me.Labelルームコードタイトル.Name = "Labelルームコードタイトル"
        Me.Labelルームコードタイトル.Size = New System.Drawing.Size(93, 12)
        Me.Labelルームコードタイトル.TabIndex = 0
        Me.Labelルームコードタイトル.Text = "irucaルームコード："
        '
        'Labelルームコード
        '
        Me.Labelルームコード.AutoSize = True
        Me.Labelルームコード.Location = New System.Drawing.Point(109, 186)
        Me.Labelルームコード.Name = "Labelルームコード"
        Me.Labelルームコード.Size = New System.Drawing.Size(0, 12)
        Me.Labelルームコード.TabIndex = 1
        '
        'Button設定ファイルを読み込む
        '
        Me.Button設定ファイルを読み込む.Location = New System.Drawing.Point(14, 36)
        Me.Button設定ファイルを読み込む.Name = "Button設定ファイルを読み込む"
        Me.Button設定ファイルを読み込む.Size = New System.Drawing.Size(174, 86)
        Me.Button設定ファイルを読み込む.TabIndex = 2
        Me.Button設定ファイルを読み込む.Text = "設定ファイル(ini)を読み込む"
        Me.Button設定ファイルを読み込む.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(217, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 12)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "高さ"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(225, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(17, 12)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "幅"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(219, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 12)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "文字サイズ"
        '
        'Button座席ボタン更新
        '
        Me.Button座席ボタン更新.Location = New System.Drawing.Point(219, 112)
        Me.Button座席ボタン更新.Name = "Button座席ボタン更新"
        Me.Button座席ボタン更新.Size = New System.Drawing.Size(129, 34)
        Me.Button座席ボタン更新.TabIndex = 9
        Me.Button座席ボタン更新.Text = "座席ボタン更新"
        Me.Button座席ボタン更新.UseVisualStyleBackColor = True
        '
        'Button標準サイズに戻す
        '
        Me.Button標準サイズに戻す.Location = New System.Drawing.Point(219, 152)
        Me.Button標準サイズに戻す.Name = "Button標準サイズに戻す"
        Me.Button標準サイズに戻す.Size = New System.Drawing.Size(129, 21)
        Me.Button標準サイズに戻す.TabIndex = 10
        Me.Button標準サイズに戻す.Text = "標準サイズに戻す"
        Me.Button標準サイズに戻す.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(219, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 12)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "【座席ボタンのサイズ調整】"
        '
        'Buttonすべてリセットする
        '
        Me.Buttonすべてリセットする.Location = New System.Drawing.Point(14, 128)
        Me.Buttonすべてリセットする.Name = "Buttonすべてリセットする"
        Me.Buttonすべてリセットする.Size = New System.Drawing.Size(174, 46)
        Me.Buttonすべてリセットする.TabIndex = 12
        Me.Buttonすべてリセットする.Text = "すべてリセットする！" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "※配置もやり直しになります"
        Me.Buttonすべてリセットする.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(44, 198)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 12)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "登録者数："
        '
        'Label登録者数
        '
        Me.Label登録者数.AutoSize = True
        Me.Label登録者数.Location = New System.Drawing.Point(109, 198)
        Me.Label登録者数.Name = "Label登録者数"
        Me.Label登録者数.Size = New System.Drawing.Size(0, 12)
        Me.Label登録者数.TabIndex = 14
        '
        'ButtonINI上書保存
        '
        Me.ButtonINI上書保存.Location = New System.Drawing.Point(14, 224)
        Me.ButtonINI上書保存.Name = "ButtonINI上書保存"
        Me.ButtonINI上書保存.Size = New System.Drawing.Size(174, 27)
        Me.ButtonINI上書保存.TabIndex = 15
        Me.ButtonINI上書保存.Text = "ini上書保存（管理者用）"
        Me.ButtonINI上書保存.UseVisualStyleBackColor = True
        '
        'ButtonOK
        '
        Me.ButtonOK.Location = New System.Drawing.Point(271, 213)
        Me.ButtonOK.Name = "ButtonOK"
        Me.ButtonOK.Size = New System.Drawing.Size(77, 38)
        Me.ButtonOK.TabIndex = 16
        Me.ButtonOK.Text = "OK"
        Me.ButtonOK.UseVisualStyleBackColor = True
        '
        'Buttonキャンセル
        '
        Me.Buttonキャンセル.Location = New System.Drawing.Point(221, 213)
        Me.Buttonキャンセル.Name = "Buttonキャンセル"
        Me.Buttonキャンセル.Size = New System.Drawing.Size(44, 38)
        Me.Buttonキャンセル.TabIndex = 17
        Me.Buttonキャンセル.Text = "キャンセル"
        Me.Buttonキャンセル.UseVisualStyleBackColor = True
        '
        'NumericUpDown高さ
        '
        Me.NumericUpDown高さ.Location = New System.Drawing.Point(248, 34)
        Me.NumericUpDown高さ.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.NumericUpDown高さ.Name = "NumericUpDown高さ"
        Me.NumericUpDown高さ.Size = New System.Drawing.Size(100, 19)
        Me.NumericUpDown高さ.TabIndex = 18
        Me.NumericUpDown高さ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'NumericUpDown幅
        '
        Me.NumericUpDown幅.Location = New System.Drawing.Point(248, 59)
        Me.NumericUpDown幅.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.NumericUpDown幅.Name = "NumericUpDown幅"
        Me.NumericUpDown幅.Size = New System.Drawing.Size(100, 19)
        Me.NumericUpDown幅.TabIndex = 19
        Me.NumericUpDown幅.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'NumericUpDown文字サイズ
        '
        Me.NumericUpDown文字サイズ.Location = New System.Drawing.Point(279, 84)
        Me.NumericUpDown文字サイズ.Name = "NumericUpDown文字サイズ"
        Me.NumericUpDown文字サイズ.Size = New System.Drawing.Size(69, 19)
        Me.NumericUpDown文字サイズ.TabIndex = 20
        Me.NumericUpDown文字サイズ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CheckBox自動起動
        '
        Me.CheckBox自動起動.AutoSize = True
        Me.CheckBox自動起動.Location = New System.Drawing.Point(14, 11)
        Me.CheckBox自動起動.Name = "CheckBox自動起動"
        Me.CheckBox自動起動.Size = New System.Drawing.Size(180, 16)
        Me.CheckBox自動起動.TabIndex = 21
        Me.CheckBox自動起動.Text = "Windows立ち上げ時に自動起動"
        Me.CheckBox自動起動.UseVisualStyleBackColor = True
        '
        '設定フォーム
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(366, 263)
        Me.Controls.Add(Me.CheckBox自動起動)
        Me.Controls.Add(Me.NumericUpDown文字サイズ)
        Me.Controls.Add(Me.NumericUpDown幅)
        Me.Controls.Add(Me.NumericUpDown高さ)
        Me.Controls.Add(Me.Buttonキャンセル)
        Me.Controls.Add(Me.ButtonOK)
        Me.Controls.Add(Me.ButtonINI上書保存)
        Me.Controls.Add(Me.Label登録者数)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Buttonすべてリセットする)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button標準サイズに戻す)
        Me.Controls.Add(Me.Button座席ボタン更新)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button設定ファイルを読み込む)
        Me.Controls.Add(Me.Labelルームコード)
        Me.Controls.Add(Me.Labelルームコードタイトル)
        Me.Name = "設定フォーム"
        Me.Text = "設定"
        CType(Me.NumericUpDown高さ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown幅, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown文字サイズ, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Labelルームコードタイトル As Label
    Friend WithEvents Labelルームコード As Label
    Friend WithEvents Button設定ファイルを読み込む As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button座席ボタン更新 As Button
    Friend WithEvents Button標準サイズに戻す As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Buttonすべてリセットする As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label登録者数 As Label
    Friend WithEvents ButtonINI上書保存 As Button
    Friend WithEvents ButtonOK As Button
    Friend WithEvents Buttonキャンセル As Button
    Friend WithEvents NumericUpDown高さ As NumericUpDown
    Friend WithEvents NumericUpDown幅 As NumericUpDown
    Friend WithEvents NumericUpDown文字サイズ As NumericUpDown
    Friend WithEvents CheckBox自動起動 As CheckBox
End Class
