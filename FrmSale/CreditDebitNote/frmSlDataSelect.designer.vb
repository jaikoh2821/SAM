<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSlDataSelect
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
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSlDataSelect))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.lblDateSaleD = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblPsCus = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblDocCode = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GCSale = New DevExpress.XtraGrid.GridControl()
        Me.GVSale = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColSelect = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rptSel = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.colDateSaleD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPdCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLotNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAmtSale = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColUnitName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColPriceSale = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidSale = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidSaleDt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rptSelect = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.btnSelectAll = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.GCSale, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVSale, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptSel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptSelect, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Appearance.BackColor = System.Drawing.Color.Lavender
        Me.PanelControl1.Appearance.BackColor2 = System.Drawing.Color.LightSteelBlue
        Me.PanelControl1.Appearance.Options.UseBackColor = True
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.lblDateSaleD)
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.lblPsCus)
        Me.PanelControl1.Controls.Add(Me.Label6)
        Me.PanelControl1.Controls.Add(Me.lblDocCode)
        Me.PanelControl1.Controls.Add(Me.Label3)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(718, 73)
        Me.PanelControl1.TabIndex = 0
        Me.PanelControl1.TabStop = True
        '
        'lblDateSaleD
        '
        Me.lblDateSaleD.BackColor = System.Drawing.Color.Gainsboro
        Me.lblDateSaleD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDateSaleD.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateSaleD.Location = New System.Drawing.Point(131, 36)
        Me.lblDateSaleD.Name = "lblDateSaleD"
        Me.lblDateSaleD.Size = New System.Drawing.Size(161, 20)
        Me.lblDateSaleD.TabIndex = 985
        Me.lblDateSaleD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(78, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 14)
        Me.Label1.TabIndex = 984
        Me.Label1.Text = "วันที่ขาย"
        '
        'lblPsCus
        '
        Me.lblPsCus.BackColor = System.Drawing.Color.Gainsboro
        Me.lblPsCus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPsCus.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPsCus.Location = New System.Drawing.Point(392, 9)
        Me.lblPsCus.Name = "lblPsCus"
        Me.lblPsCus.Size = New System.Drawing.Size(196, 47)
        Me.lblPsCus.TabIndex = 982
        Me.lblPsCus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(347, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 14)
        Me.Label6.TabIndex = 981
        Me.Label6.Text = "ลูกค้า"
        '
        'lblDocCode
        '
        Me.lblDocCode.BackColor = System.Drawing.Color.Gainsboro
        Me.lblDocCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDocCode.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDocCode.Location = New System.Drawing.Point(131, 9)
        Me.lblDocCode.Name = "lblDocCode"
        Me.lblDocCode.Size = New System.Drawing.Size(161, 20)
        Me.lblDocCode.TabIndex = 980
        Me.lblDocCode.Text = "- - - - - - - - - - - -"
        Me.lblDocCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(35, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 14)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "เลขที่อ้างอิงขาย"
        '
        'GCSale
        '
        Me.GCSale.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCSale.Location = New System.Drawing.Point(0, 105)
        Me.GCSale.MainView = Me.GVSale
        Me.GCSale.Name = "GCSale"
        Me.GCSale.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rptSelect, Me.rptSel})
        Me.GCSale.Size = New System.Drawing.Size(718, 492)
        Me.GCSale.TabIndex = 1
        Me.GCSale.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVSale})
        '
        'GVSale
        '
        Me.GVSale.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GVSale.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GVSale.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVSale.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVSale.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GVSale.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GVSale.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.GVSale.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.GVSale.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVSale.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVSale.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GVSale.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GVSale.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVSale.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.GVSale.Appearance.Empty.Options.UseBackColor = True
        Me.GVSale.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.GVSale.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GVSale.Appearance.EvenRow.Options.UseBackColor = True
        Me.GVSale.Appearance.EvenRow.Options.UseForeColor = True
        Me.GVSale.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GVSale.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GVSale.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVSale.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GVSale.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GVSale.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GVSale.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVSale.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.GVSale.Appearance.FilterPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GVSale.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVSale.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GVSale.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GVSale.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVSale.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GVSale.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GVSale.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVSale.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVSale.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GVSale.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.GVSale.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVSale.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVSale.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GVSale.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GVSale.Appearance.FooterPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVSale.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVSale.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVSale.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GVSale.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GVSale.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GVSale.Appearance.GroupButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVSale.Appearance.GroupButton.Options.UseBackColor = True
        Me.GVSale.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GVSale.Appearance.GroupButton.Options.UseForeColor = True
        Me.GVSale.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.GVSale.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.GVSale.Appearance.GroupFooter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVSale.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVSale.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GVSale.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GVSale.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVSale.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.GVSale.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.GVSale.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GVSale.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVSale.Appearance.GroupRow.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GVSale.Appearance.GroupRow.BorderColor = System.Drawing.Color.LightSteelBlue
        Me.GVSale.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.GVSale.Appearance.GroupRow.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GVSale.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVSale.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GVSale.Appearance.GroupRow.Options.UseFont = True
        Me.GVSale.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVSale.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.GVSale.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.GVSale.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVSale.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVSale.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVSale.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GVSale.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.GVSale.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVSale.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVSale.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVSale.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GVSale.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVSale.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.GVSale.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GVSale.Appearance.OddRow.Options.UseBackColor = True
        Me.GVSale.Appearance.OddRow.Options.UseForeColor = True
        Me.GVSale.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.GVSale.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.GVSale.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GVSale.Appearance.Preview.Options.UseBackColor = True
        Me.GVSale.Appearance.Preview.Options.UseFont = True
        Me.GVSale.Appearance.Preview.Options.UseForeColor = True
        Me.GVSale.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.GVSale.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GVSale.Appearance.Row.Options.UseBackColor = True
        Me.GVSale.Appearance.Row.Options.UseForeColor = True
        Me.GVSale.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVSale.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.GVSale.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GVSale.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.GVSale.Appearance.SelectedRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVSale.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVSale.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GVSale.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GVSale.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GVSale.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GVSale.Appearance.VertLine.Options.UseBackColor = True
        Me.GVSale.ColumnPanelRowHeight = 35
        Me.GVSale.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColSelect, Me.colDateSaleD, Me.colPdCode, Me.colProductName, Me.colLotNo, Me.colAmtSale, Me.ColUnitName, Me.ColPriceSale, Me.colidSale, Me.colidSaleDt})
        Me.GVSale.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GVSale.GridControl = Me.GCSale
        Me.GVSale.GroupFormat = " [#image]{1} {2}"
        Me.GVSale.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Amount", Nothing, "(คงเหลือ {0:#,##0.####})")})
        Me.GVSale.Name = "GVSale"
        Me.GVSale.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDown
        Me.GVSale.OptionsDetail.AllowOnlyOneMasterRowExpanded = True
        Me.GVSale.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GVSale.OptionsView.EnableAppearanceEvenRow = True
        Me.GVSale.OptionsView.EnableAppearanceOddRow = True
        Me.GVSale.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GVSale.OptionsView.ShowGroupPanel = False
        Me.GVSale.OptionsView.ShowIndicator = False
        Me.GVSale.PaintStyleName = "MixedXP"
        Me.GVSale.ScrollStyle = DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.None
        '
        'ColSelect
        '
        Me.ColSelect.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ColSelect.AppearanceHeader.Options.UseFont = True
        Me.ColSelect.AppearanceHeader.Options.UseTextOptions = True
        Me.ColSelect.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColSelect.Caption = "เลือก"
        Me.ColSelect.ColumnEdit = Me.rptSel
        Me.ColSelect.FieldName = "chk"
        Me.ColSelect.MaxWidth = 45
        Me.ColSelect.MinWidth = 45
        Me.ColSelect.Name = "ColSelect"
        Me.ColSelect.Visible = True
        Me.ColSelect.VisibleIndex = 0
        Me.ColSelect.Width = 45
        '
        'rptSel
        '
        Me.rptSel.AutoHeight = False
        Me.rptSel.Name = "rptSel"
        '
        'colDateSaleD
        '
        Me.colDateSaleD.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.colDateSaleD.AppearanceCell.Options.UseBackColor = True
        Me.colDateSaleD.AppearanceCell.Options.UseTextOptions = True
        Me.colDateSaleD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDateSaleD.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colDateSaleD.AppearanceHeader.Options.UseFont = True
        Me.colDateSaleD.AppearanceHeader.Options.UseTextOptions = True
        Me.colDateSaleD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDateSaleD.Caption = "วันที่ขาย"
        Me.colDateSaleD.FieldName = "DateSaleD"
        Me.colDateSaleD.MaxWidth = 100
        Me.colDateSaleD.MinWidth = 100
        Me.colDateSaleD.Name = "colDateSaleD"
        Me.colDateSaleD.OptionsColumn.AllowEdit = False
        Me.colDateSaleD.OptionsColumn.ReadOnly = True
        Me.colDateSaleD.Width = 100
        '
        'colPdCode
        '
        Me.colPdCode.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colPdCode.AppearanceCell.Options.UseBackColor = True
        Me.colPdCode.AppearanceCell.Options.UseTextOptions = True
        Me.colPdCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colPdCode.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colPdCode.AppearanceHeader.Options.UseFont = True
        Me.colPdCode.AppearanceHeader.Options.UseTextOptions = True
        Me.colPdCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPdCode.Caption = "รหัสสินค้า"
        Me.colPdCode.FieldName = "InvCode"
        Me.colPdCode.MinWidth = 75
        Me.colPdCode.Name = "colPdCode"
        Me.colPdCode.OptionsColumn.AllowEdit = False
        Me.colPdCode.OptionsColumn.ReadOnly = True
        Me.colPdCode.OptionsColumn.TabStop = False
        Me.colPdCode.Visible = True
        Me.colPdCode.VisibleIndex = 1
        Me.colPdCode.Width = 226
        '
        'colProductName
        '
        Me.colProductName.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.colProductName.AppearanceCell.Options.UseBackColor = True
        Me.colProductName.AppearanceCell.Options.UseTextOptions = True
        Me.colProductName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colProductName.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colProductName.AppearanceHeader.Options.UseFont = True
        Me.colProductName.AppearanceHeader.Options.UseTextOptions = True
        Me.colProductName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colProductName.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colProductName.Caption = "รายการสินค้า"
        Me.colProductName.FieldName = "ProductName"
        Me.colProductName.MinWidth = 200
        Me.colProductName.Name = "colProductName"
        Me.colProductName.OptionsColumn.AllowEdit = False
        Me.colProductName.OptionsColumn.ReadOnly = True
        Me.colProductName.OptionsColumn.TabStop = False
        Me.colProductName.Visible = True
        Me.colProductName.VisibleIndex = 2
        Me.colProductName.Width = 381
        '
        'colLotNo
        '
        Me.colLotNo.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.colLotNo.AppearanceCell.Options.UseBackColor = True
        Me.colLotNo.AppearanceCell.Options.UseTextOptions = True
        Me.colLotNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLotNo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colLotNo.AppearanceHeader.Options.UseFont = True
        Me.colLotNo.AppearanceHeader.Options.UseTextOptions = True
        Me.colLotNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLotNo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colLotNo.Caption = "Lot No."
        Me.colLotNo.FieldName = "LotNo"
        Me.colLotNo.MinWidth = 100
        Me.colLotNo.Name = "colLotNo"
        Me.colLotNo.OptionsColumn.AllowEdit = False
        Me.colLotNo.OptionsColumn.ReadOnly = True
        Me.colLotNo.OptionsColumn.TabStop = False
        Me.colLotNo.Visible = True
        Me.colLotNo.VisibleIndex = 3
        Me.colLotNo.Width = 421
        '
        'colAmtSale
        '
        Me.colAmtSale.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.colAmtSale.AppearanceCell.Options.UseBackColor = True
        Me.colAmtSale.AppearanceCell.Options.UseTextOptions = True
        Me.colAmtSale.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colAmtSale.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colAmtSale.AppearanceHeader.Options.UseFont = True
        Me.colAmtSale.AppearanceHeader.Options.UseTextOptions = True
        Me.colAmtSale.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colAmtSale.Caption = "จำนวนขาย"
        Me.colAmtSale.DisplayFormat.FormatString = "#,##0.00##"
        Me.colAmtSale.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colAmtSale.FieldName = "AmtSale"
        Me.colAmtSale.MaxWidth = 100
        Me.colAmtSale.MinWidth = 100
        Me.colAmtSale.Name = "colAmtSale"
        Me.colAmtSale.OptionsColumn.AllowEdit = False
        Me.colAmtSale.OptionsColumn.ReadOnly = True
        Me.colAmtSale.OptionsColumn.TabStop = False
        Me.colAmtSale.Visible = True
        Me.colAmtSale.VisibleIndex = 5
        Me.colAmtSale.Width = 100
        '
        'ColUnitName
        '
        Me.ColUnitName.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColUnitName.AppearanceCell.Options.UseBackColor = True
        Me.ColUnitName.AppearanceCell.Options.UseTextOptions = True
        Me.ColUnitName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColUnitName.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColUnitName.AppearanceHeader.Options.UseFont = True
        Me.ColUnitName.AppearanceHeader.Options.UseTextOptions = True
        Me.ColUnitName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColUnitName.Caption = "หน่วย"
        Me.ColUnitName.FieldName = "UnitName"
        Me.ColUnitName.MaxWidth = 55
        Me.ColUnitName.MinWidth = 55
        Me.ColUnitName.Name = "ColUnitName"
        Me.ColUnitName.OptionsColumn.AllowEdit = False
        Me.ColUnitName.OptionsColumn.ReadOnly = True
        Me.ColUnitName.OptionsColumn.TabStop = False
        Me.ColUnitName.Visible = True
        Me.ColUnitName.VisibleIndex = 4
        Me.ColUnitName.Width = 55
        '
        'ColPriceSale
        '
        Me.ColPriceSale.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColPriceSale.AppearanceCell.Options.UseBackColor = True
        Me.ColPriceSale.AppearanceCell.Options.UseTextOptions = True
        Me.ColPriceSale.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ColPriceSale.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ColPriceSale.AppearanceHeader.Options.UseFont = True
        Me.ColPriceSale.AppearanceHeader.Options.UseTextOptions = True
        Me.ColPriceSale.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColPriceSale.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColPriceSale.Caption = "มูลค่าเดิม"
        Me.ColPriceSale.DisplayFormat.FormatString = "#,##0.00##"
        Me.ColPriceSale.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.ColPriceSale.FieldName = "Price"
        Me.ColPriceSale.MaxWidth = 100
        Me.ColPriceSale.MinWidth = 100
        Me.ColPriceSale.Name = "ColPriceSale"
        Me.ColPriceSale.OptionsColumn.AllowEdit = False
        Me.ColPriceSale.OptionsColumn.ReadOnly = True
        Me.ColPriceSale.OptionsColumn.TabStop = False
        Me.ColPriceSale.Visible = True
        Me.ColPriceSale.VisibleIndex = 6
        Me.ColPriceSale.Width = 100
        '
        'colidSale
        '
        Me.colidSale.Caption = "idSale"
        Me.colidSale.FieldName = "idSale"
        Me.colidSale.Name = "colidSale"
        '
        'colidSaleDt
        '
        Me.colidSaleDt.Caption = "idSaleDt"
        Me.colidSaleDt.FieldName = "idSaleDt"
        Me.colidSaleDt.Name = "colidSaleDt"
        '
        'rptSelect
        '
        Me.rptSelect.AutoHeight = False
        Me.rptSelect.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Global.SAM.My.Resources.Resources.arrow_modify_old_undo_icone_3957_16, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.rptSelect.Name = "rptSelect"
        Me.rptSelect.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'btnSelectAll
        '
        Me.btnSelectAll.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectAll.Appearance.Options.UseFont = True
        Me.btnSelectAll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSelectAll.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnSelectAll.Image = Global.SAM.My.Resources.Resources.P_Down_24
        Me.btnSelectAll.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnSelectAll.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnSelectAll.Location = New System.Drawing.Point(0, 0)
        Me.btnSelectAll.Name = "btnSelectAll"
        Me.btnSelectAll.Size = New System.Drawing.Size(129, 32)
        Me.btnSelectAll.TabIndex = 0
        Me.btnSelectAll.Text = " เลือกทั้งหมด"
        '
        'PanelControl3
        '
        Me.PanelControl3.Appearance.BackColor = System.Drawing.Color.Cornsilk
        Me.PanelControl3.Appearance.BackColor2 = System.Drawing.Color.DarkGray
        Me.PanelControl3.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.PanelControl3.Appearance.Options.UseBackColor = True
        Me.PanelControl3.Appearance.Options.UseFont = True
        Me.PanelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl3.Controls.Add(Me.btnSelectAll)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl3.Location = New System.Drawing.Point(0, 73)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(718, 32)
        Me.PanelControl3.TabIndex = 0
        '
        'PanelControl2
        '
        Me.PanelControl2.Appearance.BackColor = System.Drawing.Color.LightSteelBlue
        Me.PanelControl2.Appearance.BackColor2 = System.Drawing.Color.CornflowerBlue
        Me.PanelControl2.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.PanelControl2.Appearance.Options.UseBackColor = True
        Me.PanelControl2.Appearance.Options.UseFont = True
        Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl2.Controls.Add(Me.SimpleButton1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 597)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(718, 32)
        Me.PanelControl2.TabIndex = 2
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SimpleButton1.Dock = System.Windows.Forms.DockStyle.Right
        Me.SimpleButton1.Image = Global.SAM.My.Resources.Resources.OK
        Me.SimpleButton1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.SimpleButton1.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.SimpleButton1.Location = New System.Drawing.Point(602, 0)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(116, 32)
        Me.SimpleButton1.TabIndex = 0
        Me.SimpleButton1.Text = " เลือก"
        '
        'frmSlDataSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(718, 629)
        Me.Controls.Add(Me.GCSale)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSlDataSelect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "เลือกรายการขายสินค้า"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.GCSale, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVSale, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptSel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptSelect, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GCSale As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVSale As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColSelect As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rptSelect As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents colProductName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPdCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAmtSale As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblDocCode As System.Windows.Forms.Label
    Friend WithEvents colLotNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDateSaleD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colidSale As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rptSel As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents ColPriceSale As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colidSaleDt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColUnitName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblPsCus As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnSelectAll As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblDateSaleD As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
End Class
