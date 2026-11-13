<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmBillSaleReturnData
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
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBillSaleReturnData))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.GVReturnDt = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColidSaleRTDt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColidSaleRT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColNewidSaleDt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDocRef_ = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColLotNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColInvName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColAmountRT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColUnit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColPrice_ = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColRTValue = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColPriceRT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColExp = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GVReturnMt = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColNum = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColCancel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rptCancel = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.ColEdit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rptEdit = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.ColDoc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rptDoc = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.ColPsCancel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColCancelNote = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColidSaleReturn_ = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCompCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDateRT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDocRef = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDocNum_ = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColCusName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColAp = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColPv = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColPsSale = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColTotal_ = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColRTCause = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColNote = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColPsTs = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDateTs = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColidRTDocCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidComp = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidRtAVxST = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColCompName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColidWaitReturn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColidCancel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnShowdata = New DevExpress.XtraEditors.SimpleButton()
        Me.btnExcel = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtTotalNet = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbRtAVxST = New System.Windows.Forms.CheckBox()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cbCancel = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdbDateTs = New System.Windows.Forms.RadioButton()
        Me.rdbDateSale = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dtpYear = New System.Windows.Forms.DateTimePicker()
        Me.dtpMonthE = New System.Windows.Forms.DateTimePicker()
        Me.dtpMonthS = New System.Windows.Forms.DateTimePicker()
        Me.dtpReturnE = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rdbYear = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.rdbMonth = New System.Windows.Forms.RadioButton()
        Me.rdbDate = New System.Windows.Forms.RadioButton()
        Me.dtpReturnS = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtDocCode = New System.Windows.Forms.TextBox()
        Me.chkDocCode = New System.Windows.Forms.CheckBox()
        Me.txtPsTsName = New System.Windows.Forms.TextBox()
        Me.chkPsTs = New System.Windows.Forms.CheckBox()
        Me.cmbGroupComp = New System.Windows.Forms.ComboBox()
        Me.chkComp = New System.Windows.Forms.CheckBox()
        Me.txtPsSale = New System.Windows.Forms.TextBox()
        Me.txtCusName = New System.Windows.Forms.TextBox()
        Me.ChkCus = New System.Windows.Forms.CheckBox()
        Me.ChkPsSale = New System.Windows.Forms.CheckBox()
        CType(Me.GVReturnDt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVReturnMt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GVReturnDt
        '
        Me.GVReturnDt.Appearance.HeaderPanel.BackColor = System.Drawing.Color.CornflowerBlue
        Me.GVReturnDt.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GVReturnDt.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVReturnDt.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVReturnDt.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVReturnDt.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVReturnDt.ColumnPanelRowHeight = 45
        Me.GVReturnDt.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColidSaleRTDt, Me.ColidSaleRT, Me.ColNewidSaleDt, Me.ColDocRef_, Me.ColLotNo, Me.ColInvName, Me.ColAmountRT, Me.ColUnit, Me.ColPrice_, Me.ColRTValue, Me.ColPriceRT, Me.ColExp})
        Me.GVReturnDt.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GVReturnDt.GridControl = Me.GridControl1
        Me.GVReturnDt.Name = "GVReturnDt"
        Me.GVReturnDt.OptionsView.ShowGroupPanel = False
        Me.GVReturnDt.OptionsView.ShowIndicator = False
        '
        'ColidSaleRTDt
        '
        Me.ColidSaleRTDt.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColidSaleRTDt.AppearanceCell.Options.UseFont = True
        Me.ColidSaleRTDt.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColidSaleRTDt.AppearanceHeader.Options.UseFont = True
        Me.ColidSaleRTDt.Caption = "idSaleReturnDt"
        Me.ColidSaleRTDt.FieldName = "idSaleReturnDt"
        Me.ColidSaleRTDt.Name = "ColidSaleRTDt"
        '
        'ColidSaleRT
        '
        Me.ColidSaleRT.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColidSaleRT.AppearanceCell.Options.UseFont = True
        Me.ColidSaleRT.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColidSaleRT.AppearanceHeader.Options.UseFont = True
        Me.ColidSaleRT.Caption = "idSaleReturn"
        Me.ColidSaleRT.FieldName = "idSaleReturn"
        Me.ColidSaleRT.Name = "ColidSaleRT"
        '
        'ColNewidSaleDt
        '
        Me.ColNewidSaleDt.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColNewidSaleDt.AppearanceCell.Options.UseFont = True
        Me.ColNewidSaleDt.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColNewidSaleDt.AppearanceHeader.Options.UseFont = True
        Me.ColNewidSaleDt.Caption = "NewidSaleDt"
        Me.ColNewidSaleDt.FieldName = "NewidSaleDt"
        Me.ColNewidSaleDt.Name = "ColNewidSaleDt"
        '
        'ColDocRef_
        '
        Me.ColDocRef_.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColDocRef_.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColDocRef_.AppearanceCell.Options.UseBackColor = True
        Me.ColDocRef_.AppearanceCell.Options.UseFont = True
        Me.ColDocRef_.AppearanceCell.Options.UseTextOptions = True
        Me.ColDocRef_.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDocRef_.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColDocRef_.AppearanceHeader.Options.UseFont = True
        Me.ColDocRef_.Caption = "เลขที่บิลขาย"
        Me.ColDocRef_.FieldName = "DocRef"
        Me.ColDocRef_.Name = "ColDocRef_"
        Me.ColDocRef_.OptionsColumn.AllowEdit = False
        Me.ColDocRef_.OptionsColumn.ReadOnly = True
        Me.ColDocRef_.Visible = True
        Me.ColDocRef_.VisibleIndex = 2
        Me.ColDocRef_.Width = 169
        '
        'ColLotNo
        '
        Me.ColLotNo.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColLotNo.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColLotNo.AppearanceCell.Options.UseBackColor = True
        Me.ColLotNo.AppearanceCell.Options.UseFont = True
        Me.ColLotNo.AppearanceCell.Options.UseTextOptions = True
        Me.ColLotNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColLotNo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColLotNo.AppearanceHeader.Options.UseFont = True
        Me.ColLotNo.Caption = "Lot No."
        Me.ColLotNo.FieldName = "LotNoRT"
        Me.ColLotNo.Name = "ColLotNo"
        Me.ColLotNo.OptionsColumn.AllowEdit = False
        Me.ColLotNo.OptionsColumn.ReadOnly = True
        Me.ColLotNo.Visible = True
        Me.ColLotNo.VisibleIndex = 0
        Me.ColLotNo.Width = 129
        '
        'ColInvName
        '
        Me.ColInvName.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ColInvName.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColInvName.AppearanceCell.Options.UseBackColor = True
        Me.ColInvName.AppearanceCell.Options.UseFont = True
        Me.ColInvName.AppearanceCell.Options.UseTextOptions = True
        Me.ColInvName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.ColInvName.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColInvName.AppearanceHeader.Options.UseFont = True
        Me.ColInvName.Caption = "รายการสินค้า"
        Me.ColInvName.FieldName = "InvName"
        Me.ColInvName.Name = "ColInvName"
        Me.ColInvName.OptionsColumn.AllowEdit = False
        Me.ColInvName.OptionsColumn.ReadOnly = True
        Me.ColInvName.Visible = True
        Me.ColInvName.VisibleIndex = 1
        Me.ColInvName.Width = 524
        '
        'ColAmountRT
        '
        Me.ColAmountRT.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColAmountRT.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColAmountRT.AppearanceCell.Options.UseBackColor = True
        Me.ColAmountRT.AppearanceCell.Options.UseFont = True
        Me.ColAmountRT.AppearanceCell.Options.UseTextOptions = True
        Me.ColAmountRT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ColAmountRT.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColAmountRT.AppearanceHeader.Options.UseFont = True
        Me.ColAmountRT.Caption = "จำนวนคืน"
        Me.ColAmountRT.DisplayFormat.FormatString = "#,##0.00##"
        Me.ColAmountRT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColAmountRT.FieldName = "AmountReturn"
        Me.ColAmountRT.Name = "ColAmountRT"
        Me.ColAmountRT.OptionsColumn.AllowFocus = False
        Me.ColAmountRT.OptionsColumn.ReadOnly = True
        Me.ColAmountRT.Visible = True
        Me.ColAmountRT.VisibleIndex = 3
        Me.ColAmountRT.Width = 103
        '
        'ColUnit
        '
        Me.ColUnit.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColUnit.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColUnit.AppearanceCell.Options.UseBackColor = True
        Me.ColUnit.AppearanceCell.Options.UseFont = True
        Me.ColUnit.AppearanceCell.Options.UseTextOptions = True
        Me.ColUnit.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColUnit.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColUnit.AppearanceHeader.Options.UseFont = True
        Me.ColUnit.Caption = "หน่วย"
        Me.ColUnit.FieldName = "UnitName"
        Me.ColUnit.Name = "ColUnit"
        Me.ColUnit.OptionsColumn.AllowEdit = False
        Me.ColUnit.OptionsColumn.ReadOnly = True
        Me.ColUnit.Visible = True
        Me.ColUnit.VisibleIndex = 4
        Me.ColUnit.Width = 86
        '
        'ColPrice_
        '
        Me.ColPrice_.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColPrice_.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColPrice_.AppearanceCell.Options.UseBackColor = True
        Me.ColPrice_.AppearanceCell.Options.UseFont = True
        Me.ColPrice_.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColPrice_.AppearanceHeader.Options.UseFont = True
        Me.ColPrice_.Caption = "ราคาปกติ"
        Me.ColPrice_.DisplayFormat.FormatString = "#,##0.00##"
        Me.ColPrice_.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColPrice_.FieldName = "Price"
        Me.ColPrice_.Name = "ColPrice_"
        Me.ColPrice_.OptionsColumn.AllowEdit = False
        Me.ColPrice_.OptionsColumn.ReadOnly = True
        '
        'ColRTValue
        '
        Me.ColRTValue.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColRTValue.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColRTValue.AppearanceCell.Options.UseBackColor = True
        Me.ColRTValue.AppearanceCell.Options.UseFont = True
        Me.ColRTValue.AppearanceCell.Options.UseTextOptions = True
        Me.ColRTValue.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ColRTValue.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColRTValue.AppearanceHeader.Options.UseFont = True
        Me.ColRTValue.AppearanceHeader.Options.UseTextOptions = True
        Me.ColRTValue.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColRTValue.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColRTValue.Caption = "% มูลค่าคืน"
        Me.ColRTValue.DisplayFormat.FormatString = "N2"
        Me.ColRTValue.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColRTValue.FieldName = "RTValuePerc"
        Me.ColRTValue.Name = "ColRTValue"
        Me.ColRTValue.OptionsColumn.AllowEdit = False
        Me.ColRTValue.OptionsColumn.ReadOnly = True
        Me.ColRTValue.Visible = True
        Me.ColRTValue.VisibleIndex = 5
        Me.ColRTValue.Width = 93
        '
        'ColPriceRT
        '
        Me.ColPriceRT.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColPriceRT.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColPriceRT.AppearanceCell.Options.UseBackColor = True
        Me.ColPriceRT.AppearanceCell.Options.UseFont = True
        Me.ColPriceRT.AppearanceCell.Options.UseTextOptions = True
        Me.ColPriceRT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ColPriceRT.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColPriceRT.AppearanceHeader.Options.UseFont = True
        Me.ColPriceRT.Caption = "ราคาคืน"
        Me.ColPriceRT.DisplayFormat.FormatString = "#,##0.00"
        Me.ColPriceRT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColPriceRT.FieldName = "RTPrice"
        Me.ColPriceRT.Name = "ColPriceRT"
        Me.ColPriceRT.OptionsColumn.AllowEdit = False
        Me.ColPriceRT.OptionsColumn.ReadOnly = True
        Me.ColPriceRT.Visible = True
        Me.ColPriceRT.VisibleIndex = 6
        Me.ColPriceRT.Width = 90
        '
        'ColExp
        '
        Me.ColExp.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColExp.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColExp.AppearanceCell.Options.UseBackColor = True
        Me.ColExp.AppearanceCell.Options.UseFont = True
        Me.ColExp.AppearanceCell.Options.UseTextOptions = True
        Me.ColExp.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ColExp.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColExp.AppearanceHeader.Options.UseFont = True
        Me.ColExp.Caption = "รวมเป็นเงิน"
        Me.ColExp.DisplayFormat.FormatString = "#,##0.00"
        Me.ColExp.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColExp.FieldName = "Exp"
        Me.ColExp.Name = "ColExp"
        Me.ColExp.OptionsColumn.AllowEdit = False
        Me.ColExp.OptionsColumn.ReadOnly = True
        Me.ColExp.Visible = True
        Me.ColExp.VisibleIndex = 7
        Me.ColExp.Width = 134
        '
        'GridControl1
        '
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode1.LevelTemplate = Me.GVReturnDt
        GridLevelNode1.RelationName = "Level1"
        Me.GridControl1.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.GridControl1.Location = New System.Drawing.Point(0, 202)
        Me.GridControl1.MainView = Me.GVReturnMt
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rptEdit, Me.rptDoc, Me.rptCancel})
        Me.GridControl1.Size = New System.Drawing.Size(1184, 349)
        Me.GridControl1.TabIndex = 4
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVReturnMt, Me.GVReturnDt})
        '
        'GVReturnMt
        '
        Me.GVReturnMt.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVReturnMt.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVReturnMt.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GVReturnMt.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVReturnMt.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GVReturnMt.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GVReturnMt.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GVReturnMt.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GVReturnMt.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GVReturnMt.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVReturnMt.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GVReturnMt.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GVReturnMt.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVReturnMt.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.GVReturnMt.Appearance.Empty.Options.UseBackColor = True
        Me.GVReturnMt.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.GVReturnMt.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.GVReturnMt.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GVReturnMt.Appearance.EvenRow.Options.UseBackColor = True
        Me.GVReturnMt.Appearance.EvenRow.Options.UseBorderColor = True
        Me.GVReturnMt.Appearance.EvenRow.Options.UseForeColor = True
        Me.GVReturnMt.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVReturnMt.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVReturnMt.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GVReturnMt.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GVReturnMt.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GVReturnMt.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GVReturnMt.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVReturnMt.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.GVReturnMt.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVReturnMt.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVReturnMt.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GVReturnMt.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.GVReturnMt.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVReturnMt.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.GVReturnMt.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GVReturnMt.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVReturnMt.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVReturnMt.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.GVReturnMt.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.GVReturnMt.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVReturnMt.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVReturnMt.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVReturnMt.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVReturnMt.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVReturnMt.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVReturnMt.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVReturnMt.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GVReturnMt.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.GVReturnMt.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.GVReturnMt.Appearance.GroupButton.Options.UseBackColor = True
        Me.GVReturnMt.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GVReturnMt.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GVReturnMt.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GVReturnMt.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GVReturnMt.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVReturnMt.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GVReturnMt.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GVReturnMt.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVReturnMt.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.GVReturnMt.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.GVReturnMt.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GVReturnMt.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVReturnMt.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GVReturnMt.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GVReturnMt.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GVReturnMt.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVReturnMt.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GVReturnMt.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVReturnMt.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GVReturnMt.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GVReturnMt.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GVReturnMt.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVReturnMt.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVReturnMt.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GVReturnMt.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.GVReturnMt.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.GVReturnMt.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVReturnMt.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVReturnMt.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.GVReturnMt.Appearance.HorzLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.GVReturnMt.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVReturnMt.Appearance.HorzLine.Options.UseBorderColor = True
        Me.GVReturnMt.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVReturnMt.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVReturnMt.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GVReturnMt.Appearance.OddRow.Options.UseBackColor = True
        Me.GVReturnMt.Appearance.OddRow.Options.UseBorderColor = True
        Me.GVReturnMt.Appearance.OddRow.Options.UseForeColor = True
        Me.GVReturnMt.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.GVReturnMt.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.GVReturnMt.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.GVReturnMt.Appearance.Preview.Options.UseBackColor = True
        Me.GVReturnMt.Appearance.Preview.Options.UseFont = True
        Me.GVReturnMt.Appearance.Preview.Options.UseForeColor = True
        Me.GVReturnMt.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVReturnMt.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GVReturnMt.Appearance.Row.Options.UseBackColor = True
        Me.GVReturnMt.Appearance.Row.Options.UseForeColor = True
        Me.GVReturnMt.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVReturnMt.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.GVReturnMt.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GVReturnMt.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.GVReturnMt.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.GVReturnMt.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVReturnMt.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GVReturnMt.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GVReturnMt.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GVReturnMt.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.GVReturnMt.Appearance.VertLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.GVReturnMt.Appearance.VertLine.Options.UseBackColor = True
        Me.GVReturnMt.Appearance.VertLine.Options.UseBorderColor = True
        Me.GVReturnMt.ColumnPanelRowHeight = 45
        Me.GVReturnMt.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColNum, Me.ColCancel, Me.ColEdit, Me.ColDoc, Me.ColPsCancel, Me.ColCancelNote, Me.ColidSaleReturn_, Me.colCompCode, Me.ColDateRT, Me.ColDocRef, Me.ColDocNum_, Me.ColCusName, Me.ColAp, Me.ColPv, Me.ColPsSale, Me.ColTotal_, Me.ColRTCause, Me.ColNote, Me.ColPsTs, Me.ColDateTs, Me.ColidRTDocCode, Me.colidComp, Me.colidRtAVxST, Me.ColCompName, Me.ColidWaitReturn, Me.ColidCancel})
        Me.GVReturnMt.GridControl = Me.GridControl1
        Me.GVReturnMt.Name = "GVReturnMt"
        Me.GVReturnMt.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDown
        Me.GVReturnMt.OptionsDetail.AllowOnlyOneMasterRowExpanded = True
        Me.GVReturnMt.OptionsSelection.MultiSelect = True
        Me.GVReturnMt.OptionsView.EnableAppearanceEvenRow = True
        Me.GVReturnMt.OptionsView.EnableAppearanceOddRow = True
        Me.GVReturnMt.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GVReturnMt.OptionsView.ShowGroupPanel = False
        Me.GVReturnMt.OptionsView.ShowIndicator = False
        Me.GVReturnMt.PaintStyleName = "MixedXP"
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
        'ColCancel
        '
        Me.ColCancel.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColCancel.AppearanceHeader.Options.UseFont = True
        Me.ColCancel.AppearanceHeader.Options.UseTextOptions = True
        Me.ColCancel.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColCancel.Caption = "ยกเลิก"
        Me.ColCancel.ColumnEdit = Me.rptCancel
        Me.ColCancel.MaxWidth = 45
        Me.ColCancel.MinWidth = 45
        Me.ColCancel.Name = "ColCancel"
        Me.ColCancel.Visible = True
        Me.ColCancel.VisibleIndex = 1
        Me.ColCancel.Width = 45
        '
        'rptCancel
        '
        Me.rptCancel.AutoHeight = False
        Me.rptCancel.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("rptCancel.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.rptCancel.Name = "rptCancel"
        Me.rptCancel.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'ColEdit
        '
        Me.ColEdit.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColEdit.AppearanceCell.Options.UseFont = True
        Me.ColEdit.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColEdit.AppearanceHeader.Options.UseFont = True
        Me.ColEdit.AppearanceHeader.Options.UseTextOptions = True
        Me.ColEdit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColEdit.Caption = "แก้ไข"
        Me.ColEdit.ColumnEdit = Me.rptEdit
        Me.ColEdit.MaxWidth = 40
        Me.ColEdit.MinWidth = 40
        Me.ColEdit.Name = "ColEdit"
        Me.ColEdit.Visible = True
        Me.ColEdit.VisibleIndex = 2
        Me.ColEdit.Width = 40
        '
        'rptEdit
        '
        Me.rptEdit.AutoHeight = False
        Me.rptEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Global.SAM.My.Resources.Resources.Computer_Edit, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject2, "", Nothing, Nothing, True)})
        Me.rptEdit.Name = "rptEdit"
        Me.rptEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'ColDoc
        '
        Me.ColDoc.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColDoc.AppearanceCell.Options.UseFont = True
        Me.ColDoc.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColDoc.AppearanceHeader.Options.UseFont = True
        Me.ColDoc.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDoc.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDoc.Caption = "เอกสาร"
        Me.ColDoc.ColumnEdit = Me.rptDoc
        Me.ColDoc.MaxWidth = 50
        Me.ColDoc.MinWidth = 50
        Me.ColDoc.Name = "ColDoc"
        Me.ColDoc.Visible = True
        Me.ColDoc.VisibleIndex = 3
        Me.ColDoc.Width = 50
        '
        'rptDoc
        '
        Me.rptDoc.AutoHeight = False
        Me.rptDoc.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Global.SAM.My.Resources.Resources.document_print, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject3, "", Nothing, Nothing, True)})
        Me.rptDoc.Name = "rptDoc"
        Me.rptDoc.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
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
        'ColidSaleReturn_
        '
        Me.ColidSaleReturn_.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColidSaleReturn_.AppearanceCell.Options.UseFont = True
        Me.ColidSaleReturn_.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColidSaleReturn_.AppearanceHeader.Options.UseFont = True
        Me.ColidSaleReturn_.AppearanceHeader.Options.UseTextOptions = True
        Me.ColidSaleReturn_.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColidSaleReturn_.Caption = "idSaleReturn"
        Me.ColidSaleReturn_.FieldName = "idSaleReturn"
        Me.ColidSaleReturn_.Name = "ColidSaleReturn_"
        '
        'colCompCode
        '
        Me.colCompCode.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.colCompCode.AppearanceCell.Options.UseFont = True
        Me.colCompCode.AppearanceCell.Options.UseTextOptions = True
        Me.colCompCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCompCode.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.colCompCode.AppearanceHeader.Options.UseFont = True
        Me.colCompCode.AppearanceHeader.Options.UseTextOptions = True
        Me.colCompCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCompCode.Caption = "บริษัท"
        Me.colCompCode.FieldName = "CompCode"
        Me.colCompCode.MaxWidth = 45
        Me.colCompCode.MinWidth = 45
        Me.colCompCode.Name = "colCompCode"
        Me.colCompCode.OptionsColumn.AllowEdit = False
        Me.colCompCode.OptionsColumn.ReadOnly = True
        Me.colCompCode.OptionsColumn.TabStop = False
        Me.colCompCode.Visible = True
        Me.colCompCode.VisibleIndex = 4
        Me.colCompCode.Width = 45
        '
        'ColDateRT
        '
        Me.ColDateRT.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColDateRT.AppearanceCell.Options.UseFont = True
        Me.ColDateRT.AppearanceCell.Options.UseTextOptions = True
        Me.ColDateRT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDateRT.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColDateRT.AppearanceHeader.Options.UseFont = True
        Me.ColDateRT.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDateRT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDateRT.Caption = "วันที่คืน"
        Me.ColDateRT.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.ColDateRT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.ColDateRT.FieldName = "DateReturn"
        Me.ColDateRT.MaxWidth = 80
        Me.ColDateRT.MinWidth = 80
        Me.ColDateRT.Name = "ColDateRT"
        Me.ColDateRT.OptionsColumn.AllowEdit = False
        Me.ColDateRT.OptionsColumn.ReadOnly = True
        Me.ColDateRT.OptionsColumn.TabStop = False
        Me.ColDateRT.Visible = True
        Me.ColDateRT.VisibleIndex = 5
        Me.ColDateRT.Width = 80
        '
        'ColDocRef
        '
        Me.ColDocRef.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColDocRef.AppearanceCell.Options.UseFont = True
        Me.ColDocRef.AppearanceCell.Options.UseTextOptions = True
        Me.ColDocRef.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDocRef.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColDocRef.AppearanceHeader.Options.UseFont = True
        Me.ColDocRef.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDocRef.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDocRef.Caption = "เลขที่อ้างอิง"
        Me.ColDocRef.FieldName = "DocRef"
        Me.ColDocRef.MaxWidth = 100
        Me.ColDocRef.MinWidth = 100
        Me.ColDocRef.Name = "ColDocRef"
        Me.ColDocRef.OptionsColumn.AllowEdit = False
        Me.ColDocRef.OptionsColumn.ReadOnly = True
        Me.ColDocRef.OptionsColumn.TabStop = False
        Me.ColDocRef.Visible = True
        Me.ColDocRef.VisibleIndex = 6
        Me.ColDocRef.Width = 100
        '
        'ColDocNum_
        '
        Me.ColDocNum_.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColDocNum_.AppearanceCell.Options.UseFont = True
        Me.ColDocNum_.AppearanceCell.Options.UseTextOptions = True
        Me.ColDocNum_.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDocNum_.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColDocNum_.AppearanceHeader.Options.UseFont = True
        Me.ColDocNum_.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDocNum_.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDocNum_.Caption = "เลขที่รายการ"
        Me.ColDocNum_.FieldName = "DocNum"
        Me.ColDocNum_.MaxWidth = 80
        Me.ColDocNum_.MinWidth = 80
        Me.ColDocNum_.Name = "ColDocNum_"
        Me.ColDocNum_.OptionsColumn.AllowEdit = False
        Me.ColDocNum_.OptionsColumn.ReadOnly = True
        Me.ColDocNum_.OptionsColumn.TabStop = False
        Me.ColDocNum_.Visible = True
        Me.ColDocNum_.VisibleIndex = 7
        Me.ColDocNum_.Width = 80
        '
        'ColCusName
        '
        Me.ColCusName.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ColCusName.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColCusName.AppearanceCell.Options.UseBackColor = True
        Me.ColCusName.AppearanceCell.Options.UseFont = True
        Me.ColCusName.AppearanceCell.Options.UseTextOptions = True
        Me.ColCusName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.ColCusName.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColCusName.AppearanceHeader.Options.UseFont = True
        Me.ColCusName.AppearanceHeader.Options.UseTextOptions = True
        Me.ColCusName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColCusName.Caption = "ชื่อลูกค้า"
        Me.ColCusName.FieldName = "PartnerName"
        Me.ColCusName.MinWidth = 200
        Me.ColCusName.Name = "ColCusName"
        Me.ColCusName.OptionsColumn.AllowEdit = False
        Me.ColCusName.OptionsColumn.ReadOnly = True
        Me.ColCusName.OptionsColumn.TabStop = False
        Me.ColCusName.Visible = True
        Me.ColCusName.VisibleIndex = 8
        Me.ColCusName.Width = 200
        '
        'ColAp
        '
        Me.ColAp.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColAp.AppearanceCell.Options.UseFont = True
        Me.ColAp.AppearanceCell.Options.UseTextOptions = True
        Me.ColAp.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColAp.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColAp.AppearanceHeader.Options.UseFont = True
        Me.ColAp.AppearanceHeader.Options.UseTextOptions = True
        Me.ColAp.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColAp.Caption = "อำเภอ"
        Me.ColAp.FieldName = "ApName"
        Me.ColAp.MaxWidth = 90
        Me.ColAp.MinWidth = 90
        Me.ColAp.Name = "ColAp"
        Me.ColAp.OptionsColumn.AllowEdit = False
        Me.ColAp.OptionsColumn.ReadOnly = True
        Me.ColAp.OptionsColumn.TabStop = False
        Me.ColAp.Visible = True
        Me.ColAp.VisibleIndex = 9
        Me.ColAp.Width = 90
        '
        'ColPv
        '
        Me.ColPv.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColPv.AppearanceCell.Options.UseFont = True
        Me.ColPv.AppearanceCell.Options.UseTextOptions = True
        Me.ColPv.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColPv.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColPv.AppearanceHeader.Options.UseFont = True
        Me.ColPv.AppearanceHeader.Options.UseTextOptions = True
        Me.ColPv.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColPv.Caption = "จังหวัด"
        Me.ColPv.FieldName = "ProvinceName"
        Me.ColPv.MaxWidth = 90
        Me.ColPv.MinWidth = 90
        Me.ColPv.Name = "ColPv"
        Me.ColPv.OptionsColumn.AllowEdit = False
        Me.ColPv.OptionsColumn.ReadOnly = True
        Me.ColPv.OptionsColumn.TabStop = False
        Me.ColPv.Visible = True
        Me.ColPv.VisibleIndex = 10
        Me.ColPv.Width = 90
        '
        'ColPsSale
        '
        Me.ColPsSale.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColPsSale.AppearanceCell.Options.UseFont = True
        Me.ColPsSale.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColPsSale.AppearanceHeader.Options.UseFont = True
        Me.ColPsSale.AppearanceHeader.Options.UseTextOptions = True
        Me.ColPsSale.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColPsSale.Caption = "เจ้าหน้าที่ขาย"
        Me.ColPsSale.FieldName = "PsSale"
        Me.ColPsSale.MaxWidth = 100
        Me.ColPsSale.MinWidth = 100
        Me.ColPsSale.Name = "ColPsSale"
        Me.ColPsSale.OptionsColumn.AllowEdit = False
        Me.ColPsSale.OptionsColumn.ReadOnly = True
        Me.ColPsSale.OptionsColumn.TabStop = False
        Me.ColPsSale.Visible = True
        Me.ColPsSale.VisibleIndex = 11
        Me.ColPsSale.Width = 100
        '
        'ColTotal_
        '
        Me.ColTotal_.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColTotal_.AppearanceCell.Options.UseFont = True
        Me.ColTotal_.AppearanceCell.Options.UseTextOptions = True
        Me.ColTotal_.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ColTotal_.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColTotal_.AppearanceHeader.Options.UseFont = True
        Me.ColTotal_.AppearanceHeader.Options.UseTextOptions = True
        Me.ColTotal_.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColTotal_.Caption = "รวมเป็นเงิน"
        Me.ColTotal_.DisplayFormat.FormatString = "#,##0.00##"
        Me.ColTotal_.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColTotal_.FieldName = "Total"
        Me.ColTotal_.MaxWidth = 90
        Me.ColTotal_.MinWidth = 90
        Me.ColTotal_.Name = "ColTotal_"
        Me.ColTotal_.OptionsColumn.AllowEdit = False
        Me.ColTotal_.OptionsColumn.ReadOnly = True
        Me.ColTotal_.OptionsColumn.TabStop = False
        Me.ColTotal_.Visible = True
        Me.ColTotal_.VisibleIndex = 13
        Me.ColTotal_.Width = 90
        '
        'ColRTCause
        '
        Me.ColRTCause.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColRTCause.AppearanceCell.Options.UseFont = True
        Me.ColRTCause.AppearanceCell.Options.UseTextOptions = True
        Me.ColRTCause.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.ColRTCause.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColRTCause.AppearanceHeader.Options.UseFont = True
        Me.ColRTCause.AppearanceHeader.Options.UseTextOptions = True
        Me.ColRTCause.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColRTCause.Caption = "สาเหตุการรับคืน"
        Me.ColRTCause.FieldName = "ReturnCause"
        Me.ColRTCause.MinWidth = 100
        Me.ColRTCause.Name = "ColRTCause"
        Me.ColRTCause.OptionsColumn.AllowEdit = False
        Me.ColRTCause.OptionsColumn.ReadOnly = True
        Me.ColRTCause.OptionsColumn.TabStop = False
        Me.ColRTCause.Width = 172
        '
        'ColNote
        '
        Me.ColNote.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColNote.AppearanceCell.Options.UseFont = True
        Me.ColNote.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColNote.AppearanceHeader.Options.UseFont = True
        Me.ColNote.AppearanceHeader.Options.UseTextOptions = True
        Me.ColNote.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColNote.Caption = "หมายเหตุ"
        Me.ColNote.FieldName = "Note"
        Me.ColNote.MinWidth = 70
        Me.ColNote.Name = "ColNote"
        Me.ColNote.OptionsColumn.AllowEdit = False
        Me.ColNote.OptionsColumn.ReadOnly = True
        Me.ColNote.OptionsColumn.TabStop = False
        Me.ColNote.Visible = True
        Me.ColNote.VisibleIndex = 14
        '
        'ColPsTs
        '
        Me.ColPsTs.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColPsTs.AppearanceCell.Options.UseFont = True
        Me.ColPsTs.AppearanceCell.Options.UseTextOptions = True
        Me.ColPsTs.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColPsTs.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColPsTs.AppearanceHeader.Options.UseFont = True
        Me.ColPsTs.AppearanceHeader.Options.UseTextOptions = True
        Me.ColPsTs.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColPsTs.Caption = "ผู้ทำรายการ"
        Me.ColPsTs.FieldName = "PsTsName"
        Me.ColPsTs.MaxWidth = 100
        Me.ColPsTs.MinWidth = 100
        Me.ColPsTs.Name = "ColPsTs"
        Me.ColPsTs.OptionsColumn.AllowEdit = False
        Me.ColPsTs.OptionsColumn.ReadOnly = True
        Me.ColPsTs.OptionsColumn.TabStop = False
        Me.ColPsTs.Visible = True
        Me.ColPsTs.VisibleIndex = 12
        Me.ColPsTs.Width = 100
        '
        'ColDateTs
        '
        Me.ColDateTs.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColDateTs.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColDateTs.AppearanceCell.Options.UseBackColor = True
        Me.ColDateTs.AppearanceCell.Options.UseFont = True
        Me.ColDateTs.AppearanceCell.Options.UseTextOptions = True
        Me.ColDateTs.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDateTs.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColDateTs.AppearanceHeader.Options.UseFont = True
        Me.ColDateTs.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDateTs.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDateTs.Caption = "วันที่ทำรายการ"
        Me.ColDateTs.FieldName = "DateTs"
        Me.ColDateTs.Name = "ColDateTs"
        Me.ColDateTs.OptionsColumn.AllowEdit = False
        Me.ColDateTs.OptionsColumn.ReadOnly = True
        Me.ColDateTs.Width = 94
        '
        'ColidRTDocCode
        '
        Me.ColidRTDocCode.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColidRTDocCode.AppearanceCell.Options.UseFont = True
        Me.ColidRTDocCode.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColidRTDocCode.AppearanceHeader.Options.UseFont = True
        Me.ColidRTDocCode.AppearanceHeader.Options.UseTextOptions = True
        Me.ColidRTDocCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColidRTDocCode.Caption = "idRTDocCode"
        Me.ColidRTDocCode.FieldName = "idRTDocCode"
        Me.ColidRTDocCode.Name = "ColidRTDocCode"
        '
        'colidComp
        '
        Me.colidComp.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.colidComp.AppearanceCell.Options.UseFont = True
        Me.colidComp.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.colidComp.AppearanceHeader.Options.UseFont = True
        Me.colidComp.AppearanceHeader.Options.UseTextOptions = True
        Me.colidComp.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colidComp.Caption = "idComp"
        Me.colidComp.FieldName = "idComp"
        Me.colidComp.Name = "colidComp"
        '
        'colidRtAVxST
        '
        Me.colidRtAVxST.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.colidRtAVxST.AppearanceCell.Options.UseFont = True
        Me.colidRtAVxST.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.colidRtAVxST.AppearanceHeader.Options.UseFont = True
        Me.colidRtAVxST.AppearanceHeader.Options.UseTextOptions = True
        Me.colidRtAVxST.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colidRtAVxST.Caption = "idRtAVxST"
        Me.colidRtAVxST.FieldName = "idRtAVxST"
        Me.colidRtAVxST.Name = "colidRtAVxST"
        '
        'ColCompName
        '
        Me.ColCompName.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColCompName.AppearanceCell.Options.UseFont = True
        Me.ColCompName.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColCompName.AppearanceHeader.Options.UseFont = True
        Me.ColCompName.AppearanceHeader.Options.UseTextOptions = True
        Me.ColCompName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColCompName.Caption = "CompName"
        Me.ColCompName.FieldName = "CompName"
        Me.ColCompName.Name = "ColCompName"
        '
        'ColidWaitReturn
        '
        Me.ColidWaitReturn.Caption = "idWaitReturn"
        Me.ColidWaitReturn.FieldName = "idWaitReturn"
        Me.ColidWaitReturn.Name = "ColidWaitReturn"
        '
        'ColidCancel
        '
        Me.ColidCancel.Caption = "idCancel"
        Me.ColidCancel.FieldName = "idPsCancel"
        Me.ColidCancel.Name = "ColidCancel"
        '
        'PanelControl2
        '
        Me.PanelControl2.Appearance.BackColor = System.Drawing.Color.LightSteelBlue
        Me.PanelControl2.Appearance.BackColor2 = System.Drawing.Color.CornflowerBlue
        Me.PanelControl2.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.PanelControl2.Appearance.Options.UseBackColor = True
        Me.PanelControl2.Appearance.Options.UseFont = True
        Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl2.Controls.Add(Me.Panel1)
        Me.PanelControl2.Controls.Add(Me.Panel3)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl2.Location = New System.Drawing.Point(0, 167)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(1184, 35)
        Me.PanelControl2.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.btnShowdata)
        Me.Panel1.Controls.Add(Me.btnExcel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(237, 35)
        Me.Panel1.TabIndex = 973
        '
        'btnShowdata
        '
        Me.btnShowdata.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowdata.Appearance.Options.UseFont = True
        Me.btnShowdata.Image = CType(resources.GetObject("btnShowdata.Image"), System.Drawing.Image)
        Me.btnShowdata.Location = New System.Drawing.Point(3, 2)
        Me.btnShowdata.Name = "btnShowdata"
        Me.btnShowdata.Size = New System.Drawing.Size(105, 31)
        Me.btnShowdata.TabIndex = 584
        Me.btnShowdata.Text = "Refresh"
        '
        'btnExcel
        '
        Me.btnExcel.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExcel.Appearance.Options.UseFont = True
        Me.btnExcel.Image = CType(resources.GetObject("btnExcel.Image"), System.Drawing.Image)
        Me.btnExcel.Location = New System.Drawing.Point(110, 2)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(123, 31)
        Me.btnExcel.TabIndex = 971
        Me.btnExcel.Text = "Export Excel"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.txtTotalNet)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(924, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(260, 35)
        Me.Panel3.TabIndex = 583
        '
        'txtTotalNet
        '
        Me.txtTotalNet.BackColor = System.Drawing.Color.Black
        Me.txtTotalNet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalNet.Font = New System.Drawing.Font("Tahoma", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTotalNet.ForeColor = System.Drawing.Color.Lime
        Me.txtTotalNet.Location = New System.Drawing.Point(82, 4)
        Me.txtTotalNet.Name = "txtTotalNet"
        Me.txtTotalNet.ReadOnly = True
        Me.txtTotalNet.Size = New System.Drawing.Size(174, 28)
        Me.txtTotalNet.TabIndex = 579
        Me.txtTotalNet.TabStop = False
        Me.txtTotalNet.Text = "0"
        Me.txtTotalNet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(4, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 16)
        Me.Label2.TabIndex = 142
        Me.Label2.Text = "รวมเป็นเงิน"
        '
        'cbRtAVxST
        '
        Me.cbRtAVxST.AutoSize = True
        Me.cbRtAVxST.BackColor = System.Drawing.Color.Transparent
        Me.cbRtAVxST.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbRtAVxST.ForeColor = System.Drawing.Color.Black
        Me.cbRtAVxST.Location = New System.Drawing.Point(219, 22)
        Me.cbRtAVxST.Name = "cbRtAVxST"
        Me.cbRtAVxST.Size = New System.Drawing.Size(220, 18)
        Me.cbRtAVxST.TabIndex = 972
        Me.cbRtAVxST.Text = "แสดงเฉพาะรายการรับคืนระหว่าง AV-ST"
        Me.cbRtAVxST.UseVisualStyleBackColor = False
        '
        'PanelControl1
        '
        Me.PanelControl1.Appearance.BackColor = System.Drawing.Color.Lavender
        Me.PanelControl1.Appearance.BackColor2 = System.Drawing.Color.LightSteelBlue
        Me.PanelControl1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.PanelControl1.Appearance.Options.UseBackColor = True
        Me.PanelControl1.Appearance.Options.UseFont = True
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.GroupBox4)
        Me.PanelControl1.Controls.Add(Me.GroupBox1)
        Me.PanelControl1.Controls.Add(Me.GroupBox2)
        Me.PanelControl1.Controls.Add(Me.GroupBox3)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1184, 167)
        Me.PanelControl1.TabIndex = 2
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.cbCancel)
        Me.GroupBox4.Controls.Add(Me.cbRtAVxST)
        Me.GroupBox4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(428, 111)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(609, 50)
        Me.GroupBox4.TabIndex = 973
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "การกรองข้อมูล"
        '
        'cbCancel
        '
        Me.cbCancel.AutoSize = True
        Me.cbCancel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCancel.ForeColor = System.Drawing.Color.Black
        Me.cbCancel.Location = New System.Drawing.Point(12, 22)
        Me.cbCancel.Name = "cbCancel"
        Me.cbCancel.Size = New System.Drawing.Size(171, 18)
        Me.cbCancel.TabIndex = 775
        Me.cbCancel.Text = "แสดงรายการรับคืนที่ถูกยกเลิก"
        Me.cbCancel.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.rdbDateTs)
        Me.GroupBox1.Controls.Add(Me.rdbDateSale)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(410, 43)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ประเภทข้อมูลวันที่"
        '
        'rdbDateTs
        '
        Me.rdbDateTs.AutoSize = True
        Me.rdbDateTs.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.rdbDateTs.Location = New System.Drawing.Point(168, 17)
        Me.rdbDateTs.Name = "rdbDateTs"
        Me.rdbDateTs.Size = New System.Drawing.Size(98, 18)
        Me.rdbDateTs.TabIndex = 1
        Me.rdbDateTs.Text = "วันที่ทำรายการ"
        Me.rdbDateTs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdbDateTs.UseVisualStyleBackColor = True
        '
        'rdbDateSale
        '
        Me.rdbDateSale.AutoSize = True
        Me.rdbDateSale.Checked = True
        Me.rdbDateSale.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rdbDateSale.Location = New System.Drawing.Point(54, 18)
        Me.rdbDateSale.Name = "rdbDateSale"
        Me.rdbDateSale.Size = New System.Drawing.Size(88, 18)
        Me.rdbDateSale.TabIndex = 0
        Me.rdbDateSale.TabStop = True
        Me.rdbDateSale.Text = "วันที่คืนสินค้า"
        Me.rdbDateSale.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.dtpYear)
        Me.GroupBox2.Controls.Add(Me.dtpMonthE)
        Me.GroupBox2.Controls.Add(Me.dtpMonthS)
        Me.GroupBox2.Controls.Add(Me.dtpReturnE)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.rdbYear)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.rdbMonth)
        Me.GroupBox2.Controls.Add(Me.rdbDate)
        Me.GroupBox2.Controls.Add(Me.dtpReturnS)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 50)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(410, 111)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ช่วงวันที่"
        '
        'dtpYear
        '
        Me.dtpYear.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpYear.CausesValidation = False
        Me.dtpYear.CustomFormat = "yyyy"
        Me.dtpYear.Enabled = False
        Me.dtpYear.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dtpYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpYear.Location = New System.Drawing.Point(70, 82)
        Me.dtpYear.Name = "dtpYear"
        Me.dtpYear.ShowUpDown = True
        Me.dtpYear.Size = New System.Drawing.Size(63, 22)
        Me.dtpYear.TabIndex = 7
        Me.dtpYear.Value = New Date(2025, 11, 3, 8, 6, 0, 0)
        '
        'dtpMonthE
        '
        Me.dtpMonthE.Checked = False
        Me.dtpMonthE.CustomFormat = "MMMM /yyyy"
        Me.dtpMonthE.Enabled = False
        Me.dtpMonthE.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dtpMonthE.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpMonthE.Location = New System.Drawing.Point(247, 51)
        Me.dtpMonthE.Name = "dtpMonthE"
        Me.dtpMonthE.Size = New System.Drawing.Size(151, 22)
        Me.dtpMonthE.TabIndex = 5
        '
        'dtpMonthS
        '
        Me.dtpMonthS.Checked = False
        Me.dtpMonthS.CustomFormat = "MMMM /yyyy"
        Me.dtpMonthS.Enabled = False
        Me.dtpMonthS.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dtpMonthS.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpMonthS.Location = New System.Drawing.Point(70, 51)
        Me.dtpMonthS.Name = "dtpMonthS"
        Me.dtpMonthS.Size = New System.Drawing.Size(151, 22)
        Me.dtpMonthS.TabIndex = 4
        '
        'dtpReturnE
        '
        Me.dtpReturnE.CustomFormat = "dd MMMM yyyy"
        Me.dtpReturnE.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dtpReturnE.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpReturnE.Location = New System.Drawing.Point(247, 21)
        Me.dtpReturnE.MinDate = New Date(1757, 1, 1, 0, 0, 0, 0)
        Me.dtpReturnE.Name = "dtpReturnE"
        Me.dtpReturnE.Size = New System.Drawing.Size(151, 22)
        Me.dtpReturnE.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(223, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 14)
        Me.Label1.TabIndex = 624
        Me.Label1.Text = "ถึง"
        '
        'rdbYear
        '
        Me.rdbYear.AutoSize = True
        Me.rdbYear.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.rdbYear.Location = New System.Drawing.Point(18, 83)
        Me.rdbYear.Name = "rdbYear"
        Me.rdbYear.Size = New System.Drawing.Size(33, 18)
        Me.rdbYear.TabIndex = 6
        Me.rdbYear.Text = "ปี"
        Me.rdbYear.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label4.Location = New System.Drawing.Point(224, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(20, 14)
        Me.Label4.TabIndex = 605
        Me.Label4.Text = "ถึง"
        '
        'rdbMonth
        '
        Me.rdbMonth.AutoSize = True
        Me.rdbMonth.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.rdbMonth.Location = New System.Drawing.Point(18, 53)
        Me.rdbMonth.Name = "rdbMonth"
        Me.rdbMonth.Size = New System.Drawing.Size(50, 18)
        Me.rdbMonth.TabIndex = 3
        Me.rdbMonth.Text = "เดือน"
        Me.rdbMonth.UseVisualStyleBackColor = True
        '
        'rdbDate
        '
        Me.rdbDate.AutoSize = True
        Me.rdbDate.Checked = True
        Me.rdbDate.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.rdbDate.Location = New System.Drawing.Point(18, 24)
        Me.rdbDate.Name = "rdbDate"
        Me.rdbDate.Size = New System.Drawing.Size(47, 18)
        Me.rdbDate.TabIndex = 0
        Me.rdbDate.TabStop = True
        Me.rdbDate.Text = "วันที่"
        Me.rdbDate.UseVisualStyleBackColor = True
        '
        'dtpReturnS
        '
        Me.dtpReturnS.CustomFormat = "dd MMMM yyyy"
        Me.dtpReturnS.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dtpReturnS.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpReturnS.Location = New System.Drawing.Point(70, 22)
        Me.dtpReturnS.MinDate = New Date(1757, 1, 1, 0, 0, 0, 0)
        Me.dtpReturnS.Name = "dtpReturnS"
        Me.dtpReturnS.Size = New System.Drawing.Size(151, 22)
        Me.dtpReturnS.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.txtDocCode)
        Me.GroupBox3.Controls.Add(Me.chkDocCode)
        Me.GroupBox3.Controls.Add(Me.txtPsTsName)
        Me.GroupBox3.Controls.Add(Me.chkPsTs)
        Me.GroupBox3.Controls.Add(Me.cmbGroupComp)
        Me.GroupBox3.Controls.Add(Me.chkComp)
        Me.GroupBox3.Controls.Add(Me.txtPsSale)
        Me.GroupBox3.Controls.Add(Me.txtCusName)
        Me.GroupBox3.Controls.Add(Me.ChkCus)
        Me.GroupBox3.Controls.Add(Me.ChkPsSale)
        Me.GroupBox3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(428, 8)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(609, 97)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "ค้นหาข้อมูล"
        '
        'txtDocCode
        '
        Me.txtDocCode.Enabled = False
        Me.txtDocCode.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDocCode.Location = New System.Drawing.Point(104, 42)
        Me.txtDocCode.Name = "txtDocCode"
        Me.txtDocCode.Size = New System.Drawing.Size(189, 22)
        Me.txtDocCode.TabIndex = 774
        '
        'chkDocCode
        '
        Me.chkDocCode.AutoSize = True
        Me.chkDocCode.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDocCode.Location = New System.Drawing.Point(12, 44)
        Me.chkDocCode.Name = "chkDocCode"
        Me.chkDocCode.Size = New System.Drawing.Size(85, 18)
        Me.chkDocCode.TabIndex = 2
        Me.chkDocCode.Text = "เลขที่อ้างอิง"
        Me.chkDocCode.UseVisualStyleBackColor = True
        '
        'txtPsTsName
        '
        Me.txtPsTsName.Enabled = False
        Me.txtPsTsName.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPsTsName.Location = New System.Drawing.Point(407, 42)
        Me.txtPsTsName.Name = "txtPsTsName"
        Me.txtPsTsName.Size = New System.Drawing.Size(189, 22)
        Me.txtPsTsName.TabIndex = 772
        '
        'chkPsTs
        '
        Me.chkPsTs.AutoSize = True
        Me.chkPsTs.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPsTs.Location = New System.Drawing.Point(315, 44)
        Me.chkPsTs.Name = "chkPsTs"
        Me.chkPsTs.Size = New System.Drawing.Size(84, 18)
        Me.chkPsTs.TabIndex = 5
        Me.chkPsTs.Text = "ผู้ทำรายการ"
        Me.chkPsTs.UseVisualStyleBackColor = True
        '
        'cmbGroupComp
        '
        Me.cmbGroupComp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGroupComp.Enabled = False
        Me.cmbGroupComp.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbGroupComp.FormattingEnabled = True
        Me.cmbGroupComp.Location = New System.Drawing.Point(104, 16)
        Me.cmbGroupComp.Name = "cmbGroupComp"
        Me.cmbGroupComp.Size = New System.Drawing.Size(189, 22)
        Me.cmbGroupComp.TabIndex = 1
        '
        'chkComp
        '
        Me.chkComp.AutoSize = True
        Me.chkComp.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkComp.Location = New System.Drawing.Point(12, 20)
        Me.chkComp.Name = "chkComp"
        Me.chkComp.Size = New System.Drawing.Size(57, 18)
        Me.chkComp.TabIndex = 0
        Me.chkComp.Text = "บริษัท"
        Me.chkComp.UseVisualStyleBackColor = True
        '
        'txtPsSale
        '
        Me.txtPsSale.Enabled = False
        Me.txtPsSale.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPsSale.Location = New System.Drawing.Point(407, 16)
        Me.txtPsSale.Name = "txtPsSale"
        Me.txtPsSale.Size = New System.Drawing.Size(189, 22)
        Me.txtPsSale.TabIndex = 737
        '
        'txtCusName
        '
        Me.txtCusName.Enabled = False
        Me.txtCusName.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCusName.Location = New System.Drawing.Point(104, 69)
        Me.txtCusName.Name = "txtCusName"
        Me.txtCusName.Size = New System.Drawing.Size(189, 22)
        Me.txtCusName.TabIndex = 736
        '
        'ChkCus
        '
        Me.ChkCus.AutoSize = True
        Me.ChkCus.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkCus.Location = New System.Drawing.Point(12, 71)
        Me.ChkCus.Name = "ChkCus"
        Me.ChkCus.Size = New System.Drawing.Size(53, 18)
        Me.ChkCus.TabIndex = 3
        Me.ChkCus.Text = "ลูกค้า"
        Me.ChkCus.UseVisualStyleBackColor = True
        '
        'ChkPsSale
        '
        Me.ChkPsSale.AutoSize = True
        Me.ChkPsSale.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkPsSale.Location = New System.Drawing.Point(315, 19)
        Me.ChkPsSale.Name = "ChkPsSale"
        Me.ChkPsSale.Size = New System.Drawing.Size(93, 18)
        Me.ChkPsSale.TabIndex = 4
        Me.ChkPsSale.Text = "เจ้าหน้าที่ขาย"
        Me.ChkPsSale.UseVisualStyleBackColor = True
        '
        'FrmBillSaleReturnData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 551)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmBillSaleReturnData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ข้อมูลบิลรับคืนสินค้า"
        CType(Me.GVReturnDt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVReturnMt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptCancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptDoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtTotalNet As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdbDateTs As RadioButton
    Friend WithEvents rdbDateSale As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtDocCode As TextBox
    Friend WithEvents chkDocCode As CheckBox
    Friend WithEvents txtPsTsName As TextBox
    Friend WithEvents chkPsTs As CheckBox
    Friend WithEvents cmbGroupComp As ComboBox
    Friend WithEvents chkComp As CheckBox
    Friend WithEvents txtPsSale As TextBox
    Friend WithEvents txtCusName As TextBox
    Friend WithEvents ChkCus As CheckBox
    Friend WithEvents ChkPsSale As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dtpYear As DateTimePicker
    Friend WithEvents dtpMonthE As DateTimePicker
    Friend WithEvents dtpMonthS As DateTimePicker
    Friend WithEvents dtpReturnE As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents rdbYear As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents rdbMonth As RadioButton
    Friend WithEvents rdbDate As RadioButton
    Friend WithEvents dtpReturnS As DateTimePicker
    Friend WithEvents btnShowdata As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnExcel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVReturnDt As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColidSaleRTDt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColidSaleRT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColNewidSaleDt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDocRef_ As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColLotNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColInvName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColAmountRT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColUnit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColPrice_ As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColRTValue As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColPriceRT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColExp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GVReturnMt As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColNum As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColEdit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rptEdit As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents ColDoc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rptDoc As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents ColPsCancel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColCancelNote As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColidSaleReturn_ As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDateRT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDocRef As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDocNum_ As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColCusName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColAp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColPv As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColPsSale As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColTotal_ As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColRTCause As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColNote As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColPsTs As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDateTs As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColidRTDocCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colidComp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colidRtAVxST As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColCompName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColidWaitReturn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cbRtAVxST As CheckBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents rptCancel As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents ColCancel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents cbCancel As CheckBox
    Friend WithEvents ColidCancel As DevExpress.XtraGrid.Columns.GridColumn
End Class
