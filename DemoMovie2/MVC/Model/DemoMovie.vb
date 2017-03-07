Imports System.Runtime.Serialization
Imports System.Runtime.Serialization.Formatters.Binary

<Serializable()>
Public Class DemoMovie

    <Serializable()>
    Public Enum DEMOTYPE
        Quick = 0
        Simple
        Full
    End Enum

    Public Property Title As String
    Public Property DemoDate As Date
    Public Property CustomerName As String
    Public Property Type As DEMOTYPE

    Public Property IsCloud As Boolean
    Public Property IsPublished As Boolean

    Public Author As String

    Public Property Actors As List(Of Actor)
    Public Property Scenes As List(Of Scene)

    Protected Friend Property Filename As String

    Public Sub New()
        Scenes = New List(Of Scene)
        Actors = New List(Of Actor)
    End Sub

    ''' <summary>
    ''' Short description of the demo movie
    ''' </summary>
    ''' <returns>Title and date</returns>
    Public Overrides Function ToString() As String

        Return Title & " (" & DemoDate.ToShortDateString & ")"

    End Function

    Public Shared Sub Save(this As DemoMovie)

        'Check filename
        If this.Filename = "" Then
            'First time saving, create a unique name
            this.Filename = GlobalSettings.This.Author & "-" & IO.Path.GetRandomFileName() & ".dm"
        End If

        'Serialize
        Dim stream As New IO.FileStream(GlobalSettings.This.DemoMovieFolder & "\" & this.Filename, IO.FileMode.Create)
        Dim formatter As New BinaryFormatter
        formatter.Serialize(stream, this)
        stream.Close()

    End Sub

    Public Shared Function Load(filename As String) As DemoMovie

        'Check filename
        If Not IO.File.Exists(filename) Then
            Return Nothing
        End If

        'DeSerialize
        Dim stream As New IO.FileStream(filename, IO.FileMode.Open)
        Dim formatter As New BinaryFormatter
        Dim this As Object = formatter.Deserialize(stream)
        stream.Close()

        If this IsNot Nothing Then Return DirectCast(this, DemoMovie) Else Return Nothing

    End Function

    Public Shared Sub Delete(ByRef this As DemoMovie)

        'Check filename
        If Not IO.File.Exists(GlobalSettings.This.DemoMovieFolder & "\" & this.Filename) Then Exit Sub

        'Deletion
        IO.File.Delete(GlobalSettings.This.DemoMovieFolder & "\" & this.Filename)
        this = Nothing

    End Sub

    Public Shared Sub DeleteTempFile(filename As String)

        'Check filename
        If Not IO.File.Exists(filename) Then Exit Sub

        'Deletion
        IO.File.Delete(filename)

    End Sub

    ''' <summary>
    ''' Load all demomovies
    ''' </summary>
    ''' <returns>List of all demo movies stored</returns>
    Public Shared Function GetAll(Optional local As Boolean = True) As List(Of DemoMovie)

        Dim path As String
        If local Then
            path = GlobalSettings.This.DemoMovieFolder
        Else
            path = GlobalSettings.This.DemoMovieCloudFolder
        End If

        Dim filename As String = Dir(path & "\*.dm", FileAttribute.Normal)
        Dim items As New List(Of DemoMovie)

        Do While filename <> ""
            Dim item As DemoMovie = DemoMovie.Load(path & "\" & filename)
            If Not local Then item.IsCloud = True
            If item IsNot Nothing Then items.Add(item)
            filename = Dir()
        Loop

        Return items

    End Function

    Public Function GetDummyScene() As Scene
        Return Scenes(0)
    End Function

    Public Sub RemoveActor(a As Actor)

        'Remove actor from the cast
        Actors.Remove(a)

        'Remove actor from any takes or scenes (for type Simple or Full)
        For Each s As Scene In Scenes
            For Each t As Take In s.Takes
                If t.Actors.Contains(a) Then t.Actors.Remove(a)
            Next
        Next

    End Sub

End Class
