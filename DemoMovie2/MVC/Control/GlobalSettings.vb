Public Class GlobalSettings

#Region "Singleton"

    Public Shared ReadOnly Property This() As GlobalSettings

    ''' <summary>
    ''' Create the single instance
    ''' </summary>
    Public Shared Sub Init()
        _This = New GlobalSettings
    End Sub

#End Region

    Public ReadOnly Property ImageFolder As String
    Public ReadOnly Property DemoMovieFolder As String
    Public ReadOnly Property DemoMovieCloudFolder As String

    Public ReadOnly Property Author As String

    Public Property MainForm As MainForm
    Public Property CurrentMovie As DemoMovie

    Private Sub New()

        'Initialize folders
        Dim appFolder As String = Application.StartupPath
        _ImageFolder = appFolder & "\Images"
        _DemoMovieFolder = appFolder & "\DemoMovies"
        _DemoMovieCloudFolder = appFolder & "\DemoMovies\Public"

        'Retrieve username
        _Author = Environment.UserName

        'Check folders
        CheckFolder(ImageFolder)
        CheckFolder(DemoMovieFolder)
        CheckFolder(DemoMovieCloudFolder)

    End Sub

    ''' <summary>
    ''' Check if the folder exists, if not creates a new folder
    ''' </summary>
    ''' <param name="path">folder path </param>
    Private Sub CheckFolder(path As String)

        If Not IO.Directory.Exists(path) Then
            IO.Directory.CreateDirectory(path)
        End If

    End Sub

    Protected Friend Sub ChangeAuthor(name As String)
        _Author = name
    End Sub

End Class
