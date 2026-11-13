<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCusBusinessSt
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCusBusinessSt))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.dgvCusBusinessSt = New System.Windows.Forms.DataGridView
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btnSFindAll = New System.Windows.Forms.Button
        Me.txtAddress = New System.Windows.Forms.TextBox
        Me.txtCusName = New System.Windows.Forms.TextBox
        Me.chkAddress = New System.Windows.Forms.CheckBox
        Me.chkCusName = New System.Windows.Forms.CheckBox
        Me.lbCusBuy = New System.Windows.Forms.Label
        Me.lbCusSale = New System.Windows.Forms.Label
        Me.lbCusBoth = New System.Windows.Forms.Label
        Me.rbCusBuy = New System.Windows.Forms.RadioButton
        Me.rbCusSale = New System.Windows.Forms.RadioButton
        Me.rbCusBoth = New System.Windows.Forms.RadioButton
        Me.rbUnknown = New System.Windows.Forms.RadioButton
        Me.lbUnknown = New System.Windows.Forms.Label
        Me.rbTotal = New System.Windows.Forms.RadioButton
        Me.lbTotal = New System.Windows.Forms.Label
        Me.colEdit = New System.Windows.Forms.DataGridViewImageColumn
        Me.colCusName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colAddress = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colPsName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colBuy = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.colSale = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.colNoteCusBusiness = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.idCus = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.stBusinessType = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.dgvCusBusinessSt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvCusBusinessSt
        '
        Me.dgvCusBusinessSt.AllowUserToAddRows = False
        Me.dgvCusBusinessSt.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCusBusinessSt.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCusBusinessSt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCusBusinessSt.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colEdit, Me.colCusName, Me.colAddress, Me.colPsName, Me.colBuy, Me.colSale, Me.colNoteCusBusiness, Me.idCus, Me.stBusinessType})
        Me.dgvCusBusinessSt.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvCusBusinessSt.Location = New System.Drawing.Point(0, 164)
        Me.dgvCusBusinessSt.Name = "dgvCusBusinessSt"
        Me.dgvCusBusinessSt.RowHeadersVisible = False
        Me.dgvCusBusinessSt.Size = New System.Drawing.Size(854, 418)
        Me.dgvCusBusinessSt.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnSFindAll)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 127)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(854, 37)
        Me.Panel2.TabIndex = 423
        '
        'btnSFindAll
        '
        Me.btnSFindAll.BackColor = System.Drawing.Color.DimGray
        Me.btnSFindAll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSFindAll.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnSFindAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnSFindAll.ForeColor = System.Drawing.Color.White
        Me.btnSFindAll.Image = CType(resources.GetObject("btnSFindAll.Image"), System.Drawing.Image)
        Me.btnSFindAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSFindAll.Location = New System.Drawing.Point(0, 0)
        Me.btnSFindAll.Name = "btnSFindAll"
        Me.btnSFindAll.Size = New System.Drawing.Size(115, 35)
        Me.btnSFindAll.TabIndex = 397
        Me.btnSFindAll.Tag = ""
        Me.btnSFindAll.Text = "       แสดงข้อมูล"
        Me.btnSFindAll.UseVisualStyleBackColor = False
        '
        'txtAddress
        '
        Me.txtAddress.Enabled = False
        Me.txtAddress.Location = New System.Drawing.Point(178, 63)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(197, 20)
        Me.txtAddress.TabIndex = 427
        '
        'txtCusName
        '
        Me.txtCusName.Enabled = False
        Me.txtCusName.Location = New System.Drawing.Point(178, 34)
        Me.txtCusName.Name = "txtCusName"
        Me.txtCusName.Size = New System.Drawing.Size(197, 20)
        Me.txtCusName.TabIndex = 426
        '
        'chkAddress
        '
        Me.chkAddress.AutoSize = True
        Me.chkAddress.Location = New System.Drawing.Point(109, 63)
        Me.chkAddress.Name = "chkAddress"
        Me.chkAddress.Size = New System.Drawing.Size(46, 17)
        Me.chkAddress.TabIndex = 425
        Me.chkAddress.Text = "ที่อยู่"
        Me.chkAddress.UseVisualStyleBackColor = True
        '
        'chkCusName
        '
        Me.chkCusName.AutoSize = True
        Me.chkCusName.Location = New System.Drawing.Point(109, 35)
        Me.chkCusName.Name = "chkCusName"
        Me.chkCusName.Size = New System.Drawing.Size(64, 17)
        Me.chkCusName.TabIndex = 424
        Me.chkCusName.Text = "ชื่อลูกค้า"
        Me.chkCusName.UseVisualStyleBackColor = True
        '
        'lbCusBuy
        '
        Me.lbCusBuy.AutoSize = True
        Me.lbCusBuy.ForeColor = System.Drawing.Color.Red
        Me.lbCusBuy.Location = New System.Drawing.Point(610, 9)
        Me.lbCusBuy.Name = "lbCusBuy"
        Me.lbCusBuy.Size = New System.Drawing.Size(40, 13)
        Me.lbCusBuy.TabIndex = 429
        Me.lbCusBuy.Text = "จำนวน"
        '
        'lbCusSale
        '
        Me.lbCusSale.AutoSize = True
        Me.lbCusSale.ForeColor = System.Drawing.Color.Red
        Me.lbCusSale.Location = New System.Drawing.Point(615, 32)
        Me.lbCusSale.Name = "lbCusSale"
        Me.lbCusSale.Size = New System.Drawing.Size(40, 13)
        Me.lbCusSale.TabIndex = 431
        Me.lbCusSale.Text = "จำนวน"
        '
        'lbCusBoth
        '
        Me.lbCusBoth.AutoSize = True
        Me.lbCusBoth.ForeColor = System.Drawing.Color.Red
        Me.lbCusBoth.Location = New System.Drawing.Point(627, 55)
        Me.lbCusBoth.Name = "lbCusBoth"
        Me.lbCusBoth.Size = New System.Drawing.Size(40, 13)
        Me.lbCusBoth.TabIndex = 433
        Me.lbCusBoth.Text = "จำนวน"
        '
        'rbCusBuy
        '
        Me.rbCusBuy.AutoSize = True
        Me.rbCusBuy.Location = New System.Drawing.Point(516, 7)
        Me.rbCusBuy.Name = "rbCusBuy"
        Me.rbCusBuy.Size = New System.Drawing.Size(96, 17)
        Me.rbCusBuy.TabIndex = 434
        Me.rbCusBuy.Text = "เป็นเฉพาะผู้ซื้อ"
        Me.rbCusBuy.UseVisualStyleBackColor = True
        '
        'rbCusSale
        '
        Me.rbCusSale.AutoSize = True
        Me.rbCusSale.Location = New System.Drawing.Point(516, 30)
        Me.rbCusSale.Name = "rbCusSale"
        Me.rbCusSale.Size = New System.Drawing.Size(101, 17)
        Me.rbCusSale.TabIndex = 435
        Me.rbCusSale.Text = "เป็นเฉพาะผู้ขาย"
        Me.rbCusSale.UseVisualStyleBackColor = True
        '
        'rbCusBoth
        '
        Me.rbCusBoth.AutoSize = True
        Me.rbCusBoth.Location = New System.Drawing.Point(516, 53)
        Me.rbCusBoth.Name = "rbCusBoth"
        Me.rbCusBoth.Size = New System.Drawing.Size(114, 17)
        Me.rbCusBoth.TabIndex = 436
        Me.rbCusBoth.Text = "เป็นทั้งผู้ซื้อและขาย"
        Me.rbCusBoth.UseVisualStyleBackColor = True
        '
        'rbUnknown
        '
        Me.rbUnknown.AutoSize = True
        Me.rbUnknown.Location = New System.Drawing.Point(516, 76)
        Me.rbUnknown.Name = "rbUnknown"
        Me.rbUnknown.Size = New System.Drawing.Size(81, 17)
        Me.rbUnknown.TabIndex = 437
        Me.rbUnknown.Text = "ยังไม่ได้ระบุ"
        Me.rbUnknown.UseVisualStyleBackColor = True
        '
        'lbUnknown
        '
        Me.lbUnknown.AutoSize = True
        Me.lbUnknown.ForeColor = System.Drawing.Color.Red
        Me.lbUnknown.Location = New System.Drawing.Point(596, 78)
        Me.lbUnknown.Name = "lbUnknown"
        Me.lbUnknown.Size = New System.Drawing.Size(40, 13)
        Me.lbUnknown.TabIndex = 438
        Me.lbUnknown.Text = "จำนวน"
        '
        'rbTotal
        '
        Me.rbTotal.AutoSize = True
        Me.rbTotal.Checked = True
        Me.rbTotal.Location = New System.Drawing.Point(516, 99)
        Me.rbTotal.Name = "rbTotal"
        Me.rbTotal.Size = New System.Drawing.Size(58, 17)
        Me.rbTotal.TabIndex = 439
        Me.rbTotal.TabStop = True
        Me.rbTotal.Text = "ทั้งหมด"
        Me.rbTotal.UseVisualStyleBackColor = True
        '
        'lbTotal
        '
        Me.lbTotal.AutoSize = True
        Me.lbTotal.ForeColor = System.Drawing.Color.Red
        Me.lbTotal.Location = New System.Drawing.Point(572, 101)
        Me.lbTotal.Name = "lbTotal"
        Me.lbTotal.Size = New System.Drawing.Size(40, 13)
        Me.lbTotal.TabIndex = 440
        Me.lbTotal.Text = "จำนวน"
        '
        'colEdit
        '
        Me.colEdit.HeaderText = "แก้ไข"
        Me.colEdit.Image = Global.SAM.My.Resources.Resources.gdEdit
        Me.colEdit.Name = "colEdit"
        Me.colEdit.Width = 50
        '
        'colCusName
        '
        Me.colCusName.DataPropertyName = "CusName_"
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.colCusName.DefaultCellStyle = DataGridViewCellStyle2
        Me.colCusName.HeaderText = "ชื่อลูกค้า"
        Me.colCusName.Name = "colCusName"
        Me.colCusName.ReadOnly = True
        Me.colCusName.Width = 150
        '
        'colAddress
        '
        Me.colAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colAddress.DataPropertyName = "Address"
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.colAddress.DefaultCellStyle = DataGridViewCellStyle3
        Me.colAddress.HeaderText = "ที่อยู่"
        Me.colAddress.Name = "colAddress"
        Me.colAddress.ReadOnly = True
        '
        'colPsName
        '
        Me.colPsName.DataPropertyName = "PsName"
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.colPsName.DefaultCellStyle = DataGridViewCellStyle4
        Me.colPsName.HeaderText = "เจ้าหน้าที่ขายที่ดูแล"
        Me.colPsName.Name = "colPsName"
        Me.colPsName.Width = 120
        '
        'colBuy
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle5.NullValue = False
        Me.colBuy.DefaultCellStyle = DataGridViewCellStyle5
        Me.colBuy.HeaderText = "เป็นผู้ซื้อ"
        Me.colBuy.Name = "colBuy"
        Me.colBuy.ReadOnly = True
        Me.colBuy.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colBuy.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colBuy.Width = 80
        '
        'colSale
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle6.NullValue = False
        Me.colSale.DefaultCellStyle = DataGridViewCellStyle6
        Me.colSale.HeaderText = "เป็นผู้ขาย"
        Me.colSale.Name = "colSale"
        Me.colSale.ReadOnly = True
        Me.colSale.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colSale.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colSale.Width = 80
        '
        'colNoteCusBusiness
        '
        Me.colNoteCusBusiness.DataPropertyName = "NoteCusBusiness"
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.colNoteCusBusiness.DefaultCellStyle = DataGridViewCellStyle7
        Me.colNoteCusBusiness.HeaderText = "หมายเหตุ"
        Me.colNoteCusBusiness.Name = "colNoteCusBusiness"
        Me.colNoteCusBusiness.ReadOnly = True
        Me.colNoteCusBusiness.Width = 150
        '
        'idCus
        '
        Me.idCus.DataPropertyName = "idCus"
        Me.idCus.HeaderText = "idCus"
        Me.idCus.Name = "idCus"
        Me.idCus.Visible = False
        '
        'stBusinessType
        '
        Me.stBusinessType.DataPropertyName = "stBusinessType"
        Me.stBusinessType.HeaderText = "stBusinessType"
        Me.stBusinessType.Name = "stBusinessType"
        Me.stBusinessType.Visible = False
        '
        'frmCusBusinessSt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(854, 582)
        Me.Controls.Add(Me.lbTotal)
        Me.Controls.Add(Me.rbTotal)
        Me.Controls.Add(Me.lbUnknown)
        Me.Controls.Add(Me.rbUnknown)
        Me.Controls.Add(Me.rbCusBoth)
        Me.Controls.Add(Me.rbCusSale)
        Me.Controls.Add(Me.rbCusBuy)
        Me.Controls.Add(Me.lbCusBoth)
        Me.Controls.Add(Me.lbCusSale)
        Me.Controls.Add(Me.lbCusBuy)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtCusName)
        Me.Controls.Add(Me.chkAddress)
        Me.Controls.Add(Me.chkCusName)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.dgvCusBusinessSt)
        Me.MaximizeBox = False
        Me.Name = "frmCusBusinessSt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "สถานะการซื้อขายของคู่ค้า"
        CType(Me.dgvCusBusinessSt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvCusBusinessSt As System.Windows.Forms.DataGridView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnSFindAll As System.Windows.Forms.Button
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtCusName As System.Windows.Forms.TextBox
    Friend WithEvents chkAddress As System.Windows.Forms.CheckBox
    Friend WithEvents chkCusName As System.Windows.Forms.CheckBox
    Friend WithEvents lbCusBuy As System.Windows.Forms.Label
    Friend WithEvents lbCusSale As System.Windows.Forms.Label
    Friend WithEvents lbCusBoth As System.Windows.Forms.Label
    Friend WithEvents rbCusBuy As System.Windows.Forms.RadioButton
    Friend WithEvents rbCusSale As System.Windows.Forms.RadioButton
    Friend WithEvents rbCusBoth As System.Windows.Forms.RadioButton
    Friend WithEvents rbUnknown As System.Windows.Forms.RadioButton
    Friend WithEvents lbUnknown As System.Windows.Forms.Label
    Friend WithEvents rbTotal As System.Windows.Forms.RadioButton
    Friend WithEvents lbTotal As System.Windows.Forms.Label
    Friend WithEvents colEdit As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents colCusName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAddress As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPsName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colBuy As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents colSale As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents colNoteCusBusiness As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idCus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents stBusinessType As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
