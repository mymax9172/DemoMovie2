Public Class MainForm

#Region "Movable"

    Private MouseDownLocation As Point

    Private Sub MainForm_MouseDown(sender As Object, e As MouseEventArgs) Handles TopPanel.MouseDown
        MouseDownLocation = e.Location
    End Sub

    Private Sub MainForm_MouseMove(sender As Object, e As MouseEventArgs) Handles TopPanel.MouseMove
        If e.Button = MouseButtons.Left Then
            Dim delta As Point = e.Location - MouseDownLocation
            Location = Location + delta
        End If
    End Sub

    Private Sub MainForm_MouseUp(sender As Object, e As MouseEventArgs) Handles TopPanel.MouseUp
        MouseDownLocation = Nothing
    End Sub

    Private Sub ClosePictureBox_Click(sender As Object, e As EventArgs) Handles ClosePictureBox.Click
        Close()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Register to the events
        AddHandler PanelController.This.PanelChanged, AddressOf PanelChanged
        AddHandler PanelController.This.TitleChanged, AddressOf PanelChanged

        VersionLabel.Text = Application.ProductVersion

        'Size to the middle of the screen
        Width = CInt(Screen.PrimaryScreen.WorkingArea.Width / 2)
        Height = CInt(Screen.PrimaryScreen.WorkingArea.Height / 2)
        Left = CInt(Width / 2)
        Top = CInt(Height / 2)

        'Start with the splash panel
        Dim pnl As New SplashPanel
        PanelController.This.Show(pnl)

    End Sub

    Private Sub PanelChanged(sender As Object, e As EventArgs)

        If PanelController.This.CurrentPanel IsNot Nothing Then
            SubTitleLabel.Text = PanelController.This.CurrentPanel.Title
        Else
            SubTitleLabel.Text = ""
        End If

    End Sub

#End Region


End Class
