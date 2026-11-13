<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSaleSummaryRpt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSaleSummaryRpt))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rdbDateB = New System.Windows.Forms.RadioButton
        Me.dtpDate = New System.Windows.Forms.DateTimePicker
        Me.rdbDate = New System.Windows.Forms.RadioButton
        Me.dtpDateS = New System.Windows.Forms.DateTimePicker
        Me.dtpYear = New System.Windows.Forms.DateTimePicker
        Me.dtpDateE = New System.Windows.Forms.DateTimePicker
        Me.dtpMonth = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.rdbYear = New System.Windows.Forms.RadioButton
        Me.rdbMonth = New System.Windows.Forms.RadioButton
        Me.rbType3 = New System.Windows.Forms.RadioButton
        Me.rbType2 = New System.Windows.Forms.RadioButton
        Me.rbType1 = New System.Windows.Forms.RadioButton
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnOK = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.rdbCusNotSale = New System.Windows.Forms.RadioButton
        Me.rdbPdPkNotSale = New System.Windows.Forms.RadioButton
        Me.rdbSalePv = New System.Windows.Forms.RadioButton
        Me.rbSale = New System.Windows.Forms.RadioButton
        Me.rbPlant = New System.Windows.Forms.RadioButton
        Me.rbPd = New System.Windows.Forms.RadioButton
        Me.rbCus = New System.Windows.Forms.RadioButton
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.rdbMinMax = New System.Windows.Forms.RadioButton
        Me.rdbMaxMin = New System.Windows.Forms.RadioButton
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.rdbGen = New System.Windows.Forms.RadioButton
        Me.RadioButton3 = New System.Windows.Forms.RadioButton
        Me.rdbMat = New System.Windows.Forms.RadioButton
        Me.rdbOther = New System.Windows.Forms.RadioButton
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdbDateB)
        Me.GroupBox1.Controls.Add(Me.dtpDate)
        Me.GroupBox1.Controls.Add(Me.rdbDate)
        Me.GroupBox1.Controls.Add(Me.dtpDateS)
        Me.GroupBox1.Controls.Add(Me.dtpYear)
        Me.GroupBox1.Controls.Add(Me.dtpDateE)
        Me.GroupBox1.Controls.Add(Me.dtpMonth)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.rdbYear)
        Me.GroupBox1.Controls.Add(Me.rdbMonth)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(470, 124)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ช่วงข้อมูล"
        '
        'rdbDateB
        '
        Me.rdbDateB.AutoSize = True
        Me.rdbDateB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rdbDateB.Location = New System.Drawing.Point(34, 54)
        Me.rdbDateB.Name = "rdbDateB"
        Me.rdbDateB.Size = New System.Drawing.Size(64, 17)
        Me.rdbDateB.TabIndex = 628
        Me.rdbDateB.Text = "ช่วงวันที่"
        Me.rdbDateB.UseVisualStyleBackColor = True
        '
        'dtpDate
        '
        Me.dtpDate.Enabled = False
        Me.dtpDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpDate.Location = New System.Drawing.Point(104, 19)
        Me.dtpDate.MinDate = New Date(1757, 1, 1, 0, 0, 0, 0)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(131, 20)
        Me.dtpDate.TabIndex = 624
        '
        'rdbDate
        '
        Me.rdbDate.AutoSize = True
        Me.rdbDate.Checked = True
        Me.rdbDate.Location = New System.Drawing.Point(35, 23)
        Me.rdbDate.Name = "rdbDate"
        Me.rdbDate.Size = New System.Drawing.Size(55, 17)
        Me.rdbDate.TabIndex = 623
        Me.rdbDate.TabStop = True
        Me.rdbDate.Text = "วันที่ : "
        Me.rdbDate.UseVisualStyleBackColor = True
        '
        'dtpDateS
        '
        Me.dtpDateS.Enabled = False
        Me.dtpDateS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpDateS.Location = New System.Drawing.Point(103, 50)
        Me.dtpDateS.MinDate = New Date(1757, 1, 1, 0, 0, 0, 0)
        Me.dtpDateS.Name = "dtpDateS"
        Me.dtpDateS.Size = New System.Drawing.Size(131, 20)
        Me.dtpDateS.TabIndex = 625
        '
        'dtpYear
        '
        Me.dtpYear.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpYear.CausesValidation = False
        Me.dtpYear.CustomFormat = "yyyy"
        Me.dtpYear.Enabled = False
        Me.dtpYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpYear.Location = New System.Drawing.Point(295, 84)
        Me.dtpYear.Name = "dtpYear"
        Me.dtpYear.ShowUpDown = True
        Me.dtpYear.Size = New System.Drawing.Size(65, 20)
        Me.dtpYear.TabIndex = 622
        Me.dtpYear.Value = New Date(2014, 1, 29, 0, 0, 0, 0)
        '
        'dtpDateE
        '
        Me.dtpDateE.Enabled = False
        Me.dtpDateE.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpDateE.Location = New System.Drawing.Point(269, 50)
        Me.dtpDateE.MinDate = New Date(1757, 1, 1, 0, 0, 0, 0)
        Me.dtpDateE.Name = "dtpDateE"
        Me.dtpDateE.Size = New System.Drawing.Size(135, 20)
        Me.dtpDateE.TabIndex = 626
        '
        'dtpMonth
        '
        Me.dtpMonth.Checked = False
        Me.dtpMonth.CustomFormat = "MMMM /yyyy"
        Me.dtpMonth.Enabled = False
        Me.dtpMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpMonth.Location = New System.Drawing.Point(104, 85)
        Me.dtpMonth.Name = "dtpMonth"
        Me.dtpMonth.Size = New System.Drawing.Size(131, 20)
        Me.dtpMonth.TabIndex = 620
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(244, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(19, 13)
        Me.Label4.TabIndex = 627
        Me.Label4.Text = "ถึง"
        '
        'rdbYear
        '
        Me.rdbYear.AutoSize = True
        Me.rdbYear.Location = New System.Drawing.Point(248, 86)
        Me.rdbYear.Name = "rdbYear"
        Me.rdbYear.Size = New System.Drawing.Size(41, 17)
        Me.rdbYear.TabIndex = 5
        Me.rdbYear.Text = "ปี : "
        Me.rdbYear.UseVisualStyleBackColor = True
        '
        'rdbMonth
        '
        Me.rdbMonth.AutoSize = True
        Me.rdbMonth.Location = New System.Drawing.Point(35, 88)
        Me.rdbMonth.Name = "rdbMonth"
        Me.rdbMonth.Size = New System.Drawing.Size(60, 17)
        Me.rdbMonth.TabIndex = 4
        Me.rdbMonth.Text = "เดือน : "
        Me.rdbMonth.UseVisualStyleBackColor = True
        '
        'rbType3
        '
        Me.rbType3.AutoSize = True
        Me.rbType3.Checked = True
        Me.rbType3.Location = New System.Drawing.Point(33, 26)
        Me.rbType3.Name = "rbType3"
        Me.rbType3.Size = New System.Drawing.Size(58, 17)
        Me.rbType3.TabIndex = 5
        Me.rbType3.TabStop = True
        Me.rbType3.Text = "ทั้งหมด"
        Me.rbType3.UseVisualStyleBackColor = True
        '
        'rbType2
        '
        Me.rbType2.AutoSize = True
        Me.rbType2.Location = New System.Drawing.Point(330, 26)
        Me.rbType2.Name = "rbType2"
        Me.rbType2.Size = New System.Drawing.Size(72, 17)
        Me.rbType2.TabIndex = 4
        Me.rbType2.Text = "ไม่ถูกหลัก"
        Me.rbType2.UseVisualStyleBackColor = True
        '
        'rbType1
        '
        Me.rbType1.AutoSize = True
        Me.rbType1.Location = New System.Drawing.Point(188, 26)
        Me.rbType1.Name = "rbType1"
        Me.rbType1.Size = New System.Drawing.Size(59, 17)
        Me.rbType1.TabIndex = 3
        Me.rbType1.Text = "ถูกหลัก"
        Me.rbType1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.btnOK)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 415)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(494, 42)
        Me.Panel1.TabIndex = 623
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.Color.DimGray
        Me.btnOK.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOK.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnOK.ForeColor = System.Drawing.Color.White
        Me.btnOK.Image = CType(resources.GetObject("btnOK.Image"), System.Drawing.Image)
        Me.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOK.Location = New System.Drawing.Point(0, 0)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(115, 38)
        Me.btnOK.TabIndex = 581
        Me.btnOK.Tag = ""
        Me.btnOK.Text = "       แสดงข้อมูล"
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbType1)
        Me.GroupBox2.Controls.Add(Me.rbType3)
        Me.GroupBox2.Controls.Add(Me.rbType2)
        Me.GroupBox2.Location = New System.Drawing.Point(14, 294)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(468, 56)
        Me.GroupBox2.TabIndex = 624
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ประเภทบิล"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rdbCusNotSale)
        Me.GroupBox3.Controls.Add(Me.rdbPdPkNotSale)
        Me.GroupBox3.Controls.Add(Me.rdbSalePv)
        Me.GroupBox3.Controls.Add(Me.rbSale)
        Me.GroupBox3.Controls.Add(Me.rbPlant)
        Me.GroupBox3.Controls.Add(Me.rbPd)
        Me.GroupBox3.Controls.Add(Me.rbCus)
        Me.GroupBox3.Location = New System.Drawing.Point(14, 142)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(287, 146)
        Me.GroupBox3.TabIndex = 625
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "ประเภทรายงาน"
        '
        'rdbCusNotSale
        '
        Me.rdbCusNotSale.AutoSize = True
        Me.rdbCusNotSale.Location = New System.Drawing.Point(33, 117)
        Me.rdbCusNotSale.Name = "rdbCusNotSale"
        Me.rdbCusNotSale.Size = New System.Drawing.Size(151, 17)
        Me.rdbCusNotSale.TabIndex = 13
        Me.rdbCusNotSale.Text = "รายการลูกค้าที่ไม่มียอดขาย"
        Me.rdbCusNotSale.UseVisualStyleBackColor = True
        '
        'rdbPdPkNotSale
        '
        Me.rdbPdPkNotSale.AutoSize = True
        Me.rdbPdPkNotSale.Location = New System.Drawing.Point(33, 94)
        Me.rdbPdPkNotSale.Name = "rdbPdPkNotSale"
        Me.rdbPdPkNotSale.Size = New System.Drawing.Size(152, 17)
        Me.rdbPdPkNotSale.TabIndex = 12
        Me.rdbPdPkNotSale.Text = "รายการสินค้าที่ไม่มียอดขาย"
        Me.rdbPdPkNotSale.UseVisualStyleBackColor = True
        '
        'rdbSalePv
        '
        Me.rdbSalePv.AutoSize = True
        Me.rdbSalePv.Location = New System.Drawing.Point(33, 72)
        Me.rdbSalePv.Name = "rdbSalePv"
        Me.rdbSalePv.Size = New System.Drawing.Size(250, 17)
        Me.rdbSalePv.TabIndex = 11
        Me.rdbSalePv.Text = "ยอดขายรายพนักงานขายแยกตามภาคและจังหวัด"
        Me.rdbSalePv.UseVisualStyleBackColor = True
        '
        'rbSale
        '
        Me.rbSale.AutoSize = True
        Me.rbSale.Location = New System.Drawing.Point(33, 50)
        Me.rbSale.Name = "rbSale"
        Me.rbSale.Size = New System.Drawing.Size(140, 17)
        Me.rbSale.TabIndex = 10
        Me.rbSale.Text = "ยอดขายรายพนักงานขาย"
        Me.rbSale.UseVisualStyleBackColor = True
        '
        'rbPlant
        '
        Me.rbPlant.AutoSize = True
        Me.rbPlant.Location = New System.Drawing.Point(240, 123)
        Me.rbPlant.Name = "rbPlant"
        Me.rbPlant.Size = New System.Drawing.Size(40, 17)
        Me.rbPlant.TabIndex = 9
        Me.rbPlant.Text = "พืช"
        Me.rbPlant.UseVisualStyleBackColor = True
        Me.rbPlant.Visible = False
        '
        'rbPd
        '
        Me.rbPd.AutoSize = True
        Me.rbPd.Checked = True
        Me.rbPd.Location = New System.Drawing.Point(33, 28)
        Me.rbPd.Name = "rbPd"
        Me.rbPd.Size = New System.Drawing.Size(107, 17)
        Me.rbPd.TabIndex = 8
        Me.rbPd.TabStop = True
        Me.rbPd.Text = "ยอดขายรายสินค้า"
        Me.rbPd.UseVisualStyleBackColor = True
        '
        'rbCus
        '
        Me.rbCus.AutoSize = True
        Me.rbCus.Location = New System.Drawing.Point(230, 101)
        Me.rbCus.Name = "rbCus"
        Me.rbCus.Size = New System.Drawing.Size(50, 17)
        Me.rbCus.TabIndex = 7
        Me.rbCus.Text = "ลูกค้า"
        Me.rbCus.UseVisualStyleBackColor = True
        Me.rbCus.Visible = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.rdbMinMax)
        Me.GroupBox4.Controls.Add(Me.rdbMaxMin)
        Me.GroupBox4.Location = New System.Drawing.Point(14, 355)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(468, 51)
        Me.GroupBox4.TabIndex = 626
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "การจัดเรียงข้อมูล"
        '
        'rdbMinMax
        '
        Me.rdbMinMax.AutoSize = True
        Me.rdbMinMax.Location = New System.Drawing.Point(188, 19)
        Me.rdbMinMax.Name = "rdbMinMax"
        Me.rdbMinMax.Size = New System.Drawing.Size(92, 17)
        Me.rdbMinMax.TabIndex = 8
        Me.rdbMinMax.TabStop = True
        Me.rdbMinMax.Text = "จากน้อย - มาก"
        Me.rdbMinMax.UseVisualStyleBackColor = True
        '
        'rdbMaxMin
        '
        Me.rdbMaxMin.AutoSize = True
        Me.rdbMaxMin.Checked = True
        Me.rdbMaxMin.Location = New System.Drawing.Point(33, 19)
        Me.rdbMaxMin.Name = "rdbMaxMin"
        Me.rdbMaxMin.Size = New System.Drawing.Size(92, 17)
        Me.rdbMaxMin.TabIndex = 7
        Me.rdbMaxMin.TabStop = True
        Me.rdbMaxMin.Text = "จากมาก - น้อย"
        Me.rdbMaxMin.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.rdbGen)
        Me.GroupBox5.Controls.Add(Me.RadioButton3)
        Me.GroupBox5.Controls.Add(Me.rdbMat)
        Me.GroupBox5.Controls.Add(Me.rdbOther)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(308, 148)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(174, 140)
        Me.GroupBox5.TabIndex = 627
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "ระบุประเภทสินค้า"
        '
        'rdbGen
        '
        Me.rdbGen.AutoSize = True
        Me.rdbGen.Checked = True
        Me.rdbGen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rdbGen.Location = New System.Drawing.Point(27, 31)
        Me.rdbGen.Name = "rdbGen"
        Me.rdbGen.Size = New System.Drawing.Size(77, 17)
        Me.rdbGen.TabIndex = 618
        Me.rdbGen.TabStop = True
        Me.rdbGen.Text = "สินค้าทั่วไป"
        Me.rdbGen.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.RadioButton3.Location = New System.Drawing.Point(406, 95)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(120, 17)
        Me.RadioButton3.TabIndex = 618
        Me.RadioButton3.Text = "แยกตามรายการขาย"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'rdbMat
        '
        Me.rdbMat.AutoSize = True
        Me.rdbMat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rdbMat.Location = New System.Drawing.Point(27, 65)
        Me.rdbMat.Name = "rdbMat"
        Me.rdbMat.Size = New System.Drawing.Size(85, 17)
        Me.rdbMat.TabIndex = 612
        Me.rdbMat.Text = "สินค้าวัตถุดิบ"
        Me.rdbMat.UseVisualStyleBackColor = True
        '
        'rdbOther
        '
        Me.rdbOther.AutoSize = True
        Me.rdbOther.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rdbOther.Location = New System.Drawing.Point(27, 95)
        Me.rdbOther.Name = "rdbOther"
        Me.rdbOther.Size = New System.Drawing.Size(131, 17)
        Me.rdbOther.TabIndex = 613
        Me.rdbOther.Text = "สินค้าอื่นๆ (ไม่ใช่เมล็ด)"
        Me.rdbOther.UseVisualStyleBackColor = True
        '
        'frmSaleSummaryRpt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(494, 457)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmSaleSummaryRpt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "รายงานสรุปยอดขาย"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbType2 As System.Windows.Forms.RadioButton
    Friend WithEvents rbType1 As System.Windows.Forms.RadioButton
    Friend WithEvents rbType3 As System.Windows.Forms.RadioButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents rbCus As System.Windows.Forms.RadioButton
    Friend WithEvents rbSale As System.Windows.Forms.RadioButton
    Friend WithEvents rbPlant As System.Windows.Forms.RadioButton
    Friend WithEvents rbPd As System.Windows.Forms.RadioButton
    Friend WithEvents rdbYear As System.Windows.Forms.RadioButton
    Friend WithEvents rdbMonth As System.Windows.Forms.RadioButton
    Friend WithEvents dtpMonth As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpYear As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents rdbMinMax As System.Windows.Forms.RadioButton
    Friend WithEvents rdbMaxMin As System.Windows.Forms.RadioButton
    Friend WithEvents rdbDate As System.Windows.Forms.RadioButton
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents rdbDateB As System.Windows.Forms.RadioButton
    Friend WithEvents dtpDateS As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDateE As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents rdbSalePv As System.Windows.Forms.RadioButton
    Friend WithEvents rdbPdPkNotSale As System.Windows.Forms.RadioButton
    Friend WithEvents rdbCusNotSale As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents rdbGen As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents rdbMat As System.Windows.Forms.RadioButton
    Friend WithEvents rdbOther As System.Windows.Forms.RadioButton
End Class
