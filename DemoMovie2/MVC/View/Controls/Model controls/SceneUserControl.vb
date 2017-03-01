Public Class SceneUserControl

    Public Event Edit As EventHandler
    Public Event Delete As EventHandler

    Public Property AllowDelete As Boolean
    Public Property AllowAdd As Boolean
    Public Property Selected As Boolean

    Dim oldColor As Color = Nothing

    Private _CurrentItem As Scene
    Public Property CurrentItem As Scene
        Get
            Return _CurrentItem
        End Get
        Set(value As Scene)
            _CurrentItem = value
            If value IsNot Nothing Then
                TitleLabel.Visible = True
                TakesFlowLayoutPanel.Visible = False
                TitleLabel.Text = value.Title

                TakesFlowLayoutPanel.Controls.Clear()
                For i As Integer = 0 To value.Takes.Count - 1
                    TakesFlowLayoutPanel.Controls.Add(New PictureBox With {.Image = My.Resources.TaskNotStarted, .SizeMode = PictureBoxSizeMode.Zoom, .Size = New Size(24, 24)})
                Next
            Else
                TitleLabel.Visible = False
            End If
        End Set
    End Property

    Private Sub DeletePictureBox_Click(sender As Object, e As EventArgs) Handles DeletePictureBox.Click

        RaiseEvent Delete(Me, EventArgs.Empty)

    End Sub

    Private Sub Clicks(sender As Object, e As EventArgs) Handles TitleLabel.Click
        OnClick(e)
    End Sub

    Private Sub MouseEnters(sender As Object, e As EventArgs) Handles MyBase.MouseEnter, TitleLabel.MouseEnter, DeletePictureBox.MouseEnter
        If Me.ClientRectangle.Contains(Me.PointToClient(MousePosition)) Then
            If Not Selected Then
                Selected = Not Selected
                If AllowDelete Then
                    DeletePictureBox.Visible = True
                    TakesFlowLayoutPanel.Visible = True
                End If
                BorderStyle = BorderStyle.FixedSingle
                oldColor = Me.BackColor
                Me.BackColor = Color.Orange
            End If
        End If
    End Sub

    Private Sub MouseLeaves(sender As Object, e As EventArgs) Handles MyBase.MouseLeave, TitleLabel.MouseLeave, DeletePictureBox.MouseLeave
        If Not Me.ClientRectangle.Contains(Me.PointToClient(MousePosition)) Then

            If Selected Then
                Selected = Not Selected
                If AllowDelete Then
                    DeletePictureBox.Visible = False
                    TakesFlowLayoutPanel.Visible = False
                End If
                BorderStyle = BorderStyle.None
                Me.BackColor = oldColor
                oldColor = Nothing
            End If

        End If
    End Sub

End Class
