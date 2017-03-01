<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditTakePanel
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
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TitleTextBox = New it.mymax.demomovie2.WatermarkedTextBox()
        Me.ActorsListUserControl = New it.mymax.demomovie2.ListOfActors()
        Me.AbortButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CloseButton
        '
        Me.CloseButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CloseButton.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CloseButton.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseButton.ForeColor = System.Drawing.Color.White
        Me.CloseButton.Location = New System.Drawing.Point(469, 461)
        Me.CloseButton.Margin = New System.Windows.Forms.Padding(4)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(132, 38)
        Me.CloseButton.TabIndex = 7
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(18, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(376, 34)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Select which actor must be considered for this take (action). Click on existing a" &
    "ctor to remove it from this take"
        '
        'TitleTextBox
        '
        Me.TitleTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TitleTextBox.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleTextBox.Location = New System.Drawing.Point(20, 21)
        Me.TitleTextBox.Name = "TitleTextBox"
        Me.TitleTextBox.Size = New System.Drawing.Size(571, 25)
        Me.TitleTextBox.TabIndex = 0
        Me.TitleTextBox.WaterMarkColor = System.Drawing.Color.Gray
        Me.TitleTextBox.WaterMarkText = "Title"
        '
        'ActorsListUserControl
        '
        Me.ActorsListUserControl.Actors = Nothing
        Me.ActorsListUserControl.AllowAdd = False
        Me.ActorsListUserControl.AllowDelete = False
        Me.ActorsListUserControl.Location = New System.Drawing.Point(23, 120)
        Me.ActorsListUserControl.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ActorsListUserControl.Name = "ActorsListUserControl"
        Me.ActorsListUserControl.Size = New System.Drawing.Size(566, 318)
        Me.ActorsListUserControl.TabIndex = 10
        '
        'AbortButton
        '
        Me.AbortButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.AbortButton.BackColor = System.Drawing.SystemColors.Control
        Me.AbortButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AbortButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AbortButton.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AbortButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.AbortButton.Location = New System.Drawing.Point(4, 461)
        Me.AbortButton.Margin = New System.Windows.Forms.Padding(4)
        Me.AbortButton.Name = "AbortButton"
        Me.AbortButton.Size = New System.Drawing.Size(106, 38)
        Me.AbortButton.TabIndex = 11
        Me.AbortButton.Text = "Cancel"
        Me.AbortButton.UseVisualStyleBackColor = False
        '
        'EditTakePanel
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.Controls.Add(Me.AbortButton)
        Me.Controls.Add(Me.ActorsListUserControl)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TitleTextBox)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "EditTakePanel"
        Me.Size = New System.Drawing.Size(605, 503)
        Me.Title = "Edit or Create a new take"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TitleTextBox As WatermarkedTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CloseButton As Button
    Friend WithEvents ActorsListUserControl As ListOfActors
    Friend WithEvents AbortButton As Button
End Class
