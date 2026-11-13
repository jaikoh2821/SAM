<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLotReturnSelect
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLotReturnSelect))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.GCProduct = New DevExpress.XtraGrid.GridControl()
        Me.GVProduct = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rptSelect = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.ColDocCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColLotNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColInvName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColAmtSale = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColUnitName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.txtCount = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdbOnlyCus = New System.Windows.Forms.RadioButton()
        Me.rdbAllSale = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbInvName = New System.Windows.Forms.ComboBox()
        Me.txtInvName = New System.Windows.Forms.TextBox()
        Me.txtLotNo = New System.Windows.Forms.TextBox()
        Me.chkInvName = New System.Windows.Forms.CheckBox()
        Me.chkLotNo = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GCSelected = New DevExpress.XtraGrid.GridControl()
        Me.GVSelected = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colNum = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLotNum = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInvName_ = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAmtReturn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDelete = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rptDel = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.colidLot = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidInvGroup = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidInvMain_ = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidSubType_ = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidWh_ = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CompRec = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.btnAddLot = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSel = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2.SuspendLayout()
        CType(Me.GCProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptSelect, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        Me.Panel8.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.GCSelected, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVSelected, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptDel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.SimpleButton1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(731, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(29, 551)
        Me.Panel2.TabIndex = 739
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(1, 238)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(24, 32)
        Me.SimpleButton1.TabIndex = 3
        '
        'GCProduct
        '
        Me.GCProduct.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCProduct.Location = New System.Drawing.Point(0, 128)
        Me.GCProduct.MainView = Me.GVProduct
        Me.GCProduct.Name = "GCProduct"
        Me.GCProduct.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rptSelect})
        Me.GCProduct.Size = New System.Drawing.Size(731, 423)
        Me.GCProduct.TabIndex = 742
        Me.GCProduct.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVProduct})
        '
        'GVProduct
        '
        Me.GVProduct.Appearance.FocusedCell.BackColor = System.Drawing.Color.BurlyWood
        Me.GVProduct.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVProduct.Appearance.FocusedRow.BackColor = System.Drawing.Color.Wheat
        Me.GVProduct.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVProduct.ColumnPanelRowHeight = 35
        Me.GVProduct.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSel, Me.ColDocCode, Me.ColLotNo, Me.ColInvName, Me.ColAmtSale, Me.ColUnitName, Me.ColDate})
        Me.GVProduct.GridControl = Me.GCProduct
        Me.GVProduct.GroupFormat = " [#image]{1} {2}"
        Me.GVProduct.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Amount", Nothing, "(คงเหลือ {0:#,##0.####})")})
        Me.GVProduct.Name = "GVProduct"
        Me.GVProduct.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GVProduct.OptionsView.ShowGroupPanel = False
        Me.GVProduct.OptionsView.ShowIndicator = False
        Me.GVProduct.ScrollStyle = DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.None
        '
        'colSel
        '
        Me.colSel.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colSel.AppearanceCell.Options.UseFont = True
        Me.colSel.AppearanceCell.Options.UseTextOptions = True
        Me.colSel.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colSel.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colSel.AppearanceHeader.Options.UseFont = True
        Me.colSel.AppearanceHeader.Options.UseTextOptions = True
        Me.colSel.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSel.Caption = "เลือก"
        Me.colSel.ColumnEdit = Me.rptSelect
        Me.colSel.MaxWidth = 45
        Me.colSel.MinWidth = 45
        Me.colSel.Name = "colSel"
        Me.colSel.Visible = True
        Me.colSel.VisibleIndex = 0
        Me.colSel.Width = 45
        '
        'rptSelect
        '
        Me.rptSelect.AutoHeight = False
        Me.rptSelect.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Global.SAM.My.Resources.Resources.forward_arrow16x16, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.rptSelect.Name = "rptSelect"
        Me.rptSelect.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'ColDocCode
        '
        Me.ColDocCode.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColDocCode.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColDocCode.AppearanceCell.Options.UseBackColor = True
        Me.ColDocCode.AppearanceCell.Options.UseFont = True
        Me.ColDocCode.AppearanceCell.Options.UseTextOptions = True
        Me.ColDocCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDocCode.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColDocCode.AppearanceHeader.Options.UseFont = True
        Me.ColDocCode.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDocCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDocCode.Caption = "เลขที่บิลขาย"
        Me.ColDocCode.FieldName = "DocRef"
        Me.ColDocCode.MinWidth = 85
        Me.ColDocCode.Name = "ColDocCode"
        Me.ColDocCode.OptionsColumn.AllowEdit = False
        Me.ColDocCode.OptionsColumn.ReadOnly = True
        Me.ColDocCode.Visible = True
        Me.ColDocCode.VisibleIndex = 1
        Me.ColDocCode.Width = 85
        '
        'ColLotNo
        '
        Me.ColLotNo.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColLotNo.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColLotNo.AppearanceCell.Options.UseBackColor = True
        Me.ColLotNo.AppearanceCell.Options.UseFont = True
        Me.ColLotNo.AppearanceCell.Options.UseTextOptions = True
        Me.ColLotNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.ColLotNo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColLotNo.AppearanceHeader.Options.UseFont = True
        Me.ColLotNo.AppearanceHeader.Options.UseTextOptions = True
        Me.ColLotNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColLotNo.Caption = "Lot No."
        Me.ColLotNo.FieldName = "LotNo"
        Me.ColLotNo.MinWidth = 100
        Me.ColLotNo.Name = "ColLotNo"
        Me.ColLotNo.OptionsColumn.AllowEdit = False
        Me.ColLotNo.OptionsColumn.ReadOnly = True
        Me.ColLotNo.Visible = True
        Me.ColLotNo.VisibleIndex = 2
        Me.ColLotNo.Width = 100
        '
        'ColInvName
        '
        Me.ColInvName.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ColInvName.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColInvName.AppearanceCell.Options.UseBackColor = True
        Me.ColInvName.AppearanceCell.Options.UseFont = True
        Me.ColInvName.AppearanceCell.Options.UseTextOptions = True
        Me.ColInvName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.ColInvName.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColInvName.AppearanceHeader.Options.UseFont = True
        Me.ColInvName.AppearanceHeader.Options.UseTextOptions = True
        Me.ColInvName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColInvName.Caption = "รายการสินค้า"
        Me.ColInvName.FieldName = "ProductName"
        Me.ColInvName.Name = "ColInvName"
        Me.ColInvName.OptionsColumn.AllowEdit = False
        Me.ColInvName.OptionsColumn.ReadOnly = True
        Me.ColInvName.Visible = True
        Me.ColInvName.VisibleIndex = 3
        Me.ColInvName.Width = 946
        '
        'ColAmtSale
        '
        Me.ColAmtSale.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColAmtSale.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColAmtSale.AppearanceCell.Options.UseBackColor = True
        Me.ColAmtSale.AppearanceCell.Options.UseFont = True
        Me.ColAmtSale.AppearanceCell.Options.UseTextOptions = True
        Me.ColAmtSale.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ColAmtSale.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColAmtSale.AppearanceHeader.Options.UseFont = True
        Me.ColAmtSale.AppearanceHeader.Options.UseTextOptions = True
        Me.ColAmtSale.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColAmtSale.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColAmtSale.Caption = "จำนวนขาย"
        Me.ColAmtSale.DisplayFormat.FormatString = "#,##0.######"
        Me.ColAmtSale.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.ColAmtSale.FieldName = "AmtSale"
        Me.ColAmtSale.MinWidth = 85
        Me.ColAmtSale.Name = "ColAmtSale"
        Me.ColAmtSale.OptionsColumn.AllowEdit = False
        Me.ColAmtSale.OptionsColumn.ReadOnly = True
        Me.ColAmtSale.Visible = True
        Me.ColAmtSale.VisibleIndex = 4
        Me.ColAmtSale.Width = 85
        '
        'ColUnitName
        '
        Me.ColUnitName.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColUnitName.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColUnitName.AppearanceCell.Options.UseBackColor = True
        Me.ColUnitName.AppearanceCell.Options.UseFont = True
        Me.ColUnitName.AppearanceCell.Options.UseTextOptions = True
        Me.ColUnitName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColUnitName.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColUnitName.AppearanceHeader.Options.UseFont = True
        Me.ColUnitName.AppearanceHeader.Options.UseTextOptions = True
        Me.ColUnitName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColUnitName.Caption = "หน่วย"
        Me.ColUnitName.FieldName = "UnitName"
        Me.ColUnitName.MinWidth = 85
        Me.ColUnitName.Name = "ColUnitName"
        Me.ColUnitName.OptionsColumn.AllowEdit = False
        Me.ColUnitName.OptionsColumn.ReadOnly = True
        Me.ColUnitName.Visible = True
        Me.ColUnitName.VisibleIndex = 5
        Me.ColUnitName.Width = 85
        '
        'ColDate
        '
        Me.ColDate.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColDate.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColDate.AppearanceCell.Options.UseBackColor = True
        Me.ColDate.AppearanceCell.Options.UseFont = True
        Me.ColDate.AppearanceCell.Options.UseTextOptions = True
        Me.ColDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDate.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColDate.AppearanceHeader.Options.UseFont = True
        Me.ColDate.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDate.Caption = "วันที่ผลิต"
        Me.ColDate.FieldName = "DateGen"
        Me.ColDate.MinWidth = 85
        Me.ColDate.Name = "ColDate"
        Me.ColDate.OptionsColumn.AllowEdit = False
        Me.ColDate.OptionsColumn.ReadOnly = True
        Me.ColDate.Visible = True
        Me.ColDate.VisibleIndex = 6
        Me.ColDate.Width = 367
        '
        'PanelControl2
        '
        Me.PanelControl2.Appearance.BackColor = System.Drawing.Color.LightSteelBlue
        Me.PanelControl2.Appearance.BackColor2 = System.Drawing.Color.CornflowerBlue
        Me.PanelControl2.Appearance.Options.UseBackColor = True
        Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl2.Controls.Add(Me.Panel8)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl2.Location = New System.Drawing.Point(0, 97)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(731, 31)
        Me.PanelControl2.TabIndex = 743
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.Transparent
        Me.Panel8.Controls.Add(Me.txtCount)
        Me.Panel8.Controls.Add(Me.Label1)
        Me.Panel8.Controls.Add(Me.Label4)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel8.Location = New System.Drawing.Point(506, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(225, 31)
        Me.Panel8.TabIndex = 611
        '
        'txtCount
        '
        Me.txtCount.BackColor = System.Drawing.Color.Black
        Me.txtCount.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCount.ForeColor = System.Drawing.Color.Lime
        Me.txtCount.Location = New System.Drawing.Point(60, 4)
        Me.txtCount.Name = "txtCount"
        Me.txtCount.Size = New System.Drawing.Size(100, 23)
        Me.txtCount.TabIndex = 610
        Me.txtCount.Text = "0"
        Me.txtCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(166, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 16)
        Me.Label1.TabIndex = 596
        Me.Label1.Text = "รายการ"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(3, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 16)
        Me.Label4.TabIndex = 594
        Me.Label4.Text = "จำนวน"
        '
        'PanelControl1
        '
        Me.PanelControl1.Appearance.BackColor = System.Drawing.Color.Lavender
        Me.PanelControl1.Appearance.BackColor2 = System.Drawing.Color.LightSteelBlue
        Me.PanelControl1.Appearance.Options.UseBackColor = True
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.GroupBox1)
        Me.PanelControl1.Controls.Add(Me.Label2)
        Me.PanelControl1.Controls.Add(Me.cmbInvName)
        Me.PanelControl1.Controls.Add(Me.txtInvName)
        Me.PanelControl1.Controls.Add(Me.txtLotNo)
        Me.PanelControl1.Controls.Add(Me.chkInvName)
        Me.PanelControl1.Controls.Add(Me.chkLotNo)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(731, 97)
        Me.PanelControl1.TabIndex = 741
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.rdbOnlyCus)
        Me.GroupBox1.Controls.Add(Me.rdbAllSale)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(375, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(214, 83)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "การแสดงข้อมูล"
        '
        'rdbOnlyCus
        '
        Me.rdbOnlyCus.AutoSize = True
        Me.rdbOnlyCus.BackColor = System.Drawing.Color.Transparent
        Me.rdbOnlyCus.Checked = True
        Me.rdbOnlyCus.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbOnlyCus.Location = New System.Drawing.Point(19, 28)
        Me.rdbOnlyCus.Name = "rdbOnlyCus"
        Me.rdbOnlyCus.Size = New System.Drawing.Size(179, 18)
        Me.rdbOnlyCus.TabIndex = 7
        Me.rdbOnlyCus.TabStop = True
        Me.rdbOnlyCus.Text = "เฉพาะเปิดบิลขายของลูกค้าเจ้านี้"
        Me.rdbOnlyCus.UseVisualStyleBackColor = False
        '
        'rdbAllSale
        '
        Me.rdbAllSale.AutoSize = True
        Me.rdbAllSale.BackColor = System.Drawing.Color.Transparent
        Me.rdbAllSale.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbAllSale.Location = New System.Drawing.Point(19, 52)
        Me.rdbAllSale.Name = "rdbAllSale"
        Me.rdbAllSale.Size = New System.Drawing.Size(134, 18)
        Me.rdbAllSale.TabIndex = 8
        Me.rdbAllSale.Text = "เคยเปิดบิลขายทั้งหมด"
        Me.rdbAllSale.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 14)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "ประเภทสินค้า"
        '
        'cmbInvName
        '
        Me.cmbInvName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbInvName.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbInvName.FormattingEnabled = True
        Me.cmbInvName.Location = New System.Drawing.Point(99, 12)
        Me.cmbInvName.Name = "cmbInvName"
        Me.cmbInvName.Size = New System.Drawing.Size(240, 22)
        Me.cmbInvName.TabIndex = 1
        Me.cmbInvName.TabStop = False
        '
        'txtInvName
        '
        Me.txtInvName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtInvName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtInvName.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInvName.Location = New System.Drawing.Point(99, 38)
        Me.txtInvName.Name = "txtInvName"
        Me.txtInvName.Size = New System.Drawing.Size(240, 22)
        Me.txtInvName.TabIndex = 3
        '
        'txtLotNo
        '
        Me.txtLotNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtLotNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtLotNo.Enabled = False
        Me.txtLotNo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLotNo.Location = New System.Drawing.Point(99, 66)
        Me.txtLotNo.Name = "txtLotNo"
        Me.txtLotNo.Size = New System.Drawing.Size(240, 22)
        Me.txtLotNo.TabIndex = 5
        '
        'chkInvName
        '
        Me.chkInvName.AutoSize = True
        Me.chkInvName.BackColor = System.Drawing.Color.Transparent
        Me.chkInvName.Checked = True
        Me.chkInvName.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkInvName.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.chkInvName.Location = New System.Drawing.Point(24, 40)
        Me.chkInvName.Name = "chkInvName"
        Me.chkInvName.Size = New System.Drawing.Size(68, 18)
        Me.chkInvName.TabIndex = 2
        Me.chkInvName.TabStop = False
        Me.chkInvName.Text = "ชื่อสินค้า"
        Me.chkInvName.UseVisualStyleBackColor = False
        '
        'chkLotNo
        '
        Me.chkLotNo.AutoSize = True
        Me.chkLotNo.BackColor = System.Drawing.Color.Transparent
        Me.chkLotNo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.chkLotNo.Location = New System.Drawing.Point(24, 68)
        Me.chkLotNo.Name = "chkLotNo"
        Me.chkLotNo.Size = New System.Drawing.Size(67, 18)
        Me.chkLotNo.TabIndex = 4
        Me.chkLotNo.Text = "Lot No."
        Me.chkLotNo.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GCSelected)
        Me.Panel1.Controls.Add(Me.PanelControl3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(760, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(424, 551)
        Me.Panel1.TabIndex = 744
        '
        'GCSelected
        '
        Me.GCSelected.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCSelected.Location = New System.Drawing.Point(0, 34)
        Me.GCSelected.MainView = Me.GVSelected
        Me.GCSelected.Name = "GCSelected"
        Me.GCSelected.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rptDel})
        Me.GCSelected.Size = New System.Drawing.Size(424, 517)
        Me.GCSelected.TabIndex = 741
        Me.GCSelected.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVSelected})
        '
        'GVSelected
        '
        Me.GVSelected.Appearance.FocusedCell.BackColor = System.Drawing.Color.BurlyWood
        Me.GVSelected.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVSelected.Appearance.FocusedRow.BackColor = System.Drawing.Color.Wheat
        Me.GVSelected.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVSelected.ColumnPanelRowHeight = 35
        Me.GVSelected.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNum, Me.colLotNum, Me.colInvName_, Me.colAmtReturn, Me.colDelete, Me.colidLot, Me.colidInvGroup, Me.colidInvMain_, Me.colidSubType_, Me.colidWh_, Me.CompRec})
        Me.GVSelected.GridControl = Me.GCSelected
        Me.GVSelected.Name = "GVSelected"
        Me.GVSelected.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GVSelected.OptionsView.ShowGroupPanel = False
        Me.GVSelected.OptionsView.ShowIndicator = False
        Me.GVSelected.ScrollStyle = DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.None
        '
        'colNum
        '
        Me.colNum.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.colNum.AppearanceCell.Options.UseBackColor = True
        Me.colNum.AppearanceCell.Options.UseTextOptions = True
        Me.colNum.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNum.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colNum.AppearanceHeader.Options.UseFont = True
        Me.colNum.AppearanceHeader.Options.UseTextOptions = True
        Me.colNum.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNum.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colNum.Caption = "ลำดับ"
        Me.colNum.MaxWidth = 45
        Me.colNum.MinWidth = 45
        Me.colNum.Name = "colNum"
        Me.colNum.OptionsColumn.AllowEdit = False
        Me.colNum.OptionsColumn.ReadOnly = True
        Me.colNum.Width = 45
        '
        'colLotNum
        '
        Me.colLotNum.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.colLotNum.AppearanceCell.Options.UseBackColor = True
        Me.colLotNum.AppearanceCell.Options.UseTextOptions = True
        Me.colLotNum.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLotNum.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colLotNum.AppearanceHeader.Options.UseFont = True
        Me.colLotNum.AppearanceHeader.Options.UseTextOptions = True
        Me.colLotNum.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLotNum.Caption = "Lot No."
        Me.colLotNum.FieldName = "LotNo"
        Me.colLotNum.MinWidth = 40
        Me.colLotNum.Name = "colLotNum"
        Me.colLotNum.OptionsColumn.AllowEdit = False
        Me.colLotNum.OptionsColumn.ReadOnly = True
        Me.colLotNum.Visible = True
        Me.colLotNum.VisibleIndex = 0
        Me.colLotNum.Width = 97
        '
        'colInvName_
        '
        Me.colInvName_.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.colInvName_.AppearanceCell.Options.UseBackColor = True
        Me.colInvName_.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colInvName_.AppearanceHeader.Options.UseFont = True
        Me.colInvName_.AppearanceHeader.Options.UseTextOptions = True
        Me.colInvName_.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colInvName_.Caption = "รายการสินค้า"
        Me.colInvName_.FieldName = "ProductName"
        Me.colInvName_.Name = "colInvName_"
        Me.colInvName_.OptionsColumn.AllowEdit = False
        Me.colInvName_.OptionsColumn.ReadOnly = True
        Me.colInvName_.Visible = True
        Me.colInvName_.VisibleIndex = 1
        Me.colInvName_.Width = 250
        '
        'colAmtReturn
        '
        Me.colAmtReturn.AppearanceCell.Options.UseTextOptions = True
        Me.colAmtReturn.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colAmtReturn.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colAmtReturn.AppearanceHeader.Options.UseFont = True
        Me.colAmtReturn.AppearanceHeader.Options.UseTextOptions = True
        Me.colAmtReturn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colAmtReturn.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colAmtReturn.Caption = "จำนวน  รับคืน"
        Me.colAmtReturn.FieldName = "AmountRT"
        Me.colAmtReturn.MaxWidth = 45
        Me.colAmtReturn.MinWidth = 45
        Me.colAmtReturn.Name = "colAmtReturn"
        Me.colAmtReturn.Visible = True
        Me.colAmtReturn.VisibleIndex = 2
        Me.colAmtReturn.Width = 45
        '
        'colDelete
        '
        Me.colDelete.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.colDelete.AppearanceCell.Options.UseBackColor = True
        Me.colDelete.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colDelete.AppearanceHeader.Options.UseFont = True
        Me.colDelete.AppearanceHeader.Options.UseTextOptions = True
        Me.colDelete.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDelete.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colDelete.Caption = "ลบ"
        Me.colDelete.ColumnEdit = Me.rptDel
        Me.colDelete.MaxWidth = 25
        Me.colDelete.MinWidth = 25
        Me.colDelete.Name = "colDelete"
        Me.colDelete.Visible = True
        Me.colDelete.VisibleIndex = 3
        Me.colDelete.Width = 25
        '
        'rptDel
        '
        Me.rptDel.AutoHeight = False
        Me.rptDel.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("rptDel.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject2, "", Nothing, Nothing, True)})
        Me.rptDel.Name = "rptDel"
        Me.rptDel.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'colidLot
        '
        Me.colidLot.Caption = "idLot"
        Me.colidLot.FieldName = "idLot"
        Me.colidLot.Name = "colidLot"
        Me.colidLot.Width = 127
        '
        'colidInvGroup
        '
        Me.colidInvGroup.Caption = "idInvGroup"
        Me.colidInvGroup.FieldName = "idInvGroup"
        Me.colidInvGroup.Name = "colidInvGroup"
        Me.colidInvGroup.Width = 76
        '
        'colidInvMain_
        '
        Me.colidInvMain_.Caption = "idInvMain"
        Me.colidInvMain_.FieldName = "idInvMain"
        Me.colidInvMain_.Name = "colidInvMain_"
        '
        'colidSubType_
        '
        Me.colidSubType_.Caption = "idSubType_"
        Me.colidSubType_.FieldName = "idSubType"
        Me.colidSubType_.Name = "colidSubType_"
        '
        'colidWh_
        '
        Me.colidWh_.Caption = "idWh"
        Me.colidWh_.FieldName = "idWh"
        Me.colidWh_.Name = "colidWh_"
        '
        'CompRec
        '
        Me.CompRec.Caption = "CompRec"
        Me.CompRec.FieldName = "CompRec"
        Me.CompRec.Name = "CompRec"
        '
        'PanelControl3
        '
        Me.PanelControl3.Appearance.BackColor = System.Drawing.Color.LightSteelBlue
        Me.PanelControl3.Appearance.BackColor2 = System.Drawing.Color.CornflowerBlue
        Me.PanelControl3.Appearance.Options.UseBackColor = True
        Me.PanelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl3.Controls.Add(Me.btnAddLot)
        Me.PanelControl3.Controls.Add(Me.btnSel)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl3.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(424, 34)
        Me.PanelControl3.TabIndex = 742
        '
        'btnAddLot
        '
        Me.btnAddLot.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddLot.Appearance.Options.UseFont = True
        Me.btnAddLot.Image = CType(resources.GetObject("btnAddLot.Image"), System.Drawing.Image)
        Me.btnAddLot.Location = New System.Drawing.Point(3, 3)
        Me.btnAddLot.Name = "btnAddLot"
        Me.btnAddLot.Size = New System.Drawing.Size(132, 28)
        Me.btnAddLot.TabIndex = 628
        Me.btnAddLot.Text = "เพิ่ม Lot สินค้าใหม่"
        '
        'btnSel
        '
        Me.btnSel.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSel.Appearance.Options.UseFont = True
        Me.btnSel.Image = CType(resources.GetObject("btnSel.Image"), System.Drawing.Image)
        Me.btnSel.Location = New System.Drawing.Point(136, 3)
        Me.btnSel.Name = "btnSel"
        Me.btnSel.Size = New System.Drawing.Size(139, 28)
        Me.btnSel.TabIndex = 2
        Me.btnSel.Text = "เลือกรายการทั้งหมด"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.GCProduct)
        Me.Panel3.Controls.Add(Me.PanelControl2)
        Me.Panel3.Controls.Add(Me.PanelControl1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(731, 551)
        Me.Panel3.TabIndex = 745
        '
        'frmLotReturnSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1184, 551)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmLotReturnSelect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "เลือกรายการ Lot รับคืน"
        Me.Panel2.ResumeLayout(False)
        CType(Me.GCProduct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVProduct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptSelect, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.GCSelected, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVSelected, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptDel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GCProduct As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVProduct As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rptSelect As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Panel8 As Panel
    Friend WithEvents txtCount As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbInvName As ComboBox
    Friend WithEvents txtInvName As TextBox
    Friend WithEvents txtLotNo As TextBox
    Friend WithEvents chkInvName As CheckBox
    Friend WithEvents chkLotNo As CheckBox
    Friend WithEvents rdbAllSale As RadioButton
    Friend WithEvents rdbOnlyCus As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ColDocCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColLotNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColInvName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColAmtSale As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColUnitName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents GCSelected As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVSelected As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colNum As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLotNum As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInvName_ As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDelete As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rptDel As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents colidLot As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colidInvGroup As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colidInvMain_ As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colidSubType_ As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colidWh_ As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CompRec As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnSel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAddLot As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colAmtReturn As DevExpress.XtraGrid.Columns.GridColumn
End Class
