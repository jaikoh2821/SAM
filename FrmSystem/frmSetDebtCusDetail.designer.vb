<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSetDebtCusDetail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSetDebtCusDetail))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btn_save = New System.Windows.Forms.Button
        Me.btPkSelect2 = New System.Windows.Forms.Button
        Me.dgvDebtCus = New System.Windows.Forms.DataGridView
        Me.Label1 = New System.Windows.Forms.Label
        Me.colCusName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colDebt = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colDel = New System.Windows.Forms.DataGridViewImageColumn
        Me.idCus = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.status = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Panel2.SuspendLayout()
        CType(Me.dgvDebtCus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btn_save)
        Me.Panel2.Controls.Add(Me.btPkSelect2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 327)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(497, 38)
        Me.Panel2.TabIndex = 401
        '
        'btn_save
        '
        Me.btn_save.AutoSize = True
        Me.btn_save.BackColor = System.Drawing.Color.DimGray
        Me.btn_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_save.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_save.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_save.ForeColor = System.Drawing.Color.White
        Me.btn_save.Image = Global.SAM.My.Resources.Resources.Save28
        Me.btn_save.Location = New System.Drawing.Point(120, 0)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(96, 36)
        Me.btn_save.TabIndex = 11
        Me.btn_save.Text = "บันทึก"
        Me.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'btPkSelect2
        '
        Me.btPkSelect2.AutoSize = True
        Me.btPkSelect2.BackColor = System.Drawing.Color.DimGray
        Me.btPkSelect2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btPkSelect2.Dock = System.Windows.Forms.DockStyle.Left
        Me.btPkSelect2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btPkSelect2.ForeColor = System.Drawing.Color.White
        Me.btPkSelect2.Image = CType(resources.GetObject("btPkSelect2.Image"), System.Drawing.Image)
        Me.btPkSelect2.Location = New System.Drawing.Point(0, 0)
        Me.btPkSelect2.Name = "btPkSelect2"
        Me.btPkSelect2.Size = New System.Drawing.Size(120, 36)
        Me.btPkSelect2.TabIndex = 12
        Me.btPkSelect2.Text = "เลือกชื่อคู่ค้า"
        Me.btPkSelect2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btPkSelect2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btPkSelect2.UseVisualStyleBackColor = False
        '
        'dgvDebtCus
        '
        Me.dgvDebtCus.AllowUserToAddRows = False
        Me.dgvDebtCus.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDebtCus.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvDebtCus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDebtCus.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colCusName, Me.colDebt, Me.colDel, Me.idCus, Me.status})
        Me.dgvDebtCus.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvDebtCus.Location = New System.Drawing.Point(0, 73)
        Me.dgvDebtCus.Name = "dgvDebtCus"
        Me.dgvDebtCus.RowHeadersVisible = False
        Me.dgvDebtCus.Size = New System.Drawing.Size(497, 254)
        Me.dgvDebtCus.TabIndex = 624
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 625
        Me.Label1.Text = "Label1"
        '
        'colCusName
        '
        Me.colCusName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colCusName.DataPropertyName = "CusName_"
        Me.colCusName.HeaderText = "ชื่อคู่ค้า"
        Me.colCusName.Name = "colCusName"
        Me.colCusName.ReadOnly = True
        '
        'colDebt
        '
        Me.colDebt.DataPropertyName = "Debt"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.colDebt.DefaultCellStyle = DataGridViewCellStyle2
        Me.colDebt.HeaderText = "ระบุยอดหนี้ค้าง"
        Me.colDebt.Name = "colDebt"
        Me.colDebt.Width = 120
        '
        'colDel
        '
        Me.colDel.HeaderText = "ลบ"
        Me.colDel.Image = Global.SAM.My.Resources.Resources.ImgNotprocess
        Me.colDel.Name = "colDel"
        Me.colDel.Width = 50
        '
        'idCus
        '
        Me.idCus.DataPropertyName = "idCus"
        Me.idCus.HeaderText = "idCus"
        Me.idCus.Name = "idCus"
        Me.idCus.Visible = False
        '
        'status
        '
        Me.status.DataPropertyName = "status"
        Me.status.HeaderText = "status"
        Me.status.Name = "status"
        Me.status.Visible = False
        '
        'frmSetDebtCusDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(497, 365)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvDebtCus)
        Me.Controls.Add(Me.Panel2)
        Me.MaximizeBox = False
        Me.Name = "frmSetDebtCusDetail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "บันทึกยอดหนี้คงค้างตามรายชื่อ"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgvDebtCus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents btPkSelect2 As System.Windows.Forms.Button
    Friend WithEvents dgvDebtCus As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents colCusName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDebt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDel As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents idCus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents status As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
