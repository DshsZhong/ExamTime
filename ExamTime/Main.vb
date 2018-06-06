Public Class Main
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        View.Show()
        My.Settings.Title = TxtTitle.Text
        My.Settings.Subjects = TxtSubjects.Text
        My.Settings.Notes = TxtNote.Text
        My.Settings.Countdown = ChkCountdown.Checked
        My.Settings.Shutdown = ChkShutdown.Checked
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtTitle.Text = My.Settings.Title
        TxtSubjects.Text = My.Settings.Subjects
        TxtNote.Text = My.Settings.Notes
        ChkCountdown.Checked = My.Settings.Countdown
        ChkShutdown.Checked = My.Settings.Shutdown
    End Sub
End Class