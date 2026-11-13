<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMkGiftCusRpt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMkGiftCusRpt))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cmbMY = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.rdbYear = New System.Windows.Forms.RadioButton
        Me.Label4 = New System.Windows.Forms.Label
        Me.rdbDate = New System.Windows.Forms.RadioButton
        Me.cmbYear = New System.Windows.Forms.ComboBox
        Me.cmbMonth = New System.Windows.Forms.ComboBox
        Me.rdbMonth = New System.Windows.Forms.RadioButton
        Me.dtpSaleE = New System.Windows.Forms.DateTimePicker
        Me.dtpSaleS = New System.Windows.Forms.DateTimePicker
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btnShow = New System.Windows.Forms.Button
        Me.txtTotalNet = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.rdbObject = New System.Windows.Forms.RadioButton
        Me.rdbCus = New System.Windows.Forms.RadioButton
        Me.rdbGift = New System.Windows.Forms.RadioButton
        Me.rdbSupp = New System.Windows.Forms.RadioButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rdbCusSelect = New System.Windows.Forms.RadioButton
        Me.rdbSupSelect = New System.Windows.Forms.RadioButton
        Me.rdbAll = New System.Windows.Forms.RadioButton
        Me.GroupBox2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmbMY)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.rdbYear)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.rdbDate)
        Me.GroupBox2.Controls.Add(Me.cmbYear)
        Me.GroupBox2.Controls.Add(Me.cmbMonth)
        Me.GroupBox2.Controls.Add(Me.rdbMonth)
        Me.GroupBox2.Controls.Add(Me.dtpSaleE)
        Me.GroupBox2.Controls.Add(Me.dtpSaleS)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 16)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(361, 138)
        Me.GroupBox2.TabIndex = 607
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "การแสดงข้อมูล"
        '
        'cmbMY
        '
        Me.cmbMY.Enabled = False
        Me.cmbMY.FormattingEnabled = True
        Me.cmbMY.Location = New System.Drawing.Point(241, 72)
        Me.cmbMY.Name = "cmbMY"
        Me.cmbMY.Size = New System.Drawing.Size(100, 21)
        Me.cmbMY.TabIndex = 607
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(225, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(14, 13)
        Me.Label3.TabIndex = 608
        Me.Label3.Text = "ปี"
        '
        'rdbYear
        '
        Me.rdbYear.AutoSize = True
        Me.rdbYear.Location = New System.Drawing.Point(49, 102)
        Me.rdbYear.Name = "rdbYear"
        Me.rdbYear.Size = New System.Drawing.Size(32, 17)
        Me.rdbYear.TabIndex = 606
        Me.rdbYear.Text = "ปี"
        Me.rdbYear.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(91, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(19, 13)
        Me.Label4.TabIndex = 605
        Me.Label4.Text = "ถึง"
        '
        'rdbDate
        '
        Me.rdbDate.AutoSize = True
        Me.rdbDate.Checked = True
        Me.rdbDate.Location = New System.Drawing.Point(49, 22)
        Me.rdbDate.Name = "rdbDate"
        Me.rdbDate.Size = New System.Drawing.Size(64, 17)
        Me.rdbDate.TabIndex = 603
        Me.rdbDate.TabStop = True
        Me.rdbDate.Text = "ช่วงวันที่"
        Me.rdbDate.UseVisualStyleBackColor = True
        '
        'cmbYear
        '
        Me.cmbYear.Enabled = False
        Me.cmbYear.FormattingEnabled = True
        Me.cmbYear.Location = New System.Drawing.Point(120, 100)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.Size = New System.Drawing.Size(104, 21)
        Me.cmbYear.TabIndex = 598
        '
        'cmbMonth
        '
        Me.cmbMonth.Enabled = False
        Me.cmbMonth.FormattingEnabled = True
        Me.cmbMonth.Location = New System.Drawing.Point(120, 72)
        Me.cmbMonth.Name = "cmbMonth"
        Me.cmbMonth.Size = New System.Drawing.Size(104, 21)
        Me.cmbMonth.TabIndex = 599
        '
        'rdbMonth
        '
        Me.rdbMonth.AutoSize = True
        Me.rdbMonth.Location = New System.Drawing.Point(49, 73)
        Me.rdbMonth.Name = "rdbMonth"
        Me.rdbMonth.Size = New System.Drawing.Size(51, 17)
        Me.rdbMonth.TabIndex = 604
        Me.rdbMonth.Text = "เดือน"
        Me.rdbMonth.UseVisualStyleBackColor = True
        '
        'dtpSaleE
        '
        Me.dtpSaleE.Location = New System.Drawing.Point(120, 46)
        Me.dtpSaleE.MinDate = New Date(1757, 1, 1, 0, 0, 0, 0)
        Me.dtpSaleE.Name = "dtpSaleE"
        Me.dtpSaleE.Size = New System.Drawing.Size(135, 20)
        Me.dtpSaleE.TabIndex = 602
        '
        'dtpSaleS
        '
        Me.dtpSaleS.Location = New System.Drawing.Point(120, 17)
        Me.dtpSaleS.MinDate = New Date(1757, 1, 1, 0, 0, 0, 0)
        Me.dtpSaleS.Name = "dtpSaleS"
        Me.dtpSaleS.Size = New System.Drawing.Size(135, 20)
        Me.dtpSaleS.TabIndex = 601
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnShow)
        Me.Panel2.Controls.Add(Me.txtTotalNet)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 368)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(384, 43)
        Me.Panel2.TabIndex = 619
        '
        'btnShow
        '
        Me.btnShow.BackColor = System.Drawing.Color.DimGray
        Me.btnShow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnShow.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnShow.ForeColor = System.Drawing.Color.White
        Me.btnShow.Image = CType(resources.GetObject("btnShow.Image"), System.Drawing.Image)
        Me.btnShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnShow.Location = New System.Drawing.Point(0, 0)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(115, 41)
        Me.btnShow.TabIndex = 580
        Me.btnShow.Tag = ""
        Me.btnShow.Text = "       แสดงข้อมูล"
        Me.btnShow.UseVisualStyleBackColor = False
        '
        'txtTotalNet
        '
        Me.txtTotalNet.BackColor = System.Drawing.Color.Black
        Me.txtTotalNet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalNet.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTotalNet.ForeColor = System.Drawing.Color.Lime
        Me.txtTotalNet.Location = New System.Drawing.Point(1107, 6)
        Me.txtTotalNet.Name = "txtTotalNet"
        Me.txtTotalNet.ReadOnly = True
        Me.txtTotalNet.Size = New System.Drawing.Size(158, 27)
        Me.txtTotalNet.TabIndex = 579
        Me.txtTotalNet.Text = "0"
        Me.txtTotalNet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(1027, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 17)
        Me.Label5.TabIndex = 142
        Me.Label5.Text = "รวมเป็นเงิน"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GroupBox1)
        Me.GroupBox3.Controls.Add(Me.rdbSupp)
        Me.GroupBox3.Controls.Add(Me.rdbObject)
        Me.GroupBox3.Controls.Add(Me.rdbCus)
        Me.GroupBox3.Controls.Add(Me.rdbGift)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(12, 160)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(361, 203)
        Me.GroupBox3.TabIndex = 620
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "การจัดกลุ่ม"
        '
        'rdbObject
        '
        Me.rdbObject.AutoSize = True
        Me.rdbObject.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rdbObject.Location = New System.Drawing.Point(173, 62)
        Me.rdbObject.Name = "rdbObject"
        Me.rdbObject.Size = New System.Drawing.Size(172, 17)
        Me.rdbObject.TabIndex = 617
        Me.rdbObject.Text = "จัดกลุ่มตามวัตถุประสงค์การแจก"
        Me.rdbObject.UseVisualStyleBackColor = True
        '
        'rdbCus
        '
        Me.rdbCus.AutoSize = True
        Me.rdbCus.Checked = True
        Me.rdbCus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rdbCus.Location = New System.Drawing.Point(33, 30)
        Me.rdbCus.Name = "rdbCus"
        Me.rdbCus.Size = New System.Drawing.Size(102, 17)
        Me.rdbCus.TabIndex = 615
        Me.rdbCus.Text = "จัดกลุ่มตามลูกค้า"
        Me.rdbCus.UseVisualStyleBackColor = True
        '
        'rdbGift
        '
        Me.rdbGift.AutoSize = True
        Me.rdbGift.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rdbGift.Location = New System.Drawing.Point(33, 62)
        Me.rdbGift.Name = "rdbGift"
        Me.rdbGift.Size = New System.Drawing.Size(105, 17)
        Me.rdbGift.TabIndex = 616
        Me.rdbGift.Text = "จัดกลุ่มตามสิ่งของ"
        Me.rdbGift.UseVisualStyleBackColor = True
        '
        'rdbSupp
        '
        Me.rdbSupp.AutoSize = True
        Me.rdbSupp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rdbSupp.Location = New System.Drawing.Point(174, 30)
        Me.rdbSupp.Name = "rdbSupp"
        Me.rdbSupp.Size = New System.Drawing.Size(118, 17)
        Me.rdbSupp.TabIndex = 618
        Me.rdbSupp.Text = "จัดกลุ่มตาม Supplier"
        Me.rdbSupp.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdbAll)
        Me.GroupBox1.Controls.Add(Me.rdbSupSelect)
        Me.GroupBox1.Controls.Add(Me.rdbCusSelect)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Location = New System.Drawing.Point(47, 85)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(294, 112)
        Me.GroupBox1.TabIndex = 621
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ประเภทข้อมูล"
        '
        'rdbCusSelect
        '
        Me.rdbCusSelect.AutoSize = True
        Me.rdbCusSelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rdbCusSelect.Location = New System.Drawing.Point(36, 55)
        Me.rdbCusSelect.Name = "rdbCusSelect"
        Me.rdbCusSelect.Size = New System.Drawing.Size(81, 17)
        Me.rdbCusSelect.TabIndex = 616
        Me.rdbCusSelect.Text = "เฉพาะลูกค้า"
        Me.rdbCusSelect.UseVisualStyleBackColor = True
        '
        'rdbSupSelect
        '
        Me.rdbSupSelect.AutoSize = True
        Me.rdbSupSelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rdbSupSelect.Location = New System.Drawing.Point(36, 84)
        Me.rdbSupSelect.Name = "rdbSupSelect"
        Me.rdbSupSelect.Size = New System.Drawing.Size(97, 17)
        Me.rdbSupSelect.TabIndex = 617
        Me.rdbSupSelect.Text = "เฉพาะ Supplier"
        Me.rdbSupSelect.UseVisualStyleBackColor = True
        '
        'rdbAll
        '
        Me.rdbAll.AutoSize = True
        Me.rdbAll.Checked = True
        Me.rdbAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rdbAll.Location = New System.Drawing.Point(36, 29)
        Me.rdbAll.Name = "rdbAll"
        Me.rdbAll.Size = New System.Drawing.Size(58, 17)
        Me.rdbAll.TabIndex = 618
        Me.rdbAll.Text = "ทั้งหมด"
        Me.rdbAll.UseVisualStyleBackColor = True
        '
        'frmMkGiftCusRpt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(384, 411)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox2)
        Me.MaximizeBox = False
        Me.Name = "frmMkGiftCusRpt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " รายงานการแจกสิ่งของ"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents rdbMonth As System.Windows.Forms.RadioButton
    Friend WithEvents cmbYear As System.Windows.Forms.ComboBox
    Friend WithEvents rdbDate As System.Windows.Forms.RadioButton
    Friend WithEvents cmbMonth As System.Windows.Forms.ComboBox
    Friend WithEvents dtpSaleE As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpSaleS As System.Windows.Forms.DateTimePicker
    Friend WithEvents rdbYear As System.Windows.Forms.RadioButton
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents txtTotalNet As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents rdbCus As System.Windows.Forms.RadioButton
    Friend WithEvents rdbGift As System.Windows.Forms.RadioButton
    Friend WithEvents cmbMY As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents rdbObject As System.Windows.Forms.RadioButton
    Friend WithEvents rdbSupp As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdbCusSelect As System.Windows.Forms.RadioButton
    Friend WithEvents rdbAll As System.Windows.Forms.RadioButton
    Friend WithEvents rdbSupSelect As System.Windows.Forms.RadioButton
End Class
