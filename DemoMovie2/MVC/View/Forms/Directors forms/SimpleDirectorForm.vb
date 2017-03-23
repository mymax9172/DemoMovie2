Public Class SimpleDirectorForm
    Implements ISwipeForm

    Private Property movie As DemoMovie = GlobalSettings.This.CurrentMovie
    Private thisScreen As Screen = GlobalSettings.This.UseThisScreen

    Public Sub Run()

        Width = CInt(thisScreen.WorkingArea.Width / 5 * 3)
        Location = thisScreen.Bounds.Location + New Point(CInt(Width / 3), -Height)
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

    Private _Visible As Boolean
    Private ReadOnly Property ISwipeForm_Visible As Boolean Implements ISwipeForm.Visible
        Get
            Return _Visible
        End Get
    End Property

    Public Overrides Sub Refresh() Implements ISwipeForm.Refresh
        MyBase.Refresh()

        TakesList.Refresh()

    End Sub

    Public Sub Swipe(show As Boolean, Optional enabled As Boolean = True) Implements ISwipeForm.Swipe

        Dim target As Integer

        'Set the target
        If Not show Then
            target = thisScreen.Bounds.Location.Y - Height
        Else
            Left = thisScreen.Bounds.Location.X + CInt((thisScreen.WorkingArea.Width - Width) / 2)
            target = 0
        End If

        Me.Visible = True
        Dim t As New Transitions.Transition(New Transitions.TransitionType_EaseInEaseOut(200))
        t.add(Me, "Top", target)
        t.run()

        Do While (Me.Top <> target)
            Application.DoEvents()
        Loop

        If show Then Me.Focus()
        _Visible = show
        Me.Enabled = enabled

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