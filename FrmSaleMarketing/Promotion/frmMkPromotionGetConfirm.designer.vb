<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMkPromotionGetConfirm
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
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblDateTs = New System.Windows.Forms.Label
        Me.lblPsTs = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.lblDateSale = New System.Windows.Forms.Label
        Me.lblPsSale = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblCustomer = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblDocCode = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btnConfirm = New System.Windows.Forms.Button
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn
        Me.dgvProGet = New System.Windows.Forms.DataGridView
        Me.ColNum = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColidProUse = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColDel = New System.Windows.Forms.DataGridViewImageColumn
        Me.ColProName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColidPromotion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColProTypeName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColidProType = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColCondition = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColSelectPk = New System.Windows.Forms.DataGridViewButtonColumn
        Me.ColidFree = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColFreeName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColAmtFree = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColFreeUnit = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColCollectCut = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColstBillPromotion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvProGet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lblDateTs)
        Me.Panel1.Controls.Add(Me.lblPsTs)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.lblDateSale)
        Me.Panel1.Controls.Add(Me.lblPsSale)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.lblCustomer)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.lblDocCode)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(984, 89)
        Me.Panel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(722, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 15)
        Me.Label2.TabIndex = 631
        Me.Label2.Text = "วันที่รายการ"
        '
        'lblDateTs
        '
        Me.lblDateTs.BackColor = System.Drawing.Color.Gainsboro
        Me.lblDateTs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDateTs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblDateTs.Location = New System.Drawing.Point(790, 17)
        Me.lblDateTs.Name = "lblDateTs"
        Me.lblDateTs.Size = New System.Drawing.Size(139, 22)
        Me.lblDateTs.TabIndex = 634
        Me.lblDateTs.Tag = "0"
        Me.lblDateTs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPsTs
        '
        Me.lblPsTs.BackColor = System.Drawing.Color.Gainsboro
        Me.lblPsTs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPsTs.Location = New System.Drawing.Point(790, 50)
        Me.lblPsTs.Name = "lblPsTs"
        Me.lblPsTs.Size = New System.Drawing.Size(139, 20)
        Me.lblPsTs.TabIndex = 633
        Me.lblPsTs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.Location = New System.Drawing.Point(722, 52)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 15)
        Me.Label9.TabIndex = 632
        Me.Label9.Text = "ผู้ทำรายการ"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label11.Location = New System.Drawing.Point(63, 50)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(47, 15)
        Me.Label11.TabIndex = 627
        Me.Label11.Text = "วันที่ขาย"
        '
        'lblDateSale
        '
        Me.lblDateSale.BackColor = System.Drawing.Color.Gainsboro
        Me.lblDateSale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDateSale.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblDateSale.Location = New System.Drawing.Point(116, 50)
        Me.lblDateSale.Name = "lblDateSale"
        Me.lblDateSale.Size = New System.Drawing.Size(120, 22)
        Me.lblDateSale.TabIndex = 630
        Me.lblDateSale.Tag = "0"
        Me.lblDateSale.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPsSale
        '
        Me.lblPsSale.BackColor = System.Drawing.Color.Gainsboro
        Me.lblPsSale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPsSale.Location = New System.Drawing.Point(365, 48)
        Me.lblPsSale.Name = "lblPsSale"
        Me.lblPsSale.Size = New System.Drawing.Size(139, 20)
        Me.lblPsSale.TabIndex = 591
        Me.lblPsSale.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(290, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 15)
        Me.Label5.TabIndex = 590
        Me.Label5.Text = "เจ้าหน้าที่ขาย"
        '
        'lblCustomer
        '
        Me.lblCustomer.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCustomer.Location = New System.Drawing.Point(365, 19)
        Me.lblCustomer.Name = "lblCustomer"
        Me.lblCustomer.Size = New System.Drawing.Size(310, 20)
        Me.lblCustomer.TabIndex = 589
        Me.lblCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(327, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 15)
        Me.Label3.TabIndex = 588
        Me.Label3.Text = "ลูกค้า"
        '
        'lblDocCode
        '
        Me.lblDocCode.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblDocCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDocCode.Location = New System.Drawing.Point(116, 19)
        Me.lblDocCode.Name = "lblDocCode"
        Me.lblDocCode.Size = New System.Drawing.Size(120, 20)
        Me.lblDocCode.TabIndex = 585
        Me.lblDocCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(23, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 15)
        Me.Label6.TabIndex = 584
        Me.Label6.Text = "เลขที่รายการขาย"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnConfirm)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 89)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(984, 36)
        Me.Panel2.TabIndex = 608
        '
        'btnConfirm
        '
        Me.btnConfirm.BackColor = System.Drawing.Color.DimGray
        Me.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConfirm.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnConfirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnConfirm.ForeColor = System.Drawing.Color.White
        Me.btnConfirm.Image = Global.SAM.My.Resources.Resources.confirm_icon
        Me.btnConfirm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConfirm.Location = New System.Drawing.Point(0, 0)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(190, 34)
        Me.btnConfirm.TabIndex = 580
        Me.btnConfirm.Tag = ""
        Me.btnConfirm.Text = "       อนุมัติรายการให้โปรโมชั่น"
        Me.btnConfirm.UseVisualStyleBackColor = False
        '
        'DataGridViewImageColumn1
        '
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle12.NullValue = Nothing
        Me.DataGridViewImageColumn1.DefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridViewImageColumn1.HeaderText = "รายละเอียด"
        Me.DataGridViewImageColumn1.Image = Global.SAM.My.Resources.Resources.images
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn1.Width = 55
        '
        'dgvProGet
        '
        Me.dgvProGet.AllowUserToAddRows = False
        Me.dgvProGet.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProGet.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle13
        Me.dgvProGet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProGet.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColNum, Me.ColidProUse, Me.ColDel, Me.ColProName, Me.ColidPromotion, Me.ColProTypeName, Me.ColidProType, Me.ColCondition, Me.ColSelectPk, Me.ColidFree, Me.ColFreeName, Me.ColAmtFree, Me.ColFreeUnit, Me.ColCollectCut, Me.ColstBillPromotion})
        DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvProGet.DefaultCellStyle = DataGridViewCellStyle21
        Me.dgvProGet.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvProGet.EnableHeadersVisualStyles = False
        Me.dgvProGet.GridColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvProGet.Location = New System.Drawing.Point(0, 125)
        Me.dgvProGet.MultiSelect = False
        Me.dgvProGet.Name = "dgvProGet"
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.ActiveBorder
        DataGridViewCellStyle22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProGet.RowHeadersDefaultCellStyle = DataGridViewCellStyle22
        Me.dgvProGet.RowHeadersVisible = False
        Me.dgvProGet.Size = New System.Drawing.Size(984, 337)
        Me.dgvProGet.TabIndex = 609
        '
        'ColNum
        '
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColNum.DefaultCellStyle = DataGridViewCellStyle14
        Me.ColNum.HeaderText = "ลำดับ"
        Me.ColNum.Name = "ColNum"
        Me.ColNum.ReadOnly = True
        Me.ColNum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ColNum.Width = 35
        '
        'ColidProUse
        '
        Me.ColidProUse.DataPropertyName = "idProUse"
        Me.ColidProUse.HeaderText = "idProUse"
        Me.ColidProUse.Name = "ColidProUse"
        Me.ColidProUse.Visible = False
        '
        'ColDel
        '
        Me.ColDel.HeaderText = "ไม่อนุมัติ"
        Me.ColDel.Image = Global.SAM.My.Resources.Resources.cross_circle_frame
        Me.ColDel.Name = "ColDel"
        Me.ColDel.Width = 40
        '
        'ColProName
        '
        Me.ColProName.DataPropertyName = "ProName"
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColProName.DefaultCellStyle = DataGridViewCellStyle15
        Me.ColProName.HeaderText = "ชื่อโปรโมชั่น"
        Me.ColProName.Name = "ColProName"
        Me.ColProName.ReadOnly = True
        Me.ColProName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ColProName.Width = 150
        '
        'ColidPromotion
        '
        Me.ColidPromotion.DataPropertyName = "idPromotion"
        Me.ColidPromotion.HeaderText = "idPromotion"
        Me.ColidPromotion.Name = "ColidPromotion"
        Me.ColidPromotion.Visible = False
        '
        'ColProTypeName
        '
        Me.ColProTypeName.DataPropertyName = "ProTypeName"
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColProTypeName.DefaultCellStyle = DataGridViewCellStyle16
        Me.ColProTypeName.HeaderText = "ประเภทโปรโมชั่น"
        Me.ColProTypeName.Name = "ColProTypeName"
        Me.ColProTypeName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ColProTypeName.Width = 140
        '
        'ColidProType
        '
        Me.ColidProType.DataPropertyName = "idProType"
        Me.ColidProType.HeaderText = "idProType"
        Me.ColidProType.Name = "ColidProType"
        Me.ColidProType.Visible = False
        '
        'ColCondition
        '
        Me.ColCondition.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColCondition.DataPropertyName = "Condition"
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColCondition.DefaultCellStyle = DataGridViewCellStyle17
        Me.ColCondition.HeaderText = "เงื่อนไขโปรโมชั่น"
        Me.ColCondition.Name = "ColCondition"
        Me.ColCondition.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'ColSelectPk
        '
        Me.ColSelectPk.HeaderText = "เลือกสินค้า"
        Me.ColSelectPk.Name = "ColSelectPk"
        Me.ColSelectPk.Visible = False
        Me.ColSelectPk.Width = 40
        '
        'ColidFree
        '
        Me.ColidFree.DataPropertyName = "idFree"
        Me.ColidFree.HeaderText = "idFree"
        Me.ColidFree.Name = "ColidFree"
        Me.ColidFree.Visible = False
        '
        'ColFreeName
        '
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColFreeName.DefaultCellStyle = DataGridViewCellStyle18
        Me.ColFreeName.HeaderText = "ของแถม"
        Me.ColFreeName.Name = "ColFreeName"
        Me.ColFreeName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ColFreeName.Width = 150
        '
        'ColAmtFree
        '
        Me.ColAmtFree.DataPropertyName = "AmountFree"
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle19.Format = "N0"
        DataGridViewCellStyle19.NullValue = Nothing
        Me.ColAmtFree.DefaultCellStyle = DataGridViewCellStyle19
        Me.ColAmtFree.HeaderText = "จำนวนแถม"
        Me.ColAmtFree.Name = "ColAmtFree"
        Me.ColAmtFree.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ColAmtFree.Width = 50
        '
        'ColFreeUnit
        '
        Me.ColFreeUnit.DataPropertyName = "FreeUnit"
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColFreeUnit.DefaultCellStyle = DataGridViewCellStyle20
        Me.ColFreeUnit.HeaderText = "หน่วย"
        Me.ColFreeUnit.Name = "ColFreeUnit"
        Me.ColFreeUnit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ColFreeUnit.Width = 60
        '
        'ColCollectCut
        '
        Me.ColCollectCut.DataPropertyName = "CollectCut"
        Me.ColCollectCut.HeaderText = "CollectCut"
        Me.ColCollectCut.Name = "ColCollectCut"
        Me.ColCollectCut.Visible = False
        '
        'ColstBillPromotion
        '
        Me.ColstBillPromotion.DataPropertyName = "stBillPromotion"
        Me.ColstBillPromotion.HeaderText = "stBillPromotion"
        Me.ColstBillPromotion.Name = "ColstBillPromotion"
        Me.ColstBillPromotion.Visible = False
        '
        'frmMkPromotionGetConfirm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(984, 462)
        Me.Controls.Add(Me.dgvProGet)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmMkPromotionGetConfirm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "อนุมัติรายการให้โปรโมชั่น"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgvProGet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblDocCode As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblPsSale As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblCustomer As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnConfirm As System.Windows.Forms.Button
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblDateSale As System.Windows.Forms.Label
    Friend WithEvents dgvProGet As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblDateTs As System.Windows.Forms.Label
    Friend WithEvents lblPsTs As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ColNum As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColidProUse As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColDel As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents ColProName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColidPromotion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColProTypeName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColidProType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColCondition As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColSelectPk As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents ColidFree As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColFreeName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColAmtFree As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColFreeUnit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColCollectCut As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColstBillPromotion As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
