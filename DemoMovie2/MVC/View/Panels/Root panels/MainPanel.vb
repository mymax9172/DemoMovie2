Public Class MainPanel

    Protected Friend Overrides Sub OnShowed(e As EventArgs)
        MyBase.OnShowed(e)

        RefreshList()
        AddHandler ReminderManager.This.Alert, AddressOf Alert

    End Sub

    Public Overrides Sub Refresh()
        MyBase.Refresh()
        RefreshList()
    End Sub

    'Load all items
    Public Sub RefreshList()

        'Remove all controls
        MoviesFlowLayoutPanel.Controls.Clear()

        'Load all demo movies
        Dim items As List(Of DemoMovie) = Database.This.LocalMovies

        For Each item As DemoMovie In items
            Dim uc As New MovieUserControl
            uc.CurrentItem = item
            uc.Visible = True
            uc.AllowDelete = True
            uc.AllowEdit = True
            uc.Size = New Size(150, 150)

            AddHandler uc.Edit, AddressOf EditMovie_Begin
            AddHandler uc.Delete, AddressOf DeleteMovie_Begin
            AddHandler uc.Click, AddressOf PlayMovie

            MoviesFlowLayoutPanel.Controls.Add(uc)

        Next

        'Start reminder
        ReminderManager.This.RefreshReminders(items)

        'Check if cloud is allowed
        If My.Settings.UseCloud Then

            'Show downloaded movies
            items = Database.This.CloudMovies

            For Each item As DemoMovie In items
                Dim uc As New MovieUserControl
                uc.CurrentItem = item
                uc.Visible = True
                uc.Size = New Size(150, 150)

                AddHandler uc.Download, AddressOf DownloadMovie
                AddHandler uc.Delete, AddressOf DeleteCloudMovie_Begin

                MoviesFlowLayoutPanel.Controls.Add(uc)
            Next


            'Insert the Cloud button (to download/refresh)
            Dim cloudItem As New CloudUserControl
            cloudItem.Visible = True
            cloudItem.BackColor = Color.WhiteSmoke
            cloudItem.BorderStyle = System.Windows.Forms.BorderStyle.None
            cloudItem.Size = New Size(150, 150)
            AddHandler cloudItem.Click, AddressOf DownloadCloudMovies
            MoviesFlowLayoutPanel.Controls.Add(cloudItem)

            'Adjust size
            MoviesFlowLayoutPanel.Controls(MoviesFlowLayoutPanel.Controls.Count - 1).Size = New Size(150, 150)

        End If

        'Insert the Add button
        Dim addItem As New AddUserControl
        addItem.Visible = True
        addItem.BackColor = Color.WhiteSmoke
        addItem.BorderStyle = System.Windows.Forms.BorderStyle.None
        addItem.Size = New Size(150, 150)
        AddHandler addItem.Click, AddressOf CreateMovie_Begin
        MoviesFlowLayoutPanel.Controls.Add(addItem)

        'Adjust size
        MoviesFlowLayoutPanel.Controls(MoviesFlowLayoutPanel.Controls.Count - 1).Size = New Size(150, 150)

    End Sub

    Private Sub MainPanel_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize

        If Owner Is Nothing Then Exit Sub

        MoviesFlowLayoutPanel.Width = Owner.ClientSize.Width - 10
        MoviesFlowLayoutPanel.Height = Owner.ClientRectangle.Height - 50

    End Sub

    Private Sub Alert(sender As Object, e As EventArgs)

        Dim r As Reminder = DirectCast(sender, Reminder)

        GlobalSettings.This.MainForm.DemoMovieNotifyIcon.ShowBalloonTip(3000, "DemoMovie2 - Alert", r.Movie.Title & " is planned ", ToolTipIcon.Info)

    End Sub

#Region "Creation"

    'Open the create movie panel
    Public Sub CreateMovie_Begin(sender As Object, e As EventArgs)

        Dim pnl As New CreateMoviePanel
        PanelController.This.Show(pnl, True)
        AddHandler pnl.MovieCreated, AddressOf CreateMovie_End

    End Sub

    'After creation, update refresh list
    Private Sub CreateMovie_End(sender As Object, e As EventArgs)

        Dim pnl As CreateMoviePanel = DirectCast(sender, CreateMoviePanel)
        RemoveHandler pnl.MovieCreated, AddressOf CreateMovie_End

        RefreshList()

    End Sub

#End Region

#Region "Delete"

    Private Sub DeleteMovie_Begin(sender As Object, e As EventArgs)

        Dim pnl As New MsgBoxPanel
        Dim item As MovieUserControl = DirectCast(sender, MovieUserControl)
        Dim qst As String = "Are you sure to permanently remove this movie?" & vbCrLf & vbCrLf & "Movie to delete: {0}"

        pnl.Run("Delete a movie file", String.Format(qst, item.CurrentItem.Title), MsgBoxStyle.YesNo)
        pnl.Tag = item.CurrentItem

        AddHandler pnl.Closed, AddressOf DeleteMovie_End

    End Sub

    Private Sub DeleteMovie_End(sender As Object, e As EventArgs)

        Dim pnl As MsgBoxPanel = DirectCast(sender, MsgBoxPanel)
        RemoveHandler pnl.Closed, AddressOf CreateMovie_End

        If pnl.Result = MsgBoxResult.Yes Then
            Dim movie As DemoMovie = DirectCast(pnl.Tag, DemoMovie)
            Database.This.LocalMovies.Remove(movie)

            RefreshList()
        End If

    End Sub


#End Region

#Region "Edit"

    Private Sub EditMovie_Begin(sender As Object, e As EventArgs)

        Dim pnl As New EditMoviePanel
        Dim item As MovieUserControl = DirectCast(sender, MovieUserControl)

        'Store the movie
        GlobalSettings.This.CurrentMovie = item.CurrentItem

        pnl.Run()
        AddHandler pnl.Closed, AddressOf EditMovie_End

    End Sub

    Private Sub EditMovie_End(sender As Object, e As EventArgs)

        Dim pnl As EditMoviePanel = DirectCast(sender, EditMoviePanel)
        RemoveHandler pnl.Closed, AddressOf EditMovie_End

        'Clear the current movie
        GlobalSettings.This.CurrentMovie = Nothing

        'Refresh the list
        RefreshList()

    End Sub

#End Region

#Region "Public cloud "

    Private Sub DownloadCloudMovies(sender As Object, e As EventArgs)

        Cursor = Cursors.WaitCursor

        'Establish a connection
        If PublicServer.This.IsConnected Then

            PublicServer.This.GetAllPublicMovies()

        End If

        Cursor = Cursors.Default
        Me.RefreshList()

    End Sub

    Private Sub DownloadMovie(sender As Object, e As EventArgs)

        Dim item As MovieUserControl = DirectCast(sender, MovieUserControl)
        Dim movie As DemoMovie = item.CurrentItem
        Dim tempFilename As String = movie.Filename

        Cursor = Cursors.WaitCursor

        'Download pictures of this movie
        PublicServer.This.DownloadPublicFaces(movie)

        'Remove the movie from cloud folder and repository
        PublicServer.DeleteTempFile(GlobalSettings.This.DemoMovieCloudFolder & "\" & tempFilename)
        Database.This.CloudMovies.Remove(movie)

        'Copy the movie as a new one
        movie.Filename = ""
        movie.Title = "Copy of " & movie.Title
        movie.Author = GlobalSettings.This.Author
        movie.IsCloud = False
        movie.IsPublished = False
        Database.This.LocalMovies.Add(movie)

        Cursor = Cursors.Default

        'Refresh the list
        Me.RefreshList()

    End Sub


    Private Sub DeleteCloudMovie_Begin(sender As Object, e As EventArgs)

        Dim pnl As New MsgBoxPanel
        Dim item As MovieUserControl = DirectCast(sender, MovieUserControl)
        Dim qst As String = "Are you sure to remove this movie from the Cloud?" & vbCrLf & vbCrLf & "Movie to remove: {0}"

        pnl.Run("Remove (unpublish) a movie file", String.Format(qst, item.CurrentItem.Title), MsgBoxStyle.YesNo)
        pnl.Tag = item

        AddHandler pnl.Closed, AddressOf DeleteCloudMovie_End

    End Sub

    Private Sub DeleteCloudMovie_End(sender As Object, e As EventArgs)

        Dim pnl As MsgBoxPanel = DirectCast(sender, MsgBoxPanel)
        RemoveHandler pnl.Closed, AddressOf CreateMovie_End

        If pnl.Result = MsgBoxResult.Yes Then
            Dim item As MovieUserControl = DirectCast(pnl.Tag, MovieUserControl)
            Dim movie As DemoMovie = item.CurrentItem
            PublicServer.This.UnPublish(movie)

            'Remove automatically this control
            MoviesFlowLayoutPanel.Controls.Remove(item)

            RefreshList()
        End If

    End Sub

#End Region

#Region "Playing"


    Private Sub PlayMovie(sender As Object, e As EventArgs)

        Dim item As MovieUserControl = DirectCast(sender, MovieUserControl)
        Dim movie As DemoMovie = item.CurrentItem

        'Store the current movie
        GlobalSettings.This.CurrentMovie = movie

        'Check if a project is available
        If Screen.AllScreens.Count > 1 AndAlso My.Settings.AutoDetect Then

            If My.Settings.AskConfirmation Then
                'Request confirmation to use it
                Dim pnl As New MsgBoxPanel
                Dim qst As String = "A projector has been detected." & vbCrLf & vbCrLf & "Do you want to project director/stage forms there?"
                pnl.Run("Projector detected", qst, MsgBoxStyle.YesNo)

                AddHandler pnl.Closed, AddressOf PlayMovie_End
            Else
                PlayOnThisScreen(Screen.AllScreens(1))
            End If
        Else
            PlayOnThisScreen(Screen.PrimaryScreen)
        End If

    End Sub

    Private Sub PlayMovie_End(sender As Object, e As EventArgs)

        Dim pnl As MsgBoxPanel = DirectCast(sender, MsgBoxPanel)
        RemoveHandler pnl.Closed, AddressOf PlayMovie_End

        If pnl.Result = MsgBoxResult.Yes Then
            PlayOnThisScreen(Screen.AllScreens(1))

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

End Class
