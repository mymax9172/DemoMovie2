Public Class EditMoviePanel

    Private CurrentItem As DemoMovie

    Public Sub Run()

        CurrentItem = GlobalSettings.This.CurrentMovie

        Dim genTP As TabPageUserControl = CreateTabPage("General", New Size(100, 50), New Point(5, 5), GetType(GeneralTabPanel))

        Select Case CurrentItem.Type

            Case DemoMovie.DEMOTYPE.Quick
                CreateTabPage("Cast", New Size(100, 50), New Point(107, 5), GetType(ActorsTabPanel))

            Case DemoMovie.DEMOTYPE.Simple
                CreateTabPage("Cast", New Size(100, 50), New Point(107, 5), GetType(ActorsTabPanel))
                CreateTabPage("Takes", New Size(100, 50), New Point(209, 5), GetType(TakesTabPanel))

            Case DemoMovie.DEMOTYPE.Full
                CreateTabPage("Cast", New Size(100, 50), New Point(107, 5), GetType(ActorsTabPanel))
                CreateTabPage("Scenes", New Size(100, 50), New Point(209, 5), GetType(ScenesTabPanel))

        End Select
        genTP.IsActive = True

        If CurrentItem.IsPublished AndAlso My.Settings.UseCloud Then
            SaveButton.Text = "Save && Publish"
            PublishButton.Visible = False
        Else
            SaveButton.Text = "Save"
            PublishButton.Visible = My.Settings.UseCloud
        End If

        Title = "Edit a demo movie: " & CurrentItem.Title

        PanelController.This.Show(Me)

    End Sub

    Private Function CreateTabPage(title As String, size As Size, location As Point, contentType As Type) As TabPageUserControl
        Dim tabPage As New TabPageUserControl
        With tabPage
            .Title = title
            .Size = size
            .Location = location
            .ContentType = contentType
        End With
        TabsPanel.Controls.Add(tabPage)
        AddHandler tabPage.TabActivated, AddressOf TabActivated
        AddHandler tabPage.TabDeactivated, AddressOf TabDeactivated

        Return tabPage
    End Function

    Private Sub TabActivated(sender As Object, e As EventArgs)
        For Each item As Control In TabsPanel.Controls
            If item IsNot sender Then
                DirectCast(item, TabPageUserControl).IsActive = False
            End If
        Next

        'Show the active panel
        Dim tabPage As TabPageUserControl = DirectCast(sender, TabPageUserControl)
        Dim pnl As SlidingPanel = Activator.CreateInstance(tabPage.ContentType)
        If pnl IsNot Nothing Then
            pnl.ParentPanel = Me
            pnl.AddParent(TabPagesPanel, False)
            pnl.Swipe(True)
        End If

    End Sub

    Private Sub TabDeactivated(sender As Object, e As EventArgs)

        'Hide the current panel
        Dim tabPage As TabPageUserControl = DirectCast(sender, TabPageUserControl)
        Dim pnl As SlidingPanel = DirectCast(TabPagesPanel.Controls(0), SlidingPanel)
        If pnl IsNot Nothing Then pnl.Swipe(False, 200)

    End Sub


#Region "Abort button"

    Private Sub AbortButton_Begin(sender As Object, e As EventArgs) Handles AbortButton.Click

        Dim pnl As New MsgBoxPanel
        pnl.Run("Cancel editing", "Are you sure you want to discard any change you made ?", MsgBoxStyle.YesNo)
        AddHandler pnl.Closed, AddressOf AbortButton_End
    End Sub

    Private Sub AbortButton_End(sender As Object, e As EventArgs)

        Dim pnl As MsgBoxPanel = DirectCast(sender, MsgBoxPanel)
        RemoveHandler pnl.Closed, AddressOf AbortButton_End
        If pnl.Result = MsgBoxResult.Yes Then
            PanelController.This.Close()
        End If

    End Sub

#End Region

    Private Function Save() As Boolean

        Cursor = Cursors.WaitCursor

        'Control fields
        If CurrentItem.Title = "" Then Return False
        If CurrentItem.DemoDate = Nothing Then Return False
        If CurrentItem.CustomerName = "" Then Return False
        If CurrentItem.Author = "" Then CurrentItem.Author = GlobalSettings.This.Author
        CurrentItem.IsChanged = True

        Cursor = Cursors.Default
        PanelController.This.Close()

        Return True

    End Function

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click

        If Not Save() Then
            Dim pnl As New MsgBoxPanel
            pnl.Run("Save failed", "Some mandatory fields are missing, please review", MsgBoxStyle.Information)
        End If

    End Sub

    Private Sub PublishButton_Click(sender As Object, e As EventArgs) Handles PublishButton.Click

        CurrentItem.IsPublished = True
        SaveButton_Click(Me, EventArgs.Empty)

    End Sub
End Class

