<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EditMoviePanel
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
        Me.TabPagesPanel = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PublishButton = New System.Windows.Forms.Button()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.AbortButton = New System.Windows.Forms.Button()
        Me.TabsPanel = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabPagesPanel
        '
        Me.TabPagesPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabPagesPanel.Location = New System.Drawing.Point(0, 59)
        Me.TabPagesPanel.Name = "TabPagesPanel"
        Me.TabPagesPanel.Size = New System.Drawing.Size(667, 519)
        Me.TabPagesPanel.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.it.mymax.demomovie2.My.Resources.Resources.backgroundDM
        Me.Panel1.Controls.Add(Me.PublishButton)
        Me.Panel1.Controls.Add(Me.SaveButton)
        Me.Panel1.Controls.Add(Me.AbortButton)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 578)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(667, 46)
        Me.Panel1.TabIndex = 4
        '
        'PublishButton
        '
        Me.PublishButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PublishButton.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.PublishButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PublishButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PublishButton.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PublishButton.ForeColor = System.Drawing.Color.White
        Me.PublishButton.Location = New System.Drawing.Point(361, 4)
        Me.PublishButton.Margin = New System.Windows.Forms.Padding(4)
        Me.PublishButton.Name = "PublishButton"
        Me.PublishButton.Size = New System.Drawing.Size(136, 38)
        Me.PublishButton.TabIndex = 6
        Me.PublishButton.Text = "Publish"
        Me.PublishButton.UseVisualStyleBackColor = True
        '
        'SaveButton
        '
        Me.SaveButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaveButton.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.SaveButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveButton.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveButton.ForeColor = System.Drawing.Color.White
        Me.SaveButton.Location = New System.Drawing.Point(505, 4)
        Me.SaveButton.Margin = New System.Windows.Forms.Padding(4)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(158, 38)
        Me.SaveButton.TabIndex = 4
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'AbortButton
        '
        Me.AbortButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.AbortButton.BackColor = System.Drawing.SystemColors.Control
        Me.AbortButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AbortButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AbortButton.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AbortButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.AbortButton.Location = New System.Drawing.Point(4, 4)
        Me.AbortButton.Margin = New System.Windows.Forms.Padding(4)
        Me.AbortButton.Name = "AbortButton"
        Me.AbortButton.Size = New System.Drawing.Size(175, 38)
        Me.AbortButton.TabIndex = 5
        Me.AbortButton.Text = "Cancel"
        Me.AbortButton.UseVisualStyleBackColor = False
        '
        'TabsPanel
        '
        Me.TabsPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TabsPanel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabsPanel.Location = New System.Drawing.Point(0, 0)
        Me.TabsPanel.Name = "TabsPanel"
        Me.TabsPanel.Size = New System.Drawing.Size(667, 59)
        Me.TabsPanel.TabIndex = 2
        '
        'EditMoviePanel
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.Controls.Add(Me.TabPagesPanel)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TabsPanel)
        Me.Name = "EditMoviePanel"
        Me.Size = New System.Drawing.Size(667, 624)
        Me.Title = "Edit a movie video"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabsPanel As Panel
    Friend WithEvents SaveButton As Button
    Friend WithEvents AbortButton As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TabPagesPanel As Panel
    Friend WithEvents PublishButton As Button
End Class
