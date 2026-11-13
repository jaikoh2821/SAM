<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCusLevelData
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Button1 = New System.Windows.Forms.Button
        Me.dgvData = New System.Windows.Forms.DataGridView
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn
        Me.colautonum = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colcancel = New System.Windows.Forms.DataGridViewImageColumn
        Me.CusType = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PriceRetail = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PriceBill = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PriceWholeSale = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CreditTotal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Note = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.idCusType = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Panel2.SuspendLayout()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(956, 40)
        Me.Panel2.TabIndex = 422
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.BackColor = System.Drawing.Color.DimGray
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = Global.SAM.My.Resources.Resources.Add28
        Me.Button1.Location = New System.Drawing.Point(11, -1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 40)
        Me.Button1.TabIndex = 425
        Me.Button1.Text = "เพิ่ม"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'dgvData
        '
        Me.dgvData.AllowDrop = True
        Me.dgvData.AllowUserToAddRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colautonum, Me.colcancel, Me.CusType, Me.PriceRetail, Me.PriceBill, Me.PriceWholeSale, Me.CreditTotal, Me.Note, Me.idCusType})
        Me.dgvData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvData.Location = New System.Drawing.Point(0, 40)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.RowHeadersVisible = False
        Me.dgvData.Size = New System.Drawing.Size(956, 411)
        Me.dgvData.TabIndex = 421
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = "เลือก"
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Width = 35
        '
        'DataGridViewImageColumn2
        '
        Me.DataGridViewImageColumn2.HeaderText = "ยกเลิก"
        Me.DataGridViewImageColumn2.Image = Global.SAM.My.Resources.Resources.cross_circle_frame
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        Me.DataGridViewImageColumn2.Width = 50
        '
        'colautonum
        '
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.colautonum.DefaultCellStyle = DataGridViewCellStyle2
        Me.colautonum.HeaderText = "ลำดับ"
        Me.colautonum.Name = "colautonum"
        Me.colautonum.ReadOnly = True
        Me.colautonum.Width = 35
        '
        'colcancel
        '
        Me.colcancel.HeaderText = "แก้ไข"
        Me.colcancel.Image = Global.SAM.My.Resources.Resources.gdEdit
        Me.colcancel.Name = "colcancel"
        Me.colcancel.Width = 50
        '
        'CusType
        '
        Me.CusType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.CusType.DataPropertyName = "CusType"
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CusType.DefaultCellStyle = DataGridViewCellStyle3
        Me.CusType.HeaderText = "ชื่อระดับ"
        Me.CusType.Name = "CusType"
        Me.CusType.ReadOnly = True
        Me.CusType.Width = 184
        '
        'PriceRetail
        '
        Me.PriceRetail.DataPropertyName = "PriceRetail"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PriceRetail.DefaultCellStyle = DataGridViewCellStyle4
        Me.PriceRetail.HeaderText = "ราคาปลีกถูกลง (%)"
        Me.PriceRetail.Name = "PriceRetail"
        Me.PriceRetail.ReadOnly = True
        Me.PriceRetail.Width = 150
        '
        'PriceBill
        '
        Me.PriceBill.DataPropertyName = "PriceBill"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PriceBill.DefaultCellStyle = DataGridViewCellStyle5
        Me.PriceBill.HeaderText = "ราคาหน้าบิลถูกลง (%)"
        Me.PriceBill.Name = "PriceBill"
        Me.PriceBill.ReadOnly = True
        Me.PriceBill.Width = 150
        '
        'PriceWholeSale
        '
        Me.PriceWholeSale.DataPropertyName = "PriceWholeSale"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PriceWholeSale.DefaultCellStyle = DataGridViewCellStyle6
        Me.PriceWholeSale.HeaderText = "ราคาส่งถูกลง (%)"
        Me.PriceWholeSale.Name = "PriceWholeSale"
        Me.PriceWholeSale.ReadOnly = True
        Me.PriceWholeSale.Width = 150
        '
        'CreditTotal
        '
        Me.CreditTotal.DataPropertyName = "CreditTotal"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CreditTotal.DefaultCellStyle = DataGridViewCellStyle7
        Me.CreditTotal.HeaderText = "วงเงินเครดิต"
        Me.CreditTotal.Name = "CreditTotal"
        Me.CreditTotal.ReadOnly = True
        '
        'Note
        '
        Me.Note.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Note.DataPropertyName = "Note"
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Note.DefaultCellStyle = DataGridViewCellStyle8
        Me.Note.HeaderText = "คำอธิบายระดับ"
        Me.Note.Name = "Note"
        Me.Note.ReadOnly = True
        '
        'idCusType
        '
        Me.idCusType.DataPropertyName = "idCusType"
        Me.idCusType.HeaderText = "idCusType"
        Me.idCusType.Name = "idCusType"
        Me.idCusType.Visible = False
        '
        'frmCusLevelData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(956, 451)
        Me.Controls.Add(Me.dgvData)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "frmCusLevelData"
        Me.Text = "ข้อมูลระดับลูกค้า"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents dgvData As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn2 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents colautonum As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colcancel As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents CusType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PriceRetail As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PriceBill As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PriceWholeSale As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CreditTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Note As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idCusType As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
