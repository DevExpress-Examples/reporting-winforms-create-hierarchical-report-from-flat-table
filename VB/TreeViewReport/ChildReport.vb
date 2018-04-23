Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI

Namespace TreeViewReport
	Partial Public Class ChildReport
		Inherits DevExpress.XtraReports.UI.XtraReport

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub xrSubreport1_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles xrSubreport1.BeforePrint
			Dim subReport As XRSubreport = TryCast(sender, XRSubreport)
			Dim parentNode As ParentNode = TryCast(Me.GetCurrentRow(), ParentNode)
			Dim childReport As New ChildReport()
			childReport.Parameters("Level").Value = Me.Parameters("Level").Value
			childReport.DataSource = parentNode.Children
			subReport.ReportSource = childReport
			childReport.ReduceControlSize(subReport, parentNode.Level)
		End Sub

		Private Sub ReduceControlSize(ByVal subreport As XRSubreport, ByVal level As Integer)
            Dim report_Renamed As XtraReport = subreport.ReportSource
			report_Renamed.PaperKind = System.Drawing.Printing.PaperKind.Custom
			report_Renamed.PageWidth = CInt(Math.Truncate(PrintingSystem.PageSettings.UsablePageSize.Width - subreport.LocationF.X * (level - 1) + report_Renamed.Margins.Right))
			subreport.WidthF = report_Renamed.PageWidth
            For Each band_Renamed As Band In report_Renamed.Bands
                For Each control As XRControl In band_Renamed.Controls
                    If TypeOf control Is XRTable Then
                        TryCast(control, XRTable).WidthF = subreport.SizeF.Width
                    End If
                Next control
            Next band_Renamed
		End Sub
	End Class
End Namespace
