Imports System
Imports System.Drawing
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI
Imports System.Collections.Generic

Namespace TreeViewReport

    Public Partial Class TreeReport
        Inherits XtraReport

        Private nodesList As List(Of ParentNode)

        Private helperField As DataHelper

        Private parentForm As Form1

        Public ReadOnly Property Helper As DataHelper
            Get
                Return helperField
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            AddHandler ParametersRequestSubmit, AddressOf TreeReport_ParametersRequestSubmit
        End Sub

        Public Sub New(ByVal parentForm As Form1)
            InitializeComponent()
            Me.parentForm = parentForm
            AddHandler ParametersRequestSubmit, AddressOf TreeReport_ParametersRequestSubmit
        End Sub

        Private Sub TreeReport_ParametersRequestSubmit(ByVal sender As Object, ByVal e As DevExpress.XtraReports.Parameters.ParametersRequestEventArgs)
            Dim level As Integer = Convert.ToInt32(Parameters("Level").Value)
            helperField = New DataHelper(level)
            nodesList = helperField.NodesList
            DataSource = nodesList
            CreateDocument()
        End Sub

        Private Sub xrSubreport1_BeforePrint(ByVal sender As Object, ByVal e As CancelEventArgs)
            Dim subReport As XRSubreport = TryCast(sender, XRSubreport)
            Dim childReport As ChildReport = New ChildReport()
            childReport.Parameters("Level").Value = Parameters("Level").Value
            childReport.DataSource = nodesList
            subReport.ReportSource = childReport
            parentForm.treeList1.DataSource = helperField.ReportDataSource
            parentForm.treeList1.ExpandAll()
        End Sub
    End Class
End Namespace
