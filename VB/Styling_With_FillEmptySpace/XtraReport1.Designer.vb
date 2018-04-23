Imports Microsoft.VisualBasic
Imports System
Namespace StylingWithFillEmptySpace
	Partial Public Class XtraReport1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.dummyDetailBandLabel = New DevExpress.XtraReports.UI.XRLabel()
			Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
			Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
			Me.oddStyle = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.evenStyle = New DevExpress.XtraReports.UI.XRControlStyle()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.dummyDetailBandLabel})
			Me.Detail.EvenStyleName = "evenStyle"
			Me.Detail.Height = 25
			Me.Detail.KeepTogether = True
			Me.Detail.Name = "Detail"
			Me.Detail.OddStyleName = "oddStyle"
			Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.Detail.RepeatCountOnEmptyDataSource = 100
			Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
'			Me.Detail.BeforePrint += New System.Drawing.Printing.PrintEventHandler(Me.Detail_BeforePrint);
			' 
			' dummyDetailBandLabel
			' 
			Me.dummyDetailBandLabel.Borders = DevExpress.XtraPrinting.BorderSide.None
			Me.dummyDetailBandLabel.Location = New System.Drawing.Point(0, 0)
			Me.dummyDetailBandLabel.Name = "dummyDetailBandLabel"
			Me.dummyDetailBandLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.dummyDetailBandLabel.Size = New System.Drawing.Size(650, 25)
			Me.dummyDetailBandLabel.StylePriority.UseBorders = False
			Me.dummyDetailBandLabel.Text = "Some Detail band content here.."
			' 
			' PageHeader
			' 
			Me.PageHeader.Height = 30
			Me.PageHeader.Name = "PageHeader"
			Me.PageHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' PageFooter
			' 
			Me.PageFooter.Height = 30
			Me.PageFooter.Name = "PageFooter"
			Me.PageFooter.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' oddStyle
			' 
			Me.oddStyle.BackColor = System.Drawing.Color.Khaki
			Me.oddStyle.Name = "oddStyle"
			Me.oddStyle.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			' 
			' evenStyle
			' 
			Me.evenStyle.BackColor = System.Drawing.Color.LightBlue
			Me.evenStyle.Name = "evenStyle"
			Me.evenStyle.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			' 
			' XtraReport1
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.PageHeader, Me.PageFooter})
			Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() { Me.oddStyle, Me.evenStyle})
			Me.Version = "8.1"
'			Me.FillEmptySpace += New DevExpress.XtraReports.UI.BandEventHandler(Me.XtraReport1_FillEmptySpace);
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
		Private PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
		Private PageFooter As DevExpress.XtraReports.UI.PageFooterBand
		Private dummyDetailBandLabel As DevExpress.XtraReports.UI.XRLabel
		Private oddStyle As DevExpress.XtraReports.UI.XRControlStyle
		Private evenStyle As DevExpress.XtraReports.UI.XRControlStyle
	End Class
End Namespace
