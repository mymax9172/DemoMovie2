Public Class CreateMoviePanel

    Public Event MovieCreated As EventHandler

    Protected Friend Overrides Sub OnShowed(e As EventArgs)
        MyBase.OnShowed(e)

        UpdateIcons()

    End Sub

    Private Sub TypeTrackBar_ValueChanged(sender As Object, e As EventArgs) Handles TypeTrackBar.ValueChanged

        UpdateIcons()

    End Sub

    Private Sub UpdateIcons()

        Dim n As Integer = TypeTrackBar.Value
        QuickPictureBox.Visible = CBool(n = 1)
        QuickLabel.Visible = CBool(n = 1)
        QuickLabel2.Visible = CBool(n = 1)
        SimplePictureBox.Visible = CBool(n = 2)
        SimpleLabel.Visible = CBool(n = 2)
        SimpleLabel2.Visible = CBool(n = 2)
        FullPictureBox.Visible = CBool(n = 3)
        FullLabel.Visible = CBool(n = 3)
        FullLabel2.Visible = CBool(n = 3)

    End Sub

    Private Sub CreateButton_Click(sender As Object, e As EventArgs) Handles CreateButton.Click

        'Check fields
        If TitleTextBox.Text = "" Then Exit Sub
        If CustomerTextBox.Text = "" Then Exit Sub

        'Update object
        Dim movie As New DemoMovie
        With movie
            .Title = TitleTextBox.Text
            .DemoDate = Now
            .CustomerName = CustomerTextBox.Text
            Select Case TypeTrackBar.Value
                Case 1 : .Type = DemoMovie.DEMOTYPE.Quick
                Case 2
                    .Type = DemoMovie.DEMOTYPE.Simple
                    .Scenes.Add(New Scene With {.Title = "DUMMY"})
                Case 3 : .Type = DemoMovie.DEMOTYPE.Full
            End Select
        End With

        'Save demo movie
        DemoMovie.Save(movie)
        OnMovieChanged(EventArgs.Empty)

        'Close the panel
        PanelController.This.Close()

    End Sub

    Private Sub AbortButton_Click(sender As Object, e As EventArgs) Handles AbortButton.Click

        PanelController.This.Close()

    End Sub

    Private Sub OnMovieChanged(e As EventArgs)

        RaiseEvent MovieCreated(Me, e)

    End Sub

End Class
