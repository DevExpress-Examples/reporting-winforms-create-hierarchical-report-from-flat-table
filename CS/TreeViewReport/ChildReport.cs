using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.Drawing.Printing;

namespace TreeViewReport {
    public partial class ChildReport : DevExpress.XtraReports.UI.XtraReport {
        public ChildReport() {
            InitializeComponent();
        }

        private void xrSubreport1_BeforePrint(object sender, CancelEventArgs e) {
            XRSubreport subReport = sender as XRSubreport;
            ParentNode parentNode = this.GetCurrentRow() as ParentNode;
            ChildReport childReport = new ChildReport();
            childReport.Parameters["Level"].Value = this.Parameters["Level"].Value;
            childReport.DataSource = parentNode.Children;
            subReport.ReportSource = childReport;
            childReport.ReduceControlSize(subReport, parentNode.Level);
        }

        void ReduceControlSize(XRSubreport subreport, int level) {
            XtraReport report = subreport.ReportSource;
            report.PaperKind = DXPaperKind.Custom;
            report.PageWidth = (int)(PrintingSystem.PageSettings.UsablePageSize.Width - subreport.LocationF.X * (level - 1) + report.Margins.Right);
            subreport.WidthF = report.PageWidth;
            foreach(Band band in report.Bands)
                foreach(XRControl control in band.Controls) {
                    if(control is XRTable)
                        (control as XRTable).WidthF = subreport.SizeF.Width;
                }
        }
    }
}
