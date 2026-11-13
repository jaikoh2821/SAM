<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPdIngredient
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPdIngredient))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.txt_note = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txt_FL = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txt_type = New System.Windows.Forms.TextBox
        Me.txt_plant = New System.Windows.Forms.TextBox
        Me.txt_name = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn
        Me.btn_sel = New System.Windows.Forms.Button
        Me.btn_save = New System.Windows.Forms.Button
        Me.colidPd = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colproduct = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ingredient = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.coldelete = New System.Windows.Forms.DataGridViewImageColumn
        Me.PdCode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PdName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_note
        '
        Me.txt_note.Location = New System.Drawing.Point(134, 166)
        Me.txt_note.Multiline = True
        Me.txt_note.Name = "txt_note"
        Me.txt_note.ReadOnly = True
        Me.txt_note.Size = New System.Drawing.Size(246, 61)
        Me.txt_note.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(76, 166)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "หมายเหตุ"
        '
        'txt_FL
        '
        Me.txt_FL.Location = New System.Drawing.Point(134, 129)
        Me.txt_FL.Name = "txt_FL"
        Me.txt_FL.ReadOnly = True
        Me.txt_FL.Size = New System.Drawing.Size(73, 20)
        Me.txt_FL.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(89, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "ชื่อสูตร"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.btn_sel)
        Me.Panel1.Controls.Add(Me.btn_save)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 254)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(455, 52)
        Me.Panel1.TabIndex = 16
        Me.Panel1.Visible = False
        '
        'txt_type
        '
        Me.txt_type.Enabled = False
        Me.txt_type.Location = New System.Drawing.Point(134, 93)
        Me.txt_type.Name = "txt_type"
        Me.txt_type.ReadOnly = True
        Me.txt_type.Size = New System.Drawing.Size(246, 20)
        Me.txt_type.TabIndex = 5
        '
        'txt_plant
        '
        Me.txt_plant.Enabled = False
        Me.txt_plant.Location = New System.Drawing.Point(134, 60)
        Me.txt_plant.Name = "txt_plant"
        Me.txt_plant.ReadOnly = True
        Me.txt_plant.Size = New System.Drawing.Size(246, 20)
        Me.txt_plant.TabIndex = 4
        '
        'txt_name
        '
        Me.txt_name.Enabled = False
        Me.txt_name.Location = New System.Drawing.Point(134, 29)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.ReadOnly = True
        Me.txt_name.Size = New System.Drawing.Size(246, 20)
        Me.txt_name.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(69, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "ประเภทพืช"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(93, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ชื่อพืช"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_note)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txt_FL)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_type)
        Me.GroupBox1.Controls.Add(Me.txt_plant)
        Me.GroupBox1.Controls.Add(Me.txt_name)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(428, 240)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ชื่อการค้าของสินค้า"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ชื่อการค้าของสินค้า"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colidPd, Me.colproduct, Me.ingredient, Me.coldelete, Me.PdCode, Me.PdName})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(0, 306)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(455, 232)
        Me.DataGridView1.TabIndex = 15
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = "ลบ"
        Me.DataGridViewImageColumn1.Image = CType(resources.GetObject("DataGridViewImageColumn1.Image"), System.Drawing.Image)
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewImageColumn1.Width = 80
        '
        'btn_sel
        '
        Me.btn_sel.AutoSize = True
        Me.btn_sel.BackColor = System.Drawing.Color.DimGray
        Me.btn_sel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_sel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_sel.ForeColor = System.Drawing.Color.White
        Me.btn_sel.Image = CType(resources.GetObject("btn_sel.Image"), System.Drawing.Image)
        Me.btn_sel.Location = New System.Drawing.Point(3, 4)
        Me.btn_sel.Name = "btn_sel"
        Me.btn_sel.Size = New System.Drawing.Size(153, 40)
        Me.btn_sel.TabIndex = 11
        Me.btn_sel.Text = "เลือกสินค้าส่วนผสม"
        Me.btn_sel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_sel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_sel.UseVisualStyleBackColor = False
        '
        'btn_save
        '
        Me.btn_save.AutoSize = True
        Me.btn_save.BackColor = System.Drawing.Color.DimGray
        Me.btn_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_save.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_save.ForeColor = System.Drawing.Color.White
        Me.btn_save.Image = CType(resources.GetObject("btn_save.Image"), System.Drawing.Image)
        Me.btn_save.Location = New System.Drawing.Point(163, 4)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(96, 40)
        Me.btn_save.TabIndex = 0
        Me.btn_save.Text = "บันทึก"
        Me.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'colidPd
        '
        Me.colidPd.DataPropertyName = "colidPd"
        Me.colidPd.HeaderText = "colidPd"
        Me.colidPd.Name = "colidPd"
        Me.colidPd.Visible = False
        '
        'colproduct
        '
        Me.colproduct.DataPropertyName = "PdCodeName"
        Me.colproduct.HeaderText = "สินค้าตัวอย่าง"
        Me.colproduct.Name = "colproduct"
        Me.colproduct.ReadOnly = True
        Me.colproduct.Width = 300
        '
        'ingredient
        '
        Me.ingredient.DataPropertyName = "MixPerc"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.ingredient.DefaultCellStyle = DataGridViewCellStyle4
        Me.ingredient.HeaderText = "จำนวนส่วนผสม(%)"
        Me.ingredient.Name = "ingredient"
        Me.ingredient.Width = 150
        '
        'coldelete
        '
        Me.coldelete.HeaderText = "ลบ"
        Me.coldelete.Image = CType(resources.GetObject("coldelete.Image"), System.Drawing.Image)
        Me.coldelete.Name = "coldelete"
        Me.coldelete.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.coldelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.coldelete.Visible = False
        Me.coldelete.Width = 80
        '
        'PdCode
        '
        Me.PdCode.DataPropertyName = "PdCode"
        Me.PdCode.HeaderText = "PdCode"
        Me.PdCode.Name = "PdCode"
        Me.PdCode.Visible = False
        '
        'PdName
        '
        Me.PdName.DataPropertyName = "PdName"
        Me.PdName.HeaderText = "PdName"
        Me.PdName.Name = "PdName"
        Me.PdName.Visible = False
        '
        'frmPdIngredient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(455, 538)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "frmPdIngredient"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "กำหนดส่วนผสมสินค้า"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_sel As System.Windows.Forms.Button
    Friend WithEvents txt_note As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_FL As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents txt_type As System.Windows.Forms.TextBox
    Friend WithEvents txt_plant As System.Windows.Forms.TextBox
    Friend WithEvents txt_name As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents colidPd As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colproduct As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ingredient As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldelete As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents PdCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PdName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
End Class
