<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectMoviePanel
    Inherits SlidingPanel

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
        Me.MoviesFlowLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.AbortButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'MoviesFlowLayoutPanel
        '
        Me.MoviesFlowLayoutPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MoviesFlowLayoutPanel.AutoScroll = True
        Me.MoviesFlowLayoutPanel.BackColor = System.Drawing.Color.White
        Me.MoviesFlowLayoutPanel.Location = New System.Drawing.Point(3, 15)
        Me.MoviesFlowLayoutPanel.Name = "MoviesFlowLayoutPanel"
        Me.MoviesFlowLayoutPanel.Size = New System.Drawing.Size(524, 230)
        Me.MoviesFlowLayoutPanel.TabIndex = 1
        '
        'AbortButton
        '
        Me.AbortButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.AbortButton.BackColor = System.Drawing.SystemColors.Control
        Me.AbortButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AbortButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AbortButton.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AbortButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.AbortButton.Location = New System.Drawing.Point(4, 252)
        Me.AbortButton.Margin = New System.Windows.Forms.Padding(4)
        Me.AbortButton.Name = "AbortButton"
        Me.AbortButton.Size = New System.Drawing.Size(106, 38)
        Me.AbortButton.TabIndex = 12
        Me.AbortButton.Text = "Cancel"
        Me.AbortButton.UseVisualStyleBackColor = False
        '
        'SelectMoviePanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.AbortButton)
        Me.Controls.Add(Me.MoviesFlowLayoutPanel)
        Me.Name = "SelectMoviePanel"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MoviesFlowLayoutPanel As FlowLayoutPanel
    Friend WithEvents AbortButton As Button
End Class
