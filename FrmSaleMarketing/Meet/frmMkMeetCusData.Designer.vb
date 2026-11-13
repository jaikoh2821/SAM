<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMkMeetCusData
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
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMkMeetCusData))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label1 = New System.Windows.Forms.Label
        Me.DateTime_Ts2 = New System.Windows.Forms.DateTimePicker
        Me.DateTime_Ts1 = New System.Windows.Forms.DateTimePicker
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DayOfMonth = New System.Windows.Forms.DateTimePicker
        Me.RdSMonth = New System.Windows.Forms.RadioButton
        Me.RdSDay = New System.Windows.Forms.RadioButton
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.RdAllCus = New System.Windows.Forms.RadioButton
        Me.Rd_Abroad = New System.Windows.Forms.RadioButton
        Me.Rd_InThai = New System.Windows.Forms.RadioButton
        Me.CbSCus = New System.Windows.Forms.CheckBox
        Me.txtCus = New System.Windows.Forms.TextBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.BtEmp = New System.Windows.Forms.Button
        Me.txtTitleCus = New System.Windows.Forms.TextBox
        Me.BtCus = New System.Windows.Forms.Button
        Me.txtEmp = New System.Windows.Forms.TextBox
        Me.CbSEmp = New System.Windows.Forms.CheckBox
        Me.CbSTitle = New System.Windows.Forms.CheckBox
        Me.BtTitle = New System.Windows.Forms.Button
        Me.dgvData1 = New System.Windows.Forms.DataGridView
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn
        Me.DataGridViewImageColumn3 = New System.Windows.Forms.DataGridViewImageColumn
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.btn_add = New System.Windows.Forms.Button
        Me.btn_show = New System.Windows.Forms.Button
        Me.colautonum = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cancle = New System.Windows.Forms.DataGridViewImageColumn
        Me.edit = New System.Windows.Forms.DataGridViewImageColumn
        Me.DateMeet = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CusName_ = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PsName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MeetName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MeetDetail = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Country = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.idTs = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvData1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(239, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 13)
        Me.Label1.TabIndex = 567
        Me.Label1.Text = "ถึง"
        '
        'DateTime_Ts2
        '
        Me.DateTime_Ts2.Enabled = False
        Me.DateTime_Ts2.Location = New System.Drawing.Point(262, 50)
        Me.DateTime_Ts2.Name = "DateTime_Ts2"
        Me.DateTime_Ts2.Size = New System.Drawing.Size(142, 20)
        Me.DateTime_Ts2.TabIndex = 566
        '
        'DateTime_Ts1
        '
        Me.DateTime_Ts1.Enabled = False
        Me.DateTime_Ts1.Location = New System.Drawing.Point(92, 50)
        Me.DateTime_Ts1.Name = "DateTime_Ts1"
        Me.DateTime_Ts1.Size = New System.Drawing.Size(142, 20)
        Me.DateTime_Ts1.TabIndex = 565
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DayOfMonth)
        Me.GroupBox1.Controls.Add(Me.RdSMonth)
        Me.GroupBox1.Controls.Add(Me.RdSDay)
        Me.GroupBox1.Controls.Add(Me.DateTime_Ts2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.DateTime_Ts1)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(414, 94)
        Me.GroupBox1.TabIndex = 568
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "แสดงข้อมูลการเข้าพบคู่ค้า"
        '
        'DayOfMonth
        '
        Me.DayOfMonth.CustomFormat = "MMMM / yyyy"
        Me.DayOfMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DayOfMonth.Location = New System.Drawing.Point(92, 23)
        Me.DayOfMonth.Name = "DayOfMonth"
        Me.DayOfMonth.ShowUpDown = True
        Me.DayOfMonth.Size = New System.Drawing.Size(142, 20)
        Me.DayOfMonth.TabIndex = 578
        '
        'RdSMonth
        '
        Me.RdSMonth.AutoSize = True
        Me.RdSMonth.Checked = True
        Me.RdSMonth.Location = New System.Drawing.Point(11, 24)
        Me.RdSMonth.Name = "RdSMonth"
        Me.RdSMonth.Size = New System.Drawing.Size(80, 17)
        Me.RdSMonth.TabIndex = 576
        Me.RdSMonth.TabStop = True
        Me.RdSMonth.Text = "ประจำเดือน"
        Me.RdSMonth.UseVisualStyleBackColor = True
        '
        'RdSDay
        '
        Me.RdSDay.AutoSize = True
        Me.RdSDay.Location = New System.Drawing.Point(11, 53)
        Me.RdSDay.Name = "RdSDay"
        Me.RdSDay.Size = New System.Drawing.Size(80, 17)
        Me.RdSDay.TabIndex = 575
        Me.RdSDay.Text = "ระหว่างวันที่"
        Me.RdSDay.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.RdAllCus)
        Me.GroupBox4.Controls.Add(Me.Rd_Abroad)
        Me.GroupBox4.Controls.Add(Me.Rd_InThai)
        Me.GroupBox4.Location = New System.Drawing.Point(439, 5)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(123, 94)
        Me.GroupBox4.TabIndex = 574
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "เลือกคู่ค้า"
        '
        'RdAllCus
        '
        Me.RdAllCus.AutoSize = True
        Me.RdAllCus.Location = New System.Drawing.Point(12, 63)
        Me.RdAllCus.Name = "RdAllCus"
        Me.RdAllCus.Size = New System.Drawing.Size(77, 17)
        Me.RdAllCus.TabIndex = 639
        Me.RdAllCus.Text = "คู่ค้าทั้งหมด"
        Me.RdAllCus.UseVisualStyleBackColor = True
        '
        'Rd_Abroad
        '
        Me.Rd_Abroad.AutoSize = True
        Me.Rd_Abroad.Location = New System.Drawing.Point(12, 41)
        Me.Rd_Abroad.Name = "Rd_Abroad"
        Me.Rd_Abroad.Size = New System.Drawing.Size(99, 17)
        Me.Rd_Abroad.TabIndex = 3
        Me.Rd_Abroad.Text = "คู่ค้าต่างประเทศ"
        Me.Rd_Abroad.UseVisualStyleBackColor = True
        '
        'Rd_InThai
        '
        Me.Rd_InThai.AutoSize = True
        Me.Rd_InThai.Checked = True
        Me.Rd_InThai.Location = New System.Drawing.Point(12, 19)
        Me.Rd_InThai.Name = "Rd_InThai"
        Me.Rd_InThai.Size = New System.Drawing.Size(96, 17)
        Me.Rd_InThai.TabIndex = 2
        Me.Rd_InThai.TabStop = True
        Me.Rd_InThai.Text = "คู่ค้าในประเทศ"
        Me.Rd_InThai.UseVisualStyleBackColor = True
        '
        'CbSCus
        '
        Me.CbSCus.AutoSize = True
        Me.CbSCus.Location = New System.Drawing.Point(16, 69)
        Me.CbSCus.Name = "CbSCus"
        Me.CbSCus.Size = New System.Drawing.Size(75, 17)
        Me.CbSCus.TabIndex = 572
        Me.CbSCus.Text = "หาจากคู่ค้า"
        Me.CbSCus.UseVisualStyleBackColor = True
        '
        'txtCus
        '
        Me.txtCus.Enabled = False
        Me.txtCus.Location = New System.Drawing.Point(117, 66)
        Me.txtCus.Name = "txtCus"
        Me.txtCus.Size = New System.Drawing.Size(233, 20)
        Me.txtCus.TabIndex = 637
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.BtEmp)
        Me.GroupBox3.Controls.Add(Me.txtTitleCus)
        Me.GroupBox3.Controls.Add(Me.BtCus)
        Me.GroupBox3.Controls.Add(Me.txtCus)
        Me.GroupBox3.Controls.Add(Me.txtEmp)
        Me.GroupBox3.Controls.Add(Me.CbSCus)
        Me.GroupBox3.Controls.Add(Me.CbSEmp)
        Me.GroupBox3.Controls.Add(Me.CbSTitle)
        Me.GroupBox3.Controls.Add(Me.BtTitle)
        Me.GroupBox3.Location = New System.Drawing.Point(563, 5)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(392, 94)
        Me.GroupBox3.TabIndex = 573
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "เลือกการค้นหา"
        '
        'BtEmp
        '
        Me.BtEmp.BackColor = System.Drawing.Color.DimGray
        Me.BtEmp.Enabled = False
        Me.BtEmp.Image = Global.SAM.My.Resources.Resources.Find16
        Me.BtEmp.Location = New System.Drawing.Point(350, 37)
        Me.BtEmp.Name = "BtEmp"
        Me.BtEmp.Size = New System.Drawing.Size(27, 25)
        Me.BtEmp.TabIndex = 639
        Me.BtEmp.UseVisualStyleBackColor = False
        '
        'txtTitleCus
        '
        Me.txtTitleCus.Enabled = False
        Me.txtTitleCus.Location = New System.Drawing.Point(117, 14)
        Me.txtTitleCus.Name = "txtTitleCus"
        Me.txtTitleCus.Size = New System.Drawing.Size(233, 20)
        Me.txtTitleCus.TabIndex = 626
        '
        'BtCus
        '
        Me.BtCus.BackColor = System.Drawing.Color.DimGray
        Me.BtCus.Enabled = False
        Me.BtCus.Image = Global.SAM.My.Resources.Resources.Find16
        Me.BtCus.Location = New System.Drawing.Point(350, 63)
        Me.BtCus.Name = "BtCus"
        Me.BtCus.Size = New System.Drawing.Size(27, 24)
        Me.BtCus.TabIndex = 638
        Me.BtCus.UseVisualStyleBackColor = False
        '
        'txtEmp
        '
        Me.txtEmp.Enabled = False
        Me.txtEmp.Location = New System.Drawing.Point(117, 40)
        Me.txtEmp.Name = "txtEmp"
        Me.txtEmp.Size = New System.Drawing.Size(233, 20)
        Me.txtEmp.TabIndex = 638
        '
        'CbSEmp
        '
        Me.CbSEmp.AutoSize = True
        Me.CbSEmp.Location = New System.Drawing.Point(16, 43)
        Me.CbSEmp.Name = "CbSEmp"
        Me.CbSEmp.Size = New System.Drawing.Size(97, 17)
        Me.CbSEmp.TabIndex = 571
        Me.CbSEmp.Text = "หาจากพนักงาน"
        Me.CbSEmp.UseVisualStyleBackColor = True
        '
        'CbSTitle
        '
        Me.CbSTitle.AutoSize = True
        Me.CbSTitle.Location = New System.Drawing.Point(16, 17)
        Me.CbSTitle.Name = "CbSTitle"
        Me.CbSTitle.Size = New System.Drawing.Size(81, 17)
        Me.CbSTitle.TabIndex = 570
        Me.CbSTitle.Text = "หาจากหัวข้อ"
        Me.CbSTitle.UseVisualStyleBackColor = True
        '
        'BtTitle
        '
        Me.BtTitle.BackColor = System.Drawing.Color.DimGray
        Me.BtTitle.Enabled = False
        Me.BtTitle.Image = Global.SAM.My.Resources.Resources.Find16
        Me.BtTitle.Location = New System.Drawing.Point(350, 10)
        Me.BtTitle.Name = "BtTitle"
        Me.BtTitle.Size = New System.Drawing.Size(27, 25)
        Me.BtTitle.TabIndex = 627
        Me.BtTitle.UseVisualStyleBackColor = False
        '
        'dgvData1
        '
        Me.dgvData1.AllowUserToAddRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvData1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvData1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colautonum, Me.cancle, Me.edit, Me.DateMeet, Me.CusName_, Me.PsName, Me.MeetName, Me.MeetDetail, Me.Country, Me.idTs})
        Me.dgvData1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvData1.Location = New System.Drawing.Point(0, 147)
        Me.dgvData1.Name = "dgvData1"
        Me.dgvData1.ReadOnly = True
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvData1.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvData1.RowHeadersVisible = False
        Me.dgvData1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvData1.Size = New System.Drawing.Size(984, 355)
        Me.dgvData1.TabIndex = 621
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.DataPropertyName = "edit"
        Me.DataGridViewImageColumn1.Frozen = True
        Me.DataGridViewImageColumn1.HeaderText = "แก้ไข"
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewImageColumn1.Width = 45
        '
        'DataGridViewImageColumn2
        '
        Me.DataGridViewImageColumn2.DataPropertyName = "cancle"
        Me.DataGridViewImageColumn2.Frozen = True
        Me.DataGridViewImageColumn2.HeaderText = "ยกเลิก"
        Me.DataGridViewImageColumn2.Image = CType(resources.GetObject("DataGridViewImageColumn2.Image"), System.Drawing.Image)
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        Me.DataGridViewImageColumn2.Width = 45
        '
        'DataGridViewImageColumn3
        '
        Me.DataGridViewImageColumn3.DataPropertyName = "edit"
        Me.DataGridViewImageColumn3.Frozen = True
        Me.DataGridViewImageColumn3.HeaderText = "แก้ไข"
        Me.DataGridViewImageColumn3.Image = CType(resources.GetObject("DataGridViewImageColumn3.Image"), System.Drawing.Image)
        Me.DataGridViewImageColumn3.Name = "DataGridViewImageColumn3"
        Me.DataGridViewImageColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewImageColumn3.Width = 45
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Lavender
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Controls.Add(Me.GroupBox4)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(984, 105)
        Me.Panel1.TabIndex = 622
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(834, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 20)
        Me.Label2.TabIndex = 403
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.btn_add)
        Me.Panel3.Controls.Add(Me.btn_show)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 105)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(984, 42)
        Me.Panel3.TabIndex = 623
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(759, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 20)
        Me.Label3.TabIndex = 403
        '
        'btn_add
        '
        Me.btn_add.AutoSize = True
        Me.btn_add.BackColor = System.Drawing.Color.DimGray
        Me.btn_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_add.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_add.ForeColor = System.Drawing.Color.White
        Me.btn_add.Image = Global.SAM.My.Resources.Resources.Add28
        Me.btn_add.Location = New System.Drawing.Point(106, 0)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(103, 38)
        Me.btn_add.TabIndex = 402
        Me.btn_add.Text = "ทำรายการ"
        Me.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_add.UseVisualStyleBackColor = False
        '
        'btn_show
        '
        Me.btn_show.AutoSize = True
        Me.btn_show.BackColor = System.Drawing.Color.DimGray
        Me.btn_show.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_show.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_show.ForeColor = System.Drawing.Color.White
        Me.btn_show.Image = CType(resources.GetObject("btn_show.Image"), System.Drawing.Image)
        Me.btn_show.Location = New System.Drawing.Point(-1, 0)
        Me.btn_show.Name = "btn_show"
        Me.btn_show.Size = New System.Drawing.Size(108, 38)
        Me.btn_show.TabIndex = 401
        Me.btn_show.Text = "แสดงข้อมูล"
        Me.btn_show.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_show.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_show.UseVisualStyleBackColor = False
        '
        'colautonum
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        Me.colautonum.DefaultCellStyle = DataGridViewCellStyle2
        Me.colautonum.HeaderText = "ลำดับ"
        Me.colautonum.Name = "colautonum"
        Me.colautonum.ReadOnly = True
        Me.colautonum.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colautonum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colautonum.Width = 40
        '
        'cancle
        '
        Me.cancle.DataPropertyName = "cancle"
        Me.cancle.HeaderText = "ยกเลิก"
        Me.cancle.Image = CType(resources.GetObject("cancle.Image"), System.Drawing.Image)
        Me.cancle.Name = "cancle"
        Me.cancle.ReadOnly = True
        Me.cancle.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.cancle.Width = 45
        '
        'edit
        '
        Me.edit.DataPropertyName = "edit"
        Me.edit.HeaderText = "แก้ไข"
        Me.edit.Image = CType(resources.GetObject("edit.Image"), System.Drawing.Image)
        Me.edit.Name = "edit"
        Me.edit.ReadOnly = True
        Me.edit.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.edit.Width = 45
        '
        'DateMeet
        '
        Me.DateMeet.DataPropertyName = "DateMeet"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DateMeet.DefaultCellStyle = DataGridViewCellStyle3
        Me.DateMeet.HeaderText = "วันที่"
        Me.DateMeet.Name = "DateMeet"
        Me.DateMeet.ReadOnly = True
        Me.DateMeet.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DateMeet.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DateMeet.Width = 78
        '
        'CusName_
        '
        Me.CusName_.DataPropertyName = "CusName_"
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CusName_.DefaultCellStyle = DataGridViewCellStyle4
        Me.CusName_.HeaderText = "คู่ค้า"
        Me.CusName_.Name = "CusName_"
        Me.CusName_.ReadOnly = True
        Me.CusName_.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CusName_.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.CusName_.Width = 180
        '
        'PsName
        '
        Me.PsName.DataPropertyName = "PsName"
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PsName.DefaultCellStyle = DataGridViewCellStyle5
        Me.PsName.HeaderText = "พนักงาน"
        Me.PsName.Name = "PsName"
        Me.PsName.ReadOnly = True
        Me.PsName.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.PsName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.PsName.Width = 170
        '
        'MeetName
        '
        Me.MeetName.DataPropertyName = "MeetName"
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle6.Format = "000"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.MeetName.DefaultCellStyle = DataGridViewCellStyle6
        Me.MeetName.HeaderText = "หัวข้อการเข้าพบคู่ค้า"
        Me.MeetName.Name = "MeetName"
        Me.MeetName.ReadOnly = True
        Me.MeetName.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MeetName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.MeetName.Width = 160
        '
        'MeetDetail
        '
        Me.MeetDetail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.MeetDetail.DataPropertyName = "MeetDetail"
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.WhiteSmoke
        Me.MeetDetail.DefaultCellStyle = DataGridViewCellStyle7
        Me.MeetDetail.HeaderText = "รายละเอียด"
        Me.MeetDetail.Name = "MeetDetail"
        Me.MeetDetail.ReadOnly = True
        Me.MeetDetail.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MeetDetail.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Country
        '
        Me.Country.DataPropertyName = "Country"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Country.DefaultCellStyle = DataGridViewCellStyle8
        Me.Country.HeaderText = "สถานะคู่ค้า"
        Me.Country.Name = "Country"
        Me.Country.ReadOnly = True
        Me.Country.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Country.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Country.Width = 105
        '
        'idTs
        '
        Me.idTs.DataPropertyName = "idTs"
        Me.idTs.HeaderText = "idTs"
        Me.idTs.Name = "idTs"
        Me.idTs.ReadOnly = True
        Me.idTs.Visible = False
        '
        'frmMkMeetCusData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(984, 502)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgvData1)
        Me.MaximizeBox = False
        Me.Name = "frmMkMeetCusData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ข้อมูลบันทึกการเข้าพบคู่ค้า"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgvData1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateTime_Ts2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTime_Ts1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents CbSCus As System.Windows.Forms.CheckBox
    Friend WithEvents CbSEmp As System.Windows.Forms.CheckBox
    Friend WithEvents CbSTitle As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtTitleCus As System.Windows.Forms.TextBox
    Friend WithEvents BtTitle As System.Windows.Forms.Button
    Friend WithEvents BtCus As System.Windows.Forms.Button
    Friend WithEvents txtCus As System.Windows.Forms.TextBox
    Friend WithEvents BtEmp As System.Windows.Forms.Button
    Friend WithEvents txtEmp As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Rd_Abroad As System.Windows.Forms.RadioButton
    Friend WithEvents Rd_InThai As System.Windows.Forms.RadioButton
    Friend WithEvents RdSDay As System.Windows.Forms.RadioButton
    Friend WithEvents RdSMonth As System.Windows.Forms.RadioButton
    Friend WithEvents DayOfMonth As System.Windows.Forms.DateTimePicker
    Friend WithEvents DataGridViewImageColumn2 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn3 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents RdAllCus As System.Windows.Forms.RadioButton
    Friend WithEvents dgvData1 As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btn_add As System.Windows.Forms.Button
    Friend WithEvents btn_show As System.Windows.Forms.Button
    Friend WithEvents colautonum As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cancle As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents edit As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DateMeet As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CusName_ As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PsName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MeetName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MeetDetail As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Country As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idTs As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
