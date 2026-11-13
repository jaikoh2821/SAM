<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCusLevelSet
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCusLevelSet))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label7 = New System.Windows.Forms.Label
        Me.btn_save = New System.Windows.Forms.Button
        Me.txtadd = New System.Windows.Forms.TextBox
        Me.AddcusCheck = New System.Windows.Forms.CheckBox
        Me.txtsname = New System.Windows.Forms.TextBox
        Me.CHKname = New System.Windows.Forms.CheckBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.dgvDataCus = New System.Windows.Forms.DataGridView
        Me.dgvDataCus2 = New System.Windows.Forms.DataGridView
        Me.autonum = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colselect2 = New System.Windows.Forms.DataGridViewImageColumn
        Me.CusName2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Address2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.idCusType2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.idCus2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CusType2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.lbtotal = New System.Windows.Forms.Label
        Me.chknull = New System.Windows.Forms.CheckBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.SupTypeList = New System.Windows.Forms.ComboBox
        Me.prlabel = New System.Windows.Forms.Label
        Me.pblabel = New System.Windows.Forms.Label
        Me.pwlabel = New System.Windows.Forms.Label
        Me.notelabel = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label6 = New System.Windows.Forms.Label
        Me.lbCreditTotal = New System.Windows.Forms.Label
        Me.colautonum = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colCancel = New System.Windows.Forms.DataGridViewImageColumn
        Me.CusName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.idCus = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Address = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.idCusType = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CusType = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvDataCus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDataCus2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.btn_save)
        Me.Panel1.Location = New System.Drawing.Point(5, 94)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(425, 44)
        Me.Panel1.TabIndex = 434
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(245, 12)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 18)
        Me.Label7.TabIndex = 449
        '
        'btn_save
        '
        Me.btn_save.AutoSize = True
        Me.btn_save.BackColor = System.Drawing.Color.DimGray
        Me.btn_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_save.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_save.ForeColor = System.Drawing.Color.White
        Me.btn_save.Image = Global.SAM.My.Resources.Resources.Save28
        Me.btn_save.Location = New System.Drawing.Point(0, 1)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(78, 40)
        Me.btn_save.TabIndex = 417
        Me.btn_save.Text = "บันทึก"
        Me.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'txtadd
        '
        Me.txtadd.Enabled = False
        Me.txtadd.Location = New System.Drawing.Point(122, 41)
        Me.txtadd.Name = "txtadd"
        Me.txtadd.Size = New System.Drawing.Size(197, 20)
        Me.txtadd.TabIndex = 420
        '
        'AddcusCheck
        '
        Me.AddcusCheck.AutoSize = True
        Me.AddcusCheck.Location = New System.Drawing.Point(45, 46)
        Me.AddcusCheck.Name = "AddcusCheck"
        Me.AddcusCheck.Size = New System.Drawing.Size(71, 17)
        Me.AddcusCheck.TabIndex = 419
        Me.AddcusCheck.Text = "ที่อยู่ลูกค้า"
        Me.AddcusCheck.UseVisualStyleBackColor = True
        '
        'txtsname
        '
        Me.txtsname.Enabled = False
        Me.txtsname.Location = New System.Drawing.Point(122, 15)
        Me.txtsname.Name = "txtsname"
        Me.txtsname.Size = New System.Drawing.Size(197, 20)
        Me.txtsname.TabIndex = 418
        '
        'CHKname
        '
        Me.CHKname.AutoSize = True
        Me.CHKname.Location = New System.Drawing.Point(45, 20)
        Me.CHKname.Name = "CHKname"
        Me.CHKname.Size = New System.Drawing.Size(64, 17)
        Me.CHKname.TabIndex = 417
        Me.CHKname.Text = "ชื่อลูกค้า"
        Me.CHKname.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.BackColor = System.Drawing.Color.DimGray
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(345, 20)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 40)
        Me.Button1.TabIndex = 400
        Me.Button1.Text = "แสดงข้อมูล"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.dgvDataCus)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 139)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(939, 394)
        Me.Panel2.TabIndex = 437
        '
        'dgvDataCus
        '
        Me.dgvDataCus.AllowUserToAddRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDataCus.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvDataCus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDataCus.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colautonum, Me.colCancel, Me.CusName, Me.idCus, Me.Address, Me.idCusType, Me.CusType})
        Me.dgvDataCus.Location = New System.Drawing.Point(5, -3)
        Me.dgvDataCus.Name = "dgvDataCus"
        Me.dgvDataCus.RowHeadersVisible = False
        Me.dgvDataCus.Size = New System.Drawing.Size(425, 394)
        Me.dgvDataCus.TabIndex = 421
        '
        'dgvDataCus2
        '
        Me.dgvDataCus2.AllowUserToAddRows = False
        Me.dgvDataCus2.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDataCus2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvDataCus2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDataCus2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.autonum, Me.colselect2, Me.CusName2, Me.Address2, Me.idCusType2, Me.idCus2, Me.CusType2})
        Me.dgvDataCus2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvDataCus2.Location = New System.Drawing.Point(0, 82)
        Me.dgvDataCus2.Name = "dgvDataCus2"
        Me.dgvDataCus2.RowHeadersVisible = False
        Me.dgvDataCus2.Size = New System.Drawing.Size(495, 352)
        Me.dgvDataCus2.TabIndex = 422
        '
        'autonum
        '
        Me.autonum.HeaderText = "ลำดับ"
        Me.autonum.Name = "autonum"
        Me.autonum.Width = 35
        '
        'colselect2
        '
        Me.colselect2.HeaderText = "เลือก"
        Me.colselect2.Image = CType(resources.GetObject("colselect2.Image"), System.Drawing.Image)
        Me.colselect2.Name = "colselect2"
        Me.colselect2.Width = 35
        '
        'CusName2
        '
        Me.CusName2.DataPropertyName = "CusName"
        Me.CusName2.HeaderText = "ชื่อลูกค้า"
        Me.CusName2.Name = "CusName2"
        Me.CusName2.ReadOnly = True
        Me.CusName2.Width = 191
        '
        'Address2
        '
        Me.Address2.DataPropertyName = "Address"
        Me.Address2.HeaderText = "ที่อยู่ลูกค้า"
        Me.Address2.Name = "Address2"
        Me.Address2.ReadOnly = True
        Me.Address2.Width = 150
        '
        'idCusType2
        '
        Me.idCusType2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.idCusType2.DataPropertyName = "idCusType"
        Me.idCusType2.HeaderText = "idCusType"
        Me.idCusType2.Name = "idCusType2"
        Me.idCusType2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.idCusType2.Visible = False
        '
        'idCus2
        '
        Me.idCus2.DataPropertyName = "idCus"
        Me.idCus2.HeaderText = "idCus2"
        Me.idCus2.Name = "idCus2"
        Me.idCus2.Visible = False
        '
        'CusType2
        '
        Me.CusType2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CusType2.DataPropertyName = "CusType"
        Me.CusType2.HeaderText = "ระดับ"
        Me.CusType2.Name = "CusType2"
        '
        'lbtotal
        '
        Me.lbtotal.AutoSize = True
        Me.lbtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbtotal.ForeColor = System.Drawing.Color.Crimson
        Me.lbtotal.Location = New System.Drawing.Point(679, 27)
        Me.lbtotal.Name = "lbtotal"
        Me.lbtotal.Size = New System.Drawing.Size(79, 13)
        Me.lbtotal.TabIndex = 436
        Me.lbtotal.Text = "รายการทั้งหมด "
        '
        'chknull
        '
        Me.chknull.AutoSize = True
        Me.chknull.Location = New System.Drawing.Point(530, 25)
        Me.chknull.Name = "chknull"
        Me.chknull.Size = New System.Drawing.Size(142, 17)
        Me.chknull.TabIndex = 433
        Me.chknull.Text = "ลูกค้าที่ยังไม่กำหนดระดับ"
        Me.chknull.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(169, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 20)
        Me.Label1.TabIndex = 435
        Me.Label1.Text = "ระดับลูกค้า : "
        '
        'SupTypeList
        '
        Me.SupTypeList.FormattingEnabled = True
        Me.SupTypeList.Location = New System.Drawing.Point(276, 22)
        Me.SupTypeList.Name = "SupTypeList"
        Me.SupTypeList.Size = New System.Drawing.Size(234, 21)
        Me.SupTypeList.TabIndex = 432
        '
        'prlabel
        '
        Me.prlabel.AutoSize = True
        Me.prlabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.prlabel.ForeColor = System.Drawing.Color.Crimson
        Me.prlabel.Location = New System.Drawing.Point(137, 59)
        Me.prlabel.Name = "prlabel"
        Me.prlabel.Size = New System.Drawing.Size(17, 17)
        Me.prlabel.TabIndex = 439
        Me.prlabel.Text = "- "
        '
        'pblabel
        '
        Me.pblabel.AutoSize = True
        Me.pblabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.pblabel.ForeColor = System.Drawing.Color.Crimson
        Me.pblabel.Location = New System.Drawing.Point(316, 59)
        Me.pblabel.Name = "pblabel"
        Me.pblabel.Size = New System.Drawing.Size(17, 17)
        Me.pblabel.TabIndex = 440
        Me.pblabel.Text = "- "
        '
        'pwlabel
        '
        Me.pwlabel.AutoSize = True
        Me.pwlabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.pwlabel.ForeColor = System.Drawing.Color.Crimson
        Me.pwlabel.Location = New System.Drawing.Point(467, 59)
        Me.pwlabel.Name = "pwlabel"
        Me.pwlabel.Size = New System.Drawing.Size(17, 17)
        Me.pwlabel.TabIndex = 441
        Me.pwlabel.Text = "- "
        '
        'notelabel
        '
        Me.notelabel.AutoSize = True
        Me.notelabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.notelabel.ForeColor = System.Drawing.Color.Crimson
        Me.notelabel.Location = New System.Drawing.Point(804, 59)
        Me.notelabel.Name = "notelabel"
        Me.notelabel.Size = New System.Drawing.Size(17, 17)
        Me.notelabel.TabIndex = 442
        Me.notelabel.Text = "- "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(39, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 17)
        Me.Label2.TabIndex = 443
        Me.Label2.Text = "ราคาปลีกถูกลง :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(198, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 17)
        Me.Label3.TabIndex = 444
        Me.Label3.Text = "ราคาหน้าบิลถูกลง :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(374, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 17)
        Me.Label4.TabIndex = 445
        Me.Label4.Text = "ราคาส่งถูกลง :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(704, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 17)
        Me.Label5.TabIndex = 446
        Me.Label5.Text = "คำอธิบายระดับ :"
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = "เลือก"
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Width = 35
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.txtadd)
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.dgvDataCus2)
        Me.Panel3.Controls.Add(Me.AddcusCheck)
        Me.Panel3.Controls.Add(Me.txtsname)
        Me.Panel3.Controls.Add(Me.CHKname)
        Me.Panel3.Location = New System.Drawing.Point(437, 94)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(497, 436)
        Me.Panel3.TabIndex = 423
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(534, 59)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 17)
        Me.Label6.TabIndex = 447
        Me.Label6.Text = "วงเงินเครดิต :"
        '
        'lbCreditTotal
        '
        Me.lbCreditTotal.AutoSize = True
        Me.lbCreditTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbCreditTotal.ForeColor = System.Drawing.Color.Crimson
        Me.lbCreditTotal.Location = New System.Drawing.Point(621, 59)
        Me.lbCreditTotal.Name = "lbCreditTotal"
        Me.lbCreditTotal.Size = New System.Drawing.Size(17, 17)
        Me.lbCreditTotal.TabIndex = 448
        Me.lbCreditTotal.Text = "- "
        '
        'colautonum
        '
        Me.colautonum.HeaderText = "ลำดับ"
        Me.colautonum.Name = "colautonum"
        Me.colautonum.Width = 35
        '
        'colCancel
        '
        Me.colCancel.DataPropertyName = "colimage"
        Me.colCancel.HeaderText = "ยกเลิก"
        Me.colCancel.Image = Global.SAM.My.Resources.Resources.ImgNotprocess
        Me.colCancel.Name = "colCancel"
        Me.colCancel.Width = 50
        '
        'CusName
        '
        Me.CusName.DataPropertyName = "CusName"
        Me.CusName.HeaderText = "ชื่อลูกค้า"
        Me.CusName.Name = "CusName"
        Me.CusName.ReadOnly = True
        Me.CusName.Width = 179
        '
        'idCus
        '
        Me.idCus.DataPropertyName = "idCus"
        Me.idCus.HeaderText = "idCus"
        Me.idCus.Name = "idCus"
        Me.idCus.Visible = False
        '
        'Address
        '
        Me.Address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Address.DataPropertyName = "Address"
        Me.Address.FillWeight = 150.0!
        Me.Address.HeaderText = "ที่อยู่ลูกค้า"
        Me.Address.Name = "Address"
        '
        'idCusType
        '
        Me.idCusType.DataPropertyName = "idCusType"
        Me.idCusType.HeaderText = "idCusType"
        Me.idCusType.Name = "idCusType"
        Me.idCusType.Visible = False
        '
        'CusType
        '
        Me.CusType.DataPropertyName = "CusType"
        Me.CusType.HeaderText = "CusType"
        Me.CusType.Name = "CusType"
        Me.CusType.Visible = False
        '
        'frmCusLevelSet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(939, 533)
        Me.Controls.Add(Me.lbCreditTotal)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.notelabel)
        Me.Controls.Add(Me.pwlabel)
        Me.Controls.Add(Me.pblabel)
        Me.Controls.Add(Me.prlabel)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.lbtotal)
        Me.Controls.Add(Me.chknull)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SupTypeList)
        Me.Name = "frmCusLevelSet"
        Me.Text = "กำหนดระดับลูกค้า"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgvDataCus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDataCus2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtadd As System.Windows.Forms.TextBox
    Friend WithEvents AddcusCheck As System.Windows.Forms.CheckBox
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents txtsname As System.Windows.Forms.TextBox
    Friend WithEvents CHKname As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents dgvDataCus As System.Windows.Forms.DataGridView
    Friend WithEvents dgvDataCus2 As System.Windows.Forms.DataGridView
    Friend WithEvents lbtotal As System.Windows.Forms.Label
    Friend WithEvents chknull As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SupTypeList As System.Windows.Forms.ComboBox
    Friend WithEvents prlabel As System.Windows.Forms.Label
    Friend WithEvents pblabel As System.Windows.Forms.Label
    Friend WithEvents pwlabel As System.Windows.Forms.Label
    Friend WithEvents notelabel As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lbCreditTotal As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents autonum As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colselect2 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents CusName2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Address2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idCusType2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idCus2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CusType2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colautonum As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCancel As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents CusName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idCus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Address As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idCusType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CusType As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
