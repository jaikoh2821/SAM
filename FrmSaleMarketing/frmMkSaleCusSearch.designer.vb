<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMkSaleCusSearch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMkSaleCusSearch))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.CmbPv = New System.Windows.Forms.ComboBox
        Me.rdbPvOnly = New System.Windows.Forms.RadioButton
        Me.rdbAll = New System.Windows.Forms.RadioButton
        Me.lblPdPkName = New System.Windows.Forms.Label
        Me.btnFind = New System.Windows.Forms.Button
        Me.Label10 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ChkAp = New System.Windows.Forms.CheckBox
        Me.cmbAp = New System.Windows.Forms.ComboBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btnSchPd = New System.Windows.Forms.Button
        Me.btnSearch = New System.Windows.Forms.Button
        Me.dgvCus = New System.Windows.Forms.DataGridView
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn
        Me.ColNum = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColBill = New System.Windows.Forms.DataGridViewImageColumn
        Me.ColidCus = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColCusName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColDateSale = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColAp = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColPv = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColTel = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvCus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.CmbPv)
        Me.Panel1.Controls.Add(Me.rdbPvOnly)
        Me.Panel1.Controls.Add(Me.rdbAll)
        Me.Panel1.Controls.Add(Me.lblPdPkName)
        Me.Panel1.Controls.Add(Me.btnFind)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(884, 121)
        Me.Panel1.TabIndex = 0
        '
        'CmbPv
        '
        Me.CmbPv.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbPv.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbPv.Enabled = False
        Me.CmbPv.FormattingEnabled = True
        Me.CmbPv.Location = New System.Drawing.Point(419, 47)
        Me.CmbPv.Name = "CmbPv"
        Me.CmbPv.Size = New System.Drawing.Size(128, 21)
        Me.CmbPv.TabIndex = 648
        '
        'rdbPvOnly
        '
        Me.rdbPvOnly.AutoSize = True
        Me.rdbPvOnly.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rdbPvOnly.Location = New System.Drawing.Point(352, 48)
        Me.rdbPvOnly.Name = "rdbPvOnly"
        Me.rdbPvOnly.Size = New System.Drawing.Size(61, 17)
        Me.rdbPvOnly.TabIndex = 653
        Me.rdbPvOnly.Text = "จังหวัด"
        Me.rdbPvOnly.UseVisualStyleBackColor = True
        '
        'rdbAll
        '
        Me.rdbAll.AutoSize = True
        Me.rdbAll.Checked = True
        Me.rdbAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rdbAll.Location = New System.Drawing.Point(244, 48)
        Me.rdbAll.Name = "rdbAll"
        Me.rdbAll.Size = New System.Drawing.Size(77, 17)
        Me.rdbAll.TabIndex = 652
        Me.rdbAll.TabStop = True
        Me.rdbAll.Text = "ทุกจังหวัด"
        Me.rdbAll.UseVisualStyleBackColor = True
        '
        'lblPdPkName
        '
        Me.lblPdPkName.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblPdPkName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPdPkName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblPdPkName.Location = New System.Drawing.Point(244, 19)
        Me.lblPdPkName.Name = "lblPdPkName"
        Me.lblPdPkName.Size = New System.Drawing.Size(346, 20)
        Me.lblPdPkName.TabIndex = 651
        Me.lblPdPkName.Tag = "0"
        '
        'btnFind
        '
        Me.btnFind.BackColor = System.Drawing.Color.DimGray
        Me.btnFind.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFind.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.7!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnFind.ForeColor = System.Drawing.Color.White
        Me.btnFind.Image = CType(resources.GetObject("btnFind.Image"), System.Drawing.Image)
        Me.btnFind.Location = New System.Drawing.Point(594, 16)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(28, 25)
        Me.btnFind.TabIndex = 650
        Me.btnFind.Tag = "Add"
        Me.btnFind.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.Location = New System.Drawing.Point(188, 22)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 13)
        Me.Label10.TabIndex = 649
        Me.Label10.Text = "ชื่อสินค้า"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ChkAp)
        Me.GroupBox1.Controls.Add(Me.cmbAp)
        Me.GroupBox1.Location = New System.Drawing.Point(389, 49)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(235, 54)
        Me.GroupBox1.TabIndex = 648
        Me.GroupBox1.TabStop = False
        '
        'ChkAp
        '
        Me.ChkAp.AutoSize = True
        Me.ChkAp.Enabled = False
        Me.ChkAp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ChkAp.ForeColor = System.Drawing.Color.Black
        Me.ChkAp.Location = New System.Drawing.Point(27, 27)
        Me.ChkAp.Name = "ChkAp"
        Me.ChkAp.Size = New System.Drawing.Size(60, 17)
        Me.ChkAp.TabIndex = 647
        Me.ChkAp.Text = "อำเภอ"
        Me.ChkAp.UseVisualStyleBackColor = True
        '
        'cmbAp
        '
        Me.cmbAp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbAp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbAp.Enabled = False
        Me.cmbAp.FormattingEnabled = True
        Me.cmbAp.Location = New System.Drawing.Point(91, 25)
        Me.cmbAp.Name = "cmbAp"
        Me.cmbAp.Size = New System.Drawing.Size(137, 21)
        Me.cmbAp.TabIndex = 644
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnSchPd)
        Me.Panel2.Controls.Add(Me.btnSearch)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 121)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(884, 34)
        Me.Panel2.TabIndex = 608
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
        Me.btnSchPd.TabIndex = 581
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
        'dgvCus
        '
        Me.dgvCus.AllowUserToAddRows = False
        Me.dgvCus.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveBorder
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCus.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCus.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColNum, Me.ColBill, Me.ColidCus, Me.ColCusName, Me.ColDateSale, Me.ColAp, Me.ColPv, Me.ColTel})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCus.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgvCus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvCus.EnableHeadersVisualStyles = False
        Me.dgvCus.GridColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvCus.Location = New System.Drawing.Point(0, 155)
        Me.dgvCus.Name = "dgvCus"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCus.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvCus.RowHeadersVisible = False
        Me.dgvCus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvCus.Size = New System.Drawing.Size(884, 407)
        Me.dgvCus.TabIndex = 609
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = "ประวัติการขาย"
        Me.DataGridViewImageColumn1.Image = Global.SAM.My.Resources.Resources.gtk_edit
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Width = 60
        '
        'ColNum
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColNum.DefaultCellStyle = DataGridViewCellStyle2
        Me.ColNum.HeaderText = "ลำดับ"
        Me.ColNum.Name = "ColNum"
        Me.ColNum.ReadOnly = True
        Me.ColNum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ColNum.Width = 40
        '
        'ColBill
        '
        Me.ColBill.HeaderText = "ประวัติการขาย"
        Me.ColBill.Image = Global.SAM.My.Resources.Resources.gtk_edit
        Me.ColBill.Name = "ColBill"
        Me.ColBill.Width = 60
        '
        'ColidCus
        '
        Me.ColidCus.DataPropertyName = "idCus"
        Me.ColidCus.HeaderText = "idCus"
        Me.ColidCus.Name = "ColidCus"
        Me.ColidCus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ColidCus.Visible = False
        '
        'ColCusName
        '
        Me.ColCusName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColCusName.DataPropertyName = "CusName"
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColCusName.DefaultCellStyle = DataGridViewCellStyle3
        Me.ColCusName.HeaderText = "ลูกค้า"
        Me.ColCusName.Name = "ColCusName"
        Me.ColCusName.ReadOnly = True
        Me.ColCusName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'ColDateSale
        '
        Me.ColDateSale.DataPropertyName = "LastDateSale"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColDateSale.DefaultCellStyle = DataGridViewCellStyle4
        Me.ColDateSale.HeaderText = "วันที่ขายล่าสุด"
        Me.ColDateSale.Name = "ColDateSale"
        Me.ColDateSale.ReadOnly = True
        Me.ColDateSale.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ColDateSale.Width = 85
        '
        'ColAp
        '
        Me.ColAp.DataPropertyName = "ApName"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColAp.DefaultCellStyle = DataGridViewCellStyle5
        Me.ColAp.HeaderText = "อำเภอ"
        Me.ColAp.Name = "ColAp"
        Me.ColAp.ReadOnly = True
        Me.ColAp.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'ColPv
        '
        Me.ColPv.DataPropertyName = "ProvinceName"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColPv.DefaultCellStyle = DataGridViewCellStyle6
        Me.ColPv.HeaderText = "จังหวัด"
        Me.ColPv.Name = "ColPv"
        Me.ColPv.ReadOnly = True
        Me.ColPv.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ColPv.Width = 110
        '
        'ColTel
        '
        Me.ColTel.DataPropertyName = "Tel"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColTel.DefaultCellStyle = DataGridViewCellStyle7
        Me.ColTel.HeaderText = "Tel."
        Me.ColTel.Name = "ColTel"
        Me.ColTel.ReadOnly = True
        Me.ColTel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ColTel.Width = 160
        '
        'frmMkSaleCusSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(884, 562)
        Me.Controls.Add(Me.dgvCus)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.Name = "frmMkSaleCusSearch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ค้นหาคู่ค้าจากข้อมูลการขายสินค้าแยกตามจังหวัด"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgvCus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CmbPv As System.Windows.Forms.ComboBox
    Friend WithEvents ChkAp As System.Windows.Forms.CheckBox
    Friend WithEvents cmbAp As System.Windows.Forms.ComboBox
    Friend WithEvents btnFind As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnSchPd As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents lblPdPkName As System.Windows.Forms.Label
    Friend WithEvents dgvCus As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents rdbAll As System.Windows.Forms.RadioButton
    Friend WithEvents rdbPvOnly As System.Windows.Forms.RadioButton
    Friend WithEvents ColNum As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColBill As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents ColidCus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColCusName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColDateSale As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColAp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColPv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColTel As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
