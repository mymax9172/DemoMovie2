Public Class MainForm

#Region "Movable"

    Private MouseDownLocation As Point

    Public Sub Run()

        If My.Settings.UseSystemTray Then

            'Popup notify icon
            RefreshMenuItems()

        End If

    End Sub

#Region "Notify Icon"

    Private Sub RefreshMenuItems()
        'Clear current item
        NotifyMenuItem.Items.Clear()

        'Add static menu items
        AddMenu("&Open", AddressOf OpenApplication)
        AddMenu("&Exit", AddressOf ExitApplication)

        'Add movies
        Dim movies As List(Of DemoMovie) = Database.This.LocalMovies
        If movies.Count > 0 Then

            AddMenu("-", Nothing)

            For Each movie In movies
                AddMovie(movie.Title, AddressOf PlayMovie, movie)
            Next

        End If

    End Sub

    Private Sub AddMenu(text As String, callback As EventHandler)
        Dim item As New ToolStripMenuItem With {.Text = text}
        If callback IsNot Nothing Then AddHandler item.Click, callback
        NotifyMenuItem.Items.Add(item)
    End Sub

    Private Sub AddMovie(text As String, callback As EventHandler, movie As DemoMovie)
        Dim item As New ToolStripMenuItem With {.Text = text}
        If callback IsNot Nothing Then AddHandler item.Click, callback
        item.Tag = movie
        item.Image = My.Resources.film_reel_48
        NotifyMenuItem.Items.Add(item)
    End Sub

    Private Sub ExitApplication(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub OpenApplication(sender As Object, e As EventArgs)
        Me.Show()
    End Sub

    Private Sub PlayMovie(sender As Object, e As EventArgs)

        Dim item As ToolStripMenuItem = DirectCast(sender, ToolStripMenuItem)
        Dim movie As DemoMovie = DirectCast(item.Tag, DemoMovie)

        'Store the current movie
        GlobalSettings.This.CurrentMovie = movie

        'Check if a project is available
        If Screen.AllScreens.Count > 1 Then

            'Request confirmation to use it
            Dim qst As String = "A projector has been detected." & vbCrLf & vbCrLf & "Do you want to project director/stage forms there?"
            Dim result As MsgBoxResult = MsgBox(qst, MsgBoxStyle.YesNo, "Projector detected")
            If result = MsgBoxResult.Yes Then
                PlayOnThisScreen(Screen.AllScreens(1))
            Else
                PlayOnThisScreen(Screen.PrimaryScreen)
            End If
        Else
            PlayOnThisScreen(Screen.PrimaryScreen)
        End If

    End Sub

    Private Sub PlayOnThisScreen(s As Screen)

        Dim movie As DemoMovie = GlobalSettings.This.CurrentMovie
        GlobalSettings.This.UseThisScreen = s

        Select Case movie.Type
            Case DemoMovie.DEMOTYPE.Quick
                'Check if some actors are defined
                If movie.Actors.Count = 0 Then Exit Sub

                Dim frm As New QuickDirectorForm
                frm.Run()

            Case DemoMovie.DEMOTYPE.Simple
                'Check if one take is defined
                If movie.GetDummyScene.Takes.Count = 0 Then Exit Sub

                Dim frm As New SimpleDirectorForm
                frm.Run()
            Case DemoMovie.DEMOTYPE.Full
                'Check if a scene is defined
                If movie.Scenes.Count = 0 Then Exit Sub

                Dim frm As New FullDirectorForm
                frm.Run()
        End Select

        GlobalSettings.This.MainForm.Hide()

    End Sub

#End Region

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

        'Save repository
        Database.This.SaveRepository()

        'Check if system tray must be used
        If My.Settings.UseSystemTray Then
            'Hide the window
            Me.Hide()

            'Show the tip
            Me.DemoMovieNotifyIcon.ShowBalloonTip(2000, "DemoMovie 2", "DemoMovie is still running", ToolTipIcon.Info)
        Else
            Me.Close()
        End If

    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'System tray
        Me.DemoMovieNotifyIcon.Visible = My.Settings.UseSystemTray

        'Register to the events
        AddHandler PanelController.This.PanelChanged, AddressOf PanelChanged
        AddHandler PanelController.This.TitleChanged, AddressOf PanelChanged

        VersionLabel.Text = Application.ProductVersion
        AuthorLabel.Text = GlobalSettings.This.Author

        'Size to the middle of the screen
        Width = CInt(Screen.PrimaryScreen.WorkingArea.Width / 3 * 2)
        Height = CInt(Screen.PrimaryScreen.WorkingArea.Height / 3 * 2)
        Left = CInt(Width / 4)
        Top = CInt(Height / 4)

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

    Private Sub TopPanel_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles TopPanel.MouseDoubleClick
        If WindowState = FormWindowState.Maximized Then WindowState = FormWindowState.Normal Else WindowState = FormWindowState.Maximized
    End Sub

    Private Sub DemoMovieNotifyIcon_Click(sender As Object, e As EventArgs) Handles DemoMovieNotifyIcon.Click
        RefreshMenuItems()
    End Sub

    Private Sub DemoMovieNotifyIcon_DoubleClick(sender As Object, e As EventArgs) Handles DemoMovieNotifyIcon.DoubleClick
        OpenApplication(sender, e)
    End Sub

    Private Sub NotifyMenuItem_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles NotifyMenuItem.Opening

    End Sub

    Private Sub SettingLabel_Click(sender As Object, e As EventArgs) Handles SettingLabel.Click
        'Show the settings panel
        Dim pnl As New SettingsPanel
        pnl.Run()
    End Sub

#End Region


End Class
