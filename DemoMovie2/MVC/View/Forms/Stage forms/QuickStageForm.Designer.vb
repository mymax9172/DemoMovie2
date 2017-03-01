<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QuickStageForm
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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
        Me.ActorUserControl1 = New it.mymax.demomovie2.ActorUserControl()
        Me.SuspendLayout()
        '
        'ActorUserControl1
        '
        Me.ActorUserControl1.Actor = Nothing
        Me.ActorUserControl1.AllowDelete = True
        Me.ActorUserControl1.BackColor = System.Drawing.Color.LightGray
        Me.ActorUserControl1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ActorUserControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ActorUserControl1.Location = New System.Drawing.Point(0, 0)
        Me.ActorUserControl1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.ActorUserControl1.Name = "ActorUserControl1"
        Me.ActorUserControl1.Size = New System.Drawing.Size(150, 200)
        Me.ActorUserControl1.TabIndex = 0
        '
        'QuickStageForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Violet
        Me.ClientSize = New System.Drawing.Size(150, 200)
        Me.ControlBox = False
        Me.Controls.Add(Me.ActorUserControl1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "QuickStageForm"
        Me.Opacity = 0.8R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.Violet
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ActorUserControl1 As ActorUserControl
End Class
