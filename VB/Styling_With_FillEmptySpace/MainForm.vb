Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraReports.UI

Namespace StylingWithFillEmptySpace

    Public Partial Class MainForm
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub MainForm_Load(ByVal sender As Object, ByVal e As EventArgs)
            Dim report As XtraReport1 = New XtraReport1()
            Dim tool As ReportPrintTool = New ReportPrintTool(report)
            tool.ShowPreviewDialog()
            Close()
        End Sub
    End Class
End Namespace
