Public Class View
    Friend NextTime As DateTime
    Friend Now As DateTime = DateTime.Now
    Friend Finished As Boolean = False
    Friend Pass As Boolean = False

    Private Sub View_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim StartTime(Main.TxtSubjects.Lines.Length) As DateTime
        Dim EndTime(Main.TxtSubjects.Lines.Length) As DateTime
        Dim Subject(Main.TxtSubjects.Lines.Length) As String

        If Main.ChkCountdown.Checked Then LabTimeLeft.Visible = True
        While LabSubjects.Width > 460
            LabSubjects.Font = New Font(LabSubjects.Font.FontFamily, LabSubjects.Font.Size - 0.5F, LabSubjects.Font.Style)
        End While
        LabPointer.Font = LabSubjects.Font

        LabSubjects.Text = Nothing
        LabTitle.Text = Main.TxtTitle.Text
        If Main.TxtNote.Text = Nothing Then
            LabNote.Text = Nothing
        Else
            LabNote.Text = "注意事項:" & vbLf & Main.TxtNote.Text
        End If

        If My.Settings.ShowAgain Then
            If MsgBox("如果要關閉，" & vbCr & "請雙擊畫面左上角" & vbCr & "或按下鍵盤 Alt+F4" & vbCr & vbCr & "下次是否要再顯示?", MsgBoxStyle.YesNo, "注意") = MsgBoxResult.No Then
                My.Settings.ShowAgain = False
            End If
        End If

        Me.Cursor.Hide()

        For i As Integer = 0 To Main.TxtSubjects.Lines.Length - 1
            Dim Texts() As String = Split(Main.TxtSubjects.Lines(i), "-",, 1)
            If Texts.Length >= 3 Then
                Subject(i) = Texts(0)
                StartTime(i) = DateTime.ParseExact(Texts(1), "H:mm", Nothing)
                EndTime(i) = DateTime.ParseExact(Texts(2), "H:mm", Nothing)
                Dim Other As String = Nothing
                If Texts.Length = 4 Then Other = " (" & Texts(3) & ")"
                LabSubjects.Text += Subject(i) & "  " & StartTime(i).ToString("H:mm") & "~" & EndTime(i).ToString("H:mm") & Other & vbLf
            Else
                Close()
                MsgBox("輸入格式錯誤!!!", MsgBoxStyle.Exclamation, "錯誤!")
                Exit Sub
            End If
        Next
        For i As Integer = 0 To Subject.Length - 1
            LabNowSub.Text = "下課"
            LabNowSub.ForeColor = Color.Lime
            NextTime = StartTime(i)
            LabPointer.Text = Nothing
            For x As Integer = 1 To i
                LabPointer.Text += vbLf
            Next
            LabPointer.Text += "▶"
            Pass = False
            While Pass = False
                Application.DoEvents()
            End While
            LabNowSub.Text = Subject(i)
            LabNowSub.ForeColor = Color.HotPink
            NextTime = EndTime(i)
            Pass = False
            While Pass = False
                Application.DoEvents()
            End While
        Next
        Finished = True
        LabNowSub.Text = "放學了!"
        LabNowSub.ForeColor = Color.Lime
        LabPointer.Text = Nothing
        If Main.ChkShutdown.Checked Then Shell("shutdown /s /t 120")
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        Now = DateTime.Now
        LabNow.Text = Now.ToString("H:mm")
        If Not Finished Then
            Dim TimeLeft As TimeSpan = NextTime.TimeOfDay - Now.TimeOfDay
            If TimeLeft.TotalSeconds <= 0 Then
                Pass = True
            Else
                LabTimeLeft.Text = Math.Ceiling(TimeLeft.TotalMinutes) & "分鐘"
                If Math.Floor(TimeLeft.TotalMinutes) < 5 Then
                    LabTimeLeft.ForeColor = Color.Coral
                    If Math.Floor(TimeLeft.TotalSeconds) <= 10 Then
                        LabTimeLeft.Text = "10秒"
                    ElseIf Math.Floor(TimeLeft.TotalSeconds) <= 30 Then
                        LabTimeLeft.Text = "30秒"
                    End If
                Else
                    LabTimeLeft.ForeColor = Color.DeepSkyBlue
                End If
            End If
        Else
            LabTimeLeft.Text = Nothing
        End If
    End Sub

    Private Sub View_Close(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        Timer.Stop()
        Me.Cursor.Show()
        Close()
    End Sub

    Private Sub ExitApp(sender As Object, e As EventArgs) Handles LabShutdown.MouseDoubleClick
        Timer.Stop()
        Me.Cursor.Show()
        Close()
    End Sub
End Class