Public Class SplashPanel

    Protected Friend Overrides Sub OnShowing(e As EventArgs)
        MyBase.OnShowing(e)

        'Retrieve version
        VersionLabel.Text = "Version " & Application.ProductVersion

        'Show logs
        ChangeLogTextBox.Text = My.Resources.ChangeLog

        'Update user
        AuthorLabel.Text = "Logged user: " & GlobalSettings.This.Author

    End Sub
    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click

        'Hide this panel
        PanelController.This.Close()

        'Show the main panel
        Dim pnl As New MainPanel
        PanelController.This.Show(pnl)

    End Sub

    Private Sub AuthorLabel_DblClick(sender As Object, e As EventArgs) Handles AuthorLabel.DoubleClick
        Dim sz As String = InputBox("Author name", "Login", GlobalSettings.This.Author)
        If sz <> "" Then
            GlobalSettings.This.ChangeAuthor(sz)
            AuthorLabel.Text = "Logged user: " & sz
            GlobalSettings.This.MainForm.AuthorLabel.Text = sz
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        'Open Notepad with GNU license
        Process.Start("notepad.exe", Application.StartupPath & "\GNU.txt")
    End Sub
End Class
