<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSlReturnTs
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
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSlReturnTs))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim GridFormatRule1 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim GridFormatRule2 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleExpression1 As DevExpress.XtraEditors.FormatConditionRuleExpression = New DevExpress.XtraEditors.FormatConditionRuleExpression()
        Dim GridFormatRule3 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleExpression2 As DevExpress.XtraEditors.FormatConditionRuleExpression = New DevExpress.XtraEditors.FormatConditionRuleExpression()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.ColProductName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rptProductName = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
        Me.ColWh = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rptWareHouse = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.ColLotno = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rpttxtLotNo = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnPsReturn = New DevExpress.XtraEditors.SimpleButton()
        Me.btnPsSale = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCustomer = New DevExpress.XtraEditors.SimpleButton()
        Me.cmbGroupComp = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDocRef = New System.Windows.Forms.TextBox()
        Me.lblPsReturn = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbDRCode = New System.Windows.Forms.ComboBox()
        Me.txtNote = New System.Windows.Forms.TextBox()
        Me.lblPsSale = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblPsTs = New System.Windows.Forms.Label()
        Me.lblDateTs = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbCauseReturn = New System.Windows.Forms.ComboBox()
        Me.lblPsCus = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblDocNum = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.dtpReturn = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblRejectCase = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.txtRejectNote = New System.Windows.Forms.TextBox()
        Me.rdbReject = New System.Windows.Forms.RadioButton()
        Me.rdbApv = New System.Windows.Forms.RadioButton()
        Me.rdbNoApv = New System.Windows.Forms.RadioButton()
        Me.btnProcess = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtCntReturn = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.GCReturnMt = New DevExpress.XtraGrid.GridControl()
        Me.GVReturnDt = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colidInvMain = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidSaleDt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColidLot = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColidSale = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDocCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rptDocSale = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.ColAmtRT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColUnitName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColPricePerUnit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColRTValue = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColRTPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColExp = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDateGen = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColidUnit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColBalanceRT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColidSaleReturnDt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColidLotReturn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidLotSale = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColtempAmountRT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rptDel = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.idInvGroup = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemImageComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.btnAddLotRT = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        CType(Me.rptProductName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptWareHouse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpttxtLotNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.GCReturnMt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVReturnDt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptDocSale, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptDel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        Me.SuspendLayout()
        '
        'ColProductName
        '
        Me.ColProductName.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColProductName.AppearanceCell.Options.UseBackColor = True
        Me.ColProductName.AppearanceCell.Options.UseFont = True
        Me.ColProductName.AppearanceCell.Options.UseTextOptions = True
        Me.ColProductName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.ColProductName.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColProductName.AppearanceHeader.Options.UseFont = True
        Me.ColProductName.AppearanceHeader.Options.UseTextOptions = True
        Me.ColProductName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColProductName.Caption = "รายการสินค้า"
        Me.ColProductName.ColumnEdit = Me.rptProductName
        Me.ColProductName.FieldName = "InvName"
        Me.ColProductName.Name = "ColProductName"
        Me.ColProductName.OptionsColumn.TabStop = False
        Me.ColProductName.Visible = True
        Me.ColProductName.VisibleIndex = 1
        Me.ColProductName.Width = 401
        '
        'rptProductName
        '
        Me.rptProductName.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.[True]
        Me.rptProductName.Appearance.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rptProductName.Appearance.Options.UseForeColor = True
        Me.rptProductName.AutoHeight = False
        Me.rptProductName.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Global.SAM.My.Resources.Resources.search_png_16x16, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.rptProductName.Name = "rptProductName"
        Me.rptProductName.NullText = "เลือกสินค้า"
        Me.rptProductName.SingleClick = True
        Me.rptProductName.StartKey = New DevExpress.Utils.KeyShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F))
        '
        'ColWh
        '
        Me.ColWh.AppearanceCell.Options.UseFont = True
        Me.ColWh.AppearanceCell.Options.UseTextOptions = True
        Me.ColWh.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColWh.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ColWh.AppearanceHeader.Options.UseFont = True
        Me.ColWh.AppearanceHeader.Options.UseTextOptions = True
        Me.ColWh.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColWh.Caption = "คลัง"
        Me.ColWh.ColumnEdit = Me.rptWareHouse
        Me.ColWh.FieldName = "idWh"
        Me.ColWh.Name = "ColWh"
        Me.ColWh.Visible = True
        Me.ColWh.VisibleIndex = 5
        Me.ColWh.Width = 108
        '
        'rptWareHouse
        '
        Me.rptWareHouse.AutoHeight = False
        Me.rptWareHouse.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rptWareHouse.DisplayMember = "WareHouseName"
        Me.rptWareHouse.Name = "rptWareHouse"
        Me.rptWareHouse.NullText = "เลือกคลัง"
        Me.rptWareHouse.PopupFormMinSize = New System.Drawing.Size(50, 0)
        Me.rptWareHouse.ShowFooter = False
        Me.rptWareHouse.ShowHeader = False
        Me.rptWareHouse.ValueMember = "idWh"
        '
        'ColLotno
        '
        Me.ColLotno.AppearanceCell.Options.UseFont = True
        Me.ColLotno.AppearanceCell.Options.UseTextOptions = True
        Me.ColLotno.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColLotno.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ColLotno.AppearanceHeader.Options.UseFont = True
        Me.ColLotno.AppearanceHeader.Options.UseTextOptions = True
        Me.ColLotno.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColLotno.Caption = "Lot No."
        Me.ColLotno.ColumnEdit = Me.rpttxtLotNo
        Me.ColLotno.FieldName = "LotNo"
        Me.ColLotno.Name = "ColLotno"
        Me.ColLotno.Visible = True
        Me.ColLotno.VisibleIndex = 2
        Me.ColLotno.Width = 128
        '
        'rpttxtLotNo
        '
        Me.rpttxtLotNo.AutoHeight = False
        Me.rpttxtLotNo.Name = "rpttxtLotNo"
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Mask.EditMask = "([A-Z]|\d)+"
        Me.RepositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.RepositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.btnPsReturn)
        Me.GroupBox3.Controls.Add(Me.btnPsSale)
        Me.GroupBox3.Controls.Add(Me.btnCustomer)
        Me.GroupBox3.Controls.Add(Me.cmbGroupComp)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.txtDocRef)
        Me.GroupBox3.Controls.Add(Me.lblPsReturn)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.cmbDRCode)
        Me.GroupBox3.Controls.Add(Me.txtNote)
        Me.GroupBox3.Controls.Add(Me.lblPsSale)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.lblPsTs)
        Me.GroupBox3.Controls.Add(Me.lblDateTs)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.cmbCauseReturn)
        Me.GroupBox3.Controls.Add(Me.lblPsCus)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.lblDocNum)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.dtpReturn)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.Label24)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Location = New System.Drawing.Point(4, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1075, 126)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        '
        'btnPsReturn
        '
        Me.btnPsReturn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPsReturn.Image = Global.SAM.My.Resources.Resources.search_png_16x16
        Me.btnPsReturn.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnPsReturn.Location = New System.Drawing.Point(540, 71)
        Me.btnPsReturn.Name = "btnPsReturn"
        Me.btnPsReturn.Size = New System.Drawing.Size(25, 22)
        Me.btnPsReturn.TabIndex = 6
        '
        'btnPsSale
        '
        Me.btnPsSale.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPsSale.Image = Global.SAM.My.Resources.Resources.search_png_16x16
        Me.btnPsSale.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnPsSale.Location = New System.Drawing.Point(540, 43)
        Me.btnPsSale.Name = "btnPsSale"
        Me.btnPsSale.Size = New System.Drawing.Size(25, 22)
        Me.btnPsSale.TabIndex = 5
        '
        'btnCustomer
        '
        Me.btnCustomer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCustomer.Image = Global.SAM.My.Resources.Resources.search_png_16x16
        Me.btnCustomer.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnCustomer.Location = New System.Drawing.Point(765, 16)
        Me.btnCustomer.Name = "btnCustomer"
        Me.btnCustomer.Size = New System.Drawing.Size(25, 22)
        Me.btnCustomer.TabIndex = 4
        '
        'cmbGroupComp
        '
        Me.cmbGroupComp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGroupComp.Enabled = False
        Me.cmbGroupComp.FormattingEnabled = True
        Me.cmbGroupComp.Location = New System.Drawing.Point(93, 14)
        Me.cmbGroupComp.Name = "cmbGroupComp"
        Me.cmbGroupComp.Size = New System.Drawing.Size(180, 21)
        Me.cmbGroupComp.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(50, 17)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 965
        Me.Label7.Text = "บริษัท"
        '
        'txtDocRef
        '
        Me.txtDocRef.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtDocRef.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtDocRef.Location = New System.Drawing.Point(147, 71)
        Me.txtDocRef.MaxLength = 11
        Me.txtDocRef.Name = "txtDocRef"
        Me.txtDocRef.Size = New System.Drawing.Size(126, 20)
        Me.txtDocRef.TabIndex = 2
        '
        'lblPsReturn
        '
        Me.lblPsReturn.BackColor = System.Drawing.Color.Gainsboro
        Me.lblPsReturn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPsReturn.Location = New System.Drawing.Point(379, 72)
        Me.lblPsReturn.Name = "lblPsReturn"
        Me.lblPsReturn.Size = New System.Drawing.Size(159, 20)
        Me.lblPsReturn.TabIndex = 624
        Me.lblPsReturn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(303, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 15)
        Me.Label4.TabIndex = 623
        Me.Label4.Text = "ผู้รับคืนสินค้า"
        '
        'cmbDRCode
        '
        Me.cmbDRCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDRCode.FormattingEnabled = True
        Me.cmbDRCode.Location = New System.Drawing.Point(93, 70)
        Me.cmbDRCode.Name = "cmbDRCode"
        Me.cmbDRCode.Size = New System.Drawing.Size(51, 21)
        Me.cmbDRCode.TabIndex = 1
        '
        'txtNote
        '
        Me.txtNote.Location = New System.Drawing.Point(873, 17)
        Me.txtNote.Multiline = True
        Me.txtNote.Name = "txtNote"
        Me.txtNote.Size = New System.Drawing.Size(175, 94)
        Me.txtNote.TabIndex = 8
        '
        'lblPsSale
        '
        Me.lblPsSale.BackColor = System.Drawing.Color.Gainsboro
        Me.lblPsSale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPsSale.Location = New System.Drawing.Point(379, 44)
        Me.lblPsSale.Name = "lblPsSale"
        Me.lblPsSale.Size = New System.Drawing.Size(159, 20)
        Me.lblPsSale.TabIndex = 622
        Me.lblPsSale.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label13.Location = New System.Drawing.Point(815, 17)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(52, 15)
        Me.Label13.TabIndex = 630
        Me.Label13.Text = "หมายเหตุ"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label15.Location = New System.Drawing.Point(304, 46)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(69, 15)
        Me.Label15.TabIndex = 621
        Me.Label15.Text = "เจ้าหน้าที่ขาย"
        '
        'lblPsTs
        '
        Me.lblPsTs.BackColor = System.Drawing.Color.Gainsboro
        Me.lblPsTs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPsTs.Location = New System.Drawing.Point(635, 70)
        Me.lblPsTs.Name = "lblPsTs"
        Me.lblPsTs.Size = New System.Drawing.Size(156, 20)
        Me.lblPsTs.TabIndex = 560
        Me.lblPsTs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDateTs
        '
        Me.lblDateTs.BackColor = System.Drawing.Color.Gainsboro
        Me.lblDateTs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDateTs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblDateTs.Location = New System.Drawing.Point(635, 43)
        Me.lblDateTs.Name = "lblDateTs"
        Me.lblDateTs.Size = New System.Drawing.Size(156, 22)
        Me.lblDateTs.TabIndex = 562
        Me.lblDateTs.Tag = "0"
        Me.lblDateTs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(338, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 15)
        Me.Label6.TabIndex = 618
        Me.Label6.Text = "ลูกค้า"
        '
        'cmbCauseReturn
        '
        Me.cmbCauseReturn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCauseReturn.FormattingEnabled = True
        Me.cmbCauseReturn.Location = New System.Drawing.Point(379, 98)
        Me.cmbCauseReturn.Name = "cmbCauseReturn"
        Me.cmbCauseReturn.Size = New System.Drawing.Size(186, 21)
        Me.cmbCauseReturn.TabIndex = 7
        '
        'lblPsCus
        '
        Me.lblPsCus.BackColor = System.Drawing.Color.Gainsboro
        Me.lblPsCus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPsCus.Location = New System.Drawing.Point(379, 17)
        Me.lblPsCus.Name = "lblPsCus"
        Me.lblPsCus.Size = New System.Drawing.Size(383, 20)
        Me.lblPsCus.TabIndex = 619
        Me.lblPsCus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(570, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 15)
        Me.Label2.TabIndex = 556
        Me.Label2.Text = "วันที่รายการ"
        '
        'lblDocNum
        '
        Me.lblDocNum.BackColor = System.Drawing.Color.Gainsboro
        Me.lblDocNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDocNum.Location = New System.Drawing.Point(93, 41)
        Me.lblDocNum.Name = "lblDocNum"
        Me.lblDocNum.Size = New System.Drawing.Size(180, 20)
        Me.lblDocNum.TabIndex = 627
        Me.lblDocNum.Text = "- - - - - - - - - - "
        Me.lblDocNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.Location = New System.Drawing.Point(572, 72)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 15)
        Me.Label9.TabIndex = 559
        Me.Label9.Text = "ผู้ทำรายการ"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label14.Location = New System.Drawing.Point(16, 43)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(68, 15)
        Me.Label14.TabIndex = 626
        Me.Label14.Text = "เลขที่รายการ"
        '
        'dtpReturn
        '
        Me.dtpReturn.CustomFormat = "dd  MMMM yyyy"
        Me.dtpReturn.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpReturn.Location = New System.Drawing.Point(93, 97)
        Me.dtpReturn.Name = "dtpReturn"
        Me.dtpReturn.Size = New System.Drawing.Size(145, 20)
        Me.dtpReturn.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 421
        Me.Label1.Text = "วันที่คืนสินค้า"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(26, 72)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(58, 13)
        Me.Label24.TabIndex = 576
        Me.Label24.Text = "เลขที่อ้างอิง"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.Location = New System.Drawing.Point(300, 99)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 15)
        Me.Label10.TabIndex = 557
        Me.Label10.Text = "สาเหตุการคืน"
        '
        'lblRejectCase
        '
        Me.lblRejectCase.AutoSize = True
        Me.lblRejectCase.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblRejectCase.ForeColor = System.Drawing.Color.Brown
        Me.lblRejectCase.Location = New System.Drawing.Point(6, 8)
        Me.lblRejectCase.Name = "lblRejectCase"
        Me.lblRejectCase.Size = New System.Drawing.Size(100, 16)
        Me.lblRejectCase.TabIndex = 633
        Me.lblRejectCase.Text = "สาเหตุ Reject: "
        Me.lblRejectCase.Visible = False
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTotal.ForeColor = System.Drawing.Color.Lime
        Me.txtTotal.Location = New System.Drawing.Point(318, 8)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(120, 24)
        Me.txtTotal.TabIndex = 627
        Me.txtTotal.TabStop = False
        Me.txtTotal.Text = "0"
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(198, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 17)
        Me.Label5.TabIndex = 626
        Me.Label5.Text = "รวมจำนวนเงินคืน"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Transparent
        Me.Panel7.Controls.Add(Me.txtRejectNote)
        Me.Panel7.Controls.Add(Me.rdbReject)
        Me.Panel7.Controls.Add(Me.rdbApv)
        Me.Panel7.Controls.Add(Me.rdbNoApv)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel7.Location = New System.Drawing.Point(281, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(455, 30)
        Me.Panel7.TabIndex = 608
        Me.Panel7.Visible = False
        '
        'txtRejectNote
        '
        Me.txtRejectNote.Enabled = False
        Me.txtRejectNote.Location = New System.Drawing.Point(257, 5)
        Me.txtRejectNote.MaxLength = 7
        Me.txtRejectNote.Multiline = True
        Me.txtRejectNote.Name = "txtRejectNote"
        Me.txtRejectNote.Size = New System.Drawing.Size(182, 19)
        Me.txtRejectNote.TabIndex = 618
        '
        'rdbReject
        '
        Me.rdbReject.AutoSize = True
        Me.rdbReject.ForeColor = System.Drawing.Color.White
        Me.rdbReject.Location = New System.Drawing.Point(157, 6)
        Me.rdbReject.Name = "rdbReject"
        Me.rdbReject.Size = New System.Drawing.Size(98, 17)
        Me.rdbReject.TabIndex = 5
        Me.rdbReject.TabStop = True
        Me.rdbReject.Text = "Reject สาเหตุ : "
        Me.rdbReject.UseVisualStyleBackColor = True
        '
        'rdbApv
        '
        Me.rdbApv.AutoSize = True
        Me.rdbApv.ForeColor = System.Drawing.Color.White
        Me.rdbApv.Location = New System.Drawing.Point(9, 5)
        Me.rdbApv.Name = "rdbApv"
        Me.rdbApv.Size = New System.Drawing.Size(53, 17)
        Me.rdbApv.TabIndex = 3
        Me.rdbApv.TabStop = True
        Me.rdbApv.Text = "อนุมัติ"
        Me.rdbApv.UseVisualStyleBackColor = True
        '
        'rdbNoApv
        '
        Me.rdbNoApv.AutoSize = True
        Me.rdbNoApv.ForeColor = System.Drawing.Color.White
        Me.rdbNoApv.Location = New System.Drawing.Point(76, 5)
        Me.rdbNoApv.Name = "rdbNoApv"
        Me.rdbNoApv.Size = New System.Drawing.Size(66, 17)
        Me.rdbNoApv.TabIndex = 4
        Me.rdbNoApv.TabStop = True
        Me.rdbNoApv.Text = "ไม่อนุมัติ"
        Me.rdbNoApv.UseVisualStyleBackColor = True
        '
        'btnProcess
        '
        Me.btnProcess.AutoSize = True
        Me.btnProcess.BackColor = System.Drawing.Color.DimGray
        Me.btnProcess.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnProcess.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnProcess.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnProcess.ForeColor = System.Drawing.Color.White
        Me.btnProcess.Image = CType(resources.GetObject("btnProcess.Image"), System.Drawing.Image)
        Me.btnProcess.Location = New System.Drawing.Point(185, 0)
        Me.btnProcess.Name = "btnProcess"
        Me.btnProcess.Size = New System.Drawing.Size(96, 30)
        Me.btnProcess.TabIndex = 2
        Me.btnProcess.Text = "รับทราบ"
        Me.btnProcess.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnProcess.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnProcess.UseVisualStyleBackColor = False
        Me.btnProcess.Visible = False
        '
        'btnDelete
        '
        Me.btnDelete.AutoSize = True
        Me.btnDelete.BackColor = System.Drawing.Color.DimGray
        Me.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDelete.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.Location = New System.Drawing.Point(89, 0)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(96, 30)
        Me.btnDelete.TabIndex = 1
        Me.btnDelete.Text = "ยกเลิก"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDelete.UseVisualStyleBackColor = False
        Me.btnDelete.Visible = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.DimGray
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(0, 0)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(89, 30)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Tag = "Save"
        Me.btnSave.Text = "       บันทึก"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.Controls.Add(Me.Label12)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.txtCntReturn)
        Me.Panel4.Controls.Add(Me.txtTotal)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(640, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(444, 38)
        Me.Panel4.TabIndex = 606
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(152, 11)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(44, 17)
        Me.Label12.TabIndex = 632
        Me.Label12.Text = "หน่วย"
        '
        'txtCntReturn
        '
        Me.txtCntReturn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtCntReturn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCntReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCntReturn.ForeColor = System.Drawing.Color.Lime
        Me.txtCntReturn.Location = New System.Drawing.Point(83, 8)
        Me.txtCntReturn.Name = "txtCntReturn"
        Me.txtCntReturn.ReadOnly = True
        Me.txtCntReturn.Size = New System.Drawing.Size(66, 24)
        Me.txtCntReturn.TabIndex = 631
        Me.txtCntReturn.TabStop = False
        Me.txtCntReturn.Text = "0"
        Me.txtCntReturn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(7, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 17)
        Me.Label3.TabIndex = 630
        Me.Label3.Text = "จำนวนคืน"
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = "ลบ"
        Me.DataGridViewImageColumn1.Image = CType(resources.GetObject("DataGridViewImageColumn1.Image"), System.Drawing.Image)
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewImageColumn1.Width = 35
        '
        'DataGridViewImageColumn2
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle1.NullValue = Nothing
        Me.DataGridViewImageColumn2.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewImageColumn2.HeaderText = "คืน"
        Me.DataGridViewImageColumn2.Image = CType(resources.GetObject("DataGridViewImageColumn2.Image"), System.Drawing.Image)
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        Me.DataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn2.Width = 40
        '
        'GCReturnMt
        '
        Me.GCReturnMt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCReturnMt.Location = New System.Drawing.Point(0, 170)
        Me.GCReturnMt.MainView = Me.GVReturnDt
        Me.GCReturnMt.Name = "GCReturnMt"
        Me.GCReturnMt.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rptDel, Me.rptWareHouse, Me.RepositoryItemTextEdit1, Me.RepositoryItemImageComboBox1, Me.rptProductName, Me.rpttxtLotNo, Me.rptDocSale})
        Me.GCReturnMt.Size = New System.Drawing.Size(1084, 342)
        Me.GCReturnMt.TabIndex = 2
        Me.GCReturnMt.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVReturnDt})
        '
        'GVReturnDt
        '
        Me.GVReturnDt.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GVReturnDt.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GVReturnDt.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVReturnDt.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVReturnDt.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GVReturnDt.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GVReturnDt.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.GVReturnDt.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.GVReturnDt.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVReturnDt.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVReturnDt.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GVReturnDt.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GVReturnDt.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVReturnDt.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.GVReturnDt.Appearance.Empty.Options.UseBackColor = True
        Me.GVReturnDt.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.GVReturnDt.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GVReturnDt.Appearance.EvenRow.Options.UseBackColor = True
        Me.GVReturnDt.Appearance.EvenRow.Options.UseForeColor = True
        Me.GVReturnDt.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GVReturnDt.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GVReturnDt.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVReturnDt.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GVReturnDt.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GVReturnDt.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GVReturnDt.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVReturnDt.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.GVReturnDt.Appearance.FilterPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GVReturnDt.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVReturnDt.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GVReturnDt.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GVReturnDt.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVReturnDt.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GVReturnDt.Appearance.FocusedCell.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GVReturnDt.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVReturnDt.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVReturnDt.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GVReturnDt.Appearance.FocusedRow.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GVReturnDt.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVReturnDt.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVReturnDt.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GVReturnDt.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GVReturnDt.Appearance.FooterPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVReturnDt.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVReturnDt.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVReturnDt.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GVReturnDt.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GVReturnDt.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GVReturnDt.Appearance.GroupButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVReturnDt.Appearance.GroupButton.Options.UseBackColor = True
        Me.GVReturnDt.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GVReturnDt.Appearance.GroupButton.Options.UseForeColor = True
        Me.GVReturnDt.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.GVReturnDt.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.GVReturnDt.Appearance.GroupFooter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVReturnDt.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVReturnDt.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GVReturnDt.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GVReturnDt.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVReturnDt.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.GVReturnDt.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.GVReturnDt.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GVReturnDt.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVReturnDt.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.GVReturnDt.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.GVReturnDt.Appearance.GroupRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVReturnDt.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVReturnDt.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GVReturnDt.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVReturnDt.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.GVReturnDt.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.GVReturnDt.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVReturnDt.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVReturnDt.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVReturnDt.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GVReturnDt.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.GVReturnDt.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVReturnDt.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVReturnDt.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVReturnDt.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GVReturnDt.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVReturnDt.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.GVReturnDt.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GVReturnDt.Appearance.OddRow.Options.UseBackColor = True
        Me.GVReturnDt.Appearance.OddRow.Options.UseForeColor = True
        Me.GVReturnDt.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.GVReturnDt.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.GVReturnDt.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GVReturnDt.Appearance.Preview.Options.UseBackColor = True
        Me.GVReturnDt.Appearance.Preview.Options.UseFont = True
        Me.GVReturnDt.Appearance.Preview.Options.UseForeColor = True
        Me.GVReturnDt.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.GVReturnDt.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GVReturnDt.Appearance.Row.Options.UseBackColor = True
        Me.GVReturnDt.Appearance.Row.Options.UseForeColor = True
        Me.GVReturnDt.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVReturnDt.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.GVReturnDt.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GVReturnDt.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.GVReturnDt.Appearance.SelectedRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVReturnDt.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVReturnDt.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GVReturnDt.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GVReturnDt.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GVReturnDt.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GVReturnDt.Appearance.VertLine.Options.UseBackColor = True
        Me.GVReturnDt.ColumnPanelRowHeight = 40
        Me.GVReturnDt.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colidInvMain, Me.colidSaleDt, Me.ColidLot, Me.ColidSale, Me.ColDocCode, Me.ColLotno, Me.ColProductName, Me.ColAmtRT, Me.ColUnitName, Me.ColWh, Me.ColPricePerUnit, Me.ColRTValue, Me.ColRTPrice, Me.ColExp, Me.ColDateGen, Me.ColidUnit, Me.ColBalanceRT, Me.ColidSaleReturnDt, Me.ColidLotReturn, Me.colidLotSale, Me.ColtempAmountRT, Me.ColDel, Me.idInvGroup})
        GridFormatRule1.Name = "Format0"
        GridFormatRule1.Rule = Nothing
        GridFormatRule2.Column = Me.ColProductName
        GridFormatRule2.ColumnApplyTo = Me.ColProductName
        GridFormatRule2.Name = "Format1"
        FormatConditionRuleExpression1.Appearance.ForeColor = System.Drawing.Color.Silver
        FormatConditionRuleExpression1.Appearance.Options.UseForeColor = True
        FormatConditionRuleExpression1.Expression = "[InvName] Like 'เลือกสินค้า'"
        GridFormatRule2.Rule = FormatConditionRuleExpression1
        GridFormatRule3.Column = Me.ColWh
        GridFormatRule3.ColumnApplyTo = Me.ColWh
        GridFormatRule3.Name = "Format2"
        FormatConditionRuleExpression2.Appearance.ForeColor = System.Drawing.Color.Silver
        FormatConditionRuleExpression2.Appearance.Options.UseForeColor = True
        FormatConditionRuleExpression2.Expression = "[idWh] Like 'เลือกคลัง'"
        GridFormatRule3.Rule = FormatConditionRuleExpression2
        Me.GVReturnDt.FormatRules.Add(GridFormatRule1)
        Me.GVReturnDt.FormatRules.Add(GridFormatRule2)
        Me.GVReturnDt.FormatRules.Add(GridFormatRule3)
        Me.GVReturnDt.GridControl = Me.GCReturnMt
        Me.GVReturnDt.Name = "GVReturnDt"
        Me.GVReturnDt.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GVReturnDt.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDown
        Me.GVReturnDt.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GVReturnDt.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.GVReturnDt.OptionsView.EnableAppearanceEvenRow = True
        Me.GVReturnDt.OptionsView.EnableAppearanceOddRow = True
        Me.GVReturnDt.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GVReturnDt.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GVReturnDt.OptionsView.ShowGroupPanel = False
        Me.GVReturnDt.OptionsView.ShowIndicator = False
        Me.GVReturnDt.PaintStyleName = "MixedXP"
        '
        'colidInvMain
        '
        Me.colidInvMain.AppearanceCell.Options.UseFont = True
        Me.colidInvMain.Caption = "idInvMain"
        Me.colidInvMain.FieldName = "idInvMain"
        Me.colidInvMain.Name = "colidInvMain"
        '
        'colidSaleDt
        '
        Me.colidSaleDt.AppearanceCell.Options.UseFont = True
        Me.colidSaleDt.Caption = "idSaleDt"
        Me.colidSaleDt.FieldName = "idSaleDt"
        Me.colidSaleDt.Name = "colidSaleDt"
        '
        'ColidLot
        '
        Me.ColidLot.AppearanceCell.Options.UseFont = True
        Me.ColidLot.Caption = "idLot"
        Me.ColidLot.FieldName = "idLot"
        Me.ColidLot.Name = "ColidLot"
        '
        'ColidSale
        '
        Me.ColidSale.AppearanceCell.Options.UseFont = True
        Me.ColidSale.Caption = "idSale"
        Me.ColidSale.FieldName = "idSale"
        Me.ColidSale.Name = "ColidSale"
        '
        'ColDocCode
        '
        Me.ColDocCode.AppearanceCell.Options.UseFont = True
        Me.ColDocCode.AppearanceCell.Options.UseTextOptions = True
        Me.ColDocCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDocCode.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColDocCode.AppearanceHeader.Options.UseFont = True
        Me.ColDocCode.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDocCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDocCode.Caption = "เลขที่บิลขาย"
        Me.ColDocCode.ColumnEdit = Me.rptDocSale
        Me.ColDocCode.FieldName = "DocRef"
        Me.ColDocCode.Name = "ColDocCode"
        Me.ColDocCode.Visible = True
        Me.ColDocCode.VisibleIndex = 0
        Me.ColDocCode.Width = 128
        '
        'rptDocSale
        '
        Me.rptDocSale.AutoHeight = False
        Me.rptDocSale.Name = "rptDocSale"
        '
        'ColAmtRT
        '
        Me.ColAmtRT.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.ColAmtRT.AppearanceCell.Options.UseBackColor = True
        Me.ColAmtRT.AppearanceCell.Options.UseFont = True
        Me.ColAmtRT.AppearanceCell.Options.UseTextOptions = True
        Me.ColAmtRT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ColAmtRT.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColAmtRT.AppearanceHeader.Options.UseFont = True
        Me.ColAmtRT.AppearanceHeader.Options.UseTextOptions = True
        Me.ColAmtRT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColAmtRT.Caption = "จำนวนรับคืน"
        Me.ColAmtRT.DisplayFormat.FormatString = "#,##0.00##"
        Me.ColAmtRT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColAmtRT.FieldName = "AmountRT"
        Me.ColAmtRT.Name = "ColAmtRT"
        Me.ColAmtRT.Visible = True
        Me.ColAmtRT.VisibleIndex = 3
        Me.ColAmtRT.Width = 99
        '
        'ColUnitName
        '
        Me.ColUnitName.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColUnitName.AppearanceCell.Options.UseBackColor = True
        Me.ColUnitName.AppearanceCell.Options.UseFont = True
        Me.ColUnitName.AppearanceCell.Options.UseTextOptions = True
        Me.ColUnitName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColUnitName.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColUnitName.AppearanceHeader.Options.UseFont = True
        Me.ColUnitName.AppearanceHeader.Options.UseTextOptions = True
        Me.ColUnitName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColUnitName.Caption = "หน่วย"
        Me.ColUnitName.FieldName = "UnitName"
        Me.ColUnitName.Name = "ColUnitName"
        Me.ColUnitName.OptionsColumn.AllowEdit = False
        Me.ColUnitName.OptionsColumn.ReadOnly = True
        Me.ColUnitName.OptionsColumn.TabStop = False
        Me.ColUnitName.Visible = True
        Me.ColUnitName.VisibleIndex = 4
        Me.ColUnitName.Width = 88
        '
        'ColPricePerUnit
        '
        Me.ColPricePerUnit.AppearanceCell.Options.UseFont = True
        Me.ColPricePerUnit.AppearanceCell.Options.UseTextOptions = True
        Me.ColPricePerUnit.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ColPricePerUnit.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ColPricePerUnit.AppearanceHeader.Options.UseFont = True
        Me.ColPricePerUnit.AppearanceHeader.Options.UseTextOptions = True
        Me.ColPricePerUnit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColPricePerUnit.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColPricePerUnit.Caption = "ราคาขาย"
        Me.ColPricePerUnit.DisplayFormat.FormatString = "#,##0.00##"
        Me.ColPricePerUnit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColPricePerUnit.FieldName = "Price"
        Me.ColPricePerUnit.Name = "ColPricePerUnit"
        Me.ColPricePerUnit.Visible = True
        Me.ColPricePerUnit.VisibleIndex = 6
        Me.ColPricePerUnit.Width = 70
        '
        'ColRTValue
        '
        Me.ColRTValue.AppearanceCell.Options.UseFont = True
        Me.ColRTValue.AppearanceCell.Options.UseTextOptions = True
        Me.ColRTValue.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColRTValue.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ColRTValue.AppearanceHeader.Options.UseFont = True
        Me.ColRTValue.AppearanceHeader.Options.UseTextOptions = True
        Me.ColRTValue.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColRTValue.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColRTValue.Caption = "% มูลค่าคืนสินค้า"
        Me.ColRTValue.DisplayFormat.FormatString = "#,##0.00##"
        Me.ColRTValue.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColRTValue.FieldName = "RTValuePerc"
        Me.ColRTValue.Name = "ColRTValue"
        Me.ColRTValue.Visible = True
        Me.ColRTValue.VisibleIndex = 7
        '
        'ColRTPrice
        '
        Me.ColRTPrice.AppearanceCell.Options.UseFont = True
        Me.ColRTPrice.AppearanceCell.Options.UseTextOptions = True
        Me.ColRTPrice.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ColRTPrice.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ColRTPrice.AppearanceHeader.Options.UseFont = True
        Me.ColRTPrice.AppearanceHeader.Options.UseTextOptions = True
        Me.ColRTPrice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColRTPrice.Caption = "ราคาคืน"
        Me.ColRTPrice.DisplayFormat.FormatString = "#,##0.00##"
        Me.ColRTPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColRTPrice.FieldName = "RTPrice"
        Me.ColRTPrice.Name = "ColRTPrice"
        Me.ColRTPrice.Visible = True
        Me.ColRTPrice.VisibleIndex = 8
        Me.ColRTPrice.Width = 70
        '
        'ColExp
        '
        Me.ColExp.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ColExp.AppearanceCell.Options.UseBackColor = True
        Me.ColExp.AppearanceCell.Options.UseFont = True
        Me.ColExp.AppearanceCell.Options.UseTextOptions = True
        Me.ColExp.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ColExp.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ColExp.AppearanceHeader.Options.UseFont = True
        Me.ColExp.AppearanceHeader.Options.UseTextOptions = True
        Me.ColExp.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColExp.Caption = "รวมเป็นเงิน"
        Me.ColExp.DisplayFormat.FormatString = "#,##0.00##"
        Me.ColExp.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColExp.FieldName = "Exp"
        Me.ColExp.Name = "ColExp"
        Me.ColExp.OptionsColumn.AllowEdit = False
        Me.ColExp.OptionsColumn.ReadOnly = True
        Me.ColExp.OptionsColumn.TabStop = False
        Me.ColExp.Visible = True
        Me.ColExp.VisibleIndex = 9
        Me.ColExp.Width = 131
        '
        'ColDateGen
        '
        Me.ColDateGen.AppearanceCell.Options.UseFont = True
        Me.ColDateGen.Caption = "DateGen"
        Me.ColDateGen.FieldName = "DateGen"
        Me.ColDateGen.Name = "ColDateGen"
        '
        'ColidUnit
        '
        Me.ColidUnit.AppearanceCell.Options.UseFont = True
        Me.ColidUnit.Caption = "idUnit "
        Me.ColidUnit.FieldName = "idUnit"
        Me.ColidUnit.Name = "ColidUnit"
        '
        'ColBalanceRT
        '
        Me.ColBalanceRT.AppearanceCell.Options.UseFont = True
        Me.ColBalanceRT.Caption = "BalanceRT"
        Me.ColBalanceRT.DisplayFormat.FormatString = "N2"
        Me.ColBalanceRT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColBalanceRT.FieldName = "BalanceRT"
        Me.ColBalanceRT.Name = "ColBalanceRT"
        '
        'ColidSaleReturnDt
        '
        Me.ColidSaleReturnDt.AppearanceCell.Options.UseFont = True
        Me.ColidSaleReturnDt.Caption = "idSaleReturnDt"
        Me.ColidSaleReturnDt.FieldName = "idSaleReturnDt"
        Me.ColidSaleReturnDt.Name = "ColidSaleReturnDt"
        '
        'ColidLotReturn
        '
        Me.ColidLotReturn.AppearanceCell.Options.UseFont = True
        Me.ColidLotReturn.Caption = "idLotReturn"
        Me.ColidLotReturn.FieldName = "idLotReturn"
        Me.ColidLotReturn.Name = "ColidLotReturn"
        '
        'colidLotSale
        '
        Me.colidLotSale.AppearanceCell.Options.UseFont = True
        Me.colidLotSale.Caption = "idLotSale"
        Me.colidLotSale.FieldName = "idLotSale"
        Me.colidLotSale.Name = "colidLotSale"
        '
        'ColtempAmountRT
        '
        Me.ColtempAmountRT.AppearanceCell.Options.UseFont = True
        Me.ColtempAmountRT.Caption = "tempAmountRT"
        Me.ColtempAmountRT.FieldName = "AmountRT"
        Me.ColtempAmountRT.Name = "ColtempAmountRT"
        '
        'ColDel
        '
        Me.ColDel.AppearanceCell.Options.UseFont = True
        Me.ColDel.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ColDel.AppearanceHeader.Options.UseFont = True
        Me.ColDel.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDel.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDel.Caption = "ลบ"
        Me.ColDel.ColumnEdit = Me.rptDel
        Me.ColDel.MaxWidth = 30
        Me.ColDel.MinWidth = 30
        Me.ColDel.Name = "ColDel"
        Me.ColDel.Visible = True
        Me.ColDel.VisibleIndex = 10
        Me.ColDel.Width = 30
        '
        'rptDel
        '
        Me.rptDel.AutoHeight = False
        Me.rptDel.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Global.SAM.My.Resources.Resources.minus2, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject2, "", Nothing, Nothing, True)})
        Me.rptDel.Name = "rptDel"
        Me.rptDel.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'idInvGroup
        '
        Me.idInvGroup.Caption = "idInvGroup"
        Me.idInvGroup.FieldName = "idInvGroup"
        Me.idInvGroup.Name = "idInvGroup"
        '
        'RepositoryItemImageComboBox1
        '
        Me.RepositoryItemImageComboBox1.AutoHeight = False
        Me.RepositoryItemImageComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemImageComboBox1.Name = "RepositoryItemImageComboBox1"
        '
        'PanelControl2
        '
        Me.PanelControl2.Appearance.BackColor = System.Drawing.Color.LightSteelBlue
        Me.PanelControl2.Appearance.BackColor2 = System.Drawing.Color.CornflowerBlue
        Me.PanelControl2.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.PanelControl2.Appearance.Options.UseBackColor = True
        Me.PanelControl2.Appearance.Options.UseFont = True
        Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl2.Controls.Add(Me.Panel7)
        Me.PanelControl2.Controls.Add(Me.btnProcess)
        Me.PanelControl2.Controls.Add(Me.btnDelete)
        Me.PanelControl2.Controls.Add(Me.btnSave)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 512)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(1084, 30)
        Me.PanelControl2.TabIndex = 3
        '
        'PanelControl1
        '
        Me.PanelControl1.Appearance.BackColor = System.Drawing.Color.LightSteelBlue
        Me.PanelControl1.Appearance.BackColor2 = System.Drawing.Color.CornflowerBlue
        Me.PanelControl1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.PanelControl1.Appearance.Options.UseBackColor = True
        Me.PanelControl1.Appearance.Options.UseFont = True
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.btnAddLotRT)
        Me.PanelControl1.Controls.Add(Me.Panel1)
        Me.PanelControl1.Controls.Add(Me.Panel4)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 132)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1084, 38)
        Me.PanelControl1.TabIndex = 1
        '
        'btnAddLotRT
        '
        Me.btnAddLotRT.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddLotRT.Appearance.Options.UseFont = True
        Me.btnAddLotRT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddLotRT.Image = CType(resources.GetObject("btnAddLotRT.Image"), System.Drawing.Image)
        Me.btnAddLotRT.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btnAddLotRT.Location = New System.Drawing.Point(4, 4)
        Me.btnAddLotRT.Name = "btnAddLotRT"
        Me.btnAddLotRT.Size = New System.Drawing.Size(119, 30)
        Me.btnAddLotRT.TabIndex = 635
        Me.btnAddLotRT.Text = "เพิ่ม Lot รับคืน"
        Me.btnAddLotRT.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.lblRejectCase)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(129, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(511, 38)
        Me.Panel1.TabIndex = 634
        '
        'PanelControl3
        '
        Me.PanelControl3.Appearance.BackColor = System.Drawing.Color.Lavender
        Me.PanelControl3.Appearance.BackColor2 = System.Drawing.Color.LightSteelBlue
        Me.PanelControl3.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.PanelControl3.Appearance.Options.UseBackColor = True
        Me.PanelControl3.Appearance.Options.UseFont = True
        Me.PanelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl3.Controls.Add(Me.GroupBox3)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl3.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(1084, 132)
        Me.PanelControl3.TabIndex = 723
        '
        'frmSlReturnTs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(1084, 542)
        Me.Controls.Add(Me.GCReturnMt)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSlReturnTs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ทำรายการคืนสินค้า (รหัส 153)"
        CType(Me.rptProductName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptWareHouse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpttxtLotNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.GCReturnMt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVReturnDt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptDocSale, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptDel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpReturn As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblDateTs As System.Windows.Forms.Label
    Friend WithEvents lblPsTs As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblPsCus As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblPsSale As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lblPsReturn As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn2 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtCntReturn As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblDocNum As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cmbCauseReturn As System.Windows.Forms.ComboBox
    Friend WithEvents txtNote As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cmbDRCode As System.Windows.Forms.ComboBox
    Friend WithEvents GCReturnMt As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVReturnDt As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colidSaleDt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColidLot As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColidSale As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDocCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColLotno As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColProductName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColAmtRT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColUnitName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColPricePerUnit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColRTValue As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColRTPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rptDel As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents ColidUnit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColBalanceRT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents ColidSaleReturnDt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColidLotReturn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColtempAmountRT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnProcess As System.Windows.Forms.Button
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents txtRejectNote As System.Windows.Forms.TextBox
    Friend WithEvents rdbReject As System.Windows.Forms.RadioButton
    Friend WithEvents rdbApv As System.Windows.Forms.RadioButton
    Friend WithEvents rdbNoApv As System.Windows.Forms.RadioButton
    Friend WithEvents lblRejectCase As System.Windows.Forms.Label
    Friend WithEvents ColWh As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rptWareHouse As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents txtDocRef As System.Windows.Forms.TextBox
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colidInvMain As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColExp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDateGen As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemImageComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents colidLotSale As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmbGroupComp As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnCustomer As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnPsSale As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnPsReturn As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents rptProductName As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents rpttxtLotNo As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents rptDocSale As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents idInvGroup As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnAddLotRT As DevExpress.XtraEditors.SimpleButton
End Class
