''' <summary>
''' Entry point for Windows OS
''' </summary>
Public Class Main

    ''' <summary>
    ''' Entry point for Windows OS
    ''' </summary>
    Shared Sub Main(args As String())

        'Enable visual styles
        Application.EnableVisualStyles()

        'Initialization
        Init()

        'Run application
        AddHandler Application.ApplicationExit, AddressOf Quit

        'Show application
        Dim frm As New MainForm
        GlobalSettings.This.MainForm = frm
        PanelController.This.Container = frm.ClientPanel
        frm.Run()

        'Run windows message loop
        Application.Run(frm)

    End Sub

    ''' <summary>
    ''' Initialization
    ''' </summary>
    Shared Sub Init()

        'Initialize GlobalSetting object
        GlobalSettings.Init()

        'Initialize database
        Database.This.LoadRepository()

    End Sub

    ''' <summary>
    ''' Program termination
    ''' </summary>
    Shared Sub Quit(sender As Object, e As EventArgs)

    End Sub


End Class