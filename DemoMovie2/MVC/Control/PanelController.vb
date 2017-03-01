Public Class PanelController

#Region "Singleton"

    Private Shared _This As PanelController

    Public Shared ReadOnly Property This As PanelController
        Get
            If _This Is Nothing Then _This = New PanelController
            Return _This
        End Get
    End Property

#End Region

    Public Property Container As Control
    Private Panels As New Stack(Of SlidingPanel)
    Private DarkPanel As Panel

    Public Event PanelChanged(sender As Object, e As EventArgs)
    Public Event TitleChanged(sender As Object, e As EventArgs)

    Public ReadOnly Property CurrentPanel As SlidingPanel
        Get
            If Panels.Count = 0 Then Return Nothing
            Return Panels.Peek
        End Get

    End Property

    Public Sub Freeze()

        'Disable the current panel
        If CurrentPanel IsNot Nothing Then CurrentPanel.Enabled = False

    End Sub

    Public Sub UnFreeze()

        'Enable the last panel
        If CurrentPanel IsNot Nothing Then CurrentPanel.Enabled = True

    End Sub


    Public Sub Show(panel As SlidingPanel)
        Show(panel, False)
    End Sub

    Public Sub Show(panel As SlidingPanel, isModal As Boolean)

        'Check if it is modal
        If isModal Then
            Freeze()
        End If

        'Add this panel to the list
        Panels.Push(panel)
        Container.Controls.Add(panel)

        'Show the panel
        panel.AddParent(Container, isModal)
        panel.Swipe(True)
        AddHandler panel.TitleChanged, AddressOf PanelTitleChanged

        'Raise the event
        OnPanelChanged(EventArgs.Empty)
    End Sub

    Public Sub Close()

        'Get the last panel
        Dim pnl As SlidingPanel = Panels.Pop
        pnl.Swipe(False)

        'Check if it was modal
        If pnl.IsModal Then UnFreeze()

        'Reactivate last panel
        If Panels.Count > 0 Then
            pnl = Panels.Peek
            pnl.OnResumed(EventArgs.Empty)
        End If

        RaiseEvent PanelChanged(Me, EventArgs.Empty)

    End Sub

    Protected Friend Sub OnPanelChanged(e As EventArgs)
        RaiseEvent PanelChanged(Me, e)
    End Sub

    Protected Friend Sub OnTitleChanged(e As EventArgs)
        RaiseEvent TitleChanged(Me, e)
    End Sub

    Private Sub PanelTitleChanged(sender As Object, e As EventArgs)
        OnTitleChanged(e)
    End Sub

End Class
