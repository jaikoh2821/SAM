<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMkCusPicList
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMkCusPicList))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Img1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Lv2 = New System.Windows.Forms.ListView
        Me.Img2 = New System.Windows.Forms.ImageList(Me.components)
        Me.Lv3 = New System.Windows.Forms.ListView
        Me.Img3 = New System.Windows.Forms.ImageList(Me.components)
        Me.DataGridView2 = New System.Windows.Forms.DataGridView
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Button2 = New System.Windows.Forms.Button
        Me.btn_save = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.txtname = New System.Windows.Forms.Label
        Me.txtadd = New System.Windows.Forms.Label
        Me.btnFirst = New System.Windows.Forms.Button
        Me.btnLast = New System.Windows.Forms.Button
        Me.btnBack = New System.Windows.Forms.Button
        Me.btnNext = New System.Windows.Forms.Button
        Me.btnFirst2 = New System.Windows.Forms.Button
        Me.btnLast2 = New System.Windows.Forms.Button
        Me.btnBack2 = New System.Windows.Forms.Button
        Me.btnNext2 = New System.Windows.Forms.Button
        Me.btnFirst3 = New System.Windows.Forms.Button
        Me.btnLast3 = New System.Windows.Forms.Button
        Me.btnBack3 = New System.Windows.Forms.Button
        Me.btnNext3 = New System.Windows.Forms.Button
        Me.Lv1 = New System.Windows.Forms.ListView
        Me.lbTotalPic1 = New System.Windows.Forms.Label
        Me.lbTotalPic2 = New System.Windows.Forms.Label
        Me.lbTotalPic3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtnumPs = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Img1
        '
        Me.Img1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.Img1.ImageSize = New System.Drawing.Size(100, 100)
        Me.Img1.TransparentColor = System.Drawing.Color.Transparent
        '
        'Lv2
        '
        Me.Lv2.LargeImageList = Me.Img2
        Me.Lv2.Location = New System.Drawing.Point(658, 176)
        Me.Lv2.MultiSelect = False
        Me.Lv2.Name = "Lv2"
        Me.Lv2.Size = New System.Drawing.Size(307, 390)
        Me.Lv2.TabIndex = 6
        Me.Lv2.UseCompatibleStateImageBehavior = False
        '
        'Img2
        '
        Me.Img2.ImageStream = CType(resources.GetObject("Img2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.Img2.TransparentColor = System.Drawing.Color.Transparent
        Me.Img2.Images.SetKeyName(0, "noResult.jpg")
        Me.Img2.Images.SetKeyName(1, "images.jpg")
        Me.Img2.Images.SetKeyName(2, "cross_circle_frame_black.png")
        Me.Img2.Images.SetKeyName(3, "button-back.png")
        Me.Img2.Images.SetKeyName(4, "934023.jpg")
        Me.Img2.Images.SetKeyName(5, "scaredsugarglider.jpg")
        Me.Img2.Images.SetKeyName(6, "picture_252255214080.jpg")
        '
        'Lv3
        '
        Me.Lv3.LargeImageList = Me.Img3
        Me.Lv3.Location = New System.Drawing.Point(19, 176)
        Me.Lv3.MultiSelect = False
        Me.Lv3.Name = "Lv3"
        Me.Lv3.Size = New System.Drawing.Size(307, 390)
        Me.Lv3.TabIndex = 7
        Me.Lv3.UseCompatibleStateImageBehavior = False
        '
        'Img3
        '
        Me.Img3.ImageStream = CType(resources.GetObject("Img3.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.Img3.TransparentColor = System.Drawing.Color.Transparent
        Me.Img3.Images.SetKeyName(0, "noResult.jpg")
        Me.Img3.Images.SetKeyName(1, "images.jpg")
        Me.Img3.Images.SetKeyName(2, "cross_circle_frame_black.png")
        Me.Img3.Images.SetKeyName(3, "button-back.png")
        Me.Img3.Images.SetKeyName(4, "934023.jpg")
        Me.Img3.Images.SetKeyName(5, "scaredsugarglider.jpg")
        Me.Img3.Images.SetKeyName(6, "picture_252255214080.jpg")
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView2.Location = New System.Drawing.Point(0, 136)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.Size = New System.Drawing.Size(984, 466)
        Me.DataGridView2.TabIndex = 422
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.btn_save)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 75)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(984, 61)
        Me.Panel1.TabIndex = 423
        '
        'Button2
        '
        Me.Button2.AutoSize = True
        Me.Button2.BackColor = System.Drawing.Color.DimGray
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Image = Global.SAM.My.Resources.Resources.edit_notes
        Me.Button2.Location = New System.Drawing.Point(117, 6)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(96, 48)
        Me.Button2.TabIndex = 424
        Me.Button2.Text = "แก้ไข"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btn_save
        '
        Me.btn_save.AutoSize = True
        Me.btn_save.BackColor = System.Drawing.Color.DimGray
        Me.btn_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_save.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_save.ForeColor = System.Drawing.Color.White
        Me.btn_save.Image = Global.SAM.My.Resources.Resources.Add28
        Me.btn_save.Location = New System.Drawing.Point(15, 6)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(96, 48)
        Me.btn_save.TabIndex = 417
        Me.btn_save.Text = "เพิ่ม"
        Me.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.BackColor = System.Drawing.Color.DimGray
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = Global.SAM.My.Resources.Resources.Del28
        Me.Button1.Location = New System.Drawing.Point(219, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 48)
        Me.Button1.TabIndex = 400
        Me.Button1.Text = "ลบ"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtname
        '
        Me.txtname.AutoSize = True
        Me.txtname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtname.Location = New System.Drawing.Point(12, 9)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(59, 20)
        Me.txtname.TabIndex = 424
        Me.txtname.Text = "ชื่อลูกค้า"
        '
        'txtadd
        '
        Me.txtadd.AutoSize = True
        Me.txtadd.Location = New System.Drawing.Point(12, 37)
        Me.txtadd.Name = "txtadd"
        Me.txtadd.Size = New System.Drawing.Size(52, 13)
        Me.txtadd.TabIndex = 425
        Me.txtadd.Text = "ที่อยู่ลูกค้า"
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
        Me.btnFirst.Location = New System.Drawing.Point(540, 153)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(25, 23)
        Me.btnFirst.TabIndex = 429
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
        Me.btnLast.Location = New System.Drawing.Point(619, 153)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(25, 23)
        Me.btnLast.TabIndex = 428
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
        Me.btnBack.Location = New System.Drawing.Point(567, 153)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(24, 23)
        Me.btnBack.TabIndex = 427
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
        Me.btnNext.Location = New System.Drawing.Point(593, 153)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(24, 23)
        Me.btnNext.TabIndex = 426
        Me.btnNext.UseVisualStyleBackColor = False
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
        Me.btnFirst2.Location = New System.Drawing.Point(859, 153)
        Me.btnFirst2.Name = "btnFirst2"
        Me.btnFirst2.Size = New System.Drawing.Size(25, 23)
        Me.btnFirst2.TabIndex = 433
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
        Me.btnLast2.Location = New System.Drawing.Point(938, 153)
        Me.btnLast2.Name = "btnLast2"
        Me.btnLast2.Size = New System.Drawing.Size(25, 23)
        Me.btnLast2.TabIndex = 432
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
        Me.btnBack2.Location = New System.Drawing.Point(886, 153)
        Me.btnBack2.Name = "btnBack2"
        Me.btnBack2.Size = New System.Drawing.Size(24, 23)
        Me.btnBack2.TabIndex = 431
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
        Me.btnNext2.Location = New System.Drawing.Point(912, 153)
        Me.btnNext2.Name = "btnNext2"
        Me.btnNext2.Size = New System.Drawing.Size(24, 23)
        Me.btnNext2.TabIndex = 430
        Me.btnNext2.UseVisualStyleBackColor = False
        '
        'btnFirst3
        '
        Me.btnFirst3.BackColor = System.Drawing.Color.DimGray
        Me.btnFirst3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFirst3.Enabled = False
        Me.btnFirst3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnFirst3.ForeColor = System.Drawing.Color.White
        Me.btnFirst3.Image = CType(resources.GetObject("btnFirst3.Image"), System.Drawing.Image)
        Me.btnFirst3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFirst3.Location = New System.Drawing.Point(220, 153)
        Me.btnFirst3.Name = "btnFirst3"
        Me.btnFirst3.Size = New System.Drawing.Size(25, 23)
        Me.btnFirst3.TabIndex = 437
        Me.btnFirst3.UseVisualStyleBackColor = False
        '
        'btnLast3
        '
        Me.btnLast3.BackColor = System.Drawing.Color.DimGray
        Me.btnLast3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLast3.Enabled = False
        Me.btnLast3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnLast3.ForeColor = System.Drawing.Color.White
        Me.btnLast3.Image = CType(resources.GetObject("btnLast3.Image"), System.Drawing.Image)
        Me.btnLast3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLast3.Location = New System.Drawing.Point(299, 153)
        Me.btnLast3.Name = "btnLast3"
        Me.btnLast3.Size = New System.Drawing.Size(25, 23)
        Me.btnLast3.TabIndex = 436
        Me.btnLast3.UseVisualStyleBackColor = False
        '
        'btnBack3
        '
        Me.btnBack3.BackColor = System.Drawing.Color.DimGray
        Me.btnBack3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack3.Enabled = False
        Me.btnBack3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnBack3.ForeColor = System.Drawing.Color.White
        Me.btnBack3.Image = CType(resources.GetObject("btnBack3.Image"), System.Drawing.Image)
        Me.btnBack3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBack3.Location = New System.Drawing.Point(247, 153)
        Me.btnBack3.Name = "btnBack3"
        Me.btnBack3.Size = New System.Drawing.Size(24, 23)
        Me.btnBack3.TabIndex = 435
        Me.btnBack3.UseVisualStyleBackColor = False
        '
        'btnNext3
        '
        Me.btnNext3.BackColor = System.Drawing.Color.DimGray
        Me.btnNext3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNext3.Enabled = False
        Me.btnNext3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnNext3.ForeColor = System.Drawing.Color.White
        Me.btnNext3.Image = CType(resources.GetObject("btnNext3.Image"), System.Drawing.Image)
        Me.btnNext3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNext3.Location = New System.Drawing.Point(273, 153)
        Me.btnNext3.Name = "btnNext3"
        Me.btnNext3.Size = New System.Drawing.Size(24, 23)
        Me.btnNext3.TabIndex = 434
        Me.btnNext3.UseVisualStyleBackColor = False
        '
        'Lv1
        '
        Me.Lv1.LargeImageList = Me.Img1
        Me.Lv1.Location = New System.Drawing.Point(339, 176)
        Me.Lv1.MultiSelect = False
        Me.Lv1.Name = "Lv1"
        Me.Lv1.Size = New System.Drawing.Size(307, 390)
        Me.Lv1.TabIndex = 438
        Me.Lv1.UseCompatibleStateImageBehavior = False
        '
        'lbTotalPic1
        '
        Me.lbTotalPic1.AutoSize = True
        Me.lbTotalPic1.BackColor = System.Drawing.Color.RoyalBlue
        Me.lbTotalPic1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbTotalPic1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbTotalPic1.Location = New System.Drawing.Point(525, 569)
        Me.lbTotalPic1.Name = "lbTotalPic1"
        Me.lbTotalPic1.Size = New System.Drawing.Size(62, 17)
        Me.lbTotalPic1.TabIndex = 439
        Me.lbTotalPic1.Text = "รูปทั้งหมด"
        '
        'lbTotalPic2
        '
        Me.lbTotalPic2.AutoSize = True
        Me.lbTotalPic2.BackColor = System.Drawing.Color.RoyalBlue
        Me.lbTotalPic2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbTotalPic2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbTotalPic2.Location = New System.Drawing.Point(842, 569)
        Me.lbTotalPic2.Name = "lbTotalPic2"
        Me.lbTotalPic2.Size = New System.Drawing.Size(62, 17)
        Me.lbTotalPic2.TabIndex = 440
        Me.lbTotalPic2.Text = "รูปทั้งหมด"
        '
        'lbTotalPic3
        '
        Me.lbTotalPic3.AutoSize = True
        Me.lbTotalPic3.BackColor = System.Drawing.Color.RoyalBlue
        Me.lbTotalPic3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbTotalPic3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbTotalPic3.Location = New System.Drawing.Point(199, 569)
        Me.lbTotalPic3.Name = "lbTotalPic3"
        Me.lbTotalPic3.Size = New System.Drawing.Size(62, 17)
        Me.lbTotalPic3.TabIndex = 441
        Me.lbTotalPic3.Text = "รูปทั้งหมด"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(23, 154)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 20)
        Me.Label1.TabIndex = 442
        Me.Label1.Text = "รูปเจ้าของ"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(664, 151)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 20)
        Me.Label2.TabIndex = 443
        Me.Label2.Text = "รูปการจัดงาน"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(349, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 20)
        Me.Label3.TabIndex = 444
        Me.Label3.Text = "รูปสถานที่"
        '
        'txtnumPs
        '
        Me.txtnumPs.AutoSize = True
        Me.txtnumPs.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtnumPs.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtnumPs.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtnumPs.Location = New System.Drawing.Point(13, 54)
        Me.txtnumPs.Name = "txtnumPs"
        Me.txtnumPs.Size = New System.Drawing.Size(113, 17)
        Me.txtnumPs.TabIndex = 445
        Me.txtnumPs.Text = "ชื่อพนักงานที่ดูแล : "
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(658, 565)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(307, 25)
        Me.Label4.TabIndex = 605
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(658, 149)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(307, 31)
        Me.Label5.TabIndex = 606
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(339, 149)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(307, 31)
        Me.Label6.TabIndex = 608
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(339, 565)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(307, 25)
        Me.Label7.TabIndex = 607
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(19, 150)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(307, 31)
        Me.Label8.TabIndex = 610
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(19, 565)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(307, 25)
        Me.Label9.TabIndex = 609
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmMkCusPicList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(984, 602)
        Me.Controls.Add(Me.Lv3)
        Me.Controls.Add(Me.Lv1)
        Me.Controls.Add(Me.Lv2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnFirst2)
        Me.Controls.Add(Me.btnLast2)
        Me.Controls.Add(Me.btnBack2)
        Me.Controls.Add(Me.btnNext2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbTotalPic3)
        Me.Controls.Add(Me.btnFirst3)
        Me.Controls.Add(Me.btnLast3)
        Me.Controls.Add(Me.btnBack3)
        Me.Controls.Add(Me.btnNext3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbTotalPic1)
        Me.Controls.Add(Me.btnFirst)
        Me.Controls.Add(Me.btnLast)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lbTotalPic2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtnumPs)
        Me.Controls.Add(Me.txtadd)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView2)
        Me.Name = "frmMkCusPicList"
        Me.Text = "ข้อมูลรูปภาพลูกค้า"
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lv2 As System.Windows.Forms.ListView
    Friend WithEvents Lv3 As System.Windows.Forms.ListView
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Img1 As System.Windows.Forms.ImageList
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtname As System.Windows.Forms.Label
    Friend WithEvents txtadd As System.Windows.Forms.Label
    Friend WithEvents btnFirst As System.Windows.Forms.Button
    Friend WithEvents btnLast As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnFirst2 As System.Windows.Forms.Button
    Friend WithEvents btnLast2 As System.Windows.Forms.Button
    Friend WithEvents btnBack2 As System.Windows.Forms.Button
    Friend WithEvents btnNext2 As System.Windows.Forms.Button
    Friend WithEvents btnFirst3 As System.Windows.Forms.Button
    Friend WithEvents btnLast3 As System.Windows.Forms.Button
    Friend WithEvents btnBack3 As System.Windows.Forms.Button
    Friend WithEvents btnNext3 As System.Windows.Forms.Button
    Friend WithEvents Img2 As System.Windows.Forms.ImageList
    Friend WithEvents Img3 As System.Windows.Forms.ImageList
    Friend WithEvents Lv1 As System.Windows.Forms.ListView
    Friend WithEvents lbTotalPic1 As System.Windows.Forms.Label
    Friend WithEvents lbTotalPic2 As System.Windows.Forms.Label
    Friend WithEvents lbTotalPic3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtnumPs As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
