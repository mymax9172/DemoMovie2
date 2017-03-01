Public Class AddUserControl

    Private Sub AddPictureBox_Click(sender As Object, e As EventArgs) Handles AddPictureBox.Click
        OnClick(e)
    End Sub

    Private Sub AddPictureBox_MouseEnter(sender As Object, e As EventArgs) Handles AddPictureBox.MouseEnter
        BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub AddPictureBox_MouseLeave(sender As Object, e As EventArgs) Handles AddPictureBox.MouseLeave
        BorderStyle = BorderStyle.None
    End Sub

End Class
