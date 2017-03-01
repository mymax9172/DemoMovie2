Public Class MainPanel

    Protected Friend Overrides Sub OnShowed(e As EventArgs)
        MyBase.OnShowed(e)

        RefreshList()

    End Sub

    'Load all items
    Public Sub RefreshList()

        'Remove all controls
        MoviesFlowLayoutPanel.Controls.Clear()

        'Load all demo movies
        Dim items As List(Of DemoMovie) = DemoMovie.GetAll()
        Dim odd As Boolean = True

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
            DemoMovie.Delete(movie)

            RefreshList()
        End If

    End Sub

#End Region

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

    Private Sub PlayMovie(sender As Object, e As EventArgs)

        Dim item As MovieUserControl = DirectCast(sender, MovieUserControl)
        Dim movie As DemoMovie = item.CurrentItem

        'Store the current movie
        GlobalSettings.This.CurrentMovie = movie

        Select Case movie.Type
            Case DemoMovie.DEMOTYPE.Quick
                Dim frm As New QuickDirectorForm
                frm.Run()
            Case DemoMovie.DEMOTYPE.Simple
                Dim frm As New SimpleDirectorForm
                frm.Run()
            Case DemoMovie.DEMOTYPE.Full
                Dim frm As New FullDirectorForm
                frm.Run()
        End Select

        GlobalSettings.This.MainForm.WindowState = FormWindowState.Minimized

    End Sub
End Class
