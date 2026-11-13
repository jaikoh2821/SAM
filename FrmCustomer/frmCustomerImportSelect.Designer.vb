<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomerImportSelect
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
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.dgvData = New System.Windows.Forms.DataGridView
        Me.colIdCus = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colChb = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.colSelect = New System.Windows.Forms.DataGridViewImageColumn
        Me.colCancel = New System.Windows.Forms.DataGridViewImageColumn
        Me.colCount = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colCusCode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colCusName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colAddressOld = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colNote = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colStDel = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colCancelNote = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colPsCancel = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.pnlTitle = New System.Windows.Forms.Panel
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.rdbList = New System.Windows.Forms.RadioButton
        Me.rdbOnce = New System.Windows.Forms.RadioButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtCut = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtSelect = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtNon = New System.Windows.Forms.TextBox
        Me.chbNon = New System.Windows.Forms.CheckBox
        Me.chbSelect = New System.Windows.Forms.CheckBox
        Me.chbCut = New System.Windows.Forms.CheckBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtCondition = New System.Windows.Forms.TextBox
        Me.lblField = New System.Windows.Forms.Label
        Me.btnSearch = New System.Windows.Forms.Button
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn
        Me.pnlBtn = New System.Windows.Forms.Panel
        Me.btnSelectAll = New System.Windows.Forms.Button
        Me.btnBack = New System.Windows.Forms.Button
        Me.btnAdd = New System.Windows.Forms.Button
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTitle.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.pnlBtn.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvData
        '
        Me.dgvData.AllowUserToAddRows = False
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Blue
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colIdCus, Me.colChb, Me.colSelect, Me.colCancel, Me.colCount, Me.colCusCode, Me.colCusName, Me.colAddressOld, Me.colNote, Me.colStDel, Me.colCancelNote, Me.colPsCancel})
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvData.DefaultCellStyle = DataGridViewCellStyle15
        Me.dgvData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvData.GridColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvData.Location = New System.Drawing.Point(0, 117)
        Me.dgvData.Name = "dgvData"
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvData.RowHeadersDefaultCellStyle = DataGridViewCellStyle16
        Me.dgvData.RowHeadersVisible = False
        Me.dgvData.Size = New System.Drawing.Size(934, 445)
        Me.dgvData.TabIndex = 577
        '
        'colIdCus
        '
        Me.colIdCus.DataPropertyName = "idCus"
        Me.colIdCus.HeaderText = "id"
        Me.colIdCus.Name = "colIdCus"
        Me.colIdCus.Visible = False
        '
        'colChb
        '
        Me.colChb.HeaderText = "เลือก"
        Me.colChb.Name = "colChb"
        Me.colChb.Visible = False
        Me.colChb.Width = 40
        '
        'colSelect
        '
        Me.colSelect.HeaderText = "เลือก"
        Me.colSelect.Image = Global.SAM.My.Resources.Resources.FindItemInGrid
        Me.colSelect.Name = "colSelect"
        Me.colSelect.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colSelect.Width = 40
        '
        'colCancel
        '
        Me.colCancel.HeaderText = "คัดออก"
        Me.colCancel.Image = Global.SAM.My.Resources.Resources.DocCancel18
        Me.colCancel.Name = "colCancel"
        Me.colCancel.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colCancel.Width = 50
        '
        'colCount
        '
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.colCount.DefaultCellStyle = DataGridViewCellStyle10
        Me.colCount.HeaderText = "ลำดับ"
        Me.colCount.Name = "colCount"
        Me.colCount.Width = 35
        '
        'colCusCode
        '
        Me.colCusCode.DataPropertyName = "CusCode"
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.colCusCode.DefaultCellStyle = DataGridViewCellStyle11
        Me.colCusCode.HeaderText = "รหัสลูกค้า"
        Me.colCusCode.Name = "colCusCode"
        Me.colCusCode.ReadOnly = True
        Me.colCusCode.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colCusCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colCusCode.Width = 80
        '
        'colCusName
        '
        Me.colCusName.DataPropertyName = "CusName"
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.colCusName.DefaultCellStyle = DataGridViewCellStyle12
        Me.colCusName.HeaderText = "ชื่อลูกค้า"
        Me.colCusName.Name = "colCusName"
        Me.colCusName.ReadOnly = True
        Me.colCusName.Width = 250
        '
        'colAddressOld
        '
        Me.colAddressOld.DataPropertyName = "AddressOld"
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.colAddressOld.DefaultCellStyle = DataGridViewCellStyle13
        Me.colAddressOld.HeaderText = "ที่อยู่"
        Me.colAddressOld.Name = "colAddressOld"
        Me.colAddressOld.ReadOnly = True
        Me.colAddressOld.Width = 350
        '
        'colNote
        '
        Me.colNote.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colNote.DataPropertyName = "Note"
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle14.Format = "N0"
        DataGridViewCellStyle14.NullValue = "0"
        Me.colNote.DefaultCellStyle = DataGridViewCellStyle14
        Me.colNote.HeaderText = "หมายเหตุ"
        Me.colNote.Name = "colNote"
        Me.colNote.ReadOnly = True
        '
        'colStDel
        '
        Me.colStDel.DataPropertyName = "stDel"
        Me.colStDel.HeaderText = "stDel"
        Me.colStDel.Name = "colStDel"
        Me.colStDel.Visible = False
        '
        'colCancelNote
        '
        Me.colCancelNote.DataPropertyName = "CancelNote"
        Me.colCancelNote.HeaderText = "CancelNote"
        Me.colCancelNote.Name = "colCancelNote"
        Me.colCancelNote.Visible = False
        '
        'colPsCancel
        '
        Me.colPsCancel.DataPropertyName = "PsCancel"
        Me.colPsCancel.HeaderText = "PsCancel"
        Me.colPsCancel.Name = "colPsCancel"
        Me.colPsCancel.Visible = False
        '
        'pnlTitle
        '
        Me.pnlTitle.Controls.Add(Me.GroupBox2)
        Me.pnlTitle.Controls.Add(Me.GroupBox1)
        Me.pnlTitle.Controls.Add(Me.txtCondition)
        Me.pnlTitle.Controls.Add(Me.lblField)
        Me.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTitle.Location = New System.Drawing.Point(0, 0)
        Me.pnlTitle.Name = "pnlTitle"
        Me.pnlTitle.Size = New System.Drawing.Size(934, 80)
        Me.pnlTitle.TabIndex = 578
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rdbList)
        Me.GroupBox2.Controls.Add(Me.rdbOnce)
        Me.GroupBox2.Location = New System.Drawing.Point(760, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(162, 67)
        Me.GroupBox2.TabIndex = 459
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "การเลือกข้อมูล"
        '
        'rdbList
        '
        Me.rdbList.AutoSize = True
        Me.rdbList.Location = New System.Drawing.Point(25, 40)
        Me.rdbList.Name = "rdbList"
        Me.rdbList.Size = New System.Drawing.Size(86, 17)
        Me.rdbList.TabIndex = 1
        Me.rdbList.Text = "หลายรายการ"
        Me.rdbList.UseVisualStyleBackColor = True
        '
        'rdbOnce
        '
        Me.rdbOnce.AutoSize = True
        Me.rdbOnce.Checked = True
        Me.rdbOnce.Location = New System.Drawing.Point(25, 19)
        Me.rdbOnce.Name = "rdbOnce"
        Me.rdbOnce.Size = New System.Drawing.Size(79, 17)
        Me.rdbOnce.TabIndex = 0
        Me.rdbOnce.TabStop = True
        Me.rdbOnce.Text = "ทีละรายการ"
        Me.rdbOnce.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtCut)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtSelect)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtNon)
        Me.GroupBox1.Controls.Add(Me.chbNon)
        Me.GroupBox1.Controls.Add(Me.chbSelect)
        Me.GroupBox1.Controls.Add(Me.chbCut)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(268, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(486, 66)
        Me.GroupBox1.TabIndex = 457
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ระบุการแสดงข้อมูล"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(397, 42)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 460
        Me.Label5.Text = "รายการ"
        '
        'txtCut
        '
        Me.txtCut.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtCut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCut.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCut.ForeColor = System.Drawing.Color.Lime
        Me.txtCut.Location = New System.Drawing.Point(326, 38)
        Me.txtCut.Name = "txtCut"
        Me.txtCut.Size = New System.Drawing.Size(69, 20)
        Me.txtCut.TabIndex = 459
        Me.txtCut.Text = "0"
        Me.txtCut.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(239, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 458
        Me.Label3.Text = "รายการ"
        '
        'txtSelect
        '
        Me.txtSelect.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtSelect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtSelect.ForeColor = System.Drawing.Color.Lime
        Me.txtSelect.Location = New System.Drawing.Point(168, 38)
        Me.txtSelect.Name = "txtSelect"
        Me.txtSelect.Size = New System.Drawing.Size(69, 20)
        Me.txtSelect.TabIndex = 457
        Me.txtSelect.Text = "0"
        Me.txtSelect.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(104, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 456
        Me.Label2.Text = "รายการ"
        '
        'txtNon
        '
        Me.txtNon.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtNon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNon.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtNon.ForeColor = System.Drawing.Color.Lime
        Me.txtNon.Location = New System.Drawing.Point(33, 38)
        Me.txtNon.Name = "txtNon"
        Me.txtNon.Size = New System.Drawing.Size(69, 20)
        Me.txtNon.TabIndex = 455
        Me.txtNon.Text = "0"
        Me.txtNon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'chbNon
        '
        Me.chbNon.AutoSize = True
        Me.chbNon.Checked = True
        Me.chbNon.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chbNon.Location = New System.Drawing.Point(33, 21)
        Me.chbNon.Name = "chbNon"
        Me.chbNon.Size = New System.Drawing.Size(121, 17)
        Me.chbNon.TabIndex = 0
        Me.chbNon.Text = "แสดงที่ยังไม่ได้เลือก"
        Me.chbNon.UseVisualStyleBackColor = True
        '
        'chbSelect
        '
        Me.chbSelect.AutoSize = True
        Me.chbSelect.Checked = True
        Me.chbSelect.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chbSelect.Location = New System.Drawing.Point(168, 21)
        Me.chbSelect.Name = "chbSelect"
        Me.chbSelect.Size = New System.Drawing.Size(112, 17)
        Me.chbSelect.TabIndex = 1
        Me.chbSelect.Text = "แสดงที่เลือกแล้ว ="
        Me.chbSelect.UseVisualStyleBackColor = True
        '
        'chbCut
        '
        Me.chbCut.AutoSize = True
        Me.chbCut.Checked = True
        Me.chbCut.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chbCut.Location = New System.Drawing.Point(326, 21)
        Me.chbCut.Name = "chbCut"
        Me.chbCut.Size = New System.Drawing.Size(101, 17)
        Me.chbCut.TabIndex = 2
        Me.chbCut.Text = "แสดงที่คัดออก ="
        Me.chbCut.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Salmon
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(429, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 19)
        Me.Label1.TabIndex = 454
        Me.Label1.Text = "  "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.LightGreen
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(281, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(20, 19)
        Me.Label4.TabIndex = 453
        Me.Label4.Text = "  "
        '
        'txtCondition
        '
        Me.txtCondition.BackColor = System.Drawing.Color.White
        Me.txtCondition.Location = New System.Drawing.Point(95, 28)
        Me.txtCondition.Name = "txtCondition"
        Me.txtCondition.Size = New System.Drawing.Size(163, 20)
        Me.txtCondition.TabIndex = 456
        '
        'lblField
        '
        Me.lblField.AutoSize = True
        Me.lblField.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblField.Location = New System.Drawing.Point(27, 31)
        Me.lblField.Name = "lblField"
        Me.lblField.Size = New System.Drawing.Size(65, 13)
        Me.lblField.TabIndex = 455
        Me.lblField.Text = "ค้นหาจากชื่อ"
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.DimGray
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.7!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.Image = Global.SAM.My.Resources.Resources.Find
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearch.Location = New System.Drawing.Point(0, 0)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(125, 37)
        Me.btnSearch.TabIndex = 458
        Me.btnSearch.Tag = ""
        Me.btnSearch.Text = "        แสดงข้อมูล"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = "เลือก"
        Me.DataGridViewImageColumn1.Image = Global.SAM.My.Resources.Resources.FindItemInGrid
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn1.Width = 40
        '
        'DataGridViewImageColumn2
        '
        Me.DataGridViewImageColumn2.HeaderText = "ยกเลิก"
        Me.DataGridViewImageColumn2.Image = Global.SAM.My.Resources.Resources.DocCancel18
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        Me.DataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewImageColumn2.Visible = False
        Me.DataGridViewImageColumn2.Width = 40
        '
        'pnlBtn
        '
        Me.pnlBtn.BackColor = System.Drawing.Color.CornflowerBlue
        Me.pnlBtn.Controls.Add(Me.btnSelectAll)
        Me.pnlBtn.Controls.Add(Me.btnBack)
        Me.pnlBtn.Controls.Add(Me.btnSearch)
        Me.pnlBtn.Controls.Add(Me.btnAdd)
        Me.pnlBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlBtn.Location = New System.Drawing.Point(0, 80)
        Me.pnlBtn.Name = "pnlBtn"
        Me.pnlBtn.Size = New System.Drawing.Size(934, 37)
        Me.pnlBtn.TabIndex = 579
        '
        'btnSelectAll
        '
        Me.btnSelectAll.BackColor = System.Drawing.Color.DimGray
        Me.btnSelectAll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSelectAll.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnSelectAll.Enabled = False
        Me.btnSelectAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.7!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnSelectAll.ForeColor = System.Drawing.Color.White
        Me.btnSelectAll.Image = Global.SAM.My.Resources.Resources.ApproveAll
        Me.btnSelectAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSelectAll.Location = New System.Drawing.Point(125, 0)
        Me.btnSelectAll.Name = "btnSelectAll"
        Me.btnSelectAll.Size = New System.Drawing.Size(151, 37)
        Me.btnSelectAll.TabIndex = 459
        Me.btnSelectAll.Tag = ""
        Me.btnSelectAll.Text = "        เพิ่มที่เลือกทั้งหมด"
        Me.btnSelectAll.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnBack.Location = New System.Drawing.Point(473, 6)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(249, 28)
        Me.btnBack.TabIndex = 1
        Me.btnBack.Text = "มีรายการช้ำ กลับไปเลือกข้อมูลใหม่"
        Me.btnBack.UseVisualStyleBackColor = True
        Me.btnBack.Visible = False
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(203, 6)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(249, 28)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "ไม่มีรายการช้ำ ทำการเพิ่มรายการเช้าระบบ"
        Me.btnAdd.UseVisualStyleBackColor = True
        Me.btnAdd.Visible = False
        '
        'frmCustomerImportSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(934, 562)
        Me.Controls.Add(Me.dgvData)
        Me.Controls.Add(Me.pnlBtn)
        Me.Controls.Add(Me.pnlTitle)
        Me.MaximizeBox = False
        Me.Name = "frmCustomerImportSelect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "เลือกข้อมูลนำเข้าจากระบบเดิม ที่ต้องการใช้ในระบบใหม่"
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTitle.ResumeLayout(False)
        Me.pnlTitle.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.pnlBtn.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvData As System.Windows.Forms.DataGridView
    Friend WithEvents pnlTitle As System.Windows.Forms.Panel
    Friend WithEvents chbCut As System.Windows.Forms.CheckBox
    Friend WithEvents chbSelect As System.Windows.Forms.CheckBox
    Friend WithEvents chbNon As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCondition As System.Windows.Forms.TextBox
    Friend WithEvents lblField As System.Windows.Forms.Label
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn2 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents pnlBtn As System.Windows.Forms.Panel
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCut As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtSelect As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNon As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rdbList As System.Windows.Forms.RadioButton
    Friend WithEvents rdbOnce As System.Windows.Forms.RadioButton
    Friend WithEvents colIdCus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colChb As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents colSelect As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents colCancel As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents colCount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCusCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCusName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAddressOld As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colNote As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colStDel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCancelNote As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPsCancel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnSelectAll As System.Windows.Forms.Button
End Class
