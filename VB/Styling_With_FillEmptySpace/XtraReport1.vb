Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraPrinting

Namespace StylingWithFillEmptySpace
	Partial Public Class XtraReport1
		Inherits DevExpress.XtraReports.UI.XtraReport
		Public Sub New()
			InitializeComponent()
		End Sub

		Private detailCount As Integer = 0

		Private Sub Detail_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles Detail.BeforePrint
			detailCount += 1
		End Sub

		Private Sub XtraReport1_FillEmptySpace(ByVal sender As Object, ByVal e As BandEventArgs) Handles MyBase.FillEmptySpace
			Dim labelsCount As Integer = Convert.ToInt32(e.Band.Height \ Me.dummyDetailBandLabel.Height)
			Dim targetSize As New Size((Me.PageWidth - Me.Margins.Left - Me.Margins.Right), e.Band.Height)
			Dim labelSize As New Size(Me.dummyDetailBandLabel.Width, Me.dummyDetailBandLabel.Height)
			Dim targetSizeInPixels As Size = XRConvert.Convert(targetSize, GraphicsDpi.HundredthsOfAnInch, GraphicsDpi.Pixel)
			Dim labelSizeInPixels As Size = XRConvert.Convert(labelSize, GraphicsDpi.HundredthsOfAnInch, GraphicsDpi.Pixel)

			Dim targetBitmap As New Bitmap(targetSizeInPixels.Width, targetSizeInPixels.Height)
			Dim gr As Graphics = Graphics.FromImage(targetBitmap)
			Dim pt As New Point(0, 0)
			Dim sz As New Size(targetSizeInPixels.Width, labelSizeInPixels.Height)

			For i As Integer = 0 To labelsCount - 1
				If i Mod 2 = 0 Then
					gr.FillRectangle(Brushes.LightBlue, New Rectangle(pt, sz))
				Else
					gr.FillRectangle(Brushes.Khaki, New Rectangle(pt, sz))
				End If

				pt.Y += labelSizeInPixels.Height
			Next i

			Dim pictureBox As New XRPictureBox()
			pictureBox.BackColor = Color.Transparent
			pictureBox.Size = targetSize
			pictureBox.Location = New Point(0, 0)
			pictureBox.Image = targetBitmap
			e.Band.Controls.Add(pictureBox)
		End Sub
	End Class
End Namespace
