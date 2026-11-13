<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDebtBalDataAllCus
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDebtBalDataAllCus))
        Dim GridFormatRule1 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleExpression1 As DevExpress.XtraEditors.FormatConditionRuleExpression = New DevExpress.XtraEditors.FormatConditionRuleExpression()
        Dim GridFormatRule2 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleExpression2 As DevExpress.XtraEditors.FormatConditionRuleExpression = New DevExpress.XtraEditors.FormatConditionRuleExpression()
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.ColTotalNet = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColBal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.chkDateSale = New System.Windows.Forms.CheckBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cmbBill = New System.Windows.Forms.ComboBox()
        Me.chkBill = New System.Windows.Forms.CheckBox()
        Me.lblPsSale = New System.Windows.Forms.Label()
        Me.btnPsSale = New DevExpress.XtraEditors.SimpleButton()
        Me.cbPsSale = New System.Windows.Forms.CheckBox()
        Me.lblPartnerName = New System.Windows.Forms.Label()
        Me.btnPartner = New DevExpress.XtraEditors.SimpleButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbGroupComp = New System.Windows.Forms.ComboBox()
        Me.cbPartner = New System.Windows.Forms.CheckBox()
        Me.gbDateSale = New System.Windows.Forms.GroupBox()
        Me.dtpMonthNow = New System.Windows.Forms.DateTimePicker()
        Me.dtpMonthE = New System.Windows.Forms.DateTimePicker()
        Me.rdbMonthNow = New System.Windows.Forms.RadioButton()
        Me.dtpMonthS = New System.Windows.Forms.DateTimePicker()
        Me.dtpSaleE = New System.Windows.Forms.DateTimePicker()
        Me.dtpYear = New System.Windows.Forms.DateTimePicker()
        Me.rdbMonth = New System.Windows.Forms.RadioButton()
        Me.rdbYear = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.rdbDate = New System.Windows.Forms.RadioButton()
        Me.dtpSaleS = New System.Windows.Forms.DateTimePicker()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtTotalNet = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnDebtBalRpt = New DevExpress.XtraEditors.SimpleButton()
        Me.btnRefresh = New DevExpress.XtraEditors.SimpleButton()
        Me.GCData = New DevExpress.XtraGrid.GridControl()
        Me.GvShowData = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColidSale = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColNum = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColCusDetail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rbeditDebt = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.ColPartnerName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDateSale = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColPsSaleName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDocRef = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDatePay = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColTotalPay = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColCollectBal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GVLog = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColTyp = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.gbDateSale.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.GCData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GvShowData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rbeditDebt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVLog, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ColTotalNet
        '
        Me.ColTotalNet.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColTotalNet.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColTotalNet.AppearanceCell.Options.UseBackColor = True
        Me.ColTotalNet.AppearanceCell.Options.UseFont = True
        Me.ColTotalNet.AppearanceCell.Options.UseTextOptions = True
        Me.ColTotalNet.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ColTotalNet.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColTotalNet.AppearanceHeader.Options.UseFont = True
        Me.ColTotalNet.AppearanceHeader.Options.UseTextOptions = True
        Me.ColTotalNet.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColTotalNet.Caption = "จำนวนเงิน"
        Me.ColTotalNet.DisplayFormat.FormatString = "N2"
        Me.ColTotalNet.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColTotalNet.FieldName = "TotalNet"
        Me.ColTotalNet.MinWidth = 120
        Me.ColTotalNet.Name = "ColTotalNet"
        Me.ColTotalNet.OptionsColumn.AllowEdit = False
        Me.ColTotalNet.OptionsColumn.ReadOnly = True
        Me.ColTotalNet.Visible = True
        Me.ColTotalNet.VisibleIndex = 5
        Me.ColTotalNet.Width = 138
        '
        'ColBal
        '
        Me.ColBal.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ColBal.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColBal.AppearanceCell.Options.UseBackColor = True
        Me.ColBal.AppearanceCell.Options.UseFont = True
        Me.ColBal.AppearanceCell.Options.UseTextOptions = True
        Me.ColBal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ColBal.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColBal.AppearanceHeader.Options.UseFont = True
        Me.ColBal.AppearanceHeader.Options.UseTextOptions = True
        Me.ColBal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColBal.Caption = "คงเหลือ"
        Me.ColBal.DisplayFormat.FormatString = "N2"
        Me.ColBal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColBal.FieldName = "Bal"
        Me.ColBal.MinWidth = 120
        Me.ColBal.Name = "ColBal"
        Me.ColBal.OptionsColumn.AllowEdit = False
        Me.ColBal.OptionsColumn.ReadOnly = True
        Me.ColBal.Visible = True
        Me.ColBal.VisibleIndex = 7
        Me.ColBal.Width = 138
        '
        'PanelControl1
        '
        Me.PanelControl1.Appearance.BackColor = System.Drawing.Color.Lavender
        Me.PanelControl1.Appearance.BackColor2 = System.Drawing.Color.LightSteelBlue
        Me.PanelControl1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.PanelControl1.Appearance.Options.UseBackColor = True
        Me.PanelControl1.Appearance.Options.UseFont = True
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.chkDateSale)
        Me.PanelControl1.Controls.Add(Me.GroupBox4)
        Me.PanelControl1.Controls.Add(Me.gbDateSale)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1184, 97)
        Me.PanelControl1.TabIndex = 738
        '
        'chkDateSale
        '
        Me.chkDateSale.AutoSize = True
        Me.chkDateSale.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.chkDateSale.Location = New System.Drawing.Point(12, 4)
        Me.chkDateSale.Name = "chkDateSale"
        Me.chkDateSale.Size = New System.Drawing.Size(87, 18)
        Me.chkDateSale.TabIndex = 651
        Me.chkDateSale.Text = "ช่วงวันที่บิล"
        Me.chkDateSale.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.cmbBill)
        Me.GroupBox4.Controls.Add(Me.chkBill)
        Me.GroupBox4.Controls.Add(Me.lblPsSale)
        Me.GroupBox4.Controls.Add(Me.btnPsSale)
        Me.GroupBox4.Controls.Add(Me.cbPsSale)
        Me.GroupBox4.Controls.Add(Me.lblPartnerName)
        Me.GroupBox4.Controls.Add(Me.btnPartner)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.cmbGroupComp)
        Me.GroupBox4.Controls.Add(Me.cbPartner)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(600, 10)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(579, 78)
        Me.GroupBox4.TabIndex = 771
        Me.GroupBox4.TabStop = False
        '
        'cmbBill
        '
        Me.cmbBill.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBill.Enabled = False
        Me.cmbBill.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBill.FormattingEnabled = True
        Me.cmbBill.Items.AddRange(New Object() {"บิลขาย", "บิลรับคืน", "บิลลดหนี้", "บิลเพิ่มหนี้"})
        Me.cmbBill.Location = New System.Drawing.Point(88, 44)
        Me.cmbBill.Name = "cmbBill"
        Me.cmbBill.Size = New System.Drawing.Size(183, 22)
        Me.cmbBill.TabIndex = 973
        '
        'chkBill
        '
        Me.chkBill.AutoSize = True
        Me.chkBill.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.chkBill.Location = New System.Drawing.Point(5, 45)
        Me.chkBill.Name = "chkBill"
        Me.chkBill.Size = New System.Drawing.Size(79, 18)
        Me.chkBill.TabIndex = 972
        Me.chkBill.Text = "ประเภทบิล"
        Me.chkBill.UseVisualStyleBackColor = True
        '
        'lblPsSale
        '
        Me.lblPsSale.BackColor = System.Drawing.Color.Gainsboro
        Me.lblPsSale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPsSale.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblPsSale.Location = New System.Drawing.Point(365, 43)
        Me.lblPsSale.Name = "lblPsSale"
        Me.lblPsSale.Size = New System.Drawing.Size(176, 22)
        Me.lblPsSale.TabIndex = 971
        Me.lblPsSale.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnPsSale
        '
        Me.btnPsSale.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPsSale.Enabled = False
        Me.btnPsSale.Image = CType(resources.GetObject("btnPsSale.Image"), System.Drawing.Image)
        Me.btnPsSale.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnPsSale.Location = New System.Drawing.Point(544, 43)
        Me.btnPsSale.Name = "btnPsSale"
        Me.btnPsSale.Size = New System.Drawing.Size(25, 22)
        Me.btnPsSale.TabIndex = 970
        '
        'cbPsSale
        '
        Me.cbPsSale.AutoSize = True
        Me.cbPsSale.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cbPsSale.Location = New System.Drawing.Point(281, 46)
        Me.cbPsSale.Name = "cbPsSale"
        Me.cbPsSale.Size = New System.Drawing.Size(86, 18)
        Me.cbPsSale.TabIndex = 969
        Me.cbPsSale.Text = "พนักงานขาย"
        Me.cbPsSale.UseVisualStyleBackColor = True
        '
        'lblPartnerName
        '
        Me.lblPartnerName.BackColor = System.Drawing.Color.Gainsboro
        Me.lblPartnerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPartnerName.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblPartnerName.Location = New System.Drawing.Point(365, 17)
        Me.lblPartnerName.Name = "lblPartnerName"
        Me.lblPartnerName.Size = New System.Drawing.Size(176, 22)
        Me.lblPartnerName.TabIndex = 968
        Me.lblPartnerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnPartner
        '
        Me.btnPartner.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPartner.Enabled = False
        Me.btnPartner.Image = CType(resources.GetObject("btnPartner.Image"), System.Drawing.Image)
        Me.btnPartner.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnPartner.Location = New System.Drawing.Point(544, 17)
        Me.btnPartner.Name = "btnPartner"
        Me.btnPartner.Size = New System.Drawing.Size(25, 22)
        Me.btnPartner.TabIndex = 967
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 14)
        Me.Label2.TabIndex = 769
        Me.Label2.Text = "ข้อมูลบริษัท:"
        '
        'cmbGroupComp
        '
        Me.cmbGroupComp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGroupComp.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbGroupComp.FormattingEnabled = True
        Me.cmbGroupComp.Location = New System.Drawing.Point(88, 19)
        Me.cmbGroupComp.Name = "cmbGroupComp"
        Me.cmbGroupComp.Size = New System.Drawing.Size(183, 22)
        Me.cmbGroupComp.TabIndex = 768
        '
        'cbPartner
        '
        Me.cbPartner.AutoSize = True
        Me.cbPartner.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cbPartner.Location = New System.Drawing.Point(281, 20)
        Me.cbPartner.Name = "cbPartner"
        Me.cbPartner.Size = New System.Drawing.Size(53, 18)
        Me.cbPartner.TabIndex = 412
        Me.cbPartner.Text = "ลูกค้า"
        Me.cbPartner.UseVisualStyleBackColor = True
        '
        'gbDateSale
        '
        Me.gbDateSale.BackColor = System.Drawing.Color.Transparent
        Me.gbDateSale.Controls.Add(Me.dtpMonthNow)
        Me.gbDateSale.Controls.Add(Me.dtpMonthE)
        Me.gbDateSale.Controls.Add(Me.rdbMonthNow)
        Me.gbDateSale.Controls.Add(Me.dtpMonthS)
        Me.gbDateSale.Controls.Add(Me.dtpSaleE)
        Me.gbDateSale.Controls.Add(Me.dtpYear)
        Me.gbDateSale.Controls.Add(Me.rdbMonth)
        Me.gbDateSale.Controls.Add(Me.rdbYear)
        Me.gbDateSale.Controls.Add(Me.Label1)
        Me.gbDateSale.Controls.Add(Me.Label4)
        Me.gbDateSale.Controls.Add(Me.rdbDate)
        Me.gbDateSale.Controls.Add(Me.dtpSaleS)
        Me.gbDateSale.Enabled = False
        Me.gbDateSale.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.gbDateSale.Location = New System.Drawing.Point(9, 8)
        Me.gbDateSale.Name = "gbDateSale"
        Me.gbDateSale.Size = New System.Drawing.Size(585, 80)
        Me.gbDateSale.TabIndex = 770
        Me.gbDateSale.TabStop = False
        '
        'dtpMonthNow
        '
        Me.dtpMonthNow.Checked = False
        Me.dtpMonthNow.CustomFormat = "MMMM /yyyy"
        Me.dtpMonthNow.Enabled = False
        Me.dtpMonthNow.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpMonthNow.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpMonthNow.Location = New System.Drawing.Point(440, 17)
        Me.dtpMonthNow.Name = "dtpMonthNow"
        Me.dtpMonthNow.Size = New System.Drawing.Size(138, 22)
        Me.dtpMonthNow.TabIndex = 650
        '
        'dtpMonthE
        '
        Me.dtpMonthE.Checked = False
        Me.dtpMonthE.CustomFormat = "MMMM /yyyy"
        Me.dtpMonthE.Enabled = False
        Me.dtpMonthE.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpMonthE.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpMonthE.Location = New System.Drawing.Point(241, 47)
        Me.dtpMonthE.Name = "dtpMonthE"
        Me.dtpMonthE.Size = New System.Drawing.Size(147, 22)
        Me.dtpMonthE.TabIndex = 649
        '
        'rdbMonthNow
        '
        Me.rdbMonthNow.AutoSize = True
        Me.rdbMonthNow.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rdbMonthNow.Location = New System.Drawing.Point(391, 21)
        Me.rdbMonthNow.Name = "rdbMonthNow"
        Me.rdbMonthNow.Size = New System.Drawing.Size(50, 18)
        Me.rdbMonthNow.TabIndex = 628
        Me.rdbMonthNow.Text = "เดือน"
        Me.rdbMonthNow.UseVisualStyleBackColor = True
        '
        'dtpMonthS
        '
        Me.dtpMonthS.Checked = False
        Me.dtpMonthS.CustomFormat = "MMMM /yyyy"
        Me.dtpMonthS.Enabled = False
        Me.dtpMonthS.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpMonthS.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpMonthS.Location = New System.Drawing.Point(73, 47)
        Me.dtpMonthS.Name = "dtpMonthS"
        Me.dtpMonthS.Size = New System.Drawing.Size(149, 22)
        Me.dtpMonthS.TabIndex = 648
        '
        'dtpSaleE
        '
        Me.dtpSaleE.CustomFormat = "ddMMMMyyyy"
        Me.dtpSaleE.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpSaleE.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpSaleE.Location = New System.Drawing.Point(241, 19)
        Me.dtpSaleE.MinDate = New Date(1757, 1, 1, 0, 0, 0, 0)
        Me.dtpSaleE.Name = "dtpSaleE"
        Me.dtpSaleE.Size = New System.Drawing.Size(147, 22)
        Me.dtpSaleE.TabIndex = 607
        '
        'dtpYear
        '
        Me.dtpYear.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpYear.CausesValidation = False
        Me.dtpYear.CustomFormat = "yyyy"
        Me.dtpYear.Enabled = False
        Me.dtpYear.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpYear.Location = New System.Drawing.Point(440, 45)
        Me.dtpYear.Name = "dtpYear"
        Me.dtpYear.ShowUpDown = True
        Me.dtpYear.Size = New System.Drawing.Size(65, 22)
        Me.dtpYear.TabIndex = 621
        Me.dtpYear.Value = New Date(2025, 9, 15, 15, 28, 0, 0)
        '
        'rdbMonth
        '
        Me.rdbMonth.AutoSize = True
        Me.rdbMonth.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rdbMonth.Location = New System.Drawing.Point(5, 49)
        Me.rdbMonth.Name = "rdbMonth"
        Me.rdbMonth.Size = New System.Drawing.Size(70, 18)
        Me.rdbMonth.TabIndex = 604
        Me.rdbMonth.Text = "ช่วงเดือน"
        Me.rdbMonth.UseVisualStyleBackColor = True
        '
        'rdbYear
        '
        Me.rdbYear.AutoSize = True
        Me.rdbYear.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rdbYear.Location = New System.Drawing.Point(391, 49)
        Me.rdbYear.Name = "rdbYear"
        Me.rdbYear.Size = New System.Drawing.Size(33, 18)
        Me.rdbYear.TabIndex = 606
        Me.rdbYear.Text = "ปี"
        Me.rdbYear.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(221, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 14)
        Me.Label1.TabIndex = 624
        Me.Label1.Text = "ถึง"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(222, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(20, 14)
        Me.Label4.TabIndex = 605
        Me.Label4.Text = "ถึง"
        '
        'rdbDate
        '
        Me.rdbDate.AutoSize = True
        Me.rdbDate.Checked = True
        Me.rdbDate.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rdbDate.Location = New System.Drawing.Point(5, 21)
        Me.rdbDate.Name = "rdbDate"
        Me.rdbDate.Size = New System.Drawing.Size(47, 18)
        Me.rdbDate.TabIndex = 603
        Me.rdbDate.TabStop = True
        Me.rdbDate.Text = "วันที่"
        Me.rdbDate.UseVisualStyleBackColor = True
        '
        'dtpSaleS
        '
        Me.dtpSaleS.CustomFormat = "ddMMMMyyyy"
        Me.dtpSaleS.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpSaleS.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpSaleS.Location = New System.Drawing.Point(73, 20)
        Me.dtpSaleS.MinDate = New Date(1757, 1, 1, 0, 0, 0, 0)
        Me.dtpSaleS.Name = "dtpSaleS"
        Me.dtpSaleS.Size = New System.Drawing.Size(149, 22)
        Me.dtpSaleS.TabIndex = 601
        '
        'PanelControl3
        '
        Me.PanelControl3.Appearance.BackColor = System.Drawing.Color.LightSteelBlue
        Me.PanelControl3.Appearance.BackColor2 = System.Drawing.Color.CornflowerBlue
        Me.PanelControl3.Appearance.Options.UseBackColor = True
        Me.PanelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl3.Controls.Add(Me.Panel3)
        Me.PanelControl3.Controls.Add(Me.btnDebtBalRpt)
        Me.PanelControl3.Controls.Add(Me.btnRefresh)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl3.Location = New System.Drawing.Point(0, 97)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(1184, 36)
        Me.PanelControl3.TabIndex = 739
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.txtTotalNet)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(923, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(261, 36)
        Me.Panel3.TabIndex = 587
        '
        'txtTotalNet
        '
        Me.txtTotalNet.BackColor = System.Drawing.Color.Black
        Me.txtTotalNet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalNet.Font = New System.Drawing.Font("Tahoma", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTotalNet.ForeColor = System.Drawing.Color.Lime
        Me.txtTotalNet.Location = New System.Drawing.Point(98, 4)
        Me.txtTotalNet.Name = "txtTotalNet"
        Me.txtTotalNet.ReadOnly = True
        Me.txtTotalNet.Size = New System.Drawing.Size(158, 28)
        Me.txtTotalNet.TabIndex = 579
        Me.txtTotalNet.Text = "0"
        Me.txtTotalNet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(18, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 16)
        Me.Label3.TabIndex = 142
        Me.Label3.Text = "รวมเป็นเงิน"
        '
        'btnDebtBalRpt
        '
        Me.btnDebtBalRpt.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDebtBalRpt.Appearance.Options.UseFont = True
        Me.btnDebtBalRpt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDebtBalRpt.Enabled = False
        Me.btnDebtBalRpt.Image = CType(resources.GetObject("btnDebtBalRpt.Image"), System.Drawing.Image)
        Me.btnDebtBalRpt.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnDebtBalRpt.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnDebtBalRpt.Location = New System.Drawing.Point(123, 2)
        Me.btnDebtBalRpt.Name = "btnDebtBalRpt"
        Me.btnDebtBalRpt.Size = New System.Drawing.Size(253, 31)
        Me.btnDebtBalRpt.TabIndex = 586
        Me.btnDebtBalRpt.Text = "หนังสือแจ้งยอดหนี้คงเหลือทั้งหมด"
        '
        'btnRefresh
        '
        Me.btnRefresh.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Appearance.Options.UseFont = True
        Me.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), System.Drawing.Image)
        Me.btnRefresh.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnRefresh.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnRefresh.Location = New System.Drawing.Point(4, 2)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(117, 31)
        Me.btnRefresh.TabIndex = 585
        Me.btnRefresh.Text = "แสดงข้อมูล"
        '
        'GCData
        '
        Me.GCData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCData.Location = New System.Drawing.Point(0, 133)
        Me.GCData.MainView = Me.GvShowData
        Me.GCData.Name = "GCData"
        Me.GCData.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rbeditDebt})
        Me.GCData.Size = New System.Drawing.Size(1184, 418)
        Me.GCData.TabIndex = 740
        Me.GCData.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GvShowData, Me.GVLog})
        '
        'GvShowData
        '
        Me.GvShowData.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GvShowData.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GvShowData.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GvShowData.Appearance.GroupRow.Options.UseBackColor = True
        Me.GvShowData.Appearance.GroupRow.Options.UseFont = True
        Me.GvShowData.Appearance.GroupRow.Options.UseForeColor = True
        Me.GvShowData.ColumnPanelRowHeight = 34
        Me.GvShowData.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColidSale, Me.ColNum, Me.ColCusDetail, Me.ColPartnerName, Me.ColDateSale, Me.ColPsSaleName, Me.ColDocRef, Me.ColDatePay, Me.ColTotalNet, Me.ColTotalPay, Me.ColBal, Me.ColCollectBal, Me.ColTyp})
        GridFormatRule1.Column = Me.ColTotalNet
        GridFormatRule1.ColumnApplyTo = Me.ColTotalNet
        GridFormatRule1.Name = "Format0"
        FormatConditionRuleExpression1.Expression = "[TotalNet] < 0"
        FormatConditionRuleExpression1.PredefinedName = "Red Text"
        GridFormatRule1.Rule = FormatConditionRuleExpression1
        GridFormatRule2.Column = Me.ColTotalNet
        GridFormatRule2.ColumnApplyTo = Me.ColBal
        GridFormatRule2.Name = "Format1"
        FormatConditionRuleExpression2.Expression = "[TotalNet] < 0"
        FormatConditionRuleExpression2.PredefinedName = "Red Text"
        GridFormatRule2.Rule = FormatConditionRuleExpression2
        Me.GvShowData.FormatRules.Add(GridFormatRule1)
        Me.GvShowData.FormatRules.Add(GridFormatRule2)
        Me.GvShowData.GridControl = Me.GCData
        Me.GvShowData.GroupCount = 1
        Me.GvShowData.GroupFormat = "{1} {2}"
        Me.GvShowData.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Bal", Nothing, "จำนวนเงิน: {0:n2} บาท")})
        Me.GvShowData.Name = "GvShowData"
        Me.GvShowData.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GvShowData.OptionsView.ShowGroupPanel = False
        Me.GvShowData.OptionsView.ShowIndicator = False
        Me.GvShowData.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.ColPartnerName, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'ColidSale
        '
        Me.ColidSale.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColidSale.AppearanceCell.Options.UseFont = True
        Me.ColidSale.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColidSale.AppearanceHeader.Options.UseFont = True
        Me.ColidSale.Caption = "idsale"
        Me.ColidSale.FieldName = "idSale"
        Me.ColidSale.Name = "ColidSale"
        '
        'ColNum
        '
        Me.ColNum.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColNum.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColNum.AppearanceCell.Options.UseBackColor = True
        Me.ColNum.AppearanceCell.Options.UseFont = True
        Me.ColNum.AppearanceCell.Options.UseTextOptions = True
        Me.ColNum.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColNum.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColNum.AppearanceHeader.Options.UseFont = True
        Me.ColNum.AppearanceHeader.Options.UseTextOptions = True
        Me.ColNum.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColNum.Caption = "ลำดับ"
        Me.ColNum.FieldName = "Num"
        Me.ColNum.MaxWidth = 60
        Me.ColNum.MinWidth = 50
        Me.ColNum.Name = "ColNum"
        Me.ColNum.OptionsColumn.AllowEdit = False
        Me.ColNum.OptionsColumn.ReadOnly = True
        Me.ColNum.Visible = True
        Me.ColNum.VisibleIndex = 0
        Me.ColNum.Width = 71
        '
        'ColCusDetail
        '
        Me.ColCusDetail.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColCusDetail.AppearanceHeader.Options.UseFont = True
        Me.ColCusDetail.AppearanceHeader.Options.UseTextOptions = True
        Me.ColCusDetail.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColCusDetail.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColCusDetail.Caption = "ข้อมูลลูกค้า"
        Me.ColCusDetail.ColumnEdit = Me.rbeditDebt
        Me.ColCusDetail.MaxWidth = 55
        Me.ColCusDetail.MinWidth = 55
        Me.ColCusDetail.Name = "ColCusDetail"
        Me.ColCusDetail.Width = 55
        '
        'rbeditDebt
        '
        Me.rbeditDebt.AutoHeight = False
        Me.rbeditDebt.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("rbeditDebt.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.rbeditDebt.Name = "rbeditDebt"
        Me.rbeditDebt.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'ColPartnerName
        '
        Me.ColPartnerName.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ColPartnerName.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColPartnerName.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.ColPartnerName.AppearanceCell.Options.UseBackColor = True
        Me.ColPartnerName.AppearanceCell.Options.UseFont = True
        Me.ColPartnerName.AppearanceCell.Options.UseForeColor = True
        Me.ColPartnerName.AppearanceCell.Options.UseTextOptions = True
        Me.ColPartnerName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.ColPartnerName.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColPartnerName.AppearanceHeader.Options.UseFont = True
        Me.ColPartnerName.AppearanceHeader.Options.UseTextOptions = True
        Me.ColPartnerName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColPartnerName.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColPartnerName.Caption = "ลูกค้า"
        Me.ColPartnerName.FieldName = "PartnerName"
        Me.ColPartnerName.Name = "ColPartnerName"
        Me.ColPartnerName.OptionsColumn.AllowEdit = False
        Me.ColPartnerName.OptionsColumn.ReadOnly = True
        Me.ColPartnerName.Visible = True
        Me.ColPartnerName.VisibleIndex = 2
        '
        'ColDateSale
        '
        Me.ColDateSale.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColDateSale.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColDateSale.AppearanceCell.Options.UseBackColor = True
        Me.ColDateSale.AppearanceCell.Options.UseFont = True
        Me.ColDateSale.AppearanceCell.Options.UseTextOptions = True
        Me.ColDateSale.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDateSale.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColDateSale.AppearanceHeader.Options.UseFont = True
        Me.ColDateSale.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDateSale.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDateSale.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColDateSale.Caption = "วันที่ขาย/รับคืน"
        Me.ColDateSale.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.ColDateSale.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.ColDateSale.FieldName = "DateSaleD"
        Me.ColDateSale.MinWidth = 85
        Me.ColDateSale.Name = "ColDateSale"
        Me.ColDateSale.OptionsColumn.AllowEdit = False
        Me.ColDateSale.OptionsColumn.ReadOnly = True
        Me.ColDateSale.Visible = True
        Me.ColDateSale.VisibleIndex = 1
        Me.ColDateSale.Width = 85
        '
        'ColPsSaleName
        '
        Me.ColPsSaleName.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColPsSaleName.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColPsSaleName.AppearanceCell.Options.UseBackColor = True
        Me.ColPsSaleName.AppearanceCell.Options.UseFont = True
        Me.ColPsSaleName.AppearanceCell.Options.UseTextOptions = True
        Me.ColPsSaleName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.ColPsSaleName.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColPsSaleName.AppearanceHeader.Options.UseFont = True
        Me.ColPsSaleName.AppearanceHeader.Options.UseTextOptions = True
        Me.ColPsSaleName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColPsSaleName.Caption = "พนักงานขาย"
        Me.ColPsSaleName.FieldName = "PsSaleName"
        Me.ColPsSaleName.MinWidth = 200
        Me.ColPsSaleName.Name = "ColPsSaleName"
        Me.ColPsSaleName.OptionsColumn.AllowEdit = False
        Me.ColPsSaleName.OptionsColumn.ReadOnly = True
        Me.ColPsSaleName.Visible = True
        Me.ColPsSaleName.VisibleIndex = 4
        Me.ColPsSaleName.Width = 222
        '
        'ColDocRef
        '
        Me.ColDocRef.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColDocRef.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColDocRef.AppearanceCell.Options.UseBackColor = True
        Me.ColDocRef.AppearanceCell.Options.UseFont = True
        Me.ColDocRef.AppearanceCell.Options.UseTextOptions = True
        Me.ColDocRef.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.ColDocRef.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColDocRef.AppearanceHeader.Options.UseFont = True
        Me.ColDocRef.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDocRef.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDocRef.Caption = "เลขที่เอกสาร"
        Me.ColDocRef.FieldName = "DocRef"
        Me.ColDocRef.MinWidth = 150
        Me.ColDocRef.Name = "ColDocRef"
        Me.ColDocRef.OptionsColumn.AllowEdit = False
        Me.ColDocRef.OptionsColumn.ReadOnly = True
        Me.ColDocRef.Visible = True
        Me.ColDocRef.VisibleIndex = 3
        Me.ColDocRef.Width = 150
        '
        'ColDatePay
        '
        Me.ColDatePay.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColDatePay.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColDatePay.AppearanceCell.Options.UseBackColor = True
        Me.ColDatePay.AppearanceCell.Options.UseFont = True
        Me.ColDatePay.AppearanceCell.Options.UseTextOptions = True
        Me.ColDatePay.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDatePay.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColDatePay.AppearanceHeader.Options.UseFont = True
        Me.ColDatePay.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDatePay.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDatePay.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColDatePay.Caption = "วันที่ครบกำหนดชำระ"
        Me.ColDatePay.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.ColDatePay.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.ColDatePay.FieldName = "DatePay"
        Me.ColDatePay.MinWidth = 85
        Me.ColDatePay.Name = "ColDatePay"
        Me.ColDatePay.OptionsColumn.AllowEdit = False
        Me.ColDatePay.OptionsColumn.ReadOnly = True
        Me.ColDatePay.Visible = True
        Me.ColDatePay.VisibleIndex = 2
        Me.ColDatePay.Width = 85
        '
        'ColTotalPay
        '
        Me.ColTotalPay.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColTotalPay.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColTotalPay.AppearanceCell.Options.UseBackColor = True
        Me.ColTotalPay.AppearanceCell.Options.UseFont = True
        Me.ColTotalPay.AppearanceCell.Options.UseTextOptions = True
        Me.ColTotalPay.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ColTotalPay.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColTotalPay.AppearanceHeader.Options.UseFont = True
        Me.ColTotalPay.AppearanceHeader.Options.UseTextOptions = True
        Me.ColTotalPay.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColTotalPay.Caption = "ชำระแล้ว"
        Me.ColTotalPay.DisplayFormat.FormatString = "N2"
        Me.ColTotalPay.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColTotalPay.FieldName = "TotalPay"
        Me.ColTotalPay.MinWidth = 120
        Me.ColTotalPay.Name = "ColTotalPay"
        Me.ColTotalPay.OptionsColumn.AllowEdit = False
        Me.ColTotalPay.OptionsColumn.ReadOnly = True
        Me.ColTotalPay.Visible = True
        Me.ColTotalPay.VisibleIndex = 6
        Me.ColTotalPay.Width = 138
        '
        'ColCollectBal
        '
        Me.ColCollectBal.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColCollectBal.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColCollectBal.AppearanceCell.Options.UseBackColor = True
        Me.ColCollectBal.AppearanceCell.Options.UseFont = True
        Me.ColCollectBal.AppearanceCell.Options.UseTextOptions = True
        Me.ColCollectBal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ColCollectBal.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColCollectBal.AppearanceHeader.Options.UseFont = True
        Me.ColCollectBal.AppearanceHeader.Options.UseTextOptions = True
        Me.ColCollectBal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColCollectBal.Caption = "ยอดคงเหลือสะสม"
        Me.ColCollectBal.DisplayFormat.FormatString = "N2"
        Me.ColCollectBal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColCollectBal.FieldName = "CollectBal"
        Me.ColCollectBal.Name = "ColCollectBal"
        Me.ColCollectBal.OptionsColumn.AllowEdit = False
        Me.ColCollectBal.OptionsColumn.ReadOnly = True
        Me.ColCollectBal.Visible = True
        Me.ColCollectBal.VisibleIndex = 8
        Me.ColCollectBal.Width = 621
        '
        'GVLog
        '
        Me.GVLog.GridControl = Me.GCData
        Me.GVLog.Name = "GVLog"
        Me.GVLog.OptionsView.ShowGroupPanel = False
        Me.GVLog.OptionsView.ShowIndicator = False
        '
        'ColTyp
        '
        Me.ColTyp.Caption = "typ"
        Me.ColTyp.FieldName = "typ"
        Me.ColTyp.Name = "ColTyp"
        '
        'frmDebtBalDataAllCus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1184, 551)
        Me.Controls.Add(Me.GCData)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDebtBalDataAllCus"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ข้อมูลบัญชีลูกหนี้ค้างชำระ"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.gbDateSale.ResumeLayout(False)
        Me.gbDateSale.PerformLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.GCData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GvShowData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rbeditDebt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVLog, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbGroupComp As ComboBox
    Friend WithEvents gbDateSale As GroupBox
    Friend WithEvents dtpMonthNow As DateTimePicker
    Friend WithEvents dtpMonthE As DateTimePicker
    Friend WithEvents dtpMonthS As DateTimePicker
    Friend WithEvents rdbMonthNow As RadioButton
    Friend WithEvents dtpSaleE As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpYear As DateTimePicker
    Friend WithEvents rdbYear As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents rdbMonth As RadioButton
    Friend WithEvents rdbDate As RadioButton
    Friend WithEvents dtpSaleS As DateTimePicker
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents cbPartner As CheckBox
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnDebtBalRpt As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GCData As DevExpress.XtraGrid.GridControl
    Friend WithEvents GvShowData As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColidSale As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColNum As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDateSale As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDocRef As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDatePay As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColTotalNet As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColTotalPay As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColBal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rbeditDebt As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents GVLog As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColPartnerName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnPartner As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblPartnerName As Label
    Friend WithEvents lblPsSale As Label
    Friend WithEvents btnPsSale As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cbPsSale As CheckBox
    Friend WithEvents ColPsSaleName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtTotalNet As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ColCollectBal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColCusDetail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents chkBill As CheckBox
    Friend WithEvents chkDateSale As CheckBox
    Friend WithEvents cmbBill As ComboBox
    Friend WithEvents ColTyp As DevExpress.XtraGrid.Columns.GridColumn
End Class
