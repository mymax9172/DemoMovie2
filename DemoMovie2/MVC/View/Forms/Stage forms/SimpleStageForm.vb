Public Class SimpleStageForm

    Private OwnerMain As ISwipeForm
    Private DefLocation As Boolean = True
    Private ActorIndex As Integer = -1

    Public Sub Run(item As Take, owner As ISwipeForm)

        TakeUserControl1.Take = item
        TakeUserControl1.AllowDelete = False

        If item.Actors.Count > 0 Then
            ActorUserControl1.Actor = item.Actors.First
            ActorIndex = 0
        End If

        Left = Screen.PrimaryScreen.WorkingArea.Width
        Top = CInt(Screen.PrimaryScreen.WorkingArea.Height / 10)
        OwnerMain = owner
        Show()

        TakeUserControl1.Refresh()
        ActorUserControl1.Refresh()

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

    Private Sub TakeUserControl1_MouseDown(sender As Object, e As MouseEventArgs) Handles TakeUserControl1.MouseDown

        If e.Button = MouseButtons.Left Then

            'Look for the right scene
            For Each s As Scene In GlobalSettings.This.CurrentMovie.Scenes

                If s.Takes.Contains(TakeUserControl1.Take) Then

                    Dim fgNext As Boolean = False

                    'Update all takes status (all previous must be marked as completed and the next as started)
                    For Each t As Take In s.Takes
                        If fgNext Then
                            If t.Status = [Take].STATUSTAKE.NotStarted Then t.Status = [Take].STATUSTAKE.Started
                            Exit For
                        End If
                        t.Status = [Take].STATUSTAKE.Completed
                        If t Is TakeUserControl1.Take Then fgNext = True
                    Next

                    'Exit
                    Exit For
                End If
            Next

            Swipe(False)
            OwnerMain.Refresh()
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

    Private Sub ActorUserControl1_MouseDown(sender As Object, e As MouseEventArgs) Handles ActorUserControl1.MouseDown

        If e.Button = MouseButtons.Left Then

            If TakeUserControl1.Take.Actors.Count > 1 Then

                If ActorIndex = -1 Then Exit Sub

                ActorIndex += 1
                If ActorIndex > (TakeUserControl1.Take.Actors.Count - 1) Then ActorIndex = 0
                ActorUserControl1.Actor = TakeUserControl1.Take.Actors(ActorIndex)
                ActorUserControl1.Refresh()

            End If

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