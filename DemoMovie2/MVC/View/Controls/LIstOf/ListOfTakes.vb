Public Class ListOfTakes

    Public Property Takes As List(Of Take)
    Public Property AllowDelete As Boolean
    Public Property AllowAdd As Boolean

    ''' <summary>
    ''' Refresh all takes (on current scene)
    ''' </summary>
    Public Overrides Sub Refresh()

        Dim movie As DemoMovie = GlobalSettings.This.CurrentMovie
        Dim w As Integer = 120
        Dim h As Integer = 130
        Dim dx As Integer
        Dim dy As Integer
        Dim n As Integer = Takes.Count 'Number of controls = number of takes

        'Clean the panel
        TakesPanel.Controls.Clear()

        'Add 1 control for adding new takes
        If AllowAdd Then n += 1

        'Spacing
        dx = CInt((TakesPanel.Width - n * w) / (n + 1))
        dy = CInt((TakesPanel.Height - h) / 2)
        If dx < (50) Then dx = 50

        'Show controls
        Dim x As Integer = dx
        Dim y As Integer = dy

        Dim defColor As Color = My.Resources.TaskNotStarted.GetPixel(24, 24)

        For Each t As Take In Takes

            Dim ctr As New TakeUserControl
            ctr.Take = t
            ctr.AllowDelete = Me.AllowDelete
            If AllowDelete Then t.Status = [Take].STATUSTAKE.NotStarted

            AddHandler ctr.Click, AddressOf SelectedClick
            AddHandler ctr.Delete, AddressOf DeleteClick

            TakesPanel.Controls.Add(ctr)
            ctr.Refresh()
            ctr.Size = New Size(w, h)
            ctr.Location = New Point(x, y)
            x += (w + dx)
        Next

        For i As Integer = 0 To TakesPanel.Controls.Count - 1
            Dim ctr As TakeUserControl = DirectCast(TakesPanel.Controls(i), TakeUserControl)

            'Set connectors
            If AllowDelete Then
                If i > 0 Then ctr.LeftTakeColor = defColor Else ctr.LeftTakeColor = Nothing
                ctr.RightTakeColor = defColor

            Else
                If i > 0 Then
                    ctr.LeftTakeColor = DirectCast(TakesPanel.Controls(i - 1), TakeUserControl).GetColor
                Else
                    ctr.LeftTakeColor = Nothing
                End If
                If i < (n - 1) Then
                    ctr.RightTakeColor = DirectCast(TakesPanel.Controls(i), TakeUserControl).GetColor
                Else
                    ctr.RightTakeColor = Nothing
                End If
            End If

        Next

        'Add a new control for adding
        If AllowAdd Then

            Dim ctr As New TakeUserControl
            ctr.Take = Nothing

            AddHandler ctr.Click, AddressOf CreateClick
            If n > 1 Then ctr.LeftTakeColor = defColor
            ctr.RightTakeColor = Nothing
            TakesPanel.Controls.Add(ctr)
            ctr.Refresh()
            ctr.Size = New Size(w, h)
            ctr.Location = New Point(x, y)

        End If

        MyBase.Refresh()
        TakesPanel.Invalidate()

    End Sub

    Private Sub TakesPanel_Paint(sender As Object, e As PaintEventArgs) Handles TakesPanel.Paint

        'Check if we are in design time
        If GlobalSettings.This Is Nothing Then Exit Sub

        Dim defColor As Color = My.Resources.TaskNotStarted.GetPixel(24, 24)

        Dim movie As DemoMovie = GlobalSettings.This.CurrentMovie
        Dim n As Integer = Takes.Count

        If AllowAdd Then n += 1

        'Check if more than one take exist
        If n <= 1 Then Exit Sub

        'Add Lines
        Dim g As Graphics = e.Graphics
        g.Clear(Me.BackColor)

        For i As Integer = 0 To n - 2

            'Find start and end points
            Dim c1 As Control = TakesPanel.Controls(i)
            Dim c2 As Control = TakesPanel.Controls(i + 1)
            Dim p1 As New Point(c1.Right, CInt((c1.Top + c1.Height) / 2))
            Dim p2 As New Point(c2.Left, CInt((c2.Top + c2.Height) / 2))
            p1 = DirectCast(c1, TakeUserControl).GetRightNode
            p2 = DirectCast(c2, TakeUserControl).GetLeftNode

            'Draw the line in between - color depends on second control
            Dim c As Color

            c = DirectCast(TakesPanel.Controls(i), TakeUserControl).GetColor
            g.DrawLine(New Pen(c, 5), p1, p2)

        Next

    End Sub


#Region "Events"

    Public Event Selected(sender As Object, e As EventArgs)
    Public Event Delete(sender As Object, e As EventArgs)
    Public Event Create(sender As Object, e As EventArgs)

    Private Sub SelectedClick(sender As Object, e As EventArgs)
        RaiseEvent Selected(sender, e)
    End Sub

    Private Sub DeleteClick(sender As Object, e As EventArgs)
        RaiseEvent Delete(sender, e)
    End Sub

    Private Sub CreateClick(sender As Object, e As EventArgs)
        RaiseEvent Create(Me, e)
    End Sub

#End Region

End Class
