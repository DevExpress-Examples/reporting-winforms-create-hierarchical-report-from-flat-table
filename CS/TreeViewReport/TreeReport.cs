using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
using System.Linq;
using System.Collections.Generic;

namespace TreeViewReport {
    public partial class TreeReport : DevExpress.XtraReports.UI.XtraReport {
        List<ParentNode> nodesList;
        DataHelper helper;
        Form1 parentForm;
        public DataHelper Helper { 
            get {
                return this.helper;
            }
        }
        public TreeReport() {
            InitializeComponent();
            this.ParametersRequestSubmit += TreeReport_ParametersRequestSubmit;
        }

        public TreeReport(Form1 parentForm) {
            InitializeComponent();
            this.parentForm = parentForm;
            this.ParametersRequestSubmit += TreeReport_ParametersRequestSubmit;
        }
        

        void TreeReport_ParametersRequestSubmit(object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e) {
            int level = Convert.ToInt32(this.Parameters["Level"].Value);
            helper = new DataHelper(level);
            nodesList  = helper.NodesList;
            this.DataSource = nodesList;
            this.CreateDocument();
        }        

        private void xrSubreport1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) {
            XRSubreport subReport = sender as XRSubreport;                                    
            ChildReport childReport = new ChildReport();
            childReport.Parameters["Level"].Value = this.Parameters["Level"].Value;
            childReport.DataSource = nodesList;
            subReport.ReportSource = childReport;
            parentForm.treeList1.DataSource = helper.ReportDataSource;
            parentForm.treeList1.ExpandAll();
        }
    }
}
