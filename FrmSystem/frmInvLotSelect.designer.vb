<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInvLotSelect
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
        Dim GridFormatRule1 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleExpression1 As DevExpress.XtraEditors.FormatConditionRuleExpression = New DevExpress.XtraEditors.FormatConditionRuleExpression()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim GridFormatRule2 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleExpression2 As DevExpress.XtraEditors.FormatConditionRuleExpression = New DevExpress.XtraEditors.FormatConditionRuleExpression()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInvLotSelect))
        Me.ColstCountStock = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rptSelectTransport = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn18 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn19 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
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
        Me.RepositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.GCSelected = New DevExpress.XtraGrid.GridControl()
        Me.GVSelected = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colNum = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLotNum = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInvName_ = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDelete = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rptDel = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.colidLot = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidInvGroup = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidInvMain_ = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidSubType_ = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidWh_ = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CompRec = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Weight = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.idUnitW = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.WareHouseName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ButtonUp = New System.Windows.Forms.Button()
        Me.ButtonDown = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.tpInventory = New DevExpress.XtraTab.XtraTabPage()
        Me.GCProduct = New DevExpress.XtraGrid.GridControl()
        Me.GVProduct = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colProductName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rptSelect = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.colLotNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAmount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWarehouseName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rptWh = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.colInvGroupName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInvGroup = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidWh = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidUnit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidLot_ = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidInvGroup_ = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidInvMain = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidSubType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDtType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidRefLot = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidSaleOrderDt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColCompRec = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColInvName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColpWeight = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColidUnitW = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.txtCount = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.ChkInvGroup = New System.Windows.Forms.CheckBox()
        Me.cmbInvName = New System.Windows.Forms.ComboBox()
        Me.txtInvName = New System.Windows.Forms.TextBox()
        Me.txtLotNo = New System.Windows.Forms.TextBox()
        Me.chkInvName = New System.Windows.Forms.CheckBox()
        Me.chkLotNo = New System.Windows.Forms.CheckBox()
        Me.tpTransport = New DevExpress.XtraTab.XtraTabPage()
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblCountTp = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PanelControl5 = New DevExpress.XtraEditors.PanelControl()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.ColPdCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PdCode = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptSelectTransport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCSelected, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVSelected, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptDel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.tpInventory.SuspendLayout()
        CType(Me.GCProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptSelect, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptWh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        Me.Panel8.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.tpTransport.SuspendLayout()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl5.SuspendLayout()
        Me.SuspendLayout()
        '
        'ColstCountStock
        '
        Me.ColstCountStock.Caption = "stCountStock"
        Me.ColstCountStock.FieldName = "stCountStock"
        Me.ColstCountStock.Name = "ColstCountStock"
        '
        'GridView1
        '
        Me.GridView1.ColumnPanelRowHeight = 35
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn4, Me.GridColumn5, Me.GridColumn8, Me.GridColumn10, Me.GridColumn13, Me.GridColumn14, Me.GridColumn15, Me.GridColumn16, Me.GridColumn17, Me.GridColumn18, Me.GridColumn19})
        Me.GridView1.GridControl = Me.GridControl2
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowIndicator = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "idPdPkLot"
        Me.GridColumn1.FieldName = "idPdPkLot"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn2.AppearanceHeader.Options.UseFont = True
        Me.GridColumn2.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridColumn2.Caption = "เลือก"
        Me.GridColumn2.ColumnEdit = Me.rptSelectTransport
        Me.GridColumn2.MaxWidth = 35
        Me.GridColumn2.MinWidth = 35
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        Me.GridColumn2.Width = 35
        '
        'rptSelectTransport
        '
        Me.rptSelectTransport.AutoHeight = False
        Me.rptSelectTransport.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Global.SAM.My.Resources.Resources.forward_arrow16x16, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.rptSelectTransport.Name = "rptSelectTransport"
        Me.rptSelectTransport.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'GridColumn4
        '
        Me.GridColumn4.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn4.AppearanceHeader.Options.UseFont = True
        Me.GridColumn4.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn4.Caption = "เลือก"
        Me.GridColumn4.ColumnEdit = Me.RepositoryItemCheckEdit2
        Me.GridColumn4.FieldName = "ChkKey"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Width = 98
        '
        'RepositoryItemCheckEdit2
        '
        Me.RepositoryItemCheckEdit2.AutoHeight = False
        Me.RepositoryItemCheckEdit2.Name = "RepositoryItemCheckEdit2"
        '
        'GridColumn5
        '
        Me.GridColumn5.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GridColumn5.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn5.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn5.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn5.AppearanceHeader.Options.UseFont = True
        Me.GridColumn5.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn5.Caption = "Lot No."
        Me.GridColumn5.FieldName = "LotNo"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.AllowEdit = False
        Me.GridColumn5.OptionsColumn.ReadOnly = True
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 1
        Me.GridColumn5.Width = 291
        '
        'GridColumn8
        '
        Me.GridColumn8.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridColumn8.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn8.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn8.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn8.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn8.AppearanceHeader.Options.UseFont = True
        Me.GridColumn8.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn8.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn8.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridColumn8.Caption = "จำนวนคงเหลือ"
        Me.GridColumn8.DisplayFormat.FormatString = "#,##0.######"
        Me.GridColumn8.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.GridColumn8.FieldName = "Amount"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsColumn.AllowEdit = False
        Me.GridColumn8.OptionsColumn.ReadOnly = True
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 2
        Me.GridColumn8.Width = 275
        '
        'GridColumn10
        '
        Me.GridColumn10.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GridColumn10.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn10.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn10.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn10.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn10.AppearanceHeader.Options.UseFont = True
        Me.GridColumn10.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn10.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn10.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridColumn10.Caption = "วันที่ผลิต"
        Me.GridColumn10.FieldName = "DateGen"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.OptionsColumn.AllowEdit = False
        Me.GridColumn10.OptionsColumn.ReadOnly = True
        Me.GridColumn10.Width = 398
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "วันหมดอายุ"
        Me.GridColumn13.Name = "GridColumn13"
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "อายุคงเหลือ(วัน)"
        Me.GridColumn14.Name = "GridColumn14"
        '
        'GridColumn15
        '
        Me.GridColumn15.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GridColumn15.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn15.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn15.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn15.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn15.AppearanceHeader.Options.UseFont = True
        Me.GridColumn15.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn15.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn15.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridColumn15.Caption = "คลัง"
        Me.GridColumn15.FieldName = "WareHouseName"
        Me.GridColumn15.MinWidth = 150
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.OptionsColumn.AllowEdit = False
        Me.GridColumn15.OptionsColumn.ReadOnly = True
        Me.GridColumn15.Visible = True
        Me.GridColumn15.VisibleIndex = 3
        Me.GridColumn15.Width = 200
        '
        'GridColumn16
        '
        Me.GridColumn16.Caption = "บริษัท"
        Me.GridColumn16.FieldName = "CompName"
        Me.GridColumn16.Name = "GridColumn16"
        '
        'GridColumn17
        '
        Me.GridColumn17.Caption = "CompRec"
        Me.GridColumn17.FieldName = "CompRec"
        Me.GridColumn17.Name = "GridColumn17"
        '
        'GridColumn18
        '
        Me.GridColumn18.Caption = "idSubType"
        Me.GridColumn18.FieldName = "idSubType"
        Me.GridColumn18.Name = "GridColumn18"
        '
        'GridColumn19
        '
        Me.GridColumn19.Caption = "idLotMain"
        Me.GridColumn19.FieldName = "idLot"
        Me.GridColumn19.Name = "GridColumn19"
        '
        'GridControl2
        '
        Me.GridControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl2.Location = New System.Drawing.Point(0, 89)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit2, Me.RepositoryItemLookUpEdit2, Me.rptSelectTransport})
        Me.GridControl2.Size = New System.Drawing.Size(722, 429)
        Me.GridControl2.TabIndex = 738
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2, Me.GridView1})
        '
        'GridView2
        '
        Me.GridView2.Appearance.FocusedCell.BackColor = System.Drawing.Color.BurlyWood
        Me.GridView2.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView2.Appearance.FocusedRow.BackColor = System.Drawing.Color.Wheat
        Me.GridView2.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView2.ColumnPanelRowHeight = 35
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn20, Me.GridColumn21, Me.GridColumn22, Me.GridColumn23, Me.GridColumn24, Me.GridColumn25, Me.GridColumn26, Me.GridColumn27, Me.GridColumn28, Me.GridColumn29, Me.ColstCountStock})
        GridFormatRule1.ApplyToRow = True
        GridFormatRule1.Column = Me.ColstCountStock
        GridFormatRule1.Name = "Format0"
        FormatConditionRuleExpression1.Expression = "[stCountStock] = 1"
        FormatConditionRuleExpression1.PredefinedName = "Red Fill"
        GridFormatRule1.Rule = FormatConditionRuleExpression1
        Me.GridView2.FormatRules.Add(GridFormatRule1)
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsNavigation.UseTabKey = False
        Me.GridView2.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GridView2.OptionsView.ShowGroupPanel = False
        Me.GridView2.ScrollStyle = DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.None
        '
        'GridColumn20
        '
        Me.GridColumn20.Caption = "idInvMain"
        Me.GridColumn20.FieldName = "idInvMain"
        Me.GridColumn20.Name = "GridColumn20"
        '
        'GridColumn21
        '
        Me.GridColumn21.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GridColumn21.AppearanceHeader.Options.UseFont = True
        Me.GridColumn21.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn21.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn21.Caption = "เลือก"
        Me.GridColumn21.ColumnEdit = Me.rptSelectTransport
        Me.GridColumn21.Name = "GridColumn21"
        Me.GridColumn21.Visible = True
        Me.GridColumn21.VisibleIndex = 0
        '
        'GridColumn22
        '
        Me.GridColumn22.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GridColumn22.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn22.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn22.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GridColumn22.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GridColumn22.AppearanceHeader.Options.UseFont = True
        Me.GridColumn22.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn22.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn22.Caption = "ชื่อสินค้า"
        Me.GridColumn22.FieldName = "InvName"
        Me.GridColumn22.Name = "GridColumn22"
        Me.GridColumn22.OptionsColumn.AllowEdit = False
        Me.GridColumn22.OptionsColumn.ReadOnly = True
        Me.GridColumn22.Visible = True
        Me.GridColumn22.VisibleIndex = 1
        Me.GridColumn22.Width = 774
        '
        'GridColumn23
        '
        Me.GridColumn23.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GridColumn23.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn23.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn23.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn23.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GridColumn23.AppearanceHeader.Options.UseFont = True
        Me.GridColumn23.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn23.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn23.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridColumn23.Caption = "ชื่อย่อ"
        Me.GridColumn23.FieldName = "ShortName"
        Me.GridColumn23.Name = "GridColumn23"
        Me.GridColumn23.OptionsColumn.AllowEdit = False
        Me.GridColumn23.OptionsColumn.ReadOnly = True
        Me.GridColumn23.Width = 91
        '
        'GridColumn24
        '
        Me.GridColumn24.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridColumn24.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn24.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn24.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn24.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GridColumn24.AppearanceHeader.Options.UseFont = True
        Me.GridColumn24.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn24.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn24.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridColumn24.Caption = "จน. คงเหลือ"
        Me.GridColumn24.DisplayFormat.FormatString = "#,##0.######"
        Me.GridColumn24.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.GridColumn24.FieldName = "Amount"
        Me.GridColumn24.Name = "GridColumn24"
        Me.GridColumn24.OptionsColumn.AllowEdit = False
        Me.GridColumn24.OptionsColumn.ReadOnly = True
        Me.GridColumn24.Width = 166
        '
        'GridColumn25
        '
        Me.GridColumn25.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GridColumn25.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn25.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn25.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn25.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GridColumn25.AppearanceHeader.Options.UseFont = True
        Me.GridColumn25.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn25.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn25.Caption = "หน่วย"
        Me.GridColumn25.FieldName = "UnitName"
        Me.GridColumn25.Name = "GridColumn25"
        Me.GridColumn25.OptionsColumn.AllowEdit = False
        Me.GridColumn25.OptionsColumn.ReadOnly = True
        Me.GridColumn25.Visible = True
        Me.GridColumn25.VisibleIndex = 2
        Me.GridColumn25.Width = 149
        '
        'GridColumn26
        '
        Me.GridColumn26.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridColumn26.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn26.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn26.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn26.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GridColumn26.AppearanceHeader.Options.UseFont = True
        Me.GridColumn26.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn26.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn26.Caption = "จน. คงเหลือ/กก."
        Me.GridColumn26.DisplayFormat.FormatString = "N2"
        Me.GridColumn26.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn26.FieldName = "WightOfKg"
        Me.GridColumn26.Name = "GridColumn26"
        Me.GridColumn26.OptionsColumn.AllowEdit = False
        Me.GridColumn26.OptionsColumn.ReadOnly = True
        Me.GridColumn26.Width = 110
        '
        'GridColumn27
        '
        Me.GridColumn27.Caption = "idUnit"
        Me.GridColumn27.FieldName = "idUnit"
        Me.GridColumn27.Name = "GridColumn27"
        '
        'GridColumn28
        '
        Me.GridColumn28.Caption = "dtType"
        Me.GridColumn28.FieldName = "dtType"
        Me.GridColumn28.Name = "GridColumn28"
        '
        'GridColumn29
        '
        Me.GridColumn29.Caption = "idInvGroup"
        Me.GridColumn29.FieldName = "idInvGroup"
        Me.GridColumn29.Name = "GridColumn29"
        '
        'RepositoryItemLookUpEdit2
        '
        Me.RepositoryItemLookUpEdit2.AutoHeight = False
        Me.RepositoryItemLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit2.Name = "RepositoryItemLookUpEdit2"
        '
        'GCSelected
        '
        Me.GCSelected.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCSelected.Location = New System.Drawing.Point(764, 33)
        Me.GCSelected.MainView = Me.GVSelected
        Me.GCSelected.Name = "GCSelected"
        Me.GCSelected.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rptDel})
        Me.GCSelected.Size = New System.Drawing.Size(420, 528)
        Me.GCSelected.TabIndex = 3
        Me.GCSelected.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVSelected})
        '
        'GVSelected
        '
        Me.GVSelected.Appearance.FocusedCell.BackColor = System.Drawing.Color.BurlyWood
        Me.GVSelected.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVSelected.Appearance.FocusedRow.BackColor = System.Drawing.Color.Wheat
        Me.GVSelected.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVSelected.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNum, Me.colLotNum, Me.colInvName_, Me.colDelete, Me.colidLot, Me.colidInvGroup, Me.colidInvMain_, Me.colidSubType_, Me.colidWh_, Me.CompRec, Me.Weight, Me.idUnitW, Me.WareHouseName, Me.ColPdCode})
        Me.GVSelected.GridControl = Me.GCSelected
        Me.GVSelected.Name = "GVSelected"
        Me.GVSelected.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GVSelected.OptionsView.ShowGroupPanel = False
        Me.GVSelected.OptionsView.ShowIndicator = False
        Me.GVSelected.ScrollStyle = DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.None
        '
        'colNum
        '
        Me.colNum.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.colNum.AppearanceCell.Options.UseBackColor = True
        Me.colNum.AppearanceCell.Options.UseTextOptions = True
        Me.colNum.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNum.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colNum.AppearanceHeader.Options.UseFont = True
        Me.colNum.AppearanceHeader.Options.UseTextOptions = True
        Me.colNum.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNum.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colNum.Caption = "ลำดับ"
        Me.colNum.MaxWidth = 45
        Me.colNum.MinWidth = 45
        Me.colNum.Name = "colNum"
        Me.colNum.OptionsColumn.AllowEdit = False
        Me.colNum.OptionsColumn.ReadOnly = True
        Me.colNum.Visible = True
        Me.colNum.VisibleIndex = 0
        Me.colNum.Width = 45
        '
        'colLotNum
        '
        Me.colLotNum.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.colLotNum.AppearanceCell.Options.UseBackColor = True
        Me.colLotNum.AppearanceCell.Options.UseTextOptions = True
        Me.colLotNum.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLotNum.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colLotNum.AppearanceHeader.Options.UseFont = True
        Me.colLotNum.AppearanceHeader.Options.UseTextOptions = True
        Me.colLotNum.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLotNum.Caption = "Lot No."
        Me.colLotNum.FieldName = "LotNo"
        Me.colLotNum.MinWidth = 40
        Me.colLotNum.Name = "colLotNum"
        Me.colLotNum.OptionsColumn.AllowEdit = False
        Me.colLotNum.OptionsColumn.ReadOnly = True
        Me.colLotNum.Visible = True
        Me.colLotNum.VisibleIndex = 1
        Me.colLotNum.Width = 210
        '
        'colInvName_
        '
        Me.colInvName_.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.colInvName_.AppearanceCell.Options.UseBackColor = True
        Me.colInvName_.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colInvName_.AppearanceHeader.Options.UseFont = True
        Me.colInvName_.AppearanceHeader.Options.UseTextOptions = True
        Me.colInvName_.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colInvName_.Caption = "รายการสินค้า"
        Me.colInvName_.FieldName = "InvName"
        Me.colInvName_.Name = "colInvName_"
        Me.colInvName_.OptionsColumn.AllowEdit = False
        Me.colInvName_.OptionsColumn.ReadOnly = True
        Me.colInvName_.Visible = True
        Me.colInvName_.VisibleIndex = 2
        Me.colInvName_.Width = 740
        '
        'colDelete
        '
        Me.colDelete.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.colDelete.AppearanceCell.Options.UseBackColor = True
        Me.colDelete.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colDelete.AppearanceHeader.Options.UseFont = True
        Me.colDelete.AppearanceHeader.Options.UseTextOptions = True
        Me.colDelete.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDelete.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colDelete.Caption = "ลบ"
        Me.colDelete.ColumnEdit = Me.rptDel
        Me.colDelete.MaxWidth = 35
        Me.colDelete.MinWidth = 35
        Me.colDelete.Name = "colDelete"
        Me.colDelete.Visible = True
        Me.colDelete.VisibleIndex = 3
        Me.colDelete.Width = 35
        '
        'rptDel
        '
        Me.rptDel.AutoHeight = False
        Me.rptDel.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Global.SAM.My.Resources.Resources.cross_circle_frame, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject2, "", Nothing, Nothing, True)})
        Me.rptDel.Name = "rptDel"
        Me.rptDel.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'colidLot
        '
        Me.colidLot.Caption = "idLot"
        Me.colidLot.FieldName = "idLot"
        Me.colidLot.Name = "colidLot"
        Me.colidLot.Width = 127
        '
        'colidInvGroup
        '
        Me.colidInvGroup.Caption = "idInvGroup"
        Me.colidInvGroup.FieldName = "idInvGroup"
        Me.colidInvGroup.Name = "colidInvGroup"
        Me.colidInvGroup.Width = 76
        '
        'colidInvMain_
        '
        Me.colidInvMain_.Caption = "idInvMain"
        Me.colidInvMain_.FieldName = "idInvMain"
        Me.colidInvMain_.Name = "colidInvMain_"
        '
        'colidSubType_
        '
        Me.colidSubType_.Caption = "idSubType_"
        Me.colidSubType_.FieldName = "idSubType"
        Me.colidSubType_.Name = "colidSubType_"
        '
        'colidWh_
        '
        Me.colidWh_.Caption = "idWh"
        Me.colidWh_.FieldName = "idWh"
        Me.colidWh_.Name = "colidWh_"
        '
        'CompRec
        '
        Me.CompRec.Caption = "CompRec"
        Me.CompRec.FieldName = "CompRec"
        Me.CompRec.Name = "CompRec"
        '
        'Weight
        '
        Me.Weight.Caption = "pWeight"
        Me.Weight.FieldName = "pWeight"
        Me.Weight.Name = "Weight"
        '
        'idUnitW
        '
        Me.idUnitW.Caption = "idUnitW"
        Me.idUnitW.FieldName = "idUnitW"
        Me.idUnitW.Name = "idUnitW"
        '
        'WareHouseName
        '
        Me.WareHouseName.Caption = "WareHouseName"
        Me.WareHouseName.FieldName = "WareHouseName"
        Me.WareHouseName.Name = "WareHouseName"
        '
        'PanelControl3
        '
        Me.PanelControl3.Appearance.BackColor = System.Drawing.Color.LightSteelBlue
        Me.PanelControl3.Appearance.BackColor2 = System.Drawing.Color.CornflowerBlue
        Me.PanelControl3.Appearance.Options.UseBackColor = True
        Me.PanelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl3.Controls.Add(Me.Button9)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl3.Location = New System.Drawing.Point(764, 0)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(420, 33)
        Me.PanelControl3.TabIndex = 740
        '
        'Button9
        '
        Me.Button9.AutoSize = True
        Me.Button9.BackColor = System.Drawing.Color.DimGray
        Me.Button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button9.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button9.ForeColor = System.Drawing.Color.White
        Me.Button9.Image = Global.SAM.My.Resources.Resources.trainingCheckStateIcon
        Me.Button9.Location = New System.Drawing.Point(0, 0)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(96, 33)
        Me.Button9.TabIndex = 6
        Me.Button9.Text = " เลือก"
        Me.Button9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.ButtonUp)
        Me.Panel2.Controls.Add(Me.ButtonDown)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(728, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(36, 561)
        Me.Panel2.TabIndex = 738
        '
        'ButtonUp
        '
        Me.ButtonUp.Image = Global.SAM.My.Resources.Resources.Up
        Me.ButtonUp.Location = New System.Drawing.Point(1, 242)
        Me.ButtonUp.Name = "ButtonUp"
        Me.ButtonUp.Size = New System.Drawing.Size(30, 34)
        Me.ButtonUp.TabIndex = 4
        Me.ButtonUp.TabStop = False
        Me.ButtonUp.UseVisualStyleBackColor = True
        '
        'ButtonDown
        '
        Me.ButtonDown.Image = Global.SAM.My.Resources.Resources.Down
        Me.ButtonDown.Location = New System.Drawing.Point(1, 275)
        Me.ButtonDown.Name = "ButtonDown"
        Me.ButtonDown.Size = New System.Drawing.Size(30, 34)
        Me.ButtonDown.TabIndex = 5
        Me.ButtonDown.TabStop = False
        Me.ButtonDown.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.XtraTabControl1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(728, 561)
        Me.Panel1.TabIndex = 741
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.tpInventory
        Me.XtraTabControl1.Size = New System.Drawing.Size(728, 561)
        Me.XtraTabControl1.TabIndex = 0
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tpInventory, Me.tpTransport})
        '
        'tpInventory
        '
        Me.tpInventory.Appearance.HeaderActive.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.tpInventory.Appearance.HeaderActive.ForeColor = System.Drawing.Color.Blue
        Me.tpInventory.Appearance.HeaderActive.Options.UseFont = True
        Me.tpInventory.Appearance.HeaderActive.Options.UseForeColor = True
        Me.tpInventory.Appearance.PageClient.BackColor = System.Drawing.Color.Cyan
        Me.tpInventory.Appearance.PageClient.Options.UseBackColor = True
        Me.tpInventory.Controls.Add(Me.GCProduct)
        Me.tpInventory.Controls.Add(Me.PanelControl2)
        Me.tpInventory.Controls.Add(Me.PanelControl1)
        Me.tpInventory.Image = Global.SAM.My.Resources.Resources.p_re
        Me.tpInventory.Name = "tpInventory"
        Me.tpInventory.Size = New System.Drawing.Size(722, 518)
        Me.tpInventory.Text = "สินค้า"
        '
        'GCProduct
        '
        Me.GCProduct.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCProduct.Location = New System.Drawing.Point(0, 101)
        Me.GCProduct.MainView = Me.GVProduct
        Me.GCProduct.Name = "GCProduct"
        Me.GCProduct.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rptSelect, Me.rptWh})
        Me.GCProduct.Size = New System.Drawing.Size(722, 417)
        Me.GCProduct.TabIndex = 2
        Me.GCProduct.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVProduct})
        '
        'GVProduct
        '
        Me.GVProduct.Appearance.FocusedCell.BackColor = System.Drawing.Color.BurlyWood
        Me.GVProduct.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVProduct.Appearance.FocusedRow.BackColor = System.Drawing.Color.Wheat
        Me.GVProduct.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVProduct.ColumnPanelRowHeight = 35
        Me.GVProduct.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colProductName, Me.colSel, Me.colLotNo, Me.colAmount, Me.colUnitName, Me.colWarehouseName, Me.colInvGroupName, Me.colInvGroup, Me.colidWh, Me.colidUnit, Me.colidLot_, Me.colidInvGroup_, Me.colidInvMain, Me.colidSubType, Me.colDtType, Me.colidRefLot, Me.colidSaleOrderDt, Me.ColCompRec, Me.ColInvName, Me.GridColumn3, Me.ColpWeight, Me.ColidUnitW, Me.PdCode})
        GridFormatRule2.ApplyToRow = True
        GridFormatRule2.Name = "Format0"
        FormatConditionRuleExpression2.Expression = "[stCountStock] = 1"
        FormatConditionRuleExpression2.PredefinedName = "Red Fill, Red Text"
        GridFormatRule2.Rule = FormatConditionRuleExpression2
        Me.GVProduct.FormatRules.Add(GridFormatRule2)
        Me.GVProduct.GridControl = Me.GCProduct
        Me.GVProduct.GroupCount = 1
        Me.GVProduct.GroupFormat = " [#image]{1} {2}"
        Me.GVProduct.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Amount", Nothing, "(คงเหลือ {0:#,##0.####})")})
        Me.GVProduct.Name = "GVProduct"
        Me.GVProduct.OptionsView.RowAutoHeight = True
        Me.GVProduct.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GVProduct.OptionsView.ShowGroupPanel = False
        Me.GVProduct.OptionsView.ShowIndicator = False
        Me.GVProduct.ScrollStyle = DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.None
        Me.GVProduct.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colProductName, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colProductName
        '
        Me.colProductName.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.colProductName.AppearanceCell.Options.UseBackColor = True
        Me.colProductName.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colProductName.AppearanceHeader.Options.UseFont = True
        Me.colProductName.AppearanceHeader.Options.UseTextOptions = True
        Me.colProductName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colProductName.Caption = "รายการสินค้า"
        Me.colProductName.FieldName = "InvNameShow"
        Me.colProductName.Name = "colProductName"
        Me.colProductName.OptionsColumn.AllowEdit = False
        Me.colProductName.OptionsColumn.ReadOnly = True
        Me.colProductName.OptionsColumn.TabStop = False
        Me.colProductName.Visible = True
        Me.colProductName.VisibleIndex = 2
        Me.colProductName.Width = 740
        '
        'colSel
        '
        Me.colSel.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colSel.AppearanceHeader.Options.UseFont = True
        Me.colSel.AppearanceHeader.Options.UseTextOptions = True
        Me.colSel.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSel.Caption = "เลือก"
        Me.colSel.ColumnEdit = Me.rptSelect
        Me.colSel.Name = "colSel"
        Me.colSel.Visible = True
        Me.colSel.VisibleIndex = 0
        Me.colSel.Width = 130
        '
        'rptSelect
        '
        Me.rptSelect.AutoHeight = False
        Me.rptSelect.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Global.SAM.My.Resources.Resources.forward_arrow16x16, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject3, "", Nothing, Nothing, True)})
        Me.rptSelect.Name = "rptSelect"
        Me.rptSelect.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'colLotNo
        '
        Me.colLotNo.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.colLotNo.AppearanceCell.Options.UseBackColor = True
        Me.colLotNo.AppearanceCell.Options.UseTextOptions = True
        Me.colLotNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colLotNo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colLotNo.AppearanceHeader.Options.UseFont = True
        Me.colLotNo.AppearanceHeader.Options.UseTextOptions = True
        Me.colLotNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLotNo.Caption = "Lot No."
        Me.colLotNo.FieldName = "LotNo"
        Me.colLotNo.MinWidth = 40
        Me.colLotNo.Name = "colLotNo"
        Me.colLotNo.OptionsColumn.AllowEdit = False
        Me.colLotNo.OptionsColumn.ReadOnly = True
        Me.colLotNo.OptionsColumn.TabStop = False
        Me.colLotNo.Visible = True
        Me.colLotNo.VisibleIndex = 1
        Me.colLotNo.Width = 376
        '
        'colAmount
        '
        Me.colAmount.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colAmount.AppearanceCell.Options.UseBackColor = True
        Me.colAmount.AppearanceCell.Options.UseTextOptions = True
        Me.colAmount.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colAmount.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colAmount.AppearanceHeader.Options.UseFont = True
        Me.colAmount.AppearanceHeader.Options.UseTextOptions = True
        Me.colAmount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colAmount.Caption = "จำนวนคงเหลือ"
        Me.colAmount.DisplayFormat.FormatString = "#,##0.####"
        Me.colAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colAmount.FieldName = "Amount"
        Me.colAmount.Name = "colAmount"
        Me.colAmount.OptionsColumn.AllowEdit = False
        Me.colAmount.OptionsColumn.ReadOnly = True
        Me.colAmount.OptionsColumn.TabStop = False
        Me.colAmount.Visible = True
        Me.colAmount.VisibleIndex = 2
        Me.colAmount.Width = 207
        '
        'colUnitName
        '
        Me.colUnitName.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.colUnitName.AppearanceCell.Options.UseBackColor = True
        Me.colUnitName.AppearanceCell.Options.UseTextOptions = True
        Me.colUnitName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colUnitName.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colUnitName.AppearanceHeader.Options.UseFont = True
        Me.colUnitName.AppearanceHeader.Options.UseTextOptions = True
        Me.colUnitName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colUnitName.Caption = "หน่วย"
        Me.colUnitName.FieldName = "UnitName"
        Me.colUnitName.Name = "colUnitName"
        Me.colUnitName.OptionsColumn.AllowEdit = False
        Me.colUnitName.OptionsColumn.ReadOnly = True
        Me.colUnitName.OptionsColumn.TabStop = False
        Me.colUnitName.Visible = True
        Me.colUnitName.VisibleIndex = 3
        Me.colUnitName.Width = 177
        '
        'colWarehouseName
        '
        Me.colWarehouseName.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.colWarehouseName.AppearanceCell.Options.UseBackColor = True
        Me.colWarehouseName.AppearanceCell.Options.UseTextOptions = True
        Me.colWarehouseName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colWarehouseName.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colWarehouseName.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colWarehouseName.AppearanceHeader.Options.UseFont = True
        Me.colWarehouseName.AppearanceHeader.Options.UseTextOptions = True
        Me.colWarehouseName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colWarehouseName.Caption = "คลังสินค้า"
        Me.colWarehouseName.ColumnEdit = Me.rptWh
        Me.colWarehouseName.FieldName = "full_lock"
        Me.colWarehouseName.Name = "colWarehouseName"
        Me.colWarehouseName.OptionsColumn.AllowEdit = False
        Me.colWarehouseName.OptionsColumn.ReadOnly = True
        Me.colWarehouseName.OptionsColumn.TabStop = False
        Me.colWarehouseName.Visible = True
        Me.colWarehouseName.VisibleIndex = 4
        Me.colWarehouseName.Width = 204
        '
        'rptWh
        '
        Me.rptWh.Appearance.Options.UseTextOptions = True
        Me.rptWh.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.rptWh.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.rptWh.Name = "rptWh"
        '
        'colInvGroupName
        '
        Me.colInvGroupName.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.colInvGroupName.AppearanceCell.Options.UseBackColor = True
        Me.colInvGroupName.AppearanceCell.Options.UseTextOptions = True
        Me.colInvGroupName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colInvGroupName.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colInvGroupName.AppearanceHeader.Options.UseFont = True
        Me.colInvGroupName.AppearanceHeader.Options.UseTextOptions = True
        Me.colInvGroupName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colInvGroupName.Caption = "ประเภทสินค้า"
        Me.colInvGroupName.FieldName = "InvGroupName"
        Me.colInvGroupName.Name = "colInvGroupName"
        Me.colInvGroupName.OptionsColumn.AllowEdit = False
        Me.colInvGroupName.OptionsColumn.ReadOnly = True
        Me.colInvGroupName.Width = 236
        '
        'colInvGroup
        '
        Me.colInvGroup.Caption = "idInvGroup"
        Me.colInvGroup.FieldName = "idInvGroup"
        Me.colInvGroup.Name = "colInvGroup"
        '
        'colidWh
        '
        Me.colidWh.Caption = "idWh"
        Me.colidWh.Name = "colidWh"
        '
        'colidUnit
        '
        Me.colidUnit.Caption = "idUnit"
        Me.colidUnit.FieldName = "idUnit"
        Me.colidUnit.Name = "colidUnit"
        '
        'colidLot_
        '
        Me.colidLot_.Caption = "idLot"
        Me.colidLot_.FieldName = "idLot"
        Me.colidLot_.Name = "colidLot_"
        Me.colidLot_.Width = 127
        '
        'colidInvGroup_
        '
        Me.colidInvGroup_.Caption = "idInvGroup"
        Me.colidInvGroup_.FieldName = "idInvGroup"
        Me.colidInvGroup_.Name = "colidInvGroup_"
        Me.colidInvGroup_.Width = 76
        '
        'colidInvMain
        '
        Me.colidInvMain.Caption = "idInvMain"
        Me.colidInvMain.FieldName = "idInvMain"
        Me.colidInvMain.Name = "colidInvMain"
        '
        'colidSubType
        '
        Me.colidSubType.Caption = "idSubType_"
        Me.colidSubType.FieldName = "idSubType"
        Me.colidSubType.Name = "colidSubType"
        '
        'colDtType
        '
        Me.colDtType.Caption = "DtType"
        Me.colDtType.FieldName = "dtType"
        Me.colDtType.Name = "colDtType"
        '
        'colidRefLot
        '
        Me.colidRefLot.Caption = "idRefLot"
        Me.colidRefLot.FieldName = "idRefLot"
        Me.colidRefLot.Name = "colidRefLot"
        '
        'colidSaleOrderDt
        '
        Me.colidSaleOrderDt.Caption = "idSaleOrderDt"
        Me.colidSaleOrderDt.FieldName = "idSaleOrderDt"
        Me.colidSaleOrderDt.Name = "colidSaleOrderDt"
        '
        'ColCompRec
        '
        Me.ColCompRec.Caption = "CompRec"
        Me.ColCompRec.FieldName = "CompRec"
        Me.ColCompRec.Name = "ColCompRec"
        '
        'ColInvName
        '
        Me.ColInvName.Caption = "InvName"
        Me.ColInvName.FieldName = "InvName"
        Me.ColInvName.Name = "ColInvName"
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "stCountStock"
        Me.GridColumn3.FieldName = "stCountStock"
        Me.GridColumn3.Name = "GridColumn3"
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
        'PanelControl2
        '
        Me.PanelControl2.Appearance.BackColor = System.Drawing.Color.LightSteelBlue
        Me.PanelControl2.Appearance.BackColor2 = System.Drawing.Color.CornflowerBlue
        Me.PanelControl2.Appearance.Options.UseBackColor = True
        Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl2.Controls.Add(Me.Panel8)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl2.Location = New System.Drawing.Point(0, 70)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(722, 31)
        Me.PanelControl2.TabIndex = 740
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.Transparent
        Me.Panel8.Controls.Add(Me.txtCount)
        Me.Panel8.Controls.Add(Me.Label1)
        Me.Panel8.Controls.Add(Me.Label4)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel8.Location = New System.Drawing.Point(497, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(225, 31)
        Me.Panel8.TabIndex = 611
        '
        'txtCount
        '
        Me.txtCount.BackColor = System.Drawing.Color.Black
        Me.txtCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCount.ForeColor = System.Drawing.Color.Lime
        Me.txtCount.Location = New System.Drawing.Point(60, 4)
        Me.txtCount.Name = "txtCount"
        Me.txtCount.Size = New System.Drawing.Size(100, 23)
        Me.txtCount.TabIndex = 610
        Me.txtCount.Text = "0"
        Me.txtCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(166, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 17)
        Me.Label1.TabIndex = 596
        Me.Label1.Text = "รายการ"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(3, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 17)
        Me.Label4.TabIndex = 594
        Me.Label4.Text = "จำนวน"
        '
        'PanelControl1
        '
        Me.PanelControl1.Appearance.BackColor = System.Drawing.Color.Lavender
        Me.PanelControl1.Appearance.BackColor2 = System.Drawing.Color.LightSteelBlue
        Me.PanelControl1.Appearance.Options.UseBackColor = True
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.ChkInvGroup)
        Me.PanelControl1.Controls.Add(Me.cmbInvName)
        Me.PanelControl1.Controls.Add(Me.txtInvName)
        Me.PanelControl1.Controls.Add(Me.txtLotNo)
        Me.PanelControl1.Controls.Add(Me.chkInvName)
        Me.PanelControl1.Controls.Add(Me.chkLotNo)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(722, 70)
        Me.PanelControl1.TabIndex = 1
        '
        'ChkInvGroup
        '
        Me.ChkInvGroup.AutoSize = True
        Me.ChkInvGroup.BackColor = System.Drawing.Color.Transparent
        Me.ChkInvGroup.Checked = True
        Me.ChkInvGroup.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkInvGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ChkInvGroup.Location = New System.Drawing.Point(25, 15)
        Me.ChkInvGroup.Name = "ChkInvGroup"
        Me.ChkInvGroup.Size = New System.Drawing.Size(89, 17)
        Me.ChkInvGroup.TabIndex = 0
        Me.ChkInvGroup.TabStop = False
        Me.ChkInvGroup.Text = "ประเภทสินค้า"
        Me.ChkInvGroup.UseVisualStyleBackColor = False
        '
        'cmbInvName
        '
        Me.cmbInvName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbInvName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmbInvName.FormattingEnabled = True
        Me.cmbInvName.Location = New System.Drawing.Point(120, 13)
        Me.cmbInvName.Name = "cmbInvName"
        Me.cmbInvName.Size = New System.Drawing.Size(240, 21)
        Me.cmbInvName.TabIndex = 1
        Me.cmbInvName.TabStop = False
        '
        'txtInvName
        '
        Me.txtInvName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtInvName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtInvName.Enabled = False
        Me.txtInvName.Location = New System.Drawing.Point(120, 39)
        Me.txtInvName.Name = "txtInvName"
        Me.txtInvName.Size = New System.Drawing.Size(240, 21)
        Me.txtInvName.TabIndex = 3
        '
        'txtLotNo
        '
        Me.txtLotNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtLotNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtLotNo.Enabled = False
        Me.txtLotNo.Location = New System.Drawing.Point(458, 13)
        Me.txtLotNo.Name = "txtLotNo"
        Me.txtLotNo.Size = New System.Drawing.Size(240, 21)
        Me.txtLotNo.TabIndex = 5
        '
        'chkInvName
        '
        Me.chkInvName.AutoSize = True
        Me.chkInvName.BackColor = System.Drawing.Color.Transparent
        Me.chkInvName.Checked = True
        Me.chkInvName.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkInvName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.chkInvName.Location = New System.Drawing.Point(25, 41)
        Me.chkInvName.Name = "chkInvName"
        Me.chkInvName.Size = New System.Drawing.Size(65, 17)
        Me.chkInvName.TabIndex = 2
        Me.chkInvName.TabStop = False
        Me.chkInvName.Text = "ชื่อสินค้า"
        Me.chkInvName.UseVisualStyleBackColor = False
        '
        'chkLotNo
        '
        Me.chkLotNo.AutoSize = True
        Me.chkLotNo.BackColor = System.Drawing.Color.Transparent
        Me.chkLotNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.chkLotNo.Location = New System.Drawing.Point(391, 17)
        Me.chkLotNo.Name = "chkLotNo"
        Me.chkLotNo.Size = New System.Drawing.Size(61, 17)
        Me.chkLotNo.TabIndex = 4
        Me.chkLotNo.Text = "Lot No."
        Me.chkLotNo.UseVisualStyleBackColor = False
        '
        'tpTransport
        '
        Me.tpTransport.Appearance.HeaderActive.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.tpTransport.Appearance.HeaderActive.ForeColor = System.Drawing.Color.Blue
        Me.tpTransport.Appearance.HeaderActive.Options.UseFont = True
        Me.tpTransport.Appearance.HeaderActive.Options.UseForeColor = True
        Me.tpTransport.Controls.Add(Me.GridControl2)
        Me.tpTransport.Controls.Add(Me.PanelControl4)
        Me.tpTransport.Controls.Add(Me.PanelControl5)
        Me.tpTransport.Image = Global.SAM.My.Resources.Resources.transport3
        Me.tpTransport.Name = "tpTransport"
        Me.tpTransport.Size = New System.Drawing.Size(722, 518)
        Me.tpTransport.Text = "ค่าบริการ (ค่าขนส่ง ฯลฯ)"
        '
        'PanelControl4
        '
        Me.PanelControl4.Appearance.BackColor = System.Drawing.Color.LightSteelBlue
        Me.PanelControl4.Appearance.BackColor2 = System.Drawing.Color.CornflowerBlue
        Me.PanelControl4.Appearance.Options.UseBackColor = True
        Me.PanelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl4.Controls.Add(Me.Panel3)
        Me.PanelControl4.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl4.Location = New System.Drawing.Point(0, 56)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(722, 33)
        Me.PanelControl4.TabIndex = 740
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.lblCountTp)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(497, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(225, 33)
        Me.Panel3.TabIndex = 611
        '
        'lblCountTp
        '
        Me.lblCountTp.BackColor = System.Drawing.Color.Black
        Me.lblCountTp.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblCountTp.ForeColor = System.Drawing.Color.Lime
        Me.lblCountTp.Location = New System.Drawing.Point(60, 4)
        Me.lblCountTp.Name = "lblCountTp"
        Me.lblCountTp.Size = New System.Drawing.Size(100, 23)
        Me.lblCountTp.TabIndex = 610
        Me.lblCountTp.Text = "0"
        Me.lblCountTp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(166, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 17)
        Me.Label3.TabIndex = 596
        Me.Label3.Text = "รายการ"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(3, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 17)
        Me.Label5.TabIndex = 594
        Me.Label5.Text = "จำนวน"
        '
        'PanelControl5
        '
        Me.PanelControl5.Appearance.BackColor = System.Drawing.Color.Lavender
        Me.PanelControl5.Appearance.BackColor2 = System.Drawing.Color.LightSteelBlue
        Me.PanelControl5.Appearance.Options.UseBackColor = True
        Me.PanelControl5.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl5.Controls.Add(Me.Label6)
        Me.PanelControl5.Controls.Add(Me.txtSearch)
        Me.PanelControl5.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl5.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl5.Name = "PanelControl5"
        Me.PanelControl5.Size = New System.Drawing.Size(722, 56)
        Me.PanelControl5.TabIndex = 739
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(247, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "ค้นหา"
        '
        'txtSearch
        '
        Me.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtSearch.Location = New System.Drawing.Point(287, 18)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(202, 21)
        Me.txtSearch.TabIndex = 6
        '
        'ColPdCode
        '
        Me.ColPdCode.Caption = "PdCode"
        Me.ColPdCode.FieldName = "PdCode"
        Me.ColPdCode.Name = "ColPdCode"
        '
        'PdCode
        '
        Me.PdCode.Caption = "PdCode"
        Me.PdCode.FieldName = "PdCode"
        Me.PdCode.Name = "PdCode"
        '
        'frmInvLotSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 561)
        Me.Controls.Add(Me.GCSelected)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmInvLotSelect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "เลือกสินค้า"
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptSelectTransport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCSelected, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVSelected, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptDel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.PanelControl3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.tpInventory.ResumeLayout(False)
        CType(Me.GCProduct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVProduct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptSelect, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptWh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        Me.tpTransport.ResumeLayout(False)
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl5.ResumeLayout(False)
        Me.PanelControl5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GCSelected As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVSelected As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colNum As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLotNum As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInvName_ As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDelete As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rptDel As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents colidLot As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colidInvGroup As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colidInvMain_ As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colidSubType_ As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ButtonUp As System.Windows.Forms.Button
    Friend WithEvents ButtonDown As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tpTransport As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rptSelectTransport As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn18 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn19 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
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
    Friend WithEvents RepositoryItemLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lblCountTp As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PanelControl5 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents tpInventory As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents txtCount As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmbInvName As System.Windows.Forms.ComboBox
    Friend WithEvents txtInvName As System.Windows.Forms.TextBox
    Friend WithEvents txtLotNo As System.Windows.Forms.TextBox
    Friend WithEvents chkInvName As System.Windows.Forms.CheckBox
    Friend WithEvents chkLotNo As System.Windows.Forms.CheckBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GCProduct As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVProduct As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colLotNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rptSelect As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents colidLot_ As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colidInvGroup_ As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colidInvMain As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colidSubType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAmount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWarehouseName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colidWh As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colidUnit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInvGroup As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDtType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colidWh_ As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ChkInvGroup As System.Windows.Forms.CheckBox
    Friend WithEvents colInvGroupName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colidRefLot As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colidSaleOrderDt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CompRec As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColCompRec As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColInvName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColstCountStock As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColpWeight As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColidUnitW As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Weight As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents idUnitW As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WareHouseName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rptWh As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents ColPdCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PdCode As DevExpress.XtraGrid.Columns.GridColumn
End Class
