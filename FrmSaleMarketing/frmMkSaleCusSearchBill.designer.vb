<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMkSaleCusSearchBill
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMkSaleCusSearchBill))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.lblPdTName = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblCusName = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.dgvBillH = New System.Windows.Forms.DataGridView
        Me.ColBill = New System.Windows.Forms.DataGridViewImageColumn
        Me.ColidSale = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColDateSale = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColPrice = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Panel1.SuspendLayout()
        CType(Me.dgvBillH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPdTName
        '
        Me.lblPdTName.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblPdTName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPdTName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblPdTName.Location = New System.Drawing.Point(84, 15)
        Me.lblPdTName.Name = "lblPdTName"
        Me.lblPdTName.Size = New System.Drawing.Size(249, 20)
        Me.lblPdTName.TabIndex = 653
        Me.lblPdTName.Tag = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.Location = New System.Drawing.Point(28, 18)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 13)
        Me.Label10.TabIndex = 652
        Me.Label10.Text = "ชื่อสินค้า"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblCusName)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lblPdTName)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(364, 81)
        Me.Panel1.TabIndex = 654
        '
        'lblCusName
        '
        Me.lblCusName.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblCusName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCusName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblCusName.Location = New System.Drawing.Point(83, 45)
        Me.lblCusName.Name = "lblCusName"
        Me.lblCusName.Size = New System.Drawing.Size(249, 20)
        Me.lblCusName.TabIndex = 655
        Me.lblCusName.Tag = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(41, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 654
        Me.Label2.Text = "ลูกค้า"
        '
        'dgvBillH
        '
        Me.dgvBillH.AllowUserToAddRows = False
        Me.dgvBillH.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBillH.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvBillH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBillH.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColBill, Me.ColidSale, Me.ColDateSale, Me.ColPrice})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvBillH.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvBillH.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvBillH.EnableHeadersVisualStyles = False
        Me.dgvBillH.GridColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvBillH.Location = New System.Drawing.Point(0, 81)
        Me.dgvBillH.Name = "dgvBillH"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBillH.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvBillH.RowHeadersVisible = False
        Me.dgvBillH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvBillH.Size = New System.Drawing.Size(364, 381)
        Me.dgvBillH.TabIndex = 655
        '
        'ColBill
        '
        Me.ColBill.HeaderText = "บิล"
        Me.ColBill.Image = CType(resources.GetObject("ColBill.Image"), System.Drawing.Image)
        Me.ColBill.Name = "ColBill"
        Me.ColBill.Width = 60
        '
        'ColidSale
        '
        Me.ColidSale.DataPropertyName = "idSale"
        Me.ColidSale.HeaderText = "idSale"
        Me.ColidSale.Name = "ColidSale"
        Me.ColidSale.Visible = False
        '
        'ColDateSale
        '
        Me.ColDateSale.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColDateSale.DataPropertyName = "DateSale"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColDateSale.DefaultCellStyle = DataGridViewCellStyle2
        Me.ColDateSale.HeaderText = "วันที่ซื้อ"
        Me.ColDateSale.Name = "ColDateSale"
        Me.ColDateSale.ReadOnly = True
        Me.ColDateSale.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'ColPrice
        '
        Me.ColPrice.DataPropertyName = "Price"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColPrice.DefaultCellStyle = DataGridViewCellStyle3
        Me.ColPrice.HeaderText = "ราคา"
        Me.ColPrice.Name = "ColPrice"
        Me.ColPrice.ReadOnly = True
        Me.ColPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ColPrice.Width = 150
        '
        'frmMkSaleCusSearchBill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(364, 462)
        Me.Controls.Add(Me.dgvBillH)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.Name = "frmMkSaleCusSearchBill"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ประวัติการขายสินค้า"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvBillH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblPdTName As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblCusName As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgvBillH As System.Windows.Forms.DataGridView
    Friend WithEvents ColBill As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents ColidSale As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColDateSale As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColPrice As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
