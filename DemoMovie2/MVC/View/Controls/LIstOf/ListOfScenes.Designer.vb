<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListOfScenes
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
        Me.ScenesFlowLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.SuspendLayout()
        '
        'ScenesFlowLayoutPanel
        '
        Me.ScenesFlowLayoutPanel.AutoScroll = True
        Me.ScenesFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ScenesFlowLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.ScenesFlowLayoutPanel.Name = "ScenesFlowLayoutPanel"
        Me.ScenesFlowLayoutPanel.Size = New System.Drawing.Size(571, 291)
        Me.ScenesFlowLayoutPanel.TabIndex = 5
        '
        'ListOfScenes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ScenesFlowLayoutPanel)
        Me.Name = "ListOfScenes"
        Me.Size = New System.Drawing.Size(571, 291)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ScenesFlowLayoutPanel As FlowLayoutPanel
End Class
