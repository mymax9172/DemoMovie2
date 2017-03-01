<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SceneUserControl
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
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.TakesFlowLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.DeletePictureBox = New System.Windows.Forms.PictureBox()
        CType(Me.DeletePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoEllipsis = True
        Me.TitleLabel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TitleLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLabel.Location = New System.Drawing.Point(0, 0)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(182, 108)
        Me.TitleLabel.TabIndex = 1
        Me.TitleLabel.Text = "TitleLabel"
        Me.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TakesFlowLayoutPanel
        '
        Me.TakesFlowLayoutPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TakesFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.TakesFlowLayoutPanel.Location = New System.Drawing.Point(0, 108)
        Me.TakesFlowLayoutPanel.Name = "TakesFlowLayoutPanel"
        Me.TakesFlowLayoutPanel.Size = New System.Drawing.Size(147, 43)
        Me.TakesFlowLayoutPanel.TabIndex = 2
        '
        'DeletePictureBox
        '
        Me.DeletePictureBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DeletePictureBox.Image = Global.it.mymax.demomovie2.My.Resources.Resources.full_trash_48
        Me.DeletePictureBox.Location = New System.Drawing.Point(152, 114)
        Me.DeletePictureBox.Name = "DeletePictureBox"
        Me.DeletePictureBox.Size = New System.Drawing.Size(24, 24)
        Me.DeletePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.DeletePictureBox.TabIndex = 7
        Me.DeletePictureBox.TabStop = False
        Me.DeletePictureBox.Visible = False
        '
        'SceneUserControl
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.Controls.Add(Me.DeletePictureBox)
        Me.Controls.Add(Me.TakesFlowLayoutPanel)
        Me.Controls.Add(Me.TitleLabel)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Name = "SceneUserControl"
        Me.Size = New System.Drawing.Size(182, 151)
        CType(Me.DeletePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TitleLabel As Label
    Friend WithEvents TakesFlowLayoutPanel As FlowLayoutPanel
    Friend WithEvents DeletePictureBox As PictureBox
End Class
