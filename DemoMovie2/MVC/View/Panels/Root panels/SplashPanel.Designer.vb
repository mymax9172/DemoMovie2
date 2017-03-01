<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SplashPanel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SplashPanel))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.VersionLabel = New System.Windows.Forms.Label()
        Me.StartButton = New System.Windows.Forms.Button()
        Me.CopyrightLabel = New System.Windows.Forms.Label()
        Me.SeeLicenseButton = New System.Windows.Forms.Button()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ChangeLogTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(116, 38)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Author: Massimiliano Agostinoni"
        '
        'VersionLabel
        '
        Me.VersionLabel.AutoSize = True
        Me.VersionLabel.Location = New System.Drawing.Point(116, 67)
        Me.VersionLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.VersionLabel.Name = "VersionLabel"
        Me.VersionLabel.Size = New System.Drawing.Size(80, 19)
        Me.VersionLabel.TabIndex = 1
        Me.VersionLabel.Text = "Version: 0.2"
        '
        'StartButton
        '
        Me.StartButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StartButton.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.StartButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StartButton.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartButton.ForeColor = System.Drawing.Color.White
        Me.StartButton.Location = New System.Drawing.Point(517, 514)
        Me.StartButton.Margin = New System.Windows.Forms.Padding(4)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(175, 38)
        Me.StartButton.TabIndex = 2
        Me.StartButton.Text = "Start"
        Me.StartButton.UseVisualStyleBackColor = True
        '
        'CopyrightLabel
        '
        Me.CopyrightLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CopyrightLabel.Location = New System.Drawing.Point(18, 158)
        Me.CopyrightLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.CopyrightLabel.Name = "CopyrightLabel"
        Me.CopyrightLabel.Size = New System.Drawing.Size(674, 176)
        Me.CopyrightLabel.TabIndex = 3
        Me.CopyrightLabel.Text = resources.GetString("CopyrightLabel.Text")
        '
        'SeeLicenseButton
        '
        Me.SeeLicenseButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SeeLicenseButton.BackColor = System.Drawing.Color.DarkGray
        Me.SeeLicenseButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SeeLicenseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SeeLicenseButton.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SeeLicenseButton.ForeColor = System.Drawing.Color.White
        Me.SeeLicenseButton.Location = New System.Drawing.Point(22, 514)
        Me.SeeLicenseButton.Margin = New System.Windows.Forms.Padding(4)
        Me.SeeLicenseButton.Name = "SeeLicenseButton"
        Me.SeeLicenseButton.Size = New System.Drawing.Size(175, 38)
        Me.SeeLicenseButton.TabIndex = 4
        Me.SeeLicenseButton.Text = "See GNU license"
        Me.SeeLicenseButton.UseVisualStyleBackColor = False
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LogoPictureBox.Image = Global.it.mymax.demomovie2.My.Resources.Resources.SAP_Ariba_Logo
        Me.LogoPictureBox.Location = New System.Drawing.Point(474, 3)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(218, 118)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.LogoPictureBox.TabIndex = 7
        Me.LogoPictureBox.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(22, 25)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(77, 78)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'ChangeLogTextBox
        '
        Me.ChangeLogTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChangeLogTextBox.BackColor = System.Drawing.Color.White
        Me.ChangeLogTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ChangeLogTextBox.Location = New System.Drawing.Point(22, 368)
        Me.ChangeLogTextBox.Multiline = True
        Me.ChangeLogTextBox.Name = "ChangeLogTextBox"
        Me.ChangeLogTextBox.ReadOnly = True
        Me.ChangeLogTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.ChangeLogTextBox.Size = New System.Drawing.Size(670, 124)
        Me.ChangeLogTextBox.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 343)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 19)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Change log"
        '
        'SplashPanel
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ChangeLogTextBox)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.SeeLicenseButton)
        Me.Controls.Add(Me.CopyrightLabel)
        Me.Controls.Add(Me.StartButton)
        Me.Controls.Add(Me.VersionLabel)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "SplashPanel"
        Me.Size = New System.Drawing.Size(710, 570)
        Me.Title = "Credits"
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents VersionLabel As Label
    Friend WithEvents StartButton As Button
    Friend WithEvents CopyrightLabel As Label
    Friend WithEvents SeeLicenseButton As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LogoPictureBox As PictureBox
    Friend WithEvents ChangeLogTextBox As TextBox
    Friend WithEvents Label2 As Label
End Class
