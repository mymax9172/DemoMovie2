Public Class QuickStageForm

    Private OwnerMain As QuickDirectorForm
    Private DefLocation As Boolean = True

    Public Sub Run(item As Actor, owner As QuickDirectorForm)

        ActorUserControl1.Actor = item

        Left = Screen.PrimaryScreen.WorkingArea.Width
        Top = CInt(Screen.PrimaryScreen.WorkingArea.Height / 10)
        OwnerMain = owner
        Size = New Size(100, 200)
        Show()

        Swipe(True)

    End Sub

    Private Sub Swipe(show As Boolean)

        Dim target As Integer

        'Set the target
        If Not show Then target = Screen.PrimaryScreen.WorkingArea.Width Else target = Screen.PrimaryScreen.WorkingArea.Width - Width

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
                target = 0
            Else
                target = Screen.PrimaryScreen.WorkingArea.Width - Width
            End If
            DefLocation = Not DefLocation

            Dim t As New Transitions.Transition(New Transitions.TransitionType_EaseInEaseOut(200))
            t.add(Me, "Left", target)
            t.run()

            Do While (Me.Left <> 0)
                Application.DoEvents()
            Loop

        End If
    End Sub
End Class