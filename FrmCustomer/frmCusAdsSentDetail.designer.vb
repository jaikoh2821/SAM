<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCusAdsSentDetail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCusAdsSentDetail))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CmbProvince = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CmbAp = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CmbTb = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.txtAddressAdd = New System.Windows.Forms.TextBox()
        Me.btnDel = New System.Windows.Forms.Panel()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.ChkSame = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCusName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblPsTs = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtNumS = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtMhooS = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtRoad = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtSoi = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtRoom = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtFloor = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtbuilding = New System.Windows.Forms.TextBox()
        Me.txtVillage = New System.Windows.Forms.TextBox()
        Me.rdbinThai = New System.Windows.Forms.RadioButton()
        Me.txtForeign = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rdbExp = New System.Windows.Forms.RadioButton()
        Me.btnCustomer = New System.Windows.Forms.Button()
        Me.btnDel.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "จังหวัด"
        '
        'CmbProvince
        '
        Me.CmbProvince.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CmbProvince.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbProvince.FormattingEnabled = True
        Me.CmbProvince.Location = New System.Drawing.Point(89, 135)
        Me.CmbProvince.Name = "CmbProvince"
        Me.CmbProvince.Size = New System.Drawing.Size(121, 21)
        Me.CmbProvince.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(223, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "อำเภอ/เขต"
        '
        'CmbAp
        '
        Me.CmbAp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CmbAp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbAp.FormattingEnabled = True
        Me.CmbAp.Location = New System.Drawing.Point(293, 131)
        Me.CmbAp.Name = "CmbAp"
        Me.CmbAp.Size = New System.Drawing.Size(121, 21)
        Me.CmbAp.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 169)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "ตำบล/แขวง"
        '
        'CmbTb
        '
        Me.CmbTb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CmbTb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbTb.FormattingEnabled = True
        Me.CmbTb.Location = New System.Drawing.Point(87, 166)
        Me.CmbTb.Name = "CmbTb"
        Me.CmbTb.Size = New System.Drawing.Size(121, 21)
        Me.CmbTb.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(214, 169)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "รหัสไปรษณีย์"
        '
        'txtCode
        '
        Me.txtCode.Enabled = False
        Me.txtCode.Location = New System.Drawing.Point(293, 162)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(121, 20)
        Me.txtCode.TabIndex = 9
        '
        'txtAddressAdd
        '
        Me.txtAddressAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtAddressAdd.ForeColor = System.Drawing.Color.Maroon
        Me.txtAddressAdd.Location = New System.Drawing.Point(5, 425)
        Me.txtAddressAdd.Multiline = True
        Me.txtAddressAdd.Name = "txtAddressAdd"
        Me.txtAddressAdd.ReadOnly = True
        Me.txtAddressAdd.Size = New System.Drawing.Size(442, 72)
        Me.txtAddressAdd.TabIndex = 10
        '
        'btnDel
        '
        Me.btnDel.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnDel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.btnDel.Controls.Add(Me.btnDelete)
        Me.btnDel.Controls.Add(Me.btnSave)
        Me.btnDel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnDel.Location = New System.Drawing.Point(0, 525)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(455, 37)
        Me.btnDel.TabIndex = 420
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.DimGray
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Image = Global.SAM.My.Resources.Resources.Del28
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.Location = New System.Drawing.Point(89, 0)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(89, 35)
        Me.btnDelete.TabIndex = 425
        Me.btnDelete.Tag = "Save"
        Me.btnDelete.Text = "       ยกเลิก"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.DimGray
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(0, 0)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(89, 35)
        Me.btnSave.TabIndex = 424
        Me.btnSave.Tag = "Save"
        Me.btnSave.Text = "       บันทึก"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'ChkSame
        '
        Me.ChkSame.AutoSize = True
        Me.ChkSame.Location = New System.Drawing.Point(104, 108)
        Me.ChkSame.Name = "ChkSame"
        Me.ChkSame.Size = New System.Drawing.Size(113, 17)
        Me.ChkSame.TabIndex = 421
        Me.ChkSame.Text = "เหมือนที่อยู่ปัจจุบัน"
        Me.ChkSame.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(54, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 13)
        Me.Label6.TabIndex = 422
        Me.Label6.Text = "ชื่อลูกค้า"
        '
        'txtCusName
        '
        Me.txtCusName.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.txtCusName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCusName.Location = New System.Drawing.Point(103, 19)
        Me.txtCusName.Name = "txtCusName"
        Me.txtCusName.ReadOnly = True
        Me.txtCusName.Size = New System.Drawing.Size(315, 21)
        Me.txtCusName.TabIndex = 423
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(38, 50)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 13)
        Me.Label7.TabIndex = 424
        Me.Label7.Text = "ที่อยู่ปัจจุบัน"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(103, 46)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.ReadOnly = True
        Me.txtAddress.Size = New System.Drawing.Size(315, 55)
        Me.txtAddress.TabIndex = 425
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 503)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 13)
        Me.Label8.TabIndex = 426
        Me.Label8.Text = "ผู้บันทึกล่าสุด:"
        '
        'lblPsTs
        '
        Me.lblPsTs.AutoSize = True
        Me.lblPsTs.Location = New System.Drawing.Point(78, 503)
        Me.lblPsTs.Name = "lblPsTs"
        Me.lblPsTs.Size = New System.Drawing.Size(10, 13)
        Me.lblPsTs.TabIndex = 427
        Me.lblPsTs.Text = "-"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(273, 503)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(84, 13)
        Me.Label10.TabIndex = 428
        Me.Label10.Text = "วันที่บันทึกล่าสุด:"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(355, 503)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(10, 13)
        Me.lblDate.TabIndex = 429
        Me.lblDate.Text = "-"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(47, 80)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(31, 13)
        Me.Label9.TabIndex = 430
        Me.Label9.Text = "เลขที่"
        '
        'txtNumS
        '
        Me.txtNumS.Location = New System.Drawing.Point(89, 76)
        Me.txtNumS.Name = "txtNumS"
        Me.txtNumS.Size = New System.Drawing.Size(50, 20)
        Me.txtNumS.TabIndex = 431
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(143, 79)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(21, 13)
        Me.Label11.TabIndex = 432
        Me.Label11.Text = "หมู่"
        '
        'txtMhooS
        '
        Me.txtMhooS.Location = New System.Drawing.Point(166, 76)
        Me.txtMhooS.Name = "txtMhooS"
        Me.txtMhooS.Size = New System.Drawing.Size(50, 20)
        Me.txtMhooS.TabIndex = 433
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.txtRoad)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txtSoi)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtRoom)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtFloor)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtbuilding)
        Me.GroupBox1.Controls.Add(Me.txtVillage)
        Me.GroupBox1.Controls.Add(Me.txtCode)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.CmbTb)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtMhooS)
        Me.GroupBox1.Controls.Add(Me.txtNumS)
        Me.GroupBox1.Controls.Add(Me.CmbAp)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.CmbProvince)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 221)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(442, 198)
        Me.GroupBox1.TabIndex = 434
        Me.GroupBox1.TabStop = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(36, 50)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(41, 13)
        Me.Label17.TabIndex = 451
        Me.Label17.Text = "หมู่บ้าน"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(39, 27)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(36, 13)
        Me.Label16.TabIndex = 450
        Me.Label16.Text = "อาคาร"
        '
        'txtRoad
        '
        Me.txtRoad.Location = New System.Drawing.Point(88, 104)
        Me.txtRoad.Name = "txtRoad"
        Me.txtRoad.Size = New System.Drawing.Size(210, 20)
        Me.txtRoad.TabIndex = 449
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(47, 104)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(30, 13)
        Me.Label14.TabIndex = 448
        Me.Label14.Text = "ถนน"
        '
        'txtSoi
        '
        Me.txtSoi.Location = New System.Drawing.Point(248, 77)
        Me.txtSoi.Name = "txtSoi"
        Me.txtSoi.Size = New System.Drawing.Size(50, 20)
        Me.txtSoi.TabIndex = 447
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(220, 79)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(27, 13)
        Me.Label13.TabIndex = 446
        Me.Label13.Text = "ซอย"
        '
        'txtRoom
        '
        Me.txtRoom.Location = New System.Drawing.Point(366, 24)
        Me.txtRoom.Name = "txtRoom"
        Me.txtRoom.Size = New System.Drawing.Size(50, 20)
        Me.txtRoom.TabIndex = 445
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(337, 27)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(25, 13)
        Me.Label12.TabIndex = 444
        Me.Label12.Text = "ห้อง"
        '
        'txtFloor
        '
        Me.txtFloor.Location = New System.Drawing.Point(281, 24)
        Me.txtFloor.Name = "txtFloor"
        Me.txtFloor.Size = New System.Drawing.Size(50, 20)
        Me.txtFloor.TabIndex = 443
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(253, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(22, 13)
        Me.Label1.TabIndex = 442
        Me.Label1.Text = "ชั้น"
        '
        'txtbuilding
        '
        Me.txtbuilding.Location = New System.Drawing.Point(89, 24)
        Me.txtbuilding.Name = "txtbuilding"
        Me.txtbuilding.Size = New System.Drawing.Size(158, 20)
        Me.txtbuilding.TabIndex = 441
        '
        'txtVillage
        '
        Me.txtVillage.Location = New System.Drawing.Point(88, 50)
        Me.txtVillage.Name = "txtVillage"
        Me.txtVillage.Size = New System.Drawing.Size(327, 20)
        Me.txtVillage.TabIndex = 439
        '
        'rdbinThai
        '
        Me.rdbinThai.AutoSize = True
        Me.rdbinThai.Checked = True
        Me.rdbinThai.Location = New System.Drawing.Point(5, 215)
        Me.rdbinThai.Name = "rdbinThai"
        Me.rdbinThai.Size = New System.Drawing.Size(138, 17)
        Me.rdbinThai.TabIndex = 438
        Me.rdbinThai.TabStop = True
        Me.rdbinThai.Text = "ที่อยู่จัดส่งของในประเทศ"
        Me.rdbinThai.UseVisualStyleBackColor = True
        '
        'txtForeign
        '
        Me.txtForeign.Enabled = False
        Me.txtForeign.Location = New System.Drawing.Point(77, 19)
        Me.txtForeign.Multiline = True
        Me.txtForeign.Name = "txtForeign"
        Me.txtForeign.Size = New System.Drawing.Size(343, 49)
        Me.txtForeign.TabIndex = 435
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(45, 21)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(27, 13)
        Me.Label15.TabIndex = 436
        Me.Label15.Text = "ที่อยู่"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtForeign)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Location = New System.Drawing.Point(5, 131)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(442, 77)
        Me.GroupBox2.TabIndex = 437
        Me.GroupBox2.TabStop = False
        '
        'rdbExp
        '
        Me.rdbExp.AutoSize = True
        Me.rdbExp.Location = New System.Drawing.Point(5, 127)
        Me.rdbExp.Name = "rdbExp"
        Me.rdbExp.Size = New System.Drawing.Size(100, 17)
        Me.rdbExp.TabIndex = 437
        Me.rdbExp.TabStop = True
        Me.rdbExp.Text = "ที่อยู่ต่างประเทศ"
        Me.rdbExp.UseVisualStyleBackColor = True
        '
        'btnCustomer
        '
        Me.btnCustomer.BackColor = System.Drawing.Color.DimGray
        Me.btnCustomer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.7!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnCustomer.ForeColor = System.Drawing.Color.White
        Me.btnCustomer.Image = CType(resources.GetObject("btnCustomer.Image"), System.Drawing.Image)
        Me.btnCustomer.Location = New System.Drawing.Point(420, 17)
        Me.btnCustomer.Name = "btnCustomer"
        Me.btnCustomer.Size = New System.Drawing.Size(28, 25)
        Me.btnCustomer.TabIndex = 439
        Me.btnCustomer.Tag = "Add"
        Me.btnCustomer.UseVisualStyleBackColor = False
        '
        'frmCusAdsSentDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(455, 562)
        Me.Controls.Add(Me.btnCustomer)
        Me.Controls.Add(Me.rdbinThai)
        Me.Controls.Add(Me.rdbExp)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblPsTs)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtCusName)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ChkSame)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.txtAddressAdd)
        Me.MinimizeBox = False
        Me.Name = "frmCusAdsSentDetail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "รายละเอียดที่อยู่จัดส่งของให้คู่ค้า"
        Me.btnDel.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CmbProvince As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CmbAp As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CmbTb As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents txtAddressAdd As System.Windows.Forms.TextBox
    Friend WithEvents btnDel As System.Windows.Forms.Panel
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents ChkSame As System.Windows.Forms.CheckBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCusName As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblPsTs As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtNumS As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtMhooS As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtForeign As System.Windows.Forms.TextBox
    Friend WithEvents txtVillage As System.Windows.Forms.TextBox
    Friend WithEvents txtFloor As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtbuilding As System.Windows.Forms.TextBox
    Friend WithEvents txtSoi As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtRoom As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtRoad As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents rdbinThai As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rdbExp As System.Windows.Forms.RadioButton
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnCustomer As System.Windows.Forms.Button
End Class
