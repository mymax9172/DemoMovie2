<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CreateMoviePanel
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
        Me.AbortButton = New System.Windows.Forms.Button()
        Me.CreateButton = New System.Windows.Forms.Button()
        Me.FullLabel2 = New System.Windows.Forms.Label()
        Me.FullLabel = New System.Windows.Forms.Label()
        Me.FullPictureBox = New System.Windows.Forms.PictureBox()
        Me.SimpleLabel2 = New System.Windows.Forms.Label()
        Me.SimpleLabel = New System.Windows.Forms.Label()
        Me.SimplePictureBox = New System.Windows.Forms.PictureBox()
        Me.QuickLabel2 = New System.Windows.Forms.Label()
        Me.QuickLabel = New System.Windows.Forms.Label()
        Me.QuickPictureBox = New System.Windows.Forms.PictureBox()
        Me.TypeTrackBar = New System.Windows.Forms.TrackBar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TitleTextBox = New it.mymax.demomovie2.WatermarkedTextBox()
        Me.CustomerTextBox = New it.mymax.demomovie2.WatermarkedTextBox()
        CType(Me.FullPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SimplePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuickPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TypeTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AbortButton
        '
        Me.AbortButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AbortButton.BackColor = System.Drawing.Color.Silver
        Me.AbortButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AbortButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AbortButton.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AbortButton.ForeColor = System.Drawing.Color.White
        Me.AbortButton.Location = New System.Drawing.Point(147, 459)
        Me.AbortButton.Margin = New System.Windows.Forms.Padding(4)
        Me.AbortButton.Name = "AbortButton"
        Me.AbortButton.Size = New System.Drawing.Size(112, 38)
        Me.AbortButton.TabIndex = 16
        Me.AbortButton.Text = "Abort"
        Me.AbortButton.UseVisualStyleBackColor = False
        '
        'CreateButton
        '
        Me.CreateButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CreateButton.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.CreateButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CreateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CreateButton.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CreateButton.ForeColor = System.Drawing.Color.White
        Me.CreateButton.Location = New System.Drawing.Point(327, 459)
        Me.CreateButton.Margin = New System.Windows.Forms.Padding(4)
        Me.CreateButton.Name = "CreateButton"
        Me.CreateButton.Size = New System.Drawing.Size(175, 38)
        Me.CreateButton.TabIndex = 14
        Me.CreateButton.Text = "Create"
        Me.CreateButton.UseVisualStyleBackColor = True
        '
        'FullLabel2
        '
        Me.FullLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FullLabel2.Location = New System.Drawing.Point(284, 204)
        Me.FullLabel2.Name = "FullLabel2"
        Me.FullLabel2.Size = New System.Drawing.Size(186, 57)
        Me.FullLabel2.TabIndex = 13
        Me.FullLabel2.Text = "Multiple scenes with takes and actors. Use it for complex workshop"
        Me.FullLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FullLabel
        '
        Me.FullLabel.AutoSize = True
        Me.FullLabel.Location = New System.Drawing.Point(160, 210)
        Me.FullLabel.Name = "FullLabel"
        Me.FullLabel.Size = New System.Drawing.Size(87, 23)
        Me.FullLabel.TabIndex = 12
        Me.FullLabel.Text = "Full movie"
        '
        'FullPictureBox
        '
        Me.FullPictureBox.Image = Global.it.mymax.demomovie2.My.Resources.Resources.film_reel_48
        Me.FullPictureBox.Location = New System.Drawing.Point(102, 196)
        Me.FullPictureBox.Name = "FullPictureBox"
        Me.FullPictureBox.Size = New System.Drawing.Size(48, 48)
        Me.FullPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.FullPictureBox.TabIndex = 11
        Me.FullPictureBox.TabStop = False
        '
        'SimpleLabel2
        '
        Me.SimpleLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleLabel2.Location = New System.Drawing.Point(284, 266)
        Me.SimpleLabel2.Name = "SimpleLabel2"
        Me.SimpleLabel2.Size = New System.Drawing.Size(186, 57)
        Me.SimpleLabel2.TabIndex = 10
        Me.SimpleLabel2.Text = "Use this type of movie when you need a list of takes with actors"
        Me.SimpleLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SimpleLabel
        '
        Me.SimpleLabel.AutoSize = True
        Me.SimpleLabel.Location = New System.Drawing.Point(156, 273)
        Me.SimpleLabel.Name = "SimpleLabel"
        Me.SimpleLabel.Size = New System.Drawing.Size(112, 23)
        Me.SimpleLabel.TabIndex = 9
        Me.SimpleLabel.Text = "Simple movie"
        '
        'SimplePictureBox
        '
        Me.SimplePictureBox.Image = Global.it.mymax.demomovie2.My.Resources.Resources.meditation_guru_48
        Me.SimplePictureBox.Location = New System.Drawing.Point(102, 258)
        Me.SimplePictureBox.Name = "SimplePictureBox"
        Me.SimplePictureBox.Size = New System.Drawing.Size(48, 48)
        Me.SimplePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.SimplePictureBox.TabIndex = 8
        Me.SimplePictureBox.TabStop = False
        '
        'QuickLabel2
        '
        Me.QuickLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuickLabel2.Location = New System.Drawing.Point(284, 330)
        Me.QuickLabel2.Name = "QuickLabel2"
        Me.QuickLabel2.Size = New System.Drawing.Size(186, 57)
        Me.QuickLabel2.TabIndex = 7
        Me.QuickLabel2.Text = "Use this type of movie when you need just a group of actors (cast)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.QuickLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'QuickLabel
        '
        Me.QuickLabel.AutoSize = True
        Me.QuickLabel.Location = New System.Drawing.Point(156, 339)
        Me.QuickLabel.Name = "QuickLabel"
        Me.QuickLabel.Size = New System.Drawing.Size(104, 23)
        Me.QuickLabel.TabIndex = 6
        Me.QuickLabel.Text = "Quick movie"
        '
        'QuickPictureBox
        '
        Me.QuickPictureBox.Image = Global.it.mymax.demomovie2.My.Resources.Resources.bird_48
        Me.QuickPictureBox.Location = New System.Drawing.Point(102, 322)
        Me.QuickPictureBox.Name = "QuickPictureBox"
        Me.QuickPictureBox.Size = New System.Drawing.Size(48, 48)
        Me.QuickPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.QuickPictureBox.TabIndex = 5
        Me.QuickPictureBox.TabStop = False
        '
        'TypeTrackBar
        '
        Me.TypeTrackBar.LargeChange = 1
        Me.TypeTrackBar.Location = New System.Drawing.Point(62, 206)
        Me.TypeTrackBar.Maximum = 3
        Me.TypeTrackBar.Minimum = 1
        Me.TypeTrackBar.Name = "TypeTrackBar"
        Me.TypeTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.TypeTrackBar.Size = New System.Drawing.Size(56, 155)
        Me.TypeTrackBar.TabIndex = 4
        Me.TypeTrackBar.Value = 1
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(23, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(459, 55)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Select the type of demo movie  (scroll the pointer up and down)"
        '
        'TitleTextBox
        '
        Me.TitleTextBox.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleTextBox.Location = New System.Drawing.Point(27, 26)
        Me.TitleTextBox.Name = "TitleTextBox"
        Me.TitleTextBox.Size = New System.Drawing.Size(360, 32)
        Me.TitleTextBox.TabIndex = 18
        Me.TitleTextBox.WaterMarkColor = System.Drawing.Color.Gray
        Me.TitleTextBox.WaterMarkText = "Title of the demo movie"
        '
        'CustomerTextBox
        '
        Me.CustomerTextBox.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomerTextBox.Location = New System.Drawing.Point(27, 59)
        Me.CustomerTextBox.Name = "CustomerTextBox"
        Me.CustomerTextBox.Size = New System.Drawing.Size(360, 32)
        Me.CustomerTextBox.TabIndex = 19
        Me.CustomerTextBox.WaterMarkColor = System.Drawing.Color.Gray
        Me.CustomerTextBox.WaterMarkText = "Customer name"
        '
        'CreateMoviePanel
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.CustomerTextBox)
        Me.Controls.Add(Me.TitleTextBox)
        Me.Controls.Add(Me.AbortButton)
        Me.Controls.Add(Me.CreateButton)
        Me.Controls.Add(Me.FullLabel2)
        Me.Controls.Add(Me.FullLabel)
        Me.Controls.Add(Me.FullPictureBox)
        Me.Controls.Add(Me.SimpleLabel2)
        Me.Controls.Add(Me.SimpleLabel)
        Me.Controls.Add(Me.SimplePictureBox)
        Me.Controls.Add(Me.QuickLabel2)
        Me.Controls.Add(Me.QuickLabel)
        Me.Controls.Add(Me.QuickPictureBox)
        Me.Controls.Add(Me.TypeTrackBar)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "CreateMoviePanel"
        Me.Size = New System.Drawing.Size(519, 512)
        Me.Title = "Create a brand new demo movie"
        CType(Me.FullPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SimplePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuickPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TypeTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents TypeTrackBar As TrackBar
    Friend WithEvents QuickPictureBox As PictureBox
    Friend WithEvents QuickLabel As Label
    Friend WithEvents QuickLabel2 As Label
    Friend WithEvents SimplePictureBox As PictureBox
    Friend WithEvents SimpleLabel As Label
    Friend WithEvents SimpleLabel2 As Label
    Friend WithEvents FullPictureBox As PictureBox
    Friend WithEvents FullLabel As Label
    Friend WithEvents FullLabel2 As Label
    Friend WithEvents CreateButton As Button
    Friend WithEvents AbortButton As Button
    Friend WithEvents TitleTextBox As WatermarkedTextBox
    Friend WithEvents CustomerTextBox As WatermarkedTextBox
End Class
