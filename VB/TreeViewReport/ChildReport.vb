Imports System.Drawing
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI
Imports DevExpress.Drawing.Printing

Namespace TreeViewReport

    Public Partial Class ChildReport
        Inherits XtraReport

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub xrSubreport1_BeforePrint(ByVal sender As Object, ByVal e As CancelEventArgs)
            Dim subReport As XRSubreport = TryCast(sender, XRSubreport)
            Dim parentNode As ParentNode = TryCast(GetCurrentRow(), ParentNode)
            Dim childReport As ChildReport = New ChildReport()
            childReport.Parameters("Level").Value = Parameters("Level").Value
            childReport.DataSource = parentNode.Children
            subReport.ReportSource = childReport
            childReport.ReduceControlSize(subReport, parentNode.Level)
        End Sub

        Private Sub ReduceControlSize(ByVal subreport As XRSubreport, ByVal level As Integer)
            Dim report As XtraReport = subreport.ReportSource
            report.PaperKind = DXPaperKind.Custom
            report.PageWidth = CInt(PrintingSystem.PageSettings.UsablePageSize.Width - subreport.LocationF.X * (level - 1) + report.Margins.Right)
            subreport.WidthF = report.PageWidth
            For Each band As Band In report.Bands
                For Each control As XRControl In band.Controls
                    If TypeOf control Is XRTable Then TryCast(control, XRTable).WidthF = subreport.SizeF.Width
                Next
            Next
        End Sub
    End Class
End Namespace
