Imports it.mymax.demomovie2

Public Class SimpleDirectorForm
    Implements ISwipeForm

    Private Property movie As DemoMovie = GlobalSettings.This.CurrentMovie

    Public Sub Run()

        Width = CInt(Screen.PrimaryScreen.WorkingArea.Width / 5 * 3)
        Left = CInt(Width / 3)
        Top = -Height
        Show()
        Application.DoEvents()

        'Set up the movie
        TitleLabel.Text = movie.Title & " @ " & movie.CustomerName

        For Each t As Take In movie.GetDummyScene.Takes
            t.Status = [Take].STATUSTAKE.NotStarted
        Next
        movie.GetDummyScene.Takes(0).Status = [Take].STATUSTAKE.Started

        TakesList.Takes = movie.GetDummyScene.Takes
        TakesList.AllowAdd = False
        TakesList.AllowDelete = False
        AddHandler TakesList.Selected, AddressOf ShowTake

        TakesList.Refresh()

        Swipe(True)

    End Sub

    Public Overrides Sub Refresh() Implements ISwipeForm.Refresh
        MyBase.Refresh()

        TakesList.Refresh()

    End Sub

    Public Sub Swipe(show As Boolean) Implements ISwipeForm.Swipe

        Dim target As Integer

        'Set the target
        If Not show Then
            target = -Height
        Else
            Left = CInt((Screen.PrimaryScreen.WorkingArea.Width - Width) / 2)
            target = 0
        End If

        Me.Visible = True
        Dim t As New Transitions.Transition(New Transitions.TransitionType_EaseInEaseOut(200))
        t.add(Me, "Top", target)
        t.run()

        Do While (Me.Top <> target)
            Application.DoEvents()
        Loop

    End Sub

    Private Sub ClosePictureBox_Click(sender As Object, e As EventArgs) Handles ClosePictureBox.Click
        Close()

        GlobalSettings.This.CurrentMovie = Nothing
        GlobalSettings.This.MainForm.Show()

    End Sub

    Private Sub ShowTake(sender As Object, e As EventArgs)

        Swipe(False)

        Dim t As Take = DirectCast(sender, TakeUserControl).Take

        'Update his status
        t.Status = [Take].STATUSTAKE.Started

        'Show the window
        Dim frm As New SimpleStageForm
        frm.Run(t, Me)

    End Sub


End Class