<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SimpleStageForm
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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
        Me.ActorUserControl1 = New it.mymax.demomovie2.ActorUserControl()
        Me.TakeUserControl1 = New it.mymax.demomovie2.TakeUserControl()
        Me.SuspendLayout()
        '
        'ActorUserControl1
        '
        Me.ActorUserControl1.Active = True
        Me.ActorUserControl1.Actor = Nothing
        Me.ActorUserControl1.AllowDelete = False
        Me.ActorUserControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ActorUserControl1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ActorUserControl1.Location = New System.Drawing.Point(0, 153)
        Me.ActorUserControl1.Margin = New System.Windows.Forms.Padding(3, 16, 3, 16)
        Me.ActorUserControl1.Name = "ActorUserControl1"
        Me.ActorUserControl1.Size = New System.Drawing.Size(155, 242)
        Me.ActorUserControl1.TabIndex = 1
        '
        'TakeUserControl1
        '
        Me.TakeUserControl1.AllowDelete = True
        Me.TakeUserControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TakeUserControl1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TakeUserControl1.LeftTakeColor = System.Drawing.Color.Empty
        Me.TakeUserControl1.Location = New System.Drawing.Point(0, 0)
        Me.TakeUserControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TakeUserControl1.Name = "TakeUserControl1"
        Me.TakeUserControl1.RightTakeColor = System.Drawing.Color.Empty
        Me.TakeUserControl1.Size = New System.Drawing.Size(167, 142)
        Me.TakeUserControl1.TabIndex = 0
        Me.TakeUserControl1.Take = Nothing
        '
        'SimpleStageForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(167, 405)
        Me.Controls.Add(Me.ActorUserControl1)
        Me.Controls.Add(Me.TakeUserControl1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "SimpleStageForm"
        Me.Opacity = 0.8R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "DirectorStageForm"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TakeUserControl1 As TakeUserControl
    Friend WithEvents ActorUserControl1 As ActorUserControl
End Class
