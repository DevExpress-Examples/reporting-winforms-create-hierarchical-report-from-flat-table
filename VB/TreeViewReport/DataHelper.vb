Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text

Namespace TreeViewReport
	Public Class DataHelper
        Private level_Renamed As Integer
		Private nodesCount As Integer
        Private nodesList_Renamed As List(Of ParentNode)
		Private rows As List(Of DataRow)
		Private dataTable As DataTable

		Public ReadOnly Property ReportDataSource() As DataTable
			Get
				Return dataTable
			End Get
		End Property

		Public Property Level() As Integer

		Public ReadOnly Property NodesList() As List(Of ParentNode)
			Get
				Return nodesList_Renamed
			End Get
		End Property

		Public Sub New(ByVal level As Integer)
			Me.Level = level
			GenerateDataTable()
			nodesList_Renamed = New List(Of ParentNode)()
			rows = dataTable.AsEnumerable().ToList()
			nodesCount = dataTable.Rows.Count - 1
			ParseTree(Nothing)
		End Sub

		Private Sub GenerateDataTable()
			dataTable = New DataTable()
			dataTable.Columns.Add("Key", GetType(Object))
			dataTable.Columns.Add("ParentKey", GetType(Object))
			dataTable.Columns.Add("Name", GetType(String))
			dataTable.Columns.Add("Description", GetType(String))
			dataTable.Rows.Add(0, Nothing, "RootNode", "RootNode")
			Dim parentKey As Integer = 0
			Dim currentKey As Integer = 1
			Dim rnd As New Random()
			For levelCount As Integer = 1 To Level
				Dim childCount As Integer = rnd.Next(1, 4)
				For j As Integer = 1 To childCount
					Dim name As String = String.Format("Child Node {0}", currentKey)
					Dim description As String = String.Format("Child Node {0} Parent {1}", currentKey, parentKey)
					dataTable.Rows.Add(currentKey, parentKey, name, description)
					currentKey += 1
				Next j
				parentKey += 1
			Next levelCount
		End Sub

		Private Function CreateNewNode(ByVal dataRow As DataRow) As ParentNode
			Dim node As New ParentNode()
			node.NodeKey = dataRow(0)
			node.ParentNodeKey = dataRow(1)
			node.NodeName = dataRow(2).ToString()
			node.NodeDescription = dataRow(3).ToString()
			node.Children = New List(Of ParentNode)()
			Return node
		End Function

		Private Sub ParseTree(ByVal parent As ParentNode)
			If parent IsNot Nothing Then 'create child nodes
				Dim foundRows As List(Of DataRow) = rows.FindAll(Function(x) x.ItemArray(1).Equals(parent.NodeKey))
				For Each row As DataRow In foundRows
					If nodesCount >= 0 Then
						Dim node As ParentNode = CreateNewNode(row)
						parent.Children.Add(node)
						level_Renamed += 1
						node.Level = level_Renamed
						ParseTree(node)
						nodesCount -= 1
						level_Renamed -= 1
					End If
				Next row ' create root ParentNode
			Else
				Dim foundRow As DataRow = rows.Find(Function(x) x.ItemArray(1).Equals(DBNull.Value))
				Dim node As ParentNode = CreateNewNode(foundRow)
				node.Level = level_Renamed
				nodesList_Renamed.Add(node)
				rows.Remove(foundRow)
				nodesCount -= 1
				ParseTree(node)
			End If
		End Sub
	End Class

	Public Class SimpleNode
		Public Property NodeKey() As Object
		Public Property ParentNodeKey() As Object
		Public Property NodeName() As String
		Public Property NodeDescription() As String
	End Class

	Public Class ParentNode
		Inherits SimpleNode

		Public Property Children() As List(Of ParentNode)
		Public Property Level() As Integer
	End Class
End Namespace
