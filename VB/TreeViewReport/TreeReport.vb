Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI
Imports System.Data
Imports System.Linq
Imports System.Collections.Generic

Namespace TreeViewReport
	Partial Public Class TreeReport
		Inherits DevExpress.XtraReports.UI.XtraReport

		Private nodesList As List(Of ParentNode)
        Private helper_Renamed As DataHelper
		Private parentForm As Form1
		Public ReadOnly Property Helper() As DataHelper
			Get
				Return Me.helper_Renamed
			End Get
		End Property
		Public Sub New()
			InitializeComponent()
			AddHandler Me.ParametersRequestSubmit, AddressOf TreeReport_ParametersRequestSubmit
		End Sub

		Public Sub New(ByVal parentForm As Form1)
			InitializeComponent()
			Me.parentForm = parentForm
			AddHandler Me.ParametersRequestSubmit, AddressOf TreeReport_ParametersRequestSubmit
		End Sub


		Private Sub TreeReport_ParametersRequestSubmit(ByVal sender As Object, ByVal e As DevExpress.XtraReports.Parameters.ParametersRequestEventArgs)
            Dim level_Renamed As Integer = Convert.ToInt32(Me.Parameters("Level").Value)
			helper_Renamed = New DataHelper(level_Renamed)
			nodesList = helper_Renamed.NodesList
			Me.DataSource = nodesList
			Me.CreateDocument()
		End Sub

		Private Sub xrSubreport1_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles xrSubreport1.BeforePrint
			Dim subReport As XRSubreport = TryCast(sender, XRSubreport)
			Dim childReport As New ChildReport()
			childReport.Parameters("Level").Value = Me.Parameters("Level").Value
			childReport.DataSource = nodesList
			subReport.ReportSource = childReport
			parentForm.treeList1.DataSource = helper_Renamed.ReportDataSource
			parentForm.treeList1.ExpandAll()
		End Sub
	End Class
End Namespace
