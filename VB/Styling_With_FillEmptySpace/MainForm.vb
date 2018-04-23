Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Namespace StylingWithFillEmptySpace
	Partial Public Class MainForm
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub MainForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Dim report As XtraReport1 = New XtraReport1()
			report.ShowPreviewDialog()
			Me.Close()
		End Sub
	End Class
End Namespace