Public Class ActorsTabPanel

    Protected Friend Overrides Sub OnShowing(e As EventArgs)
        MyBase.OnShowing(e)

        ActorsListUserControl.AllowDelete = True
        ActorsListUserControl.AllowAdd = True
        ActorsListUserControl.Actors = GlobalSettings.This.CurrentMovie.Actors
        ActorsListUserControl.Refresh()

        AddHandler ActorsListUserControl.Selected, AddressOf EditActor_Begin
        AddHandler ActorsListUserControl.Create, AddressOf CreateNewActor_Begin
        AddHandler ActorsListUserControl.Delete, AddressOf DeleteActor_Begin

    End Sub

    Private Sub CreateNewActor_Begin(sender As Object, e As EventArgs)

        Dim pnl As New EditActorPanel
        pnl.Run(Nothing)
        AddHandler pnl.Closed, AddressOf CreateNewActor_End

    End Sub

    Private Sub CreateNewActor_End(sender As Object, e As EventArgs)

        Dim pnl As SlidingPanel = DirectCast(sender, SlidingPanel)
        RemoveHandler pnl.Closed, AddressOf CreateNewActor_End

        If pnl.DialogResult = DialogResult.OK Then
            'Add a new actor to the list
            GlobalSettings.This.CurrentMovie.Actors.Add(pnl.DataSource)
            ActorsListUserControl.Refresh()
        End If

    End Sub

    Private Sub EditActor_Begin(sender As Object, e As EventArgs)

        Dim pnl As New EditActorPanel
        Dim a As Actor = DirectCast(sender, ActorUserControl).Actor
        pnl.Run(a)
        AddHandler pnl.Closed, AddressOf EditActor_End

    End Sub

    Private Sub EditActor_End(sender As Object, e As EventArgs)

        Dim pnl As SlidingPanel = DirectCast(sender, SlidingPanel)
        RemoveHandler pnl.Closed, AddressOf EditActor_End

        If pnl.DialogResult = DialogResult.OK Then
            ActorsListUserControl.Refresh()
        End If

    End Sub

    Private Sub DeleteActor_Begin(sender As Object, e As EventArgs)

        'Ask confirmation
        Dim pnl As New MsgBoxPanel
        Dim ctr As ActorUserControl = DirectCast(sender, ActorUserControl)
        Dim qst As String

        'Define the message
        If GlobalSettings.This.CurrentMovie.Type = DemoMovie.DEMOTYPE.Quick Then
            qst = "Are you sure to permanently remove this actor?"
        Else
            qst = "Are you sure to permanently remove this actor?" & vbCrLf & "Note: Actor will be deleted from any task he/she appears"
        End If
        qst = qst & vbCrLf & "Actor to delete: " & ctr.Actor.ToString

        'Run the msgbox panel
        pnl.DataSource = ctr.Actor
        pnl.Run("Remove an actor from the cast", qst, MsgBoxStyle.YesNo)
        AddHandler pnl.Closed, AddressOf DeleteActor_End

    End Sub

    Private Sub DeleteActor_End(sender As Object, e As EventArgs)

        Dim pnl As MsgBoxPanel = DirectCast(sender, MsgBoxPanel)
        Dim movie As DemoMovie = GlobalSettings.This.CurrentMovie
        Dim a As Actor = pnl.GetDataSource(Of Actor)

        RemoveHandler pnl.Closed, AddressOf DeleteActor_End

        If pnl.Result = MsgBoxResult.Yes Then

            'Remove actor from the cast
            movie.RemoveActor(a)

            'Refresh list
            ActorsListUserControl.Refresh()

        End If

    End Sub

    Private Sub CopyActorsLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles CopyActorsLink.LinkClicked

        Dim pnl As New SelectMoviePanel
        PanelController.This.Show(pnl, True)
        AddHandler pnl.Closed, AddressOf CopyActors_End

    End Sub

    Private Sub CopyActors_End(sender As Object, e As EventArgs)

        Dim pnl As SelectMoviePanel = DirectCast(sender, SelectMoviePanel)
        RemoveHandler pnl.Closed, AddressOf CopyActors_End
        Dim movie As DemoMovie = GlobalSettings.This.CurrentMovie

        If pnl.DialogResult = DialogResult.OK Then
            Dim copiedMovie As DemoMovie = pnl.GetDataSource(Of DemoMovie)

            'Clear actors
            Do While movie.Actors.Count > 0
                movie.RemoveActor(movie.Actors(0))
            Loop

            'Copy actors
            For Each item As Actor In copiedMovie.Actors
                GlobalSettings.This.CurrentMovie.Actors.Add(item.Clone)
            Next

            'Refresh
            ActorsListUserControl.Refresh()
        End If


    End Sub
End Class
