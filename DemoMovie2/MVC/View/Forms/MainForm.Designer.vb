<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.ClientPanel = New System.Windows.Forms.Panel()
        Me.TopPanel = New System.Windows.Forms.Panel()
        Me.AuthorLabel = New System.Windows.Forms.Label()
        Me.VersionLabel = New System.Windows.Forms.Label()
        Me.SubTitleLabel = New System.Windows.Forms.Label()
        Me.LinePictureBox = New System.Windows.Forms.PictureBox()
        Me.ClosePictureBox = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DemoMovieNotifyIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.NotifyMenuItem = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.OpenMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TopPanel.SuspendLayout()
        CType(Me.LinePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClosePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NotifyMenuItem.SuspendLayout()
        Me.SuspendLayout()
        '
        'ClientPanel
        '
        Me.ClientPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ClientPanel.Location = New System.Drawing.Point(0, 86)
        Me.ClientPanel.Name = "ClientPanel"
        Me.ClientPanel.Size = New System.Drawing.Size(818, 723)
        Me.ClientPanel.TabIndex = 2
        '
        'TopPanel
        '
        Me.TopPanel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TopPanel.BackgroundImage = Global.it.mymax.demomovie2.My.Resources.Resources.backgroundDM
        Me.TopPanel.Controls.Add(Me.AuthorLabel)
        Me.TopPanel.Controls.Add(Me.VersionLabel)
        Me.TopPanel.Controls.Add(Me.SubTitleLabel)
        Me.TopPanel.Controls.Add(Me.LinePictureBox)
        Me.TopPanel.Controls.Add(Me.ClosePictureBox)
        Me.TopPanel.Controls.Add(Me.Label1)
        Me.TopPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopPanel.Name = "TopPanel"
        Me.TopPanel.Size = New System.Drawing.Size(818, 83)
        Me.TopPanel.TabIndex = 4
        '
        'AuthorLabel
        '
        Me.AuthorLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AuthorLabel.AutoSize = True
        Me.AuthorLabel.BackColor = System.Drawing.Color.Transparent
        Me.AuthorLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AuthorLabel.ForeColor = System.Drawing.Color.Black
        Me.AuthorLabel.Location = New System.Drawing.Point(737, 59)
        Me.AuthorLabel.Name = "AuthorLabel"
        Me.AuthorLabel.Size = New System.Drawing.Size(46, 17)
        Me.AuthorLabel.TabIndex = 10
        Me.AuthorLabel.Text = "Author"
        Me.AuthorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'VersionLabel
        '
        Me.VersionLabel.AutoSize = True
        Me.VersionLabel.BackColor = System.Drawing.Color.Transparent
        Me.VersionLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VersionLabel.ForeColor = System.Drawing.Color.Black
        Me.VersionLabel.Location = New System.Drawing.Point(14, 59)
        Me.VersionLabel.Name = "VersionLabel"
        Me.VersionLabel.Size = New System.Drawing.Size(49, 17)
        Me.VersionLabel.TabIndex = 9
        Me.VersionLabel.Text = "Version"
        '
        'SubTitleLabel
        '
        Me.SubTitleLabel.AutoSize = True
        Me.SubTitleLabel.BackColor = System.Drawing.Color.Transparent
        Me.SubTitleLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubTitleLabel.ForeColor = System.Drawing.Color.Black
        Me.SubTitleLabel.Location = New System.Drawing.Point(221, 42)
        Me.SubTitleLabel.Name = "SubTitleLabel"
        Me.SubTitleLabel.Size = New System.Drawing.Size(59, 17)
        Me.SubTitleLabel.TabIndex = 8
        Me.SubTitleLabel.Text = "SubTitle"
        '
        'LinePictureBox
        '
        Me.LinePictureBox.BackColor = System.Drawing.Color.DarkOrange
        Me.LinePictureBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.LinePictureBox.Location = New System.Drawing.Point(0, 0)
        Me.LinePictureBox.Name = "LinePictureBox"
        Me.LinePictureBox.Size = New System.Drawing.Size(818, 8)
        Me.LinePictureBox.TabIndex = 7
        Me.LinePictureBox.TabStop = False
        '
        'ClosePictureBox
        '
        Me.ClosePictureBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ClosePictureBox.BackColor = System.Drawing.Color.Transparent
        Me.ClosePictureBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ClosePictureBox.Image = Global.it.mymax.demomovie2.My.Resources.Resources.cancel_48
        Me.ClosePictureBox.Location = New System.Drawing.Point(782, 30)
        Me.ClosePictureBox.Name = "ClosePictureBox"
        Me.ClosePictureBox.Size = New System.Drawing.Size(24, 24)
        Me.ClosePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ClosePictureBox.TabIndex = 6
        Me.ClosePictureBox.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Black", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 30)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Demo Movie"
        '
        'DemoMovieNotifyIcon
        '
        Me.DemoMovieNotifyIcon.ContextMenuStrip = Me.NotifyMenuItem
        Me.DemoMovieNotifyIcon.Icon = CType(resources.GetObject("DemoMovieNotifyIcon.Icon"), System.Drawing.Icon)
        Me.DemoMovieNotifyIcon.Text = "DemoMovie 2"
        Me.DemoMovieNotifyIcon.Visible = True
        '
        'NotifyMenuItem
        '
        Me.NotifyMenuItem.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenMenuItem, Me.ToolStripSeparator1, Me.ToolStripSeparator2, Me.ExitMenuItem})
        Me.NotifyMenuItem.Name = "NotifyMenuItem"
        Me.NotifyMenuItem.Size = New System.Drawing.Size(104, 60)
        '
        'OpenMenuItem
        '
        Me.OpenMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.OpenMenuItem.Name = "OpenMenuItem"
        Me.OpenMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.OpenMenuItem.Text = "Open"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(100, 6)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(100, 6)
        '
        'ExitMenuItem
        '
        Me.ExitMenuItem.Name = "ExitMenuItem"
        Me.ExitMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.ExitMenuItem.Text = "&Exit"
        '
        'MainForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(818, 813)
        Me.ControlBox = False
        Me.Controls.Add(Me.TopPanel)
        Me.Controls.Add(Me.ClientPanel)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopPanel.ResumeLayout(False)
        Me.TopPanel.PerformLayout()
        CType(Me.LinePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClosePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NotifyMenuItem.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ClientPanel As Panel
    Friend WithEvents TopPanel As Panel
    Friend WithEvents ClosePictureBox As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LinePictureBox As PictureBox
    Friend WithEvents SubTitleLabel As Label
    Friend WithEvents VersionLabel As Label
    Friend WithEvents AuthorLabel As Label
    Friend WithEvents DemoMovieNotifyIcon As NotifyIcon
    Friend WithEvents NotifyMenuItem As ContextMenuStrip
    Friend WithEvents OpenMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ExitMenuItem As ToolStripMenuItem
End Class
