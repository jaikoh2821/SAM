<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPsSaleComm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPsSaleComm))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label1 = New System.Windows.Forms.Label
        Me.btn_seed = New System.Windows.Forms.Button
        Me.txt_PdTName = New System.Windows.Forms.TextBox
        Me.dgvComm = New System.Windows.Forms.DataGridView
        Me.colautonum = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.coledit = New System.Windows.Forms.DataGridViewImageColumn
        Me.colDateComm = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colPay = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colpay2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colComm = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.col_idComm = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.col_idPdT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btn_add = New System.Windows.Forms.Button
        Me.chbPdT = New System.Windows.Forms.CheckBox
        Me.dgvCommP = New System.Windows.Forms.DataGridView
        Me.colautonum2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.coledit2 = New System.Windows.Forms.DataGridViewImageColumn
        Me.colPdTName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colDateCommP = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colPayCommP = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colCommP = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colidCommP = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colidPdT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colTargetPd = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btn_add2 = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.txt_target = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btn_YM = New System.Windows.Forms.Button
        Me.txt_YM = New System.Windows.Forms.TextBox
        Me.lb_PerY = New System.Windows.Forms.Label
        Me.lb_PerM = New System.Windows.Forms.Label
        Me.txt_PerY = New System.Windows.Forms.TextBox
        Me.txt_PerM = New System.Windows.Forms.TextBox
        Me.lb_Y = New System.Windows.Forms.Label
        Me.lb_M = New System.Windows.Forms.Label
        Me.txt_TotalNetM = New System.Windows.Forms.TextBox
        Me.txt_TotalNetY = New System.Windows.Forms.TextBox
        CType(Me.dgvComm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCommP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(44, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 18)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "เดือน/ปี"
        '
        'btn_seed
        '
        Me.btn_seed.BackColor = System.Drawing.Color.DimGray
        Me.btn_seed.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_seed.Enabled = False
        Me.btn_seed.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.7!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_seed.ForeColor = System.Drawing.Color.White
        Me.btn_seed.Image = CType(resources.GetObject("btn_seed.Image"), System.Drawing.Image)
        Me.btn_seed.Location = New System.Drawing.Point(457, 8)
        Me.btn_seed.Name = "btn_seed"
        Me.btn_seed.Size = New System.Drawing.Size(28, 25)
        Me.btn_seed.TabIndex = 633
        Me.btn_seed.Tag = "Add"
        Me.btn_seed.UseVisualStyleBackColor = False
        '
        'txt_PdTName
        '
        Me.txt_PdTName.Enabled = False
        Me.txt_PdTName.Location = New System.Drawing.Point(351, 11)
        Me.txt_PdTName.Name = "txt_PdTName"
        Me.txt_PdTName.ReadOnly = True
        Me.txt_PdTName.Size = New System.Drawing.Size(100, 20)
        Me.txt_PdTName.TabIndex = 632
        '
        'dgvComm
        '
        Me.dgvComm.AllowUserToAddRows = False
        Me.dgvComm.AllowUserToDeleteRows = False
        Me.dgvComm.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgvComm.BackgroundColor = System.Drawing.Color.Lavender
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvComm.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvComm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvComm.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colautonum, Me.coledit, Me.colDateComm, Me.colPay, Me.colpay2, Me.colComm, Me.col_idComm, Me.col_idPdT})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvComm.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvComm.Location = New System.Drawing.Point(0, 41)
        Me.dgvComm.Name = "dgvComm"
        Me.dgvComm.RowHeadersVisible = False
        Me.dgvComm.Size = New System.Drawing.Size(374, 306)
        Me.dgvComm.TabIndex = 634
        '
        'colautonum
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro
        Me.colautonum.DefaultCellStyle = DataGridViewCellStyle2
        Me.colautonum.HeaderText = "ลำดับ"
        Me.colautonum.Name = "colautonum"
        Me.colautonum.ReadOnly = True
        Me.colautonum.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colautonum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colautonum.Width = 60
        '
        'coledit
        '
        Me.coledit.HeaderText = "แก้ไข"
        Me.coledit.Image = Global.SAM.My.Resources.Resources.gdEdit
        Me.coledit.Name = "coledit"
        Me.coledit.Width = 60
        '
        'colDateComm
        '
        Me.colDateComm.DataPropertyName = "DateComm"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Gainsboro
        Me.colDateComm.DefaultCellStyle = DataGridViewCellStyle3
        Me.colDateComm.HeaderText = "เดือน/ปี"
        Me.colDateComm.Name = "colDateComm"
        Me.colDateComm.ReadOnly = True
        Me.colDateComm.Visible = False
        Me.colDateComm.Width = 80
        '
        'colPay
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Gainsboro
        Me.colPay.DefaultCellStyle = DataGridViewCellStyle4
        Me.colPay.HeaderText = "ยอดขาย"
        Me.colPay.Name = "colPay"
        Me.colPay.ReadOnly = True
        Me.colPay.Width = 150
        '
        'colpay2
        '
        Me.colpay2.DataPropertyName = "PayComm"
        Me.colpay2.HeaderText = "PayComm"
        Me.colpay2.Name = "colpay2"
        Me.colpay2.ReadOnly = True
        Me.colpay2.Visible = False
        '
        'colComm
        '
        Me.colComm.DataPropertyName = "Comm"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Gainsboro
        Me.colComm.DefaultCellStyle = DataGridViewCellStyle5
        Me.colComm.HeaderText = "คอมมิสชั่น (%)"
        Me.colComm.Name = "colComm"
        Me.colComm.ReadOnly = True
        '
        'col_idComm
        '
        Me.col_idComm.DataPropertyName = "idComm"
        Me.col_idComm.HeaderText = "idComm"
        Me.col_idComm.Name = "col_idComm"
        Me.col_idComm.ReadOnly = True
        Me.col_idComm.Visible = False
        '
        'col_idPdT
        '
        Me.col_idPdT.DataPropertyName = "idPdT"
        Me.col_idPdT.HeaderText = "idPdT"
        Me.col_idPdT.Name = "col_idPdT"
        Me.col_idPdT.ReadOnly = True
        Me.col_idPdT.Visible = False
        '
        'btn_add
        '
        Me.btn_add.BackColor = System.Drawing.Color.DimGray
        Me.btn_add.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_add.Enabled = False
        Me.btn_add.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_add.ForeColor = System.Drawing.Color.White
        Me.btn_add.Image = Global.SAM.My.Resources.Resources.Add28
        Me.btn_add.Location = New System.Drawing.Point(275, 2)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(96, 38)
        Me.btn_add.TabIndex = 415
        Me.btn_add.Tag = ""
        Me.btn_add.Text = "เพิ่มข้อมูล"
        Me.btn_add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_add.UseVisualStyleBackColor = False
        '
        'chbPdT
        '
        Me.chbPdT.AutoSize = True
        Me.chbPdT.Location = New System.Drawing.Point(280, 13)
        Me.chbPdT.Name = "chbPdT"
        Me.chbPdT.Size = New System.Drawing.Size(65, 17)
        Me.chbPdT.TabIndex = 636
        Me.chbPdT.Text = "ชื่อสินค้า"
        Me.chbPdT.UseVisualStyleBackColor = True
        '
        'dgvCommP
        '
        Me.dgvCommP.AllowUserToAddRows = False
        Me.dgvCommP.AllowUserToDeleteRows = False
        Me.dgvCommP.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgvCommP.BackgroundColor = System.Drawing.Color.Lavender
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCommP.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvCommP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCommP.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colautonum2, Me.coledit2, Me.colPdTName, Me.colDateCommP, Me.colPayCommP, Me.colCommP, Me.colidCommP, Me.colidPdT, Me.colTargetPd})
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCommP.DefaultCellStyle = DataGridViewCellStyle14
        Me.dgvCommP.Location = New System.Drawing.Point(-1, 40)
        Me.dgvCommP.Name = "dgvCommP"
        Me.dgvCommP.RowHeadersVisible = False
        Me.dgvCommP.Size = New System.Drawing.Size(671, 307)
        Me.dgvCommP.TabIndex = 637
        '
        'colautonum2
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.Gainsboro
        Me.colautonum2.DefaultCellStyle = DataGridViewCellStyle8
        Me.colautonum2.HeaderText = "ลำดับ"
        Me.colautonum2.Name = "colautonum2"
        Me.colautonum2.ReadOnly = True
        Me.colautonum2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colautonum2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colautonum2.Width = 60
        '
        'coledit2
        '
        Me.coledit2.HeaderText = "แก้ไข"
        Me.coledit2.Image = Global.SAM.My.Resources.Resources.gdEdit
        Me.coledit2.Name = "coledit2"
        Me.coledit2.Width = 60
        '
        'colPdTName
        '
        Me.colPdTName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colPdTName.DataPropertyName = "PdTradeName"
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.Gainsboro
        Me.colPdTName.DefaultCellStyle = DataGridViewCellStyle9
        Me.colPdTName.HeaderText = "สินค้า"
        Me.colPdTName.Name = "colPdTName"
        Me.colPdTName.ReadOnly = True
        '
        'colDateCommP
        '
        Me.colDateCommP.DataPropertyName = "DateComm"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.Gainsboro
        Me.colDateCommP.DefaultCellStyle = DataGridViewCellStyle10
        Me.colDateCommP.HeaderText = "เดือน/ปี"
        Me.colDateCommP.Name = "colDateCommP"
        Me.colDateCommP.ReadOnly = True
        Me.colDateCommP.Visible = False
        Me.colDateCommP.Width = 80
        '
        'colPayCommP
        '
        Me.colPayCommP.DataPropertyName = "PayComm"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle11.Format = "N2"
        DataGridViewCellStyle11.NullValue = Nothing
        Me.colPayCommP.DefaultCellStyle = DataGridViewCellStyle11
        Me.colPayCommP.HeaderText = "ยอดขายตั้งแต่"
        Me.colPayCommP.Name = "colPayCommP"
        Me.colPayCommP.ReadOnly = True
        Me.colPayCommP.Width = 150
        '
        'colCommP
        '
        Me.colCommP.DataPropertyName = "Comm"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.Gainsboro
        Me.colCommP.DefaultCellStyle = DataGridViewCellStyle12
        Me.colCommP.HeaderText = "คอมมิสชั่น (%)"
        Me.colCommP.Name = "colCommP"
        Me.colCommP.ReadOnly = True
        '
        'colidCommP
        '
        Me.colidCommP.DataPropertyName = "idComm"
        Me.colidCommP.HeaderText = "idComm"
        Me.colidCommP.Name = "colidCommP"
        Me.colidCommP.ReadOnly = True
        Me.colidCommP.Visible = False
        '
        'colidPdT
        '
        Me.colidPdT.DataPropertyName = "idPdT"
        Me.colidPdT.HeaderText = "idPdT"
        Me.colidPdT.Name = "colidPdT"
        Me.colidPdT.ReadOnly = True
        Me.colidPdT.Visible = False
        '
        'colTargetPd
        '
        Me.colTargetPd.DataPropertyName = "Target"
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle13.Format = "N2"
        DataGridViewCellStyle13.NullValue = Nothing
        Me.colTargetPd.DefaultCellStyle = DataGridViewCellStyle13
        Me.colTargetPd.HeaderText = "เป้ายอดขาย"
        Me.colTargetPd.Name = "colTargetPd"
        Me.colTargetPd.ReadOnly = True
        Me.colTargetPd.Width = 150
        '
        'btn_add2
        '
        Me.btn_add2.BackColor = System.Drawing.Color.DimGray
        Me.btn_add2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_add2.Enabled = False
        Me.btn_add2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_add2.ForeColor = System.Drawing.Color.White
        Me.btn_add2.Image = Global.SAM.My.Resources.Resources.Add28
        Me.btn_add2.Location = New System.Drawing.Point(563, 1)
        Me.btn_add2.Name = "btn_add2"
        Me.btn_add2.Size = New System.Drawing.Size(96, 38)
        Me.btn_add2.TabIndex = 415
        Me.btn_add2.Tag = ""
        Me.btn_add2.Text = "เพิ่มข้อมูล"
        Me.btn_add2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_add2.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(112, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 18)
        Me.Label3.TabIndex = 638
        Me.Label3.Text = "ยอดขายรวม"
        '
        'txt_target
        '
        Me.txt_target.BackColor = System.Drawing.Color.Black
        Me.txt_target.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_target.ForeColor = System.Drawing.Color.LimeGreen
        Me.txt_target.Location = New System.Drawing.Point(100, 41)
        Me.txt_target.Name = "txt_target"
        Me.txt_target.ReadOnly = True
        Me.txt_target.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_target.Size = New System.Drawing.Size(134, 24)
        Me.txt_target.TabIndex = 639
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 18)
        Me.Label2.TabIndex = 640
        Me.Label2.Text = "เป้ายอดขาย"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(144, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 18)
        Me.Label4.TabIndex = 638
        Me.Label4.Text = "ยอดขายสินค้า"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btn_add2)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.dgvCommP)
        Me.Panel1.Controls.Add(Me.chbPdT)
        Me.Panel1.Controls.Add(Me.txt_PdTName)
        Me.Panel1.Controls.Add(Me.btn_seed)
        Me.Panel1.Location = New System.Drawing.Point(379, 87)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(675, 349)
        Me.Panel1.TabIndex = 641
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.btn_add)
        Me.Panel2.Controls.Add(Me.dgvComm)
        Me.Panel2.Location = New System.Drawing.Point(-1, 87)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(374, 349)
        Me.Panel2.TabIndex = 642
        '
        'btn_YM
        '
        Me.btn_YM.BackColor = System.Drawing.Color.DimGray
        Me.btn_YM.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_YM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.7!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_YM.ForeColor = System.Drawing.Color.White
        Me.btn_YM.Image = CType(resources.GetObject("btn_YM.Image"), System.Drawing.Image)
        Me.btn_YM.Location = New System.Drawing.Point(240, 10)
        Me.btn_YM.Name = "btn_YM"
        Me.btn_YM.Size = New System.Drawing.Size(28, 25)
        Me.btn_YM.TabIndex = 639
        Me.btn_YM.Tag = "Add"
        Me.btn_YM.UseVisualStyleBackColor = False
        '
        'txt_YM
        '
        Me.txt_YM.Enabled = False
        Me.txt_YM.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_YM.Location = New System.Drawing.Point(100, 9)
        Me.txt_YM.Name = "txt_YM"
        Me.txt_YM.ReadOnly = True
        Me.txt_YM.Size = New System.Drawing.Size(134, 24)
        Me.txt_YM.TabIndex = 643
        '
        'lb_PerY
        '
        Me.lb_PerY.AutoSize = True
        Me.lb_PerY.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lb_PerY.Location = New System.Drawing.Point(657, 14)
        Me.lb_PerY.Name = "lb_PerY"
        Me.lb_PerY.Size = New System.Drawing.Size(171, 16)
        Me.lb_PerY.TabIndex = 644
        Me.lb_PerY.Text = "เปอร์เซ็นส่วนต่างยอดขายปีก่อน"
        '
        'lb_PerM
        '
        Me.lb_PerM.AutoSize = True
        Me.lb_PerM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lb_PerM.Location = New System.Drawing.Point(657, 46)
        Me.lb_PerM.Name = "lb_PerM"
        Me.lb_PerM.Size = New System.Drawing.Size(190, 16)
        Me.lb_PerM.TabIndex = 645
        Me.lb_PerM.Text = "เปอร์เซ็นส่วนต่างยอดขายเดือนก่อน"
        '
        'txt_PerY
        '
        Me.txt_PerY.BackColor = System.Drawing.Color.Black
        Me.txt_PerY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_PerY.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_PerY.ForeColor = System.Drawing.Color.LimeGreen
        Me.txt_PerY.Location = New System.Drawing.Point(943, 12)
        Me.txt_PerY.Name = "txt_PerY"
        Me.txt_PerY.Size = New System.Drawing.Size(70, 22)
        Me.txt_PerY.TabIndex = 646
        '
        'txt_PerM
        '
        Me.txt_PerM.BackColor = System.Drawing.Color.Black
        Me.txt_PerM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_PerM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_PerM.ForeColor = System.Drawing.Color.LimeGreen
        Me.txt_PerM.Location = New System.Drawing.Point(943, 44)
        Me.txt_PerM.Name = "txt_PerM"
        Me.txt_PerM.Size = New System.Drawing.Size(70, 22)
        Me.txt_PerM.TabIndex = 647
        '
        'lb_Y
        '
        Me.lb_Y.AutoSize = True
        Me.lb_Y.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lb_Y.Location = New System.Drawing.Point(314, 14)
        Me.lb_Y.Name = "lb_Y"
        Me.lb_Y.Size = New System.Drawing.Size(81, 16)
        Me.lb_Y.TabIndex = 644
        Me.lb_Y.Text = "ยอดขายปีก่อน"
        '
        'lb_M
        '
        Me.lb_M.AutoSize = True
        Me.lb_M.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lb_M.Location = New System.Drawing.Point(314, 46)
        Me.lb_M.Name = "lb_M"
        Me.lb_M.Size = New System.Drawing.Size(100, 16)
        Me.lb_M.TabIndex = 645
        Me.lb_M.Text = "ยอดขายเดือนก่อน"
        '
        'txt_TotalNetM
        '
        Me.txt_TotalNetM.BackColor = System.Drawing.Color.Black
        Me.txt_TotalNetM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_TotalNetM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_TotalNetM.ForeColor = System.Drawing.Color.LimeGreen
        Me.txt_TotalNetM.Location = New System.Drawing.Point(511, 44)
        Me.txt_TotalNetM.Name = "txt_TotalNetM"
        Me.txt_TotalNetM.Size = New System.Drawing.Size(108, 22)
        Me.txt_TotalNetM.TabIndex = 649
        '
        'txt_TotalNetY
        '
        Me.txt_TotalNetY.BackColor = System.Drawing.Color.Black
        Me.txt_TotalNetY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_TotalNetY.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_TotalNetY.ForeColor = System.Drawing.Color.LimeGreen
        Me.txt_TotalNetY.Location = New System.Drawing.Point(511, 12)
        Me.txt_TotalNetY.Name = "txt_TotalNetY"
        Me.txt_TotalNetY.Size = New System.Drawing.Size(108, 22)
        Me.txt_TotalNetY.TabIndex = 648
        '
        'frmPsSaleComm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(1051, 435)
        Me.Controls.Add(Me.txt_TotalNetM)
        Me.Controls.Add(Me.txt_TotalNetY)
        Me.Controls.Add(Me.txt_PerM)
        Me.Controls.Add(Me.txt_PerY)
        Me.Controls.Add(Me.lb_M)
        Me.Controls.Add(Me.lb_PerM)
        Me.Controls.Add(Me.lb_Y)
        Me.Controls.Add(Me.lb_PerY)
        Me.Controls.Add(Me.txt_YM)
        Me.Controls.Add(Me.btn_YM)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_target)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "frmPsSaleComm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "กำหนดค่าคอมมิสชั่นเจ้าหน้าที่ขาย"
        CType(Me.dgvComm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCommP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_seed As System.Windows.Forms.Button
    Friend WithEvents txt_PdTName As System.Windows.Forms.TextBox
    Friend WithEvents dgvComm As System.Windows.Forms.DataGridView
    Friend WithEvents btn_add As System.Windows.Forms.Button
    Friend WithEvents chbPdT As System.Windows.Forms.CheckBox
    Friend WithEvents dgvCommP As System.Windows.Forms.DataGridView
    Friend WithEvents btn_add2 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_target As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btn_YM As System.Windows.Forms.Button
    Friend WithEvents txt_YM As System.Windows.Forms.TextBox
    Friend WithEvents colautonum As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coledit As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents colDateComm As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPay As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colpay2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colComm As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_idComm As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_idPdT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lb_PerY As System.Windows.Forms.Label
    Friend WithEvents lb_PerM As System.Windows.Forms.Label
    Friend WithEvents txt_PerY As System.Windows.Forms.TextBox
    Friend WithEvents txt_PerM As System.Windows.Forms.TextBox
    Friend WithEvents lb_Y As System.Windows.Forms.Label
    Friend WithEvents lb_M As System.Windows.Forms.Label
    Friend WithEvents txt_TotalNetM As System.Windows.Forms.TextBox
    Friend WithEvents txt_TotalNetY As System.Windows.Forms.TextBox
    Friend WithEvents colautonum2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coledit2 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents colPdTName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDateCommP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPayCommP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCommP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colidCommP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colidPdT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTargetPd As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
