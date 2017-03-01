<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddUserControl
    Inherits System.Windows.Forms.UserControl

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
        Me.AddPictureBox = New System.Windows.Forms.PictureBox()
        CType(Me.AddPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AddPictureBox
        '
        Me.AddPictureBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AddPictureBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AddPictureBox.Image = Global.it.mymax.demomovie2.My.Resources.Resources.plus2_math_48
        Me.AddPictureBox.Location = New System.Drawing.Point(0, 0)
        Me.AddPictureBox.Margin = New System.Windows.Forms.Padding(2)
        Me.AddPictureBox.Name = "AddPictureBox"
        Me.AddPictureBox.Size = New System.Drawing.Size(112, 122)
        Me.AddPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.AddPictureBox.TabIndex = 1
        Me.AddPictureBox.TabStop = False
        '
        'AddUserControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.AddPictureBox)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "AddUserControl"
        Me.Size = New System.Drawing.Size(112, 122)
        CType(Me.AddPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AddPictureBox As PictureBox
End Class
