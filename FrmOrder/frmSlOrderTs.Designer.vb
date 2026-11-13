<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSlOrderTs
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSlOrderTs))
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnPsSale = New DevExpress.XtraEditors.SimpleButton()
        Me.btnPsOrder = New DevExpress.XtraEditors.SimpleButton()
        Me.btnPsCus = New DevExpress.XtraEditors.SimpleButton()
        Me.lblCusNote = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbGroupComp = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblPsSale = New System.Windows.Forms.Label()
        Me.lblDocCode = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtNote = New System.Windows.Forms.TextBox()
        Me.dtpOrder = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblPsOrder = New System.Windows.Forms.Label()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblPsTs = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblDateTs = New System.Windows.Forms.Label()
        Me.dtpRequire = New System.Windows.Forms.DateTimePicker()
        Me.lblPsCus = New System.Windows.Forms.Label()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblWeight = New System.Windows.Forms.Label()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnSelectAll = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_img = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnClose = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.btnNewPd = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GcOrder = New DevExpress.XtraGrid.GridControl()
        Me.GvOrder = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColSel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rptSel = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.ColNum = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColPdCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rptPdCode = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.ColProductName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rptProductName = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
        Me.ColPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColAmount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColAmtSale = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColAmtBal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColidUnit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rptUnit = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.ColNoteDt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rptDel = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.ColidSaleOrderDt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidInvMain = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColUnit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidInvGroup = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColidSubType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColidUnitPd = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColPerbox = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.GcOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GvOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptSel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptPdCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptProductName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptUnit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptDel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.btnPsSale)
        Me.GroupBox3.Controls.Add(Me.btnPsOrder)
        Me.GroupBox3.Controls.Add(Me.btnPsCus)
        Me.GroupBox3.Controls.Add(Me.lblCusNote)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.cmbGroupComp)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.lblPsSale)
        Me.GroupBox3.Controls.Add(Me.lblDocCode)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.txtNote)
        Me.GroupBox3.Controls.Add(Me.dtpOrder)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.lblPsOrder)
        Me.GroupBox3.Controls.Add(Me.Label53)
        Me.GroupBox3.Controls.Add(Me.Label47)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.lblPsTs)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.lblDateTs)
        Me.GroupBox3.Controls.Add(Me.dtpRequire)
        Me.GroupBox3.Controls.Add(Me.lblPsCus)
        Me.GroupBox3.Controls.Add(Me.Label51)
        Me.GroupBox3.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1178, 124)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        '
        'btnPsSale
        '
        Me.btnPsSale.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPsSale.Image = CType(resources.GetObject("btnPsSale.Image"), System.Drawing.Image)
        Me.btnPsSale.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnPsSale.Location = New System.Drawing.Point(911, 16)
        Me.btnPsSale.Name = "btnPsSale"
        Me.btnPsSale.Size = New System.Drawing.Size(25, 22)
        Me.btnPsSale.TabIndex = 772
        '
        'btnPsOrder
        '
        Me.btnPsOrder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPsOrder.Image = CType(resources.GetObject("btnPsOrder.Image"), System.Drawing.Image)
        Me.btnPsOrder.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnPsOrder.Location = New System.Drawing.Point(911, 42)
        Me.btnPsOrder.Name = "btnPsOrder"
        Me.btnPsOrder.Size = New System.Drawing.Size(25, 22)
        Me.btnPsOrder.TabIndex = 771
        '
        'btnPsCus
        '
        Me.btnPsCus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPsCus.Image = CType(resources.GetObject("btnPsCus.Image"), System.Drawing.Image)
        Me.btnPsCus.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnPsCus.Location = New System.Drawing.Point(593, 16)
        Me.btnPsCus.Name = "btnPsCus"
        Me.btnPsCus.Size = New System.Drawing.Size(25, 22)
        Me.btnPsCus.TabIndex = 770
        '
        'lblCusNote
        '
        Me.lblCusNote.BackColor = System.Drawing.Color.Lavender
        Me.lblCusNote.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblCusNote.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCusNote.ForeColor = System.Drawing.Color.MediumBlue
        Me.lblCusNote.Location = New System.Drawing.Point(359, 70)
        Me.lblCusNote.Multiline = True
        Me.lblCusNote.Name = "lblCusNote"
        Me.lblCusNote.ReadOnly = True
        Me.lblCusNote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.lblCusNote.Size = New System.Drawing.Size(231, 47)
        Me.lblCusNote.TabIndex = 769
        Me.lblCusNote.TabStop = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label16.Location = New System.Drawing.Point(300, 72)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(54, 14)
        Me.Label16.TabIndex = 768
        Me.Label16.Text = "หมายเหตุ"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(319, 87)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 14)
        Me.Label6.TabIndex = 767
        Me.Label6.Text = "ลูกค้า"
        '
        'cmbGroupComp
        '
        Me.cmbGroupComp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGroupComp.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbGroupComp.FormattingEnabled = True
        Me.cmbGroupComp.Location = New System.Drawing.Point(106, 16)
        Me.cmbGroupComp.Name = "cmbGroupComp"
        Me.cmbGroupComp.Size = New System.Drawing.Size(188, 22)
        Me.cmbGroupComp.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(64, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 14)
        Me.Label4.TabIndex = 766
        Me.Label4.Text = "บริษัท"
        '
        'lblPsSale
        '
        Me.lblPsSale.BackColor = System.Drawing.Color.Gainsboro
        Me.lblPsSale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPsSale.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPsSale.Location = New System.Drawing.Point(710, 17)
        Me.lblPsSale.Name = "lblPsSale"
        Me.lblPsSale.Size = New System.Drawing.Size(198, 20)
        Me.lblPsSale.TabIndex = 586
        Me.lblPsSale.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDocCode
        '
        Me.lblDocCode.BackColor = System.Drawing.Color.Gainsboro
        Me.lblDocCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDocCode.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDocCode.Location = New System.Drawing.Point(106, 44)
        Me.lblDocCode.Name = "lblDocCode"
        Me.lblDocCode.Size = New System.Drawing.Size(150, 20)
        Me.lblDocCode.TabIndex = 561
        Me.lblDocCode.Text = "- - - - - - - - - - "
        Me.lblDocCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label21.Location = New System.Drawing.Point(633, 20)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(74, 14)
        Me.Label21.TabIndex = 585
        Me.Label21.Text = "เจ้าหน้าที่ขาย"
        '
        'txtNote
        '
        Me.txtNote.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNote.Location = New System.Drawing.Point(1012, 14)
        Me.txtNote.Multiline = True
        Me.txtNote.Name = "txtNote"
        Me.txtNote.Size = New System.Drawing.Size(157, 102)
        Me.txtNote.TabIndex = 6
        '
        'dtpOrder
        '
        Me.dtpOrder.CalendarFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpOrder.CustomFormat = "ddMMMMyyyy"
        Me.dtpOrder.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpOrder.Location = New System.Drawing.Point(106, 70)
        Me.dtpOrder.Name = "dtpOrder"
        Me.dtpOrder.Size = New System.Drawing.Size(150, 22)
        Me.dtpOrder.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.Location = New System.Drawing.Point(954, 17)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 14)
        Me.Label10.TabIndex = 557
        Me.Label10.Text = "หมายเหตุ"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 14)
        Me.Label1.TabIndex = 421
        Me.Label1.Text = "วันที่รับคำสั่งซื้อ"
        '
        'lblPsOrder
        '
        Me.lblPsOrder.BackColor = System.Drawing.Color.Gainsboro
        Me.lblPsOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPsOrder.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPsOrder.Location = New System.Drawing.Point(710, 43)
        Me.lblPsOrder.Name = "lblPsOrder"
        Me.lblPsOrder.Size = New System.Drawing.Size(198, 20)
        Me.lblPsOrder.TabIndex = 589
        Me.lblPsOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label53.Location = New System.Drawing.Point(638, 46)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(68, 14)
        Me.Label53.TabIndex = 588
        Me.Label53.Text = "ผู้รับคำสั่งซื้อ"
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label47.Location = New System.Drawing.Point(641, 72)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(65, 14)
        Me.Label47.TabIndex = 559
        Me.Label47.Text = "ผู้ทำรายการ"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label11.Location = New System.Drawing.Point(40, 47)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 14)
        Me.Label11.TabIndex = 558
        Me.Label11.Text = "เลขที่สั่งซื้อ"
        '
        'lblPsTs
        '
        Me.lblPsTs.BackColor = System.Drawing.Color.Gainsboro
        Me.lblPsTs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPsTs.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPsTs.Location = New System.Drawing.Point(710, 69)
        Me.lblPsTs.Name = "lblPsTs"
        Me.lblPsTs.Size = New System.Drawing.Size(198, 20)
        Me.lblPsTs.TabIndex = 560
        Me.lblPsTs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(627, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 14)
        Me.Label2.TabIndex = 556
        Me.Label2.Text = "วันที่ทำรายการ"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 14)
        Me.Label3.TabIndex = 569
        Me.Label3.Text = "วันที่ต้องการสินค้า"
        '
        'lblDateTs
        '
        Me.lblDateTs.BackColor = System.Drawing.Color.Gainsboro
        Me.lblDateTs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDateTs.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblDateTs.Location = New System.Drawing.Point(710, 94)
        Me.lblDateTs.Name = "lblDateTs"
        Me.lblDateTs.Size = New System.Drawing.Size(198, 22)
        Me.lblDateTs.TabIndex = 562
        Me.lblDateTs.Tag = "0"
        Me.lblDateTs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpRequire
        '
        Me.dtpRequire.CalendarFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpRequire.CustomFormat = "ddMMMMyyyy"
        Me.dtpRequire.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpRequire.Location = New System.Drawing.Point(106, 96)
        Me.dtpRequire.Name = "dtpRequire"
        Me.dtpRequire.Size = New System.Drawing.Size(150, 22)
        Me.dtpRequire.TabIndex = 2
        '
        'lblPsCus
        '
        Me.lblPsCus.BackColor = System.Drawing.Color.Gainsboro
        Me.lblPsCus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPsCus.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPsCus.ForeColor = System.Drawing.Color.Black
        Me.lblPsCus.Location = New System.Drawing.Point(359, 16)
        Me.lblPsCus.Name = "lblPsCus"
        Me.lblPsCus.Size = New System.Drawing.Size(231, 48)
        Me.lblPsCus.TabIndex = 583
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label51.Location = New System.Drawing.Point(321, 20)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(34, 14)
        Me.Label51.TabIndex = 582
        Me.Label51.Text = "ลูกค้า"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label14.Location = New System.Drawing.Point(188, 9)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(56, 16)
        Me.Label14.TabIndex = 604
        Me.Label14.Text = "กิโลกรัม"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label5.Location = New System.Drawing.Point(13, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 16)
        Me.Label5.TabIndex = 603
        Me.Label5.Text = "น้ำหนักรวม"
        '
        'lblWeight
        '
        Me.lblWeight.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblWeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblWeight.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblWeight.Location = New System.Drawing.Point(95, 7)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(89, 22)
        Me.lblWeight.TabIndex = 602
        Me.lblWeight.Tag = "0"
        Me.lblWeight.Text = "0"
        Me.lblWeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = "ตรวจสอบสถานะสต๊อก"
        Me.DataGridViewImageColumn1.Image = Global.SAM.My.Resources.Resources.arrow_refresh
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn1.Visible = False
        Me.DataGridViewImageColumn1.Width = 40
        '
        'DataGridViewImageColumn2
        '
        Me.DataGridViewImageColumn2.HeaderText = "ลบ"
        Me.DataGridViewImageColumn2.Image = Global.SAM.My.Resources.Resources.cross_circle_frame
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        Me.DataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewImageColumn2.Width = 35
        '
        'PanelControl1
        '
        Me.PanelControl1.Appearance.BackColor = System.Drawing.Color.Lavender
        Me.PanelControl1.Appearance.BackColor2 = System.Drawing.Color.LightSteelBlue
        Me.PanelControl1.Appearance.Options.UseBackColor = True
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.GroupBox3)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1184, 133)
        Me.PanelControl1.TabIndex = 0
        '
        'PanelControl3
        '
        Me.PanelControl3.Appearance.BackColor = System.Drawing.Color.LightSteelBlue
        Me.PanelControl3.Appearance.BackColor2 = System.Drawing.Color.CornflowerBlue
        Me.PanelControl3.Appearance.Options.UseBackColor = True
        Me.PanelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl3.Controls.Add(Me.Panel4)
        Me.PanelControl3.Controls.Add(Me.Panel1)
        Me.PanelControl3.Controls.Add(Me.Panel2)
        Me.PanelControl3.Controls.Add(Me.Panel8)
        Me.PanelControl3.Controls.Add(Me.btnNewPd)
        Me.PanelControl3.Controls.Add(Me.Panel3)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl3.Location = New System.Drawing.Point(0, 517)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(1184, 34)
        Me.PanelControl3.TabIndex = 2
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.Controls.Add(Me.btnSelectAll)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(338, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(164, 34)
        Me.Panel4.TabIndex = 771
        Me.Panel4.Visible = False
        '
        'btnSelectAll
        '
        Me.btnSelectAll.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectAll.Appearance.Options.UseFont = True
        Me.btnSelectAll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSelectAll.Image = CType(resources.GetObject("btnSelectAll.Image"), System.Drawing.Image)
        Me.btnSelectAll.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnSelectAll.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnSelectAll.Location = New System.Drawing.Point(2, 1)
        Me.btnSelectAll.Name = "btnSelectAll"
        Me.btnSelectAll.Size = New System.Drawing.Size(158, 32)
        Me.btnSelectAll.TabIndex = 2
        Me.btnSelectAll.Text = "เลือกรายการทั้งหมด"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.btn_img)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(200, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(138, 34)
        Me.Panel1.TabIndex = 769
        '
        'btn_img
        '
        Me.btn_img.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_img.Appearance.Options.UseFont = True
        Me.btn_img.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_img.Image = CType(resources.GetObject("btn_img.Image"), System.Drawing.Image)
        Me.btn_img.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btn_img.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_img.Location = New System.Drawing.Point(2, 1)
        Me.btn_img.Name = "btn_img"
        Me.btn_img.Size = New System.Drawing.Size(133, 32)
        Me.btn_img.TabIndex = 2
        Me.btn_img.Text = "รูปภาพอ้างอิง"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.btnClose)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(90, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(110, 34)
        Me.Panel2.TabIndex = 770
        Me.Panel2.Visible = False
        '
        'btnClose
        '
        Me.btnClose.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Appearance.Options.UseFont = True
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnClose.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnClose.Location = New System.Drawing.Point(2, 1)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(105, 32)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "ปิดรายการ"
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.Transparent
        Me.Panel8.Controls.Add(Me.btnSave)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(90, 34)
        Me.Panel8.TabIndex = 768
        '
        'btnSave
        '
        Me.btnSave.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Appearance.Options.UseFont = True
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnSave.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnSave.Location = New System.Drawing.Point(4, 1)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(84, 32)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "บันทึก"
        '
        'btnNewPd
        '
        Me.btnNewPd.BackColor = System.Drawing.Color.DimGray
        Me.btnNewPd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNewPd.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnNewPd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnNewPd.ForeColor = System.Drawing.Color.White
        Me.btnNewPd.Image = Global.SAM.My.Resources.Resources.FindItemInGrid
        Me.btnNewPd.Location = New System.Drawing.Point(824, 0)
        Me.btnNewPd.Name = "btnNewPd"
        Me.btnNewPd.Size = New System.Drawing.Size(111, 34)
        Me.btnNewPd.TabIndex = 767
        Me.btnNewPd.Tag = ""
        Me.btnNewPd.Text = " เลือกสินค้า"
        Me.btnNewPd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNewPd.UseVisualStyleBackColor = False
        Me.btnNewPd.Visible = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.Label14)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.lblWeight)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(935, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(249, 34)
        Me.Panel3.TabIndex = 766
        Me.Panel3.Visible = False
        '
        'GcOrder
        '
        Me.GcOrder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GcOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GcOrder.Location = New System.Drawing.Point(0, 133)
        Me.GcOrder.MainView = Me.GvOrder
        Me.GcOrder.Name = "GcOrder"
        Me.GcOrder.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rptDel, Me.rptUnit, Me.rptProductName, Me.rptPdCode, Me.rptSel})
        Me.GcOrder.Size = New System.Drawing.Size(1184, 384)
        Me.GcOrder.TabIndex = 1
        Me.GcOrder.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GvOrder})
        '
        'GvOrder
        '
        Me.GvOrder.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GvOrder.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GvOrder.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GvOrder.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GvOrder.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GvOrder.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GvOrder.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GvOrder.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GvOrder.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GvOrder.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GvOrder.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GvOrder.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GvOrder.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GvOrder.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.GvOrder.Appearance.Empty.Options.UseBackColor = True
        Me.GvOrder.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GvOrder.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GvOrder.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GvOrder.Appearance.EvenRow.Options.UseBackColor = True
        Me.GvOrder.Appearance.EvenRow.Options.UseBorderColor = True
        Me.GvOrder.Appearance.EvenRow.Options.UseForeColor = True
        Me.GvOrder.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GvOrder.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GvOrder.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GvOrder.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GvOrder.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GvOrder.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GvOrder.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GvOrder.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.GvOrder.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.GvOrder.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GvOrder.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GvOrder.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.GvOrder.Appearance.FixedLine.Options.UseBackColor = True
        Me.GvOrder.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GvOrder.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GvOrder.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GvOrder.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GvOrder.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.GvOrder.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GvOrder.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GvOrder.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GvOrder.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GvOrder.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GvOrder.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GvOrder.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GvOrder.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GvOrder.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GvOrder.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.GvOrder.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.GvOrder.Appearance.GroupButton.Options.UseBackColor = True
        Me.GvOrder.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GvOrder.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GvOrder.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GvOrder.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GvOrder.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GvOrder.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GvOrder.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GvOrder.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GvOrder.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.GvOrder.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.GvOrder.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GvOrder.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GvOrder.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GvOrder.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GvOrder.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GvOrder.Appearance.GroupRow.Options.UseBackColor = True
        Me.GvOrder.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GvOrder.Appearance.GroupRow.Options.UseForeColor = True
        Me.GvOrder.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GvOrder.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GvOrder.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GvOrder.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GvOrder.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GvOrder.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GvOrder.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.GvOrder.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.GvOrder.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GvOrder.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GvOrder.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.GvOrder.Appearance.HorzLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.GvOrder.Appearance.HorzLine.Options.UseBackColor = True
        Me.GvOrder.Appearance.HorzLine.Options.UseBorderColor = True
        Me.GvOrder.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GvOrder.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GvOrder.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GvOrder.Appearance.OddRow.Options.UseBackColor = True
        Me.GvOrder.Appearance.OddRow.Options.UseBorderColor = True
        Me.GvOrder.Appearance.OddRow.Options.UseForeColor = True
        Me.GvOrder.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.GvOrder.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.GvOrder.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.GvOrder.Appearance.Preview.Options.UseBackColor = True
        Me.GvOrder.Appearance.Preview.Options.UseFont = True
        Me.GvOrder.Appearance.Preview.Options.UseForeColor = True
        Me.GvOrder.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GvOrder.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GvOrder.Appearance.Row.Options.UseBackColor = True
        Me.GvOrder.Appearance.Row.Options.UseForeColor = True
        Me.GvOrder.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GvOrder.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.GvOrder.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GvOrder.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.GvOrder.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.GvOrder.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GvOrder.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GvOrder.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GvOrder.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GvOrder.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.GvOrder.Appearance.VertLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.GvOrder.Appearance.VertLine.Options.UseBackColor = True
        Me.GvOrder.Appearance.VertLine.Options.UseBorderColor = True
        Me.GvOrder.ColumnPanelRowHeight = 35
        Me.GvOrder.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColSel, Me.ColNum, Me.ColPdCode, Me.ColProductName, Me.ColPrice, Me.ColAmount, Me.ColAmtSale, Me.ColAmtBal, Me.ColidUnit, Me.ColNoteDt, Me.ColDel, Me.ColidSaleOrderDt, Me.colidInvMain, Me.ColUnit, Me.colidInvGroup, Me.ColidSubType, Me.ColidUnitPd, Me.ColPerbox, Me.ColStatus})
        Me.GvOrder.GridControl = Me.GcOrder
        Me.GvOrder.IndicatorWidth = 35
        Me.GvOrder.Name = "GvOrder"
        Me.GvOrder.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GvOrder.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDown
        Me.GvOrder.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GvOrder.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.GvOrder.OptionsView.EnableAppearanceEvenRow = True
        Me.GvOrder.OptionsView.EnableAppearanceOddRow = True
        Me.GvOrder.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GvOrder.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GvOrder.OptionsView.ShowGroupPanel = False
        Me.GvOrder.OptionsView.ShowIndicator = False
        Me.GvOrder.PaintStyleName = "Flat"
        '
        'ColSel
        '
        Me.ColSel.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColSel.AppearanceHeader.Options.UseFont = True
        Me.ColSel.AppearanceHeader.Options.UseTextOptions = True
        Me.ColSel.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColSel.Caption = "เลือก"
        Me.ColSel.ColumnEdit = Me.rptSel
        Me.ColSel.FieldName = "Sel"
        Me.ColSel.MaxWidth = 45
        Me.ColSel.MinWidth = 45
        Me.ColSel.Name = "ColSel"
        Me.ColSel.Width = 45
        '
        'rptSel
        '
        Me.rptSel.AutoHeight = False
        Me.rptSel.Name = "rptSel"
        '
        'ColNum
        '
        Me.ColNum.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColNum.AppearanceCell.Options.UseFont = True
        Me.ColNum.AppearanceCell.Options.UseTextOptions = True
        Me.ColNum.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColNum.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.ColNum.AppearanceHeader.Options.UseFont = True
        Me.ColNum.AppearanceHeader.Options.UseTextOptions = True
        Me.ColNum.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColNum.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColNum.Caption = "No."
        Me.ColNum.MaxWidth = 42
        Me.ColNum.MinWidth = 42
        Me.ColNum.Name = "ColNum"
        Me.ColNum.OptionsColumn.AllowEdit = False
        Me.ColNum.OptionsColumn.ReadOnly = True
        Me.ColNum.Visible = True
        Me.ColNum.VisibleIndex = 0
        Me.ColNum.Width = 42
        '
        'ColPdCode
        '
        Me.ColPdCode.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColPdCode.AppearanceCell.Options.UseFont = True
        Me.ColPdCode.AppearanceCell.Options.UseImage = True
        Me.ColPdCode.AppearanceCell.Options.UseTextOptions = True
        Me.ColPdCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColPdCode.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.ColPdCode.AppearanceHeader.Options.UseFont = True
        Me.ColPdCode.AppearanceHeader.Options.UseTextOptions = True
        Me.ColPdCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColPdCode.Caption = "รหัสสินค้า"
        Me.ColPdCode.ColumnEdit = Me.rptPdCode
        Me.ColPdCode.FieldName = "PdCode"
        Me.ColPdCode.MinWidth = 115
        Me.ColPdCode.Name = "ColPdCode"
        Me.ColPdCode.OptionsColumn.AllowEdit = False
        Me.ColPdCode.OptionsColumn.ReadOnly = True
        Me.ColPdCode.Visible = True
        Me.ColPdCode.VisibleIndex = 1
        Me.ColPdCode.Width = 140
        '
        'rptPdCode
        '
        Me.rptPdCode.AutoHeight = False
        Me.rptPdCode.Name = "rptPdCode"
        '
        'ColProductName
        '
        Me.ColProductName.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColProductName.AppearanceCell.Options.UseFont = True
        Me.ColProductName.AppearanceCell.Options.UseTextOptions = True
        Me.ColProductName.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.ColProductName.AppearanceHeader.Options.UseFont = True
        Me.ColProductName.AppearanceHeader.Options.UseTextOptions = True
        Me.ColProductName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColProductName.Caption = "รายการสินค้า"
        Me.ColProductName.ColumnEdit = Me.rptProductName
        Me.ColProductName.FieldName = "ProductName"
        Me.ColProductName.MinWidth = 10
        Me.ColProductName.Name = "ColProductName"
        Me.ColProductName.Visible = True
        Me.ColProductName.VisibleIndex = 2
        Me.ColProductName.Width = 468
        '
        'rptProductName
        '
        Me.rptProductName.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.[True]
        Me.rptProductName.AutoHeight = False
        Me.rptProductName.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.[Default], Global.SAM.My.Resources.Resources.search_png_16x16, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject3, "", Nothing, Nothing, True)})
        Me.rptProductName.LinkColorUseParentAppearance = True
        Me.rptProductName.Name = "rptProductName"
        Me.rptProductName.NullText = "เลือกสินค้า"
        '
        'ColPrice
        '
        Me.ColPrice.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColPrice.AppearanceCell.Options.UseFont = True
        Me.ColPrice.AppearanceCell.Options.UseTextOptions = True
        Me.ColPrice.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ColPrice.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.ColPrice.AppearanceHeader.Options.UseFont = True
        Me.ColPrice.AppearanceHeader.Options.UseTextOptions = True
        Me.ColPrice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColPrice.Caption = "ราคา"
        Me.ColPrice.DisplayFormat.FormatString = "#,##0.00##"
        Me.ColPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.ColPrice.FieldName = "Price"
        Me.ColPrice.MinWidth = 75
        Me.ColPrice.Name = "ColPrice"
        Me.ColPrice.Visible = True
        Me.ColPrice.VisibleIndex = 5
        Me.ColPrice.Width = 99
        '
        'ColAmount
        '
        Me.ColAmount.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColAmount.AppearanceCell.Options.UseFont = True
        Me.ColAmount.AppearanceCell.Options.UseTextOptions = True
        Me.ColAmount.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ColAmount.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.ColAmount.AppearanceHeader.Options.UseFont = True
        Me.ColAmount.AppearanceHeader.Options.UseTextOptions = True
        Me.ColAmount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColAmount.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColAmount.Caption = "จำนวนสั่งซื้อ"
        Me.ColAmount.DisplayFormat.FormatString = "#,##0.00##"
        Me.ColAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.ColAmount.FieldName = "Amount"
        Me.ColAmount.MinWidth = 60
        Me.ColAmount.Name = "ColAmount"
        Me.ColAmount.Visible = True
        Me.ColAmount.VisibleIndex = 3
        Me.ColAmount.Width = 104
        '
        'ColAmtSale
        '
        Me.ColAmtSale.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColAmtSale.AppearanceCell.Options.UseFont = True
        Me.ColAmtSale.AppearanceCell.Options.UseTextOptions = True
        Me.ColAmtSale.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ColAmtSale.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColAmtSale.AppearanceHeader.Options.UseFont = True
        Me.ColAmtSale.AppearanceHeader.Options.UseTextOptions = True
        Me.ColAmtSale.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColAmtSale.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColAmtSale.Caption = "จำนวนขายแล้ว"
        Me.ColAmtSale.DisplayFormat.FormatString = "#,##0.####"
        Me.ColAmtSale.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.ColAmtSale.FieldName = "AmtSale"
        Me.ColAmtSale.Name = "ColAmtSale"
        Me.ColAmtSale.OptionsColumn.AllowEdit = False
        Me.ColAmtSale.OptionsColumn.ReadOnly = True
        '
        'ColAmtBal
        '
        Me.ColAmtBal.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColAmtBal.AppearanceCell.Options.UseFont = True
        Me.ColAmtBal.AppearanceCell.Options.UseTextOptions = True
        Me.ColAmtBal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ColAmtBal.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColAmtBal.AppearanceHeader.Options.UseFont = True
        Me.ColAmtBal.AppearanceHeader.Options.UseTextOptions = True
        Me.ColAmtBal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColAmtBal.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColAmtBal.Caption = "จำนวนสั่งซื้อคงเหลือ"
        Me.ColAmtBal.DisplayFormat.FormatString = "#,##0.####"
        Me.ColAmtBal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.ColAmtBal.FieldName = "AmtBal"
        Me.ColAmtBal.Name = "ColAmtBal"
        Me.ColAmtBal.OptionsColumn.AllowEdit = False
        Me.ColAmtBal.OptionsColumn.ReadOnly = True
        '
        'ColidUnit
        '
        Me.ColidUnit.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColidUnit.AppearanceCell.Options.UseFont = True
        Me.ColidUnit.AppearanceCell.Options.UseTextOptions = True
        Me.ColidUnit.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColidUnit.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.ColidUnit.AppearanceHeader.Options.UseFont = True
        Me.ColidUnit.AppearanceHeader.Options.UseTextOptions = True
        Me.ColidUnit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColidUnit.Caption = "หน่วย"
        Me.ColidUnit.ColumnEdit = Me.rptUnit
        Me.ColidUnit.FieldName = "idUnit"
        Me.ColidUnit.MinWidth = 60
        Me.ColidUnit.Name = "ColidUnit"
        Me.ColidUnit.Visible = True
        Me.ColidUnit.VisibleIndex = 4
        Me.ColidUnit.Width = 84
        '
        'rptUnit
        '
        Me.rptUnit.AutoHeight = False
        Me.rptUnit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rptUnit.DisplayMember = "UnitName"
        Me.rptUnit.Name = "rptUnit"
        Me.rptUnit.NullText = ""
        Me.rptUnit.PopupFormMinSize = New System.Drawing.Size(40, 0)
        Me.rptUnit.ShowFooter = False
        Me.rptUnit.ShowHeader = False
        Me.rptUnit.ValueMember = "idUnit"
        '
        'ColNoteDt
        '
        Me.ColNoteDt.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColNoteDt.AppearanceCell.Options.UseFont = True
        Me.ColNoteDt.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.ColNoteDt.AppearanceHeader.Options.UseFont = True
        Me.ColNoteDt.AppearanceHeader.Options.UseTextOptions = True
        Me.ColNoteDt.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColNoteDt.Caption = "หมายเหตุ"
        Me.ColNoteDt.FieldName = "NoteDt"
        Me.ColNoteDt.Name = "ColNoteDt"
        Me.ColNoteDt.Visible = True
        Me.ColNoteDt.VisibleIndex = 6
        Me.ColNoteDt.Width = 189
        '
        'ColDel
        '
        Me.ColDel.AppearanceCell.Options.UseTextOptions = True
        Me.ColDel.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDel.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.ColDel.AppearanceHeader.Options.UseFont = True
        Me.ColDel.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDel.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDel.Caption = "ลบ"
        Me.ColDel.ColumnEdit = Me.rptDel
        Me.ColDel.MaxWidth = 35
        Me.ColDel.MinWidth = 35
        Me.ColDel.Name = "ColDel"
        Me.ColDel.OptionsColumn.AllowSize = False
        Me.ColDel.Visible = True
        Me.ColDel.VisibleIndex = 7
        Me.ColDel.Width = 35
        '
        'rptDel
        '
        Me.rptDel.AutoHeight = False
        Me.rptDel.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("rptDel.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject4, "", Nothing, Nothing, True)})
        Me.rptDel.Name = "rptDel"
        Me.rptDel.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'ColidSaleOrderDt
        '
        Me.ColidSaleOrderDt.Caption = "idSaleOrderDt"
        Me.ColidSaleOrderDt.FieldName = "idSaleOrderDt"
        Me.ColidSaleOrderDt.Name = "ColidSaleOrderDt"
        '
        'colidInvMain
        '
        Me.colidInvMain.Caption = "idInvMain"
        Me.colidInvMain.FieldName = "idInvMain"
        Me.colidInvMain.Name = "colidInvMain"
        '
        'ColUnit
        '
        Me.ColUnit.Caption = "idUnit"
        Me.ColUnit.FieldName = "idUnit"
        Me.ColUnit.Name = "ColUnit"
        '
        'colidInvGroup
        '
        Me.colidInvGroup.Caption = "idInvGroup"
        Me.colidInvGroup.FieldName = "idInvGroup"
        Me.colidInvGroup.Name = "colidInvGroup"
        '
        'ColidSubType
        '
        Me.ColidSubType.Caption = "idSubType"
        Me.ColidSubType.FieldName = "idSubType"
        Me.ColidSubType.Name = "ColidSubType"
        '
        'ColidUnitPd
        '
        Me.ColidUnitPd.Caption = "ifUnitPd"
        Me.ColidUnitPd.FieldName = "idUnitPd"
        Me.ColidUnitPd.Name = "ColidUnitPd"
        '
        'ColPerbox
        '
        Me.ColPerbox.Caption = "Perbox"
        Me.ColPerbox.FieldName = "Perbox"
        Me.ColPerbox.Name = "ColPerbox"
        '
        'ColStatus
        '
        Me.ColStatus.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColStatus.AppearanceCell.Options.UseFont = True
        Me.ColStatus.AppearanceCell.Options.UseTextOptions = True
        Me.ColStatus.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColStatus.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColStatus.AppearanceHeader.Options.UseFont = True
        Me.ColStatus.AppearanceHeader.Options.UseTextOptions = True
        Me.ColStatus.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColStatus.Caption = "สถานะ"
        Me.ColStatus.FieldName = "stBal"
        Me.ColStatus.Name = "ColStatus"
        Me.ColStatus.OptionsColumn.AllowEdit = False
        Me.ColStatus.OptionsColumn.ReadOnly = True
        '
        'frmSlOrderTs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(1184, 551)
        Me.Controls.Add(Me.GcOrder)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.PanelControl3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSlOrderTs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ทำรายการสั่งซื้อสินค้า (Order)"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.GcOrder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GvOrder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptSel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptPdCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptProductName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptUnit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptDel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lblDocCode As System.Windows.Forms.Label
    Friend WithEvents dtpOrder As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtNote As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpRequire As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblPsSale As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents lblPsCus As System.Windows.Forms.Label
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents lblPsOrder As System.Windows.Forms.Label
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblWeight As System.Windows.Forms.Label
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn2 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnNewPd As System.Windows.Forms.Button
    Friend WithEvents cmbGroupComp As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblCusNote As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GcOrder As DevExpress.XtraGrid.GridControl
    Friend WithEvents GvOrder As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColNum As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColPdCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rptPdCode As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents ColProductName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rptProductName As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents ColAmount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColidUnit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rptUnit As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents ColPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColidSaleOrderDt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColNoteDt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colidInvMain As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColUnit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rptDel As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents colidInvGroup As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColidSubType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColidUnitPd As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColPerbox As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnPsCus As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnPsOrder As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnPsSale As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_img As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel8 As Panel
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ColAmtSale As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColSel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rptSel As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents ColAmtBal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ColStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label47 As Label
    Friend WithEvents lblPsTs As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblDateTs As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnSelectAll As DevExpress.XtraEditors.SimpleButton
End Class
