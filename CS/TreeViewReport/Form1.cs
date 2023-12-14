namespace TreeViewReport {
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm {
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
