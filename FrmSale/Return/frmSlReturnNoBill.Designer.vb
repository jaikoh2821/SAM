<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSlReturnNoBill
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSlReturnNoBill))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.rptSelect = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtLotNo = New System.Windows.Forms.TextBox()
        Me.GCData = New DevExpress.XtraGrid.GridControl()
        Me.GvShowData = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.ColSelect = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDocRef = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColPartnerName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColLotno = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColProductName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColAmtSale = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColUnitName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDateGen = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidProduct = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidLot = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidUnit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColidSaleDt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColidSale = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.idInvGroup = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NavBarControl1 = New DevExpress.XtraNavBar.NavBarControl()
        Me.NVLotxSmSale = New DevExpress.XtraNavBar.NavBarGroup()
        Me.NavBarGroupControlContainer2 = New DevExpress.XtraNavBar.NavBarGroupControlContainer()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.NavBarGroupControlContainer1 = New DevExpress.XtraNavBar.NavBarGroupControlContainer()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblPdName = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.btnFindPd = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpDateMFG = New System.Windows.Forms.DateTimePicker()
        Me.lblUnit = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.NVNewLot = New DevExpress.XtraNavBar.NavBarGroup()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.btnBlackSelectLot = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAddLot = New DevExpress.XtraEditors.SimpleButton()
        Me.ChkOld = New System.Windows.Forms.CheckBox()
        CType(Me.rptSelect, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GvShowData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NavBarControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NavBarControl1.SuspendLayout()
        Me.NavBarGroupControlContainer2.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        Me.NavBarGroupControlContainer1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'rptSelect
        '
        Me.rptSelect.AutoHeight = False
        Me.rptSelect.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("rptSelect.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.rptSelect.Name = "rptSelect"
        Me.rptSelect.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(300, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 15)
        Me.Label2.TabIndex = 625
        Me.Label2.Text = "ค้นหา Lot No."
        '
        'txtLotNo
        '
        Me.txtLotNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtLotNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtLotNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLotNo.Location = New System.Drawing.Point(392, 12)
        Me.txtLotNo.Name = "txtLotNo"
        Me.txtLotNo.Size = New System.Drawing.Size(171, 22)
        Me.txtLotNo.TabIndex = 0
        '
        'GCData
        '
        Me.GCData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCData.Location = New System.Drawing.Point(0, 38)
        Me.GCData.MainView = Me.GvShowData
        Me.GCData.Name = "GCData"
        Me.GCData.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.GCData.Size = New System.Drawing.Size(904, 434)
        Me.GCData.TabIndex = 2
        Me.GCData.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GvShowData})
        '
        'GvShowData
        '
        Me.GvShowData.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GvShowData.Appearance.FocusedCell.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GvShowData.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GvShowData.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GvShowData.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GvShowData.Appearance.FocusedRow.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GvShowData.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GvShowData.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GvShowData.ColumnPanelRowHeight = 40
        Me.GvShowData.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.ColSelect, Me.ColDocRef, Me.ColPartnerName, Me.ColLotno, Me.ColProductName, Me.ColAmtSale, Me.ColUnitName, Me.ColDateGen, Me.ColPrice, Me.colidProduct, Me.colidLot, Me.colidUnit, Me.ColidSaleDt, Me.ColidSale, Me.idInvGroup})
        Me.GvShowData.GridControl = Me.GCData
        Me.GvShowData.Name = "GvShowData"
        Me.GvShowData.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GvShowData.OptionsView.ShowGroupPanel = False
        Me.GvShowData.OptionsView.ShowIndicator = False
        Me.GvShowData.PaintStyleName = "MixedXP"
        Me.GvShowData.RowHeight = 25
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn1.AppearanceHeader.Options.UseFont = True
        Me.GridColumn1.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.Caption = "เลือก"
        Me.GridColumn1.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.GridColumn1.FieldName = "chk"
        Me.GridColumn1.MaxWidth = 45
        Me.GridColumn1.MinWidth = 45
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 45
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'ColSelect
        '
        Me.ColSelect.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ColSelect.AppearanceHeader.Options.UseFont = True
        Me.ColSelect.AppearanceHeader.Options.UseTextOptions = True
        Me.ColSelect.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColSelect.Caption = "เลือก"
        Me.ColSelect.ColumnEdit = Me.rptSelect
        Me.ColSelect.MaxWidth = 45
        Me.ColSelect.MinWidth = 45
        Me.ColSelect.Name = "ColSelect"
        Me.ColSelect.Width = 45
        '
        'ColDocRef
        '
        Me.ColDocRef.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColDocRef.AppearanceCell.Options.UseBackColor = True
        Me.ColDocRef.AppearanceCell.Options.UseTextOptions = True
        Me.ColDocRef.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDocRef.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ColDocRef.AppearanceHeader.Options.UseFont = True
        Me.ColDocRef.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDocRef.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDocRef.Caption = "เลขที่บิลขาย"
        Me.ColDocRef.FieldName = "DocRef"
        Me.ColDocRef.MaxWidth = 85
        Me.ColDocRef.MinWidth = 85
        Me.ColDocRef.Name = "ColDocRef"
        Me.ColDocRef.OptionsColumn.AllowEdit = False
        Me.ColDocRef.OptionsColumn.ReadOnly = True
        Me.ColDocRef.OptionsColumn.TabStop = False
        Me.ColDocRef.Visible = True
        Me.ColDocRef.VisibleIndex = 1
        Me.ColDocRef.Width = 85
        '
        'ColPartnerName
        '
        Me.ColPartnerName.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColPartnerName.AppearanceCell.Options.UseBackColor = True
        Me.ColPartnerName.AppearanceCell.Options.UseTextOptions = True
        Me.ColPartnerName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.ColPartnerName.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ColPartnerName.AppearanceHeader.Options.UseFont = True
        Me.ColPartnerName.AppearanceHeader.Options.UseTextOptions = True
        Me.ColPartnerName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColPartnerName.Caption = "ชื่อลูกค้า"
        Me.ColPartnerName.FieldName = "PartnerName"
        Me.ColPartnerName.Name = "ColPartnerName"
        Me.ColPartnerName.OptionsColumn.AllowEdit = False
        Me.ColPartnerName.OptionsColumn.ReadOnly = True
        Me.ColPartnerName.OptionsColumn.TabStop = False
        Me.ColPartnerName.Width = 199
        '
        'ColLotno
        '
        Me.ColLotno.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColLotno.AppearanceCell.Options.UseBackColor = True
        Me.ColLotno.AppearanceCell.Options.UseTextOptions = True
        Me.ColLotno.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColLotno.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ColLotno.AppearanceHeader.Options.UseFont = True
        Me.ColLotno.AppearanceHeader.Options.UseTextOptions = True
        Me.ColLotno.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColLotno.Caption = "Lot No."
        Me.ColLotno.FieldName = "LotNo"
        Me.ColLotno.MinWidth = 100
        Me.ColLotno.Name = "ColLotno"
        Me.ColLotno.OptionsColumn.AllowEdit = False
        Me.ColLotno.OptionsColumn.ReadOnly = True
        Me.ColLotno.OptionsColumn.TabStop = False
        Me.ColLotno.Visible = True
        Me.ColLotno.VisibleIndex = 2
        Me.ColLotno.Width = 100
        '
        'ColProductName
        '
        Me.ColProductName.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ColProductName.AppearanceCell.Options.UseBackColor = True
        Me.ColProductName.AppearanceCell.Options.UseTextOptions = True
        Me.ColProductName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.ColProductName.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColProductName.AppearanceHeader.Options.UseFont = True
        Me.ColProductName.AppearanceHeader.Options.UseTextOptions = True
        Me.ColProductName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColProductName.Caption = "รายการสินค้า"
        Me.ColProductName.FieldName = "ProductName"
        Me.ColProductName.Name = "ColProductName"
        Me.ColProductName.OptionsColumn.AllowEdit = False
        Me.ColProductName.OptionsColumn.ReadOnly = True
        Me.ColProductName.OptionsColumn.TabStop = False
        Me.ColProductName.Visible = True
        Me.ColProductName.VisibleIndex = 3
        Me.ColProductName.Width = 452
        '
        'ColAmtSale
        '
        Me.ColAmtSale.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColAmtSale.AppearanceCell.Options.UseBackColor = True
        Me.ColAmtSale.AppearanceCell.Options.UseTextOptions = True
        Me.ColAmtSale.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ColAmtSale.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColAmtSale.AppearanceHeader.Options.UseFont = True
        Me.ColAmtSale.AppearanceHeader.Options.UseTextOptions = True
        Me.ColAmtSale.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColAmtSale.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColAmtSale.Caption = "จำนวนขาย"
        Me.ColAmtSale.DisplayFormat.FormatString = "N2"
        Me.ColAmtSale.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColAmtSale.FieldName = "AmtSale"
        Me.ColAmtSale.MaxWidth = 65
        Me.ColAmtSale.MinWidth = 65
        Me.ColAmtSale.Name = "ColAmtSale"
        Me.ColAmtSale.OptionsColumn.AllowEdit = False
        Me.ColAmtSale.OptionsColumn.ReadOnly = True
        Me.ColAmtSale.OptionsColumn.TabStop = False
        Me.ColAmtSale.Visible = True
        Me.ColAmtSale.VisibleIndex = 4
        Me.ColAmtSale.Width = 65
        '
        'ColUnitName
        '
        Me.ColUnitName.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColUnitName.AppearanceCell.Options.UseBackColor = True
        Me.ColUnitName.AppearanceCell.Options.UseTextOptions = True
        Me.ColUnitName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColUnitName.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColUnitName.AppearanceHeader.Options.UseFont = True
        Me.ColUnitName.AppearanceHeader.Options.UseTextOptions = True
        Me.ColUnitName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColUnitName.Caption = "หน่วย"
        Me.ColUnitName.FieldName = "UnitName"
        Me.ColUnitName.MaxWidth = 65
        Me.ColUnitName.MinWidth = 65
        Me.ColUnitName.Name = "ColUnitName"
        Me.ColUnitName.OptionsColumn.AllowEdit = False
        Me.ColUnitName.OptionsColumn.ReadOnly = True
        Me.ColUnitName.OptionsColumn.TabStop = False
        Me.ColUnitName.Visible = True
        Me.ColUnitName.VisibleIndex = 5
        Me.ColUnitName.Width = 65
        '
        'ColDateGen
        '
        Me.ColDateGen.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColDateGen.AppearanceCell.Options.UseBackColor = True
        Me.ColDateGen.AppearanceCell.Options.UseTextOptions = True
        Me.ColDateGen.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDateGen.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ColDateGen.AppearanceHeader.Options.UseFont = True
        Me.ColDateGen.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDateGen.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDateGen.Caption = "วันที่ผลิต"
        Me.ColDateGen.FieldName = "DateGen"
        Me.ColDateGen.MaxWidth = 75
        Me.ColDateGen.MinWidth = 75
        Me.ColDateGen.Name = "ColDateGen"
        Me.ColDateGen.OptionsColumn.AllowEdit = False
        Me.ColDateGen.OptionsColumn.ReadOnly = True
        Me.ColDateGen.OptionsColumn.TabStop = False
        Me.ColDateGen.Visible = True
        Me.ColDateGen.VisibleIndex = 6
        '
        'ColPrice
        '
        Me.ColPrice.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColPrice.AppearanceCell.Options.UseBackColor = True
        Me.ColPrice.AppearanceCell.Options.UseTextOptions = True
        Me.ColPrice.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ColPrice.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ColPrice.AppearanceHeader.Options.UseFont = True
        Me.ColPrice.AppearanceHeader.Options.UseTextOptions = True
        Me.ColPrice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColPrice.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColPrice.Caption = "ราคาต่อหน่วย"
        Me.ColPrice.DisplayFormat.FormatString = "#,##0.00##"
        Me.ColPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColPrice.FieldName = "Price"
        Me.ColPrice.Name = "ColPrice"
        Me.ColPrice.OptionsColumn.AllowEdit = False
        Me.ColPrice.OptionsColumn.ReadOnly = True
        Me.ColPrice.Width = 61
        '
        'colidProduct
        '
        Me.colidProduct.Caption = "idProduct"
        Me.colidProduct.FieldName = "idProduct"
        Me.colidProduct.Name = "colidProduct"
        '
        'colidLot
        '
        Me.colidLot.Caption = "idLot"
        Me.colidLot.FieldName = "idLot"
        Me.colidLot.Name = "colidLot"
        '
        'colidUnit
        '
        Me.colidUnit.Caption = "idUnit"
        Me.colidUnit.FieldName = "idUnit"
        Me.colidUnit.Name = "colidUnit"
        '
        'ColidSaleDt
        '
        Me.ColidSaleDt.Caption = "idSaleDt"
        Me.ColidSaleDt.FieldName = "idSaleDt"
        Me.ColidSaleDt.Name = "ColidSaleDt"
        '
        'ColidSale
        '
        Me.ColidSale.Caption = "idSale"
        Me.ColidSale.FieldName = "idSale"
        Me.ColidSale.Name = "ColidSale"
        '
        'idInvGroup
        '
        Me.idInvGroup.Caption = "idInvGroup"
        Me.idInvGroup.FieldName = "idInvGroup"
        Me.idInvGroup.Name = "idInvGroup"
        '
        'NavBarControl1
        '
        Me.NavBarControl1.ActiveGroup = Me.NVLotxSmSale
        Me.NavBarControl1.Controls.Add(Me.NavBarGroupControlContainer1)
        Me.NavBarControl1.Controls.Add(Me.NavBarGroupControlContainer2)
        Me.NavBarControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NavBarControl1.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() {Me.NVLotxSmSale, Me.NVNewLot})
        Me.NavBarControl1.Location = New System.Drawing.Point(0, 64)
        Me.NavBarControl1.Name = "NavBarControl1"
        Me.NavBarControl1.OptionsNavPane.ExpandedWidth = 912
        Me.NavBarControl1.Size = New System.Drawing.Size(912, 508)
        Me.NavBarControl1.TabIndex = 1
        Me.NavBarControl1.Text = "NavBarControl1"
        '
        'NVLotxSmSale
        '
        Me.NVLotxSmSale.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NVLotxSmSale.Appearance.Options.UseFont = True
        Me.NVLotxSmSale.Caption = " เลือกข้อมูล Lot No. จากรายการขาย"
        Me.NVLotxSmSale.ControlContainer = Me.NavBarGroupControlContainer2
        Me.NVLotxSmSale.GroupClientHeight = 476
        Me.NVLotxSmSale.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer
        Me.NVLotxSmSale.Name = "NVLotxSmSale"
        Me.NVLotxSmSale.SmallImage = CType(resources.GetObject("NVLotxSmSale.SmallImage"), System.Drawing.Image)
        '
        'NavBarGroupControlContainer2
        '
        Me.NavBarGroupControlContainer2.Controls.Add(Me.GCData)
        Me.NavBarGroupControlContainer2.Controls.Add(Me.PanelControl2)
        Me.NavBarGroupControlContainer2.Name = "NavBarGroupControlContainer2"
        Me.NavBarGroupControlContainer2.Size = New System.Drawing.Size(904, 472)
        Me.NavBarGroupControlContainer2.TabIndex = 1
        '
        'PanelControl2
        '
        Me.PanelControl2.Appearance.BackColor = System.Drawing.Color.Lavender
        Me.PanelControl2.Appearance.BackColor2 = System.Drawing.Color.LightSteelBlue
        Me.PanelControl2.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.PanelControl2.Appearance.Options.UseBackColor = True
        Me.PanelControl2.Appearance.Options.UseFont = True
        Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl2.Controls.Add(Me.SimpleButton2)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl2.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(904, 38)
        Me.PanelControl2.TabIndex = 3
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton2.Appearance.Options.UseFont = True
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(3, 2)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(142, 35)
        Me.SimpleButton2.TabIndex = 0
        Me.SimpleButton2.Text = "เลือกรายการที่ระบุ"
        '
        'NavBarGroupControlContainer1
        '
        Me.NavBarGroupControlContainer1.Controls.Add(Me.Panel2)
        Me.NavBarGroupControlContainer1.Name = "NavBarGroupControlContainer1"
        Me.NavBarGroupControlContainer1.Size = New System.Drawing.Size(904, 126)
        Me.NavBarGroupControlContainer1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Beige
        Me.Panel2.Controls.Add(Me.btnSave)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.txtCost)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(904, 126)
        Me.Panel2.TabIndex = 0
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.DimGray
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(404, 91)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(114, 29)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Tag = "Save"
        Me.btnSave.Text = "  เพิ่มรายการ"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(797, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 637
        Me.Label4.Text = "ราคาต้นทุน"
        Me.Label4.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.lblPdName)
        Me.GroupBox1.Controls.Add(Me.txtAmount)
        Me.GroupBox1.Controls.Add(Me.btnFindPd)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.dtpDateMFG)
        Me.GroupBox1.Controls.Add(Me.lblUnit)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(199, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(521, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(17, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 15)
        Me.Label6.TabIndex = 621
        Me.Label6.Text = "ชื่อสินค้า"
        '
        'lblPdName
        '
        Me.lblPdName.BackColor = System.Drawing.Color.Gainsboro
        Me.lblPdName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPdName.Location = New System.Drawing.Point(68, 25)
        Me.lblPdName.Name = "lblPdName"
        Me.lblPdName.Size = New System.Drawing.Size(400, 20)
        Me.lblPdName.TabIndex = 622
        Me.lblPdName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(323, 57)
        Me.txtAmount.MaxLength = 30
        Me.txtAmount.Multiline = True
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(107, 19)
        Me.txtAmount.TabIndex = 1
        Me.txtAmount.Text = "0"
        Me.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnFindPd
        '
        Me.btnFindPd.BackColor = System.Drawing.Color.DimGray
        Me.btnFindPd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFindPd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.7!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnFindPd.ForeColor = System.Drawing.Color.White
        Me.btnFindPd.Image = CType(resources.GetObject("btnFindPd.Image"), System.Drawing.Image)
        Me.btnFindPd.Location = New System.Drawing.Point(472, 23)
        Me.btnFindPd.Name = "btnFindPd"
        Me.btnFindPd.Size = New System.Drawing.Size(28, 25)
        Me.btnFindPd.TabIndex = 0
        Me.btnFindPd.Tag = "Add"
        Me.btnFindPd.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 624
        Me.Label5.Text = "วันทีผลิต"
        '
        'dtpDateMFG
        '
        Me.dtpDateMFG.CustomFormat = "dd MMMM yyyy"
        Me.dtpDateMFG.Enabled = False
        Me.dtpDateMFG.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateMFG.Location = New System.Drawing.Point(68, 54)
        Me.dtpDateMFG.Name = "dtpDateMFG"
        Me.dtpDateMFG.Size = New System.Drawing.Size(148, 20)
        Me.dtpDateMFG.TabIndex = 3
        Me.dtpDateMFG.Value = New Date(2018, 4, 5, 9, 59, 32, 0)
        '
        'lblUnit
        '
        Me.lblUnit.AutoSize = True
        Me.lblUnit.Location = New System.Drawing.Point(433, 60)
        Me.lblUnit.Name = "lblUnit"
        Me.lblUnit.Size = New System.Drawing.Size(35, 13)
        Me.lblUnit.TabIndex = 631
        Me.lblUnit.Text = "หน่วย"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(251, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 627
        Me.Label3.Text = "จำนวนรับคืน"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(828, 72)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(26, 13)
        Me.Label9.TabIndex = 636
        Me.Label9.Text = "บาท"
        Me.Label9.Visible = False
        '
        'txtCost
        '
        Me.txtCost.Location = New System.Drawing.Point(805, 50)
        Me.txtCost.MaxLength = 30
        Me.txtCost.Multiline = True
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(49, 19)
        Me.txtCost.TabIndex = 2
        Me.txtCost.Text = "0.00"
        Me.txtCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCost.Visible = False
        '
        'NVNewLot
        '
        Me.NVNewLot.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NVNewLot.Appearance.Options.UseFont = True
        Me.NVNewLot.Caption = " เพิ่มข้อมูล Lot No. รับคืน"
        Me.NVNewLot.ControlContainer = Me.NavBarGroupControlContainer1
        Me.NVNewLot.Expanded = True
        Me.NVNewLot.GroupClientHeight = 130
        Me.NVNewLot.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer
        Me.NVNewLot.Name = "NVNewLot"
        Me.NVNewLot.SmallImage = CType(resources.GetObject("NVNewLot.SmallImage"), System.Drawing.Image)
        '
        'PanelControl1
        '
        Me.PanelControl1.Appearance.BackColor = System.Drawing.Color.Lavender
        Me.PanelControl1.Appearance.BackColor2 = System.Drawing.Color.LightSteelBlue
        Me.PanelControl1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.PanelControl1.Appearance.Options.UseBackColor = True
        Me.PanelControl1.Appearance.Options.UseFont = True
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.btnBlackSelectLot)
        Me.PanelControl1.Controls.Add(Me.btnAddLot)
        Me.PanelControl1.Controls.Add(Me.ChkOld)
        Me.PanelControl1.Controls.Add(Me.Label2)
        Me.PanelControl1.Controls.Add(Me.txtLotNo)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(912, 64)
        Me.PanelControl1.TabIndex = 1
        '
        'btnBlackSelectLot
        '
        Me.btnBlackSelectLot.Image = Global.SAM.My.Resources.Resources.arrow_modify_old_undo_icone_3957_16
        Me.btnBlackSelectLot.Location = New System.Drawing.Point(569, 36)
        Me.btnBlackSelectLot.Name = "btnBlackSelectLot"
        Me.btnBlackSelectLot.Size = New System.Drawing.Size(134, 21)
        Me.btnBlackSelectLot.TabIndex = 628
        Me.btnBlackSelectLot.Text = "กลับไปเลือก Lot เดิม"
        '
        'btnAddLot
        '
        Me.btnAddLot.Image = Global.SAM.My.Resources.Resources.arrow2
        Me.btnAddLot.Location = New System.Drawing.Point(569, 13)
        Me.btnAddLot.Name = "btnAddLot"
        Me.btnAddLot.Size = New System.Drawing.Size(134, 21)
        Me.btnAddLot.TabIndex = 627
        Me.btnAddLot.Text = "เพิ่ม Lot สินค้าใหม่"
        '
        'ChkOld
        '
        Me.ChkOld.AutoSize = True
        Me.ChkOld.BackColor = System.Drawing.Color.Transparent
        Me.ChkOld.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ChkOld.ForeColor = System.Drawing.Color.Blue
        Me.ChkOld.Location = New System.Drawing.Point(392, 38)
        Me.ChkOld.Name = "ChkOld"
        Me.ChkOld.Size = New System.Drawing.Size(171, 19)
        Me.ChkOld.TabIndex = 626
        Me.ChkOld.Text = "แสดงรายการขายที่มากกว่า 2 ปี"
        Me.ChkOld.UseVisualStyleBackColor = False
        Me.ChkOld.Visible = False
        '
        'frmSlReturnNoBill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(912, 572)
        Me.Controls.Add(Me.NavBarControl1)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSlReturnNoBill"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ข้อมูลสินค้ารับคืน"
        CType(Me.rptSelect, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GvShowData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NavBarControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NavBarControl1.ResumeLayout(False)
        Me.NavBarGroupControlContainer2.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.NavBarGroupControlContainer1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtLotNo As System.Windows.Forms.TextBox
    Friend WithEvents GCData As DevExpress.XtraGrid.GridControl
    Friend WithEvents GvShowData As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColSelect As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColLotno As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColProductName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDateGen As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColUnitName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NavBarControl1 As DevExpress.XtraNavBar.NavBarControl
    Friend WithEvents NVNewLot As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents NavBarGroupControlContainer1 As DevExpress.XtraNavBar.NavBarGroupControlContainer
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtCost As System.Windows.Forms.TextBox
    Friend WithEvents lblUnit As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpDateMFG As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnFindPd As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblPdName As System.Windows.Forms.Label
    Friend WithEvents NavBarGroupControlContainer2 As DevExpress.XtraNavBar.NavBarGroupControlContainer
    Friend WithEvents NVLotxSmSale As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents colidProduct As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colidLot As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colidUnit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents ColDocRef As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColAmtSale As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColPartnerName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColidSaleDt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColidSale As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ChkOld As System.Windows.Forms.CheckBox
    Friend WithEvents rptSelect As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents btnAddLot As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnBlackSelectLot As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents idInvGroup As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
End Class
