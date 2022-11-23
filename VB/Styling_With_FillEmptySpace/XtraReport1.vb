Imports System
Imports System.Drawing
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraPrinting

Namespace StylingWithFillEmptySpace

    Public Partial Class XtraReport1
        Inherits XtraReport

        Public Sub New()
            InitializeComponent()
        End Sub

        Private detailCount As Integer = 0

        Private Sub Detail_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs)
            detailCount += 1
        End Sub

        Private Sub XtraReport1_FillEmptySpace(ByVal sender As Object, ByVal e As BandEventArgs)
            Dim labelsCount As Integer = Convert.ToInt32(e.Band.Height \ dummyDetailBandLabel.Height)
            Dim targetSize As Size = New Size(PageWidth - Margins.Left - Margins.Right, e.Band.Height)
            Dim labelSize As Size = New Size(dummyDetailBandLabel.Width, dummyDetailBandLabel.Height)
            Dim targetSizeInPixels As Size = GraphicsUnitConverter.Convert(targetSize, GraphicsDpi.HundredthsOfAnInch, GraphicsDpi.Pixel)
            Dim labelSizeInPixels As Size = GraphicsUnitConverter.Convert(labelSize, GraphicsDpi.HundredthsOfAnInch, GraphicsDpi.Pixel)
            Dim targetBitmap As Bitmap = New Bitmap(targetSizeInPixels.Width, targetSizeInPixels.Height)
            Dim gr As Graphics = Graphics.FromImage(targetBitmap)
            Dim pt As Point = New Point(0, 0)
            Dim sz As Size = New Size(targetSizeInPixels.Width, labelSizeInPixels.Height)
            For i As Integer = 0 To labelsCount - 1
                If i Mod 2 = 0 Then
                    gr.FillRectangle(Brushes.LightBlue, New Rectangle(pt, sz))
                Else
                    gr.FillRectangle(Brushes.Khaki, New Rectangle(pt, sz))
                End If

                pt.Y += labelSizeInPixels.Height
            Next

            Dim pictureBox As XRPictureBox = New XRPictureBox()
            pictureBox.BackColor = Color.Transparent
            pictureBox.Size = targetSize
            pictureBox.Location = New Point(0, 0)
            pictureBox.Image = targetBitmap
            e.Band.Controls.Add(pictureBox)
        End Sub
    End Class
End Namespace
