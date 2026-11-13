<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAccountSaleMY
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAccountSaleMY))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtTotalNet = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.dgvSaleValue = New System.Windows.Forms.DataGridView()
        Me.ColNumM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColMonth = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColSaleValue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColSumSAM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColDiff = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbGroupComp = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpYear = New System.Windows.Forms.DateTimePicker()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtDiff = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTotalSAM = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvSaleValue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.txtTotalNet)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.btnSave)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 47)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(484, 34)
        Me.Panel2.TabIndex = 542
        '
        'txtTotalNet
        '
        Me.txtTotalNet.BackColor = System.Drawing.Color.Black
        Me.txtTotalNet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalNet.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTotalNet.ForeColor = System.Drawing.Color.Cyan
        Me.txtTotalNet.Location = New System.Drawing.Point(341, 5)
        Me.txtTotalNet.Name = "txtTotalNet"
        Me.txtTotalNet.ReadOnly = True
        Me.txtTotalNet.Size = New System.Drawing.Size(138, 24)
        Me.txtTotalNet.TabIndex = 581
        Me.txtTotalNet.Text = "0"
        Me.txtTotalNet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(187, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(149, 17)
        Me.Label2.TabIndex = 580
        Me.Label2.Text = "รวมยอดขายทางบัญชี : "
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.DimGray
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(0, 0)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(83, 32)
        Me.btnSave.TabIndex = 95
        Me.btnSave.Tag = "Save"
        Me.btnSave.Text = "       บันทึก"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'dgvSaleValue
        '
        Me.dgvSaleValue.AllowUserToAddRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSaleValue.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvSaleValue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSaleValue.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColNumM, Me.ColMonth, Me.ColSaleValue, Me.ColSumSAM, Me.ColDiff})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSaleValue.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvSaleValue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvSaleValue.Location = New System.Drawing.Point(0, 137)
        Me.dgvSaleValue.Name = "dgvSaleValue"
        Me.dgvSaleValue.RowHeadersVisible = False
        Me.dgvSaleValue.Size = New System.Drawing.Size(484, 300)
        Me.dgvSaleValue.TabIndex = 543
        '
        'ColNumM
        '
        Me.ColNumM.HeaderText = "idMonth"
        Me.ColNumM.Name = "ColNumM"
        Me.ColNumM.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ColNumM.Visible = False
        '
        'ColMonth
        '
        Me.ColMonth.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.PaleGreen
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.ColMonth.DefaultCellStyle = DataGridViewCellStyle2
        Me.ColMonth.HeaderText = "เดือน"
        Me.ColMonth.Name = "ColMonth"
        Me.ColMonth.ReadOnly = True
        Me.ColMonth.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'ColSaleValue
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "#,##0.00##"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.ColSaleValue.DefaultCellStyle = DataGridViewCellStyle3
        Me.ColSaleValue.HeaderText = "ยอดขายบัญชี (บาท)"
        Me.ColSaleValue.Name = "ColSaleValue"
        Me.ColSaleValue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ColSaleValue.Width = 130
        '
        'ColSumSAM
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle4.Format = "#,##0.00##"
        DataGridViewCellStyle4.NullValue = "0.00"
        Me.ColSumSAM.DefaultCellStyle = DataGridViewCellStyle4
        Me.ColSumSAM.HeaderText = "ยอดขาย SAM (บาท)"
        Me.ColSumSAM.Name = "ColSumSAM"
        Me.ColSumSAM.ReadOnly = True
        Me.ColSumSAM.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ColSumSAM.Visible = False
        Me.ColSumSAM.Width = 140
        '
        'ColDiff
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle5.Format = "#,##0.00##"
        DataGridViewCellStyle5.NullValue = "0.00"
        Me.ColDiff.DefaultCellStyle = DataGridViewCellStyle5
        Me.ColDiff.HeaderText = "ส่วนต่าง"
        Me.ColDiff.Name = "ColDiff"
        Me.ColDiff.ReadOnly = True
        Me.ColDiff.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ColDiff.Visible = False
        Me.ColDiff.Width = 110
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.cmbGroupComp)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.dtpYear)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(484, 47)
        Me.Panel1.TabIndex = 544
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(23, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 18)
        Me.Label6.TabIndex = 764
        Me.Label6.Text = "บริษัท"
        '
        'cmbGroupComp
        '
        Me.cmbGroupComp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGroupComp.FormattingEnabled = True
        Me.cmbGroupComp.Location = New System.Drawing.Point(74, 12)
        Me.cmbGroupComp.Name = "cmbGroupComp"
        Me.cmbGroupComp.Size = New System.Drawing.Size(188, 21)
        Me.cmbGroupComp.TabIndex = 765
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(275, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 18)
        Me.Label1.TabIndex = 653
        Me.Label1.Text = "ยอดขายปี"
        '
        'dtpYear
        '
        Me.dtpYear.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpYear.CausesValidation = False
        Me.dtpYear.CustomFormat = "yyyy"
        Me.dtpYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpYear.Location = New System.Drawing.Point(349, 9)
        Me.dtpYear.Name = "dtpYear"
        Me.dtpYear.ShowUpDown = True
        Me.dtpYear.Size = New System.Drawing.Size(78, 26)
        Me.dtpYear.TabIndex = 652
        Me.dtpYear.Value = New Date(2020, 3, 10, 14, 12, 59, 0)
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel3.Controls.Add(Me.txtDiff)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.txtTotalSAM)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 81)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(484, 56)
        Me.Panel3.TabIndex = 545
        Me.Panel3.Visible = False
        '
        'txtDiff
        '
        Me.txtDiff.BackColor = System.Drawing.Color.Black
        Me.txtDiff.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDiff.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtDiff.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtDiff.Location = New System.Drawing.Point(341, 29)
        Me.txtDiff.Name = "txtDiff"
        Me.txtDiff.ReadOnly = True
        Me.txtDiff.Size = New System.Drawing.Size(138, 24)
        Me.txtDiff.TabIndex = 583
        Me.txtDiff.Text = "0"
        Me.txtDiff.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(274, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 16)
        Me.Label3.TabIndex = 582
        Me.Label3.Text = "ส่วนต่าง :"
        '
        'txtTotalSAM
        '
        Me.txtTotalSAM.BackColor = System.Drawing.Color.Black
        Me.txtTotalSAM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalSAM.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTotalSAM.ForeColor = System.Drawing.Color.Yellow
        Me.txtTotalSAM.Location = New System.Drawing.Point(341, 3)
        Me.txtTotalSAM.Name = "txtTotalSAM"
        Me.txtTotalSAM.ReadOnly = True
        Me.txtTotalSAM.Size = New System.Drawing.Size(138, 24)
        Me.txtTotalSAM.TabIndex = 581
        Me.txtTotalSAM.Text = "0"
        Me.txtTotalSAM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(188, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(148, 15)
        Me.Label5.TabIndex = 580
        Me.Label5.Text = "รวมยอดขายระบบ SAM : "
        '
        'frmAccountSaleMY
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(484, 437)
        Me.Controls.Add(Me.dgvSaleValue)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAccountSaleMY"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ยอดขายทางบัญชีประจำเดือน"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgvSaleValue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents dgvSaleValue As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpYear As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtTotalNet As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents txtTotalSAM As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDiff As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ColNumM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColMonth As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColSaleValue As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColSumSAM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColDiff As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbGroupComp As System.Windows.Forms.ComboBox
End Class
