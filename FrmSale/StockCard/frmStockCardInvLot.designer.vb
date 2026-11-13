<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStockCardInvLot
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStockCardInvLot))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.ColQtyIn = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.GBDateBuy = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbWareHouse = New System.Windows.Forms.ComboBox()
        Me.cbWh = New DevExpress.XtraEditors.CheckEdit()
        Me.btnLotNo = New DevExpress.XtraEditors.SimpleButton()
        Me.lblLotNo = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbGroupComp = New System.Windows.Forms.ComboBox()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnRefresh = New DevExpress.XtraEditors.SimpleButton()
        Me.lblLot = New System.Windows.Forms.Label()
        Me.lblInvName = New System.Windows.Forms.Label()
        Me.GCStockCard = New DevExpress.XtraGrid.GridControl()
        Me.BandedGridView1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView()
        Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.ColNo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gridBand7 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.ColDateX = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.ColDetail = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.ColWhName = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gridBand8 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.QtyOUT = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.CalBal = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.ColUnit = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gridBand6 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.ColPsName = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.idWh = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.rptEdit = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.rptShow = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.rptCancel = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.GVReturnDt = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColNum = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColBoxNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColLotno = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColProductName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColAmtRT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColUnitName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColRtCause = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColHumid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColFLName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidInvMain = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.GBDateBuy.SuspendLayout()
        CType(Me.cbWh.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.GCStockCard, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BandedGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptShow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVReturnDt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ColQtyIn
        '
        Me.ColQtyIn.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ColQtyIn.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColQtyIn.AppearanceCell.Options.UseBackColor = True
        Me.ColQtyIn.AppearanceCell.Options.UseFont = True
        Me.ColQtyIn.AppearanceCell.Options.UseTextOptions = True
        Me.ColQtyIn.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ColQtyIn.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColQtyIn.AppearanceHeader.Options.UseFont = True
        Me.ColQtyIn.AppearanceHeader.Options.UseTextOptions = True
        Me.ColQtyIn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColQtyIn.Caption = "เข้า"
        Me.ColQtyIn.DisplayFormat.FormatString = "#,##0.00##"
        Me.ColQtyIn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.ColQtyIn.FieldName = "QtyIN"
        Me.ColQtyIn.Name = "ColQtyIn"
        Me.ColQtyIn.OptionsColumn.AllowEdit = False
        Me.ColQtyIn.OptionsColumn.ReadOnly = True
        Me.ColQtyIn.Visible = True
        Me.ColQtyIn.Width = 76
        '
        'PanelControl1
        '
        Me.PanelControl1.Appearance.BackColor = System.Drawing.Color.Lavender
        Me.PanelControl1.Appearance.BackColor2 = System.Drawing.Color.LightSteelBlue
        Me.PanelControl1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.PanelControl1.Appearance.Options.UseBackColor = True
        Me.PanelControl1.Appearance.Options.UseFont = True
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.GBDateBuy)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1184, 67)
        Me.PanelControl1.TabIndex = 736
        '
        'GBDateBuy
        '
        Me.GBDateBuy.BackColor = System.Drawing.Color.Transparent
        Me.GBDateBuy.Controls.Add(Me.Label1)
        Me.GBDateBuy.Controls.Add(Me.cmbWareHouse)
        Me.GBDateBuy.Controls.Add(Me.cbWh)
        Me.GBDateBuy.Controls.Add(Me.btnLotNo)
        Me.GBDateBuy.Controls.Add(Me.lblLotNo)
        Me.GBDateBuy.Controls.Add(Me.Label2)
        Me.GBDateBuy.Controls.Add(Me.cmbGroupComp)
        Me.GBDateBuy.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBDateBuy.Location = New System.Drawing.Point(3, 5)
        Me.GBDateBuy.Name = "GBDateBuy"
        Me.GBDateBuy.Size = New System.Drawing.Size(1178, 56)
        Me.GBDateBuy.TabIndex = 714
        Me.GBDateBuy.TabStop = False
        Me.GBDateBuy.Text = "การแสดงข้อมูล"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(342, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 14)
        Me.Label1.TabIndex = 773
        Me.Label1.Text = "Lot No.:"
        '
        'cmbWareHouse
        '
        Me.cmbWareHouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbWareHouse.Enabled = False
        Me.cmbWareHouse.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbWareHouse.FormattingEnabled = True
        Me.cmbWareHouse.Location = New System.Drawing.Point(712, 18)
        Me.cmbWareHouse.Name = "cmbWareHouse"
        Me.cmbWareHouse.Size = New System.Drawing.Size(137, 22)
        Me.cmbWareHouse.TabIndex = 772
        '
        'cbWh
        '
        Me.cbWh.Enabled = False
        Me.cbWh.Location = New System.Drawing.Point(634, 20)
        Me.cbWh.Name = "cbWh"
        Me.cbWh.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbWh.Properties.Appearance.Options.UseFont = True
        Me.cbWh.Properties.Caption = "เลือกคลัง"
        Me.cbWh.Size = New System.Drawing.Size(75, 19)
        Me.cbWh.TabIndex = 771
        '
        'btnLotNo
        '
        Me.btnLotNo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLotNo.Image = CType(resources.GetObject("btnLotNo.Image"), System.Drawing.Image)
        Me.btnLotNo.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnLotNo.Location = New System.Drawing.Point(580, 19)
        Me.btnLotNo.Name = "btnLotNo"
        Me.btnLotNo.Size = New System.Drawing.Size(25, 22)
        Me.btnLotNo.TabIndex = 737
        '
        'lblLotNo
        '
        Me.lblLotNo.BackColor = System.Drawing.Color.Gainsboro
        Me.lblLotNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLotNo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLotNo.Location = New System.Drawing.Point(397, 21)
        Me.lblLotNo.Name = "lblLotNo"
        Me.lblLotNo.Size = New System.Drawing.Size(179, 20)
        Me.lblLotNo.TabIndex = 738
        Me.lblLotNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(33, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 14)
        Me.Label2.TabIndex = 769
        Me.Label2.Text = "ข้อมูลบริษัท:"
        '
        'cmbGroupComp
        '
        Me.cmbGroupComp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGroupComp.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbGroupComp.FormattingEnabled = True
        Me.cmbGroupComp.Location = New System.Drawing.Point(109, 21)
        Me.cmbGroupComp.Name = "cmbGroupComp"
        Me.cmbGroupComp.Size = New System.Drawing.Size(199, 22)
        Me.cmbGroupComp.TabIndex = 768
        '
        'PanelControl2
        '
        Me.PanelControl2.Appearance.BackColor = System.Drawing.Color.LightSteelBlue
        Me.PanelControl2.Appearance.BackColor2 = System.Drawing.Color.CornflowerBlue
        Me.PanelControl2.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.PanelControl2.Appearance.Options.UseBackColor = True
        Me.PanelControl2.Appearance.Options.UseFont = True
        Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl2.Controls.Add(Me.Panel1)
        Me.PanelControl2.Controls.Add(Me.lblLot)
        Me.PanelControl2.Controls.Add(Me.lblInvName)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl2.Location = New System.Drawing.Point(0, 67)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(1184, 41)
        Me.PanelControl2.TabIndex = 737
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.btnRefresh)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(1072, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(112, 41)
        Me.Panel1.TabIndex = 775
        '
        'btnRefresh
        '
        Me.btnRefresh.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Appearance.Options.UseFont = True
        Me.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), System.Drawing.Image)
        Me.btnRefresh.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnRefresh.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnRefresh.Location = New System.Drawing.Point(4, 3)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(105, 35)
        Me.btnRefresh.TabIndex = 0
        Me.btnRefresh.Text = "Refresh"
        '
        'lblLot
        '
        Me.lblLot.AutoSize = True
        Me.lblLot.BackColor = System.Drawing.Color.Transparent
        Me.lblLot.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLot.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblLot.Location = New System.Drawing.Point(65, 24)
        Me.lblLot.Name = "lblLot"
        Me.lblLot.Size = New System.Drawing.Size(56, 14)
        Me.lblLot.TabIndex = 774
        Me.lblLot.Text = "Lot No.:"
        '
        'lblInvName
        '
        Me.lblInvName.AutoSize = True
        Me.lblInvName.BackColor = System.Drawing.Color.Transparent
        Me.lblInvName.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvName.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblInvName.Location = New System.Drawing.Point(6, 4)
        Me.lblInvName.Name = "lblInvName"
        Me.lblInvName.Size = New System.Drawing.Size(115, 14)
        Me.lblInvName.TabIndex = 773
        Me.lblInvName.Text = "รายการสต็อกการ์ด :"
        '
        'GCStockCard
        '
        Me.GCStockCard.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCStockCard.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GCStockCard.Location = New System.Drawing.Point(0, 108)
        Me.GCStockCard.MainView = Me.BandedGridView1
        Me.GCStockCard.Name = "GCStockCard"
        Me.GCStockCard.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rptEdit, Me.rptShow, Me.rptCancel})
        Me.GCStockCard.Size = New System.Drawing.Size(1184, 443)
        Me.GCStockCard.TabIndex = 738
        Me.GCStockCard.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.BandedGridView1, Me.GVReturnDt})
        '
        'BandedGridView1
        '
        Me.BandedGridView1.Appearance.HeaderPanel.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BandedGridView1.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Gray
        Me.BandedGridView1.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BandedGridView1.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.BandedGridView1.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.BandedGridView1.Appearance.HeaderPanel.Options.UseFont = True
        Me.BandedGridView1.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.BandedGridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BandedGridView1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand1, Me.gridBand7, Me.gridBand8, Me.gridBand6})
        Me.BandedGridView1.ColumnPanelRowHeight = 35
        Me.BandedGridView1.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.ColDateX, Me.ColDetail, Me.ColWhName, Me.ColQtyIn, Me.QtyOUT, Me.CalBal, Me.ColUnit, Me.ColPsName, Me.ColNo, Me.idWh})
        Me.BandedGridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.BandedGridView1.GridControl = Me.GCStockCard
        Me.BandedGridView1.IndicatorWidth = 45
        Me.BandedGridView1.Name = "BandedGridView1"
        Me.BandedGridView1.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDown
        Me.BandedGridView1.OptionsDetail.AllowOnlyOneMasterRowExpanded = True
        Me.BandedGridView1.OptionsMenu.EnableFooterMenu = False
        Me.BandedGridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.BandedGridView1.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.BandedGridView1.OptionsView.EnableAppearanceEvenRow = True
        Me.BandedGridView1.OptionsView.EnableAppearanceOddRow = True
        Me.BandedGridView1.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.Hidden
        Me.BandedGridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.BandedGridView1.OptionsView.ShowGroupPanel = False
        '
        'GridBand1
        '
        Me.GridBand1.Columns.Add(Me.ColNo)
        Me.GridBand1.Name = "GridBand1"
        Me.GridBand1.Visible = False
        Me.GridBand1.VisibleIndex = -1
        Me.GridBand1.Width = 42
        '
        'ColNo
        '
        Me.ColNo.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColNo.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColNo.AppearanceCell.Options.UseBackColor = True
        Me.ColNo.AppearanceCell.Options.UseFont = True
        Me.ColNo.AppearanceCell.Options.UseTextOptions = True
        Me.ColNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColNo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColNo.AppearanceHeader.Options.UseFont = True
        Me.ColNo.AppearanceHeader.Options.UseTextOptions = True
        Me.ColNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColNo.Caption = "ลำดับ"
        Me.ColNo.Name = "ColNo"
        Me.ColNo.OptionsColumn.AllowEdit = False
        Me.ColNo.OptionsColumn.ReadOnly = True
        Me.ColNo.Visible = True
        Me.ColNo.Width = 42
        '
        'gridBand7
        '
        Me.gridBand7.Columns.Add(Me.ColDateX)
        Me.gridBand7.Columns.Add(Me.ColDetail)
        Me.gridBand7.Columns.Add(Me.ColWhName)
        Me.gridBand7.Name = "gridBand7"
        Me.gridBand7.VisibleIndex = 0
        Me.gridBand7.Width = 626
        '
        'ColDateX
        '
        Me.ColDateX.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColDateX.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColDateX.AppearanceCell.Options.UseBackColor = True
        Me.ColDateX.AppearanceCell.Options.UseFont = True
        Me.ColDateX.AppearanceCell.Options.UseTextOptions = True
        Me.ColDateX.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDateX.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColDateX.AppearanceHeader.Options.UseFont = True
        Me.ColDateX.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDateX.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDateX.Caption = "วันที่"
        Me.ColDateX.FieldName = "DateX"
        Me.ColDateX.Name = "ColDateX"
        Me.ColDateX.OptionsColumn.AllowEdit = False
        Me.ColDateX.OptionsColumn.ReadOnly = True
        Me.ColDateX.Visible = True
        Me.ColDateX.Width = 90
        '
        'ColDetail
        '
        Me.ColDetail.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColDetail.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColDetail.AppearanceCell.Options.UseBackColor = True
        Me.ColDetail.AppearanceCell.Options.UseFont = True
        Me.ColDetail.AppearanceCell.Options.UseTextOptions = True
        Me.ColDetail.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.ColDetail.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColDetail.AppearanceHeader.Options.UseFont = True
        Me.ColDetail.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDetail.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDetail.Caption = "รายละเอียด"
        Me.ColDetail.FieldName = "Detail"
        Me.ColDetail.Name = "ColDetail"
        Me.ColDetail.OptionsColumn.AllowEdit = False
        Me.ColDetail.OptionsColumn.ReadOnly = True
        Me.ColDetail.Visible = True
        Me.ColDetail.Width = 403
        '
        'ColWhName
        '
        Me.ColWhName.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColWhName.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColWhName.AppearanceCell.Options.UseBackColor = True
        Me.ColWhName.AppearanceCell.Options.UseFont = True
        Me.ColWhName.AppearanceCell.Options.UseTextOptions = True
        Me.ColWhName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColWhName.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColWhName.AppearanceHeader.Options.UseFont = True
        Me.ColWhName.AppearanceHeader.Options.UseTextOptions = True
        Me.ColWhName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColWhName.Caption = "คลัง"
        Me.ColWhName.FieldName = "WhName"
        Me.ColWhName.Name = "ColWhName"
        Me.ColWhName.OptionsColumn.AllowEdit = False
        Me.ColWhName.OptionsColumn.ReadOnly = True
        Me.ColWhName.Visible = True
        Me.ColWhName.Width = 133
        '
        'gridBand8
        '
        Me.gridBand8.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.gridBand8.AppearanceHeader.Options.UseFont = True
        Me.gridBand8.AppearanceHeader.Options.UseTextOptions = True
        Me.gridBand8.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gridBand8.Caption = "จำนวน"
        Me.gridBand8.Columns.Add(Me.ColQtyIn)
        Me.gridBand8.Columns.Add(Me.QtyOUT)
        Me.gridBand8.Columns.Add(Me.CalBal)
        Me.gridBand8.Columns.Add(Me.ColUnit)
        Me.gridBand8.Name = "gridBand8"
        Me.gridBand8.VisibleIndex = 1
        Me.gridBand8.Width = 312
        '
        'QtyOUT
        '
        Me.QtyOUT.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.QtyOUT.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.QtyOUT.AppearanceCell.Options.UseBackColor = True
        Me.QtyOUT.AppearanceCell.Options.UseFont = True
        Me.QtyOUT.AppearanceCell.Options.UseTextOptions = True
        Me.QtyOUT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.QtyOUT.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.QtyOUT.AppearanceHeader.Options.UseFont = True
        Me.QtyOUT.AppearanceHeader.Options.UseTextOptions = True
        Me.QtyOUT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.QtyOUT.Caption = "ออก"
        Me.QtyOUT.DisplayFormat.FormatString = "#,##0.00##"
        Me.QtyOUT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.QtyOUT.FieldName = "QtyOUT"
        Me.QtyOUT.Name = "QtyOUT"
        Me.QtyOUT.OptionsColumn.AllowEdit = False
        Me.QtyOUT.OptionsColumn.ReadOnly = True
        Me.QtyOUT.Visible = True
        Me.QtyOUT.Width = 76
        '
        'CalBal
        '
        Me.CalBal.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CalBal.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.CalBal.AppearanceCell.Options.UseBackColor = True
        Me.CalBal.AppearanceCell.Options.UseFont = True
        Me.CalBal.AppearanceCell.Options.UseTextOptions = True
        Me.CalBal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.CalBal.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.CalBal.AppearanceHeader.Options.UseFont = True
        Me.CalBal.AppearanceHeader.Options.UseTextOptions = True
        Me.CalBal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.CalBal.Caption = "คงเหลือ"
        Me.CalBal.DisplayFormat.FormatString = "#,##0.00##"
        Me.CalBal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.CalBal.FieldName = "Bal"
        Me.CalBal.Name = "CalBal"
        Me.CalBal.OptionsColumn.AllowEdit = False
        Me.CalBal.OptionsColumn.ReadOnly = True
        Me.CalBal.Visible = True
        Me.CalBal.Width = 76
        '
        'ColUnit
        '
        Me.ColUnit.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColUnit.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColUnit.AppearanceCell.Options.UseBackColor = True
        Me.ColUnit.AppearanceCell.Options.UseFont = True
        Me.ColUnit.AppearanceCell.Options.UseTextOptions = True
        Me.ColUnit.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColUnit.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColUnit.AppearanceHeader.Options.UseFont = True
        Me.ColUnit.AppearanceHeader.Options.UseTextOptions = True
        Me.ColUnit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColUnit.Caption = "หน่วย"
        Me.ColUnit.FieldName = "UnitName"
        Me.ColUnit.Name = "ColUnit"
        Me.ColUnit.OptionsColumn.AllowEdit = False
        Me.ColUnit.OptionsColumn.ReadOnly = True
        Me.ColUnit.Visible = True
        Me.ColUnit.Width = 84
        '
        'gridBand6
        '
        Me.gridBand6.Columns.Add(Me.ColPsName)
        Me.gridBand6.Name = "gridBand6"
        Me.gridBand6.VisibleIndex = 2
        Me.gridBand6.Width = 111
        '
        'ColPsName
        '
        Me.ColPsName.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColPsName.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColPsName.AppearanceCell.Options.UseBackColor = True
        Me.ColPsName.AppearanceCell.Options.UseFont = True
        Me.ColPsName.AppearanceCell.Options.UseTextOptions = True
        Me.ColPsName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.ColPsName.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColPsName.AppearanceHeader.Options.UseFont = True
        Me.ColPsName.AppearanceHeader.Options.UseTextOptions = True
        Me.ColPsName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColPsName.Caption = "ผู้ทำรายการ"
        Me.ColPsName.FieldName = "PsName"
        Me.ColPsName.Name = "ColPsName"
        Me.ColPsName.OptionsColumn.AllowEdit = False
        Me.ColPsName.OptionsColumn.ReadOnly = True
        Me.ColPsName.Visible = True
        Me.ColPsName.Width = 111
        '
        'idWh
        '
        Me.idWh.Caption = "idWh"
        Me.idWh.FieldName = "idWh"
        Me.idWh.Name = "idWh"
        '
        'rptEdit
        '
        Me.rptEdit.AutoHeight = False
        Me.rptEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("rptEdit.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.rptEdit.Name = "rptEdit"
        Me.rptEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'rptShow
        '
        Me.rptShow.AutoHeight = False
        Me.rptShow.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("rptShow.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject2, "", Nothing, Nothing, True)})
        Me.rptShow.Name = "rptShow"
        Me.rptShow.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'rptCancel
        '
        Me.rptCancel.AutoHeight = False
        Me.rptCancel.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("rptCancel.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject3, "", Nothing, Nothing, True)})
        Me.rptCancel.Name = "rptCancel"
        Me.rptCancel.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'GVReturnDt
        '
        Me.GVReturnDt.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.GVReturnDt.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVReturnDt.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.GVReturnDt.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Gray
        Me.GVReturnDt.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVReturnDt.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GVReturnDt.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GVReturnDt.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVReturnDt.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GVReturnDt.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVReturnDt.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Blue
        Me.GVReturnDt.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVReturnDt.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GVReturnDt.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GVReturnDt.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVReturnDt.Appearance.Empty.Options.UseBackColor = True
        Me.GVReturnDt.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GVReturnDt.Appearance.EvenRow.Options.UseForeColor = True
        Me.GVReturnDt.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GVReturnDt.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GVReturnDt.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.GVReturnDt.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.GVReturnDt.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.GVReturnDt.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.GVReturnDt.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVReturnDt.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GVReturnDt.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.GVReturnDt.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVReturnDt.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GVReturnDt.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVReturnDt.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.GVReturnDt.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.GVReturnDt.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.GVReturnDt.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVReturnDt.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVReturnDt.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVReturnDt.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GVReturnDt.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.GVReturnDt.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.GVReturnDt.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.GVReturnDt.Appearance.GroupButton.Options.UseBackColor = True
        Me.GVReturnDt.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GVReturnDt.Appearance.GroupButton.Options.UseForeColor = True
        Me.GVReturnDt.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.GVReturnDt.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.GVReturnDt.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GVReturnDt.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVReturnDt.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GVReturnDt.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GVReturnDt.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.GVReturnDt.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.GVReturnDt.Appearance.GroupPanel.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GVReturnDt.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White
        Me.GVReturnDt.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GVReturnDt.Appearance.GroupPanel.Options.UseFont = True
        Me.GVReturnDt.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVReturnDt.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.GVReturnDt.Appearance.GroupRow.ForeColor = System.Drawing.Color.Silver
        Me.GVReturnDt.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVReturnDt.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVReturnDt.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.GVReturnDt.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.LightSteelBlue
        Me.GVReturnDt.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.GVReturnDt.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GVReturnDt.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GVReturnDt.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVReturnDt.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVReturnDt.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVReturnDt.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GVReturnDt.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.GVReturnDt.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVReturnDt.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.GVReturnDt.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVReturnDt.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GVReturnDt.Appearance.OddRow.Options.UseForeColor = True
        Me.GVReturnDt.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GVReturnDt.Appearance.Row.Options.UseForeColor = True
        Me.GVReturnDt.Appearance.RowSeparator.ForeColor = System.Drawing.Color.Black
        Me.GVReturnDt.Appearance.RowSeparator.Options.UseForeColor = True
        Me.GVReturnDt.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.GVReturnDt.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GVReturnDt.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.GVReturnDt.Appearance.VertLine.Options.UseBackColor = True
        Me.GVReturnDt.ColumnPanelRowHeight = 40
        Me.GVReturnDt.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColNum, Me.ColBoxNo, Me.ColLotno, Me.ColProductName, Me.ColAmtRT, Me.ColUnitName, Me.ColRtCause, Me.ColHumid, Me.ColFLName, Me.colidInvMain})
        Me.GVReturnDt.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GVReturnDt.GridControl = Me.GCStockCard
        Me.GVReturnDt.Name = "GVReturnDt"
        Me.GVReturnDt.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GVReturnDt.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDown
        Me.GVReturnDt.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GVReturnDt.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.GVReturnDt.OptionsView.EnableAppearanceEvenRow = True
        Me.GVReturnDt.OptionsView.EnableAppearanceOddRow = True
        Me.GVReturnDt.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GVReturnDt.OptionsView.ShowGroupPanel = False
        Me.GVReturnDt.OptionsView.ShowIndicator = False
        '
        'ColNum
        '
        Me.ColNum.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColNum.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColNum.AppearanceCell.Options.UseBackColor = True
        Me.ColNum.AppearanceCell.Options.UseFont = True
        Me.ColNum.AppearanceCell.Options.UseTextOptions = True
        Me.ColNum.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColNum.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColNum.AppearanceHeader.Options.UseFont = True
        Me.ColNum.AppearanceHeader.Options.UseTextOptions = True
        Me.ColNum.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColNum.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColNum.Caption = "ลำดับ"
        Me.ColNum.MaxWidth = 50
        Me.ColNum.MinWidth = 50
        Me.ColNum.Name = "ColNum"
        Me.ColNum.OptionsColumn.AllowEdit = False
        Me.ColNum.OptionsColumn.AllowFocus = False
        Me.ColNum.OptionsColumn.ReadOnly = True
        Me.ColNum.Width = 50
        '
        'ColBoxNo
        '
        Me.ColBoxNo.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColBoxNo.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColBoxNo.AppearanceCell.Options.UseBackColor = True
        Me.ColBoxNo.AppearanceCell.Options.UseFont = True
        Me.ColBoxNo.AppearanceCell.Options.UseTextOptions = True
        Me.ColBoxNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColBoxNo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColBoxNo.AppearanceHeader.Options.UseFont = True
        Me.ColBoxNo.AppearanceHeader.Options.UseTextOptions = True
        Me.ColBoxNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColBoxNo.Caption = "เลขที่กล่อง"
        Me.ColBoxNo.FieldName = "BoxNo"
        Me.ColBoxNo.Name = "ColBoxNo"
        Me.ColBoxNo.OptionsColumn.AllowFocus = False
        Me.ColBoxNo.OptionsColumn.ReadOnly = True
        Me.ColBoxNo.Visible = True
        Me.ColBoxNo.VisibleIndex = 0
        Me.ColBoxNo.Width = 117
        '
        'ColLotno
        '
        Me.ColLotno.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColLotno.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColLotno.AppearanceCell.Options.UseBackColor = True
        Me.ColLotno.AppearanceCell.Options.UseFont = True
        Me.ColLotno.AppearanceCell.Options.UseTextOptions = True
        Me.ColLotno.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColLotno.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ColLotno.AppearanceHeader.Options.UseFont = True
        Me.ColLotno.AppearanceHeader.Options.UseTextOptions = True
        Me.ColLotno.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColLotno.Caption = "Lot No."
        Me.ColLotno.FieldName = "LotNo"
        Me.ColLotno.Name = "ColLotno"
        Me.ColLotno.OptionsColumn.AllowFocus = False
        Me.ColLotno.OptionsColumn.ReadOnly = True
        Me.ColLotno.Visible = True
        Me.ColLotno.VisibleIndex = 1
        Me.ColLotno.Width = 121
        '
        'ColProductName
        '
        Me.ColProductName.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColProductName.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColProductName.AppearanceCell.Options.UseBackColor = True
        Me.ColProductName.AppearanceCell.Options.UseFont = True
        Me.ColProductName.AppearanceCell.Options.UseTextOptions = True
        Me.ColProductName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.ColProductName.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColProductName.AppearanceHeader.Options.UseFont = True
        Me.ColProductName.AppearanceHeader.Options.UseTextOptions = True
        Me.ColProductName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColProductName.Caption = "รายการ"
        Me.ColProductName.FieldName = "InvName"
        Me.ColProductName.Name = "ColProductName"
        Me.ColProductName.OptionsColumn.AllowFocus = False
        Me.ColProductName.OptionsColumn.ReadOnly = True
        Me.ColProductName.Visible = True
        Me.ColProductName.VisibleIndex = 2
        Me.ColProductName.Width = 333
        '
        'ColAmtRT
        '
        Me.ColAmtRT.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColAmtRT.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
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
        Me.ColAmtRT.FieldName = "AmountReturn"
        Me.ColAmtRT.Name = "ColAmtRT"
        Me.ColAmtRT.OptionsColumn.AllowFocus = False
        Me.ColAmtRT.OptionsColumn.ReadOnly = True
        Me.ColAmtRT.Visible = True
        Me.ColAmtRT.VisibleIndex = 3
        Me.ColAmtRT.Width = 112
        '
        'ColUnitName
        '
        Me.ColUnitName.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColUnitName.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
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
        Me.ColUnitName.OptionsColumn.AllowFocus = False
        Me.ColUnitName.OptionsColumn.ReadOnly = True
        Me.ColUnitName.Visible = True
        Me.ColUnitName.VisibleIndex = 4
        Me.ColUnitName.Width = 84
        '
        'ColRtCause
        '
        Me.ColRtCause.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColRtCause.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColRtCause.AppearanceCell.Options.UseBackColor = True
        Me.ColRtCause.AppearanceCell.Options.UseFont = True
        Me.ColRtCause.AppearanceCell.Options.UseTextOptions = True
        Me.ColRtCause.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.ColRtCause.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColRtCause.AppearanceHeader.Options.UseFont = True
        Me.ColRtCause.AppearanceHeader.Options.UseTextOptions = True
        Me.ColRtCause.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColRtCause.Caption = "สาเหตุรับคืน"
        Me.ColRtCause.FieldName = "ReturnCause"
        Me.ColRtCause.Name = "ColRtCause"
        Me.ColRtCause.OptionsColumn.AllowEdit = False
        Me.ColRtCause.OptionsColumn.ReadOnly = True
        Me.ColRtCause.Visible = True
        Me.ColRtCause.VisibleIndex = 7
        Me.ColRtCause.Width = 157
        '
        'ColHumid
        '
        Me.ColHumid.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColHumid.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColHumid.AppearanceCell.Options.UseBackColor = True
        Me.ColHumid.AppearanceCell.Options.UseFont = True
        Me.ColHumid.AppearanceCell.Options.UseTextOptions = True
        Me.ColHumid.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColHumid.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColHumid.AppearanceHeader.Options.UseFont = True
        Me.ColHumid.AppearanceHeader.Options.UseTextOptions = True
        Me.ColHumid.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColHumid.Caption = "ความชื้น"
        Me.ColHumid.FieldName = "Humid"
        Me.ColHumid.Name = "ColHumid"
        Me.ColHumid.OptionsColumn.AllowEdit = False
        Me.ColHumid.OptionsColumn.ReadOnly = True
        Me.ColHumid.Visible = True
        Me.ColHumid.VisibleIndex = 6
        Me.ColHumid.Width = 86
        '
        'ColFLName
        '
        Me.ColFLName.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColFLName.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColFLName.AppearanceCell.Options.UseBackColor = True
        Me.ColFLName.AppearanceCell.Options.UseFont = True
        Me.ColFLName.AppearanceCell.Options.UseTextOptions = True
        Me.ColFLName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColFLName.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColFLName.AppearanceHeader.Options.UseFont = True
        Me.ColFLName.AppearanceHeader.Options.UseTextOptions = True
        Me.ColFLName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColFLName.Caption = "สูตร"
        Me.ColFLName.FieldName = "FLName"
        Me.ColFLName.Name = "ColFLName"
        Me.ColFLName.OptionsColumn.AllowEdit = False
        Me.ColFLName.OptionsColumn.ReadOnly = True
        Me.ColFLName.Visible = True
        Me.ColFLName.VisibleIndex = 5
        Me.ColFLName.Width = 84
        '
        'colidInvMain
        '
        Me.colidInvMain.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.colidInvMain.AppearanceCell.Options.UseBackColor = True
        Me.colidInvMain.AppearanceCell.Options.UseFont = True
        Me.colidInvMain.Caption = "idInvMain"
        Me.colidInvMain.FieldName = "idInvMain"
        Me.colidInvMain.Name = "colidInvMain"
        '
        'frmStockCardInvLot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 551)
        Me.Controls.Add(Me.GCStockCard)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmStockCardInvLot"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "สต็อกการ์ดวัสดุและสินค้า"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.GBDateBuy.ResumeLayout(False)
        Me.GBDateBuy.PerformLayout()
        CType(Me.cbWh.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.GCStockCard, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BandedGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptShow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptCancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVReturnDt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GBDateBuy As System.Windows.Forms.GroupBox
    Friend WithEvents cmbGroupComp As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnLotNo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblLotNo As System.Windows.Forms.Label
    Friend WithEvents cmbWareHouse As System.Windows.Forms.ComboBox
    Friend WithEvents cbWh As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lblLot As System.Windows.Forms.Label
    Friend WithEvents lblInvName As System.Windows.Forms.Label
    Friend WithEvents GCStockCard As DevExpress.XtraGrid.GridControl
    Friend WithEvents BandedGridView1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
    Friend WithEvents ColDateX As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents ColDetail As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents ColWhName As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents ColQtyIn As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents QtyOUT As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents CalBal As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents ColUnit As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents ColPsName As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents rptEdit As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents rptShow As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents rptCancel As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents GVReturnDt As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColNum As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColBoxNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColLotno As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColProductName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColAmtRT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColUnitName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColRtCause As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColHumid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColFLName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colidInvMain As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColNo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents gridBand7 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents gridBand8 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents gridBand6 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents idWh As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
