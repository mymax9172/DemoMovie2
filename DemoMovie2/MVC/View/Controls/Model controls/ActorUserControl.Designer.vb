<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ActorUserControl
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
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.RoleLabel = New System.Windows.Forms.Label()
        Me.DeletePictureBox = New System.Windows.Forms.PictureBox()
        Me.ImagePictureBox = New it.mymax.demomovie2.CircledPicture()
        CType(Me.DeletePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImagePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NameLabel
        '
        Me.NameLabel.AutoEllipsis = True
        Me.NameLabel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.NameLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameLabel.Location = New System.Drawing.Point(0, 84)
        Me.NameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(150, 42)
        Me.NameLabel.TabIndex = 4
        Me.NameLabel.Text = "Label1"
        Me.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RoleLabel
        '
        Me.RoleLabel.AutoEllipsis = True
        Me.RoleLabel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.RoleLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoleLabel.Location = New System.Drawing.Point(0, 126)
        Me.RoleLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.RoleLabel.Name = "RoleLabel"
        Me.RoleLabel.Size = New System.Drawing.Size(150, 24)
        Me.RoleLabel.TabIndex = 3
        Me.RoleLabel.Text = "Label1"
        Me.RoleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DeletePictureBox
        '
        Me.DeletePictureBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DeletePictureBox.Image = Global.it.mymax.demomovie2.My.Resources.Resources.full_trash_48
        Me.DeletePictureBox.Location = New System.Drawing.Point(123, 123)
        Me.DeletePictureBox.Name = "DeletePictureBox"
        Me.DeletePictureBox.Size = New System.Drawing.Size(24, 24)
        Me.DeletePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.DeletePictureBox.TabIndex = 7
        Me.DeletePictureBox.TabStop = False
        Me.DeletePictureBox.Visible = False
        '
        'ImagePictureBox
        '
        Me.ImagePictureBox.Image = Global.it.mymax.demomovie2.My.Resources.Resources.Unknown
        Me.ImagePictureBox.Location = New System.Drawing.Point(34, 3)
        Me.ImagePictureBox.Name = "ImagePictureBox"
        Me.ImagePictureBox.Size = New System.Drawing.Size(80, 80)
        Me.ImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.ImagePictureBox.TabIndex = 5
        Me.ImagePictureBox.TabStop = False
        '
        'ActorUserControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.DeletePictureBox)
        Me.Controls.Add(Me.ImagePictureBox)
        Me.Controls.Add(Me.NameLabel)
        Me.Controls.Add(Me.RoleLabel)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Name = "ActorUserControl"
        CType(Me.DeletePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImagePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents NameLabel As Label
    Friend WithEvents RoleLabel As Label
    Friend WithEvents ImagePictureBox As CircledPicture
    Friend WithEvents DeletePictureBox As PictureBox
End Class
