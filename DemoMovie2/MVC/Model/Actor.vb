<Serializable()>
Public Class Actor

    Public Property Name As String
    Public Property Role As String
    Public Property ImageName As String

    ''' <summary>
    ''' Provide a bitmap for the role
    ''' </summary>
    ''' <returns></returns>
    Public Function GetImage() As Bitmap

        Dim path As String = GlobalSettings.This.ImageFolder & "\" & ImageName
        If IO.File.Exists(path) Then
            Return New Bitmap(path)
        Else
            Return My.Resources.Unknown
        End If


    End Function

    ''' <summary>
    ''' Short version of the actor description
    ''' </summary>
    ''' <returns>Name and role</returns>
    Public Overrides Function ToString() As String

        Return Name & " (" & Role & ")"

    End Function

    Public Function Clone() As Actor
        Return Me.MemberwiseClone()
    End Function

End Class
