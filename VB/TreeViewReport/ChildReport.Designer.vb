Namespace TreeViewReport

    Partial Class ChildReport

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.xrTable1 = New DevExpress.XtraReports.UI.XRTable()
            Me.xrTableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.SubBand1 = New DevExpress.XtraReports.UI.SubBand()
            Me.xrSubreport1 = New DevExpress.XtraReports.UI.XRSubreport()
            Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.Title = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.FieldCaption = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.PageInfo = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.DataField = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.Level = New DevExpress.XtraReports.Parameters.Parameter()
            Me.objectDataSource1 = New DevExpress.DataAccess.ObjectBinding.ObjectDataSource(Me.components)
            CType((Me.xrTable1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.objectDataSource1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me), System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrTable1})
            Me.Detail.HeightF = 25F
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.Detail.StylePriority.UseBackColor = False
            Me.Detail.StylePriority.UseBorderColor = False
            Me.Detail.StylePriority.UseBorders = False
            Me.Detail.SubBands.AddRange(New DevExpress.XtraReports.UI.SubBand() {Me.SubBand1})
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrTable1
            ' 
            Me.xrTable1.AnchorHorizontal = DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left
            Me.xrTable1.BackColor = System.Drawing.Color.DarkKhaki
            Me.xrTable1.Borders = CType(((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom)), DevExpress.XtraPrinting.BorderSide)
            Me.xrTable1.CanPublish = False
            Me.xrTable1.KeepTogether = True
            Me.xrTable1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.xrTable1.Name = "xrTable1"
            Me.xrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.xrTableRow3})
            Me.xrTable1.SizeF = New System.Drawing.SizeF(750F, 25F)
            Me.xrTable1.StylePriority.UseBackColor = False
            Me.xrTable1.StylePriority.UseBorders = False
            ' 
            ' xrTableRow3
            ' 
            Me.xrTableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell7, Me.xrTableCell8, Me.xrTableCell9, Me.xrTableCell10})
            Me.xrTableRow3.Name = "xrTableRow3"
            Me.xrTableRow3.Weight = 11.5R
            ' 
            ' xrTableCell7
            ' 
            Me.xrTableCell7.BackColor = System.Drawing.Color.LightGray
            Me.xrTableCell7.CanPublish = False
            Me.xrTableCell7.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[NodeKey]")})
            Me.xrTableCell7.Name = "xrTableCell7"
            Me.xrTableCell7.StylePriority.UseBackColor = False
            Me.xrTableCell7.StylePriority.UseTextAlignment = False
            Me.xrTableCell7.Text = "xrTableCell7"
            Me.xrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.xrTableCell7.Weight = 0.10143790849673202R
            ' 
            ' xrTableCell8
            ' 
            Me.xrTableCell8.BackColor = System.Drawing.Color.LightGray
            Me.xrTableCell8.CanPublish = False
            Me.xrTableCell8.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ParentNodeKey]")})
            Me.xrTableCell8.Name = "xrTableCell8"
            Me.xrTableCell8.StylePriority.UseBackColor = False
            Me.xrTableCell8.StylePriority.UseTextAlignment = False
            Me.xrTableCell8.Text = "xrTableCell8"
            Me.xrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.xrTableCell8.Weight = 0.12549019607843134R
            ' 
            ' xrTableCell9
            ' 
            Me.xrTableCell9.BackColor = System.Drawing.Color.LightGray
            Me.xrTableCell9.CanPublish = False
            Me.xrTableCell9.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[NodeName]")})
            Me.xrTableCell9.Name = "xrTableCell9"
            Me.xrTableCell9.StylePriority.UseBackColor = False
            Me.xrTableCell9.StylePriority.UseTextAlignment = False
            Me.xrTableCell9.Text = "xrTableCell9"
            Me.xrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell9.Weight = 0.14640522875816997R
            ' 
            ' xrTableCell10
            ' 
            Me.xrTableCell10.BackColor = System.Drawing.Color.LightGray
            Me.xrTableCell10.CanShrink = True
            Me.xrTableCell10.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[NodeDescription]")})
            Me.xrTableCell10.Name = "xrTableCell10"
            Me.xrTableCell10.StylePriority.UseBackColor = False
            Me.xrTableCell10.StylePriority.UseTextAlignment = False
            Me.xrTableCell10.Text = "xrTableCell10"
            Me.xrTableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell10.Weight = 0.26392156862745086R
            ' 
            ' SubBand1
            ' 
            Me.SubBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrSubreport1})
            Me.SubBand1.HeightF = 20F
            Me.SubBand1.Name = "SubBand1"
            ' 
            ' xrSubreport1
            ' 
            Me.xrSubreport1.CanShrink = True
            Me.xrSubreport1.LocationFloat = New DevExpress.Utils.PointFloat(20F, 0F)
            Me.xrSubreport1.Name = "xrSubreport1"
            Me.xrSubreport1.SizeF = New System.Drawing.SizeF(730F, 20F)
            AddHandler Me.xrSubreport1.BeforePrint, New DevExpress.XtraReports.UI.BeforePrintEventHandler(AddressOf Me.xrSubreport1_BeforePrint)
            ' 
            ' TopMargin
            ' 
            Me.TopMargin.HeightF = 50F
            Me.TopMargin.Name = "TopMargin"
            Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' BottomMargin
            ' 
            Me.BottomMargin.HeightF = 50F
            Me.BottomMargin.Name = "BottomMargin"
            Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            ' 
            ' Title
            ' 
            Me.Title.BackColor = System.Drawing.Color.Transparent
            Me.Title.BorderColor = System.Drawing.Color.Black
            Me.Title.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.Title.BorderWidth = 1F
            Me.Title.Font = New DevExpress.Drawing.DXFont("Times New Roman", 20F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.Title.ForeColor = System.Drawing.Color.Maroon
            Me.Title.Name = "Title"
            ' 
            ' FieldCaption
            ' 
            Me.FieldCaption.BackColor = System.Drawing.Color.Transparent
            Me.FieldCaption.BorderColor = System.Drawing.Color.Black
            Me.FieldCaption.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            Me.FieldCaption.BorderWidth = 1F
            Me.FieldCaption.Font = New DevExpress.Drawing.DXFont("Arial", 10F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.FieldCaption.ForeColor = System.Drawing.Color.Maroon
            Me.FieldCaption.Name = "FieldCaption"
            ' 
            ' PageInfo
            ' 
            Me.PageInfo.BackColor = System.Drawing.Color.Transparent
            Me.PageInfo.BorderColor = System.Drawing.Color.Black
            Me.PageInfo.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.PageInfo.BorderWidth = 1F
            Me.PageInfo.Font = New DevExpress.Drawing.DXFont("Times New Roman", 10F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.PageInfo.ForeColor = System.Drawing.Color.Black
            Me.PageInfo.Name = "PageInfo"
            ' 
            ' DataField
            ' 
            Me.DataField.BackColor = System.Drawing.Color.Transparent
            Me.DataField.BorderColor = System.Drawing.Color.Black
            Me.DataField.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.DataField.BorderWidth = 1F
            Me.DataField.Font = New DevExpress.Drawing.DXFont("Times New Roman", 10F)
            Me.DataField.ForeColor = System.Drawing.Color.Black
            Me.DataField.Name = "DataField"
            Me.DataField.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' Level
            ' 
            Me.Level.Description = "Level"
            Me.Level.Name = "Level"
            Me.Level.Type = GetType(Integer)
            Me.Level.ValueInfo = "100"
            Me.Level.Visible = False
            ' 
            ' objectDataSource1
            ' 
            Me.objectDataSource1.DataSource = GetType(TreeViewReport.ParentNode)
            Me.objectDataSource1.Name = "objectDataSource1"
            ' 
            ' ChildReport
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin})
            Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.objectDataSource1})
            Me.DataSource = Me.objectDataSource1
            Me.Margins = New DevExpress.Drawing.DXMargins(50F, 50F, 50F, 50F)
            Me.PaperKind = DevExpress.Drawing.Printing.DXPaperKind.Custom
            Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.Level})
            Me.ReportPrintOptions.DetailCountOnEmptyDataSource = 0
            Me.ReportPrintOptions.PrintOnEmptyDataSource = False
            Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.Title, Me.FieldCaption, Me.PageInfo, Me.DataField})
            Me.Version = "23.1"
            CType((Me.xrTable1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.objectDataSource1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me), System.ComponentModel.ISupportInitialize).EndInit()
        End Sub

#End Region
        Private Detail As DevExpress.XtraReports.UI.DetailBand

        Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand

        Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand

        Private objectDataSource1 As DevExpress.DataAccess.ObjectBinding.ObjectDataSource

        Private Title As DevExpress.XtraReports.UI.XRControlStyle

        Private FieldCaption As DevExpress.XtraReports.UI.XRControlStyle

        Private PageInfo As DevExpress.XtraReports.UI.XRControlStyle

        Private DataField As DevExpress.XtraReports.UI.XRControlStyle

        Private Level As DevExpress.XtraReports.Parameters.Parameter

        Private xrTable1 As DevExpress.XtraReports.UI.XRTable

        Private xrTableRow3 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell7 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell8 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell9 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell10 As DevExpress.XtraReports.UI.XRTableCell

        Private SubBand1 As DevExpress.XtraReports.UI.SubBand

        Private xrSubreport1 As DevExpress.XtraReports.UI.XRSubreport
    End Class
End Namespace
