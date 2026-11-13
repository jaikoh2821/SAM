<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMkPromotionPdSelect
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMkPromotionPdSelect))
        Me.dgvPd = New System.Windows.Forms.DataGridView
        Me.colSelect = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.ColChoose = New System.Windows.Forms.DataGridViewButtonColumn
        Me.ColID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColPlantName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColidPkUnit = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColPkUnitName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btn_add = New System.Windows.Forms.Button
        Me.btnSchPd = New System.Windows.Forms.Button
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.cmbUnit = New System.Windows.Forms.ComboBox
        Me.cmbWeight = New System.Windows.Forms.ComboBox
        Me.ChkWeight = New System.Windows.Forms.CheckBox
        Me.txtPdName = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.dgvPd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
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
        Me.dgvPd.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colSelect, Me.ColChoose, Me.ColID, Me.ColName, Me.ColPlantName, Me.ColidPkUnit, Me.ColPkUnitName})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPd.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvPd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvPd.EnableHeadersVisualStyles = False
        Me.dgvPd.GridColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvPd.Location = New System.Drawing.Point(0, 137)
        Me.dgvPd.Name = "dgvPd"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPd.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvPd.RowHeadersVisible = False
        Me.dgvPd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvPd.Size = New System.Drawing.Size(484, 375)
        Me.dgvPd.TabIndex = 688
        '
        'colSelect
        '
        Me.colSelect.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.NullValue = False
        Me.colSelect.DefaultCellStyle = DataGridViewCellStyle2
        Me.colSelect.HeaderText = "เลือก"
        Me.colSelect.Name = "colSelect"
        Me.colSelect.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colSelect.Visible = False
        '
        'ColChoose
        '
        Me.ColChoose.HeaderText = "เลือก"
        Me.ColChoose.Name = "ColChoose"
        Me.ColChoose.Width = 40
        '
        'ColID
        '
        Me.ColID.DataPropertyName = "fId"
        Me.ColID.HeaderText = "id"
        Me.ColID.Name = "ColID"
        Me.ColID.Visible = False
        '
        'ColName
        '
        Me.ColName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColName.DataPropertyName = "fName"
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColName.DefaultCellStyle = DataGridViewCellStyle3
        Me.ColName.HeaderText = "ชื่อ"
        Me.ColName.Name = "ColName"
        '
        'ColPlantName
        '
        Me.ColPlantName.DataPropertyName = "PlantName"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColPlantName.DefaultCellStyle = DataGridViewCellStyle4
        Me.ColPlantName.HeaderText = "ประเภทพืช"
        Me.ColPlantName.Name = "ColPlantName"
        Me.ColPlantName.ReadOnly = True
        Me.ColPlantName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ColPlantName.Visible = False
        '
        'ColidPkUnit
        '
        Me.ColidPkUnit.DataPropertyName = "idPkUnit"
        Me.ColidPkUnit.HeaderText = "idPkUnit"
        Me.ColidPkUnit.Name = "ColidPkUnit"
        Me.ColidPkUnit.Visible = False
        '
        'ColPkUnitName
        '
        Me.ColPkUnitName.DataPropertyName = "PkUnitName"
        Me.ColPkUnitName.HeaderText = "PkUnitName"
        Me.ColPkUnitName.Name = "ColPkUnitName"
        Me.ColPkUnitName.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel1.Controls.Add(Me.btn_add)
        Me.Panel1.Controls.Add(Me.btnSchPd)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 103)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(484, 34)
        Me.Panel1.TabIndex = 689
        '
        'btn_add
        '
        Me.btn_add.AutoSize = True
        Me.btn_add.BackColor = System.Drawing.Color.DimGray
        Me.btn_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_add.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_add.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_add.ForeColor = System.Drawing.Color.White
        Me.btn_add.Image = Global.SAM.My.Resources.Resources.Add28
        Me.btn_add.Location = New System.Drawing.Point(115, 0)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(96, 34)
        Me.btn_add.TabIndex = 418
        Me.btn_add.Text = "ตกลง"
        Me.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_add.UseVisualStyleBackColor = False
        Me.btn_add.Visible = False
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
        Me.btnSchPd.Size = New System.Drawing.Size(115, 34)
        Me.btnSchPd.TabIndex = 582
        Me.btnSchPd.Tag = ""
        Me.btnSchPd.Text = "       แสดงข้อมูล"
        Me.btnSchPd.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.cmbUnit)
        Me.Panel2.Controls.Add(Me.cmbWeight)
        Me.Panel2.Controls.Add(Me.ChkWeight)
        Me.Panel2.Controls.Add(Me.txtPdName)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(484, 103)
        Me.Panel2.TabIndex = 690
        '
        'cmbUnit
        '
        Me.cmbUnit.Enabled = False
        Me.cmbUnit.FormattingEnabled = True
        Me.cmbUnit.Location = New System.Drawing.Point(285, 59)
        Me.cmbUnit.Name = "cmbUnit"
        Me.cmbUnit.Size = New System.Drawing.Size(69, 21)
        Me.cmbUnit.TabIndex = 10
        Me.cmbUnit.Visible = False
        '
        'cmbWeight
        '
        Me.cmbWeight.Enabled = False
        Me.cmbWeight.FormattingEnabled = True
        Me.cmbWeight.Location = New System.Drawing.Point(209, 59)
        Me.cmbWeight.Name = "cmbWeight"
        Me.cmbWeight.Size = New System.Drawing.Size(70, 21)
        Me.cmbWeight.TabIndex = 9
        Me.cmbWeight.Visible = False
        '
        'ChkWeight
        '
        Me.ChkWeight.AutoSize = True
        Me.ChkWeight.Location = New System.Drawing.Point(116, 63)
        Me.ChkWeight.Name = "ChkWeight"
        Me.ChkWeight.Size = New System.Drawing.Size(87, 17)
        Me.ChkWeight.TabIndex = 8
        Me.ChkWeight.Text = "น้ำหนักสินค้า"
        Me.ChkWeight.UseVisualStyleBackColor = True
        Me.ChkWeight.Visible = False
        '
        'txtPdName
        '
        Me.txtPdName.Location = New System.Drawing.Point(177, 27)
        Me.txtPdName.Name = "txtPdName"
        Me.txtPdName.Size = New System.Drawing.Size(177, 20)
        Me.txtPdName.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(113, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "ค้นหาสินค้า"
        '
        'frmMkPromotionPdSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(484, 512)
        Me.Controls.Add(Me.dgvPd)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.MaximizeBox = False
        Me.Name = "frmMkPromotionPdSelect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "เลือกรายการสินค้า"
        CType(Me.dgvPd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvPd As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn_add As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnSchPd As System.Windows.Forms.Button
    Friend WithEvents txtPdName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents colSelect As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ColChoose As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents ColID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColPlantName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColidPkUnit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColPkUnitName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChkWeight As System.Windows.Forms.CheckBox
    Friend WithEvents cmbUnit As System.Windows.Forms.ComboBox
    Friend WithEvents cmbWeight As System.Windows.Forms.ComboBox
End Class
