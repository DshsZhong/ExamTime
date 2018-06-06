<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class View
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.LabSubjects = New System.Windows.Forms.Label()
        Me.LabTitle = New System.Windows.Forms.Label()
        Me.LabPointer = New System.Windows.Forms.Label()
        Me.LabNowSub = New System.Windows.Forms.Label()
        Me.LabNow = New System.Windows.Forms.Label()
        Me.LabTimeLeft = New System.Windows.Forms.Label()
        Me.LabNote = New System.Windows.Forms.Label()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.LabShutdown = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LabSubjects
        '
        Me.LabSubjects.AutoSize = True
        Me.LabSubjects.Font = New System.Drawing.Font("微軟正黑體", 45.0!, System.Drawing.FontStyle.Bold)
        Me.LabSubjects.ForeColor = System.Drawing.Color.GreenYellow
        Me.LabSubjects.Location = New System.Drawing.Point(82, 146)
        Me.LabSubjects.Name = "LabSubjects"
        Me.LabSubjects.Size = New System.Drawing.Size(795, 560)
        Me.LabSubjects.TabIndex = 0
        Me.LabSubjects.Text = "地理 7:50~8:40" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "物理 9:00~10:10" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "國文 10:30~11:50" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "地科 13:00~13:50" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "英文 14:10~15:30"
        '
        'LabTitle
        '
        Me.LabTitle.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabTitle.Font = New System.Drawing.Font("微軟正黑體", 50.0!, System.Drawing.FontStyle.Bold)
        Me.LabTitle.ForeColor = System.Drawing.Color.Salmon
        Me.LabTitle.Location = New System.Drawing.Point(0, 20)
        Me.LabTitle.Name = "LabTitle"
        Me.LabTitle.Size = New System.Drawing.Size(1920, 126)
        Me.LabTitle.TabIndex = 0
        Me.LabTitle.Text = "第二次月考 Day1 11/28"
        Me.LabTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabPointer
        '
        Me.LabPointer.AutoSize = True
        Me.LabPointer.Font = New System.Drawing.Font("微軟正黑體", 45.0!)
        Me.LabPointer.ForeColor = System.Drawing.Color.Coral
        Me.LabPointer.Location = New System.Drawing.Point(-7, 146)
        Me.LabPointer.Name = "LabPointer"
        Me.LabPointer.Size = New System.Drawing.Size(137, 336)
        Me.LabPointer.TabIndex = 0
        Me.LabPointer.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "▶"
        '
        'LabNowSub
        '
        Me.LabNowSub.Font = New System.Drawing.Font("微軟正黑體", 130.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabNowSub.ForeColor = System.Drawing.Color.Violet
        Me.LabNowSub.Location = New System.Drawing.Point(936, 471)
        Me.LabNowSub.Name = "LabNowSub"
        Me.LabNowSub.Size = New System.Drawing.Size(927, 346)
        Me.LabNowSub.TabIndex = 0
        Me.LabNowSub.Text = "國文"
        Me.LabNowSub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabNow
        '
        Me.LabNow.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabNow.BackColor = System.Drawing.Color.Transparent
        Me.LabNow.Font = New System.Drawing.Font("微軟正黑體", 180.0!, System.Drawing.FontStyle.Bold)
        Me.LabNow.ForeColor = System.Drawing.Color.Orange
        Me.LabNow.Location = New System.Drawing.Point(779, 107)
        Me.LabNow.Name = "LabNow"
        Me.LabNow.Size = New System.Drawing.Size(1245, 402)
        Me.LabNow.TabIndex = 0
        Me.LabNow.Text = "12:30"
        Me.LabNow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabTimeLeft
        '
        Me.LabTimeLeft.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabTimeLeft.BackColor = System.Drawing.Color.Transparent
        Me.LabTimeLeft.Font = New System.Drawing.Font("微軟正黑體", 120.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabTimeLeft.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.LabTimeLeft.Location = New System.Drawing.Point(937, 725)
        Me.LabTimeLeft.Name = "LabTimeLeft"
        Me.LabTimeLeft.Size = New System.Drawing.Size(926, 351)
        Me.LabTimeLeft.TabIndex = 0
        Me.LabTimeLeft.Text = "70分鐘"
        Me.LabTimeLeft.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.LabTimeLeft.Visible = False
        '
        'LabNote
        '
        Me.LabNote.Font = New System.Drawing.Font("微軟正黑體", 32.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabNote.ForeColor = System.Drawing.Color.Pink
        Me.LabNote.Location = New System.Drawing.Point(82, 548)
        Me.LabNote.Name = "LabNote"
        Me.LabNote.Size = New System.Drawing.Size(849, 523)
        Me.LabNote.TabIndex = 0
        Me.LabNote.Text = "注意事項:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "123" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "123" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "123"
        Me.LabNote.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Timer
        '
        Me.Timer.Enabled = True
        Me.Timer.Interval = 50
        '
        'LabShutdown
        '
        Me.LabShutdown.Location = New System.Drawing.Point(0, 0)
        Me.LabShutdown.Name = "LabShutdown"
        Me.LabShutdown.Size = New System.Drawing.Size(1, 1)
        Me.LabShutdown.TabIndex = 1
        Me.LabShutdown.Text = "Label1"
        '
        'View
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1920, 1080)
        Me.ControlBox = False
        Me.Controls.Add(Me.LabShutdown)
        Me.Controls.Add(Me.LabSubjects)
        Me.Controls.Add(Me.LabPointer)
        Me.Controls.Add(Me.LabTitle)
        Me.Controls.Add(Me.LabNow)
        Me.Controls.Add(Me.LabNowSub)
        Me.Controls.Add(Me.LabNote)
        Me.Controls.Add(Me.LabTimeLeft)
        Me.Cursor = System.Windows.Forms.Cursors.Cross
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimizeBox = False
        Me.Name = "View"
        Me.ShowInTaskbar = False
        Me.Text = "View"
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabSubjects As Label
    Friend WithEvents LabTitle As Label
    Friend WithEvents LabPointer As Label
    Friend WithEvents LabNowSub As Label
    Friend WithEvents LabNow As Label
    Friend WithEvents LabTimeLeft As Label
    Friend WithEvents LabNote As Label
    Friend WithEvents Timer As Timer
    Friend WithEvents LabShutdown As Label
End Class
