<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSlOrderToSaleSelect
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSlOrderToSaleSelect))
        Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle39 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle29 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle30 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle31 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle32 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle33 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle34 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle35 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle36 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle37 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle38 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNoPass = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCount = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnCustomer = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCusName = New System.Windows.Forms.TextBox()
        Me.dgvOrder = New System.Windows.Forms.DataGridView()
        Me.colSelect = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ColidSaleOrder = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColDetail = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ColDocCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCusName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColidCus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColDateTs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColDateReq = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColDay = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColPsSale = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColPsOrder = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColOrderBy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColNote = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColstAddress = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColidComp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColidPsAccept = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColidPsCheck = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColidPsApp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColstApp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.btnCustomer)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 70)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1044, 33)
        Me.Panel1.TabIndex = 602
        '
        'txtPass
        '
        Me.txtPass.BackColor = System.Drawing.Color.Black
        Me.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPass.ForeColor = System.Drawing.Color.Lime
        Me.txtPass.Location = New System.Drawing.Point(233, 5)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.ReadOnly = True
        Me.txtPass.Size = New System.Drawing.Size(60, 24)
        Me.txtPass.TabIndex = 617
        Me.txtPass.Text = "0"
        Me.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(19, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(208, 17)
        Me.Label3.TabIndex = 616
        Me.Label3.Text = "จำนวนรายการที่ผ่านกระบวนการ"
        '
        'txtNoPass
        '
        Me.txtNoPass.BackColor = System.Drawing.Color.Black
        Me.txtNoPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtNoPass.ForeColor = System.Drawing.Color.Lime
        Me.txtNoPass.Location = New System.Drawing.Point(545, 5)
        Me.txtNoPass.Name = "txtNoPass"
        Me.txtNoPass.ReadOnly = True
        Me.txtNoPass.Size = New System.Drawing.Size(60, 24)
        Me.txtNoPass.TabIndex = 615
        Me.txtNoPass.Text = "0"
        Me.txtNoPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(299, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(240, 17)
        Me.Label2.TabIndex = 614
        Me.Label2.Text = "จำนวนรายการที่ยังไม่ผ่านกระบวนการ"
        '
        'txtCount
        '
        Me.txtCount.BackColor = System.Drawing.Color.Black
        Me.txtCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCount.ForeColor = System.Drawing.Color.Lime
        Me.txtCount.Location = New System.Drawing.Point(761, 5)
        Me.txtCount.Name = "txtCount"
        Me.txtCount.ReadOnly = True
        Me.txtCount.Size = New System.Drawing.Size(60, 24)
        Me.txtCount.TabIndex = 613
        Me.txtCount.Text = "0"
        Me.txtCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(613, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(142, 17)
        Me.Label5.TabIndex = 612
        Me.Label5.Text = "จำนวนรายการทั้งหมด"
        '
        'btnCustomer
        '
        Me.btnCustomer.BackColor = System.Drawing.Color.DimGray
        Me.btnCustomer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCustomer.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnCustomer.ForeColor = System.Drawing.Color.White
        Me.btnCustomer.Image = CType(resources.GetObject("btnCustomer.Image"), System.Drawing.Image)
        Me.btnCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCustomer.Location = New System.Drawing.Point(0, 0)
        Me.btnCustomer.Name = "btnCustomer"
        Me.btnCustomer.Size = New System.Drawing.Size(108, 31)
        Me.btnCustomer.TabIndex = 602
        Me.btnCustomer.Tag = ""
        Me.btnCustomer.Text = "       แสดงข้อมูล"
        Me.btnCustomer.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(415, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 601
        Me.Label1.Text = "ชื่อลูกค้า"
        '
        'txtCusName
        '
        Me.txtCusName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtCusName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtCusName.Location = New System.Drawing.Point(466, 27)
        Me.txtCusName.Name = "txtCusName"
        Me.txtCusName.Size = New System.Drawing.Size(141, 20)
        Me.txtCusName.TabIndex = 600
        '
        'dgvOrder
        '
        Me.dgvOrder.AllowUserToAddRows = False
        Me.dgvOrder.AllowUserToDeleteRows = False
        DataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle27.BackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle27.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle27.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvOrder.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle27
        Me.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOrder.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colSelect, Me.ColidSaleOrder, Me.ColDetail, Me.ColDocCode, Me.colCusName, Me.ColidCus, Me.ColDateTs, Me.ColTime, Me.ColDateReq, Me.ColDay, Me.ColPsSale, Me.ColPsOrder, Me.ColOrderBy, Me.ColNote, Me.ColstAddress, Me.ColidComp, Me.ColidPsAccept, Me.ColidPsCheck, Me.ColidPsApp, Me.ColstApp})
        DataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle39.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle39.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle39.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle39.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle39.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle39.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvOrder.DefaultCellStyle = DataGridViewCellStyle39
        Me.dgvOrder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvOrder.EnableHeadersVisualStyles = False
        Me.dgvOrder.GridColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvOrder.Location = New System.Drawing.Point(0, 103)
        Me.dgvOrder.Name = "dgvOrder"
        Me.dgvOrder.RowHeadersVisible = False
        Me.dgvOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvOrder.Size = New System.Drawing.Size(1044, 391)
        Me.dgvOrder.TabIndex = 599
        '
        'colSelect
        '
        Me.colSelect.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        DataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle28.BackColor = System.Drawing.Color.Gray
        Me.colSelect.DefaultCellStyle = DataGridViewCellStyle28
        Me.colSelect.HeaderText = "เลือก"
        Me.colSelect.Name = "colSelect"
        Me.colSelect.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colSelect.Width = 41
        '
        'ColidSaleOrder
        '
        Me.ColidSaleOrder.DataPropertyName = "idSaleOrder"
        Me.ColidSaleOrder.HeaderText = "idSaleOrder"
        Me.ColidSaleOrder.Name = "ColidSaleOrder"
        Me.ColidSaleOrder.Visible = False
        '
        'ColDetail
        '
        Me.ColDetail.HeaderText = "รายละเอียด"
        Me.ColDetail.Image = Global.SAM.My.Resources.Resources.Open_16x16
        Me.ColDetail.Name = "ColDetail"
        Me.ColDetail.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColDetail.Width = 55
        '
        'ColDocCode
        '
        Me.ColDocCode.DataPropertyName = "DocCode"
        DataGridViewCellStyle29.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColDocCode.DefaultCellStyle = DataGridViewCellStyle29
        Me.ColDocCode.HeaderText = "เลขที่สั่งซื้อ"
        Me.ColDocCode.Name = "ColDocCode"
        Me.ColDocCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ColDocCode.Width = 90
        '
        'colCusName
        '
        Me.colCusName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colCusName.DataPropertyName = "CusName_"
        DataGridViewCellStyle30.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.colCusName.DefaultCellStyle = DataGridViewCellStyle30
        Me.colCusName.HeaderText = "ชื่อลูกค้า"
        Me.colCusName.Name = "colCusName"
        Me.colCusName.ReadOnly = True
        Me.colCusName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'ColidCus
        '
        Me.ColidCus.DataPropertyName = "idCus"
        Me.ColidCus.HeaderText = "idCus"
        Me.ColidCus.Name = "ColidCus"
        Me.ColidCus.Visible = False
        '
        'ColDateTs
        '
        Me.ColDateTs.DataPropertyName = "DateTs"
        DataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle31.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColDateTs.DefaultCellStyle = DataGridViewCellStyle31
        Me.ColDateTs.HeaderText = "วันที่ทำรายการสั่งซื้อ"
        Me.ColDateTs.Name = "ColDateTs"
        Me.ColDateTs.ReadOnly = True
        Me.ColDateTs.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ColDateTs.Width = 90
        '
        'ColTime
        '
        Me.ColTime.DataPropertyName = "TimeTs"
        DataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle32.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColTime.DefaultCellStyle = DataGridViewCellStyle32
        Me.ColTime.HeaderText = "เวลา"
        Me.ColTime.Name = "ColTime"
        Me.ColTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ColTime.Width = 50
        '
        'ColDateReq
        '
        Me.ColDateReq.DataPropertyName = "DateRequire"
        DataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle33.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColDateReq.DefaultCellStyle = DataGridViewCellStyle33
        Me.ColDateReq.HeaderText = "วันที่ต้องการสินค้า"
        Me.ColDateReq.Name = "ColDateReq"
        Me.ColDateReq.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ColDateReq.Width = 90
        '
        'ColDay
        '
        Me.ColDay.DataPropertyName = "CountDay"
        DataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle34.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColDay.DefaultCellStyle = DataGridViewCellStyle34
        Me.ColDay.HeaderText = "จำนวนวันสั่งซื้อ"
        Me.ColDay.Name = "ColDay"
        Me.ColDay.ReadOnly = True
        Me.ColDay.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ColDay.Visible = False
        Me.ColDay.Width = 70
        '
        'ColPsSale
        '
        Me.ColPsSale.DataPropertyName = "PsSale"
        DataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle35.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColPsSale.DefaultCellStyle = DataGridViewCellStyle35
        Me.ColPsSale.HeaderText = "เจ้าหน้าที่ขาย"
        Me.ColPsSale.Name = "ColPsSale"
        Me.ColPsSale.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ColPsSale.Width = 90
        '
        'ColPsOrder
        '
        Me.ColPsOrder.DataPropertyName = "PsOrder"
        DataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle36.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColPsOrder.DefaultCellStyle = DataGridViewCellStyle36
        Me.ColPsOrder.HeaderText = "ผู้รับรายการสั่งซื้อ"
        Me.ColPsOrder.Name = "ColPsOrder"
        Me.ColPsOrder.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ColPsOrder.Width = 90
        '
        'ColOrderBy
        '
        Me.ColOrderBy.DataPropertyName = "stSysOrder"
        DataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle37.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColOrderBy.DefaultCellStyle = DataGridViewCellStyle37
        Me.ColOrderBy.HeaderText = "ช่องทางการสั่งซื้อ"
        Me.ColOrderBy.Name = "ColOrderBy"
        Me.ColOrderBy.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ColOrderBy.Width = 70
        '
        'ColNote
        '
        Me.ColNote.DataPropertyName = "Note"
        DataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle38.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColNote.DefaultCellStyle = DataGridViewCellStyle38
        Me.ColNote.HeaderText = "หมายเเหตุ"
        Me.ColNote.Name = "ColNote"
        Me.ColNote.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ColNote.Width = 90
        '
        'ColstAddress
        '
        Me.ColstAddress.DataPropertyName = "stAddress"
        Me.ColstAddress.HeaderText = "stAddress"
        Me.ColstAddress.Name = "ColstAddress"
        Me.ColstAddress.Visible = False
        '
        'ColidComp
        '
        Me.ColidComp.DataPropertyName = "idComp"
        Me.ColidComp.HeaderText = "idComp"
        Me.ColidComp.Name = "ColidComp"
        Me.ColidComp.Visible = False
        '
        'ColidPsAccept
        '
        Me.ColidPsAccept.DataPropertyName = "idPsAccept"
        Me.ColidPsAccept.HeaderText = "idPsAccept"
        Me.ColidPsAccept.Name = "ColidPsAccept"
        Me.ColidPsAccept.Visible = False
        '
        'ColidPsCheck
        '
        Me.ColidPsCheck.DataPropertyName = "idPsCheck"
        Me.ColidPsCheck.HeaderText = "idPsCheck"
        Me.ColidPsCheck.Name = "ColidPsCheck"
        Me.ColidPsCheck.Visible = False
        '
        'ColidPsApp
        '
        Me.ColidPsApp.DataPropertyName = "idPsApp"
        Me.ColidPsApp.HeaderText = "idPsApp"
        Me.ColidPsApp.Name = "ColidPsApp"
        Me.ColidPsApp.Visible = False
        '
        'ColstApp
        '
        Me.ColstApp.DataPropertyName = "stApp"
        Me.ColstApp.HeaderText = "StApp"
        Me.ColstApp.Name = "ColstApp"
        Me.ColstApp.Visible = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.txtCusName)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1044, 70)
        Me.Panel2.TabIndex = 603
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.txtPass)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.txtCount)
        Me.Panel3.Controls.Add(Me.txtNoPass)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(211, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(831, 31)
        Me.Panel3.TabIndex = 604
        '
        'frmSlOrderToSaleSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(1044, 494)
        Me.Controls.Add(Me.dgvOrder)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "frmSlOrderToSaleSelect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "เลือกรายการสั่งซื้อจากลำดับทำรายการสั่งซื้อ"
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgvOrder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtCount As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnCustomer As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCusName As System.Windows.Forms.TextBox
    Friend WithEvents dgvOrder As System.Windows.Forms.DataGridView
    Friend WithEvents txtNoPass As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPass As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents colSelect As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents ColidSaleOrder As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColDetail As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents ColDocCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCusName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColidCus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColDateTs As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColTime As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColDateReq As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColDay As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColPsSale As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColPsOrder As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColOrderBy As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColNote As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColstAddress As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColidComp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColidPsAccept As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColidPsCheck As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColidPsApp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColstApp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
End Class
