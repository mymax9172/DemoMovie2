<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditScenePanel
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
        Me.TitleTextBox = New it.mymax.demomovie2.WatermarkedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.TakesList = New it.mymax.demomovie2.ListOfTakes()
        Me.AbortButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TitleTextBox
        '
        Me.TitleTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TitleTextBox.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleTextBox.Location = New System.Drawing.Point(26, 30)
        Me.TitleTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TitleTextBox.Name = "TitleTextBox"
        Me.TitleTextBox.Size = New System.Drawing.Size(538, 25)
        Me.TitleTextBox.TabIndex = 1
        Me.TitleTextBox.WaterMarkColor = System.Drawing.Color.Gray
        Me.TitleTextBox.WaterMarkText = "Title"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(23, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(541, 48)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Manage here all takes for this scene." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "For each take you can assign one or more a" &
    "ctors (but not twice)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "After casting, design here your steps as single takes"
        '
        'CloseButton
        '
        Me.CloseButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CloseButton.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CloseButton.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseButton.ForeColor = System.Drawing.Color.White
        Me.CloseButton.Location = New System.Drawing.Point(655, 362)
        Me.CloseButton.Margin = New System.Windows.Forms.Padding(4)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(132, 38)
        Me.CloseButton.TabIndex = 8
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'TakesList
        '
        Me.TakesList.AllowAdd = False
        Me.TakesList.AllowDelete = False
        Me.TakesList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TakesList.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TakesList.Location = New System.Drawing.Point(26, 146)
        Me.TakesList.Name = "TakesList"
        Me.TakesList.Size = New System.Drawing.Size(761, 209)
        Me.TakesList.TabIndex = 9
        Me.TakesList.Takes = Nothing
        '
        'AbortButton
        '
        Me.AbortButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.AbortButton.BackColor = System.Drawing.SystemColors.Control
        Me.AbortButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AbortButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AbortButton.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AbortButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.AbortButton.Location = New System.Drawing.Point(4, 362)
        Me.AbortButton.Margin = New System.Windows.Forms.Padding(4)
        Me.AbortButton.Name = "AbortButton"
        Me.AbortButton.Size = New System.Drawing.Size(106, 38)
        Me.AbortButton.TabIndex = 12
        Me.AbortButton.Text = "Cancel"
        Me.AbortButton.UseVisualStyleBackColor = False
        '
        'EditScenePanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.AbortButton)
        Me.Controls.Add(Me.TakesList)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TitleTextBox)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "EditScenePanel"
        Me.Size = New System.Drawing.Size(791, 404)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TitleTextBox As WatermarkedTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CloseButton As Button
    Friend WithEvents TakesList As ListOfTakes
    Friend WithEvents AbortButton As Button
End Class
