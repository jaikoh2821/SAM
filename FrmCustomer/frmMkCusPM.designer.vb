<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMkCusPM
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.selectPmType = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Button2 = New System.Windows.Forms.Button
        Me.dgvDataCus2 = New System.Windows.Forms.DataGridView
        Me.txtsname = New System.Windows.Forms.TextBox
        Me.CHKname = New System.Windows.Forms.CheckBox
        Me.dgvDataCus = New System.Windows.Forms.DataGridView
        Me.colautonum = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colCancel = New System.Windows.Forms.DataGridViewImageColumn
        Me.CusName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.idCus = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Address = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.idCusType = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CusType = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btn_save = New System.Windows.Forms.Button
        Me.autonum = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colselect2 = New System.Windows.Forms.DataGridViewImageColumn
        Me.CusName2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Address2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.idCusType2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.idCus2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CusType2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgvDataCus2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDataCus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'selectPmType
        '
        Me.selectPmType.FormattingEnabled = True
        Me.selectPmType.Location = New System.Drawing.Point(177, 29)
        Me.selectPmType.Name = "selectPmType"
        Me.selectPmType.Size = New System.Drawing.Size(197, 21)
        Me.selectPmType.TabIndex = 678
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(41, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 20)
        Me.Label1.TabIndex = 682
        Me.Label1.Text = "เงื่อนไขการชำระเงิน"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.dgvDataCus2)
        Me.Panel2.Controls.Add(Me.txtsname)
        Me.Panel2.Controls.Add(Me.CHKname)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(488, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(496, 484)
        Me.Panel2.TabIndex = 679
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Button2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 86)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(494, 50)
        Me.Panel3.TabIndex = 684
        '
        'Button2
        '
        Me.Button2.AutoSize = True
        Me.Button2.BackColor = System.Drawing.Color.DimGray
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Image = Global.SAM.My.Resources.Resources.Find
        Me.Button2.Location = New System.Drawing.Point(8, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 40)
        Me.Button2.TabIndex = 417
        Me.Button2.Text = "ค้นหา"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = False
        '
        'dgvDataCus2
        '
        Me.dgvDataCus2.AllowUserToAddRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDataCus2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvDataCus2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDataCus2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.autonum, Me.colselect2, Me.CusName2, Me.Address2, Me.idCusType2, Me.idCus2, Me.CusType2})
        Me.dgvDataCus2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvDataCus2.Location = New System.Drawing.Point(0, 136)
        Me.dgvDataCus2.Name = "dgvDataCus2"
        Me.dgvDataCus2.RowHeadersVisible = False
        Me.dgvDataCus2.Size = New System.Drawing.Size(494, 346)
        Me.dgvDataCus2.TabIndex = 683
        '
        'txtsname
        '
        Me.txtsname.Enabled = False
        Me.txtsname.Location = New System.Drawing.Point(196, 26)
        Me.txtsname.Name = "txtsname"
        Me.txtsname.Size = New System.Drawing.Size(197, 20)
        Me.txtsname.TabIndex = 418
        '
        'CHKname
        '
        Me.CHKname.AutoSize = True
        Me.CHKname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.CHKname.Location = New System.Drawing.Point(112, 24)
        Me.CHKname.Name = "CHKname"
        Me.CHKname.Size = New System.Drawing.Size(78, 24)
        Me.CHKname.TabIndex = 417
        Me.CHKname.Text = "ชื่อลูกค้า"
        Me.CHKname.UseVisualStyleBackColor = True
        '
        'dgvDataCus
        '
        Me.dgvDataCus.AllowUserToAddRows = False
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDataCus.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvDataCus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDataCus.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colautonum, Me.colCancel, Me.CusName, Me.idCus, Me.Address, Me.idCusType, Me.CusType})
        Me.dgvDataCus.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvDataCus.Location = New System.Drawing.Point(0, 138)
        Me.dgvDataCus.Name = "dgvDataCus"
        Me.dgvDataCus.RowHeadersVisible = False
        Me.dgvDataCus.Size = New System.Drawing.Size(488, 346)
        Me.dgvDataCus.TabIndex = 683
        '
        'colautonum
        '
        Me.colautonum.HeaderText = "ลำดับ"
        Me.colautonum.Name = "colautonum"
        Me.colautonum.Width = 35
        '
        'colCancel
        '
        Me.colCancel.DataPropertyName = "colimage"
        Me.colCancel.HeaderText = "ยกเลิก"
        Me.colCancel.Name = "colCancel"
        Me.colCancel.Width = 50
        '
        'CusName
        '
        Me.CusName.DataPropertyName = "CusName_"
        Me.CusName.HeaderText = "ชื่อลูกค้า"
        Me.CusName.Name = "CusName"
        Me.CusName.ReadOnly = True
        Me.CusName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.CusName.Width = 179
        '
        'idCus
        '
        Me.idCus.DataPropertyName = "idCus"
        Me.idCus.HeaderText = "idCus"
        Me.idCus.Name = "idCus"
        Me.idCus.Visible = False
        '
        'Address
        '
        Me.Address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Address.DataPropertyName = "Address"
        Me.Address.FillWeight = 150.0!
        Me.Address.HeaderText = "ที่อยู่ลูกค้า"
        Me.Address.Name = "Address"
        Me.Address.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'idCusType
        '
        Me.idCusType.DataPropertyName = "idPM"
        Me.idCusType.HeaderText = "idCusType"
        Me.idCusType.Name = "idCusType"
        Me.idCusType.Visible = False
        '
        'CusType
        '
        Me.CusType.DataPropertyName = "PaymentTerms"
        Me.CusType.HeaderText = "CusType"
        Me.CusType.Name = "CusType"
        Me.CusType.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btn_save)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 88)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(488, 50)
        Me.Panel1.TabIndex = 684
        '
        'btn_save
        '
        Me.btn_save.AutoSize = True
        Me.btn_save.BackColor = System.Drawing.Color.DimGray
        Me.btn_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_save.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_save.ForeColor = System.Drawing.Color.White
        Me.btn_save.Image = Global.SAM.My.Resources.Resources.Save28
        Me.btn_save.Location = New System.Drawing.Point(8, 3)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(112, 40)
        Me.btn_save.TabIndex = 417
        Me.btn_save.Text = "บันทึก"
        Me.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'autonum
        '
        Me.autonum.HeaderText = "ลำดับ"
        Me.autonum.Name = "autonum"
        Me.autonum.Width = 35
        '
        'colselect2
        '
        Me.colselect2.HeaderText = "เลือก"
        Me.colselect2.Image = Global.SAM.My.Resources.Resources.CancelCheck
        Me.colselect2.Name = "colselect2"
        Me.colselect2.Width = 35
        '
        'CusName2
        '
        Me.CusName2.DataPropertyName = "CusName_"
        Me.CusName2.HeaderText = "ชื่อลูกค้า"
        Me.CusName2.Name = "CusName2"
        Me.CusName2.ReadOnly = True
        Me.CusName2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.CusName2.Width = 191
        '
        'Address2
        '
        Me.Address2.DataPropertyName = "Address"
        Me.Address2.HeaderText = "ที่อยู่ลูกค้า"
        Me.Address2.Name = "Address2"
        Me.Address2.ReadOnly = True
        Me.Address2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Address2.Width = 150
        '
        'idCusType2
        '
        Me.idCusType2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.idCusType2.DataPropertyName = "idPM"
        Me.idCusType2.HeaderText = "idCusType"
        Me.idCusType2.Name = "idCusType2"
        Me.idCusType2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.idCusType2.Visible = False
        '
        'idCus2
        '
        Me.idCus2.DataPropertyName = "idCus"
        Me.idCus2.HeaderText = "idCus2"
        Me.idCus2.Name = "idCus2"
        Me.idCus2.Visible = False
        '
        'CusType2
        '
        Me.CusType2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CusType2.DataPropertyName = "PaymentTerms"
        Me.CusType2.HeaderText = "เงื่อนไข"
        Me.CusType2.Name = "CusType2"
        Me.CusType2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'frmMkCusPM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(984, 484)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgvDataCus)
        Me.Controls.Add(Me.selectPmType)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "frmMkCusPM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "กำหนดข้อมูลเงื่อนไขการชำระเงิน"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.dgvDataCus2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDataCus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents selectPmType As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtsname As System.Windows.Forms.TextBox
    Friend WithEvents CHKname As System.Windows.Forms.CheckBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents dgvDataCus2 As System.Windows.Forms.DataGridView
    Friend WithEvents dgvDataCus As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents colautonum As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCancel As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents CusName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idCus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Address As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idCusType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CusType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents autonum As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colselect2 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents CusName2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Address2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idCusType2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idCus2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CusType2 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
