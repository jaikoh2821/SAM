<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPdPkStockUpdate
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
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvPd = New System.Windows.Forms.DataGridView()
        Me.colSelect = New System.Windows.Forms.DataGridViewImageColumn()
        Me.idPd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LotNum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.barcode_pd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pd_Code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_add = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.colPdName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitPd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Operetor = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ChangeAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.perboxcol = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.AfterAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.note = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldelete = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_docimport = New System.Windows.Forms.Button()
        Me.btn_note = New System.Windows.Forms.Button()
        Me.btn_operetor = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPsCommand = New System.Windows.Forms.TextBox()
        Me.txtPsAction = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtnote = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.btn_PsAction = New System.Windows.Forms.Button()
        Me.btn_Pscommand = New System.Windows.Forms.Button()
        CType(Me.dgvPd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvPd
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPd.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvPd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPd.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colSelect, Me.idPd, Me.LotNum, Me.barcode_pd, Me.Pd_Code, Me.btn_add, Me.colPdName, Me.UnitPd, Me.Amount, Me.Operetor, Me.ChangeAmount, Me.perboxcol, Me.AfterAmount, Me.note, Me.OP, Me.coldelete})
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPd.DefaultCellStyle = DataGridViewCellStyle11
        Me.dgvPd.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvPd.EnableHeadersVisualStyles = False
        Me.dgvPd.GridColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvPd.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dgvPd.Location = New System.Drawing.Point(0, 132)
        Me.dgvPd.Name = "dgvPd"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPd.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.dgvPd.RowHeadersVisible = False
        Me.dgvPd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvPd.Size = New System.Drawing.Size(1084, 369)
        Me.dgvPd.TabIndex = 3
        '
        'colSelect
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle2.NullValue = Nothing
        Me.colSelect.DefaultCellStyle = DataGridViewCellStyle2
        Me.colSelect.HeaderText = "ประวัติบันทึก"
        Me.colSelect.Image = Global.SAM.My.Resources.Resources.gdEdit
        Me.colSelect.Name = "colSelect"
        Me.colSelect.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colSelect.Width = 50
        '
        'idPd
        '
        Me.idPd.DataPropertyName = "idPd"
        Me.idPd.HeaderText = "idPd"
        Me.idPd.Name = "idPd"
        Me.idPd.Visible = False
        '
        'LotNum
        '
        Me.LotNum.DataPropertyName = "LotNum"
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LotNum.DefaultCellStyle = DataGridViewCellStyle3
        Me.LotNum.HeaderText = "เลขที่Lot"
        Me.LotNum.Name = "LotNum"
        Me.LotNum.ReadOnly = True
        Me.LotNum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'barcode_pd
        '
        Me.barcode_pd.DataPropertyName = "Barcode"
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.barcode_pd.DefaultCellStyle = DataGridViewCellStyle4
        Me.barcode_pd.HeaderText = "Barcode"
        Me.barcode_pd.Name = "barcode_pd"
        Me.barcode_pd.ReadOnly = True
        Me.barcode_pd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.barcode_pd.Width = 75
        '
        'Pd_Code
        '
        Me.Pd_Code.DataPropertyName = "PdCode"
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Pd_Code.DefaultCellStyle = DataGridViewCellStyle5
        Me.Pd_Code.HeaderText = "Code"
        Me.Pd_Code.Name = "Pd_Code"
        Me.Pd_Code.ReadOnly = True
        Me.Pd_Code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Pd_Code.Width = 75
        '
        'btn_add
        '
        Me.btn_add.HeaderText = "ค้นหา"
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Width = 40
        '
        'colPdName
        '
        Me.colPdName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colPdName.DataPropertyName = "PdName"
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.colPdName.DefaultCellStyle = DataGridViewCellStyle6
        Me.colPdName.HeaderText = "ชื่อสินค้า"
        Me.colPdName.Name = "colPdName"
        Me.colPdName.ReadOnly = True
        Me.colPdName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'UnitPd
        '
        Me.UnitPd.DataPropertyName = "PkUnitName"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.UnitPd.DefaultCellStyle = DataGridViewCellStyle7
        Me.UnitPd.HeaderText = "หน่วย"
        Me.UnitPd.Name = "UnitPd"
        Me.UnitPd.ReadOnly = True
        Me.UnitPd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.UnitPd.Width = 50
        '
        'Amount
        '
        Me.Amount.DataPropertyName = "Before"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle8.Format = "N0"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.Amount.DefaultCellStyle = DataGridViewCellStyle8
        Me.Amount.HeaderText = "จำนวนคงเหลือ"
        Me.Amount.Name = "Amount"
        Me.Amount.ReadOnly = True
        Me.Amount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Amount.Width = 75
        '
        'Operetor
        '
        Me.Operetor.HeaderText = "ตัวดำเนินการ"
        Me.Operetor.Items.AddRange(New Object() {"+", "-", "="})
        Me.Operetor.Name = "Operetor"
        Me.Operetor.Width = 80
        '
        'ChangeAmount
        '
        Me.ChangeAmount.DataPropertyName = "Change"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Format = "N0"
        DataGridViewCellStyle9.NullValue = Nothing
        Me.ChangeAmount.DefaultCellStyle = DataGridViewCellStyle9
        Me.ChangeAmount.HeaderText = "จำนวนที่เปลี่ยนแปลง"
        Me.ChangeAmount.Name = "ChangeAmount"
        Me.ChangeAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ChangeAmount.Width = 95
        '
        'perboxcol
        '
        Me.perboxcol.HeaderText = "แปลงหน่วย"
        Me.perboxcol.Name = "perboxcol"
        Me.perboxcol.Width = 50
        '
        'AfterAmount
        '
        Me.AfterAmount.DataPropertyName = "After"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle10.Format = "N0"
        DataGridViewCellStyle10.NullValue = Nothing
        Me.AfterAmount.DefaultCellStyle = DataGridViewCellStyle10
        Me.AfterAmount.HeaderText = "ยอดคงเหลือใหม่"
        Me.AfterAmount.Name = "AfterAmount"
        Me.AfterAmount.ReadOnly = True
        Me.AfterAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.AfterAmount.Width = 80
        '
        'note
        '
        Me.note.DataPropertyName = "note"
        Me.note.HeaderText = "*หมายเหตุ"
        Me.note.Name = "note"
        Me.note.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.note.Width = 80
        '
        'OP
        '
        Me.OP.DataPropertyName = "OP"
        Me.OP.HeaderText = "OP"
        Me.OP.Name = "OP"
        Me.OP.Visible = False
        '
        'coldelete
        '
        Me.coldelete.HeaderText = "ลบ"
        Me.coldelete.Image = Global.SAM.My.Resources.Resources.cross_circle_frame
        Me.coldelete.Name = "coldelete"
        Me.coldelete.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.coldelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.coldelete.Width = 30
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.btn_docimport)
        Me.Panel1.Controls.Add(Me.btn_note)
        Me.Panel1.Controls.Add(Me.btn_operetor)
        Me.Panel1.Controls.Add(Me.btn_save)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 92)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1084, 40)
        Me.Panel1.TabIndex = 607
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(668, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(245, 13)
        Me.Label3.TabIndex = 680
        Me.Label3.Text = "*ปุ่มแปลงหน่วยใช้ในกรณีที่ตรวจนับสินค้าเป็นกล่อง"
        '
        'btn_docimport
        '
        Me.btn_docimport.AutoSize = True
        Me.btn_docimport.BackColor = System.Drawing.Color.DimGray
        Me.btn_docimport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_docimport.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_docimport.ForeColor = System.Drawing.Color.White
        Me.btn_docimport.Image = Global.SAM.My.Resources.Resources.ImportDoc
        Me.btn_docimport.Location = New System.Drawing.Point(482, 0)
        Me.btn_docimport.Name = "btn_docimport"
        Me.btn_docimport.Size = New System.Drawing.Size(169, 38)
        Me.btn_docimport.TabIndex = 3
        Me.btn_docimport.Text = "เลือกสินค้าจากเอกสาร"
        Me.btn_docimport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_docimport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_docimport.UseVisualStyleBackColor = False
        Me.btn_docimport.Visible = False
        '
        'btn_note
        '
        Me.btn_note.AutoSize = True
        Me.btn_note.BackColor = System.Drawing.Color.DimGray
        Me.btn_note.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_note.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_note.ForeColor = System.Drawing.Color.White
        Me.btn_note.Image = Global.SAM.My.Resources.Resources.Find
        Me.btn_note.Location = New System.Drawing.Point(323, 0)
        Me.btn_note.Name = "btn_note"
        Me.btn_note.Size = New System.Drawing.Size(160, 38)
        Me.btn_note.TabIndex = 2
        Me.btn_note.Text = "ระบุหมายเหตุทั้งหมด"
        Me.btn_note.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_note.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_note.UseVisualStyleBackColor = False
        '
        'btn_operetor
        '
        Me.btn_operetor.AutoSize = True
        Me.btn_operetor.BackColor = System.Drawing.Color.DimGray
        Me.btn_operetor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_operetor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_operetor.ForeColor = System.Drawing.Color.White
        Me.btn_operetor.Image = Global.SAM.My.Resources.Resources.Find
        Me.btn_operetor.Location = New System.Drawing.Point(125, 0)
        Me.btn_operetor.Name = "btn_operetor"
        Me.btn_operetor.Size = New System.Drawing.Size(199, 38)
        Me.btn_operetor.TabIndex = 1
        Me.btn_operetor.Text = "เปลี่ยนตัวดำเนินการทั้งหมด"
        Me.btn_operetor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_operetor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_operetor.UseVisualStyleBackColor = False
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.Color.DimGray
        Me.btn_save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_save.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_save.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_save.ForeColor = System.Drawing.Color.White
        Me.btn_save.Image = Global.SAM.My.Resources.Resources.Save28
        Me.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_save.Location = New System.Drawing.Point(0, 0)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(126, 38)
        Me.btn_save.TabIndex = 0
        Me.btn_save.Tag = ""
        Me.btn_save.Text = "    บันทึกข้อมูล"
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(201, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 13)
        Me.Label6.TabIndex = 609
        Me.Label6.Text = "ชื่อพนักงานออกคำสั่ง"
        '
        'txtPsCommand
        '
        Me.txtPsCommand.Enabled = False
        Me.txtPsCommand.Location = New System.Drawing.Point(310, 15)
        Me.txtPsCommand.Name = "txtPsCommand"
        Me.txtPsCommand.Size = New System.Drawing.Size(176, 20)
        Me.txtPsCommand.TabIndex = 608
        '
        'txtPsAction
        '
        Me.txtPsAction.Enabled = False
        Me.txtPsAction.Location = New System.Drawing.Point(310, 53)
        Me.txtPsAction.Name = "txtPsAction"
        Me.txtPsAction.Size = New System.Drawing.Size(176, 20)
        Me.txtPsAction.TabIndex = 668
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(201, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 13)
        Me.Label1.TabIndex = 669
        Me.Label1.Text = "ชื่อพนักงานปฏิบัติงาน"
        '
        'txtnote
        '
        Me.txtnote.Location = New System.Drawing.Point(604, 9)
        Me.txtnote.Multiline = True
        Me.txtnote.Name = "txtnote"
        Me.txtnote.Size = New System.Drawing.Size(221, 70)
        Me.txtnote.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(542, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 675
        Me.Label2.Text = "*หมายเหตุ"
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle13.NullValue = Nothing
        Me.DataGridViewImageColumn1.DefaultCellStyle = DataGridViewCellStyle13
        Me.DataGridViewImageColumn1.HeaderText = "เลือก"
        Me.DataGridViewImageColumn1.Image = Global.SAM.My.Resources.Resources.gdEdit
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'DataGridViewImageColumn2
        '
        Me.DataGridViewImageColumn2.HeaderText = "ลบ"
        Me.DataGridViewImageColumn2.Image = Global.SAM.My.Resources.Resources.cross_circle_frame
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        Me.DataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewImageColumn2.Width = 30
        '
        'btn_PsAction
        '
        Me.btn_PsAction.AutoSize = True
        Me.btn_PsAction.BackColor = System.Drawing.Color.DimGray
        Me.btn_PsAction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_PsAction.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_PsAction.ForeColor = System.Drawing.Color.White
        Me.btn_PsAction.Image = Global.SAM.My.Resources.Resources.Find
        Me.btn_PsAction.Location = New System.Drawing.Point(492, 45)
        Me.btn_PsAction.Name = "btn_PsAction"
        Me.btn_PsAction.Size = New System.Drawing.Size(30, 30)
        Me.btn_PsAction.TabIndex = 1
        Me.btn_PsAction.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_PsAction.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_PsAction.UseVisualStyleBackColor = False
        '
        'btn_Pscommand
        '
        Me.btn_Pscommand.AutoSize = True
        Me.btn_Pscommand.BackColor = System.Drawing.Color.DimGray
        Me.btn_Pscommand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Pscommand.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_Pscommand.ForeColor = System.Drawing.Color.White
        Me.btn_Pscommand.Image = Global.SAM.My.Resources.Resources.Find
        Me.btn_Pscommand.Location = New System.Drawing.Point(492, 9)
        Me.btn_Pscommand.Name = "btn_Pscommand"
        Me.btn_Pscommand.Size = New System.Drawing.Size(30, 30)
        Me.btn_Pscommand.TabIndex = 0
        Me.btn_Pscommand.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Pscommand.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Pscommand.UseVisualStyleBackColor = False
        '
        'frmPdPkStockUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(1084, 501)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtnote)
        Me.Controls.Add(Me.btn_PsAction)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPsAction)
        Me.Controls.Add(Me.btn_Pscommand)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtPsCommand)
        Me.Controls.Add(Me.dgvPd)
        Me.Name = "frmPdPkStockUpdate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ปรับปรุงสต็อกสินค้าสำเร็จรูป"
        CType(Me.dgvPd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvPd As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtPsCommand As System.Windows.Forms.TextBox
    Friend WithEvents btn_Pscommand As System.Windows.Forms.Button
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents txtPsAction As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_PsAction As System.Windows.Forms.Button
    Friend WithEvents txtnote As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_note As System.Windows.Forms.Button
    Friend WithEvents btn_operetor As System.Windows.Forms.Button
    Friend WithEvents btn_docimport As System.Windows.Forms.Button
    Friend WithEvents DataGridViewImageColumn2 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents colSelect As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents idPd As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LotNum As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents barcode_pd As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Pd_Code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btn_add As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents colPdName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UnitPd As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Amount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Operetor As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents ChangeAmount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents perboxcol As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents AfterAmount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents note As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldelete As System.Windows.Forms.DataGridViewImageColumn
End Class
