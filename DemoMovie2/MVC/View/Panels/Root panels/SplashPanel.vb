Public Class SplashPanel

    Protected Friend Overrides Sub OnShowing(e As EventArgs)
        MyBase.OnShowing(e)

        'Retriev version
        VersionLabel.Text = "Version " & Application.ProductVersion

        ChangeLogTextBox.Text = My.Resources.ChangeLog

    End Sub
    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click

        'Hide this panel
        PanelController.This.Close()

        'Show the main panel
        Dim pnl As New MainPanel
        PanelController.This.Show(pnl)

    End Sub

    Private Sub SeeLicenseButton_Click(sender As Object, e As EventArgs) Handles SeeLicenseButton.Click

        'Open Notepad with GNU license
        Process.Start("notepad.exe", Application.StartupPath & "\GNU.txt")

    End Sub

End Class
