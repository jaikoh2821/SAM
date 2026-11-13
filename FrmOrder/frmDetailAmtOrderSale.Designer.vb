<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetailAmtOrderSale
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetailAmtOrderSale))
        Me.GCOrderSale = New DevExpress.XtraGrid.GridControl()
        Me.GVOrderSale = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColNum = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDateSale = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDocCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDocRef = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLotNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColAmount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColPsTs = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DateTimeTs = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidsale = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidSaleDt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rptAmtSale = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
        Me.rptProcessName = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.rptDocCode = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.lblInvName = New System.Windows.Forms.Label()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.lblDocCodeRef = New System.Windows.Forms.Label()
        CType(Me.GCOrderSale, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVOrderSale, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptAmtSale, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptProcessName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptDocCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GCOrderSale
        '
        Me.GCOrderSale.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCOrderSale.Location = New System.Drawing.Point(0, 54)
        Me.GCOrderSale.MainView = Me.GVOrderSale
        Me.GCOrderSale.Name = "GCOrderSale"
        Me.GCOrderSale.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rptAmtSale, Me.rptProcessName, Me.rptDocCode})
        Me.GCOrderSale.Size = New System.Drawing.Size(959, 483)
        Me.GCOrderSale.TabIndex = 736
        Me.GCOrderSale.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVOrderSale})
        '
        'GVOrderSale
        '
        Me.GVOrderSale.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVOrderSale.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVOrderSale.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GVOrderSale.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVOrderSale.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GVOrderSale.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GVOrderSale.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GVOrderSale.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GVOrderSale.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GVOrderSale.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVOrderSale.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GVOrderSale.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GVOrderSale.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVOrderSale.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.GVOrderSale.Appearance.Empty.Options.UseBackColor = True
        Me.GVOrderSale.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.GVOrderSale.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.GVOrderSale.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GVOrderSale.Appearance.EvenRow.Options.UseBackColor = True
        Me.GVOrderSale.Appearance.EvenRow.Options.UseBorderColor = True
        Me.GVOrderSale.Appearance.EvenRow.Options.UseForeColor = True
        Me.GVOrderSale.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVOrderSale.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVOrderSale.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GVOrderSale.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GVOrderSale.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GVOrderSale.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GVOrderSale.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVOrderSale.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.GVOrderSale.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVOrderSale.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVOrderSale.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GVOrderSale.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.GVOrderSale.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVOrderSale.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GVOrderSale.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GVOrderSale.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVOrderSale.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVOrderSale.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GVOrderSale.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.GVOrderSale.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVOrderSale.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVOrderSale.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVOrderSale.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVOrderSale.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GVOrderSale.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVOrderSale.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVOrderSale.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVOrderSale.Appearance.FooterPanel.Options.UseFont = True
        Me.GVOrderSale.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GVOrderSale.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.GVOrderSale.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.GVOrderSale.Appearance.GroupButton.Options.UseBackColor = True
        Me.GVOrderSale.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GVOrderSale.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GVOrderSale.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GVOrderSale.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GVOrderSale.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVOrderSale.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GVOrderSale.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GVOrderSale.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVOrderSale.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.GVOrderSale.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.GVOrderSale.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GVOrderSale.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVOrderSale.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GVOrderSale.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GVOrderSale.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GVOrderSale.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVOrderSale.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GVOrderSale.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVOrderSale.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GVOrderSale.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GVOrderSale.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GVOrderSale.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVOrderSale.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVOrderSale.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GVOrderSale.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GVOrderSale.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.GVOrderSale.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVOrderSale.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVOrderSale.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.GVOrderSale.Appearance.HorzLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.GVOrderSale.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVOrderSale.Appearance.HorzLine.Options.UseBorderColor = True
        Me.GVOrderSale.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVOrderSale.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVOrderSale.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GVOrderSale.Appearance.OddRow.Options.UseBackColor = True
        Me.GVOrderSale.Appearance.OddRow.Options.UseBorderColor = True
        Me.GVOrderSale.Appearance.OddRow.Options.UseForeColor = True
        Me.GVOrderSale.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.GVOrderSale.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.GVOrderSale.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.GVOrderSale.Appearance.Preview.Options.UseBackColor = True
        Me.GVOrderSale.Appearance.Preview.Options.UseFont = True
        Me.GVOrderSale.Appearance.Preview.Options.UseForeColor = True
        Me.GVOrderSale.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVOrderSale.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GVOrderSale.Appearance.Row.Options.UseBackColor = True
        Me.GVOrderSale.Appearance.Row.Options.UseForeColor = True
        Me.GVOrderSale.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVOrderSale.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.GVOrderSale.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GVOrderSale.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.GVOrderSale.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.GVOrderSale.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVOrderSale.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GVOrderSale.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GVOrderSale.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GVOrderSale.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.GVOrderSale.Appearance.VertLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.GVOrderSale.Appearance.VertLine.Options.UseBackColor = True
        Me.GVOrderSale.Appearance.VertLine.Options.UseBorderColor = True
        Me.GVOrderSale.ColumnPanelRowHeight = 35
        Me.GVOrderSale.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColNum, Me.ColDateSale, Me.ColDocCode, Me.ColDocRef, Me.colLotNo, Me.ColAmount, Me.colUnitName, Me.ColPsTs, Me.DateTimeTs, Me.colidsale, Me.colidSaleDt})
        Me.GVOrderSale.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GVOrderSale.GridControl = Me.GCOrderSale
        Me.GVOrderSale.GroupFormat = "[#image]{1} {2}"
        Me.GVOrderSale.Name = "GVOrderSale"
        Me.GVOrderSale.OptionsView.EnableAppearanceEvenRow = True
        Me.GVOrderSale.OptionsView.EnableAppearanceOddRow = True
        Me.GVOrderSale.OptionsView.RowAutoHeight = True
        Me.GVOrderSale.OptionsView.ShowFooter = True
        Me.GVOrderSale.OptionsView.ShowGroupPanel = False
        Me.GVOrderSale.OptionsView.ShowIndicator = False
        Me.GVOrderSale.PaintStyleName = "Flat"
        Me.GVOrderSale.RowHeight = 25
        '
        'ColNum
        '
        Me.ColNum.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.ColNum.AppearanceCell.Options.UseFont = True
        Me.ColNum.AppearanceCell.Options.UseTextOptions = True
        Me.ColNum.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColNum.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColNum.AppearanceHeader.Options.UseFont = True
        Me.ColNum.AppearanceHeader.Options.UseTextOptions = True
        Me.ColNum.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColNum.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColNum.Caption = "ลำดับ"
        Me.ColNum.MaxWidth = 55
        Me.ColNum.MinWidth = 55
        Me.ColNum.Name = "ColNum"
        Me.ColNum.OptionsColumn.AllowEdit = False
        Me.ColNum.OptionsColumn.ReadOnly = True
        Me.ColNum.Visible = True
        Me.ColNum.VisibleIndex = 0
        Me.ColNum.Width = 55
        '
        'ColDateSale
        '
        Me.ColDateSale.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.ColDateSale.AppearanceCell.Options.UseFont = True
        Me.ColDateSale.AppearanceCell.Options.UseTextOptions = True
        Me.ColDateSale.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.ColDateSale.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.ColDateSale.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColDateSale.AppearanceHeader.Options.UseFont = True
        Me.ColDateSale.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDateSale.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDateSale.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColDateSale.Caption = "วันที่ขาย"
        Me.ColDateSale.FieldName = "DateSaleD"
        Me.ColDateSale.MaxWidth = 85
        Me.ColDateSale.MinWidth = 85
        Me.ColDateSale.Name = "ColDateSale"
        Me.ColDateSale.OptionsColumn.AllowEdit = False
        Me.ColDateSale.OptionsColumn.ReadOnly = True
        Me.ColDateSale.Visible = True
        Me.ColDateSale.VisibleIndex = 1
        Me.ColDateSale.Width = 85
        '
        'ColDocCode
        '
        Me.ColDocCode.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColDocCode.AppearanceCell.Options.UseFont = True
        Me.ColDocCode.AppearanceCell.Options.UseTextOptions = True
        Me.ColDocCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.ColDocCode.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColDocCode.AppearanceHeader.Options.UseFont = True
        Me.ColDocCode.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDocCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDocCode.Caption = "เลขที่เอกสาร"
        Me.ColDocCode.FieldName = "DocCode"
        Me.ColDocCode.MinWidth = 100
        Me.ColDocCode.Name = "ColDocCode"
        Me.ColDocCode.OptionsColumn.AllowEdit = False
        Me.ColDocCode.OptionsColumn.ReadOnly = True
        Me.ColDocCode.Visible = True
        Me.ColDocCode.VisibleIndex = 2
        Me.ColDocCode.Width = 104
        '
        'ColDocRef
        '
        Me.ColDocRef.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.ColDocRef.AppearanceCell.Options.UseFont = True
        Me.ColDocRef.AppearanceCell.Options.UseTextOptions = True
        Me.ColDocRef.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.ColDocRef.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.ColDocRef.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColDocRef.AppearanceHeader.Options.UseFont = True
        Me.ColDocRef.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDocRef.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDocRef.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColDocRef.Caption = "เลขที่อ้างอิงขาย"
        Me.ColDocRef.FieldName = "DocRef"
        Me.ColDocRef.MinWidth = 100
        Me.ColDocRef.Name = "ColDocRef"
        Me.ColDocRef.OptionsColumn.AllowEdit = False
        Me.ColDocRef.OptionsColumn.ReadOnly = True
        Me.ColDocRef.Visible = True
        Me.ColDocRef.VisibleIndex = 3
        Me.ColDocRef.Width = 126
        '
        'colLotNo
        '
        Me.colLotNo.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.colLotNo.AppearanceCell.Options.UseFont = True
        Me.colLotNo.AppearanceCell.Options.UseTextOptions = True
        Me.colLotNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLotNo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.colLotNo.AppearanceHeader.Options.UseFont = True
        Me.colLotNo.AppearanceHeader.Options.UseTextOptions = True
        Me.colLotNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLotNo.Caption = "Lot No."
        Me.colLotNo.FieldName = "LotNo"
        Me.colLotNo.MinWidth = 80
        Me.colLotNo.Name = "colLotNo"
        Me.colLotNo.OptionsColumn.AllowEdit = False
        Me.colLotNo.OptionsColumn.ReadOnly = True
        Me.colLotNo.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom, "LotNo", "รวมจำนวนที่ขายแล้ว")})
        Me.colLotNo.Visible = True
        Me.colLotNo.VisibleIndex = 4
        Me.colLotNo.Width = 106
        '
        'ColAmount
        '
        Me.ColAmount.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.ColAmount.AppearanceCell.Options.UseFont = True
        Me.ColAmount.AppearanceCell.Options.UseTextOptions = True
        Me.ColAmount.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ColAmount.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColAmount.AppearanceHeader.Options.UseFont = True
        Me.ColAmount.AppearanceHeader.Options.UseTextOptions = True
        Me.ColAmount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColAmount.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColAmount.Caption = "จำนวนขาย"
        Me.ColAmount.DisplayFormat.FormatString = "#,##0.00##"
        Me.ColAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColAmount.FieldName = "Amount"
        Me.ColAmount.MaxWidth = 100
        Me.ColAmount.MinWidth = 100
        Me.ColAmount.Name = "ColAmount"
        Me.ColAmount.OptionsColumn.AllowEdit = False
        Me.ColAmount.OptionsColumn.ReadOnly = True
        Me.ColAmount.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Amount", "{0:#,##0.00##}")})
        Me.ColAmount.Visible = True
        Me.ColAmount.VisibleIndex = 5
        Me.ColAmount.Width = 100
        '
        'colUnitName
        '
        Me.colUnitName.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.colUnitName.AppearanceCell.Options.UseFont = True
        Me.colUnitName.AppearanceCell.Options.UseTextOptions = True
        Me.colUnitName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colUnitName.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.colUnitName.AppearanceHeader.Options.UseFont = True
        Me.colUnitName.AppearanceHeader.Options.UseTextOptions = True
        Me.colUnitName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colUnitName.Caption = "หน่วย"
        Me.colUnitName.FieldName = "UnitName"
        Me.colUnitName.MaxWidth = 55
        Me.colUnitName.MinWidth = 55
        Me.colUnitName.Name = "colUnitName"
        Me.colUnitName.OptionsColumn.AllowEdit = False
        Me.colUnitName.OptionsColumn.ReadOnly = True
        Me.colUnitName.Visible = True
        Me.colUnitName.VisibleIndex = 6
        Me.colUnitName.Width = 55
        '
        'ColPsTs
        '
        Me.ColPsTs.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColPsTs.AppearanceCell.Options.UseFont = True
        Me.ColPsTs.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColPsTs.AppearanceHeader.Options.UseFont = True
        Me.ColPsTs.AppearanceHeader.Options.UseTextOptions = True
        Me.ColPsTs.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColPsTs.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColPsTs.Caption = "ผู้ทำรายการ"
        Me.ColPsTs.FieldName = "PsTsName"
        Me.ColPsTs.MinWidth = 80
        Me.ColPsTs.Name = "ColPsTs"
        Me.ColPsTs.OptionsColumn.AllowEdit = False
        Me.ColPsTs.OptionsColumn.ReadOnly = True
        Me.ColPsTs.Visible = True
        Me.ColPsTs.VisibleIndex = 7
        Me.ColPsTs.Width = 129
        '
        'DateTimeTs
        '
        Me.DateTimeTs.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.DateTimeTs.AppearanceCell.Options.UseFont = True
        Me.DateTimeTs.AppearanceCell.Options.UseTextOptions = True
        Me.DateTimeTs.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.DateTimeTs.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.DateTimeTs.AppearanceHeader.Options.UseFont = True
        Me.DateTimeTs.AppearanceHeader.Options.UseTextOptions = True
        Me.DateTimeTs.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.DateTimeTs.Caption = "เวลา"
        Me.DateTimeTs.FieldName = "TimeTs"
        Me.DateTimeTs.MaxWidth = 55
        Me.DateTimeTs.MinWidth = 55
        Me.DateTimeTs.Name = "DateTimeTs"
        Me.DateTimeTs.OptionsColumn.AllowEdit = False
        Me.DateTimeTs.OptionsColumn.ReadOnly = True
        Me.DateTimeTs.Visible = True
        Me.DateTimeTs.VisibleIndex = 8
        Me.DateTimeTs.Width = 55
        '
        'colidsale
        '
        Me.colidsale.Caption = "idSale"
        Me.colidsale.FieldName = "idSale"
        Me.colidsale.Name = "colidsale"
        '
        'colidSaleDt
        '
        Me.colidSaleDt.Caption = "idSaleDt"
        Me.colidSaleDt.FieldName = "idSaleDt"
        Me.colidSaleDt.Name = "colidSaleDt"
        '
        'rptAmtSale
        '
        Me.rptAmtSale.AutoHeight = False
        Me.rptAmtSale.Name = "rptAmtSale"
        '
        'rptProcessName
        '
        Me.rptProcessName.Appearance.Options.UseTextOptions = True
        Me.rptProcessName.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.rptProcessName.Name = "rptProcessName"
        '
        'rptDocCode
        '
        Me.rptDocCode.Appearance.Options.UseTextOptions = True
        Me.rptDocCode.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.rptDocCode.Name = "rptDocCode"
        '
        'PanelControl1
        '
        Me.PanelControl1.Appearance.BackColor = System.Drawing.Color.Lavender
        Me.PanelControl1.Appearance.BackColor2 = System.Drawing.Color.LightSteelBlue
        Me.PanelControl1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.PanelControl1.Appearance.Options.UseBackColor = True
        Me.PanelControl1.Appearance.Options.UseFont = True
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.lblInvName)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Controls.Add(Me.lblDocCodeRef)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(959, 54)
        Me.PanelControl1.TabIndex = 737
        '
        'lblInvName
        '
        Me.lblInvName.BackColor = System.Drawing.Color.Transparent
        Me.lblInvName.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblInvName.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblInvName.Location = New System.Drawing.Point(48, 27)
        Me.lblInvName.Name = "lblInvName"
        Me.lblInvName.Size = New System.Drawing.Size(768, 23)
        Me.lblInvName.TabIndex = 584
        Me.lblInvName.Text = "ชื่อสินค้า : XXXX "
        Me.lblInvName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Image = CType(resources.GetObject("LabelControl1.Appearance.Image"), System.Drawing.Image)
        Me.LabelControl1.Location = New System.Drawing.Point(10, 7)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(32, 32)
        Me.LabelControl1.TabIndex = 583
        '
        'lblDocCodeRef
        '
        Me.lblDocCodeRef.BackColor = System.Drawing.Color.Transparent
        Me.lblDocCodeRef.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblDocCodeRef.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblDocCodeRef.Location = New System.Drawing.Point(48, 4)
        Me.lblDocCodeRef.Name = "lblDocCodeRef"
        Me.lblDocCodeRef.Size = New System.Drawing.Size(768, 23)
        Me.lblDocCodeRef.TabIndex = 579
        Me.lblDocCodeRef.Text = "เลขที่คำสั่งซื้อ (อ้างอิง) : XXXX"
        Me.lblDocCodeRef.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmDetailAmtOrderSale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(959, 537)
        Me.Controls.Add(Me.GCOrderSale)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDetailAmtOrderSale"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "รายละเอียดการขายสินค้าจากคำสั่งซื้อ"
        CType(Me.GCOrderSale, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVOrderSale, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptAmtSale, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptProcessName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptDocCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GCOrderSale As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVOrderSale As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColNum As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDocRef As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rptDocCode As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents ColDateSale As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rptProcessName As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents ColAmount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLotNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColPsTs As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colidsale As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colidSaleDt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rptAmtSale As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblDocCodeRef As Label
    Friend WithEvents ColDocCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblInvName As Label
    Friend WithEvents DateTimeTs As DevExpress.XtraGrid.Columns.GridColumn
End Class
