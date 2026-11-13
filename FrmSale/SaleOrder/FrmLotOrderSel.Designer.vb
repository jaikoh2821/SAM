<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLotOrderSel
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
        Dim GridFormatRule1 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLotOrderSel))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim GridFormatRule2 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleExpression1 As DevExpress.XtraEditors.FormatConditionRuleExpression = New DevExpress.XtraEditors.FormatConditionRuleExpression()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.GVLotSale = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColidRefLot_ = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColLotNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColWHName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rptWh = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.ColAmtBal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDateGen = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColMFG = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColUnitBal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColAmountCut = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDelLot = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rptbtnDel = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.ColidLot = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColidSaleOrderDt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColidUnitBal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCLotFIFO = New DevExpress.XtraGrid.GridControl()
        Me.GVSaleOrder = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColNumC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColAddLot = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rptAddLot = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.ColDocCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColInvName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColAmtOrder = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColAmtSale = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColUnitC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColidSaleOrderDt_ = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDelMt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rptDel = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.rptbtnEditAddLot = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.rptbtnEditImageList = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lblPartnerName = New System.Windows.Forms.Label()
        Me.rdb60 = New System.Windows.Forms.RadioButton()
        Me.rdb90 = New System.Windows.Forms.RadioButton()
        Me.rdb30 = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.GVLotSale, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptWh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptbtnDel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCLotFIFO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVSaleOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptAddLot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptDel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptbtnEditAddLot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptbtnEditImageList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GVLotSale
        '
        Me.GVLotSale.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColidRefLot_, Me.ColLotNo, Me.ColWHName, Me.ColAmtBal, Me.colDateGen, Me.ColMFG, Me.ColUnitBal, Me.ColAmountCut, Me.ColDelLot, Me.ColidLot, Me.ColidSaleOrderDt, Me.ColidUnitBal})
        GridFormatRule1.Name = "Format0"
        GridFormatRule1.Rule = Nothing
        Me.GVLotSale.FormatRules.Add(GridFormatRule1)
        Me.GVLotSale.GridControl = Me.GCLotFIFO
        Me.GVLotSale.Name = "GVLotSale"
        Me.GVLotSale.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect
        Me.GVLotSale.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
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
        'ColLotNo
        '
        Me.ColLotNo.AppearanceCell.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ColLotNo.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColLotNo.AppearanceCell.Options.UseBackColor = True
        Me.ColLotNo.AppearanceCell.Options.UseFont = True
        Me.ColLotNo.AppearanceCell.Options.UseTextOptions = True
        Me.ColLotNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.ColLotNo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColLotNo.AppearanceHeader.Options.UseFont = True
        Me.ColLotNo.AppearanceHeader.Options.UseTextOptions = True
        Me.ColLotNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColLotNo.Caption = "Lot No."
        Me.ColLotNo.FieldName = "LotNo"
        Me.ColLotNo.MinWidth = 80
        Me.ColLotNo.Name = "ColLotNo"
        Me.ColLotNo.OptionsColumn.AllowEdit = False
        Me.ColLotNo.OptionsColumn.ReadOnly = True
        Me.ColLotNo.Visible = True
        Me.ColLotNo.VisibleIndex = 0
        Me.ColLotNo.Width = 810
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
        Me.ColWHName.VisibleIndex = 1
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
        Me.ColAmtBal.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.ColAmtBal.VisibleIndex = 2
        Me.ColAmtBal.Width = 120
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
        Me.colDateGen.VisibleIndex = 5
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
        Me.ColMFG.VisibleIndex = 6
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
        Me.ColUnitBal.VisibleIndex = 3
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
        Me.ColAmountCut.VisibleIndex = 4
        Me.ColAmountCut.Width = 120
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
        Me.ColDelLot.ColumnEdit = Me.rptbtnDel
        Me.ColDelLot.MaxWidth = 30
        Me.ColDelLot.MinWidth = 30
        Me.ColDelLot.Name = "ColDelLot"
        Me.ColDelLot.Visible = True
        Me.ColDelLot.VisibleIndex = 7
        Me.ColDelLot.Width = 30
        '
        'rptbtnDel
        '
        Me.rptbtnDel.AutoHeight = False
        Me.rptbtnDel.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("rptbtnDel.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.rptbtnDel.Name = "rptbtnDel"
        Me.rptbtnDel.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
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
        'GCLotFIFO
        '
        Me.GCLotFIFO.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode1.LevelTemplate = Me.GVLotSale
        GridLevelNode1.RelationName = "Level1"
        Me.GCLotFIFO.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.GCLotFIFO.Location = New System.Drawing.Point(0, 35)
        Me.GCLotFIFO.MainView = Me.GVSaleOrder
        Me.GCLotFIFO.Name = "GCLotFIFO"
        Me.GCLotFIFO.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rptbtnDel, Me.rptbtnEditAddLot, Me.rptbtnEditImageList, Me.rptDel, Me.rptAddLot, Me.rptWh})
        Me.GCLotFIFO.Size = New System.Drawing.Size(1012, 461)
        Me.GCLotFIFO.TabIndex = 794
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
        Me.GVSaleOrder.ColumnPanelRowHeight = 22
        Me.GVSaleOrder.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColNumC, Me.ColAddLot, Me.ColDocCode, Me.ColInvName, Me.ColAmtOrder, Me.ColAmtSale, Me.ColUnitC, Me.ColidSaleOrderDt_, Me.ColDelMt})
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
        Me.GVSaleOrder.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect
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
        Me.ColAddLot.ColumnEdit = Me.rptAddLot
        Me.ColAddLot.MaxWidth = 40
        Me.ColAddLot.MinWidth = 40
        Me.ColAddLot.Name = "ColAddLot"
        Me.ColAddLot.OptionsColumn.ReadOnly = True
        Me.ColAddLot.OptionsColumn.ShowCaption = False
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
        Me.ColDocCode.Caption = "เลขที่สั่งซื้อ (Order)"
        Me.ColDocCode.FieldName = "DocCode"
        Me.ColDocCode.MinWidth = 135
        Me.ColDocCode.Name = "ColDocCode"
        Me.ColDocCode.OptionsColumn.AllowEdit = False
        Me.ColDocCode.OptionsColumn.ReadOnly = True
        Me.ColDocCode.Visible = True
        Me.ColDocCode.VisibleIndex = 2
        Me.ColDocCode.Width = 164
        '
        'ColInvName
        '
        Me.ColInvName.AppearanceCell.BackColor = System.Drawing.Color.Honeydew
        Me.ColInvName.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColInvName.AppearanceCell.Options.UseBackColor = True
        Me.ColInvName.AppearanceCell.Options.UseFont = True
        Me.ColInvName.AppearanceCell.Options.UseTextOptions = True
        Me.ColInvName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.ColInvName.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColInvName.AppearanceHeader.Options.UseFont = True
        Me.ColInvName.AppearanceHeader.Options.UseTextOptions = True
        Me.ColInvName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColInvName.Caption = "รายการสั่งซื้อ"
        Me.ColInvName.FieldName = "InvName"
        Me.ColInvName.MinWidth = 200
        Me.ColInvName.Name = "ColInvName"
        Me.ColInvName.OptionsColumn.AllowEdit = False
        Me.ColInvName.OptionsColumn.ReadOnly = True
        Me.ColInvName.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "name", "ทั้งหมด {0:0} รายการ")})
        Me.ColInvName.Visible = True
        Me.ColInvName.VisibleIndex = 3
        Me.ColInvName.Width = 886
        '
        'ColAmtOrder
        '
        Me.ColAmtOrder.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.ColAmtOrder.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColAmtOrder.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.ColAmtOrder.AppearanceCell.Options.UseBackColor = True
        Me.ColAmtOrder.AppearanceCell.Options.UseFont = True
        Me.ColAmtOrder.AppearanceCell.Options.UseForeColor = True
        Me.ColAmtOrder.AppearanceCell.Options.UseTextOptions = True
        Me.ColAmtOrder.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ColAmtOrder.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColAmtOrder.AppearanceHeader.Options.UseFont = True
        Me.ColAmtOrder.Caption = "จำนวนสั่งซื้อ"
        Me.ColAmtOrder.DisplayFormat.FormatString = "N2"
        Me.ColAmtOrder.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColAmtOrder.FieldName = "AmtOrder"
        Me.ColAmtOrder.MaxWidth = 180
        Me.ColAmtOrder.MinWidth = 100
        Me.ColAmtOrder.Name = "ColAmtOrder"
        Me.ColAmtOrder.OptionsColumn.AllowEdit = False
        Me.ColAmtOrder.OptionsColumn.ReadOnly = True
        Me.ColAmtOrder.Visible = True
        Me.ColAmtOrder.VisibleIndex = 4
        Me.ColAmtOrder.Width = 172
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
        Me.ColAmtSale.VisibleIndex = 5
        Me.ColAmtSale.Width = 172
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
        Me.ColUnitC.MinWidth = 90
        Me.ColUnitC.Name = "ColUnitC"
        Me.ColUnitC.OptionsColumn.AllowEdit = False
        Me.ColUnitC.OptionsColumn.ReadOnly = True
        Me.ColUnitC.Visible = True
        Me.ColUnitC.VisibleIndex = 6
        Me.ColUnitC.Width = 144
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
        Me.ColDelMt.ColumnEdit = Me.rptDel
        Me.ColDelMt.MaxWidth = 30
        Me.ColDelMt.MinWidth = 30
        Me.ColDelMt.Name = "ColDelMt"
        Me.ColDelMt.Visible = True
        Me.ColDelMt.VisibleIndex = 7
        Me.ColDelMt.Width = 30
        '
        'rptDel
        '
        Me.rptDel.AutoHeight = False
        Me.rptDel.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("rptDel.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject3, "", Nothing, Nothing, True)})
        Me.rptDel.Name = "rptDel"
        Me.rptDel.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'rptbtnEditAddLot
        '
        Me.rptbtnEditAddLot.AutoHeight = False
        Me.rptbtnEditAddLot.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("rptbtnEditAddLot.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject4, "", Nothing, Nothing, True)})
        Me.rptbtnEditAddLot.Name = "rptbtnEditAddLot"
        Me.rptbtnEditAddLot.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'rptbtnEditImageList
        '
        Me.rptbtnEditImageList.AutoHeight = False
        Me.rptbtnEditImageList.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.rptbtnEditImageList.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", "0", 0), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", "1", 1)})
        Me.rptbtnEditImageList.Name = "rptbtnEditImageList"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.GroupBox4)
        Me.Panel6.Controls.Add(Me.Panel1)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1012, 35)
        Me.Panel6.TabIndex = 795
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GroupBox4.Controls.Add(Me.lblPartnerName)
        Me.GroupBox4.Controls.Add(Me.rdb60)
        Me.GroupBox4.Controls.Add(Me.rdb90)
        Me.GroupBox4.Controls.Add(Me.rdb30)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox4.Location = New System.Drawing.Point(156, 0)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(309, 33)
        Me.GroupBox4.TabIndex = 795
        Me.GroupBox4.TabStop = False
        '
        'lblPartnerName
        '
        Me.lblPartnerName.BackColor = System.Drawing.Color.Transparent
        Me.lblPartnerName.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblPartnerName.ForeColor = System.Drawing.Color.Black
        Me.lblPartnerName.Location = New System.Drawing.Point(1, 2)
        Me.lblPartnerName.Name = "lblPartnerName"
        Me.lblPartnerName.Size = New System.Drawing.Size(100, 32)
        Me.lblPartnerName.TabIndex = 796
        Me.lblPartnerName.Text = "วันที่ผลิตไม่เกิน"
        Me.lblPartnerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'rdb60
        '
        Me.rdb60.AutoSize = True
        Me.rdb60.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rdb60.Location = New System.Drawing.Point(176, 9)
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
        Me.rdb90.Location = New System.Drawing.Point(107, 9)
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
        Me.rdb30.Location = New System.Drawing.Point(241, 9)
        Me.rdb30.Name = "rdb30"
        Me.rdb30.Size = New System.Drawing.Size(56, 18)
        Me.rdb30.TabIndex = 2
        Me.rdb30.Text = "30 วัน"
        Me.rdb30.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.SimpleButton3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(156, 33)
        Me.Panel1.TabIndex = 794
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton3.Appearance.Options.UseFont = True
        Me.SimpleButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SimpleButton3.Image = CType(resources.GetObject("SimpleButton3.Image"), System.Drawing.Image)
        Me.SimpleButton3.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.SimpleButton3.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.SimpleButton3.Location = New System.Drawing.Point(3, 2)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(148, 29)
        Me.SimpleButton3.TabIndex = 1
        Me.SimpleButton3.Text = "เพิ่มรายการออเดอร์"
        '
        'FrmLotOrderSel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1012, 496)
        Me.Controls.Add(Me.GCLotFIFO)
        Me.Controls.Add(Me.Panel6)
        Me.Name = "FrmLotOrderSel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmLotOrderSel"
        CType(Me.GVLotSale, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptWh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptbtnDel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCLotFIFO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVSaleOrder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptAddLot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptDel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptbtnEditAddLot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptbtnEditImageList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GCLotFIFO As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVLotSale As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColidRefLot_ As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColLotNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColWHName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColAmtBal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColUnitBal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColAmountCut As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDelLot As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rptbtnDel As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents GVSaleOrder As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColNumC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColAddLot As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rptbtnEditImageList As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
    Friend WithEvents ColInvName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColAmtOrder As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColUnitC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColidSaleOrderDt_ As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rptbtnEditAddLot As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents colDateGen As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ColidLot As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColidSaleOrderDt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColidUnitBal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents rdb60 As RadioButton
    Friend WithEvents rdb90 As RadioButton
    Friend WithEvents rdb30 As RadioButton
    Friend WithEvents lblPartnerName As Label
    Friend WithEvents ColDelMt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rptDel As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents rptAddLot As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents ColAmtSale As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rptWh As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents ColMFG As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDocCode As DevExpress.XtraGrid.Columns.GridColumn
End Class
