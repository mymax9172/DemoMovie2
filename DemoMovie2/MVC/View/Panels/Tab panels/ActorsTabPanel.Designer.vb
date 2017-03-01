<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ActorsTabPanel
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ActorsListUserControl = New it.mymax.demomovie2.ListOfActors()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CopyActorsLink = New System.Windows.Forms.LinkLabel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.it.mymax.demomovie2.My.Resources.Resources.audition
        Me.PictureBox1.Location = New System.Drawing.Point(486, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(285, 135)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(680, 208)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Bette Davis"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(483, 166)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(285, 42)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = """Without wonder and insight, acting is just a business. With it, it becomes creat" &
    "ion"""
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(20, 43)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(424, 120)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Manage here all actors you need for your demo movie." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "An actor is someone who per" &
    "forms an action during the demonstration" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Start from this page defining your c" &
    "ast"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ActorsListUserControl
        '
        Me.ActorsListUserControl.Actors = Nothing
        Me.ActorsListUserControl.AllowAdd = False
        Me.ActorsListUserControl.AllowDelete = False
        Me.ActorsListUserControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ActorsListUserControl.Location = New System.Drawing.Point(23, 259)
        Me.ActorsListUserControl.Name = "ActorsListUserControl"
        Me.ActorsListUserControl.Size = New System.Drawing.Size(734, 381)
        Me.ActorsListUserControl.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(89, 166)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(359, 42)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "to copy actors from existing movies (Existing actors will be removed from this de" &
    "mo)"
        '
        'CopyActorsLink
        '
        Me.CopyActorsLink.AutoSize = True
        Me.CopyActorsLink.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CopyActorsLink.Location = New System.Drawing.Point(20, 172)
        Me.CopyActorsLink.Name = "CopyActorsLink"
        Me.CopyActorsLink.Size = New System.Drawing.Size(64, 17)
        Me.CopyActorsLink.TabIndex = 5
        Me.CopyActorsLink.TabStop = True
        Me.CopyActorsLink.Text = "Click here"
        '
        'ActorsTabPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.CopyActorsLink)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ActorsListUserControl)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "ActorsTabPanel"
        Me.Size = New System.Drawing.Size(771, 656)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ActorsListUserControl As ListOfActors
    Friend WithEvents Label3 As Label
    Friend WithEvents CopyActorsLink As LinkLabel
End Class
