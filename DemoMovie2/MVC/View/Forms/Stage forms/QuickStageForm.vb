Public Class QuickStageForm

    Private OwnerMain As QuickDirectorForm
    Private DefLocation As Boolean = True

    Private thisScreen As Screen = GlobalSettings.This.UseThisScreen

    Public Sub Run(item As Actor, owner As QuickDirectorForm)

        ActorUserControl1.Actor = item

        Location = thisScreen.Bounds.Location + New Point(thisScreen.WorkingArea.Width, 0)
        OwnerMain = owner
        Show()

        Swipe(True)

    End Sub

    Private Sub Swipe(show As Boolean)

        Dim target As Integer

        'Set the target
        If Not show Then target = thisScreen.Bounds.Location.X + thisScreen.WorkingArea.Width Else target = thisScreen.Bounds.Location.X + thisScreen.WorkingArea.Width - Width

        Me.Visible = True
        Dim t As New Transitions.Transition(New Transitions.TransitionType_EaseInEaseOut(500))
        t.add(Me, "Left", target)
        t.run()

        Do While (Me.Left <> target)
            Application.DoEvents()
        Loop

        If show Then Me.Show()

    End Sub

    Private Sub ActorUserControl1_MouseDown(sender As Object, e As MouseEventArgs) Handles ActorUserControl1.MouseDown

        If e.Button = MouseButtons.Left Then

            Swipe(False)
            OwnerMain.Swipe(True)
            Close()

        ElseIf e.Button = MouseButtons.Right Then

            Dim target As Integer

            If DefLocation Then
                target = thisScreen.Bounds.Location.X
            Else
                target = thisScreen.Bounds.Location.X + thisScreen.WorkingArea.Width - Width
            End If
            DefLocation = Not DefLocation

            Dim t As New Transitions.Transition(New Transitions.TransitionType_EaseInEaseOut(200))
            t.add(Me, "Left", target)
            t.run()

            Do While (Me.Left <> target)
                Application.DoEvents()
            Loop

        End If
    End Sub
End Class