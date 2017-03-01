<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditActorPanel
    Inherits SlidingPanel

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
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.RoleTextBox = New it.mymax.demomovie2.WatermarkedTextBox()
        Me.NameTextBox = New it.mymax.demomovie2.WatermarkedTextBox()
        Me.ImagePictureBox = New it.mymax.demomovie2.CircledPicture()
        CType(Me.ImagePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CancelButton
        '
        Me.CancelButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CancelButton.BackColor = System.Drawing.Color.DarkGray
        Me.CancelButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CancelButton.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelButton.ForeColor = System.Drawing.Color.White
        Me.CancelButton.Location = New System.Drawing.Point(21, 119)
        Me.CancelButton.Margin = New System.Windows.Forms.Padding(4)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(92, 38)
        Me.CancelButton.TabIndex = 5
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.UseVisualStyleBackColor = False
        '
        'CloseButton
        '
        Me.CloseButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CloseButton.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CloseButton.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseButton.ForeColor = System.Drawing.Color.White
        Me.CloseButton.Location = New System.Drawing.Point(272, 119)
        Me.CloseButton.Margin = New System.Windows.Forms.Padding(4)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(132, 38)
        Me.CloseButton.TabIndex = 3
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'RoleTextBox
        '
        Me.RoleTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RoleTextBox.AutoCompleteCustomSource.AddRange(New String() {"Buyer", "A/P user", "Contract Manager", "Sourcing Manager", "Procurement manager", "CPO", "CEO", "CIO", "Tech user", "Business user", "Legal", "Commercial", "Local CPO", "Global CPO "})
        Me.RoleTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.RoleTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.RoleTextBox.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoleTextBox.Location = New System.Drawing.Point(21, 53)
        Me.RoleTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RoleTextBox.Name = "RoleTextBox"
        Me.RoleTextBox.Size = New System.Drawing.Size(241, 25)
        Me.RoleTextBox.TabIndex = 1
        Me.RoleTextBox.WaterMarkColor = System.Drawing.Color.Gray
        Me.RoleTextBox.WaterMarkText = "Role"
        '
        'NameTextBox
        '
        Me.NameTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NameTextBox.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameTextBox.Location = New System.Drawing.Point(21, 20)
        Me.NameTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(241, 25)
        Me.NameTextBox.TabIndex = 0
        Me.NameTextBox.WaterMarkColor = System.Drawing.Color.Gray
        Me.NameTextBox.WaterMarkText = "Name"
        '
        'ImagePictureBox
        '
        Me.ImagePictureBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ImagePictureBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ImagePictureBox.Image = Global.it.mymax.demomovie2.My.Resources.Resources.Unknown
        Me.ImagePictureBox.Location = New System.Drawing.Point(305, 12)
        Me.ImagePictureBox.Name = "ImagePictureBox"
        Me.ImagePictureBox.Size = New System.Drawing.Size(80, 80)
        Me.ImagePictureBox.TabIndex = 8
        Me.ImagePictureBox.TabStop = False
        '
        'EditActorPanel
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.Controls.Add(Me.ImagePictureBox)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.RoleTextBox)
        Me.Controls.Add(Me.NameTextBox)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "EditActorPanel"
        Me.Size = New System.Drawing.Size(427, 172)
        CType(Me.ImagePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NameTextBox As WatermarkedTextBox
    Friend WithEvents RoleTextBox As WatermarkedTextBox
    Friend WithEvents CloseButton As Button
    Friend WithEvents CancelButton As Button
    Friend WithEvents ImagePictureBox As CircledPicture
End Class
