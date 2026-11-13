<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMkCusPicSet
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMkCusPicSet))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lbtotal = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.txtadd = New System.Windows.Forms.TextBox
        Me.AddcusCheck = New System.Windows.Forms.CheckBox
        Me.txtsname = New System.Windows.Forms.TextBox
        Me.CHKname = New System.Windows.Forms.CheckBox
        Me.dgvDataCus = New System.Windows.Forms.DataGridView
        Me.colautonum = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colselect = New System.Windows.Forms.DataGridViewImageColumn
        Me.colCusName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colAddCus = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.idCus = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colPicOwner = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colPicLocation = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colPicEvent = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.numPs = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn
        Me.CHKOwnPic = New System.Windows.Forms.CheckBox
        Me.CHKLocation = New System.Windows.Forms.CheckBox
        Me.CHKEventPic = New System.Windows.Forms.CheckBox
        Me.lbOwn = New System.Windows.Forms.Label
        Me.lbLocation = New System.Windows.Forms.Label
        Me.lbEvent = New System.Windows.Forms.Label
        Me.DataGridView2 = New System.Windows.Forms.DataGridView
        Me.Panel1.SuspendLayout()
        CType(Me.dgvDataCus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lbtotal)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 106)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(984, 50)
        Me.Panel1.TabIndex = 422
        '
        'lbtotal
        '
        Me.lbtotal.AutoSize = True
        Me.lbtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbtotal.ForeColor = System.Drawing.Color.Crimson
        Me.lbtotal.Location = New System.Drawing.Point(768, 17)
        Me.lbtotal.Name = "lbtotal"
        Me.lbtotal.Size = New System.Drawing.Size(92, 17)
        Me.lbtotal.TabIndex = 429
        Me.lbtotal.Text = "รายการทั้งหมด "
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.BackColor = System.Drawing.Color.DimGray
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(11, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 40)
        Me.Button1.TabIndex = 400
        Me.Button1.Text = "แสดงข้อมูล"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtadd
        '
        Me.txtadd.Enabled = False
        Me.txtadd.Location = New System.Drawing.Point(407, 53)
        Me.txtadd.Name = "txtadd"
        Me.txtadd.Size = New System.Drawing.Size(197, 20)
        Me.txtadd.TabIndex = 420
        '
        'AddcusCheck
        '
        Me.AddcusCheck.AutoSize = True
        Me.AddcusCheck.Location = New System.Drawing.Point(327, 56)
        Me.AddcusCheck.Name = "AddcusCheck"
        Me.AddcusCheck.Size = New System.Drawing.Size(71, 17)
        Me.AddcusCheck.TabIndex = 419
        Me.AddcusCheck.Text = "ที่อยู่ลูกค้า"
        Me.AddcusCheck.UseVisualStyleBackColor = True
        '
        'txtsname
        '
        Me.txtsname.Enabled = False
        Me.txtsname.Location = New System.Drawing.Point(407, 27)
        Me.txtsname.Name = "txtsname"
        Me.txtsname.Size = New System.Drawing.Size(197, 20)
        Me.txtsname.TabIndex = 418
        '
        'CHKname
        '
        Me.CHKname.AutoSize = True
        Me.CHKname.Location = New System.Drawing.Point(327, 30)
        Me.CHKname.Name = "CHKname"
        Me.CHKname.Size = New System.Drawing.Size(64, 17)
        Me.CHKname.TabIndex = 417
        Me.CHKname.Text = "ชื่อลูกค้า"
        Me.CHKname.UseVisualStyleBackColor = True
        '
        'dgvDataCus
        '
        Me.dgvDataCus.AllowUserToAddRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDataCus.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvDataCus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDataCus.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colautonum, Me.colselect, Me.colCusName, Me.colAddCus, Me.idCus, Me.colPicOwner, Me.colPicLocation, Me.colPicEvent, Me.numPs})
        Me.dgvDataCus.Location = New System.Drawing.Point(0, 155)
        Me.dgvDataCus.Name = "dgvDataCus"
        Me.dgvDataCus.RowHeadersVisible = False
        Me.dgvDataCus.Size = New System.Drawing.Size(984, 447)
        Me.dgvDataCus.TabIndex = 420
        '
        'colautonum
        '
        Me.colautonum.DataPropertyName = "colautonum"
        Me.colautonum.HeaderText = "ลำดับ"
        Me.colautonum.Name = "colautonum"
        Me.colautonum.Width = 35
        '
        'colselect
        '
        Me.colselect.HeaderText = "เลือก"
        Me.colselect.Image = Global.SAM.My.Resources.Resources.CamearSelect
        Me.colselect.Name = "colselect"
        Me.colselect.Width = 35
        '
        'colCusName
        '
        Me.colCusName.DataPropertyName = "CusName"
        Me.colCusName.HeaderText = "ชื่อลูกค้า"
        Me.colCusName.Name = "colCusName"
        Me.colCusName.ReadOnly = True
        Me.colCusName.Width = 150
        '
        'colAddCus
        '
        Me.colAddCus.DataPropertyName = "Address"
        Me.colAddCus.FillWeight = 74.07407!
        Me.colAddCus.HeaderText = "ที่อยู่ลูกค้า"
        Me.colAddCus.Name = "colAddCus"
        Me.colAddCus.ReadOnly = True
        Me.colAddCus.Width = 230
        '
        'idCus
        '
        Me.idCus.DataPropertyName = "idCus"
        Me.idCus.HeaderText = "idCus2"
        Me.idCus.Name = "idCus"
        Me.idCus.Visible = False
        '
        'colPicOwner
        '
        Me.colPicOwner.DataPropertyName = "colPicOwner"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colPicOwner.DefaultCellStyle = DataGridViewCellStyle2
        Me.colPicOwner.FillWeight = 74.07407!
        Me.colPicOwner.HeaderText = "จำนวนรูปเจ้าของ"
        Me.colPicOwner.Name = "colPicOwner"
        Me.colPicOwner.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colPicOwner.Width = 110
        '
        'colPicLocation
        '
        Me.colPicLocation.DataPropertyName = "colPicLocation"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colPicLocation.DefaultCellStyle = DataGridViewCellStyle3
        Me.colPicLocation.FillWeight = 177.7778!
        Me.colPicLocation.HeaderText = "จำนวนรูปสถานที่"
        Me.colPicLocation.Name = "colPicLocation"
        Me.colPicLocation.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colPicLocation.Width = 110
        '
        'colPicEvent
        '
        Me.colPicEvent.DataPropertyName = "colPicEvent"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colPicEvent.DefaultCellStyle = DataGridViewCellStyle4
        Me.colPicEvent.FillWeight = 74.07407!
        Me.colPicEvent.HeaderText = "จำนวนรูปการจัดงาน"
        Me.colPicEvent.Name = "colPicEvent"
        Me.colPicEvent.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colPicEvent.Width = 125
        '
        'numPs
        '
        Me.numPs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.numPs.DataPropertyName = "CusPsName"
        Me.numPs.HeaderText = "ชื่อพนักงานที่ดูแล"
        Me.numPs.Name = "numPs"
        Me.numPs.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = "เลือก"
        Me.DataGridViewImageColumn1.Image = Global.SAM.My.Resources.Resources.FindItemInGrid
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Width = 35
        '
        'CHKOwnPic
        '
        Me.CHKOwnPic.AutoSize = True
        Me.CHKOwnPic.Location = New System.Drawing.Point(623, 20)
        Me.CHKOwnPic.Name = "CHKOwnPic"
        Me.CHKOwnPic.Size = New System.Drawing.Size(124, 17)
        Me.CHKOwnPic.TabIndex = 423
        Me.CHKOwnPic.Text = "ลูกค้าที่ไม่มีรูปเจ้าของ"
        Me.CHKOwnPic.UseVisualStyleBackColor = True
        '
        'CHKLocation
        '
        Me.CHKLocation.AutoSize = True
        Me.CHKLocation.Location = New System.Drawing.Point(623, 43)
        Me.CHKLocation.Name = "CHKLocation"
        Me.CHKLocation.Size = New System.Drawing.Size(124, 17)
        Me.CHKLocation.TabIndex = 424
        Me.CHKLocation.Text = "ลูกค้าที่ไม่มีรูปสถานที่"
        Me.CHKLocation.UseVisualStyleBackColor = True
        '
        'CHKEventPic
        '
        Me.CHKEventPic.AutoSize = True
        Me.CHKEventPic.Location = New System.Drawing.Point(623, 66)
        Me.CHKEventPic.Name = "CHKEventPic"
        Me.CHKEventPic.Size = New System.Drawing.Size(140, 17)
        Me.CHKEventPic.TabIndex = 425
        Me.CHKEventPic.Text = "ลูกค้าที่ไม่มีรูปการจัดงาน"
        Me.CHKEventPic.UseVisualStyleBackColor = True
        '
        'lbOwn
        '
        Me.lbOwn.AutoSize = True
        Me.lbOwn.ForeColor = System.Drawing.Color.Crimson
        Me.lbOwn.Location = New System.Drawing.Point(753, 21)
        Me.lbOwn.Name = "lbOwn"
        Me.lbOwn.Size = New System.Drawing.Size(73, 13)
        Me.lbOwn.TabIndex = 426
        Me.lbOwn.Text = "ยังไม่ได้อนุมัติ"
        '
        'lbLocation
        '
        Me.lbLocation.AutoSize = True
        Me.lbLocation.ForeColor = System.Drawing.Color.Crimson
        Me.lbLocation.Location = New System.Drawing.Point(753, 44)
        Me.lbLocation.Name = "lbLocation"
        Me.lbLocation.Size = New System.Drawing.Size(73, 13)
        Me.lbLocation.TabIndex = 427
        Me.lbLocation.Text = "ยังไม่ได้อนุมัติ"
        '
        'lbEvent
        '
        Me.lbEvent.AutoSize = True
        Me.lbEvent.ForeColor = System.Drawing.Color.Crimson
        Me.lbEvent.Location = New System.Drawing.Point(769, 67)
        Me.lbEvent.Name = "lbEvent"
        Me.lbEvent.Size = New System.Drawing.Size(73, 13)
        Me.lbEvent.TabIndex = 428
        Me.lbEvent.Text = "ยังไม่ได้อนุมัติ"
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView2.Location = New System.Drawing.Point(0, 156)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.Size = New System.Drawing.Size(984, 446)
        Me.DataGridView2.TabIndex = 421
        '
        'frmMkCusPicSet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(984, 602)
        Me.Controls.Add(Me.lbEvent)
        Me.Controls.Add(Me.lbLocation)
        Me.Controls.Add(Me.lbOwn)
        Me.Controls.Add(Me.CHKEventPic)
        Me.Controls.Add(Me.CHKLocation)
        Me.Controls.Add(Me.CHKOwnPic)
        Me.Controls.Add(Me.txtadd)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.AddcusCheck)
        Me.Controls.Add(Me.dgvDataCus)
        Me.Controls.Add(Me.txtsname)
        Me.Controls.Add(Me.CHKname)
        Me.Controls.Add(Me.DataGridView2)
        Me.Name = "frmMkCusPicSet"
        Me.Text = "ข้อมูลรูปภาพลูกค้า"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvDataCus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtadd As System.Windows.Forms.TextBox
    Friend WithEvents AddcusCheck As System.Windows.Forms.CheckBox
    Friend WithEvents txtsname As System.Windows.Forms.TextBox
    Friend WithEvents CHKname As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents dgvDataCus As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents CHKOwnPic As System.Windows.Forms.CheckBox
    Friend WithEvents CHKLocation As System.Windows.Forms.CheckBox
    Friend WithEvents CHKEventPic As System.Windows.Forms.CheckBox
    Friend WithEvents lbOwn As System.Windows.Forms.Label
    Friend WithEvents lbLocation As System.Windows.Forms.Label
    Friend WithEvents lbEvent As System.Windows.Forms.Label
    Friend WithEvents colautonum As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colselect As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents colCusName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAddCus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idCus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPicOwner As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPicLocation As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPicEvent As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents numPs As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lbtotal As System.Windows.Forms.Label
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
End Class
