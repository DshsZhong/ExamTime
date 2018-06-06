<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.TxtTitle = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TxtSubjects = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtNote = New System.Windows.Forms.RichTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ChkShutdown = New System.Windows.Forms.CheckBox()
        Me.ChkCountdown = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'TxtTitle
        '
        Me.TxtTitle.Font = New System.Drawing.Font("微軟正黑體", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TxtTitle.Location = New System.Drawing.Point(8, 8)
        Me.TxtTitle.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtTitle.Name = "TxtTitle"
        Me.TxtTitle.Size = New System.Drawing.Size(412, 50)
        Me.TxtTitle.TabIndex = 0
        Me.TxtTitle.Text = "月考"
        Me.TxtTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("微軟正黑體", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button1.Location = New System.Drawing.Point(11, 567)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(403, 67)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "開始"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TxtSubjects
        '
        Me.TxtSubjects.DetectUrls = False
        Me.TxtSubjects.Font = New System.Drawing.Font("微軟正黑體", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TxtSubjects.Location = New System.Drawing.Point(14, 157)
        Me.TxtSubjects.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtSubjects.Name = "TxtSubjects"
        Me.TxtSubjects.Size = New System.Drawing.Size(406, 180)
        Me.TxtSubjects.TabIndex = 4
        Me.TxtSubjects.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 60)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(412, 93)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "輸入科目、時間:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "[科目]-[開始時間]-[結束時間](-[備註])" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "範例:  國文-7:30-8:30-原"
        '
        'TxtNote
        '
        Me.TxtNote.DetectUrls = False
        Me.TxtNote.Location = New System.Drawing.Point(14, 387)
        Me.TxtNote.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtNote.Name = "TxtNote"
        Me.TxtNote.Size = New System.Drawing.Size(400, 135)
        Me.TxtNote.TabIndex = 4
        Me.TxtNote.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 354)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 31)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "注意事項:"
        '
        'ChkShutdown
        '
        Me.ChkShutdown.AutoSize = True
        Me.ChkShutdown.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ChkShutdown.Location = New System.Drawing.Point(235, 527)
        Me.ChkShutdown.Name = "ChkShutdown"
        Me.ChkShutdown.Size = New System.Drawing.Size(160, 35)
        Me.ChkShutdown.TabIndex = 6
        Me.ChkShutdown.Text = "結束後關機"
        Me.ChkShutdown.UseVisualStyleBackColor = True
        '
        'ChkCountdown
        '
        Me.ChkCountdown.AutoSize = True
        Me.ChkCountdown.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ChkCountdown.Location = New System.Drawing.Point(14, 527)
        Me.ChkCountdown.Name = "ChkCountdown"
        Me.ChkCountdown.Size = New System.Drawing.Size(136, 35)
        Me.ChkCountdown.TabIndex = 6
        Me.ChkCountdown.Text = "顯示倒數"
        Me.ChkCountdown.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(428, 645)
        Me.Controls.Add(Me.ChkCountdown)
        Me.Controls.Add(Me.ChkShutdown)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtNote)
        Me.Controls.Add(Me.TxtSubjects)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TxtTitle)
        Me.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(450, 700)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(450, 700)
        Me.Name = "Main"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "月考日程"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtTitle As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TxtSubjects As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtNote As RichTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ChkShutdown As CheckBox
    Friend WithEvents ChkCountdown As CheckBox
End Class
