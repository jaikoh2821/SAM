<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSlSaleTsSH
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSlSaleTsSH))
        Dim GridFormatRule3 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleExpression3 As DevExpress.XtraEditors.FormatConditionRuleExpression = New DevExpress.XtraEditors.FormatConditionRuleExpression()
        Dim GridFormatRule4 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleExpression4 As DevExpress.XtraEditors.FormatConditionRuleExpression = New DevExpress.XtraEditors.FormatConditionRuleExpression()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.colstEnough = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColLotNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rpttxtLotNo = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.rdbBill = New System.Windows.Forms.RadioButton()
        Me.rdbWhole = New System.Windows.Forms.RadioButton()
        Me.rdbRetail = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtPrePay = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPercP = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmbTp = New System.Windows.Forms.ComboBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.dtpPay = New System.Windows.Forms.DateTimePicker()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.GBDiscount = New System.Windows.Forms.GroupBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtDiscBath = New System.Windows.Forms.TextBox()
        Me.lblPerc = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txtAmtPerc = New System.Windows.Forms.TextBox()
        Me.rdbBathDisc = New System.Windows.Forms.RadioButton()
        Me.rdbPerDisc = New System.Windows.Forms.RadioButton()
        Me.txtTotalBFDisc = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.gcNote = New DevExpress.XtraGrid.GridControl()
        Me.gvNote = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colNote = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.txtTotalNet = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblDocCodeSH = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblSeason = New System.Windows.Forms.Label()
        Me.lblJobNo = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.lblPSsupport = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.dtpJob = New System.Windows.Forms.DateTimePicker()
        Me.lblZone = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblSeedName = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblStrainCode = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblFarmerName = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rdbRight = New System.Windows.Forms.RadioButton()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.rdbNoRight = New System.Windows.Forms.RadioButton()
        Me.btnRefDoc = New DevExpress.XtraEditors.SimpleButton()
        Me.lblRefAcc = New System.Windows.Forms.Label()
        Me.cmbGroupComp = New System.Windows.Forms.ComboBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.dtpSale = New System.Windows.Forms.DateTimePicker()
        Me.cmbDRCode = New System.Windows.Forms.ComboBox()
        Me.txtDocRef = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.GCSale = New DevExpress.XtraGrid.GridControl()
        Me.DGVBind = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colidSubType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.AmtSaleHide = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColidUnitHide = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PriceNormalHide = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PercDiscHide = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BathDiscHide = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.idInvMainHide = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PriceSaleHide = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColNum = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColProductName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColAmtStock = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColSelLot = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rptSelLot = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.ColAmtSale = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColidUnit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rptUnit = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.ColWareHouseName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColPriceSale = New DevExpress.XtraGrid.Columns.GridColumn()
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
        Me.colstEdit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colstWIMAllRec = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAmtWIMRecBal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDtType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColLotNoHide = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColidWhHide = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColidLotHide = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidRefLot = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.StatusStrip2 = New System.Windows.Forms.StatusStrip()
        Me.stLbl_DateTs = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stLbl_PsTs = New System.Windows.Forms.ToolStripStatusLabel()
        CType(Me.rpttxtLotNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GBDiscount.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.gcNote, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvNote, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.GCSale, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVBind, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptSelLot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptUnit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptDel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'colstEnough
        '
        Me.colstEnough.Caption = "stEnough"
        Me.colstEnough.FieldName = "stEnough"
        Me.colstEnough.Name = "colstEnough"
        '
        'ColLotNo
        '
        Me.ColLotNo.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColLotNo.AppearanceCell.Options.UseFont = True
        Me.ColLotNo.AppearanceCell.Options.UseTextOptions = True
        Me.ColLotNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColLotNo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColLotNo.AppearanceHeader.Options.UseFont = True
        Me.ColLotNo.AppearanceHeader.Options.UseTextOptions = True
        Me.ColLotNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColLotNo.Caption = "Lot No."
        Me.ColLotNo.ColumnEdit = Me.rpttxtLotNo
        Me.ColLotNo.FieldName = "LotNo"
        Me.ColLotNo.MinWidth = 85
        Me.ColLotNo.Name = "ColLotNo"
        Me.ColLotNo.Visible = True
        Me.ColLotNo.VisibleIndex = 2
        Me.ColLotNo.Width = 114
        '
        'rpttxtLotNo
        '
        Me.rpttxtLotNo.AutoHeight = False
        Me.rpttxtLotNo.ContextImageAlignment = DevExpress.XtraEditors.ContextImageAlignment.Far
        Me.rpttxtLotNo.Name = "rpttxtLotNo"
        '
        'PanelControl2
        '
        Me.PanelControl2.Appearance.BackColor = System.Drawing.Color.LightSteelBlue
        Me.PanelControl2.Appearance.BackColor2 = System.Drawing.Color.CornflowerBlue
        Me.PanelControl2.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.PanelControl2.Appearance.Options.UseBackColor = True
        Me.PanelControl2.Appearance.Options.UseFont = True
        Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl2.Controls.Add(Me.btnSave)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 494)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(1184, 35)
        Me.PanelControl2.TabIndex = 5
        '
        'btnSave
        '
        Me.btnSave.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Appearance.Options.UseFont = True
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnSave.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnSave.Location = New System.Drawing.Point(4, 1)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(97, 32)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "บันทึกบิล"
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
        Me.PanelControl1.Controls.Add(Me.GroupBox2)
        Me.PanelControl1.Controls.Add(Me.GBDiscount)
        Me.PanelControl1.Controls.Add(Me.txtTotalBFDisc)
        Me.PanelControl1.Controls.Add(Me.Label32)
        Me.PanelControl1.Controls.Add(Me.Panel4)
        Me.PanelControl1.Controls.Add(Me.Label33)
        Me.PanelControl1.Controls.Add(Me.txtTotalNet)
        Me.PanelControl1.Controls.Add(Me.GroupBox1)
        Me.PanelControl1.Controls.Add(Me.GroupBox6)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1184, 257)
        Me.PanelControl1.TabIndex = 4
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
        Me.GroupBox4.Location = New System.Drawing.Point(629, 8)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(264, 56)
        Me.GroupBox4.TabIndex = 590
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
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GroupBox2.Controls.Add(Me.txtPrePay)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtPercP)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.cmbTp)
        Me.GroupBox2.Controls.Add(Me.Label34)
        Me.GroupBox2.Controls.Add(Me.dtpPay)
        Me.GroupBox2.Controls.Add(Me.Label35)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(629, 72)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(264, 117)
        Me.GroupBox2.TabIndex = 591
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "การชำระเงินบิลนี้"
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
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.Location = New System.Drawing.Point(145, 54)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 14)
        Me.Label9.TabIndex = 598
        Me.Label9.Text = "% ="
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
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label12.Location = New System.Drawing.Point(34, 52)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(51, 14)
        Me.Label12.TabIndex = 596
        Me.Label12.Text = "เงินมัดจำ"
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
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label34.Location = New System.Drawing.Point(17, 24)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(68, 14)
        Me.Label34.TabIndex = 594
        Me.Label34.Text = "เงื่อนไขชำระ"
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
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label35.Location = New System.Drawing.Point(21, 83)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(66, 14)
        Me.Label35.TabIndex = 569
        Me.Label35.Text = "วันที่จ่ายเงิน"
        '
        'GBDiscount
        '
        Me.GBDiscount.BackColor = System.Drawing.Color.Transparent
        Me.GBDiscount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GBDiscount.Controls.Add(Me.Label22)
        Me.GBDiscount.Controls.Add(Me.txtDiscBath)
        Me.GBDiscount.Controls.Add(Me.lblPerc)
        Me.GBDiscount.Controls.Add(Me.Label31)
        Me.GBDiscount.Controls.Add(Me.txtAmtPerc)
        Me.GBDiscount.Controls.Add(Me.rdbBathDisc)
        Me.GBDiscount.Controls.Add(Me.rdbPerDisc)
        Me.GBDiscount.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GBDiscount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GBDiscount.Location = New System.Drawing.Point(909, 36)
        Me.GBDiscount.Name = "GBDiscount"
        Me.GBDiscount.Size = New System.Drawing.Size(269, 74)
        Me.GBDiscount.TabIndex = 584
        Me.GBDiscount.TabStop = False
        Me.GBDiscount.Text = "การให้ส่วนลด"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label22.Location = New System.Drawing.Point(228, 51)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(30, 14)
        Me.Label22.TabIndex = 585
        Me.Label22.Text = "บาท"
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
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label31.Location = New System.Drawing.Point(149, 27)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(32, 14)
        Me.Label31.TabIndex = 600
        Me.Label31.Text = "% ="
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
        'txtTotalBFDisc
        '
        Me.txtTotalBFDisc.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtTotalBFDisc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalBFDisc.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTotalBFDisc.ForeColor = System.Drawing.Color.Lime
        Me.txtTotalBFDisc.Location = New System.Drawing.Point(997, 8)
        Me.txtTotalBFDisc.Multiline = True
        Me.txtTotalBFDisc.Name = "txtTotalBFDisc"
        Me.txtTotalBFDisc.ReadOnly = True
        Me.txtTotalBFDisc.Size = New System.Drawing.Size(175, 26)
        Me.txtTotalBFDisc.TabIndex = 589
        Me.txtTotalBFDisc.TabStop = False
        Me.txtTotalBFDisc.Text = "0"
        Me.txtTotalBFDisc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.BackColor = System.Drawing.Color.Transparent
        Me.Label32.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label32.Location = New System.Drawing.Point(918, 13)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(66, 14)
        Me.Label32.TabIndex = 588
        Me.Label32.Text = "รวมเป็นเงิน"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.gcNote)
        Me.Panel4.Location = New System.Drawing.Point(899, 150)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(277, 94)
        Me.Panel4.TabIndex = 585
        '
        'gcNote
        '
        Me.gcNote.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcNote.Location = New System.Drawing.Point(0, 0)
        Me.gcNote.MainView = Me.gvNote
        Me.gcNote.Name = "gcNote"
        Me.gcNote.Size = New System.Drawing.Size(277, 94)
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
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.BackColor = System.Drawing.Color.Transparent
        Me.Label33.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label33.Location = New System.Drawing.Point(906, 124)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(90, 14)
        Me.Label33.TabIndex = 587
        Me.Label33.Text = "รวมเป็นเงินสุทธิ"
        '
        'txtTotalNet
        '
        Me.txtTotalNet.BackColor = System.Drawing.Color.Black
        Me.txtTotalNet.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTotalNet.ForeColor = System.Drawing.Color.Lime
        Me.txtTotalNet.Location = New System.Drawing.Point(997, 118)
        Me.txtTotalNet.Name = "txtTotalNet"
        Me.txtTotalNet.ReadOnly = True
        Me.txtTotalNet.Size = New System.Drawing.Size(175, 27)
        Me.txtTotalNet.TabIndex = 586
        Me.txtTotalNet.TabStop = False
        Me.txtTotalNet.Text = "0"
        Me.txtTotalNet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.lblDocCodeSH)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.lblSeason)
        Me.GroupBox1.Controls.Add(Me.lblJobNo)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.lblPSsupport)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.dtpJob)
        Me.GroupBox1.Controls.Add(Me.lblZone)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.lblSeedName)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lblStrainCode)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lblFarmerName)
        Me.GroupBox1.Controls.Add(Me.Label30)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 94)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(610, 150)
        Me.GroupBox1.TabIndex = 581
        Me.GroupBox1.TabStop = False
        '
        'lblDocCodeSH
        '
        Me.lblDocCodeSH.BackColor = System.Drawing.Color.Gainsboro
        Me.lblDocCodeSH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDocCodeSH.Location = New System.Drawing.Point(80, 17)
        Me.lblDocCodeSH.Name = "lblDocCodeSH"
        Me.lblDocCodeSH.Size = New System.Drawing.Size(197, 22)
        Me.lblDocCodeSH.TabIndex = 990
        Me.lblDocCodeSH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(20, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 14)
        Me.Label6.TabIndex = 989
        Me.Label6.Text = "เบิกโสหุ้ย"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(11, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 14)
        Me.Label5.TabIndex = 988
        Me.Label5.Text = "รหัสเอกสาร"
        '
        'lblSeason
        '
        Me.lblSeason.BackColor = System.Drawing.Color.Gainsboro
        Me.lblSeason.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSeason.Location = New System.Drawing.Point(399, 18)
        Me.lblSeason.Name = "lblSeason"
        Me.lblSeason.Size = New System.Drawing.Size(197, 22)
        Me.lblSeason.TabIndex = 987
        Me.lblSeason.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblJobNo
        '
        Me.lblJobNo.BackColor = System.Drawing.Color.Gainsboro
        Me.lblJobNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblJobNo.Location = New System.Drawing.Point(80, 97)
        Me.lblJobNo.Name = "lblJobNo"
        Me.lblJobNo.Size = New System.Drawing.Size(197, 22)
        Me.lblJobNo.TabIndex = 986
        Me.lblJobNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label20.Location = New System.Drawing.Point(352, 23)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(42, 14)
        Me.Label20.TabIndex = 971
        Me.Label20.Text = "ฤดูผลิต"
        '
        'lblPSsupport
        '
        Me.lblPSsupport.BackColor = System.Drawing.Color.Gainsboro
        Me.lblPSsupport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPSsupport.Location = New System.Drawing.Point(399, 128)
        Me.lblPSsupport.Name = "lblPSsupport"
        Me.lblPSsupport.Size = New System.Drawing.Size(197, 22)
        Me.lblPSsupport.TabIndex = 985
        Me.lblPSsupport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label18.Location = New System.Drawing.Point(303, 132)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(90, 14)
        Me.Label18.TabIndex = 984
        Me.Label18.Text = "เจ้าหน้าที่ส่งเสริม"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(3, 129)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(73, 14)
        Me.Label14.TabIndex = 983
        Me.Label14.Text = "วันที่แจก Job"
        '
        'dtpJob
        '
        Me.dtpJob.CustomFormat = "ddMMMMyyyy"
        Me.dtpJob.Enabled = False
        Me.dtpJob.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpJob.Location = New System.Drawing.Point(80, 125)
        Me.dtpJob.Name = "dtpJob"
        Me.dtpJob.Size = New System.Drawing.Size(197, 22)
        Me.dtpJob.TabIndex = 982
        '
        'lblZone
        '
        Me.lblZone.BackColor = System.Drawing.Color.Gainsboro
        Me.lblZone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblZone.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblZone.Location = New System.Drawing.Point(399, 99)
        Me.lblZone.Name = "lblZone"
        Me.lblZone.Size = New System.Drawing.Size(197, 22)
        Me.lblZone.TabIndex = 979
        Me.lblZone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(346, 103)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 14)
        Me.Label7.TabIndex = 978
        Me.Label7.Text = "เขตปลูก"
        '
        'lblSeedName
        '
        Me.lblSeedName.BackColor = System.Drawing.Color.Gainsboro
        Me.lblSeedName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSeedName.Location = New System.Drawing.Point(399, 72)
        Me.lblSeedName.Name = "lblSeedName"
        Me.lblSeedName.Size = New System.Drawing.Size(197, 22)
        Me.lblSeedName.TabIndex = 977
        Me.lblSeedName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(371, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(22, 14)
        Me.Label4.TabIndex = 976
        Me.Label4.Text = "พืช"
        '
        'lblStrainCode
        '
        Me.lblStrainCode.BackColor = System.Drawing.Color.Gainsboro
        Me.lblStrainCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblStrainCode.Location = New System.Drawing.Point(399, 46)
        Me.lblStrainCode.Name = "lblStrainCode"
        Me.lblStrainCode.Size = New System.Drawing.Size(197, 22)
        Me.lblStrainCode.TabIndex = 975
        Me.lblStrainCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(346, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 14)
        Me.Label1.TabIndex = 974
        Me.Label1.Text = "รหัสผลิต"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(27, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 14)
        Me.Label3.TabIndex = 973
        Me.Label3.Text = "Job No."
        '
        'lblFarmerName
        '
        Me.lblFarmerName.BackColor = System.Drawing.Color.Gainsboro
        Me.lblFarmerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFarmerName.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblFarmerName.Location = New System.Drawing.Point(80, 47)
        Me.lblFarmerName.Name = "lblFarmerName"
        Me.lblFarmerName.Size = New System.Drawing.Size(197, 45)
        Me.lblFarmerName.TabIndex = 583
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label30.Location = New System.Drawing.Point(23, 47)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(51, 14)
        Me.Label30.TabIndex = 582
        Me.Label30.Text = "เกษตรกร"
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox6.Controls.Add(Me.Label2)
        Me.GroupBox6.Controls.Add(Me.rdbRight)
        Me.GroupBox6.Controls.Add(Me.Label16)
        Me.GroupBox6.Controls.Add(Me.rdbNoRight)
        Me.GroupBox6.Controls.Add(Me.btnRefDoc)
        Me.GroupBox6.Controls.Add(Me.lblRefAcc)
        Me.GroupBox6.Controls.Add(Me.cmbGroupComp)
        Me.GroupBox6.Controls.Add(Me.Label38)
        Me.GroupBox6.Controls.Add(Me.Label24)
        Me.GroupBox6.Controls.Add(Me.Label17)
        Me.GroupBox6.Controls.Add(Me.Label21)
        Me.GroupBox6.Controls.Add(Me.dtpSale)
        Me.GroupBox6.Controls.Add(Me.cmbDRCode)
        Me.GroupBox6.Controls.Add(Me.txtDocRef)
        Me.GroupBox6.Controls.Add(Me.Label28)
        Me.GroupBox6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(12, 3)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(610, 92)
        Me.GroupBox6.TabIndex = 580
        Me.GroupBox6.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(324, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 14)
        Me.Label2.TabIndex = 969
        Me.Label2.Text = "หลักสรรพากร"
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
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label16.Location = New System.Drawing.Point(325, 20)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(70, 14)
        Me.Label16.TabIndex = 558
        Me.Label16.Text = "เลขที่รายการ"
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
        Me.lblRefAcc.Size = New System.Drawing.Size(197, 20)
        Me.lblRefAcc.TabIndex = 616
        Me.lblRefAcc.Text = "- - - - - - - - - - "
        Me.lblRefAcc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbGroupComp
        '
        Me.cmbGroupComp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGroupComp.Enabled = False
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
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.Gainsboro
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label17.Location = New System.Drawing.Point(399, 17)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(197, 20)
        Me.Label17.TabIndex = 561
        Me.Label17.Text = "- - - - - - - - - - "
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label21.Location = New System.Drawing.Point(21, 69)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(49, 14)
        Me.Label21.TabIndex = 421
        Me.Label21.Text = "วันที่ขาย"
        '
        'dtpSale
        '
        Me.dtpSale.CustomFormat = "ddMMMMyyyy"
        Me.dtpSale.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpSale.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpSale.Location = New System.Drawing.Point(76, 65)
        Me.dtpSale.Name = "dtpSale"
        Me.dtpSale.Size = New System.Drawing.Size(201, 22)
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
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label28.Location = New System.Drawing.Point(32, 17)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(38, 14)
        Me.Label28.TabIndex = 967
        Me.Label28.Text = "บริษัท"
        '
        'GCSale
        '
        Me.GCSale.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCSale.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GCSale.Location = New System.Drawing.Point(0, 257)
        Me.GCSale.MainView = Me.DGVBind
        Me.GCSale.Name = "GCSale"
        Me.GCSale.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rptDel, Me.rptUnit, Me.rpttxtLotNo, Me.rptSelLot})
        Me.GCSale.Size = New System.Drawing.Size(1184, 237)
        Me.GCSale.TabIndex = 7
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
        Me.DGVBind.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.DGVBind.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.DGVBind.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.DGVBind.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
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
        Me.DGVBind.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
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
        Me.DGVBind.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.DGVBind.Appearance.SelectedRow.Options.UseBackColor = True
        Me.DGVBind.Appearance.SelectedRow.Options.UseForeColor = True
        Me.DGVBind.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.DGVBind.Appearance.TopNewRow.Options.UseBackColor = True
        Me.DGVBind.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.DGVBind.Appearance.VertLine.Options.UseBackColor = True
        Me.DGVBind.ColumnPanelRowHeight = 35
        Me.DGVBind.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colidSubType, Me.AmtSaleHide, Me.ColidUnitHide, Me.PriceNormalHide, Me.PercDiscHide, Me.BathDiscHide, Me.idInvMainHide, Me.PriceSaleHide, Me.ColNum, Me.ColLotNo, Me.ColProductName, Me.ColAmtStock, Me.ColSelLot, Me.ColAmtSale, Me.ColidUnit, Me.ColWareHouseName, Me.ColPriceSale, Me.ColExp, Me.ColDel, Me.Col_idSaleOrderDt, Me.Col_idSaleDt, Me.Col_OldStock, Me.Col_OldAmt, Me.Col_CompRec, Me.colidInvMain, Me.Col_idLot, Me.colidLotSPM, Me.colidInvGroup, Me.colidWh, Me.colNo, Me.colstEdit, Me.colstWIMAllRec, Me.colAmtWIMRecBal, Me.ColDtType, Me.colUnitName, Me.ColLotNoHide, Me.ColidWhHide, Me.ColidLotHide, Me.colidRefLot, Me.colstEnough})
        GridFormatRule3.ApplyToRow = True
        GridFormatRule3.Column = Me.colstEnough
        GridFormatRule3.Name = "Format0"
        FormatConditionRuleExpression3.Appearance.ForeColor = System.Drawing.Color.Red
        FormatConditionRuleExpression3.Appearance.Options.UseForeColor = True
        FormatConditionRuleExpression3.Expression = "[stEnough] = 0"
        GridFormatRule3.Rule = FormatConditionRuleExpression3
        GridFormatRule4.Column = Me.ColLotNo
        GridFormatRule4.ColumnApplyTo = Me.ColLotNo
        GridFormatRule4.Name = "Format1"
        FormatConditionRuleExpression4.Appearance.ForeColor = System.Drawing.Color.Silver
        FormatConditionRuleExpression4.Appearance.Options.UseForeColor = True
        FormatConditionRuleExpression4.Expression = "[LotNo] = 'เลือก Lot'"
        GridFormatRule4.Rule = FormatConditionRuleExpression4
        Me.DGVBind.FormatRules.Add(GridFormatRule3)
        Me.DGVBind.FormatRules.Add(GridFormatRule4)
        Me.DGVBind.GridControl = Me.GCSale
        Me.DGVBind.IndicatorWidth = 35
        Me.DGVBind.Name = "DGVBind"
        Me.DGVBind.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDown
        Me.DGVBind.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.DGVBind.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.DGVBind.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect
        Me.DGVBind.OptionsView.EnableAppearanceEvenRow = True
        Me.DGVBind.OptionsView.EnableAppearanceOddRow = True
        Me.DGVBind.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.DGVBind.OptionsView.ShowGroupPanel = False
        Me.DGVBind.OptionsView.ShowIndicator = False
        Me.DGVBind.PaintStyleName = "MixedXP"
        '
        'colidSubType
        '
        Me.colidSubType.Caption = "idSubType"
        Me.colidSubType.FieldName = "idSubType"
        Me.colidSubType.Name = "colidSubType"
        '
        'AmtSaleHide
        '
        Me.AmtSaleHide.Caption = "AmtSaleHide"
        Me.AmtSaleHide.FieldName = "AmtSaleHide"
        Me.AmtSaleHide.Name = "AmtSaleHide"
        '
        'ColidUnitHide
        '
        Me.ColidUnitHide.Caption = "idUnitHide"
        Me.ColidUnitHide.FieldName = "idUnitHide"
        Me.ColidUnitHide.Name = "ColidUnitHide"
        '
        'PriceNormalHide
        '
        Me.PriceNormalHide.Caption = "PriceNormalHide"
        Me.PriceNormalHide.FieldName = "PriceNormalHide"
        Me.PriceNormalHide.Name = "PriceNormalHide"
        '
        'PercDiscHide
        '
        Me.PercDiscHide.Caption = "PercDiscHide"
        Me.PercDiscHide.FieldName = "PercDiscHide"
        Me.PercDiscHide.Name = "PercDiscHide"
        '
        'BathDiscHide
        '
        Me.BathDiscHide.Caption = "BathDiscHide"
        Me.BathDiscHide.FieldName = "BathDiscHide"
        Me.BathDiscHide.Name = "BathDiscHide"
        '
        'idInvMainHide
        '
        Me.idInvMainHide.Caption = "idInvMainHide"
        Me.idInvMainHide.FieldName = "idInvMainHide"
        Me.idInvMainHide.Name = "idInvMainHide"
        '
        'PriceSaleHide
        '
        Me.PriceSaleHide.Caption = "PriceSaleHide"
        Me.PriceSaleHide.FieldName = "PriceSaleHide"
        Me.PriceSaleHide.Name = "PriceSaleHide"
        '
        'ColNum
        '
        Me.ColNum.AppearanceCell.BackColor = System.Drawing.Color.Gainsboro
        Me.ColNum.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColNum.AppearanceCell.Options.UseBackColor = True
        Me.ColNum.AppearanceCell.Options.UseFont = True
        Me.ColNum.AppearanceCell.Options.UseTextOptions = True
        Me.ColNum.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColNum.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
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
        'ColProductName
        '
        Me.ColProductName.AppearanceCell.BackColor = System.Drawing.Color.Gainsboro
        Me.ColProductName.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColProductName.AppearanceCell.Options.UseBackColor = True
        Me.ColProductName.AppearanceCell.Options.UseFont = True
        Me.ColProductName.AppearanceCell.Options.UseTextOptions = True
        Me.ColProductName.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColProductName.AppearanceHeader.Options.UseFont = True
        Me.ColProductName.AppearanceHeader.Options.UseTextOptions = True
        Me.ColProductName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColProductName.Caption = "รายการสินค้า"
        Me.ColProductName.FieldName = "ProductName"
        Me.ColProductName.MinWidth = 290
        Me.ColProductName.Name = "ColProductName"
        Me.ColProductName.OptionsColumn.AllowEdit = False
        Me.ColProductName.OptionsColumn.ReadOnly = True
        Me.ColProductName.Visible = True
        Me.ColProductName.VisibleIndex = 1
        Me.ColProductName.Width = 380
        '
        'ColAmtStock
        '
        Me.ColAmtStock.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ColAmtStock.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColAmtStock.AppearanceCell.Options.UseBackColor = True
        Me.ColAmtStock.AppearanceCell.Options.UseFont = True
        Me.ColAmtStock.AppearanceCell.Options.UseTextOptions = True
        Me.ColAmtStock.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ColAmtStock.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
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
        Me.ColAmtStock.Width = 87
        '
        'ColSelLot
        '
        Me.ColSelLot.ColumnEdit = Me.rptSelLot
        Me.ColSelLot.MaxWidth = 35
        Me.ColSelLot.MinWidth = 35
        Me.ColSelLot.Name = "ColSelLot"
        Me.ColSelLot.Visible = True
        Me.ColSelLot.VisibleIndex = 3
        Me.ColSelLot.Width = 35
        '
        'rptSelLot
        '
        Me.rptSelLot.AutoHeight = False
        Me.rptSelLot.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("rptSelLot.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject3, "", Nothing, Nothing, True)})
        Me.rptSelLot.Name = "rptSelLot"
        Me.rptSelLot.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'ColAmtSale
        '
        Me.ColAmtSale.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColAmtSale.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColAmtSale.AppearanceCell.Options.UseBackColor = True
        Me.ColAmtSale.AppearanceCell.Options.UseFont = True
        Me.ColAmtSale.AppearanceCell.Options.UseTextOptions = True
        Me.ColAmtSale.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ColAmtSale.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColAmtSale.AppearanceHeader.Options.UseFont = True
        Me.ColAmtSale.AppearanceHeader.Options.UseTextOptions = True
        Me.ColAmtSale.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColAmtSale.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColAmtSale.Caption = "จำนวนขาย"
        Me.ColAmtSale.DisplayFormat.FormatString = "#,##0.00##"
        Me.ColAmtSale.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.ColAmtSale.FieldName = "AmtSale"
        Me.ColAmtSale.MinWidth = 60
        Me.ColAmtSale.Name = "ColAmtSale"
        Me.ColAmtSale.OptionsColumn.AllowEdit = False
        Me.ColAmtSale.OptionsColumn.ReadOnly = True
        Me.ColAmtSale.Visible = True
        Me.ColAmtSale.VisibleIndex = 5
        Me.ColAmtSale.Width = 87
        '
        'ColidUnit
        '
        Me.ColidUnit.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColidUnit.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColidUnit.AppearanceCell.Options.UseBackColor = True
        Me.ColidUnit.AppearanceCell.Options.UseFont = True
        Me.ColidUnit.AppearanceCell.Options.UseTextOptions = True
        Me.ColidUnit.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColidUnit.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColidUnit.AppearanceHeader.Options.UseFont = True
        Me.ColidUnit.AppearanceHeader.Options.UseTextOptions = True
        Me.ColidUnit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColidUnit.Caption = "หน่วย"
        Me.ColidUnit.ColumnEdit = Me.rptUnit
        Me.ColidUnit.FieldName = "idUnit"
        Me.ColidUnit.MinWidth = 55
        Me.ColidUnit.Name = "ColidUnit"
        Me.ColidUnit.OptionsColumn.AllowEdit = False
        Me.ColidUnit.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[True]
        Me.ColidUnit.OptionsColumn.ReadOnly = True
        Me.ColidUnit.Visible = True
        Me.ColidUnit.VisibleIndex = 6
        Me.ColidUnit.Width = 70
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
        'ColWareHouseName
        '
        Me.ColWareHouseName.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColWareHouseName.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColWareHouseName.AppearanceCell.Options.UseBackColor = True
        Me.ColWareHouseName.AppearanceCell.Options.UseFont = True
        Me.ColWareHouseName.AppearanceCell.Options.UseTextOptions = True
        Me.ColWareHouseName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColWareHouseName.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColWareHouseName.AppearanceHeader.Options.UseFont = True
        Me.ColWareHouseName.AppearanceHeader.Options.UseTextOptions = True
        Me.ColWareHouseName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColWareHouseName.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColWareHouseName.Caption = "คลัง"
        Me.ColWareHouseName.FieldName = "WareHouseName"
        Me.ColWareHouseName.Name = "ColWareHouseName"
        Me.ColWareHouseName.OptionsColumn.AllowEdit = False
        Me.ColWareHouseName.OptionsColumn.TabStop = False
        Me.ColWareHouseName.Visible = True
        Me.ColWareHouseName.VisibleIndex = 9
        Me.ColWareHouseName.Width = 134
        '
        'ColPriceSale
        '
        Me.ColPriceSale.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColPriceSale.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColPriceSale.AppearanceCell.Options.UseBackColor = True
        Me.ColPriceSale.AppearanceCell.Options.UseFont = True
        Me.ColPriceSale.AppearanceCell.Options.UseTextOptions = True
        Me.ColPriceSale.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ColPriceSale.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColPriceSale.AppearanceHeader.Options.UseFont = True
        Me.ColPriceSale.AppearanceHeader.Options.UseTextOptions = True
        Me.ColPriceSale.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColPriceSale.Caption = "ราคาขาย"
        Me.ColPriceSale.DisplayFormat.FormatString = "#,##0.00##"
        Me.ColPriceSale.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.ColPriceSale.FieldName = "PriceSale"
        Me.ColPriceSale.MinWidth = 65
        Me.ColPriceSale.Name = "ColPriceSale"
        Me.ColPriceSale.OptionsColumn.AllowEdit = False
        Me.ColPriceSale.OptionsColumn.ReadOnly = True
        Me.ColPriceSale.Visible = True
        Me.ColPriceSale.VisibleIndex = 7
        Me.ColPriceSale.Width = 89
        '
        'ColExp
        '
        Me.ColExp.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ColExp.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColExp.AppearanceCell.Options.UseBackColor = True
        Me.ColExp.AppearanceCell.Options.UseFont = True
        Me.ColExp.AppearanceCell.Options.UseTextOptions = True
        Me.ColExp.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ColExp.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColExp.AppearanceHeader.Options.UseFont = True
        Me.ColExp.AppearanceHeader.Options.UseTextOptions = True
        Me.ColExp.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColExp.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColExp.Caption = "รวมเป็นเงิน"
        Me.ColExp.DisplayFormat.FormatString = "#,##0.00##"
        Me.ColExp.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColExp.FieldName = "Total"
        Me.ColExp.MinWidth = 65
        Me.ColExp.Name = "ColExp"
        Me.ColExp.OptionsColumn.AllowEdit = False
        Me.ColExp.OptionsColumn.ReadOnly = True
        Me.ColExp.OptionsColumn.TabStop = False
        Me.ColExp.Visible = True
        Me.ColExp.VisibleIndex = 8
        Me.ColExp.Width = 114
        '
        'ColDel
        '
        Me.ColDel.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColDel.AppearanceCell.Options.UseFont = True
        Me.ColDel.AppearanceCell.Options.UseTextOptions = True
        Me.ColDel.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDel.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColDel.AppearanceHeader.Options.UseFont = True
        Me.ColDel.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDel.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDel.Caption = "ลบ"
        Me.ColDel.ColumnEdit = Me.rptDel
        Me.ColDel.MaxWidth = 30
        Me.ColDel.MinWidth = 30
        Me.ColDel.Name = "ColDel"
        Me.ColDel.OptionsColumn.AllowSize = False
        Me.ColDel.Visible = True
        Me.ColDel.VisibleIndex = 10
        Me.ColDel.Width = 30
        '
        'rptDel
        '
        Me.rptDel.AutoHeight = False
        Me.rptDel.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Global.SAM.My.Resources.Resources.minus2, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject4, "", Nothing, Nothing, True)})
        Me.rptDel.Name = "rptDel"
        Me.rptDel.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'Col_idSaleOrderDt
        '
        Me.Col_idSaleOrderDt.Caption = "idSaleOrderDt"
        Me.Col_idSaleOrderDt.FieldName = "idSaleOrderDt"
        Me.Col_idSaleOrderDt.Name = "Col_idSaleOrderDt"
        '
        'Col_idSaleDt
        '
        Me.Col_idSaleDt.Caption = "idSaleDt"
        Me.Col_idSaleDt.FieldName = "idSaleDt"
        Me.Col_idSaleDt.Name = "Col_idSaleDt"
        '
        'Col_OldStock
        '
        Me.Col_OldStock.Caption = "OldStock"
        Me.Col_OldStock.DisplayFormat.FormatString = "#,##0.00###"
        Me.Col_OldStock.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Col_OldStock.FieldName = "OldStock"
        Me.Col_OldStock.Name = "Col_OldStock"
        '
        'Col_OldAmt
        '
        Me.Col_OldAmt.Caption = "OldAmt"
        Me.Col_OldAmt.DisplayFormat.FormatString = "#,##0.00###"
        Me.Col_OldAmt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Col_OldAmt.FieldName = "OldAmt"
        Me.Col_OldAmt.Name = "Col_OldAmt"
        '
        'Col_CompRec
        '
        Me.Col_CompRec.Caption = "CompRec"
        Me.Col_CompRec.FieldName = "CompRec"
        Me.Col_CompRec.Name = "Col_CompRec"
        '
        'colidInvMain
        '
        Me.colidInvMain.Caption = "idInvMain"
        Me.colidInvMain.FieldName = "idInvMain"
        Me.colidInvMain.Name = "colidInvMain"
        '
        'Col_idLot
        '
        Me.Col_idLot.Caption = "idLot"
        Me.Col_idLot.FieldName = "idLot"
        Me.Col_idLot.Name = "Col_idLot"
        '
        'colidLotSPM
        '
        Me.colidLotSPM.Caption = "colidLotSPM"
        Me.colidLotSPM.FieldName = "idLotSPM"
        Me.colidLotSPM.Name = "colidLotSPM"
        '
        'colidInvGroup
        '
        Me.colidInvGroup.Caption = "idInvGroup"
        Me.colidInvGroup.FieldName = "idInvGroup"
        Me.colidInvGroup.Name = "colidInvGroup"
        '
        'colidWh
        '
        Me.colidWh.Caption = "idWh"
        Me.colidWh.FieldName = "idWh"
        Me.colidWh.Name = "colidWh"
        '
        'colNo
        '
        Me.colNo.Caption = "colNo"
        Me.colNo.FieldName = "No"
        Me.colNo.Name = "colNo"
        '
        'colstEdit
        '
        Me.colstEdit.Caption = "stEdit"
        Me.colstEdit.FieldName = "stEdit"
        Me.colstEdit.Name = "colstEdit"
        '
        'colstWIMAllRec
        '
        Me.colstWIMAllRec.Caption = "stWIMAllRec"
        Me.colstWIMAllRec.FieldName = "stWIMAllRec"
        Me.colstWIMAllRec.Name = "colstWIMAllRec"
        '
        'colAmtWIMRecBal
        '
        Me.colAmtWIMRecBal.Caption = "AmtWIMRecBal"
        Me.colAmtWIMRecBal.FieldName = "AmtWIMRecBal"
        Me.colAmtWIMRecBal.Name = "colAmtWIMRecBal"
        '
        'ColDtType
        '
        Me.ColDtType.Caption = "DtType"
        Me.ColDtType.FieldName = "DtType"
        Me.ColDtType.Name = "ColDtType"
        '
        'colUnitName
        '
        Me.colUnitName.Caption = "UnitName"
        Me.colUnitName.FieldName = "UnitName"
        Me.colUnitName.Name = "colUnitName"
        '
        'ColLotNoHide
        '
        Me.ColLotNoHide.Caption = "LotNoHide"
        Me.ColLotNoHide.FieldName = "LotNoHide"
        Me.ColLotNoHide.Name = "ColLotNoHide"
        '
        'ColidWhHide
        '
        Me.ColidWhHide.Caption = "idWhHide"
        Me.ColidWhHide.FieldName = "idWhHide"
        Me.ColidWhHide.Name = "ColidWhHide"
        '
        'ColidLotHide
        '
        Me.ColidLotHide.Caption = "idLotHide"
        Me.ColidLotHide.FieldName = "idLotHide"
        Me.ColidLotHide.Name = "ColidLotHide"
        '
        'colidRefLot
        '
        Me.colidRefLot.Caption = "idRefLot"
        Me.colidRefLot.FieldName = "idRefLot"
        Me.colidRefLot.Name = "colidRefLot"
        '
        'StatusStrip2
        '
        Me.StatusStrip2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.StatusStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.stLbl_DateTs, Me.stLbl_PsTs})
        Me.StatusStrip2.Location = New System.Drawing.Point(0, 529)
        Me.StatusStrip2.Name = "StatusStrip2"
        Me.StatusStrip2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StatusStrip2.Size = New System.Drawing.Size(1184, 22)
        Me.StatusStrip2.TabIndex = 735
        Me.StatusStrip2.Text = "StatusStrip2"
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
        'FrmSlSaleTsSH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 551)
        Me.Controls.Add(Me.GCSale)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.StatusStrip2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmSlSaleTsSH"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ทำรายการ/แก้ไขรายการขายสินค้าโสหุ้ย"
        CType(Me.rpttxtLotNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GBDiscount.ResumeLayout(False)
        Me.GBDiscount.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        CType(Me.gcNote, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvNote, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.GCSale, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVBind, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptSelLot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptUnit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptDel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip2.ResumeLayout(False)
        Me.StatusStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblStrainCode As System.Windows.Forms.Label
    Friend WithEvents lblSeedName As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents dtpJob As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblPSsupport As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
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
    Friend WithEvents ColNum As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColLotNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rpttxtLotNo As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents ColProductName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColAmtStock As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColAmtSale As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColidUnit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rptUnit As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents ColWareHouseName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColPriceSale As DevExpress.XtraGrid.Columns.GridColumn
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
    Friend WithEvents colstEdit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colstWIMAllRec As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAmtWIMRecBal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDtType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColLotNoHide As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColidWhHide As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColidLotHide As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colidRefLot As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colstEnough As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents StatusStrip2 As StatusStrip
    Friend WithEvents stLbl_DateTs As ToolStripStatusLabel
    Friend WithEvents stLbl_PsTs As ToolStripStatusLabel
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents rdbRight As RadioButton
    Friend WithEvents Label16 As Label
    Friend WithEvents rdbNoRight As RadioButton
    Friend WithEvents btnRefDoc As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblRefAcc As Label
    Friend WithEvents cmbGroupComp As ComboBox
    Friend WithEvents Label38 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents dtpSale As DateTimePicker
    Friend WithEvents cmbDRCode As ComboBox
    Friend WithEvents txtDocRef As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblFarmerName As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents GBDiscount As GroupBox
    Friend WithEvents Label22 As Label
    Friend WithEvents txtDiscBath As TextBox
    Friend WithEvents lblPerc As TextBox
    Friend WithEvents Label31 As Label
    Friend WithEvents txtAmtPerc As TextBox
    Friend WithEvents rdbBathDisc As RadioButton
    Friend WithEvents rdbPerDisc As RadioButton
    Friend WithEvents txtTotalBFDisc As TextBox
    Friend WithEvents Label32 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents gcNote As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvNote As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colNote As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label33 As Label
    Friend WithEvents txtTotalNet As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents rdbBill As RadioButton
    Friend WithEvents rdbWhole As RadioButton
    Friend WithEvents rdbRetail As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtPrePay As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtPercP As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents cmbTp As ComboBox
    Friend WithEvents Label34 As Label
    Friend WithEvents dtpPay As DateTimePicker
    Friend WithEvents Label35 As Label
    Friend WithEvents lblSeason As Label
    Friend WithEvents lblJobNo As Label
    Friend WithEvents lblZone As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ColSelLot As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rptSelLot As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblDocCodeSH As Label
End Class
