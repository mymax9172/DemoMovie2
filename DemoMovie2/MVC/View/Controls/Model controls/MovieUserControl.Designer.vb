<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MovieUserControl
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
        Me.DeletePictureBox = New System.Windows.Forms.PictureBox()
        Me.EditPictureBox = New System.Windows.Forms.PictureBox()
        Me.CustomerLabel = New System.Windows.Forms.Label()
        Me.DateLabel = New System.Windows.Forms.Label()
        CType(Me.DeletePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EditPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TitleLabel
        '
        Me.TitleLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TitleLabel.AutoEllipsis = True
        Me.TitleLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLabel.Location = New System.Drawing.Point(3, 9)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(166, 61)
        Me.TitleLabel.TabIndex = 0
        Me.TitleLabel.Text = "TitleLabel"
        '
        'DeletePictureBox
        '
        Me.DeletePictureBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DeletePictureBox.Image = Global.it.mymax.demomovie2.My.Resources.Resources.full_trash_48
        Me.DeletePictureBox.Location = New System.Drawing.Point(104, 112)
        Me.DeletePictureBox.Name = "DeletePictureBox"
        Me.DeletePictureBox.Size = New System.Drawing.Size(24, 24)
        Me.DeletePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.DeletePictureBox.TabIndex = 6
        Me.DeletePictureBox.TabStop = False
        Me.DeletePictureBox.Visible = False
        '
        'EditPictureBox
        '
        Me.EditPictureBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EditPictureBox.Image = Global.it.mymax.demomovie2.My.Resources.Resources.edit_48
        Me.EditPictureBox.Location = New System.Drawing.Point(134, 112)
        Me.EditPictureBox.Name = "EditPictureBox"
        Me.EditPictureBox.Size = New System.Drawing.Size(24, 24)
        Me.EditPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.EditPictureBox.TabIndex = 5
        Me.EditPictureBox.TabStop = False
        Me.EditPictureBox.Visible = False
        '
        'CustomerLabel
        '
        Me.CustomerLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CustomerLabel.AutoEllipsis = True
        Me.CustomerLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomerLabel.ForeColor = System.Drawing.Color.White
        Me.CustomerLabel.Location = New System.Drawing.Point(3, 70)
        Me.CustomerLabel.Name = "CustomerLabel"
        Me.CustomerLabel.Size = New System.Drawing.Size(166, 39)
        Me.CustomerLabel.TabIndex = 7
        Me.CustomerLabel.Text = "Label1"
        Me.CustomerLabel.Visible = False
        '
        'DateLabel
        '
        Me.DateLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateLabel.AutoEllipsis = True
        Me.DateLabel.AutoSize = True
        Me.DateLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.DateLabel.Location = New System.Drawing.Point(3, 117)
        Me.DateLabel.Name = "DateLabel"
        Me.DateLabel.Size = New System.Drawing.Size(41, 15)
        Me.DateLabel.TabIndex = 8
        Me.DateLabel.Text = "Label1"
        Me.DateLabel.Visible = False
        '
        'MovieUserControl
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.Controls.Add(Me.DateLabel)
        Me.Controls.Add(Me.CustomerLabel)
        Me.Controls.Add(Me.DeletePictureBox)
        Me.Controls.Add(Me.EditPictureBox)
        Me.Controls.Add(Me.TitleLabel)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "MovieUserControl"
        Me.Size = New System.Drawing.Size(172, 151)
        CType(Me.DeletePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EditPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TitleLabel As Label
    Friend WithEvents DeletePictureBox As PictureBox
    Friend WithEvents EditPictureBox As PictureBox
    Friend WithEvents CustomerLabel As Label
    Friend WithEvents DateLabel As Label
End Class
