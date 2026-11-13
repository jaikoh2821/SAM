<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPsSaleSummaryPerson
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPsSaleSummaryPerson))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbPsSale = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtpMonthE = New System.Windows.Forms.DateTimePicker
        Me.dtpMonthS = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.dgvCus = New System.Windows.Forms.DataGridView
        Me.ColNum = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColidCus = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColCusName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColAddress = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColTotalSale = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btnPrint = New System.Windows.Forms.Button
        Me.txtTotalNet = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnSchPd = New System.Windows.Forms.Button
        Me.btnSearch = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        CType(Me.dgvCus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.cmbPsSale)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.dtpMonthE)
        Me.Panel1.Controls.Add(Me.dtpMonthS)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(834, 105)
        Me.Panel1.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(249, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 15)
        Me.Label3.TabIndex = 654
        Me.Label3.Text = "ยอดขายเดือน :"
        '
        'cmbPsSale
        '
        Me.cmbPsSale.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmbPsSale.FormattingEnabled = True
        Me.cmbPsSale.Location = New System.Drawing.Point(344, 22)
        Me.cmbPsSale.Name = "cmbPsSale"
        Me.cmbPsSale.Size = New System.Drawing.Size(142, 23)
        Me.cmbPsSale.TabIndex = 610
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(251, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 15)
        Me.Label2.TabIndex = 611
        Me.Label2.Text = "เจ้าหน้าที่ขาย :"
        '
        'dtpMonthE
        '
        Me.dtpMonthE.Checked = False
        Me.dtpMonthE.CustomFormat = "MMMM /yyyy"
        Me.dtpMonthE.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpMonthE.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpMonthE.Location = New System.Drawing.Point(513, 61)
        Me.dtpMonthE.Name = "dtpMonthE"
        Me.dtpMonthE.Size = New System.Drawing.Size(138, 20)
        Me.dtpMonthE.TabIndex = 653
        '
        'dtpMonthS
        '
        Me.dtpMonthS.Checked = False
        Me.dtpMonthS.CustomFormat = "MMMM /yyyy"
        Me.dtpMonthS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpMonthS.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpMonthS.Location = New System.Drawing.Point(344, 60)
        Me.dtpMonthS.Name = "dtpMonthS"
        Me.dtpMonthS.Size = New System.Drawing.Size(142, 20)
        Me.dtpMonthS.TabIndex = 652
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(488, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 13)
        Me.Label1.TabIndex = 651
        Me.Label1.Text = "ถึง"
        '
        'dgvCus
        '
        Me.dgvCus.AllowUserToAddRows = False
        Me.dgvCus.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCus.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCus.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColNum, Me.ColidCus, Me.ColCusName, Me.ColAddress, Me.ColTotalSale})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCus.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvCus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvCus.EnableHeadersVisualStyles = False
        Me.dgvCus.GridColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvCus.Location = New System.Drawing.Point(0, 143)
        Me.dgvCus.Name = "dgvCus"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCus.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvCus.RowHeadersVisible = False
        Me.dgvCus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvCus.Size = New System.Drawing.Size(834, 369)
        Me.dgvCus.TabIndex = 613
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
        'ColidCus
        '
        Me.ColidCus.DataPropertyName = "idCus"
        Me.ColidCus.HeaderText = "idCus"
        Me.ColidCus.Name = "ColidCus"
        Me.ColidCus.Visible = False
        '
        'ColCusName
        '
        Me.ColCusName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColCusName.DataPropertyName = "CusName"
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColCusName.DefaultCellStyle = DataGridViewCellStyle3
        Me.ColCusName.HeaderText = "ชื่อลูกค้า"
        Me.ColCusName.Name = "ColCusName"
        Me.ColCusName.ReadOnly = True
        Me.ColCusName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'ColAddress
        '
        Me.ColAddress.DataPropertyName = "Address"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColAddress.DefaultCellStyle = DataGridViewCellStyle4
        Me.ColAddress.HeaderText = "ที่อยู่"
        Me.ColAddress.Name = "ColAddress"
        Me.ColAddress.ReadOnly = True
        Me.ColAddress.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ColAddress.Width = 400
        '
        'ColTotalSale
        '
        Me.ColTotalSale.DataPropertyName = "TotalSale"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.ColTotalSale.DefaultCellStyle = DataGridViewCellStyle5
        Me.ColTotalSale.HeaderText = "ยอดขาย"
        Me.ColTotalSale.Name = "ColTotalSale"
        Me.ColTotalSale.ReadOnly = True
        Me.ColTotalSale.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ColTotalSale.Width = 150
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnPrint)
        Me.Panel2.Controls.Add(Me.txtTotalNet)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.btnSchPd)
        Me.Panel2.Controls.Add(Me.btnSearch)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 105)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(834, 38)
        Me.Panel2.TabIndex = 614
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.DimGray
        Me.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrint.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnPrint.ForeColor = System.Drawing.Color.White
        Me.btnPrint.Image = Global.SAM.My.Resources.Resources.Printers
        Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrint.Location = New System.Drawing.Point(115, 0)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(125, 36)
        Me.btnPrint.TabIndex = 584
        Me.btnPrint.Tag = ""
        Me.btnPrint.Text = "       Print / PDF"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'txtTotalNet
        '
        Me.txtTotalNet.BackColor = System.Drawing.Color.Black
        Me.txtTotalNet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalNet.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTotalNet.ForeColor = System.Drawing.Color.Lime
        Me.txtTotalNet.Location = New System.Drawing.Point(647, 4)
        Me.txtTotalNet.Name = "txtTotalNet"
        Me.txtTotalNet.ReadOnly = True
        Me.txtTotalNet.Size = New System.Drawing.Size(174, 27)
        Me.txtTotalNet.TabIndex = 583
        Me.txtTotalNet.Text = "0"
        Me.txtTotalNet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(540, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 17)
        Me.Label4.TabIndex = 582
        Me.Label4.Text = "ยอดขายทั้งหมด"
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
        Me.btnSchPd.Size = New System.Drawing.Size(115, 36)
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
        'frmPsSaleSummaryPerson
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(834, 512)
        Me.Controls.Add(Me.dgvCus)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmPsSaleSummaryPerson"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "สรุปยอดเจ้าหน้าที่ขายแต่ละคนแยกตามลูกค้า"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvCus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents dgvCus As System.Windows.Forms.DataGridView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnSchPd As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents cmbPsSale As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpMonthE As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpMonthS As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTotalNet As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ColNum As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColidCus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColCusName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColAddress As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColTotalSale As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnPrint As System.Windows.Forms.Button
End Class
