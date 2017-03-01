Public Class TakeUserControl

    Private Property Selected As Boolean = False
    Public Property AllowDelete As Boolean = True

    Public Property LeftTakeColor As Color
    Public Property RightTakeColor As Color

    Const IMAGE_SELECTED As Integer = 3
    Const IMAGE_ADD As Integer = 4
    Const IMAGE_ADDSELECTED As Integer = 5

    Public Property Take As Take

    Public Overrides Sub Refresh()
        MyBase.Refresh()

        If Take Is Nothing Then
            TitleLabel.Text = ""
            AllowDelete = False
            ImagePictureBox.Image = TaskImageList.Images(IMAGE_ADD)
        Else
            ImagePictureBox.Image = TaskImageList.Images(Take.Status)
            If AllowDelete Then
                TitleLabel.Text = Take.Title & " (" & Take.Actors.Count & ")"
            Else
                TitleLabel.Text = Take.Title
            End If
        End If

        Invalidate()

    End Sub

    Private Sub DrawConnector(left As Boolean, g As Graphics, colorLine As Color)

        If ImagePictureBox.Image Is Nothing Then Exit Sub

        If left Then

            'Find start and end points
            Dim p1 As New Point(0, ImagePictureBox.Top + CInt(ImagePictureBox.Height / 2))
            Dim p2 As New Point(ImagePictureBox.Left, p1.Y)

            'Draw the line
            g.DrawLine(New Pen(colorLine, 5), p1, p2)

        Else

            'Find start and end points
            Dim p1 As New Point(ImagePictureBox.Right, ImagePictureBox.Top + CInt(ImagePictureBox.Height / 2))
            Dim p2 As New Point(Width, p1.Y)

            'Draw the line
            g.DrawLine(New Pen(colorLine, 5), p1, p2)

        End If

    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)

        Dim g As Graphics = e.Graphics
        g.Clear(BackColor)

        If LeftTakeColor <> Nothing Then DrawConnector(True, g, LeftTakeColor)
        If RightTakeColor <> Nothing Then DrawConnector(False, g, RightTakeColor)

    End Sub

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

    Private Sub ImagePictureBox_Click(sender As Object, e As EventArgs) Handles ImagePictureBox.Click
        OnClick(e)
    End Sub

    Private Sub MouseEnters(sender As Object, e As EventArgs) Handles MyBase.MouseEnter, ImagePictureBox.MouseEnter, TitleLabel.MouseEnter, DeletePictureBox.MouseEnter
        If Me.ClientRectangle.Contains(Me.PointToClient(MousePosition)) Then
            If Not Selected Then
                If Take Is Nothing Then
                    ImagePictureBox.Image = TaskImageList.Images(IMAGE_ADDSELECTED)
                Else
                    ImagePictureBox.Image = TaskImageList.Images(IMAGE_SELECTED)
                End If
                If AllowDelete Then DeletePictureBox.Visible = True
                Selected = True
            End If
        End If
    End Sub

    Private Sub MouseLeaves(sender As Object, e As EventArgs) Handles MyBase.MouseLeave, ImagePictureBox.MouseLeave, TitleLabel.MouseLeave, DeletePictureBox.MouseLeave
        If Not Me.ClientRectangle.Contains(Me.PointToClient(MousePosition)) Then
            If Selected Then
                Refresh()
                If AllowDelete Then DeletePictureBox.Visible = False
                Selected = False
            End If
        End If
    End Sub

    Private Sub ClickMouseDown(sender As Object, e As MouseEventArgs) Handles ImagePictureBox.MouseDown
        OnMouseDown(e)
    End Sub

    Public Function GetLeftNode() As Point
        Return New Point(Me.Left, Me.Top + ImagePictureBox.Top + CInt(ImagePictureBox.Height / 2))

    End Function

    Public Function GetRightNode() As Point
        Return New Point(Me.Right, Me.Top + ImagePictureBox.Top + CInt(ImagePictureBox.Height / 2))
    End Function

    Public Function GetColor() As Color
        If ImagePictureBox.Image Is Nothing Then Return Nothing
        Dim bmp As Bitmap = ImagePictureBox.Image
        Return bmp.GetPixel(24, 24)
    End Function

    Private Sub TakeUserControl_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged

        ImagePictureBox.Left = CInt((Width - ImagePictureBox.Width) / 2)
        ImagePictureBox.Top = 20

    End Sub
End Class
