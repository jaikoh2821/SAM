<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTspDetail
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
        Me.comboPv = New System.Windows.Forms.ComboBox
        Me.txtTspAddress = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.comboTb = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.comboAp = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.ComboTsp = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtImportance = New System.Windows.Forms.TextBox
        Me.txtTsptel = New System.Windows.Forms.MaskedTextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtTspArea = New System.Windows.Forms.TextBox
        Me.txtTspShort = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtTspNote = New System.Windows.Forms.TextBox
        Me.txtTspName = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.btn_Delete = New System.Windows.Forms.Button
        Me.btn_save = New System.Windows.Forms.Button
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'comboPv
        '
        Me.comboPv.FormattingEnabled = True
        Me.comboPv.Location = New System.Drawing.Point(73, 22)
        Me.comboPv.Name = "comboPv"
        Me.comboPv.Size = New System.Drawing.Size(179, 21)
        Me.comboPv.TabIndex = 0
        '
        'txtTspAddress
        '
        Me.txtTspAddress.Location = New System.Drawing.Point(82, 22)
        Me.txtTspAddress.Multiline = True
        Me.txtTspAddress.Name = "txtTspAddress"
        Me.txtTspAddress.Size = New System.Drawing.Size(230, 45)
        Me.txtTspAddress.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(34, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "ที่อยู่  :"
        '
        'comboTb
        '
        Me.comboTb.FormattingEnabled = True
        Me.comboTb.Location = New System.Drawing.Point(73, 77)
        Me.comboTb.Name = "comboTb"
        Me.comboTb.Size = New System.Drawing.Size(179, 21)
        Me.comboTb.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(24, 81)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "ตำบล  :"
        '
        'comboAp
        '
        Me.comboAp.FormattingEnabled = True
        Me.comboAp.Location = New System.Drawing.Point(73, 49)
        Me.comboAp.Name = "comboAp"
        Me.comboAp.Size = New System.Drawing.Size(179, 21)
        Me.comboAp.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 53)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "อำเภอ  :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "จังหวัด  :"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.ComboTsp)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.txtImportance)
        Me.GroupBox3.Controls.Add(Me.txtTsptel)
        Me.GroupBox3.Controls.Add(Me.GroupBox2)
        Me.GroupBox3.Controls.Add(Me.txtTspArea)
        Me.GroupBox3.Controls.Add(Me.txtTspShort)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.txtTspNote)
        Me.GroupBox3.Controls.Add(Me.txtTspName)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Location = New System.Drawing.Point(2, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(651, 372)
        Me.GroupBox3.TabIndex = 16
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "จัดการรายละเอียดการขนส่ง"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(24, 90)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(118, 13)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "เลือกรูปแบบการขนส่ง  :"
        '
        'ComboTsp
        '
        Me.ComboTsp.FormattingEnabled = True
        Me.ComboTsp.Location = New System.Drawing.Point(151, 87)
        Me.ComboTsp.Name = "ComboTsp"
        Me.ComboTsp.Size = New System.Drawing.Size(180, 21)
        Me.ComboTsp.TabIndex = 22
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(340, 63)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(136, 13)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "ลำดับความสำคัญการขนส่ง  :"
        '
        'txtImportance
        '
        Me.txtImportance.Location = New System.Drawing.Point(484, 60)
        Me.txtImportance.MaxLength = 1
        Me.txtImportance.Name = "txtImportance"
        Me.txtImportance.Size = New System.Drawing.Size(62, 20)
        Me.txtImportance.TabIndex = 20
        Me.txtImportance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTsptel
        '
        Me.txtTsptel.Location = New System.Drawing.Point(116, 60)
        Me.txtTsptel.Mask = "#############/#############"
        Me.txtTsptel.Name = "txtTsptel"
        Me.txtTsptel.Size = New System.Drawing.Size(172, 20)
        Me.txtTsptel.TabIndex = 19
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtTspAddress)
        Me.GroupBox2.Location = New System.Drawing.Point(20, 110)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(611, 138)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ที่อยู่"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.comboTb)
        Me.GroupBox1.Controls.Add(Me.comboPv)
        Me.GroupBox1.Controls.Add(Me.comboAp)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(329, 17)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(272, 112)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "เลือกพื้นที่"
        '
        'txtTspArea
        '
        Me.txtTspArea.Location = New System.Drawing.Point(107, 270)
        Me.txtTspArea.Multiline = True
        Me.txtTspArea.Name = "txtTspArea"
        Me.txtTspArea.Size = New System.Drawing.Size(224, 89)
        Me.txtTspArea.TabIndex = 15
        '
        'txtTspShort
        '
        Me.txtTspShort.Location = New System.Drawing.Point(484, 32)
        Me.txtTspShort.Name = "txtTspShort"
        Me.txtTspShort.Size = New System.Drawing.Size(115, 20)
        Me.txtTspShort.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(18, 273)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(83, 13)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "พื้นที่ให้บริการ  :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "ชื่อการขนส่ง  :"
        '
        'txtTspNote
        '
        Me.txtTspNote.Location = New System.Drawing.Point(408, 268)
        Me.txtTspNote.Multiline = True
        Me.txtTspNote.Name = "txtTspNote"
        Me.txtTspNote.Size = New System.Drawing.Size(223, 91)
        Me.txtTspNote.TabIndex = 13
        '
        'txtTspName
        '
        Me.txtTspName.Location = New System.Drawing.Point(116, 32)
        Me.txtTspName.Name = "txtTspName"
        Me.txtTspName.Size = New System.Drawing.Size(215, 20)
        Me.txtTspName.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(338, 272)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "หมายเหตุ  :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(390, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "ชื่อย่อการขนส่ง  :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "เบอร์โทรศัพท์  :"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel3.Controls.Add(Me.btn_Delete)
        Me.Panel3.Controls.Add(Me.btn_save)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 385)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(655, 41)
        Me.Panel3.TabIndex = 622
        '
        'btn_Delete
        '
        Me.btn_Delete.AutoSize = True
        Me.btn_Delete.BackColor = System.Drawing.Color.DimGray
        Me.btn_Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_Delete.ForeColor = System.Drawing.Color.White
        Me.btn_Delete.Image = Global.SAM.My.Resources.Resources.Del28
        Me.btn_Delete.Location = New System.Drawing.Point(81, 2)
        Me.btn_Delete.Name = "btn_Delete"
        Me.btn_Delete.Size = New System.Drawing.Size(89, 38)
        Me.btn_Delete.TabIndex = 623
        Me.btn_Delete.Text = "ลบข้อมูล"
        Me.btn_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Delete.UseVisualStyleBackColor = False
        Me.btn_Delete.Visible = False
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.Color.DimGray
        Me.btn_save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_save.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_save.ForeColor = System.Drawing.Color.White
        Me.btn_save.Image = Global.SAM.My.Resources.Resources.Save28
        Me.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_save.Location = New System.Drawing.Point(1, 2)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(81, 38)
        Me.btn_save.TabIndex = 415
        Me.btn_save.Tag = ""
        Me.btn_save.Text = "บันทึก"
        Me.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'frmTspDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(655, 426)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Panel3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTspDetail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "รายละเอียดการขนส่ง"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents comboPv As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTspName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTspShort As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTspAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents comboAp As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents comboTb As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtTspNote As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtTspArea As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents btn_Delete As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtTsptel As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtImportance As System.Windows.Forms.TextBox
    Friend WithEvents ComboTsp As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
End Class
