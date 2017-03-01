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


        'Window UI
        Dim frm As New MainForm
        GlobalSettings.This.MainForm = frm
        PanelController.This.Container = frm.ClientPanel

        Application.Run(frm)

    End Sub

    ''' <summary>
    ''' Initialization
    ''' </summary>
    Shared Sub Init()

        'Initialize GlobalSetting object
        GlobalSettings.Init()

    End Sub

    ''' <summary>
    ''' Program termination
    ''' </summary>
    Shared Sub Quit(sender As Object, e As EventArgs)

        'Add here any final operation
        '...

    End Sub


End Class