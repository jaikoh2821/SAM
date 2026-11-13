<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCusCompSet
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCusCompSet))
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.txtCusName = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.DGV_AllCus = New System.Windows.Forms.DataGridView
        Me.ColSelect = New System.Windows.Forms.DataGridViewImageColumn
        Me.ColNumAll = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColidCusAll = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColCusNameAll = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColCompSet = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dgvCustomer = New System.Windows.Forms.DataGridView
        Me.ColNum = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColidCus = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colCusName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColDel = New System.Windows.Forms.DataGridViewImageColumn
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btn_save = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbComp = New System.Windows.Forms.ComboBox
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn
        Me.bntSearch = New System.Windows.Forms.Button
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.DGVCompany = New System.Windows.Forms.DataGridView
        Me.Panel8 = New System.Windows.Forms.Panel
        Me.btnSave2 = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.lblCus = New System.Windows.Forms.Label
        Me.btnCustomer = New System.Windows.Forms.Button
        Me.ColCheckbox = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.ColidComp = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColCompName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DGV_AllCus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.DGVCompany, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel8.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(684, 512)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Lavender
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(676, 486)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "กำหนดจากบริษัท"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.cmbComp)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(670, 480)
        Me.Panel1.TabIndex = 599
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.bntSearch)
        Me.Panel4.Controls.Add(Me.txtCusName)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 69)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(670, 33)
        Me.Panel4.TabIndex = 601
        '
        'txtCusName
        '
        Me.txtCusName.Location = New System.Drawing.Point(426, 5)
        Me.txtCusName.Name = "txtCusName"
        Me.txtCusName.Size = New System.Drawing.Size(172, 20)
        Me.txtCusName.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label3.Location = New System.Drawing.Point(333, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "ค้นหาลูกค้า :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label2.Location = New System.Drawing.Point(6, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ลูกค้าที่ผูกกับบริษัท : "
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.DGV_AllCus)
        Me.Panel3.Controls.Add(Me.dgvCustomer)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 102)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(670, 345)
        Me.Panel3.TabIndex = 600
        '
        'DGV_AllCus
        '
        Me.DGV_AllCus.AllowUserToAddRows = False
        Me.DGV_AllCus.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_AllCus.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_AllCus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_AllCus.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColSelect, Me.ColNumAll, Me.ColidCusAll, Me.ColCusNameAll, Me.ColCompSet})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_AllCus.DefaultCellStyle = DataGridViewCellStyle4
        Me.DGV_AllCus.Dock = System.Windows.Forms.DockStyle.Right
        Me.DGV_AllCus.EnableHeadersVisualStyles = False
        Me.DGV_AllCus.GridColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_AllCus.Location = New System.Drawing.Point(337, 0)
        Me.DGV_AllCus.Name = "DGV_AllCus"
        Me.DGV_AllCus.RowHeadersVisible = False
        Me.DGV_AllCus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DGV_AllCus.Size = New System.Drawing.Size(333, 345)
        Me.DGV_AllCus.TabIndex = 189
        '
        'ColSelect
        '
        Me.ColSelect.HeaderText = "เลือก"
        Me.ColSelect.Image = Global.SAM.My.Resources.Resources.arrow_modify_old_undo_icone_3957_16
        Me.ColSelect.Name = "ColSelect"
        Me.ColSelect.Width = 40
        '
        'ColNumAll
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColNumAll.DefaultCellStyle = DataGridViewCellStyle2
        Me.ColNumAll.HeaderText = "ลำดับ"
        Me.ColNumAll.Name = "ColNumAll"
        Me.ColNumAll.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ColNumAll.Visible = False
        Me.ColNumAll.Width = 40
        '
        'ColidCusAll
        '
        Me.ColidCusAll.DataPropertyName = "idCus"
        Me.ColidCusAll.HeaderText = "idCus"
        Me.ColidCusAll.Name = "ColidCusAll"
        Me.ColidCusAll.Visible = False
        '
        'ColCusNameAll
        '
        Me.ColCusNameAll.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColCusNameAll.DataPropertyName = "CusName_"
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColCusNameAll.DefaultCellStyle = DataGridViewCellStyle3
        Me.ColCusNameAll.HeaderText = "ชื่อลูกค้า"
        Me.ColCusNameAll.Name = "ColCusNameAll"
        Me.ColCusNameAll.ReadOnly = True
        Me.ColCusNameAll.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'ColCompSet
        '
        Me.ColCompSet.HeaderText = "บริษัทที่ผูก"
        Me.ColCompSet.Name = "ColCompSet"
        Me.ColCompSet.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ColCompSet.Visible = False
        Me.ColCompSet.Width = 200
        '
        'dgvCustomer
        '
        Me.dgvCustomer.AllowUserToAddRows = False
        Me.dgvCustomer.AllowUserToDeleteRows = False
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCustomer.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCustomer.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColNum, Me.ColidCus, Me.colCusName, Me.ColDel})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCustomer.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgvCustomer.Dock = System.Windows.Forms.DockStyle.Left
        Me.dgvCustomer.EnableHeadersVisualStyles = False
        Me.dgvCustomer.GridColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvCustomer.Location = New System.Drawing.Point(0, 0)
        Me.dgvCustomer.Name = "dgvCustomer"
        Me.dgvCustomer.RowHeadersVisible = False
        Me.dgvCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvCustomer.Size = New System.Drawing.Size(340, 345)
        Me.dgvCustomer.TabIndex = 188
        '
        'ColNum
        '
        Me.ColNum.HeaderText = "ลำดับ"
        Me.ColNum.Name = "ColNum"
        Me.ColNum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ColNum.Visible = False
        Me.ColNum.Width = 40
        '
        'ColidCus
        '
        Me.ColidCus.DataPropertyName = "idCus"
        Me.ColidCus.HeaderText = "idCus"
        Me.ColidCus.Name = "ColidCus"
        Me.ColidCus.Visible = False
        '
        'colCusName
        '
        Me.colCusName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colCusName.DataPropertyName = "CusName_"
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.colCusName.DefaultCellStyle = DataGridViewCellStyle6
        Me.colCusName.HeaderText = "ชื่อลูกค้า"
        Me.colCusName.Name = "colCusName"
        Me.colCusName.ReadOnly = True
        Me.colCusName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'ColDel
        '
        Me.ColDel.HeaderText = "ลบ"
        Me.ColDel.Image = Global.SAM.My.Resources.Resources.cross_circle_frame
        Me.ColDel.Name = "ColDel"
        Me.ColDel.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColDel.Width = 40
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btn_save)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 447)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(670, 33)
        Me.Panel2.TabIndex = 599
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.Color.DimGray
        Me.btn_save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_save.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_save.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.7!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_save.ForeColor = System.Drawing.Color.White
        Me.btn_save.Image = Global.SAM.My.Resources.Resources.Save28
        Me.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_save.Location = New System.Drawing.Point(0, 0)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(91, 31)
        Me.btn_save.TabIndex = 609
        Me.btn_save.Tag = "Add"
        Me.btn_save.Text = "    บันทึก"
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(187, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 17)
        Me.Label1.TabIndex = 189
        Me.Label1.Text = "บริษัท"
        '
        'cmbComp
        '
        Me.cmbComp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmbComp.FormattingEnabled = True
        Me.cmbComp.Location = New System.Drawing.Point(236, 21)
        Me.cmbComp.Name = "cmbComp"
        Me.cmbComp.Size = New System.Drawing.Size(217, 23)
        Me.cmbComp.TabIndex = 1
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Lavender
        Me.TabPage2.Controls.Add(Me.Panel5)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(676, 486)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "กำหนดจากลูกค้า"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = "เพิ่มลูกค้า"
        Me.DataGridViewImageColumn1.Image = Global.SAM.My.Resources.Resources.arrow2
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn1.Width = 60
        '
        'bntSearch
        '
        Me.bntSearch.Location = New System.Drawing.Point(604, 3)
        Me.bntSearch.Name = "bntSearch"
        Me.bntSearch.Size = New System.Drawing.Size(55, 23)
        Me.bntSearch.TabIndex = 1
        Me.bntSearch.Text = "ค้นหา"
        Me.bntSearch.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.lblCus)
        Me.Panel5.Controls.Add(Me.btnCustomer)
        Me.Panel5.Controls.Add(Me.Panel7)
        Me.Panel5.Controls.Add(Me.Panel8)
        Me.Panel5.Controls.Add(Me.Label6)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(3, 3)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(670, 480)
        Me.Panel5.TabIndex = 600
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.DGVCompany)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel7.Location = New System.Drawing.Point(0, 68)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(670, 379)
        Me.Panel7.TabIndex = 600
        '
        'DGVCompany
        '
        Me.DGVCompany.AllowUserToAddRows = False
        Me.DGVCompany.AllowUserToDeleteRows = False
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVCompany.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.DGVCompany.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVCompany.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColCheckbox, Me.ColidComp, Me.ColCompName})
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVCompany.DefaultCellStyle = DataGridViewCellStyle10
        Me.DGVCompany.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVCompany.EnableHeadersVisualStyles = False
        Me.DGVCompany.GridColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGVCompany.Location = New System.Drawing.Point(0, 0)
        Me.DGVCompany.Name = "DGVCompany"
        Me.DGVCompany.RowHeadersVisible = False
        Me.DGVCompany.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DGVCompany.Size = New System.Drawing.Size(670, 379)
        Me.DGVCompany.TabIndex = 188
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel8.Controls.Add(Me.btnSave2)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel8.Location = New System.Drawing.Point(0, 447)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(670, 33)
        Me.Panel8.TabIndex = 599
        '
        'btnSave2
        '
        Me.btnSave2.BackColor = System.Drawing.Color.DimGray
        Me.btnSave2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave2.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnSave2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.7!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnSave2.ForeColor = System.Drawing.Color.White
        Me.btnSave2.Image = Global.SAM.My.Resources.Resources.Save28
        Me.btnSave2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave2.Location = New System.Drawing.Point(0, 0)
        Me.btnSave2.Name = "btnSave2"
        Me.btnSave2.Size = New System.Drawing.Size(91, 31)
        Me.btnSave2.TabIndex = 609
        Me.btnSave2.Tag = "Add"
        Me.btnSave2.Text = "    บันทึก"
        Me.btnSave2.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(126, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 17)
        Me.Label6.TabIndex = 189
        Me.Label6.Text = "ลูกค้า"
        '
        'lblCus
        '
        Me.lblCus.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblCus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCus.Enabled = False
        Me.lblCus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblCus.Location = New System.Drawing.Point(172, 23)
        Me.lblCus.Name = "lblCus"
        Me.lblCus.Size = New System.Drawing.Size(334, 20)
        Me.lblCus.TabIndex = 625
        Me.lblCus.Tag = "0"
        '
        'btnCustomer
        '
        Me.btnCustomer.BackColor = System.Drawing.Color.DimGray
        Me.btnCustomer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.7!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnCustomer.ForeColor = System.Drawing.Color.White
        Me.btnCustomer.Image = CType(resources.GetObject("btnCustomer.Image"), System.Drawing.Image)
        Me.btnCustomer.Location = New System.Drawing.Point(508, 20)
        Me.btnCustomer.Name = "btnCustomer"
        Me.btnCustomer.Size = New System.Drawing.Size(28, 25)
        Me.btnCustomer.TabIndex = 626
        Me.btnCustomer.Tag = "Add"
        Me.btnCustomer.UseVisualStyleBackColor = False
        '
        'ColCheckbox
        '
        Me.ColCheckbox.HeaderText = "ผูกข้อมูล"
        Me.ColCheckbox.Name = "ColCheckbox"
        Me.ColCheckbox.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColCheckbox.Width = 70
        '
        'ColidComp
        '
        Me.ColidComp.DataPropertyName = "idComp"
        Me.ColidComp.HeaderText = "idCus"
        Me.ColidComp.Name = "ColidComp"
        Me.ColidComp.Visible = False
        '
        'ColCompName
        '
        Me.ColCompName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColCompName.DataPropertyName = "CompName"
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColCompName.DefaultCellStyle = DataGridViewCellStyle9
        Me.ColCompName.HeaderText = "ชื่อบริษัท"
        Me.ColCompName.Name = "ColCompName"
        Me.ColCompName.ReadOnly = True
        Me.ColCompName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'frmCusCompSet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(684, 512)
        Me.Controls.Add(Me.TabControl1)
        Me.MaximizeBox = False
        Me.Name = "frmCusCompSet"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "กำหนดลูกค้าของแต่ละบริษัท"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.DGV_AllCus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        CType(Me.DGVCompany, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel8.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbComp As System.Windows.Forms.ComboBox
    Friend WithEvents dgvCustomer As System.Windows.Forms.DataGridView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents DGV_AllCus As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ColSelect As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents ColNumAll As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColidCusAll As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColCusNameAll As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColCompSet As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColNum As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColidCus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCusName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColDel As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents txtCusName As System.Windows.Forms.TextBox
    Friend WithEvents bntSearch As System.Windows.Forms.Button
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents DGVCompany As System.Windows.Forms.DataGridView
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents btnSave2 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblCus As System.Windows.Forms.Label
    Friend WithEvents btnCustomer As System.Windows.Forms.Button
    Friend WithEvents ColCheckbox As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ColidComp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColCompName As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
