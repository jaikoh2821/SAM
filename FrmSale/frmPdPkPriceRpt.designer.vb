<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPdPkPriceRpt
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DGV = New System.Windows.Forms.DataGridView
        Me.rad_all = New System.Windows.Forms.RadioButton
        Me.rad_seed = New System.Windows.Forms.RadioButton
        Me.btn_ok = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.rad_type2 = New System.Windows.Forms.RadioButton
        Me.rad_type1 = New System.Windows.Forms.RadioButton
        Me.col_chk = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.colidseed = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colSeedName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DGV)
        Me.GroupBox1.Controls.Add(Me.rad_all)
        Me.GroupBox1.Controls.Add(Me.rad_seed)
        Me.GroupBox1.Location = New System.Drawing.Point(41, 26)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(426, 336)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "เลือกการแสดงรายงานได้จาก"
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_chk, Me.colidseed, Me.colSeedName})
        Me.DGV.Location = New System.Drawing.Point(64, 54)
        Me.DGV.Name = "DGV"
        Me.DGV.RowHeadersVisible = False
        Me.DGV.Size = New System.Drawing.Size(293, 230)
        Me.DGV.TabIndex = 2
        '
        'rad_all
        '
        Me.rad_all.AutoSize = True
        Me.rad_all.Location = New System.Drawing.Point(44, 300)
        Me.rad_all.Name = "rad_all"
        Me.rad_all.Size = New System.Drawing.Size(84, 17)
        Me.rad_all.TabIndex = 1
        Me.rad_all.TabStop = True
        Me.rad_all.Text = "แสดงทั้งหมด"
        Me.rad_all.UseVisualStyleBackColor = True
        '
        'rad_seed
        '
        Me.rad_seed.AutoSize = True
        Me.rad_seed.Checked = True
        Me.rad_seed.Location = New System.Drawing.Point(44, 31)
        Me.rad_seed.Name = "rad_seed"
        Me.rad_seed.Size = New System.Drawing.Size(77, 17)
        Me.rad_seed.TabIndex = 0
        Me.rad_seed.TabStop = True
        Me.rad_seed.Text = "ประเภทพืช"
        Me.rad_seed.UseVisualStyleBackColor = True
        '
        'btn_ok
        '
        Me.btn_ok.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_ok.Location = New System.Drawing.Point(177, 472)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(114, 27)
        Me.btn_ok.TabIndex = 6
        Me.btn_ok.Text = "แสดงรายงาน"
        Me.btn_ok.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rad_type2)
        Me.GroupBox2.Controls.Add(Me.rad_type1)
        Me.GroupBox2.Location = New System.Drawing.Point(41, 377)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(426, 78)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "รูปแบบการแสดงรายงาน"
        '
        'rad_type2
        '
        Me.rad_type2.AutoSize = True
        Me.rad_type2.Location = New System.Drawing.Point(223, 36)
        Me.rad_type2.Name = "rad_type2"
        Me.rad_type2.Size = New System.Drawing.Size(128, 17)
        Me.rad_type2.TabIndex = 4
        Me.rad_type2.TabStop = True
        Me.rad_type2.Text = "แบบเรียงตามชื่อสินค้า"
        Me.rad_type2.UseVisualStyleBackColor = True
        '
        'rad_type1
        '
        Me.rad_type1.AutoSize = True
        Me.rad_type1.Checked = True
        Me.rad_type1.Location = New System.Drawing.Point(37, 36)
        Me.rad_type1.Name = "rad_type1"
        Me.rad_type1.Size = New System.Drawing.Size(138, 17)
        Me.rad_type1.TabIndex = 3
        Me.rad_type1.TabStop = True
        Me.rad_type1.Text = "แบบจัดกลุ่มตามชื่อสินค้า"
        Me.rad_type1.UseVisualStyleBackColor = True
        '
        'col_chk
        '
        Me.col_chk.HeaderText = "เลือก"
        Me.col_chk.Name = "col_chk"
        Me.col_chk.Width = 60
        '
        'colidseed
        '
        Me.colidseed.DataPropertyName = "idSeed"
        Me.colidseed.HeaderText = "idseed"
        Me.colidseed.Name = "colidseed"
        Me.colidseed.ReadOnly = True
        Me.colidseed.Visible = False
        '
        'colSeedName
        '
        Me.colSeedName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colSeedName.DataPropertyName = "SeedName"
        Me.colSeedName.HeaderText = "ประเภทพืช"
        Me.colSeedName.Name = "colSeedName"
        Me.colSeedName.ReadOnly = True
        '
        'frmPdPkPriceRpt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(516, 523)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btn_ok)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmPdPkPriceRpt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "รายงานข้อมูลราคาสินค้าขาย"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rad_all As System.Windows.Forms.RadioButton
    Friend WithEvents rad_seed As System.Windows.Forms.RadioButton
    Friend WithEvents btn_ok As System.Windows.Forms.Button
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rad_type2 As System.Windows.Forms.RadioButton
    Friend WithEvents rad_type1 As System.Windows.Forms.RadioButton
    Friend WithEvents col_chk As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents colidseed As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSeedName As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
