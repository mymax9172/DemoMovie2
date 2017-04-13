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
    Public Property DemoDate As DateTime
    Public Property CustomerName As String
    Public Property Type As DEMOTYPE
    Public Property RemindMe As Boolean

    Public Property IsCloud As Boolean
    Public Property IsPublished As Boolean
    Public Property IsChanged As Boolean

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
