Public Class QuickDirectorForm

    Private Property movie As DemoMovie = GlobalSettings.This.CurrentMovie

    Public Sub Run()

        Width = CInt(Screen.PrimaryScreen.WorkingArea.Width / 5 * 3)
        Left = CInt(Width / 3)
        Top = -Height
        Show()
        Application.DoEvents()

        'Set up the movie
        TitleLabel.Text = movie.Title & " @ " & movie.CustomerName

        ActorsListUserControl.AllowAdd = False
        ActorsListUserControl.AllowDelete = False
        ActorsListUserControl.Actors = movie.Actors
        AddHandler ActorsListUserControl.Selected, AddressOf ShowActor

        ActorsListUserControl.Refresh()

        Swipe(True)

    End Sub

    Public Sub Swipe(show As Boolean)

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

        If show Then Me.Focus()

    End Sub

    Private Sub ClosePictureBox_Click(sender As Object, e As EventArgs) Handles ClosePictureBox.Click
        Close()

        GlobalSettings.This.CurrentMovie = Nothing
        GlobalSettings.This.MainForm.Show()

    End Sub

    Private Sub ShowActor(sender As Object, e As EventArgs)

        Swipe(False)

        Dim frm As New QuickStageForm
        frm.Run(DirectCast(sender, ActorUserControl).Actor, Me)

    End Sub

End Class