<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCusCommercePic
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCusCommercePic))
        Me.dgvCusComPic = New System.Windows.Forms.DataGridView
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btnSFindAll = New System.Windows.Forms.Button
        Me.txtAddress = New System.Windows.Forms.TextBox
        Me.txtCusName = New System.Windows.Forms.TextBox
        Me.chkAddress = New System.Windows.Forms.CheckBox
        Me.chkCusName = New System.Windows.Forms.CheckBox
        Me.chkNoCusCard = New System.Windows.Forms.CheckBox
        Me.chkNoCusRegistration = New System.Windows.Forms.CheckBox
        Me.chkNoCusCommercial = New System.Windows.Forms.CheckBox
        Me.chkNoCusBusiness = New System.Windows.Forms.CheckBox
        Me.lbNoCusCard = New System.Windows.Forms.Label
        Me.lbNoCusRegistration = New System.Windows.Forms.Label
        Me.lbNoCusCommercial = New System.Windows.Forms.Label
        Me.lbNoCusBusiness = New System.Windows.Forms.Label
        Me.lbNoCusBusinessEtc = New System.Windows.Forms.Label
        Me.chkNoCusBusinessEtc = New System.Windows.Forms.CheckBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.colEdit = New System.Windows.Forms.DataGridViewImageColumn
        Me.colCusName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colAddress = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colPsName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colCusCard = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.colCusRegistration = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.colCusCommercial = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.colCusBusiness = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.colCusBusinessEtc = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.idCus = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.stPicCard = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.stPicRegist = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.stCusComm = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.stCusBusiness = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.stCusBusinessEtc = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.dgvCusComPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvCusComPic
        '
        Me.dgvCusComPic.AllowUserToAddRows = False
        Me.dgvCusComPic.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCusComPic.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCusComPic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCusComPic.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colEdit, Me.colCusName, Me.colAddress, Me.colPsName, Me.colCusCard, Me.colCusRegistration, Me.colCusCommercial, Me.colCusBusiness, Me.colCusBusinessEtc, Me.idCus, Me.stPicCard, Me.stPicRegist, Me.stCusComm, Me.stCusBusiness, Me.stCusBusinessEtc})
        Me.dgvCusComPic.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvCusComPic.Location = New System.Drawing.Point(0, 152)
        Me.dgvCusComPic.Name = "dgvCusComPic"
        Me.dgvCusComPic.RowHeadersVisible = False
        Me.dgvCusComPic.Size = New System.Drawing.Size(984, 350)
        Me.dgvCusComPic.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnSFindAll)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 115)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(984, 37)
        Me.Panel2.TabIndex = 407
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
        Me.btnSFindAll.Size = New System.Drawing.Size(115, 35)
        Me.btnSFindAll.TabIndex = 397
        Me.btnSFindAll.Tag = ""
        Me.btnSFindAll.Text = "       แสดงข้อมูล"
        Me.btnSFindAll.UseVisualStyleBackColor = False
        '
        'txtAddress
        '
        Me.txtAddress.Enabled = False
        Me.txtAddress.Location = New System.Drawing.Point(92, 55)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(197, 20)
        Me.txtAddress.TabIndex = 414
        '
        'txtCusName
        '
        Me.txtCusName.Enabled = False
        Me.txtCusName.Location = New System.Drawing.Point(92, 26)
        Me.txtCusName.Name = "txtCusName"
        Me.txtCusName.Size = New System.Drawing.Size(197, 20)
        Me.txtCusName.TabIndex = 413
        '
        'chkAddress
        '
        Me.chkAddress.AutoSize = True
        Me.chkAddress.Location = New System.Drawing.Point(23, 55)
        Me.chkAddress.Name = "chkAddress"
        Me.chkAddress.Size = New System.Drawing.Size(46, 17)
        Me.chkAddress.TabIndex = 412
        Me.chkAddress.Text = "ที่อยู่"
        Me.chkAddress.UseVisualStyleBackColor = True
        '
        'chkCusName
        '
        Me.chkCusName.AutoSize = True
        Me.chkCusName.Location = New System.Drawing.Point(23, 27)
        Me.chkCusName.Name = "chkCusName"
        Me.chkCusName.Size = New System.Drawing.Size(64, 17)
        Me.chkCusName.TabIndex = 411
        Me.chkCusName.Text = "ชื่อลูกค้า"
        Me.chkCusName.UseVisualStyleBackColor = True
        '
        'chkNoCusCard
        '
        Me.chkNoCusCard.AutoSize = True
        Me.chkNoCusCard.Location = New System.Drawing.Point(16, 19)
        Me.chkNoCusCard.Name = "chkNoCusCard"
        Me.chkNoCusCard.Size = New System.Drawing.Size(111, 17)
        Me.chkNoCusCard.TabIndex = 415
        Me.chkNoCusCard.Text = "ไม่มีบัตรประชาชน"
        Me.chkNoCusCard.UseVisualStyleBackColor = True
        '
        'chkNoCusRegistration
        '
        Me.chkNoCusRegistration.AutoSize = True
        Me.chkNoCusRegistration.Location = New System.Drawing.Point(16, 42)
        Me.chkNoCusRegistration.Name = "chkNoCusRegistration"
        Me.chkNoCusRegistration.Size = New System.Drawing.Size(105, 17)
        Me.chkNoCusRegistration.TabIndex = 416
        Me.chkNoCusRegistration.Text = "ไม่มีทะเบียนบ้าน"
        Me.chkNoCusRegistration.UseVisualStyleBackColor = True
        '
        'chkNoCusCommercial
        '
        Me.chkNoCusCommercial.AutoSize = True
        Me.chkNoCusCommercial.Location = New System.Drawing.Point(16, 65)
        Me.chkNoCusCommercial.Name = "chkNoCusCommercial"
        Me.chkNoCusCommercial.Size = New System.Drawing.Size(115, 17)
        Me.chkNoCusCommercial.TabIndex = 417
        Me.chkNoCusCommercial.Text = "ไม่มีทะเบียนการค้า"
        Me.chkNoCusCommercial.UseVisualStyleBackColor = True
        '
        'chkNoCusBusiness
        '
        Me.chkNoCusBusiness.AutoSize = True
        Me.chkNoCusBusiness.Location = New System.Drawing.Point(194, 19)
        Me.chkNoCusBusiness.Name = "chkNoCusBusiness"
        Me.chkNoCusBusiness.Size = New System.Drawing.Size(116, 17)
        Me.chkNoCusBusiness.TabIndex = 418
        Me.chkNoCusBusiness.Text = "ไม่มีภาพถ่ายกิจการ"
        Me.chkNoCusBusiness.UseVisualStyleBackColor = True
        '
        'lbNoCusCard
        '
        Me.lbNoCusCard.AutoSize = True
        Me.lbNoCusCard.ForeColor = System.Drawing.Color.Red
        Me.lbNoCusCard.Location = New System.Drawing.Point(124, 20)
        Me.lbNoCusCard.Name = "lbNoCusCard"
        Me.lbNoCusCard.Size = New System.Drawing.Size(40, 13)
        Me.lbNoCusCard.TabIndex = 419
        Me.lbNoCusCard.Text = "จำนวน"
        '
        'lbNoCusRegistration
        '
        Me.lbNoCusRegistration.AutoSize = True
        Me.lbNoCusRegistration.ForeColor = System.Drawing.Color.Red
        Me.lbNoCusRegistration.Location = New System.Drawing.Point(119, 43)
        Me.lbNoCusRegistration.Name = "lbNoCusRegistration"
        Me.lbNoCusRegistration.Size = New System.Drawing.Size(40, 13)
        Me.lbNoCusRegistration.TabIndex = 420
        Me.lbNoCusRegistration.Text = "จำนวน"
        '
        'lbNoCusCommercial
        '
        Me.lbNoCusCommercial.AutoSize = True
        Me.lbNoCusCommercial.ForeColor = System.Drawing.Color.Red
        Me.lbNoCusCommercial.Location = New System.Drawing.Point(129, 66)
        Me.lbNoCusCommercial.Name = "lbNoCusCommercial"
        Me.lbNoCusCommercial.Size = New System.Drawing.Size(40, 13)
        Me.lbNoCusCommercial.TabIndex = 421
        Me.lbNoCusCommercial.Text = "จำนวน"
        '
        'lbNoCusBusiness
        '
        Me.lbNoCusBusiness.AutoSize = True
        Me.lbNoCusBusiness.ForeColor = System.Drawing.Color.Red
        Me.lbNoCusBusiness.Location = New System.Drawing.Point(307, 20)
        Me.lbNoCusBusiness.Name = "lbNoCusBusiness"
        Me.lbNoCusBusiness.Size = New System.Drawing.Size(40, 13)
        Me.lbNoCusBusiness.TabIndex = 422
        Me.lbNoCusBusiness.Text = "จำนวน"
        '
        'lbNoCusBusinessEtc
        '
        Me.lbNoCusBusinessEtc.AutoSize = True
        Me.lbNoCusBusinessEtc.ForeColor = System.Drawing.Color.Red
        Me.lbNoCusBusinessEtc.Location = New System.Drawing.Point(307, 43)
        Me.lbNoCusBusinessEtc.Name = "lbNoCusBusinessEtc"
        Me.lbNoCusBusinessEtc.Size = New System.Drawing.Size(40, 13)
        Me.lbNoCusBusinessEtc.TabIndex = 424
        Me.lbNoCusBusinessEtc.Text = "จำนวน"
        '
        'chkNoCusBusinessEtc
        '
        Me.chkNoCusBusinessEtc.AutoSize = True
        Me.chkNoCusBusinessEtc.Location = New System.Drawing.Point(194, 42)
        Me.chkNoCusBusinessEtc.Name = "chkNoCusBusinessEtc"
        Me.chkNoCusBusinessEtc.Size = New System.Drawing.Size(108, 17)
        Me.chkNoCusBusinessEtc.TabIndex = 423
        Me.chkNoCusBusinessEtc.Text = "ไม่มีหลักฐานอื่น ๆ"
        Me.chkNoCusBusinessEtc.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkCusName)
        Me.GroupBox1.Controls.Add(Me.chkAddress)
        Me.GroupBox1.Controls.Add(Me.txtCusName)
        Me.GroupBox1.Controls.Add(Me.txtAddress)
        Me.GroupBox1.Location = New System.Drawing.Point(129, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(355, 100)
        Me.GroupBox1.TabIndex = 425
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ข้อมูลทั่วไป"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkNoCusCard)
        Me.GroupBox2.Controls.Add(Me.chkNoCusRegistration)
        Me.GroupBox2.Controls.Add(Me.lbNoCusBusinessEtc)
        Me.GroupBox2.Controls.Add(Me.chkNoCusCommercial)
        Me.GroupBox2.Controls.Add(Me.chkNoCusBusinessEtc)
        Me.GroupBox2.Controls.Add(Me.chkNoCusBusiness)
        Me.GroupBox2.Controls.Add(Me.lbNoCusBusiness)
        Me.GroupBox2.Controls.Add(Me.lbNoCusCard)
        Me.GroupBox2.Controls.Add(Me.lbNoCusCommercial)
        Me.GroupBox2.Controls.Add(Me.lbNoCusRegistration)
        Me.GroupBox2.Location = New System.Drawing.Point(519, 9)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(365, 100)
        Me.GroupBox2.TabIndex = 426
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ข้อมูลภาพถ่าย"
        '
        'colEdit
        '
        Me.colEdit.HeaderText = "แก้ไข"
        Me.colEdit.Image = Global.SAM.My.Resources.Resources.gdEdit
        Me.colEdit.Name = "colEdit"
        Me.colEdit.Width = 50
        '
        'colCusName
        '
        Me.colCusName.DataPropertyName = "CusName_"
        Me.colCusName.HeaderText = "ชื่อลูกค้า"
        Me.colCusName.Name = "colCusName"
        Me.colCusName.ReadOnly = True
        Me.colCusName.Width = 170
        '
        'colAddress
        '
        Me.colAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colAddress.DataPropertyName = "Address"
        Me.colAddress.HeaderText = "ที่อยู่"
        Me.colAddress.Name = "colAddress"
        Me.colAddress.ReadOnly = True
        Me.colAddress.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colPsName
        '
        Me.colPsName.DataPropertyName = "PsName"
        Me.colPsName.HeaderText = "เจ้าหน้าที่ที่ดูแล"
        Me.colPsName.Name = "colPsName"
        Me.colPsName.ReadOnly = True
        Me.colPsName.Width = 120
        '
        'colCusCard
        '
        Me.colCusCard.FalseValue = ""
        Me.colCusCard.HeaderText = "บัตรประชาชน"
        Me.colCusCard.Name = "colCusCard"
        Me.colCusCard.ReadOnly = True
        Me.colCusCard.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colCusCard.TrueValue = ""
        '
        'colCusRegistration
        '
        Me.colCusRegistration.FalseValue = ""
        Me.colCusRegistration.HeaderText = "ทะเบียนบ้าน"
        Me.colCusRegistration.Name = "colCusRegistration"
        Me.colCusRegistration.ReadOnly = True
        Me.colCusRegistration.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colCusRegistration.TrueValue = ""
        '
        'colCusCommercial
        '
        Me.colCusCommercial.FalseValue = ""
        Me.colCusCommercial.HeaderText = "ทะเบียนการค้า"
        Me.colCusCommercial.Name = "colCusCommercial"
        Me.colCusCommercial.ReadOnly = True
        Me.colCusCommercial.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colCusCommercial.TrueValue = ""
        '
        'colCusBusiness
        '
        Me.colCusBusiness.FalseValue = ""
        Me.colCusBusiness.HeaderText = "ภาพถ่ายกิจการ"
        Me.colCusBusiness.Name = "colCusBusiness"
        Me.colCusBusiness.ReadOnly = True
        Me.colCusBusiness.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colCusBusiness.TrueValue = ""
        '
        'colCusBusinessEtc
        '
        Me.colCusBusinessEtc.HeaderText = "หลักฐานอื่นๆ"
        Me.colCusBusinessEtc.Name = "colCusBusinessEtc"
        Me.colCusBusinessEtc.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'idCus
        '
        Me.idCus.DataPropertyName = "idCus"
        Me.idCus.HeaderText = "idCus"
        Me.idCus.Name = "idCus"
        Me.idCus.Visible = False
        '
        'stPicCard
        '
        Me.stPicCard.DataPropertyName = "stPicCard"
        Me.stPicCard.HeaderText = "stPicCard"
        Me.stPicCard.Name = "stPicCard"
        Me.stPicCard.Visible = False
        '
        'stPicRegist
        '
        Me.stPicRegist.DataPropertyName = "stPicRegist"
        Me.stPicRegist.HeaderText = "stPicRegist"
        Me.stPicRegist.Name = "stPicRegist"
        Me.stPicRegist.Visible = False
        '
        'stCusComm
        '
        Me.stCusComm.DataPropertyName = "stCusComm"
        Me.stCusComm.HeaderText = "stCusComm"
        Me.stCusComm.Name = "stCusComm"
        Me.stCusComm.Visible = False
        '
        'stCusBusiness
        '
        Me.stCusBusiness.DataPropertyName = "stCusBusiness"
        Me.stCusBusiness.HeaderText = "stCusBusiness"
        Me.stCusBusiness.Name = "stCusBusiness"
        Me.stCusBusiness.Visible = False
        '
        'stCusBusinessEtc
        '
        Me.stCusBusinessEtc.DataPropertyName = "stCusBusinessEtc"
        Me.stCusBusinessEtc.HeaderText = "stCusBusinessEtc"
        Me.stCusBusinessEtc.Name = "stCusBusinessEtc"
        Me.stCusBusinessEtc.Visible = False
        '
        'frmCusCommercePic
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(984, 502)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.dgvCusComPic)
        Me.Name = "frmCusCommercePic"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "หลักฐานการทำการค้าของคู่ค้า"
        CType(Me.dgvCusComPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvCusComPic As System.Windows.Forms.DataGridView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnSFindAll As System.Windows.Forms.Button
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtCusName As System.Windows.Forms.TextBox
    Friend WithEvents chkAddress As System.Windows.Forms.CheckBox
    Friend WithEvents chkCusName As System.Windows.Forms.CheckBox
    Friend WithEvents chkNoCusCard As System.Windows.Forms.CheckBox
    Friend WithEvents chkNoCusRegistration As System.Windows.Forms.CheckBox
    Friend WithEvents chkNoCusCommercial As System.Windows.Forms.CheckBox
    Friend WithEvents chkNoCusBusiness As System.Windows.Forms.CheckBox
    Friend WithEvents lbNoCusCard As System.Windows.Forms.Label
    Friend WithEvents lbNoCusRegistration As System.Windows.Forms.Label
    Friend WithEvents lbNoCusCommercial As System.Windows.Forms.Label
    Friend WithEvents lbNoCusBusiness As System.Windows.Forms.Label
    Friend WithEvents lbNoCusBusinessEtc As System.Windows.Forms.Label
    Friend WithEvents chkNoCusBusinessEtc As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents colEdit As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents colCusName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAddress As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPsName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCusCard As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents colCusRegistration As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents colCusCommercial As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents colCusBusiness As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents colCusBusinessEtc As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents idCus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents stPicCard As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents stPicRegist As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents stCusComm As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents stCusBusiness As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents stCusBusinessEtc As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
