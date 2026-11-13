<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSlBnTs
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSlBnTs))
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpDateBill = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNote = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lblDateTs = New System.Windows.Forms.Label()
        Me.lblPsTs = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.Label()
        Me.lblCustomer = New System.Windows.Forms.Label()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.lblCompName = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.gc2 = New DevExpress.XtraGrid.GridControl()
        Me.gv2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColidSale = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColNum = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDocRef = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDateSaleD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColPayment_ = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColPsSale_ = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDebt_ = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColNote_ = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDelete = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rptbtnDel = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.gc2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptbtnDel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "ลูกค้า"
        '
        'dtpDateBill
        '
        Me.dtpDateBill.CustomFormat = "ddMMMMyyyy"
        Me.dtpDateBill.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateBill.Location = New System.Drawing.Point(463, 11)
        Me.dtpDateBill.Name = "dtpDateBill"
        Me.dtpDateBill.Size = New System.Drawing.Size(164, 21)
        Me.dtpDateBill.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(401, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "วันที่วางบิล"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(407, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "หมายเหตุ"
        '
        'txtNote
        '
        Me.txtNote.Location = New System.Drawing.Point(463, 37)
        Me.txtNote.Multiline = True
        Me.txtNote.Name = "txtNote"
        Me.txtNote.Size = New System.Drawing.Size(164, 42)
        Me.txtNote.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(686, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "วันที่รายการ"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(687, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 16)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "ผู้ทำรายการ"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(676, 63)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 16)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "รวมจำนวนเงิน"
        '
        'btnSelect
        '
        Me.btnSelect.BackColor = System.Drawing.Color.DimGray
        Me.btnSelect.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSelect.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnSelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnSelect.ForeColor = System.Drawing.Color.White
        Me.btnSelect.Image = CType(resources.GetObject("btnSelect.Image"), System.Drawing.Image)
        Me.btnSelect.Location = New System.Drawing.Point(89, 0)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(152, 34)
        Me.btnSelect.TabIndex = 426
        Me.btnSelect.Tag = "Save"
        Me.btnSelect.Text = "เลือกรายการบิลซื้อ"
        Me.btnSelect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSelect.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.DimGray
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(0, 0)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(89, 34)
        Me.btnSave.TabIndex = 425
        Me.btnSave.Tag = "Save"
        Me.btnSave.Text = " บันทึก"
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'lblDateTs
        '
        Me.lblDateTs.BackColor = System.Drawing.Color.Gainsboro
        Me.lblDateTs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDateTs.Location = New System.Drawing.Point(753, 13)
        Me.lblDateTs.Name = "lblDateTs"
        Me.lblDateTs.Size = New System.Drawing.Size(167, 20)
        Me.lblDateTs.TabIndex = 601
        Me.lblDateTs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPsTs
        '
        Me.lblPsTs.BackColor = System.Drawing.Color.Gainsboro
        Me.lblPsTs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPsTs.Location = New System.Drawing.Point(753, 36)
        Me.lblPsTs.Name = "lblPsTs"
        Me.lblPsTs.Size = New System.Drawing.Size(167, 20)
        Me.lblPsTs.TabIndex = 602
        Me.lblPsTs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.Color.Gray
        Me.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTotal.ForeColor = System.Drawing.Color.Lime
        Me.txtTotal.Location = New System.Drawing.Point(753, 61)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(167, 21)
        Me.txtTotal.TabIndex = 604
        Me.txtTotal.Text = "0"
        Me.txtTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCustomer
        '
        Me.lblCustomer.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCustomer.Location = New System.Drawing.Point(54, 36)
        Me.lblCustomer.Name = "lblCustomer"
        Me.lblCustomer.Size = New System.Drawing.Size(301, 46)
        Me.lblCustomer.TabIndex = 606
        Me.lblCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PanelControl1
        '
        Me.PanelControl1.Appearance.BackColor = System.Drawing.Color.Lavender
        Me.PanelControl1.Appearance.BackColor2 = System.Drawing.Color.LightSteelBlue
        Me.PanelControl1.Appearance.Options.UseBackColor = True
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.lblCompName)
        Me.PanelControl1.Controls.Add(Me.Label7)
        Me.PanelControl1.Controls.Add(Me.lblCustomer)
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.Label5)
        Me.PanelControl1.Controls.Add(Me.txtTotal)
        Me.PanelControl1.Controls.Add(Me.Label6)
        Me.PanelControl1.Controls.Add(Me.dtpDateBill)
        Me.PanelControl1.Controls.Add(Me.Label4)
        Me.PanelControl1.Controls.Add(Me.Label2)
        Me.PanelControl1.Controls.Add(Me.txtNote)
        Me.PanelControl1.Controls.Add(Me.lblPsTs)
        Me.PanelControl1.Controls.Add(Me.lblDateTs)
        Me.PanelControl1.Controls.Add(Me.Label3)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1134, 95)
        Me.PanelControl1.TabIndex = 726
        '
        'lblCompName
        '
        Me.lblCompName.BackColor = System.Drawing.Color.Gainsboro
        Me.lblCompName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCompName.Location = New System.Drawing.Point(56, 11)
        Me.lblCompName.Name = "lblCompName"
        Me.lblCompName.Size = New System.Drawing.Size(299, 20)
        Me.lblCompName.TabIndex = 786
        Me.lblCompName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(17, 12)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 16)
        Me.Label7.TabIndex = 785
        Me.Label7.Text = "บริษัท"
        '
        'PanelControl3
        '
        Me.PanelControl3.Appearance.BackColor = System.Drawing.Color.LightSteelBlue
        Me.PanelControl3.Appearance.BackColor2 = System.Drawing.Color.CornflowerBlue
        Me.PanelControl3.Appearance.Options.UseBackColor = True
        Me.PanelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl3.Controls.Add(Me.btnSelect)
        Me.PanelControl3.Controls.Add(Me.btnSave)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl3.Location = New System.Drawing.Point(0, 95)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(1134, 34)
        Me.PanelControl3.TabIndex = 727
        '
        'gc2
        '
        Me.gc2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gc2.Location = New System.Drawing.Point(0, 129)
        Me.gc2.MainView = Me.gv2
        Me.gc2.Name = "gc2"
        Me.gc2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rptbtnDel})
        Me.gc2.Size = New System.Drawing.Size(1134, 412)
        Me.gc2.TabIndex = 729
        Me.gc2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gv2})
        '
        'gv2
        '
        Me.gv2.Appearance.FocusedCell.BackColor = System.Drawing.Color.PeachPuff
        Me.gv2.Appearance.FocusedCell.Options.UseBackColor = True
        Me.gv2.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.gv2.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gv2.Appearance.Row.Options.UseTextOptions = True
        Me.gv2.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gv2.ColumnPanelRowHeight = 36
        Me.gv2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColidSale, Me.ColNum, Me.ColDocRef, Me.ColDateSaleD, Me.ColPayment_, Me.ColPsSale_, Me.ColDebt_, Me.ColNote_, Me.ColDelete})
        Me.gv2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        StyleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Red
        StyleFormatCondition1.Appearance.Options.UseForeColor = True
        StyleFormatCondition1.ApplyToRow = True
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Less
        StyleFormatCondition1.Value1 = 0
        Me.gv2.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
        Me.gv2.GridControl = Me.gc2
        Me.gv2.Name = "gv2"
        Me.gv2.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.gv2.OptionsView.ShowGroupPanel = False
        Me.gv2.OptionsView.ShowIndicator = False
        '
        'ColidSale
        '
        Me.ColidSale.Caption = "idSale"
        Me.ColidSale.FieldName = "idSale"
        Me.ColidSale.Name = "ColidSale"
        Me.ColidSale.OptionsColumn.AllowEdit = False
        '
        'ColNum
        '
        Me.ColNum.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColNum.AppearanceCell.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ColNum.AppearanceCell.Options.UseBackColor = True
        Me.ColNum.AppearanceCell.Options.UseForeColor = True
        Me.ColNum.AppearanceCell.Options.UseTextOptions = True
        Me.ColNum.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColNum.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColNum.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColNum.AppearanceHeader.Options.UseFont = True
        Me.ColNum.Caption = "ลำดับ"
        Me.ColNum.MaxWidth = 50
        Me.ColNum.MinWidth = 50
        Me.ColNum.Name = "ColNum"
        Me.ColNum.OptionsColumn.AllowEdit = False
        Me.ColNum.OptionsColumn.ReadOnly = True
        Me.ColNum.Visible = True
        Me.ColNum.VisibleIndex = 0
        Me.ColNum.Width = 50
        '
        'ColDocRef
        '
        Me.ColDocRef.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColDocRef.AppearanceCell.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ColDocRef.AppearanceCell.Options.UseBackColor = True
        Me.ColDocRef.AppearanceCell.Options.UseForeColor = True
        Me.ColDocRef.AppearanceCell.Options.UseTextOptions = True
        Me.ColDocRef.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDocRef.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColDocRef.AppearanceHeader.Options.UseFont = True
        Me.ColDocRef.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDocRef.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDocRef.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColDocRef.Caption = "เลขที่รายการ"
        Me.ColDocRef.FieldName = "DocRef"
        Me.ColDocRef.MaxWidth = 150
        Me.ColDocRef.MinWidth = 120
        Me.ColDocRef.Name = "ColDocRef"
        Me.ColDocRef.OptionsColumn.AllowEdit = False
        Me.ColDocRef.OptionsColumn.ReadOnly = True
        Me.ColDocRef.Visible = True
        Me.ColDocRef.VisibleIndex = 1
        Me.ColDocRef.Width = 120
        '
        'ColDateSaleD
        '
        Me.ColDateSaleD.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColDateSaleD.AppearanceCell.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ColDateSaleD.AppearanceCell.Options.UseBackColor = True
        Me.ColDateSaleD.AppearanceCell.Options.UseForeColor = True
        Me.ColDateSaleD.AppearanceCell.Options.UseTextOptions = True
        Me.ColDateSaleD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDateSaleD.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColDateSaleD.AppearanceHeader.Options.UseFont = True
        Me.ColDateSaleD.Caption = "วันที่ขาย"
        Me.ColDateSaleD.FieldName = "DateSaleD"
        Me.ColDateSaleD.MaxWidth = 150
        Me.ColDateSaleD.MinWidth = 120
        Me.ColDateSaleD.Name = "ColDateSaleD"
        Me.ColDateSaleD.OptionsColumn.AllowEdit = False
        Me.ColDateSaleD.OptionsColumn.ReadOnly = True
        Me.ColDateSaleD.Visible = True
        Me.ColDateSaleD.VisibleIndex = 2
        Me.ColDateSaleD.Width = 120
        '
        'ColPayment_
        '
        Me.ColPayment_.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColPayment_.AppearanceCell.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ColPayment_.AppearanceCell.Options.UseBackColor = True
        Me.ColPayment_.AppearanceCell.Options.UseForeColor = True
        Me.ColPayment_.AppearanceCell.Options.UseTextOptions = True
        Me.ColPayment_.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.ColPayment_.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColPayment_.AppearanceHeader.Options.UseFont = True
        Me.ColPayment_.Caption = "เงื่อนไขการชำระเงิน"
        Me.ColPayment_.FieldName = "PaymentTerms"
        Me.ColPayment_.MinWidth = 150
        Me.ColPayment_.Name = "ColPayment_"
        Me.ColPayment_.OptionsColumn.AllowEdit = False
        Me.ColPayment_.Visible = True
        Me.ColPayment_.VisibleIndex = 3
        Me.ColPayment_.Width = 150
        '
        'ColPsSale_
        '
        Me.ColPsSale_.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColPsSale_.AppearanceCell.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ColPsSale_.AppearanceCell.Options.UseBackColor = True
        Me.ColPsSale_.AppearanceCell.Options.UseForeColor = True
        Me.ColPsSale_.AppearanceCell.Options.UseTextOptions = True
        Me.ColPsSale_.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.ColPsSale_.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColPsSale_.AppearanceHeader.Options.UseFont = True
        Me.ColPsSale_.Caption = "เจ้าหน้าที่ขาย"
        Me.ColPsSale_.FieldName = "PsSale"
        Me.ColPsSale_.MinWidth = 200
        Me.ColPsSale_.Name = "ColPsSale_"
        Me.ColPsSale_.OptionsColumn.AllowEdit = False
        Me.ColPsSale_.OptionsColumn.ReadOnly = True
        Me.ColPsSale_.Visible = True
        Me.ColPsSale_.VisibleIndex = 4
        Me.ColPsSale_.Width = 200
        '
        'ColDebt_
        '
        Me.ColDebt_.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ColDebt_.AppearanceCell.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ColDebt_.AppearanceCell.Options.UseBackColor = True
        Me.ColDebt_.AppearanceCell.Options.UseForeColor = True
        Me.ColDebt_.AppearanceCell.Options.UseTextOptions = True
        Me.ColDebt_.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ColDebt_.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColDebt_.AppearanceHeader.Options.UseFont = True
        Me.ColDebt_.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDebt_.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDebt_.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColDebt_.Caption = "ยอดค้างจ่าย"
        Me.ColDebt_.DisplayFormat.FormatString = "N2"
        Me.ColDebt_.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColDebt_.FieldName = "Debt"
        Me.ColDebt_.MinWidth = 150
        Me.ColDebt_.Name = "ColDebt_"
        Me.ColDebt_.OptionsColumn.AllowEdit = False
        Me.ColDebt_.Visible = True
        Me.ColDebt_.VisibleIndex = 5
        Me.ColDebt_.Width = 233
        '
        'ColNote_
        '
        Me.ColNote_.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColNote_.AppearanceCell.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ColNote_.AppearanceCell.Options.UseBackColor = True
        Me.ColNote_.AppearanceCell.Options.UseForeColor = True
        Me.ColNote_.AppearanceCell.Options.UseTextOptions = True
        Me.ColNote_.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.ColNote_.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColNote_.AppearanceHeader.Options.UseFont = True
        Me.ColNote_.Caption = "คำอธิบายกรายการ"
        Me.ColNote_.FieldName = "Note"
        Me.ColNote_.MinWidth = 120
        Me.ColNote_.Name = "ColNote_"
        Me.ColNote_.OptionsColumn.AllowEdit = False
        Me.ColNote_.Visible = True
        Me.ColNote_.VisibleIndex = 6
        Me.ColNote_.Width = 334
        '
        'ColDelete
        '
        Me.ColDelete.AppearanceCell.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ColDelete.AppearanceCell.Options.UseForeColor = True
        Me.ColDelete.AppearanceCell.Options.UseTextOptions = True
        Me.ColDelete.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDelete.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColDelete.AppearanceHeader.Options.UseFont = True
        Me.ColDelete.Caption = "ลบ"
        Me.ColDelete.ColumnEdit = Me.rptbtnDel
        Me.ColDelete.MaxWidth = 40
        Me.ColDelete.MinWidth = 35
        Me.ColDelete.Name = "ColDelete"
        Me.ColDelete.Visible = True
        Me.ColDelete.VisibleIndex = 7
        Me.ColDelete.Width = 40
        '
        'rptbtnDel
        '
        Me.rptbtnDel.AutoHeight = False
        Me.rptbtnDel.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Global.SAM.My.Resources.Resources.cross_circle_frame, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.rptbtnDel.Name = "rptbtnDel"
        Me.rptbtnDel.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'frmSlBnTs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(1134, 541)
        Me.Controls.Add(Me.gc2)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSlBnTs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ทำรายการออกใบวางบิล"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.gc2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptbtnDel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpDateBill As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNote As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents lblDateTs As System.Windows.Forms.Label
    Friend WithEvents lblPsTs As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.Label
    Friend WithEvents lblCustomer As System.Windows.Forms.Label
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents gc2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents gv2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColidSale As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColNum As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDocRef As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDateSaleD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColPayment_ As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColPsSale_ As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDebt_ As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColNote_ As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDelete As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents rptbtnDel As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents lblCompName As System.Windows.Forms.Label
End Class
