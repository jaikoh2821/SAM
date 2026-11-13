<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCreditDebitNoteTs
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
        Dim GridFormatRule1 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleExpression1 As DevExpress.XtraEditors.FormatConditionRuleExpression = New DevExpress.XtraEditors.FormatConditionRuleExpression()
        Dim GridFormatRule2 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleExpression2 As DevExpress.XtraEditors.FormatConditionRuleExpression = New DevExpress.XtraEditors.FormatConditionRuleExpression()
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCreditDebitNoteTs))
        Me.ColLotNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.cmbDRCode = New System.Windows.Forms.ComboBox()
        Me.txtTotalNet = New System.Windows.Forms.Label()
        Me.lblI = New System.Windows.Forms.Label()
        Me.txtDocImpress = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPartnerName = New System.Windows.Forms.TextBox()
        Me.lblTotalDiff = New System.Windows.Forms.Label()
        Me.lblTotalNew = New System.Windows.Forms.Label()
        Me.lblTotalSale = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblDocCode = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNote = New System.Windows.Forms.TextBox()
        Me.lblDateNote = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCustomer = New DevExpress.XtraEditors.SimpleButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbGroupComp = New System.Windows.Forms.ComboBox()
        Me.dtpDateNote = New System.Windows.Forms.DateTimePicker()
        Me.lblPsSale = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtDocRef = New System.Windows.Forms.TextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.stLbl_DateTs = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stLbl_PsTs = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GCSale = New DevExpress.XtraGrid.GridControl()
        Me.DGVBind = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColNum = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDocCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDateSaleD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColPdCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColProductName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColAmtSale = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColUnitName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColPriceSale = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColPriceNew = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rptPriceNew = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.ColPriceDiff = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColTotalPriceDiff = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rptDel = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.ColidSaleDt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColidUnit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidNoteDt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidSale = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColidProduct = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.btnPdInc = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.GCSale, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVBind, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptPriceNew, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptDel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        Me.SuspendLayout()
        '
        'ColLotNo
        '
        Me.ColLotNo.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColLotNo.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ColLotNo.AppearanceCell.Options.UseBackColor = True
        Me.ColLotNo.AppearanceCell.Options.UseFont = True
        Me.ColLotNo.AppearanceCell.Options.UseTextOptions = True
        Me.ColLotNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColLotNo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ColLotNo.AppearanceHeader.Options.UseFont = True
        Me.ColLotNo.AppearanceHeader.Options.UseTextOptions = True
        Me.ColLotNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColLotNo.Caption = "Lot No."
        Me.ColLotNo.FieldName = "LotNo"
        Me.ColLotNo.MinWidth = 100
        Me.ColLotNo.Name = "ColLotNo"
        Me.ColLotNo.OptionsColumn.AllowEdit = False
        Me.ColLotNo.OptionsColumn.ReadOnly = True
        Me.ColLotNo.OptionsColumn.TabStop = False
        Me.ColLotNo.Width = 100
        '
        'PanelControl1
        '
        Me.PanelControl1.Appearance.BackColor = System.Drawing.Color.Lavender
        Me.PanelControl1.Appearance.BackColor2 = System.Drawing.Color.LightSteelBlue
        Me.PanelControl1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.PanelControl1.Appearance.Options.UseBackColor = True
        Me.PanelControl1.Appearance.Options.UseFont = True
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.GroupBox6)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1184, 137)
        Me.PanelControl1.TabIndex = 0
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.cmbDRCode)
        Me.GroupBox6.Controls.Add(Me.txtTotalNet)
        Me.GroupBox6.Controls.Add(Me.lblI)
        Me.GroupBox6.Controls.Add(Me.txtDocImpress)
        Me.GroupBox6.Controls.Add(Me.Label1)
        Me.GroupBox6.Controls.Add(Me.txtPartnerName)
        Me.GroupBox6.Controls.Add(Me.lblTotalDiff)
        Me.GroupBox6.Controls.Add(Me.lblTotalNew)
        Me.GroupBox6.Controls.Add(Me.lblTotalSale)
        Me.GroupBox6.Controls.Add(Me.Label12)
        Me.GroupBox6.Controls.Add(Me.lblDocCode)
        Me.GroupBox6.Controls.Add(Me.Label11)
        Me.GroupBox6.Controls.Add(Me.Label9)
        Me.GroupBox6.Controls.Add(Me.Label4)
        Me.GroupBox6.Controls.Add(Me.txtNote)
        Me.GroupBox6.Controls.Add(Me.lblDateNote)
        Me.GroupBox6.Controls.Add(Me.Label3)
        Me.GroupBox6.Controls.Add(Me.btnCustomer)
        Me.GroupBox6.Controls.Add(Me.Label8)
        Me.GroupBox6.Controls.Add(Me.cmbGroupComp)
        Me.GroupBox6.Controls.Add(Me.dtpDateNote)
        Me.GroupBox6.Controls.Add(Me.lblPsSale)
        Me.GroupBox6.Controls.Add(Me.Label15)
        Me.GroupBox6.Controls.Add(Me.Label6)
        Me.GroupBox6.Controls.Add(Me.Label10)
        Me.GroupBox6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(9, 2)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(1163, 129)
        Me.GroupBox6.TabIndex = 0
        Me.GroupBox6.TabStop = False
        '
        'cmbDRCode
        '
        Me.cmbDRCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDRCode.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmbDRCode.FormattingEnabled = True
        Me.cmbDRCode.Location = New System.Drawing.Point(409, 41)
        Me.cmbDRCode.Name = "cmbDRCode"
        Me.cmbDRCode.Size = New System.Drawing.Size(54, 22)
        Me.cmbDRCode.TabIndex = 986
        '
        'txtTotalNet
        '
        Me.txtTotalNet.BackColor = System.Drawing.Color.Black
        Me.txtTotalNet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalNet.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtTotalNet.ForeColor = System.Drawing.Color.Lime
        Me.txtTotalNet.Location = New System.Drawing.Point(980, 80)
        Me.txtTotalNet.Name = "txtTotalNet"
        Me.txtTotalNet.Size = New System.Drawing.Size(163, 27)
        Me.txtTotalNet.TabIndex = 985
        Me.txtTotalNet.Text = "0"
        Me.txtTotalNet.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblI
        '
        Me.lblI.AutoSize = True
        Me.lblI.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblI.Location = New System.Drawing.Point(338, 46)
        Me.lblI.Name = "lblI"
        Me.lblI.Size = New System.Drawing.Size(66, 14)
        Me.lblI.TabIndex = 983
        Me.lblI.Text = "เลขที่อ้างอิง"
        '
        'txtDocImpress
        '
        Me.txtDocImpress.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtDocImpress.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtDocImpress.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDocImpress.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDocImpress.Location = New System.Drawing.Point(465, 41)
        Me.txtDocImpress.MaxLength = 15
        Me.txtDocImpress.Name = "txtDocImpress"
        Me.txtDocImpress.Size = New System.Drawing.Size(139, 22)
        Me.txtDocImpress.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(904, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 14)
        Me.Label1.TabIndex = 982
        Me.Label1.Text = "7% แล้ว"
        '
        'txtPartnerName
        '
        Me.txtPartnerName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtPartnerName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtPartnerName.BackColor = System.Drawing.Color.Gainsboro
        Me.txtPartnerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPartnerName.Location = New System.Drawing.Point(84, 46)
        Me.txtPartnerName.Multiline = True
        Me.txtPartnerName.Name = "txtPartnerName"
        Me.txtPartnerName.ReadOnly = True
        Me.txtPartnerName.Size = New System.Drawing.Size(181, 41)
        Me.txtPartnerName.TabIndex = 1
        '
        'lblTotalDiff
        '
        Me.lblTotalDiff.BackColor = System.Drawing.Color.Gainsboro
        Me.lblTotalDiff.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalDiff.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalDiff.ForeColor = System.Drawing.Color.Red
        Me.lblTotalDiff.Location = New System.Drawing.Point(980, 52)
        Me.lblTotalDiff.Name = "lblTotalDiff"
        Me.lblTotalDiff.Size = New System.Drawing.Size(163, 20)
        Me.lblTotalDiff.TabIndex = 981
        Me.lblTotalDiff.Text = "0"
        Me.lblTotalDiff.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotalNew
        '
        Me.lblTotalNew.BackColor = System.Drawing.Color.Gainsboro
        Me.lblTotalNew.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalNew.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalNew.Location = New System.Drawing.Point(980, 18)
        Me.lblTotalNew.Name = "lblTotalNew"
        Me.lblTotalNew.Size = New System.Drawing.Size(163, 20)
        Me.lblTotalNew.TabIndex = 980
        Me.lblTotalNew.Text = "0"
        Me.lblTotalNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotalSale
        '
        Me.lblTotalSale.BackColor = System.Drawing.Color.Gainsboro
        Me.lblTotalSale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalSale.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalSale.Location = New System.Drawing.Point(695, 17)
        Me.lblTotalSale.Name = "lblTotalSale"
        Me.lblTotalSale.Size = New System.Drawing.Size(172, 20)
        Me.lblTotalSale.TabIndex = 979
        Me.lblTotalSale.Text = "0"
        Me.lblTotalSale.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(888, 87)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(86, 14)
        Me.Label12.TabIndex = 977
        Me.Label12.Text = "จำนวนเงินทั้งสิ้น"
        '
        'lblDocCode
        '
        Me.lblDocCode.BackColor = System.Drawing.Color.Gainsboro
        Me.lblDocCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDocCode.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDocCode.Location = New System.Drawing.Point(409, 15)
        Me.lblDocCode.Name = "lblDocCode"
        Me.lblDocCode.Size = New System.Drawing.Size(195, 20)
        Me.lblDocCode.TabIndex = 586
        Me.lblDocCode.Text = "- - - - - - - - - - "
        Me.lblDocCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label11.Location = New System.Drawing.Point(334, 18)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(70, 14)
        Me.Label11.TabIndex = 972
        Me.Label11.Text = "เลขที่เอกสาร"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(637, 47)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 14)
        Me.Label9.TabIndex = 970
        Me.Label9.Text = "หมายเหตุ"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(888, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 14)
        Me.Label4.TabIndex = 583
        Me.Label4.Text = "รวมภาษีมูลค่าเพิ่ม"
        '
        'txtNote
        '
        Me.txtNote.BackColor = System.Drawing.Color.White
        Me.txtNote.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNote.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNote.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtNote.Location = New System.Drawing.Point(695, 49)
        Me.txtNote.Multiline = True
        Me.txtNote.Name = "txtNote"
        Me.txtNote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNote.Size = New System.Drawing.Size(172, 69)
        Me.txtNote.TabIndex = 5
        '
        'lblDateNote
        '
        Me.lblDateNote.AutoSize = True
        Me.lblDateNote.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateNote.Location = New System.Drawing.Point(344, 73)
        Me.lblDateNote.Name = "lblDateNote"
        Me.lblDateNote.Size = New System.Drawing.Size(58, 14)
        Me.lblDateNote.TabIndex = 585
        Me.lblDateNote.Text = "วันที่ลดหนี้"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(888, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 14)
        Me.Label3.TabIndex = 581
        Me.Label3.Text = "มูลค่าที่ถูกต้อง"
        '
        'btnCustomer
        '
        Me.btnCustomer.Appearance.BackColor = System.Drawing.Color.Gray
        Me.btnCustomer.Appearance.Options.UseBackColor = True
        Me.btnCustomer.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.btnCustomer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCustomer.Image = Global.SAM.My.Resources.Resources.Find16
        Me.btnCustomer.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnCustomer.Location = New System.Drawing.Point(267, 46)
        Me.btnCustomer.Name = "btnCustomer"
        Me.btnCustomer.Size = New System.Drawing.Size(25, 22)
        Me.btnCustomer.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(637, 19)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 14)
        Me.Label8.TabIndex = 579
        Me.Label8.Text = "มูลค่าเดิม"
        '
        'cmbGroupComp
        '
        Me.cmbGroupComp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGroupComp.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbGroupComp.FormattingEnabled = True
        Me.cmbGroupComp.Location = New System.Drawing.Point(84, 15)
        Me.cmbGroupComp.Name = "cmbGroupComp"
        Me.cmbGroupComp.Size = New System.Drawing.Size(181, 22)
        Me.cmbGroupComp.TabIndex = 0
        '
        'dtpDateNote
        '
        Me.dtpDateNote.CustomFormat = "ddMMMMyyyy"
        Me.dtpDateNote.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDateNote.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateNote.Location = New System.Drawing.Point(409, 69)
        Me.dtpDateNote.Name = "dtpDateNote"
        Me.dtpDateNote.Size = New System.Drawing.Size(195, 22)
        Me.dtpDateNote.TabIndex = 4
        '
        'lblPsSale
        '
        Me.lblPsSale.BackColor = System.Drawing.Color.Gainsboro
        Me.lblPsSale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPsSale.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPsSale.Location = New System.Drawing.Point(409, 98)
        Me.lblPsSale.Name = "lblPsSale"
        Me.lblPsSale.Size = New System.Drawing.Size(195, 20)
        Me.lblPsSale.TabIndex = 586
        Me.lblPsSale.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(330, 100)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(74, 14)
        Me.Label15.TabIndex = 585
        Me.Label15.Text = "เจ้าหน้าที่ขาย"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(43, 47)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 14)
        Me.Label6.TabIndex = 582
        Me.Label6.Text = "ลูกค้า"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(43, 19)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(38, 14)
        Me.Label10.TabIndex = 967
        Me.Label10.Text = "บริษัท"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.White
        Me.Label24.Location = New System.Drawing.Point(6, 9)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(94, 14)
        Me.Label24.TabIndex = 578
        Me.Label24.Text = "เลขที่อ้างอิงขาย"
        '
        'txtDocRef
        '
        Me.txtDocRef.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtDocRef.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtDocRef.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDocRef.Enabled = False
        Me.txtDocRef.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDocRef.Location = New System.Drawing.Point(101, 5)
        Me.txtDocRef.MaxLength = 15
        Me.txtDocRef.Name = "txtDocRef"
        Me.txtDocRef.Size = New System.Drawing.Size(178, 22)
        Me.txtDocRef.TabIndex = 0
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.stLbl_DateTs, Me.stLbl_PsTs})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 529)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StatusStrip1.Size = New System.Drawing.Size(1184, 22)
        Me.StatusStrip1.TabIndex = 4
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'stLbl_DateTs
        '
        Me.stLbl_DateTs.Image = Global.SAM.My.Resources.Resources.DateTime
        Me.stLbl_DateTs.Name = "stLbl_DateTs"
        Me.stLbl_DateTs.Size = New System.Drawing.Size(93, 17)
        Me.stLbl_DateTs.Text = ": วันที่ทำรายการ"
        Me.stLbl_DateTs.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'stLbl_PsTs
        '
        Me.stLbl_PsTs.Image = Global.SAM.My.Resources.Resources.Person_32x32
        Me.stLbl_PsTs.Name = "stLbl_PsTs"
        Me.stLbl_PsTs.Size = New System.Drawing.Size(81, 17)
        Me.stLbl_PsTs.Text = ": ผู้ทำรายการ"
        Me.stLbl_PsTs.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'GCSale
        '
        Me.GCSale.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCSale.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GCSale.Location = New System.Drawing.Point(0, 169)
        Me.GCSale.MainView = Me.DGVBind
        Me.GCSale.Name = "GCSale"
        Me.GCSale.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rptDel, Me.rptPriceNew})
        Me.GCSale.Size = New System.Drawing.Size(1184, 325)
        Me.GCSale.TabIndex = 7
        Me.GCSale.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.DGVBind})
        '
        'DGVBind
        '
        Me.DGVBind.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.DGVBind.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.DGVBind.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DGVBind.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.DGVBind.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.DGVBind.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.DGVBind.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.DGVBind.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.DGVBind.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DGVBind.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.DGVBind.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.DGVBind.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.DGVBind.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DGVBind.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.DGVBind.Appearance.Empty.Options.UseBackColor = True
        Me.DGVBind.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.DGVBind.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.DGVBind.Appearance.EvenRow.Options.UseBackColor = True
        Me.DGVBind.Appearance.EvenRow.Options.UseForeColor = True
        Me.DGVBind.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.DGVBind.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.DGVBind.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DGVBind.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.DGVBind.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.DGVBind.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.DGVBind.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DGVBind.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.DGVBind.Appearance.FilterPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.DGVBind.Appearance.FilterPanel.Options.UseBackColor = True
        Me.DGVBind.Appearance.FilterPanel.Options.UseForeColor = True
        Me.DGVBind.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.DGVBind.Appearance.FixedLine.Options.UseBackColor = True
        Me.DGVBind.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.DGVBind.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.DGVBind.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.DGVBind.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.DGVBind.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.DGVBind.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.DGVBind.Appearance.FooterPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DGVBind.Appearance.FooterPanel.Options.UseBackColor = True
        Me.DGVBind.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.DGVBind.Appearance.FooterPanel.Options.UseForeColor = True
        Me.DGVBind.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.DGVBind.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.DGVBind.Appearance.GroupButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DGVBind.Appearance.GroupButton.Options.UseBackColor = True
        Me.DGVBind.Appearance.GroupButton.Options.UseBorderColor = True
        Me.DGVBind.Appearance.GroupButton.Options.UseForeColor = True
        Me.DGVBind.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.DGVBind.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.DGVBind.Appearance.GroupFooter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DGVBind.Appearance.GroupFooter.Options.UseBackColor = True
        Me.DGVBind.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.DGVBind.Appearance.GroupFooter.Options.UseForeColor = True
        Me.DGVBind.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DGVBind.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.DGVBind.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.DGVBind.Appearance.GroupPanel.Options.UseBackColor = True
        Me.DGVBind.Appearance.GroupPanel.Options.UseForeColor = True
        Me.DGVBind.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.DGVBind.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.DGVBind.Appearance.GroupRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DGVBind.Appearance.GroupRow.Options.UseBackColor = True
        Me.DGVBind.Appearance.GroupRow.Options.UseBorderColor = True
        Me.DGVBind.Appearance.GroupRow.Options.UseForeColor = True
        Me.DGVBind.Appearance.HeaderPanel.BackColor = System.Drawing.Color.DodgerBlue
        Me.DGVBind.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.LightSkyBlue
        Me.DGVBind.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.White
        Me.DGVBind.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.DGVBind.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.DGVBind.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.DGVBind.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.DGVBind.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.DGVBind.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.DGVBind.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.DGVBind.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.DGVBind.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.DGVBind.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.DGVBind.Appearance.HorzLine.Options.UseBackColor = True
        Me.DGVBind.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.DGVBind.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.DGVBind.Appearance.OddRow.Options.UseBackColor = True
        Me.DGVBind.Appearance.OddRow.Options.UseForeColor = True
        Me.DGVBind.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.DGVBind.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.DGVBind.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.DGVBind.Appearance.Preview.Options.UseBackColor = True
        Me.DGVBind.Appearance.Preview.Options.UseFont = True
        Me.DGVBind.Appearance.Preview.Options.UseForeColor = True
        Me.DGVBind.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.DGVBind.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.DGVBind.Appearance.Row.Options.UseBackColor = True
        Me.DGVBind.Appearance.Row.Options.UseForeColor = True
        Me.DGVBind.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DGVBind.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.DGVBind.Appearance.RowSeparator.Options.UseBackColor = True
        Me.DGVBind.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.DGVBind.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.DGVBind.Appearance.SelectedRow.Options.UseBackColor = True
        Me.DGVBind.Appearance.SelectedRow.Options.UseForeColor = True
        Me.DGVBind.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.DGVBind.Appearance.TopNewRow.Options.UseBackColor = True
        Me.DGVBind.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.DGVBind.Appearance.VertLine.Options.UseBackColor = True
        Me.DGVBind.ColumnPanelRowHeight = 35
        Me.DGVBind.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColNum, Me.ColDocCode, Me.ColDateSaleD, Me.ColPdCode, Me.ColLotNo, Me.ColProductName, Me.ColAmtSale, Me.ColUnitName, Me.ColPriceSale, Me.ColPriceNew, Me.ColPriceDiff, Me.ColTotalPriceDiff, Me.ColDel, Me.ColidSaleDt, Me.ColidUnit, Me.colidNoteDt, Me.colidSale, Me.ColidProduct})
        GridFormatRule1.ApplyToRow = True
        GridFormatRule1.Name = "Format0"
        FormatConditionRuleExpression1.Appearance.ForeColor = System.Drawing.Color.Red
        FormatConditionRuleExpression1.Appearance.Options.UseForeColor = True
        FormatConditionRuleExpression1.Expression = "[stEnough] = 0"
        GridFormatRule1.Rule = FormatConditionRuleExpression1
        GridFormatRule2.Column = Me.ColLotNo
        GridFormatRule2.ColumnApplyTo = Me.ColLotNo
        GridFormatRule2.Name = "Format1"
        FormatConditionRuleExpression2.Appearance.ForeColor = System.Drawing.Color.Silver
        FormatConditionRuleExpression2.Appearance.Options.UseForeColor = True
        FormatConditionRuleExpression2.Expression = "[LotNo] = 'เลือก Lot'"
        GridFormatRule2.Rule = FormatConditionRuleExpression2
        Me.DGVBind.FormatRules.Add(GridFormatRule1)
        Me.DGVBind.FormatRules.Add(GridFormatRule2)
        Me.DGVBind.GridControl = Me.GCSale
        Me.DGVBind.IndicatorWidth = 35
        Me.DGVBind.Name = "DGVBind"
        Me.DGVBind.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.DGVBind.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDown
        Me.DGVBind.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.DGVBind.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.DGVBind.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect
        Me.DGVBind.OptionsView.EnableAppearanceEvenRow = True
        Me.DGVBind.OptionsView.EnableAppearanceOddRow = True
        Me.DGVBind.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.DGVBind.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.DGVBind.OptionsView.ShowGroupPanel = False
        Me.DGVBind.OptionsView.ShowIndicator = False
        Me.DGVBind.PaintStyleName = "UltraFlat"
        '
        'ColNum
        '
        Me.ColNum.AppearanceCell.BackColor = System.Drawing.Color.Gainsboro
        Me.ColNum.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ColNum.AppearanceCell.Options.UseBackColor = True
        Me.ColNum.AppearanceCell.Options.UseFont = True
        Me.ColNum.AppearanceCell.Options.UseTextOptions = True
        Me.ColNum.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColNum.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ColNum.AppearanceHeader.Options.UseFont = True
        Me.ColNum.AppearanceHeader.Options.UseTextOptions = True
        Me.ColNum.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColNum.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColNum.Caption = "ลำดับ"
        Me.ColNum.MaxWidth = 42
        Me.ColNum.MinWidth = 42
        Me.ColNum.Name = "ColNum"
        Me.ColNum.OptionsColumn.AllowEdit = False
        Me.ColNum.OptionsColumn.ReadOnly = True
        Me.ColNum.OptionsColumn.TabStop = False
        Me.ColNum.Visible = True
        Me.ColNum.VisibleIndex = 0
        Me.ColNum.Width = 42
        '
        'ColDocCode
        '
        Me.ColDocCode.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColDocCode.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ColDocCode.AppearanceCell.Options.UseBackColor = True
        Me.ColDocCode.AppearanceCell.Options.UseFont = True
        Me.ColDocCode.AppearanceCell.Options.UseTextOptions = True
        Me.ColDocCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDocCode.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ColDocCode.AppearanceHeader.Options.UseFont = True
        Me.ColDocCode.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDocCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDocCode.Caption = "เลขที่อ้างอิงขาย"
        Me.ColDocCode.FieldName = "DocRef"
        Me.ColDocCode.MinWidth = 100
        Me.ColDocCode.Name = "ColDocCode"
        Me.ColDocCode.OptionsColumn.AllowEdit = False
        Me.ColDocCode.OptionsColumn.ReadOnly = True
        Me.ColDocCode.Visible = True
        Me.ColDocCode.VisibleIndex = 1
        Me.ColDocCode.Width = 100
        '
        'ColDateSaleD
        '
        Me.ColDateSaleD.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColDateSaleD.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ColDateSaleD.AppearanceCell.Options.UseBackColor = True
        Me.ColDateSaleD.AppearanceCell.Options.UseFont = True
        Me.ColDateSaleD.AppearanceCell.Options.UseTextOptions = True
        Me.ColDateSaleD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDateSaleD.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ColDateSaleD.AppearanceHeader.Options.UseFont = True
        Me.ColDateSaleD.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDateSaleD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDateSaleD.Caption = "วันที่ขาย"
        Me.ColDateSaleD.FieldName = "DateSaleD"
        Me.ColDateSaleD.MinWidth = 85
        Me.ColDateSaleD.Name = "ColDateSaleD"
        Me.ColDateSaleD.OptionsColumn.AllowEdit = False
        Me.ColDateSaleD.OptionsColumn.ReadOnly = True
        Me.ColDateSaleD.Visible = True
        Me.ColDateSaleD.VisibleIndex = 2
        Me.ColDateSaleD.Width = 85
        '
        'ColPdCode
        '
        Me.ColPdCode.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColPdCode.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ColPdCode.AppearanceCell.Options.UseBackColor = True
        Me.ColPdCode.AppearanceCell.Options.UseFont = True
        Me.ColPdCode.AppearanceCell.Options.UseImage = True
        Me.ColPdCode.AppearanceCell.Options.UseTextOptions = True
        Me.ColPdCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColPdCode.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ColPdCode.AppearanceHeader.Options.UseFont = True
        Me.ColPdCode.AppearanceHeader.Options.UseTextOptions = True
        Me.ColPdCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColPdCode.Caption = "รหัสสินค้า"
        Me.ColPdCode.FieldName = "InvCode"
        Me.ColPdCode.MinWidth = 105
        Me.ColPdCode.Name = "ColPdCode"
        Me.ColPdCode.OptionsColumn.AllowEdit = False
        Me.ColPdCode.OptionsColumn.ReadOnly = True
        Me.ColPdCode.OptionsColumn.TabStop = False
        Me.ColPdCode.Visible = True
        Me.ColPdCode.VisibleIndex = 3
        Me.ColPdCode.Width = 105
        '
        'ColProductName
        '
        Me.ColProductName.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColProductName.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ColProductName.AppearanceCell.Options.UseBackColor = True
        Me.ColProductName.AppearanceCell.Options.UseFont = True
        Me.ColProductName.AppearanceCell.Options.UseTextOptions = True
        Me.ColProductName.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ColProductName.AppearanceHeader.Options.UseFont = True
        Me.ColProductName.AppearanceHeader.Options.UseTextOptions = True
        Me.ColProductName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColProductName.Caption = "รายการสินค้า"
        Me.ColProductName.FieldName = "ProductName"
        Me.ColProductName.MinWidth = 290
        Me.ColProductName.Name = "ColProductName"
        Me.ColProductName.OptionsColumn.AllowEdit = False
        Me.ColProductName.OptionsColumn.ReadOnly = True
        Me.ColProductName.OptionsColumn.TabStop = False
        Me.ColProductName.Visible = True
        Me.ColProductName.VisibleIndex = 4
        Me.ColProductName.Width = 290
        '
        'ColAmtSale
        '
        Me.ColAmtSale.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ColAmtSale.AppearanceCell.Options.UseFont = True
        Me.ColAmtSale.AppearanceCell.Options.UseTextOptions = True
        Me.ColAmtSale.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ColAmtSale.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ColAmtSale.AppearanceHeader.Options.UseFont = True
        Me.ColAmtSale.AppearanceHeader.Options.UseTextOptions = True
        Me.ColAmtSale.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColAmtSale.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColAmtSale.Caption = "จน.ขาย"
        Me.ColAmtSale.DisplayFormat.FormatString = "#,##0.00##"
        Me.ColAmtSale.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.ColAmtSale.FieldName = "AmtSale"
        Me.ColAmtSale.MinWidth = 60
        Me.ColAmtSale.Name = "ColAmtSale"
        Me.ColAmtSale.OptionsColumn.TabStop = False
        Me.ColAmtSale.Visible = True
        Me.ColAmtSale.VisibleIndex = 5
        Me.ColAmtSale.Width = 71
        '
        'ColUnitName
        '
        Me.ColUnitName.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColUnitName.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ColUnitName.AppearanceCell.Options.UseBackColor = True
        Me.ColUnitName.AppearanceCell.Options.UseFont = True
        Me.ColUnitName.AppearanceCell.Options.UseTextOptions = True
        Me.ColUnitName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColUnitName.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ColUnitName.AppearanceHeader.Options.UseFont = True
        Me.ColUnitName.AppearanceHeader.Options.UseTextOptions = True
        Me.ColUnitName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColUnitName.Caption = "หน่วย"
        Me.ColUnitName.FieldName = "UnitName"
        Me.ColUnitName.MinWidth = 55
        Me.ColUnitName.Name = "ColUnitName"
        Me.ColUnitName.OptionsColumn.AllowEdit = False
        Me.ColUnitName.OptionsColumn.ReadOnly = True
        Me.ColUnitName.OptionsColumn.TabStop = False
        Me.ColUnitName.Visible = True
        Me.ColUnitName.VisibleIndex = 6
        Me.ColUnitName.Width = 57
        '
        'ColPriceSale
        '
        Me.ColPriceSale.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ColPriceSale.AppearanceCell.Options.UseFont = True
        Me.ColPriceSale.AppearanceCell.Options.UseTextOptions = True
        Me.ColPriceSale.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ColPriceSale.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ColPriceSale.AppearanceHeader.Options.UseFont = True
        Me.ColPriceSale.AppearanceHeader.Options.UseTextOptions = True
        Me.ColPriceSale.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColPriceSale.Caption = "มูลค่าเดิม"
        Me.ColPriceSale.DisplayFormat.FormatString = "#,##0.00##"
        Me.ColPriceSale.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.ColPriceSale.FieldName = "PriceSale"
        Me.ColPriceSale.MinWidth = 65
        Me.ColPriceSale.Name = "ColPriceSale"
        Me.ColPriceSale.OptionsColumn.TabStop = False
        Me.ColPriceSale.Visible = True
        Me.ColPriceSale.VisibleIndex = 7
        Me.ColPriceSale.Width = 73
        '
        'ColPriceNew
        '
        Me.ColPriceNew.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ColPriceNew.AppearanceCell.Options.UseFont = True
        Me.ColPriceNew.AppearanceCell.Options.UseTextOptions = True
        Me.ColPriceNew.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ColPriceNew.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ColPriceNew.AppearanceHeader.Options.UseFont = True
        Me.ColPriceNew.AppearanceHeader.Options.UseTextOptions = True
        Me.ColPriceNew.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColPriceNew.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColPriceNew.Caption = "มูลค่าที่ถูกต้อง"
        Me.ColPriceNew.ColumnEdit = Me.rptPriceNew
        Me.ColPriceNew.DisplayFormat.FormatString = "#,##0.00"
        Me.ColPriceNew.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColPriceNew.FieldName = "PriceNew"
        Me.ColPriceNew.MinWidth = 65
        Me.ColPriceNew.Name = "ColPriceNew"
        Me.ColPriceNew.Visible = True
        Me.ColPriceNew.VisibleIndex = 8
        '
        'rptPriceNew
        '
        Me.rptPriceNew.AutoHeight = False
        Me.rptPriceNew.Name = "rptPriceNew"
        '
        'ColPriceDiff
        '
        Me.ColPriceDiff.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ColPriceDiff.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ColPriceDiff.AppearanceCell.Options.UseBackColor = True
        Me.ColPriceDiff.AppearanceCell.Options.UseFont = True
        Me.ColPriceDiff.AppearanceCell.Options.UseTextOptions = True
        Me.ColPriceDiff.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ColPriceDiff.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ColPriceDiff.AppearanceHeader.Options.UseFont = True
        Me.ColPriceDiff.AppearanceHeader.Options.UseTextOptions = True
        Me.ColPriceDiff.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColPriceDiff.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColPriceDiff.Caption = "ผลต่าง"
        Me.ColPriceDiff.DisplayFormat.FormatString = "#,##0.00##"
        Me.ColPriceDiff.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColPriceDiff.FieldName = "PriceDiff"
        Me.ColPriceDiff.MinWidth = 65
        Me.ColPriceDiff.Name = "ColPriceDiff"
        Me.ColPriceDiff.OptionsColumn.AllowEdit = False
        Me.ColPriceDiff.OptionsColumn.ReadOnly = True
        Me.ColPriceDiff.OptionsColumn.TabStop = False
        Me.ColPriceDiff.Visible = True
        Me.ColPriceDiff.VisibleIndex = 9
        Me.ColPriceDiff.Width = 65
        '
        'ColTotalPriceDiff
        '
        Me.ColTotalPriceDiff.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ColTotalPriceDiff.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ColTotalPriceDiff.AppearanceCell.Options.UseBackColor = True
        Me.ColTotalPriceDiff.AppearanceCell.Options.UseFont = True
        Me.ColTotalPriceDiff.AppearanceCell.Options.UseTextOptions = True
        Me.ColTotalPriceDiff.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ColTotalPriceDiff.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ColTotalPriceDiff.AppearanceHeader.Options.UseFont = True
        Me.ColTotalPriceDiff.AppearanceHeader.Options.UseTextOptions = True
        Me.ColTotalPriceDiff.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColTotalPriceDiff.Caption = "รวมผลต่าง"
        Me.ColTotalPriceDiff.DisplayFormat.FormatString = "#,##0.00##"
        Me.ColTotalPriceDiff.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColTotalPriceDiff.FieldName = "TotalPriceDiff"
        Me.ColTotalPriceDiff.MinWidth = 65
        Me.ColTotalPriceDiff.Name = "ColTotalPriceDiff"
        Me.ColTotalPriceDiff.OptionsColumn.AllowEdit = False
        Me.ColTotalPriceDiff.OptionsColumn.ReadOnly = True
        Me.ColTotalPriceDiff.OptionsColumn.TabStop = False
        Me.ColTotalPriceDiff.Visible = True
        Me.ColTotalPriceDiff.VisibleIndex = 10
        '
        'ColDel
        '
        Me.ColDel.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ColDel.AppearanceCell.Options.UseFont = True
        Me.ColDel.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ColDel.AppearanceHeader.Options.UseFont = True
        Me.ColDel.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDel.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDel.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.ColDel.Caption = "ลบ"
        Me.ColDel.ColumnEdit = Me.rptDel
        Me.ColDel.MaxWidth = 45
        Me.ColDel.MinWidth = 45
        Me.ColDel.Name = "ColDel"
        Me.ColDel.Visible = True
        Me.ColDel.VisibleIndex = 11
        Me.ColDel.Width = 45
        '
        'rptDel
        '
        Me.rptDel.AutoHeight = False
        Me.rptDel.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Global.SAM.My.Resources.Resources.minus2, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.rptDel.Name = "rptDel"
        Me.rptDel.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'ColidSaleDt
        '
        Me.ColidSaleDt.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ColidSaleDt.AppearanceCell.Options.UseFont = True
        Me.ColidSaleDt.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ColidSaleDt.AppearanceHeader.Options.UseFont = True
        Me.ColidSaleDt.Caption = "idSaleDt"
        Me.ColidSaleDt.FieldName = "idSaleDt"
        Me.ColidSaleDt.Name = "ColidSaleDt"
        '
        'ColidUnit
        '
        Me.ColidUnit.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ColidUnit.AppearanceCell.Options.UseFont = True
        Me.ColidUnit.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ColidUnit.AppearanceHeader.Options.UseFont = True
        Me.ColidUnit.Caption = "idUnit"
        Me.ColidUnit.FieldName = "idUnit"
        Me.ColidUnit.Name = "ColidUnit"
        '
        'colidNoteDt
        '
        Me.colidNoteDt.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.colidNoteDt.AppearanceCell.Options.UseFont = True
        Me.colidNoteDt.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.colidNoteDt.AppearanceHeader.Options.UseFont = True
        Me.colidNoteDt.Caption = "idNoteDt"
        Me.colidNoteDt.FieldName = "idNoteDt"
        Me.colidNoteDt.Name = "colidNoteDt"
        '
        'colidSale
        '
        Me.colidSale.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.colidSale.AppearanceCell.Options.UseFont = True
        Me.colidSale.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.colidSale.AppearanceHeader.Options.UseFont = True
        Me.colidSale.Caption = "idSale"
        Me.colidSale.FieldName = "idSale"
        Me.colidSale.Name = "colidSale"
        '
        'ColidProduct
        '
        Me.ColidProduct.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ColidProduct.AppearanceCell.Options.UseFont = True
        Me.ColidProduct.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ColidProduct.AppearanceHeader.Options.UseFont = True
        Me.ColidProduct.Caption = "idProduct"
        Me.ColidProduct.FieldName = "idProduct"
        Me.ColidProduct.Name = "ColidProduct"
        '
        'PanelControl2
        '
        Me.PanelControl2.Appearance.BackColor = System.Drawing.Color.RoyalBlue
        Me.PanelControl2.Appearance.BackColor2 = System.Drawing.Color.CornflowerBlue
        Me.PanelControl2.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.PanelControl2.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.PanelControl2.Appearance.Options.UseBackColor = True
        Me.PanelControl2.Appearance.Options.UseFont = True
        Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl2.Controls.Add(Me.btnCancel)
        Me.PanelControl2.Controls.Add(Me.btnSave)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 494)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(1184, 35)
        Me.PanelControl2.TabIndex = 8
        '
        'btnCancel
        '
        Me.btnCancel.Appearance.BackColor = System.Drawing.Color.DimGray
        Me.btnCancel.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Appearance.Options.UseBackColor = True
        Me.btnCancel.Appearance.Options.UseFont = True
        Me.btnCancel.Appearance.Options.UseForeColor = True
        Me.btnCancel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnCancel.Image = Global.SAM.My.Resources.Resources.ic_close
        Me.btnCancel.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnCancel.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnCancel.Location = New System.Drawing.Point(104, 0)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(104, 35)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = " ยกเลิก"
        Me.btnCancel.Visible = False
        '
        'btnSave
        '
        Me.btnSave.Appearance.BackColor = System.Drawing.Color.DimGray
        Me.btnSave.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnSave.Appearance.Options.UseBackColor = True
        Me.btnSave.Appearance.Options.UseFont = True
        Me.btnSave.Appearance.Options.UseForeColor = True
        Me.btnSave.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnSave.Image = Global.SAM.My.Resources.Resources.Save28
        Me.btnSave.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnSave.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnSave.Location = New System.Drawing.Point(0, 0)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(104, 35)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = " บันทึก"
        '
        'PanelControl3
        '
        Me.PanelControl3.Appearance.BackColor = System.Drawing.Color.RoyalBlue
        Me.PanelControl3.Appearance.BackColor2 = System.Drawing.Color.CornflowerBlue
        Me.PanelControl3.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.PanelControl3.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.PanelControl3.Appearance.Options.UseBackColor = True
        Me.PanelControl3.Appearance.Options.UseFont = True
        Me.PanelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl3.Controls.Add(Me.btnPdInc)
        Me.PanelControl3.Controls.Add(Me.Label24)
        Me.PanelControl3.Controls.Add(Me.txtDocRef)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl3.Location = New System.Drawing.Point(0, 137)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(1184, 32)
        Me.PanelControl3.TabIndex = 6
        '
        'btnPdInc
        '
        Me.btnPdInc.Appearance.BackColor = System.Drawing.Color.DimGray
        Me.btnPdInc.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPdInc.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnPdInc.Appearance.Options.UseBackColor = True
        Me.btnPdInc.Appearance.Options.UseFont = True
        Me.btnPdInc.Appearance.Options.UseForeColor = True
        Me.btnPdInc.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.btnPdInc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPdInc.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnPdInc.Image = CType(resources.GetObject("btnPdInc.Image"), System.Drawing.Image)
        Me.btnPdInc.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnPdInc.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnPdInc.Location = New System.Drawing.Point(1080, 0)
        Me.btnPdInc.Name = "btnPdInc"
        Me.btnPdInc.Size = New System.Drawing.Size(104, 32)
        Me.btnPdInc.TabIndex = 579
        Me.btnPdInc.Text = "เพิ่มสินค้า"
        '
        'frmCreditDebitNoteTs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(1184, 551)
        Me.Controls.Add(Me.GCSale)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCreditDebitNoteTs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ทำรายการลดหนี้"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.GCSale, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVBind, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptPriceNew, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptDel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.PanelControl3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnCustomer As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblPsSale As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbGroupComp As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents stLbl_DateTs As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents stLbl_PsTs As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents GCSale As DevExpress.XtraGrid.GridControl
    Friend WithEvents DGVBind As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColNum As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColPdCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColLotNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColProductName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColAmtSale As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColUnitName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColPriceSale As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColPriceNew As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColPriceDiff As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lblDateNote As System.Windows.Forms.Label
    Friend WithEvents dtpDateNote As System.Windows.Forms.DateTimePicker
    Friend WithEvents ColTotalPriceDiff As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtNote As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblDocCode As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ColidSaleDt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColidUnit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblTotalSale As System.Windows.Forms.Label
    Friend WithEvents lblTotalNew As System.Windows.Forms.Label
    Friend WithEvents lblTotalDiff As System.Windows.Forms.Label
    Friend WithEvents colidNoteDt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDocCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDateSaleD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtDocRef As System.Windows.Forms.TextBox
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents colidSale As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtPartnerName As System.Windows.Forms.TextBox
    Friend WithEvents ColidProduct As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ColDel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rptDel As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents rptPriceNew As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents lblI As System.Windows.Forms.Label
    Friend WithEvents txtDocImpress As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalNet As System.Windows.Forms.Label
    Friend WithEvents btnPdInc As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmbDRCode As ComboBox
End Class
