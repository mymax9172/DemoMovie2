<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TabPageUserControl
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
        Me.LinePictureBox = New System.Windows.Forms.PictureBox()
        Me.TitleLabel = New System.Windows.Forms.Label()
        CType(Me.LinePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LinePictureBox
        '
        Me.LinePictureBox.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LinePictureBox.Location = New System.Drawing.Point(0, 53)
        Me.LinePictureBox.Name = "LinePictureBox"
        Me.LinePictureBox.Size = New System.Drawing.Size(200, 5)
        Me.LinePictureBox.TabIndex = 1
        Me.LinePictureBox.TabStop = False
        '
        'TitleLabel
        '
        Me.TitleLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TitleLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLabel.Location = New System.Drawing.Point(0, 0)
        Me.TitleLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(200, 53)
        Me.TitleLabel.TabIndex = 2
        Me.TitleLabel.Text = "Label1"
        Me.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TabPageUserControl
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.Controls.Add(Me.TitleLabel)
        Me.Controls.Add(Me.LinePictureBox)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "TabPageUserControl"
        Me.Size = New System.Drawing.Size(200, 58)
        CType(Me.LinePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LinePictureBox As PictureBox
    Friend WithEvents TitleLabel As Label
End Class
