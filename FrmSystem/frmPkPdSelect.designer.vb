<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPkPdSelect
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPkPdSelect))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.dgvPkPdSetList = New System.Windows.Forms.DataGridView
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btnSFindAll = New System.Windows.Forms.Button
        Me.txtPlantName = New System.Windows.Forms.TextBox
        Me.txtPdName = New System.Windows.Forms.TextBox
        Me.chkPlantName = New System.Windows.Forms.CheckBox
        Me.chkPdName = New System.Windows.Forms.CheckBox
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.colSelect = New System.Windows.Forms.DataGridViewImageColumn
        Me.colPlantTypeName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colPdTradeName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colPkUnit = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colSizeName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colWeight = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colidUnitW = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.idPdPk = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PriceBill = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PriceWholesale = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PriceRetail = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.idPkUnit = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.idUnitW = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.col_idPdT = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.dgvPkPdSetList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvPkPdSetList
        '
        Me.dgvPkPdSetList.AllowUserToAddRows = False
        Me.dgvPkPdSetList.AllowUserToDeleteRows = False
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPkPdSetList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvPkPdSetList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPkPdSetList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colSelect, Me.colPlantTypeName, Me.colPdTradeName, Me.colPkUnit, Me.colSizeName, Me.colWeight, Me.colidUnitW, Me.idPdPk, Me.PriceBill, Me.PriceWholesale, Me.PriceRetail, Me.idPkUnit, Me.idUnitW, Me.col_idPdT})
        Me.dgvPkPdSetList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvPkPdSetList.Location = New System.Drawing.Point(0, 105)
        Me.dgvPkPdSetList.Name = "dgvPkPdSetList"
        Me.dgvPkPdSetList.RowHeadersVisible = False
        Me.dgvPkPdSetList.Size = New System.Drawing.Size(872, 374)
        Me.dgvPkPdSetList.TabIndex = 402
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnSFindAll)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 68)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(872, 37)
        Me.Panel2.TabIndex = 406
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
        'txtPlantName
        '
        Me.txtPlantName.Enabled = False
        Me.txtPlantName.Location = New System.Drawing.Point(372, 39)
        Me.txtPlantName.Name = "txtPlantName"
        Me.txtPlantName.Size = New System.Drawing.Size(197, 20)
        Me.txtPlantName.TabIndex = 410
        '
        'txtPdName
        '
        Me.txtPdName.Enabled = False
        Me.txtPdName.Location = New System.Drawing.Point(372, 13)
        Me.txtPdName.Name = "txtPdName"
        Me.txtPdName.Size = New System.Drawing.Size(197, 20)
        Me.txtPdName.TabIndex = 409
        '
        'chkPlantName
        '
        Me.chkPlantName.AutoSize = True
        Me.chkPlantName.Location = New System.Drawing.Point(303, 41)
        Me.chkPlantName.Name = "chkPlantName"
        Me.chkPlantName.Size = New System.Drawing.Size(54, 17)
        Me.chkPlantName.TabIndex = 408
        Me.chkPlantName.Text = "ชื่อพืช"
        Me.chkPlantName.UseVisualStyleBackColor = True
        '
        'chkPdName
        '
        Me.chkPdName.AutoSize = True
        Me.chkPdName.Location = New System.Drawing.Point(303, 14)
        Me.chkPdName.Name = "chkPdName"
        Me.chkPdName.Size = New System.Drawing.Size(65, 17)
        Me.chkPdName.TabIndex = 407
        Me.chkPdName.Text = "ชื่อสินค้า"
        Me.chkPdName.UseVisualStyleBackColor = True
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = "กำหนดรหัสBarcode"
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn1.Width = 50
        '
        'DataGridViewImageColumn2
        '
        Me.DataGridViewImageColumn2.HeaderText = "เลือก"
        Me.DataGridViewImageColumn2.Image = Global.SAM.My.Resources.Resources.gdEdit
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        Me.DataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn2.Width = 120
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.chkPdName)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.txtPlantName)
        Me.Panel1.Controls.Add(Me.chkPlantName)
        Me.Panel1.Controls.Add(Me.txtPdName)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(872, 105)
        Me.Panel1.TabIndex = 411
        '
        'colSelect
        '
        Me.colSelect.HeaderText = "เลือก"
        Me.colSelect.Name = "colSelect"
        Me.colSelect.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colSelect.Width = 50
        '
        'colPlantTypeName
        '
        Me.colPlantTypeName.DataPropertyName = "PlantTypeName"
        Me.colPlantTypeName.HeaderText = "ชื่อพืช"
        Me.colPlantTypeName.Name = "colPlantTypeName"
        Me.colPlantTypeName.ReadOnly = True
        Me.colPlantTypeName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colPlantTypeName.Width = 160
        '
        'colPdTradeName
        '
        Me.colPdTradeName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colPdTradeName.DataPropertyName = "PdTradeName"
        Me.colPdTradeName.HeaderText = "ชื่อสินค้า"
        Me.colPdTradeName.Name = "colPdTradeName"
        Me.colPdTradeName.ReadOnly = True
        Me.colPdTradeName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colPkUnit
        '
        Me.colPkUnit.DataPropertyName = "PkUnitName"
        Me.colPkUnit.HeaderText = "หน่วยบรรจุ"
        Me.colPkUnit.Name = "colPkUnit"
        Me.colPkUnit.ReadOnly = True
        Me.colPkUnit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colSizeName
        '
        Me.colSizeName.DataPropertyName = "SizeName"
        Me.colSizeName.HeaderText = "ชื่อขนาด"
        Me.colSizeName.Name = "colSizeName"
        Me.colSizeName.ReadOnly = True
        Me.colSizeName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colSizeName.Visible = False
        '
        'colWeight
        '
        Me.colWeight.DataPropertyName = "Weight"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colWeight.DefaultCellStyle = DataGridViewCellStyle4
        Me.colWeight.HeaderText = "น้ำหนัก"
        Me.colWeight.Name = "colWeight"
        Me.colWeight.ReadOnly = True
        Me.colWeight.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colWeight.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colidUnitW
        '
        Me.colidUnitW.DataPropertyName = "UnitW"
        Me.colidUnitW.HeaderText = "หน่วยน้ำหนัก"
        Me.colidUnitW.Name = "colidUnitW"
        Me.colidUnitW.ReadOnly = True
        Me.colidUnitW.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colidUnitW.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'idPdPk
        '
        Me.idPdPk.DataPropertyName = "idPdPk"
        Me.idPdPk.HeaderText = "idPdPk"
        Me.idPdPk.Name = "idPdPk"
        Me.idPdPk.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.idPdPk.Visible = False
        '
        'PriceBill
        '
        Me.PriceBill.DataPropertyName = "PriceBill"
        Me.PriceBill.HeaderText = "PriceBill"
        Me.PriceBill.Name = "PriceBill"
        Me.PriceBill.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.PriceBill.Visible = False
        '
        'PriceWholesale
        '
        Me.PriceWholesale.DataPropertyName = "PriceWholesale"
        Me.PriceWholesale.HeaderText = "PriceWholesale"
        Me.PriceWholesale.Name = "PriceWholesale"
        Me.PriceWholesale.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.PriceWholesale.Visible = False
        '
        'PriceRetail
        '
        Me.PriceRetail.DataPropertyName = "PriceRetail"
        Me.PriceRetail.HeaderText = "PriceRetail"
        Me.PriceRetail.Name = "PriceRetail"
        Me.PriceRetail.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.PriceRetail.Visible = False
        '
        'idPkUnit
        '
        Me.idPkUnit.DataPropertyName = "idPkUnit"
        Me.idPkUnit.HeaderText = "idPkUnit"
        Me.idPkUnit.Name = "idPkUnit"
        Me.idPkUnit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.idPkUnit.Visible = False
        '
        'idUnitW
        '
        Me.idUnitW.DataPropertyName = "idUnitW"
        Me.idUnitW.HeaderText = "idUnitW"
        Me.idUnitW.Name = "idUnitW"
        Me.idUnitW.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.idUnitW.Visible = False
        '
        'col_idPdT
        '
        Me.col_idPdT.DataPropertyName = "idPdT"
        Me.col_idPdT.HeaderText = "col_idPdT"
        Me.col_idPdT.Name = "col_idPdT"
        Me.col_idPdT.Visible = False
        '
        'frmPkPdSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(872, 479)
        Me.Controls.Add(Me.dgvPkPdSetList)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmPkPdSelect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "เลือกข้อมูลสินค้าขาย"
        CType(Me.dgvPkPdSetList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvPkPdSetList As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnSFindAll As System.Windows.Forms.Button
    Friend WithEvents txtPlantName As System.Windows.Forms.TextBox
    Friend WithEvents txtPdName As System.Windows.Forms.TextBox
    Friend WithEvents chkPlantName As System.Windows.Forms.CheckBox
    Friend WithEvents chkPdName As System.Windows.Forms.CheckBox
    Friend WithEvents DataGridViewImageColumn2 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents colSelect As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents colPlantTypeName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPdTradeName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPkUnit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSizeName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colWeight As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colidUnitW As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idPdPk As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PriceBill As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PriceWholesale As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PriceRetail As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idPkUnit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idUnitW As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_idPdT As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
