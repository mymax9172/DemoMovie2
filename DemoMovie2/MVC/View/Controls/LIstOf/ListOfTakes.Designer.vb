<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListOfTakes
    Inherits System.Windows.Forms.UserControl

    'UserControl esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TakesPanel = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'TakesPanel
        '
        Me.TakesPanel.AutoScroll = True
        Me.TakesPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TakesPanel.Location = New System.Drawing.Point(0, 0)
        Me.TakesPanel.Name = "TakesPanel"
        Me.TakesPanel.Size = New System.Drawing.Size(660, 307)
        Me.TakesPanel.TabIndex = 1
        '
        'ListOfTakes
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.Controls.Add(Me.TakesPanel)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "ListOfTakes"
        Me.Size = New System.Drawing.Size(660, 307)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TakesPanel As Panel
End Class
