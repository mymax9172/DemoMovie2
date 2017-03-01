Public Class MsgBoxPanel

    Public ReadOnly Property Result As MsgBoxResult
    Private Property Buttons As New List(Of Button)

    Public Sub Run(Title As String, Description As String, Style As MsgBoxStyle)
        Me.Title = Title
        DescriptionLabel.Text = Description

        If Style And MsgBoxStyle.Information Then
            AddButton("OK", Color.DeepSkyBlue, Color.White, MsgBoxResult.Ok)
            BackColor = Color.WhiteSmoke
        End If

        If Style And MsgBoxStyle.YesNo Then
            AddButton("Yes", Color.DeepSkyBlue, Color.White, MsgBoxResult.Yes)
            AddButton("No", Color.DarkGray, Color.Black, MsgBoxResult.No)
            BackColor = Color.WhiteSmoke
        End If

        If Style And MsgBoxStyle.YesNoCancel Then
            AddButton("Yes", Color.DeepSkyBlue, Color.White, MsgBoxResult.Yes)
            AddButton("No", Color.DarkGray, Color.Black, MsgBoxResult.No)
            AddButton("Cancel", Color.DarkGray, Color.Black, MsgBoxResult.Cancel)
            BackColor = Color.WhiteSmoke
        End If

        'Arrange size
        Dim space As Integer = CInt((Me.Width - (Buttons.Count) * 100) / (Buttons.Count + 1))
        Dim dy As Integer = Me.Height - 50 - 10
        Dim dx As Integer = space
        For Each btn As Button In Buttons
            btn.Location = New Point(dx, dy)
            dx += btn.Width + space
        Next

        PanelController.This.Show(Me, True)

    End Sub

    Private Sub AddButton(text As String, backColor As Color, foreColor As Color, result As MsgBoxResult)

        Dim btn As New Button
        With btn
            .FlatStyle = FlatStyle.Flat
            .BackColor = backColor
            .ForeColor = foreColor
            .Text = text
            .Tag = result
            .Visible = True
            .Cursor = Cursors.Hand
            .Size = New Size(100, 50)
        End With

        AddHandler btn.Click, AddressOf ButtonClick
        Buttons.Add(btn)
        Me.Controls.Add(btn)

    End Sub

    Private Sub ButtonClick(sender As Object, e As EventArgs)
        Dim btn As Button = DirectCast(sender, Button)
        _Result = CType(btn.Tag, MsgBoxResult)
        PanelController.This.Close()
    End Sub

End Class
