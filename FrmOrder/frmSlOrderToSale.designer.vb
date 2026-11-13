<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSlOrderToSale
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim GridFormatRule1 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleExpression1 As DevExpress.XtraEditors.FormatConditionRuleExpression = New DevExpress.XtraEditors.FormatConditionRuleExpression()
        Dim GridFormatRule2 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleExpression2 As DevExpress.XtraEditors.FormatConditionRuleExpression = New DevExpress.XtraEditors.FormatConditionRuleExpression()
        Dim GridFormatRule3 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleExpression3 As DevExpress.XtraEditors.FormatConditionRuleExpression = New DevExpress.XtraEditors.FormatConditionRuleExpression()
        Dim GridFormatRule4 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleExpression4 As DevExpress.XtraEditors.FormatConditionRuleExpression = New DevExpress.XtraEditors.FormatConditionRuleExpression()
        Dim GridFormatRule5 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleExpression5 As DevExpress.XtraEditors.FormatConditionRuleExpression = New DevExpress.XtraEditors.FormatConditionRuleExpression()
        Dim GridFormatRule6 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleExpression6 As DevExpress.XtraEditors.FormatConditionRuleExpression = New DevExpress.XtraEditors.FormatConditionRuleExpression()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSlOrderToSale))
        Me.GVSaleOrderDt = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GCSaleOrder = New DevExpress.XtraGrid.GridControl()
        Me.GVSaleOrder = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColidSaleOrder = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColidCancel1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColidComp = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColNum = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColSelMt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rptSel = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.ColCompCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDocCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DocCode_PO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColPartnerName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDateOrderD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDateReq = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColInvCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColInvName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rptInvName = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.ColAmount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColUnitOrder = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColPsSale1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColPsOrder1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColstSysText = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColNote1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCountDt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColstShow = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColAmtStock = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColidPartner = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldNET = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Col_i = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDtType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColpWeight = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColidUnitW = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColidInvGroup = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColWPerPack = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.chkDoc = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtDocCodePO = New System.Windows.Forms.TextBox()
        Me.cbDocCodePO = New System.Windows.Forms.CheckBox()
        Me.cbReadyToOrder = New System.Windows.Forms.CheckBox()
        Me.txtDocCode = New System.Windows.Forms.TextBox()
        Me.chkDocCode = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnCustomer = New DevExpress.XtraEditors.SimpleButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbGroupComp = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblPartner = New System.Windows.Forms.Label()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnSaleTs = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnRefresh = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.GVSaleOrderDt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCSaleOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVSaleOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptSel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptInvName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GVSaleOrderDt
        '
        Me.GVSaleOrderDt.ColumnPanelRowHeight = 35
        Me.GVSaleOrderDt.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        GridFormatRule1.Name = "Format0"
        FormatConditionRuleExpression1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        FormatConditionRuleExpression1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        FormatConditionRuleExpression1.Appearance.Options.UseBackColor = True
        FormatConditionRuleExpression1.Appearance.Options.UseFont = True
        FormatConditionRuleExpression1.Expression = "[status] = 'พร้อมขาย'"
        FormatConditionRuleExpression1.PredefinedName = "Green Text"
        GridFormatRule1.Rule = FormatConditionRuleExpression1
        GridFormatRule2.ApplyToRow = True
        GridFormatRule2.Name = "Format4"
        FormatConditionRuleExpression2.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        FormatConditionRuleExpression2.Appearance.Options.UseBackColor = True
        FormatConditionRuleExpression2.Expression = "[status] = 'พร้อมขาย'"
        GridFormatRule2.Rule = FormatConditionRuleExpression2
        GridFormatRule3.Name = "Format1"
        FormatConditionRuleExpression3.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        FormatConditionRuleExpression3.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        FormatConditionRuleExpression3.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        FormatConditionRuleExpression3.Appearance.Options.UseBackColor = True
        FormatConditionRuleExpression3.Appearance.Options.UseFont = True
        FormatConditionRuleExpression3.Appearance.Options.UseForeColor = True
        FormatConditionRuleExpression3.Expression = "[status] = 'อยู่ระหว่างผลิต'"
        GridFormatRule3.Rule = FormatConditionRuleExpression3
        GridFormatRule4.ApplyToRow = True
        GridFormatRule4.Name = "Format6"
        FormatConditionRuleExpression4.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        FormatConditionRuleExpression4.Appearance.Options.UseBackColor = True
        FormatConditionRuleExpression4.Expression = "[status] = 'อยู่ระหว่างผลิต'"
        GridFormatRule4.Rule = FormatConditionRuleExpression4
        GridFormatRule5.Name = "Format3"
        FormatConditionRuleExpression5.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        FormatConditionRuleExpression5.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        FormatConditionRuleExpression5.Appearance.ForeColor = System.Drawing.Color.Olive
        FormatConditionRuleExpression5.Appearance.Options.UseBackColor = True
        FormatConditionRuleExpression5.Appearance.Options.UseFont = True
        FormatConditionRuleExpression5.Appearance.Options.UseForeColor = True
        FormatConditionRuleExpression5.Expression = "[status] = 'รอผลิต'"
        GridFormatRule5.Rule = FormatConditionRuleExpression5
        GridFormatRule6.ApplyToRow = True
        GridFormatRule6.Name = "Format5"
        FormatConditionRuleExpression6.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        FormatConditionRuleExpression6.Appearance.Options.UseBackColor = True
        FormatConditionRuleExpression6.Expression = "[status] = 'รอผลิต'"
        GridFormatRule6.Rule = FormatConditionRuleExpression6
        Me.GVSaleOrderDt.FormatRules.Add(GridFormatRule1)
        Me.GVSaleOrderDt.FormatRules.Add(GridFormatRule2)
        Me.GVSaleOrderDt.FormatRules.Add(GridFormatRule3)
        Me.GVSaleOrderDt.FormatRules.Add(GridFormatRule4)
        Me.GVSaleOrderDt.FormatRules.Add(GridFormatRule5)
        Me.GVSaleOrderDt.FormatRules.Add(GridFormatRule6)
        Me.GVSaleOrderDt.GridControl = Me.GCSaleOrder
        Me.GVSaleOrderDt.Name = "GVSaleOrderDt"
        Me.GVSaleOrderDt.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GVSaleOrderDt.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.GVSaleOrderDt.OptionsView.ShowGroupPanel = False
        Me.GVSaleOrderDt.OptionsView.ShowIndicator = False
        '
        'GCSaleOrder
        '
        Me.GCSaleOrder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCSaleOrder.Location = New System.Drawing.Point(0, 154)
        Me.GCSaleOrder.MainView = Me.GVSaleOrder
        Me.GCSaleOrder.Name = "GCSaleOrder"
        Me.GCSaleOrder.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rptSel, Me.rptInvName})
        Me.GCSaleOrder.Size = New System.Drawing.Size(1145, 397)
        Me.GCSaleOrder.TabIndex = 793
        Me.GCSaleOrder.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVSaleOrder, Me.GVSaleOrderDt})
        '
        'GVSaleOrder
        '
        Me.GVSaleOrder.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GVSaleOrder.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GVSaleOrder.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVSaleOrder.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVSaleOrder.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GVSaleOrder.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GVSaleOrder.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.GVSaleOrder.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.GVSaleOrder.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVSaleOrder.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVSaleOrder.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GVSaleOrder.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GVSaleOrder.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVSaleOrder.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.GVSaleOrder.Appearance.Empty.Options.UseBackColor = True
        Me.GVSaleOrder.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.GVSaleOrder.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GVSaleOrder.Appearance.EvenRow.Options.UseBackColor = True
        Me.GVSaleOrder.Appearance.EvenRow.Options.UseForeColor = True
        Me.GVSaleOrder.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GVSaleOrder.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GVSaleOrder.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVSaleOrder.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GVSaleOrder.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GVSaleOrder.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GVSaleOrder.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVSaleOrder.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.GVSaleOrder.Appearance.FilterPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GVSaleOrder.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVSaleOrder.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GVSaleOrder.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GVSaleOrder.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVSaleOrder.Appearance.FocusedCell.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GVSaleOrder.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GVSaleOrder.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVSaleOrder.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVSaleOrder.Appearance.FocusedRow.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GVSaleOrder.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.GVSaleOrder.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVSaleOrder.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVSaleOrder.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GVSaleOrder.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GVSaleOrder.Appearance.FooterPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVSaleOrder.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVSaleOrder.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVSaleOrder.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GVSaleOrder.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GVSaleOrder.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GVSaleOrder.Appearance.GroupButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVSaleOrder.Appearance.GroupButton.Options.UseBackColor = True
        Me.GVSaleOrder.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GVSaleOrder.Appearance.GroupButton.Options.UseForeColor = True
        Me.GVSaleOrder.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.GVSaleOrder.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.GVSaleOrder.Appearance.GroupFooter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVSaleOrder.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVSaleOrder.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GVSaleOrder.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GVSaleOrder.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVSaleOrder.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.GVSaleOrder.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.GVSaleOrder.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GVSaleOrder.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVSaleOrder.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.GVSaleOrder.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.GVSaleOrder.Appearance.GroupRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVSaleOrder.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVSaleOrder.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GVSaleOrder.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVSaleOrder.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.GVSaleOrder.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.GVSaleOrder.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVSaleOrder.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVSaleOrder.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVSaleOrder.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GVSaleOrder.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.GVSaleOrder.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVSaleOrder.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVSaleOrder.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVSaleOrder.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GVSaleOrder.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVSaleOrder.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.GVSaleOrder.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GVSaleOrder.Appearance.OddRow.Options.UseBackColor = True
        Me.GVSaleOrder.Appearance.OddRow.Options.UseForeColor = True
        Me.GVSaleOrder.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.GVSaleOrder.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.GVSaleOrder.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GVSaleOrder.Appearance.Preview.Options.UseBackColor = True
        Me.GVSaleOrder.Appearance.Preview.Options.UseFont = True
        Me.GVSaleOrder.Appearance.Preview.Options.UseForeColor = True
        Me.GVSaleOrder.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.GVSaleOrder.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GVSaleOrder.Appearance.Row.Options.UseBackColor = True
        Me.GVSaleOrder.Appearance.Row.Options.UseForeColor = True
        Me.GVSaleOrder.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVSaleOrder.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.GVSaleOrder.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GVSaleOrder.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.GVSaleOrder.Appearance.SelectedRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVSaleOrder.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVSaleOrder.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GVSaleOrder.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GVSaleOrder.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GVSaleOrder.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GVSaleOrder.Appearance.VertLine.Options.UseBackColor = True
        Me.GVSaleOrder.ColumnPanelRowHeight = 35
        Me.GVSaleOrder.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColidSaleOrder, Me.ColidCancel1, Me.ColidComp, Me.ColNum, Me.ColSelMt, Me.ColCompCode, Me.ColDocCode, Me.DocCode_PO, Me.ColPartnerName, Me.ColDateOrderD, Me.ColDateReq, Me.ColInvCode, Me.ColInvName, Me.ColAmount, Me.ColUnitOrder, Me.ColPsSale1, Me.ColPsOrder1, Me.ColstSysText, Me.ColNote1, Me.colCountDt, Me.ColstShow, Me.ColAmtStock, Me.ColidPartner, Me.coldNET, Me.Col_i, Me.ColDtType, Me.ColpWeight, Me.ColidUnitW, Me.ColidInvGroup, Me.ColWPerPack})
        Me.GVSaleOrder.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GVSaleOrder.GridControl = Me.GCSaleOrder
        Me.GVSaleOrder.Name = "GVSaleOrder"
        Me.GVSaleOrder.OptionsView.EnableAppearanceEvenRow = True
        Me.GVSaleOrder.OptionsView.EnableAppearanceOddRow = True
        Me.GVSaleOrder.OptionsView.RowAutoHeight = True
        Me.GVSaleOrder.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GVSaleOrder.OptionsView.ShowGroupPanel = False
        Me.GVSaleOrder.OptionsView.ShowIndicator = False
        Me.GVSaleOrder.PaintStyleName = "MixedXP"
        Me.GVSaleOrder.RowHeight = 25
        '
        'ColidSaleOrder
        '
        Me.ColidSaleOrder.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColidSaleOrder.AppearanceCell.Options.UseFont = True
        Me.ColidSaleOrder.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColidSaleOrder.AppearanceHeader.ForeColor = System.Drawing.Color.White
        Me.ColidSaleOrder.AppearanceHeader.Options.UseFont = True
        Me.ColidSaleOrder.AppearanceHeader.Options.UseForeColor = True
        Me.ColidSaleOrder.Caption = "idSaleOrder"
        Me.ColidSaleOrder.FieldName = "idSaleOrder"
        Me.ColidSaleOrder.Name = "ColidSaleOrder"
        '
        'ColidCancel1
        '
        Me.ColidCancel1.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColidCancel1.AppearanceCell.Options.UseFont = True
        Me.ColidCancel1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColidCancel1.AppearanceHeader.ForeColor = System.Drawing.Color.White
        Me.ColidCancel1.AppearanceHeader.Options.UseFont = True
        Me.ColidCancel1.AppearanceHeader.Options.UseForeColor = True
        Me.ColidCancel1.Caption = "idCancel"
        Me.ColidCancel1.FieldName = "idPsCancel"
        Me.ColidCancel1.Name = "ColidCancel1"
        '
        'ColidComp
        '
        Me.ColidComp.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColidComp.AppearanceCell.Options.UseFont = True
        Me.ColidComp.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColidComp.AppearanceHeader.ForeColor = System.Drawing.Color.White
        Me.ColidComp.AppearanceHeader.Options.UseFont = True
        Me.ColidComp.AppearanceHeader.Options.UseForeColor = True
        Me.ColidComp.Caption = "idComp"
        Me.ColidComp.FieldName = "idComp"
        Me.ColidComp.Name = "ColidComp"
        '
        'ColNum
        '
        Me.ColNum.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColNum.AppearanceCell.Options.UseFont = True
        Me.ColNum.AppearanceCell.Options.UseTextOptions = True
        Me.ColNum.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColNum.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColNum.AppearanceHeader.ForeColor = System.Drawing.Color.White
        Me.ColNum.AppearanceHeader.Options.UseFont = True
        Me.ColNum.AppearanceHeader.Options.UseForeColor = True
        Me.ColNum.AppearanceHeader.Options.UseTextOptions = True
        Me.ColNum.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColNum.Caption = "ลำดับ"
        Me.ColNum.MaxWidth = 45
        Me.ColNum.MinWidth = 45
        Me.ColNum.Name = "ColNum"
        Me.ColNum.OptionsColumn.AllowEdit = False
        Me.ColNum.OptionsColumn.ReadOnly = True
        Me.ColNum.OptionsColumn.TabStop = False
        Me.ColNum.Visible = True
        Me.ColNum.VisibleIndex = 0
        Me.ColNum.Width = 45
        '
        'ColSelMt
        '
        Me.ColSelMt.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColSelMt.AppearanceCell.Options.UseFont = True
        Me.ColSelMt.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColSelMt.AppearanceHeader.ForeColor = System.Drawing.Color.White
        Me.ColSelMt.AppearanceHeader.Options.UseFont = True
        Me.ColSelMt.AppearanceHeader.Options.UseForeColor = True
        Me.ColSelMt.AppearanceHeader.Options.UseTextOptions = True
        Me.ColSelMt.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColSelMt.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColSelMt.Caption = "เลือก"
        Me.ColSelMt.ColumnEdit = Me.rptSel
        Me.ColSelMt.FieldName = "Chk"
        Me.ColSelMt.MaxWidth = 45
        Me.ColSelMt.MinWidth = 45
        Me.ColSelMt.Name = "ColSelMt"
        Me.ColSelMt.Visible = True
        Me.ColSelMt.VisibleIndex = 1
        Me.ColSelMt.Width = 45
        '
        'rptSel
        '
        Me.rptSel.AutoHeight = False
        Me.rptSel.Name = "rptSel"
        '
        'ColCompCode
        '
        Me.ColCompCode.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColCompCode.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColCompCode.AppearanceCell.Options.UseBackColor = True
        Me.ColCompCode.AppearanceCell.Options.UseFont = True
        Me.ColCompCode.AppearanceCell.Options.UseTextOptions = True
        Me.ColCompCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColCompCode.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColCompCode.AppearanceHeader.ForeColor = System.Drawing.Color.White
        Me.ColCompCode.AppearanceHeader.Options.UseFont = True
        Me.ColCompCode.AppearanceHeader.Options.UseForeColor = True
        Me.ColCompCode.AppearanceHeader.Options.UseTextOptions = True
        Me.ColCompCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColCompCode.Caption = "บริษัท"
        Me.ColCompCode.FieldName = "CompCode"
        Me.ColCompCode.MaxWidth = 60
        Me.ColCompCode.MinWidth = 60
        Me.ColCompCode.Name = "ColCompCode"
        Me.ColCompCode.OptionsColumn.AllowEdit = False
        Me.ColCompCode.OptionsColumn.ReadOnly = True
        Me.ColCompCode.Width = 60
        '
        'ColDocCode
        '
        Me.ColDocCode.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColDocCode.AppearanceCell.Options.UseFont = True
        Me.ColDocCode.AppearanceCell.Options.UseTextOptions = True
        Me.ColDocCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDocCode.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColDocCode.AppearanceHeader.ForeColor = System.Drawing.Color.White
        Me.ColDocCode.AppearanceHeader.Options.UseFont = True
        Me.ColDocCode.AppearanceHeader.Options.UseForeColor = True
        Me.ColDocCode.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDocCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDocCode.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColDocCode.Caption = "เลขที่สั่งซื้อ (Order No.)"
        Me.ColDocCode.FieldName = "DocCode"
        Me.ColDocCode.MaxWidth = 90
        Me.ColDocCode.MinWidth = 90
        Me.ColDocCode.Name = "ColDocCode"
        Me.ColDocCode.OptionsColumn.AllowEdit = False
        Me.ColDocCode.OptionsColumn.ReadOnly = True
        Me.ColDocCode.OptionsColumn.TabStop = False
        Me.ColDocCode.Visible = True
        Me.ColDocCode.VisibleIndex = 2
        Me.ColDocCode.Width = 90
        '
        'DocCode_PO
        '
        Me.DocCode_PO.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DocCode_PO.AppearanceCell.Options.UseFont = True
        Me.DocCode_PO.AppearanceCell.Options.UseTextOptions = True
        Me.DocCode_PO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.DocCode_PO.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.DocCode_PO.AppearanceHeader.Options.UseFont = True
        Me.DocCode_PO.AppearanceHeader.Options.UseTextOptions = True
        Me.DocCode_PO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.DocCode_PO.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.DocCode_PO.Caption = "เลขที่ใบสั่งซื้อ (PO No.)"
        Me.DocCode_PO.FieldName = "DocCode_PO"
        Me.DocCode_PO.MaxWidth = 90
        Me.DocCode_PO.MinWidth = 90
        Me.DocCode_PO.Name = "DocCode_PO"
        Me.DocCode_PO.OptionsColumn.AllowEdit = False
        Me.DocCode_PO.OptionsColumn.ReadOnly = True
        Me.DocCode_PO.Visible = True
        Me.DocCode_PO.VisibleIndex = 3
        Me.DocCode_PO.Width = 90
        '
        'ColPartnerName
        '
        Me.ColPartnerName.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ColPartnerName.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColPartnerName.AppearanceCell.Options.UseBackColor = True
        Me.ColPartnerName.AppearanceCell.Options.UseFont = True
        Me.ColPartnerName.AppearanceCell.Options.UseTextOptions = True
        Me.ColPartnerName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.ColPartnerName.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColPartnerName.AppearanceHeader.ForeColor = System.Drawing.Color.White
        Me.ColPartnerName.AppearanceHeader.Options.UseFont = True
        Me.ColPartnerName.AppearanceHeader.Options.UseForeColor = True
        Me.ColPartnerName.AppearanceHeader.Options.UseTextOptions = True
        Me.ColPartnerName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColPartnerName.Caption = "ชื่อลูกค้า"
        Me.ColPartnerName.FieldName = "PartnerName"
        Me.ColPartnerName.MinWidth = 170
        Me.ColPartnerName.Name = "ColPartnerName"
        Me.ColPartnerName.OptionsColumn.AllowEdit = False
        Me.ColPartnerName.OptionsColumn.ReadOnly = True
        Me.ColPartnerName.OptionsColumn.TabStop = False
        Me.ColPartnerName.Width = 276
        '
        'ColDateOrderD
        '
        Me.ColDateOrderD.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColDateOrderD.AppearanceCell.Options.UseFont = True
        Me.ColDateOrderD.AppearanceCell.Options.UseTextOptions = True
        Me.ColDateOrderD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDateOrderD.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColDateOrderD.AppearanceHeader.ForeColor = System.Drawing.Color.White
        Me.ColDateOrderD.AppearanceHeader.Options.UseFont = True
        Me.ColDateOrderD.AppearanceHeader.Options.UseForeColor = True
        Me.ColDateOrderD.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDateOrderD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDateOrderD.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColDateOrderD.Caption = "   วันที่สั่งซื้อ   (Date Order)"
        Me.ColDateOrderD.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.ColDateOrderD.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.ColDateOrderD.FieldName = "DateOrderD"
        Me.ColDateOrderD.MaxWidth = 90
        Me.ColDateOrderD.MinWidth = 90
        Me.ColDateOrderD.Name = "ColDateOrderD"
        Me.ColDateOrderD.OptionsColumn.AllowEdit = False
        Me.ColDateOrderD.OptionsColumn.ReadOnly = True
        Me.ColDateOrderD.OptionsColumn.TabStop = False
        Me.ColDateOrderD.Visible = True
        Me.ColDateOrderD.VisibleIndex = 4
        Me.ColDateOrderD.Width = 90
        '
        'ColDateReq
        '
        Me.ColDateReq.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColDateReq.AppearanceCell.Options.UseFont = True
        Me.ColDateReq.AppearanceCell.Options.UseTextOptions = True
        Me.ColDateReq.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDateReq.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColDateReq.AppearanceHeader.ForeColor = System.Drawing.Color.White
        Me.ColDateReq.AppearanceHeader.Options.UseFont = True
        Me.ColDateReq.AppearanceHeader.Options.UseForeColor = True
        Me.ColDateReq.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDateReq.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDateReq.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColDateReq.Caption = "วันที่ต้องการสินค้า"
        Me.ColDateReq.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.ColDateReq.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.ColDateReq.FieldName = "DateRequireD"
        Me.ColDateReq.MaxWidth = 90
        Me.ColDateReq.MinWidth = 90
        Me.ColDateReq.Name = "ColDateReq"
        Me.ColDateReq.OptionsColumn.AllowEdit = False
        Me.ColDateReq.OptionsColumn.ReadOnly = True
        Me.ColDateReq.OptionsColumn.TabStop = False
        Me.ColDateReq.Visible = True
        Me.ColDateReq.VisibleIndex = 5
        Me.ColDateReq.Width = 90
        '
        'ColInvCode
        '
        Me.ColInvCode.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColInvCode.AppearanceCell.Options.UseFont = True
        Me.ColInvCode.AppearanceCell.Options.UseTextOptions = True
        Me.ColInvCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.ColInvCode.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColInvCode.AppearanceHeader.ForeColor = System.Drawing.Color.White
        Me.ColInvCode.AppearanceHeader.Options.UseFont = True
        Me.ColInvCode.AppearanceHeader.Options.UseForeColor = True
        Me.ColInvCode.AppearanceHeader.Options.UseTextOptions = True
        Me.ColInvCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColInvCode.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColInvCode.Caption = "รหัสสินค้า"
        Me.ColInvCode.FieldName = "InvCode"
        Me.ColInvCode.MinWidth = 70
        Me.ColInvCode.Name = "ColInvCode"
        Me.ColInvCode.OptionsColumn.AllowEdit = False
        Me.ColInvCode.OptionsColumn.ReadOnly = True
        Me.ColInvCode.OptionsColumn.TabStop = False
        Me.ColInvCode.Visible = True
        Me.ColInvCode.VisibleIndex = 6
        Me.ColInvCode.Width = 70
        '
        'ColInvName
        '
        Me.ColInvName.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColInvName.AppearanceCell.Options.UseFont = True
        Me.ColInvName.AppearanceCell.Options.UseTextOptions = True
        Me.ColInvName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.ColInvName.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColInvName.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColInvName.AppearanceHeader.ForeColor = System.Drawing.Color.White
        Me.ColInvName.AppearanceHeader.Options.UseFont = True
        Me.ColInvName.AppearanceHeader.Options.UseForeColor = True
        Me.ColInvName.AppearanceHeader.Options.UseTextOptions = True
        Me.ColInvName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColInvName.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColInvName.Caption = "รายการสั่งซื้อ"
        Me.ColInvName.ColumnEdit = Me.rptInvName
        Me.ColInvName.FieldName = "InvName"
        Me.ColInvName.MinWidth = 200
        Me.ColInvName.Name = "ColInvName"
        Me.ColInvName.OptionsColumn.AllowEdit = False
        Me.ColInvName.OptionsColumn.ReadOnly = True
        Me.ColInvName.OptionsColumn.TabStop = False
        Me.ColInvName.Visible = True
        Me.ColInvName.VisibleIndex = 7
        Me.ColInvName.Width = 200
        '
        'rptInvName
        '
        Me.rptInvName.Name = "rptInvName"
        '
        'ColAmount
        '
        Me.ColAmount.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColAmount.AppearanceCell.Options.UseFont = True
        Me.ColAmount.AppearanceCell.Options.UseTextOptions = True
        Me.ColAmount.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ColAmount.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColAmount.AppearanceHeader.ForeColor = System.Drawing.Color.White
        Me.ColAmount.AppearanceHeader.Options.UseFont = True
        Me.ColAmount.AppearanceHeader.Options.UseForeColor = True
        Me.ColAmount.AppearanceHeader.Options.UseTextOptions = True
        Me.ColAmount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColAmount.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColAmount.Caption = "จำนวนสั่งซื้อ"
        Me.ColAmount.DisplayFormat.FormatString = "#,##0.00##"
        Me.ColAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColAmount.FieldName = "AmtOrder"
        Me.ColAmount.MinWidth = 65
        Me.ColAmount.Name = "ColAmount"
        Me.ColAmount.OptionsColumn.AllowEdit = False
        Me.ColAmount.OptionsColumn.ReadOnly = True
        Me.ColAmount.OptionsColumn.TabStop = False
        Me.ColAmount.Visible = True
        Me.ColAmount.VisibleIndex = 8
        Me.ColAmount.Width = 65
        '
        'ColUnitOrder
        '
        Me.ColUnitOrder.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColUnitOrder.AppearanceCell.Options.UseFont = True
        Me.ColUnitOrder.AppearanceCell.Options.UseTextOptions = True
        Me.ColUnitOrder.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColUnitOrder.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColUnitOrder.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColUnitOrder.AppearanceHeader.ForeColor = System.Drawing.Color.White
        Me.ColUnitOrder.AppearanceHeader.Options.UseFont = True
        Me.ColUnitOrder.AppearanceHeader.Options.UseForeColor = True
        Me.ColUnitOrder.AppearanceHeader.Options.UseTextOptions = True
        Me.ColUnitOrder.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColUnitOrder.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColUnitOrder.Caption = "หน่วยสั่งซื้อ"
        Me.ColUnitOrder.FieldName = "UnitNameOrd"
        Me.ColUnitOrder.MaxWidth = 50
        Me.ColUnitOrder.MinWidth = 50
        Me.ColUnitOrder.Name = "ColUnitOrder"
        Me.ColUnitOrder.OptionsColumn.AllowEdit = False
        Me.ColUnitOrder.OptionsColumn.ReadOnly = True
        Me.ColUnitOrder.OptionsColumn.TabStop = False
        Me.ColUnitOrder.Visible = True
        Me.ColUnitOrder.VisibleIndex = 9
        Me.ColUnitOrder.Width = 50
        '
        'ColPsSale1
        '
        Me.ColPsSale1.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColPsSale1.AppearanceCell.Options.UseFont = True
        Me.ColPsSale1.AppearanceCell.Options.UseTextOptions = True
        Me.ColPsSale1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColPsSale1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColPsSale1.AppearanceHeader.ForeColor = System.Drawing.Color.White
        Me.ColPsSale1.AppearanceHeader.Options.UseFont = True
        Me.ColPsSale1.AppearanceHeader.Options.UseForeColor = True
        Me.ColPsSale1.AppearanceHeader.Options.UseTextOptions = True
        Me.ColPsSale1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColPsSale1.Caption = "เจ้าหน้าที่ขาย"
        Me.ColPsSale1.FieldName = "PsSale"
        Me.ColPsSale1.MinWidth = 100
        Me.ColPsSale1.Name = "ColPsSale1"
        Me.ColPsSale1.OptionsColumn.AllowEdit = False
        Me.ColPsSale1.OptionsColumn.ReadOnly = True
        Me.ColPsSale1.OptionsColumn.TabStop = False
        Me.ColPsSale1.Visible = True
        Me.ColPsSale1.VisibleIndex = 10
        Me.ColPsSale1.Width = 100
        '
        'ColPsOrder1
        '
        Me.ColPsOrder1.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColPsOrder1.AppearanceCell.Options.UseFont = True
        Me.ColPsOrder1.AppearanceCell.Options.UseTextOptions = True
        Me.ColPsOrder1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColPsOrder1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColPsOrder1.AppearanceHeader.ForeColor = System.Drawing.Color.White
        Me.ColPsOrder1.AppearanceHeader.Options.UseFont = True
        Me.ColPsOrder1.AppearanceHeader.Options.UseForeColor = True
        Me.ColPsOrder1.AppearanceHeader.Options.UseTextOptions = True
        Me.ColPsOrder1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColPsOrder1.Caption = "ผู้รับคำสั่งซื้อ"
        Me.ColPsOrder1.FieldName = "PsOrder"
        Me.ColPsOrder1.MinWidth = 100
        Me.ColPsOrder1.Name = "ColPsOrder1"
        Me.ColPsOrder1.OptionsColumn.AllowEdit = False
        Me.ColPsOrder1.OptionsColumn.ReadOnly = True
        Me.ColPsOrder1.OptionsColumn.TabStop = False
        Me.ColPsOrder1.Visible = True
        Me.ColPsOrder1.VisibleIndex = 11
        Me.ColPsOrder1.Width = 100
        '
        'ColstSysText
        '
        Me.ColstSysText.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColstSysText.AppearanceCell.Options.UseFont = True
        Me.ColstSysText.AppearanceCell.Options.UseTextOptions = True
        Me.ColstSysText.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColstSysText.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColstSysText.AppearanceHeader.ForeColor = System.Drawing.Color.White
        Me.ColstSysText.AppearanceHeader.Options.UseFont = True
        Me.ColstSysText.AppearanceHeader.Options.UseForeColor = True
        Me.ColstSysText.AppearanceHeader.Options.UseTextOptions = True
        Me.ColstSysText.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColstSysText.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColstSysText.Caption = "ช่องทางการสั่งซื้อ"
        Me.ColstSysText.DisplayFormat.FormatString = "N2"
        Me.ColstSysText.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColstSysText.FieldName = "stSysText"
        Me.ColstSysText.MaxWidth = 75
        Me.ColstSysText.MinWidth = 75
        Me.ColstSysText.Name = "ColstSysText"
        Me.ColstSysText.OptionsColumn.AllowEdit = False
        Me.ColstSysText.OptionsColumn.ReadOnly = True
        Me.ColstSysText.OptionsColumn.TabStop = False
        Me.ColstSysText.Visible = True
        Me.ColstSysText.VisibleIndex = 12
        '
        'ColNote1
        '
        Me.ColNote1.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColNote1.AppearanceCell.Options.UseFont = True
        Me.ColNote1.AppearanceCell.Options.UseTextOptions = True
        Me.ColNote1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.ColNote1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColNote1.AppearanceHeader.ForeColor = System.Drawing.Color.White
        Me.ColNote1.AppearanceHeader.Options.UseFont = True
        Me.ColNote1.AppearanceHeader.Options.UseForeColor = True
        Me.ColNote1.AppearanceHeader.Options.UseTextOptions = True
        Me.ColNote1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColNote1.Caption = "คำอธิบายรายการ"
        Me.ColNote1.FieldName = "NoteOrder"
        Me.ColNote1.MinWidth = 120
        Me.ColNote1.Name = "ColNote1"
        Me.ColNote1.OptionsColumn.AllowEdit = False
        Me.ColNote1.OptionsColumn.ReadOnly = True
        Me.ColNote1.OptionsColumn.TabStop = False
        Me.ColNote1.Visible = True
        Me.ColNote1.VisibleIndex = 14
        Me.ColNote1.Width = 120
        '
        'colCountDt
        '
        Me.colCountDt.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.colCountDt.AppearanceCell.Options.UseFont = True
        Me.colCountDt.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.colCountDt.AppearanceHeader.ForeColor = System.Drawing.Color.White
        Me.colCountDt.AppearanceHeader.Options.UseFont = True
        Me.colCountDt.AppearanceHeader.Options.UseForeColor = True
        Me.colCountDt.Caption = "#Dt"
        Me.colCountDt.FieldName = "NumDt"
        Me.colCountDt.Name = "colCountDt"
        '
        'ColstShow
        '
        Me.ColstShow.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColstShow.AppearanceCell.Options.UseFont = True
        Me.ColstShow.AppearanceCell.Options.UseTextOptions = True
        Me.ColstShow.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColstShow.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColstShow.AppearanceHeader.Options.UseFont = True
        Me.ColstShow.AppearanceHeader.Options.UseTextOptions = True
        Me.ColstShow.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColstShow.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColstShow.Caption = "สถานะใน Stock"
        Me.ColstShow.FieldName = "status"
        Me.ColstShow.MinWidth = 65
        Me.ColstShow.Name = "ColstShow"
        Me.ColstShow.OptionsColumn.AllowEdit = False
        Me.ColstShow.OptionsColumn.ReadOnly = True
        Me.ColstShow.OptionsColumn.TabStop = False
        Me.ColstShow.Visible = True
        Me.ColstShow.VisibleIndex = 13
        Me.ColstShow.Width = 65
        '
        'ColAmtStock
        '
        Me.ColAmtStock.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColAmtStock.AppearanceCell.Options.UseFont = True
        Me.ColAmtStock.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColAmtStock.AppearanceHeader.Options.UseFont = True
        Me.ColAmtStock.Caption = "AmtStock"
        Me.ColAmtStock.FieldName = "AmtStock"
        Me.ColAmtStock.Name = "ColAmtStock"
        '
        'ColidPartner
        '
        Me.ColidPartner.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColidPartner.AppearanceCell.Options.UseFont = True
        Me.ColidPartner.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColidPartner.AppearanceHeader.Options.UseFont = True
        Me.ColidPartner.Caption = "idPartner"
        Me.ColidPartner.FieldName = "idPartner"
        Me.ColidPartner.Name = "ColidPartner"
        '
        'coldNET
        '
        Me.coldNET.Caption = "dNET"
        Me.coldNET.FieldName = "dNET"
        Me.coldNET.Name = "coldNET"
        '
        'Col_i
        '
        Me.Col_i.Caption = "i"
        Me.Col_i.FieldName = "i"
        Me.Col_i.Name = "Col_i"
        '
        'ColDtType
        '
        Me.ColDtType.Caption = "DtType"
        Me.ColDtType.FieldName = "DtType"
        Me.ColDtType.Name = "ColDtType"
        '
        'ColpWeight
        '
        Me.ColpWeight.Caption = "pWeight"
        Me.ColpWeight.FieldName = "pWeight"
        Me.ColpWeight.Name = "ColpWeight"
        '
        'ColidUnitW
        '
        Me.ColidUnitW.Caption = "idUnitW"
        Me.ColidUnitW.FieldName = "idUnitW"
        Me.ColidUnitW.Name = "ColidUnitW"
        '
        'ColidInvGroup
        '
        Me.ColidInvGroup.Caption = "idInvGroup"
        Me.ColidInvGroup.FieldName = "idInvGroup"
        Me.ColidInvGroup.Name = "ColidInvGroup"
        '
        'ColWPerPack
        '
        Me.ColWPerPack.Caption = "WPerPack"
        Me.ColWPerPack.FieldName = "WPerPack"
        Me.ColWPerPack.Name = "ColWPerPack"
        '
        'PanelControl1
        '
        Me.PanelControl1.Appearance.BackColor = System.Drawing.Color.Lavender
        Me.PanelControl1.Appearance.BackColor2 = System.Drawing.Color.LightSteelBlue
        Me.PanelControl1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.PanelControl1.Appearance.Options.UseBackColor = True
        Me.PanelControl1.Appearance.Options.UseFont = True
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.GroupBox3)
        Me.PanelControl1.Controls.Add(Me.GroupBox2)
        Me.PanelControl1.Controls.Add(Me.GroupBox1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1145, 122)
        Me.PanelControl1.TabIndex = 726
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.CheckBox3)
        Me.GroupBox3.Controls.Add(Me.CheckBox1)
        Me.GroupBox3.Controls.Add(Me.chkDoc)
        Me.GroupBox3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(594, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(126, 110)
        Me.GroupBox3.TabIndex = 796
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Tag = ""
        Me.GroupBox3.Text = "จัดกลุ่มตาม"
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox3.Location = New System.Drawing.Point(10, 54)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(90, 18)
        Me.CheckBox3.TabIndex = 799
        Me.CheckBox3.Text = "รายการสั่งซื้อ"
        Me.CheckBox3.UseVisualStyleBackColor = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(10, 77)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(113, 18)
        Me.CheckBox1.TabIndex = 798
        Me.CheckBox1.Text = "วันที่ต้องการสินค้า"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'chkDoc
        '
        Me.chkDoc.AutoSize = True
        Me.chkDoc.BackColor = System.Drawing.Color.Transparent
        Me.chkDoc.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDoc.Location = New System.Drawing.Point(10, 30)
        Me.chkDoc.Name = "chkDoc"
        Me.chkDoc.Size = New System.Drawing.Size(81, 18)
        Me.chkDoc.TabIndex = 797
        Me.chkDoc.Text = "เลขที่สั่งซื้อ"
        Me.chkDoc.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.txtDocCodePO)
        Me.GroupBox2.Controls.Add(Me.cbDocCodePO)
        Me.GroupBox2.Controls.Add(Me.cbReadyToOrder)
        Me.GroupBox2.Controls.Add(Me.txtDocCode)
        Me.GroupBox2.Controls.Add(Me.chkDocCode)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(326, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(262, 111)
        Me.GroupBox2.TabIndex = 792
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Tag = ""
        Me.GroupBox2.Text = "ค้นหาจาก"
        '
        'txtDocCodePO
        '
        Me.txtDocCodePO.Enabled = False
        Me.txtDocCodePO.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDocCodePO.Location = New System.Drawing.Point(105, 51)
        Me.txtDocCodePO.Name = "txtDocCodePO"
        Me.txtDocCodePO.Size = New System.Drawing.Size(151, 22)
        Me.txtDocCodePO.TabIndex = 797
        '
        'cbDocCodePO
        '
        Me.cbDocCodePO.AutoSize = True
        Me.cbDocCodePO.BackColor = System.Drawing.Color.Transparent
        Me.cbDocCodePO.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDocCodePO.Location = New System.Drawing.Point(14, 55)
        Me.cbDocCodePO.Name = "cbDocCodePO"
        Me.cbDocCodePO.Size = New System.Drawing.Size(90, 18)
        Me.cbDocCodePO.TabIndex = 796
        Me.cbDocCodePO.Text = "รายการสั่งซื้อ"
        Me.cbDocCodePO.UseVisualStyleBackColor = False
        '
        'cbReadyToOrder
        '
        Me.cbReadyToOrder.AutoSize = True
        Me.cbReadyToOrder.BackColor = System.Drawing.Color.Transparent
        Me.cbReadyToOrder.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbReadyToOrder.Location = New System.Drawing.Point(14, 78)
        Me.cbReadyToOrder.Name = "cbReadyToOrder"
        Me.cbReadyToOrder.Size = New System.Drawing.Size(221, 18)
        Me.cbReadyToOrder.TabIndex = 795
        Me.cbReadyToOrder.Text = "แสดงเฉพาะรายการสินค้าที่เปิดบิลขายได้"
        Me.cbReadyToOrder.UseVisualStyleBackColor = False
        '
        'txtDocCode
        '
        Me.txtDocCode.Enabled = False
        Me.txtDocCode.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDocCode.Location = New System.Drawing.Point(105, 27)
        Me.txtDocCode.Name = "txtDocCode"
        Me.txtDocCode.Size = New System.Drawing.Size(151, 22)
        Me.txtDocCode.TabIndex = 794
        '
        'chkDocCode
        '
        Me.chkDocCode.AutoSize = True
        Me.chkDocCode.BackColor = System.Drawing.Color.Transparent
        Me.chkDocCode.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDocCode.Location = New System.Drawing.Point(14, 31)
        Me.chkDocCode.Name = "chkDocCode"
        Me.chkDocCode.Size = New System.Drawing.Size(81, 18)
        Me.chkDocCode.TabIndex = 793
        Me.chkDocCode.Text = "เลขที่สั่งซื้อ"
        Me.chkDocCode.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btnCustomer)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmbGroupComp)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.lblPartner)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(6, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(316, 111)
        Me.GroupBox1.TabIndex = 788
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Tag = ""
        Me.GroupBox1.Text = "เลือกรายการสั่งซื้อจาก"
        '
        'btnCustomer
        '
        Me.btnCustomer.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCustomer.Appearance.Options.UseFont = True
        Me.btnCustomer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCustomer.Image = CType(resources.GetObject("btnCustomer.Image"), System.Drawing.Image)
        Me.btnCustomer.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnCustomer.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnCustomer.Location = New System.Drawing.Point(267, 48)
        Me.btnCustomer.Name = "btnCustomer"
        Me.btnCustomer.Size = New System.Drawing.Size(32, 28)
        Me.btnCustomer.TabIndex = 971
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 14)
        Me.Label1.TabIndex = 970
        Me.Label1.Text = "ลูกค้า"
        '
        'cmbGroupComp
        '
        Me.cmbGroupComp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGroupComp.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbGroupComp.FormattingEnabled = True
        Me.cmbGroupComp.Location = New System.Drawing.Point(62, 20)
        Me.cmbGroupComp.Name = "cmbGroupComp"
        Me.cmbGroupComp.Size = New System.Drawing.Size(203, 22)
        Me.cmbGroupComp.TabIndex = 968
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(18, 26)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(38, 14)
        Me.Label10.TabIndex = 969
        Me.Label10.Text = "บริษัท"
        '
        'lblPartner
        '
        Me.lblPartner.BackColor = System.Drawing.Color.PaleGreen
        Me.lblPartner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPartner.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblPartner.ForeColor = System.Drawing.Color.Maroon
        Me.lblPartner.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblPartner.Location = New System.Drawing.Point(62, 48)
        Me.lblPartner.Name = "lblPartner"
        Me.lblPartner.Size = New System.Drawing.Size(203, 48)
        Me.lblPartner.TabIndex = 789
        Me.lblPartner.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PanelControl3
        '
        Me.PanelControl3.Appearance.BackColor = System.Drawing.Color.LightSteelBlue
        Me.PanelControl3.Appearance.BackColor2 = System.Drawing.Color.CornflowerBlue
        Me.PanelControl3.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.PanelControl3.Appearance.Options.UseBackColor = True
        Me.PanelControl3.Appearance.Options.UseFont = True
        Me.PanelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl3.Controls.Add(Me.Panel3)
        Me.PanelControl3.Controls.Add(Me.Panel2)
        Me.PanelControl3.Controls.Add(Me.Panel1)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl3.Location = New System.Drawing.Point(0, 122)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(1145, 32)
        Me.PanelControl3.TabIndex = 794
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.SimpleButton1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(220, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(130, 32)
        Me.Panel3.TabIndex = 587
        Me.Panel3.Visible = False
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SimpleButton1.Dock = System.Windows.Forms.DockStyle.Left
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.SimpleButton1.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.SimpleButton1.Location = New System.Drawing.Point(0, 0)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(115, 32)
        Me.SimpleButton1.TabIndex = 584
        Me.SimpleButton1.Text = "เลือกรายการ"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.btnSaleTs)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(108, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(112, 32)
        Me.Panel2.TabIndex = 586
        '
        'btnSaleTs
        '
        Me.btnSaleTs.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaleTs.Appearance.Options.UseFont = True
        Me.btnSaleTs.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSaleTs.Image = CType(resources.GetObject("btnSaleTs.Image"), System.Drawing.Image)
        Me.btnSaleTs.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnSaleTs.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnSaleTs.Location = New System.Drawing.Point(2, 1)
        Me.btnSaleTs.Name = "btnSaleTs"
        Me.btnSaleTs.Size = New System.Drawing.Size(106, 35)
        Me.btnSaleTs.TabIndex = 584
        Me.btnSaleTs.Text = "เปิดบิลขาย"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.btnRefresh)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(108, 32)
        Me.Panel1.TabIndex = 585
        '
        'btnRefresh
        '
        Me.btnRefresh.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Appearance.Options.UseFont = True
        Me.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefresh.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), System.Drawing.Image)
        Me.btnRefresh.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnRefresh.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnRefresh.Location = New System.Drawing.Point(0, 0)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(106, 32)
        Me.btnRefresh.TabIndex = 583
        Me.btnRefresh.Text = " Refresh"
        '
        'frmSlOrderToSale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(1145, 551)
        Me.Controls.Add(Me.GCSaleOrder)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSlOrderToSale"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " ข้อมูลรายการสั่งซื้อเพื่อเปิดบิลขาย"
        CType(Me.GVSaleOrderDt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCSaleOrder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVSaleOrder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptSel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptInvName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblPartner As System.Windows.Forms.Label
    Friend WithEvents GCSaleOrder As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVSaleOrderDt As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GVSaleOrder As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColidSaleOrder As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColidCancel1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColidComp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColNum As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColSelMt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rptSel As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents ColCompCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDocCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColPartnerName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDateOrderD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDateReq As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColPsSale1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColPsOrder1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColstSysText As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColNote1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCountDt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColInvCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColInvName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColAmount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColUnitOrder As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColstShow As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColAmtStock As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDocCode As System.Windows.Forms.TextBox
    Friend WithEvents chkDocCode As System.Windows.Forms.CheckBox
    Friend WithEvents cbReadyToOrder As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ColidPartner As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmbGroupComp As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents chkDoc As System.Windows.Forms.CheckBox
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSaleTs As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCustomer As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents txtDocCodePO As System.Windows.Forms.TextBox
    Friend WithEvents cbDocCodePO As System.Windows.Forms.CheckBox
    Friend WithEvents coldNET As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Col_i As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDtType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rptInvName As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents DocCode_PO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel3 As Panel
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ColpWeight As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColidUnitW As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColidInvGroup As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColWPerPack As DevExpress.XtraGrid.Columns.GridColumn
End Class
