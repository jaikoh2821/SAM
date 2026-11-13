<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPdPkPriceData
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.dgvData = New System.Windows.Forms.DataGridView
        Me.colNum = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colPdTradeName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colPriceRetail_Old = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colPriceBill_Retail = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colPriceWholeSale = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colPriceRetail_New = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colPriceBill_New = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colPriceWholeSale_New = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colDateTs = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colPsSet = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colPsTs = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colNote = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btnSFindAll = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.dtpDateS = New System.Windows.Forms.DateTimePicker
        Me.dtpDateE = New System.Windows.Forms.DateTimePicker
        Me.txtSPdName = New System.Windows.Forms.TextBox
        Me.CbSPdName = New System.Windows.Forms.CheckBox
        Me.DayOfMonth = New System.Windows.Forms.DateTimePicker
        Me.RdSMonth = New System.Windows.Forms.RadioButton
        Me.RdSDay = New System.Windows.Forms.RadioButton
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvData
        '
        Me.dgvData.AllowUserToAddRows = False
        Me.dgvData.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colNum, Me.colPdTradeName, Me.colPriceRetail_Old, Me.colPriceBill_Retail, Me.colPriceWholeSale, Me.colPriceRetail_New, Me.colPriceBill_New, Me.colPriceWholeSale_New, Me.colDateTs, Me.colPsSet, Me.colPsTs, Me.colNote})
        Me.dgvData.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvData.Location = New System.Drawing.Point(0, 157)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.ReadOnly = True
        Me.dgvData.RowHeadersVisible = False
        Me.dgvData.Size = New System.Drawing.Size(981, 403)
        Me.dgvData.TabIndex = 0
        '
        'colNum
        '
        Me.colNum.DataPropertyName = "Num"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.colNum.DefaultCellStyle = DataGridViewCellStyle2
        Me.colNum.HeaderText = "ลำดับ"
        Me.colNum.Name = "colNum"
        Me.colNum.ReadOnly = True
        Me.colNum.Width = 40
        '
        'colPdTradeName
        '
        Me.colPdTradeName.DataPropertyName = "PdTradeName"
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.colPdTradeName.DefaultCellStyle = DataGridViewCellStyle3
        Me.colPdTradeName.HeaderText = "สินค้า"
        Me.colPdTradeName.Name = "colPdTradeName"
        Me.colPdTradeName.ReadOnly = True
        Me.colPdTradeName.Width = 150
        '
        'colPriceRetail_Old
        '
        Me.colPriceRetail_Old.DataPropertyName = "PriceRetail_Old"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.colPriceRetail_Old.DefaultCellStyle = DataGridViewCellStyle4
        Me.colPriceRetail_Old.HeaderText = "ราคาปลีกเก่า"
        Me.colPriceRetail_Old.Name = "colPriceRetail_Old"
        Me.colPriceRetail_Old.ReadOnly = True
        Me.colPriceRetail_Old.Width = 70
        '
        'colPriceBill_Retail
        '
        Me.colPriceBill_Retail.DataPropertyName = "PriceBill_Old"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.colPriceBill_Retail.DefaultCellStyle = DataGridViewCellStyle5
        Me.colPriceBill_Retail.HeaderText = "ราคาหน้าบิลเก่า"
        Me.colPriceBill_Retail.Name = "colPriceBill_Retail"
        Me.colPriceBill_Retail.ReadOnly = True
        Me.colPriceBill_Retail.Width = 70
        '
        'colPriceWholeSale
        '
        Me.colPriceWholeSale.DataPropertyName = "PriceWholeSale_Old"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle6.Format = "N2"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.colPriceWholeSale.DefaultCellStyle = DataGridViewCellStyle6
        Me.colPriceWholeSale.HeaderText = "ราคาขายส่งเก่า"
        Me.colPriceWholeSale.Name = "colPriceWholeSale"
        Me.colPriceWholeSale.ReadOnly = True
        Me.colPriceWholeSale.Width = 70
        '
        'colPriceRetail_New
        '
        Me.colPriceRetail_New.DataPropertyName = "PriceRetail_New"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle7.Format = "N2"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.colPriceRetail_New.DefaultCellStyle = DataGridViewCellStyle7
        Me.colPriceRetail_New.HeaderText = "ราคาปลีกใหม่"
        Me.colPriceRetail_New.Name = "colPriceRetail_New"
        Me.colPriceRetail_New.ReadOnly = True
        Me.colPriceRetail_New.Width = 70
        '
        'colPriceBill_New
        '
        Me.colPriceBill_New.DataPropertyName = "PriceBill_New"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle8.Format = "N2"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.colPriceBill_New.DefaultCellStyle = DataGridViewCellStyle8
        Me.colPriceBill_New.HeaderText = "ราคาหน้าบิลใหม่"
        Me.colPriceBill_New.Name = "colPriceBill_New"
        Me.colPriceBill_New.ReadOnly = True
        Me.colPriceBill_New.Width = 70
        '
        'colPriceWholeSale_New
        '
        Me.colPriceWholeSale_New.DataPropertyName = "PriceWholeSale_New"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle9.Format = "N2"
        DataGridViewCellStyle9.NullValue = Nothing
        Me.colPriceWholeSale_New.DefaultCellStyle = DataGridViewCellStyle9
        Me.colPriceWholeSale_New.HeaderText = "ราคาขายส่งใหม่"
        Me.colPriceWholeSale_New.Name = "colPriceWholeSale_New"
        Me.colPriceWholeSale_New.ReadOnly = True
        Me.colPriceWholeSale_New.Width = 70
        '
        'colDateTs
        '
        Me.colDateTs.DataPropertyName = "DateTs"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.colDateTs.DefaultCellStyle = DataGridViewCellStyle10
        Me.colDateTs.HeaderText = "วันที่ทำรายการ"
        Me.colDateTs.Name = "colDateTs"
        Me.colDateTs.ReadOnly = True
        Me.colDateTs.Width = 80
        '
        'colPsSet
        '
        Me.colPsSet.DataPropertyName = "PsSet"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.colPsSet.DefaultCellStyle = DataGridViewCellStyle11
        Me.colPsSet.HeaderText = "ผู้ปรับราคา"
        Me.colPsSet.Name = "colPsSet"
        Me.colPsSet.ReadOnly = True
        '
        'colPsTs
        '
        Me.colPsTs.DataPropertyName = "PsTs"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.colPsTs.DefaultCellStyle = DataGridViewCellStyle12
        Me.colPsTs.HeaderText = "ผู้ทำรายการ (ผู้บันทึก)"
        Me.colPsTs.Name = "colPsTs"
        Me.colPsTs.ReadOnly = True
        '
        'colNote
        '
        Me.colNote.DataPropertyName = "Note"
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.colNote.DefaultCellStyle = DataGridViewCellStyle13
        Me.colNote.HeaderText = "หมายเหตุ"
        Me.colNote.Name = "colNote"
        Me.colNote.ReadOnly = True
        Me.colNote.Width = 70
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnSFindAll)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 120)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(981, 37)
        Me.Panel2.TabIndex = 399
        '
        'btnSFindAll
        '
        Me.btnSFindAll.BackColor = System.Drawing.Color.DimGray
        Me.btnSFindAll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSFindAll.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnSFindAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnSFindAll.ForeColor = System.Drawing.Color.White
        Me.btnSFindAll.Image = Global.SAM.My.Resources.Resources.Find
        Me.btnSFindAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSFindAll.Location = New System.Drawing.Point(0, 0)
        Me.btnSFindAll.Name = "btnSFindAll"
        Me.btnSFindAll.Size = New System.Drawing.Size(115, 35)
        Me.btnSFindAll.TabIndex = 397
        Me.btnSFindAll.Tag = ""
        Me.btnSFindAll.Text = "       แสดงข้อมูล"
        Me.btnSFindAll.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(261, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(19, 13)
        Me.Label7.TabIndex = 403
        Me.Label7.Text = "ถึง"
        '
        'dtpDateS
        '
        Me.dtpDateS.Location = New System.Drawing.Point(117, 22)
        Me.dtpDateS.MinDate = New Date(1757, 1, 1, 0, 0, 0, 0)
        Me.dtpDateS.Name = "dtpDateS"
        Me.dtpDateS.Size = New System.Drawing.Size(142, 20)
        Me.dtpDateS.TabIndex = 404
        '
        'dtpDateE
        '
        Me.dtpDateE.Location = New System.Drawing.Point(281, 22)
        Me.dtpDateE.MinDate = New Date(1757, 1, 1, 0, 0, 0, 0)
        Me.dtpDateE.Name = "dtpDateE"
        Me.dtpDateE.Size = New System.Drawing.Size(139, 20)
        Me.dtpDateE.TabIndex = 405
        '
        'txtSPdName
        '
        Me.txtSPdName.Enabled = False
        Me.txtSPdName.Location = New System.Drawing.Point(131, 84)
        Me.txtSPdName.Name = "txtSPdName"
        Me.txtSPdName.Size = New System.Drawing.Size(233, 20)
        Me.txtSPdName.TabIndex = 582
        '
        'CbSPdName
        '
        Me.CbSPdName.AutoSize = True
        Me.CbSPdName.Location = New System.Drawing.Point(30, 87)
        Me.CbSPdName.Name = "CbSPdName"
        Me.CbSPdName.Size = New System.Drawing.Size(92, 17)
        Me.CbSPdName.TabIndex = 581
        Me.CbSPdName.Text = "ค้นหาชื่อสินค้า"
        Me.CbSPdName.UseVisualStyleBackColor = True
        '
        'DayOfMonth
        '
        Me.DayOfMonth.CustomFormat = "MMMM / yyyy"
        Me.DayOfMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DayOfMonth.Location = New System.Drawing.Point(116, 53)
        Me.DayOfMonth.Name = "DayOfMonth"
        Me.DayOfMonth.Size = New System.Drawing.Size(142, 20)
        Me.DayOfMonth.TabIndex = 580
        '
        'RdSMonth
        '
        Me.RdSMonth.AutoSize = True
        Me.RdSMonth.Location = New System.Drawing.Point(31, 55)
        Me.RdSMonth.Name = "RdSMonth"
        Me.RdSMonth.Size = New System.Drawing.Size(85, 17)
        Me.RdSMonth.TabIndex = 579
        Me.RdSMonth.Text = "ระหว่างเดือน"
        Me.RdSMonth.UseVisualStyleBackColor = True
        '
        'RdSDay
        '
        Me.RdSDay.AutoSize = True
        Me.RdSDay.Checked = True
        Me.RdSDay.Location = New System.Drawing.Point(32, 23)
        Me.RdSDay.Name = "RdSDay"
        Me.RdSDay.Size = New System.Drawing.Size(80, 17)
        Me.RdSDay.TabIndex = 407
        Me.RdSDay.TabStop = True
        Me.RdSDay.Text = "ระหว่างวันที่"
        Me.RdSDay.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtSPdName)
        Me.GroupBox3.Controls.Add(Me.CbSPdName)
        Me.GroupBox3.Controls.Add(Me.RdSMonth)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.dtpDateS)
        Me.GroupBox3.Controls.Add(Me.DayOfMonth)
        Me.GroupBox3.Controls.Add(Me.dtpDateE)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.RdSDay)
        Me.GroupBox3.Location = New System.Drawing.Point(246, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(455, 114)
        Me.GroupBox3.TabIndex = 583
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "เลิอกการค้นหา"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(47, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 406
        '
        'frmPdPkPriceData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(981, 560)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.dgvData)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPdPkPriceData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ข้อมูลการปรับราคาสินค้า"
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvData As System.Windows.Forms.DataGridView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnSFindAll As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dtpDateS As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDateE As System.Windows.Forms.DateTimePicker
    Friend WithEvents colNum As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPdTradeName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPriceRetail_Old As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPriceBill_Retail As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPriceWholeSale As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPriceRetail_New As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPriceBill_New As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPriceWholeSale_New As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDateTs As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPsSet As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPsTs As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colNote As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RdSDay As System.Windows.Forms.RadioButton
    Friend WithEvents DayOfMonth As System.Windows.Forms.DateTimePicker
    Friend WithEvents RdSMonth As System.Windows.Forms.RadioButton
    Friend WithEvents txtSPdName As System.Windows.Forms.TextBox
    Friend WithEvents CbSPdName As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
