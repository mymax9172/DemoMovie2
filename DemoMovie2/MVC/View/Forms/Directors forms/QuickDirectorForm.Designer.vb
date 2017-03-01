<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class QuickDirectorForm
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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
        Me.TopPanel = New System.Windows.Forms.Panel()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.LinePictureBox = New System.Windows.Forms.PictureBox()
        Me.ClosePictureBox = New System.Windows.Forms.PictureBox()
        Me.ActorsListUserControl = New it.mymax.demomovie2.ListOfActors()
        Me.TopPanel.SuspendLayout()
        CType(Me.LinePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClosePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TopPanel
        '
        Me.TopPanel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TopPanel.BackgroundImage = Global.it.mymax.demomovie2.My.Resources.Resources.backgroundDM
        Me.TopPanel.Controls.Add(Me.TitleLabel)
        Me.TopPanel.Controls.Add(Me.LinePictureBox)
        Me.TopPanel.Controls.Add(Me.ClosePictureBox)
        Me.TopPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopPanel.Name = "TopPanel"
        Me.TopPanel.Size = New System.Drawing.Size(726, 83)
        Me.TopPanel.TabIndex = 5
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.BackColor = System.Drawing.Color.Transparent
        Me.TitleLabel.Font = New System.Drawing.Font("Segoe UI Black", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLabel.ForeColor = System.Drawing.Color.White
        Me.TitleLabel.Location = New System.Drawing.Point(12, 25)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(144, 30)
        Me.TitleLabel.TabIndex = 8
        Me.TitleLabel.Text = "Demo Movie"
        '
        'LinePictureBox
        '
        Me.LinePictureBox.BackColor = System.Drawing.Color.DarkOrange
        Me.LinePictureBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.LinePictureBox.Location = New System.Drawing.Point(0, 0)
        Me.LinePictureBox.Name = "LinePictureBox"
        Me.LinePictureBox.Size = New System.Drawing.Size(726, 8)
        Me.LinePictureBox.TabIndex = 7
        Me.LinePictureBox.TabStop = False
        '
        'ClosePictureBox
        '
        Me.ClosePictureBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ClosePictureBox.BackColor = System.Drawing.Color.Transparent
        Me.ClosePictureBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ClosePictureBox.Image = Global.it.mymax.demomovie2.My.Resources.Resources.cancel_48
        Me.ClosePictureBox.Location = New System.Drawing.Point(690, 31)
        Me.ClosePictureBox.Name = "ClosePictureBox"
        Me.ClosePictureBox.Size = New System.Drawing.Size(24, 24)
        Me.ClosePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ClosePictureBox.TabIndex = 6
        Me.ClosePictureBox.TabStop = False
        '
        'ActorsListUserControl
        '
        Me.ActorsListUserControl.Actors = Nothing
        Me.ActorsListUserControl.AllowAdd = False
        Me.ActorsListUserControl.AllowDelete = False
        Me.ActorsListUserControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ActorsListUserControl.Location = New System.Drawing.Point(0, 83)
        Me.ActorsListUserControl.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ActorsListUserControl.Name = "ActorsListUserControl"
        Me.ActorsListUserControl.Size = New System.Drawing.Size(726, 300)
        Me.ActorsListUserControl.TabIndex = 6
        '
        'QuickDirectorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(726, 383)
        Me.ControlBox = False
        Me.Controls.Add(Me.ActorsListUserControl)
        Me.Controls.Add(Me.TopPanel)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "QuickDirectorForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.TopMost = True
        Me.TopPanel.ResumeLayout(False)
        Me.TopPanel.PerformLayout()
        CType(Me.LinePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClosePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TopPanel As Panel
    Friend WithEvents LinePictureBox As PictureBox
    Friend WithEvents ClosePictureBox As PictureBox
    Friend WithEvents TitleLabel As Label
    Friend WithEvents ActorsListUserControl As ListOfActors
End Class
