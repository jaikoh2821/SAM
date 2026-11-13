<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCusCommercePicDetail
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCusCommercePicDetail))
        Me.btnCusCard = New System.Windows.Forms.Button
        Me.ptbCusCard = New System.Windows.Forms.PictureBox
        Me.btnCusCardDel = New System.Windows.Forms.Button
        Me.Label19 = New System.Windows.Forms.Label
        Me.ofdUpImg = New System.Windows.Forms.OpenFileDialog
        Me.btnCusRegistration = New System.Windows.Forms.Button
        Me.ptbCusRegistration = New System.Windows.Forms.PictureBox
        Me.btnCusRegistrationDel = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnCusCommercial = New System.Windows.Forms.Button
        Me.ptbCusCommercial = New System.Windows.Forms.PictureBox
        Me.btnCusCommercialDel = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btnCusBusinessDel = New System.Windows.Forms.Button
        Me.btnCusBusiness = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.lbTotalPic = New System.Windows.Forms.Label
        Me.lbTotalPages = New System.Windows.Forms.Label
        Me.lbCurPage = New System.Windows.Forms.Label
        Me.btnFirst = New System.Windows.Forms.Button
        Me.btnLast = New System.Windows.Forms.Button
        Me.btnBack = New System.Windows.Forms.Button
        Me.btnNext = New System.Windows.Forms.Button
        Me.lsv = New System.Windows.Forms.ListView
        Me.img = New System.Windows.Forms.ImageList(Me.components)
        Me.lbCusName = New System.Windows.Forms.Label
        Me.lbAddress = New System.Windows.Forms.Label
        Me.lbPsName = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.btnCusBusinessDel2 = New System.Windows.Forms.Button
        Me.btnCusBusiness2 = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.lbTotalPic2 = New System.Windows.Forms.Label
        Me.lbTotalPages2 = New System.Windows.Forms.Label
        Me.lbCurPage2 = New System.Windows.Forms.Label
        Me.btnFirst2 = New System.Windows.Forms.Button
        Me.btnLast2 = New System.Windows.Forms.Button
        Me.btnBack2 = New System.Windows.Forms.Button
        Me.btnNext2 = New System.Windows.Forms.Button
        Me.lsvetc = New System.Windows.Forms.ListView
        Me.img2 = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.ptbCusCard, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbCusRegistration, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbCusCommercial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCusCard
        '
        Me.btnCusCard.BackColor = System.Drawing.Color.DimGray
        Me.btnCusCard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCusCard.ForeColor = System.Drawing.Color.White
        Me.btnCusCard.Location = New System.Drawing.Point(250, 79)
        Me.btnCusCard.Name = "btnCusCard"
        Me.btnCusCard.Size = New System.Drawing.Size(40, 23)
        Me.btnCusCard.TabIndex = 601
        Me.btnCusCard.Text = "เลือก"
        Me.btnCusCard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCusCard.UseVisualStyleBackColor = False
        '
        'ptbCusCard
        '
        Me.ptbCusCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ptbCusCard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ptbCusCard.Location = New System.Drawing.Point(21, 103)
        Me.ptbCusCard.Name = "ptbCusCard"
        Me.ptbCusCard.Size = New System.Drawing.Size(300, 250)
        Me.ptbCusCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbCusCard.TabIndex = 598
        Me.ptbCusCard.TabStop = False
        '
        'btnCusCardDel
        '
        Me.btnCusCardDel.BackColor = System.Drawing.Color.DimGray
        Me.btnCusCardDel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCusCardDel.Enabled = False
        Me.btnCusCardDel.ForeColor = System.Drawing.Color.White
        Me.btnCusCardDel.Location = New System.Drawing.Point(290, 79)
        Me.btnCusCardDel.Name = "btnCusCardDel"
        Me.btnCusCardDel.Size = New System.Drawing.Size(29, 23)
        Me.btnCusCardDel.TabIndex = 600
        Me.btnCusCardDel.Text = "ลบ"
        Me.btnCusCardDel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCusCardDel.UseVisualStyleBackColor = False
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(21, 78)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(300, 25)
        Me.Label19.TabIndex = 599
        Me.Label19.Text = "                    รูปบัตรประชาชน"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ofdUpImg
        '
        Me.ofdUpImg.Filter = "*.jpg|*.jpg"
        '
        'btnCusRegistration
        '
        Me.btnCusRegistration.BackColor = System.Drawing.Color.DimGray
        Me.btnCusRegistration.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCusRegistration.ForeColor = System.Drawing.Color.White
        Me.btnCusRegistration.Location = New System.Drawing.Point(572, 79)
        Me.btnCusRegistration.Name = "btnCusRegistration"
        Me.btnCusRegistration.Size = New System.Drawing.Size(40, 23)
        Me.btnCusRegistration.TabIndex = 605
        Me.btnCusRegistration.Text = "เลือก"
        Me.btnCusRegistration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCusRegistration.UseVisualStyleBackColor = False
        '
        'ptbCusRegistration
        '
        Me.ptbCusRegistration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ptbCusRegistration.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ptbCusRegistration.Location = New System.Drawing.Point(343, 103)
        Me.ptbCusRegistration.Name = "ptbCusRegistration"
        Me.ptbCusRegistration.Size = New System.Drawing.Size(300, 250)
        Me.ptbCusRegistration.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbCusRegistration.TabIndex = 602
        Me.ptbCusRegistration.TabStop = False
        '
        'btnCusRegistrationDel
        '
        Me.btnCusRegistrationDel.BackColor = System.Drawing.Color.DimGray
        Me.btnCusRegistrationDel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCusRegistrationDel.Enabled = False
        Me.btnCusRegistrationDel.ForeColor = System.Drawing.Color.White
        Me.btnCusRegistrationDel.Location = New System.Drawing.Point(612, 79)
        Me.btnCusRegistrationDel.Name = "btnCusRegistrationDel"
        Me.btnCusRegistrationDel.Size = New System.Drawing.Size(29, 23)
        Me.btnCusRegistrationDel.TabIndex = 604
        Me.btnCusRegistrationDel.Text = "ลบ"
        Me.btnCusRegistrationDel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCusRegistrationDel.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(343, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(300, 25)
        Me.Label1.TabIndex = 603
        Me.Label1.Text = "                      รูปทะเบียนบ้าน"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnCusCommercial
        '
        Me.btnCusCommercial.BackColor = System.Drawing.Color.DimGray
        Me.btnCusCommercial.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCusCommercial.ForeColor = System.Drawing.Color.White
        Me.btnCusCommercial.Location = New System.Drawing.Point(894, 80)
        Me.btnCusCommercial.Name = "btnCusCommercial"
        Me.btnCusCommercial.Size = New System.Drawing.Size(40, 23)
        Me.btnCusCommercial.TabIndex = 609
        Me.btnCusCommercial.Text = "เลือก"
        Me.btnCusCommercial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCusCommercial.UseVisualStyleBackColor = False
        '
        'ptbCusCommercial
        '
        Me.ptbCusCommercial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ptbCusCommercial.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ptbCusCommercial.Location = New System.Drawing.Point(664, 104)
        Me.ptbCusCommercial.Name = "ptbCusCommercial"
        Me.ptbCusCommercial.Size = New System.Drawing.Size(300, 250)
        Me.ptbCusCommercial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbCusCommercial.TabIndex = 606
        Me.ptbCusCommercial.TabStop = False
        '
        'btnCusCommercialDel
        '
        Me.btnCusCommercialDel.BackColor = System.Drawing.Color.DimGray
        Me.btnCusCommercialDel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCusCommercialDel.Enabled = False
        Me.btnCusCommercialDel.ForeColor = System.Drawing.Color.White
        Me.btnCusCommercialDel.Location = New System.Drawing.Point(934, 80)
        Me.btnCusCommercialDel.Name = "btnCusCommercialDel"
        Me.btnCusCommercialDel.Size = New System.Drawing.Size(29, 23)
        Me.btnCusCommercialDel.TabIndex = 608
        Me.btnCusCommercialDel.Text = "ลบ"
        Me.btnCusCommercialDel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCusCommercialDel.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(664, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(300, 25)
        Me.Label2.TabIndex = 607
        Me.Label2.Text = "                     รูปทะเบียนการค้า"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.lsv)
        Me.Panel1.Location = New System.Drawing.Point(9, 357)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(480, 233)
        Me.Panel1.TabIndex = 612
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnCusBusinessDel)
        Me.Panel2.Controls.Add(Me.btnCusBusiness)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.lbTotalPic)
        Me.Panel2.Controls.Add(Me.lbTotalPages)
        Me.Panel2.Controls.Add(Me.lbCurPage)
        Me.Panel2.Controls.Add(Me.btnFirst)
        Me.Panel2.Controls.Add(Me.btnLast)
        Me.Panel2.Controls.Add(Me.btnBack)
        Me.Panel2.Controls.Add(Me.btnNext)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(480, 40)
        Me.Panel2.TabIndex = 613
        '
        'btnCusBusinessDel
        '
        Me.btnCusBusinessDel.BackColor = System.Drawing.Color.DimGray
        Me.btnCusBusinessDel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCusBusinessDel.Enabled = False
        Me.btnCusBusinessDel.ForeColor = System.Drawing.Color.White
        Me.btnCusBusinessDel.Location = New System.Drawing.Point(144, 10)
        Me.btnCusBusinessDel.Name = "btnCusBusinessDel"
        Me.btnCusBusinessDel.Size = New System.Drawing.Size(29, 23)
        Me.btnCusBusinessDel.TabIndex = 607
        Me.btnCusBusinessDel.Text = "ลบ"
        Me.btnCusBusinessDel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCusBusinessDel.UseVisualStyleBackColor = False
        '
        'btnCusBusiness
        '
        Me.btnCusBusiness.BackColor = System.Drawing.Color.DimGray
        Me.btnCusBusiness.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCusBusiness.ForeColor = System.Drawing.Color.White
        Me.btnCusBusiness.Location = New System.Drawing.Point(100, 10)
        Me.btnCusBusiness.Name = "btnCusBusiness"
        Me.btnCusBusiness.Size = New System.Drawing.Size(38, 23)
        Me.btnCusBusiness.TabIndex = 606
        Me.btnCusBusiness.Text = "เพิ่ม"
        Me.btnCusBusiness.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCusBusiness.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(3, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 18)
        Me.Label3.TabIndex = 469
        Me.Label3.Text = "ภาพถ่ายกิจการ"
        '
        'lbTotalPic
        '
        Me.lbTotalPic.AutoSize = True
        Me.lbTotalPic.ForeColor = System.Drawing.Color.White
        Me.lbTotalPic.Location = New System.Drawing.Point(179, 15)
        Me.lbTotalPic.Name = "lbTotalPic"
        Me.lbTotalPic.Size = New System.Drawing.Size(73, 13)
        Me.lbTotalPic.TabIndex = 468
        Me.lbTotalPic.Text = "รูปภาพทั้งหมด"
        '
        'lbTotalPages
        '
        Me.lbTotalPages.AutoSize = True
        Me.lbTotalPages.ForeColor = System.Drawing.Color.White
        Me.lbTotalPages.Location = New System.Drawing.Point(276, 20)
        Me.lbTotalPages.Name = "lbTotalPages"
        Me.lbTotalPages.Size = New System.Drawing.Size(60, 13)
        Me.lbTotalPages.TabIndex = 467
        Me.lbTotalPages.Text = "หน้าทั้งหมด"
        '
        'lbCurPage
        '
        Me.lbCurPage.AutoSize = True
        Me.lbCurPage.ForeColor = System.Drawing.Color.White
        Me.lbCurPage.Location = New System.Drawing.Point(275, 3)
        Me.lbCurPage.Name = "lbCurPage"
        Me.lbCurPage.Size = New System.Drawing.Size(61, 13)
        Me.lbCurPage.TabIndex = 466
        Me.lbCurPage.Text = "หน้าปัจจุบัน"
        '
        'btnFirst
        '
        Me.btnFirst.BackColor = System.Drawing.Color.DimGray
        Me.btnFirst.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFirst.Enabled = False
        Me.btnFirst.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnFirst.ForeColor = System.Drawing.Color.White
        Me.btnFirst.Image = CType(resources.GetObject("btnFirst.Image"), System.Drawing.Image)
        Me.btnFirst.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFirst.Location = New System.Drawing.Point(359, 9)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(23, 23)
        Me.btnFirst.TabIndex = 465
        Me.btnFirst.UseVisualStyleBackColor = False
        '
        'btnLast
        '
        Me.btnLast.BackColor = System.Drawing.Color.DimGray
        Me.btnLast.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLast.Enabled = False
        Me.btnLast.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnLast.ForeColor = System.Drawing.Color.White
        Me.btnLast.Image = CType(resources.GetObject("btnLast.Image"), System.Drawing.Image)
        Me.btnLast.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLast.Location = New System.Drawing.Point(448, 9)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(24, 23)
        Me.btnLast.TabIndex = 464
        Me.btnLast.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.DimGray
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.Enabled = False
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Image = CType(resources.GetObject("btnBack.Image"), System.Drawing.Image)
        Me.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBack.Location = New System.Drawing.Point(388, 9)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(24, 23)
        Me.btnBack.TabIndex = 463
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.DimGray
        Me.btnNext.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNext.Enabled = False
        Me.btnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnNext.ForeColor = System.Drawing.Color.White
        Me.btnNext.Image = CType(resources.GetObject("btnNext.Image"), System.Drawing.Image)
        Me.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNext.Location = New System.Drawing.Point(418, 9)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(24, 23)
        Me.btnNext.TabIndex = 462
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'lsv
        '
        Me.lsv.BackColor = System.Drawing.Color.Lavender
        Me.lsv.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lsv.LargeImageList = Me.img
        Me.lsv.Location = New System.Drawing.Point(0, 43)
        Me.lsv.Name = "lsv"
        Me.lsv.Scrollable = False
        Me.lsv.Size = New System.Drawing.Size(480, 190)
        Me.lsv.TabIndex = 612
        Me.lsv.UseCompatibleStateImageBehavior = False
        '
        'img
        '
        Me.img.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.img.ImageSize = New System.Drawing.Size(180, 180)
        Me.img.TransparentColor = System.Drawing.Color.Transparent
        '
        'lbCusName
        '
        Me.lbCusName.AutoSize = True
        Me.lbCusName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbCusName.Location = New System.Drawing.Point(18, 9)
        Me.lbCusName.Name = "lbCusName"
        Me.lbCusName.Size = New System.Drawing.Size(64, 17)
        Me.lbCusName.TabIndex = 613
        Me.lbCusName.Text = "ชื่อลูกค้า : "
        '
        'lbAddress
        '
        Me.lbAddress.AutoSize = True
        Me.lbAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbAddress.Location = New System.Drawing.Point(18, 33)
        Me.lbAddress.Name = "lbAddress"
        Me.lbAddress.Size = New System.Drawing.Size(42, 17)
        Me.lbAddress.TabIndex = 614
        Me.lbAddress.Text = "ที่อยู่ : "
        '
        'lbPsName
        '
        Me.lbPsName.AutoSize = True
        Me.lbPsName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbPsName.Location = New System.Drawing.Point(18, 57)
        Me.lbPsName.Name = "lbPsName"
        Me.lbPsName.Size = New System.Drawing.Size(100, 17)
        Me.lbPsName.TabIndex = 615
        Me.lbPsName.Text = "เจ้าหน้าที่ที่ดูแล : "
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.lsvetc)
        Me.Panel3.Location = New System.Drawing.Point(495, 357)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(483, 233)
        Me.Panel3.TabIndex = 614
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.btnCusBusinessDel2)
        Me.Panel4.Controls.Add(Me.btnCusBusiness2)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.lbTotalPic2)
        Me.Panel4.Controls.Add(Me.lbTotalPages2)
        Me.Panel4.Controls.Add(Me.lbCurPage2)
        Me.Panel4.Controls.Add(Me.btnFirst2)
        Me.Panel4.Controls.Add(Me.btnLast2)
        Me.Panel4.Controls.Add(Me.btnBack2)
        Me.Panel4.Controls.Add(Me.btnNext2)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(483, 40)
        Me.Panel4.TabIndex = 613
        '
        'btnCusBusinessDel2
        '
        Me.btnCusBusinessDel2.BackColor = System.Drawing.Color.DimGray
        Me.btnCusBusinessDel2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCusBusinessDel2.Enabled = False
        Me.btnCusBusinessDel2.ForeColor = System.Drawing.Color.White
        Me.btnCusBusinessDel2.Location = New System.Drawing.Point(144, 10)
        Me.btnCusBusinessDel2.Name = "btnCusBusinessDel2"
        Me.btnCusBusinessDel2.Size = New System.Drawing.Size(29, 23)
        Me.btnCusBusinessDel2.TabIndex = 607
        Me.btnCusBusinessDel2.Text = "ลบ"
        Me.btnCusBusinessDel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCusBusinessDel2.UseVisualStyleBackColor = False
        '
        'btnCusBusiness2
        '
        Me.btnCusBusiness2.BackColor = System.Drawing.Color.DimGray
        Me.btnCusBusiness2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCusBusiness2.ForeColor = System.Drawing.Color.White
        Me.btnCusBusiness2.Location = New System.Drawing.Point(100, 10)
        Me.btnCusBusiness2.Name = "btnCusBusiness2"
        Me.btnCusBusiness2.Size = New System.Drawing.Size(38, 23)
        Me.btnCusBusiness2.TabIndex = 606
        Me.btnCusBusiness2.Text = "เพิ่ม"
        Me.btnCusBusiness2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCusBusiness2.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(3, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 18)
        Me.Label4.TabIndex = 469
        Me.Label4.Text = "หลักฐานอื่น ๆ"
        '
        'lbTotalPic2
        '
        Me.lbTotalPic2.AutoSize = True
        Me.lbTotalPic2.ForeColor = System.Drawing.Color.White
        Me.lbTotalPic2.Location = New System.Drawing.Point(179, 15)
        Me.lbTotalPic2.Name = "lbTotalPic2"
        Me.lbTotalPic2.Size = New System.Drawing.Size(73, 13)
        Me.lbTotalPic2.TabIndex = 468
        Me.lbTotalPic2.Text = "รูปภาพทั้งหมด"
        '
        'lbTotalPages2
        '
        Me.lbTotalPages2.AutoSize = True
        Me.lbTotalPages2.ForeColor = System.Drawing.Color.White
        Me.lbTotalPages2.Location = New System.Drawing.Point(276, 20)
        Me.lbTotalPages2.Name = "lbTotalPages2"
        Me.lbTotalPages2.Size = New System.Drawing.Size(60, 13)
        Me.lbTotalPages2.TabIndex = 467
        Me.lbTotalPages2.Text = "หน้าทั้งหมด"
        '
        'lbCurPage2
        '
        Me.lbCurPage2.AutoSize = True
        Me.lbCurPage2.ForeColor = System.Drawing.Color.White
        Me.lbCurPage2.Location = New System.Drawing.Point(275, 3)
        Me.lbCurPage2.Name = "lbCurPage2"
        Me.lbCurPage2.Size = New System.Drawing.Size(61, 13)
        Me.lbCurPage2.TabIndex = 466
        Me.lbCurPage2.Text = "หน้าปัจจุบัน"
        '
        'btnFirst2
        '
        Me.btnFirst2.BackColor = System.Drawing.Color.DimGray
        Me.btnFirst2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFirst2.Enabled = False
        Me.btnFirst2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnFirst2.ForeColor = System.Drawing.Color.White
        Me.btnFirst2.Image = CType(resources.GetObject("btnFirst2.Image"), System.Drawing.Image)
        Me.btnFirst2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFirst2.Location = New System.Drawing.Point(359, 9)
        Me.btnFirst2.Name = "btnFirst2"
        Me.btnFirst2.Size = New System.Drawing.Size(23, 23)
        Me.btnFirst2.TabIndex = 465
        Me.btnFirst2.UseVisualStyleBackColor = False
        '
        'btnLast2
        '
        Me.btnLast2.BackColor = System.Drawing.Color.DimGray
        Me.btnLast2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLast2.Enabled = False
        Me.btnLast2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnLast2.ForeColor = System.Drawing.Color.White
        Me.btnLast2.Image = CType(resources.GetObject("btnLast2.Image"), System.Drawing.Image)
        Me.btnLast2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLast2.Location = New System.Drawing.Point(448, 9)
        Me.btnLast2.Name = "btnLast2"
        Me.btnLast2.Size = New System.Drawing.Size(24, 23)
        Me.btnLast2.TabIndex = 464
        Me.btnLast2.UseVisualStyleBackColor = False
        '
        'btnBack2
        '
        Me.btnBack2.BackColor = System.Drawing.Color.DimGray
        Me.btnBack2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack2.Enabled = False
        Me.btnBack2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnBack2.ForeColor = System.Drawing.Color.White
        Me.btnBack2.Image = CType(resources.GetObject("btnBack2.Image"), System.Drawing.Image)
        Me.btnBack2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBack2.Location = New System.Drawing.Point(388, 9)
        Me.btnBack2.Name = "btnBack2"
        Me.btnBack2.Size = New System.Drawing.Size(24, 23)
        Me.btnBack2.TabIndex = 463
        Me.btnBack2.UseVisualStyleBackColor = False
        '
        'btnNext2
        '
        Me.btnNext2.BackColor = System.Drawing.Color.DimGray
        Me.btnNext2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNext2.Enabled = False
        Me.btnNext2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnNext2.ForeColor = System.Drawing.Color.White
        Me.btnNext2.Image = CType(resources.GetObject("btnNext2.Image"), System.Drawing.Image)
        Me.btnNext2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNext2.Location = New System.Drawing.Point(418, 9)
        Me.btnNext2.Name = "btnNext2"
        Me.btnNext2.Size = New System.Drawing.Size(24, 23)
        Me.btnNext2.TabIndex = 462
        Me.btnNext2.UseVisualStyleBackColor = False
        '
        'lsvetc
        '
        Me.lsvetc.BackColor = System.Drawing.Color.Lavender
        Me.lsvetc.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lsvetc.LargeImageList = Me.img2
        Me.lsvetc.Location = New System.Drawing.Point(0, 43)
        Me.lsvetc.Name = "lsvetc"
        Me.lsvetc.Scrollable = False
        Me.lsvetc.Size = New System.Drawing.Size(483, 190)
        Me.lsvetc.TabIndex = 612
        Me.lsvetc.UseCompatibleStateImageBehavior = False
        '
        'img2
        '
        Me.img2.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.img2.ImageSize = New System.Drawing.Size(180, 180)
        Me.img2.TransparentColor = System.Drawing.Color.Transparent
        '
        'frmCusCommercePicDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(988, 602)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.lbPsName)
        Me.Controls.Add(Me.lbAddress)
        Me.Controls.Add(Me.lbCusName)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnCusCommercial)
        Me.Controls.Add(Me.ptbCusCommercial)
        Me.Controls.Add(Me.btnCusCommercialDel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnCusRegistration)
        Me.Controls.Add(Me.ptbCusRegistration)
        Me.Controls.Add(Me.btnCusRegistrationDel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCusCard)
        Me.Controls.Add(Me.ptbCusCard)
        Me.Controls.Add(Me.btnCusCardDel)
        Me.Controls.Add(Me.Label19)
        Me.Name = "frmCusCommercePicDetail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "รูปหลักฐานการทำการค้าของคู่ค้า"
        CType(Me.ptbCusCard, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbCusRegistration, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbCusCommercial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCusCard As System.Windows.Forms.Button
    Friend WithEvents ptbCusCard As System.Windows.Forms.PictureBox
    Friend WithEvents btnCusCardDel As System.Windows.Forms.Button
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents ofdUpImg As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnCusRegistration As System.Windows.Forms.Button
    Friend WithEvents ptbCusRegistration As System.Windows.Forms.PictureBox
    Friend WithEvents btnCusRegistrationDel As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCusCommercial As System.Windows.Forms.Button
    Friend WithEvents ptbCusCommercial As System.Windows.Forms.PictureBox
    Friend WithEvents btnCusCommercialDel As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lbTotalPic As System.Windows.Forms.Label
    Friend WithEvents lbTotalPages As System.Windows.Forms.Label
    Friend WithEvents lbCurPage As System.Windows.Forms.Label
    Friend WithEvents btnFirst As System.Windows.Forms.Button
    Friend WithEvents btnLast As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents lsv As System.Windows.Forms.ListView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents img As System.Windows.Forms.ImageList
    Friend WithEvents btnCusBusiness As System.Windows.Forms.Button
    Friend WithEvents btnCusBusinessDel As System.Windows.Forms.Button
    Friend WithEvents lbCusName As System.Windows.Forms.Label
    Friend WithEvents lbAddress As System.Windows.Forms.Label
    Friend WithEvents lbPsName As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents btnCusBusinessDel2 As System.Windows.Forms.Button
    Friend WithEvents btnCusBusiness2 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbTotalPic2 As System.Windows.Forms.Label
    Friend WithEvents lbTotalPages2 As System.Windows.Forms.Label
    Friend WithEvents lbCurPage2 As System.Windows.Forms.Label
    Friend WithEvents btnFirst2 As System.Windows.Forms.Button
    Friend WithEvents btnLast2 As System.Windows.Forms.Button
    Friend WithEvents btnBack2 As System.Windows.Forms.Button
    Friend WithEvents btnNext2 As System.Windows.Forms.Button
    Friend WithEvents lsvetc As System.Windows.Forms.ListView
    Friend WithEvents img2 As System.Windows.Forms.ImageList
End Class
