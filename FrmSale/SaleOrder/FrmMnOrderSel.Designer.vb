<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMnOrderSel
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim GridFormatRule1 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMnOrderSel))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim GridFormatRule2 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleExpression1 As DevExpress.XtraEditors.FormatConditionRuleExpression = New DevExpress.XtraEditors.FormatConditionRuleExpression()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim GridLevelNode2 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim SerializableAppearanceObject5 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.GVLotSale = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColidRefLot_ = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LotNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColWHName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rptWh = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.ColAmtBal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDateGen = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColMFG = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColUnitBal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColAmountCut = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDelLot = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rptDelDt = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.ColidLot = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColidSaleOrderDt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColidUnitBal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColidWh = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.idLotSPM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColCompRec = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColAmtCurStock = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCLotFIFO = New DevExpress.XtraGrid.GridControl()
        Me.GVSaleOrder = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColNumC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColAddLot = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rptAddLot = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.ColDocCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rptProductName = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColAmtSale = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColUnitC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColidSaleOrderDt_ = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDelMt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rptDelMt = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.ColDateOrder = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDateRq = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidInvGroup_ = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PriceWholesale_fg = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PriceRetail_fg = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PriceBill_fg = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.idPdoType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CreditThirty_pdo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CreditSixty_pdo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PricePdo_pdo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PriceSeed = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PdCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DtType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.idSubType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.pWeight = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.idUnitW = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.WPerPack = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColidSaleOrder = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColidInvMain = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColidCusRefAddr = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColidType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GVOrderDt = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rptSelDt = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rptInvName = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn18 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn20 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn21 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn22 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn23 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn24 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn25 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn26 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn27 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn28 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn29 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn30 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn31 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn32 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn33 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColWPerPack = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ClidSaleOrderDt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ClidSaleOrder = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ClidType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCOrder = New DevExpress.XtraGrid.GridControl()
        Me.GVOrderMt = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColNum = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColSel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rptSelOrder = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.ColPsCancel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColCancelNote = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColidSaleOrder_ = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDateOrderD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDateRequire = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDocCode_ = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDocRef = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDateTs = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn35 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn36 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rptNote = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.GridColumn37 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn38 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemButtonEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.RepositoryItemMemoEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.RepositoryItemButtonEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.txtCount = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.cbDocRef = New System.Windows.Forms.CheckBox()
        Me.cbOrderNo = New System.Windows.Forms.CheckBox()
        Me.txtDocRef = New System.Windows.Forms.TextBox()
        Me.txtOrderNo = New System.Windows.Forms.TextBox()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lblPartnerName = New System.Windows.Forms.Label()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblSelected = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnLotADD = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl5 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl6 = New DevExpress.XtraEditors.PanelControl()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.btnBack = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.txtCountLot = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.rdb60 = New System.Windows.Forms.RadioButton()
        Me.rdb90 = New System.Windows.Forms.RadioButton()
        Me.rdb30 = New System.Windows.Forms.RadioButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.ColDocCode_PO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDocCodeRef = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.GVLotSale, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptWh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptDelDt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCLotFIFO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVSaleOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptAddLot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptProductName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptDelMt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVOrderDt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptSelDt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptInvName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVOrderMt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptSelOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptNote, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel8.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl5.SuspendLayout()
        CType(Me.PanelControl6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GVLotSale
        '
        Me.GVLotSale.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColidRefLot_, Me.LotNo, Me.ColWHName, Me.ColAmtBal, Me.colDateGen, Me.ColMFG, Me.ColUnitBal, Me.ColAmountCut, Me.ColDocCode_PO, Me.ColDelLot, Me.ColidLot, Me.ColidSaleOrderDt, Me.ColidUnitBal, Me.ColidWh, Me.idLotSPM, Me.ColCompRec, Me.ColAmtCurStock})
        GridFormatRule1.Name = "Format0"
        GridFormatRule1.Rule = Nothing
        Me.GVLotSale.FormatRules.Add(GridFormatRule1)
        Me.GVLotSale.GridControl = Me.GCLotFIFO
        Me.GVLotSale.Name = "GVLotSale"
        Me.GVLotSale.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect
        Me.GVLotSale.OptionsView.RowAutoHeight = True
        Me.GVLotSale.OptionsView.ShowGroupPanel = False
        '
        'ColidRefLot_
        '
        Me.ColidRefLot_.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColidRefLot_.AppearanceCell.Options.UseFont = True
        Me.ColidRefLot_.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColidRefLot_.AppearanceHeader.Options.UseFont = True
        Me.ColidRefLot_.Caption = "idRefLot"
        Me.ColidRefLot_.FieldName = "idRefLot"
        Me.ColidRefLot_.Name = "ColidRefLot_"
        '
        'LotNo
        '
        Me.LotNo.AppearanceCell.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.LotNo.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LotNo.AppearanceCell.Options.UseBackColor = True
        Me.LotNo.AppearanceCell.Options.UseFont = True
        Me.LotNo.AppearanceCell.Options.UseTextOptions = True
        Me.LotNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.LotNo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LotNo.AppearanceHeader.Options.UseFont = True
        Me.LotNo.AppearanceHeader.Options.UseTextOptions = True
        Me.LotNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LotNo.Caption = "Lot No."
        Me.LotNo.FieldName = "LotNo"
        Me.LotNo.MinWidth = 80
        Me.LotNo.Name = "LotNo"
        Me.LotNo.OptionsColumn.AllowEdit = False
        Me.LotNo.OptionsColumn.ReadOnly = True
        Me.LotNo.Visible = True
        Me.LotNo.VisibleIndex = 1
        Me.LotNo.Width = 984
        '
        'ColWHName
        '
        Me.ColWHName.AppearanceCell.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ColWHName.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColWHName.AppearanceCell.Options.UseBackColor = True
        Me.ColWHName.AppearanceCell.Options.UseFont = True
        Me.ColWHName.AppearanceCell.Options.UseTextOptions = True
        Me.ColWHName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.ColWHName.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.ColWHName.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColWHName.AppearanceHeader.Options.UseFont = True
        Me.ColWHName.AppearanceHeader.Options.UseTextOptions = True
        Me.ColWHName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColWHName.Caption = "คลัง"
        Me.ColWHName.ColumnEdit = Me.rptWh
        Me.ColWHName.FieldName = "WareHouseName"
        Me.ColWHName.MaxWidth = 130
        Me.ColWHName.MinWidth = 130
        Me.ColWHName.Name = "ColWHName"
        Me.ColWHName.OptionsColumn.AllowEdit = False
        Me.ColWHName.OptionsColumn.ReadOnly = True
        Me.ColWHName.Visible = True
        Me.ColWHName.VisibleIndex = 2
        Me.ColWHName.Width = 130
        '
        'rptWh
        '
        Me.rptWh.Appearance.Options.UseTextOptions = True
        Me.rptWh.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.rptWh.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.rptWh.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.rptWh.Name = "rptWh"
        '
        'ColAmtBal
        '
        Me.ColAmtBal.AppearanceCell.BackColor = System.Drawing.Color.Linen
        Me.ColAmtBal.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColAmtBal.AppearanceCell.Options.UseBackColor = True
        Me.ColAmtBal.AppearanceCell.Options.UseFont = True
        Me.ColAmtBal.AppearanceCell.Options.UseTextOptions = True
        Me.ColAmtBal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ColAmtBal.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColAmtBal.AppearanceHeader.Options.UseFont = True
        Me.ColAmtBal.AppearanceHeader.Options.UseTextOptions = True
        Me.ColAmtBal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColAmtBal.Caption = "คงเหลือ"
        Me.ColAmtBal.DisplayFormat.FormatString = "N2"
        Me.ColAmtBal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColAmtBal.FieldName = "AmtBal"
        Me.ColAmtBal.MaxWidth = 120
        Me.ColAmtBal.MinWidth = 100
        Me.ColAmtBal.Name = "ColAmtBal"
        Me.ColAmtBal.OptionsColumn.AllowEdit = False
        Me.ColAmtBal.OptionsColumn.ReadOnly = True
        Me.ColAmtBal.Visible = True
        Me.ColAmtBal.VisibleIndex = 3
        Me.ColAmtBal.Width = 103
        '
        'colDateGen
        '
        Me.colDateGen.AppearanceCell.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.colDateGen.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.colDateGen.AppearanceCell.Options.UseBackColor = True
        Me.colDateGen.AppearanceCell.Options.UseFont = True
        Me.colDateGen.AppearanceCell.Options.UseTextOptions = True
        Me.colDateGen.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDateGen.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.colDateGen.AppearanceHeader.Options.UseFont = True
        Me.colDateGen.AppearanceHeader.Options.UseTextOptions = True
        Me.colDateGen.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDateGen.Caption = "วันที่ผลิต"
        Me.colDateGen.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.colDateGen.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colDateGen.FieldName = "DateGen"
        Me.colDateGen.MaxWidth = 100
        Me.colDateGen.MinWidth = 100
        Me.colDateGen.Name = "colDateGen"
        Me.colDateGen.OptionsColumn.AllowEdit = False
        Me.colDateGen.OptionsColumn.ReadOnly = True
        Me.colDateGen.Visible = True
        Me.colDateGen.VisibleIndex = 6
        Me.colDateGen.Width = 100
        '
        'ColMFG
        '
        Me.ColMFG.AppearanceCell.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ColMFG.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColMFG.AppearanceCell.Options.UseBackColor = True
        Me.ColMFG.AppearanceCell.Options.UseFont = True
        Me.ColMFG.AppearanceCell.Options.UseTextOptions = True
        Me.ColMFG.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColMFG.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColMFG.AppearanceHeader.Options.UseFont = True
        Me.ColMFG.AppearanceHeader.Options.UseTextOptions = True
        Me.ColMFG.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColMFG.Caption = "อายุสินค้า"
        Me.ColMFG.FieldName = "PDAge"
        Me.ColMFG.MaxWidth = 100
        Me.ColMFG.MinWidth = 100
        Me.ColMFG.Name = "ColMFG"
        Me.ColMFG.OptionsColumn.AllowEdit = False
        Me.ColMFG.OptionsColumn.ReadOnly = True
        Me.ColMFG.Visible = True
        Me.ColMFG.VisibleIndex = 7
        Me.ColMFG.Width = 100
        '
        'ColUnitBal
        '
        Me.ColUnitBal.AppearanceCell.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ColUnitBal.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColUnitBal.AppearanceCell.Options.UseBackColor = True
        Me.ColUnitBal.AppearanceCell.Options.UseFont = True
        Me.ColUnitBal.AppearanceCell.Options.UseTextOptions = True
        Me.ColUnitBal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColUnitBal.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColUnitBal.AppearanceHeader.Options.UseFont = True
        Me.ColUnitBal.AppearanceHeader.Options.UseTextOptions = True
        Me.ColUnitBal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColUnitBal.Caption = "หน่วยคงเหลือ"
        Me.ColUnitBal.FieldName = "UnitNameBal"
        Me.ColUnitBal.MaxWidth = 85
        Me.ColUnitBal.MinWidth = 85
        Me.ColUnitBal.Name = "ColUnitBal"
        Me.ColUnitBal.OptionsColumn.AllowEdit = False
        Me.ColUnitBal.OptionsColumn.ReadOnly = True
        Me.ColUnitBal.Visible = True
        Me.ColUnitBal.VisibleIndex = 4
        Me.ColUnitBal.Width = 85
        '
        'ColAmountCut
        '
        Me.ColAmountCut.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColAmountCut.AppearanceCell.Options.UseFont = True
        Me.ColAmountCut.AppearanceCell.Options.UseTextOptions = True
        Me.ColAmountCut.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ColAmountCut.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColAmountCut.AppearanceHeader.Options.UseFont = True
        Me.ColAmountCut.AppearanceHeader.Options.UseTextOptions = True
        Me.ColAmountCut.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColAmountCut.Caption = "จำนวนขาย"
        Me.ColAmountCut.DisplayFormat.FormatString = "#,##0.00####"
        Me.ColAmountCut.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColAmountCut.FieldName = "AmountCut"
        Me.ColAmountCut.MaxWidth = 120
        Me.ColAmountCut.MinWidth = 100
        Me.ColAmountCut.Name = "ColAmountCut"
        Me.ColAmountCut.Visible = True
        Me.ColAmountCut.VisibleIndex = 5
        Me.ColAmountCut.Width = 100
        '
        'ColDelLot
        '
        Me.ColDelLot.AppearanceCell.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ColDelLot.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColDelLot.AppearanceCell.Options.UseBackColor = True
        Me.ColDelLot.AppearanceCell.Options.UseFont = True
        Me.ColDelLot.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColDelLot.AppearanceHeader.Options.UseFont = True
        Me.ColDelLot.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDelLot.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDelLot.Caption = "ลบ"
        Me.ColDelLot.ColumnEdit = Me.rptDelDt
        Me.ColDelLot.MaxWidth = 30
        Me.ColDelLot.MinWidth = 30
        Me.ColDelLot.Name = "ColDelLot"
        Me.ColDelLot.Visible = True
        Me.ColDelLot.VisibleIndex = 8
        Me.ColDelLot.Width = 30
        '
        'rptDelDt
        '
        Me.rptDelDt.AutoHeight = False
        Me.rptDelDt.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("rptDelDt.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.rptDelDt.Name = "rptDelDt"
        Me.rptDelDt.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'ColidLot
        '
        Me.ColidLot.Caption = "idLot"
        Me.ColidLot.FieldName = "idLot"
        Me.ColidLot.Name = "ColidLot"
        '
        'ColidSaleOrderDt
        '
        Me.ColidSaleOrderDt.Caption = "idSaleOrderDt"
        Me.ColidSaleOrderDt.FieldName = "idSaleOrderDt"
        Me.ColidSaleOrderDt.Name = "ColidSaleOrderDt"
        '
        'ColidUnitBal
        '
        Me.ColidUnitBal.Caption = "idUnitBal"
        Me.ColidUnitBal.FieldName = "idUnitBal"
        Me.ColidUnitBal.Name = "ColidUnitBal"
        '
        'ColidWh
        '
        Me.ColidWh.Caption = "idWh"
        Me.ColidWh.FieldName = "idWh"
        Me.ColidWh.Name = "ColidWh"
        '
        'idLotSPM
        '
        Me.idLotSPM.Caption = "idLotSPM"
        Me.idLotSPM.FieldName = "idLotSPM"
        Me.idLotSPM.Name = "idLotSPM"
        '
        'ColCompRec
        '
        Me.ColCompRec.Caption = "CompRec"
        Me.ColCompRec.FieldName = "CompRec"
        Me.ColCompRec.Name = "ColCompRec"
        '
        'ColAmtCurStock
        '
        Me.ColAmtCurStock.Caption = "AmtCurStock"
        Me.ColAmtCurStock.FieldName = "AmtCurStock"
        Me.ColAmtCurStock.Name = "ColAmtCurStock"
        '
        'GCLotFIFO
        '
        Me.GCLotFIFO.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode1.LevelTemplate = Me.GVLotSale
        GridLevelNode1.RelationName = "Level1"
        Me.GCLotFIFO.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.GCLotFIFO.Location = New System.Drawing.Point(0, 69)
        Me.GCLotFIFO.MainView = Me.GVSaleOrder
        Me.GCLotFIFO.Name = "GCLotFIFO"
        Me.GCLotFIFO.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rptDelDt, Me.rptDelMt, Me.rptAddLot, Me.rptWh, Me.rptProductName})
        Me.GCLotFIFO.Size = New System.Drawing.Size(801, 621)
        Me.GCLotFIFO.TabIndex = 796
        Me.GCLotFIFO.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVSaleOrder, Me.GVLotSale})
        '
        'GVSaleOrder
        '
        Me.GVSaleOrder.Appearance.FocusedCell.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.GVSaleOrder.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVSaleOrder.Appearance.FocusedRow.BackColor = System.Drawing.Color.Transparent
        Me.GVSaleOrder.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVSaleOrder.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVSaleOrder.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVSaleOrder.Appearance.SelectedRow.BackColor = System.Drawing.Color.Transparent
        Me.GVSaleOrder.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVSaleOrder.ColumnPanelRowHeight = 35
        Me.GVSaleOrder.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColNumC, Me.ColAddLot, Me.ColDocCode, Me.ColDocCodeRef, Me.GridColumn2, Me.GridColumn3, Me.ColAmtSale, Me.ColUnitC, Me.ColidSaleOrderDt_, Me.ColDelMt, Me.ColDateOrder, Me.ColDateRq, Me.colidInvGroup_, Me.PriceWholesale_fg, Me.PriceRetail_fg, Me.PriceBill_fg, Me.idPdoType, Me.CreditThirty_pdo, Me.CreditSixty_pdo, Me.PricePdo_pdo, Me.PriceSeed, Me.PdCode, Me.DtType, Me.idSubType, Me.pWeight, Me.idUnitW, Me.WPerPack, Me.ColidSaleOrder, Me.ColidInvMain, Me.ColidCusRefAddr, Me.ColidType})
        Me.GVSaleOrder.CustomizationFormBounds = New System.Drawing.Rectangle(0, 259, 210, 347)
        GridFormatRule2.Column = Me.ColAmtSale
        GridFormatRule2.ColumnApplyTo = Me.ColAmtSale
        GridFormatRule2.Name = "Format0"
        FormatConditionRuleExpression1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        FormatConditionRuleExpression1.Appearance.Options.UseFont = True
        FormatConditionRuleExpression1.Expression = "[AmtOrder] > [AmtSale]"
        FormatConditionRuleExpression1.PredefinedName = "Red Text"
        GridFormatRule2.Rule = FormatConditionRuleExpression1
        Me.GVSaleOrder.FormatRules.Add(GridFormatRule2)
        Me.GVSaleOrder.GridControl = Me.GCLotFIFO
        Me.GVSaleOrder.IndicatorWidth = 30
        Me.GVSaleOrder.Name = "GVSaleOrder"
        Me.GVSaleOrder.OptionsBehavior.AutoExpandAllGroups = True
        Me.GVSaleOrder.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect
        Me.GVSaleOrder.OptionsView.RowAutoHeight = True
        Me.GVSaleOrder.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GVSaleOrder.OptionsView.ShowGroupPanel = False
        Me.GVSaleOrder.OptionsView.ShowIndicator = False
        '
        'ColNumC
        '
        Me.ColNumC.AppearanceCell.BackColor = System.Drawing.Color.Honeydew
        Me.ColNumC.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColNumC.AppearanceCell.Options.UseBackColor = True
        Me.ColNumC.AppearanceCell.Options.UseFont = True
        Me.ColNumC.AppearanceCell.Options.UseTextOptions = True
        Me.ColNumC.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColNumC.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColNumC.AppearanceHeader.Options.UseFont = True
        Me.ColNumC.AppearanceHeader.Options.UseTextOptions = True
        Me.ColNumC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColNumC.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColNumC.Caption = "*"
        Me.ColNumC.FieldName = "Num"
        Me.ColNumC.MaxWidth = 40
        Me.ColNumC.MinWidth = 40
        Me.ColNumC.Name = "ColNumC"
        Me.ColNumC.OptionsColumn.AllowEdit = False
        Me.ColNumC.OptionsColumn.ReadOnly = True
        Me.ColNumC.Visible = True
        Me.ColNumC.VisibleIndex = 0
        Me.ColNumC.Width = 40
        '
        'ColAddLot
        '
        Me.ColAddLot.AppearanceCell.BackColor = System.Drawing.Color.Honeydew
        Me.ColAddLot.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColAddLot.AppearanceCell.Options.UseBackColor = True
        Me.ColAddLot.AppearanceCell.Options.UseFont = True
        Me.ColAddLot.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColAddLot.AppearanceHeader.Options.UseFont = True
        Me.ColAddLot.AppearanceHeader.Options.UseTextOptions = True
        Me.ColAddLot.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColAddLot.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColAddLot.Caption = "เพิ่ม Lot"
        Me.ColAddLot.ColumnEdit = Me.rptAddLot
        Me.ColAddLot.MaxWidth = 40
        Me.ColAddLot.MinWidth = 40
        Me.ColAddLot.Name = "ColAddLot"
        Me.ColAddLot.OptionsColumn.ReadOnly = True
        Me.ColAddLot.Visible = True
        Me.ColAddLot.VisibleIndex = 1
        Me.ColAddLot.Width = 40
        '
        'rptAddLot
        '
        Me.rptAddLot.AutoHeight = False
        Me.rptAddLot.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("rptAddLot.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject2, "", Nothing, Nothing, True)})
        Me.rptAddLot.Name = "rptAddLot"
        Me.rptAddLot.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'ColDocCode
        '
        Me.ColDocCode.AppearanceCell.BackColor = System.Drawing.Color.Honeydew
        Me.ColDocCode.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColDocCode.AppearanceCell.Options.UseBackColor = True
        Me.ColDocCode.AppearanceCell.Options.UseFont = True
        Me.ColDocCode.AppearanceCell.Options.UseTextOptions = True
        Me.ColDocCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDocCode.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColDocCode.AppearanceHeader.Options.UseFont = True
        Me.ColDocCode.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDocCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDocCode.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColDocCode.Caption = "เลขที่สั่งซื้อ (Order)"
        Me.ColDocCode.FieldName = "DocCode"
        Me.ColDocCode.MinWidth = 100
        Me.ColDocCode.Name = "ColDocCode"
        Me.ColDocCode.OptionsColumn.AllowEdit = False
        Me.ColDocCode.OptionsColumn.ReadOnly = True
        Me.ColDocCode.Visible = True
        Me.ColDocCode.VisibleIndex = 2
        Me.ColDocCode.Width = 138
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceCell.BackColor = System.Drawing.Color.Honeydew
        Me.GridColumn2.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.GridColumn2.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn2.AppearanceCell.Options.UseFont = True
        Me.GridColumn2.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GridColumn2.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GridColumn2.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridColumn2.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GridColumn2.AppearanceHeader.Options.UseFont = True
        Me.GridColumn2.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.Caption = "รายการสั่งซื้อ"
        Me.GridColumn2.ColumnEdit = Me.rptProductName
        Me.GridColumn2.FieldName = "InvName"
        Me.GridColumn2.MinWidth = 200
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.OptionsColumn.ReadOnly = True
        Me.GridColumn2.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "name", "ทั้งหมด {0:0} รายการ")})
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 4
        Me.GridColumn2.Width = 711
        '
        'rptProductName
        '
        Me.rptProductName.Appearance.Options.UseTextOptions = True
        Me.rptProductName.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.rptProductName.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.rptProductName.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.rptProductName.Name = "rptProductName"
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GridColumn3.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.GridColumn3.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.GridColumn3.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn3.AppearanceCell.Options.UseFont = True
        Me.GridColumn3.AppearanceCell.Options.UseForeColor = True
        Me.GridColumn3.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn3.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GridColumn3.AppearanceHeader.Options.UseFont = True
        Me.GridColumn3.Caption = "จำนวนสั่งซื้อ"
        Me.GridColumn3.DisplayFormat.FormatString = "N2"
        Me.GridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn3.FieldName = "AmtOrder"
        Me.GridColumn3.MaxWidth = 180
        Me.GridColumn3.MinWidth = 100
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.OptionsColumn.ReadOnly = True
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 5
        Me.GridColumn3.Width = 135
        '
        'ColAmtSale
        '
        Me.ColAmtSale.AppearanceCell.BackColor = System.Drawing.SystemColors.Info
        Me.ColAmtSale.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColAmtSale.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.ColAmtSale.AppearanceCell.Options.UseBackColor = True
        Me.ColAmtSale.AppearanceCell.Options.UseFont = True
        Me.ColAmtSale.AppearanceCell.Options.UseForeColor = True
        Me.ColAmtSale.AppearanceCell.Options.UseTextOptions = True
        Me.ColAmtSale.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ColAmtSale.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColAmtSale.AppearanceHeader.Options.UseFont = True
        Me.ColAmtSale.Caption = "จำนวนขาย"
        Me.ColAmtSale.DisplayFormat.FormatString = "N2"
        Me.ColAmtSale.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColAmtSale.FieldName = "AmtSale"
        Me.ColAmtSale.MaxWidth = 180
        Me.ColAmtSale.MinWidth = 100
        Me.ColAmtSale.Name = "ColAmtSale"
        Me.ColAmtSale.OptionsColumn.AllowEdit = False
        Me.ColAmtSale.OptionsColumn.ReadOnly = True
        Me.ColAmtSale.Visible = True
        Me.ColAmtSale.VisibleIndex = 6
        Me.ColAmtSale.Width = 135
        '
        'ColUnitC
        '
        Me.ColUnitC.AppearanceCell.BackColor = System.Drawing.Color.Honeydew
        Me.ColUnitC.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColUnitC.AppearanceCell.Options.UseBackColor = True
        Me.ColUnitC.AppearanceCell.Options.UseFont = True
        Me.ColUnitC.AppearanceCell.Options.UseTextOptions = True
        Me.ColUnitC.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColUnitC.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColUnitC.AppearanceHeader.Options.UseFont = True
        Me.ColUnitC.Caption = "หน่วย"
        Me.ColUnitC.FieldName = "UnitName"
        Me.ColUnitC.MaxWidth = 150
        Me.ColUnitC.MinWidth = 80
        Me.ColUnitC.Name = "ColUnitC"
        Me.ColUnitC.OptionsColumn.AllowEdit = False
        Me.ColUnitC.OptionsColumn.ReadOnly = True
        Me.ColUnitC.Visible = True
        Me.ColUnitC.VisibleIndex = 7
        Me.ColUnitC.Width = 80
        '
        'ColidSaleOrderDt_
        '
        Me.ColidSaleOrderDt_.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColidSaleOrderDt_.AppearanceCell.Options.UseFont = True
        Me.ColidSaleOrderDt_.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColidSaleOrderDt_.AppearanceHeader.Options.UseFont = True
        Me.ColidSaleOrderDt_.Caption = "idSaleOrderDt"
        Me.ColidSaleOrderDt_.FieldName = "idSaleOrderDt"
        Me.ColidSaleOrderDt_.Name = "ColidSaleOrderDt_"
        '
        'ColDelMt
        '
        Me.ColDelMt.AppearanceCell.BackColor = System.Drawing.Color.Honeydew
        Me.ColDelMt.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColDelMt.AppearanceCell.Options.UseBackColor = True
        Me.ColDelMt.AppearanceCell.Options.UseFont = True
        Me.ColDelMt.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColDelMt.AppearanceHeader.Options.UseFont = True
        Me.ColDelMt.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDelMt.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDelMt.Caption = "ลบ"
        Me.ColDelMt.ColumnEdit = Me.rptDelMt
        Me.ColDelMt.MaxWidth = 30
        Me.ColDelMt.MinWidth = 30
        Me.ColDelMt.Name = "ColDelMt"
        Me.ColDelMt.Visible = True
        Me.ColDelMt.VisibleIndex = 8
        Me.ColDelMt.Width = 30
        '
        'rptDelMt
        '
        Me.rptDelMt.AutoHeight = False
        Me.rptDelMt.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("rptDelMt.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject3, "", Nothing, Nothing, True)})
        Me.rptDelMt.Name = "rptDelMt"
        Me.rptDelMt.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'ColDateOrder
        '
        Me.ColDateOrder.Caption = "DateOrder"
        Me.ColDateOrder.FieldName = "DateOrder"
        Me.ColDateOrder.Name = "ColDateOrder"
        '
        'ColDateRq
        '
        Me.ColDateRq.Caption = "DateRequire"
        Me.ColDateRq.FieldName = "DateRequireD"
        Me.ColDateRq.Name = "ColDateRq"
        '
        'colidInvGroup_
        '
        Me.colidInvGroup_.Caption = "idInvGroup"
        Me.colidInvGroup_.FieldName = "idInvGroup"
        Me.colidInvGroup_.Name = "colidInvGroup_"
        '
        'PriceWholesale_fg
        '
        Me.PriceWholesale_fg.Caption = "PriceWholesale_fg"
        Me.PriceWholesale_fg.FieldName = "PriceWholesale_fg"
        Me.PriceWholesale_fg.Name = "PriceWholesale_fg"
        '
        'PriceRetail_fg
        '
        Me.PriceRetail_fg.Caption = "PriceRetail_fg"
        Me.PriceRetail_fg.FieldName = "PriceRetail_fg"
        Me.PriceRetail_fg.Name = "PriceRetail_fg"
        '
        'PriceBill_fg
        '
        Me.PriceBill_fg.Caption = "PriceBill_fg"
        Me.PriceBill_fg.FieldName = "PriceBill_fg"
        Me.PriceBill_fg.Name = "PriceBill_fg"
        '
        'idPdoType
        '
        Me.idPdoType.Caption = "idPdoType"
        Me.idPdoType.FieldName = "idPdoType"
        Me.idPdoType.Name = "idPdoType"
        '
        'CreditThirty_pdo
        '
        Me.CreditThirty_pdo.Caption = "CreditThirty_pdo"
        Me.CreditThirty_pdo.FieldName = "CreditThirty_pdo"
        Me.CreditThirty_pdo.Name = "CreditThirty_pdo"
        '
        'CreditSixty_pdo
        '
        Me.CreditSixty_pdo.Caption = "CreditSixty_pdo"
        Me.CreditSixty_pdo.FieldName = "CreditSixty_pdo"
        Me.CreditSixty_pdo.Name = "CreditSixty_pdo"
        '
        'PricePdo_pdo
        '
        Me.PricePdo_pdo.Caption = "PricePdo_pdo"
        Me.PricePdo_pdo.FieldName = "PricePdo_pdo"
        Me.PricePdo_pdo.Name = "PricePdo_pdo"
        '
        'PriceSeed
        '
        Me.PriceSeed.Caption = "PriceSeed"
        Me.PriceSeed.FieldName = "PriceSeed"
        Me.PriceSeed.Name = "PriceSeed"
        '
        'PdCode
        '
        Me.PdCode.Caption = "PdCode"
        Me.PdCode.FieldName = "PdCode"
        Me.PdCode.Name = "PdCode"
        '
        'DtType
        '
        Me.DtType.Caption = "DtType"
        Me.DtType.FieldName = "DtType"
        Me.DtType.Name = "DtType"
        '
        'idSubType
        '
        Me.idSubType.Caption = "idSubType"
        Me.idSubType.FieldName = "idSubType"
        Me.idSubType.Name = "idSubType"
        '
        'pWeight
        '
        Me.pWeight.Caption = "pWeight"
        Me.pWeight.FieldName = "pWeight"
        Me.pWeight.Name = "pWeight"
        '
        'idUnitW
        '
        Me.idUnitW.Caption = "idUnitW"
        Me.idUnitW.FieldName = "idUnitW"
        Me.idUnitW.Name = "idUnitW"
        '
        'WPerPack
        '
        Me.WPerPack.Caption = "WPerPack"
        Me.WPerPack.FieldName = "WPerPack"
        Me.WPerPack.Name = "WPerPack"
        '
        'ColidSaleOrder
        '
        Me.ColidSaleOrder.Caption = "idSaleOrder"
        Me.ColidSaleOrder.FieldName = "idSaleOrder"
        Me.ColidSaleOrder.Name = "ColidSaleOrder"
        '
        'ColidInvMain
        '
        Me.ColidInvMain.Caption = "idInvMain"
        Me.ColidInvMain.FieldName = "idInvMain"
        Me.ColidInvMain.Name = "ColidInvMain"
        '
        'ColidCusRefAddr
        '
        Me.ColidCusRefAddr.Caption = "idCusRefAddr"
        Me.ColidCusRefAddr.FieldName = "idCusRefAddr"
        Me.ColidCusRefAddr.Name = "ColidCusRefAddr"
        '
        'ColidType
        '
        Me.ColidType.Caption = "idType"
        Me.ColidType.FieldName = "idType"
        Me.ColidType.Name = "ColidType"
        '
        'GVOrderDt
        '
        Me.GVOrderDt.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVOrderDt.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVOrderDt.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GVOrderDt.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVOrderDt.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GVOrderDt.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GVOrderDt.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GVOrderDt.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GVOrderDt.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GVOrderDt.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVOrderDt.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GVOrderDt.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GVOrderDt.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVOrderDt.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.GVOrderDt.Appearance.Empty.Options.UseBackColor = True
        Me.GVOrderDt.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.GVOrderDt.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.GVOrderDt.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GVOrderDt.Appearance.EvenRow.Options.UseBackColor = True
        Me.GVOrderDt.Appearance.EvenRow.Options.UseBorderColor = True
        Me.GVOrderDt.Appearance.EvenRow.Options.UseForeColor = True
        Me.GVOrderDt.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVOrderDt.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVOrderDt.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GVOrderDt.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GVOrderDt.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GVOrderDt.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GVOrderDt.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVOrderDt.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.GVOrderDt.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVOrderDt.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVOrderDt.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GVOrderDt.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.GVOrderDt.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVOrderDt.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.GVOrderDt.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GVOrderDt.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVOrderDt.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVOrderDt.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.GVOrderDt.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.GVOrderDt.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVOrderDt.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVOrderDt.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVOrderDt.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVOrderDt.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVOrderDt.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVOrderDt.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVOrderDt.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GVOrderDt.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.GVOrderDt.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.GVOrderDt.Appearance.GroupButton.Options.UseBackColor = True
        Me.GVOrderDt.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GVOrderDt.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GVOrderDt.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GVOrderDt.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GVOrderDt.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVOrderDt.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GVOrderDt.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GVOrderDt.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVOrderDt.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.GVOrderDt.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.GVOrderDt.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GVOrderDt.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVOrderDt.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GVOrderDt.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GVOrderDt.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GVOrderDt.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVOrderDt.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GVOrderDt.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVOrderDt.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GVOrderDt.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GVOrderDt.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GVOrderDt.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVOrderDt.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVOrderDt.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GVOrderDt.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.GVOrderDt.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.GVOrderDt.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVOrderDt.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVOrderDt.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.GVOrderDt.Appearance.HorzLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.GVOrderDt.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVOrderDt.Appearance.HorzLine.Options.UseBorderColor = True
        Me.GVOrderDt.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.GVOrderDt.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.GVOrderDt.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GVOrderDt.Appearance.OddRow.Options.UseBackColor = True
        Me.GVOrderDt.Appearance.OddRow.Options.UseBorderColor = True
        Me.GVOrderDt.Appearance.OddRow.Options.UseForeColor = True
        Me.GVOrderDt.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.GVOrderDt.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.GVOrderDt.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.GVOrderDt.Appearance.Preview.Options.UseBackColor = True
        Me.GVOrderDt.Appearance.Preview.Options.UseFont = True
        Me.GVOrderDt.Appearance.Preview.Options.UseForeColor = True
        Me.GVOrderDt.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVOrderDt.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GVOrderDt.Appearance.Row.Options.UseBackColor = True
        Me.GVOrderDt.Appearance.Row.Options.UseForeColor = True
        Me.GVOrderDt.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVOrderDt.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.GVOrderDt.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GVOrderDt.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.GVOrderDt.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.GVOrderDt.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVOrderDt.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GVOrderDt.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GVOrderDt.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GVOrderDt.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.GVOrderDt.Appearance.VertLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.GVOrderDt.Appearance.VertLine.Options.UseBackColor = True
        Me.GVOrderDt.Appearance.VertLine.Options.UseBorderColor = True
        Me.GVOrderDt.ColumnPanelRowHeight = 45
        Me.GVOrderDt.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColNo, Me.GridColumn1, Me.GridColumn11, Me.GridColumn12, Me.GridColumn13, Me.GridColumn14, Me.GridColumn16, Me.GridColumn18, Me.GridColumn20, Me.GridColumn21, Me.GridColumn22, Me.GridColumn23, Me.GridColumn24, Me.GridColumn25, Me.GridColumn26, Me.GridColumn27, Me.GridColumn28, Me.GridColumn29, Me.GridColumn30, Me.GridColumn31, Me.GridColumn32, Me.GridColumn33, Me.ColWPerPack, Me.ClidSaleOrderDt, Me.ClidSaleOrder, Me.ClidType})
        Me.GVOrderDt.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus
        Me.GVOrderDt.GridControl = Me.GCOrder
        Me.GVOrderDt.Name = "GVOrderDt"
        Me.GVOrderDt.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDown
        Me.GVOrderDt.OptionsDetail.AllowOnlyOneMasterRowExpanded = True
        Me.GVOrderDt.OptionsSelection.MultiSelect = True
        Me.GVOrderDt.OptionsView.EnableAppearanceEvenRow = True
        Me.GVOrderDt.OptionsView.EnableAppearanceOddRow = True
        Me.GVOrderDt.OptionsView.RowAutoHeight = True
        Me.GVOrderDt.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GVOrderDt.OptionsView.ShowGroupPanel = False
        Me.GVOrderDt.OptionsView.ShowIndicator = False
        '
        'ColNo
        '
        Me.ColNo.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColNo.AppearanceCell.Options.UseFont = True
        Me.ColNo.AppearanceCell.Options.UseTextOptions = True
        Me.ColNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColNo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColNo.AppearanceHeader.Options.UseFont = True
        Me.ColNo.AppearanceHeader.Options.UseTextOptions = True
        Me.ColNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColNo.Caption = "ลำดับ"
        Me.ColNo.MaxWidth = 50
        Me.ColNo.MinWidth = 50
        Me.ColNo.Name = "ColNo"
        Me.ColNo.OptionsColumn.AllowEdit = False
        Me.ColNo.OptionsColumn.ReadOnly = True
        Me.ColNo.Visible = True
        Me.ColNo.VisibleIndex = 0
        Me.ColNo.Width = 50
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn1.AppearanceHeader.Options.UseFont = True
        Me.GridColumn1.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridColumn1.Caption = "เลือกทีละรายการ"
        Me.GridColumn1.ColumnEdit = Me.rptSelDt
        Me.GridColumn1.MaxWidth = 55
        Me.GridColumn1.MinWidth = 55
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 1
        Me.GridColumn1.Width = 55
        '
        'rptSelDt
        '
        Me.rptSelDt.AutoHeight = False
        Me.rptSelDt.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("rptSelDt.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject4, "", Nothing, Nothing, True)})
        Me.rptSelDt.Name = "rptSelDt"
        Me.rptSelDt.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'GridColumn11
        '
        Me.GridColumn11.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.GridColumn11.AppearanceCell.Options.UseFont = True
        Me.GridColumn11.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn11.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GridColumn11.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GridColumn11.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridColumn11.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GridColumn11.AppearanceHeader.Options.UseFont = True
        Me.GridColumn11.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn11.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn11.Caption = "รายการสินค้า"
        Me.GridColumn11.ColumnEdit = Me.rptInvName
        Me.GridColumn11.FieldName = "InvName"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.OptionsColumn.AllowEdit = False
        Me.GridColumn11.OptionsColumn.ReadOnly = True
        Me.GridColumn11.OptionsColumn.TabStop = False
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 2
        Me.GridColumn11.Width = 306
        '
        'rptInvName
        '
        Me.rptInvName.Appearance.Options.UseTextOptions = True
        Me.rptInvName.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.rptInvName.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.rptInvName.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.rptInvName.Name = "rptInvName"
        '
        'GridColumn12
        '
        Me.GridColumn12.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.GridColumn12.AppearanceCell.Options.UseFont = True
        Me.GridColumn12.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn12.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn12.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GridColumn12.AppearanceHeader.Options.UseFont = True
        Me.GridColumn12.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn12.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn12.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridColumn12.Caption = "จำนวนสั่งซื้อ"
        Me.GridColumn12.DisplayFormat.FormatString = "#,##0.##"
        Me.GridColumn12.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn12.FieldName = "AmtOrder"
        Me.GridColumn12.MinWidth = 55
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.OptionsColumn.AllowEdit = False
        Me.GridColumn12.OptionsColumn.ReadOnly = True
        Me.GridColumn12.OptionsColumn.TabStop = False
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 3
        Me.GridColumn12.Width = 55
        '
        'GridColumn13
        '
        Me.GridColumn13.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.GridColumn13.AppearanceCell.Options.UseFont = True
        Me.GridColumn13.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn13.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn13.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GridColumn13.AppearanceHeader.Options.UseFont = True
        Me.GridColumn13.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn13.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn13.Caption = "หน่วย"
        Me.GridColumn13.FieldName = "UnitName"
        Me.GridColumn13.MaxWidth = 55
        Me.GridColumn13.MinWidth = 55
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.OptionsColumn.AllowEdit = False
        Me.GridColumn13.OptionsColumn.ReadOnly = True
        Me.GridColumn13.OptionsColumn.TabStop = False
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 4
        Me.GridColumn13.Width = 55
        '
        'GridColumn14
        '
        Me.GridColumn14.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GridColumn14.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.GridColumn14.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn14.AppearanceCell.Options.UseFont = True
        Me.GridColumn14.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn14.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn14.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GridColumn14.AppearanceHeader.Options.UseFont = True
        Me.GridColumn14.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn14.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn14.Caption = "วันที่ทำรายการ"
        Me.GridColumn14.FieldName = "DateTs"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.OptionsColumn.AllowEdit = False
        Me.GridColumn14.OptionsColumn.ReadOnly = True
        Me.GridColumn14.Width = 94
        '
        'GridColumn16
        '
        Me.GridColumn16.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.GridColumn16.AppearanceCell.Options.UseFont = True
        Me.GridColumn16.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GridColumn16.AppearanceHeader.Options.UseFont = True
        Me.GridColumn16.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn16.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn16.Caption = "idComp"
        Me.GridColumn16.FieldName = "idComp"
        Me.GridColumn16.Name = "GridColumn16"
        '
        'GridColumn18
        '
        Me.GridColumn18.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.GridColumn18.AppearanceCell.Options.UseFont = True
        Me.GridColumn18.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GridColumn18.AppearanceHeader.Options.UseFont = True
        Me.GridColumn18.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn18.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn18.Caption = "CompName"
        Me.GridColumn18.FieldName = "CompName"
        Me.GridColumn18.Name = "GridColumn18"
        '
        'GridColumn20
        '
        Me.GridColumn20.Caption = "idInvGroup"
        Me.GridColumn20.FieldName = "idInvGroup"
        Me.GridColumn20.Name = "GridColumn20"
        '
        'GridColumn21
        '
        Me.GridColumn21.Caption = "PriceWholesale_fg"
        Me.GridColumn21.FieldName = "PriceWholesale_fg"
        Me.GridColumn21.Name = "GridColumn21"
        '
        'GridColumn22
        '
        Me.GridColumn22.Caption = "PriceRetail_fg"
        Me.GridColumn22.FieldName = "PriceRetail_fg"
        Me.GridColumn22.Name = "GridColumn22"
        '
        'GridColumn23
        '
        Me.GridColumn23.Caption = "PriceBill_fg"
        Me.GridColumn23.FieldName = "PriceBill_fg"
        Me.GridColumn23.Name = "GridColumn23"
        '
        'GridColumn24
        '
        Me.GridColumn24.Caption = "idPdoType"
        Me.GridColumn24.FieldName = "idPdoType"
        Me.GridColumn24.Name = "GridColumn24"
        '
        'GridColumn25
        '
        Me.GridColumn25.Caption = "CreditThirty_pdo"
        Me.GridColumn25.FieldName = "CreditThirty_pdo"
        Me.GridColumn25.Name = "GridColumn25"
        '
        'GridColumn26
        '
        Me.GridColumn26.Caption = "CreditSixty_pdo"
        Me.GridColumn26.FieldName = "CreditSixty_pdo"
        Me.GridColumn26.Name = "GridColumn26"
        '
        'GridColumn27
        '
        Me.GridColumn27.Caption = "PricePdo_pdo"
        Me.GridColumn27.FieldName = "PricePdo_pdo"
        Me.GridColumn27.Name = "GridColumn27"
        '
        'GridColumn28
        '
        Me.GridColumn28.Caption = "PriceSeed"
        Me.GridColumn28.FieldName = "PriceSeed"
        Me.GridColumn28.Name = "GridColumn28"
        '
        'GridColumn29
        '
        Me.GridColumn29.Caption = "PdCode"
        Me.GridColumn29.FieldName = "PdCode"
        Me.GridColumn29.Name = "GridColumn29"
        '
        'GridColumn30
        '
        Me.GridColumn30.Caption = "DtType"
        Me.GridColumn30.FieldName = "DtType"
        Me.GridColumn30.Name = "GridColumn30"
        '
        'GridColumn31
        '
        Me.GridColumn31.Caption = "idSubType"
        Me.GridColumn31.FieldName = "idSubType"
        Me.GridColumn31.Name = "GridColumn31"
        '
        'GridColumn32
        '
        Me.GridColumn32.Caption = "idUnitW"
        Me.GridColumn32.FieldName = "idUnitW"
        Me.GridColumn32.Name = "GridColumn32"
        '
        'GridColumn33
        '
        Me.GridColumn33.Caption = "pWeight"
        Me.GridColumn33.FieldName = "pWeight"
        Me.GridColumn33.Name = "GridColumn33"
        '
        'ColWPerPack
        '
        Me.ColWPerPack.Caption = "WPerPack"
        Me.ColWPerPack.FieldName = "WPerPack"
        Me.ColWPerPack.Name = "ColWPerPack"
        '
        'ClidSaleOrderDt
        '
        Me.ClidSaleOrderDt.Caption = "idSaleOrderDt"
        Me.ClidSaleOrderDt.FieldName = "idSaleOrderDt"
        Me.ClidSaleOrderDt.Name = "ClidSaleOrderDt"
        '
        'ClidSaleOrder
        '
        Me.ClidSaleOrder.Caption = "idSaleOrder"
        Me.ClidSaleOrder.FieldName = "idSaleOrder"
        Me.ClidSaleOrder.Name = "ClidSaleOrder"
        '
        'ClidType
        '
        Me.ClidType.Caption = "idType"
        Me.ClidType.FieldName = "idType"
        Me.ClidType.Name = "ClidType"
        '
        'GCOrder
        '
        Me.GCOrder.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode2.LevelTemplate = Me.GVOrderDt
        GridLevelNode2.RelationName = "Level1"
        Me.GCOrder.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode2})
        Me.GCOrder.Location = New System.Drawing.Point(0, 113)
        Me.GCOrder.MainView = Me.GVOrderMt
        Me.GCOrder.Name = "GCOrder"
        Me.GCOrder.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rptSelOrder, Me.rptInvName, Me.rptSelDt, Me.rptNote})
        Me.GCOrder.Size = New System.Drawing.Size(721, 577)
        Me.GCOrder.TabIndex = 4
        Me.GCOrder.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVOrderMt, Me.GVOrderDt})
        '
        'GVOrderMt
        '
        Me.GVOrderMt.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVOrderMt.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVOrderMt.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GVOrderMt.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVOrderMt.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GVOrderMt.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GVOrderMt.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GVOrderMt.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GVOrderMt.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GVOrderMt.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVOrderMt.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GVOrderMt.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GVOrderMt.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVOrderMt.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.GVOrderMt.Appearance.Empty.Options.UseBackColor = True
        Me.GVOrderMt.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVOrderMt.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVOrderMt.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GVOrderMt.Appearance.EvenRow.Options.UseBackColor = True
        Me.GVOrderMt.Appearance.EvenRow.Options.UseBorderColor = True
        Me.GVOrderMt.Appearance.EvenRow.Options.UseForeColor = True
        Me.GVOrderMt.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVOrderMt.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVOrderMt.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GVOrderMt.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GVOrderMt.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GVOrderMt.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GVOrderMt.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVOrderMt.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.GVOrderMt.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVOrderMt.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVOrderMt.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GVOrderMt.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.GVOrderMt.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVOrderMt.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.GVOrderMt.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GVOrderMt.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVOrderMt.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVOrderMt.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.GVOrderMt.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.GVOrderMt.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVOrderMt.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVOrderMt.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVOrderMt.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVOrderMt.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVOrderMt.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVOrderMt.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVOrderMt.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GVOrderMt.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.GVOrderMt.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.GVOrderMt.Appearance.GroupButton.Options.UseBackColor = True
        Me.GVOrderMt.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GVOrderMt.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GVOrderMt.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GVOrderMt.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GVOrderMt.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVOrderMt.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GVOrderMt.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GVOrderMt.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVOrderMt.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.GVOrderMt.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.GVOrderMt.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GVOrderMt.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVOrderMt.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GVOrderMt.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GVOrderMt.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GVOrderMt.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVOrderMt.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GVOrderMt.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVOrderMt.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GVOrderMt.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GVOrderMt.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GVOrderMt.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVOrderMt.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVOrderMt.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GVOrderMt.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.GVOrderMt.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.GVOrderMt.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVOrderMt.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVOrderMt.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.GVOrderMt.Appearance.HorzLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.GVOrderMt.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVOrderMt.Appearance.HorzLine.Options.UseBorderColor = True
        Me.GVOrderMt.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVOrderMt.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVOrderMt.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GVOrderMt.Appearance.OddRow.Options.UseBackColor = True
        Me.GVOrderMt.Appearance.OddRow.Options.UseBorderColor = True
        Me.GVOrderMt.Appearance.OddRow.Options.UseForeColor = True
        Me.GVOrderMt.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.GVOrderMt.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.GVOrderMt.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.GVOrderMt.Appearance.Preview.Options.UseBackColor = True
        Me.GVOrderMt.Appearance.Preview.Options.UseFont = True
        Me.GVOrderMt.Appearance.Preview.Options.UseForeColor = True
        Me.GVOrderMt.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVOrderMt.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GVOrderMt.Appearance.Row.Options.UseBackColor = True
        Me.GVOrderMt.Appearance.Row.Options.UseForeColor = True
        Me.GVOrderMt.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVOrderMt.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.GVOrderMt.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GVOrderMt.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.GVOrderMt.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.GVOrderMt.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVOrderMt.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GVOrderMt.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GVOrderMt.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GVOrderMt.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.GVOrderMt.Appearance.VertLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.GVOrderMt.Appearance.VertLine.Options.UseBackColor = True
        Me.GVOrderMt.Appearance.VertLine.Options.UseBorderColor = True
        Me.GVOrderMt.ColumnPanelRowHeight = 45
        Me.GVOrderMt.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColNum, Me.ColSel, Me.ColPsCancel, Me.ColCancelNote, Me.ColidSaleOrder_, Me.ColDateOrderD, Me.ColDateRequire, Me.ColDocCode_, Me.ColDocRef, Me.ColDateTs, Me.GridColumn35, Me.GridColumn36, Me.GridColumn37, Me.GridColumn38})
        Me.GVOrderMt.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus
        Me.GVOrderMt.GridControl = Me.GCOrder
        Me.GVOrderMt.Name = "GVOrderMt"
        Me.GVOrderMt.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDown
        Me.GVOrderMt.OptionsDetail.AllowOnlyOneMasterRowExpanded = True
        Me.GVOrderMt.OptionsSelection.MultiSelect = True
        Me.GVOrderMt.OptionsView.EnableAppearanceEvenRow = True
        Me.GVOrderMt.OptionsView.EnableAppearanceOddRow = True
        Me.GVOrderMt.OptionsView.RowAutoHeight = True
        Me.GVOrderMt.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GVOrderMt.OptionsView.ShowGroupPanel = False
        Me.GVOrderMt.OptionsView.ShowIndicator = False
        Me.GVOrderMt.PaintStyleName = "MixedXP"
        '
        'ColNum
        '
        Me.ColNum.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColNum.AppearanceCell.Options.UseFont = True
        Me.ColNum.AppearanceCell.Options.UseTextOptions = True
        Me.ColNum.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColNum.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColNum.AppearanceHeader.Options.UseFont = True
        Me.ColNum.AppearanceHeader.Options.UseTextOptions = True
        Me.ColNum.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColNum.Caption = "ลำดับ"
        Me.ColNum.MaxWidth = 40
        Me.ColNum.MinWidth = 40
        Me.ColNum.Name = "ColNum"
        Me.ColNum.OptionsColumn.AllowEdit = False
        Me.ColNum.OptionsColumn.ReadOnly = True
        Me.ColNum.OptionsColumn.TabStop = False
        Me.ColNum.Visible = True
        Me.ColNum.VisibleIndex = 0
        Me.ColNum.Width = 40
        '
        'ColSel
        '
        Me.ColSel.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColSel.AppearanceHeader.Options.UseFont = True
        Me.ColSel.AppearanceHeader.Options.UseTextOptions = True
        Me.ColSel.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColSel.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColSel.Caption = "เลือกทั้งหมด"
        Me.ColSel.ColumnEdit = Me.rptSelOrder
        Me.ColSel.FieldName = "Chk"
        Me.ColSel.MaxWidth = 55
        Me.ColSel.MinWidth = 55
        Me.ColSel.Name = "ColSel"
        Me.ColSel.Visible = True
        Me.ColSel.VisibleIndex = 1
        Me.ColSel.Width = 55
        '
        'rptSelOrder
        '
        Me.rptSelOrder.AutoHeight = False
        Me.rptSelOrder.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Global.SAM.My.Resources.Resources.forward_arrow16x16, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject5, "", Nothing, Nothing, True)})
        Me.rptSelOrder.Name = "rptSelOrder"
        Me.rptSelOrder.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'ColPsCancel
        '
        Me.ColPsCancel.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColPsCancel.AppearanceCell.Options.UseFont = True
        Me.ColPsCancel.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColPsCancel.AppearanceHeader.Options.UseFont = True
        Me.ColPsCancel.AppearanceHeader.Options.UseTextOptions = True
        Me.ColPsCancel.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColPsCancel.Caption = "PsCancel"
        Me.ColPsCancel.FieldName = "PsCancel"
        Me.ColPsCancel.Name = "ColPsCancel"
        '
        'ColCancelNote
        '
        Me.ColCancelNote.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColCancelNote.AppearanceCell.Options.UseFont = True
        Me.ColCancelNote.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColCancelNote.AppearanceHeader.Options.UseFont = True
        Me.ColCancelNote.AppearanceHeader.Options.UseTextOptions = True
        Me.ColCancelNote.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColCancelNote.Caption = "CancelNote"
        Me.ColCancelNote.FieldName = "CancelNote"
        Me.ColCancelNote.Name = "ColCancelNote"
        '
        'ColidSaleOrder_
        '
        Me.ColidSaleOrder_.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColidSaleOrder_.AppearanceCell.Options.UseFont = True
        Me.ColidSaleOrder_.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColidSaleOrder_.AppearanceHeader.Options.UseFont = True
        Me.ColidSaleOrder_.AppearanceHeader.Options.UseTextOptions = True
        Me.ColidSaleOrder_.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColidSaleOrder_.Caption = "idSaleOrder"
        Me.ColidSaleOrder_.FieldName = "idSaleOrder"
        Me.ColidSaleOrder_.Name = "ColidSaleOrder_"
        '
        'ColDateOrderD
        '
        Me.ColDateOrderD.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColDateOrderD.AppearanceCell.Options.UseFont = True
        Me.ColDateOrderD.AppearanceCell.Options.UseTextOptions = True
        Me.ColDateOrderD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDateOrderD.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColDateOrderD.AppearanceHeader.Options.UseFont = True
        Me.ColDateOrderD.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDateOrderD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDateOrderD.Caption = "วันที่สั่งซื้อ"
        Me.ColDateOrderD.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.ColDateOrderD.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.ColDateOrderD.FieldName = "DateOrderD"
        Me.ColDateOrderD.MaxWidth = 80
        Me.ColDateOrderD.MinWidth = 80
        Me.ColDateOrderD.Name = "ColDateOrderD"
        Me.ColDateOrderD.OptionsColumn.AllowEdit = False
        Me.ColDateOrderD.OptionsColumn.ReadOnly = True
        Me.ColDateOrderD.OptionsColumn.TabStop = False
        Me.ColDateOrderD.Width = 80
        '
        'ColDateRequire
        '
        Me.ColDateRequire.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColDateRequire.AppearanceCell.Options.UseFont = True
        Me.ColDateRequire.AppearanceCell.Options.UseTextOptions = True
        Me.ColDateRequire.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDateRequire.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColDateRequire.AppearanceHeader.Options.UseFont = True
        Me.ColDateRequire.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDateRequire.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDateRequire.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColDateRequire.Caption = "วันที่ต้องการสินค้า"
        Me.ColDateRequire.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.ColDateRequire.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.ColDateRequire.FieldName = "DateRequireD"
        Me.ColDateRequire.MaxWidth = 80
        Me.ColDateRequire.MinWidth = 80
        Me.ColDateRequire.Name = "ColDateRequire"
        Me.ColDateRequire.OptionsColumn.AllowEdit = False
        Me.ColDateRequire.OptionsColumn.ReadOnly = True
        Me.ColDateRequire.OptionsColumn.TabStop = False
        Me.ColDateRequire.Width = 80
        '
        'ColDocCode_
        '
        Me.ColDocCode_.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColDocCode_.AppearanceCell.Options.UseFont = True
        Me.ColDocCode_.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColDocCode_.AppearanceHeader.Options.UseFont = True
        Me.ColDocCode_.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDocCode_.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDocCode_.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColDocCode_.Caption = "เลขที่สั่งซื้อ (Order No.)"
        Me.ColDocCode_.FieldName = "DocCode"
        Me.ColDocCode_.MaxWidth = 100
        Me.ColDocCode_.MinWidth = 100
        Me.ColDocCode_.Name = "ColDocCode_"
        Me.ColDocCode_.OptionsColumn.AllowEdit = False
        Me.ColDocCode_.OptionsColumn.ReadOnly = True
        Me.ColDocCode_.OptionsColumn.TabStop = False
        Me.ColDocCode_.Visible = True
        Me.ColDocCode_.VisibleIndex = 2
        Me.ColDocCode_.Width = 100
        '
        'ColDocRef
        '
        Me.ColDocRef.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColDocRef.AppearanceCell.Options.UseFont = True
        Me.ColDocRef.AppearanceCell.Options.UseTextOptions = True
        Me.ColDocRef.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.ColDocRef.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColDocRef.AppearanceHeader.Options.UseFont = True
        Me.ColDocRef.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDocRef.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDocRef.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColDocRef.Caption = "เลขที่อ้างอิง"
        Me.ColDocRef.FieldName = "DocRef"
        Me.ColDocRef.MaxWidth = 100
        Me.ColDocRef.MinWidth = 100
        Me.ColDocRef.Name = "ColDocRef"
        Me.ColDocRef.OptionsColumn.AllowEdit = False
        Me.ColDocRef.OptionsColumn.ReadOnly = True
        Me.ColDocRef.OptionsColumn.TabStop = False
        Me.ColDocRef.Visible = True
        Me.ColDocRef.VisibleIndex = 3
        Me.ColDocRef.Width = 100
        '
        'ColDateTs
        '
        Me.ColDateTs.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColDateTs.AppearanceCell.Options.UseFont = True
        Me.ColDateTs.AppearanceCell.Options.UseTextOptions = True
        Me.ColDateTs.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDateTs.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColDateTs.AppearanceHeader.Options.UseFont = True
        Me.ColDateTs.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDateTs.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDateTs.Caption = "วันที่ทำรายการ"
        Me.ColDateTs.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.ColDateTs.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.ColDateTs.FieldName = "DateTsD"
        Me.ColDateTs.MaxWidth = 90
        Me.ColDateTs.MinWidth = 90
        Me.ColDateTs.Name = "ColDateTs"
        Me.ColDateTs.OptionsColumn.AllowEdit = False
        Me.ColDateTs.OptionsColumn.ReadOnly = True
        Me.ColDateTs.OptionsColumn.TabStop = False
        Me.ColDateTs.Visible = True
        Me.ColDateTs.VisibleIndex = 4
        Me.ColDateTs.Width = 90
        '
        'GridColumn35
        '
        Me.GridColumn35.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.GridColumn35.AppearanceCell.Options.UseFont = True
        Me.GridColumn35.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn35.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn35.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GridColumn35.AppearanceHeader.Options.UseFont = True
        Me.GridColumn35.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn35.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn35.Caption = "เวลา"
        Me.GridColumn35.FieldName = "TimeTs"
        Me.GridColumn35.MaxWidth = 55
        Me.GridColumn35.MinWidth = 55
        Me.GridColumn35.Name = "GridColumn35"
        Me.GridColumn35.OptionsColumn.AllowEdit = False
        Me.GridColumn35.OptionsColumn.ReadOnly = True
        Me.GridColumn35.OptionsColumn.TabStop = False
        Me.GridColumn35.Visible = True
        Me.GridColumn35.VisibleIndex = 5
        Me.GridColumn35.Width = 55
        '
        'GridColumn36
        '
        Me.GridColumn36.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.GridColumn36.AppearanceCell.Options.UseFont = True
        Me.GridColumn36.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn36.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GridColumn36.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GridColumn36.AppearanceHeader.Options.UseFont = True
        Me.GridColumn36.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn36.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn36.Caption = "คำอธิบายรายการ"
        Me.GridColumn36.ColumnEdit = Me.rptNote
        Me.GridColumn36.FieldName = "NoteOrder"
        Me.GridColumn36.Name = "GridColumn36"
        Me.GridColumn36.OptionsColumn.AllowEdit = False
        Me.GridColumn36.OptionsColumn.ReadOnly = True
        Me.GridColumn36.OptionsColumn.TabStop = False
        Me.GridColumn36.Visible = True
        Me.GridColumn36.VisibleIndex = 7
        Me.GridColumn36.Width = 189
        '
        'rptNote
        '
        Me.rptNote.Appearance.Options.UseTextOptions = True
        Me.rptNote.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.rptNote.Name = "rptNote"
        '
        'GridColumn37
        '
        Me.GridColumn37.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.GridColumn37.AppearanceCell.Options.UseFont = True
        Me.GridColumn37.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GridColumn37.AppearanceHeader.Options.UseFont = True
        Me.GridColumn37.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn37.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn37.Caption = "เจ้าหน้าที่ขาย"
        Me.GridColumn37.FieldName = "PsSale"
        Me.GridColumn37.MaxWidth = 100
        Me.GridColumn37.MinWidth = 100
        Me.GridColumn37.Name = "GridColumn37"
        Me.GridColumn37.OptionsColumn.AllowEdit = False
        Me.GridColumn37.OptionsColumn.ReadOnly = True
        Me.GridColumn37.OptionsColumn.TabStop = False
        Me.GridColumn37.Visible = True
        Me.GridColumn37.VisibleIndex = 6
        Me.GridColumn37.Width = 100
        '
        'GridColumn38
        '
        Me.GridColumn38.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.GridColumn38.AppearanceCell.Options.UseFont = True
        Me.GridColumn38.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GridColumn38.AppearanceHeader.Options.UseFont = True
        Me.GridColumn38.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn38.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn38.Caption = "ช่องทางก.สั่งซื้อ"
        Me.GridColumn38.Name = "GridColumn38"
        Me.GridColumn38.Width = 421
        '
        'RepositoryItemButtonEdit2
        '
        Me.RepositoryItemButtonEdit2.AutoHeight = False
        Me.RepositoryItemButtonEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)})
        Me.RepositoryItemButtonEdit2.Name = "RepositoryItemButtonEdit2"
        Me.RepositoryItemButtonEdit2.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'RepositoryItemMemoEdit2
        '
        Me.RepositoryItemMemoEdit2.Appearance.Options.UseTextOptions = True
        Me.RepositoryItemMemoEdit2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.RepositoryItemMemoEdit2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.RepositoryItemMemoEdit2.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.RepositoryItemMemoEdit2.Name = "RepositoryItemMemoEdit2"
        '
        'RepositoryItemButtonEdit1
        '
        Me.RepositoryItemButtonEdit1.AutoHeight = False
        Me.RepositoryItemButtonEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)})
        Me.RepositoryItemButtonEdit1.Name = "RepositoryItemButtonEdit1"
        Me.RepositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'RepositoryItemMemoEdit1
        '
        Me.RepositoryItemMemoEdit1.Appearance.Options.UseTextOptions = True
        Me.RepositoryItemMemoEdit1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.RepositoryItemMemoEdit1.Name = "RepositoryItemMemoEdit1"
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.Transparent
        Me.Panel8.Controls.Add(Me.txtCount)
        Me.Panel8.Controls.Add(Me.Label1)
        Me.Panel8.Controls.Add(Me.Label4)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel8.Location = New System.Drawing.Point(496, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(225, 33)
        Me.Panel8.TabIndex = 611
        '
        'txtCount
        '
        Me.txtCount.BackColor = System.Drawing.Color.Black
        Me.txtCount.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCount.ForeColor = System.Drawing.Color.Lime
        Me.txtCount.Location = New System.Drawing.Point(62, 6)
        Me.txtCount.Name = "txtCount"
        Me.txtCount.Size = New System.Drawing.Size(100, 23)
        Me.txtCount.TabIndex = 610
        Me.txtCount.Text = "0"
        Me.txtCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(168, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 16)
        Me.Label1.TabIndex = 596
        Me.Label1.Text = "รายการ"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(5, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 16)
        Me.Label4.TabIndex = 594
        Me.Label4.Text = "จำนวน"
        '
        'PanelControl1
        '
        Me.PanelControl1.Appearance.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.PanelControl1.Appearance.BackColor2 = System.Drawing.Color.LightSteelBlue
        Me.PanelControl1.Appearance.Options.UseBackColor = True
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.cbDocRef)
        Me.PanelControl1.Controls.Add(Me.cbOrderNo)
        Me.PanelControl1.Controls.Add(Me.txtDocRef)
        Me.PanelControl1.Controls.Add(Me.txtOrderNo)
        Me.PanelControl1.Controls.Add(Me.PanelControl2)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(721, 80)
        Me.PanelControl1.TabIndex = 1
        '
        'cbDocRef
        '
        Me.cbDocRef.AutoSize = True
        Me.cbDocRef.BackColor = System.Drawing.Color.Transparent
        Me.cbDocRef.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDocRef.Location = New System.Drawing.Point(367, 52)
        Me.cbDocRef.Name = "cbDocRef"
        Me.cbDocRef.Size = New System.Drawing.Size(91, 18)
        Me.cbDocRef.TabIndex = 2
        Me.cbDocRef.Text = "เลขที่อ้างอิง"
        Me.cbDocRef.UseVisualStyleBackColor = False
        '
        'cbOrderNo
        '
        Me.cbOrderNo.AutoSize = True
        Me.cbOrderNo.BackColor = System.Drawing.Color.Transparent
        Me.cbOrderNo.Checked = True
        Me.cbOrderNo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbOrderNo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbOrderNo.Location = New System.Drawing.Point(16, 52)
        Me.cbOrderNo.Name = "cbOrderNo"
        Me.cbOrderNo.Size = New System.Drawing.Size(159, 18)
        Me.cbOrderNo.TabIndex = 0
        Me.cbOrderNo.Text = "เลขที่สั่งซื้อ (Order No.)"
        Me.cbOrderNo.UseVisualStyleBackColor = False
        '
        'txtDocRef
        '
        Me.txtDocRef.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtDocRef.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtDocRef.Enabled = False
        Me.txtDocRef.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDocRef.Location = New System.Drawing.Point(462, 49)
        Me.txtDocRef.Name = "txtDocRef"
        Me.txtDocRef.Size = New System.Drawing.Size(190, 23)
        Me.txtDocRef.TabIndex = 3
        '
        'txtOrderNo
        '
        Me.txtOrderNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtOrderNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtOrderNo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrderNo.Location = New System.Drawing.Point(179, 49)
        Me.txtOrderNo.Name = "txtOrderNo"
        Me.txtOrderNo.Size = New System.Drawing.Size(172, 23)
        Me.txtOrderNo.TabIndex = 1
        '
        'PanelControl2
        '
        Me.PanelControl2.Appearance.BackColor = System.Drawing.Color.LightBlue
        Me.PanelControl2.Appearance.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.PanelControl2.Appearance.Options.UseBackColor = True
        Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl2.Controls.Add(Me.Panel4)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl2.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(721, 41)
        Me.PanelControl2.TabIndex = 742
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.Controls.Add(Me.lblPartnerName)
        Me.Panel4.Controls.Add(Me.LabelControl1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(721, 41)
        Me.Panel4.TabIndex = 612
        '
        'lblPartnerName
        '
        Me.lblPartnerName.BackColor = System.Drawing.Color.Transparent
        Me.lblPartnerName.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblPartnerName.ForeColor = System.Drawing.Color.Navy
        Me.lblPartnerName.Location = New System.Drawing.Point(47, 3)
        Me.lblPartnerName.Name = "lblPartnerName"
        Me.lblPartnerName.Size = New System.Drawing.Size(654, 34)
        Me.lblPartnerName.TabIndex = 611
        Me.lblPartnerName.Text = "ชื่อลูกค้า"
        Me.lblPartnerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Image = CType(resources.GetObject("LabelControl1.Appearance.Image"), System.Drawing.Image)
        Me.LabelControl1.Location = New System.Drawing.Point(9, 3)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(32, 32)
        Me.LabelControl1.TabIndex = 612
        '
        'PanelControl3
        '
        Me.PanelControl3.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PanelControl3.Appearance.BackColor2 = System.Drawing.Color.LightSteelBlue
        Me.PanelControl3.Appearance.Options.UseBackColor = True
        Me.PanelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl3.Controls.Add(Me.Panel1)
        Me.PanelControl3.Controls.Add(Me.Panel2)
        Me.PanelControl3.Controls.Add(Me.Panel8)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl3.Location = New System.Drawing.Point(0, 80)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(721, 33)
        Me.PanelControl3.TabIndex = 741
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.lblSelected)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(237, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(259, 33)
        Me.Panel1.TabIndex = 613
        Me.Panel1.Visible = False
        '
        'lblSelected
        '
        Me.lblSelected.BackColor = System.Drawing.Color.Black
        Me.lblSelected.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblSelected.ForeColor = System.Drawing.Color.Lime
        Me.lblSelected.Location = New System.Drawing.Point(92, 6)
        Me.lblSelected.Name = "lblSelected"
        Me.lblSelected.Size = New System.Drawing.Size(100, 23)
        Me.lblSelected.TabIndex = 610
        Me.lblSelected.Text = "0"
        Me.lblSelected.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(198, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 16)
        Me.Label5.TabIndex = 596
        Me.Label5.Text = "รายการ"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(3, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 16)
        Me.Label6.TabIndex = 594
        Me.Label6.Text = "จำนวนที่เลือก"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.btnLotADD)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(153, 33)
        Me.Panel2.TabIndex = 612
        Me.Panel2.Visible = False
        '
        'btnLotADD
        '
        Me.btnLotADD.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLotADD.Appearance.Options.UseFont = True
        Me.btnLotADD.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLotADD.Image = CType(resources.GetObject("btnLotADD.Image"), System.Drawing.Image)
        Me.btnLotADD.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btnLotADD.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnLotADD.Location = New System.Drawing.Point(5, 3)
        Me.btnLotADD.Name = "btnLotADD"
        Me.btnLotADD.Size = New System.Drawing.Size(141, 27)
        Me.btnLotADD.TabIndex = 633
        Me.btnLotADD.Text = "เลือก Lot สินค้า"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.GCOrder)
        Me.Panel3.Controls.Add(Me.PanelControl3)
        Me.Panel3.Controls.Add(Me.PanelControl1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(721, 690)
        Me.Panel3.TabIndex = 743
        '
        'PanelControl4
        '
        Me.PanelControl4.Appearance.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.PanelControl4.Appearance.BackColor2 = System.Drawing.Color.LightSteelBlue
        Me.PanelControl4.Appearance.Options.UseBackColor = True
        Me.PanelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl4.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelControl4.Location = New System.Drawing.Point(721, 0)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(11, 690)
        Me.PanelControl4.TabIndex = 744
        '
        'PanelControl5
        '
        Me.PanelControl5.Appearance.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.PanelControl5.Appearance.BackColor2 = System.Drawing.Color.LightSteelBlue
        Me.PanelControl5.Appearance.Options.UseBackColor = True
        Me.PanelControl5.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl5.Controls.Add(Me.GCLotFIFO)
        Me.PanelControl5.Controls.Add(Me.PanelControl6)
        Me.PanelControl5.Controls.Add(Me.Panel5)
        Me.PanelControl5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl5.Location = New System.Drawing.Point(732, 0)
        Me.PanelControl5.Name = "PanelControl5"
        Me.PanelControl5.Size = New System.Drawing.Size(801, 690)
        Me.PanelControl5.TabIndex = 745
        '
        'PanelControl6
        '
        Me.PanelControl6.Appearance.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.PanelControl6.Appearance.BackColor2 = System.Drawing.Color.PowderBlue
        Me.PanelControl6.Appearance.Options.UseBackColor = True
        Me.PanelControl6.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl6.Controls.Add(Me.Panel7)
        Me.PanelControl6.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl6.Location = New System.Drawing.Point(0, 35)
        Me.PanelControl6.Name = "PanelControl6"
        Me.PanelControl6.Size = New System.Drawing.Size(801, 34)
        Me.PanelControl6.TabIndex = 746
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Transparent
        Me.Panel7.Controls.Add(Me.btnBack)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel7.Location = New System.Drawing.Point(561, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(240, 34)
        Me.Panel7.TabIndex = 801
        '
        'btnBack
        '
        Me.btnBack.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Appearance.Options.UseFont = True
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.Enabled = False
        Me.btnBack.Image = CType(resources.GetObject("btnBack.Image"), System.Drawing.Image)
        Me.btnBack.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btnBack.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnBack.Location = New System.Drawing.Point(3, 2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(233, 30)
        Me.btnBack.TabIndex = 634
        Me.btnBack.Text = "เลือก Lot เสร็จสิ้น กลับสู่หน้าหลัก"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Controls.Add(Me.GroupBox4)
        Me.Panel5.Controls.Add(Me.Label8)
        Me.Panel5.Controls.Add(Me.LabelControl2)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(801, 35)
        Me.Panel5.TabIndex = 800
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Transparent
        Me.Panel6.Controls.Add(Me.txtCountLot)
        Me.Panel6.Controls.Add(Me.Label10)
        Me.Panel6.Controls.Add(Me.Label11)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel6.Location = New System.Drawing.Point(577, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(222, 33)
        Me.Panel6.TabIndex = 800
        '
        'txtCountLot
        '
        Me.txtCountLot.BackColor = System.Drawing.Color.Black
        Me.txtCountLot.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCountLot.ForeColor = System.Drawing.Color.Lime
        Me.txtCountLot.Location = New System.Drawing.Point(62, 6)
        Me.txtCountLot.Name = "txtCountLot"
        Me.txtCountLot.Size = New System.Drawing.Size(100, 23)
        Me.txtCountLot.TabIndex = 610
        Me.txtCountLot.Text = "0"
        Me.txtCountLot.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Navy
        Me.Label10.Location = New System.Drawing.Point(168, 9)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 16)
        Me.Label10.TabIndex = 596
        Me.Label10.Text = "รายการ"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Navy
        Me.Label11.Location = New System.Drawing.Point(5, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 16)
        Me.Label11.TabIndex = 594
        Me.Label11.Text = "จำนวน"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.rdb60)
        Me.GroupBox4.Controls.Add(Me.rdb90)
        Me.GroupBox4.Controls.Add(Me.rdb30)
        Me.GroupBox4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox4.Location = New System.Drawing.Point(202, -4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(287, 35)
        Me.GroupBox4.TabIndex = 795
        Me.GroupBox4.TabStop = False
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(6, 6)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 32)
        Me.Label7.TabIndex = 796
        Me.Label7.Text = "วันที่ผลิตไม่เกิน"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'rdb60
        '
        Me.rdb60.AutoSize = True
        Me.rdb60.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rdb60.Location = New System.Drawing.Point(170, 13)
        Me.rdb60.Name = "rdb60"
        Me.rdb60.Size = New System.Drawing.Size(56, 18)
        Me.rdb60.TabIndex = 1
        Me.rdb60.Text = "60 วัน"
        Me.rdb60.UseVisualStyleBackColor = True
        '
        'rdb90
        '
        Me.rdb90.AutoSize = True
        Me.rdb90.Checked = True
        Me.rdb90.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rdb90.Location = New System.Drawing.Point(112, 13)
        Me.rdb90.Name = "rdb90"
        Me.rdb90.Size = New System.Drawing.Size(56, 18)
        Me.rdb90.TabIndex = 0
        Me.rdb90.TabStop = True
        Me.rdb90.Text = "90 วัน"
        Me.rdb90.UseVisualStyleBackColor = True
        '
        'rdb30
        '
        Me.rdb30.AutoSize = True
        Me.rdb30.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rdb30.Location = New System.Drawing.Point(227, 13)
        Me.rdb30.Name = "rdb30"
        Me.rdb30.Size = New System.Drawing.Size(56, 18)
        Me.rdb30.TabIndex = 2
        Me.rdb30.Text = "30 วัน"
        Me.rdb30.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(35, 2)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(168, 31)
        Me.Label8.TabIndex = 798
        Me.Label8.Text = "Lot ที่เลือกสำหรับขาย :"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Image = CType(resources.GetObject("LabelControl2.Appearance.Image"), System.Drawing.Image)
        Me.LabelControl2.Location = New System.Drawing.Point(5, 0)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(32, 32)
        Me.LabelControl2.TabIndex = 799
        '
        'ColDocCode_PO
        '
        Me.ColDocCode_PO.AppearanceCell.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ColDocCode_PO.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColDocCode_PO.AppearanceCell.Options.UseBackColor = True
        Me.ColDocCode_PO.AppearanceCell.Options.UseFont = True
        Me.ColDocCode_PO.AppearanceCell.Options.UseTextOptions = True
        Me.ColDocCode_PO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.ColDocCode_PO.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColDocCode_PO.AppearanceHeader.Options.UseFont = True
        Me.ColDocCode_PO.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDocCode_PO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDocCode_PO.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColDocCode_PO.Caption = "ผลิตตาม PO"
        Me.ColDocCode_PO.FieldName = "DocCode_PO"
        Me.ColDocCode_PO.MinWidth = 100
        Me.ColDocCode_PO.Name = "ColDocCode_PO"
        Me.ColDocCode_PO.OptionsColumn.AllowEdit = False
        Me.ColDocCode_PO.OptionsColumn.ReadOnly = True
        Me.ColDocCode_PO.Visible = True
        Me.ColDocCode_PO.VisibleIndex = 0
        Me.ColDocCode_PO.Width = 110
        '
        'ColDocCodeRef
        '
        Me.ColDocCodeRef.AppearanceCell.BackColor = System.Drawing.Color.Honeydew
        Me.ColDocCodeRef.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColDocCodeRef.AppearanceCell.Options.UseBackColor = True
        Me.ColDocCodeRef.AppearanceCell.Options.UseFont = True
        Me.ColDocCodeRef.AppearanceCell.Options.UseTextOptions = True
        Me.ColDocCodeRef.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.ColDocCodeRef.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColDocCodeRef.AppearanceHeader.Options.UseFont = True
        Me.ColDocCodeRef.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDocCodeRef.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDocCodeRef.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColDocCodeRef.Caption = "เลขที่อ้างอิง (PO)"
        Me.ColDocCodeRef.FieldName = "DocRef"
        Me.ColDocCodeRef.MinWidth = 100
        Me.ColDocCodeRef.Name = "ColDocCodeRef"
        Me.ColDocCodeRef.Visible = True
        Me.ColDocCodeRef.VisibleIndex = 3
        Me.ColDocCodeRef.Width = 300
        '
        'FrmMnOrderSel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1533, 690)
        Me.Controls.Add(Me.PanelControl5)
        Me.Controls.Add(Me.PanelControl4)
        Me.Controls.Add(Me.Panel3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmMnOrderSel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "รายการสั่งซื้อของลูกค้า"
        CType(Me.GVLotSale, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptWh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptDelDt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCLotFIFO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVSaleOrder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptAddLot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptProductName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptDelMt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVOrderDt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptSelDt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptInvName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCOrder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVOrderMt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptSelOrder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptNote, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl5.ResumeLayout(False)
        CType(Me.PanelControl6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl6.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel8 As Panel
    Friend WithEvents txtCount As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GCOrder As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVOrderMt As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColNum As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColPsCancel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColCancelNote As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColidSaleOrder_ As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDateOrderD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDocRef As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDateTs As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblPartnerName As Label
    Friend WithEvents ColSel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnLotADD As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblSelected As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ColDateRequire As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txtDocRef As TextBox
    Friend WithEvents txtOrderNo As TextBox
    Friend WithEvents rptSelOrder As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl5 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GCLotFIFO As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVLotSale As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColidRefLot_ As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LotNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColWHName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rptWh As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents ColAmtBal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDateGen As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColMFG As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColUnitBal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColAmountCut As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDelLot As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rptDelDt As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents ColidLot As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColidSaleOrderDt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColidUnitBal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GVSaleOrder As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColNumC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColAddLot As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rptAddLot As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents ColDocCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColAmtSale As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColUnitC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColidSaleOrderDt_ As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDelMt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rptDelMt As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents rdb60 As RadioButton
    Friend WithEvents rdb90 As RadioButton
    Friend WithEvents rdb30 As RadioButton
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents rptInvName As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents Panel6 As Panel
    Friend WithEvents txtCountLot As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents ColDateOrder As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDateRq As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelControl6 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnBack As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel7 As Panel
    Friend WithEvents ColidWh As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colidInvGroup_ As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PriceWholesale_fg As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PriceRetail_fg As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PriceBill_fg As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents idPdoType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CreditThirty_pdo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CreditSixty_pdo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PricePdo_pdo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PriceSeed As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PdCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cbOrderNo As CheckBox
    Friend WithEvents cbDocRef As CheckBox
    Friend WithEvents rptProductName As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents DtType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents idSubType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents idLotSPM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents pWeight As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents idUnitW As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WPerPack As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColCompRec As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GVOrderDt As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn18 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn20 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn21 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn22 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn23 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn24 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn25 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn26 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn27 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn28 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn29 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn30 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn31 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn32 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn33 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColWPerPack As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn35 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn36 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn37 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn38 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rptSelDt As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents ClidSaleOrderDt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDocCode_ As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColidSaleOrder As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ClidSaleOrder As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rptNote As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents ColidInvMain As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemButtonEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents RepositoryItemMemoEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemButtonEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents ColAmtCurStock As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColidCusRefAddr As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColidType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ClidType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDocCode_PO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDocCodeRef As DevExpress.XtraGrid.Columns.GridColumn
End Class
