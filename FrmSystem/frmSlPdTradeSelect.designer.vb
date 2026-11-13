<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSlPdTradeSelect
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
        Me.dgvData = New System.Windows.Forms.DataGridView
        Me.colCheck = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.colSelect = New System.Windows.Forms.DataGridViewButtonColumn
        Me.colPdTradeName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colPlantTypeName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colDetail = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PricePerKg = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.idPdT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.chkPdName = New System.Windows.Forms.CheckBox
        Me.chkPlantName = New System.Windows.Forms.CheckBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btnAdd = New System.Windows.Forms.Button
        Me.btnSFindAll = New System.Windows.Forms.Button
        Me.txtPdName = New System.Windows.Forms.TextBox
        Me.txtPlantName = New System.Windows.Forms.TextBox
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvData
        '
        Me.dgvData.AllowUserToAddRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colCheck, Me.colSelect, Me.colPdTradeName, Me.colPlantTypeName, Me.colDetail, Me.PricePerKg, Me.idPdT})
        Me.dgvData.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvData.Location = New System.Drawing.Point(0, 115)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.RowHeadersVisible = False
        Me.dgvData.Size = New System.Drawing.Size(493, 369)
        Me.dgvData.TabIndex = 0
        '
        'colCheck
        '
        Me.colCheck.HeaderText = "เลือก"
        Me.colCheck.Name = "colCheck"
        Me.colCheck.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colCheck.Width = 40
        '
        'colSelect
        '
        Me.colSelect.HeaderText = "เลือก"
        Me.colSelect.Name = "colSelect"
        Me.colSelect.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colSelect.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colSelect.Visible = False
        Me.colSelect.Width = 40
        '
        'colPdTradeName
        '
        Me.colPdTradeName.DataPropertyName = "PdTradeName"
        Me.colPdTradeName.HeaderText = "ชื่อสินค้า"
        Me.colPdTradeName.Name = "colPdTradeName"
        Me.colPdTradeName.Width = 150
        '
        'colPlantTypeName
        '
        Me.colPlantTypeName.DataPropertyName = "PlantTypeName"
        Me.colPlantTypeName.HeaderText = "ชื่อพืช"
        Me.colPlantTypeName.Name = "colPlantTypeName"
        Me.colPlantTypeName.Width = 150
        '
        'colDetail
        '
        Me.colDetail.DataPropertyName = "Detail"
        Me.colDetail.HeaderText = "รายละเอียด"
        Me.colDetail.Name = "colDetail"
        Me.colDetail.Width = 150
        '
        'PricePerKg
        '
        Me.PricePerKg.DataPropertyName = "PricePerKg"
        Me.PricePerKg.HeaderText = "PricePerKg"
        Me.PricePerKg.Name = "PricePerKg"
        Me.PricePerKg.Visible = False
        '
        'idPdT
        '
        Me.idPdT.DataPropertyName = "idPdT"
        Me.idPdT.HeaderText = "idPdT"
        Me.idPdT.Name = "idPdT"
        Me.idPdT.Visible = False
        '
        'chkPdName
        '
        Me.chkPdName.AutoSize = True
        Me.chkPdName.Location = New System.Drawing.Point(103, 15)
        Me.chkPdName.Name = "chkPdName"
        Me.chkPdName.Size = New System.Drawing.Size(65, 17)
        Me.chkPdName.TabIndex = 1
        Me.chkPdName.Text = "ชื่อสินค้า"
        Me.chkPdName.UseVisualStyleBackColor = True
        '
        'chkPlantName
        '
        Me.chkPlantName.AutoSize = True
        Me.chkPlantName.Location = New System.Drawing.Point(103, 43)
        Me.chkPlantName.Name = "chkPlantName"
        Me.chkPlantName.Size = New System.Drawing.Size(54, 17)
        Me.chkPlantName.TabIndex = 2
        Me.chkPlantName.Text = "ชื่อพืช"
        Me.chkPlantName.UseVisualStyleBackColor = True
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
        Me.Panel2.Size = New System.Drawing.Size(493, 37)
        Me.Panel2.TabIndex = 397
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.DimGray
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Image = Global.SAM.My.Resources.Resources.Add28
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
        Me.btnSFindAll.Image = Global.SAM.My.Resources.Resources.Find
        Me.btnSFindAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSFindAll.Location = New System.Drawing.Point(0, 0)
        Me.btnSFindAll.Name = "btnSFindAll"
        Me.btnSFindAll.Size = New System.Drawing.Size(115, 35)
        Me.btnSFindAll.TabIndex = 397
        Me.btnSFindAll.Tag = ""
        Me.btnSFindAll.Text = "       แสดงข้อมูล"
        Me.btnSFindAll.UseVisualStyleBackColor = False
        '
        'txtPdName
        '
        Me.txtPdName.Enabled = False
        Me.txtPdName.Location = New System.Drawing.Point(174, 12)
        Me.txtPdName.Name = "txtPdName"
        Me.txtPdName.Size = New System.Drawing.Size(197, 20)
        Me.txtPdName.TabIndex = 398
        '
        'txtPlantName
        '
        Me.txtPlantName.Enabled = False
        Me.txtPlantName.Location = New System.Drawing.Point(174, 41)
        Me.txtPlantName.Name = "txtPlantName"
        Me.txtPlantName.Size = New System.Drawing.Size(197, 20)
        Me.txtPlantName.TabIndex = 399
        '
        'frmSlPdTradeSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(493, 484)
        Me.Controls.Add(Me.txtPlantName)
        Me.Controls.Add(Me.txtPdName)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.chkPlantName)
        Me.Controls.Add(Me.chkPdName)
        Me.Controls.Add(Me.dgvData)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSlPdTradeSelect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "เลือกข้อมูลสินค้า"
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvData As System.Windows.Forms.DataGridView
    Friend WithEvents chkPdName As System.Windows.Forms.CheckBox
    Friend WithEvents chkPlantName As System.Windows.Forms.CheckBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnSFindAll As System.Windows.Forms.Button
    Friend WithEvents txtPdName As System.Windows.Forms.TextBox
    Friend WithEvents txtPlantName As System.Windows.Forms.TextBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents colCheck As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents colSelect As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents colPdTradeName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPlantTypeName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDetail As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PricePerKg As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idPdT As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
