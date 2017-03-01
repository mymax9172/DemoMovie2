Public Class SelectActorPanel

    Public Sub Run(item As Take)

        DataSource = item

        'Show the window
        RefreshActors()

        PanelController.This.Show(Me, True)

    End Sub

    Private Sub RefreshActors()

        'Load all actors
        ActorsFlowLayoutPanel.Controls.Clear()
        Dim ctr As ActorUserControl
        For Each a As Actor In GlobalSettings.This.CurrentMovie.Actors

            'Check if actor was already used
            Dim t As Take = DirectCast(DataSource, Take)
            If Not t.Actors.Contains(a) Then

                'Create a new actor control
                ctr = New ActorUserControl
                ctr.BackColor = Color.LightSkyBlue
                ctr.Actor = a
                AddHandler ctr.Click, AddressOf SelectActor

                'Add to the parent flow control
                ActorsFlowLayoutPanel.Controls.Add(ctr)
                ctr.Size = New Size(100, 150)
            End If

        Next

    End Sub

    Private Sub SelectActor(sender As Object, e As EventArgs)

        Dim ctr As ActorUserControl = DirectCast(sender, ActorUserControl)
        DialogResult = DialogResult.OK
        DataSource = ctr.Actor
        PanelController.This.Close()

    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click

        DialogResult = DialogResult.Cancel
        DataSource = Nothing
        PanelController.This.Close()

    End Sub
End Class
