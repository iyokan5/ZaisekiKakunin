<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_設定
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
        Me.PropertyGrid1 = New System.Windows.Forms.PropertyGrid()
        Me.ButtonOK = New System.Windows.Forms.Button()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.FixedBtn_設定出力 = New System.Windows.Forms.Button()
        Me.FixedBtn_SeatGenerate = New System.Windows.Forms.Button()
        Me.FixedBtn_SeatLoad = New System.Windows.Forms.Button()
        Me.FixedBtn_SeatClear = New System.Windows.Forms.Button()
        Me.FixedBtn_フォルダ表示 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'PropertyGrid1
        '
        Me.PropertyGrid1.Location = New System.Drawing.Point(12, 54)
        Me.PropertyGrid1.Name = "PropertyGrid1"
        Me.PropertyGrid1.Size = New System.Drawing.Size(565, 350)
        Me.PropertyGrid1.TabIndex = 0
        '
        'ButtonOK
        '
        Me.ButtonOK.Location = New System.Drawing.Point(421, 410)
        Me.ButtonOK.Name = "ButtonOK"
        Me.ButtonOK.Size = New System.Drawing.Size(75, 23)
        Me.ButtonOK.TabIndex = 1
        Me.ButtonOK.Text = "OK"
        Me.ButtonOK.UseVisualStyleBackColor = True
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Location = New System.Drawing.Point(502, 410)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCancel.TabIndex = 2
        Me.ButtonCancel.Text = "キャンセル"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'FixedBtn_設定出力
        '
        Me.FixedBtn_設定出力.Location = New System.Drawing.Point(328, 12)
        Me.FixedBtn_設定出力.Name = "FixedBtn_設定出力"
        Me.FixedBtn_設定出力.Size = New System.Drawing.Size(62, 23)
        Me.FixedBtn_設定出力.TabIndex = 24
        Me.FixedBtn_設定出力.Text = "設定出力"
        Me.FixedBtn_設定出力.UseVisualStyleBackColor = True
        '
        'FixedBtn_SeatGenerate
        '
        Me.FixedBtn_SeatGenerate.Location = New System.Drawing.Point(12, 12)
        Me.FixedBtn_SeatGenerate.Name = "FixedBtn_SeatGenerate"
        Me.FixedBtn_SeatGenerate.Size = New System.Drawing.Size(63, 23)
        Me.FixedBtn_SeatGenerate.TabIndex = 23
        Me.FixedBtn_SeatGenerate.Text = "座席生成"
        Me.FixedBtn_SeatGenerate.UseVisualStyleBackColor = True
        '
        'FixedBtn_SeatLoad
        '
        Me.FixedBtn_SeatLoad.Location = New System.Drawing.Point(150, 12)
        Me.FixedBtn_SeatLoad.Name = "FixedBtn_SeatLoad"
        Me.FixedBtn_SeatLoad.Size = New System.Drawing.Size(62, 23)
        Me.FixedBtn_SeatLoad.TabIndex = 26
        Me.FixedBtn_SeatLoad.Text = "座席復元"
        Me.FixedBtn_SeatLoad.UseVisualStyleBackColor = True
        '
        'FixedBtn_SeatClear
        '
        Me.FixedBtn_SeatClear.Location = New System.Drawing.Point(81, 12)
        Me.FixedBtn_SeatClear.Name = "FixedBtn_SeatClear"
        Me.FixedBtn_SeatClear.Size = New System.Drawing.Size(63, 23)
        Me.FixedBtn_SeatClear.TabIndex = 27
        Me.FixedBtn_SeatClear.Text = "座席クリア"
        Me.FixedBtn_SeatClear.UseVisualStyleBackColor = True
        '
        'FixedBtn_フォルダ表示
        '
        Me.FixedBtn_フォルダ表示.Location = New System.Drawing.Point(405, 12)
        Me.FixedBtn_フォルダ表示.Name = "FixedBtn_フォルダ表示"
        Me.FixedBtn_フォルダ表示.Size = New System.Drawing.Size(91, 23)
        Me.FixedBtn_フォルダ表示.TabIndex = 28
        Me.FixedBtn_フォルダ表示.Text = "フォルダ表示"
        Me.FixedBtn_フォルダ表示.UseVisualStyleBackColor = True
        '
        'Form_設定
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(590, 444)
        Me.Controls.Add(Me.FixedBtn_フォルダ表示)
        Me.Controls.Add(Me.FixedBtn_SeatClear)
        Me.Controls.Add(Me.FixedBtn_SeatLoad)
        Me.Controls.Add(Me.FixedBtn_設定出力)
        Me.Controls.Add(Me.FixedBtn_SeatGenerate)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.ButtonOK)
        Me.Controls.Add(Me.PropertyGrid1)
        Me.Name = "Form_設定"
        Me.Text = "FormSetting"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PropertyGrid1 As PropertyGrid
    Friend WithEvents ButtonOK As Button
    Friend WithEvents ButtonCancel As Button
    Friend WithEvents FixedBtn_設定出力 As Button
    Friend WithEvents FixedBtn_SeatGenerate As Button
    Friend WithEvents FixedBtn_SeatLoad As Button
    Friend WithEvents FixedBtn_SeatClear As Button
    Friend WithEvents FixedBtn_フォルダ表示 As Button
End Class
