<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmRptInvoice
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRptInvoice))
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.btnPrint = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rdbDESC = New System.Windows.Forms.RadioButton()
        Me.rdbASC = New System.Windows.Forms.RadioButton()
        Me.cmbOrderBy = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbGroupComp = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdbDateTs = New System.Windows.Forms.RadioButton()
        Me.rdbDateSale = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dtpMonthNow = New System.Windows.Forms.DateTimePicker()
        Me.dtpMonthE = New System.Windows.Forms.DateTimePicker()
        Me.dtpMonthS = New System.Windows.Forms.DateTimePicker()
        Me.rdbMonthNow = New System.Windows.Forms.RadioButton()
        Me.dtpSaleE = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpYear = New System.Windows.Forms.DateTimePicker()
        Me.rdbYear = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.rdbMonth = New System.Windows.Forms.RadioButton()
        Me.rdbDate = New System.Windows.Forms.RadioButton()
        Me.dtpSaleS = New System.Windows.Forms.DateTimePicker()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelControl2
        '
        Me.PanelControl2.Appearance.BackColor = System.Drawing.Color.LightSteelBlue
        Me.PanelControl2.Appearance.BackColor2 = System.Drawing.Color.CornflowerBlue
        Me.PanelControl2.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.PanelControl2.Appearance.Options.UseBackColor = True
        Me.PanelControl2.Appearance.Options.UseFont = True
        Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl2.Controls.Add(Me.btnPrint)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 374)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(465, 39)
        Me.PanelControl2.TabIndex = 724
        '
        'btnPrint
        '
        Me.btnPrint.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Appearance.Options.UseFont = True
        Me.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btnPrint.Location = New System.Drawing.Point(5, 2)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(102, 35)
        Me.btnPrint.TabIndex = 1
        Me.btnPrint.Text = "Print"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel2.Controls.Add(Me.GroupBox3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.cmbGroupComp)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Controls.Add(Me.GroupBox2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(465, 374)
        Me.Panel2.TabIndex = 725
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.rdbDESC)
        Me.GroupBox3.Controls.Add(Me.rdbASC)
        Me.GroupBox3.Controls.Add(Me.cmbOrderBy)
        Me.GroupBox3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(25, 260)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(410, 96)
        Me.GroupBox3.TabIndex = 608
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "เรียงลำดับตาม"
        '
        'rdbDESC
        '
        Me.rdbDESC.AutoSize = True
        Me.rdbDESC.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rdbDESC.Location = New System.Drawing.Point(169, 27)
        Me.rdbDESC.Name = "rdbDESC"
        Me.rdbDESC.Size = New System.Drawing.Size(100, 18)
        Me.rdbDESC.TabIndex = 967
        Me.rdbDESC.Text = "จากมากไปน้อย"
        Me.rdbDESC.UseVisualStyleBackColor = True
        '
        'rdbASC
        '
        Me.rdbASC.AutoSize = True
        Me.rdbASC.Checked = True
        Me.rdbASC.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rdbASC.Location = New System.Drawing.Point(42, 27)
        Me.rdbASC.Name = "rdbASC"
        Me.rdbASC.Size = New System.Drawing.Size(100, 18)
        Me.rdbASC.TabIndex = 651
        Me.rdbASC.TabStop = True
        Me.rdbASC.Text = "จากน้อยไปมาก"
        Me.rdbASC.UseVisualStyleBackColor = True
        '
        'cmbOrderBy
        '
        Me.cmbOrderBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOrderBy.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmbOrderBy.FormattingEnabled = True
        Me.cmbOrderBy.Items.AddRange(New Object() {"เลขที่อินวอยซ์", "วันที่ขายสินค้า", "พนักงานขาย", "ชื่อลูกค้า"})
        Me.cmbOrderBy.Location = New System.Drawing.Point(42, 55)
        Me.cmbOrderBy.Name = "cmbOrderBy"
        Me.cmbOrderBy.Size = New System.Drawing.Size(224, 22)
        Me.cmbOrderBy.TabIndex = 966
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 14)
        Me.Label2.TabIndex = 651
        Me.Label2.Text = "บริษัท"
        '
        'cmbGroupComp
        '
        Me.cmbGroupComp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGroupComp.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmbGroupComp.FormattingEnabled = True
        Me.cmbGroupComp.Location = New System.Drawing.Point(67, 12)
        Me.cmbGroupComp.Name = "cmbGroupComp"
        Me.cmbGroupComp.Size = New System.Drawing.Size(227, 22)
        Me.cmbGroupComp.TabIndex = 965
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.rdbDateTs)
        Me.GroupBox1.Controls.Add(Me.rdbDateSale)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(25, 54)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(410, 43)
        Me.GroupBox1.TabIndex = 607
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ประเภทข้อมูลวันที่"
        '
        'rdbDateTs
        '
        Me.rdbDateTs.AutoSize = True
        Me.rdbDateTs.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.rdbDateTs.Location = New System.Drawing.Point(168, 17)
        Me.rdbDateTs.Name = "rdbDateTs"
        Me.rdbDateTs.Size = New System.Drawing.Size(98, 18)
        Me.rdbDateTs.TabIndex = 601
        Me.rdbDateTs.Text = "วันที่ทำรายการ"
        Me.rdbDateTs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdbDateTs.UseVisualStyleBackColor = True
        '
        'rdbDateSale
        '
        Me.rdbDateSale.AutoSize = True
        Me.rdbDateSale.Checked = True
        Me.rdbDateSale.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.rdbDateSale.Location = New System.Drawing.Point(54, 18)
        Me.rdbDateSale.Name = "rdbDateSale"
        Me.rdbDateSale.Size = New System.Drawing.Size(67, 18)
        Me.rdbDateSale.TabIndex = 600
        Me.rdbDateSale.TabStop = True
        Me.rdbDateSale.Text = "วันที่ขาย"
        Me.rdbDateSale.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.dtpMonthNow)
        Me.GroupBox2.Controls.Add(Me.dtpMonthE)
        Me.GroupBox2.Controls.Add(Me.dtpMonthS)
        Me.GroupBox2.Controls.Add(Me.rdbMonthNow)
        Me.GroupBox2.Controls.Add(Me.dtpSaleE)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.dtpYear)
        Me.GroupBox2.Controls.Add(Me.rdbYear)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.rdbMonth)
        Me.GroupBox2.Controls.Add(Me.rdbDate)
        Me.GroupBox2.Controls.Add(Me.dtpSaleS)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(25, 107)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(410, 144)
        Me.GroupBox2.TabIndex = 608
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ช่วงวันที่"
        '
        'dtpMonthNow
        '
        Me.dtpMonthNow.Checked = False
        Me.dtpMonthNow.CustomFormat = "MMMM /yyyy"
        Me.dtpMonthNow.Enabled = False
        Me.dtpMonthNow.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dtpMonthNow.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpMonthNow.Location = New System.Drawing.Point(82, 77)
        Me.dtpMonthNow.Name = "dtpMonthNow"
        Me.dtpMonthNow.Size = New System.Drawing.Size(147, 22)
        Me.dtpMonthNow.TabIndex = 650
        '
        'dtpMonthE
        '
        Me.dtpMonthE.Checked = False
        Me.dtpMonthE.CustomFormat = "MMMM /yyyy"
        Me.dtpMonthE.Enabled = False
        Me.dtpMonthE.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dtpMonthE.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpMonthE.Location = New System.Drawing.Point(260, 49)
        Me.dtpMonthE.Name = "dtpMonthE"
        Me.dtpMonthE.Size = New System.Drawing.Size(144, 22)
        Me.dtpMonthE.TabIndex = 649
        '
        'dtpMonthS
        '
        Me.dtpMonthS.Checked = False
        Me.dtpMonthS.CustomFormat = "MMMM /yyyy"
        Me.dtpMonthS.Enabled = False
        Me.dtpMonthS.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dtpMonthS.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpMonthS.Location = New System.Drawing.Point(82, 48)
        Me.dtpMonthS.Name = "dtpMonthS"
        Me.dtpMonthS.Size = New System.Drawing.Size(147, 22)
        Me.dtpMonthS.TabIndex = 648
        '
        'rdbMonthNow
        '
        Me.rdbMonthNow.AutoSize = True
        Me.rdbMonthNow.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.rdbMonthNow.Location = New System.Drawing.Point(12, 80)
        Me.rdbMonthNow.Name = "rdbMonthNow"
        Me.rdbMonthNow.Size = New System.Drawing.Size(50, 18)
        Me.rdbMonthNow.TabIndex = 628
        Me.rdbMonthNow.Text = "เดือน"
        Me.rdbMonthNow.UseVisualStyleBackColor = True
        '
        'dtpSaleE
        '
        Me.dtpSaleE.CustomFormat = "ddMMMMyyyy"
        Me.dtpSaleE.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dtpSaleE.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpSaleE.Location = New System.Drawing.Point(260, 20)
        Me.dtpSaleE.MinDate = New Date(1757, 1, 1, 0, 0, 0, 0)
        Me.dtpSaleE.Name = "dtpSaleE"
        Me.dtpSaleE.Size = New System.Drawing.Size(144, 22)
        Me.dtpSaleE.TabIndex = 607
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(235, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 14)
        Me.Label1.TabIndex = 624
        Me.Label1.Text = "ถึง"
        '
        'dtpYear
        '
        Me.dtpYear.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpYear.CausesValidation = False
        Me.dtpYear.CustomFormat = "yyyy"
        Me.dtpYear.Enabled = False
        Me.dtpYear.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dtpYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpYear.Location = New System.Drawing.Point(82, 105)
        Me.dtpYear.Name = "dtpYear"
        Me.dtpYear.ShowUpDown = True
        Me.dtpYear.Size = New System.Drawing.Size(65, 22)
        Me.dtpYear.TabIndex = 621
        Me.dtpYear.Value = New Date(2015, 1, 19, 15, 28, 51, 0)
        '
        'rdbYear
        '
        Me.rdbYear.AutoSize = True
        Me.rdbYear.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.rdbYear.Location = New System.Drawing.Point(12, 109)
        Me.rdbYear.Name = "rdbYear"
        Me.rdbYear.Size = New System.Drawing.Size(33, 18)
        Me.rdbYear.TabIndex = 606
        Me.rdbYear.Text = "ปี"
        Me.rdbYear.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label4.Location = New System.Drawing.Point(235, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(20, 14)
        Me.Label4.TabIndex = 605
        Me.Label4.Text = "ถึง"
        '
        'rdbMonth
        '
        Me.rdbMonth.AutoSize = True
        Me.rdbMonth.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.rdbMonth.Location = New System.Drawing.Point(12, 52)
        Me.rdbMonth.Name = "rdbMonth"
        Me.rdbMonth.Size = New System.Drawing.Size(70, 18)
        Me.rdbMonth.TabIndex = 604
        Me.rdbMonth.Text = "ช่วงเดือน"
        Me.rdbMonth.UseVisualStyleBackColor = True
        '
        'rdbDate
        '
        Me.rdbDate.AutoSize = True
        Me.rdbDate.Checked = True
        Me.rdbDate.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rdbDate.Location = New System.Drawing.Point(12, 25)
        Me.rdbDate.Name = "rdbDate"
        Me.rdbDate.Size = New System.Drawing.Size(47, 18)
        Me.rdbDate.TabIndex = 603
        Me.rdbDate.TabStop = True
        Me.rdbDate.Text = "วันที่"
        Me.rdbDate.UseVisualStyleBackColor = True
        '
        'dtpSaleS
        '
        Me.dtpSaleS.CustomFormat = "ddMMMMyyyy"
        Me.dtpSaleS.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dtpSaleS.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpSaleS.Location = New System.Drawing.Point(82, 20)
        Me.dtpSaleS.MinDate = New Date(1757, 1, 1, 0, 0, 0, 0)
        Me.dtpSaleS.Name = "dtpSaleS"
        Me.dtpSaleS.Size = New System.Drawing.Size(147, 22)
        Me.dtpSaleS.TabIndex = 601
        '
        'FrmRptInvoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(465, 413)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PanelControl2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmRptInvoice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "รายงานทะเบียนใบกำกับภาษี"
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnPrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdbDateTs As RadioButton
    Friend WithEvents rdbDateSale As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dtpMonthNow As DateTimePicker
    Friend WithEvents dtpMonthE As DateTimePicker
    Friend WithEvents dtpMonthS As DateTimePicker
    Friend WithEvents rdbMonthNow As RadioButton
    Friend WithEvents dtpSaleE As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpYear As DateTimePicker
    Friend WithEvents rdbYear As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents rdbMonth As RadioButton
    Friend WithEvents rdbDate As RadioButton
    Friend WithEvents dtpSaleS As DateTimePicker
    Friend WithEvents cmbGroupComp As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cmbOrderBy As ComboBox
    Friend WithEvents rdbDESC As RadioButton
    Friend WithEvents rdbASC As RadioButton
End Class
