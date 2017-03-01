Public Class EditTakePanel

    Public Sub Run(item As Take)

        If item Is Nothing Then
            DataSource = New Take
        Else
            DataSource = item
        End If

        'Load data
        ActorsListUserControl.AllowDelete = True
        ActorsListUserControl.Actors = GetDataSource(Of Take).Actors

        'Check if just one actor is defined, auto-added to the list
        If GlobalSettings.This.CurrentMovie.Actors.Count = 1 Then
            GetDataSource(Of Take).Actors.Add(GlobalSettings.This.CurrentMovie.Actors(0))
        End If

        'Check if actors can be added
        ActorsListUserControl.AllowAdd = CBool(GetDataSource(Of Take).Actors.Count < GlobalSettings.This.CurrentMovie.Actors.Count)

        TitleTextBox.Text = GetDataSource(Of Take).Title

        AddHandler ActorsListUserControl.Create, AddressOf CreateNewActor_Begin
        AddHandler ActorsListUserControl.Delete, AddressOf RemoveActor
        ActorsListUserControl.Refresh()

        'Show the window
        PanelController.This.Show(Me)

    End Sub

    Private Sub CreateNewActor_Begin(sender As Object, e As EventArgs)

        Dim pnl As New SelectActorPanel
        pnl.Run(GetDataSource(Of Take))
        AddHandler pnl.Closed, AddressOf CreateNewActor_End

    End Sub

    Private Sub CreateNewActor_End(sender As Object, e As EventArgs)

        Dim pnl As SelectActorPanel = DirectCast(sender, SelectActorPanel)
        RemoveHandler pnl.Closed, AddressOf CreateNewActor_End

        If pnl.DialogResult = DialogResult.OK Then
            GetDataSource(Of Take).Actors.Add(DirectCast(pnl.DataSource, Actor))

            'Check if actors can be added
            ActorsListUserControl.AllowAdd = CBool(GetDataSource(Of Take).Actors.Count < GlobalSettings.This.CurrentMovie.Actors.Count)
            ActorsListUserControl.Refresh()
        End If


    End Sub

    Private Sub RemoveActor(sender As Object, e As EventArgs)

        'Remove the actor
        Dim ctr As ActorUserControl = DirectCast(sender, ActorUserControl)
        GetDataSource(Of Take).Actors.Remove(ctr.Actor)

        'Check if actors can be added
        ActorsListUserControl.AllowAdd = CBool(GetDataSource(Of Take).Actors.Count < GlobalSettings.This.CurrentMovie.Actors.Count)
        ActorsListUserControl.Refresh()

    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click

        'Control fields
        If TitleTextBox.Text = "" Then Exit Sub

        'Return
        GetDataSource(Of Take).Title = TitleTextBox.Text
        DialogResult = DialogResult.OK
        PanelController.This.Close()

    End Sub

    Private Sub AbortButton_Click(sender As Object, e As EventArgs) Handles AbortButton.Click
        DialogResult = DialogResult.Cancel
        PanelController.This.Close()
    End Sub

End Class
