<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GeneralTabPanel
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
        Me.CustomerTextBox = New it.mymax.demomovie2.WatermarkedTextBox()
        Me.TitleTextBox = New it.mymax.demomovie2.WatermarkedTextBox()
        Me.FullPictureBox = New System.Windows.Forms.PictureBox()
        Me.SimplePictureBox = New System.Windows.Forms.PictureBox()
        Me.QuickPictureBox = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FullLabel = New System.Windows.Forms.Label()
        Me.SimpleLabel = New System.Windows.Forms.Label()
        Me.QuickLabel = New System.Windows.Forms.Label()
        Me.DemoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.QuickPanel = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SimplePanel = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.FullPanel = New System.Windows.Forms.Panel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.PublishedLabel = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        CType(Me.FullPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SimplePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuickPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.QuickPanel.SuspendLayout()
        Me.SimplePanel.SuspendLayout()
        Me.FullPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'CustomerTextBox
        '
        Me.CustomerTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CustomerTextBox.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomerTextBox.Location = New System.Drawing.Point(31, 68)
        Me.CustomerTextBox.Name = "CustomerTextBox"
        Me.CustomerTextBox.Size = New System.Drawing.Size(385, 27)
        Me.CustomerTextBox.TabIndex = 21
        Me.CustomerTextBox.WaterMarkColor = System.Drawing.Color.Gray
        Me.CustomerTextBox.WaterMarkText = "Customer name"
        '
        'TitleTextBox
        '
        Me.TitleTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TitleTextBox.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleTextBox.Location = New System.Drawing.Point(31, 35)
        Me.TitleTextBox.Name = "TitleTextBox"
        Me.TitleTextBox.Size = New System.Drawing.Size(385, 27)
        Me.TitleTextBox.TabIndex = 20
        Me.TitleTextBox.WaterMarkColor = System.Drawing.Color.Gray
        Me.TitleTextBox.WaterMarkText = "Title of the demo movie"
        '
        'FullPictureBox
        '
        Me.FullPictureBox.Image = Global.it.mymax.demomovie2.My.Resources.Resources.film_reel_48
        Me.FullPictureBox.Location = New System.Drawing.Point(158, 191)
        Me.FullPictureBox.Name = "FullPictureBox"
        Me.FullPictureBox.Size = New System.Drawing.Size(48, 48)
        Me.FullPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.FullPictureBox.TabIndex = 24
        Me.FullPictureBox.TabStop = False
        '
        'SimplePictureBox
        '
        Me.SimplePictureBox.Image = Global.it.mymax.demomovie2.My.Resources.Resources.meditation_guru_48
        Me.SimplePictureBox.Location = New System.Drawing.Point(158, 191)
        Me.SimplePictureBox.Name = "SimplePictureBox"
        Me.SimplePictureBox.Size = New System.Drawing.Size(48, 48)
        Me.SimplePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.SimplePictureBox.TabIndex = 23
        Me.SimplePictureBox.TabStop = False
        '
        'QuickPictureBox
        '
        Me.QuickPictureBox.Image = Global.it.mymax.demomovie2.My.Resources.Resources.bird_48
        Me.QuickPictureBox.Location = New System.Drawing.Point(158, 191)
        Me.QuickPictureBox.Name = "QuickPictureBox"
        Me.QuickPictureBox.Size = New System.Drawing.Size(48, 48)
        Me.QuickPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.QuickPictureBox.TabIndex = 22
        Me.QuickPictureBox.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 201)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 17)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Demo type"
        '
        'FullLabel
        '
        Me.FullLabel.AutoSize = True
        Me.FullLabel.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FullLabel.Location = New System.Drawing.Point(219, 204)
        Me.FullLabel.Name = "FullLabel"
        Me.FullLabel.Size = New System.Drawing.Size(81, 20)
        Me.FullLabel.TabIndex = 28
        Me.FullLabel.Text = "Full movie"
        '
        'SimpleLabel
        '
        Me.SimpleLabel.AutoSize = True
        Me.SimpleLabel.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleLabel.Location = New System.Drawing.Point(219, 204)
        Me.SimpleLabel.Name = "SimpleLabel"
        Me.SimpleLabel.Size = New System.Drawing.Size(103, 20)
        Me.SimpleLabel.TabIndex = 27
        Me.SimpleLabel.Text = "Simple movie"
        '
        'QuickLabel
        '
        Me.QuickLabel.AutoSize = True
        Me.QuickLabel.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuickLabel.Location = New System.Drawing.Point(219, 204)
        Me.QuickLabel.Name = "QuickLabel"
        Me.QuickLabel.Size = New System.Drawing.Size(95, 20)
        Me.QuickLabel.TabIndex = 26
        Me.QuickLabel.Text = "Quick movie"
        '
        'DemoDateTimePicker
        '
        Me.DemoDateTimePicker.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DemoDateTimePicker.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DemoDateTimePicker.Location = New System.Drawing.Point(158, 114)
        Me.DemoDateTimePicker.Name = "DemoDateTimePicker"
        Me.DemoDateTimePicker.Size = New System.Drawing.Size(258, 25)
        Me.DemoDateTimePicker.TabIndex = 29
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 17)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Planned date"
        '
        'QuickPanel
        '
        Me.QuickPanel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.QuickPanel.Controls.Add(Me.Label5)
        Me.QuickPanel.Controls.Add(Me.Label4)
        Me.QuickPanel.Controls.Add(Me.Label3)
        Me.QuickPanel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuickPanel.Location = New System.Drawing.Point(463, 26)
        Me.QuickPanel.Name = "QuickPanel"
        Me.QuickPanel.Size = New System.Drawing.Size(386, 131)
        Me.QuickPanel.TabIndex = 31
        Me.QuickPanel.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(46, 79)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(149, 17)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "2) Play your quick movie"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(46, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(281, 17)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "1) Create your cast, selecting players and roles"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Follow these steps:"
        '
        'SimplePanel
        '
        Me.SimplePanel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimplePanel.Controls.Add(Me.Label10)
        Me.SimplePanel.Controls.Add(Me.Label9)
        Me.SimplePanel.Controls.Add(Me.Label6)
        Me.SimplePanel.Controls.Add(Me.Label7)
        Me.SimplePanel.Controls.Add(Me.Label8)
        Me.SimplePanel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimplePanel.Location = New System.Drawing.Point(463, 26)
        Me.SimplePanel.Name = "SimplePanel"
        Me.SimplePanel.Size = New System.Drawing.Size(386, 172)
        Me.SimplePanel.TabIndex = 32
        Me.SimplePanel.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(46, 145)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(169, 17)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "4) Player your simple movie"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(46, 118)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(231, 17)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "3) Repeat step 2 as much as you need"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(46, 79)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(325, 37)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "2) Create a take, by defining a title for it and selecting a subset of actors fro" &
    "m your cast"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(46, 52)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(281, 17)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "1) Create your cast, selecting players and roles"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(19, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(118, 17)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Follow these steps:"
        '
        'FullPanel
        '
        Me.FullPanel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FullPanel.Controls.Add(Me.Label16)
        Me.FullPanel.Controls.Add(Me.Label11)
        Me.FullPanel.Controls.Add(Me.Label12)
        Me.FullPanel.Controls.Add(Me.Label13)
        Me.FullPanel.Controls.Add(Me.Label14)
        Me.FullPanel.Controls.Add(Me.Label15)
        Me.FullPanel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FullPanel.Location = New System.Drawing.Point(463, 26)
        Me.FullPanel.Name = "FullPanel"
        Me.FullPanel.Size = New System.Drawing.Size(386, 194)
        Me.FullPanel.TabIndex = 33
        Me.FullPanel.Visible = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(46, 101)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(377, 17)
        Me.Label16.TabIndex = 5
        Me.Label16.Text = "3) Add takes, with a title and a selction of actors from your cast"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(46, 153)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(148, 17)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "5) Player your full movie"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(46, 127)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(274, 17)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "4) Repeat steps 2 and 3 as much as you need"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(46, 79)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(153, 17)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "2) Create athe first scene"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(46, 52)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(281, 17)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "1) Create your cast, selecting players and roles"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(19, 18)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(118, 17)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Follow these steps:"
        '
        'PublishedLabel
        '
        Me.PublishedLabel.AutoSize = True
        Me.PublishedLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PublishedLabel.Location = New System.Drawing.Point(28, 267)
        Me.PublishedLabel.Name = "PublishedLabel"
        Me.PublishedLabel.Size = New System.Drawing.Size(266, 17)
        Me.PublishedLabel.TabIndex = 34
        Me.PublishedLabel.Text = "This demo has been published on the Cloud"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(30, 153)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(371, 17)
        Me.Label17.TabIndex = 34
        Me.Label17.Text = "A reminder will be notified 15 minutes before the panned time"
        '
        'GeneralTabPanel
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.PublishedLabel)
        Me.Controls.Add(Me.FullPanel)
        Me.Controls.Add(Me.SimplePanel)
        Me.Controls.Add(Me.QuickPanel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DemoDateTimePicker)
        Me.Controls.Add(Me.FullLabel)
        Me.Controls.Add(Me.SimpleLabel)
        Me.Controls.Add(Me.QuickLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.FullPictureBox)
        Me.Controls.Add(Me.SimplePictureBox)
        Me.Controls.Add(Me.QuickPictureBox)
        Me.Controls.Add(Me.CustomerTextBox)
        Me.Controls.Add(Me.TitleTextBox)
        Me.Name = "GeneralTabPanel"
        Me.Size = New System.Drawing.Size(871, 547)
        CType(Me.FullPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SimplePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuickPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.QuickPanel.ResumeLayout(False)
        Me.QuickPanel.PerformLayout()
        Me.SimplePanel.ResumeLayout(False)
        Me.SimplePanel.PerformLayout()
        Me.FullPanel.ResumeLayout(False)
        Me.FullPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CustomerTextBox As WatermarkedTextBox
    Friend WithEvents TitleTextBox As WatermarkedTextBox
    Friend WithEvents FullPictureBox As PictureBox
    Friend WithEvents SimplePictureBox As PictureBox
    Friend WithEvents QuickPictureBox As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents FullLabel As Label
    Friend WithEvents SimpleLabel As Label
    Friend WithEvents QuickLabel As Label
    Friend WithEvents DemoDateTimePicker As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents QuickPanel As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents SimplePanel As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents FullPanel As Panel
    Friend WithEvents Label16 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents PublishedLabel As Label
    Friend WithEvents Label17 As Label
End Class
