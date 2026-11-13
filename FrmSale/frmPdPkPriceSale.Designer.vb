<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPdPkPriceSale
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
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rb_all = New System.Windows.Forms.RadioButton
        Me.rb_1y = New System.Windows.Forms.RadioButton
        Me.rb_6m = New System.Windows.Forms.RadioButton
        Me.DGV = New System.Windows.Forms.DataGridView
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lb_PdPkName = New System.Windows.Forms.Label
        Me.lb_stPrice = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.colautonum = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colDateSale = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colDocCode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colCusName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colPsSale = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colPsTs = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colCompName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colPrice = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colNote = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colidPdPk = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colidSale = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colstSale = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label5 = New System.Windows.Forms.Label
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rb_all)
        Me.GroupBox1.Controls.Add(Me.rb_1y)
        Me.GroupBox1.Controls.Add(Me.rb_6m)
        Me.GroupBox1.Location = New System.Drawing.Point(326, 109)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(279, 46)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "เลือกช่วงเวลา"
        '
        'rb_all
        '
        Me.rb_all.AutoSize = True
        Me.rb_all.Location = New System.Drawing.Point(206, 19)
        Me.rb_all.Name = "rb_all"
        Me.rb_all.Size = New System.Drawing.Size(58, 17)
        Me.rb_all.TabIndex = 2
        Me.rb_all.Text = "ทั้งหมด"
        Me.rb_all.UseVisualStyleBackColor = True
        '
        'rb_1y
        '
        Me.rb_1y.AutoSize = True
        Me.rb_1y.Location = New System.Drawing.Point(120, 19)
        Me.rb_1y.Name = "rb_1y"
        Me.rb_1y.Size = New System.Drawing.Size(80, 17)
        Me.rb_1y.TabIndex = 1
        Me.rb_1y.Text = "1 ปีที่ผ่านมา"
        Me.rb_1y.UseVisualStyleBackColor = True
        '
        'rb_6m
        '
        Me.rb_6m.AutoSize = True
        Me.rb_6m.Checked = True
        Me.rb_6m.Location = New System.Drawing.Point(15, 19)
        Me.rb_6m.Name = "rb_6m"
        Me.rb_6m.Size = New System.Drawing.Size(99, 17)
        Me.rb_6m.TabIndex = 0
        Me.rb_6m.TabStop = True
        Me.rb_6m.Text = "6 เดือนที่ผ่านมา"
        Me.rb_6m.UseVisualStyleBackColor = True
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGV.BackgroundColor = System.Drawing.Color.Lavender
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colautonum, Me.colDateSale, Me.colDocCode, Me.colCusName, Me.colPsSale, Me.colPsTs, Me.colCompName, Me.colPrice, Me.colNote, Me.colidPdPk, Me.colidSale, Me.colstSale})
        Me.DGV.Location = New System.Drawing.Point(0, 208)
        Me.DGV.Name = "DGV"
        Me.DGV.RowHeadersVisible = False
        Me.DGV.Size = New System.Drawing.Size(984, 354)
        Me.DGV.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(0, 161)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(984, 25)
        Me.Panel1.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(380, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(175, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "รายละเอียดราคาขาย 6 เดือนก่อนหน้า"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(309, 29)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "รายละเอียดราคาขายของสินค้า"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "ชื่อสินค้า"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "ประเภทราคา"
        '
        'lb_PdPkName
        '
        Me.lb_PdPkName.AutoSize = True
        Me.lb_PdPkName.Location = New System.Drawing.Point(130, 53)
        Me.lb_PdPkName.Name = "lb_PdPkName"
        Me.lb_PdPkName.Size = New System.Drawing.Size(39, 13)
        Me.lb_PdPkName.TabIndex = 6
        Me.lb_PdPkName.Text = "Label5"
        '
        'lb_stPrice
        '
        Me.lb_stPrice.AutoSize = True
        Me.lb_stPrice.Location = New System.Drawing.Point(130, 82)
        Me.lb_stPrice.Name = "lb_stPrice"
        Me.lb_stPrice.Size = New System.Drawing.Size(39, 13)
        Me.lb_stPrice.TabIndex = 7
        Me.lb_stPrice.Text = "Label6"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(566, 189)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(418, 16)
        Me.Label6.TabIndex = 408
        Me.Label6.Text = "สถานะสีที่แสดงในตารางหมายถึงราคาสินค้าที่ได้โปรโมชั่น และสามารถคลิกดูรายละเอียดได" & _
            "้"
        '
        'colautonum
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro
        Me.colautonum.DefaultCellStyle = DataGridViewCellStyle2
        Me.colautonum.HeaderText = "ลำดับ"
        Me.colautonum.Name = "colautonum"
        Me.colautonum.ReadOnly = True
        Me.colautonum.Width = 50
        '
        'colDateSale
        '
        Me.colDateSale.DataPropertyName = "DateSale"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Gainsboro
        Me.colDateSale.DefaultCellStyle = DataGridViewCellStyle3
        Me.colDateSale.HeaderText = "วันที่ขาย"
        Me.colDateSale.Name = "colDateSale"
        Me.colDateSale.ReadOnly = True
        Me.colDateSale.Width = 80
        '
        'colDocCode
        '
        Me.colDocCode.DataPropertyName = "DocCode"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Gainsboro
        Me.colDocCode.DefaultCellStyle = DataGridViewCellStyle4
        Me.colDocCode.HeaderText = "เลขที่รายการ"
        Me.colDocCode.Name = "colDocCode"
        Me.colDocCode.ReadOnly = True
        Me.colDocCode.Width = 90
        '
        'colCusName
        '
        Me.colCusName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colCusName.DataPropertyName = "CusName"
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Gainsboro
        Me.colCusName.DefaultCellStyle = DataGridViewCellStyle5
        Me.colCusName.HeaderText = "ชื่อลูกค้า"
        Me.colCusName.Name = "colCusName"
        Me.colCusName.ReadOnly = True
        '
        'colPsSale
        '
        Me.colPsSale.DataPropertyName = "PsSale"
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.Gainsboro
        Me.colPsSale.DefaultCellStyle = DataGridViewCellStyle6
        Me.colPsSale.HeaderText = "เจ้าหน้าที่ขาย"
        Me.colPsSale.Name = "colPsSale"
        Me.colPsSale.ReadOnly = True
        '
        'colPsTs
        '
        Me.colPsTs.DataPropertyName = "PsTs"
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.Gainsboro
        Me.colPsTs.DefaultCellStyle = DataGridViewCellStyle7
        Me.colPsTs.HeaderText = "ผู้ทำรายการ"
        Me.colPsTs.Name = "colPsTs"
        Me.colPsTs.ReadOnly = True
        '
        'colCompName
        '
        Me.colCompName.DataPropertyName = "CompName"
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.Gainsboro
        Me.colCompName.DefaultCellStyle = DataGridViewCellStyle8
        Me.colCompName.HeaderText = "บริษัทที่ขาย"
        Me.colCompName.Name = "colCompName"
        Me.colCompName.ReadOnly = True
        Me.colCompName.Width = 150
        '
        'colPrice
        '
        Me.colPrice.DataPropertyName = "Price"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle9.Format = "N2"
        DataGridViewCellStyle9.NullValue = Nothing
        Me.colPrice.DefaultCellStyle = DataGridViewCellStyle9
        Me.colPrice.HeaderText = "ราคา"
        Me.colPrice.Name = "colPrice"
        Me.colPrice.ReadOnly = True
        '
        'colNote
        '
        Me.colNote.DataPropertyName = "Note"
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.Gainsboro
        Me.colNote.DefaultCellStyle = DataGridViewCellStyle10
        Me.colNote.HeaderText = "หมายเหตุ"
        Me.colNote.Name = "colNote"
        Me.colNote.ReadOnly = True
        Me.colNote.Width = 120
        '
        'colidPdPk
        '
        Me.colidPdPk.DataPropertyName = "idPdPk"
        Me.colidPdPk.HeaderText = "idPdPk"
        Me.colidPdPk.Name = "colidPdPk"
        Me.colidPdPk.ReadOnly = True
        Me.colidPdPk.Visible = False
        '
        'colidSale
        '
        Me.colidSale.DataPropertyName = "idSale"
        Me.colidSale.HeaderText = "idSale"
        Me.colidSale.Name = "colidSale"
        Me.colidSale.ReadOnly = True
        Me.colidSale.Visible = False
        '
        'colstSale
        '
        Me.colstSale.DataPropertyName = "stSale"
        Me.colstSale.HeaderText = "stSale"
        Me.colstSale.Name = "colstSale"
        Me.colstSale.ReadOnly = True
        Me.colstSale.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(679, 4)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(171, 16)
        Me.Label5.TabIndex = 409
        Me.Label5.Text = "รายการสินค้าที่ได้โปรโมชั่นทั้งหมด "
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'frmPdPkPriceSale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(984, 562)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lb_stPrice)
        Me.Controls.Add(Me.lb_PdPkName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmPdPkPriceSale"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "รายละเอียดราคาขาย"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_all As System.Windows.Forms.RadioButton
    Friend WithEvents rb_1y As System.Windows.Forms.RadioButton
    Friend WithEvents rb_6m As System.Windows.Forms.RadioButton
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lb_PdPkName As System.Windows.Forms.Label
    Friend WithEvents lb_stPrice As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents colautonum As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDateSale As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDocCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCusName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPsSale As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPsTs As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCompName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colNote As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colidPdPk As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colidSale As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colstSale As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
End Class
