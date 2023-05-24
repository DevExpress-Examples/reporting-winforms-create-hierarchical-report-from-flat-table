Imports System.ComponentModel
Imports System.Drawing

Namespace TreeViewReport

    Public Partial Class Form1
        Inherits DevExpress.XtraEditors.XtraForm

        Private report As TreeReport

        Public Sub New()
            InitializeComponent()
            report = New TreeReport(Me)
            documentViewer1.DocumentSource = report
            treeList1.KeyFieldName = "Key"
            treeList1.ParentFieldName = "ParentKey"
        End Sub
    End Class
End Namespace
