<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMkCusAddressSendDoc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMkCusAddressSendDoc))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.dgvCustomer = New System.Windows.Forms.DataGridView
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btnShowDoc = New System.Windows.Forms.Button
        Me.btnSelect = New System.Windows.Forms.Button
        Me.ColNum = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Cusid = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colCusName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColAp = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColPv = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColPsConn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Address = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColDel = New System.Windows.Forms.DataGridViewImageColumn
        CType(Me.dgvCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvCustomer
        '
        Me.dgvCustomer.AllowUserToAddRows = False
        Me.dgvCustomer.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCustomer.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCustomer.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColNum, Me.Cusid, Me.colCusName, Me.ColAp, Me.ColPv, Me.ColPsConn, Me.Address, Me.ColDel})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCustomer.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvCustomer.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgvCustomer.EnableHeadersVisualStyles = False
        Me.dgvCustomer.GridColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvCustomer.Location = New System.Drawing.Point(0, 0)
        Me.dgvCustomer.Name = "dgvCustomer"
        Me.dgvCustomer.RowHeadersVisible = False
        Me.dgvCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvCustomer.Size = New System.Drawing.Size(899, 488)
        Me.dgvCustomer.TabIndex = 187
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnShowDoc)
        Me.Panel2.Controls.Add(Me.btnSelect)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 490)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(899, 37)
        Me.Panel2.TabIndex = 428
        '
        'btnShowDoc
        '
        Me.btnShowDoc.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnShowDoc.BackColor = System.Drawing.Color.DimGray
        Me.btnShowDoc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnShowDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnShowDoc.ForeColor = System.Drawing.Color.White
        Me.btnShowDoc.Image = Global.SAM.My.Resources.Resources.Printers
        Me.btnShowDoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnShowDoc.Location = New System.Drawing.Point(123, 0)
        Me.btnShowDoc.Name = "btnShowDoc"
        Me.btnShowDoc.Size = New System.Drawing.Size(111, 36)
        Me.btnShowDoc.TabIndex = 583
        Me.btnShowDoc.Tag = ""
        Me.btnShowDoc.Text = "       พิมพ์เอกสาร"
        Me.btnShowDoc.UseVisualStyleBackColor = False
        '
        'btnSelect
        '
        Me.btnSelect.BackColor = System.Drawing.Color.DimGray
        Me.btnSelect.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnSelect.ForeColor = System.Drawing.Color.White
        Me.btnSelect.Image = CType(resources.GetObject("btnSelect.Image"), System.Drawing.Image)
        Me.btnSelect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSelect.Location = New System.Drawing.Point(0, -1)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(125, 37)
        Me.btnSelect.TabIndex = 426
        Me.btnSelect.Tag = "Save"
        Me.btnSelect.Text = "    เลือกลูกค้า"
        Me.btnSelect.UseVisualStyleBackColor = False
        '
        'ColNum
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.ColNum.DefaultCellStyle = DataGridViewCellStyle2
        Me.ColNum.HeaderText = "ลำดับ"
        Me.ColNum.Name = "ColNum"
        Me.ColNum.Width = 40
        '
        'Cusid
        '
        Me.Cusid.DataPropertyName = "idCus"
        Me.Cusid.HeaderText = "idCus"
        Me.Cusid.Name = "Cusid"
        Me.Cusid.Visible = False
        '
        'colCusName
        '
        Me.colCusName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colCusName.DataPropertyName = "CusName"
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.colCusName.DefaultCellStyle = DataGridViewCellStyle3
        Me.colCusName.HeaderText = "ชื่อลูกค้า"
        Me.colCusName.Name = "colCusName"
        '
        'ColAp
        '
        Me.ColAp.DataPropertyName = "ApName"
        Me.ColAp.HeaderText = "อำเภอ"
        Me.ColAp.Name = "ColAp"
        '
        'ColPv
        '
        Me.ColPv.DataPropertyName = "PvName"
        Me.ColPv.HeaderText = "จังหวัด"
        Me.ColPv.Name = "ColPv"
        '
        'ColPsConn
        '
        Me.ColPsConn.DataPropertyName = "CusNameConn"
        Me.ColPsConn.HeaderText = "ชื่อผู้ติดต่อ"
        Me.ColPsConn.Name = "ColPsConn"
        Me.ColPsConn.Width = 150
        '
        'Address
        '
        Me.Address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Address.DataPropertyName = "address"
        Me.Address.HeaderText = "ที่อยู่"
        Me.Address.Name = "Address"
        '
        'ColDel
        '
        Me.ColDel.DataPropertyName = "Del"
        Me.ColDel.HeaderText = "ลบ"
        Me.ColDel.Name = "ColDel"
        Me.ColDel.Width = 40
        '
        'frmMkCusAddressSendDoc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(899, 527)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.dgvCustomer)
        Me.MaximizeBox = False
        Me.Name = "frmMkCusAddressSendDoc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "รายชื่อลูกค้า"
        CType(Me.dgvCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvCustomer As System.Windows.Forms.DataGridView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents btnShowDoc As System.Windows.Forms.Button
    Friend WithEvents ColNum As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cusid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCusName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColAp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColPv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColPsConn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Address As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColDel As System.Windows.Forms.DataGridViewImageColumn
End Class
