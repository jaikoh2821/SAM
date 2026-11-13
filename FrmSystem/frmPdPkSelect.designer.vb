<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPdPkSelect
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPdPkSelect))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtPdName = New System.Windows.Forms.TextBox()
        Me.dgvPd = New System.Windows.Forms.DataGridView()
        Me.ChkPd = New System.Windows.Forms.CheckBox()
        Me.ChkWeight = New System.Windows.Forms.CheckBox()
        Me.cmbWeight = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ChkNoStock = New System.Windows.Forms.CheckBox()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.btnSchPd = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.CmbUnitW = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtLot = New System.Windows.Forms.TextBox()
        Me.ChkLot = New System.Windows.Forms.CheckBox()
        Me.colSelect = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.col_sel2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.idPd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idPdPkLot = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColLotNum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPdName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColuShortName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColBarcode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColPriceBill = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColPriceRetail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColPriceWholesale = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PdCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WeightPd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitW = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colidUnitW = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colidPkUnit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColPkUnitName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColPerBox = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColidSeedKind = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvPd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtPdName
        '
        Me.txtPdName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtPdName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtPdName.Enabled = False
        Me.txtPdName.Location = New System.Drawing.Point(334, 18)
        Me.txtPdName.Name = "txtPdName"
        Me.txtPdName.Size = New System.Drawing.Size(141, 20)
        Me.txtPdName.TabIndex = 1
        '
        'dgvPd
        '
        Me.dgvPd.AllowUserToAddRows = False
        Me.dgvPd.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPd.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvPd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPd.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colSelect, Me.col_sel2, Me.idPd, Me.idPdPkLot, Me.ColLotNum, Me.colPdName, Me.ColuShortName, Me.ColBarcode, Me.ColPriceBill, Me.ColPriceRetail, Me.ColPriceWholesale, Me.PdCode, Me.WeightPd, Me.Amount, Me.UnitW, Me.colidUnitW, Me.colidPkUnit, Me.ColPkUnitName, Me.ColPerBox, Me.ColidSeedKind})
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPd.DefaultCellStyle = DataGridViewCellStyle13
        Me.dgvPd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvPd.EnableHeadersVisualStyles = False
        Me.dgvPd.GridColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvPd.Location = New System.Drawing.Point(0, 120)
        Me.dgvPd.Name = "dgvPd"
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPd.RowHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.dgvPd.RowHeadersVisible = False
        Me.dgvPd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvPd.Size = New System.Drawing.Size(784, 392)
        Me.dgvPd.TabIndex = 6
        '
        'ChkPd
        '
        Me.ChkPd.AutoSize = True
        Me.ChkPd.Checked = True
        Me.ChkPd.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkPd.Location = New System.Drawing.Point(262, 20)
        Me.ChkPd.Name = "ChkPd"
        Me.ChkPd.Size = New System.Drawing.Size(65, 17)
        Me.ChkPd.TabIndex = 0
        Me.ChkPd.Text = "ชื่อสินค้า"
        Me.ChkPd.UseVisualStyleBackColor = True
        '
        'ChkWeight
        '
        Me.ChkWeight.AutoSize = True
        Me.ChkWeight.Location = New System.Drawing.Point(518, 60)
        Me.ChkWeight.Name = "ChkWeight"
        Me.ChkWeight.Size = New System.Drawing.Size(61, 17)
        Me.ChkWeight.TabIndex = 553
        Me.ChkWeight.Text = "น้ำหนัก"
        Me.ChkWeight.UseVisualStyleBackColor = True
        Me.ChkWeight.Visible = False
        '
        'cmbWeight
        '
        Me.cmbWeight.Enabled = False
        Me.cmbWeight.FormattingEnabled = True
        Me.cmbWeight.Location = New System.Drawing.Point(584, 57)
        Me.cmbWeight.Name = "cmbWeight"
        Me.cmbWeight.Size = New System.Drawing.Size(71, 21)
        Me.cmbWeight.TabIndex = 554
        Me.cmbWeight.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.ChkNoStock)
        Me.Panel1.Controls.Add(Me.btn_add)
        Me.Panel1.Controls.Add(Me.btnSchPd)
        Me.Panel1.Controls.Add(Me.btnSearch)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 84)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(784, 36)
        Me.Panel1.TabIndex = 1
        '
        'ChkNoStock
        '
        Me.ChkNoStock.AutoSize = True
        Me.ChkNoStock.Checked = True
        Me.ChkNoStock.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkNoStock.Dock = System.Windows.Forms.DockStyle.Left
        Me.ChkNoStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ChkNoStock.ForeColor = System.Drawing.Color.White
        Me.ChkNoStock.Location = New System.Drawing.Point(211, 0)
        Me.ChkNoStock.Name = "ChkNoStock"
        Me.ChkNoStock.Size = New System.Drawing.Size(173, 34)
        Me.ChkNoStock.TabIndex = 393
        Me.ChkNoStock.Text = "ไม่แสดงสินค้าที่หมดแล้ว"
        Me.ChkNoStock.UseVisualStyleBackColor = True
        Me.ChkNoStock.Visible = False
        '
        'btn_add
        '
        Me.btn_add.AutoSize = True
        Me.btn_add.BackColor = System.Drawing.Color.DimGray
        Me.btn_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_add.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_add.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_add.ForeColor = System.Drawing.Color.White
        Me.btn_add.Image = Global.SAM.My.Resources.Resources.Add28
        Me.btn_add.Location = New System.Drawing.Point(115, 0)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(96, 34)
        Me.btn_add.TabIndex = 5
        Me.btn_add.Text = " ตกลง"
        Me.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_add.UseVisualStyleBackColor = False
        Me.btn_add.Visible = False
        '
        'btnSchPd
        '
        Me.btnSchPd.BackColor = System.Drawing.Color.DimGray
        Me.btnSchPd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSchPd.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnSchPd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnSchPd.ForeColor = System.Drawing.Color.White
        Me.btnSchPd.Image = CType(resources.GetObject("btnSchPd.Image"), System.Drawing.Image)
        Me.btnSchPd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSchPd.Location = New System.Drawing.Point(0, 0)
        Me.btnSchPd.Name = "btnSchPd"
        Me.btnSchPd.Size = New System.Drawing.Size(115, 34)
        Me.btnSchPd.TabIndex = 4
        Me.btnSchPd.Tag = ""
        Me.btnSchPd.Text = "       แสดงข้อมูล"
        Me.btnSchPd.UseVisualStyleBackColor = False
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.DimGray
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.7!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearch.Location = New System.Drawing.Point(3, -1)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(111, 36)
        Me.btnSearch.TabIndex = 392
        Me.btnSearch.Tag = "Add"
        Me.btnSearch.Text = "        แสดงข้อมูล"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'CmbUnitW
        '
        Me.CmbUnitW.Enabled = False
        Me.CmbUnitW.FormattingEnabled = True
        Me.CmbUnitW.Location = New System.Drawing.Point(661, 57)
        Me.CmbUnitW.Name = "CmbUnitW"
        Me.CmbUnitW.Size = New System.Drawing.Size(64, 21)
        Me.CmbUnitW.TabIndex = 555
        Me.CmbUnitW.Visible = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.txtLot)
        Me.Panel2.Controls.Add(Me.ChkLot)
        Me.Panel2.Controls.Add(Me.cmbWeight)
        Me.Panel2.Controls.Add(Me.CmbUnitW)
        Me.Panel2.Controls.Add(Me.txtPdName)
        Me.Panel2.Controls.Add(Me.ChkPd)
        Me.Panel2.Controls.Add(Me.ChkWeight)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(784, 84)
        Me.Panel2.TabIndex = 0
        '
        'txtLot
        '
        Me.txtLot.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtLot.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtLot.Enabled = False
        Me.txtLot.Location = New System.Drawing.Point(334, 44)
        Me.txtLot.Name = "txtLot"
        Me.txtLot.Size = New System.Drawing.Size(141, 20)
        Me.txtLot.TabIndex = 3
        Me.txtLot.Visible = False
        '
        'ChkLot
        '
        Me.ChkLot.AutoSize = True
        Me.ChkLot.Location = New System.Drawing.Point(262, 47)
        Me.ChkLot.Name = "ChkLot"
        Me.ChkLot.Size = New System.Drawing.Size(61, 17)
        Me.ChkLot.TabIndex = 2
        Me.ChkLot.Text = "Lot No."
        Me.ChkLot.UseVisualStyleBackColor = True
        Me.ChkLot.Visible = False
        '
        'colSelect
        '
        Me.colSelect.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray
        Me.colSelect.DefaultCellStyle = DataGridViewCellStyle2
        Me.colSelect.HeaderText = "เลือก"
        Me.colSelect.Name = "colSelect"
        Me.colSelect.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colSelect.Width = 41
        '
        'col_sel2
        '
        Me.col_sel2.DataPropertyName = "chkPdPk"
        Me.col_sel2.HeaderText = "เลือก"
        Me.col_sel2.Name = "col_sel2"
        Me.col_sel2.Visible = False
        '
        'idPd
        '
        Me.idPd.DataPropertyName = "idPdPk"
        Me.idPd.HeaderText = "idPd"
        Me.idPd.Name = "idPd"
        Me.idPd.Visible = False
        '
        'idPdPkLot
        '
        Me.idPdPkLot.DataPropertyName = "idPdPkLot"
        Me.idPdPkLot.HeaderText = "idPdPkLot"
        Me.idPdPkLot.Name = "idPdPkLot"
        Me.idPdPkLot.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'ColLotNum
        '
        Me.ColLotNum.DataPropertyName = "LotNum"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColLotNum.DefaultCellStyle = DataGridViewCellStyle3
        Me.ColLotNum.HeaderText = "Lot No."
        Me.ColLotNum.Name = "ColLotNum"
        Me.ColLotNum.ReadOnly = True
        Me.ColLotNum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ColLotNum.Visible = False
        '
        'colPdName
        '
        Me.colPdName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colPdName.DataPropertyName = "PdPkName"
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.colPdName.DefaultCellStyle = DataGridViewCellStyle4
        Me.colPdName.HeaderText = "ชื่อสินค้า"
        Me.colPdName.Name = "colPdName"
        Me.colPdName.ReadOnly = True
        Me.colPdName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'ColuShortName
        '
        Me.ColuShortName.DataPropertyName = "ShortName"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColuShortName.DefaultCellStyle = DataGridViewCellStyle5
        Me.ColuShortName.HeaderText = "ชื่อย่อ"
        Me.ColuShortName.Name = "ColuShortName"
        Me.ColuShortName.ReadOnly = True
        Me.ColuShortName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ColuShortName.Width = 50
        '
        'ColBarcode
        '
        Me.ColBarcode.DataPropertyName = "Barcode"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.ColBarcode.DefaultCellStyle = DataGridViewCellStyle6
        Me.ColBarcode.HeaderText = "Barcode"
        Me.ColBarcode.Name = "ColBarcode"
        Me.ColBarcode.ReadOnly = True
        Me.ColBarcode.Visible = False
        '
        'ColPriceBill
        '
        Me.ColPriceBill.DataPropertyName = "PriceBill"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColPriceBill.DefaultCellStyle = DataGridViewCellStyle7
        Me.ColPriceBill.HeaderText = "ราคาบิล"
        Me.ColPriceBill.Name = "ColPriceBill"
        Me.ColPriceBill.ReadOnly = True
        Me.ColPriceBill.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ColPriceBill.Width = 80
        '
        'ColPriceRetail
        '
        Me.ColPriceRetail.DataPropertyName = "PriceRetail"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColPriceRetail.DefaultCellStyle = DataGridViewCellStyle8
        Me.ColPriceRetail.HeaderText = "ราคาปลีก"
        Me.ColPriceRetail.Name = "ColPriceRetail"
        Me.ColPriceRetail.ReadOnly = True
        Me.ColPriceRetail.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'ColPriceWholesale
        '
        Me.ColPriceWholesale.DataPropertyName = "PriceWholesale"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColPriceWholesale.DefaultCellStyle = DataGridViewCellStyle9
        Me.ColPriceWholesale.HeaderText = "ราคาส่ง"
        Me.ColPriceWholesale.Name = "ColPriceWholesale"
        Me.ColPriceWholesale.ReadOnly = True
        Me.ColPriceWholesale.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ColPriceWholesale.Width = 80
        '
        'PdCode
        '
        Me.PdCode.DataPropertyName = "PdCode"
        Me.PdCode.HeaderText = "PdCode"
        Me.PdCode.Name = "PdCode"
        Me.PdCode.ReadOnly = True
        Me.PdCode.Visible = False
        '
        'WeightPd
        '
        Me.WeightPd.DataPropertyName = "Weight"
        Me.WeightPd.HeaderText = "น้ำหนัก"
        Me.WeightPd.Name = "WeightPd"
        Me.WeightPd.ReadOnly = True
        Me.WeightPd.Visible = False
        '
        'Amount
        '
        Me.Amount.DataPropertyName = "Amount"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle10.Format = "N0"
        DataGridViewCellStyle10.NullValue = Nothing
        Me.Amount.DefaultCellStyle = DataGridViewCellStyle10
        Me.Amount.HeaderText = "จำนวนคงเหลือ"
        Me.Amount.Name = "Amount"
        Me.Amount.ReadOnly = True
        Me.Amount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Amount.Visible = False
        Me.Amount.Width = 80
        '
        'UnitW
        '
        Me.UnitW.DataPropertyName = "UnitW"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.UnitW.DefaultCellStyle = DataGridViewCellStyle11
        Me.UnitW.HeaderText = "หน่วยน้ำหนัก"
        Me.UnitW.Name = "UnitW"
        Me.UnitW.ReadOnly = True
        Me.UnitW.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.UnitW.Visible = False
        Me.UnitW.Width = 80
        '
        'colidUnitW
        '
        Me.colidUnitW.DataPropertyName = "idUnitW"
        Me.colidUnitW.HeaderText = "idหน่วย"
        Me.colidUnitW.Name = "colidUnitW"
        Me.colidUnitW.ReadOnly = True
        Me.colidUnitW.Visible = False
        '
        'colidPkUnit
        '
        Me.colidPkUnit.DataPropertyName = "idPkUnit"
        Me.colidPkUnit.HeaderText = "idหน่วยขาย"
        Me.colidPkUnit.Name = "colidPkUnit"
        Me.colidPkUnit.ReadOnly = True
        Me.colidPkUnit.Visible = False
        '
        'ColPkUnitName
        '
        Me.ColPkUnitName.DataPropertyName = "PkUnitName"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColPkUnitName.DefaultCellStyle = DataGridViewCellStyle12
        Me.ColPkUnitName.HeaderText = "หน่วย"
        Me.ColPkUnitName.Name = "ColPkUnitName"
        Me.ColPkUnitName.ReadOnly = True
        Me.ColPkUnitName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ColPkUnitName.Visible = False
        Me.ColPkUnitName.Width = 80
        '
        'ColPerBox
        '
        Me.ColPerBox.DataPropertyName = "PerBox"
        Me.ColPerBox.HeaderText = "PerBox"
        Me.ColPerBox.Name = "ColPerBox"
        Me.ColPerBox.ReadOnly = True
        Me.ColPerBox.Visible = False
        '
        'ColidSeedKind
        '
        Me.ColidSeedKind.DataPropertyName = "idSeedKind"
        Me.ColidSeedKind.HeaderText = "idSeedKind"
        Me.ColidSeedKind.Name = "ColidSeedKind"
        Me.ColidSeedKind.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ColidSeedKind.Visible = False
        Me.ColidSeedKind.Width = 60
        '
        'frmPdPkSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(784, 512)
        Me.Controls.Add(Me.dgvPd)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.MaximizeBox = False
        Me.Name = "frmPdPkSelect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "เลือกสินค้า"
        CType(Me.dgvPd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtPdName As System.Windows.Forms.TextBox
    Friend WithEvents dgvPd As System.Windows.Forms.DataGridView
    Friend WithEvents ChkPd As System.Windows.Forms.CheckBox
    Friend WithEvents ChkWeight As System.Windows.Forms.CheckBox
    Friend WithEvents cmbWeight As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnSchPd As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents CmbUnitW As System.Windows.Forms.ComboBox
    Friend WithEvents btn_add As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtLot As System.Windows.Forms.TextBox
    Friend WithEvents ChkLot As System.Windows.Forms.CheckBox
    Friend WithEvents ChkNoStock As System.Windows.Forms.CheckBox
    Friend WithEvents colSelect As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents col_sel2 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents idPd As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idPdPkLot As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColLotNum As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPdName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColuShortName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColBarcode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColPriceBill As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColPriceRetail As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColPriceWholesale As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PdCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WeightPd As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Amount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UnitW As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colidUnitW As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colidPkUnit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColPkUnitName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColPerBox As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColidSeedKind As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
