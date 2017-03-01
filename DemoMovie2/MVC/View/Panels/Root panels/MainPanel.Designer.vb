<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainPanel
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
        Me.MoviesFlowLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'MoviesFlowLayoutPanel
        '
        Me.MoviesFlowLayoutPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MoviesFlowLayoutPanel.AutoScroll = True
        Me.MoviesFlowLayoutPanel.BackColor = System.Drawing.Color.White
        Me.MoviesFlowLayoutPanel.Location = New System.Drawing.Point(3, 56)
        Me.MoviesFlowLayoutPanel.Name = "MoviesFlowLayoutPanel"
        Me.MoviesFlowLayoutPanel.Size = New System.Drawing.Size(563, 486)
        Me.MoviesFlowLayoutPanel.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(9, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(522, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Click on one of these demo movies to play it. Click on plus icon to add a brand n" &
    "ew one"
        '
        'MainPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = False
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MoviesFlowLayoutPanel)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "MainPanel"
        Me.Size = New System.Drawing.Size(569, 545)
        Me.Title = "Manage your demo movies"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MoviesFlowLayoutPanel As FlowLayoutPanel
    Friend WithEvents Label1 As Label
End Class
