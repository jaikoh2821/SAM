<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmSlSaleGroupMt
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
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim GridFormatRule1 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleExpression1 As DevExpress.XtraEditors.FormatConditionRuleExpression = New DevExpress.XtraEditors.FormatConditionRuleExpression()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSlSaleGroupMt))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.GVSlGroupDt = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColNumDt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColidSaleMt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDocRef = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColProductName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColUnit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCSaleGroup = New DevExpress.XtraGrid.GridControl()
        Me.GVSlGroupMt = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColNum = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColView = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rptShow = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.ColidSale = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCompCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDocRef1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDateSale1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColCusName1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColTotal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColTotalNet1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColPsTs1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDateTs1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColNote1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColidComp = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColidPsCancel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColCompName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColPsCancel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColCancelNote = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColidJobMt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.gbDateOrder = New System.Windows.Forms.GroupBox()
        Me.dtpYear = New System.Windows.Forms.DateTimePicker()
        Me.rdbYear = New System.Windows.Forms.RadioButton()
        Me.dtpMonth = New System.Windows.Forms.DateTimePicker()
        Me.rdbMonth = New System.Windows.Forms.RadioButton()
        Me.rdbDateTs = New System.Windows.Forms.RadioButton()
        Me.dtpDateStart = New System.Windows.Forms.DateTimePicker()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.dtpDateNow = New System.Windows.Forms.DateTimePicker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnNew = New DevExpress.XtraEditors.SimpleButton()
        Me.btnRefresh = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.GVSlGroupDt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCSaleGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVSlGroupMt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptShow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.gbDateOrder.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GVSlGroupDt
        '
        Me.GVSlGroupDt.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVSlGroupDt.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVSlGroupDt.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GVSlGroupDt.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVSlGroupDt.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GVSlGroupDt.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GVSlGroupDt.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GVSlGroupDt.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GVSlGroupDt.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GVSlGroupDt.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVSlGroupDt.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GVSlGroupDt.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GVSlGroupDt.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVSlGroupDt.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.GVSlGroupDt.Appearance.Empty.Options.UseBackColor = True
        Me.GVSlGroupDt.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.GVSlGroupDt.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.GVSlGroupDt.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GVSlGroupDt.Appearance.EvenRow.Options.UseBackColor = True
        Me.GVSlGroupDt.Appearance.EvenRow.Options.UseBorderColor = True
        Me.GVSlGroupDt.Appearance.EvenRow.Options.UseForeColor = True
        Me.GVSlGroupDt.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVSlGroupDt.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVSlGroupDt.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GVSlGroupDt.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GVSlGroupDt.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GVSlGroupDt.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GVSlGroupDt.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVSlGroupDt.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.GVSlGroupDt.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVSlGroupDt.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVSlGroupDt.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GVSlGroupDt.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.GVSlGroupDt.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVSlGroupDt.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.GVSlGroupDt.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GVSlGroupDt.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVSlGroupDt.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVSlGroupDt.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.GVSlGroupDt.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.GVSlGroupDt.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVSlGroupDt.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVSlGroupDt.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVSlGroupDt.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVSlGroupDt.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVSlGroupDt.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVSlGroupDt.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVSlGroupDt.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GVSlGroupDt.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.GVSlGroupDt.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.GVSlGroupDt.Appearance.GroupButton.Options.UseBackColor = True
        Me.GVSlGroupDt.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GVSlGroupDt.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GVSlGroupDt.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GVSlGroupDt.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GVSlGroupDt.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVSlGroupDt.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GVSlGroupDt.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GVSlGroupDt.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVSlGroupDt.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.GVSlGroupDt.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.GVSlGroupDt.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GVSlGroupDt.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVSlGroupDt.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GVSlGroupDt.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GVSlGroupDt.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GVSlGroupDt.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVSlGroupDt.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GVSlGroupDt.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVSlGroupDt.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GVSlGroupDt.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GVSlGroupDt.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GVSlGroupDt.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVSlGroupDt.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVSlGroupDt.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GVSlGroupDt.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.GVSlGroupDt.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.GVSlGroupDt.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVSlGroupDt.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVSlGroupDt.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.GVSlGroupDt.Appearance.HorzLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.GVSlGroupDt.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVSlGroupDt.Appearance.HorzLine.Options.UseBorderColor = True
        Me.GVSlGroupDt.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVSlGroupDt.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVSlGroupDt.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GVSlGroupDt.Appearance.OddRow.Options.UseBackColor = True
        Me.GVSlGroupDt.Appearance.OddRow.Options.UseBorderColor = True
        Me.GVSlGroupDt.Appearance.OddRow.Options.UseForeColor = True
        Me.GVSlGroupDt.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.GVSlGroupDt.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.GVSlGroupDt.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.GVSlGroupDt.Appearance.Preview.Options.UseBackColor = True
        Me.GVSlGroupDt.Appearance.Preview.Options.UseFont = True
        Me.GVSlGroupDt.Appearance.Preview.Options.UseForeColor = True
        Me.GVSlGroupDt.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVSlGroupDt.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GVSlGroupDt.Appearance.Row.Options.UseBackColor = True
        Me.GVSlGroupDt.Appearance.Row.Options.UseForeColor = True
        Me.GVSlGroupDt.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVSlGroupDt.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.GVSlGroupDt.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GVSlGroupDt.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.GVSlGroupDt.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.GVSlGroupDt.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVSlGroupDt.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GVSlGroupDt.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GVSlGroupDt.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GVSlGroupDt.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.GVSlGroupDt.Appearance.VertLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.GVSlGroupDt.Appearance.VertLine.Options.UseBackColor = True
        Me.GVSlGroupDt.Appearance.VertLine.Options.UseBorderColor = True
        Me.GVSlGroupDt.ColumnPanelRowHeight = 25
        Me.GVSlGroupDt.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColNumDt, Me.ColidSaleMt, Me.ColDocRef, Me.ColProductName, Me.ColPrice, Me.ColUnit})
        Me.GVSlGroupDt.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GVSlGroupDt.GridControl = Me.GCSaleGroup
        Me.GVSlGroupDt.Name = "GVSlGroupDt"
        Me.GVSlGroupDt.OptionsView.EnableAppearanceEvenRow = True
        Me.GVSlGroupDt.OptionsView.EnableAppearanceOddRow = True
        Me.GVSlGroupDt.OptionsView.ShowGroupPanel = False
        Me.GVSlGroupDt.OptionsView.ShowIndicator = False
        Me.GVSlGroupDt.PaintStyleName = "MixedXP"
        Me.GVSlGroupDt.RowHeight = 25
        Me.GVSlGroupDt.ViewCaption = "รายการใบแจ้งหนี้ที่ถูกรวบรวม"
        '
        'ColNumDt
        '
        Me.ColNumDt.AppearanceCell.BackColor = System.Drawing.Color.Transparent
        Me.ColNumDt.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColNumDt.AppearanceCell.Options.UseBackColor = True
        Me.ColNumDt.AppearanceCell.Options.UseFont = True
        Me.ColNumDt.AppearanceCell.Options.UseTextOptions = True
        Me.ColNumDt.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColNumDt.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColNumDt.AppearanceHeader.Options.UseFont = True
        Me.ColNumDt.AppearanceHeader.Options.UseTextOptions = True
        Me.ColNumDt.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColNumDt.Caption = "ลำดับ"
        Me.ColNumDt.Name = "ColNumDt"
        Me.ColNumDt.OptionsColumn.AllowEdit = False
        Me.ColNumDt.OptionsColumn.ReadOnly = True
        Me.ColNumDt.Visible = True
        Me.ColNumDt.VisibleIndex = 0
        Me.ColNumDt.Width = 118
        '
        'ColidSaleMt
        '
        Me.ColidSaleMt.AppearanceCell.BackColor = System.Drawing.Color.Transparent
        Me.ColidSaleMt.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColidSaleMt.AppearanceCell.Options.UseBackColor = True
        Me.ColidSaleMt.AppearanceCell.Options.UseFont = True
        Me.ColidSaleMt.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColidSaleMt.AppearanceHeader.Options.UseFont = True
        Me.ColidSaleMt.Caption = "idSaleDt"
        Me.ColidSaleMt.FieldName = "idSale"
        Me.ColidSaleMt.Name = "ColidSaleMt"
        Me.ColidSaleMt.OptionsColumn.AllowEdit = False
        Me.ColidSaleMt.OptionsColumn.ReadOnly = True
        '
        'ColDocRef
        '
        Me.ColDocRef.AppearanceCell.BackColor = System.Drawing.Color.Transparent
        Me.ColDocRef.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColDocRef.AppearanceCell.Options.UseBackColor = True
        Me.ColDocRef.AppearanceCell.Options.UseFont = True
        Me.ColDocRef.AppearanceCell.Options.UseTextOptions = True
        Me.ColDocRef.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDocRef.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColDocRef.AppearanceHeader.Options.UseFont = True
        Me.ColDocRef.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDocRef.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDocRef.Caption = "เลขที่ใบแจ้งหนี้"
        Me.ColDocRef.FieldName = "DocRef"
        Me.ColDocRef.Name = "ColDocRef"
        Me.ColDocRef.OptionsColumn.AllowEdit = False
        Me.ColDocRef.OptionsColumn.ReadOnly = True
        Me.ColDocRef.Visible = True
        Me.ColDocRef.VisibleIndex = 1
        Me.ColDocRef.Width = 153
        '
        'ColProductName
        '
        Me.ColProductName.AppearanceCell.BackColor = System.Drawing.Color.Transparent
        Me.ColProductName.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColProductName.AppearanceCell.Options.UseBackColor = True
        Me.ColProductName.AppearanceCell.Options.UseFont = True
        Me.ColProductName.AppearanceCell.Options.UseTextOptions = True
        Me.ColProductName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.ColProductName.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColProductName.AppearanceHeader.Options.UseFont = True
        Me.ColProductName.AppearanceHeader.Options.UseTextOptions = True
        Me.ColProductName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColProductName.Caption = "รายละเอียด"
        Me.ColProductName.FieldName = "PartnerNameBill"
        Me.ColProductName.Name = "ColProductName"
        Me.ColProductName.OptionsColumn.AllowEdit = False
        Me.ColProductName.OptionsColumn.ReadOnly = True
        Me.ColProductName.Visible = True
        Me.ColProductName.VisibleIndex = 2
        Me.ColProductName.Width = 1009
        '
        'ColPrice
        '
        Me.ColPrice.AppearanceCell.BackColor = System.Drawing.Color.Transparent
        Me.ColPrice.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColPrice.AppearanceCell.Options.UseBackColor = True
        Me.ColPrice.AppearanceCell.Options.UseFont = True
        Me.ColPrice.AppearanceCell.Options.UseTextOptions = True
        Me.ColPrice.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ColPrice.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColPrice.AppearanceHeader.Options.UseFont = True
        Me.ColPrice.AppearanceHeader.Options.UseTextOptions = True
        Me.ColPrice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColPrice.Caption = "จำนวนเงิน"
        Me.ColPrice.DisplayFormat.FormatString = "#,##0.00##"
        Me.ColPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColPrice.FieldName = "TotalBill"
        Me.ColPrice.Name = "ColPrice"
        Me.ColPrice.OptionsColumn.AllowEdit = False
        Me.ColPrice.OptionsColumn.ReadOnly = True
        Me.ColPrice.Visible = True
        Me.ColPrice.VisibleIndex = 3
        Me.ColPrice.Width = 204
        '
        'ColUnit
        '
        Me.ColUnit.AppearanceCell.BackColor = System.Drawing.Color.Transparent
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
        Me.ColUnit.VisibleIndex = 4
        Me.ColUnit.Width = 164
        '
        'GCSaleGroup
        '
        Me.GCSaleGroup.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode1.LevelTemplate = Me.GVSlGroupDt
        GridLevelNode1.RelationName = "Level1"
        Me.GCSaleGroup.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.GCSaleGroup.Location = New System.Drawing.Point(0, 123)
        Me.GCSaleGroup.MainView = Me.GVSlGroupMt
        Me.GCSaleGroup.Name = "GCSaleGroup"
        Me.GCSaleGroup.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rptShow})
        Me.GCSaleGroup.Size = New System.Drawing.Size(1184, 428)
        Me.GCSaleGroup.TabIndex = 726
        Me.GCSaleGroup.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVSlGroupMt, Me.GVSlGroupDt})
        '
        'GVSlGroupMt
        '
        Me.GVSlGroupMt.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVSlGroupMt.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVSlGroupMt.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GVSlGroupMt.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVSlGroupMt.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GVSlGroupMt.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GVSlGroupMt.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GVSlGroupMt.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GVSlGroupMt.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GVSlGroupMt.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVSlGroupMt.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GVSlGroupMt.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GVSlGroupMt.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVSlGroupMt.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.GVSlGroupMt.Appearance.Empty.Options.UseBackColor = True
        Me.GVSlGroupMt.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.GVSlGroupMt.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.GVSlGroupMt.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GVSlGroupMt.Appearance.EvenRow.Options.UseBackColor = True
        Me.GVSlGroupMt.Appearance.EvenRow.Options.UseBorderColor = True
        Me.GVSlGroupMt.Appearance.EvenRow.Options.UseForeColor = True
        Me.GVSlGroupMt.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVSlGroupMt.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVSlGroupMt.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GVSlGroupMt.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GVSlGroupMt.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GVSlGroupMt.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GVSlGroupMt.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVSlGroupMt.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.GVSlGroupMt.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVSlGroupMt.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVSlGroupMt.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GVSlGroupMt.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.GVSlGroupMt.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVSlGroupMt.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.GVSlGroupMt.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GVSlGroupMt.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVSlGroupMt.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVSlGroupMt.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.GVSlGroupMt.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.GVSlGroupMt.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVSlGroupMt.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVSlGroupMt.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVSlGroupMt.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVSlGroupMt.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GVSlGroupMt.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVSlGroupMt.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVSlGroupMt.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVSlGroupMt.Appearance.FooterPanel.Options.UseFont = True
        Me.GVSlGroupMt.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GVSlGroupMt.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.GVSlGroupMt.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.GVSlGroupMt.Appearance.GroupButton.Options.UseBackColor = True
        Me.GVSlGroupMt.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GVSlGroupMt.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GVSlGroupMt.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GVSlGroupMt.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GVSlGroupMt.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVSlGroupMt.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GVSlGroupMt.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GVSlGroupMt.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVSlGroupMt.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.GVSlGroupMt.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.GVSlGroupMt.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GVSlGroupMt.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVSlGroupMt.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GVSlGroupMt.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GVSlGroupMt.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GVSlGroupMt.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVSlGroupMt.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GVSlGroupMt.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVSlGroupMt.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GVSlGroupMt.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GVSlGroupMt.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GVSlGroupMt.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVSlGroupMt.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVSlGroupMt.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GVSlGroupMt.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.GVSlGroupMt.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.GVSlGroupMt.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVSlGroupMt.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVSlGroupMt.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.GVSlGroupMt.Appearance.HorzLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.GVSlGroupMt.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVSlGroupMt.Appearance.HorzLine.Options.UseBorderColor = True
        Me.GVSlGroupMt.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVSlGroupMt.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVSlGroupMt.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GVSlGroupMt.Appearance.OddRow.Options.UseBackColor = True
        Me.GVSlGroupMt.Appearance.OddRow.Options.UseBorderColor = True
        Me.GVSlGroupMt.Appearance.OddRow.Options.UseForeColor = True
        Me.GVSlGroupMt.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.GVSlGroupMt.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.GVSlGroupMt.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.GVSlGroupMt.Appearance.Preview.Options.UseBackColor = True
        Me.GVSlGroupMt.Appearance.Preview.Options.UseFont = True
        Me.GVSlGroupMt.Appearance.Preview.Options.UseForeColor = True
        Me.GVSlGroupMt.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVSlGroupMt.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GVSlGroupMt.Appearance.Row.Options.UseBackColor = True
        Me.GVSlGroupMt.Appearance.Row.Options.UseForeColor = True
        Me.GVSlGroupMt.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVSlGroupMt.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.GVSlGroupMt.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GVSlGroupMt.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.GVSlGroupMt.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.GVSlGroupMt.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVSlGroupMt.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GVSlGroupMt.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GVSlGroupMt.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GVSlGroupMt.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.GVSlGroupMt.Appearance.VertLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.GVSlGroupMt.Appearance.VertLine.Options.UseBackColor = True
        Me.GVSlGroupMt.Appearance.VertLine.Options.UseBorderColor = True
        Me.GVSlGroupMt.ColumnPanelRowHeight = 35
        Me.GVSlGroupMt.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColNum, Me.ColView, Me.ColidSale, Me.colCompCode, Me.ColDocRef1, Me.ColDateSale1, Me.ColCusName1, Me.ColTotal, Me.ColTotalNet1, Me.ColPsTs1, Me.ColDateTs1, Me.ColNote1, Me.ColidComp, Me.ColidPsCancel, Me.ColCompName, Me.ColPsCancel, Me.ColCancelNote, Me.ColidJobMt})
        Me.GVSlGroupMt.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        GridFormatRule1.Name = "stWaitCut"
        FormatConditionRuleExpression1.Expression = "[stWaitCut] = 'Draft'"
        FormatConditionRuleExpression1.PredefinedName = "Red Text"
        GridFormatRule1.Rule = FormatConditionRuleExpression1
        Me.GVSlGroupMt.FormatRules.Add(GridFormatRule1)
        Me.GVSlGroupMt.GridControl = Me.GCSaleGroup
        Me.GVSlGroupMt.Name = "GVSlGroupMt"
        Me.GVSlGroupMt.OptionsView.EnableAppearanceEvenRow = True
        Me.GVSlGroupMt.OptionsView.EnableAppearanceOddRow = True
        Me.GVSlGroupMt.OptionsView.RowAutoHeight = True
        Me.GVSlGroupMt.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GVSlGroupMt.OptionsView.ShowFooter = True
        Me.GVSlGroupMt.OptionsView.ShowGroupPanel = False
        Me.GVSlGroupMt.OptionsView.ShowIndicator = False
        Me.GVSlGroupMt.PaintStyleName = "MixedXP"
        Me.GVSlGroupMt.RowHeight = 25
        '
        'ColNum
        '
        Me.ColNum.AppearanceCell.BackColor = System.Drawing.Color.Transparent
        Me.ColNum.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColNum.AppearanceCell.Options.UseBackColor = True
        Me.ColNum.AppearanceCell.Options.UseFont = True
        Me.ColNum.AppearanceCell.Options.UseTextOptions = True
        Me.ColNum.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColNum.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColNum.AppearanceHeader.Options.UseFont = True
        Me.ColNum.AppearanceHeader.Options.UseTextOptions = True
        Me.ColNum.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColNum.Caption = "ลำดับ"
        Me.ColNum.MaxWidth = 45
        Me.ColNum.MinWidth = 45
        Me.ColNum.Name = "ColNum"
        Me.ColNum.OptionsColumn.AllowEdit = False
        Me.ColNum.OptionsColumn.ReadOnly = True
        Me.ColNum.Visible = True
        Me.ColNum.VisibleIndex = 0
        Me.ColNum.Width = 45
        '
        'ColView
        '
        Me.ColView.AppearanceCell.BackColor = System.Drawing.Color.Transparent
        Me.ColView.AppearanceCell.Options.UseBackColor = True
        Me.ColView.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColView.AppearanceHeader.Options.UseFont = True
        Me.ColView.AppearanceHeader.Options.UseTextOptions = True
        Me.ColView.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColView.Caption = "ข้อมูล"
        Me.ColView.ColumnEdit = Me.rptShow
        Me.ColView.MaxWidth = 45
        Me.ColView.MinWidth = 45
        Me.ColView.Name = "ColView"
        Me.ColView.Visible = True
        Me.ColView.VisibleIndex = 1
        Me.ColView.Width = 45
        '
        'rptShow
        '
        Me.rptShow.AutoHeight = False
        Me.rptShow.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("rptShow.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.rptShow.Name = "rptShow"
        Me.rptShow.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'ColidSale
        '
        Me.ColidSale.AppearanceCell.BackColor = System.Drawing.Color.Transparent
        Me.ColidSale.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColidSale.AppearanceCell.Options.UseBackColor = True
        Me.ColidSale.AppearanceCell.Options.UseFont = True
        Me.ColidSale.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColidSale.AppearanceHeader.Options.UseFont = True
        Me.ColidSale.AppearanceHeader.Options.UseTextOptions = True
        Me.ColidSale.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColidSale.Caption = "idSale"
        Me.ColidSale.FieldName = "idSale"
        Me.ColidSale.Name = "ColidSale"
        '
        'colCompCode
        '
        Me.colCompCode.AppearanceCell.BackColor = System.Drawing.Color.Transparent
        Me.colCompCode.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.colCompCode.AppearanceCell.Options.UseBackColor = True
        Me.colCompCode.AppearanceCell.Options.UseFont = True
        Me.colCompCode.AppearanceCell.Options.UseTextOptions = True
        Me.colCompCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCompCode.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.colCompCode.AppearanceHeader.Options.UseFont = True
        Me.colCompCode.AppearanceHeader.Options.UseTextOptions = True
        Me.colCompCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCompCode.Caption = "บริษัท"
        Me.colCompCode.FieldName = "CompCode"
        Me.colCompCode.MaxWidth = 45
        Me.colCompCode.MinWidth = 45
        Me.colCompCode.Name = "colCompCode"
        Me.colCompCode.OptionsColumn.AllowEdit = False
        Me.colCompCode.OptionsColumn.ReadOnly = True
        Me.colCompCode.Visible = True
        Me.colCompCode.VisibleIndex = 2
        Me.colCompCode.Width = 45
        '
        'ColDocRef1
        '
        Me.ColDocRef1.AppearanceCell.BackColor = System.Drawing.Color.Transparent
        Me.ColDocRef1.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColDocRef1.AppearanceCell.Options.UseBackColor = True
        Me.ColDocRef1.AppearanceCell.Options.UseFont = True
        Me.ColDocRef1.AppearanceCell.Options.UseTextOptions = True
        Me.ColDocRef1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDocRef1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColDocRef1.AppearanceHeader.Options.UseFont = True
        Me.ColDocRef1.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDocRef1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDocRef1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColDocRef1.Caption = "เลขที่เอกสารรวบรวมใบแจ้งหนี้"
        Me.ColDocRef1.FieldName = "DocCodeGroup"
        Me.ColDocRef1.Name = "ColDocRef1"
        Me.ColDocRef1.OptionsColumn.AllowEdit = False
        Me.ColDocRef1.OptionsColumn.ReadOnly = True
        Me.ColDocRef1.Visible = True
        Me.ColDocRef1.VisibleIndex = 3
        Me.ColDocRef1.Width = 183
        '
        'ColDateSale1
        '
        Me.ColDateSale1.AppearanceCell.BackColor = System.Drawing.Color.Transparent
        Me.ColDateSale1.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColDateSale1.AppearanceCell.Options.UseBackColor = True
        Me.ColDateSale1.AppearanceCell.Options.UseFont = True
        Me.ColDateSale1.AppearanceCell.Options.UseTextOptions = True
        Me.ColDateSale1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDateSale1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColDateSale1.AppearanceHeader.Options.UseFont = True
        Me.ColDateSale1.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDateSale1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDateSale1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColDateSale1.Caption = "วันที่รวบรวมใบแจ้งหนี้"
        Me.ColDateSale1.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.ColDateSale1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.ColDateSale1.FieldName = "DateDocGroup"
        Me.ColDateSale1.Name = "ColDateSale1"
        Me.ColDateSale1.OptionsColumn.AllowEdit = False
        Me.ColDateSale1.OptionsColumn.ReadOnly = True
        Me.ColDateSale1.Visible = True
        Me.ColDateSale1.VisibleIndex = 4
        Me.ColDateSale1.Width = 124
        '
        'ColCusName1
        '
        Me.ColCusName1.AppearanceCell.BackColor = System.Drawing.Color.Transparent
        Me.ColCusName1.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColCusName1.AppearanceCell.Options.UseBackColor = True
        Me.ColCusName1.AppearanceCell.Options.UseFont = True
        Me.ColCusName1.AppearanceCell.Options.UseTextOptions = True
        Me.ColCusName1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.ColCusName1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColCusName1.AppearanceHeader.Options.UseFont = True
        Me.ColCusName1.AppearanceHeader.Options.UseTextOptions = True
        Me.ColCusName1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColCusName1.Caption = "ชื่อลูกค้า (กลุ่มที่รวบรวมใบแจ้งหนี้)"
        Me.ColCusName1.CustomizationCaption = " "
        Me.ColCusName1.FieldName = "PartnerNameGroup"
        Me.ColCusName1.Name = "ColCusName1"
        Me.ColCusName1.OptionsColumn.AllowEdit = False
        Me.ColCusName1.OptionsColumn.ReadOnly = True
        Me.ColCusName1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom, "PartnerNameGroup", "รวมเป็นเงินทั้งหมด")})
        Me.ColCusName1.Visible = True
        Me.ColCusName1.VisibleIndex = 5
        Me.ColCusName1.Width = 377
        '
        'ColTotal
        '
        Me.ColTotal.AppearanceCell.BackColor = System.Drawing.Color.Transparent
        Me.ColTotal.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColTotal.AppearanceCell.Options.UseBackColor = True
        Me.ColTotal.AppearanceCell.Options.UseFont = True
        Me.ColTotal.AppearanceCell.Options.UseTextOptions = True
        Me.ColTotal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ColTotal.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColTotal.AppearanceHeader.Options.UseFont = True
        Me.ColTotal.AppearanceHeader.Options.UseTextOptions = True
        Me.ColTotal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColTotal.Caption = "รวมราคา"
        Me.ColTotal.DisplayFormat.FormatString = "#,##0.00##"
        Me.ColTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColTotal.FieldName = "Total"
        Me.ColTotal.Name = "ColTotal"
        Me.ColTotal.OptionsColumn.AllowEdit = False
        Me.ColTotal.OptionsColumn.ReadOnly = True
        Me.ColTotal.Width = 90
        '
        'ColTotalNet1
        '
        Me.ColTotalNet1.AppearanceCell.BackColor = System.Drawing.Color.Transparent
        Me.ColTotalNet1.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColTotalNet1.AppearanceCell.Options.UseBackColor = True
        Me.ColTotalNet1.AppearanceCell.Options.UseFont = True
        Me.ColTotalNet1.AppearanceCell.Options.UseTextOptions = True
        Me.ColTotalNet1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ColTotalNet1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColTotalNet1.AppearanceHeader.Options.UseFont = True
        Me.ColTotalNet1.AppearanceHeader.Options.UseTextOptions = True
        Me.ColTotalNet1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColTotalNet1.Caption = "รวมสุทธิ"
        Me.ColTotalNet1.DisplayFormat.FormatString = "#,##0.00##"
        Me.ColTotalNet1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColTotalNet1.FieldName = "TotalNet"
        Me.ColTotalNet1.Name = "ColTotalNet1"
        Me.ColTotalNet1.OptionsColumn.AllowEdit = False
        Me.ColTotalNet1.OptionsColumn.ReadOnly = True
        Me.ColTotalNet1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalNet", "{0:#,##0.00##}")})
        Me.ColTotalNet1.Visible = True
        Me.ColTotalNet1.VisibleIndex = 6
        Me.ColTotalNet1.Width = 154
        '
        'ColPsTs1
        '
        Me.ColPsTs1.AppearanceCell.BackColor = System.Drawing.Color.Transparent
        Me.ColPsTs1.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColPsTs1.AppearanceCell.Options.UseBackColor = True
        Me.ColPsTs1.AppearanceCell.Options.UseFont = True
        Me.ColPsTs1.AppearanceCell.Options.UseTextOptions = True
        Me.ColPsTs1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.ColPsTs1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColPsTs1.AppearanceHeader.Options.UseFont = True
        Me.ColPsTs1.AppearanceHeader.Options.UseTextOptions = True
        Me.ColPsTs1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColPsTs1.Caption = "ผู้ทำรายการ"
        Me.ColPsTs1.FieldName = "PsTs"
        Me.ColPsTs1.Name = "ColPsTs1"
        Me.ColPsTs1.OptionsColumn.AllowEdit = False
        Me.ColPsTs1.OptionsColumn.ReadOnly = True
        Me.ColPsTs1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom, "PsTs", "บาท")})
        Me.ColPsTs1.Visible = True
        Me.ColPsTs1.VisibleIndex = 7
        Me.ColPsTs1.Width = 202
        '
        'ColDateTs1
        '
        Me.ColDateTs1.AppearanceCell.BackColor = System.Drawing.Color.Transparent
        Me.ColDateTs1.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColDateTs1.AppearanceCell.Options.UseBackColor = True
        Me.ColDateTs1.AppearanceCell.Options.UseFont = True
        Me.ColDateTs1.AppearanceCell.Options.UseTextOptions = True
        Me.ColDateTs1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDateTs1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColDateTs1.AppearanceHeader.Options.UseFont = True
        Me.ColDateTs1.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDateTs1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDateTs1.Caption = "วันที่ทำรายการ"
        Me.ColDateTs1.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.ColDateTs1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.ColDateTs1.FieldName = "DateTs"
        Me.ColDateTs1.Name = "ColDateTs1"
        Me.ColDateTs1.OptionsColumn.AllowEdit = False
        Me.ColDateTs1.OptionsColumn.ReadOnly = True
        Me.ColDateTs1.Visible = True
        Me.ColDateTs1.VisibleIndex = 8
        Me.ColDateTs1.Width = 132
        '
        'ColNote1
        '
        Me.ColNote1.AppearanceCell.BackColor = System.Drawing.Color.Transparent
        Me.ColNote1.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColNote1.AppearanceCell.Options.UseBackColor = True
        Me.ColNote1.AppearanceCell.Options.UseFont = True
        Me.ColNote1.AppearanceCell.Options.UseTextOptions = True
        Me.ColNote1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.ColNote1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColNote1.AppearanceHeader.Options.UseFont = True
        Me.ColNote1.AppearanceHeader.Options.UseTextOptions = True
        Me.ColNote1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColNote1.Caption = "หมายเหตุ"
        Me.ColNote1.FieldName = "Note"
        Me.ColNote1.Name = "ColNote1"
        Me.ColNote1.OptionsColumn.AllowEdit = False
        Me.ColNote1.OptionsColumn.ReadOnly = True
        Me.ColNote1.Visible = True
        Me.ColNote1.VisibleIndex = 9
        Me.ColNote1.Width = 341
        '
        'ColidComp
        '
        Me.ColidComp.AppearanceCell.BackColor = System.Drawing.Color.Transparent
        Me.ColidComp.AppearanceCell.Options.UseBackColor = True
        Me.ColidComp.Caption = "idComp"
        Me.ColidComp.FieldName = "idComp"
        Me.ColidComp.Name = "ColidComp"
        '
        'ColidPsCancel
        '
        Me.ColidPsCancel.AppearanceCell.BackColor = System.Drawing.Color.Transparent
        Me.ColidPsCancel.AppearanceCell.Options.UseBackColor = True
        Me.ColidPsCancel.Caption = "idPsCancel"
        Me.ColidPsCancel.FieldName = "idPsCancel"
        Me.ColidPsCancel.Name = "ColidPsCancel"
        '
        'ColCompName
        '
        Me.ColCompName.AppearanceCell.BackColor = System.Drawing.Color.Transparent
        Me.ColCompName.AppearanceCell.Options.UseBackColor = True
        Me.ColCompName.Caption = "CompName"
        Me.ColCompName.FieldName = "CompanyName"
        Me.ColCompName.Name = "ColCompName"
        '
        'ColPsCancel
        '
        Me.ColPsCancel.AppearanceCell.BackColor = System.Drawing.Color.Transparent
        Me.ColPsCancel.AppearanceCell.Options.UseBackColor = True
        Me.ColPsCancel.Caption = "PsCancel"
        Me.ColPsCancel.FieldName = "PsCancel"
        Me.ColPsCancel.Name = "ColPsCancel"
        '
        'ColCancelNote
        '
        Me.ColCancelNote.AppearanceCell.BackColor = System.Drawing.Color.Transparent
        Me.ColCancelNote.AppearanceCell.Options.UseBackColor = True
        Me.ColCancelNote.Caption = "CancelNote"
        Me.ColCancelNote.FieldName = "CancelNote"
        Me.ColCancelNote.Name = "ColCancelNote"
        '
        'ColidJobMt
        '
        Me.ColidJobMt.AppearanceCell.BackColor = System.Drawing.Color.Transparent
        Me.ColidJobMt.AppearanceCell.Options.UseBackColor = True
        Me.ColidJobMt.Caption = "idJobMt"
        Me.ColidJobMt.FieldName = "idJobMt"
        Me.ColidJobMt.Name = "ColidJobMt"
        '
        'PanelControl1
        '
        Me.PanelControl1.Appearance.BackColor = System.Drawing.Color.Lavender
        Me.PanelControl1.Appearance.BackColor2 = System.Drawing.Color.LightSteelBlue
        Me.PanelControl1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.PanelControl1.Appearance.Options.UseBackColor = True
        Me.PanelControl1.Appearance.Options.UseFont = True
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.gbDateOrder)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1184, 88)
        Me.PanelControl1.TabIndex = 724
        '
        'gbDateOrder
        '
        Me.gbDateOrder.BackColor = System.Drawing.Color.Transparent
        Me.gbDateOrder.Controls.Add(Me.dtpYear)
        Me.gbDateOrder.Controls.Add(Me.rdbYear)
        Me.gbDateOrder.Controls.Add(Me.dtpMonth)
        Me.gbDateOrder.Controls.Add(Me.rdbMonth)
        Me.gbDateOrder.Controls.Add(Me.rdbDateTs)
        Me.gbDateOrder.Controls.Add(Me.dtpDateStart)
        Me.gbDateOrder.Controls.Add(Me.LabelControl4)
        Me.gbDateOrder.Controls.Add(Me.LabelControl3)
        Me.gbDateOrder.Controls.Add(Me.dtpDateNow)
        Me.gbDateOrder.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.gbDateOrder.Location = New System.Drawing.Point(3, 3)
        Me.gbDateOrder.Name = "gbDateOrder"
        Me.gbDateOrder.Size = New System.Drawing.Size(424, 79)
        Me.gbDateOrder.TabIndex = 1
        Me.gbDateOrder.TabStop = False
        Me.gbDateOrder.Text = "วันที่รวบรวมใบแจ้งหนี้"
        '
        'dtpYear
        '
        Me.dtpYear.Checked = False
        Me.dtpYear.CustomFormat = "yyyy"
        Me.dtpYear.Enabled = False
        Me.dtpYear.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpYear.Location = New System.Drawing.Point(276, 47)
        Me.dtpYear.Name = "dtpYear"
        Me.dtpYear.ShowUpDown = True
        Me.dtpYear.Size = New System.Drawing.Size(66, 23)
        Me.dtpYear.TabIndex = 206
        '
        'rdbYear
        '
        Me.rdbYear.AutoSize = True
        Me.rdbYear.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rdbYear.Location = New System.Drawing.Point(227, 51)
        Me.rdbYear.Name = "rdbYear"
        Me.rdbYear.Size = New System.Drawing.Size(33, 18)
        Me.rdbYear.TabIndex = 205
        Me.rdbYear.Text = "ปี"
        Me.rdbYear.UseVisualStyleBackColor = True
        '
        'dtpMonth
        '
        Me.dtpMonth.Checked = False
        Me.dtpMonth.CustomFormat = "MMMM yyyy"
        Me.dtpMonth.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpMonth.Location = New System.Drawing.Point(276, 16)
        Me.dtpMonth.Name = "dtpMonth"
        Me.dtpMonth.ShowUpDown = True
        Me.dtpMonth.Size = New System.Drawing.Size(139, 23)
        Me.dtpMonth.TabIndex = 204
        '
        'rdbMonth
        '
        Me.rdbMonth.AutoSize = True
        Me.rdbMonth.Checked = True
        Me.rdbMonth.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rdbMonth.Location = New System.Drawing.Point(227, 19)
        Me.rdbMonth.Name = "rdbMonth"
        Me.rdbMonth.Size = New System.Drawing.Size(50, 18)
        Me.rdbMonth.TabIndex = 203
        Me.rdbMonth.TabStop = True
        Me.rdbMonth.Text = "เดือน"
        Me.rdbMonth.UseVisualStyleBackColor = True
        '
        'rdbDateTs
        '
        Me.rdbDateTs.AutoSize = True
        Me.rdbDateTs.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rdbDateTs.Location = New System.Drawing.Point(6, 21)
        Me.rdbDateTs.Name = "rdbDateTs"
        Me.rdbDateTs.Size = New System.Drawing.Size(47, 18)
        Me.rdbDateTs.TabIndex = 202
        Me.rdbDateTs.Text = "วันที่"
        Me.rdbDateTs.UseVisualStyleBackColor = True
        '
        'dtpDateStart
        '
        Me.dtpDateStart.Checked = False
        Me.dtpDateStart.CustomFormat = "dd MMMM yyyy"
        Me.dtpDateStart.Enabled = False
        Me.dtpDateStart.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpDateStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateStart.Location = New System.Drawing.Point(54, 19)
        Me.dtpDateStart.Name = "dtpDateStart"
        Me.dtpDateStart.Size = New System.Drawing.Size(163, 23)
        Me.dtpDateStart.TabIndex = 190
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(184, 24)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(13, 14)
        Me.LabelControl4.TabIndex = 189
        Me.LabelControl4.Text = "ถึง"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(35, 53)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(13, 14)
        Me.LabelControl3.TabIndex = 188
        Me.LabelControl3.Text = "ถึง"
        '
        'dtpDateNow
        '
        Me.dtpDateNow.Checked = False
        Me.dtpDateNow.CustomFormat = "dd MMMM yyyy"
        Me.dtpDateNow.Enabled = False
        Me.dtpDateNow.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpDateNow.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateNow.Location = New System.Drawing.Point(54, 48)
        Me.dtpDateNow.Name = "dtpDateNow"
        Me.dtpDateNow.Size = New System.Drawing.Size(163, 23)
        Me.dtpDateNow.TabIndex = 164
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 88)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1184, 35)
        Me.Panel1.TabIndex = 725
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnNew)
        Me.Panel2.Controls.Add(Me.btnRefresh)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(302, 35)
        Me.Panel2.TabIndex = 588
        '
        'btnNew
        '
        Me.btnNew.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.Appearance.Options.UseFont = True
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.Location = New System.Drawing.Point(100, 3)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(194, 30)
        Me.btnNew.TabIndex = 1
        Me.btnNew.Text = "ทำรายการรวบรวบใบแจ้งหนี้"
        '
        'btnRefresh
        '
        Me.btnRefresh.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Appearance.Options.UseFont = True
        Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), System.Drawing.Image)
        Me.btnRefresh.Location = New System.Drawing.Point(1, 3)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(97, 30)
        Me.btnRefresh.TabIndex = 0
        Me.btnRefresh.Text = "Refresh"
        '
        'FrmSlSaleGroupMt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 551)
        Me.Controls.Add(Me.GCSaleGroup)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmSlSaleGroupMt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = " "
        Me.Text = "ข้อมูลรายการรวบรวมใบแจ้งหนี้สินค้าโสหุัย"
        CType(Me.GVSlGroupDt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCSaleGroup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVSlGroupMt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptShow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.gbDateOrder.ResumeLayout(False)
        Me.gbDateOrder.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GCSaleGroup As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVSlGroupDt As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColidSaleMt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColProductName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColUnit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GVSlGroupMt As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColNum As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColView As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rptShow As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents ColidSale As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDocRef1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDateSale1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColCusName1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColTotalNet1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColPsTs1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDateTs1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColNote1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColidComp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColidPsCancel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColCompName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColPsCancel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColCancelNote As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColidJobMt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnNew As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gbDateOrder As GroupBox
    Friend WithEvents dtpYear As DateTimePicker
    Friend WithEvents rdbYear As RadioButton
    Friend WithEvents dtpMonth As DateTimePicker
    Friend WithEvents rdbMonth As RadioButton
    Friend WithEvents rdbDateTs As RadioButton
    Friend WithEvents dtpDateStart As DateTimePicker
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtpDateNow As DateTimePicker
    Friend WithEvents ColNumDt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDocRef As DevExpress.XtraGrid.Columns.GridColumn
End Class
