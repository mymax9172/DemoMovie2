Public Class ScenesTabPanel

    Protected Friend Overrides Sub OnShowing(e As EventArgs)
        MyBase.OnShowing(e)

        ScenesListUserControl.Scenes = GlobalSettings.This.CurrentMovie.Scenes
        ScenesListUserControl.AllowAdd = True
        ScenesListUserControl.AllowDelete = True
        ScenesListUserControl.Refresh()

        AddHandler ScenesListUserControl.Delete, AddressOf DeleteScene_Begin
        AddHandler ScenesListUserControl.Create, AddressOf AddNewScene_Begin
        AddHandler ScenesListUserControl.Selected, AddressOf EditScene_Begin

    End Sub

    Private Sub EditScene_Begin(sender As Object, e As EventArgs)

        Dim pnl As New EditScenePanel
        Dim s As Scene = DirectCast(sender, SceneUserControl).CurrentItem
        pnl.DataSource = s
        PanelController.This.Show(pnl)

        AddHandler pnl.Closed, AddressOf EditScene_End

    End Sub

    Private Sub EditScene_End(sender As Object, e As EventArgs)

        Dim movie As DemoMovie = GlobalSettings.This.CurrentMovie
        Dim pnl As EditScenePanel = DirectCast(sender, EditScenePanel)
        RemoveHandler pnl.Closed, AddressOf EditScene_End

        If pnl.DialogResult = DialogResult.OK Then
            ScenesListUserControl.Refresh()
        End If

    End Sub

    Private Sub DeleteScene_Begin(sender As Object, e As EventArgs)

        'Ask confirmation
        Dim pnl As New MsgBoxPanel
        Dim ctr As SceneUserControl = DirectCast(sender, SceneUserControl)
        Dim qst As String

        'Define the message
        qst = "Are you sure to permanently remove this scene (including embedded takes)?"
        qst = qst & vbCrLf & "Scene to delete: " & ctr.CurrentItem.ToString

        'Run the msgbox panel
        pnl.DataSource = ctr.CurrentItem
        pnl.Run("Remove a scene from the movie", qst, MsgBoxStyle.YesNo)
        AddHandler pnl.Closed, AddressOf DeleteScene_End

    End Sub

    Private Sub DeleteScene_End(sender As Object, e As EventArgs)

        Dim pnl As MsgBoxPanel = DirectCast(sender, MsgBoxPanel)
        Dim movie As DemoMovie = GlobalSettings.This.CurrentMovie
        Dim s As Scene = pnl.GetDataSource(Of Scene)

        RemoveHandler pnl.Closed, AddressOf DeleteScene_End

        If pnl.Result = MsgBoxResult.Yes Then

            movie.Scenes.Remove(s)

            'Refresh the list
            ScenesListUserControl.Refresh()
        End If

    End Sub

    Private Sub AddNewScene_Begin(sender As Object, e As EventArgs)

        Dim pnl As New EditScenePanel
        PanelController.This.Show(pnl)
        AddHandler pnl.Closed, AddressOf AddNewScene_End

    End Sub

    Private Sub AddNewScene_End(sender As Object, e As EventArgs)

        Dim movie As DemoMovie = GlobalSettings.This.CurrentMovie
        Dim pnl As EditScenePanel = DirectCast(sender, EditScenePanel)
        RemoveHandler pnl.Closed, AddressOf AddNewScene_End

        If pnl.DialogResult = DialogResult.OK Then
            movie.Scenes.Add(pnl.GetDataSource(Of Scene))
            ScenesListUserControl.Refresh()
        End If

    End Sub

End Class
