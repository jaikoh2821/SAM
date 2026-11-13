<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPsSaleLineSummary
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.dgv_SaleSum = New System.Windows.Forms.DataGridView()
        Me.colautonum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPsSale = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTotalNet = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colRatio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colidPsSale = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbYear = New System.Windows.Forms.RadioButton()
        Me.rbMonth = New System.Windows.Forms.RadioButton()
        Me.dtpYear = New System.Windows.Forms.DateTimePicker()
        Me.dtpMonth = New System.Windows.Forms.DateTimePicker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblAllTotal = New System.Windows.Forms.Label()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        CType(Me.dgv_SaleSum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'TreeView1
        '
        Me.TreeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView1.Location = New System.Drawing.Point(0, 24)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(624, 433)
        Me.TreeView1.TabIndex = 0
        '
        'dgv_SaleSum
        '
        Me.dgv_SaleSum.AllowUserToAddRows = False
        Me.dgv_SaleSum.BackgroundColor = System.Drawing.Color.Lavender
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_SaleSum.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_SaleSum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_SaleSum.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colautonum, Me.colPsSale, Me.colTotalNet, Me.colRatio, Me.colidPsSale})
        Me.dgv_SaleSum.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_SaleSum.Location = New System.Drawing.Point(0, 24)
        Me.dgv_SaleSum.Name = "dgv_SaleSum"
        Me.dgv_SaleSum.RowHeadersVisible = False
        Me.dgv_SaleSum.Size = New System.Drawing.Size(360, 433)
        Me.dgv_SaleSum.TabIndex = 1
        '
        'colautonum
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro
        Me.colautonum.DefaultCellStyle = DataGridViewCellStyle2
        Me.colautonum.HeaderText = "ลำดับ"
        Me.colautonum.Name = "colautonum"
        Me.colautonum.ReadOnly = True
        Me.colautonum.Width = 40
        '
        'colPsSale
        '
        Me.colPsSale.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colPsSale.DataPropertyName = "PsSale"
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Gainsboro
        Me.colPsSale.DefaultCellStyle = DataGridViewCellStyle3
        Me.colPsSale.HeaderText = "ชื่อเจ้าหน้าที่ขาย"
        Me.colPsSale.Name = "colPsSale"
        Me.colPsSale.ReadOnly = True
        '
        'colTotalNet
        '
        Me.colTotalNet.DataPropertyName = "TotalNet"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.colTotalNet.DefaultCellStyle = DataGridViewCellStyle4
        Me.colTotalNet.HeaderText = "ยอดขาย"
        Me.colTotalNet.Name = "colTotalNet"
        Me.colTotalNet.ReadOnly = True
        '
        'colRatio
        '
        Me.colRatio.DataPropertyName = "ratio"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Gainsboro
        Me.colRatio.DefaultCellStyle = DataGridViewCellStyle5
        Me.colRatio.HeaderText = "สัดส่วน"
        Me.colRatio.Name = "colRatio"
        Me.colRatio.ReadOnly = True
        Me.colRatio.Width = 70
        '
        'colidPsSale
        '
        Me.colidPsSale.DataPropertyName = "idPsSale"
        Me.colidPsSale.HeaderText = "idPsSale"
        Me.colidPsSale.Name = "colidPsSale"
        Me.colidPsSale.ReadOnly = True
        Me.colidPsSale.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbYear)
        Me.GroupBox1.Controls.Add(Me.rbMonth)
        Me.GroupBox1.Controls.Add(Me.dtpYear)
        Me.GroupBox1.Controls.Add(Me.dtpMonth)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(371, 63)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "เลือกช่วงข้อมูล"
        '
        'rbYear
        '
        Me.rbYear.AutoSize = True
        Me.rbYear.Location = New System.Drawing.Point(236, 25)
        Me.rbYear.Name = "rbYear"
        Me.rbYear.Size = New System.Drawing.Size(41, 17)
        Me.rbYear.TabIndex = 5
        Me.rbYear.Text = "ปี : "
        Me.rbYear.UseVisualStyleBackColor = True
        '
        'rbMonth
        '
        Me.rbMonth.AutoSize = True
        Me.rbMonth.Checked = True
        Me.rbMonth.Location = New System.Drawing.Point(28, 24)
        Me.rbMonth.Name = "rbMonth"
        Me.rbMonth.Size = New System.Drawing.Size(60, 17)
        Me.rbMonth.TabIndex = 4
        Me.rbMonth.TabStop = True
        Me.rbMonth.Text = "เดือน : "
        Me.rbMonth.UseVisualStyleBackColor = True
        '
        'dtpYear
        '
        Me.dtpYear.CustomFormat = "yyyy"
        Me.dtpYear.Enabled = False
        Me.dtpYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpYear.Location = New System.Drawing.Point(280, 19)
        Me.dtpYear.MinimumSize = New System.Drawing.Size(4, 30)
        Me.dtpYear.Name = "dtpYear"
        Me.dtpYear.ShowUpDown = True
        Me.dtpYear.Size = New System.Drawing.Size(60, 30)
        Me.dtpYear.TabIndex = 2
        '
        'dtpMonth
        '
        Me.dtpMonth.CustomFormat = "MMMM/yyyy"
        Me.dtpMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpMonth.Location = New System.Drawing.Point(91, 19)
        Me.dtpMonth.MinimumSize = New System.Drawing.Size(4, 30)
        Me.dtpMonth.Name = "dtpMonth"
        Me.dtpMonth.ShowUpDown = True
        Me.dtpMonth.Size = New System.Drawing.Size(130, 30)
        Me.dtpMonth.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblAllTotal)
        Me.Panel1.Controls.Add(Me.btnShow)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 71)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(984, 34)
        Me.Panel1.TabIndex = 624
        '
        'lblAllTotal
        '
        Me.lblAllTotal.AutoSize = True
        Me.lblAllTotal.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblAllTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblAllTotal.ForeColor = System.Drawing.Color.Yellow
        Me.lblAllTotal.Location = New System.Drawing.Point(868, 0)
        Me.lblAllTotal.Name = "lblAllTotal"
        Me.lblAllTotal.Size = New System.Drawing.Size(114, 20)
        Me.lblAllTotal.TabIndex = 400
        Me.lblAllTotal.Text = "ยอดขายทั้งหมด"
        '
        'btnShow
        '
        Me.btnShow.BackColor = System.Drawing.Color.DimGray
        Me.btnShow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnShow.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnShow.ForeColor = System.Drawing.Color.White
        Me.btnShow.Image = Global.SAM.My.Resources.Resources.Find
        Me.btnShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnShow.Location = New System.Drawing.Point(0, 0)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(103, 32)
        Me.btnShow.TabIndex = 399
        Me.btnShow.Text = "แสดงข้อมูล"
        Me.btnShow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnShow.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(624, 24)
        Me.Panel2.TabIndex = 649
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(223, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "สายงานเจ้าหน้าที่ขาย"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(360, 24)
        Me.Panel3.TabIndex = 650
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(131, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ยอดขายเจ้าหน้าที่ขาย"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.GroupBox1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(984, 71)
        Me.Panel4.TabIndex = 6
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Panel7)
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 105)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(984, 457)
        Me.Panel5.TabIndex = 651
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.TreeView1)
        Me.Panel7.Controls.Add(Me.Panel2)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(624, 457)
        Me.Panel7.TabIndex = 1
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.dgv_SaleSum)
        Me.Panel6.Controls.Add(Me.Panel3)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel6.Location = New System.Drawing.Point(624, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(360, 457)
        Me.Panel6.TabIndex = 0
        '
        'frmPsSaleLineSummary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(984, 562)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "frmPsSaleLineSummary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "สรุปยอดขายแยกตามสายงาน"
        CType(Me.dgv_SaleSum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents dgv_SaleSum As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbYear As System.Windows.Forms.RadioButton
    Friend WithEvents rbMonth As System.Windows.Forms.RadioButton
    Friend WithEvents dtpYear As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpMonth As System.Windows.Forms.DateTimePicker
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblAllTotal As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents colautonum As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPsSale As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTotalNet As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colRatio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colidPsSale As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
