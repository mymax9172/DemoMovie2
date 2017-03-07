Public Class FullDirectorForm
    Implements ISwipeForm

    Private Property movie As DemoMovie = GlobalSettings.This.CurrentMovie
    Private thisScreen As Screen = GlobalSettings.This.UseThisScreen

    Private _SelectedScene As Scene
    Private Property SelectedScene As Scene
        Get
            Return _SelectedScene
        End Get
        Set(value As Scene)
            _SelectedScene = value
            If value IsNot Nothing Then
                SelectedSceneUserControl.CurrentItem = value
                TakesList.Takes = value.Takes
            End If
        End Set
    End Property

    Public Sub Run()

        Width = CInt(thisScreen.WorkingArea.Width / 5 * 3)
        Location = thisScreen.Bounds.Location + New Point(CInt(Width / 3), -Height)
        Show()
        Application.DoEvents()

        'Set up the movie
        TitleLabel.Text = movie.Title & " @ " & movie.CustomerName

        For Each s As Scene In movie.Scenes
            For Each t As Take In s.Takes
                t.Status = [Take].STATUSTAKE.NotStarted
            Next
            If s.Takes.Count > 0 Then s.Takes.First.Status = [Take].STATUSTAKE.Started
        Next

        ScenesList.Scenes = movie.Scenes
        ScenesList.AllowDelete = False
        ScenesList.AllowAdd = False
        AddHandler ScenesList.Selected, AddressOf ShowScene

        TakesList.AllowAdd = False
        TakesList.AllowDelete = False
        AddHandler TakesList.Selected, AddressOf ShowTask

        SelectedSceneUserControl.BackColor = Color.SkyBlue

        SelectedScene = Nothing

        Refresh()

        Swipe(True)

    End Sub

    Public Overrides Sub Refresh() Implements ISwipeForm.Refresh
        MyBase.Refresh()

        If SelectedScene Is Nothing Then
            ScenesList.Visible = True
            ScenesList.Refresh()
            SelectedSceneUserControl.Visible = False
            TakesList.Visible = False
        Else
            ScenesList.Visible = False
            SelectedSceneUserControl.Visible = True
            SelectedSceneUserControl.Refresh()
            TakesList.Visible = True
            TakesList.Refresh()
        End If

    End Sub

    Public Sub Swipe(show As Boolean) Implements ISwipeForm.Swipe

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

    End Sub

    Private Sub ClosePictureBox_Click(sender As Object, e As EventArgs) Handles ClosePictureBox.Click
        Close()

        GlobalSettings.This.CurrentMovie = Nothing
        GlobalSettings.This.MainForm.Show()

    End Sub

    Private Sub ShowScene(sender As Object, e As EventArgs)

        Dim s As Scene = DirectCast(sender, SceneUserControl).CurrentItem

        'Show takes for this scene
        TakesList.Takes = s.Takes
        SelectedScene = s
        Refresh()

    End Sub

    Private Sub ShowTask(sender As Object, e As EventArgs)

        Swipe(False)

        Dim t As Take = DirectCast(sender, TakeUserControl).Take

        'Update his status
        t.Status = [Take].STATUSTAKE.Started

        'Show the window
        Dim frm As New SimpleStageForm
        frm.Run(t, Me)

    End Sub

    Private Sub SelectedSceneUserControl_Click(sender As Object, e As EventArgs) Handles SelectedSceneUserControl.Click

        SelectedScene = Nothing
        Refresh()

    End Sub


End Class