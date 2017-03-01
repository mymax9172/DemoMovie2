Imports System.ComponentModel

Public Class SlidingPanel

    Dim loaded As Boolean = False

    Public Property DialogResult As DialogResult
    Public Property Owner As Control = Nothing
    Public Property IsModal As Boolean = False

    Private _Title As String

    <Browsable(True), Description("Specifies the title of the panel")>
    Public Property Title As String
        Get
            Return _Title
        End Get
        Set(value As String)
            _Title = value
            RaiseEvent TitleChanged(Me, EventArgs.Empty)
        End Set
    End Property

    Public Event Closed(sender As Object, e As EventArgs)
    Public Event Showed(sender As Object, e As EventArgs)
    Public Event Showing(sender As Object, e As EventArgs)
    Public Event Closing(sender As Object, e As EventArgs)

    Public Event Resumed(sender As Object, e As EventArgs)
    Public Event TitleChanged(sender As Object, e As EventArgs)

    Public Property DataSource As Object
    Public Property ParentPanel As SlidingPanel

    Public Function GetDataSource(Of T)() As T
        Return DirectCast(DataSource, T)
    End Function

    Protected Friend Overridable Sub OnShowed(e As EventArgs)
        RaiseEvent Showed(Me, e)
    End Sub

    Protected Friend Overridable Sub OnClosed(e As EventArgs)
        RaiseEvent Closed(Me, e)
    End Sub

    Protected Friend Overridable Sub OnResumed(e As EventArgs)
        RaiseEvent Resumed(Me, e)
    End Sub

    Protected Friend Overridable Sub OnShowing(e As EventArgs)
        RaiseEvent Showing(Me, e)
    End Sub

    Protected Friend Overridable Sub OnClosing(e As EventArgs)
        RaiseEvent Closing(Me, e)
    End Sub


    Public Sub AddParent(owner As Control, Optional isModal As Boolean = False)

        'Read input parameters
        Me.Owner = owner
        Me.IsModal = isModal

        'Hide panel
        Me.Visible = False

        'Add to the parent control
        Me.Owner.Controls.Add(Me)

        'Resize the panel
        If isModal Then
            BorderStyle = BorderStyle.FixedSingle
        End If

        ResizePanel()
        Me.BringToFront()

        AddHandler Me.Owner.Resize, AddressOf OwnerResize

    End Sub

    Private Sub OwnerResize(sender As Object, e As EventArgs)
        ResizePanel()
    End Sub

    Private Sub ResizePanel()

        If Not IsModal Then

            Width = Owner.ClientSize.Width
            Height = Owner.ClientSize.Height

            If loaded Then
                Me.Location = New Point(0, 0)
            Else
                Me.Location = New Point(Owner.Width, 0)
            End If

        Else

            Dim dx As Integer = CInt((Owner.ClientSize.Width - Width) / 2)
            If dx < 0 Then
                dx = 0
                Width = Owner.ClientSize.Width
            End If

            If loaded Then
                Me.Location = New Point(dx, 0)
            Else
                Me.Location = New Point(dx, -Height)
            End If

        End If

    End Sub

    Public Sub Swipe(show As Boolean, Optional speed As Integer = 0)

        Dim target As Integer

        If show Then OnShowing(EventArgs.Empty) Else OnClosing(EventArgs.Empty)

        If Not IsModal Then

            'Set the target
            If Not show Then target = Me.Width Else target = 0

            Me.Visible = True
            Dim t As New Transitions.Transition(New Transitions.TransitionType_EaseInEaseOut(IIf(speed = 0, 500, speed)))
            t.add(Me, "Left", target)
            t.run()

            Do While (Me.Left <> target)
                Application.DoEvents()
            Loop

        Else

            'Set the target
            If Not show Then target = -Height Else target = 0

            Me.Visible = True
            Dim t As New Transitions.Transition(New Transitions.TransitionType_EaseInEaseOut(200))
            t.add(Me, "Top", target)
            t.run()

            Do While (Me.Top <> target)
                Application.DoEvents()
            Loop

        End If

        If Not show Then
            OnClosed(EventArgs.Empty)
            RemoveHandler Me.Owner.Resize, AddressOf OwnerResize
            Owner.Controls.Remove(Me)
            Me.Dispose()
        Else
            loaded = True
            ResizePanel()
            Me.Focus()
            OnShowed(EventArgs.Empty)
        End If

    End Sub

    Private Sub SlidingPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
