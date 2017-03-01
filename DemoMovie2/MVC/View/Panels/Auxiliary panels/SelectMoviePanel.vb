Public Class SelectMoviePanel

    Protected Friend Overrides Sub OnShowing(e As EventArgs)
        MyBase.OnShowing(e)

        RefreshList()

    End Sub

    'Load all items
    Public Sub RefreshList()

        'Remove all controls
        MoviesFlowLayoutPanel.Controls.Clear()

        'Load all demo movies
        Dim items As List(Of DemoMovie) = DemoMovie.GetAll()
        Dim odd As Boolean = True

        For Each item As DemoMovie In items

            If item.Filename <> GlobalSettings.This.CurrentMovie.Filename Then

                Dim uc As New MovieUserControl
                uc.CurrentItem = item
                uc.AllowDelete = False
                uc.AllowEdit = False

                uc.Visible = True
                uc.Size = New Size(120, 120)

                AddHandler uc.Click, AddressOf SelectedItem

                MoviesFlowLayoutPanel.Controls.Add(uc)

            End If

        Next

    End Sub

    Private Sub SelectedItem(sender As Object, e As EventArgs)

        DataSource = DirectCast(sender, MovieUserControl).CurrentItem
        DialogResult = DialogResult.OK
        PanelController.This.Close()

    End Sub

    Private Sub AbortButton_Click(sender As Object, e As EventArgs) Handles AbortButton.Click

        DialogResult = DialogResult.Cancel
        PanelController.This.Close()

    End Sub

    Private Sub SelectMoviePanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
