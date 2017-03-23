Public Class ActorUserControl

#Region "Microsft KB953934"

    Public Delegate Sub SizeChangedDelegate(ByVal e As EventArgs)

    Private Sub SizeChangedDelegateHandler(ByVal e As EventArgs)

        MyBase.OnSizeChanged(e)

    End Sub

    Protected Overrides Sub OnSizeChanged(ByVal e As EventArgs)

        If Me.Handle.ToInt32 > 0 Then

            Dim obj(0) As Object

            obj(0) = e

            Dim scd As New SizeChangedDelegate(AddressOf SizeChangedDelegateHandler)
            Me.BeginInvoke(scd, obj)

        End If

    End Sub

#End Region

    Private _Active As Boolean = True
    Public Property Active As Boolean
        Get
            Return _Active
        End Get
        Set(value As Boolean)
            _Active = value
            If value Then Cursor = Cursors.Hand Else Cursor = Cursors.Default
        End Set
    End Property

    'Private members
    Dim oldColor As Color = Nothing

    'Edit mode
    Public Property AllowDelete As Boolean = True

    Private _Actor As Actor
    Public Property Actor As Actor
        Get
            Return _Actor
        End Get
        Set(value As Actor)
            _Actor = value

            If _Actor IsNot Nothing Then
                NameLabel.Text = _Actor.Name
                RoleLabel.Text = _Actor.Role
                Dim img As Bitmap = _Actor.GetImage
                If img IsNot Nothing Then ImagePictureBox.Image = img
            Else
                NameLabel.Text = ""
                RoleLabel.Text = ""
            End If
        End Set
    End Property

#Region "Manage the selection behaviour"

    Private Property Selected As Boolean = False

    Public Event Entered(sender As Object, e As EventArgs)

    Private Sub MouseEnters(sender As Object, e As EventArgs) Handles MyBase.MouseEnter, ImagePictureBox.MouseEnter, NameLabel.MouseEnter, RoleLabel.MouseEnter, DeletePictureBox.MouseEnter
        RaiseEvent Entered(Me, EventArgs.Empty)
        If Not Active Then Exit Sub
        If Me.ClientRectangle.Contains(Me.PointToClient(MousePosition)) Then
            If Not Selected Then
                Selected = Not Selected
                oldColor = Me.BackColor
                Me.BackColor = Color.Orange
                If AllowDelete Then DeletePictureBox.Visible = True
                BorderStyle = BorderStyle.FixedSingle

            End If
        End If
    End Sub

    Private Sub MouseLeaves(sender As Object, e As EventArgs) Handles MyBase.MouseLeave, ImagePictureBox.MouseLeave, NameLabel.MouseLeave, RoleLabel.MouseLeave
        If Not Active Then Exit Sub
        If Not Me.ClientRectangle.Contains(Me.PointToClient(MousePosition)) Then
            If Selected Then
                Selected = Not Selected
                Me.BackColor = oldColor
                oldColor = Nothing
                If AllowDelete Then DeletePictureBox.Visible = False
                BorderStyle = BorderStyle.None
            End If
        End If
    End Sub

#End Region

#Region "Delete"

    'Delete event
    Public Event Delete(sender As Object, e As EventArgs)

    Protected Friend Overridable Sub OnDelete(e As EventArgs)
        RaiseEvent Delete(Me, e)
    End Sub

    'Raise the public event
    Private Sub DeletePictureBox_Click(sender As Object, e As EventArgs) Handles DeletePictureBox.Click
        OnDelete(e)
    End Sub

#End Region

    'Raise the main Click event for each subcontrols clicked
    Private Sub Clicks(sender As Object, e As EventArgs) Handles ImagePictureBox.Click, NameLabel.Click, RoleLabel.Click
        If Active Then OnClick(e)
    End Sub

    'Control the image position
    Private Sub ActorUserControl_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Try
            ImagePictureBox.Size = New Size(CInt(Me.Width / 3 * 2), CInt(Me.Width / 3 * 2))
            ImagePictureBox.Location = New Point(CInt((Me.Width - ImagePictureBox.Width) / 2), 10)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ImagePictureBox_MouseDown(sender As Object, e As MouseEventArgs) Handles ImagePictureBox.MouseDown
        If Active Then OnMouseDown(e)
    End Sub

End Class
