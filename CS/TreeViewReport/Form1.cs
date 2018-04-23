using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TreeViewReport {
    public partial class Form1 : DevExpress.XtraEditors.XtraForm {
        TreeReport report;
        public Form1() {
            InitializeComponent();
            report = new TreeReport(this);
            documentViewer1.DocumentSource = report;
            treeList1.KeyFieldName = "Key";
            treeList1.ParentFieldName = "ParentKey";
        }
    }
}
