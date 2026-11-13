<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSetDebtCus
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSetDebtCus))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.tbDebtYear = New System.Windows.Forms.TextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btn_save = New System.Windows.Forms.Button
        Me.dgvDebt = New System.Windows.Forms.DataGridView
        Me.colSelect = New System.Windows.Forms.DataGridViewButtonColumn
        Me.colMonthName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colDebt = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colMonth = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Panel1.SuspendLayout()
        CType(Me.dgvDebt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "yyyy"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(183, 31)
        Me.DateTimePicker1.MaxDate = New Date(2013, 7, 29, 13, 47, 38, 0)
        Me.DateTimePicker1.MinimumSize = New System.Drawing.Size(4, 30)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.ShowUpDown = True
        Me.DateTimePicker1.Size = New System.Drawing.Size(60, 30)
        Me.DateTimePicker1.TabIndex = 0
        Me.DateTimePicker1.Value = New Date(2013, 7, 29, 0, 0, 0, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(145, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ระบุปี"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(98, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ระบุยอดหนี้ทั้งปี"
        '
        'tbDebtYear
        '
        Me.tbDebtYear.Location = New System.Drawing.Point(183, 83)
        Me.tbDebtYear.Name = "tbDebtYear"
        Me.tbDebtYear.Size = New System.Drawing.Size(100, 20)
        Me.tbDebtYear.TabIndex = 3
        Me.tbDebtYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.btn_save)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 430)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(415, 40)
        Me.Panel1.TabIndex = 622
        '
        'btn_save
        '
        Me.btn_save.AutoSize = True
        Me.btn_save.BackColor = System.Drawing.Color.DimGray
        Me.btn_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_save.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_save.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_save.ForeColor = System.Drawing.Color.White
        Me.btn_save.Image = CType(resources.GetObject("btn_save.Image"), System.Drawing.Image)
        Me.btn_save.Location = New System.Drawing.Point(0, 0)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(96, 36)
        Me.btn_save.TabIndex = 10
        Me.btn_save.Text = "บันทึก"
        Me.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'dgvDebt
        '
        Me.dgvDebt.AllowUserToAddRows = False
        Me.dgvDebt.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDebt.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvDebt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDebt.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colSelect, Me.colMonthName, Me.colDebt, Me.colMonth})
        Me.dgvDebt.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvDebt.Location = New System.Drawing.Point(0, 140)
        Me.dgvDebt.Name = "dgvDebt"
        Me.dgvDebt.RowHeadersVisible = False
        Me.dgvDebt.Size = New System.Drawing.Size(415, 290)
        Me.dgvDebt.TabIndex = 623
        '
        'colSelect
        '
        Me.colSelect.HeaderText = "กำหนดยอดหนี้ของคู่ค้า"
        Me.colSelect.Name = "colSelect"
        Me.colSelect.Width = 120
        '
        'colMonthName
        '
        Me.colMonthName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colMonthName.DataPropertyName = "MonthName"
        Me.colMonthName.HeaderText = "เดือน"
        Me.colMonthName.Name = "colMonthName"
        Me.colMonthName.ReadOnly = True
        Me.colMonthName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colDebt
        '
        Me.colDebt.DataPropertyName = "Debt"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.colDebt.DefaultCellStyle = DataGridViewCellStyle2
        Me.colDebt.HeaderText = "ระบุยอดหนี้ค้างแต่ละเดือน"
        Me.colDebt.Name = "colDebt"
        Me.colDebt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colDebt.Width = 160
        '
        'colMonth
        '
        Me.colMonth.DataPropertyName = "Month_"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colMonth.DefaultCellStyle = DataGridViewCellStyle3
        Me.colMonth.HeaderText = "Month_"
        Me.colMonth.Name = "colMonth"
        Me.colMonth.ReadOnly = True
        Me.colMonth.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colMonth.Visible = False
        '
        'frmSetDebtCus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(415, 470)
        Me.Controls.Add(Me.dgvDebt)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.tbDebtYear)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.MaximizeBox = False
        Me.Name = "frmSetDebtCus"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "บันทึกยอดหนี้คงค้างของคู่ค้าจากระบบบัญชี"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvDebt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbDebtYear As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents dgvDebt As System.Windows.Forms.DataGridView
    Friend WithEvents colSelect As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents colMonthName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDebt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMonth As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
