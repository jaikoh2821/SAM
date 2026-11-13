<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCrateSaleRTData
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
        Me.components = New System.ComponentModel.Container()
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCrateSaleRTData))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.GVReturnDt = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColNum = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColBoxNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColLotno = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColProductName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColAmtRT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColUnitName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColWareHouse = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColRtCause = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColHumid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColFLName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidInvMain = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCWaitRT = New DevExpress.XtraGrid.GridControl()
        Me.GVReturnMt = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColNumMt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColCancel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rptCancel = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.ColShow = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rptShow = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.ColCheck = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rptCheck = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.ColApv = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rptApv = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.colCompName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDateWaitRT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDocCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDocRT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColPartnerName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColPsSaleName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColPsRT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColReturnCause = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColPsTs = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDateTs = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColidWaitReturn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.idComp = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CancelNote = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PsCancel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rptButton = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtCount = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnFind = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdbDateTs = New System.Windows.Forms.RadioButton()
        Me.rdbDateReturn = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dtpMonth = New System.Windows.Forms.DateTimePicker()
        Me.rdbMonth = New System.Windows.Forms.RadioButton()
        Me.dtpReturnE = New System.Windows.Forms.DateTimePicker()
        Me.dtpYear = New System.Windows.Forms.DateTimePicker()
        Me.rdbYear = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.rdbDate = New System.Windows.Forms.RadioButton()
        Me.dtpReturnS = New System.Windows.Forms.DateTimePicker()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.GVReturnDt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCWaitRT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVReturnMt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptShow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptCheck, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptApv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
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
        Me.GVReturnDt.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColNum, Me.ColBoxNo, Me.ColLotno, Me.ColProductName, Me.ColAmtRT, Me.ColUnitName, Me.ColWareHouse, Me.ColRtCause, Me.ColHumid, Me.ColFLName, Me.colidInvMain})
        Me.GVReturnDt.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GVReturnDt.GridControl = Me.GCWaitRT
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
        Me.ColBoxNo.Width = 119
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
        Me.ColLotno.VisibleIndex = 0
        Me.ColLotno.Width = 123
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
        Me.ColProductName.VisibleIndex = 1
        Me.ColProductName.Width = 319
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
        Me.ColAmtRT.VisibleIndex = 2
        Me.ColAmtRT.Width = 118
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
        Me.ColUnitName.VisibleIndex = 3
        Me.ColUnitName.Width = 72
        '
        'ColWareHouse
        '
        Me.ColWareHouse.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColWareHouse.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColWareHouse.AppearanceCell.Options.UseBackColor = True
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
        Me.ColWareHouse.VisibleIndex = 4
        Me.ColWareHouse.Width = 201
        '
        'ColRtCause
        '
        Me.ColRtCause.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColRtCause.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
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
        Me.ColRtCause.VisibleIndex = 5
        Me.ColRtCause.Width = 142
        '
        'ColHumid
        '
        Me.ColHumid.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColHumid.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
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
        Me.ColHumid.Width = 86
        '
        'ColFLName
        '
        Me.ColFLName.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColFLName.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
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
        'GCWaitRT
        '
        Me.GCWaitRT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCWaitRT.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        GridLevelNode1.LevelTemplate = Me.GVReturnDt
        GridLevelNode1.RelationName = "Level1"
        Me.GCWaitRT.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.GCWaitRT.Location = New System.Drawing.Point(0, 124)
        Me.GCWaitRT.MainView = Me.GVReturnMt
        Me.GCWaitRT.Name = "GCWaitRT"
        Me.GCWaitRT.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rptCheck, Me.rptShow, Me.rptCancel, Me.rptApv, Me.rptButton})
        Me.GCWaitRT.Size = New System.Drawing.Size(1184, 427)
        Me.GCWaitRT.TabIndex = 738
        Me.GCWaitRT.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVReturnMt, Me.GVReturnDt})
        '
        'GVReturnMt
        '
        Me.GVReturnMt.Appearance.HeaderPanel.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GVReturnMt.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Gray
        Me.GVReturnMt.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVReturnMt.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVReturnMt.ColumnPanelRowHeight = 35
        Me.GVReturnMt.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColNumMt, Me.ColCancel, Me.ColShow, Me.ColCheck, Me.ColApv, Me.colCompName, Me.ColDateWaitRT, Me.ColDocCode, Me.ColDocRT, Me.ColPartnerName, Me.ColPsSaleName, Me.ColPsRT, Me.ColReturnCause, Me.ColPsTs, Me.ColDateTs, Me.ColidWaitReturn, Me.idComp, Me.CancelNote, Me.PsCancel})
        Me.GVReturnMt.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GVReturnMt.GridControl = Me.GCWaitRT
        Me.GVReturnMt.Name = "GVReturnMt"
        Me.GVReturnMt.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDown
        Me.GVReturnMt.OptionsDetail.AllowOnlyOneMasterRowExpanded = True
        Me.GVReturnMt.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GVReturnMt.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.GVReturnMt.OptionsView.EnableAppearanceEvenRow = True
        Me.GVReturnMt.OptionsView.EnableAppearanceOddRow = True
        Me.GVReturnMt.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GVReturnMt.OptionsView.ShowGroupPanel = False
        Me.GVReturnMt.OptionsView.ShowIndicator = False
        '
        'ColNumMt
        '
        Me.ColNumMt.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColNumMt.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColNumMt.AppearanceCell.Options.UseBackColor = True
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
        'ColCancel
        '
        Me.ColCancel.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColCancel.AppearanceHeader.Options.UseFont = True
        Me.ColCancel.AppearanceHeader.Options.UseTextOptions = True
        Me.ColCancel.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColCancel.Caption = "ยกเลิก"
        Me.ColCancel.ColumnEdit = Me.rptCancel
        Me.ColCancel.MaxWidth = 45
        Me.ColCancel.MinWidth = 45
        Me.ColCancel.Name = "ColCancel"
        Me.ColCancel.Width = 45
        '
        'rptCancel
        '
        Me.rptCancel.AutoHeight = False
        Me.rptCancel.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("rptCancel.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.rptCancel.Name = "rptCancel"
        Me.rptCancel.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'ColShow
        '
        Me.ColShow.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColShow.AppearanceHeader.Options.UseFont = True
        Me.ColShow.AppearanceHeader.Options.UseTextOptions = True
        Me.ColShow.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColShow.Caption = "ข้อมูล"
        Me.ColShow.ColumnEdit = Me.rptShow
        Me.ColShow.MaxWidth = 45
        Me.ColShow.MinWidth = 45
        Me.ColShow.Name = "ColShow"
        Me.ColShow.Width = 45
        '
        'rptShow
        '
        Me.rptShow.AutoHeight = False
        Me.rptShow.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("rptShow.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject2, "", Nothing, Nothing, True)})
        Me.rptShow.Name = "rptShow"
        Me.rptShow.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'ColCheck
        '
        Me.ColCheck.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColCheck.AppearanceCell.Options.UseBackColor = True
        Me.ColCheck.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColCheck.AppearanceHeader.Options.UseFont = True
        Me.ColCheck.AppearanceHeader.Options.UseTextOptions = True
        Me.ColCheck.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColCheck.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColCheck.Caption = "ตรวจสอบ"
        Me.ColCheck.ColumnEdit = Me.rptCheck
        Me.ColCheck.MaxWidth = 45
        Me.ColCheck.MinWidth = 45
        Me.ColCheck.Name = "ColCheck"
        Me.ColCheck.Width = 45
        '
        'rptCheck
        '
        Me.rptCheck.AutoHeight = False
        Me.rptCheck.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("rptCheck.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject3, "", Nothing, Nothing, True)})
        Me.rptCheck.Name = "rptCheck"
        Me.rptCheck.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'ColApv
        '
        Me.ColApv.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColApv.AppearanceCell.Options.UseBackColor = True
        Me.ColApv.AppearanceCell.Options.UseFont = True
        Me.ColApv.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColApv.AppearanceHeader.Options.UseFont = True
        Me.ColApv.AppearanceHeader.Options.UseTextOptions = True
        Me.ColApv.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColApv.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColApv.Caption = "สร้างบิล"
        Me.ColApv.ColumnEdit = Me.rptApv
        Me.ColApv.FieldName = "stBill"
        Me.ColApv.MaxWidth = 45
        Me.ColApv.MinWidth = 45
        Me.ColApv.Name = "ColApv"
        Me.ColApv.OptionsColumn.ReadOnly = True
        Me.ColApv.Visible = True
        Me.ColApv.VisibleIndex = 0
        Me.ColApv.Width = 45
        '
        'rptApv
        '
        Me.rptApv.AutoHeight = False
        Me.rptApv.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("rptApv.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject4, "", Nothing, Nothing, True)})
        Me.rptApv.Name = "rptApv"
        Me.rptApv.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'colCompName
        '
        Me.colCompName.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.colCompName.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.colCompName.AppearanceCell.Options.UseBackColor = True
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
        'ColDateWaitRT
        '
        Me.ColDateWaitRT.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColDateWaitRT.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColDateWaitRT.AppearanceCell.Options.UseBackColor = True
        Me.ColDateWaitRT.AppearanceCell.Options.UseFont = True
        Me.ColDateWaitRT.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColDateWaitRT.AppearanceHeader.Options.UseFont = True
        Me.ColDateWaitRT.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDateWaitRT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDateWaitRT.Caption = "วันที่รับคืน"
        Me.ColDateWaitRT.FieldName = "DateWaitReturn"
        Me.ColDateWaitRT.MinWidth = 100
        Me.ColDateWaitRT.Name = "ColDateWaitRT"
        Me.ColDateWaitRT.OptionsColumn.AllowEdit = False
        Me.ColDateWaitRT.OptionsColumn.ReadOnly = True
        Me.ColDateWaitRT.Visible = True
        Me.ColDateWaitRT.VisibleIndex = 3
        Me.ColDateWaitRT.Width = 100
        '
        'ColDocCode
        '
        Me.ColDocCode.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColDocCode.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColDocCode.AppearanceCell.Options.UseBackColor = True
        Me.ColDocCode.AppearanceCell.Options.UseFont = True
        Me.ColDocCode.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColDocCode.AppearanceHeader.Options.UseFont = True
        Me.ColDocCode.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDocCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDocCode.Caption = "เลขที่รายการ"
        Me.ColDocCode.FieldName = "DocCode"
        Me.ColDocCode.MinWidth = 100
        Me.ColDocCode.Name = "ColDocCode"
        Me.ColDocCode.OptionsColumn.AllowEdit = False
        Me.ColDocCode.OptionsColumn.ReadOnly = True
        Me.ColDocCode.Visible = True
        Me.ColDocCode.VisibleIndex = 5
        Me.ColDocCode.Width = 100
        '
        'ColDocRT
        '
        Me.ColDocRT.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColDocRT.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColDocRT.AppearanceCell.Options.UseBackColor = True
        Me.ColDocRT.AppearanceCell.Options.UseFont = True
        Me.ColDocRT.AppearanceCell.Options.UseTextOptions = True
        Me.ColDocRT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDocRT.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColDocRT.AppearanceHeader.Options.UseFont = True
        Me.ColDocRT.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDocRT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDocRT.Caption = "เลขที่รับคืน"
        Me.ColDocRT.FieldName = "ReturnNo"
        Me.ColDocRT.MinWidth = 100
        Me.ColDocRT.Name = "ColDocRT"
        Me.ColDocRT.OptionsColumn.AllowEdit = False
        Me.ColDocRT.OptionsColumn.ReadOnly = True
        Me.ColDocRT.Visible = True
        Me.ColDocRT.VisibleIndex = 4
        Me.ColDocRT.Width = 100
        '
        'ColPartnerName
        '
        Me.ColPartnerName.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ColPartnerName.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColPartnerName.AppearanceCell.Options.UseBackColor = True
        Me.ColPartnerName.AppearanceCell.Options.UseFont = True
        Me.ColPartnerName.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColPartnerName.AppearanceHeader.Options.UseFont = True
        Me.ColPartnerName.AppearanceHeader.Options.UseTextOptions = True
        Me.ColPartnerName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColPartnerName.Caption = "ชื่อลูกค้า"
        Me.ColPartnerName.FieldName = "PartnerName"
        Me.ColPartnerName.Name = "ColPartnerName"
        Me.ColPartnerName.OptionsColumn.AllowEdit = False
        Me.ColPartnerName.OptionsColumn.ReadOnly = True
        Me.ColPartnerName.Visible = True
        Me.ColPartnerName.VisibleIndex = 6
        Me.ColPartnerName.Width = 246
        '
        'ColPsSaleName
        '
        Me.ColPsSaleName.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColPsSaleName.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColPsSaleName.AppearanceCell.Options.UseBackColor = True
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
        Me.ColPsSaleName.Width = 149
        '
        'ColPsRT
        '
        Me.ColPsRT.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColPsRT.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColPsRT.AppearanceCell.Options.UseBackColor = True
        Me.ColPsRT.AppearanceCell.Options.UseFont = True
        Me.ColPsRT.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColPsRT.AppearanceHeader.Options.UseFont = True
        Me.ColPsRT.AppearanceHeader.Options.UseTextOptions = True
        Me.ColPsRT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColPsRT.Caption = "ผู้รับคืนสินค้า"
        Me.ColPsRT.FieldName = "PsRTName"
        Me.ColPsRT.Name = "ColPsRT"
        Me.ColPsRT.OptionsColumn.AllowEdit = False
        Me.ColPsRT.OptionsColumn.ReadOnly = True
        Me.ColPsRT.Visible = True
        Me.ColPsRT.VisibleIndex = 8
        Me.ColPsRT.Width = 138
        '
        'ColReturnCause
        '
        Me.ColReturnCause.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColReturnCause.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColReturnCause.AppearanceCell.Options.UseBackColor = True
        Me.ColReturnCause.AppearanceCell.Options.UseFont = True
        Me.ColReturnCause.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColReturnCause.AppearanceHeader.Options.UseFont = True
        Me.ColReturnCause.AppearanceHeader.Options.UseTextOptions = True
        Me.ColReturnCause.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColReturnCause.Caption = "สาเหตุการคืน"
        Me.ColReturnCause.FieldName = "ReturnCause"
        Me.ColReturnCause.Name = "ColReturnCause"
        Me.ColReturnCause.OptionsColumn.AllowEdit = False
        Me.ColReturnCause.OptionsColumn.ReadOnly = True
        Me.ColReturnCause.Width = 106
        '
        'ColPsTs
        '
        Me.ColPsTs.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColPsTs.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColPsTs.AppearanceCell.Options.UseBackColor = True
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
        Me.ColPsTs.VisibleIndex = 9
        Me.ColPsTs.Width = 105
        '
        'ColDateTs
        '
        Me.ColDateTs.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColDateTs.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColDateTs.AppearanceCell.Options.UseBackColor = True
        Me.ColDateTs.AppearanceCell.Options.UseFont = True
        Me.ColDateTs.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColDateTs.AppearanceHeader.Options.UseFont = True
        Me.ColDateTs.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDateTs.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDateTs.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColDateTs.Caption = "วันที่ทำรายการ"
        Me.ColDateTs.FieldName = "DateTs"
        Me.ColDateTs.Name = "ColDateTs"
        Me.ColDateTs.OptionsColumn.AllowEdit = False
        Me.ColDateTs.OptionsColumn.ReadOnly = True
        Me.ColDateTs.Visible = True
        Me.ColDateTs.VisibleIndex = 10
        Me.ColDateTs.Width = 99
        '
        'ColidWaitReturn
        '
        Me.ColidWaitReturn.Caption = "idWaitReturn"
        Me.ColidWaitReturn.FieldName = "idWaitReturn"
        Me.ColidWaitReturn.Name = "ColidWaitReturn"
        '
        'idComp
        '
        Me.idComp.Caption = "idComp"
        Me.idComp.FieldName = "idComp"
        Me.idComp.Name = "idComp"
        '
        'CancelNote
        '
        Me.CancelNote.Caption = "CancelNote"
        Me.CancelNote.FieldName = "CancelNote"
        Me.CancelNote.Name = "CancelNote"
        '
        'PsCancel
        '
        Me.PsCancel.Caption = "PsCancel"
        Me.PsCancel.FieldName = "PsCancel"
        Me.PsCancel.Name = "PsCancel"
        '
        'rptButton
        '
        Me.rptButton.AutoHeight = False
        Me.rptButton.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.rptButton.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", "0", 0), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", "1", 1)})
        Me.rptButton.Name = "rptButton"
        Me.rptButton.SmallImages = Me.ImageList1
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "adddoc.png")
        Me.ImageList1.Images.SetKeyName(1, "Computer-Edit.png")
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel4.Controls.Add(Me.Panel3)
        Me.Panel4.Controls.Add(Me.Panel2)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 71)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1184, 28)
        Me.Panel4.TabIndex = 641
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
        Me.txtCount.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCount.ForeColor = System.Drawing.Color.Lime
        Me.txtCount.Location = New System.Drawing.Point(111, 2)
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
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnFind)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(114, 28)
        Me.Panel2.TabIndex = 588
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
        Me.PanelControl1.TabIndex = 723
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
        Me.rdbDateReturn.Size = New System.Drawing.Size(74, 18)
        Me.rdbDateReturn.TabIndex = 600
        Me.rdbDateReturn.Text = "วันที่รับคืน"
        Me.rdbDateReturn.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.dtpMonth)
        Me.GroupBox2.Controls.Add(Me.rdbMonth)
        Me.GroupBox2.Controls.Add(Me.dtpReturnE)
        Me.GroupBox2.Controls.Add(Me.dtpYear)
        Me.GroupBox2.Controls.Add(Me.rdbYear)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.rdbDate)
        Me.GroupBox2.Controls.Add(Me.dtpReturnS)
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
        'dtpReturnE
        '
        Me.dtpReturnE.CustomFormat = "ddMMMMyyyy"
        Me.dtpReturnE.Enabled = False
        Me.dtpReturnE.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpReturnE.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpReturnE.Location = New System.Drawing.Point(241, 21)
        Me.dtpReturnE.MinDate = New Date(1757, 1, 1, 0, 0, 0, 0)
        Me.dtpReturnE.Name = "dtpReturnE"
        Me.dtpReturnE.Size = New System.Drawing.Size(144, 22)
        Me.dtpReturnE.TabIndex = 607
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
        'dtpReturnS
        '
        Me.dtpReturnS.CustomFormat = "ddMMMMyyyy"
        Me.dtpReturnS.Enabled = False
        Me.dtpReturnS.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpReturnS.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpReturnS.Location = New System.Drawing.Point(62, 21)
        Me.dtpReturnS.MinDate = New Date(1757, 1, 1, 0, 0, 0, 0)
        Me.dtpReturnS.Name = "dtpReturnS"
        Me.dtpReturnS.Size = New System.Drawing.Size(147, 22)
        Me.dtpReturnS.TabIndex = 601
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
        Me.LabelControl9.TabIndex = 739
        Me.LabelControl9.Text = "รายการรับคืนรอสร้างบิล"
        '
        'frmCrateSaleRTData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1184, 551)
        Me.Controls.Add(Me.GCWaitRT)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCrateSaleRTData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "รายการรอสร้างบิลรับคืนวัสดุและสินค้า"
        CType(Me.GVReturnDt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCWaitRT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVReturnMt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptCancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptShow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptCheck, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptApv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnFind As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdbDateTs As RadioButton
    Friend WithEvents rdbDateReturn As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dtpMonth As DateTimePicker
    Friend WithEvents rdbMonth As RadioButton
    Friend WithEvents dtpReturnE As DateTimePicker
    Friend WithEvents dtpYear As DateTimePicker
    Friend WithEvents rdbYear As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents rdbDate As RadioButton
    Friend WithEvents dtpReturnS As DateTimePicker
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtCount As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GCWaitRT As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVReturnDt As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColNum As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColBoxNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColLotno As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColProductName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColAmtRT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColUnitName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColWareHouse As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColRtCause As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColHumid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColFLName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colidInvMain As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GVReturnMt As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColNumMt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColCancel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rptCancel As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents ColShow As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rptShow As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents ColCheck As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rptCheck As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents colCompName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDateWaitRT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDocCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDocRT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColPartnerName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColPsSaleName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColPsRT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColReturnCause As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColPsTs As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDateTs As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColidWaitReturn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents idComp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CancelNote As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PsCancel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColApv As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rptApv As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents rptButton As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
End Class
