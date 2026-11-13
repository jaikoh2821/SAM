<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSaleRpt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSaleRpt))
        Me.rdbCus = New System.Windows.Forms.RadioButton()
        Me.rdbPd = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rdbTsp = New System.Windows.Forms.RadioButton()
        Me.rdbCusNoSale = New System.Windows.Forms.RadioButton()
        Me.rdbPdNoSale = New System.Windows.Forms.RadioButton()
        Me.rdbDaily = New System.Windows.Forms.RadioButton()
        Me.rdbDoc = New System.Windows.Forms.RadioButton()
        Me.rdbPsSale = New System.Windows.Forms.RadioButton()
        Me.lblCus = New System.Windows.Forms.Label()
        Me.lblPsSale = New System.Windows.Forms.Label()
        Me.CheckCus = New System.Windows.Forms.CheckBox()
        Me.btnPsSale = New System.Windows.Forms.Button()
        Me.btnCustomer = New System.Windows.Forms.Button()
        Me.CheckPsSale = New System.Windows.Forms.CheckBox()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbSlAVxST = New System.Windows.Forms.CheckBox()
        Me.chkLotNo = New System.Windows.Forms.CheckBox()
        Me.txtLotNo = New System.Windows.Forms.TextBox()
        Me.dtpYear = New System.Windows.Forms.DateTimePicker()
        Me.rdbYear = New System.Windows.Forms.RadioButton()
        Me.dtpMonth = New System.Windows.Forms.DateTimePicker()
        Me.rdbMonth = New System.Windows.Forms.RadioButton()
        Me.ccbtDocType = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.rdbDate = New System.Windows.Forms.RadioButton()
        Me.dtpSaleE = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblPdName = New System.Windows.Forms.Label()
        Me.dtpSaleS = New System.Windows.Forms.DateTimePicker()
        Me.CheckRefNo = New System.Windows.Forms.CheckBox()
        Me.btnPd = New System.Windows.Forms.Button()
        Me.txtRefNo = New System.Windows.Forms.TextBox()
        Me.txtDocNo = New System.Windows.Forms.TextBox()
        Me.CheckPdName = New System.Windows.Forms.CheckBox()
        Me.CheckDocType = New System.Windows.Forms.CheckBox()
        Me.CheckDocNo = New System.Windows.Forms.CheckBox()
        Me.CheckPdNo = New System.Windows.Forms.CheckBox()
        Me.txtPdNo = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cbMeterial = New System.Windows.Forms.CheckBox()
        Me.ChkTsp = New System.Windows.Forms.CheckBox()
        Me.CheckGen = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdbGenPA = New System.Windows.Forms.RadioButton()
        Me.rdbGenPN = New System.Windows.Forms.RadioButton()
        Me.rdbGenPC = New System.Windows.Forms.RadioButton()
        Me.CheckOther = New System.Windows.Forms.CheckBox()
        Me.CheckMat = New System.Windows.Forms.CheckBox()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.cmbGroupComp = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.lblPsOrder = New System.Windows.Forms.Label()
        Me.btnPsOrder = New System.Windows.Forms.Button()
        Me.cbPsOrder = New System.Windows.Forms.CheckBox()
        Me.rdbPsOrder = New System.Windows.Forms.RadioButton()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ccbtDocType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        Me.SuspendLayout()
        '
        'rdbCus
        '
        Me.rdbCus.AutoSize = True
        Me.rdbCus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rdbCus.Location = New System.Drawing.Point(185, 27)
        Me.rdbCus.Name = "rdbCus"
        Me.rdbCus.Size = New System.Drawing.Size(102, 17)
        Me.rdbCus.TabIndex = 615
        Me.rdbCus.Text = "จัดกุล่มตามลูกค้า"
        Me.rdbCus.UseVisualStyleBackColor = True
        '
        'rdbPd
        '
        Me.rdbPd.AutoSize = True
        Me.rdbPd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rdbPd.Location = New System.Drawing.Point(185, 62)
        Me.rdbPd.Name = "rdbPd"
        Me.rdbPd.Size = New System.Drawing.Size(103, 17)
        Me.rdbPd.TabIndex = 616
        Me.rdbPd.Text = "จัดกลุ่มตามสินค้า"
        Me.rdbPd.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.rdbPsOrder)
        Me.GroupBox3.Controls.Add(Me.rdbTsp)
        Me.GroupBox3.Controls.Add(Me.rdbCusNoSale)
        Me.GroupBox3.Controls.Add(Me.rdbPdNoSale)
        Me.GroupBox3.Controls.Add(Me.rdbDaily)
        Me.GroupBox3.Controls.Add(Me.rdbDoc)
        Me.GroupBox3.Controls.Add(Me.rdbPsSale)
        Me.GroupBox3.Controls.Add(Me.rdbCus)
        Me.GroupBox3.Controls.Add(Me.rdbPd)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(16, 43)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(321, 188)
        Me.GroupBox3.TabIndex = 616
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "ประเภทรายงาน"
        '
        'rdbTsp
        '
        Me.rdbTsp.AutoSize = True
        Me.rdbTsp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rdbTsp.Location = New System.Drawing.Point(185, 98)
        Me.rdbTsp.Name = "rdbTsp"
        Me.rdbTsp.Size = New System.Drawing.Size(120, 17)
        Me.rdbTsp.TabIndex = 623
        Me.rdbTsp.Text = "จัดกลุ่มตามการขนส่ง"
        Me.rdbTsp.UseVisualStyleBackColor = True
        '
        'rdbCusNoSale
        '
        Me.rdbCusNoSale.AutoSize = True
        Me.rdbCusNoSale.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rdbCusNoSale.Location = New System.Drawing.Point(20, 131)
        Me.rdbCusNoSale.Name = "rdbCusNoSale"
        Me.rdbCusNoSale.Size = New System.Drawing.Size(151, 17)
        Me.rdbCusNoSale.TabIndex = 622
        Me.rdbCusNoSale.Text = "รายการลูกค้าที่ไม่มียอดขาย"
        Me.rdbCusNoSale.UseVisualStyleBackColor = True
        '
        'rdbPdNoSale
        '
        Me.rdbPdNoSale.AutoSize = True
        Me.rdbPdNoSale.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rdbPdNoSale.Location = New System.Drawing.Point(20, 166)
        Me.rdbPdNoSale.Name = "rdbPdNoSale"
        Me.rdbPdNoSale.Size = New System.Drawing.Size(152, 17)
        Me.rdbPdNoSale.TabIndex = 621
        Me.rdbPdNoSale.Text = "รายการสินค้าที่ไม่มียอดขาย"
        Me.rdbPdNoSale.UseVisualStyleBackColor = True
        Me.rdbPdNoSale.Visible = False
        '
        'rdbDaily
        '
        Me.rdbDaily.AutoSize = True
        Me.rdbDaily.Checked = True
        Me.rdbDaily.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rdbDaily.Location = New System.Drawing.Point(20, 27)
        Me.rdbDaily.Name = "rdbDaily"
        Me.rdbDaily.Size = New System.Drawing.Size(104, 17)
        Me.rdbDaily.TabIndex = 620
        Me.rdbDaily.TabStop = True
        Me.rdbDaily.Text = "รายงานประจำวัน"
        Me.rdbDaily.UseVisualStyleBackColor = True
        '
        'rdbDoc
        '
        Me.rdbDoc.AutoSize = True
        Me.rdbDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rdbDoc.Location = New System.Drawing.Point(20, 98)
        Me.rdbDoc.Name = "rdbDoc"
        Me.rdbDoc.Size = New System.Drawing.Size(128, 17)
        Me.rdbDoc.TabIndex = 618
        Me.rdbDoc.Text = "จัดกลุ่มตามเลขที่อ้างอิง"
        Me.rdbDoc.UseVisualStyleBackColor = True
        '
        'rdbPsSale
        '
        Me.rdbPsSale.AutoSize = True
        Me.rdbPsSale.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rdbPsSale.Location = New System.Drawing.Point(20, 62)
        Me.rdbPsSale.Name = "rdbPsSale"
        Me.rdbPsSale.Size = New System.Drawing.Size(138, 17)
        Me.rdbPsSale.TabIndex = 618
        Me.rdbPsSale.Text = "จัดกลุ่มตามเจ้าหน้าที่ขาย"
        Me.rdbPsSale.UseVisualStyleBackColor = True
        '
        'lblCus
        '
        Me.lblCus.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblCus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCus.Enabled = False
        Me.lblCus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblCus.Location = New System.Drawing.Point(105, 278)
        Me.lblCus.Name = "lblCus"
        Me.lblCus.Size = New System.Drawing.Size(170, 20)
        Me.lblCus.TabIndex = 624
        Me.lblCus.Tag = "0"
        '
        'lblPsSale
        '
        Me.lblPsSale.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblPsSale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPsSale.Enabled = False
        Me.lblPsSale.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblPsSale.Location = New System.Drawing.Point(105, 304)
        Me.lblPsSale.Name = "lblPsSale"
        Me.lblPsSale.Size = New System.Drawing.Size(170, 20)
        Me.lblPsSale.TabIndex = 627
        Me.lblPsSale.Tag = "0"
        '
        'CheckCus
        '
        Me.CheckCus.AutoSize = True
        Me.CheckCus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.CheckCus.Location = New System.Drawing.Point(15, 281)
        Me.CheckCus.Name = "CheckCus"
        Me.CheckCus.Size = New System.Drawing.Size(51, 17)
        Me.CheckCus.TabIndex = 625
        Me.CheckCus.Text = "ลูกค้า"
        Me.CheckCus.UseVisualStyleBackColor = True
        '
        'btnPsSale
        '
        Me.btnPsSale.BackColor = System.Drawing.Color.DimGray
        Me.btnPsSale.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPsSale.Enabled = False
        Me.btnPsSale.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.7!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnPsSale.ForeColor = System.Drawing.Color.White
        Me.btnPsSale.Image = CType(resources.GetObject("btnPsSale.Image"), System.Drawing.Image)
        Me.btnPsSale.Location = New System.Drawing.Point(279, 303)
        Me.btnPsSale.Name = "btnPsSale"
        Me.btnPsSale.Size = New System.Drawing.Size(28, 25)
        Me.btnPsSale.TabIndex = 629
        Me.btnPsSale.Tag = "Add"
        Me.btnPsSale.UseVisualStyleBackColor = False
        '
        'btnCustomer
        '
        Me.btnCustomer.BackColor = System.Drawing.Color.DimGray
        Me.btnCustomer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCustomer.Enabled = False
        Me.btnCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.7!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnCustomer.ForeColor = System.Drawing.Color.White
        Me.btnCustomer.Image = CType(resources.GetObject("btnCustomer.Image"), System.Drawing.Image)
        Me.btnCustomer.Location = New System.Drawing.Point(279, 276)
        Me.btnCustomer.Name = "btnCustomer"
        Me.btnCustomer.Size = New System.Drawing.Size(28, 25)
        Me.btnCustomer.TabIndex = 626
        Me.btnCustomer.Tag = "Add"
        Me.btnCustomer.UseVisualStyleBackColor = False
        '
        'CheckPsSale
        '
        Me.CheckPsSale.AutoSize = True
        Me.CheckPsSale.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.CheckPsSale.Location = New System.Drawing.Point(15, 306)
        Me.CheckPsSale.Name = "CheckPsSale"
        Me.CheckPsSale.Size = New System.Drawing.Size(87, 17)
        Me.CheckPsSale.TabIndex = 628
        Me.CheckPsSale.Text = "เจ้าหน้าที่ขาย"
        Me.CheckPsSale.UseVisualStyleBackColor = True
        '
        'btnShow
        '
        Me.btnShow.BackColor = System.Drawing.Color.DimGray
        Me.btnShow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnShow.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnShow.ForeColor = System.Drawing.Color.White
        Me.btnShow.Image = CType(resources.GetObject("btnShow.Image"), System.Drawing.Image)
        Me.btnShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnShow.Location = New System.Drawing.Point(0, 0)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(115, 35)
        Me.btnShow.TabIndex = 580
        Me.btnShow.Tag = ""
        Me.btnShow.Text = "       แสดงข้อมูล"
        Me.btnShow.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.lblPsOrder)
        Me.GroupBox2.Controls.Add(Me.btnPsOrder)
        Me.GroupBox2.Controls.Add(Me.cbPsOrder)
        Me.GroupBox2.Controls.Add(Me.cbSlAVxST)
        Me.GroupBox2.Controls.Add(Me.chkLotNo)
        Me.GroupBox2.Controls.Add(Me.txtLotNo)
        Me.GroupBox2.Controls.Add(Me.dtpYear)
        Me.GroupBox2.Controls.Add(Me.rdbYear)
        Me.GroupBox2.Controls.Add(Me.dtpMonth)
        Me.GroupBox2.Controls.Add(Me.rdbMonth)
        Me.GroupBox2.Controls.Add(Me.ccbtDocType)
        Me.GroupBox2.Controls.Add(Me.CheckCus)
        Me.GroupBox2.Controls.Add(Me.rdbDate)
        Me.GroupBox2.Controls.Add(Me.dtpSaleE)
        Me.GroupBox2.Controls.Add(Me.lblPsSale)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.lblPdName)
        Me.GroupBox2.Controls.Add(Me.dtpSaleS)
        Me.GroupBox2.Controls.Add(Me.btnPsSale)
        Me.GroupBox2.Controls.Add(Me.CheckRefNo)
        Me.GroupBox2.Controls.Add(Me.btnPd)
        Me.GroupBox2.Controls.Add(Me.txtRefNo)
        Me.GroupBox2.Controls.Add(Me.txtDocNo)
        Me.GroupBox2.Controls.Add(Me.CheckPdName)
        Me.GroupBox2.Controls.Add(Me.CheckDocType)
        Me.GroupBox2.Controls.Add(Me.btnCustomer)
        Me.GroupBox2.Controls.Add(Me.CheckDocNo)
        Me.GroupBox2.Controls.Add(Me.CheckPdNo)
        Me.GroupBox2.Controls.Add(Me.lblCus)
        Me.GroupBox2.Controls.Add(Me.CheckPsSale)
        Me.GroupBox2.Controls.Add(Me.txtPdNo)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(343, 7)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(319, 379)
        Me.GroupBox2.TabIndex = 619
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "เงื่อนไข"
        '
        'cbSlAVxST
        '
        Me.cbSlAVxST.AutoSize = True
        Me.cbSlAVxST.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cbSlAVxST.Location = New System.Drawing.Point(15, 355)
        Me.cbSlAVxST.Name = "cbSlAVxST"
        Me.cbSlAVxST.Size = New System.Drawing.Size(205, 17)
        Me.cbSlAVxST.TabIndex = 969
        Me.cbSlAVxST.Text = "แสดงเฉพาะรายการขายระหว่าง AV-ST"
        Me.cbSlAVxST.UseVisualStyleBackColor = True
        '
        'chkLotNo
        '
        Me.chkLotNo.AutoSize = True
        Me.chkLotNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.chkLotNo.Location = New System.Drawing.Point(15, 229)
        Me.chkLotNo.Name = "chkLotNo"
        Me.chkLotNo.Size = New System.Drawing.Size(61, 17)
        Me.chkLotNo.TabIndex = 652
        Me.chkLotNo.Text = "Lot No."
        Me.chkLotNo.UseVisualStyleBackColor = True
        '
        'txtLotNo
        '
        Me.txtLotNo.Enabled = False
        Me.txtLotNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtLotNo.Location = New System.Drawing.Point(105, 227)
        Me.txtLotNo.Name = "txtLotNo"
        Me.txtLotNo.Size = New System.Drawing.Size(170, 20)
        Me.txtLotNo.TabIndex = 651
        '
        'dtpYear
        '
        Me.dtpYear.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpYear.CausesValidation = False
        Me.dtpYear.CustomFormat = "yyyy"
        Me.dtpYear.Enabled = False
        Me.dtpYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpYear.Location = New System.Drawing.Point(105, 99)
        Me.dtpYear.Name = "dtpYear"
        Me.dtpYear.ShowUpDown = True
        Me.dtpYear.Size = New System.Drawing.Size(170, 20)
        Me.dtpYear.TabIndex = 650
        Me.dtpYear.Value = New Date(2018, 7, 4, 0, 0, 0, 0)
        '
        'rdbYear
        '
        Me.rdbYear.AutoSize = True
        Me.rdbYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rdbYear.Location = New System.Drawing.Point(15, 98)
        Me.rdbYear.Name = "rdbYear"
        Me.rdbYear.Size = New System.Drawing.Size(32, 17)
        Me.rdbYear.TabIndex = 649
        Me.rdbYear.Text = "ปี"
        Me.rdbYear.UseVisualStyleBackColor = True
        '
        'dtpMonth
        '
        Me.dtpMonth.Checked = False
        Me.dtpMonth.CustomFormat = "MMMM  yyyy"
        Me.dtpMonth.Enabled = False
        Me.dtpMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpMonth.Location = New System.Drawing.Point(105, 73)
        Me.dtpMonth.Name = "dtpMonth"
        Me.dtpMonth.Size = New System.Drawing.Size(170, 20)
        Me.dtpMonth.TabIndex = 648
        '
        'rdbMonth
        '
        Me.rdbMonth.AutoSize = True
        Me.rdbMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rdbMonth.Location = New System.Drawing.Point(15, 73)
        Me.rdbMonth.Name = "rdbMonth"
        Me.rdbMonth.Size = New System.Drawing.Size(51, 17)
        Me.rdbMonth.TabIndex = 646
        Me.rdbMonth.Text = "เดือน"
        Me.rdbMonth.UseVisualStyleBackColor = True
        '
        'ccbtDocType
        '
        Me.ccbtDocType.Enabled = False
        Me.ccbtDocType.Location = New System.Drawing.Point(105, 124)
        Me.ccbtDocType.Name = "ccbtDocType"
        Me.ccbtDocType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ccbtDocType.Properties.PopupResizeMode = DevExpress.XtraEditors.Controls.ResizeMode.FrameResize
        Me.ccbtDocType.Size = New System.Drawing.Size(170, 20)
        Me.ccbtDocType.TabIndex = 632
        '
        'rdbDate
        '
        Me.rdbDate.AutoSize = True
        Me.rdbDate.Checked = True
        Me.rdbDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rdbDate.Location = New System.Drawing.Point(14, 22)
        Me.rdbDate.Name = "rdbDate"
        Me.rdbDate.Size = New System.Drawing.Size(64, 17)
        Me.rdbDate.TabIndex = 647
        Me.rdbDate.TabStop = True
        Me.rdbDate.Text = "ช่วงวันที่"
        Me.rdbDate.UseVisualStyleBackColor = True
        '
        'dtpSaleE
        '
        Me.dtpSaleE.CustomFormat = "ddMMMMyyyy"
        Me.dtpSaleE.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpSaleE.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpSaleE.Location = New System.Drawing.Point(105, 47)
        Me.dtpSaleE.MinDate = New Date(1757, 1, 1, 0, 0, 0, 0)
        Me.dtpSaleE.Name = "dtpSaleE"
        Me.dtpSaleE.Size = New System.Drawing.Size(170, 20)
        Me.dtpSaleE.TabIndex = 644
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(30, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 645
        Me.Label4.Text = "ถึงวันที่"
        '
        'lblPdName
        '
        Me.lblPdName.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblPdName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPdName.Enabled = False
        Me.lblPdName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblPdName.Location = New System.Drawing.Point(105, 253)
        Me.lblPdName.Name = "lblPdName"
        Me.lblPdName.Size = New System.Drawing.Size(170, 20)
        Me.lblPdName.TabIndex = 640
        Me.lblPdName.Tag = "0"
        '
        'dtpSaleS
        '
        Me.dtpSaleS.CustomFormat = "ddMMMMyyyy"
        Me.dtpSaleS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpSaleS.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpSaleS.Location = New System.Drawing.Point(105, 21)
        Me.dtpSaleS.MinDate = New Date(1757, 1, 1, 0, 0, 0, 0)
        Me.dtpSaleS.Name = "dtpSaleS"
        Me.dtpSaleS.Size = New System.Drawing.Size(170, 20)
        Me.dtpSaleS.TabIndex = 643
        '
        'CheckRefNo
        '
        Me.CheckRefNo.AutoSize = True
        Me.CheckRefNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.CheckRefNo.Location = New System.Drawing.Point(15, 152)
        Me.CheckRefNo.Name = "CheckRefNo"
        Me.CheckRefNo.Size = New System.Drawing.Size(77, 17)
        Me.CheckRefNo.TabIndex = 635
        Me.CheckRefNo.Text = "เลขที่อ้างอิง"
        Me.CheckRefNo.UseVisualStyleBackColor = True
        '
        'btnPd
        '
        Me.btnPd.BackColor = System.Drawing.Color.DimGray
        Me.btnPd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPd.Enabled = False
        Me.btnPd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.7!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnPd.ForeColor = System.Drawing.Color.White
        Me.btnPd.Image = CType(resources.GetObject("btnPd.Image"), System.Drawing.Image)
        Me.btnPd.Location = New System.Drawing.Point(279, 250)
        Me.btnPd.Name = "btnPd"
        Me.btnPd.Size = New System.Drawing.Size(28, 25)
        Me.btnPd.TabIndex = 642
        Me.btnPd.Tag = "Add"
        Me.btnPd.UseVisualStyleBackColor = False
        '
        'txtRefNo
        '
        Me.txtRefNo.Enabled = False
        Me.txtRefNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtRefNo.Location = New System.Drawing.Point(105, 150)
        Me.txtRefNo.Name = "txtRefNo"
        Me.txtRefNo.Size = New System.Drawing.Size(170, 20)
        Me.txtRefNo.TabIndex = 634
        '
        'txtDocNo
        '
        Me.txtDocNo.Enabled = False
        Me.txtDocNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtDocNo.Location = New System.Drawing.Point(105, 176)
        Me.txtDocNo.Name = "txtDocNo"
        Me.txtDocNo.Size = New System.Drawing.Size(170, 20)
        Me.txtDocNo.TabIndex = 636
        '
        'CheckPdName
        '
        Me.CheckPdName.AutoSize = True
        Me.CheckPdName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.CheckPdName.Location = New System.Drawing.Point(15, 255)
        Me.CheckPdName.Name = "CheckPdName"
        Me.CheckPdName.Size = New System.Drawing.Size(65, 17)
        Me.CheckPdName.TabIndex = 641
        Me.CheckPdName.Text = "ชื่อสินค้า"
        Me.CheckPdName.UseVisualStyleBackColor = True
        '
        'CheckDocType
        '
        Me.CheckDocType.AutoSize = True
        Me.CheckDocType.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.CheckDocType.Location = New System.Drawing.Point(15, 126)
        Me.CheckDocType.Name = "CheckDocType"
        Me.CheckDocType.Size = New System.Drawing.Size(80, 17)
        Me.CheckDocType.TabIndex = 633
        Me.CheckDocType.Text = "รหัสเอกสาร"
        Me.CheckDocType.UseVisualStyleBackColor = True
        '
        'CheckDocNo
        '
        Me.CheckDocNo.AutoSize = True
        Me.CheckDocNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.CheckDocNo.Location = New System.Drawing.Point(15, 178)
        Me.CheckDocNo.Name = "CheckDocNo"
        Me.CheckDocNo.Size = New System.Drawing.Size(85, 17)
        Me.CheckDocNo.TabIndex = 637
        Me.CheckDocNo.Text = "เลขที่เอกสาร"
        Me.CheckDocNo.UseVisualStyleBackColor = True
        '
        'CheckPdNo
        '
        Me.CheckPdNo.AutoSize = True
        Me.CheckPdNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.CheckPdNo.Location = New System.Drawing.Point(15, 204)
        Me.CheckPdNo.Name = "CheckPdNo"
        Me.CheckPdNo.Size = New System.Drawing.Size(71, 17)
        Me.CheckPdNo.TabIndex = 639
        Me.CheckPdNo.Text = "รหัสสินค้า"
        Me.CheckPdNo.UseVisualStyleBackColor = True
        '
        'txtPdNo
        '
        Me.txtPdNo.Enabled = False
        Me.txtPdNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPdNo.Location = New System.Drawing.Point(105, 202)
        Me.txtPdNo.Name = "txtPdNo"
        Me.txtPdNo.Size = New System.Drawing.Size(170, 20)
        Me.txtPdNo.TabIndex = 638
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.cbMeterial)
        Me.GroupBox4.Controls.Add(Me.ChkTsp)
        Me.GroupBox4.Controls.Add(Me.CheckGen)
        Me.GroupBox4.Controls.Add(Me.GroupBox1)
        Me.GroupBox4.Controls.Add(Me.CheckOther)
        Me.GroupBox4.Controls.Add(Me.CheckMat)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(16, 238)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(321, 148)
        Me.GroupBox4.TabIndex = 668
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "ประเภทสินค้า"
        '
        'cbMeterial
        '
        Me.cbMeterial.AutoSize = True
        Me.cbMeterial.Checked = True
        Me.cbMeterial.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbMeterial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cbMeterial.Location = New System.Drawing.Point(214, 70)
        Me.cbMeterial.Name = "cbMeterial"
        Me.cbMeterial.Size = New System.Drawing.Size(65, 17)
        Me.cbMeterial.TabIndex = 666
        Me.cbMeterial.Text = "วัสดุอื่นๆ"
        Me.cbMeterial.UseVisualStyleBackColor = True
        '
        'ChkTsp
        '
        Me.ChkTsp.AutoSize = True
        Me.ChkTsp.Checked = True
        Me.ChkTsp.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkTsp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ChkTsp.Location = New System.Drawing.Point(214, 91)
        Me.ChkTsp.Name = "ChkTsp"
        Me.ChkTsp.Size = New System.Drawing.Size(63, 17)
        Me.ChkTsp.TabIndex = 651
        Me.ChkTsp.Text = "ค่าขนส่ง"
        Me.ChkTsp.UseVisualStyleBackColor = True
        '
        'CheckGen
        '
        Me.CheckGen.AutoSize = True
        Me.CheckGen.Checked = True
        Me.CheckGen.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckGen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.CheckGen.Location = New System.Drawing.Point(20, 31)
        Me.CheckGen.Name = "CheckGen"
        Me.CheckGen.Size = New System.Drawing.Size(93, 17)
        Me.CheckGen.TabIndex = 663
        Me.CheckGen.Text = "สินค้าสำเร็จรูป"
        Me.CheckGen.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdbGenPA)
        Me.GroupBox1.Controls.Add(Me.rdbGenPN)
        Me.GroupBox1.Controls.Add(Me.rdbGenPC)
        Me.GroupBox1.Location = New System.Drawing.Point(40, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(150, 79)
        Me.GroupBox1.TabIndex = 623
        Me.GroupBox1.TabStop = False
        '
        'rdbGenPA
        '
        Me.rdbGenPA.AutoSize = True
        Me.rdbGenPA.Checked = True
        Me.rdbGenPA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rdbGenPA.Location = New System.Drawing.Point(15, 19)
        Me.rdbGenPA.Name = "rdbGenPA"
        Me.rdbGenPA.Size = New System.Drawing.Size(125, 17)
        Me.rdbGenPA.TabIndex = 668
        Me.rdbGenPA.TabStop = True
        Me.rdbGenPA.Text = "สินค้าสำเร็จรูปทั้งหมด"
        Me.rdbGenPA.UseVisualStyleBackColor = True
        '
        'rdbGenPN
        '
        Me.rdbGenPN.AutoSize = True
        Me.rdbGenPN.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rdbGenPN.Location = New System.Drawing.Point(15, 37)
        Me.rdbGenPN.Name = "rdbGenPN"
        Me.rdbGenPN.Size = New System.Drawing.Size(77, 17)
        Me.rdbGenPN.TabIndex = 667
        Me.rdbGenPN.Text = "สินค้าทั่วไป"
        Me.rdbGenPN.UseVisualStyleBackColor = True
        '
        'rdbGenPC
        '
        Me.rdbGenPC.AutoSize = True
        Me.rdbGenPC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rdbGenPC.Location = New System.Drawing.Point(15, 54)
        Me.rdbGenPC.Name = "rdbGenPC"
        Me.rdbGenPC.Size = New System.Drawing.Size(83, 17)
        Me.rdbGenPC.TabIndex = 666
        Me.rdbGenPC.Text = "สินค้าผักซอง"
        Me.rdbGenPC.UseVisualStyleBackColor = True
        '
        'CheckOther
        '
        Me.CheckOther.AutoSize = True
        Me.CheckOther.Checked = True
        Me.CheckOther.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckOther.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.CheckOther.Location = New System.Drawing.Point(215, 28)
        Me.CheckOther.Name = "CheckOther"
        Me.CheckOther.Size = New System.Drawing.Size(72, 17)
        Me.CheckOther.TabIndex = 664
        Me.CheckOther.Text = "สินค้าอื่นๆ"
        Me.CheckOther.UseVisualStyleBackColor = True
        '
        'CheckMat
        '
        Me.CheckMat.AutoSize = True
        Me.CheckMat.Checked = True
        Me.CheckMat.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckMat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.CheckMat.Location = New System.Drawing.Point(214, 49)
        Me.CheckMat.Name = "CheckMat"
        Me.CheckMat.Size = New System.Drawing.Size(86, 17)
        Me.CheckMat.TabIndex = 665
        Me.CheckMat.Text = "สินค้าวัตถุดิบ"
        Me.CheckMat.UseVisualStyleBackColor = True
        '
        'PanelControl1
        '
        Me.PanelControl1.Appearance.BackColor = System.Drawing.Color.Lavender
        Me.PanelControl1.Appearance.BackColor2 = System.Drawing.Color.LightSteelBlue
        Me.PanelControl1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.PanelControl1.Appearance.Options.UseBackColor = True
        Me.PanelControl1.Appearance.Options.UseFont = True
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.cmbGroupComp)
        Me.PanelControl1.Controls.Add(Me.Label12)
        Me.PanelControl1.Controls.Add(Me.GroupBox3)
        Me.PanelControl1.Controls.Add(Me.GroupBox4)
        Me.PanelControl1.Controls.Add(Me.GroupBox2)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(674, 430)
        Me.PanelControl1.TabIndex = 722
        '
        'cmbGroupComp
        '
        Me.cmbGroupComp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGroupComp.FormattingEnabled = True
        Me.cmbGroupComp.Location = New System.Drawing.Point(69, 12)
        Me.cmbGroupComp.Name = "cmbGroupComp"
        Me.cmbGroupComp.Size = New System.Drawing.Size(268, 21)
        Me.cmbGroupComp.TabIndex = 958
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label12.Location = New System.Drawing.Point(24, 15)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(39, 13)
        Me.Label12.TabIndex = 957
        Me.Label12.Text = "บริษัท"
        '
        'PanelControl2
        '
        Me.PanelControl2.Appearance.BackColor = System.Drawing.Color.LightSteelBlue
        Me.PanelControl2.Appearance.BackColor2 = System.Drawing.Color.CornflowerBlue
        Me.PanelControl2.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.PanelControl2.Appearance.Options.UseBackColor = True
        Me.PanelControl2.Appearance.Options.UseFont = True
        Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl2.Controls.Add(Me.btnShow)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 395)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(674, 35)
        Me.PanelControl2.TabIndex = 723
        '
        'lblPsOrder
        '
        Me.lblPsOrder.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblPsOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPsOrder.Enabled = False
        Me.lblPsOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblPsOrder.Location = New System.Drawing.Point(105, 330)
        Me.lblPsOrder.Name = "lblPsOrder"
        Me.lblPsOrder.Size = New System.Drawing.Size(170, 20)
        Me.lblPsOrder.TabIndex = 970
        Me.lblPsOrder.Tag = "0"
        '
        'btnPsOrder
        '
        Me.btnPsOrder.BackColor = System.Drawing.Color.DimGray
        Me.btnPsOrder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPsOrder.Enabled = False
        Me.btnPsOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.7!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnPsOrder.ForeColor = System.Drawing.Color.White
        Me.btnPsOrder.Image = CType(resources.GetObject("btnPsOrder.Image"), System.Drawing.Image)
        Me.btnPsOrder.Location = New System.Drawing.Point(279, 329)
        Me.btnPsOrder.Name = "btnPsOrder"
        Me.btnPsOrder.Size = New System.Drawing.Size(28, 25)
        Me.btnPsOrder.TabIndex = 972
        Me.btnPsOrder.Tag = "Add"
        Me.btnPsOrder.UseVisualStyleBackColor = False
        '
        'cbPsOrder
        '
        Me.cbPsOrder.AutoSize = True
        Me.cbPsOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cbPsOrder.Location = New System.Drawing.Point(15, 332)
        Me.cbPsOrder.Name = "cbPsOrder"
        Me.cbPsOrder.Size = New System.Drawing.Size(57, 17)
        Me.cbPsOrder.TabIndex = 971
        Me.cbPsOrder.Text = "ชื่อผู้สั่ง"
        Me.cbPsOrder.UseVisualStyleBackColor = True
        '
        'rdbPsOrder
        '
        Me.rdbPsOrder.AutoSize = True
        Me.rdbPsOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rdbPsOrder.Location = New System.Drawing.Point(185, 131)
        Me.rdbPsOrder.Name = "rdbPsOrder"
        Me.rdbPsOrder.Size = New System.Drawing.Size(95, 17)
        Me.rdbPsOrder.TabIndex = 624
        Me.rdbPsOrder.Text = "จัดกลุ่มตามผู้สัง"
        Me.rdbPsOrder.UseVisualStyleBackColor = True
        '
        'frmSaleRpt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(674, 430)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSaleRpt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "รายงานการขายสินค้า"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.ccbtDocType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rdbPd As System.Windows.Forms.RadioButton
    Friend WithEvents rdbCus As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents rdbPsSale As System.Windows.Forms.RadioButton
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents lblCus As System.Windows.Forms.Label
    Friend WithEvents lblPsSale As System.Windows.Forms.Label
    Friend WithEvents CheckCus As System.Windows.Forms.CheckBox
    Friend WithEvents btnPsSale As System.Windows.Forms.Button
    Friend WithEvents btnCustomer As System.Windows.Forms.Button
    Friend WithEvents CheckPsSale As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents rdbGenPA As System.Windows.Forms.RadioButton
    Friend WithEvents rdbGenPN As System.Windows.Forms.RadioButton
    Friend WithEvents rdbGenPC As System.Windows.Forms.RadioButton
    Friend WithEvents CheckMat As System.Windows.Forms.CheckBox
    Friend WithEvents CheckOther As System.Windows.Forms.CheckBox
    Friend WithEvents CheckGen As System.Windows.Forms.CheckBox
    Friend WithEvents rdbDoc As System.Windows.Forms.RadioButton
    Friend WithEvents rdbDaily As System.Windows.Forms.RadioButton
    Friend WithEvents CheckDocType As System.Windows.Forms.CheckBox
    Friend WithEvents ccbtDocType As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents txtRefNo As System.Windows.Forms.TextBox
    Friend WithEvents CheckPdNo As System.Windows.Forms.CheckBox
    Friend WithEvents txtPdNo As System.Windows.Forms.TextBox
    Friend WithEvents CheckDocNo As System.Windows.Forms.CheckBox
    Friend WithEvents txtDocNo As System.Windows.Forms.TextBox
    Friend WithEvents CheckRefNo As System.Windows.Forms.CheckBox
    Friend WithEvents lblPdName As System.Windows.Forms.Label
    Friend WithEvents btnPd As System.Windows.Forms.Button
    Friend WithEvents CheckPdName As System.Windows.Forms.CheckBox
    Friend WithEvents dtpYear As System.Windows.Forms.DateTimePicker
    Friend WithEvents rdbYear As System.Windows.Forms.RadioButton
    Friend WithEvents dtpMonth As System.Windows.Forms.DateTimePicker
    Friend WithEvents rdbMonth As System.Windows.Forms.RadioButton
    Friend WithEvents rdbDate As System.Windows.Forms.RadioButton
    Friend WithEvents dtpSaleE As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtpSaleS As System.Windows.Forms.DateTimePicker
    Friend WithEvents rdbCusNoSale As System.Windows.Forms.RadioButton
    Friend WithEvents rdbPdNoSale As System.Windows.Forms.RadioButton
    Friend WithEvents ChkTsp As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdbTsp As System.Windows.Forms.RadioButton
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmbGroupComp As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cbMeterial As System.Windows.Forms.CheckBox
    Friend WithEvents chkLotNo As System.Windows.Forms.CheckBox
    Friend WithEvents txtLotNo As System.Windows.Forms.TextBox
    Friend WithEvents cbSlAVxST As System.Windows.Forms.CheckBox
    Friend WithEvents lblPsOrder As Label
    Friend WithEvents btnPsOrder As Button
    Friend WithEvents cbPsOrder As CheckBox
    Friend WithEvents rdbPsOrder As RadioButton
End Class
