Public Class ListOfScenes

    Public Property Scenes As List(Of Scene)
    Public Property AllowDelete As Boolean
    Public Property AllowAdd As Boolean

    ''' <summary>
    ''' Refresh all scenes  
    ''' </summary>
    Public Overrides Sub Refresh()
        MyBase.Refresh()

        'Load all actors
        ScenesFlowLayoutPanel.Controls.Clear()
        Dim ctr As SceneUserControl
        For Each s As Scene In Scenes

            'Create a new scene control
            ctr = New SceneUserControl
            ctr.AllowDelete = AllowDelete

            'Check if scene is fully completed

            ctr.BackColor = Color.LightSkyBlue
            ctr.CurrentItem = s

            AddHandler ctr.Click, AddressOf SelectedClick
            AddHandler ctr.Delete, AddressOf DeleteClick

            'Add to the parent flow control
            ScenesFlowLayoutPanel.Controls.Add(ctr)
            ctr.Size = New Size(200, Me.Height - 10)

        Next

        If AllowAdd Then
            'Create add actor control
            Dim addItem As New AddUserControl
            addItem.Visible = True
            addItem.BackColor = Color.WhiteSmoke
            addItem.BorderStyle = System.Windows.Forms.BorderStyle.None
            AddHandler addItem.Click, AddressOf CreateClick

            'Add to the parent flow control
            ScenesFlowLayoutPanel.Controls.Add(addItem)
            addItem.Size = New Size(200, Me.Height - 10)
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
