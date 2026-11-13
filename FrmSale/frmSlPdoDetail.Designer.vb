<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSlPdoDetail
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
        Me.txtProductNamePt = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.PnOther = New System.Windows.Forms.Panel
        Me.cbChkPerbox = New System.Windows.Forms.CheckBox
        Me.txtPricePerboxOt = New System.Windows.Forms.TextBox
        Me.lbUnit = New System.Windows.Forms.Label
        Me.txtProductTitleOt = New System.Windows.Forms.TextBox
        Me.lbPricePerbox = New System.Windows.Forms.Label
        Me.txtUnit = New System.Windows.Forms.TextBox
        Me.txtVolumnOt = New System.Windows.Forms.TextBox
        Me.txtPerboxOt = New System.Windows.Forms.TextBox
        Me.cmb_VolumnUnit = New System.Windows.Forms.ComboBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.lbPerbox = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.lbPriceBill = New System.Windows.Forms.Label
        Me.txtPriceBillOt = New System.Windows.Forms.TextBox
        Me.txtProductNameOt = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.PnPlasticPrice = New System.Windows.Forms.Panel
        Me.txtProductTitlePt = New System.Windows.Forms.TextBox
        Me.txtCreditPt60 = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.txtCreditPt30 = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtCashPt = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.lbSize = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtWidthPt = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtThicknessPt = New System.Windows.Forms.TextBox
        Me.txtWeightPt = New System.Windows.Forms.TextBox
        Me.txtLongPt = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtPhasePt = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtGradePt = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtLookPt = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.PnNote = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtNote = New System.Windows.Forms.RichTextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmb_ProductType = New System.Windows.Forms.ComboBox
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.btnDel = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.cmb_Unit = New System.Windows.Forms.ComboBox
        Me.GroupBox1.SuspendLayout()
        Me.PnOther.SuspendLayout()
        Me.PnPlasticPrice.SuspendLayout()
        Me.PnNote.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtProductNamePt
        '
        Me.txtProductNamePt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtProductNamePt.Location = New System.Drawing.Point(116, 33)
        Me.txtProductNamePt.Name = "txtProductNamePt"
        Me.txtProductNamePt.Size = New System.Drawing.Size(498, 24)
        Me.txtProductNamePt.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PnOther)
        Me.GroupBox1.Controls.Add(Me.PnPlasticPrice)
        Me.GroupBox1.Controls.Add(Me.PnNote)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cmb_ProductType)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(4, -3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(640, 330)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'PnOther
        '
        Me.PnOther.Controls.Add(Me.cmb_Unit)
        Me.PnOther.Controls.Add(Me.cbChkPerbox)
        Me.PnOther.Controls.Add(Me.txtPricePerboxOt)
        Me.PnOther.Controls.Add(Me.lbUnit)
        Me.PnOther.Controls.Add(Me.txtProductTitleOt)
        Me.PnOther.Controls.Add(Me.lbPricePerbox)
        Me.PnOther.Controls.Add(Me.txtUnit)
        Me.PnOther.Controls.Add(Me.txtVolumnOt)
        Me.PnOther.Controls.Add(Me.txtPerboxOt)
        Me.PnOther.Controls.Add(Me.cmb_VolumnUnit)
        Me.PnOther.Controls.Add(Me.Label20)
        Me.PnOther.Controls.Add(Me.lbPerbox)
        Me.PnOther.Controls.Add(Me.Label19)
        Me.PnOther.Controls.Add(Me.lbPriceBill)
        Me.PnOther.Controls.Add(Me.txtPriceBillOt)
        Me.PnOther.Controls.Add(Me.txtProductNameOt)
        Me.PnOther.Controls.Add(Me.Label18)
        Me.PnOther.Location = New System.Drawing.Point(6, 42)
        Me.PnOther.Name = "PnOther"
        Me.PnOther.Size = New System.Drawing.Size(629, 190)
        Me.PnOther.TabIndex = 2
        '
        'cbChkPerbox
        '
        Me.cbChkPerbox.AutoSize = True
        Me.cbChkPerbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cbChkPerbox.Location = New System.Drawing.Point(28, 162)
        Me.cbChkPerbox.Name = "cbChkPerbox"
        Me.cbChkPerbox.Size = New System.Drawing.Size(86, 22)
        Me.cbChkPerbox.TabIndex = 34
        Me.cbChkPerbox.Text = "บรรจุกล่อง"
        Me.cbChkPerbox.UseVisualStyleBackColor = True
        '
        'txtPricePerboxOt
        '
        Me.txtPricePerboxOt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPricePerboxOt.Location = New System.Drawing.Point(451, 160)
        Me.txtPricePerboxOt.Name = "txtPricePerboxOt"
        Me.txtPricePerboxOt.Size = New System.Drawing.Size(85, 24)
        Me.txtPricePerboxOt.TabIndex = 31
        Me.txtPricePerboxOt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbUnit
        '
        Me.lbUnit.AutoSize = True
        Me.lbUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbUnit.Location = New System.Drawing.Point(223, 133)
        Me.lbUnit.Name = "lbUnit"
        Me.lbUnit.Size = New System.Drawing.Size(41, 18)
        Me.lbUnit.TabIndex = 29
        Me.lbUnit.Text = "หน่วย"
        '
        'txtProductTitleOt
        '
        Me.txtProductTitleOt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtProductTitleOt.Location = New System.Drawing.Point(116, 67)
        Me.txtProductTitleOt.Multiline = True
        Me.txtProductTitleOt.Name = "txtProductTitleOt"
        Me.txtProductTitleOt.Size = New System.Drawing.Size(498, 55)
        Me.txtProductTitleOt.TabIndex = 1
        Me.txtProductTitleOt.TabStop = False
        '
        'lbPricePerbox
        '
        Me.lbPricePerbox.AutoSize = True
        Me.lbPricePerbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbPricePerbox.Location = New System.Drawing.Point(371, 163)
        Me.lbPricePerbox.Name = "lbPricePerbox"
        Me.lbPricePerbox.Size = New System.Drawing.Size(76, 18)
        Me.lbPricePerbox.TabIndex = 33
        Me.lbPricePerbox.Text = "ราคา / กล่อง"
        '
        'txtUnit
        '
        Me.txtUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtUnit.Location = New System.Drawing.Point(270, 130)
        Me.txtUnit.Name = "txtUnit"
        Me.txtUnit.Size = New System.Drawing.Size(85, 24)
        Me.txtUnit.TabIndex = 29
        '
        'txtVolumnOt
        '
        Me.txtVolumnOt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtVolumnOt.Location = New System.Drawing.Point(117, 36)
        Me.txtVolumnOt.Name = "txtVolumnOt"
        Me.txtVolumnOt.Size = New System.Drawing.Size(85, 24)
        Me.txtVolumnOt.TabIndex = 2
        Me.txtVolumnOt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPerboxOt
        '
        Me.txtPerboxOt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPerboxOt.Location = New System.Drawing.Point(270, 160)
        Me.txtPerboxOt.Name = "txtPerboxOt"
        Me.txtPerboxOt.Size = New System.Drawing.Size(85, 24)
        Me.txtPerboxOt.TabIndex = 30
        Me.txtPerboxOt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmb_VolumnUnit
        '
        Me.cmb_VolumnUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_VolumnUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.cmb_VolumnUnit.FormattingEnabled = True
        Me.cmb_VolumnUnit.Items.AddRange(New Object() {"", "ซีซี", "ลิตร"})
        Me.cmb_VolumnUnit.Location = New System.Drawing.Point(206, 34)
        Me.cmb_VolumnUnit.Name = "cmb_VolumnUnit"
        Me.cmb_VolumnUnit.Size = New System.Drawing.Size(84, 26)
        Me.cmb_VolumnUnit.TabIndex = 3
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label20.Location = New System.Drawing.Point(38, 40)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(69, 18)
        Me.Label20.TabIndex = 27
        Me.Label20.Text = "ขนาดบรรจุ"
        '
        'lbPerbox
        '
        Me.lbPerbox.AutoSize = True
        Me.lbPerbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbPerbox.Location = New System.Drawing.Point(147, 164)
        Me.lbPerbox.Name = "lbPerbox"
        Me.lbPerbox.Size = New System.Drawing.Size(117, 18)
        Me.lbPerbox.TabIndex = 32
        Me.lbPerbox.Text = "จำนวนบรรจุ / กล่อง"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label19.Location = New System.Drawing.Point(25, 71)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(82, 18)
        Me.Label19.TabIndex = 28
        Me.Label19.Text = "ชื่อเรียกสินค้า"
        '
        'lbPriceBill
        '
        Me.lbPriceBill.AutoSize = True
        Me.lbPriceBill.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbPriceBill.Location = New System.Drawing.Point(33, 133)
        Me.lbPriceBill.Name = "lbPriceBill"
        Me.lbPriceBill.Size = New System.Drawing.Size(75, 18)
        Me.lbPriceBill.TabIndex = 22
        Me.lbPriceBill.Text = "ราคาหน้าบิล"
        '
        'txtPriceBillOt
        '
        Me.txtPriceBillOt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPriceBillOt.Location = New System.Drawing.Point(118, 130)
        Me.txtPriceBillOt.Name = "txtPriceBillOt"
        Me.txtPriceBillOt.Size = New System.Drawing.Size(85, 24)
        Me.txtPriceBillOt.TabIndex = 4
        Me.txtPriceBillOt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtProductNameOt
        '
        Me.txtProductNameOt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtProductNameOt.Location = New System.Drawing.Point(116, 5)
        Me.txtProductNameOt.Name = "txtProductNameOt"
        Me.txtProductNameOt.Size = New System.Drawing.Size(498, 24)
        Me.txtProductNameOt.TabIndex = 0
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label18.Location = New System.Drawing.Point(52, 8)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(55, 18)
        Me.Label18.TabIndex = 27
        Me.Label18.Text = "ชื่อสินค้า"
        '
        'PnPlasticPrice
        '
        Me.PnPlasticPrice.Controls.Add(Me.txtProductTitlePt)
        Me.PnPlasticPrice.Controls.Add(Me.txtCreditPt60)
        Me.PnPlasticPrice.Controls.Add(Me.Label17)
        Me.PnPlasticPrice.Controls.Add(Me.txtCreditPt30)
        Me.PnPlasticPrice.Controls.Add(Me.Label16)
        Me.PnPlasticPrice.Controls.Add(Me.txtCashPt)
        Me.PnPlasticPrice.Controls.Add(Me.Label2)
        Me.PnPlasticPrice.Controls.Add(Me.lbSize)
        Me.PnPlasticPrice.Controls.Add(Me.Label15)
        Me.PnPlasticPrice.Controls.Add(Me.txtWidthPt)
        Me.PnPlasticPrice.Controls.Add(Me.Label5)
        Me.PnPlasticPrice.Controls.Add(Me.txtThicknessPt)
        Me.PnPlasticPrice.Controls.Add(Me.txtWeightPt)
        Me.PnPlasticPrice.Controls.Add(Me.txtLongPt)
        Me.PnPlasticPrice.Controls.Add(Me.Label14)
        Me.PnPlasticPrice.Controls.Add(Me.Label7)
        Me.PnPlasticPrice.Controls.Add(Me.txtPhasePt)
        Me.PnPlasticPrice.Controls.Add(Me.Label13)
        Me.PnPlasticPrice.Controls.Add(Me.Label11)
        Me.PnPlasticPrice.Controls.Add(Me.txtGradePt)
        Me.PnPlasticPrice.Controls.Add(Me.Label6)
        Me.PnPlasticPrice.Controls.Add(Me.txtLookPt)
        Me.PnPlasticPrice.Controls.Add(Me.txtProductNamePt)
        Me.PnPlasticPrice.Controls.Add(Me.Label1)
        Me.PnPlasticPrice.Location = New System.Drawing.Point(6, 42)
        Me.PnPlasticPrice.Name = "PnPlasticPrice"
        Me.PnPlasticPrice.Size = New System.Drawing.Size(629, 214)
        Me.PnPlasticPrice.TabIndex = 2
        '
        'txtProductTitlePt
        '
        Me.txtProductTitlePt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtProductTitlePt.Location = New System.Drawing.Point(116, 125)
        Me.txtProductTitlePt.Multiline = True
        Me.txtProductTitlePt.Name = "txtProductTitlePt"
        Me.txtProductTitlePt.Size = New System.Drawing.Size(495, 55)
        Me.txtProductTitlePt.TabIndex = 27
        Me.txtProductTitlePt.TabStop = False
        '
        'txtCreditPt60
        '
        Me.txtCreditPt60.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCreditPt60.Location = New System.Drawing.Point(529, 185)
        Me.txtCreditPt60.Name = "txtCreditPt60"
        Me.txtCreditPt60.Size = New System.Drawing.Size(85, 24)
        Me.txtCreditPt60.TabIndex = 10
        Me.txtCreditPt60.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label17.Location = New System.Drawing.Point(438, 188)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(83, 18)
        Me.Label17.TabIndex = 25
        Me.Label17.Text = "เครดิต 60 วัน"
        '
        'txtCreditPt30
        '
        Me.txtCreditPt30.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCreditPt30.Location = New System.Drawing.Point(301, 186)
        Me.txtCreditPt30.Name = "txtCreditPt30"
        Me.txtCreditPt30.Size = New System.Drawing.Size(85, 24)
        Me.txtCreditPt30.TabIndex = 9
        Me.txtCreditPt30.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label16.Location = New System.Drawing.Point(212, 188)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(83, 18)
        Me.Label16.TabIndex = 24
        Me.Label16.Text = "เครดิต 30 วัน"
        '
        'txtCashPt
        '
        Me.txtCashPt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCashPt.Location = New System.Drawing.Point(116, 185)
        Me.txtCashPt.Name = "txtCashPt"
        Me.txtCashPt.Size = New System.Drawing.Size(85, 24)
        Me.txtCashPt.TabIndex = 8
        Me.txtCashPt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(402, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 18)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "น้ำหนัก(กก.) / ม้วน"
        '
        'lbSize
        '
        Me.lbSize.AutoSize = True
        Me.lbSize.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbSize.Location = New System.Drawing.Point(47, 66)
        Me.lbSize.Name = "lbSize"
        Me.lbSize.Size = New System.Drawing.Size(62, 18)
        Me.lbSize.TabIndex = 14
        Me.lbSize.Text = "กว้าง (m)"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label15.Location = New System.Drawing.Point(65, 188)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(43, 18)
        Me.Label15.TabIndex = 22
        Me.Label15.Text = "เงินสด"
        '
        'txtWidthPt
        '
        Me.txtWidthPt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtWidthPt.Location = New System.Drawing.Point(116, 63)
        Me.txtWidthPt.Name = "txtWidthPt"
        Me.txtWidthPt.Size = New System.Drawing.Size(85, 24)
        Me.txtWidthPt.TabIndex = 3
        Me.txtWidthPt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(243, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 18)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "ยาว (Y)"
        '
        'txtThicknessPt
        '
        Me.txtThicknessPt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtThicknessPt.Location = New System.Drawing.Point(527, 94)
        Me.txtThicknessPt.Name = "txtThicknessPt"
        Me.txtThicknessPt.Size = New System.Drawing.Size(85, 24)
        Me.txtThicknessPt.TabIndex = 7
        Me.txtThicknessPt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtWeightPt
        '
        Me.txtWeightPt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtWeightPt.Location = New System.Drawing.Point(527, 63)
        Me.txtWeightPt.Name = "txtWeightPt"
        Me.txtWeightPt.Size = New System.Drawing.Size(85, 24)
        Me.txtWeightPt.TabIndex = 5
        Me.txtWeightPt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtLongPt
        '
        Me.txtLongPt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtLongPt.Location = New System.Drawing.Point(301, 63)
        Me.txtLongPt.Name = "txtLongPt"
        Me.txtLongPt.Size = New System.Drawing.Size(85, 24)
        Me.txtLongPt.TabIndex = 4
        Me.txtLongPt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label14.Location = New System.Drawing.Point(428, 98)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(93, 18)
        Me.Label14.TabIndex = 19
        Me.Label14.Text = "ความหนา(mc)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(25, 128)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 18)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "ชื่อเรียกสินค้า"
        '
        'txtPhasePt
        '
        Me.txtPhasePt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPhasePt.Location = New System.Drawing.Point(116, 94)
        Me.txtPhasePt.Name = "txtPhasePt"
        Me.txtPhasePt.Size = New System.Drawing.Size(270, 24)
        Me.txtPhasePt.TabIndex = 6
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label13.Location = New System.Drawing.Point(9, 97)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(102, 18)
        Me.Label13.TabIndex = 17
        Me.Label13.Text = "ระยะเจาะรู(CM)"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label11.Location = New System.Drawing.Point(37, 7)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(71, 18)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "ลักษณะ / สี"
        '
        'txtGradePt
        '
        Me.txtGradePt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtGradePt.Location = New System.Drawing.Point(301, 4)
        Me.txtGradePt.Name = "txtGradePt"
        Me.txtGradePt.Size = New System.Drawing.Size(85, 24)
        Me.txtGradePt.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(255, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 18)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "เกรด"
        '
        'txtLookPt
        '
        Me.txtLookPt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtLookPt.Location = New System.Drawing.Point(116, 3)
        Me.txtLookPt.Name = "txtLookPt"
        Me.txtLookPt.Size = New System.Drawing.Size(85, 24)
        Me.txtLookPt.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(40, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 18)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "การเจาะถุง"
        '
        'PnNote
        '
        Me.PnNote.Controls.Add(Me.Label3)
        Me.PnNote.Controls.Add(Me.txtNote)
        Me.PnNote.Location = New System.Drawing.Point(6, 254)
        Me.PnNote.Name = "PnNote"
        Me.PnNote.Size = New System.Drawing.Size(629, 68)
        Me.PnNote.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(47, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 18)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "หมายเหตุ"
        '
        'txtNote
        '
        Me.txtNote.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.txtNote.Location = New System.Drawing.Point(116, 4)
        Me.txtNote.Name = "txtNote"
        Me.txtNote.Size = New System.Drawing.Size(498, 61)
        Me.txtNote.TabIndex = 0
        Me.txtNote.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(29, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 18)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "ประเภทสินค้า"
        '
        'cmb_ProductType
        '
        Me.cmb_ProductType.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.cmb_ProductType.FormattingEnabled = True
        Me.cmb_ProductType.Location = New System.Drawing.Point(122, 14)
        Me.cmb_ProductType.Name = "cmb_ProductType"
        Me.cmb_ProductType.Size = New System.Drawing.Size(498, 26)
        Me.cmb_ProductType.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel3.Controls.Add(Me.btnDel)
        Me.Panel3.Controls.Add(Me.btnSave)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 333)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(649, 33)
        Me.Panel3.TabIndex = 2
        '
        'btnDel
        '
        Me.btnDel.BackColor = System.Drawing.Color.DimGray
        Me.btnDel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDel.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnDel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnDel.ForeColor = System.Drawing.Color.White
        Me.btnDel.Image = Global.SAM.My.Resources.Resources.Del28
        Me.btnDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDel.Location = New System.Drawing.Point(85, 0)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(101, 33)
        Me.btnDel.TabIndex = 1
        Me.btnDel.Tag = ""
        Me.btnDel.Text = "ลบข้อมูล"
        Me.btnDel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDel.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.DimGray
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Image = Global.SAM.My.Resources.Resources.Save28
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(0, 0)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(85, 33)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Tag = ""
        Me.btnSave.Text = "บันทึก"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'cmb_Unit
        '
        Me.cmb_Unit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.cmb_Unit.FormattingEnabled = True
        Me.cmb_Unit.Items.AddRange(New Object() {"", "ลูก", "กิโลกรัม"})
        Me.cmb_Unit.Location = New System.Drawing.Point(361, 128)
        Me.cmb_Unit.Name = "cmb_Unit"
        Me.cmb_Unit.Size = New System.Drawing.Size(84, 26)
        Me.cmb_Unit.TabIndex = 35
        '
        'frmSlPdoDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(649, 366)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSlPdoDetail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "รายละเอียดสินค้าอื่น ๆ"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.PnOther.ResumeLayout(False)
        Me.PnOther.PerformLayout()
        Me.PnPlasticPrice.ResumeLayout(False)
        Me.PnPlasticPrice.PerformLayout()
        Me.PnNote.ResumeLayout(False)
        Me.PnNote.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtProductNamePt As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmb_ProductType As System.Windows.Forms.ComboBox
    Friend WithEvents btnDel As System.Windows.Forms.Button
    Friend WithEvents PnPlasticPrice As System.Windows.Forms.Panel
    Friend WithEvents txtGradePt As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtLookPt As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PnOther As System.Windows.Forms.Panel
    Friend WithEvents txtCashPt As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtPriceBillOt As System.Windows.Forms.TextBox
    Friend WithEvents lbPriceBill As System.Windows.Forms.Label
    Friend WithEvents cmb_VolumnUnit As System.Windows.Forms.ComboBox
    Friend WithEvents txtWeightPt As System.Windows.Forms.TextBox
    Friend WithEvents txtWidthPt As System.Windows.Forms.TextBox
    Friend WithEvents lbSize As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents PnNote As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNote As System.Windows.Forms.RichTextBox
    Friend WithEvents txtLongPt As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtThicknessPt As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtPhasePt As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtCreditPt60 As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtCreditPt30 As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtVolumnOt As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtProductNameOt As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtProductTitlePt As System.Windows.Forms.TextBox
    Friend WithEvents txtProductTitleOt As System.Windows.Forms.TextBox
    Friend WithEvents lbUnit As System.Windows.Forms.Label
    Friend WithEvents txtUnit As System.Windows.Forms.TextBox
    Friend WithEvents cbChkPerbox As System.Windows.Forms.CheckBox
    Friend WithEvents txtPricePerboxOt As System.Windows.Forms.TextBox
    Friend WithEvents lbPricePerbox As System.Windows.Forms.Label
    Friend WithEvents txtPerboxOt As System.Windows.Forms.TextBox
    Friend WithEvents lbPerbox As System.Windows.Forms.Label
    Friend WithEvents cmb_Unit As System.Windows.Forms.ComboBox
End Class
