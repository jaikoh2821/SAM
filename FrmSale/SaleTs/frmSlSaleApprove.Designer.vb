<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSlSaleApprove
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
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.rdbSendDoc = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.rdbNoAppr = New System.Windows.Forms.RadioButton()
        Me.rdbAppr = New System.Windows.Forms.RadioButton()
        Me.txtDateApprove = New System.Windows.Forms.TextBox()
        Me.txtPsApprove = New System.Windows.Forms.TextBox()
        Me.btnApprove = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtDateAccept = New System.Windows.Forms.TextBox()
        Me.txtPsAccept = New System.Windows.Forms.TextBox()
        Me.btnAccept = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtDateCheck = New System.Windows.Forms.TextBox()
        Me.txtPsCheck = New System.Windows.Forms.TextBox()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnNoVATpaper = New System.Windows.Forms.Button()
        Me.rdbBillVat = New System.Windows.Forms.RadioButton()
        Me.rdbBillNoVat = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdbBorrow = New System.Windows.Forms.RadioButton()
        Me.rdbReady = New System.Windows.Forms.RadioButton()
        Me.rdbPreview = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.GroupBox2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 77)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.ShowExportButton = False
        Me.CrystalReportViewer1.ShowGroupTreeButton = False
        Me.CrystalReportViewer1.ShowPrintButton = False
        Me.CrystalReportViewer1.ShowRefreshButton = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1062, 485)
        Me.CrystalReportViewer1.TabIndex = 1
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'rdbSendDoc
        '
        Me.rdbSendDoc.AutoSize = True
        Me.rdbSendDoc.Location = New System.Drawing.Point(403, 31)
        Me.rdbSendDoc.Name = "rdbSendDoc"
        Me.rdbSendDoc.Size = New System.Drawing.Size(66, 17)
        Me.rdbSendDoc.TabIndex = 4
        Me.rdbSendDoc.Text = "ใบส่งของ"
        Me.rdbSendDoc.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Panel3)
        Me.GroupBox2.Controls.Add(Me.Panel1)
        Me.GroupBox2.Controls.Add(Me.Panel2)
        Me.GroupBox2.Location = New System.Drawing.Point(922, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(453, 63)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "กระบวนการทำงาน"
        Me.GroupBox2.Visible = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.rdbNoAppr)
        Me.Panel3.Controls.Add(Me.rdbAppr)
        Me.Panel3.Controls.Add(Me.txtDateApprove)
        Me.Panel3.Controls.Add(Me.txtPsApprove)
        Me.Panel3.Controls.Add(Me.btnApprove)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Location = New System.Drawing.Point(444, 19)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(205, 114)
        Me.Panel3.TabIndex = 6
        '
        'rdbNoAppr
        '
        Me.rdbNoAppr.AutoSize = True
        Me.rdbNoAppr.Location = New System.Drawing.Point(138, 58)
        Me.rdbNoAppr.Name = "rdbNoAppr"
        Me.rdbNoAppr.Size = New System.Drawing.Size(66, 17)
        Me.rdbNoAppr.TabIndex = 6
        Me.rdbNoAppr.TabStop = True
        Me.rdbNoAppr.Text = "ไม่อนุมัติ"
        Me.rdbNoAppr.UseVisualStyleBackColor = True
        Me.rdbNoAppr.Visible = False
        '
        'rdbAppr
        '
        Me.rdbAppr.AutoSize = True
        Me.rdbAppr.Location = New System.Drawing.Point(79, 58)
        Me.rdbAppr.Name = "rdbAppr"
        Me.rdbAppr.Size = New System.Drawing.Size(53, 17)
        Me.rdbAppr.TabIndex = 5
        Me.rdbAppr.TabStop = True
        Me.rdbAppr.Text = "อนุมัติ"
        Me.rdbAppr.UseVisualStyleBackColor = True
        Me.rdbAppr.Visible = False
        '
        'txtDateApprove
        '
        Me.txtDateApprove.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtDateApprove.Location = New System.Drawing.Point(74, 32)
        Me.txtDateApprove.Name = "txtDateApprove"
        Me.txtDateApprove.ReadOnly = True
        Me.txtDateApprove.Size = New System.Drawing.Size(123, 20)
        Me.txtDateApprove.TabIndex = 5
        '
        'txtPsApprove
        '
        Me.txtPsApprove.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtPsApprove.Location = New System.Drawing.Point(74, 7)
        Me.txtPsApprove.Name = "txtPsApprove"
        Me.txtPsApprove.ReadOnly = True
        Me.txtPsApprove.Size = New System.Drawing.Size(123, 20)
        Me.txtPsApprove.TabIndex = 4
        '
        'btnApprove
        '
        Me.btnApprove.Location = New System.Drawing.Point(74, 81)
        Me.btnApprove.Name = "btnApprove"
        Me.btnApprove.Size = New System.Drawing.Size(75, 23)
        Me.btnApprove.TabIndex = 4
        Me.btnApprove.Text = "บันทึก"
        Me.btnApprove.UseVisualStyleBackColor = True
        Me.btnApprove.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "วันที่อนุมัติ:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(28, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "ผู้อนุมัติ:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtDateAccept)
        Me.Panel1.Controls.Add(Me.txtPsAccept)
        Me.Panel1.Controls.Add(Me.btnAccept)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(16, 19)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(205, 114)
        Me.Panel1.TabIndex = 4
        '
        'txtDateAccept
        '
        Me.txtDateAccept.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtDateAccept.Location = New System.Drawing.Point(73, 32)
        Me.txtDateAccept.Name = "txtDateAccept"
        Me.txtDateAccept.ReadOnly = True
        Me.txtDateAccept.Size = New System.Drawing.Size(123, 20)
        Me.txtDateAccept.TabIndex = 5
        '
        'txtPsAccept
        '
        Me.txtPsAccept.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtPsAccept.Location = New System.Drawing.Point(74, 6)
        Me.txtPsAccept.Name = "txtPsAccept"
        Me.txtPsAccept.ReadOnly = True
        Me.txtPsAccept.Size = New System.Drawing.Size(122, 20)
        Me.txtPsAccept.TabIndex = 4
        '
        'btnAccept
        '
        Me.btnAccept.Location = New System.Drawing.Point(73, 58)
        Me.btnAccept.Name = "btnAccept"
        Me.btnAccept.Size = New System.Drawing.Size(75, 23)
        Me.btnAccept.TabIndex = 4
        Me.btnAccept.Text = "รับทราบ"
        Me.btnAccept.UseVisualStyleBackColor = True
        Me.btnAccept.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "วันที่รับทราบ:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "ผู้รับทราบ:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.txtDateCheck)
        Me.Panel2.Controls.Add(Me.txtPsCheck)
        Me.Panel2.Controls.Add(Me.btnCheck)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Location = New System.Drawing.Point(231, 19)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(205, 114)
        Me.Panel2.TabIndex = 5
        '
        'txtDateCheck
        '
        Me.txtDateCheck.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtDateCheck.Location = New System.Drawing.Point(77, 32)
        Me.txtDateCheck.Name = "txtDateCheck"
        Me.txtDateCheck.ReadOnly = True
        Me.txtDateCheck.Size = New System.Drawing.Size(123, 20)
        Me.txtDateCheck.TabIndex = 5
        '
        'txtPsCheck
        '
        Me.txtPsCheck.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtPsCheck.Location = New System.Drawing.Point(76, 7)
        Me.txtPsCheck.Name = "txtPsCheck"
        Me.txtPsCheck.ReadOnly = True
        Me.txtPsCheck.Size = New System.Drawing.Size(123, 20)
        Me.txtPsCheck.TabIndex = 4
        '
        'btnCheck
        '
        Me.btnCheck.Location = New System.Drawing.Point(76, 58)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(75, 23)
        Me.btnCheck.TabIndex = 4
        Me.btnCheck.Text = "ตรวจสอบ"
        Me.btnCheck.UseVisualStyleBackColor = True
        Me.btnCheck.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "วันที่ตรวจสอบ:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "ผู้ตรวจสอบ:"
        '
        'btnNoVATpaper
        '
        Me.btnNoVATpaper.BackColor = System.Drawing.Color.PaleGreen
        Me.btnNoVATpaper.Enabled = False
        Me.btnNoVATpaper.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnNoVATpaper.ForeColor = System.Drawing.Color.RoyalBlue
        Me.btnNoVATpaper.Image = Global.SAM.My.Resources.Resources.Printers
        Me.btnNoVATpaper.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNoVATpaper.Location = New System.Drawing.Point(6, 2)
        Me.btnNoVATpaper.Name = "btnNoVATpaper"
        Me.btnNoVATpaper.Size = New System.Drawing.Size(248, 38)
        Me.btnNoVATpaper.TabIndex = 5
        Me.btnNoVATpaper.Text = "   ใบเสร็จแบบกระดาษต่อเนื่อง"
        Me.btnNoVATpaper.UseVisualStyleBackColor = False
        '
        'rdbBillVat
        '
        Me.rdbBillVat.AutoSize = True
        Me.rdbBillVat.Location = New System.Drawing.Point(27, 31)
        Me.rdbBillVat.Name = "rdbBillVat"
        Me.rdbBillVat.Size = New System.Drawing.Size(127, 17)
        Me.rdbBillVat.TabIndex = 0
        Me.rdbBillVat.Text = "ใบเสร็จแบบถอด VAT"
        Me.rdbBillVat.UseVisualStyleBackColor = True
        '
        'rdbBillNoVat
        '
        Me.rdbBillNoVat.AutoSize = True
        Me.rdbBillNoVat.Location = New System.Drawing.Point(178, 31)
        Me.rdbBillNoVat.Name = "rdbBillNoVat"
        Me.rdbBillNoVat.Size = New System.Drawing.Size(139, 17)
        Me.rdbBillNoVat.TabIndex = 3
        Me.rdbBillNoVat.Text = "ใบเสร็จแบบไม่รวม VAT"
        Me.rdbBillNoVat.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdbBorrow)
        Me.GroupBox1.Controls.Add(Me.rdbSendDoc)
        Me.GroupBox1.Controls.Add(Me.rdbBillNoVat)
        Me.GroupBox1.Controls.Add(Me.rdbBillVat)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(619, 66)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "รูปแบบเอกสาร"
        '
        'rdbBorrow
        '
        Me.rdbBorrow.AutoSize = True
        Me.rdbBorrow.Location = New System.Drawing.Point(334, 31)
        Me.rdbBorrow.Name = "rdbBorrow"
        Me.rdbBorrow.Size = New System.Drawing.Size(52, 17)
        Me.rdbBorrow.TabIndex = 5
        Me.rdbBorrow.Text = "ใบยืม"
        Me.rdbBorrow.UseVisualStyleBackColor = True
        '
        'rdbReady
        '
        Me.rdbReady.AutoSize = True
        Me.rdbReady.Checked = True
        Me.rdbReady.Location = New System.Drawing.Point(32, 44)
        Me.rdbReady.Name = "rdbReady"
        Me.rdbReady.Size = New System.Drawing.Size(70, 17)
        Me.rdbReady.TabIndex = 6
        Me.rdbReady.TabStop = True
        Me.rdbReady.Text = "พิมพ์ทันที"
        Me.rdbReady.UseVisualStyleBackColor = True
        '
        'rdbPreview
        '
        Me.rdbPreview.AutoSize = True
        Me.rdbPreview.Location = New System.Drawing.Point(123, 44)
        Me.rdbPreview.Name = "rdbPreview"
        Me.rdbPreview.Size = New System.Drawing.Size(131, 17)
        Me.rdbPreview.TabIndex = 7
        Me.rdbPreview.Text = "แสดงตัวอย่างก่อนพิมพ์"
        Me.rdbPreview.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rdbReady)
        Me.GroupBox3.Controls.Add(Me.btnNoVATpaper)
        Me.GroupBox3.Controls.Add(Me.rdbPreview)
        Me.GroupBox3.Enabled = False
        Me.GroupBox3.Location = New System.Drawing.Point(648, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(268, 67)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.GroupBox1)
        Me.Panel4.Controls.Add(Me.GroupBox2)
        Me.Panel4.Controls.Add(Me.GroupBox3)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1062, 77)
        Me.Panel4.TabIndex = 9
        '
        'frmSlSaleApprove
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(1062, 562)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.Panel4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmSlSaleApprove"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " รับทราบ ตรวจสอบ อนุมัติ บิลขายสินค้า"
        Me.GroupBox2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents rdbSendDoc As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtPsAccept As System.Windows.Forms.TextBox
    Friend WithEvents btnAccept As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtDateCheck As System.Windows.Forms.TextBox
    Friend WithEvents txtPsCheck As System.Windows.Forms.TextBox
    Friend WithEvents btnCheck As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDateAccept As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents rdbNoAppr As System.Windows.Forms.RadioButton
    Friend WithEvents rdbAppr As System.Windows.Forms.RadioButton
    Friend WithEvents txtDateApprove As System.Windows.Forms.TextBox
    Friend WithEvents txtPsApprove As System.Windows.Forms.TextBox
    Friend WithEvents btnApprove As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents rdbBillVat As System.Windows.Forms.RadioButton
    Friend WithEvents rdbBillNoVat As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnNoVATpaper As System.Windows.Forms.Button
    Friend WithEvents rdbReady As System.Windows.Forms.RadioButton
    Friend WithEvents rdbPreview As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents rdbBorrow As System.Windows.Forms.RadioButton
End Class
