Public Class CreateMoviePanel

    Public Event MovieCreated As EventHandler

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
            .IsChanged = True
        End With

        'Save demo movie
        Database.This.LocalMovies.Add(movie)

        Me.DataSource = movie
        RaiseEvent MovieCreated(Me, e)

        'Close the panel
        PanelController.This.Close()

    End Sub

    Private Sub AbortButton_Click(sender As Object, e As EventArgs) Handles AbortButton.Click

        PanelController.This.Close()

    End Sub

End Class
