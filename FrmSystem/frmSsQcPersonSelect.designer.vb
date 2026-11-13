<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSsQcPersonSelect
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.DGV_person = New System.Windows.Forms.DataGridView
        Me.txt_name = New System.Windows.Forms.TextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btn_add = New System.Windows.Forms.Button
        Me.comboposition = New System.Windows.Forms.ComboBox
        Me.CHKname = New System.Windows.Forms.CheckBox
        Me.CHKPosition = New System.Windows.Forms.CheckBox
        Me.RdSales = New System.Windows.Forms.RadioButton
        Me.RdAll = New System.Windows.Forms.RadioButton
        Me.txtSName = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.colautonum = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colSel = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.colSel2 = New System.Windows.Forms.DataGridViewButtonColumn
        Me.colidPs = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colPsName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.col_PosName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.col_CompName = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.DGV_person, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGV_person
        '
        Me.DGV_person.AllowUserToAddRows = False
        Me.DGV_person.AllowUserToResizeColumns = False
        Me.DGV_person.AllowUserToResizeRows = False
        Me.DGV_person.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGV_person.BackgroundColor = System.Drawing.Color.Lavender
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_person.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DGV_person.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_person.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colautonum, Me.colSel, Me.colSel2, Me.colidPs, Me.colPsName, Me.col_PosName, Me.col_CompName})
        Me.DGV_person.Location = New System.Drawing.Point(0, 67)
        Me.DGV_person.Name = "DGV_person"
        Me.DGV_person.RowHeadersVisible = False
        Me.DGV_person.Size = New System.Drawing.Size(564, 301)
        Me.DGV_person.TabIndex = 0
        '
        'txt_name
        '
        Me.txt_name.Enabled = False
        Me.txt_name.Location = New System.Drawing.Point(231, 5)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(138, 20)
        Me.txt_name.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel1.Controls.Add(Me.btn_add)
        Me.Panel1.Location = New System.Drawing.Point(0, 366)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(564, 40)
        Me.Panel1.TabIndex = 6
        '
        'btn_add
        '
        Me.btn_add.AutoSize = True
        Me.btn_add.BackColor = System.Drawing.Color.DimGray
        Me.btn_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_add.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_add.ForeColor = System.Drawing.Color.White
        Me.btn_add.Image = Global.SAM.My.Resources.Resources.Add28
        Me.btn_add.Location = New System.Drawing.Point(3, 0)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(96, 40)
        Me.btn_add.TabIndex = 418
        Me.btn_add.Text = "เพิ่ม"
        Me.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_add.UseVisualStyleBackColor = False
        '
        'comboposition
        '
        Me.comboposition.Enabled = False
        Me.comboposition.FormattingEnabled = True
        Me.comboposition.Location = New System.Drawing.Point(231, 32)
        Me.comboposition.Name = "comboposition"
        Me.comboposition.Size = New System.Drawing.Size(138, 21)
        Me.comboposition.TabIndex = 425
        '
        'CHKname
        '
        Me.CHKname.AutoSize = True
        Me.CHKname.Location = New System.Drawing.Point(146, 8)
        Me.CHKname.Name = "CHKname"
        Me.CHKname.Size = New System.Drawing.Size(80, 17)
        Me.CHKname.TabIndex = 426
        Me.CHKname.Text = "ชื่อพนักงาน"
        Me.CHKname.UseVisualStyleBackColor = True
        '
        'CHKPosition
        '
        Me.CHKPosition.AutoSize = True
        Me.CHKPosition.Location = New System.Drawing.Point(147, 34)
        Me.CHKPosition.Name = "CHKPosition"
        Me.CHKPosition.Size = New System.Drawing.Size(79, 17)
        Me.CHKPosition.TabIndex = 427
        Me.CHKPosition.Text = "ชื่อตำแหน่ง"
        Me.CHKPosition.UseVisualStyleBackColor = True
        '
        'RdSales
        '
        Me.RdSales.AutoSize = True
        Me.RdSales.Checked = True
        Me.RdSales.Location = New System.Drawing.Point(399, 12)
        Me.RdSales.Name = "RdSales"
        Me.RdSales.Size = New System.Drawing.Size(84, 17)
        Me.RdSales.TabIndex = 428
        Me.RdSales.TabStop = True
        Me.RdSales.Text = "พนักงานขาย"
        Me.RdSales.UseVisualStyleBackColor = True
        '
        'RdAll
        '
        Me.RdAll.AutoSize = True
        Me.RdAll.Location = New System.Drawing.Point(399, 34)
        Me.RdAll.Name = "RdAll"
        Me.RdAll.Size = New System.Drawing.Size(99, 17)
        Me.RdAll.TabIndex = 429
        Me.RdAll.Text = "พนักงานทั้งหมด"
        Me.RdAll.UseVisualStyleBackColor = True
        '
        'txtSName
        '
        Me.txtSName.Location = New System.Drawing.Point(210, 32)
        Me.txtSName.Name = "txtSName"
        Me.txtSName.Size = New System.Drawing.Size(157, 20)
        Me.txtSName.TabIndex = 432
        Me.txtSName.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(159, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 433
        Me.Label1.Text = "ค้าหาชื่อ"
        '
        'colautonum
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.colautonum.DefaultCellStyle = DataGridViewCellStyle5
        Me.colautonum.HeaderText = "ลำดับ"
        Me.colautonum.Name = "colautonum"
        Me.colautonum.ReadOnly = True
        Me.colautonum.Width = 40
        '
        'colSel
        '
        Me.colSel.DataPropertyName = "chkPs"
        Me.colSel.HeaderText = "เลือก"
        Me.colSel.Name = "colSel"
        Me.colSel.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colSel.Width = 60
        '
        'colSel2
        '
        Me.colSel2.HeaderText = "เลือก"
        Me.colSel2.Name = "colSel2"
        Me.colSel2.Visible = False
        Me.colSel2.Width = 60
        '
        'colidPs
        '
        Me.colidPs.DataPropertyName = "idPs"
        Me.colidPs.HeaderText = "idPs"
        Me.colidPs.Name = "colidPs"
        Me.colidPs.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colidPs.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colidPs.Visible = False
        '
        'colPsName
        '
        Me.colPsName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colPsName.DataPropertyName = "PsName"
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colPsName.DefaultCellStyle = DataGridViewCellStyle6
        Me.colPsName.HeaderText = "ชื่อ"
        Me.colPsName.Name = "colPsName"
        Me.colPsName.ReadOnly = True
        Me.colPsName.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colPsName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'col_PosName
        '
        Me.col_PosName.DataPropertyName = "PositionName"
        Me.col_PosName.HeaderText = "ต่ำแหน่ง"
        Me.col_PosName.Name = "col_PosName"
        Me.col_PosName.ReadOnly = True
        Me.col_PosName.Width = 120
        '
        'col_CompName
        '
        Me.col_CompName.DataPropertyName = "CompName"
        Me.col_CompName.HeaderText = "บริษัท"
        Me.col_CompName.Name = "col_CompName"
        Me.col_CompName.ReadOnly = True
        Me.col_CompName.Width = 140
        '
        'frmSsQcPersonSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(564, 406)
        Me.Controls.Add(Me.RdSales)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RdAll)
        Me.Controls.Add(Me.txtSName)
        Me.Controls.Add(Me.CHKPosition)
        Me.Controls.Add(Me.CHKname)
        Me.Controls.Add(Me.comboposition)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.DGV_person)
        Me.Name = "frmSsQcPersonSelect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "เลือกบุคคลที่มีสิทธิ์เข้าใช้งาน"
        CType(Me.DGV_person, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGV_person As System.Windows.Forms.DataGridView
    Friend WithEvents txt_name As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn_add As System.Windows.Forms.Button
    Friend WithEvents comboposition As System.Windows.Forms.ComboBox
    Friend WithEvents CHKname As System.Windows.Forms.CheckBox
    Friend WithEvents CHKPosition As System.Windows.Forms.CheckBox
    Friend WithEvents RdSales As System.Windows.Forms.RadioButton
    Friend WithEvents RdAll As System.Windows.Forms.RadioButton
    Friend WithEvents txtSName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents colautonum As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSel As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents colSel2 As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents colidPs As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPsName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_PosName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_CompName As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
