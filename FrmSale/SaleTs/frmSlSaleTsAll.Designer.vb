<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSlSaleTsAll
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
        Me.components = New System.ComponentModel.Container()
        Dim SerializableAppearanceObject6 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject7 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject8 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSlSaleTsAll))
        Dim SerializableAppearanceObject9 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject10 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.rptChx = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.rptCheckPrice = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.ColExp = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rptDel = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.Col_idSaleOrderDt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Col_idSaleDt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Col_OldStock = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Col_OldAmt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Col_CompRec = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidInvMain = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Col_idLot = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidLotSPM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidInvGroup = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidWh = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColLastPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColNum = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColChxProductName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnDraft = New DevExpress.XtraEditors.SimpleButton()
        Me.ColPdCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rptPdCode = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.ColLot = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rpttxtLotNo = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.ColCodeOrder = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColProductName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rptProductName = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
        Me.colstEdit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColAmtStock = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColAmtSale = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColidUnit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rptUnit = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.ColPriceNormal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColPercDiscount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColBathDiscount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColPriceSale = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAmtOrder = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColWareHouseName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colstWIMAllRec = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.colAmtWIMRecBal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtTotalBFDisc = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.stLbl_DateTs = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stLbl_PsTs = New System.Windows.Forms.ToolStripStatusLabel()
        Me.txtDiscBath = New System.Windows.Forms.TextBox()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.rdbAppOK = New System.Windows.Forms.RadioButton()
        Me.rdbAppNo = New System.Windows.Forms.RadioButton()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnPdInc = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_img = New System.Windows.Forms.Button()
        Me.StatusStrip2 = New System.Windows.Forms.StatusStrip()
        Me.lblPerc = New System.Windows.Forms.TextBox()
        Me.ColDtType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColLotNoHide = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColidWhHide = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColidLotHide = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidRefLot = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.stCutStock = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colpWeight = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColidUnitW = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rptLotNo = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblPsOrder = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.btnPsOrder = New DevExpress.XtraEditors.SimpleButton()
        Me.GBDiscount = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtAmtPerc = New System.Windows.Forms.TextBox()
        Me.rdbBathDisc = New System.Windows.Forms.RadioButton()
        Me.rdbPerDisc = New System.Windows.Forms.RadioButton()
        Me.btnFindOrder = New DevExpress.XtraEditors.SimpleButton()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.gcNote = New DevExpress.XtraGrid.GridControl()
        Me.gvNote = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colNote = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnTspComp = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAddressS = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSale = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCustomer = New DevExpress.XtraEditors.SimpleButton()
        Me.lblTspComp = New System.Windows.Forms.Label()
        Me.lblCusNote = New System.Windows.Forms.TextBox()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.cmbTypePayTrp = New System.Windows.Forms.ComboBox()
        Me.lblAddr = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.CmbTs = New System.Windows.Forms.ComboBox()
        Me.lblTS = New System.Windows.Forms.Label()
        Me.lblCusRec = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.lblPsSale = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblPsCus = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.rdbBill = New System.Windows.Forms.RadioButton()
        Me.rdbWhole = New System.Windows.Forms.RadioButton()
        Me.rdbRetail = New System.Windows.Forms.RadioButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtTotalNet = New System.Windows.Forms.TextBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.rdbRight = New System.Windows.Forms.RadioButton()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.rdbNoRight = New System.Windows.Forms.RadioButton()
        Me.btnRefDoc = New DevExpress.XtraEditors.SimpleButton()
        Me.lblRefAcc = New System.Windows.Forms.Label()
        Me.cmbGroupComp = New System.Windows.Forms.ComboBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.lblDocCode = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpSale = New System.Windows.Forms.DateTimePicker()
        Me.cmbDRCode = New System.Windows.Forms.ComboBox()
        Me.txtDocRef = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.txtPrePay = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtPercP = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbTp = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.dtpPay = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PriceSaleHide = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.idInvMainHide = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Img1 = New System.Windows.Forms.ImageList(Me.components)
        Me.GCSale = New DevExpress.XtraGrid.GridControl()
        Me.DGVBind = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colidSubType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.AmtSaleHide = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColidUnitHide = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PriceNormalHide = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PercDiscHide = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BathDiscHide = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.rptChx, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptCheckPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptDel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.rptPdCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpttxtLotNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptProductName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptUnit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.StatusStrip2.SuspendLayout()
        CType(Me.rptLotNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GBDiscount.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.gcNote, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvNote, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        CType(Me.GCSale, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVBind, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rptChx
        '
        Me.rptChx.AutoHeight = False
        Me.rptChx.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Global.SAM.My.Resources.Resources.arrow_refresh, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject6, "", Nothing, Nothing, True)})
        Me.rptChx.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.rptChx.Name = "rptChx"
        Me.rptChx.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'rptCheckPrice
        '
        Me.rptCheckPrice.AutoHeight = False
        Me.rptCheckPrice.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Global.SAM.My.Resources.Resources.P_Down, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject7, "", Nothing, Nothing, True)})
        Me.rptCheckPrice.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.rptCheckPrice.Name = "rptCheckPrice"
        Me.rptCheckPrice.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'ColExp
        '
        Me.ColExp.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ColExp.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColExp.AppearanceCell.Options.UseBackColor = True
        Me.ColExp.AppearanceCell.Options.UseFont = True
        Me.ColExp.AppearanceCell.Options.UseTextOptions = True
        Me.ColExp.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ColExp.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColExp.AppearanceHeader.Options.UseFont = True
        Me.ColExp.AppearanceHeader.Options.UseTextOptions = True
        Me.ColExp.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColExp.Caption = "รวมเป็นเงิน"
        Me.ColExp.DisplayFormat.FormatString = "#,##0.00"
        Me.ColExp.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColExp.FieldName = "Total"
        Me.ColExp.MinWidth = 85
        Me.ColExp.Name = "ColExp"
        Me.ColExp.OptionsColumn.AllowEdit = False
        Me.ColExp.OptionsColumn.ReadOnly = True
        Me.ColExp.OptionsColumn.TabStop = False
        Me.ColExp.Visible = True
        Me.ColExp.VisibleIndex = 11
        Me.ColExp.Width = 91
        '
        'ColDel
        '
        Me.ColDel.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColDel.AppearanceCell.Options.UseFont = True
        Me.ColDel.AppearanceCell.Options.UseTextOptions = True
        Me.ColDel.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDel.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColDel.AppearanceHeader.Options.UseFont = True
        Me.ColDel.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDel.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDel.Caption = "ลบ"
        Me.ColDel.ColumnEdit = Me.rptDel
        Me.ColDel.MaxWidth = 35
        Me.ColDel.MinWidth = 35
        Me.ColDel.Name = "ColDel"
        Me.ColDel.OptionsColumn.AllowSize = False
        Me.ColDel.Visible = True
        Me.ColDel.VisibleIndex = 13
        Me.ColDel.Width = 35
        '
        'rptDel
        '
        Me.rptDel.AutoHeight = False
        Me.rptDel.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Global.SAM.My.Resources.Resources.minus2, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject8, "", Nothing, Nothing, True)})
        Me.rptDel.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.rptDel.Name = "rptDel"
        Me.rptDel.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'Col_idSaleOrderDt
        '
        Me.Col_idSaleOrderDt.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Col_idSaleOrderDt.AppearanceCell.Options.UseFont = True
        Me.Col_idSaleOrderDt.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Col_idSaleOrderDt.AppearanceHeader.Options.UseFont = True
        Me.Col_idSaleOrderDt.Caption = "idSaleOrderDt"
        Me.Col_idSaleOrderDt.FieldName = "idSaleOrderDt"
        Me.Col_idSaleOrderDt.Name = "Col_idSaleOrderDt"
        '
        'Col_idSaleDt
        '
        Me.Col_idSaleDt.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Col_idSaleDt.AppearanceCell.Options.UseFont = True
        Me.Col_idSaleDt.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Col_idSaleDt.AppearanceHeader.Options.UseFont = True
        Me.Col_idSaleDt.Caption = "idSaleDt"
        Me.Col_idSaleDt.FieldName = "idSaleDt"
        Me.Col_idSaleDt.Name = "Col_idSaleDt"
        '
        'Col_OldStock
        '
        Me.Col_OldStock.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Col_OldStock.AppearanceCell.Options.UseFont = True
        Me.Col_OldStock.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Col_OldStock.AppearanceHeader.Options.UseFont = True
        Me.Col_OldStock.Caption = "OldStock"
        Me.Col_OldStock.DisplayFormat.FormatString = "#,##0.00###"
        Me.Col_OldStock.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Col_OldStock.FieldName = "OldStock"
        Me.Col_OldStock.Name = "Col_OldStock"
        '
        'Col_OldAmt
        '
        Me.Col_OldAmt.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Col_OldAmt.AppearanceCell.Options.UseFont = True
        Me.Col_OldAmt.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Col_OldAmt.AppearanceHeader.Options.UseFont = True
        Me.Col_OldAmt.Caption = "OldAmt"
        Me.Col_OldAmt.DisplayFormat.FormatString = "#,##0.00###"
        Me.Col_OldAmt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Col_OldAmt.FieldName = "OldAmt"
        Me.Col_OldAmt.Name = "Col_OldAmt"
        '
        'Col_CompRec
        '
        Me.Col_CompRec.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Col_CompRec.AppearanceCell.Options.UseFont = True
        Me.Col_CompRec.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Col_CompRec.AppearanceHeader.Options.UseFont = True
        Me.Col_CompRec.Caption = "CompRec"
        Me.Col_CompRec.FieldName = "CompRec"
        Me.Col_CompRec.Name = "Col_CompRec"
        '
        'colidInvMain
        '
        Me.colidInvMain.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colidInvMain.AppearanceCell.Options.UseFont = True
        Me.colidInvMain.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colidInvMain.AppearanceHeader.Options.UseFont = True
        Me.colidInvMain.Caption = "idInvMain"
        Me.colidInvMain.FieldName = "idInvMain"
        Me.colidInvMain.Name = "colidInvMain"
        '
        'Col_idLot
        '
        Me.Col_idLot.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Col_idLot.AppearanceCell.Options.UseFont = True
        Me.Col_idLot.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Col_idLot.AppearanceHeader.Options.UseFont = True
        Me.Col_idLot.Caption = "idLot"
        Me.Col_idLot.FieldName = "idLot"
        Me.Col_idLot.Name = "Col_idLot"
        '
        'colidLotSPM
        '
        Me.colidLotSPM.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colidLotSPM.AppearanceCell.Options.UseFont = True
        Me.colidLotSPM.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colidLotSPM.AppearanceHeader.Options.UseFont = True
        Me.colidLotSPM.Caption = "colidLotSPM"
        Me.colidLotSPM.FieldName = "idLotSPM"
        Me.colidLotSPM.Name = "colidLotSPM"
        '
        'colidInvGroup
        '
        Me.colidInvGroup.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colidInvGroup.AppearanceCell.Options.UseFont = True
        Me.colidInvGroup.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colidInvGroup.AppearanceHeader.Options.UseFont = True
        Me.colidInvGroup.Caption = "idInvGroup"
        Me.colidInvGroup.FieldName = "idInvGroup"
        Me.colidInvGroup.Name = "colidInvGroup"
        '
        'colidWh
        '
        Me.colidWh.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colidWh.AppearanceCell.Options.UseFont = True
        Me.colidWh.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colidWh.AppearanceHeader.Options.UseFont = True
        Me.colidWh.Caption = "idWh"
        Me.colidWh.FieldName = "idWh"
        Me.colidWh.Name = "colidWh"
        '
        'colNo
        '
        Me.colNo.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colNo.AppearanceCell.Options.UseFont = True
        Me.colNo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colNo.AppearanceHeader.Options.UseFont = True
        Me.colNo.Caption = "colNo"
        Me.colNo.FieldName = "No"
        Me.colNo.Name = "colNo"
        '
        'ColLastPrice
        '
        Me.ColLastPrice.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColLastPrice.AppearanceCell.Options.UseFont = True
        Me.ColLastPrice.AppearanceCell.Options.UseTextOptions = True
        Me.ColLastPrice.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColLastPrice.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColLastPrice.AppearanceHeader.Options.UseFont = True
        Me.ColLastPrice.AppearanceHeader.Options.UseTextOptions = True
        Me.ColLastPrice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColLastPrice.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColLastPrice.Caption = "ตรวจสอบราคา"
        Me.ColLastPrice.ColumnEdit = Me.rptCheckPrice
        Me.ColLastPrice.MaxWidth = 50
        Me.ColLastPrice.MinWidth = 50
        Me.ColLastPrice.Name = "ColLastPrice"
        Me.ColLastPrice.OptionsColumn.ReadOnly = True
        Me.ColLastPrice.OptionsColumn.TabStop = False
        Me.ColLastPrice.Visible = True
        Me.ColLastPrice.VisibleIndex = 15
        Me.ColLastPrice.Width = 50
        '
        'ColNum
        '
        Me.ColNum.AppearanceCell.BackColor = System.Drawing.Color.Gainsboro
        Me.ColNum.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColNum.AppearanceCell.Options.UseBackColor = True
        Me.ColNum.AppearanceCell.Options.UseFont = True
        Me.ColNum.AppearanceCell.Options.UseTextOptions = True
        Me.ColNum.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColNum.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColNum.AppearanceHeader.Options.UseFont = True
        Me.ColNum.AppearanceHeader.Options.UseTextOptions = True
        Me.ColNum.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColNum.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColNum.Caption = "ลำดับ"
        Me.ColNum.MaxWidth = 42
        Me.ColNum.MinWidth = 42
        Me.ColNum.Name = "ColNum"
        Me.ColNum.OptionsColumn.AllowEdit = False
        Me.ColNum.OptionsColumn.ReadOnly = True
        Me.ColNum.OptionsColumn.TabStop = False
        Me.ColNum.Visible = True
        Me.ColNum.VisibleIndex = 0
        Me.ColNum.Width = 42
        '
        'ColChxProductName
        '
        Me.ColChxProductName.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColChxProductName.AppearanceCell.Options.UseFont = True
        Me.ColChxProductName.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColChxProductName.AppearanceHeader.Options.UseFont = True
        Me.ColChxProductName.AppearanceHeader.Options.UseTextOptions = True
        Me.ColChxProductName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColChxProductName.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColChxProductName.Caption = "แก้ไขชื่อสินค้า"
        Me.ColChxProductName.ColumnEdit = Me.rptChx
        Me.ColChxProductName.MaxWidth = 48
        Me.ColChxProductName.MinWidth = 48
        Me.ColChxProductName.Name = "ColChxProductName"
        Me.ColChxProductName.OptionsColumn.TabStop = False
        Me.ColChxProductName.Visible = True
        Me.ColChxProductName.VisibleIndex = 14
        Me.ColChxProductName.Width = 48
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.btnDraft)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(130, 35)
        Me.Panel3.TabIndex = 27
        Me.Panel3.Visible = False
        '
        'btnDraft
        '
        Me.btnDraft.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDraft.Appearance.Options.UseFont = True
        Me.btnDraft.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDraft.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnDraft.Image = CType(resources.GetObject("btnDraft.Image"), System.Drawing.Image)
        Me.btnDraft.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnDraft.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnDraft.Location = New System.Drawing.Point(0, 0)
        Me.btnDraft.Name = "btnDraft"
        Me.btnDraft.Size = New System.Drawing.Size(130, 35)
        Me.btnDraft.TabIndex = 2
        Me.btnDraft.Text = "บันทึกแบบร่าง"
        '
        'ColPdCode
        '
        Me.ColPdCode.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColPdCode.AppearanceCell.Options.UseFont = True
        Me.ColPdCode.AppearanceCell.Options.UseImage = True
        Me.ColPdCode.AppearanceCell.Options.UseTextOptions = True
        Me.ColPdCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColPdCode.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColPdCode.AppearanceHeader.Options.UseFont = True
        Me.ColPdCode.AppearanceHeader.Options.UseTextOptions = True
        Me.ColPdCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColPdCode.Caption = "รหัสสินค้า"
        Me.ColPdCode.ColumnEdit = Me.rptPdCode
        Me.ColPdCode.FieldName = "PdCode"
        Me.ColPdCode.MinWidth = 115
        Me.ColPdCode.Name = "ColPdCode"
        Me.ColPdCode.Visible = True
        Me.ColPdCode.VisibleIndex = 1
        Me.ColPdCode.Width = 115
        '
        'rptPdCode
        '
        Me.rptPdCode.AutoHeight = False
        Me.rptPdCode.ContextImageAlignment = DevExpress.XtraEditors.ContextImageAlignment.Far
        Me.rptPdCode.Name = "rptPdCode"
        '
        'ColLot
        '
        Me.ColLot.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColLot.AppearanceCell.Options.UseFont = True
        Me.ColLot.AppearanceCell.Options.UseTextOptions = True
        Me.ColLot.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColLot.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColLot.AppearanceHeader.Options.UseFont = True
        Me.ColLot.AppearanceHeader.Options.UseTextOptions = True
        Me.ColLot.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColLot.Caption = "Lot No."
        Me.ColLot.ColumnEdit = Me.rpttxtLotNo
        Me.ColLot.FieldName = "LotNo"
        Me.ColLot.MinWidth = 90
        Me.ColLot.Name = "ColLot"
        Me.ColLot.Visible = True
        Me.ColLot.VisibleIndex = 3
        Me.ColLot.Width = 104
        '
        'rpttxtLotNo
        '
        Me.rpttxtLotNo.AutoHeight = False
        Me.rpttxtLotNo.ContextImageAlignment = DevExpress.XtraEditors.ContextImageAlignment.Far
        Me.rpttxtLotNo.Name = "rpttxtLotNo"
        '
        'ColCodeOrder
        '
        Me.ColCodeOrder.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColCodeOrder.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColCodeOrder.AppearanceCell.Options.UseBackColor = True
        Me.ColCodeOrder.AppearanceCell.Options.UseFont = True
        Me.ColCodeOrder.AppearanceCell.Options.UseTextOptions = True
        Me.ColCodeOrder.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColCodeOrder.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColCodeOrder.AppearanceHeader.Options.UseFont = True
        Me.ColCodeOrder.AppearanceHeader.Options.UseTextOptions = True
        Me.ColCodeOrder.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColCodeOrder.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColCodeOrder.Caption = "เลขที่รายการสั่งซื้อ"
        Me.ColCodeOrder.FieldName = "CodeOrder"
        Me.ColCodeOrder.MaxWidth = 85
        Me.ColCodeOrder.MinWidth = 85
        Me.ColCodeOrder.Name = "ColCodeOrder"
        Me.ColCodeOrder.OptionsColumn.AllowEdit = False
        Me.ColCodeOrder.OptionsColumn.ReadOnly = True
        Me.ColCodeOrder.Width = 85
        '
        'ColProductName
        '
        Me.ColProductName.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.ColProductName.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColProductName.AppearanceCell.Options.UseBackColor = True
        Me.ColProductName.AppearanceCell.Options.UseFont = True
        Me.ColProductName.AppearanceCell.Options.UseTextOptions = True
        Me.ColProductName.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColProductName.AppearanceHeader.Options.UseFont = True
        Me.ColProductName.AppearanceHeader.Options.UseTextOptions = True
        Me.ColProductName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColProductName.Caption = "รายการสินค้า"
        Me.ColProductName.ColumnEdit = Me.rptProductName
        Me.ColProductName.FieldName = "ProductName"
        Me.ColProductName.MinWidth = 10
        Me.ColProductName.Name = "ColProductName"
        Me.ColProductName.Visible = True
        Me.ColProductName.VisibleIndex = 2
        Me.ColProductName.Width = 247
        '
        'rptProductName
        '
        Me.rptProductName.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.[True]
        Me.rptProductName.AutoHeight = False
        Me.rptProductName.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.[Default], Global.SAM.My.Resources.Resources.search_png_16x16, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject9, "", Nothing, Nothing, True)})
        Me.rptProductName.LinkColorUseParentAppearance = True
        Me.rptProductName.Name = "rptProductName"
        Me.rptProductName.NullText = "เลือกสินค้า"
        Me.rptProductName.SingleClick = True
        Me.rptProductName.StartKey = New DevExpress.Utils.KeyShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F))
        '
        'colstEdit
        '
        Me.colstEdit.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colstEdit.AppearanceCell.Options.UseFont = True
        Me.colstEdit.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colstEdit.AppearanceHeader.Options.UseFont = True
        Me.colstEdit.Caption = "stEdit"
        Me.colstEdit.FieldName = "stEdit"
        Me.colstEdit.Name = "colstEdit"
        '
        'ColAmtStock
        '
        Me.ColAmtStock.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ColAmtStock.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColAmtStock.AppearanceCell.Options.UseBackColor = True
        Me.ColAmtStock.AppearanceCell.Options.UseFont = True
        Me.ColAmtStock.AppearanceCell.Options.UseTextOptions = True
        Me.ColAmtStock.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ColAmtStock.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColAmtStock.AppearanceHeader.Options.UseFont = True
        Me.ColAmtStock.AppearanceHeader.Options.UseTextOptions = True
        Me.ColAmtStock.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColAmtStock.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColAmtStock.Caption = "จน.คงเหลือใน Stock"
        Me.ColAmtStock.DisplayFormat.FormatString = "#,##0.00##"
        Me.ColAmtStock.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColAmtStock.FieldName = "AmtStock"
        Me.ColAmtStock.MinWidth = 70
        Me.ColAmtStock.Name = "ColAmtStock"
        Me.ColAmtStock.OptionsColumn.AllowEdit = False
        Me.ColAmtStock.OptionsColumn.ReadOnly = True
        Me.ColAmtStock.OptionsColumn.TabStop = False
        Me.ColAmtStock.Visible = True
        Me.ColAmtStock.VisibleIndex = 4
        Me.ColAmtStock.Width = 70
        '
        'ColAmtSale
        '
        Me.ColAmtSale.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColAmtSale.AppearanceCell.Options.UseFont = True
        Me.ColAmtSale.AppearanceCell.Options.UseTextOptions = True
        Me.ColAmtSale.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ColAmtSale.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColAmtSale.AppearanceHeader.Options.UseFont = True
        Me.ColAmtSale.AppearanceHeader.Options.UseTextOptions = True
        Me.ColAmtSale.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColAmtSale.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColAmtSale.Caption = "จน.ขาย"
        Me.ColAmtSale.DisplayFormat.FormatString = "#,##0.00##"
        Me.ColAmtSale.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.ColAmtSale.FieldName = "AmtSale"
        Me.ColAmtSale.MinWidth = 60
        Me.ColAmtSale.Name = "ColAmtSale"
        Me.ColAmtSale.Visible = True
        Me.ColAmtSale.VisibleIndex = 5
        Me.ColAmtSale.Width = 60
        '
        'ColidUnit
        '
        Me.ColidUnit.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColidUnit.AppearanceCell.Options.UseFont = True
        Me.ColidUnit.AppearanceCell.Options.UseTextOptions = True
        Me.ColidUnit.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColidUnit.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColidUnit.AppearanceHeader.Options.UseFont = True
        Me.ColidUnit.AppearanceHeader.Options.UseTextOptions = True
        Me.ColidUnit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColidUnit.Caption = "หน่วย"
        Me.ColidUnit.ColumnEdit = Me.rptUnit
        Me.ColidUnit.FieldName = "idUnit"
        Me.ColidUnit.MinWidth = 60
        Me.ColidUnit.Name = "ColidUnit"
        Me.ColidUnit.Visible = True
        Me.ColidUnit.VisibleIndex = 6
        Me.ColidUnit.Width = 60
        '
        'rptUnit
        '
        Me.rptUnit.AutoHeight = False
        Me.rptUnit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rptUnit.DisplayMember = "UnitName"
        Me.rptUnit.Name = "rptUnit"
        Me.rptUnit.NullText = ""
        Me.rptUnit.PopupFormMinSize = New System.Drawing.Size(40, 0)
        Me.rptUnit.ShowFooter = False
        Me.rptUnit.ShowHeader = False
        Me.rptUnit.ValueMember = "idUnit"
        '
        'ColPriceNormal
        '
        Me.ColPriceNormal.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColPriceNormal.AppearanceCell.Options.UseFont = True
        Me.ColPriceNormal.AppearanceCell.Options.UseTextOptions = True
        Me.ColPriceNormal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ColPriceNormal.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColPriceNormal.AppearanceHeader.Options.UseFont = True
        Me.ColPriceNormal.AppearanceHeader.Options.UseTextOptions = True
        Me.ColPriceNormal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColPriceNormal.Caption = "ราคาปกติ"
        Me.ColPriceNormal.DisplayFormat.FormatString = "#,##0.00##"
        Me.ColPriceNormal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.ColPriceNormal.FieldName = "PriceNormal"
        Me.ColPriceNormal.MinWidth = 75
        Me.ColPriceNormal.Name = "ColPriceNormal"
        Me.ColPriceNormal.Visible = True
        Me.ColPriceNormal.VisibleIndex = 7
        '
        'ColPercDiscount
        '
        Me.ColPercDiscount.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColPercDiscount.AppearanceCell.Options.UseFont = True
        Me.ColPercDiscount.AppearanceCell.Options.UseTextOptions = True
        Me.ColPercDiscount.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColPercDiscount.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColPercDiscount.AppearanceHeader.Options.UseFont = True
        Me.ColPercDiscount.AppearanceHeader.Options.UseTextOptions = True
        Me.ColPercDiscount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColPercDiscount.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColPercDiscount.Caption = "ส่วนลด (%)"
        Me.ColPercDiscount.DisplayFormat.FormatString = "#,##0.00"
        Me.ColPercDiscount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColPercDiscount.FieldName = "PercDisc"
        Me.ColPercDiscount.MinWidth = 55
        Me.ColPercDiscount.Name = "ColPercDiscount"
        Me.ColPercDiscount.Visible = True
        Me.ColPercDiscount.VisibleIndex = 8
        Me.ColPercDiscount.Width = 55
        '
        'ColBathDiscount
        '
        Me.ColBathDiscount.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColBathDiscount.AppearanceCell.Options.UseFont = True
        Me.ColBathDiscount.AppearanceCell.Options.UseTextOptions = True
        Me.ColBathDiscount.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColBathDiscount.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColBathDiscount.AppearanceHeader.Options.UseFont = True
        Me.ColBathDiscount.AppearanceHeader.Options.UseTextOptions = True
        Me.ColBathDiscount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColBathDiscount.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColBathDiscount.Caption = "ส่วนลด (บาท)"
        Me.ColBathDiscount.DisplayFormat.FormatString = "#,##0.00"
        Me.ColBathDiscount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColBathDiscount.FieldName = "BathDisc"
        Me.ColBathDiscount.MinWidth = 55
        Me.ColBathDiscount.Name = "ColBathDiscount"
        Me.ColBathDiscount.Visible = True
        Me.ColBathDiscount.VisibleIndex = 9
        Me.ColBathDiscount.Width = 55
        '
        'ColPriceSale
        '
        Me.ColPriceSale.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColPriceSale.AppearanceCell.Options.UseFont = True
        Me.ColPriceSale.AppearanceCell.Options.UseTextOptions = True
        Me.ColPriceSale.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ColPriceSale.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColPriceSale.AppearanceHeader.Options.UseFont = True
        Me.ColPriceSale.AppearanceHeader.Options.UseTextOptions = True
        Me.ColPriceSale.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColPriceSale.Caption = "ราคาขาย"
        Me.ColPriceSale.DisplayFormat.FormatString = "#,##0.00##"
        Me.ColPriceSale.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.ColPriceSale.FieldName = "PriceSale"
        Me.ColPriceSale.MinWidth = 75
        Me.ColPriceSale.Name = "ColPriceSale"
        Me.ColPriceSale.Visible = True
        Me.ColPriceSale.VisibleIndex = 10
        '
        'colAmtOrder
        '
        Me.colAmtOrder.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colAmtOrder.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colAmtOrder.AppearanceCell.Options.UseBackColor = True
        Me.colAmtOrder.AppearanceCell.Options.UseFont = True
        Me.colAmtOrder.AppearanceCell.Options.UseTextOptions = True
        Me.colAmtOrder.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colAmtOrder.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colAmtOrder.AppearanceHeader.Options.UseFont = True
        Me.colAmtOrder.AppearanceHeader.Options.UseTextOptions = True
        Me.colAmtOrder.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colAmtOrder.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colAmtOrder.Caption = "จน.สั่งซื้อ"
        Me.colAmtOrder.DisplayFormat.FormatString = "#,##0.00##"
        Me.colAmtOrder.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colAmtOrder.FieldName = "AmtOrder"
        Me.colAmtOrder.MaxWidth = 60
        Me.colAmtOrder.MinWidth = 60
        Me.colAmtOrder.Name = "colAmtOrder"
        Me.colAmtOrder.OptionsColumn.AllowEdit = False
        Me.colAmtOrder.OptionsColumn.ReadOnly = True
        Me.colAmtOrder.Width = 60
        '
        'ColWareHouseName
        '
        Me.ColWareHouseName.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColWareHouseName.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColWareHouseName.AppearanceCell.Options.UseBackColor = True
        Me.ColWareHouseName.AppearanceCell.Options.UseFont = True
        Me.ColWareHouseName.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColWareHouseName.AppearanceHeader.Options.UseFont = True
        Me.ColWareHouseName.AppearanceHeader.Options.UseTextOptions = True
        Me.ColWareHouseName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColWareHouseName.Caption = "คลังสินค้า"
        Me.ColWareHouseName.FieldName = "full_lock"
        Me.ColWareHouseName.MinWidth = 100
        Me.ColWareHouseName.Name = "ColWareHouseName"
        Me.ColWareHouseName.OptionsColumn.AllowEdit = False
        Me.ColWareHouseName.OptionsColumn.ReadOnly = True
        Me.ColWareHouseName.Visible = True
        Me.ColWareHouseName.VisibleIndex = 12
        Me.ColWareHouseName.Width = 100
        '
        'colstWIMAllRec
        '
        Me.colstWIMAllRec.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colstWIMAllRec.AppearanceCell.Options.UseFont = True
        Me.colstWIMAllRec.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colstWIMAllRec.AppearanceHeader.Options.UseFont = True
        Me.colstWIMAllRec.Caption = "stWIMAllRec"
        Me.colstWIMAllRec.FieldName = "stWIMAllRec"
        Me.colstWIMAllRec.Name = "colstWIMAllRec"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.Location = New System.Drawing.Point(228, 51)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(30, 14)
        Me.Label9.TabIndex = 585
        Me.Label9.Text = "บาท"
        '
        'colAmtWIMRecBal
        '
        Me.colAmtWIMRecBal.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colAmtWIMRecBal.AppearanceCell.Options.UseFont = True
        Me.colAmtWIMRecBal.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colAmtWIMRecBal.AppearanceHeader.Options.UseFont = True
        Me.colAmtWIMRecBal.Caption = "AmtWIMRecBal"
        Me.colAmtWIMRecBal.FieldName = "AmtWIMRecBal"
        Me.colAmtWIMRecBal.Name = "colAmtWIMRecBal"
        '
        'txtTotalBFDisc
        '
        Me.txtTotalBFDisc.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtTotalBFDisc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalBFDisc.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTotalBFDisc.ForeColor = System.Drawing.Color.Lime
        Me.txtTotalBFDisc.Location = New System.Drawing.Point(996, 8)
        Me.txtTotalBFDisc.Multiline = True
        Me.txtTotalBFDisc.Name = "txtTotalBFDisc"
        Me.txtTotalBFDisc.ReadOnly = True
        Me.txtTotalBFDisc.Size = New System.Drawing.Size(175, 26)
        Me.txtTotalBFDisc.TabIndex = 583
        Me.txtTotalBFDisc.TabStop = False
        Me.txtTotalBFDisc.Text = "0"
        Me.txtTotalBFDisc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(917, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 14)
        Me.Label2.TabIndex = 582
        Me.Label2.Text = "รวมเป็นเงิน"
        '
        'stLbl_DateTs
        '
        Me.stLbl_DateTs.Image = CType(resources.GetObject("stLbl_DateTs.Image"), System.Drawing.Image)
        Me.stLbl_DateTs.Name = "stLbl_DateTs"
        Me.stLbl_DateTs.Size = New System.Drawing.Size(93, 17)
        Me.stLbl_DateTs.Text = ": วันที่ทำรายการ"
        Me.stLbl_DateTs.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'stLbl_PsTs
        '
        Me.stLbl_PsTs.Image = CType(resources.GetObject("stLbl_PsTs.Image"), System.Drawing.Image)
        Me.stLbl_PsTs.Name = "stLbl_PsTs"
        Me.stLbl_PsTs.Size = New System.Drawing.Size(81, 17)
        Me.stLbl_PsTs.Text = ": ผู้ทำรายการ"
        Me.stLbl_PsTs.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'txtDiscBath
        '
        Me.txtDiscBath.BackColor = System.Drawing.Color.White
        Me.txtDiscBath.Enabled = False
        Me.txtDiscBath.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtDiscBath.ForeColor = System.Drawing.Color.Black
        Me.txtDiscBath.Location = New System.Drawing.Point(128, 46)
        Me.txtDiscBath.MaxLength = 3
        Me.txtDiscBath.Name = "txtDiscBath"
        Me.txtDiscBath.Size = New System.Drawing.Size(94, 22)
        Me.txtDiscBath.TabIndex = 602
        Me.txtDiscBath.Text = "0"
        Me.txtDiscBath.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PanelControl3
        '
        Me.PanelControl3.Appearance.BackColor = System.Drawing.Color.LightSteelBlue
        Me.PanelControl3.Appearance.BackColor2 = System.Drawing.Color.CornflowerBlue
        Me.PanelControl3.Appearance.Options.UseBackColor = True
        Me.PanelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl3.Controls.Add(Me.Panel5)
        Me.PanelControl3.Controls.Add(Me.Panel6)
        Me.PanelControl3.Controls.Add(Me.Panel2)
        Me.PanelControl3.Controls.Add(Me.Panel1)
        Me.PanelControl3.Controls.Add(Me.Panel3)
        Me.PanelControl3.Controls.Add(Me.btn_img)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl3.Location = New System.Drawing.Point(0, 524)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(1184, 35)
        Me.PanelControl3.TabIndex = 739
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Transparent
        Me.Panel5.Controls.Add(Me.rdbAppOK)
        Me.Panel5.Controls.Add(Me.rdbAppNo)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(744, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(175, 35)
        Me.Panel5.TabIndex = 30
        '
        'rdbAppOK
        '
        Me.rdbAppOK.AutoSize = True
        Me.rdbAppOK.BackColor = System.Drawing.Color.Transparent
        Me.rdbAppOK.Checked = True
        Me.rdbAppOK.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rdbAppOK.ForeColor = System.Drawing.Color.Crimson
        Me.rdbAppOK.Location = New System.Drawing.Point(7, 9)
        Me.rdbAppOK.Name = "rdbAppOK"
        Me.rdbAppOK.Size = New System.Drawing.Size(61, 20)
        Me.rdbAppOK.TabIndex = 25
        Me.rdbAppOK.TabStop = True
        Me.rdbAppOK.Text = "อนุมัติ"
        Me.rdbAppOK.UseVisualStyleBackColor = False
        Me.rdbAppOK.Visible = False
        '
        'rdbAppNo
        '
        Me.rdbAppNo.AutoSize = True
        Me.rdbAppNo.BackColor = System.Drawing.Color.Transparent
        Me.rdbAppNo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rdbAppNo.ForeColor = System.Drawing.Color.Crimson
        Me.rdbAppNo.Location = New System.Drawing.Point(69, 9)
        Me.rdbAppNo.Name = "rdbAppNo"
        Me.rdbAppNo.Size = New System.Drawing.Size(77, 20)
        Me.rdbAppNo.TabIndex = 26
        Me.rdbAppNo.Text = "ไม่อนุมัติ"
        Me.rdbAppNo.UseVisualStyleBackColor = False
        Me.rdbAppNo.Visible = False
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Transparent
        Me.Panel6.Controls.Add(Me.Label20)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(327, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(417, 35)
        Me.Panel6.TabIndex = 31
        Me.Panel6.Visible = False
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.Gold
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Navy
        Me.Label20.Location = New System.Drawing.Point(5, 4)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(403, 26)
        Me.Label20.TabIndex = 979
        Me.Label20.Text = "**รายการนี้เป็นเพียงแบบร่าง จึงยังไม่ถูกส่งไปตัดเบิกออกจากคลัง**"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.btnPdInc)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(227, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(100, 35)
        Me.Panel2.TabIndex = 29
        '
        'btnPdInc
        '
        Me.btnPdInc.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPdInc.Appearance.Options.UseFont = True
        Me.btnPdInc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPdInc.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnPdInc.Image = CType(resources.GetObject("btnPdInc.Image"), System.Drawing.Image)
        Me.btnPdInc.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnPdInc.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnPdInc.Location = New System.Drawing.Point(0, 0)
        Me.btnPdInc.Name = "btnPdInc"
        Me.btnPdInc.Size = New System.Drawing.Size(100, 35)
        Me.btnPdInc.TabIndex = 1
        Me.btnPdInc.Text = "เพิ่มสินค้า"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(130, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(97, 35)
        Me.Panel1.TabIndex = 28
        '
        'btnSave
        '
        Me.btnSave.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Appearance.Options.UseFont = True
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnSave.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnSave.Location = New System.Drawing.Point(0, 0)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(97, 35)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "บันทึกบิล"
        '
        'btn_img
        '
        Me.btn_img.BackColor = System.Drawing.Color.DimGray
        Me.btn_img.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_img.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_img.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_img.ForeColor = System.Drawing.Color.White
        Me.btn_img.Image = CType(resources.GetObject("btn_img.Image"), System.Drawing.Image)
        Me.btn_img.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_img.Location = New System.Drawing.Point(971, 0)
        Me.btn_img.Name = "btn_img"
        Me.btn_img.Size = New System.Drawing.Size(213, 35)
        Me.btn_img.TabIndex = 5
        Me.btn_img.Tag = "Save"
        Me.btn_img.Text = "       รูปภาพอ้างอิงรายการขายสินค้า"
        Me.btn_img.UseVisualStyleBackColor = False
        '
        'StatusStrip2
        '
        Me.StatusStrip2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.StatusStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.stLbl_DateTs, Me.stLbl_PsTs})
        Me.StatusStrip2.Location = New System.Drawing.Point(0, 559)
        Me.StatusStrip2.Name = "StatusStrip2"
        Me.StatusStrip2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StatusStrip2.Size = New System.Drawing.Size(1184, 22)
        Me.StatusStrip2.TabIndex = 738
        Me.StatusStrip2.Text = "StatusStrip2"
        '
        'lblPerc
        '
        Me.lblPerc.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblPerc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPerc.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblPerc.ForeColor = System.Drawing.Color.Lime
        Me.lblPerc.Location = New System.Drawing.Point(178, 24)
        Me.lblPerc.Multiline = True
        Me.lblPerc.Name = "lblPerc"
        Me.lblPerc.ReadOnly = True
        Me.lblPerc.Size = New System.Drawing.Size(76, 18)
        Me.lblPerc.TabIndex = 601
        Me.lblPerc.TabStop = False
        Me.lblPerc.Text = "0"
        Me.lblPerc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ColDtType
        '
        Me.ColDtType.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColDtType.AppearanceCell.Options.UseFont = True
        Me.ColDtType.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColDtType.AppearanceHeader.Options.UseFont = True
        Me.ColDtType.Caption = "DtType"
        Me.ColDtType.FieldName = "DtType"
        Me.ColDtType.Name = "ColDtType"
        '
        'colUnitName
        '
        Me.colUnitName.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colUnitName.AppearanceCell.Options.UseFont = True
        Me.colUnitName.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colUnitName.AppearanceHeader.Options.UseFont = True
        Me.colUnitName.Caption = "UnitName"
        Me.colUnitName.FieldName = "UnitName"
        Me.colUnitName.Name = "colUnitName"
        '
        'ColLotNoHide
        '
        Me.ColLotNoHide.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColLotNoHide.AppearanceCell.Options.UseFont = True
        Me.ColLotNoHide.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColLotNoHide.AppearanceHeader.Options.UseFont = True
        Me.ColLotNoHide.Caption = "LotNoHide"
        Me.ColLotNoHide.FieldName = "LotNoHide"
        Me.ColLotNoHide.Name = "ColLotNoHide"
        '
        'ColidWhHide
        '
        Me.ColidWhHide.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColidWhHide.AppearanceCell.Options.UseFont = True
        Me.ColidWhHide.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColidWhHide.AppearanceHeader.Options.UseFont = True
        Me.ColidWhHide.Caption = "idWhHide"
        Me.ColidWhHide.FieldName = "idWhHide"
        Me.ColidWhHide.Name = "ColidWhHide"
        '
        'ColidLotHide
        '
        Me.ColidLotHide.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColidLotHide.AppearanceCell.Options.UseFont = True
        Me.ColidLotHide.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColidLotHide.AppearanceHeader.Options.UseFont = True
        Me.ColidLotHide.Caption = "idLotHide"
        Me.ColidLotHide.FieldName = "idLotHide"
        Me.ColidLotHide.Name = "ColidLotHide"
        '
        'colidRefLot
        '
        Me.colidRefLot.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colidRefLot.AppearanceCell.Options.UseFont = True
        Me.colidRefLot.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colidRefLot.AppearanceHeader.Options.UseFont = True
        Me.colidRefLot.Caption = "idRefLot"
        Me.colidRefLot.FieldName = "idRefLot"
        Me.colidRefLot.Name = "colidRefLot"
        '
        'stCutStock
        '
        Me.stCutStock.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stCutStock.AppearanceCell.Options.UseFont = True
        Me.stCutStock.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stCutStock.AppearanceHeader.Options.UseFont = True
        Me.stCutStock.Caption = "stCutStock"
        Me.stCutStock.FieldName = "stCutStock"
        Me.stCutStock.Name = "stCutStock"
        '
        'colpWeight
        '
        Me.colpWeight.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colpWeight.AppearanceCell.Options.UseFont = True
        Me.colpWeight.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colpWeight.AppearanceHeader.Options.UseFont = True
        Me.colpWeight.Caption = "pWeight"
        Me.colpWeight.FieldName = "pWeight"
        Me.colpWeight.Name = "colpWeight"
        '
        'ColidUnitW
        '
        Me.ColidUnitW.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColidUnitW.AppearanceCell.Options.UseFont = True
        Me.ColidUnitW.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColidUnitW.AppearanceHeader.Options.UseFont = True
        Me.ColidUnitW.Caption = "idUnitW"
        Me.ColidUnitW.FieldName = "idUnitW"
        Me.ColidUnitW.Name = "ColidUnitW"
        '
        'rptLotNo
        '
        Me.rptLotNo.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.[True]
        Me.rptLotNo.AutoHeight = False
        Me.rptLotNo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Global.SAM.My.Resources.Resources.search_png_16x16, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject10, "", Nothing, Nothing, True)})
        Me.rptLotNo.LinkColorUseParentAppearance = True
        Me.rptLotNo.Name = "rptLotNo"
        Me.rptLotNo.NullText = "Lot"
        Me.rptLotNo.SingleClick = True
        Me.rptLotNo.StartKey = New DevExpress.Utils.KeyShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F))
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "arrow_refresh.png")
        Me.ImageList1.Images.SetKeyName(1, "blank.gif")
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'PanelControl1
        '
        Me.PanelControl1.Appearance.BackColor = System.Drawing.Color.Lavender
        Me.PanelControl1.Appearance.BackColor2 = System.Drawing.Color.LightSteelBlue
        Me.PanelControl1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.PanelControl1.Appearance.Options.UseBackColor = True
        Me.PanelControl1.Appearance.Options.UseFont = True
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.Label17)
        Me.PanelControl1.Controls.Add(Me.GroupBox1)
        Me.PanelControl1.Controls.Add(Me.GBDiscount)
        Me.PanelControl1.Controls.Add(Me.btnFindOrder)
        Me.PanelControl1.Controls.Add(Me.txtTotalBFDisc)
        Me.PanelControl1.Controls.Add(Me.Label2)
        Me.PanelControl1.Controls.Add(Me.TextBox1)
        Me.PanelControl1.Controls.Add(Me.Panel4)
        Me.PanelControl1.Controls.Add(Me.Label12)
        Me.PanelControl1.Controls.Add(Me.GroupBox3)
        Me.PanelControl1.Controls.Add(Me.GroupBox4)
        Me.PanelControl1.Controls.Add(Me.Label8)
        Me.PanelControl1.Controls.Add(Me.txtTotalNet)
        Me.PanelControl1.Controls.Add(Me.GroupBox6)
        Me.PanelControl1.Controls.Add(Me.GroupBox9)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1184, 287)
        Me.PanelControl1.TabIndex = 736
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(621, 258)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(65, 14)
        Me.Label17.TabIndex = 979
        Me.Label17.Text = "ต่อเนื่องจาก"
        Me.Label17.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GroupBox1.Controls.Add(Me.lblPsOrder)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.btnPsOrder)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(628, 189)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(264, 44)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'lblPsOrder
        '
        Me.lblPsOrder.BackColor = System.Drawing.Color.Gainsboro
        Me.lblPsOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPsOrder.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblPsOrder.Location = New System.Drawing.Point(48, 13)
        Me.lblPsOrder.Name = "lblPsOrder"
        Me.lblPsOrder.Size = New System.Drawing.Size(181, 23)
        Me.lblPsOrder.TabIndex = 635
        Me.lblPsOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label19.Location = New System.Drawing.Point(4, 16)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(42, 14)
        Me.Label19.TabIndex = 974
        Me.Label19.Text = "ชื่อผู้สั่ง"
        '
        'btnPsOrder
        '
        Me.btnPsOrder.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnPsOrder.Appearance.Options.UseFont = True
        Me.btnPsOrder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPsOrder.Image = CType(resources.GetObject("btnPsOrder.Image"), System.Drawing.Image)
        Me.btnPsOrder.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnPsOrder.Location = New System.Drawing.Point(231, 14)
        Me.btnPsOrder.Name = "btnPsOrder"
        Me.btnPsOrder.Size = New System.Drawing.Size(25, 22)
        Me.btnPsOrder.TabIndex = 5
        '
        'GBDiscount
        '
        Me.GBDiscount.BackColor = System.Drawing.Color.Transparent
        Me.GBDiscount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GBDiscount.Controls.Add(Me.Label9)
        Me.GBDiscount.Controls.Add(Me.txtDiscBath)
        Me.GBDiscount.Controls.Add(Me.lblPerc)
        Me.GBDiscount.Controls.Add(Me.Label4)
        Me.GBDiscount.Controls.Add(Me.txtAmtPerc)
        Me.GBDiscount.Controls.Add(Me.rdbBathDisc)
        Me.GBDiscount.Controls.Add(Me.rdbPerDisc)
        Me.GBDiscount.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GBDiscount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GBDiscount.Location = New System.Drawing.Point(908, 36)
        Me.GBDiscount.Name = "GBDiscount"
        Me.GBDiscount.Size = New System.Drawing.Size(269, 74)
        Me.GBDiscount.TabIndex = 6
        Me.GBDiscount.TabStop = False
        Me.GBDiscount.Text = "การให้ส่วนลด"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(149, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 14)
        Me.Label4.TabIndex = 600
        Me.Label4.Text = "% ="
        '
        'txtAmtPerc
        '
        Me.txtAmtPerc.BackColor = System.Drawing.Color.White
        Me.txtAmtPerc.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtAmtPerc.ForeColor = System.Drawing.Color.Black
        Me.txtAmtPerc.Location = New System.Drawing.Point(104, 23)
        Me.txtAmtPerc.MaxLength = 3
        Me.txtAmtPerc.Name = "txtAmtPerc"
        Me.txtAmtPerc.Size = New System.Drawing.Size(38, 22)
        Me.txtAmtPerc.TabIndex = 3
        Me.txtAmtPerc.Text = "0"
        Me.txtAmtPerc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'rdbBathDisc
        '
        Me.rdbBathDisc.AutoSize = True
        Me.rdbBathDisc.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rdbBathDisc.Location = New System.Drawing.Point(16, 49)
        Me.rdbBathDisc.Name = "rdbBathDisc"
        Me.rdbBathDisc.Size = New System.Drawing.Size(105, 18)
        Me.rdbBathDisc.TabIndex = 2
        Me.rdbBathDisc.Text = "ให้ส่วนลดจำนวน"
        Me.rdbBathDisc.UseVisualStyleBackColor = True
        '
        'rdbPerDisc
        '
        Me.rdbPerDisc.AutoSize = True
        Me.rdbPerDisc.Checked = True
        Me.rdbPerDisc.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rdbPerDisc.Location = New System.Drawing.Point(16, 25)
        Me.rdbPerDisc.Name = "rdbPerDisc"
        Me.rdbPerDisc.Size = New System.Drawing.Size(88, 18)
        Me.rdbPerDisc.TabIndex = 1
        Me.rdbPerDisc.TabStop = True
        Me.rdbPerDisc.Text = "ให้ส่วนลด %"
        Me.rdbPerDisc.UseVisualStyleBackColor = True
        '
        'btnFindOrder
        '
        Me.btnFindOrder.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnFindOrder.Appearance.Options.UseFont = True
        Me.btnFindOrder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFindOrder.Image = CType(resources.GetObject("btnFindOrder.Image"), System.Drawing.Image)
        Me.btnFindOrder.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnFindOrder.Location = New System.Drawing.Point(859, 244)
        Me.btnFindOrder.Name = "btnFindOrder"
        Me.btnFindOrder.Size = New System.Drawing.Size(25, 22)
        Me.btnFindOrder.TabIndex = 981
        Me.btnFindOrder.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.TextBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TextBox1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(690, 244)
        Me.TextBox1.MaxLength = 9
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(167, 22)
        Me.TextBox1.TabIndex = 980
        Me.TextBox1.Visible = False
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.gcNote)
        Me.Panel4.Location = New System.Drawing.Point(898, 150)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(277, 127)
        Me.Panel4.TabIndex = 7
        '
        'gcNote
        '
        Me.gcNote.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcNote.Location = New System.Drawing.Point(0, 0)
        Me.gcNote.MainView = Me.gvNote
        Me.gcNote.Name = "gcNote"
        Me.gcNote.Size = New System.Drawing.Size(277, 127)
        Me.gcNote.TabIndex = 4
        Me.gcNote.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvNote})
        '
        'gvNote
        '
        Me.gvNote.Appearance.FocusedCell.BackColor = System.Drawing.Color.LemonChiffon
        Me.gvNote.Appearance.FocusedCell.Options.UseBackColor = True
        Me.gvNote.Appearance.FocusedRow.BackColor = System.Drawing.Color.LemonChiffon
        Me.gvNote.Appearance.FocusedRow.Options.UseBackColor = True
        Me.gvNote.ColumnPanelRowHeight = 10
        Me.gvNote.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNote})
        Me.gvNote.GridControl = Me.gcNote
        Me.gvNote.Name = "gvNote"
        Me.gvNote.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.gvNote.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseUp
        Me.gvNote.OptionsNavigation.AutoFocusNewRow = True
        Me.gvNote.OptionsNavigation.UseTabKey = False
        Me.gvNote.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.gvNote.OptionsView.RowAutoHeight = True
        Me.gvNote.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.gvNote.OptionsView.ShowGroupPanel = False
        Me.gvNote.OptionsView.ShowIndicator = False
        '
        'colNote
        '
        Me.colNote.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colNote.AppearanceHeader.Options.UseFont = True
        Me.colNote.AppearanceHeader.Options.UseTextOptions = True
        Me.colNote.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNote.Caption = "หมายเหตุ"
        Me.colNote.FieldName = "Note"
        Me.colNote.Name = "colNote"
        Me.colNote.Visible = True
        Me.colNote.VisibleIndex = 0
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(645, 244)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(42, 14)
        Me.Label12.TabIndex = 978
        Me.Label12.Text = "บิลขาย"
        Me.Label12.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.btnTspComp)
        Me.GroupBox3.Controls.Add(Me.btnAddressS)
        Me.GroupBox3.Controls.Add(Me.btnSale)
        Me.GroupBox3.Controls.Add(Me.btnCustomer)
        Me.GroupBox3.Controls.Add(Me.lblTspComp)
        Me.GroupBox3.Controls.Add(Me.lblCusNote)
        Me.GroupBox3.Controls.Add(Me.Label56)
        Me.GroupBox3.Controls.Add(Me.Label54)
        Me.GroupBox3.Controls.Add(Me.cmbTypePayTrp)
        Me.GroupBox3.Controls.Add(Me.lblAddr)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.CmbTs)
        Me.GroupBox3.Controls.Add(Me.lblTS)
        Me.GroupBox3.Controls.Add(Me.lblCusRec)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label40)
        Me.GroupBox3.Controls.Add(Me.lblPsSale)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.lblPsCus)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(6, 95)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(616, 185)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        '
        'btnTspComp
        '
        Me.btnTspComp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTspComp.Image = CType(resources.GetObject("btnTspComp.Image"), System.Drawing.Image)
        Me.btnTspComp.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnTspComp.Location = New System.Drawing.Point(584, 134)
        Me.btnTspComp.Name = "btnTspComp"
        Me.btnTspComp.Size = New System.Drawing.Size(25, 22)
        Me.btnTspComp.TabIndex = 5
        '
        'btnAddressS
        '
        Me.btnAddressS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddressS.Image = CType(resources.GetObject("btnAddressS.Image"), System.Drawing.Image)
        Me.btnAddressS.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnAddressS.Location = New System.Drawing.Point(582, 15)
        Me.btnAddressS.Name = "btnAddressS"
        Me.btnAddressS.Size = New System.Drawing.Size(25, 22)
        Me.btnAddressS.TabIndex = 3
        '
        'btnSale
        '
        Me.btnSale.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnSale.Appearance.Options.UseFont = True
        Me.btnSale.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSale.Image = CType(resources.GetObject("btnSale.Image"), System.Drawing.Image)
        Me.btnSale.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnSale.Location = New System.Drawing.Point(259, 136)
        Me.btnSale.Name = "btnSale"
        Me.btnSale.Size = New System.Drawing.Size(25, 22)
        Me.btnSale.TabIndex = 2
        '
        'btnCustomer
        '
        Me.btnCustomer.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnCustomer.Appearance.Options.UseFont = True
        Me.btnCustomer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCustomer.Image = CType(resources.GetObject("btnCustomer.Image"), System.Drawing.Image)
        Me.btnCustomer.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnCustomer.Location = New System.Drawing.Point(275, 16)
        Me.btnCustomer.Name = "btnCustomer"
        Me.btnCustomer.Size = New System.Drawing.Size(25, 22)
        Me.btnCustomer.TabIndex = 0
        '
        'lblTspComp
        '
        Me.lblTspComp.BackColor = System.Drawing.Color.Gainsboro
        Me.lblTspComp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTspComp.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblTspComp.Location = New System.Drawing.Point(399, 132)
        Me.lblTspComp.Name = "lblTspComp"
        Me.lblTspComp.Size = New System.Drawing.Size(183, 20)
        Me.lblTspComp.TabIndex = 634
        Me.lblTspComp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCusNote
        '
        Me.lblCusNote.BackColor = System.Drawing.Color.Lavender
        Me.lblCusNote.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblCusNote.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblCusNote.ForeColor = System.Drawing.Color.Red
        Me.lblCusNote.Location = New System.Drawing.Point(72, 65)
        Me.lblCusNote.Multiline = True
        Me.lblCusNote.Name = "lblCusNote"
        Me.lblCusNote.ReadOnly = True
        Me.lblCusNote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.lblCusNote.Size = New System.Drawing.Size(201, 65)
        Me.lblCusNote.TabIndex = 1
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label56.Location = New System.Drawing.Point(333, 134)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(65, 14)
        Me.Label56.TabIndex = 633
        Me.Label56.Text = "บริษัทขนส่ง"
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label54.Location = New System.Drawing.Point(294, 158)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(102, 14)
        Me.Label54.TabIndex = 630
        Me.Label54.Text = "การจ่ายเงินค่าขนส่ง"
        '
        'cmbTypePayTrp
        '
        Me.cmbTypePayTrp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTypePayTrp.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmbTypePayTrp.FormattingEnabled = True
        Me.cmbTypePayTrp.Location = New System.Drawing.Point(399, 155)
        Me.cmbTypePayTrp.Name = "cmbTypePayTrp"
        Me.cmbTypePayTrp.Size = New System.Drawing.Size(209, 22)
        Me.cmbTypePayTrp.TabIndex = 6
        '
        'lblAddr
        '
        Me.lblAddr.BackColor = System.Drawing.Color.Gainsboro
        Me.lblAddr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAddr.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblAddr.Location = New System.Drawing.Point(399, 43)
        Me.lblAddr.Name = "lblAddr"
        Me.lblAddr.Size = New System.Drawing.Size(209, 59)
        Me.lblAddr.TabIndex = 615
        Me.lblAddr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label14.Location = New System.Drawing.Point(353, 19)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(42, 14)
        Me.Label14.TabIndex = 617
        Me.Label14.Text = "ชื่อผู้รับ"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label16.Location = New System.Drawing.Point(10, 66)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(54, 14)
        Me.Label16.TabIndex = 621
        Me.Label16.Text = "หมายเหตุ"
        '
        'CmbTs
        '
        Me.CmbTs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbTs.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.CmbTs.FormattingEnabled = True
        Me.CmbTs.Location = New System.Drawing.Point(399, 106)
        Me.CmbTs.Name = "CmbTs"
        Me.CmbTs.Size = New System.Drawing.Size(209, 22)
        Me.CmbTs.TabIndex = 4
        '
        'lblTS
        '
        Me.lblTS.AutoSize = True
        Me.lblTS.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblTS.Location = New System.Drawing.Point(323, 109)
        Me.lblTS.Name = "lblTS"
        Me.lblTS.Size = New System.Drawing.Size(72, 14)
        Me.lblTS.TabIndex = 596
        Me.lblTS.Text = "ประเภทขนส่ง"
        '
        'lblCusRec
        '
        Me.lblCusRec.BackColor = System.Drawing.Color.Gainsboro
        Me.lblCusRec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCusRec.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblCusRec.Location = New System.Drawing.Point(399, 15)
        Me.lblCusRec.Name = "lblCusRec"
        Me.lblCusRec.Size = New System.Drawing.Size(181, 23)
        Me.lblCusRec.TabIndex = 616
        Me.lblCusRec.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(19, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 14)
        Me.Label5.TabIndex = 620
        Me.Label5.Text = "ลูกค้า"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label40.Location = New System.Drawing.Point(338, 43)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(57, 14)
        Me.Label40.TabIndex = 614
        Me.Label40.Text = "ที่อยู่จัดส่ง"
        '
        'lblPsSale
        '
        Me.lblPsSale.BackColor = System.Drawing.Color.Gainsboro
        Me.lblPsSale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPsSale.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblPsSale.Location = New System.Drawing.Point(76, 136)
        Me.lblPsSale.Name = "lblPsSale"
        Me.lblPsSale.Size = New System.Drawing.Size(181, 23)
        Me.lblPsSale.TabIndex = 586
        Me.lblPsSale.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label15.Location = New System.Drawing.Point(-2, 138)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(74, 14)
        Me.Label15.TabIndex = 585
        Me.Label15.Text = "เจ้าหน้าที่ขาย"
        '
        'lblPsCus
        '
        Me.lblPsCus.BackColor = System.Drawing.Color.Gainsboro
        Me.lblPsCus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPsCus.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblPsCus.Location = New System.Drawing.Point(72, 16)
        Me.lblPsCus.Name = "lblPsCus"
        Me.lblPsCus.Size = New System.Drawing.Size(201, 45)
        Me.lblPsCus.TabIndex = 583
        Me.lblPsCus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(33, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 14)
        Me.Label6.TabIndex = 582
        Me.Label6.Text = "ลูกค้า"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GroupBox4.Controls.Add(Me.rdbBill)
        Me.GroupBox4.Controls.Add(Me.rdbWhole)
        Me.GroupBox4.Controls.Add(Me.rdbRetail)
        Me.GroupBox4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox4.Location = New System.Drawing.Point(628, 8)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(264, 56)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "การให้ราคาบิลนี้"
        '
        'rdbBill
        '
        Me.rdbBill.AutoSize = True
        Me.rdbBill.Checked = True
        Me.rdbBill.Location = New System.Drawing.Point(91, 23)
        Me.rdbBill.Name = "rdbBill"
        Me.rdbBill.Size = New System.Drawing.Size(90, 18)
        Me.rdbBill.TabIndex = 1
        Me.rdbBill.TabStop = True
        Me.rdbBill.Text = "ราคาหน้าบิล"
        Me.rdbBill.UseVisualStyleBackColor = True
        '
        'rdbWhole
        '
        Me.rdbWhole.AutoSize = True
        Me.rdbWhole.Location = New System.Drawing.Point(22, 23)
        Me.rdbWhole.Name = "rdbWhole"
        Me.rdbWhole.Size = New System.Drawing.Size(66, 18)
        Me.rdbWhole.TabIndex = 0
        Me.rdbWhole.TabStop = True
        Me.rdbWhole.Text = "ราคาส่ง"
        Me.rdbWhole.UseVisualStyleBackColor = True
        '
        'rdbRetail
        '
        Me.rdbRetail.AutoSize = True
        Me.rdbRetail.Location = New System.Drawing.Point(187, 23)
        Me.rdbRetail.Name = "rdbRetail"
        Me.rdbRetail.Size = New System.Drawing.Size(75, 18)
        Me.rdbRetail.TabIndex = 2
        Me.rdbRetail.TabStop = True
        Me.rdbRetail.Text = "ราคาปลีก"
        Me.rdbRetail.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(905, 124)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 14)
        Me.Label8.TabIndex = 579
        Me.Label8.Text = "รวมเป็นเงินสุทธิ"
        '
        'txtTotalNet
        '
        Me.txtTotalNet.BackColor = System.Drawing.Color.Black
        Me.txtTotalNet.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTotalNet.ForeColor = System.Drawing.Color.Lime
        Me.txtTotalNet.Location = New System.Drawing.Point(996, 118)
        Me.txtTotalNet.Name = "txtTotalNet"
        Me.txtTotalNet.ReadOnly = True
        Me.txtTotalNet.Size = New System.Drawing.Size(175, 27)
        Me.txtTotalNet.TabIndex = 578
        Me.txtTotalNet.TabStop = False
        Me.txtTotalNet.Text = "0"
        Me.txtTotalNet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox6.Controls.Add(Me.Label18)
        Me.GroupBox6.Controls.Add(Me.rdbRight)
        Me.GroupBox6.Controls.Add(Me.Label11)
        Me.GroupBox6.Controls.Add(Me.rdbNoRight)
        Me.GroupBox6.Controls.Add(Me.btnRefDoc)
        Me.GroupBox6.Controls.Add(Me.lblRefAcc)
        Me.GroupBox6.Controls.Add(Me.cmbGroupComp)
        Me.GroupBox6.Controls.Add(Me.Label38)
        Me.GroupBox6.Controls.Add(Me.Label24)
        Me.GroupBox6.Controls.Add(Me.lblDocCode)
        Me.GroupBox6.Controls.Add(Me.Label1)
        Me.GroupBox6.Controls.Add(Me.dtpSale)
        Me.GroupBox6.Controls.Add(Me.cmbDRCode)
        Me.GroupBox6.Controls.Add(Me.txtDocRef)
        Me.GroupBox6.Controls.Add(Me.Label10)
        Me.GroupBox6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(6, 3)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(616, 92)
        Me.GroupBox6.TabIndex = 0
        Me.GroupBox6.TabStop = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label18.Location = New System.Drawing.Point(324, 71)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(71, 14)
        Me.Label18.TabIndex = 969
        Me.Label18.Text = "หลักสรรพากร"
        '
        'rdbRight
        '
        Me.rdbRight.AutoSize = True
        Me.rdbRight.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rdbRight.Location = New System.Drawing.Point(399, 69)
        Me.rdbRight.Name = "rdbRight"
        Me.rdbRight.Size = New System.Drawing.Size(61, 18)
        Me.rdbRight.TabIndex = 5
        Me.rdbRight.TabStop = True
        Me.rdbRight.Text = "ถูกหลัก"
        Me.rdbRight.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label11.Location = New System.Drawing.Point(325, 20)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(70, 14)
        Me.Label11.TabIndex = 558
        Me.Label11.Text = "เลขที่รายการ"
        '
        'rdbNoRight
        '
        Me.rdbNoRight.AutoSize = True
        Me.rdbNoRight.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rdbNoRight.Location = New System.Drawing.Point(477, 69)
        Me.rdbNoRight.Name = "rdbNoRight"
        Me.rdbNoRight.Size = New System.Drawing.Size(74, 18)
        Me.rdbNoRight.TabIndex = 6
        Me.rdbNoRight.TabStop = True
        Me.rdbNoRight.Text = "ไม่ถูกหลัก"
        Me.rdbNoRight.UseVisualStyleBackColor = True
        '
        'btnRefDoc
        '
        Me.btnRefDoc.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnRefDoc.Appearance.Options.UseFont = True
        Me.btnRefDoc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefDoc.Image = CType(resources.GetObject("btnRefDoc.Image"), System.Drawing.Image)
        Me.btnRefDoc.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnRefDoc.Location = New System.Drawing.Point(275, 40)
        Me.btnRefDoc.Name = "btnRefDoc"
        Me.btnRefDoc.Size = New System.Drawing.Size(25, 22)
        Me.btnRefDoc.TabIndex = 635
        '
        'lblRefAcc
        '
        Me.lblRefAcc.BackColor = System.Drawing.Color.Gainsboro
        Me.lblRefAcc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRefAcc.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblRefAcc.Location = New System.Drawing.Point(399, 42)
        Me.lblRefAcc.Name = "lblRefAcc"
        Me.lblRefAcc.Size = New System.Drawing.Size(210, 20)
        Me.lblRefAcc.TabIndex = 616
        Me.lblRefAcc.Text = "- - - - - - - - - - "
        Me.lblRefAcc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbGroupComp
        '
        Me.cmbGroupComp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGroupComp.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmbGroupComp.FormattingEnabled = True
        Me.cmbGroupComp.Location = New System.Drawing.Point(76, 14)
        Me.cmbGroupComp.Name = "cmbGroupComp"
        Me.cmbGroupComp.Size = New System.Drawing.Size(224, 22)
        Me.cmbGroupComp.TabIndex = 0
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label38.ForeColor = System.Drawing.Color.Black
        Me.Label38.Location = New System.Drawing.Point(315, 45)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(81, 14)
        Me.Label38.TabIndex = 596
        Me.Label38.Text = "เลขที่ทางบัญชี"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(9, 42)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(66, 14)
        Me.Label24.TabIndex = 576
        Me.Label24.Text = "เลขที่อ้างอิง"
        '
        'lblDocCode
        '
        Me.lblDocCode.BackColor = System.Drawing.Color.Gainsboro
        Me.lblDocCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDocCode.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblDocCode.Location = New System.Drawing.Point(399, 17)
        Me.lblDocCode.Name = "lblDocCode"
        Me.lblDocCode.Size = New System.Drawing.Size(208, 20)
        Me.lblDocCode.TabIndex = 561
        Me.lblDocCode.Text = "- - - - - - - - - - "
        Me.lblDocCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 14)
        Me.Label1.TabIndex = 421
        Me.Label1.Text = "วันที่ขาย"
        '
        'dtpSale
        '
        Me.dtpSale.CustomFormat = "ddMMMMyyyy"
        Me.dtpSale.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpSale.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpSale.Location = New System.Drawing.Point(76, 65)
        Me.dtpSale.Name = "dtpSale"
        Me.dtpSale.Size = New System.Drawing.Size(153, 22)
        Me.dtpSale.TabIndex = 4
        '
        'cmbDRCode
        '
        Me.cmbDRCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDRCode.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmbDRCode.FormattingEnabled = True
        Me.cmbDRCode.Location = New System.Drawing.Point(76, 39)
        Me.cmbDRCode.Name = "cmbDRCode"
        Me.cmbDRCode.Size = New System.Drawing.Size(54, 22)
        Me.cmbDRCode.TabIndex = 1
        '
        'txtDocRef
        '
        Me.txtDocRef.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtDocRef.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtDocRef.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtDocRef.Location = New System.Drawing.Point(133, 40)
        Me.txtDocRef.MaxLength = 9
        Me.txtDocRef.Name = "txtDocRef"
        Me.txtDocRef.Size = New System.Drawing.Size(140, 22)
        Me.txtDocRef.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.Location = New System.Drawing.Point(32, 17)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(38, 14)
        Me.Label10.TabIndex = 967
        Me.Label10.Text = "บริษัท"
        '
        'GroupBox9
        '
        Me.GroupBox9.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GroupBox9.Controls.Add(Me.txtPrePay)
        Me.GroupBox9.Controls.Add(Me.Label13)
        Me.GroupBox9.Controls.Add(Me.txtPercP)
        Me.GroupBox9.Controls.Add(Me.Label7)
        Me.GroupBox9.Controls.Add(Me.cmbTp)
        Me.GroupBox9.Controls.Add(Me.Label21)
        Me.GroupBox9.Controls.Add(Me.dtpPay)
        Me.GroupBox9.Controls.Add(Me.Label3)
        Me.GroupBox9.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox9.Location = New System.Drawing.Point(628, 72)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(264, 117)
        Me.GroupBox9.TabIndex = 3
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "การชำระเงินบิลนี้"
        '
        'txtPrePay
        '
        Me.txtPrePay.BackColor = System.Drawing.Color.Gainsboro
        Me.txtPrePay.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPrePay.ForeColor = System.Drawing.Color.Black
        Me.txtPrePay.Location = New System.Drawing.Point(174, 51)
        Me.txtPrePay.Name = "txtPrePay"
        Me.txtPrePay.ReadOnly = True
        Me.txtPrePay.Size = New System.Drawing.Size(85, 22)
        Me.txtPrePay.TabIndex = 599
        Me.txtPrePay.TabStop = False
        Me.txtPrePay.Text = "0"
        Me.txtPrePay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label13.Location = New System.Drawing.Point(145, 54)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(32, 14)
        Me.Label13.TabIndex = 598
        Me.Label13.Text = "% ="
        '
        'txtPercP
        '
        Me.txtPercP.BackColor = System.Drawing.Color.White
        Me.txtPercP.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPercP.ForeColor = System.Drawing.Color.Black
        Me.txtPercP.Location = New System.Drawing.Point(88, 50)
        Me.txtPercP.MaxLength = 3
        Me.txtPercP.Name = "txtPercP"
        Me.txtPercP.ReadOnly = True
        Me.txtPercP.Size = New System.Drawing.Size(56, 22)
        Me.txtPercP.TabIndex = 1
        Me.txtPercP.Text = "0"
        Me.txtPercP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(34, 52)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 14)
        Me.Label7.TabIndex = 596
        Me.Label7.Text = "เงินมัดจำ"
        '
        'cmbTp
        '
        Me.cmbTp.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbTp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTp.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmbTp.FormattingEnabled = True
        Me.cmbTp.Location = New System.Drawing.Point(87, 21)
        Me.cmbTp.Name = "cmbTp"
        Me.cmbTp.Size = New System.Drawing.Size(172, 22)
        Me.cmbTp.TabIndex = 0
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label21.Location = New System.Drawing.Point(17, 24)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(68, 14)
        Me.Label21.TabIndex = 594
        Me.Label21.Text = "เงื่อนไขชำระ"
        '
        'dtpPay
        '
        Me.dtpPay.CustomFormat = "ddMMMMyyyy"
        Me.dtpPay.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpPay.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpPay.Location = New System.Drawing.Point(88, 80)
        Me.dtpPay.Name = "dtpPay"
        Me.dtpPay.Size = New System.Drawing.Size(171, 22)
        Me.dtpPay.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(21, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 14)
        Me.Label3.TabIndex = 569
        Me.Label3.Text = "วันที่จ่ายเงิน"
        '
        'PriceSaleHide
        '
        Me.PriceSaleHide.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PriceSaleHide.AppearanceCell.Options.UseFont = True
        Me.PriceSaleHide.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PriceSaleHide.AppearanceHeader.Options.UseFont = True
        Me.PriceSaleHide.Caption = "PriceSaleHide"
        Me.PriceSaleHide.FieldName = "PriceSaleHide"
        Me.PriceSaleHide.Name = "PriceSaleHide"
        '
        'idInvMainHide
        '
        Me.idInvMainHide.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idInvMainHide.AppearanceCell.Options.UseFont = True
        Me.idInvMainHide.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idInvMainHide.AppearanceHeader.Options.UseFont = True
        Me.idInvMainHide.Caption = "idInvMainHide"
        Me.idInvMainHide.FieldName = "idInvMainHide"
        Me.idInvMainHide.Name = "idInvMainHide"
        '
        'Img1
        '
        Me.Img1.ImageStream = CType(resources.GetObject("Img1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.Img1.TransparentColor = System.Drawing.Color.Transparent
        Me.Img1.Images.SetKeyName(0, "JPG_icon.jpg")
        '
        'GCSale
        '
        Me.GCSale.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCSale.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GCSale.Location = New System.Drawing.Point(0, 287)
        Me.GCSale.MainView = Me.DGVBind
        Me.GCSale.Name = "GCSale"
        Me.GCSale.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rptDel, Me.rptCheckPrice, Me.rptUnit, Me.rptLotNo, Me.rptProductName, Me.rptPdCode, Me.rptChx, Me.rpttxtLotNo})
        Me.GCSale.Size = New System.Drawing.Size(1184, 237)
        Me.GCSale.TabIndex = 737
        Me.GCSale.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.DGVBind})
        '
        'DGVBind
        '
        Me.DGVBind.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.DGVBind.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.DGVBind.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DGVBind.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.DGVBind.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.DGVBind.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.DGVBind.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.DGVBind.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.DGVBind.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DGVBind.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.DGVBind.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.DGVBind.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.DGVBind.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DGVBind.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.DGVBind.Appearance.Empty.Options.UseBackColor = True
        Me.DGVBind.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.DGVBind.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.DGVBind.Appearance.EvenRow.Options.UseBackColor = True
        Me.DGVBind.Appearance.EvenRow.Options.UseForeColor = True
        Me.DGVBind.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.DGVBind.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.DGVBind.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DGVBind.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.DGVBind.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.DGVBind.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.DGVBind.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DGVBind.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.DGVBind.Appearance.FilterPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.DGVBind.Appearance.FilterPanel.Options.UseBackColor = True
        Me.DGVBind.Appearance.FilterPanel.Options.UseForeColor = True
        Me.DGVBind.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.DGVBind.Appearance.FixedLine.Options.UseBackColor = True
        Me.DGVBind.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.DGVBind.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.DGVBind.Appearance.FocusedCell.Options.UseBackColor = True
        Me.DGVBind.Appearance.FocusedCell.Options.UseForeColor = True
        Me.DGVBind.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.DGVBind.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.DGVBind.Appearance.FocusedRow.Options.UseBackColor = True
        Me.DGVBind.Appearance.FocusedRow.Options.UseForeColor = True
        Me.DGVBind.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.DGVBind.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.DGVBind.Appearance.FooterPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DGVBind.Appearance.FooterPanel.Options.UseBackColor = True
        Me.DGVBind.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.DGVBind.Appearance.FooterPanel.Options.UseForeColor = True
        Me.DGVBind.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.DGVBind.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.DGVBind.Appearance.GroupButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DGVBind.Appearance.GroupButton.Options.UseBackColor = True
        Me.DGVBind.Appearance.GroupButton.Options.UseBorderColor = True
        Me.DGVBind.Appearance.GroupButton.Options.UseForeColor = True
        Me.DGVBind.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.DGVBind.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.DGVBind.Appearance.GroupFooter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DGVBind.Appearance.GroupFooter.Options.UseBackColor = True
        Me.DGVBind.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.DGVBind.Appearance.GroupFooter.Options.UseForeColor = True
        Me.DGVBind.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DGVBind.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.DGVBind.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.DGVBind.Appearance.GroupPanel.Options.UseBackColor = True
        Me.DGVBind.Appearance.GroupPanel.Options.UseForeColor = True
        Me.DGVBind.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.DGVBind.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.DGVBind.Appearance.GroupRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DGVBind.Appearance.GroupRow.Options.UseBackColor = True
        Me.DGVBind.Appearance.GroupRow.Options.UseBorderColor = True
        Me.DGVBind.Appearance.GroupRow.Options.UseForeColor = True
        Me.DGVBind.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.DGVBind.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.DGVBind.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DGVBind.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.DGVBind.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.DGVBind.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.DGVBind.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.DGVBind.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DGVBind.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.DGVBind.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.DGVBind.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.DGVBind.Appearance.HorzLine.Options.UseBackColor = True
        Me.DGVBind.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.DGVBind.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.DGVBind.Appearance.OddRow.Options.UseBackColor = True
        Me.DGVBind.Appearance.OddRow.Options.UseForeColor = True
        Me.DGVBind.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.DGVBind.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.DGVBind.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.DGVBind.Appearance.Preview.Options.UseBackColor = True
        Me.DGVBind.Appearance.Preview.Options.UseFont = True
        Me.DGVBind.Appearance.Preview.Options.UseForeColor = True
        Me.DGVBind.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.DGVBind.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.DGVBind.Appearance.Row.Options.UseBackColor = True
        Me.DGVBind.Appearance.Row.Options.UseForeColor = True
        Me.DGVBind.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DGVBind.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.DGVBind.Appearance.RowSeparator.Options.UseBackColor = True
        Me.DGVBind.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.DGVBind.Appearance.SelectedRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DGVBind.Appearance.SelectedRow.Options.UseBackColor = True
        Me.DGVBind.Appearance.SelectedRow.Options.UseForeColor = True
        Me.DGVBind.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.DGVBind.Appearance.TopNewRow.Options.UseBackColor = True
        Me.DGVBind.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.DGVBind.Appearance.VertLine.Options.UseBackColor = True
        Me.DGVBind.ColumnPanelRowHeight = 35
        Me.DGVBind.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colidSubType, Me.AmtSaleHide, Me.ColidUnitHide, Me.PriceNormalHide, Me.PercDiscHide, Me.BathDiscHide, Me.idInvMainHide, Me.PriceSaleHide, Me.ColNum, Me.ColPdCode, Me.ColLot, Me.ColCodeOrder, Me.ColProductName, Me.ColAmtStock, Me.colAmtOrder, Me.ColAmtSale, Me.ColidUnit, Me.ColPriceNormal, Me.ColPercDiscount, Me.ColBathDiscount, Me.ColPriceSale, Me.ColWareHouseName, Me.ColChxProductName, Me.ColLastPrice, Me.ColExp, Me.ColDel, Me.Col_idSaleOrderDt, Me.Col_idSaleDt, Me.Col_OldStock, Me.Col_OldAmt, Me.Col_CompRec, Me.colidInvMain, Me.Col_idLot, Me.colidLotSPM, Me.colidInvGroup, Me.colidWh, Me.colNo, Me.colstEdit, Me.colstWIMAllRec, Me.colAmtWIMRecBal, Me.ColDtType, Me.colUnitName, Me.ColLotNoHide, Me.ColidWhHide, Me.ColidLotHide, Me.colidRefLot, Me.stCutStock, Me.colpWeight, Me.ColidUnitW})
        Me.DGVBind.GridControl = Me.GCSale
        Me.DGVBind.IndicatorWidth = 35
        Me.DGVBind.Name = "DGVBind"
        Me.DGVBind.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDown
        Me.DGVBind.OptionsCustomization.AllowSort = False
        Me.DGVBind.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.DGVBind.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.DGVBind.OptionsView.EnableAppearanceEvenRow = True
        Me.DGVBind.OptionsView.EnableAppearanceOddRow = True
        Me.DGVBind.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.DGVBind.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.DGVBind.OptionsView.ShowGroupPanel = False
        Me.DGVBind.OptionsView.ShowIndicator = False
        Me.DGVBind.PaintStyleName = "MixedXP"
        '
        'colidSubType
        '
        Me.colidSubType.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colidSubType.AppearanceCell.Options.UseFont = True
        Me.colidSubType.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colidSubType.AppearanceHeader.Options.UseFont = True
        Me.colidSubType.Caption = "idSubType"
        Me.colidSubType.FieldName = "idSubType"
        Me.colidSubType.Name = "colidSubType"
        '
        'AmtSaleHide
        '
        Me.AmtSaleHide.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AmtSaleHide.AppearanceCell.Options.UseFont = True
        Me.AmtSaleHide.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AmtSaleHide.AppearanceHeader.Options.UseFont = True
        Me.AmtSaleHide.Caption = "AmtSaleHide"
        Me.AmtSaleHide.FieldName = "AmtSaleHide"
        Me.AmtSaleHide.Name = "AmtSaleHide"
        '
        'ColidUnitHide
        '
        Me.ColidUnitHide.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColidUnitHide.AppearanceCell.Options.UseFont = True
        Me.ColidUnitHide.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColidUnitHide.AppearanceHeader.Options.UseFont = True
        Me.ColidUnitHide.Caption = "idUnitHide"
        Me.ColidUnitHide.FieldName = "idUnitHide"
        Me.ColidUnitHide.Name = "ColidUnitHide"
        '
        'PriceNormalHide
        '
        Me.PriceNormalHide.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PriceNormalHide.AppearanceCell.Options.UseFont = True
        Me.PriceNormalHide.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PriceNormalHide.AppearanceHeader.Options.UseFont = True
        Me.PriceNormalHide.Caption = "PriceNormalHide"
        Me.PriceNormalHide.FieldName = "PriceNormalHide"
        Me.PriceNormalHide.Name = "PriceNormalHide"
        '
        'PercDiscHide
        '
        Me.PercDiscHide.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PercDiscHide.AppearanceCell.Options.UseFont = True
        Me.PercDiscHide.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PercDiscHide.AppearanceHeader.Options.UseFont = True
        Me.PercDiscHide.Caption = "PercDiscHide"
        Me.PercDiscHide.FieldName = "PercDiscHide"
        Me.PercDiscHide.Name = "PercDiscHide"
        '
        'BathDiscHide
        '
        Me.BathDiscHide.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BathDiscHide.AppearanceCell.Options.UseFont = True
        Me.BathDiscHide.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BathDiscHide.AppearanceHeader.Options.UseFont = True
        Me.BathDiscHide.Caption = "BathDiscHide"
        Me.BathDiscHide.FieldName = "BathDiscHide"
        Me.BathDiscHide.Name = "BathDiscHide"
        '
        'frmSlSaleTsAll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 581)
        Me.Controls.Add(Me.GCSale)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.StatusStrip2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "frmSlSaleTsAll"
        Me.Text = "frmSlSaleTsAll"
        CType(Me.rptChx, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptCheckPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptDel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.rptPdCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpttxtLotNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptProductName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptUnit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.StatusStrip2.ResumeLayout(False)
        Me.StatusStrip2.PerformLayout()
        CType(Me.rptLotNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GBDiscount.ResumeLayout(False)
        Me.GBDiscount.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        CType(Me.gcNote, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvNote, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        CType(Me.GCSale, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVBind, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rptChx As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents rptCheckPrice As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents ColExp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rptDel As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents Col_idSaleOrderDt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Col_idSaleDt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Col_OldStock As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Col_OldAmt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Col_CompRec As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colidInvMain As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Col_idLot As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colidLotSPM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colidInvGroup As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colidWh As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColLastPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColNum As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColChxProductName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnDraft As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ColPdCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rptPdCode As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents ColLot As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rpttxtLotNo As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents ColCodeOrder As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColProductName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rptProductName As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents colstEdit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColAmtStock As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColAmtSale As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColidUnit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rptUnit As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents ColPriceNormal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColPercDiscount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColBathDiscount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColPriceSale As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAmtOrder As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColWareHouseName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colstWIMAllRec As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label9 As Label
    Friend WithEvents colAmtWIMRecBal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtTotalBFDisc As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents stLbl_DateTs As ToolStripStatusLabel
    Friend WithEvents stLbl_PsTs As ToolStripStatusLabel
    Friend WithEvents txtDiscBath As TextBox
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Panel5 As Panel
    Friend WithEvents rdbAppOK As RadioButton
    Friend WithEvents rdbAppNo As RadioButton
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label20 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnPdInc As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_img As Button
    Friend WithEvents StatusStrip2 As StatusStrip
    Friend WithEvents lblPerc As TextBox
    Friend WithEvents ColDtType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColLotNoHide As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColidWhHide As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColidLotHide As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colidRefLot As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents stCutStock As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colpWeight As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColidUnitW As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rptLotNo As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Label17 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblPsOrder As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents btnPsOrder As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GBDiscount As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtAmtPerc As TextBox
    Friend WithEvents rdbBathDisc As RadioButton
    Friend WithEvents rdbPerDisc As RadioButton
    Friend WithEvents btnFindOrder As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents gcNote As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvNote As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colNote As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label12 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnTspComp As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAddressS As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSale As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCustomer As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblTspComp As Label
    Friend WithEvents lblCusNote As TextBox
    Friend WithEvents Label56 As Label
    Friend WithEvents Label54 As Label
    Friend WithEvents cmbTypePayTrp As ComboBox
    Friend WithEvents lblAddr As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents CmbTs As ComboBox
    Friend WithEvents lblTS As Label
    Friend WithEvents lblCusRec As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents lblPsSale As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents lblPsCus As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents rdbBill As RadioButton
    Friend WithEvents rdbWhole As RadioButton
    Friend WithEvents rdbRetail As RadioButton
    Friend WithEvents Label8 As Label
    Friend WithEvents txtTotalNet As TextBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Label18 As Label
    Friend WithEvents rdbRight As RadioButton
    Friend WithEvents Label11 As Label
    Friend WithEvents rdbNoRight As RadioButton
    Friend WithEvents btnRefDoc As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblRefAcc As Label
    Friend WithEvents cmbGroupComp As ComboBox
    Friend WithEvents Label38 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents lblDocCode As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpSale As DateTimePicker
    Friend WithEvents cmbDRCode As ComboBox
    Friend WithEvents txtDocRef As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents txtPrePay As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtPercP As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cmbTp As ComboBox
    Friend WithEvents Label21 As Label
    Friend WithEvents dtpPay As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents GCSale As DevExpress.XtraGrid.GridControl
    Friend WithEvents DGVBind As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colidSubType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AmtSaleHide As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColidUnitHide As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PriceNormalHide As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PercDiscHide As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BathDiscHide As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents idInvMainHide As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PriceSaleHide As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Img1 As ImageList
End Class
