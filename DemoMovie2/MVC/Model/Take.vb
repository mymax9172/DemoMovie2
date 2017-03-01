<Serializable()>
Public Class Take

    Public Property Title As String
    Public Property Actors As List(Of Actor)
    Public Property Status As STATUSTAKE = STATUSTAKE.NotStarted

    Public Enum STATUSTAKE
        NotStarted = 0
        Started
        Completed
    End Enum

    Public Sub New()
        Actors = New List(Of Actor)
    End Sub

    ''' <summary>
    ''' Short description of the take
    ''' </summary>
    ''' <returns>Title</returns>
    Public Overrides Function ToString() As String

        Return Title

    End Function

End Class
