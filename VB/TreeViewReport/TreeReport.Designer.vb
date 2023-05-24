Namespace TreeViewReport

    Partial Class TreeReport

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
            Me.xrSubreport1 = New DevExpress.XtraReports.UI.XRSubreport()
            Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.Level = New DevExpress.XtraReports.Parameters.Parameter()
            Me.bindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
            CType((Me.bindingSource1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me), System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrSubreport1})
            Me.Detail.Dpi = 100F
            Me.Detail.HeightF = 21.95833F
            Me.Detail.KeepTogether = True
            Me.Detail.KeepTogetherWithDetailReports = True
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrSubreport1
            ' 
            Me.xrSubreport1.Dpi = 100F
            Me.xrSubreport1.LocationFloat = New DevExpress.Utils.PointFloat(2.384186E-05F, 0F)
            Me.xrSubreport1.Name = "xrSubreport1"
            Me.xrSubreport1.SizeF = New System.Drawing.SizeF(750F, 21.95833F)
            AddHandler Me.xrSubreport1.BeforePrint, New DevExpress.XtraReports.UI.BeforePrintEventHandler(AddressOf Me.xrSubreport1_BeforePrint)
            ' 
            ' TopMargin
            ' 
            Me.TopMargin.Dpi = 100F
            Me.TopMargin.HeightF = 50F
            Me.TopMargin.Name = "TopMargin"
            Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' BottomMargin
            ' 
            Me.BottomMargin.Dpi = 100F
            Me.BottomMargin.HeightF = 50F
            Me.BottomMargin.Name = "BottomMargin"
            Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 5, 5, 100F)
            Me.BottomMargin.StylePriority.UsePadding = False
            Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' Level
            ' 
            Me.Level.Description = "Maximum tree level"
            Me.Level.Name = "Level"
            Me.Level.Type = GetType(Integer)
            Me.Level.ValueInfo = "4"
            ' 
            ' bindingSource1
            ' 
            Me.bindingSource1.DataSource = GetType(TreeViewReport.ParentNode)
            ' 
            ' TreeReport
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin})
            Me.DataSource = Me.bindingSource1
            Me.Margins = New DevExpress.Drawing.DXMargins(50, 50, 50, 50)
            Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.Level})
            Me.ReportPrintOptions.PrintOnEmptyDataSource = False
            Me.Version = "16.1"
            CType((Me.bindingSource1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me), System.ComponentModel.ISupportInitialize).EndInit()
        End Sub

#End Region
        Private Detail As DevExpress.XtraReports.UI.DetailBand

        Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand

        Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand

        Private bindingSource1 As System.Windows.Forms.BindingSource

        Private Level As DevExpress.XtraReports.Parameters.Parameter

        Private xrSubreport1 As DevExpress.XtraReports.UI.XRSubreport
    End Class
End Namespace
