﻿Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI

''' <summary>
''' Summary description for CategoriesReport
''' </summary>
Public Class CategoriesReport
    Inherits DevExpress.XtraReports.UI.XtraReport

    Private sqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
    Private topMarginBand1 As TopMarginBand
    Private bottomMarginBand1 As BottomMarginBand
    Private xrPageInfo1 As XRPageInfo
    Private xrPageInfo2 As XRPageInfo
    Private reportHeaderBand1 As ReportHeaderBand
    Private xrLabel1 As XRLabel
    Private groupHeaderBand1 As GroupHeaderBand
    Private xrPanel1 As XRPanel
    Private xrTable1 As XRTable
    Private xrTableRow1 As XRTableRow
    Private xrTableCell1 As XRTableCell
    Private xrTableCell2 As XRTableCell
    Private xrTableCell3 As XRTableCell
    Private xrTableCell4 As XRTableCell
    Private detailBand1 As DetailBand
    Private xrTable2 As XRTable
    Private xrTableRow2 As XRTableRow
    Private xrTableCell5 As XRTableCell
    Private xrTableCell6 As XRTableCell
    Private xrTableCell7 As XRTableCell
    Private xrTableCell8 As XRTableCell
    Private xrPictureBox1 As XRPictureBox
    Private Title As XRControlStyle
    Private DetailCaption3 As XRControlStyle
    Private DetailData3 As XRControlStyle
    Private DetailData3_Odd As XRControlStyle
    Private DetailCaptionBackground3 As XRControlStyle
    Private PageInfo As XRControlStyle

    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    Public Sub New()
        InitializeComponent()
        '
        ' TODO: Add constructor logic here
        '
    End Sub

    ''' <summary> 
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
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
        Dim selectQuery1 As New DevExpress.DataAccess.Sql.SelectQuery()
        Dim column1 As New DevExpress.DataAccess.Sql.Column()
        Dim columnExpression1 As New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim table1 As New DevExpress.DataAccess.Sql.Table()
        Dim column2 As New DevExpress.DataAccess.Sql.Column()
        Dim columnExpression2 As New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim column3 As New DevExpress.DataAccess.Sql.Column()
        Dim columnExpression3 As New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim column4 As New DevExpress.DataAccess.Sql.Column()
        Dim columnExpression4 As New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(CategoriesReport))
        Me.sqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
        Me.topMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.bottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.xrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.xrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.reportHeaderBand1 = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.groupHeaderBand1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.xrPanel1 = New DevExpress.XtraReports.UI.XRPanel()
        Me.xrTable1 = New DevExpress.XtraReports.UI.XRTable()
        Me.xrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.xrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.detailBand1 = New DevExpress.XtraReports.UI.DetailBand()
        Me.xrTable2 = New DevExpress.XtraReports.UI.XRTable()
        Me.xrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.xrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.xrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.Title = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.DetailCaption3 = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.DetailData3 = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.DetailData3_Odd = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.DetailCaptionBackground3 = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.PageInfo = New DevExpress.XtraReports.UI.XRControlStyle()
        DirectCast(Me.xrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        DirectCast(Me.xrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        ' 
        ' sqlDataSource1
        ' 
        Me.sqlDataSource1.ConnectionName = "NWindConnectionString"
        Me.sqlDataSource1.Name = "sqlDataSource1"
        columnExpression1.ColumnName = "CategoryID"
        table1.MetaSerializable = Nothing
        table1.Name = "Categories"
        columnExpression1.Table = table1
        column1.Expression = columnExpression1
        columnExpression2.ColumnName = "CategoryName"
        columnExpression2.Table = table1
        column2.Expression = columnExpression2
        columnExpression3.ColumnName = "Description"
        columnExpression3.Table = table1
        column3.Expression = columnExpression3
        columnExpression4.ColumnName = "Picture"
        columnExpression4.Table = table1
        column4.Expression = columnExpression4
        selectQuery1.Columns.Add(column1)
        selectQuery1.Columns.Add(column2)
        selectQuery1.Columns.Add(column3)
        selectQuery1.Columns.Add(column4)
        selectQuery1.MetaSerializable = Nothing
        selectQuery1.Name = "Categories"
        selectQuery1.Tables.Add(table1)
        Me.sqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {selectQuery1})
        Me.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable")
        ' 
        ' topMarginBand1
        ' 
        Me.topMarginBand1.HeightF = 100.0F
        Me.topMarginBand1.Name = "topMarginBand1"
        ' 
        ' bottomMarginBand1
        ' 
        Me.bottomMarginBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrPageInfo1, Me.xrPageInfo2})
        Me.bottomMarginBand1.HeightF = 100.0F
        Me.bottomMarginBand1.Name = "bottomMarginBand1"
        ' 
        ' xrPageInfo1
        ' 
        Me.xrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(6.0F, 6.0F)
        Me.xrPageInfo1.Name = "xrPageInfo1"
        Me.xrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0F)
        Me.xrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.xrPageInfo1.SizeF = New System.Drawing.SizeF(313.0F, 23.0F)
        Me.xrPageInfo1.StyleName = "PageInfo"
        ' 
        ' xrPageInfo2
        ' 
        Me.xrPageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(331.0F, 6.0F)
        Me.xrPageInfo2.Name = "xrPageInfo2"
        Me.xrPageInfo2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0F)
        Me.xrPageInfo2.SizeF = New System.Drawing.SizeF(313.0F, 23.0F)
        Me.xrPageInfo2.StyleName = "PageInfo"
        Me.xrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.xrPageInfo2.TextFormatString = "Page {0} of {1}"
        ' 
        ' reportHeaderBand1
        ' 
        Me.reportHeaderBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel1})
        Me.reportHeaderBand1.HeightF = 60.0F
        Me.reportHeaderBand1.Name = "reportHeaderBand1"
        ' 
        ' xrLabel1
        ' 
        Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(6.0F, 6.0F)
        Me.xrLabel1.Name = "xrLabel1"
        Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0F)
        Me.xrLabel1.SizeF = New System.Drawing.SizeF(638.0F, 26.0F)
        Me.xrLabel1.StyleName = "Title"
        Me.xrLabel1.Text = "Categories Report"
        ' 
        ' groupHeaderBand1
        ' 
        Me.groupHeaderBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrPanel1})
        Me.groupHeaderBand1.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail
        Me.groupHeaderBand1.HeightF = 48.0F
        Me.groupHeaderBand1.Name = "groupHeaderBand1"
        ' 
        ' xrPanel1
        ' 
        Me.xrPanel1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrTable1})
        Me.xrPanel1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
        Me.xrPanel1.Name = "xrPanel1"
        Me.xrPanel1.SizeF = New System.Drawing.SizeF(650.0F, 48.0F)
        Me.xrPanel1.StyleName = "DetailCaptionBackground3"
        ' 
        ' xrTable1
        ' 
        Me.xrTable1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 20.0F)
        Me.xrTable1.Name = "xrTable1"
        Me.xrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.xrTableRow1})
        Me.xrTable1.SizeF = New System.Drawing.SizeF(650.0F, 28.0F)
        ' 
        ' xrTableRow1
        ' 
        Me.xrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell1, Me.xrTableCell2, Me.xrTableCell3, Me.xrTableCell4})
        Me.xrTableRow1.Name = "xrTableRow1"
        Me.xrTableRow1.Weight = 1.0R
        ' 
        ' xrTableCell1
        ' 
        Me.xrTableCell1.Name = "xrTableCell1"
        Me.xrTableCell1.StyleName = "DetailCaption3"
        Me.xrTableCell1.StylePriority.UseTextAlignment = False
        Me.xrTableCell1.Text = "Category ID"
        Me.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.xrTableCell1.Weight = 0.26058631310096153R
        ' 
        ' xrTableCell2
        ' 
        Me.xrTableCell2.Name = "xrTableCell2"
        Me.xrTableCell2.StyleName = "DetailCaption3"
        Me.xrTableCell2.Text = "Category Name"
        Me.xrTableCell2.Weight = 0.2006807326518093R
        ' 
        ' xrTableCell3
        ' 
        Me.xrTableCell3.Name = "xrTableCell3"
        Me.xrTableCell3.StyleName = "DetailCaption3"
        Me.xrTableCell3.Text = "Description"
        Me.xrTableCell3.Weight = 0.36935182725654409R
        ' 
        ' xrTableCell4
        ' 
        Me.xrTableCell4.Name = "xrTableCell4"
        Me.xrTableCell4.StyleName = "DetailCaption3"
        Me.xrTableCell4.Text = "Picture"
        Me.xrTableCell4.Weight = 0.169381103515625R
        ' 
        ' detailBand1
        ' 
        Me.detailBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrTable2})
        Me.detailBand1.HeightF = 25.0F
        Me.detailBand1.Name = "detailBand1"
        ' 
        ' xrTable2
        ' 
        Me.xrTable2.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
        Me.xrTable2.Name = "xrTable2"
        Me.xrTable2.OddStyleName = "DetailData3_Odd"
        Me.xrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.xrTableRow2})
        Me.xrTable2.SizeF = New System.Drawing.SizeF(650.0F, 25.0F)
        ' 
        ' xrTableRow2
        ' 
        Me.xrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell5, Me.xrTableCell6, Me.xrTableCell7, Me.xrTableCell8})
        Me.xrTableRow2.Name = "xrTableRow2"
        Me.xrTableRow2.Weight = 11.5R
        ' 
        ' xrTableCell5
        ' 
        Me.xrTableCell5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.CategoryID")})
        Me.xrTableCell5.Name = "xrTableCell5"
        Me.xrTableCell5.StyleName = "DetailData3"
        Me.xrTableCell5.StylePriority.UseTextAlignment = False
        Me.xrTableCell5.Text = "xrTableCell5"
        Me.xrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.xrTableCell5.Weight = 0.26058631310096153R
        ' 
        ' xrTableCell6
        ' 
        Me.xrTableCell6.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.CategoryName")})
        Me.xrTableCell6.Name = "xrTableCell6"
        Me.xrTableCell6.StyleName = "DetailData3"
        Me.xrTableCell6.Text = "xrTableCell6"
        Me.xrTableCell6.Weight = 0.2006807326518093R
        ' 
        ' xrTableCell7
        ' 
        Me.xrTableCell7.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.Description")})
        Me.xrTableCell7.Name = "xrTableCell7"
        Me.xrTableCell7.StyleName = "DetailData3"
        Me.xrTableCell7.Text = "xrTableCell7"
        Me.xrTableCell7.Weight = 0.36935182725654409R
        ' 
        ' xrPictureBox1
        ' 
        Me.xrPictureBox1.AnchorHorizontal = (CType((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right), DevExpress.XtraReports.UI.HorizontalAnchorStyles))
        Me.xrPictureBox1.AnchorVertical = (CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles))
        Me.xrPictureBox1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Image", Nothing, "Categories.Picture")})
        Me.xrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
        Me.xrPictureBox1.Name = "xrPictureBox1"
        Me.xrPictureBox1.SizeF = New System.Drawing.SizeF(110.0977F, 25.0F)
        Me.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        ' 
        ' xrTableCell8
        ' 
        Me.xrTableCell8.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrPictureBox1})
        Me.xrTableCell8.Name = "xrTableCell8"
        Me.xrTableCell8.StyleName = "DetailData3"
        Me.xrTableCell8.Text = "xrTableCell8"
        Me.xrTableCell8.Weight = 0.169381103515625R
        ' 
        ' Title
        ' 
        Me.Title.BackColor = System.Drawing.Color.Transparent
        Me.Title.BorderColor = System.Drawing.Color.Black
        Me.Title.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Title.BorderWidth = 1.0F
        Me.Title.Font = New System.Drawing.Font("Tahoma", 14.0F)
        Me.Title.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(75)))), (CInt((CByte(75)))), (CInt((CByte(75)))))
        Me.Title.Name = "Title"
        ' 
        ' DetailCaption3
        ' 
        Me.DetailCaption3.BackColor = System.Drawing.Color.Transparent
        Me.DetailCaption3.BorderColor = System.Drawing.Color.Transparent
        Me.DetailCaption3.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.DetailCaption3.Font = New System.Drawing.Font("Tahoma", 8.0F, System.Drawing.FontStyle.Bold)
        Me.DetailCaption3.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(75)))), (CInt((CByte(75)))), (CInt((CByte(75)))))
        Me.DetailCaption3.Name = "DetailCaption3"
        Me.DetailCaption3.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100.0F)
        Me.DetailCaption3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        ' 
        ' DetailData3
        ' 
        Me.DetailData3.Font = New System.Drawing.Font("Tahoma", 8.0F)
        Me.DetailData3.ForeColor = System.Drawing.Color.Black
        Me.DetailData3.Name = "DetailData3"
        Me.DetailData3.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100.0F)
        Me.DetailData3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        ' 
        ' DetailData3_Odd
        ' 
        Me.DetailData3_Odd.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(231)))), (CInt((CByte(231)))), (CInt((CByte(231)))))
        Me.DetailData3_Odd.BorderColor = System.Drawing.Color.Transparent
        Me.DetailData3_Odd.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.DetailData3_Odd.BorderWidth = 1.0F
        Me.DetailData3_Odd.Font = New System.Drawing.Font("Tahoma", 8.0F)
        Me.DetailData3_Odd.ForeColor = System.Drawing.Color.Black
        Me.DetailData3_Odd.Name = "DetailData3_Odd"
        Me.DetailData3_Odd.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100.0F)
        Me.DetailData3_Odd.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        ' 
        ' DetailCaptionBackground3
        ' 
        Me.DetailCaptionBackground3.BackColor = System.Drawing.Color.Transparent
        Me.DetailCaptionBackground3.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(206)))), (CInt((CByte(206)))), (CInt((CByte(206)))))
        Me.DetailCaptionBackground3.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.DetailCaptionBackground3.BorderWidth = 2.0F
        Me.DetailCaptionBackground3.Name = "DetailCaptionBackground3"
        ' 
        ' PageInfo
        ' 
        Me.PageInfo.Font = New System.Drawing.Font("Tahoma", 8.0F, System.Drawing.FontStyle.Bold)
        Me.PageInfo.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(75)))), (CInt((CByte(75)))), (CInt((CByte(75)))))
        Me.PageInfo.Name = "PageInfo"
        Me.PageInfo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F)
        ' 
        ' CategoriesReport
        ' 
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.topMarginBand1, Me.bottomMarginBand1, Me.reportHeaderBand1, Me.groupHeaderBand1, Me.detailBand1})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.sqlDataSource1})
        Me.DataMember = "Categories"
        Me.DataSource = Me.sqlDataSource1
        Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.Title, Me.DetailCaption3, Me.DetailData3, Me.DetailData3_Odd, Me.DetailCaptionBackground3, Me.PageInfo})
        Me.Version = "17.2"
        DirectCast(Me.xrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        DirectCast(Me.xrTable2, System.ComponentModel.ISupportInitialize).EndInit()
        DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

#End Region
End Class
