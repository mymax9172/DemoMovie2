Public Class MovieUserControl

    Public Event Edit As EventHandler
    Public Event Delete As EventHandler
    Public Event Download As EventHandler

    Public Property AllowEdit As Boolean
    Public Property AllowDelete As Boolean

    Dim oldColor As Color = Nothing

    Private _CurrentItem As DemoMovie
    Public Property CurrentItem As DemoMovie
        Get
            Return _CurrentItem
        End Get
        Set(value As DemoMovie)
            _CurrentItem = value
            If value IsNot Nothing Then
                TitleLabel.Visible = True
                TitleLabel.Text = value.Title

                CustomerLabel.Visible = True
                DateLabel.Visible = AllowEdit
                DateLabel.Text = CurrentItem.DemoDate.ToShortDateString
                CustomerLabel.Text = value.CustomerName

                Select Case value.Type
                    Case DemoMovie.DEMOTYPE.Quick : BackColor = Color.LightSkyBlue
                    Case DemoMovie.DEMOTYPE.Simple : BackColor = Color.SkyBlue
                    Case DemoMovie.DEMOTYPE.Full : BackColor = Color.DeepSkyBlue
                End Select

                If value.IsCloud Then
                    BackColor = Color.LightGray
                    AllowEdit = False
                    AllowDelete = CBool(value.Author = GlobalSettings.This.Author)
                    DeletePictureBox.Visible = False
                    EditPictureBox.Visible = False
                    DownloadPictureBox.Visible = True
                End If
            Else
                TitleLabel.Visible = False
            End If
        End Set
    End Property

    Private Sub EditPictureBox_Click(sender As Object, e As EventArgs) Handles EditPictureBox.Click

        RaiseEvent Edit(Me, EventArgs.Empty)

    End Sub

    Private Sub DeletePictureBox_Click(sender As Object, e As EventArgs) Handles DeletePictureBox.Click

        RaiseEvent Delete(Me, EventArgs.Empty)

    End Sub

    Private Sub Clicks(sender As Object, e As EventArgs) Handles TitleLabel.Click, CustomerLabel.Click, DateLabel.Click
        OnClick(e)
    End Sub

    Private Sub MouseEnters(sender As Object, e As EventArgs) Handles MyBase.MouseEnter, TitleLabel.MouseEnter, EditPictureBox.MouseEnter, DeletePictureBox.MouseEnter, CustomerLabel.MouseEnter
        If Me.ClientRectangle.Contains(Me.PointToClient(MousePosition)) Then
            If AllowEdit Then EditPictureBox.Visible = True
            If AllowDelete Then DeletePictureBox.Visible = True
            If AllowEdit Then DateLabel.Visible = True

            If oldColor = Nothing Then
                BorderStyle = BorderStyle.FixedSingle
                oldColor = Me.BackColor
                Me.BackColor = Color.Orange
            End If
        End If
    End Sub

    Private Sub MouseLeaves(sender As Object, e As EventArgs) Handles MyBase.MouseLeave, TitleLabel.MouseLeave, EditPictureBox.MouseLeave, DeletePictureBox.MouseLeave, CustomerLabel.MouseLeave
        If Not Me.ClientRectangle.Contains(Me.PointToClient(MousePosition)) Then
            If AllowEdit Then EditPictureBox.Visible = False
            If AllowDelete Then DeletePictureBox.Visible = False

            If AllowEdit Then DateLabel.Visible = False

            If oldColor <> Nothing Then
                BorderStyle = BorderStyle.None
                Me.BackColor = oldColor
                oldColor = Nothing
            End If
        End If
    End Sub

    Private Sub DownloadPictureBox_Click(sender As Object, e As EventArgs) Handles DownloadPictureBox.Click

        RaiseEvent Download(Me, EventArgs.Empty)

    End Sub

End Class
