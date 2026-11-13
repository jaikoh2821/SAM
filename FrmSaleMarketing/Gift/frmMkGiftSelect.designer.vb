<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMkGiftSelect
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
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btn_show = New System.Windows.Forms.Button
        Me.dgvData = New System.Windows.Forms.DataGridView
        Me.colselect = New System.Windows.Forms.DataGridViewImageColumn
        Me.idStore = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.idInv = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.InvName_ = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Amount = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UnitName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.StoreName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn
        Me.txtName = New System.Windows.Forms.TextBox
        Me.CHKName = New System.Windows.Forms.CheckBox
        Me.Panel2.SuspendLayout()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btn_show)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 60)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(731, 44)
        Me.Panel2.TabIndex = 678
        '
        'btn_show
        '
        Me.btn_show.AutoSize = True
        Me.btn_show.BackColor = System.Drawing.Color.DimGray
        Me.btn_show.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_show.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_show.ForeColor = System.Drawing.Color.White
        Me.btn_show.Image = Global.SAM.My.Resources.Resources.Find
        Me.btn_show.Location = New System.Drawing.Point(3, 1)
        Me.btn_show.Name = "btn_show"
        Me.btn_show.Size = New System.Drawing.Size(110, 40)
        Me.btn_show.TabIndex = 400
        Me.btn_show.Text = "แสดงข้อมูล"
        Me.btn_show.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_show.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_show.UseVisualStyleBackColor = False
        '
        'dgvData
        '
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
        Me.dgvData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colselect, Me.idStore, Me.idInv, Me.InvName_, Me.Amount, Me.UnitName, Me.StoreName})
        Me.dgvData.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvData.Location = New System.Drawing.Point(0, 104)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.RowHeadersVisible = False
        Me.dgvData.Size = New System.Drawing.Size(731, 270)
        Me.dgvData.TabIndex = 677
        '
        'colselect
        '
        Me.colselect.HeaderText = "เลือก"
        Me.colselect.Image = Global.SAM.My.Resources.Resources.CancelCheck
        Me.colselect.Name = "colselect"
        Me.colselect.Width = 35
        '
        'idStore
        '
        Me.idStore.DataPropertyName = "idStore"
        Me.idStore.HeaderText = "idStore"
        Me.idStore.Name = "idStore"
        Me.idStore.Visible = False
        '
        'idInv
        '
        Me.idInv.DataPropertyName = "idInv"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.idInv.DefaultCellStyle = DataGridViewCellStyle2
        Me.idInv.HeaderText = "idInv"
        Me.idInv.Name = "idInv"
        Me.idInv.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.idInv.Visible = False
        Me.idInv.Width = 75
        '
        'InvName_
        '
        Me.InvName_.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.InvName_.DataPropertyName = "InvName_"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.InvName_.DefaultCellStyle = DataGridViewCellStyle3
        Me.InvName_.HeaderText = "ชื่อสิ่งของ"
        Me.InvName_.Name = "InvName_"
        Me.InvName_.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Amount
        '
        Me.Amount.DataPropertyName = "Amount"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Amount.DefaultCellStyle = DataGridViewCellStyle4
        Me.Amount.HeaderText = "จำนวนคงเหลือ"
        Me.Amount.Name = "Amount"
        Me.Amount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'UnitName
        '
        Me.UnitName.DataPropertyName = "UnitName"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.UnitName.DefaultCellStyle = DataGridViewCellStyle5
        Me.UnitName.HeaderText = "หน่วยเก็บ"
        Me.UnitName.Name = "UnitName"
        Me.UnitName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.UnitName.Width = 75
        '
        'StoreName
        '
        Me.StoreName.DataPropertyName = "StoreName"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.StoreName.DefaultCellStyle = DataGridViewCellStyle6
        Me.StoreName.HeaderText = "คลังเก็บ"
        Me.StoreName.Name = "StoreName"
        Me.StoreName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = "เลือก"
        Me.DataGridViewImageColumn1.Image = Global.SAM.My.Resources.Resources.CancelCheck
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Width = 35
        '
        'txtName
        '
        Me.txtName.Enabled = False
        Me.txtName.Location = New System.Drawing.Point(297, 24)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(199, 20)
        Me.txtName.TabIndex = 679
        '
        'CHKName
        '
        Me.CHKName.AutoSize = True
        Me.CHKName.Location = New System.Drawing.Point(224, 27)
        Me.CHKName.Name = "CHKName"
        Me.CHKName.Size = New System.Drawing.Size(67, 17)
        Me.CHKName.TabIndex = 680
        Me.CHKName.Text = "ชื่อสิ่งของ"
        Me.CHKName.UseVisualStyleBackColor = True
        '
        'frmMkGiftSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(731, 374)
        Me.Controls.Add(Me.CHKName)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.dgvData)
        Me.Name = "frmMkGiftSelect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "เลือกสิ่งของ"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btn_show As System.Windows.Forms.Button
    Friend WithEvents dgvData As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents CHKName As System.Windows.Forms.CheckBox
    Friend WithEvents colselect As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents idStore As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idInv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InvName_ As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Amount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UnitName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StoreName As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
