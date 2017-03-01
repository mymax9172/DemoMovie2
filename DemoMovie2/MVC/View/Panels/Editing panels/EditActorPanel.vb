Public Class EditActorPanel

    Private Property CurrentItem As Actor

    Public Sub Run(item As Actor)

        'Store input parameters
        CurrentItem = item

        If item Is Nothing Then
            CurrentItem = New Actor
        Else
            CurrentItem = item
        End If
        DataSource = CurrentItem

        'Show the window
        RefreshWindow()

        PanelController.This.Show(Me, True)

    End Sub

    Protected Friend Overrides Sub OnShowing(e As EventArgs)
        MyBase.OnShowing(e)

        ImagePictureBox.Size = New Size(80, 80)

    End Sub

    Private Sub RefreshWindow()

        NameTextBox.Text = CurrentItem.Name
        RoleTextBox.Text = CurrentItem.Role
        ImagePictureBox.Tag = CurrentItem.ImageName
        If CurrentItem.ImageName <> "" Then ImagePictureBox.Image = CurrentItem.GetImage

    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        PanelController.This.Close()
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click

        'Check fields
        If NameTextBox.Text = "" Then Exit Sub
        If RoleTextBox.Text = "" Then Exit Sub

        'Update object
        CurrentItem.Name = NameTextBox.Text
        CurrentItem.Role = RoleTextBox.Text
        CurrentItem.ImageName = CStr(ImagePictureBox.Tag)

        Me.DialogResult = DialogResult.OK

        PanelController.This.Close()

    End Sub

    Private Sub ImagePictureBox_Click(sender As Object, e As EventArgs) Handles ImagePictureBox.Click

        Dim ms As New OpenFileDialog
        With ms
            .CheckFileExists = True
            .InitialDirectory = GlobalSettings.This.ImageFolder
            .Multiselect = False
        End With

        Dim msgResult As DialogResult = ms.ShowDialog()

        If msgResult = DialogResult.OK Then

            'Check if the file exist into the image folder
            If Not IO.File.Exists(GlobalSettings.This.ImageFolder & "\" & ms.SafeFileName) Then
                IO.File.Copy(ms.FileName, GlobalSettings.This.ImageFolder & "\" & ms.SafeFileName)
            End If

            ImagePictureBox.Tag = ms.SafeFileName
            CurrentItem.ImageName = ms.SafeFileName
            ImagePictureBox.Image = CurrentItem.GetImage

            'Check if the name exist or not
            If NameTextBox.Text = "" Then
                NameTextBox.Text = System.IO.Path.GetFileNameWithoutExtension(ms.FileName)
            End If

        End If

    End Sub

End Class
