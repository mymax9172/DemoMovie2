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

    Public Property UseThisScreen As Screen

    Public Property SnoozeTime As Integer = 5
    Public Property RemindBefore As Integer = 15

    Private Sub New()

        'Initialize folders - Starting from myDocuments
        Dim appFolder As String = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\DemoMovie2"

        _ImageFolder = appFolder & "\Images"
        _DemoMovieFolder = appFolder & "\LocalMovies"
        _DemoMovieCloudFolder = appFolder & "\PublicMovies"

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
