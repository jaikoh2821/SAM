<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCusMapSet
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCusMapSet))
        Me.dgvCusMapSet = New System.Windows.Forms.DataGridView
        Me.colEdit = New System.Windows.Forms.DataGridViewImageColumn
        Me.colCusName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colAddress = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colPsName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colLatitude = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colLongitude = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.idCus = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.txtAddress = New System.Windows.Forms.TextBox
        Me.txtCusName = New System.Windows.Forms.TextBox
        Me.chkAddress = New System.Windows.Forms.CheckBox
        Me.chkCusName = New System.Windows.Forms.CheckBox
        Me.chkPsName = New System.Windows.Forms.CheckBox
        Me.txtPsName = New System.Windows.Forms.TextBox
        Me.chkNoMapSet = New System.Windows.Forms.CheckBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btnSFindAll = New System.Windows.Forms.Button
        Me.lbNoMapSet = New System.Windows.Forms.Label
        CType(Me.dgvCusMapSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvCusMapSet
        '
        Me.dgvCusMapSet.AllowUserToAddRows = False
        Me.dgvCusMapSet.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCusMapSet.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCusMapSet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCusMapSet.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colEdit, Me.colCusName, Me.colAddress, Me.colPsName, Me.colLatitude, Me.colLongitude, Me.idCus})
        Me.dgvCusMapSet.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvCusMapSet.Location = New System.Drawing.Point(0, 117)
        Me.dgvCusMapSet.Name = "dgvCusMapSet"
        Me.dgvCusMapSet.RowHeadersVisible = False
        Me.dgvCusMapSet.Size = New System.Drawing.Size(764, 465)
        Me.dgvCusMapSet.TabIndex = 1
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
        Me.colCusName.DataPropertyName = "CusName"
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
        Me.colPsName.ReadOnly = True
        Me.colPsName.Width = 120
        '
        'colLatitude
        '
        Me.colLatitude.DataPropertyName = "Latitude"
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.colLatitude.DefaultCellStyle = DataGridViewCellStyle5
        Me.colLatitude.HeaderText = "Latitude"
        Me.colLatitude.Name = "colLatitude"
        Me.colLatitude.ReadOnly = True
        Me.colLatitude.Width = 110
        '
        'colLongitude
        '
        Me.colLongitude.DataPropertyName = "Longitude"
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.colLongitude.DefaultCellStyle = DataGridViewCellStyle6
        Me.colLongitude.HeaderText = "Longitude"
        Me.colLongitude.Name = "colLongitude"
        Me.colLongitude.ReadOnly = True
        Me.colLongitude.Width = 110
        '
        'idCus
        '
        Me.idCus.DataPropertyName = "idCus"
        Me.idCus.HeaderText = "idCus"
        Me.idCus.Name = "idCus"
        Me.idCus.Visible = False
        '
        'txtAddress
        '
        Me.txtAddress.Enabled = False
        Me.txtAddress.Location = New System.Drawing.Point(121, 45)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(197, 20)
        Me.txtAddress.TabIndex = 418
        '
        'txtCusName
        '
        Me.txtCusName.Enabled = False
        Me.txtCusName.Location = New System.Drawing.Point(121, 16)
        Me.txtCusName.Name = "txtCusName"
        Me.txtCusName.Size = New System.Drawing.Size(197, 20)
        Me.txtCusName.TabIndex = 417
        '
        'chkAddress
        '
        Me.chkAddress.AutoSize = True
        Me.chkAddress.Location = New System.Drawing.Point(52, 45)
        Me.chkAddress.Name = "chkAddress"
        Me.chkAddress.Size = New System.Drawing.Size(46, 17)
        Me.chkAddress.TabIndex = 416
        Me.chkAddress.Text = "ที่อยู่"
        Me.chkAddress.UseVisualStyleBackColor = True
        '
        'chkCusName
        '
        Me.chkCusName.AutoSize = True
        Me.chkCusName.Location = New System.Drawing.Point(52, 17)
        Me.chkCusName.Name = "chkCusName"
        Me.chkCusName.Size = New System.Drawing.Size(64, 17)
        Me.chkCusName.TabIndex = 415
        Me.chkCusName.Text = "ชื่อลูกค้า"
        Me.chkCusName.UseVisualStyleBackColor = True
        '
        'chkPsName
        '
        Me.chkPsName.AutoSize = True
        Me.chkPsName.Location = New System.Drawing.Point(375, 17)
        Me.chkPsName.Name = "chkPsName"
        Me.chkPsName.Size = New System.Drawing.Size(115, 17)
        Me.chkPsName.TabIndex = 419
        Me.chkPsName.Text = "เจ้าหน้าที่ขายที่ดูแล"
        Me.chkPsName.UseVisualStyleBackColor = True
        '
        'txtPsName
        '
        Me.txtPsName.Enabled = False
        Me.txtPsName.Location = New System.Drawing.Point(496, 17)
        Me.txtPsName.Name = "txtPsName"
        Me.txtPsName.Size = New System.Drawing.Size(197, 20)
        Me.txtPsName.TabIndex = 420
        '
        'chkNoMapSet
        '
        Me.chkNoMapSet.AutoSize = True
        Me.chkNoMapSet.Location = New System.Drawing.Point(375, 48)
        Me.chkNoMapSet.Name = "chkNoMapSet"
        Me.chkNoMapSet.Size = New System.Drawing.Size(152, 17)
        Me.chkNoMapSet.TabIndex = 421
        Me.chkNoMapSet.Text = "ลูกค้าที่ยังไม่มีตำแหน่งพิกัด"
        Me.chkNoMapSet.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnSFindAll)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 80)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(764, 37)
        Me.Panel2.TabIndex = 422
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
        'lbNoMapSet
        '
        Me.lbNoMapSet.AutoSize = True
        Me.lbNoMapSet.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbNoMapSet.ForeColor = System.Drawing.Color.Red
        Me.lbNoMapSet.Location = New System.Drawing.Point(526, 47)
        Me.lbNoMapSet.Name = "lbNoMapSet"
        Me.lbNoMapSet.Size = New System.Drawing.Size(45, 15)
        Me.lbNoMapSet.TabIndex = 423
        Me.lbNoMapSet.Text = "จำนวน"
        '
        'frmCusMapSet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(764, 582)
        Me.Controls.Add(Me.lbNoMapSet)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.chkNoMapSet)
        Me.Controls.Add(Me.txtPsName)
        Me.Controls.Add(Me.chkPsName)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtCusName)
        Me.Controls.Add(Me.chkAddress)
        Me.Controls.Add(Me.chkCusName)
        Me.Controls.Add(Me.dgvCusMapSet)
        Me.Name = "frmCusMapSet"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "กำหนดตำแหน่งพิกัดคู่ค้าในแผนที่"
        CType(Me.dgvCusMapSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvCusMapSet As System.Windows.Forms.DataGridView
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtCusName As System.Windows.Forms.TextBox
    Friend WithEvents chkAddress As System.Windows.Forms.CheckBox
    Friend WithEvents chkCusName As System.Windows.Forms.CheckBox
    Friend WithEvents chkPsName As System.Windows.Forms.CheckBox
    Friend WithEvents txtPsName As System.Windows.Forms.TextBox
    Friend WithEvents chkNoMapSet As System.Windows.Forms.CheckBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnSFindAll As System.Windows.Forms.Button
    Friend WithEvents lbNoMapSet As System.Windows.Forms.Label
    Friend WithEvents colEdit As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents colCusName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAddress As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPsName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colLatitude As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colLongitude As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idCus As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
