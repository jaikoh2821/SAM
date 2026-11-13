<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPdOtherSelectCard
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPdOtherSelectCard))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtLotNum = New System.Windows.Forms.TextBox()
        Me.CHKLotNum = New System.Windows.Forms.CheckBox()
        Me.cmbType = New System.Windows.Forms.ComboBox()
        Me.txtPdName = New System.Windows.Forms.TextBox()
        Me.ChkPd = New System.Windows.Forms.CheckBox()
        Me.ChkType = New System.Windows.Forms.CheckBox()
        Me.dgvPd = New System.Windows.Forms.DataGridView()
        Me.colSelect = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ColidPdO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LotNum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColTitle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColPdoTypeName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColPerbox = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColCreditThirty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColPriceWholesale = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idPdOLot = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSchPd = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvPd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.txtLotNum)
        Me.Panel2.Controls.Add(Me.CHKLotNum)
        Me.Panel2.Controls.Add(Me.cmbType)
        Me.Panel2.Controls.Add(Me.txtPdName)
        Me.Panel2.Controls.Add(Me.ChkPd)
        Me.Panel2.Controls.Add(Me.ChkType)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(812, 105)
        Me.Panel2.TabIndex = 0
        '
        'txtLotNum
        '
        Me.txtLotNum.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtLotNum.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtLotNum.Enabled = False
        Me.txtLotNum.Location = New System.Drawing.Point(364, 69)
        Me.txtLotNum.Name = "txtLotNum"
        Me.txtLotNum.Size = New System.Drawing.Size(174, 20)
        Me.txtLotNum.TabIndex = 605
        '
        'CHKLotNum
        '
        Me.CHKLotNum.AutoSize = True
        Me.CHKLotNum.Location = New System.Drawing.Point(269, 71)
        Me.CHKLotNum.Name = "CHKLotNum"
        Me.CHKLotNum.Size = New System.Drawing.Size(59, 17)
        Me.CHKLotNum.TabIndex = 606
        Me.CHKLotNum.Text = "Lot no."
        Me.CHKLotNum.UseVisualStyleBackColor = True
        '
        'cmbType
        '
        Me.cmbType.Enabled = False
        Me.cmbType.FormattingEnabled = True
        Me.cmbType.Location = New System.Drawing.Point(364, 42)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(174, 21)
        Me.cmbType.TabIndex = 2
        '
        'txtPdName
        '
        Me.txtPdName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtPdName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtPdName.Enabled = False
        Me.txtPdName.Location = New System.Drawing.Point(364, 16)
        Me.txtPdName.Name = "txtPdName"
        Me.txtPdName.Size = New System.Drawing.Size(174, 20)
        Me.txtPdName.TabIndex = 1
        '
        'ChkPd
        '
        Me.ChkPd.AutoSize = True
        Me.ChkPd.Location = New System.Drawing.Point(269, 18)
        Me.ChkPd.Name = "ChkPd"
        Me.ChkPd.Size = New System.Drawing.Size(65, 17)
        Me.ChkPd.TabIndex = 603
        Me.ChkPd.Text = "ชื่อสินค้า"
        Me.ChkPd.UseVisualStyleBackColor = True
        '
        'ChkType
        '
        Me.ChkType.AutoSize = True
        Me.ChkType.Location = New System.Drawing.Point(269, 44)
        Me.ChkType.Name = "ChkType"
        Me.ChkType.Size = New System.Drawing.Size(89, 17)
        Me.ChkType.TabIndex = 604
        Me.ChkType.Text = "ประเภทสินค้า"
        Me.ChkType.UseVisualStyleBackColor = True
        '
        'dgvPd
        '
        Me.dgvPd.AllowUserToAddRows = False
        Me.dgvPd.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPd.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvPd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPd.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colSelect, Me.ColidPdO, Me.LotNum, Me.ColTitle, Me.ColPdoTypeName, Me.ColPerbox, Me.Amount, Me.ColPrice, Me.ColCreditThirty, Me.ColPriceWholesale, Me.idPdOLot, Me.UnitName})
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPd.DefaultCellStyle = DataGridViewCellStyle11
        Me.dgvPd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvPd.EnableHeadersVisualStyles = False
        Me.dgvPd.GridColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvPd.Location = New System.Drawing.Point(0, 139)
        Me.dgvPd.Name = "dgvPd"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPd.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.dgvPd.RowHeadersVisible = False
        Me.dgvPd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvPd.Size = New System.Drawing.Size(812, 382)
        Me.dgvPd.TabIndex = 2
        '
        'colSelect
        '
        Me.colSelect.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray
        Me.colSelect.DefaultCellStyle = DataGridViewCellStyle2
        Me.colSelect.HeaderText = "เลือก"
        Me.colSelect.Name = "colSelect"
        Me.colSelect.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colSelect.Width = 41
        '
        'ColidPdO
        '
        Me.ColidPdO.DataPropertyName = "idPdO"
        Me.ColidPdO.HeaderText = "idPdO"
        Me.ColidPdO.Name = "ColidPdO"
        Me.ColidPdO.Visible = False
        '
        'LotNum
        '
        Me.LotNum.DataPropertyName = "LotNum"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LotNum.DefaultCellStyle = DataGridViewCellStyle3
        Me.LotNum.HeaderText = "Lot no."
        Me.LotNum.Name = "LotNum"
        Me.LotNum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.LotNum.Width = 150
        '
        'ColTitle
        '
        Me.ColTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColTitle.DataPropertyName = "Title"
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColTitle.DefaultCellStyle = DataGridViewCellStyle4
        Me.ColTitle.HeaderText = "ชื่อสินค้า"
        Me.ColTitle.Name = "ColTitle"
        Me.ColTitle.ReadOnly = True
        Me.ColTitle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'ColPdoTypeName
        '
        Me.ColPdoTypeName.DataPropertyName = "PdoTypeName"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColPdoTypeName.DefaultCellStyle = DataGridViewCellStyle5
        Me.ColPdoTypeName.HeaderText = "ประเภทสินค้า"
        Me.ColPdoTypeName.Name = "ColPdoTypeName"
        Me.ColPdoTypeName.ReadOnly = True
        Me.ColPdoTypeName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'ColPerbox
        '
        Me.ColPerbox.DataPropertyName = "Perbox"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColPerbox.DefaultCellStyle = DataGridViewCellStyle6
        Me.ColPerbox.HeaderText = "จำนวน/กล่อง"
        Me.ColPerbox.Name = "ColPerbox"
        Me.ColPerbox.ReadOnly = True
        Me.ColPerbox.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ColPerbox.Visible = False
        Me.ColPerbox.Width = 80
        '
        'Amount
        '
        Me.Amount.DataPropertyName = "Amount"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle7.Format = "N2"
        Me.Amount.DefaultCellStyle = DataGridViewCellStyle7
        Me.Amount.HeaderText = "คงเหลือ"
        Me.Amount.Name = "Amount"
        Me.Amount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'ColPrice
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.ColPrice.DefaultCellStyle = DataGridViewCellStyle8
        Me.ColPrice.HeaderText = "ราคา"
        Me.ColPrice.Name = "ColPrice"
        Me.ColPrice.Visible = False
        Me.ColPrice.Width = 80
        '
        'ColCreditThirty
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.ColCreditThirty.DefaultCellStyle = DataGridViewCellStyle9
        Me.ColCreditThirty.HeaderText = "ราคาเครดิต 30 วัน"
        Me.ColCreditThirty.Name = "ColCreditThirty"
        Me.ColCreditThirty.Visible = False
        '
        'ColPriceWholesale
        '
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.ColPriceWholesale.DefaultCellStyle = DataGridViewCellStyle10
        Me.ColPriceWholesale.HeaderText = "ราคาส่ง"
        Me.ColPriceWholesale.Name = "ColPriceWholesale"
        Me.ColPriceWholesale.Visible = False
        Me.ColPriceWholesale.Width = 80
        '
        'idPdOLot
        '
        Me.idPdOLot.DataPropertyName = "idPdOLot"
        Me.idPdOLot.HeaderText = "idPdOLot"
        Me.idPdOLot.Name = "idPdOLot"
        Me.idPdOLot.Visible = False
        '
        'UnitName
        '
        Me.UnitName.DataPropertyName = "UnitName"
        Me.UnitName.HeaderText = "unit"
        Me.UnitName.Name = "UnitName"
        Me.UnitName.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnSchPd)
        Me.Panel1.Controls.Add(Me.btnSearch)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 105)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(812, 34)
        Me.Panel1.TabIndex = 1
        '
        'btnSchPd
        '
        Me.btnSchPd.BackColor = System.Drawing.Color.DimGray
        Me.btnSchPd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSchPd.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnSchPd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnSchPd.ForeColor = System.Drawing.Color.White
        Me.btnSchPd.Image = CType(resources.GetObject("btnSchPd.Image"), System.Drawing.Image)
        Me.btnSchPd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSchPd.Location = New System.Drawing.Point(0, 0)
        Me.btnSchPd.Name = "btnSchPd"
        Me.btnSchPd.Size = New System.Drawing.Size(115, 32)
        Me.btnSchPd.TabIndex = 3
        Me.btnSchPd.Tag = ""
        Me.btnSchPd.Text = "       แสดงข้อมูล"
        Me.btnSchPd.UseVisualStyleBackColor = False
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.DimGray
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.7!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearch.Location = New System.Drawing.Point(3, -1)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(111, 36)
        Me.btnSearch.TabIndex = 392
        Me.btnSearch.Tag = "Add"
        Me.btnSearch.Text = "        แสดงข้อมูล"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'frmPdOtherSelectCard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(812, 521)
        Me.Controls.Add(Me.dgvPd)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.MaximizeBox = False
        Me.Name = "frmPdOtherSelectCard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "รายการสินค้าอื่นๆ (ไม่ใช่เมล็ด)"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgvPd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents cmbType As System.Windows.Forms.ComboBox
    Friend WithEvents txtPdName As System.Windows.Forms.TextBox
    Friend WithEvents ChkPd As System.Windows.Forms.CheckBox
    Friend WithEvents ChkType As System.Windows.Forms.CheckBox
    Friend WithEvents dgvPd As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnSchPd As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents txtLotNum As System.Windows.Forms.TextBox
    Friend WithEvents CHKLotNum As System.Windows.Forms.CheckBox
    Friend WithEvents colSelect As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents ColidPdO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LotNum As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColTitle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColPdoTypeName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColPerbox As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Amount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColCreditThirty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColPriceWholesale As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idPdOLot As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UnitName As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
