Imports DevExpress.XtraReports.UI
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Namespace TreeViewReport
	Partial Public Class Form1
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
