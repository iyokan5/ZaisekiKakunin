<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.FixedBtn_更新 = New System.Windows.Forms.Button()
        Me.FixedBtn_Setting = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ContextMenuStrip右クリック = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem取込中 = New System.Windows.Forms.ToolStripMenuItem()
        Me.外出ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.休暇ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.帰宅ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.自動切替ONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.自動切替OFFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label自動離席判定 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label更新対象 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NumericUpDown離席になるまでの時間 = New System.Windows.Forms.NumericUpDown()
        Me.CheckBox自動更新 = New System.Windows.Forms.CheckBox()
        Me.NumericUpDown自動更新間隔 = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStripシステムトレイ = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.座席表示ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.終了ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label無操作時間 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip右クリック.SuspendLayout()
        CType(Me.NumericUpDown離席になるまでの時間, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown自動更新間隔, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStripシステムトレイ.SuspendLayout()
        Me.SuspendLayout()
        '
        'FixedBtn_更新
        '
        Me.FixedBtn_更新.Location = New System.Drawing.Point(477, 6)
        Me.FixedBtn_更新.Name = "FixedBtn_更新"
        Me.FixedBtn_更新.Size = New System.Drawing.Size(69, 36)
        Me.FixedBtn_更新.TabIndex = 10
        Me.FixedBtn_更新.Text = "在席状況更新"
        Me.FixedBtn_更新.UseVisualStyleBackColor = True
        '
        'FixedBtn_Setting
        '
        Me.FixedBtn_Setting.Location = New System.Drawing.Point(12, 7)
        Me.FixedBtn_Setting.Name = "FixedBtn_Setting"
        Me.FixedBtn_Setting.Size = New System.Drawing.Size(63, 37)
        Me.FixedBtn_Setting.TabIndex = 11
        Me.FixedBtn_Setting.Text = "設定"
        Me.FixedBtn_Setting.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 10000
        '
        'ContextMenuStrip右クリック
        '
        Me.ContextMenuStrip右クリック.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem取込中, Me.外出ToolStripMenuItem, Me.休暇ToolStripMenuItem, Me.帰宅ToolStripMenuItem, Me.自動切替ONToolStripMenuItem, Me.自動切替OFFToolStripMenuItem})
        Me.ContextMenuStrip右クリック.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip右クリック.Size = New System.Drawing.Size(144, 136)
        '
        'ToolStripMenuItem取込中
        '
        Me.ToolStripMenuItem取込中.Name = "ToolStripMenuItem取込中"
        Me.ToolStripMenuItem取込中.Size = New System.Drawing.Size(143, 22)
        Me.ToolStripMenuItem取込中.Text = "取込中"
        '
        '外出ToolStripMenuItem
        '
        Me.外出ToolStripMenuItem.Name = "外出ToolStripMenuItem"
        Me.外出ToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.外出ToolStripMenuItem.Text = "外出"
        '
        '休暇ToolStripMenuItem
        '
        Me.休暇ToolStripMenuItem.Name = "休暇ToolStripMenuItem"
        Me.休暇ToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.休暇ToolStripMenuItem.Text = "休暇"
        '
        '帰宅ToolStripMenuItem
        '
        Me.帰宅ToolStripMenuItem.Name = "帰宅ToolStripMenuItem"
        Me.帰宅ToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.帰宅ToolStripMenuItem.Text = "帰宅"
        '
        '自動切替ONToolStripMenuItem
        '
        Me.自動切替ONToolStripMenuItem.Name = "自動切替ONToolStripMenuItem"
        Me.自動切替ONToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.自動切替ONToolStripMenuItem.Text = "自動切替ON"
        '
        '自動切替OFFToolStripMenuItem
        '
        Me.自動切替OFFToolStripMenuItem.Name = "自動切替OFFToolStripMenuItem"
        Me.自動切替OFFToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.自動切替OFFToolStripMenuItem.Text = "自動切替OFF"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(103, 24)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(100, 16)
        Me.CheckBox1.TabIndex = 16
        Me.CheckBox1.Text = "座席移動モード"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(209, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 12)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "【自動離席判定】"
        '
        'Label自動離席判定
        '
        Me.Label自動離席判定.AutoSize = True
        Me.Label自動離席判定.Location = New System.Drawing.Point(301, 8)
        Me.Label自動離席判定.Name = "Label自動離席判定"
        Me.Label自動離席判定.Size = New System.Drawing.Size(27, 12)
        Me.Label自動離席判定.TabIndex = 18
        Me.Label自動離席判定.Text = "OFF"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(209, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 12)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "＜更新対象＞"
        '
        'Label更新対象
        '
        Me.Label更新対象.AutoSize = True
        Me.Label更新対象.Location = New System.Drawing.Point(283, 25)
        Me.Label更新対象.Name = "Label更新対象"
        Me.Label更新対象.Size = New System.Drawing.Size(24, 12)
        Me.Label更新対象.TabIndex = 20
        Me.Label更新対象.Text = "なし"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(334, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 12)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "離席時間（分）"
        '
        'NumericUpDown離席になるまでの時間
        '
        Me.NumericUpDown離席になるまでの時間.Location = New System.Drawing.Point(408, 4)
        Me.NumericUpDown離席になるまでの時間.Name = "NumericUpDown離席になるまでの時間"
        Me.NumericUpDown離席になるまでの時間.ReadOnly = True
        Me.NumericUpDown離席になるまでの時間.Size = New System.Drawing.Size(38, 19)
        Me.NumericUpDown離席になるまでの時間.TabIndex = 23
        Me.NumericUpDown離席になるまでの時間.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CheckBox自動更新
        '
        Me.CheckBox自動更新.AutoSize = True
        Me.CheckBox自動更新.Location = New System.Drawing.Point(565, 6)
        Me.CheckBox自動更新.Name = "CheckBox自動更新"
        Me.CheckBox自動更新.Size = New System.Drawing.Size(72, 16)
        Me.CheckBox自動更新.TabIndex = 25
        Me.CheckBox自動更新.Text = "自動更新"
        Me.CheckBox自動更新.UseVisualStyleBackColor = True
        '
        'NumericUpDown自動更新間隔
        '
        Me.NumericUpDown自動更新間隔.Location = New System.Drawing.Point(584, 23)
        Me.NumericUpDown自動更新間隔.Name = "NumericUpDown自動更新間隔"
        Me.NumericUpDown自動更新間隔.ReadOnly = True
        Me.NumericUpDown自動更新間隔.Size = New System.Drawing.Size(45, 19)
        Me.NumericUpDown自動更新間隔.TabIndex = 26
        Me.NumericUpDown自動更新間隔.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(631, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 12)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "分毎）"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(561, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(23, 12)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "（※"
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStripシステムトレイ
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "在席確認 kawa-iruca"
        Me.NotifyIcon1.Visible = True
        '
        'ContextMenuStripシステムトレイ
        '
        Me.ContextMenuStripシステムトレイ.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.座席表示ToolStripMenuItem, Me.終了ToolStripMenuItem})
        Me.ContextMenuStripシステムトレイ.Name = "ContextMenuStripシステムトレイ"
        Me.ContextMenuStripシステムトレイ.Size = New System.Drawing.Size(123, 48)
        '
        '座席表示ToolStripMenuItem
        '
        Me.座席表示ToolStripMenuItem.Name = "座席表示ToolStripMenuItem"
        Me.座席表示ToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.座席表示ToolStripMenuItem.Text = "座席表示"
        '
        '終了ToolStripMenuItem
        '
        Me.終了ToolStripMenuItem.Name = "終了ToolStripMenuItem"
        Me.終了ToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.終了ToolStripMenuItem.Text = "終了"
        '
        'Label無操作時間
        '
        Me.Label無操作時間.AutoSize = True
        Me.Label無操作時間.Location = New System.Drawing.Point(103, 7)
        Me.Label無操作時間.Name = "Label無操作時間"
        Me.Label無操作時間.Size = New System.Drawing.Size(92, 12)
        Me.Label無操作時間.TabIndex = 29
        Me.Label無操作時間.Text = "Label無操作時間"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(696, 785)
        Me.Controls.Add(Me.Label無操作時間)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.NumericUpDown自動更新間隔)
        Me.Controls.Add(Me.CheckBox自動更新)
        Me.Controls.Add(Me.NumericUpDown離席になるまでの時間)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label更新対象)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label自動離席判定)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.FixedBtn_Setting)
        Me.Controls.Add(Me.FixedBtn_更新)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "在席確認"
        Me.ContextMenuStrip右クリック.ResumeLayout(False)
        CType(Me.NumericUpDown離席になるまでの時間, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown自動更新間隔, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStripシステムトレイ.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FixedBtn_更新 As Button
    Friend WithEvents FixedBtn_Setting As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ContextMenuStrip右クリック As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem取込中 As ToolStripMenuItem
    Friend WithEvents 外出ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 休暇ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 帰宅ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 自動切替ONToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 自動切替OFFToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Label1 As Label
    Friend WithEvents Label自動離席判定 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label更新対象 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents NumericUpDown離席になるまでの時間 As NumericUpDown
    Friend WithEvents CheckBox自動更新 As CheckBox
    Friend WithEvents NumericUpDown自動更新間隔 As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents ContextMenuStripシステムトレイ As ContextMenuStrip
    Friend WithEvents 座席表示ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 終了ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label無操作時間 As Label
End Class
