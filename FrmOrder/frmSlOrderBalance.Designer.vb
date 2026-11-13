<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSlOrderBalance
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSlOrderBalance))
        Dim GridFormatRule1 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleExpression1 As DevExpress.XtraEditors.FormatConditionRuleExpression = New DevExpress.XtraEditors.FormatConditionRuleExpression()
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim GridFormatRule2 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Me.ColAmtSale = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rptAmtSale = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnExcel = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCount = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.btnRefresh = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rdbNoGroup = New System.Windows.Forms.RadioButton()
        Me.rdbInvName = New System.Windows.Forms.RadioButton()
        Me.rdbCusName = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblInvName = New System.Windows.Forms.Label()
        Me.lblPartnerName = New System.Windows.Forms.Label()
        Me.btnPartner = New DevExpress.XtraEditors.SimpleButton()
        Me.btnInvName = New DevExpress.XtraEditors.SimpleButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbGroupComp = New System.Windows.Forms.ComboBox()
        Me.chkInvName = New System.Windows.Forms.CheckBox()
        Me.ChkCus = New System.Windows.Forms.CheckBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.dtpYear = New System.Windows.Forms.DateTimePicker()
        Me.dtpDateE = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.rdbDate = New System.Windows.Forms.RadioButton()
        Me.dtpDateS = New System.Windows.Forms.DateTimePicker()
        Me.dtpMonthS = New System.Windows.Forms.DateTimePicker()
        Me.rdbMonth = New System.Windows.Forms.RadioButton()
        Me.rdbYear = New System.Windows.Forms.RadioButton()
        Me.GCSlOrderBal = New DevExpress.XtraGrid.GridControl()
        Me.GVSlOrderBal = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColNum = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDocCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDocRef = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDateOrder = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColPartnerName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rptPartnerName = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.ColPsSale = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColPayTspName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDateRequired = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColInvName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rptProductName = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.ColPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColAmtOrder = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColAmtOrderBal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColUnitC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.idSaleOrderDt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rptDelDt = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.rptDelMt = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.rptAddLot = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.GVLotSale = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColidRefLot_ = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LotNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColWHName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColAmtBal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDateGen = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColMFG = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColUnitBal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColAmountCut = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDelLot = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColidLot = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColidSaleOrderDt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColidUnitBal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColidWh = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.idLotSPM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColCompRec = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColAmtCurStock = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.rptAmtSale, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel8.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.GCSlOrderBal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVSlOrderBal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptPartnerName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptProductName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptDelDt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptDelMt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptAddLot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVLotSale, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.ColAmtSale.AppearanceHeader.Options.UseTextOptions = True
        Me.ColAmtSale.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColAmtSale.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColAmtSale.Caption = "จำนวนที่ขายแล้ว"
        Me.ColAmtSale.ColumnEdit = Me.rptAmtSale
        Me.ColAmtSale.DisplayFormat.FormatString = "#,##0.####"
        Me.ColAmtSale.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.ColAmtSale.FieldName = "AmtSale"
        Me.ColAmtSale.MaxWidth = 75
        Me.ColAmtSale.MinWidth = 75
        Me.ColAmtSale.Name = "ColAmtSale"
        Me.ColAmtSale.Visible = True
        Me.ColAmtSale.VisibleIndex = 11
        '
        'rptAmtSale
        '
        Me.rptAmtSale.Appearance.ForeColor = System.Drawing.Color.Black
        Me.rptAmtSale.Appearance.Options.UseForeColor = True
        Me.rptAmtSale.AutoHeight = False
        Me.rptAmtSale.DisplayFormat.FormatString = "#,##0.####"
        Me.rptAmtSale.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.rptAmtSale.Name = "rptAmtSale"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Panel7)
        Me.Panel1.Controls.Add(Me.Panel8)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 75)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1184, 35)
        Me.Panel1.TabIndex = 733
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnExcel)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(99, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(139, 35)
        Me.Panel2.TabIndex = 715
        '
        'btnExcel
        '
        Me.btnExcel.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExcel.Appearance.Options.UseFont = True
        Me.btnExcel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExcel.Image = CType(resources.GetObject("btnExcel.Image"), System.Drawing.Image)
        Me.btnExcel.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnExcel.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnExcel.Location = New System.Drawing.Point(3, 3)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(133, 30)
        Me.btnExcel.TabIndex = 714
        Me.btnExcel.Text = "Export Excel"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Transparent
        Me.Panel7.Controls.Add(Me.Label8)
        Me.Panel7.Controls.Add(Me.txtCount)
        Me.Panel7.Controls.Add(Me.Label9)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel7.Location = New System.Drawing.Point(928, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(256, 35)
        Me.Panel7.TabIndex = 600
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label8.Location = New System.Drawing.Point(201, 10)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 16)
        Me.Label8.TabIndex = 602
        Me.Label8.Text = "รายการ"
        '
        'txtCount
        '
        Me.txtCount.BackColor = System.Drawing.Color.Black
        Me.txtCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCount.ForeColor = System.Drawing.Color.Lime
        Me.txtCount.Location = New System.Drawing.Point(97, 6)
        Me.txtCount.Name = "txtCount"
        Me.txtCount.ReadOnly = True
        Me.txtCount.Size = New System.Drawing.Size(98, 24)
        Me.txtCount.TabIndex = 601
        Me.txtCount.Text = "0"
        Me.txtCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label9.Location = New System.Drawing.Point(6, 10)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(94, 16)
        Me.Label9.TabIndex = 600
        Me.Label9.Text = "จำนวนรายการ"
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.btnRefresh)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(99, 35)
        Me.Panel8.TabIndex = 588
        '
        'btnRefresh
        '
        Me.btnRefresh.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Appearance.Options.UseFont = True
        Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), System.Drawing.Image)
        Me.btnRefresh.Location = New System.Drawing.Point(1, 3)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(97, 30)
        Me.btnRefresh.TabIndex = 0
        Me.btnRefresh.Text = "Refresh"
        '
        'PanelControl1
        '
        Me.PanelControl1.Appearance.BackColor = System.Drawing.Color.Lavender
        Me.PanelControl1.Appearance.BackColor2 = System.Drawing.Color.LightSteelBlue
        Me.PanelControl1.Appearance.Options.UseBackColor = True
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.GroupBox2)
        Me.PanelControl1.Controls.Add(Me.GroupBox1)
        Me.PanelControl1.Controls.Add(Me.GroupBox4)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1184, 75)
        Me.PanelControl1.TabIndex = 732
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.rdbNoGroup)
        Me.GroupBox2.Controls.Add(Me.rdbInvName)
        Me.GroupBox2.Controls.Add(Me.rdbCusName)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(1002, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(170, 66)
        Me.GroupBox2.TabIndex = 788
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Tag = ""
        Me.GroupBox2.Text = "จัดกลุ่มตาม"
        '
        'rdbNoGroup
        '
        Me.rdbNoGroup.AutoSize = True
        Me.rdbNoGroup.Checked = True
        Me.rdbNoGroup.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rdbNoGroup.Location = New System.Drawing.Point(13, 42)
        Me.rdbNoGroup.Name = "rdbNoGroup"
        Me.rdbNoGroup.Size = New System.Drawing.Size(73, 18)
        Me.rdbNoGroup.TabIndex = 654
        Me.rdbNoGroup.TabStop = True
        Me.rdbNoGroup.Text = "ไม่จัดกลุ่ม"
        Me.rdbNoGroup.UseVisualStyleBackColor = True
        '
        'rdbInvName
        '
        Me.rdbInvName.AutoSize = True
        Me.rdbInvName.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rdbInvName.Location = New System.Drawing.Point(86, 21)
        Me.rdbInvName.Name = "rdbInvName"
        Me.rdbInvName.Size = New System.Drawing.Size(67, 18)
        Me.rdbInvName.TabIndex = 653
        Me.rdbInvName.Text = "ชื่อสินค้า"
        Me.rdbInvName.UseVisualStyleBackColor = True
        '
        'rdbCusName
        '
        Me.rdbCusName.AutoSize = True
        Me.rdbCusName.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rdbCusName.Location = New System.Drawing.Point(13, 21)
        Me.rdbCusName.Name = "rdbCusName"
        Me.rdbCusName.Size = New System.Drawing.Size(52, 18)
        Me.rdbCusName.TabIndex = 652
        Me.rdbCusName.Text = "ลูกค้า"
        Me.rdbCusName.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.lblInvName)
        Me.GroupBox1.Controls.Add(Me.lblPartnerName)
        Me.GroupBox1.Controls.Add(Me.btnPartner)
        Me.GroupBox1.Controls.Add(Me.btnInvName)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmbGroupComp)
        Me.GroupBox1.Controls.Add(Me.chkInvName)
        Me.GroupBox1.Controls.Add(Me.ChkCus)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(419, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(577, 66)
        Me.GroupBox1.TabIndex = 787
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Tag = ""
        Me.GroupBox1.Text = "ค้นหา"
        '
        'lblInvName
        '
        Me.lblInvName.BackColor = System.Drawing.Color.Gainsboro
        Me.lblInvName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblInvName.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvName.ForeColor = System.Drawing.Color.Black
        Me.lblInvName.Location = New System.Drawing.Point(353, 13)
        Me.lblInvName.Name = "lblInvName"
        Me.lblInvName.Size = New System.Drawing.Size(176, 47)
        Me.lblInvName.TabIndex = 793
        '
        'lblPartnerName
        '
        Me.lblPartnerName.BackColor = System.Drawing.Color.Gainsboro
        Me.lblPartnerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPartnerName.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPartnerName.ForeColor = System.Drawing.Color.Black
        Me.lblPartnerName.Location = New System.Drawing.Point(84, 38)
        Me.lblPartnerName.Name = "lblPartnerName"
        Me.lblPartnerName.Size = New System.Drawing.Size(190, 22)
        Me.lblPartnerName.TabIndex = 792
        '
        'btnPartner
        '
        Me.btnPartner.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPartner.Enabled = False
        Me.btnPartner.Image = CType(resources.GetObject("btnPartner.Image"), System.Drawing.Image)
        Me.btnPartner.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnPartner.Location = New System.Drawing.Point(276, 38)
        Me.btnPartner.Name = "btnPartner"
        Me.btnPartner.Size = New System.Drawing.Size(25, 22)
        Me.btnPartner.TabIndex = 791
        '
        'btnInvName
        '
        Me.btnInvName.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInvName.Enabled = False
        Me.btnInvName.Image = CType(resources.GetObject("btnInvName.Image"), System.Drawing.Image)
        Me.btnInvName.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnInvName.Location = New System.Drawing.Point(532, 13)
        Me.btnInvName.Name = "btnInvName"
        Me.btnInvName.Size = New System.Drawing.Size(25, 22)
        Me.btnInvName.TabIndex = 790
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(40, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 14)
        Me.Label2.TabIndex = 789
        Me.Label2.Text = "บริษัท"
        '
        'cmbGroupComp
        '
        Me.cmbGroupComp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGroupComp.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbGroupComp.FormattingEnabled = True
        Me.cmbGroupComp.Location = New System.Drawing.Point(84, 13)
        Me.cmbGroupComp.Name = "cmbGroupComp"
        Me.cmbGroupComp.Size = New System.Drawing.Size(190, 22)
        Me.cmbGroupComp.TabIndex = 788
        '
        'chkInvName
        '
        Me.chkInvName.AutoSize = True
        Me.chkInvName.BackColor = System.Drawing.Color.Transparent
        Me.chkInvName.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkInvName.Location = New System.Drawing.Point(288, 17)
        Me.chkInvName.Name = "chkInvName"
        Me.chkInvName.Size = New System.Drawing.Size(68, 18)
        Me.chkInvName.TabIndex = 787
        Me.chkInvName.Text = "ชื่อสินค้า"
        Me.chkInvName.UseVisualStyleBackColor = False
        '
        'ChkCus
        '
        Me.ChkCus.AutoSize = True
        Me.ChkCus.BackColor = System.Drawing.Color.Transparent
        Me.ChkCus.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkCus.Location = New System.Drawing.Point(25, 39)
        Me.ChkCus.Name = "ChkCus"
        Me.ChkCus.Size = New System.Drawing.Size(53, 18)
        Me.ChkCus.TabIndex = 412
        Me.ChkCus.Text = "ลูกค้า"
        Me.ChkCus.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.dtpYear)
        Me.GroupBox4.Controls.Add(Me.dtpDateE)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.rdbDate)
        Me.GroupBox4.Controls.Add(Me.dtpDateS)
        Me.GroupBox4.Controls.Add(Me.dtpMonthS)
        Me.GroupBox4.Controls.Add(Me.rdbMonth)
        Me.GroupBox4.Controls.Add(Me.rdbYear)
        Me.GroupBox4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(5, 3)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(415, 66)
        Me.GroupBox4.TabIndex = 606
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "วันที่รับคำสั่งซื้อ"
        '
        'dtpYear
        '
        Me.dtpYear.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpYear.CausesValidation = False
        Me.dtpYear.CustomFormat = "yyyy"
        Me.dtpYear.Enabled = False
        Me.dtpYear.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpYear.Location = New System.Drawing.Point(267, 41)
        Me.dtpYear.Name = "dtpYear"
        Me.dtpYear.ShowUpDown = True
        Me.dtpYear.Size = New System.Drawing.Size(65, 22)
        Me.dtpYear.TabIndex = 651
        Me.dtpYear.Value = New Date(2025, 9, 2, 16, 22, 0, 0)
        '
        'dtpDateE
        '
        Me.dtpDateE.CustomFormat = "ddMMMMyyyy"
        Me.dtpDateE.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpDateE.Location = New System.Drawing.Point(65, 41)
        Me.dtpDateE.MinDate = New Date(1757, 1, 1, 0, 0, 0, 0)
        Me.dtpDateE.Name = "dtpDateE"
        Me.dtpDateE.Size = New System.Drawing.Size(141, 22)
        Me.dtpDateE.TabIndex = 607
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(39, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(20, 14)
        Me.Label5.TabIndex = 605
        Me.Label5.Text = "ถึง"
        '
        'rdbDate
        '
        Me.rdbDate.AutoSize = True
        Me.rdbDate.Checked = True
        Me.rdbDate.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rdbDate.Location = New System.Drawing.Point(15, 17)
        Me.rdbDate.Name = "rdbDate"
        Me.rdbDate.Size = New System.Drawing.Size(47, 18)
        Me.rdbDate.TabIndex = 603
        Me.rdbDate.TabStop = True
        Me.rdbDate.Text = "วันที่"
        Me.rdbDate.UseVisualStyleBackColor = True
        '
        'dtpDateS
        '
        Me.dtpDateS.CustomFormat = "ddMMMMyyyy"
        Me.dtpDateS.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpDateS.Location = New System.Drawing.Point(65, 16)
        Me.dtpDateS.MinDate = New Date(1757, 1, 1, 0, 0, 0, 0)
        Me.dtpDateS.Name = "dtpDateS"
        Me.dtpDateS.Size = New System.Drawing.Size(141, 22)
        Me.dtpDateS.TabIndex = 601
        '
        'dtpMonthS
        '
        Me.dtpMonthS.Checked = False
        Me.dtpMonthS.CustomFormat = "MMMM /yyyy"
        Me.dtpMonthS.Enabled = False
        Me.dtpMonthS.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpMonthS.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpMonthS.Location = New System.Drawing.Point(267, 16)
        Me.dtpMonthS.Name = "dtpMonthS"
        Me.dtpMonthS.Size = New System.Drawing.Size(141, 22)
        Me.dtpMonthS.TabIndex = 649
        '
        'rdbMonth
        '
        Me.rdbMonth.AutoSize = True
        Me.rdbMonth.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rdbMonth.Location = New System.Drawing.Point(215, 17)
        Me.rdbMonth.Name = "rdbMonth"
        Me.rdbMonth.Size = New System.Drawing.Size(50, 18)
        Me.rdbMonth.TabIndex = 604
        Me.rdbMonth.Text = "เดือน"
        Me.rdbMonth.UseVisualStyleBackColor = True
        '
        'rdbYear
        '
        Me.rdbYear.AutoSize = True
        Me.rdbYear.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rdbYear.Location = New System.Drawing.Point(215, 43)
        Me.rdbYear.Name = "rdbYear"
        Me.rdbYear.Size = New System.Drawing.Size(33, 18)
        Me.rdbYear.TabIndex = 606
        Me.rdbYear.Text = "ปี"
        Me.rdbYear.UseVisualStyleBackColor = True
        '
        'GCSlOrderBal
        '
        Me.GCSlOrderBal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCSlOrderBal.Location = New System.Drawing.Point(0, 110)
        Me.GCSlOrderBal.MainView = Me.GVSlOrderBal
        Me.GCSlOrderBal.Name = "GCSlOrderBal"
        Me.GCSlOrderBal.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rptDelDt, Me.rptDelMt, Me.rptAddLot, Me.rptPartnerName, Me.rptProductName, Me.rptAmtSale})
        Me.GCSlOrderBal.Size = New System.Drawing.Size(1184, 441)
        Me.GCSlOrderBal.TabIndex = 797
        Me.GCSlOrderBal.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVSlOrderBal, Me.GVLotSale})
        '
        'GVSlOrderBal
        '
        Me.GVSlOrderBal.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.GVSlOrderBal.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.GVSlOrderBal.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GVSlOrderBal.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVSlOrderBal.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GVSlOrderBal.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GVSlOrderBal.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.GVSlOrderBal.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.GVSlOrderBal.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GVSlOrderBal.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVSlOrderBal.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GVSlOrderBal.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GVSlOrderBal.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.GVSlOrderBal.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.GVSlOrderBal.Appearance.Empty.Options.UseBackColor = True
        Me.GVSlOrderBal.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.GVSlOrderBal.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.GVSlOrderBal.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GVSlOrderBal.Appearance.EvenRow.Options.UseBackColor = True
        Me.GVSlOrderBal.Appearance.EvenRow.Options.UseBorderColor = True
        Me.GVSlOrderBal.Appearance.EvenRow.Options.UseForeColor = True
        Me.GVSlOrderBal.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.GVSlOrderBal.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.GVSlOrderBal.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GVSlOrderBal.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GVSlOrderBal.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GVSlOrderBal.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GVSlOrderBal.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.GVSlOrderBal.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.GVSlOrderBal.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVSlOrderBal.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVSlOrderBal.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GVSlOrderBal.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.GVSlOrderBal.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GVSlOrderBal.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVSlOrderBal.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVSlOrderBal.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.GVSlOrderBal.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.GVSlOrderBal.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVSlOrderBal.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVSlOrderBal.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.GVSlOrderBal.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.GVSlOrderBal.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVSlOrderBal.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVSlOrderBal.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVSlOrderBal.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GVSlOrderBal.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.GVSlOrderBal.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.GVSlOrderBal.Appearance.GroupButton.Options.UseBackColor = True
        Me.GVSlOrderBal.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GVSlOrderBal.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.GVSlOrderBal.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.GVSlOrderBal.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GVSlOrderBal.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVSlOrderBal.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GVSlOrderBal.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GVSlOrderBal.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.GVSlOrderBal.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.GVSlOrderBal.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.GVSlOrderBal.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GVSlOrderBal.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVSlOrderBal.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.GVSlOrderBal.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.GVSlOrderBal.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GVSlOrderBal.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GVSlOrderBal.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVSlOrderBal.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GVSlOrderBal.Appearance.GroupRow.Options.UseFont = True
        Me.GVSlOrderBal.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVSlOrderBal.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.GVSlOrderBal.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.GVSlOrderBal.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GVSlOrderBal.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVSlOrderBal.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVSlOrderBal.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GVSlOrderBal.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.GVSlOrderBal.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.GVSlOrderBal.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVSlOrderBal.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVSlOrderBal.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.GVSlOrderBal.Appearance.HorzLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.GVSlOrderBal.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVSlOrderBal.Appearance.HorzLine.Options.UseBorderColor = True
        Me.GVSlOrderBal.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.GVSlOrderBal.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.GVSlOrderBal.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GVSlOrderBal.Appearance.OddRow.Options.UseBackColor = True
        Me.GVSlOrderBal.Appearance.OddRow.Options.UseBorderColor = True
        Me.GVSlOrderBal.Appearance.OddRow.Options.UseForeColor = True
        Me.GVSlOrderBal.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GVSlOrderBal.Appearance.Preview.BorderColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GVSlOrderBal.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.GVSlOrderBal.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.GVSlOrderBal.Appearance.Preview.Options.UseBackColor = True
        Me.GVSlOrderBal.Appearance.Preview.Options.UseBorderColor = True
        Me.GVSlOrderBal.Appearance.Preview.Options.UseFont = True
        Me.GVSlOrderBal.Appearance.Preview.Options.UseForeColor = True
        Me.GVSlOrderBal.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.GVSlOrderBal.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.GVSlOrderBal.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GVSlOrderBal.Appearance.Row.Options.UseBackColor = True
        Me.GVSlOrderBal.Appearance.Row.Options.UseBorderColor = True
        Me.GVSlOrderBal.Appearance.Row.Options.UseForeColor = True
        Me.GVSlOrderBal.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.GVSlOrderBal.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.GVSlOrderBal.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GVSlOrderBal.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.GVSlOrderBal.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.GVSlOrderBal.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVSlOrderBal.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GVSlOrderBal.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GVSlOrderBal.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GVSlOrderBal.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.GVSlOrderBal.Appearance.VertLine.Options.UseBackColor = True
        Me.GVSlOrderBal.ColumnPanelRowHeight = 35
        Me.GVSlOrderBal.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColNum, Me.ColDocCode, Me.ColDocRef, Me.ColDateOrder, Me.ColPartnerName, Me.ColPsSale, Me.ColPayTspName, Me.ColDateRequired, Me.ColInvName, Me.ColPrice, Me.ColAmtOrder, Me.ColAmtSale, Me.ColAmtOrderBal, Me.ColUnitC, Me.idSaleOrderDt})
        Me.GVSlOrderBal.CustomizationFormBounds = New System.Drawing.Rectangle(0, 259, 210, 347)
        Me.GVSlOrderBal.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        GridFormatRule1.Column = Me.ColAmtSale
        GridFormatRule1.ColumnApplyTo = Me.ColAmtSale
        GridFormatRule1.Name = "Format0"
        FormatConditionRuleExpression1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        FormatConditionRuleExpression1.Appearance.Options.UseFont = True
        FormatConditionRuleExpression1.Expression = "[AmtOrder] > [AmtSale]"
        FormatConditionRuleExpression1.PredefinedName = "Red Text"
        GridFormatRule1.Rule = FormatConditionRuleExpression1
        Me.GVSlOrderBal.FormatRules.Add(GridFormatRule1)
        Me.GVSlOrderBal.GridControl = Me.GCSlOrderBal
        Me.GVSlOrderBal.IndicatorWidth = 30
        Me.GVSlOrderBal.Name = "GVSlOrderBal"
        Me.GVSlOrderBal.OptionsBehavior.AutoExpandAllGroups = True
        Me.GVSlOrderBal.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect
        Me.GVSlOrderBal.OptionsView.EnableAppearanceEvenRow = True
        Me.GVSlOrderBal.OptionsView.EnableAppearanceOddRow = True
        Me.GVSlOrderBal.OptionsView.RowAutoHeight = True
        Me.GVSlOrderBal.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GVSlOrderBal.OptionsView.ShowGroupPanel = False
        Me.GVSlOrderBal.OptionsView.ShowIndicator = False
        Me.GVSlOrderBal.PaintStyleName = "MixedXP"
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
        Me.ColNum.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColNum.Caption = "ลำดับ"
        Me.ColNum.FieldName = "RowNum"
        Me.ColNum.MaxWidth = 40
        Me.ColNum.MinWidth = 40
        Me.ColNum.Name = "ColNum"
        Me.ColNum.OptionsColumn.AllowEdit = False
        Me.ColNum.OptionsColumn.Printable = DevExpress.Utils.DefaultBoolean.[True]
        Me.ColNum.OptionsColumn.ReadOnly = True
        Me.ColNum.Visible = True
        Me.ColNum.VisibleIndex = 0
        Me.ColNum.Width = 40
        '
        'ColDocCode
        '
        Me.ColDocCode.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColDocCode.AppearanceCell.Options.UseFont = True
        Me.ColDocCode.AppearanceCell.Options.UseTextOptions = True
        Me.ColDocCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDocCode.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColDocCode.AppearanceHeader.Options.UseFont = True
        Me.ColDocCode.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDocCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDocCode.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColDocCode.Caption = "เลขที่ออเดอร์"
        Me.ColDocCode.FieldName = "DocCode"
        Me.ColDocCode.MaxWidth = 85
        Me.ColDocCode.MinWidth = 85
        Me.ColDocCode.Name = "ColDocCode"
        Me.ColDocCode.OptionsColumn.AllowEdit = False
        Me.ColDocCode.OptionsColumn.ReadOnly = True
        Me.ColDocCode.Visible = True
        Me.ColDocCode.VisibleIndex = 1
        Me.ColDocCode.Width = 85
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
        Me.ColDocRef.Caption = "เลขที่อ้างอิง"
        Me.ColDocRef.FieldName = "DocRef"
        Me.ColDocRef.MaxWidth = 85
        Me.ColDocRef.MinWidth = 85
        Me.ColDocRef.Name = "ColDocRef"
        Me.ColDocRef.OptionsColumn.AllowEdit = False
        Me.ColDocRef.OptionsColumn.ReadOnly = True
        Me.ColDocRef.Visible = True
        Me.ColDocRef.VisibleIndex = 2
        Me.ColDocRef.Width = 85
        '
        'ColDateOrder
        '
        Me.ColDateOrder.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColDateOrder.AppearanceCell.Options.UseFont = True
        Me.ColDateOrder.AppearanceCell.Options.UseTextOptions = True
        Me.ColDateOrder.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDateOrder.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColDateOrder.AppearanceHeader.Options.UseFont = True
        Me.ColDateOrder.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDateOrder.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDateOrder.Caption = "วันที่สั่งซื้อ"
        Me.ColDateOrder.FieldName = "DateOrderD"
        Me.ColDateOrder.MaxWidth = 75
        Me.ColDateOrder.MinWidth = 75
        Me.ColDateOrder.Name = "ColDateOrder"
        Me.ColDateOrder.OptionsColumn.AllowEdit = False
        Me.ColDateOrder.OptionsColumn.ReadOnly = True
        Me.ColDateOrder.Visible = True
        Me.ColDateOrder.VisibleIndex = 3
        '
        'ColPartnerName
        '
        Me.ColPartnerName.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColPartnerName.AppearanceCell.Options.UseFont = True
        Me.ColPartnerName.AppearanceCell.Options.UseTextOptions = True
        Me.ColPartnerName.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.ColPartnerName.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColPartnerName.AppearanceHeader.Options.UseFont = True
        Me.ColPartnerName.AppearanceHeader.Options.UseTextOptions = True
        Me.ColPartnerName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColPartnerName.Caption = "ลูกค้า"
        Me.ColPartnerName.ColumnEdit = Me.rptPartnerName
        Me.ColPartnerName.FieldName = "PartNerName"
        Me.ColPartnerName.MinWidth = 250
        Me.ColPartnerName.Name = "ColPartnerName"
        Me.ColPartnerName.OptionsColumn.AllowEdit = False
        Me.ColPartnerName.OptionsColumn.ReadOnly = True
        Me.ColPartnerName.Visible = True
        Me.ColPartnerName.VisibleIndex = 4
        Me.ColPartnerName.Width = 250
        '
        'rptPartnerName
        '
        Me.rptPartnerName.Appearance.Options.UseTextOptions = True
        Me.rptPartnerName.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.rptPartnerName.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.rptPartnerName.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.rptPartnerName.Name = "rptPartnerName"
        '
        'ColPsSale
        '
        Me.ColPsSale.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColPsSale.AppearanceCell.Options.UseFont = True
        Me.ColPsSale.AppearanceCell.Options.UseTextOptions = True
        Me.ColPsSale.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.ColPsSale.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColPsSale.AppearanceHeader.Options.UseFont = True
        Me.ColPsSale.AppearanceHeader.Options.UseTextOptions = True
        Me.ColPsSale.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColPsSale.Caption = "พนักงานขาย"
        Me.ColPsSale.FieldName = "PsSale"
        Me.ColPsSale.MinWidth = 135
        Me.ColPsSale.Name = "ColPsSale"
        Me.ColPsSale.OptionsColumn.AllowEdit = False
        Me.ColPsSale.OptionsColumn.ReadOnly = True
        Me.ColPsSale.Visible = True
        Me.ColPsSale.VisibleIndex = 5
        Me.ColPsSale.Width = 150
        '
        'ColPayTspName
        '
        Me.ColPayTspName.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColPayTspName.AppearanceCell.Options.UseFont = True
        Me.ColPayTspName.AppearanceCell.Options.UseTextOptions = True
        Me.ColPayTspName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.ColPayTspName.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColPayTspName.AppearanceHeader.Options.UseFont = True
        Me.ColPayTspName.AppearanceHeader.Options.UseTextOptions = True
        Me.ColPayTspName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColPayTspName.Caption = "การขนส่ง"
        Me.ColPayTspName.FieldName = "PayTspName"
        Me.ColPayTspName.MinWidth = 100
        Me.ColPayTspName.Name = "ColPayTspName"
        Me.ColPayTspName.OptionsColumn.AllowEdit = False
        Me.ColPayTspName.OptionsColumn.ReadOnly = True
        Me.ColPayTspName.Visible = True
        Me.ColPayTspName.VisibleIndex = 7
        Me.ColPayTspName.Width = 101
        '
        'ColDateRequired
        '
        Me.ColDateRequired.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColDateRequired.AppearanceCell.Options.UseFont = True
        Me.ColDateRequired.AppearanceCell.Options.UseTextOptions = True
        Me.ColDateRequired.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDateRequired.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColDateRequired.AppearanceHeader.Options.UseFont = True
        Me.ColDateRequired.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDateRequired.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDateRequired.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColDateRequired.Caption = "กำหนดส่งมอบวันที่"
        Me.ColDateRequired.FieldName = "DateRequireD"
        Me.ColDateRequired.MaxWidth = 75
        Me.ColDateRequired.MinWidth = 75
        Me.ColDateRequired.Name = "ColDateRequired"
        Me.ColDateRequired.Visible = True
        Me.ColDateRequired.VisibleIndex = 6
        '
        'ColInvName
        '
        Me.ColInvName.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColInvName.AppearanceCell.Options.UseFont = True
        Me.ColInvName.AppearanceCell.Options.UseTextOptions = True
        Me.ColInvName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.ColInvName.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.ColInvName.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColInvName.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColInvName.AppearanceHeader.Options.UseFont = True
        Me.ColInvName.AppearanceHeader.Options.UseTextOptions = True
        Me.ColInvName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColInvName.Caption = "ชื่อสินค้า"
        Me.ColInvName.ColumnEdit = Me.rptProductName
        Me.ColInvName.FieldName = "InvName"
        Me.ColInvName.MinWidth = 200
        Me.ColInvName.Name = "ColInvName"
        Me.ColInvName.OptionsColumn.AllowEdit = False
        Me.ColInvName.OptionsColumn.ReadOnly = True
        Me.ColInvName.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "name", "ทั้งหมด {0:0} รายการ")})
        Me.ColInvName.Visible = True
        Me.ColInvName.VisibleIndex = 8
        Me.ColInvName.Width = 628
        '
        'rptProductName
        '
        Me.rptProductName.Appearance.Options.UseTextOptions = True
        Me.rptProductName.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.rptProductName.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.rptProductName.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.rptProductName.Name = "rptProductName"
        '
        'ColPrice
        '
        Me.ColPrice.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColPrice.AppearanceCell.Options.UseFont = True
        Me.ColPrice.AppearanceCell.Options.UseTextOptions = True
        Me.ColPrice.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ColPrice.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColPrice.AppearanceHeader.Options.UseFont = True
        Me.ColPrice.AppearanceHeader.Options.UseTextOptions = True
        Me.ColPrice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColPrice.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColPrice.Caption = "ราคาต่อหน่วย"
        Me.ColPrice.DisplayFormat.FormatString = "N2"
        Me.ColPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColPrice.FieldName = "Price"
        Me.ColPrice.MaxWidth = 55
        Me.ColPrice.MinWidth = 55
        Me.ColPrice.Name = "ColPrice"
        Me.ColPrice.OptionsColumn.AllowEdit = False
        Me.ColPrice.OptionsColumn.ReadOnly = True
        Me.ColPrice.Visible = True
        Me.ColPrice.VisibleIndex = 9
        Me.ColPrice.Width = 55
        '
        'ColAmtOrder
        '
        Me.ColAmtOrder.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColAmtOrder.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.ColAmtOrder.AppearanceCell.Options.UseFont = True
        Me.ColAmtOrder.AppearanceCell.Options.UseForeColor = True
        Me.ColAmtOrder.AppearanceCell.Options.UseTextOptions = True
        Me.ColAmtOrder.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ColAmtOrder.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColAmtOrder.AppearanceHeader.Options.UseFont = True
        Me.ColAmtOrder.AppearanceHeader.Options.UseTextOptions = True
        Me.ColAmtOrder.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColAmtOrder.Caption = "จำนวนสั่งซื้อ"
        Me.ColAmtOrder.DisplayFormat.FormatString = "#,##0.####"
        Me.ColAmtOrder.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.ColAmtOrder.FieldName = "AmtOrder"
        Me.ColAmtOrder.MaxWidth = 75
        Me.ColAmtOrder.MinWidth = 75
        Me.ColAmtOrder.Name = "ColAmtOrder"
        Me.ColAmtOrder.OptionsColumn.AllowEdit = False
        Me.ColAmtOrder.OptionsColumn.ReadOnly = True
        Me.ColAmtOrder.Visible = True
        Me.ColAmtOrder.VisibleIndex = 10
        '
        'ColAmtOrderBal
        '
        Me.ColAmtOrderBal.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.ColAmtOrderBal.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColAmtOrderBal.AppearanceCell.Options.UseBackColor = True
        Me.ColAmtOrderBal.AppearanceCell.Options.UseFont = True
        Me.ColAmtOrderBal.AppearanceCell.Options.UseTextOptions = True
        Me.ColAmtOrderBal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ColAmtOrderBal.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColAmtOrderBal.AppearanceHeader.Options.UseFont = True
        Me.ColAmtOrderBal.AppearanceHeader.Options.UseTextOptions = True
        Me.ColAmtOrderBal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColAmtOrderBal.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColAmtOrderBal.Caption = "จน.สั่งซื้อคงค้าง"
        Me.ColAmtOrderBal.DisplayFormat.FormatString = "#,##0.####"
        Me.ColAmtOrderBal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.ColAmtOrderBal.FieldName = "AmtOrderBal"
        Me.ColAmtOrderBal.MaxWidth = 75
        Me.ColAmtOrderBal.MinWidth = 75
        Me.ColAmtOrderBal.Name = "ColAmtOrderBal"
        Me.ColAmtOrderBal.OptionsColumn.AllowEdit = False
        Me.ColAmtOrderBal.OptionsColumn.ReadOnly = True
        Me.ColAmtOrderBal.Visible = True
        Me.ColAmtOrderBal.VisibleIndex = 12
        '
        'ColUnitC
        '
        Me.ColUnitC.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColUnitC.AppearanceCell.Options.UseFont = True
        Me.ColUnitC.AppearanceCell.Options.UseTextOptions = True
        Me.ColUnitC.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColUnitC.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColUnitC.AppearanceHeader.Options.UseFont = True
        Me.ColUnitC.AppearanceHeader.Options.UseTextOptions = True
        Me.ColUnitC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColUnitC.Caption = "หน่วย"
        Me.ColUnitC.FieldName = "UnitName"
        Me.ColUnitC.MaxWidth = 75
        Me.ColUnitC.MinWidth = 75
        Me.ColUnitC.Name = "ColUnitC"
        Me.ColUnitC.OptionsColumn.AllowEdit = False
        Me.ColUnitC.OptionsColumn.ReadOnly = True
        Me.ColUnitC.Visible = True
        Me.ColUnitC.VisibleIndex = 13
        '
        'idSaleOrderDt
        '
        Me.idSaleOrderDt.Caption = "idSaleOrderDt"
        Me.idSaleOrderDt.FieldName = "idSaleOrderDt"
        Me.idSaleOrderDt.Name = "idSaleOrderDt"
        '
        'rptDelDt
        '
        Me.rptDelDt.AutoHeight = False
        Me.rptDelDt.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("rptDelDt.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.rptDelDt.Name = "rptDelDt"
        Me.rptDelDt.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'rptDelMt
        '
        Me.rptDelMt.AutoHeight = False
        Me.rptDelMt.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("rptDelMt.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject2, "", Nothing, Nothing, True)})
        Me.rptDelMt.Name = "rptDelMt"
        Me.rptDelMt.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'rptAddLot
        '
        Me.rptAddLot.AutoHeight = False
        Me.rptAddLot.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("rptAddLot.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject3, "", Nothing, Nothing, True)})
        Me.rptAddLot.Name = "rptAddLot"
        Me.rptAddLot.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'GVLotSale
        '
        Me.GVLotSale.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColidRefLot_, Me.LotNo, Me.ColWHName, Me.ColAmtBal, Me.colDateGen, Me.ColMFG, Me.ColUnitBal, Me.ColAmountCut, Me.ColDelLot, Me.ColidLot, Me.ColidSaleOrderDt, Me.ColidUnitBal, Me.ColidWh, Me.idLotSPM, Me.ColCompRec, Me.ColAmtCurStock})
        GridFormatRule2.Name = "Format0"
        GridFormatRule2.Rule = Nothing
        Me.GVLotSale.FormatRules.Add(GridFormatRule2)
        Me.GVLotSale.GridControl = Me.GCSlOrderBal
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
        Me.LotNo.VisibleIndex = 0
        Me.LotNo.Width = 810
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
        Me.ColWHName.ColumnEdit = Me.rptPartnerName
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
        Me.ColDelLot.ColumnEdit = Me.rptDelDt
        Me.ColDelLot.MaxWidth = 30
        Me.ColDelLot.MinWidth = 30
        Me.ColDelLot.Name = "ColDelLot"
        Me.ColDelLot.Visible = True
        Me.ColDelLot.VisibleIndex = 7
        Me.ColDelLot.Width = 30
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
        'frmSlOrderBalance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1184, 551)
        Me.Controls.Add(Me.GCSlOrderBal)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSlOrderBalance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "รายงานการสั่งซื้อคงค้าง"
        CType(Me.rptAmtSale, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.GCSlOrderBal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVSlOrderBal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptPartnerName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptProductName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptDelDt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptDelMt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptAddLot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVLotSale, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents txtCount As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents btnRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chkInvName As CheckBox
    Friend WithEvents ChkCus As CheckBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents dtpYear As DateTimePicker
    Friend WithEvents dtpDateE As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents rdbDate As RadioButton
    Friend WithEvents dtpDateS As DateTimePicker
    Friend WithEvents dtpMonthS As DateTimePicker
    Friend WithEvents rdbMonth As RadioButton
    Friend WithEvents rdbYear As RadioButton
    Friend WithEvents GCSlOrderBal As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVSlOrderBal As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColNum As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDocCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColPartnerName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColInvName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rptProductName As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents ColAmtOrder As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColAmtSale As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColAmtOrderBal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColUnitC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rptDelDt As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents rptDelMt As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents rptAddLot As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents rptPartnerName As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents GVLotSale As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColidRefLot_ As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LotNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColWHName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColAmtBal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDateGen As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColMFG As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColUnitBal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColAmountCut As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDelLot As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColidLot As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColidSaleOrderDt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColidUnitBal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColidWh As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents idLotSPM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColCompRec As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColAmtCurStock As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbGroupComp As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rdbInvName As RadioButton
    Friend WithEvents rdbCusName As RadioButton
    Friend WithEvents rdbNoGroup As RadioButton
    Friend WithEvents rptAmtSale As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents idSaleOrderDt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDocRef As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnExcel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnInvName As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnPartner As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblPartnerName As Label
    Friend WithEvents lblInvName As Label
    Friend WithEvents ColPsSale As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDateOrder As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColPayTspName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDateRequired As DevExpress.XtraGrid.Columns.GridColumn
End Class
