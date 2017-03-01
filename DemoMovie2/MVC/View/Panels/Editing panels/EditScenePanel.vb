Public Class EditScenePanel

    Protected Friend Overrides Sub OnShowing(e As EventArgs)
        MyBase.OnShowing(e)

        If DataSource Is Nothing Then DataSource = New Scene

        TitleTextBox.Text = GetDataSource(Of Scene).Title

        TakesList.Takes = GetDataSource(Of Scene).Takes
        TakesList.AllowAdd = True
        TakesList.AllowDelete = True
        TakesList.Refresh()

        AddHandler TakesList.Delete, AddressOf DeleteTake_Begin
        AddHandler TakesList.Create, AddressOf AddNewTake_Begin
        AddHandler TakesList.Selected, AddressOf EditTake_Begin

    End Sub

    Private Sub EditTake_Begin(sender As Object, e As EventArgs)

        Dim pnl As New EditTakePanel
        Dim t As Take = DirectCast(sender, TakeUserControl).Take
        pnl.Run(t)
        AddHandler pnl.Closed, AddressOf EditTake_End

    End Sub

    Private Sub EditTake_End(sender As Object, e As EventArgs)

        Dim movie As DemoMovie = GlobalSettings.This.CurrentMovie
        Dim pnl As EditTakePanel = DirectCast(sender, EditTakePanel)
        RemoveHandler pnl.Closed, AddressOf EditTake_End

        If pnl.DialogResult = DialogResult.OK Then
            TakesList.Refresh()
        End If

    End Sub

    Private Sub DeleteTake_Begin(sender As Object, e As EventArgs)

        'Ask confirmation
        Dim pnl As New MsgBoxPanel
        Dim ctr As TakeUserControl = DirectCast(sender, TakeUserControl)
        Dim qst As String

        'Define the message
        qst = "Are you sure to permanently remove this take?"
        qst = qst & vbCrLf & "Take to delete: " & ctr.Take.ToString

        'Run the msgbox panel
        pnl.DataSource = ctr.Take
        pnl.Run("Remove a take from the movie", qst, MsgBoxStyle.YesNo)
        AddHandler pnl.Closed, AddressOf DeleteTake_End

    End Sub

    Private Sub DeleteTake_End(sender As Object, e As EventArgs)

        Dim pnl As MsgBoxPanel = DirectCast(sender, MsgBoxPanel)
        Dim movie As DemoMovie = GlobalSettings.This.CurrentMovie
        Dim t As Take = pnl.GetDataSource(Of Take)

        RemoveHandler pnl.Closed, AddressOf DeleteTake_End

        If pnl.Result = MsgBoxResult.Yes Then

            'Retrieve the scene (parent) of this take
            For Each s As Scene In movie.Scenes
                If s.Takes.Contains(t) Then
                    s.Takes.Remove(t)
                    Exit For
                End If
            Next

            'Refresh the list
            TakesList.Refresh()
        End If

    End Sub

    Private Sub AddNewTake_Begin(sender As Object, e As EventArgs)

        Dim pnl As New EditTakePanel
        pnl.Run(Nothing)
        AddHandler pnl.Closed, AddressOf AddNewTake_End

    End Sub


    Private Sub AddNewTake_End(sender As Object, e As EventArgs)

        Dim movie As DemoMovie = GlobalSettings.This.CurrentMovie
        Dim pnl As EditTakePanel = DirectCast(sender, EditTakePanel)
        RemoveHandler pnl.Closed, AddressOf AddNewTake_End

        If pnl.DialogResult = DialogResult.OK Then
            GetDataSource(Of Scene).Takes.Add(pnl.GetDataSource(Of Take))
            TakesList.Refresh()
        End If

    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        'Control fields
        If TitleTextBox.Text = "" Then Exit Sub

        'Return
        GetDataSource(Of Scene).Title = TitleTextBox.Text
        DialogResult = DialogResult.OK
        PanelController.This.Close()
    End Sub

    Private Sub AbortButton_Click(sender As Object, e As EventArgs) Handles AbortButton.Click
        DialogResult = DialogResult.Cancel
        PanelController.This.Close()
    End Sub
End Class
