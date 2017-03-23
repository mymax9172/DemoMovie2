Public Class GeneralTabPanel

    Private CurrentItem As DemoMovie

    Protected Friend Overrides Sub OnShowing(e As EventArgs)
        MyBase.OnShowing(e)

        CurrentItem = GlobalSettings.This.CurrentMovie

        DemoDateTimePicker.Format = DateTimePickerFormat.Custom
        DemoDateTimePicker.CustomFormat = "MM-dd-yyyy HH:mm:ss"

        TitleTextBox.Text = CurrentItem.Title
        CustomerTextBox.Text = CurrentItem.CustomerName
        DemoDateTimePicker.Value = CurrentItem.DemoDate

        FullPictureBox.Visible = CBool(CurrentItem.Type = DemoMovie.DEMOTYPE.Full)
        FullLabel.Visible = CBool(CurrentItem.Type = DemoMovie.DEMOTYPE.Full)
        SimplePictureBox.Visible = CBool(CurrentItem.Type = DemoMovie.DEMOTYPE.Simple)
        SimpleLabel.Visible = CBool(CurrentItem.Type = DemoMovie.DEMOTYPE.Simple)
        QuickPictureBox.Visible = CBool(CurrentItem.Type = DemoMovie.DEMOTYPE.Quick)
        QuickLabel.Visible = CBool(CurrentItem.Type = DemoMovie.DEMOTYPE.Quick)

        PublishedLabel.Visible = CurrentItem.IsPublished

        Select Case CurrentItem.Type
            Case DemoMovie.DEMOTYPE.Quick : QuickPanel.Visible = True
            Case DemoMovie.DEMOTYPE.Simple : SimplePanel.Visible = True
            Case DemoMovie.DEMOTYPE.Full : FullPanel.Visible = True
        End Select

    End Sub

    Private Sub TitleTextBox_TextChanged(sender As Object, e As EventArgs) Handles TitleTextBox.TextChanged

        CurrentItem.Title = TitleTextBox.Text
        ParentPanel.Title = "Edit a demo movie: " & CurrentItem.Title

    End Sub

    Private Sub CustomerTextBox_TextChanged(sender As Object, e As EventArgs) Handles CustomerTextBox.TextChanged

        CurrentItem.CustomerName = CustomerTextBox.Text

    End Sub

    Private Sub DemoDateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles DemoDateTimePicker.ValueChanged

        CurrentItem.DemoDate = DemoDateTimePicker.Value

    End Sub


End Class
