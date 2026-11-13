<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCusTfBankNone
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCusTfBankNone))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lbCntCus = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtSearch = New System.Windows.Forms.TextBox
        Me.dgvCusNon = New System.Windows.Forms.DataGridView
        Me.change = New System.Windows.Forms.DataGridViewImageColumn
        Me.CusName_ = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.address = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.idCus_ = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Panel1.SuspendLayout()
        CType(Me.dgvCusNon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lbCntCus)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtSearch)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(709, 93)
        Me.Panel1.TabIndex = 1
        '
        'lbCntCus
        '
        Me.lbCntCus.BackColor = System.Drawing.Color.CornflowerBlue
        Me.lbCntCus.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lbCntCus.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbCntCus.ForeColor = System.Drawing.Color.White
        Me.lbCntCus.Location = New System.Drawing.Point(0, 63)
        Me.lbCntCus.Name = "lbCntCus"
        Me.lbCntCus.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbCntCus.Size = New System.Drawing.Size(709, 30)
        Me.lbCntCus.TabIndex = 431
        Me.lbCntCus.Text = "ลูกค้าที่ยังไม่ได้กำหนดธนาคาร"
        Me.lbCntCus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbCntCus.UseCompatibleTextRendering = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(130, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 25)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "ค้นหาชื่อลูกค้า"
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(263, 18)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(309, 26)
        Me.txtSearch.TabIndex = 0
        '
        'dgvCusNon
        '
        Me.dgvCusNon.AllowUserToAddRows = False
        Me.dgvCusNon.AllowUserToDeleteRows = False
        Me.dgvCusNon.BackgroundColor = System.Drawing.Color.Silver
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveBorder
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCusNon.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvCusNon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCusNon.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.change, Me.CusName_, Me.address, Me.idCus_})
        Me.dgvCusNon.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvCusNon.EnableHeadersVisualStyles = False
        Me.dgvCusNon.Location = New System.Drawing.Point(0, 93)
        Me.dgvCusNon.Name = "dgvCusNon"
        Me.dgvCusNon.Size = New System.Drawing.Size(709, 466)
        Me.dgvCusNon.TabIndex = 2
        '
        'change
        '
        Me.change.HeaderText = "เลือก"
        Me.change.Image = CType(resources.GetObject("change.Image"), System.Drawing.Image)
        Me.change.Name = "change"
        Me.change.Width = 40
        '
        'CusName_
        '
        Me.CusName_.DataPropertyName = "CusName"
        Me.CusName_.HeaderText = "ลูกค้า"
        Me.CusName_.Name = "CusName_"
        Me.CusName_.ReadOnly = True
        Me.CusName_.Width = 200
        '
        'address
        '
        Me.address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.address.DataPropertyName = "address"
        Me.address.HeaderText = "ที่อยู่"
        Me.address.Name = "address"
        Me.address.ReadOnly = True
        '
        'idCus_
        '
        Me.idCus_.DataPropertyName = "idCus"
        Me.idCus_.HeaderText = "idCus"
        Me.idCus_.Name = "idCus_"
        Me.idCus_.Visible = False
        '
        'frmCusTfBankNone
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(709, 559)
        Me.Controls.Add(Me.dgvCusNon)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmCusTfBankNone"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ลูกค้าที่ยังไม่ได้กำหนด"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvCusNon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents dgvCusNon As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbCntCus As System.Windows.Forms.Label
    Friend WithEvents change As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents CusName_ As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents address As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idCus_ As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
