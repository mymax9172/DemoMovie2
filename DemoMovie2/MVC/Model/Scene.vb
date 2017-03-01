<Serializable()>
Public Class Scene

    Public Property Title As String
    Public Property Description As String
    Public Property Takes As List(Of Take)

    Public Sub New()
        Takes = New List(Of Take)
    End Sub

    ''' <summary>
    ''' Short description of the scene
    ''' </summary>
    ''' <returns>Title</returns>
    Public Overrides Function ToString() As String

        Return Title

    End Function
End Class
