<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMkPromotionData
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMkPromotionData))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.dgvPromotion = New System.Windows.Forms.DataGridView
        Me.ColNum = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColChk = New System.Windows.Forms.DataGridViewButtonColumn
        Me.ColDetail = New System.Windows.Forms.DataGridViewImageColumn
        Me.ColEdit = New System.Windows.Forms.DataGridViewImageColumn
        Me.ColCancel = New System.Windows.Forms.DataGridViewImageColumn
        Me.ColidPromotion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColProName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColProTypeName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColstProOpen = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColProOpen = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColstPdOfPro = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColProOdPd = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColPsPro = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Colnote = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColidPsCancel = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColPsCancel = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColCancelNote = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.btnNew = New System.Windows.Forms.Button
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.txtTotalNet = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnSFindAll = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.rdbAll = New System.Windows.Forms.RadioButton
        Me.rdbClose = New System.Windows.Forms.RadioButton
        Me.rdbOpen = New System.Windows.Forms.RadioButton
        Me.ChkProType = New System.Windows.Forms.CheckBox
        Me.txtProName = New System.Windows.Forms.TextBox
        Me.ChkProName = New System.Windows.Forms.CheckBox
        Me.cmbPmtType = New System.Windows.Forms.ComboBox
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn
        Me.DataGridViewImageColumn3 = New System.Windows.Forms.DataGridViewImageColumn
        CType(Me.dgvPromotion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvPromotion
        '
        Me.dgvPromotion.AllowUserToAddRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPromotion.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvPromotion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPromotion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColNum, Me.ColChk, Me.ColDetail, Me.ColEdit, Me.ColCancel, Me.ColidPromotion, Me.ColProName, Me.ColProTypeName, Me.ColstProOpen, Me.ColProOpen, Me.ColstPdOfPro, Me.ColProOdPd, Me.ColPsPro, Me.Colnote, Me.ColidPsCancel, Me.ColPsCancel, Me.ColCancelNote})
        Me.dgvPromotion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvPromotion.Location = New System.Drawing.Point(0, 174)
        Me.dgvPromotion.Name = "dgvPromotion"
        Me.dgvPromotion.RowHeadersVisible = False
        Me.dgvPromotion.Size = New System.Drawing.Size(934, 338)
        Me.dgvPromotion.TabIndex = 411
        '
        'ColNum
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColNum.DefaultCellStyle = DataGridViewCellStyle2
        Me.ColNum.HeaderText = "ลำดับ"
        Me.ColNum.Name = "ColNum"
        Me.ColNum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ColNum.Width = 40
        '
        'ColChk
        '
        Me.ColChk.HeaderText = "เลือก"
        Me.ColChk.Name = "ColChk"
        Me.ColChk.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColChk.Visible = False
        Me.ColChk.Width = 40
        '
        'ColDetail
        '
        Me.ColDetail.HeaderText = "รายละเอียด"
        Me.ColDetail.Image = Global.SAM.My.Resources.Resources.Open_16x16
        Me.ColDetail.Name = "ColDetail"
        Me.ColDetail.Visible = False
        Me.ColDetail.Width = 50
        '
        'ColEdit
        '
        Me.ColEdit.HeaderText = "แก้ไข"
        Me.ColEdit.Image = Global.SAM.My.Resources.Resources.Computer_Edit
        Me.ColEdit.Name = "ColEdit"
        Me.ColEdit.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColEdit.Visible = False
        Me.ColEdit.Width = 40
        '
        'ColCancel
        '
        Me.ColCancel.HeaderText = "ยกเลิก"
        Me.ColCancel.Image = CType(resources.GetObject("ColCancel.Image"), System.Drawing.Image)
        Me.ColCancel.Name = "ColCancel"
        Me.ColCancel.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColCancel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.ColCancel.Visible = False
        Me.ColCancel.Width = 40
        '
        'ColidPromotion
        '
        Me.ColidPromotion.DataPropertyName = "idPromotion"
        Me.ColidPromotion.HeaderText = "idPromotion"
        Me.ColidPromotion.Name = "ColidPromotion"
        Me.ColidPromotion.Visible = False
        '
        'ColProName
        '
        Me.ColProName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColProName.DataPropertyName = "ProName"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColProName.DefaultCellStyle = DataGridViewCellStyle3
        Me.ColProName.HeaderText = "ชื่อโปรโมชั่น"
        Me.ColProName.Name = "ColProName"
        Me.ColProName.ReadOnly = True
        Me.ColProName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'ColProTypeName
        '
        Me.ColProTypeName.DataPropertyName = "ProTypeName"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColProTypeName.DefaultCellStyle = DataGridViewCellStyle4
        Me.ColProTypeName.HeaderText = "ประเภทโปรโมชั่น"
        Me.ColProTypeName.Name = "ColProTypeName"
        Me.ColProTypeName.ReadOnly = True
        Me.ColProTypeName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ColProTypeName.Width = 150
        '
        'ColstProOpen
        '
        Me.ColstProOpen.DataPropertyName = "stProOpen"
        Me.ColstProOpen.HeaderText = "stProOpen"
        Me.ColstProOpen.Name = "ColstProOpen"
        Me.ColstProOpen.Visible = False
        '
        'ColProOpen
        '
        Me.ColProOpen.DataPropertyName = "ProOpen"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColProOpen.DefaultCellStyle = DataGridViewCellStyle5
        Me.ColProOpen.HeaderText = "สถานะเปิด-ปิดโปรโมชั่น"
        Me.ColProOpen.Name = "ColProOpen"
        Me.ColProOpen.ReadOnly = True
        Me.ColProOpen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ColProOpen.Width = 120
        '
        'ColstPdOfPro
        '
        Me.ColstPdOfPro.DataPropertyName = "stPdOfPro"
        Me.ColstPdOfPro.HeaderText = "stPdOfPro"
        Me.ColstPdOfPro.Name = "ColstPdOfPro"
        Me.ColstPdOfPro.Visible = False
        '
        'ColProOdPd
        '
        Me.ColProOdPd.DataPropertyName = "ProOdPd"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle6.Format = "N2"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.ColProOdPd.DefaultCellStyle = DataGridViewCellStyle6
        Me.ColProOdPd.HeaderText = "การผูกกับสินค้า"
        Me.ColProOdPd.Name = "ColProOdPd"
        Me.ColProOdPd.ReadOnly = True
        Me.ColProOdPd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ColProOdPd.Width = 150
        '
        'ColPsPro
        '
        Me.ColPsPro.DataPropertyName = "PsPro"
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColPsPro.DefaultCellStyle = DataGridViewCellStyle7
        Me.ColPsPro.HeaderText = "ผู้กำหนดโปรโมชั่น"
        Me.ColPsPro.Name = "ColPsPro"
        Me.ColPsPro.ReadOnly = True
        Me.ColPsPro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ColPsPro.Width = 110
        '
        'Colnote
        '
        Me.Colnote.DataPropertyName = "Note"
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Colnote.DefaultCellStyle = DataGridViewCellStyle8
        Me.Colnote.HeaderText = "หมายเหตุ"
        Me.Colnote.Name = "Colnote"
        Me.Colnote.ReadOnly = True
        Me.Colnote.Width = 140
        '
        'ColidPsCancel
        '
        Me.ColidPsCancel.DataPropertyName = "idPsCancel"
        Me.ColidPsCancel.HeaderText = "idPsCancel"
        Me.ColidPsCancel.Name = "ColidPsCancel"
        Me.ColidPsCancel.Visible = False
        '
        'ColPsCancel
        '
        Me.ColPsCancel.DataPropertyName = "PsCancel"
        Me.ColPsCancel.HeaderText = "ผู้ยกเลิก"
        Me.ColPsCancel.Name = "ColPsCancel"
        Me.ColPsCancel.Visible = False
        '
        'ColCancelNote
        '
        Me.ColCancelNote.DataPropertyName = "CancelNote"
        Me.ColCancelNote.HeaderText = "CancelNote"
        Me.ColCancelNote.Name = "ColCancelNote"
        Me.ColCancelNote.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.btnNew)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.btnSFindAll)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 136)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(934, 38)
        Me.Panel2.TabIndex = 410
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(277, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(175, 36)
        Me.Panel4.TabIndex = 586
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(40, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 16)
        Me.Label1.TabIndex = 637
        Me.Label1.Text = "โปรโมชั่นที่เปิดใช้งาน"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Location = New System.Drawing.Point(8, 10)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(26, 21)
        Me.Panel5.TabIndex = 636
        '
        'btnNew
        '
        Me.btnNew.BackColor = System.Drawing.Color.DimGray
        Me.btnNew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNew.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnNew.ForeColor = System.Drawing.Color.White
        Me.btnNew.Image = Global.SAM.My.Resources.Resources.gtk_edit
        Me.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNew.Location = New System.Drawing.Point(115, 0)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(162, 36)
        Me.btnNew.TabIndex = 585
        Me.btnNew.Tag = ""
        Me.btnNew.Text = "       กำหนดโปรโมชั่นใหม่"
        Me.btnNew.UseVisualStyleBackColor = False
        Me.btnNew.Visible = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.txtTotalNet)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(686, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(246, 36)
        Me.Panel3.TabIndex = 581
        '
        'txtTotalNet
        '
        Me.txtTotalNet.BackColor = System.Drawing.Color.Black
        Me.txtTotalNet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalNet.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTotalNet.ForeColor = System.Drawing.Color.Lime
        Me.txtTotalNet.Location = New System.Drawing.Point(116, 4)
        Me.txtTotalNet.Name = "txtTotalNet"
        Me.txtTotalNet.ReadOnly = True
        Me.txtTotalNet.Size = New System.Drawing.Size(122, 27)
        Me.txtTotalNet.TabIndex = 579
        Me.txtTotalNet.Text = "0"
        Me.txtTotalNet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 17)
        Me.Label2.TabIndex = 142
        Me.Label2.Text = "จำนวนรายการ"
        '
        'btnSFindAll
        '
        Me.btnSFindAll.BackColor = System.Drawing.Color.DimGray
        Me.btnSFindAll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSFindAll.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnSFindAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnSFindAll.ForeColor = System.Drawing.Color.White
        Me.btnSFindAll.Image = CType(resources.GetObject("btnSFindAll.Image"), System.Drawing.Image)
        Me.btnSFindAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSFindAll.Location = New System.Drawing.Point(0, 0)
        Me.btnSFindAll.Name = "btnSFindAll"
        Me.btnSFindAll.Size = New System.Drawing.Size(115, 36)
        Me.btnSFindAll.TabIndex = 580
        Me.btnSFindAll.Tag = ""
        Me.btnSFindAll.Text = "       แสดงข้อมูล"
        Me.btnSFindAll.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(934, 136)
        Me.Panel1.TabIndex = 409
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.rdbAll)
        Me.GroupBox1.Controls.Add(Me.rdbClose)
        Me.GroupBox1.Controls.Add(Me.rdbOpen)
        Me.GroupBox1.Controls.Add(Me.ChkProType)
        Me.GroupBox1.Controls.Add(Me.txtProName)
        Me.GroupBox1.Controls.Add(Me.ChkProName)
        Me.GroupBox1.Controls.Add(Me.cmbPmtType)
        Me.GroupBox1.Location = New System.Drawing.Point(233, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(454, 112)
        Me.GroupBox1.TabIndex = 626
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "เงื่อนไขการแสดงข้อมูล"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(62, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 654
        Me.Label3.Text = "สถานะโปรโมชั่น"
        '
        'rdbAll
        '
        Me.rdbAll.AutoSize = True
        Me.rdbAll.Checked = True
        Me.rdbAll.Location = New System.Drawing.Point(158, 84)
        Me.rdbAll.Name = "rdbAll"
        Me.rdbAll.Size = New System.Drawing.Size(58, 17)
        Me.rdbAll.TabIndex = 653
        Me.rdbAll.TabStop = True
        Me.rdbAll.Text = "ทั้งหมด"
        Me.rdbAll.UseVisualStyleBackColor = True
        '
        'rdbClose
        '
        Me.rdbClose.AutoSize = True
        Me.rdbClose.Location = New System.Drawing.Point(339, 84)
        Me.rdbClose.Name = "rdbClose"
        Me.rdbClose.Size = New System.Drawing.Size(108, 17)
        Me.rdbClose.TabIndex = 652
        Me.rdbClose.Text = "เฉพาะที่ไม่เปิดใช้"
        Me.rdbClose.UseVisualStyleBackColor = True
        '
        'rdbOpen
        '
        Me.rdbOpen.AutoSize = True
        Me.rdbOpen.Location = New System.Drawing.Point(232, 84)
        Me.rdbOpen.Name = "rdbOpen"
        Me.rdbOpen.Size = New System.Drawing.Size(95, 17)
        Me.rdbOpen.TabIndex = 627
        Me.rdbOpen.Text = "เฉพาะที่เปิดใช้"
        Me.rdbOpen.UseVisualStyleBackColor = True
        '
        'ChkProType
        '
        Me.ChkProType.AutoSize = True
        Me.ChkProType.Location = New System.Drawing.Point(45, 56)
        Me.ChkProType.Name = "ChkProType"
        Me.ChkProType.Size = New System.Drawing.Size(108, 17)
        Me.ChkProType.TabIndex = 650
        Me.ChkProType.Text = "ประเภทโปรโมชั่น"
        Me.ChkProType.UseVisualStyleBackColor = True
        '
        'txtProName
        '
        Me.txtProName.Enabled = False
        Me.txtProName.Location = New System.Drawing.Point(158, 22)
        Me.txtProName.Name = "txtProName"
        Me.txtProName.Size = New System.Drawing.Size(281, 20)
        Me.txtProName.TabIndex = 649
        '
        'ChkProName
        '
        Me.ChkProName.AutoSize = True
        Me.ChkProName.Location = New System.Drawing.Point(45, 26)
        Me.ChkProName.Name = "ChkProName"
        Me.ChkProName.Size = New System.Drawing.Size(84, 17)
        Me.ChkProName.TabIndex = 648
        Me.ChkProName.Text = "ชื่อโปรโมชั่น"
        Me.ChkProName.UseVisualStyleBackColor = True
        '
        'cmbPmtType
        '
        Me.cmbPmtType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbPmtType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbPmtType.Enabled = False
        Me.cmbPmtType.FormattingEnabled = True
        Me.cmbPmtType.Location = New System.Drawing.Point(158, 53)
        Me.cmbPmtType.Name = "cmbPmtType"
        Me.cmbPmtType.Size = New System.Drawing.Size(281, 21)
        Me.cmbPmtType.TabIndex = 647
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = "รายละเอียด"
        Me.DataGridViewImageColumn1.Image = Global.SAM.My.Resources.Resources.Open_16x16
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Visible = False
        Me.DataGridViewImageColumn1.Width = 50
        '
        'DataGridViewImageColumn2
        '
        Me.DataGridViewImageColumn2.HeaderText = "แก้ไข"
        Me.DataGridViewImageColumn2.Image = Global.SAM.My.Resources.Resources.Computer_Edit
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        Me.DataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn2.Visible = False
        Me.DataGridViewImageColumn2.Width = 40
        '
        'DataGridViewImageColumn3
        '
        Me.DataGridViewImageColumn3.HeaderText = "ยกเลิก"
        Me.DataGridViewImageColumn3.Image = CType(resources.GetObject("DataGridViewImageColumn3.Image"), System.Drawing.Image)
        Me.DataGridViewImageColumn3.Name = "DataGridViewImageColumn3"
        Me.DataGridViewImageColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewImageColumn3.Visible = False
        Me.DataGridViewImageColumn3.Width = 40
        '
        'frmMkPromotionData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(934, 512)
        Me.Controls.Add(Me.dgvPromotion)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmMkPromotionData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ข้อมูลโปรโมชั่น"
        CType(Me.dgvPromotion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvPromotion As System.Windows.Forms.DataGridView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents txtTotalNet As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnSFindAll As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbPmtType As System.Windows.Forms.ComboBox
    Friend WithEvents ChkProName As System.Windows.Forms.CheckBox
    Friend WithEvents ChkProType As System.Windows.Forms.CheckBox
    Friend WithEvents txtProName As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn2 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn3 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents ColNum As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColChk As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents ColDetail As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents ColEdit As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents ColCancel As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents ColidPromotion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColProName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColProTypeName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColstProOpen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColProOpen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColstPdOfPro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColProOdPd As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColPsPro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Colnote As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColidPsCancel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColPsCancel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColCancelNote As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents rdbOpen As System.Windows.Forms.RadioButton
    Friend WithEvents rdbAll As System.Windows.Forms.RadioButton
    Friend WithEvents rdbClose As System.Windows.Forms.RadioButton
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
