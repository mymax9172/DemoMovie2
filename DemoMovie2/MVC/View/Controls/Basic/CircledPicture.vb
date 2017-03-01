Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging

Public Class CircledPicture
    Inherits PictureBox

    Protected Overrides Sub OnPaint(e As PaintEventArgs)

        Dim brushImage As System.Drawing.Brush
        Dim dx As Integer = 2
        Dim dy As Integer = 2

        Try
            Dim Imagem As New Bitmap(Image)

            'get images of the same size as control
            Imagem = New Bitmap(Imagem, New Size(Width - dx, Height - dy))
            brushImage = New TextureBrush(Imagem)

        Catch ex As Exception
            Dim Imagem As Bitmap = New Bitmap(Me.Width - dx, Me.Height - dy, PixelFormat.Format24bppRgb)
            Using grp As Graphics = Graphics.FromImage(Imagem)
                grp.FillRectangle(Brushes.White, 0, 0, Width - dx, Height - dy)
                Imagem = New Bitmap(Width - dx, Height - dy, grp)

            End Using
            brushImage = New TextureBrush(Imagem)

        End Try

        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias

        Dim path As GraphicsPath = New GraphicsPath()
        path.AddEllipse(0, 0, Width - dx, Height - dy)
        e.Graphics.FillPath(brushImage, path)
        Dim p As New Pen(Color.Black, CInt((dx + dy) / 2))
        e.Graphics.DrawPath(p, path)
    End Sub

End Class