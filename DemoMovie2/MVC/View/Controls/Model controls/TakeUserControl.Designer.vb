<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TakeUserControl
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TakeUserControl))
        Me.TaskImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.ImagePictureBox = New System.Windows.Forms.PictureBox()
        Me.DeletePictureBox = New System.Windows.Forms.PictureBox()
        CType(Me.ImagePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeletePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TaskImageList
        '
        Me.TaskImageList.ImageStream = CType(resources.GetObject("TaskImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.TaskImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.TaskImageList.Images.SetKeyName(0, "TaskNotStarted.png")
        Me.TaskImageList.Images.SetKeyName(1, "TaskOnGoing.png")
        Me.TaskImageList.Images.SetKeyName(2, "TaskCompleted.png")
        Me.TaskImageList.Images.SetKeyName(3, "TaskSelected.png")
        Me.TaskImageList.Images.SetKeyName(4, "TaskAdd.png")
        Me.TaskImageList.Images.SetKeyName(5, "TaskAddSelected.png")
        '
        'TitleLabel
        '
        Me.TitleLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TitleLabel.AutoEllipsis = True
        Me.TitleLabel.Location = New System.Drawing.Point(0, 94)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(164, 45)
        Me.TitleLabel.TabIndex = 1
        Me.TitleLabel.Text = "Label1"
        Me.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ImagePictureBox
        '
        Me.ImagePictureBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ImagePictureBox.Location = New System.Drawing.Point(53, 20)
        Me.ImagePictureBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ImagePictureBox.Name = "ImagePictureBox"
        Me.ImagePictureBox.Size = New System.Drawing.Size(48, 48)
        Me.ImagePictureBox.TabIndex = 2
        Me.ImagePictureBox.TabStop = False
        '
        'DeletePictureBox
        '
        Me.DeletePictureBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DeletePictureBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DeletePictureBox.Image = Global.it.mymax.demomovie2.My.Resources.Resources.full_trash_48
        Me.DeletePictureBox.Location = New System.Drawing.Point(137, 112)
        Me.DeletePictureBox.Name = "DeletePictureBox"
        Me.DeletePictureBox.Size = New System.Drawing.Size(24, 24)
        Me.DeletePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.DeletePictureBox.TabIndex = 8
        Me.DeletePictureBox.TabStop = False
        Me.DeletePictureBox.Visible = False
        '
        'TakeUserControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.DeletePictureBox)
        Me.Controls.Add(Me.ImagePictureBox)
        Me.Controls.Add(Me.TitleLabel)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "TakeUserControl"
        Me.Size = New System.Drawing.Size(164, 139)
        CType(Me.ImagePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeletePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TaskImageList As ImageList
    Friend WithEvents TitleLabel As Label
    Friend WithEvents ImagePictureBox As PictureBox
    Friend WithEvents DeletePictureBox As PictureBox
End Class
