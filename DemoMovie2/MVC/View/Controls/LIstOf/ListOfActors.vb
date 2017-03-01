Public Class ListOfActors

    Public Property Actors As List(Of Actor)
    Public Property AllowDelete As Boolean
    Public Property AllowAdd As Boolean

    ''' <summary>
    ''' Refresh all actors (available in all demo types)
    ''' </summary>
    Public Overrides Sub Refresh()
        MyBase.Refresh()

        'Load all actors
        ActorsFlowLayoutPanel.Controls.Clear()
        Dim ctr As ActorUserControl
        For Each a As Actor In Actors

            'Create a new actor control
            ctr = New ActorUserControl
            ctr.AllowDelete = AllowDelete
            ctr.BackColor = Color.LightSkyBlue
            ctr.Actor = a

            AddHandler ctr.Click, AddressOf SelectedClick
            AddHandler ctr.Delete, AddressOf DeleteClick

            'Add to the parent flow control
            ActorsFlowLayoutPanel.Controls.Add(ctr)
            ctr.Size = New Size(100, 150)

        Next

        If AllowAdd Then
            'Create add actor control
            Dim addItem As New AddUserControl
            addItem.Visible = True
            addItem.BackColor = Color.WhiteSmoke
            addItem.BorderStyle = System.Windows.Forms.BorderStyle.None
            AddHandler addItem.Click, AddressOf CreateClick

            'Add to the parent flow control
            ActorsFlowLayoutPanel.Controls.Add(addItem)
            addItem.Size = New Size(100, 150)
        End If

    End Sub

#Region "Events"

    Public Event Selected(sender As Object, e As EventArgs)
    Public Event Delete(sender As Object, e As EventArgs)
    Public Event Create(sender As Object, e As EventArgs)

    Private Sub SelectedClick(sender As Object, e As EventArgs)
        RaiseEvent Selected(sender, e)
    End Sub

    Private Sub DeleteClick(sender As Object, e As EventArgs)
        RaiseEvent Delete(sender, e)
    End Sub

    Private Sub CreateClick(sender As Object, e As EventArgs)
        RaiseEvent Create(Me, e)
    End Sub


#End Region
End Class
