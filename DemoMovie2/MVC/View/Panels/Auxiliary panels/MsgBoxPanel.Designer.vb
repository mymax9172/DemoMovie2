<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MsgBoxPanel
    Inherits SlidingPanel

    'UserControl esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.DescriptionLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'DescriptionLabel
        '
        Me.DescriptionLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DescriptionLabel.AutoEllipsis = True
        Me.DescriptionLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescriptionLabel.Location = New System.Drawing.Point(25, 16)
        Me.DescriptionLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DescriptionLabel.Name = "DescriptionLabel"
        Me.DescriptionLabel.Size = New System.Drawing.Size(441, 71)
        Me.DescriptionLabel.TabIndex = 0
        Me.DescriptionLabel.Text = "Label1"
        Me.DescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MsgBoxPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.DescriptionLabel)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MsgBoxPanel"
        Me.Size = New System.Drawing.Size(502, 200)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DescriptionLabel As Label
End Class
