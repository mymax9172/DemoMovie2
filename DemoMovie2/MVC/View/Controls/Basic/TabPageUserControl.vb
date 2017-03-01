Imports System.ComponentModel

<Serializable()>
Public Class TabPageUserControl

    Public Event TabActivated(sender As Object, e As EventArgs)
    Public Event TabDeactivated(sender As Object, e As EventArgs)

    Public Property ContentType As Type

    Public Sub New()

        ' La chiamata è richiesta dalla finestra di progettazione.
        InitializeComponent()

        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().
        Width = 100
        LinePictureBox.BackColor = DeactiveColor
        LinePictureBox.Visible = True
    End Sub

    <Browsable(True)>
    Public Property Title As String
        Get
            Return TitleLabel.Text
        End Get
        Set(value As String)
            TitleLabel.Text = value
        End Set
    End Property

    <Browsable(True)> Public Property ActiveColor As Color = Color.DeepSkyBlue
    <Browsable(True)> Public Property DeactiveColor As Color = Color.DarkGray

    Private _IsActive As Boolean = False
    Public Property IsActive As Boolean
        Get
            Return _IsActive
        End Get
        Set(value As Boolean)
            If value Then
                LinePictureBox.BackColor = ActiveColor
                TitleLabel.Font = New Font(Me.Font.Name, 12, FontStyle.Bold)

                If Not _IsActive Then OnTabActivated(EventArgs.Empty)
            Else
                LinePictureBox.BackColor = DeactiveColor
                TitleLabel.Font = New Font(Me.Font.Name, 10, FontStyle.Regular)
                If _IsActive Then OnTabDeactivated(EventArgs.Empty)
            End If
            _IsActive = value
            Me.Refresh()
        End Set

    End Property

    Private Sub TitleLabel_Click(sender As Object, e As EventArgs) Handles TitleLabel.Click
        IsActive = True
    End Sub

    Protected Friend Sub OnTabActivated(e As EventArgs)
        RaiseEvent TabActivated(Me, e)
    End Sub

    Protected Friend Sub OnTabDeactivated(e As EventArgs)
        RaiseEvent TabDeactivated(Me, e)
    End Sub

End Class
