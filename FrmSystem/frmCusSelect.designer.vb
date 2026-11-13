<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCusSelect
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCusSelect))
        Me.dgvCus = New System.Windows.Forms.DataGridView
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btnAdd = New System.Windows.Forms.Button
        Me.btnSFindAll = New System.Windows.Forms.Button
        Me.txtAddress = New System.Windows.Forms.TextBox
        Me.txtCusName = New System.Windows.Forms.TextBox
        Me.chkAddress = New System.Windows.Forms.CheckBox
        Me.chkCusName = New System.Windows.Forms.CheckBox
        Me.colCheck = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.colCusName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colAddress = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.idCus = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.dgvCus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvCus
        '
        Me.dgvCus.AllowUserToAddRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCus.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCus.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colCheck, Me.colCusName, Me.colAddress, Me.idCus})
        Me.dgvCus.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvCus.Location = New System.Drawing.Point(0, 115)
        Me.dgvCus.Name = "dgvCus"
        Me.dgvCus.RowHeadersVisible = False
        Me.dgvCus.Size = New System.Drawing.Size(511, 369)
        Me.dgvCus.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnAdd)
        Me.Panel2.Controls.Add(Me.btnSFindAll)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 78)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(511, 37)
        Me.Panel2.TabIndex = 398
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.DimGray
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdd.Location = New System.Drawing.Point(116, 0)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(81, 37)
        Me.btnAdd.TabIndex = 398
        Me.btnAdd.Text = "ตกลง"
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAdd.UseVisualStyleBackColor = False
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
        Me.txtAddress.Location = New System.Drawing.Point(177, 43)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(197, 20)
        Me.txtAddress.TabIndex = 431
        '
        'txtCusName
        '
        Me.txtCusName.Enabled = False
        Me.txtCusName.Location = New System.Drawing.Point(177, 14)
        Me.txtCusName.Name = "txtCusName"
        Me.txtCusName.Size = New System.Drawing.Size(197, 20)
        Me.txtCusName.TabIndex = 430
        '
        'chkAddress
        '
        Me.chkAddress.AutoSize = True
        Me.chkAddress.Location = New System.Drawing.Point(108, 43)
        Me.chkAddress.Name = "chkAddress"
        Me.chkAddress.Size = New System.Drawing.Size(46, 17)
        Me.chkAddress.TabIndex = 429
        Me.chkAddress.Text = "ที่อยู่"
        Me.chkAddress.UseVisualStyleBackColor = True
        '
        'chkCusName
        '
        Me.chkCusName.AutoSize = True
        Me.chkCusName.Location = New System.Drawing.Point(108, 15)
        Me.chkCusName.Name = "chkCusName"
        Me.chkCusName.Size = New System.Drawing.Size(64, 17)
        Me.chkCusName.TabIndex = 428
        Me.chkCusName.Text = "ชื่อลูกค้า"
        Me.chkCusName.UseVisualStyleBackColor = True
        '
        'colCheck
        '
        Me.colCheck.HeaderText = "เลือก"
        Me.colCheck.Name = "colCheck"
        Me.colCheck.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colCheck.Width = 40
        '
        'colCusName
        '
        Me.colCusName.DataPropertyName = "CusName_"
        Me.colCusName.HeaderText = "ชื่อลูกค้า"
        Me.colCusName.Name = "colCusName"
        Me.colCusName.Width = 200
        '
        'colAddress
        '
        Me.colAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colAddress.DataPropertyName = "Address"
        Me.colAddress.HeaderText = "ที่อยู่"
        Me.colAddress.Name = "colAddress"
        '
        'idCus
        '
        Me.idCus.DataPropertyName = "idCus"
        Me.idCus.HeaderText = "idCus"
        Me.idCus.Name = "idCus"
        Me.idCus.Visible = False
        '
        'frmCusSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(511, 484)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtCusName)
        Me.Controls.Add(Me.chkAddress)
        Me.Controls.Add(Me.chkCusName)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.dgvCus)
        Me.MaximizeBox = False
        Me.Name = "frmCusSelect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "เลือกชื่อคู่ค้า"
        CType(Me.dgvCus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvCus As System.Windows.Forms.DataGridView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnSFindAll As System.Windows.Forms.Button
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtCusName As System.Windows.Forms.TextBox
    Friend WithEvents chkAddress As System.Windows.Forms.CheckBox
    Friend WithEvents chkCusName As System.Windows.Forms.CheckBox
    Friend WithEvents colCheck As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents colCusName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAddress As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idCus As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
