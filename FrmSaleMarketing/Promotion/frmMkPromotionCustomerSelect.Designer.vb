<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMkPromotionCustomerSelect
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMkPromotionCustomerSelect))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.txtTotalNet = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnShow = New System.Windows.Forms.Button
        Me.btnSearch = New System.Windows.Forms.Button
        Me.dgvCusPro = New System.Windows.Forms.DataGridView
        Me.ColSelect = New System.Windows.Forms.DataGridViewButtonColumn
        Me.ColNum = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColidCus = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColCusName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColDebt = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.txtCus = New System.Windows.Forms.TextBox
        Me.lblField = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgvCusPro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.btnShow)
        Me.Panel1.Controls.Add(Me.btnSearch)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 74)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(444, 39)
        Me.Panel1.TabIndex = 417
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.txtTotalNet)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(181, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(261, 37)
        Me.Panel3.TabIndex = 583
        '
        'txtTotalNet
        '
        Me.txtTotalNet.BackColor = System.Drawing.Color.Black
        Me.txtTotalNet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalNet.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTotalNet.ForeColor = System.Drawing.Color.Lime
        Me.txtTotalNet.Location = New System.Drawing.Point(163, 7)
        Me.txtTotalNet.Name = "txtTotalNet"
        Me.txtTotalNet.ReadOnly = True
        Me.txtTotalNet.Size = New System.Drawing.Size(87, 27)
        Me.txtTotalNet.TabIndex = 579
        Me.txtTotalNet.Text = "0"
        Me.txtTotalNet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(29, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 17)
        Me.Label2.TabIndex = 142
        Me.Label2.Text = "จำนวนลูกค้าทั้งหมด"
        '
        'btnShow
        '
        Me.btnShow.BackColor = System.Drawing.Color.DimGray
        Me.btnShow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnShow.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnShow.ForeColor = System.Drawing.Color.White
        Me.btnShow.Image = CType(resources.GetObject("btnShow.Image"), System.Drawing.Image)
        Me.btnShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnShow.Location = New System.Drawing.Point(0, 0)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(115, 37)
        Me.btnShow.TabIndex = 581
        Me.btnShow.Tag = ""
        Me.btnShow.Text = "       แสดงข้อมูล"
        Me.btnShow.UseVisualStyleBackColor = False
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
        'dgvCusPro
        '
        Me.dgvCusPro.AllowUserToAddRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCusPro.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCusPro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCusPro.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColSelect, Me.ColNum, Me.ColidCus, Me.ColCusName, Me.ColDebt})
        Me.dgvCusPro.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvCusPro.Location = New System.Drawing.Point(0, 113)
        Me.dgvCusPro.Name = "dgvCusPro"
        Me.dgvCusPro.RowHeadersVisible = False
        Me.dgvCusPro.Size = New System.Drawing.Size(444, 399)
        Me.dgvCusPro.TabIndex = 416
        '
        'ColSelect
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColSelect.DefaultCellStyle = DataGridViewCellStyle2
        Me.ColSelect.HeaderText = "เลือก"
        Me.ColSelect.Name = "ColSelect"
        Me.ColSelect.Width = 40
        '
        'ColNum
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColNum.DefaultCellStyle = DataGridViewCellStyle3
        Me.ColNum.HeaderText = "ลำดับ"
        Me.ColNum.Name = "ColNum"
        Me.ColNum.Width = 40
        '
        'ColidCus
        '
        Me.ColidCus.DataPropertyName = "idCus"
        Me.ColidCus.HeaderText = "รหัสลูกค้า"
        Me.ColidCus.Name = "ColidCus"
        Me.ColidCus.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColidCus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ColidCus.Visible = False
        Me.ColidCus.Width = 60
        '
        'ColCusName
        '
        Me.ColCusName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColCusName.DataPropertyName = "CusName_"
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColCusName.DefaultCellStyle = DataGridViewCellStyle4
        Me.ColCusName.HeaderText = "ชื่อลูกค้า"
        Me.ColCusName.Name = "ColCusName"
        Me.ColCusName.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColCusName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'ColDebt
        '
        Me.ColDebt.DataPropertyName = "CntPro"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle5.NullValue = Nothing
        Me.ColDebt.DefaultCellStyle = DataGridViewCellStyle5
        Me.ColDebt.HeaderText = "จำนวนโปรโมชั่นที่ได้รับ"
        Me.ColDebt.Name = "ColDebt"
        Me.ColDebt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ColDebt.Width = 80
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.txtCus)
        Me.Panel2.Controls.Add(Me.lblField)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(444, 74)
        Me.Panel2.TabIndex = 418
        '
        'txtCus
        '
        Me.txtCus.BackColor = System.Drawing.Color.White
        Me.txtCus.Location = New System.Drawing.Point(165, 23)
        Me.txtCus.Name = "txtCus"
        Me.txtCus.Size = New System.Drawing.Size(162, 20)
        Me.txtCus.TabIndex = 419
        '
        'lblField
        '
        Me.lblField.AutoSize = True
        Me.lblField.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblField.Location = New System.Drawing.Point(100, 26)
        Me.lblField.Name = "lblField"
        Me.lblField.Size = New System.Drawing.Size(59, 13)
        Me.lblField.TabIndex = 418
        Me.lblField.Text = "ค้นหาลูกค้า"
        '
        'frmMkPromotionCustomerSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(444, 512)
        Me.Controls.Add(Me.dgvCusPro)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.MaximizeBox = False
        Me.Name = "frmMkPromotionCustomerSelect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "เลือกลูกค้าเพื่อทำรายการแจกของโปรโมชั่น"
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.dgvCusPro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents txtTotalNet As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents dgvCusPro As System.Windows.Forms.DataGridView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtCus As System.Windows.Forms.TextBox
    Friend WithEvents lblField As System.Windows.Forms.Label
    Friend WithEvents ColSelect As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents ColNum As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColidCus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColCusName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColDebt As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
