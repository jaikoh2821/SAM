<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmOrderWaitToSale
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
        Me.components = New System.ComponentModel.Container()
        Dim GridLevelNode2 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmOrderWaitToSale))
        Dim SerializableAppearanceObject5 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject6 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject7 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject8 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.GVSmSaleOrderDt = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColNum = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColLotno = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColProductName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColAmtOrder = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColAmtSale = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColUnitName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColWareHouse = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidInvMain = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCWaitOrderToBill = New DevExpress.XtraGrid.GridControl()
        Me.GVSmSaleOrderMt = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColNumMt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColCrateBill = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rptCrateBill = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.colCompName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDateOrderD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDocCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDocRef = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColPartnerName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rptPartNerName = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.ColPsSaleName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColPsTs = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDateTs = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColidSaleOrder = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rptCheck = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.rptShow = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.rptCancel = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtCount = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnFind = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdbDateTs = New System.Windows.Forms.RadioButton()
        Me.rdbDateReturn = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dtpMonth = New System.Windows.Forms.DateTimePicker()
        Me.rdbMonth = New System.Windows.Forms.RadioButton()
        Me.dtpOrderE = New System.Windows.Forms.DateTimePicker()
        Me.dtpYear = New System.Windows.Forms.DateTimePicker()
        Me.rdbYear = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.rdbDate = New System.Windows.Forms.RadioButton()
        Me.dtpOrderS = New System.Windows.Forms.DateTimePicker()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnNewBill = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.ColidWaitCutDt = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.GVSmSaleOrderDt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCWaitOrderToBill, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVSmSaleOrderMt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptCrateBill, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptPartNerName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptCheck, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptShow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GVSmSaleOrderDt
        '
        Me.GVSmSaleOrderDt.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.GVSmSaleOrderDt.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVSmSaleOrderDt.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.GVSmSaleOrderDt.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Gray
        Me.GVSmSaleOrderDt.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVSmSaleOrderDt.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GVSmSaleOrderDt.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GVSmSaleOrderDt.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVSmSaleOrderDt.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GVSmSaleOrderDt.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVSmSaleOrderDt.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Blue
        Me.GVSmSaleOrderDt.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVSmSaleOrderDt.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GVSmSaleOrderDt.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GVSmSaleOrderDt.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GVSmSaleOrderDt.Appearance.EvenRow.Options.UseForeColor = True
        Me.GVSmSaleOrderDt.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GVSmSaleOrderDt.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GVSmSaleOrderDt.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.GVSmSaleOrderDt.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.GVSmSaleOrderDt.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.GVSmSaleOrderDt.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.GVSmSaleOrderDt.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVSmSaleOrderDt.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GVSmSaleOrderDt.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.GVSmSaleOrderDt.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVSmSaleOrderDt.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GVSmSaleOrderDt.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVSmSaleOrderDt.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.GVSmSaleOrderDt.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.GVSmSaleOrderDt.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.GVSmSaleOrderDt.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVSmSaleOrderDt.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVSmSaleOrderDt.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVSmSaleOrderDt.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GVSmSaleOrderDt.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.GVSmSaleOrderDt.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.GVSmSaleOrderDt.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.GVSmSaleOrderDt.Appearance.GroupButton.Options.UseBackColor = True
        Me.GVSmSaleOrderDt.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GVSmSaleOrderDt.Appearance.GroupButton.Options.UseForeColor = True
        Me.GVSmSaleOrderDt.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.GVSmSaleOrderDt.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.GVSmSaleOrderDt.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GVSmSaleOrderDt.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVSmSaleOrderDt.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GVSmSaleOrderDt.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GVSmSaleOrderDt.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.GVSmSaleOrderDt.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.GVSmSaleOrderDt.Appearance.GroupPanel.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GVSmSaleOrderDt.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White
        Me.GVSmSaleOrderDt.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GVSmSaleOrderDt.Appearance.GroupPanel.Options.UseFont = True
        Me.GVSmSaleOrderDt.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVSmSaleOrderDt.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.GVSmSaleOrderDt.Appearance.GroupRow.ForeColor = System.Drawing.Color.Silver
        Me.GVSmSaleOrderDt.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVSmSaleOrderDt.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVSmSaleOrderDt.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.GVSmSaleOrderDt.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.LightSteelBlue
        Me.GVSmSaleOrderDt.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.GVSmSaleOrderDt.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GVSmSaleOrderDt.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GVSmSaleOrderDt.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVSmSaleOrderDt.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVSmSaleOrderDt.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVSmSaleOrderDt.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GVSmSaleOrderDt.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.GVSmSaleOrderDt.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVSmSaleOrderDt.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.GVSmSaleOrderDt.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVSmSaleOrderDt.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GVSmSaleOrderDt.Appearance.OddRow.Options.UseForeColor = True
        Me.GVSmSaleOrderDt.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GVSmSaleOrderDt.Appearance.Row.Options.UseForeColor = True
        Me.GVSmSaleOrderDt.Appearance.RowSeparator.ForeColor = System.Drawing.Color.Black
        Me.GVSmSaleOrderDt.Appearance.RowSeparator.Options.UseForeColor = True
        Me.GVSmSaleOrderDt.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.GVSmSaleOrderDt.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GVSmSaleOrderDt.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.GVSmSaleOrderDt.Appearance.VertLine.Options.UseBackColor = True
        Me.GVSmSaleOrderDt.ColumnPanelRowHeight = 40
        Me.GVSmSaleOrderDt.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColNum, Me.ColLotno, Me.ColProductName, Me.ColAmtOrder, Me.ColAmtSale, Me.ColUnitName, Me.ColWareHouse, Me.colidInvMain, Me.ColidWaitCutDt})
        Me.GVSmSaleOrderDt.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GVSmSaleOrderDt.GridControl = Me.GCWaitOrderToBill
        Me.GVSmSaleOrderDt.Name = "GVSmSaleOrderDt"
        Me.GVSmSaleOrderDt.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GVSmSaleOrderDt.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDown
        Me.GVSmSaleOrderDt.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GVSmSaleOrderDt.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.GVSmSaleOrderDt.OptionsView.EnableAppearanceEvenRow = True
        Me.GVSmSaleOrderDt.OptionsView.EnableAppearanceOddRow = True
        Me.GVSmSaleOrderDt.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GVSmSaleOrderDt.OptionsView.ShowGroupPanel = False
        Me.GVSmSaleOrderDt.OptionsView.ShowIndicator = False
        '
        'ColNum
        '
        Me.ColNum.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
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
        'ColLotno
        '
        Me.ColLotno.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
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
        Me.ColLotno.VisibleIndex = 0
        Me.ColLotno.Width = 123
        '
        'ColProductName
        '
        Me.ColProductName.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
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
        Me.ColProductName.VisibleIndex = 1
        Me.ColProductName.Width = 319
        '
        'ColAmtOrder
        '
        Me.ColAmtOrder.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColAmtOrder.AppearanceCell.Options.UseFont = True
        Me.ColAmtOrder.AppearanceCell.Options.UseTextOptions = True
        Me.ColAmtOrder.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ColAmtOrder.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColAmtOrder.AppearanceHeader.Options.UseFont = True
        Me.ColAmtOrder.AppearanceHeader.Options.UseTextOptions = True
        Me.ColAmtOrder.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColAmtOrder.Caption = "จำนวนสั่งซื้อ"
        Me.ColAmtOrder.DisplayFormat.FormatString = "#,##0.00##"
        Me.ColAmtOrder.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColAmtOrder.FieldName = "AmtOrder"
        Me.ColAmtOrder.Name = "ColAmtOrder"
        Me.ColAmtOrder.Visible = True
        Me.ColAmtOrder.VisibleIndex = 4
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
        Me.ColAmtSale.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ColAmtSale.Caption = "จำนวนเปิดบิลขาย"
        Me.ColAmtSale.DisplayFormat.FormatString = "#,##0.00##"
        Me.ColAmtSale.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColAmtSale.FieldName = "AmtSale"
        Me.ColAmtSale.Name = "ColAmtSale"
        Me.ColAmtSale.OptionsColumn.AllowFocus = False
        Me.ColAmtSale.OptionsColumn.ReadOnly = True
        Me.ColAmtSale.Visible = True
        Me.ColAmtSale.VisibleIndex = 2
        Me.ColAmtSale.Width = 118
        '
        'ColUnitName
        '
        Me.ColUnitName.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
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
        Me.ColUnitName.VisibleIndex = 3
        Me.ColUnitName.Width = 72
        '
        'ColWareHouse
        '
        Me.ColWareHouse.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColWareHouse.AppearanceCell.Options.UseFont = True
        Me.ColWareHouse.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColWareHouse.AppearanceHeader.Options.UseFont = True
        Me.ColWareHouse.AppearanceHeader.Options.UseTextOptions = True
        Me.ColWareHouse.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColWareHouse.Caption = "คลัง"
        Me.ColWareHouse.FieldName = "WareHouseName"
        Me.ColWareHouse.Name = "ColWareHouse"
        Me.ColWareHouse.OptionsColumn.AllowEdit = False
        Me.ColWareHouse.OptionsColumn.ReadOnly = True
        Me.ColWareHouse.Visible = True
        Me.ColWareHouse.VisibleIndex = 5
        Me.ColWareHouse.Width = 201
        '
        'colidInvMain
        '
        Me.colidInvMain.AppearanceCell.Options.UseFont = True
        Me.colidInvMain.Caption = "idInvMain"
        Me.colidInvMain.FieldName = "idInvMain"
        Me.colidInvMain.Name = "colidInvMain"
        '
        'GCWaitOrderToBill
        '
        Me.GCWaitOrderToBill.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCWaitOrderToBill.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        GridLevelNode2.LevelTemplate = Me.GVSmSaleOrderDt
        GridLevelNode2.RelationName = "Level1"
        Me.GCWaitOrderToBill.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode2})
        Me.GCWaitOrderToBill.Location = New System.Drawing.Point(0, 124)
        Me.GCWaitOrderToBill.MainView = Me.GVSmSaleOrderMt
        Me.GCWaitOrderToBill.Name = "GCWaitOrderToBill"
        Me.GCWaitOrderToBill.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rptCheck, Me.rptShow, Me.rptCancel, Me.rptCrateBill, Me.rptPartNerName})
        Me.GCWaitOrderToBill.Size = New System.Drawing.Size(1184, 427)
        Me.GCWaitOrderToBill.TabIndex = 742
        Me.GCWaitOrderToBill.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVSmSaleOrderMt, Me.GVSmSaleOrderDt})
        '
        'GVSmSaleOrderMt
        '
        Me.GVSmSaleOrderMt.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVSmSaleOrderMt.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVSmSaleOrderMt.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GVSmSaleOrderMt.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVSmSaleOrderMt.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GVSmSaleOrderMt.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GVSmSaleOrderMt.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GVSmSaleOrderMt.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GVSmSaleOrderMt.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GVSmSaleOrderMt.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVSmSaleOrderMt.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GVSmSaleOrderMt.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GVSmSaleOrderMt.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVSmSaleOrderMt.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.GVSmSaleOrderMt.Appearance.Empty.Options.UseBackColor = True
        Me.GVSmSaleOrderMt.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVSmSaleOrderMt.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVSmSaleOrderMt.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GVSmSaleOrderMt.Appearance.EvenRow.Options.UseBackColor = True
        Me.GVSmSaleOrderMt.Appearance.EvenRow.Options.UseBorderColor = True
        Me.GVSmSaleOrderMt.Appearance.EvenRow.Options.UseForeColor = True
        Me.GVSmSaleOrderMt.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVSmSaleOrderMt.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVSmSaleOrderMt.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GVSmSaleOrderMt.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GVSmSaleOrderMt.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GVSmSaleOrderMt.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GVSmSaleOrderMt.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVSmSaleOrderMt.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.GVSmSaleOrderMt.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVSmSaleOrderMt.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVSmSaleOrderMt.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GVSmSaleOrderMt.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.GVSmSaleOrderMt.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVSmSaleOrderMt.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GVSmSaleOrderMt.Appearance.FocusedCell.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.GVSmSaleOrderMt.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVSmSaleOrderMt.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVSmSaleOrderMt.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GVSmSaleOrderMt.Appearance.FocusedRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.GVSmSaleOrderMt.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVSmSaleOrderMt.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVSmSaleOrderMt.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVSmSaleOrderMt.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVSmSaleOrderMt.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVSmSaleOrderMt.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVSmSaleOrderMt.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVSmSaleOrderMt.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GVSmSaleOrderMt.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.GVSmSaleOrderMt.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.GVSmSaleOrderMt.Appearance.GroupButton.Options.UseBackColor = True
        Me.GVSmSaleOrderMt.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GVSmSaleOrderMt.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GVSmSaleOrderMt.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GVSmSaleOrderMt.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GVSmSaleOrderMt.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVSmSaleOrderMt.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GVSmSaleOrderMt.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GVSmSaleOrderMt.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVSmSaleOrderMt.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.GVSmSaleOrderMt.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.GVSmSaleOrderMt.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GVSmSaleOrderMt.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVSmSaleOrderMt.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GVSmSaleOrderMt.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GVSmSaleOrderMt.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GVSmSaleOrderMt.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVSmSaleOrderMt.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GVSmSaleOrderMt.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVSmSaleOrderMt.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GVSmSaleOrderMt.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GVSmSaleOrderMt.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GVSmSaleOrderMt.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVSmSaleOrderMt.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVSmSaleOrderMt.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GVSmSaleOrderMt.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GVSmSaleOrderMt.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.GVSmSaleOrderMt.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVSmSaleOrderMt.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVSmSaleOrderMt.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.GVSmSaleOrderMt.Appearance.HorzLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.GVSmSaleOrderMt.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVSmSaleOrderMt.Appearance.HorzLine.Options.UseBorderColor = True
        Me.GVSmSaleOrderMt.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVSmSaleOrderMt.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVSmSaleOrderMt.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GVSmSaleOrderMt.Appearance.OddRow.Options.UseBackColor = True
        Me.GVSmSaleOrderMt.Appearance.OddRow.Options.UseBorderColor = True
        Me.GVSmSaleOrderMt.Appearance.OddRow.Options.UseForeColor = True
        Me.GVSmSaleOrderMt.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.GVSmSaleOrderMt.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.GVSmSaleOrderMt.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.GVSmSaleOrderMt.Appearance.Preview.Options.UseBackColor = True
        Me.GVSmSaleOrderMt.Appearance.Preview.Options.UseFont = True
        Me.GVSmSaleOrderMt.Appearance.Preview.Options.UseForeColor = True
        Me.GVSmSaleOrderMt.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVSmSaleOrderMt.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GVSmSaleOrderMt.Appearance.Row.Options.UseBackColor = True
        Me.GVSmSaleOrderMt.Appearance.Row.Options.UseForeColor = True
        Me.GVSmSaleOrderMt.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVSmSaleOrderMt.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.GVSmSaleOrderMt.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GVSmSaleOrderMt.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GVSmSaleOrderMt.Appearance.SelectedRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.GVSmSaleOrderMt.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVSmSaleOrderMt.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GVSmSaleOrderMt.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GVSmSaleOrderMt.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GVSmSaleOrderMt.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.GVSmSaleOrderMt.Appearance.VertLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.GVSmSaleOrderMt.Appearance.VertLine.Options.UseBackColor = True
        Me.GVSmSaleOrderMt.Appearance.VertLine.Options.UseBorderColor = True
        Me.GVSmSaleOrderMt.ColumnPanelRowHeight = 35
        Me.GVSmSaleOrderMt.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColNumMt, Me.ColCrateBill, Me.colCompName, Me.ColDateOrderD, Me.ColDocCode, Me.ColDocRef, Me.ColPartnerName, Me.ColPsSaleName, Me.ColPsTs, Me.ColDateTs, Me.ColidSaleOrder})
        Me.GVSmSaleOrderMt.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GVSmSaleOrderMt.GridControl = Me.GCWaitOrderToBill
        Me.GVSmSaleOrderMt.Name = "GVSmSaleOrderMt"
        Me.GVSmSaleOrderMt.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDown
        Me.GVSmSaleOrderMt.OptionsDetail.AllowOnlyOneMasterRowExpanded = True
        Me.GVSmSaleOrderMt.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GVSmSaleOrderMt.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.GVSmSaleOrderMt.OptionsView.EnableAppearanceEvenRow = True
        Me.GVSmSaleOrderMt.OptionsView.EnableAppearanceOddRow = True
        Me.GVSmSaleOrderMt.OptionsView.RowAutoHeight = True
        Me.GVSmSaleOrderMt.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GVSmSaleOrderMt.OptionsView.ShowGroupPanel = False
        Me.GVSmSaleOrderMt.OptionsView.ShowIndicator = False
        Me.GVSmSaleOrderMt.PaintStyleName = "MixedXP"
        '
        'ColNumMt
        '
        Me.ColNumMt.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColNumMt.AppearanceCell.Options.UseFont = True
        Me.ColNumMt.AppearanceCell.Options.UseTextOptions = True
        Me.ColNumMt.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColNumMt.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColNumMt.AppearanceHeader.Options.UseFont = True
        Me.ColNumMt.AppearanceHeader.Options.UseTextOptions = True
        Me.ColNumMt.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColNumMt.Caption = "ลำดับ"
        Me.ColNumMt.MaxWidth = 45
        Me.ColNumMt.MinWidth = 45
        Me.ColNumMt.Name = "ColNumMt"
        Me.ColNumMt.OptionsColumn.AllowEdit = False
        Me.ColNumMt.OptionsColumn.ReadOnly = True
        Me.ColNumMt.Visible = True
        Me.ColNumMt.VisibleIndex = 1
        Me.ColNumMt.Width = 45
        '
        'ColCrateBill
        '
        Me.ColCrateBill.AppearanceCell.Options.UseFont = True
        Me.ColCrateBill.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColCrateBill.AppearanceHeader.Options.UseFont = True
        Me.ColCrateBill.AppearanceHeader.Options.UseTextOptions = True
        Me.ColCrateBill.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColCrateBill.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColCrateBill.Caption = "เปิดบิลขาย"
        Me.ColCrateBill.ColumnEdit = Me.rptCrateBill
        Me.ColCrateBill.FieldName = "stBill"
        Me.ColCrateBill.MaxWidth = 45
        Me.ColCrateBill.MinWidth = 45
        Me.ColCrateBill.Name = "ColCrateBill"
        Me.ColCrateBill.OptionsColumn.ReadOnly = True
        Me.ColCrateBill.Visible = True
        Me.ColCrateBill.VisibleIndex = 0
        Me.ColCrateBill.Width = 45
        '
        'rptCrateBill
        '
        Me.rptCrateBill.AutoHeight = False
        Me.rptCrateBill.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("rptCrateBill.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject5, "", Nothing, Nothing, True)})
        Me.rptCrateBill.Name = "rptCrateBill"
        Me.rptCrateBill.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'colCompName
        '
        Me.colCompName.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.colCompName.AppearanceCell.Options.UseFont = True
        Me.colCompName.AppearanceCell.Options.UseTextOptions = True
        Me.colCompName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCompName.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.colCompName.AppearanceHeader.Options.UseFont = True
        Me.colCompName.AppearanceHeader.Options.UseTextOptions = True
        Me.colCompName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCompName.Caption = "บริษัท"
        Me.colCompName.FieldName = "CompCode"
        Me.colCompName.MaxWidth = 55
        Me.colCompName.MinWidth = 55
        Me.colCompName.Name = "colCompName"
        Me.colCompName.OptionsColumn.AllowEdit = False
        Me.colCompName.OptionsColumn.ReadOnly = True
        Me.colCompName.Visible = True
        Me.colCompName.VisibleIndex = 2
        Me.colCompName.Width = 55
        '
        'ColDateOrderD
        '
        Me.ColDateOrderD.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColDateOrderD.AppearanceCell.Options.UseFont = True
        Me.ColDateOrderD.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColDateOrderD.AppearanceHeader.Options.UseFont = True
        Me.ColDateOrderD.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDateOrderD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDateOrderD.Caption = "วันที่สั่งซื้อ"
        Me.ColDateOrderD.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.ColDateOrderD.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.ColDateOrderD.FieldName = "DateOrderD"
        Me.ColDateOrderD.MinWidth = 100
        Me.ColDateOrderD.Name = "ColDateOrderD"
        Me.ColDateOrderD.OptionsColumn.AllowEdit = False
        Me.ColDateOrderD.OptionsColumn.ReadOnly = True
        Me.ColDateOrderD.Visible = True
        Me.ColDateOrderD.VisibleIndex = 3
        Me.ColDateOrderD.Width = 142
        '
        'ColDocCode
        '
        Me.ColDocCode.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColDocCode.AppearanceCell.Options.UseFont = True
        Me.ColDocCode.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColDocCode.AppearanceHeader.Options.UseFont = True
        Me.ColDocCode.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDocCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDocCode.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColDocCode.Caption = "เลขที่รายการสั่งซื้อ"
        Me.ColDocCode.FieldName = "DocCode"
        Me.ColDocCode.MinWidth = 100
        Me.ColDocCode.Name = "ColDocCode"
        Me.ColDocCode.OptionsColumn.AllowEdit = False
        Me.ColDocCode.OptionsColumn.ReadOnly = True
        Me.ColDocCode.Visible = True
        Me.ColDocCode.VisibleIndex = 4
        Me.ColDocCode.Width = 154
        '
        'ColDocRef
        '
        Me.ColDocRef.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColDocRef.AppearanceCell.Options.UseFont = True
        Me.ColDocRef.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColDocRef.AppearanceHeader.Options.UseFont = True
        Me.ColDocRef.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDocRef.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDocRef.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColDocRef.Caption = "เลขที่เอกสารอ้างอิง"
        Me.ColDocRef.FieldName = "DocRef"
        Me.ColDocRef.Name = "ColDocRef"
        Me.ColDocRef.OptionsColumn.AllowEdit = False
        Me.ColDocRef.OptionsColumn.ReadOnly = True
        Me.ColDocRef.Visible = True
        Me.ColDocRef.VisibleIndex = 5
        Me.ColDocRef.Width = 167
        '
        'ColPartnerName
        '
        Me.ColPartnerName.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColPartnerName.AppearanceCell.Options.UseFont = True
        Me.ColPartnerName.AppearanceCell.Options.UseTextOptions = True
        Me.ColPartnerName.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.ColPartnerName.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColPartnerName.AppearanceHeader.Options.UseFont = True
        Me.ColPartnerName.AppearanceHeader.Options.UseTextOptions = True
        Me.ColPartnerName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColPartnerName.Caption = "ชื่อลูกค้า"
        Me.ColPartnerName.ColumnEdit = Me.rptPartNerName
        Me.ColPartnerName.FieldName = "PartnerName"
        Me.ColPartnerName.Name = "ColPartnerName"
        Me.ColPartnerName.OptionsColumn.AllowEdit = False
        Me.ColPartnerName.OptionsColumn.ReadOnly = True
        Me.ColPartnerName.Visible = True
        Me.ColPartnerName.VisibleIndex = 6
        Me.ColPartnerName.Width = 345
        '
        'rptPartNerName
        '
        Me.rptPartNerName.Name = "rptPartNerName"
        '
        'ColPsSaleName
        '
        Me.ColPsSaleName.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColPsSaleName.AppearanceCell.Options.UseFont = True
        Me.ColPsSaleName.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColPsSaleName.AppearanceHeader.Options.UseFont = True
        Me.ColPsSaleName.AppearanceHeader.Options.UseTextOptions = True
        Me.ColPsSaleName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColPsSaleName.Caption = "เจ้าหน้าที่ขาย"
        Me.ColPsSaleName.FieldName = "PsSaleName"
        Me.ColPsSaleName.Name = "ColPsSaleName"
        Me.ColPsSaleName.OptionsColumn.AllowEdit = False
        Me.ColPsSaleName.OptionsColumn.ReadOnly = True
        Me.ColPsSaleName.Visible = True
        Me.ColPsSaleName.VisibleIndex = 7
        Me.ColPsSaleName.Width = 190
        '
        'ColPsTs
        '
        Me.ColPsTs.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColPsTs.AppearanceCell.Options.UseFont = True
        Me.ColPsTs.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColPsTs.AppearanceHeader.Options.UseFont = True
        Me.ColPsTs.AppearanceHeader.Options.UseTextOptions = True
        Me.ColPsTs.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColPsTs.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColPsTs.Caption = "ผู้ทำรายการ"
        Me.ColPsTs.FieldName = "PsTsName"
        Me.ColPsTs.Name = "ColPsTs"
        Me.ColPsTs.OptionsColumn.AllowEdit = False
        Me.ColPsTs.OptionsColumn.ReadOnly = True
        Me.ColPsTs.Visible = True
        Me.ColPsTs.VisibleIndex = 8
        Me.ColPsTs.Width = 133
        '
        'ColDateTs
        '
        Me.ColDateTs.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColDateTs.AppearanceCell.Options.UseFont = True
        Me.ColDateTs.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColDateTs.AppearanceHeader.Options.UseFont = True
        Me.ColDateTs.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDateTs.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDateTs.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColDateTs.Caption = "วันที่ทำรายการ"
        Me.ColDateTs.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.ColDateTs.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.ColDateTs.FieldName = "DateTsD"
        Me.ColDateTs.Name = "ColDateTs"
        Me.ColDateTs.OptionsColumn.AllowEdit = False
        Me.ColDateTs.OptionsColumn.ReadOnly = True
        Me.ColDateTs.Visible = True
        Me.ColDateTs.VisibleIndex = 9
        Me.ColDateTs.Width = 196
        '
        'ColidSaleOrder
        '
        Me.ColidSaleOrder.Caption = "idSaleOrder"
        Me.ColidSaleOrder.FieldName = "idSaleOrder"
        Me.ColidSaleOrder.Name = "ColidSaleOrder"
        '
        'rptCheck
        '
        Me.rptCheck.AutoHeight = False
        Me.rptCheck.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("rptCheck.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject6, "", Nothing, Nothing, True)})
        Me.rptCheck.Name = "rptCheck"
        Me.rptCheck.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'rptShow
        '
        Me.rptShow.AutoHeight = False
        Me.rptShow.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("rptShow.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject7, "", Nothing, Nothing, True)})
        Me.rptShow.Name = "rptShow"
        Me.rptShow.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'rptCancel
        '
        Me.rptCancel.AutoHeight = False
        Me.rptCancel.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("rptCancel.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject8, "", Nothing, Nothing, True)})
        Me.rptCancel.Name = "rptCancel"
        Me.rptCancel.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "adddoc.png")
        Me.ImageList1.Images.SetKeyName(1, "Computer-Edit.png")
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.txtCount)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(916, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(268, 28)
        Me.Panel3.TabIndex = 711
        '
        'txtCount
        '
        Me.txtCount.BackColor = System.Drawing.Color.Black
        Me.txtCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCount.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCount.ForeColor = System.Drawing.Color.Lime
        Me.txtCount.Location = New System.Drawing.Point(111, 1)
        Me.txtCount.Name = "txtCount"
        Me.txtCount.Size = New System.Drawing.Size(98, 25)
        Me.txtCount.TabIndex = 600
        Me.txtCount.Text = "0"
        Me.txtCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(211, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 16)
        Me.Label3.TabIndex = 599
        Me.Label3.Text = "รายการ"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(10, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 16)
        Me.Label5.TabIndex = 597
        Me.Label5.Text = "จำนวนรายการ"
        '
        'btnFind
        '
        Me.btnFind.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFind.Appearance.Options.UseFont = True
        Me.btnFind.Image = CType(resources.GetObject("btnFind.Image"), System.Drawing.Image)
        Me.btnFind.Location = New System.Drawing.Point(2, 1)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(105, 26)
        Me.btnFind.TabIndex = 0
        Me.btnFind.Text = "Refresh"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.rdbDateTs)
        Me.GroupBox1.Controls.Add(Me.rdbDateReturn)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(231, 54)
        Me.GroupBox1.TabIndex = 600
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ประเภทข้อมูลวันที่"
        '
        'rdbDateTs
        '
        Me.rdbDateTs.AutoSize = True
        Me.rdbDateTs.Checked = True
        Me.rdbDateTs.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rdbDateTs.Location = New System.Drawing.Point(116, 23)
        Me.rdbDateTs.Name = "rdbDateTs"
        Me.rdbDateTs.Size = New System.Drawing.Size(98, 18)
        Me.rdbDateTs.TabIndex = 601
        Me.rdbDateTs.TabStop = True
        Me.rdbDateTs.Text = "วันที่ทำรายการ"
        Me.rdbDateTs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdbDateTs.UseVisualStyleBackColor = True
        '
        'rdbDateReturn
        '
        Me.rdbDateReturn.AutoSize = True
        Me.rdbDateReturn.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rdbDateReturn.Location = New System.Drawing.Point(30, 23)
        Me.rdbDateReturn.Name = "rdbDateReturn"
        Me.rdbDateReturn.Size = New System.Drawing.Size(75, 18)
        Me.rdbDateReturn.TabIndex = 600
        Me.rdbDateReturn.Text = "วันที่สั่งซื้อ"
        Me.rdbDateReturn.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.dtpMonth)
        Me.GroupBox2.Controls.Add(Me.rdbMonth)
        Me.GroupBox2.Controls.Add(Me.dtpOrderE)
        Me.GroupBox2.Controls.Add(Me.dtpYear)
        Me.GroupBox2.Controls.Add(Me.rdbYear)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.rdbDate)
        Me.GroupBox2.Controls.Add(Me.dtpOrderS)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(249, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(738, 54)
        Me.GroupBox2.TabIndex = 606
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ช่วงวันที่"
        '
        'dtpMonth
        '
        Me.dtpMonth.Checked = False
        Me.dtpMonth.CustomFormat = "MMMM /yyyy"
        Me.dtpMonth.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpMonth.Location = New System.Drawing.Point(455, 21)
        Me.dtpMonth.Name = "dtpMonth"
        Me.dtpMonth.Size = New System.Drawing.Size(147, 22)
        Me.dtpMonth.TabIndex = 650
        '
        'rdbMonth
        '
        Me.rdbMonth.AutoSize = True
        Me.rdbMonth.Checked = True
        Me.rdbMonth.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rdbMonth.Location = New System.Drawing.Point(409, 23)
        Me.rdbMonth.Name = "rdbMonth"
        Me.rdbMonth.Size = New System.Drawing.Size(50, 18)
        Me.rdbMonth.TabIndex = 628
        Me.rdbMonth.TabStop = True
        Me.rdbMonth.Text = "เดือน"
        Me.rdbMonth.UseVisualStyleBackColor = True
        '
        'dtpOrderE
        '
        Me.dtpOrderE.CustomFormat = "ddMMMMyyyy"
        Me.dtpOrderE.Enabled = False
        Me.dtpOrderE.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpOrderE.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpOrderE.Location = New System.Drawing.Point(241, 21)
        Me.dtpOrderE.MinDate = New Date(1757, 1, 1, 0, 0, 0, 0)
        Me.dtpOrderE.Name = "dtpOrderE"
        Me.dtpOrderE.Size = New System.Drawing.Size(144, 22)
        Me.dtpOrderE.TabIndex = 607
        '
        'dtpYear
        '
        Me.dtpYear.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpYear.CausesValidation = False
        Me.dtpYear.CustomFormat = "yyyy"
        Me.dtpYear.Enabled = False
        Me.dtpYear.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpYear.Location = New System.Drawing.Point(661, 19)
        Me.dtpYear.Name = "dtpYear"
        Me.dtpYear.ShowUpDown = True
        Me.dtpYear.Size = New System.Drawing.Size(65, 22)
        Me.dtpYear.TabIndex = 621
        Me.dtpYear.Value = New Date(2025, 1, 19, 15, 28, 0, 0)
        '
        'rdbYear
        '
        Me.rdbYear.AutoSize = True
        Me.rdbYear.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rdbYear.Location = New System.Drawing.Point(628, 21)
        Me.rdbYear.Name = "rdbYear"
        Me.rdbYear.Size = New System.Drawing.Size(33, 18)
        Me.rdbYear.TabIndex = 606
        Me.rdbYear.Text = "ปี"
        Me.rdbYear.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(215, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(20, 14)
        Me.Label4.TabIndex = 605
        Me.Label4.Text = "ถึง"
        '
        'rdbDate
        '
        Me.rdbDate.AutoSize = True
        Me.rdbDate.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rdbDate.Location = New System.Drawing.Point(9, 23)
        Me.rdbDate.Name = "rdbDate"
        Me.rdbDate.Size = New System.Drawing.Size(47, 18)
        Me.rdbDate.TabIndex = 603
        Me.rdbDate.Text = "วันที่"
        Me.rdbDate.UseVisualStyleBackColor = True
        '
        'dtpOrderS
        '
        Me.dtpOrderS.CustomFormat = "ddMMMMyyyy"
        Me.dtpOrderS.Enabled = False
        Me.dtpOrderS.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpOrderS.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpOrderS.Location = New System.Drawing.Point(62, 21)
        Me.dtpOrderS.MinDate = New Date(1757, 1, 1, 0, 0, 0, 0)
        Me.dtpOrderS.Name = "dtpOrderS"
        Me.dtpOrderS.Size = New System.Drawing.Size(147, 22)
        Me.dtpOrderS.TabIndex = 601
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnFind)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(108, 28)
        Me.Panel2.TabIndex = 588
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.LabelControl9.Appearance.BackColor2 = System.Drawing.SystemColors.ActiveCaption
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl9.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.LabelControl9.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl9.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelControl9.Location = New System.Drawing.Point(0, 99)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.LabelControl9.Size = New System.Drawing.Size(1184, 25)
        Me.LabelControl9.TabIndex = 743
        Me.LabelControl9.Text = "รายการสั่งซื้อ (Order) รอเปิดบิลขาย"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel4.Controls.Add(Me.Panel1)
        Me.Panel4.Controls.Add(Me.Panel3)
        Me.Panel4.Controls.Add(Me.Panel2)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 71)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1184, 28)
        Me.Panel4.TabIndex = 740
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnNewBill)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(108, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(216, 28)
        Me.Panel1.TabIndex = 712
        '
        'btnNewBill
        '
        Me.btnNewBill.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewBill.Appearance.Options.UseFont = True
        Me.btnNewBill.Image = CType(resources.GetObject("btnNewBill.Image"), System.Drawing.Image)
        Me.btnNewBill.Location = New System.Drawing.Point(3, 1)
        Me.btnNewBill.Name = "btnNewBill"
        Me.btnNewBill.Size = New System.Drawing.Size(210, 26)
        Me.btnNewBill.TabIndex = 0
        Me.btnNewBill.Text = "เปิดบิลขายไม่อ้างอิงออเดอร์"
        '
        'PanelControl1
        '
        Me.PanelControl1.Appearance.BackColor = System.Drawing.Color.Lavender
        Me.PanelControl1.Appearance.BackColor2 = System.Drawing.Color.LightSteelBlue
        Me.PanelControl1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.PanelControl1.Appearance.Options.UseBackColor = True
        Me.PanelControl1.Appearance.Options.UseFont = True
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.GroupBox1)
        Me.PanelControl1.Controls.Add(Me.GroupBox2)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1184, 71)
        Me.PanelControl1.TabIndex = 741
        '
        'ColidWaitCutDt
        '
        Me.ColidWaitCutDt.Caption = "idWaitCutDt"
        Me.ColidWaitCutDt.FieldName = "idWaitCutDt"
        Me.ColidWaitCutDt.Name = "ColidWaitCutDt"
        '
        'FrmOrderWaitToSale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1184, 551)
        Me.Controls.Add(Me.GCWaitOrderToBill)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmOrderWaitToSale"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "รายการสั่งซื้อ (Order) รอเปิดบิลขาย"
        CType(Me.GVSmSaleOrderDt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCWaitOrderToBill, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVSmSaleOrderMt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptCrateBill, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptPartNerName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptCheck, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptShow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptCancel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ColPsSaleName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColPsTs As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDateTs As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColidSaleOrder As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtCount As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnFind As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdbDateTs As RadioButton
    Friend WithEvents rdbDateReturn As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dtpMonth As DateTimePicker
    Friend WithEvents rdbMonth As RadioButton
    Friend WithEvents dtpOrderE As DateTimePicker
    Friend WithEvents dtpYear As DateTimePicker
    Friend WithEvents rdbYear As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents rdbDate As RadioButton
    Friend WithEvents dtpOrderS As DateTimePicker
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ColPartnerName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCWaitOrderToBill As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVSmSaleOrderDt As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColNum As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColLotno As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColProductName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColAmtSale As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColUnitName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColWareHouse As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colidInvMain As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GVSmSaleOrderMt As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColNumMt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rptCancel As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents rptShow As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents rptCheck As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents ColCrateBill As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rptCrateBill As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents colCompName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDateOrderD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDocCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents ColAmtOrder As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDocRef As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rptPartNerName As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnNewBill As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ColidWaitCutDt As DevExpress.XtraGrid.Columns.GridColumn
End Class
