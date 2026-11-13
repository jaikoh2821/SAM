<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSlSaleDataSH
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
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim GridFormatRule1 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleExpression1 As DevExpress.XtraEditors.FormatConditionRuleExpression = New DevExpress.XtraEditors.FormatConditionRuleExpression()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSlSaleDataSH))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.GVSaleDt = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colidSaleDt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidProduct = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidLot = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidWh = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColPdCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColLotNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColProductName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColAmount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColUnit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColWareHouseName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDiscount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDiscountBath = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColExp = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDocCode_PO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GVSaleMt = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColNum = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColView = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rptShow = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.ColEdit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rptEdit = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.ColDoc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rptDoc = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.ColCancel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rptCancel = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.ColidSale = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCompCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDocRef1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDateSale1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDatePay1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColCusName1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColTotal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColTotalNet1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDocCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDocRefAcc1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColPsTs1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDateTs1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColTimeTs1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColNote1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColidComp = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColidPsCancel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColCompName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColPsCancel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColCancelNote = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColidJobMt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtCusName = New System.Windows.Forms.TextBox()
        Me.chkComp = New System.Windows.Forms.CheckBox()
        Me.cmbGroupComp = New System.Windows.Forms.ComboBox()
        Me.ChkCus = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdbDateTs = New System.Windows.Forms.RadioButton()
        Me.rdbDateSale = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dtpMonthNow = New System.Windows.Forms.DateTimePicker()
        Me.dtpMonthE = New System.Windows.Forms.DateTimePicker()
        Me.dtpMonthS = New System.Windows.Forms.DateTimePicker()
        Me.rdbMonthNow = New System.Windows.Forms.RadioButton()
        Me.dtpSaleE = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpYear = New System.Windows.Forms.DateTimePicker()
        Me.rdbYear = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.rdbMonth = New System.Windows.Forms.RadioButton()
        Me.rdbDate = New System.Windows.Forms.RadioButton()
        Me.dtpSaleS = New System.Windows.Forms.DateTimePicker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCountDt = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTotalNet = New System.Windows.Forms.TextBox()
        Me.txtCount = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnSFindAll = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.GVSaleDt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVSaleMt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptShow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GVSaleDt
        '
        Me.GVSaleDt.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GVSaleDt.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GVSaleDt.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVSaleDt.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVSaleDt.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GVSaleDt.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GVSaleDt.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.GVSaleDt.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.GVSaleDt.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVSaleDt.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVSaleDt.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GVSaleDt.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GVSaleDt.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVSaleDt.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.GVSaleDt.Appearance.Empty.Options.UseBackColor = True
        Me.GVSaleDt.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.GVSaleDt.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GVSaleDt.Appearance.EvenRow.Options.UseBackColor = True
        Me.GVSaleDt.Appearance.EvenRow.Options.UseForeColor = True
        Me.GVSaleDt.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GVSaleDt.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GVSaleDt.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVSaleDt.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GVSaleDt.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GVSaleDt.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GVSaleDt.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVSaleDt.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.GVSaleDt.Appearance.FilterPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GVSaleDt.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVSaleDt.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GVSaleDt.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GVSaleDt.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVSaleDt.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GVSaleDt.Appearance.FocusedCell.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GVSaleDt.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVSaleDt.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVSaleDt.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GVSaleDt.Appearance.FocusedRow.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GVSaleDt.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVSaleDt.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVSaleDt.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GVSaleDt.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GVSaleDt.Appearance.FooterPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVSaleDt.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVSaleDt.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVSaleDt.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GVSaleDt.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GVSaleDt.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GVSaleDt.Appearance.GroupButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVSaleDt.Appearance.GroupButton.Options.UseBackColor = True
        Me.GVSaleDt.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GVSaleDt.Appearance.GroupButton.Options.UseForeColor = True
        Me.GVSaleDt.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.GVSaleDt.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.GVSaleDt.Appearance.GroupFooter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVSaleDt.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVSaleDt.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GVSaleDt.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GVSaleDt.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVSaleDt.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.GVSaleDt.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.GVSaleDt.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GVSaleDt.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVSaleDt.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.GVSaleDt.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.GVSaleDt.Appearance.GroupRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVSaleDt.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVSaleDt.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GVSaleDt.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVSaleDt.Appearance.HeaderPanel.BackColor = System.Drawing.Color.LightBlue
        Me.GVSaleDt.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.LightBlue
        Me.GVSaleDt.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GVSaleDt.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVSaleDt.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVSaleDt.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GVSaleDt.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.GVSaleDt.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVSaleDt.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVSaleDt.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVSaleDt.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GVSaleDt.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVSaleDt.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.GVSaleDt.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GVSaleDt.Appearance.OddRow.Options.UseBackColor = True
        Me.GVSaleDt.Appearance.OddRow.Options.UseForeColor = True
        Me.GVSaleDt.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.GVSaleDt.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.GVSaleDt.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GVSaleDt.Appearance.Preview.Options.UseBackColor = True
        Me.GVSaleDt.Appearance.Preview.Options.UseFont = True
        Me.GVSaleDt.Appearance.Preview.Options.UseForeColor = True
        Me.GVSaleDt.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.GVSaleDt.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GVSaleDt.Appearance.Row.Options.UseBackColor = True
        Me.GVSaleDt.Appearance.Row.Options.UseForeColor = True
        Me.GVSaleDt.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVSaleDt.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.GVSaleDt.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GVSaleDt.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.GVSaleDt.Appearance.SelectedRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVSaleDt.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVSaleDt.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GVSaleDt.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GVSaleDt.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GVSaleDt.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GVSaleDt.Appearance.VertLine.Options.UseBackColor = True
        Me.GVSaleDt.ColumnPanelRowHeight = 25
        Me.GVSaleDt.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colidSaleDt, Me.colidProduct, Me.colidLot, Me.colidWh, Me.ColPdCode, Me.ColLotNo, Me.ColProductName, Me.ColAmount, Me.ColUnit, Me.ColWareHouseName, Me.ColDiscount, Me.ColDiscountBath, Me.ColPrice, Me.ColExp, Me.colDocCode_PO})
        Me.GVSaleDt.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GVSaleDt.GridControl = Me.GridControl1
        Me.GVSaleDt.Name = "GVSaleDt"
        Me.GVSaleDt.OptionsView.EnableAppearanceEvenRow = True
        Me.GVSaleDt.OptionsView.EnableAppearanceOddRow = True
        Me.GVSaleDt.OptionsView.ShowGroupPanel = False
        Me.GVSaleDt.OptionsView.ShowIndicator = False
        Me.GVSaleDt.PaintStyleName = "MixedXP"
        Me.GVSaleDt.RowHeight = 25
        '
        'colidSaleDt
        '
        Me.colidSaleDt.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.colidSaleDt.AppearanceCell.Options.UseFont = True
        Me.colidSaleDt.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.colidSaleDt.AppearanceHeader.Options.UseFont = True
        Me.colidSaleDt.Caption = "idSaleDt"
        Me.colidSaleDt.FieldName = "idSaleDt"
        Me.colidSaleDt.Name = "colidSaleDt"
        '
        'colidProduct
        '
        Me.colidProduct.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.colidProduct.AppearanceCell.Options.UseFont = True
        Me.colidProduct.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.colidProduct.AppearanceHeader.Options.UseFont = True
        Me.colidProduct.Caption = "idProduct"
        Me.colidProduct.FieldName = "idProduct"
        Me.colidProduct.Name = "colidProduct"
        '
        'colidLot
        '
        Me.colidLot.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.colidLot.AppearanceCell.Options.UseFont = True
        Me.colidLot.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.colidLot.AppearanceHeader.Options.UseFont = True
        Me.colidLot.Caption = "idLot"
        Me.colidLot.FieldName = "idLot"
        Me.colidLot.Name = "colidLot"
        '
        'colidWh
        '
        Me.colidWh.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.colidWh.AppearanceCell.Options.UseFont = True
        Me.colidWh.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.colidWh.AppearanceHeader.Options.UseFont = True
        Me.colidWh.Caption = "idWh"
        Me.colidWh.FieldName = "idWh"
        Me.colidWh.Name = "colidWh"
        '
        'ColPdCode
        '
        Me.ColPdCode.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColPdCode.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColPdCode.AppearanceCell.Options.UseBackColor = True
        Me.ColPdCode.AppearanceCell.Options.UseFont = True
        Me.ColPdCode.AppearanceCell.Options.UseTextOptions = True
        Me.ColPdCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColPdCode.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColPdCode.AppearanceHeader.Options.UseFont = True
        Me.ColPdCode.AppearanceHeader.Options.UseTextOptions = True
        Me.ColPdCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColPdCode.Caption = "รหัสสินค้า"
        Me.ColPdCode.FieldName = "PdCode"
        Me.ColPdCode.Name = "ColPdCode"
        Me.ColPdCode.OptionsColumn.AllowEdit = False
        Me.ColPdCode.OptionsColumn.ReadOnly = True
        Me.ColPdCode.Visible = True
        Me.ColPdCode.VisibleIndex = 0
        Me.ColPdCode.Width = 153
        '
        'ColLotNo
        '
        Me.ColLotNo.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColLotNo.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColLotNo.AppearanceCell.Options.UseBackColor = True
        Me.ColLotNo.AppearanceCell.Options.UseFont = True
        Me.ColLotNo.AppearanceCell.Options.UseTextOptions = True
        Me.ColLotNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColLotNo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColLotNo.AppearanceHeader.Options.UseFont = True
        Me.ColLotNo.AppearanceHeader.Options.UseTextOptions = True
        Me.ColLotNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColLotNo.Caption = "Lot No."
        Me.ColLotNo.FieldName = "LotNo"
        Me.ColLotNo.Name = "ColLotNo"
        Me.ColLotNo.OptionsColumn.AllowEdit = False
        Me.ColLotNo.OptionsColumn.ReadOnly = True
        Me.ColLotNo.Visible = True
        Me.ColLotNo.VisibleIndex = 1
        Me.ColLotNo.Width = 138
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
        Me.ColProductName.Caption = "รายการสินค้า"
        Me.ColProductName.FieldName = "ProductName"
        Me.ColProductName.Name = "ColProductName"
        Me.ColProductName.OptionsColumn.AllowEdit = False
        Me.ColProductName.OptionsColumn.ReadOnly = True
        Me.ColProductName.Visible = True
        Me.ColProductName.VisibleIndex = 2
        Me.ColProductName.Width = 544
        '
        'ColAmount
        '
        Me.ColAmount.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColAmount.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColAmount.AppearanceCell.Options.UseBackColor = True
        Me.ColAmount.AppearanceCell.Options.UseFont = True
        Me.ColAmount.AppearanceCell.Options.UseTextOptions = True
        Me.ColAmount.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ColAmount.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColAmount.AppearanceHeader.Options.UseFont = True
        Me.ColAmount.AppearanceHeader.Options.UseTextOptions = True
        Me.ColAmount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColAmount.Caption = "จำนวนขาย"
        Me.ColAmount.DisplayFormat.FormatString = "#,##0.00##"
        Me.ColAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColAmount.FieldName = "Amount"
        Me.ColAmount.Name = "ColAmount"
        Me.ColAmount.OptionsColumn.AllowFocus = False
        Me.ColAmount.OptionsColumn.ReadOnly = True
        Me.ColAmount.Visible = True
        Me.ColAmount.VisibleIndex = 3
        Me.ColAmount.Width = 106
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
        Me.ColUnit.VisibleIndex = 4
        Me.ColUnit.Width = 106
        '
        'ColWareHouseName
        '
        Me.ColWareHouseName.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColWareHouseName.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColWareHouseName.AppearanceCell.Options.UseBackColor = True
        Me.ColWareHouseName.AppearanceCell.Options.UseFont = True
        Me.ColWareHouseName.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColWareHouseName.AppearanceHeader.Options.UseFont = True
        Me.ColWareHouseName.AppearanceHeader.Options.UseTextOptions = True
        Me.ColWareHouseName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColWareHouseName.Caption = "คลังสินค้า"
        Me.ColWareHouseName.FieldName = "full_lock"
        Me.ColWareHouseName.Name = "ColWareHouseName"
        Me.ColWareHouseName.OptionsColumn.AllowEdit = False
        Me.ColWareHouseName.OptionsColumn.ReadOnly = True
        Me.ColWareHouseName.Visible = True
        Me.ColWareHouseName.VisibleIndex = 9
        Me.ColWareHouseName.Width = 124
        '
        'ColDiscount
        '
        Me.ColDiscount.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColDiscount.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColDiscount.AppearanceCell.Options.UseBackColor = True
        Me.ColDiscount.AppearanceCell.Options.UseFont = True
        Me.ColDiscount.AppearanceCell.Options.UseTextOptions = True
        Me.ColDiscount.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ColDiscount.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColDiscount.AppearanceHeader.Options.UseFont = True
        Me.ColDiscount.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDiscount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDiscount.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColDiscount.Caption = "ส่วนลด (%)"
        Me.ColDiscount.DisplayFormat.FormatString = "#,##0.00##"
        Me.ColDiscount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColDiscount.FieldName = "Discount"
        Me.ColDiscount.Name = "ColDiscount"
        Me.ColDiscount.OptionsColumn.AllowEdit = False
        Me.ColDiscount.OptionsColumn.ReadOnly = True
        Me.ColDiscount.Visible = True
        Me.ColDiscount.VisibleIndex = 5
        Me.ColDiscount.Width = 131
        '
        'ColDiscountBath
        '
        Me.ColDiscountBath.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColDiscountBath.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColDiscountBath.AppearanceCell.Options.UseBackColor = True
        Me.ColDiscountBath.AppearanceCell.Options.UseFont = True
        Me.ColDiscountBath.AppearanceCell.Options.UseTextOptions = True
        Me.ColDiscountBath.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ColDiscountBath.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColDiscountBath.AppearanceHeader.Options.UseFont = True
        Me.ColDiscountBath.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDiscountBath.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDiscountBath.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColDiscountBath.Caption = "ส่วนลด (บาท)"
        Me.ColDiscountBath.DisplayFormat.FormatString = "#,##0.00##"
        Me.ColDiscountBath.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColDiscountBath.FieldName = "DiscountBath"
        Me.ColDiscountBath.Name = "ColDiscountBath"
        Me.ColDiscountBath.OptionsColumn.AllowEdit = False
        Me.ColDiscountBath.OptionsColumn.ReadOnly = True
        Me.ColDiscountBath.Visible = True
        Me.ColDiscountBath.VisibleIndex = 6
        Me.ColDiscountBath.Width = 124
        '
        'ColPrice
        '
        Me.ColPrice.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColPrice.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColPrice.AppearanceCell.Options.UseBackColor = True
        Me.ColPrice.AppearanceCell.Options.UseFont = True
        Me.ColPrice.AppearanceCell.Options.UseTextOptions = True
        Me.ColPrice.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ColPrice.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColPrice.AppearanceHeader.Options.UseFont = True
        Me.ColPrice.AppearanceHeader.Options.UseTextOptions = True
        Me.ColPrice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColPrice.Caption = "ราคา"
        Me.ColPrice.DisplayFormat.FormatString = "#,##0.00##"
        Me.ColPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColPrice.FieldName = "Price"
        Me.ColPrice.Name = "ColPrice"
        Me.ColPrice.OptionsColumn.AllowEdit = False
        Me.ColPrice.OptionsColumn.ReadOnly = True
        Me.ColPrice.Visible = True
        Me.ColPrice.VisibleIndex = 7
        Me.ColPrice.Width = 95
        '
        'ColExp
        '
        Me.ColExp.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColExp.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColExp.AppearanceCell.Options.UseBackColor = True
        Me.ColExp.AppearanceCell.Options.UseFont = True
        Me.ColExp.AppearanceCell.Options.UseTextOptions = True
        Me.ColExp.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ColExp.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColExp.AppearanceHeader.Options.UseFont = True
        Me.ColExp.AppearanceHeader.Options.UseTextOptions = True
        Me.ColExp.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColExp.Caption = "รวมเป็นเงิน"
        Me.ColExp.DisplayFormat.FormatString = "#,##0.00##"
        Me.ColExp.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColExp.FieldName = "ExSump"
        Me.ColExp.Name = "ColExp"
        Me.ColExp.OptionsColumn.AllowEdit = False
        Me.ColExp.OptionsColumn.ReadOnly = True
        Me.ColExp.Visible = True
        Me.ColExp.VisibleIndex = 8
        Me.ColExp.Width = 127
        '
        'colDocCode_PO
        '
        Me.colDocCode_PO.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.colDocCode_PO.AppearanceCell.Options.UseFont = True
        Me.colDocCode_PO.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.colDocCode_PO.AppearanceHeader.Options.UseFont = True
        Me.colDocCode_PO.Caption = "DocCode_PO"
        Me.colDocCode_PO.FieldName = "DocCode_PO"
        Me.colDocCode_PO.Name = "colDocCode_PO"
        '
        'GridControl1
        '
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode1.LevelTemplate = Me.GVSaleDt
        GridLevelNode1.RelationName = "Level1"
        Me.GridControl1.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.GridControl1.Location = New System.Drawing.Point(0, 163)
        Me.GridControl1.MainView = Me.GVSaleMt
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rptDoc, Me.rptCancel, Me.rptShow, Me.rptEdit})
        Me.GridControl1.Size = New System.Drawing.Size(1184, 388)
        Me.GridControl1.TabIndex = 725
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVSaleMt, Me.GVSaleDt})
        '
        'GVSaleMt
        '
        Me.GVSaleMt.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GVSaleMt.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GVSaleMt.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVSaleMt.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVSaleMt.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GVSaleMt.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GVSaleMt.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.GVSaleMt.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.GVSaleMt.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVSaleMt.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVSaleMt.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GVSaleMt.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GVSaleMt.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVSaleMt.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.GVSaleMt.Appearance.Empty.Options.UseBackColor = True
        Me.GVSaleMt.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.GVSaleMt.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GVSaleMt.Appearance.EvenRow.Options.UseBackColor = True
        Me.GVSaleMt.Appearance.EvenRow.Options.UseForeColor = True
        Me.GVSaleMt.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GVSaleMt.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GVSaleMt.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVSaleMt.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GVSaleMt.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GVSaleMt.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GVSaleMt.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVSaleMt.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.GVSaleMt.Appearance.FilterPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GVSaleMt.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVSaleMt.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GVSaleMt.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GVSaleMt.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVSaleMt.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVSaleMt.Appearance.FocusedCell.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GVSaleMt.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVSaleMt.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVSaleMt.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVSaleMt.Appearance.FocusedRow.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GVSaleMt.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVSaleMt.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVSaleMt.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GVSaleMt.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GVSaleMt.Appearance.FooterPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVSaleMt.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVSaleMt.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVSaleMt.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GVSaleMt.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GVSaleMt.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GVSaleMt.Appearance.GroupButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVSaleMt.Appearance.GroupButton.Options.UseBackColor = True
        Me.GVSaleMt.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GVSaleMt.Appearance.GroupButton.Options.UseForeColor = True
        Me.GVSaleMt.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.GVSaleMt.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.GVSaleMt.Appearance.GroupFooter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVSaleMt.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVSaleMt.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GVSaleMt.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GVSaleMt.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVSaleMt.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.GVSaleMt.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.GVSaleMt.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GVSaleMt.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVSaleMt.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.GVSaleMt.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.GVSaleMt.Appearance.GroupRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVSaleMt.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVSaleMt.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GVSaleMt.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVSaleMt.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.GVSaleMt.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.GVSaleMt.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVSaleMt.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVSaleMt.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVSaleMt.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GVSaleMt.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.GVSaleMt.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVSaleMt.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVSaleMt.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVSaleMt.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GVSaleMt.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVSaleMt.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.GVSaleMt.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GVSaleMt.Appearance.OddRow.Options.UseBackColor = True
        Me.GVSaleMt.Appearance.OddRow.Options.UseForeColor = True
        Me.GVSaleMt.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.GVSaleMt.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.GVSaleMt.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GVSaleMt.Appearance.Preview.Options.UseBackColor = True
        Me.GVSaleMt.Appearance.Preview.Options.UseFont = True
        Me.GVSaleMt.Appearance.Preview.Options.UseForeColor = True
        Me.GVSaleMt.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.GVSaleMt.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GVSaleMt.Appearance.Row.Options.UseBackColor = True
        Me.GVSaleMt.Appearance.Row.Options.UseForeColor = True
        Me.GVSaleMt.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVSaleMt.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.GVSaleMt.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GVSaleMt.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.GVSaleMt.Appearance.SelectedRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GVSaleMt.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVSaleMt.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GVSaleMt.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GVSaleMt.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GVSaleMt.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GVSaleMt.Appearance.VertLine.Options.UseBackColor = True
        Me.GVSaleMt.ColumnPanelRowHeight = 35
        Me.GVSaleMt.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColNum, Me.ColView, Me.ColEdit, Me.ColDoc, Me.ColCancel, Me.ColidSale, Me.colCompCode, Me.ColDocRef1, Me.ColDateSale1, Me.ColDatePay1, Me.ColCusName1, Me.ColTotal, Me.ColTotalNet1, Me.ColDocCode, Me.ColDocRefAcc1, Me.ColPsTs1, Me.ColDateTs1, Me.ColTimeTs1, Me.ColNote1, Me.ColidComp, Me.ColidPsCancel, Me.ColCompName, Me.ColPsCancel, Me.ColCancelNote, Me.ColidJobMt})
        Me.GVSaleMt.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        GridFormatRule1.Name = "stWaitCut"
        FormatConditionRuleExpression1.Expression = "[stWaitCut] = 'Draft'"
        FormatConditionRuleExpression1.PredefinedName = "Red Text"
        GridFormatRule1.Rule = FormatConditionRuleExpression1
        Me.GVSaleMt.FormatRules.Add(GridFormatRule1)
        Me.GVSaleMt.GridControl = Me.GridControl1
        Me.GVSaleMt.Name = "GVSaleMt"
        Me.GVSaleMt.OptionsDetail.AllowOnlyOneMasterRowExpanded = True
        Me.GVSaleMt.OptionsView.ColumnAutoWidth = False
        Me.GVSaleMt.OptionsView.EnableAppearanceEvenRow = True
        Me.GVSaleMt.OptionsView.EnableAppearanceOddRow = True
        Me.GVSaleMt.OptionsView.RowAutoHeight = True
        Me.GVSaleMt.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GVSaleMt.OptionsView.ShowGroupPanel = False
        Me.GVSaleMt.OptionsView.ShowIndicator = False
        Me.GVSaleMt.PaintStyleName = "MixedXP"
        Me.GVSaleMt.RowHeight = 25
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
        Me.ColView.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
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
        Me.ColView.VisibleIndex = 2
        Me.ColView.Width = 45
        '
        'rptShow
        '
        Me.rptShow.AutoHeight = False
        Me.rptShow.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("rptShow.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.rptShow.Name = "rptShow"
        Me.rptShow.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'ColEdit
        '
        Me.ColEdit.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColEdit.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColEdit.AppearanceCell.Options.UseBackColor = True
        Me.ColEdit.AppearanceCell.Options.UseFont = True
        Me.ColEdit.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColEdit.AppearanceHeader.Options.UseFont = True
        Me.ColEdit.AppearanceHeader.Options.UseTextOptions = True
        Me.ColEdit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColEdit.Caption = "แก้ไข"
        Me.ColEdit.ColumnEdit = Me.rptEdit
        Me.ColEdit.MaxWidth = 45
        Me.ColEdit.MinWidth = 45
        Me.ColEdit.Name = "ColEdit"
        Me.ColEdit.Visible = True
        Me.ColEdit.VisibleIndex = 1
        Me.ColEdit.Width = 45
        '
        'rptEdit
        '
        Me.rptEdit.AutoHeight = False
        Me.rptEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("rptEdit.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject2, "", Nothing, Nothing, True)})
        Me.rptEdit.Name = "rptEdit"
        Me.rptEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'ColDoc
        '
        Me.ColDoc.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColDoc.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColDoc.AppearanceCell.Options.UseBackColor = True
        Me.ColDoc.AppearanceCell.Options.UseFont = True
        Me.ColDoc.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColDoc.AppearanceHeader.Options.UseFont = True
        Me.ColDoc.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDoc.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDoc.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColDoc.Caption = "เอกสาร"
        Me.ColDoc.ColumnEdit = Me.rptDoc
        Me.ColDoc.MaxWidth = 48
        Me.ColDoc.MinWidth = 48
        Me.ColDoc.Name = "ColDoc"
        Me.ColDoc.Visible = True
        Me.ColDoc.VisibleIndex = 3
        Me.ColDoc.Width = 48
        '
        'rptDoc
        '
        Me.rptDoc.AutoHeight = False
        Me.rptDoc.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("rptDoc.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject3, "", Nothing, Nothing, True)})
        Me.rptDoc.Name = "rptDoc"
        Me.rptDoc.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'ColCancel
        '
        Me.ColCancel.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColCancel.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColCancel.AppearanceCell.Options.UseBackColor = True
        Me.ColCancel.AppearanceCell.Options.UseFont = True
        Me.ColCancel.AppearanceCell.Options.UseTextOptions = True
        Me.ColCancel.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColCancel.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColCancel.AppearanceHeader.Options.UseFont = True
        Me.ColCancel.AppearanceHeader.Options.UseTextOptions = True
        Me.ColCancel.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColCancel.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColCancel.Caption = "ยกเลิก"
        Me.ColCancel.ColumnEdit = Me.rptCancel
        Me.ColCancel.MaxWidth = 45
        Me.ColCancel.MinWidth = 45
        Me.ColCancel.Name = "ColCancel"
        Me.ColCancel.Visible = True
        Me.ColCancel.VisibleIndex = 4
        Me.ColCancel.Width = 45
        '
        'rptCancel
        '
        Me.rptCancel.AutoHeight = False
        Me.rptCancel.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("rptCancel.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject4, "", Nothing, Nothing, True)})
        Me.rptCancel.Name = "rptCancel"
        Me.rptCancel.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'ColidSale
        '
        Me.ColidSale.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
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
        Me.colCompCode.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
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
        Me.colCompCode.VisibleIndex = 5
        Me.colCompCode.Width = 45
        '
        'ColDocRef1
        '
        Me.ColDocRef1.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColDocRef1.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColDocRef1.AppearanceCell.Options.UseBackColor = True
        Me.ColDocRef1.AppearanceCell.Options.UseFont = True
        Me.ColDocRef1.AppearanceCell.Options.UseTextOptions = True
        Me.ColDocRef1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDocRef1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColDocRef1.AppearanceHeader.Options.UseFont = True
        Me.ColDocRef1.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDocRef1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDocRef1.Caption = "เลขที่อ้างอิง"
        Me.ColDocRef1.FieldName = "DocRef"
        Me.ColDocRef1.Name = "ColDocRef1"
        Me.ColDocRef1.OptionsColumn.AllowEdit = False
        Me.ColDocRef1.OptionsColumn.ReadOnly = True
        Me.ColDocRef1.Visible = True
        Me.ColDocRef1.VisibleIndex = 6
        Me.ColDocRef1.Width = 118
        '
        'ColDateSale1
        '
        Me.ColDateSale1.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColDateSale1.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColDateSale1.AppearanceCell.Options.UseBackColor = True
        Me.ColDateSale1.AppearanceCell.Options.UseFont = True
        Me.ColDateSale1.AppearanceCell.Options.UseTextOptions = True
        Me.ColDateSale1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDateSale1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColDateSale1.AppearanceHeader.Options.UseFont = True
        Me.ColDateSale1.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDateSale1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDateSale1.Caption = "วันที่ขาย"
        Me.ColDateSale1.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.ColDateSale1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.ColDateSale1.FieldName = "DateSale"
        Me.ColDateSale1.Name = "ColDateSale1"
        Me.ColDateSale1.OptionsColumn.AllowEdit = False
        Me.ColDateSale1.OptionsColumn.ReadOnly = True
        Me.ColDateSale1.Visible = True
        Me.ColDateSale1.VisibleIndex = 7
        Me.ColDateSale1.Width = 80
        '
        'ColDatePay1
        '
        Me.ColDatePay1.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColDatePay1.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColDatePay1.AppearanceCell.Options.UseBackColor = True
        Me.ColDatePay1.AppearanceCell.Options.UseFont = True
        Me.ColDatePay1.AppearanceCell.Options.UseTextOptions = True
        Me.ColDatePay1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDatePay1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColDatePay1.AppearanceHeader.Options.UseFont = True
        Me.ColDatePay1.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDatePay1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDatePay1.Caption = "วันที่จ่ายเงิน"
        Me.ColDatePay1.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.ColDatePay1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.ColDatePay1.FieldName = "DatePay"
        Me.ColDatePay1.Name = "ColDatePay1"
        Me.ColDatePay1.OptionsColumn.AllowEdit = False
        Me.ColDatePay1.OptionsColumn.ReadOnly = True
        Me.ColDatePay1.Visible = True
        Me.ColDatePay1.VisibleIndex = 8
        Me.ColDatePay1.Width = 80
        '
        'ColCusName1
        '
        Me.ColCusName1.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ColCusName1.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColCusName1.AppearanceCell.Options.UseBackColor = True
        Me.ColCusName1.AppearanceCell.Options.UseFont = True
        Me.ColCusName1.AppearanceCell.Options.UseTextOptions = True
        Me.ColCusName1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.ColCusName1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColCusName1.AppearanceHeader.Options.UseFont = True
        Me.ColCusName1.AppearanceHeader.Options.UseTextOptions = True
        Me.ColCusName1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColCusName1.Caption = "ชื่อเกษตรกร"
        Me.ColCusName1.FieldName = "CusName"
        Me.ColCusName1.Name = "ColCusName1"
        Me.ColCusName1.OptionsColumn.AllowEdit = False
        Me.ColCusName1.OptionsColumn.ReadOnly = True
        Me.ColCusName1.Visible = True
        Me.ColCusName1.VisibleIndex = 9
        Me.ColCusName1.Width = 454
        '
        'ColTotal
        '
        Me.ColTotal.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
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
        Me.ColTotalNet1.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
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
        Me.ColTotalNet1.Visible = True
        Me.ColTotalNet1.VisibleIndex = 10
        Me.ColTotalNet1.Width = 90
        '
        'ColDocCode
        '
        Me.ColDocCode.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColDocCode.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColDocCode.AppearanceCell.Options.UseBackColor = True
        Me.ColDocCode.AppearanceCell.Options.UseFont = True
        Me.ColDocCode.AppearanceCell.Options.UseTextOptions = True
        Me.ColDocCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDocCode.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColDocCode.AppearanceHeader.Options.UseFont = True
        Me.ColDocCode.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDocCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDocCode.Caption = "เลขที่รายการ"
        Me.ColDocCode.FieldName = "DocCode"
        Me.ColDocCode.Name = "ColDocCode"
        Me.ColDocCode.OptionsColumn.AllowEdit = False
        Me.ColDocCode.OptionsColumn.ReadOnly = True
        Me.ColDocCode.Visible = True
        Me.ColDocCode.VisibleIndex = 11
        Me.ColDocCode.Width = 84
        '
        'ColDocRefAcc1
        '
        Me.ColDocRefAcc1.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColDocRefAcc1.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColDocRefAcc1.AppearanceCell.Options.UseBackColor = True
        Me.ColDocRefAcc1.AppearanceCell.Options.UseFont = True
        Me.ColDocRefAcc1.AppearanceCell.Options.UseTextOptions = True
        Me.ColDocRefAcc1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDocRefAcc1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColDocRefAcc1.AppearanceHeader.Options.UseFont = True
        Me.ColDocRefAcc1.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDocRefAcc1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDocRefAcc1.Caption = "เลขที่ทางบัญชี"
        Me.ColDocRefAcc1.FieldName = "DocRefAcc"
        Me.ColDocRefAcc1.Name = "ColDocRefAcc1"
        Me.ColDocRefAcc1.OptionsColumn.AllowEdit = False
        Me.ColDocRefAcc1.OptionsColumn.ReadOnly = True
        Me.ColDocRefAcc1.Visible = True
        Me.ColDocRefAcc1.VisibleIndex = 12
        Me.ColDocRefAcc1.Width = 97
        '
        'ColPsTs1
        '
        Me.ColPsTs1.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
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
        Me.ColPsTs1.Visible = True
        Me.ColPsTs1.VisibleIndex = 13
        '
        'ColDateTs1
        '
        Me.ColDateTs1.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
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
        Me.ColDateTs1.VisibleIndex = 14
        Me.ColDateTs1.Width = 94
        '
        'ColTimeTs1
        '
        Me.ColTimeTs1.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColTimeTs1.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColTimeTs1.AppearanceCell.Options.UseBackColor = True
        Me.ColTimeTs1.AppearanceCell.Options.UseFont = True
        Me.ColTimeTs1.AppearanceCell.Options.UseTextOptions = True
        Me.ColTimeTs1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColTimeTs1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColTimeTs1.AppearanceHeader.Options.UseFont = True
        Me.ColTimeTs1.AppearanceHeader.Options.UseTextOptions = True
        Me.ColTimeTs1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColTimeTs1.Caption = "เวลา"
        Me.ColTimeTs1.FieldName = "TimeTs"
        Me.ColTimeTs1.Name = "ColTimeTs1"
        Me.ColTimeTs1.OptionsColumn.AllowEdit = False
        Me.ColTimeTs1.OptionsColumn.ReadOnly = True
        Me.ColTimeTs1.Visible = True
        Me.ColTimeTs1.VisibleIndex = 15
        Me.ColTimeTs1.Width = 51
        '
        'ColNote1
        '
        Me.ColNote1.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
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
        Me.ColNote1.VisibleIndex = 16
        Me.ColNote1.Width = 174
        '
        'ColidComp
        '
        Me.ColidComp.Caption = "idComp"
        Me.ColidComp.FieldName = "idComp"
        Me.ColidComp.Name = "ColidComp"
        '
        'ColidPsCancel
        '
        Me.ColidPsCancel.Caption = "idPsCancel"
        Me.ColidPsCancel.FieldName = "idPsCancel"
        Me.ColidPsCancel.Name = "ColidPsCancel"
        '
        'ColCompName
        '
        Me.ColCompName.Caption = "CompName"
        Me.ColCompName.FieldName = "CompanyName"
        Me.ColCompName.Name = "ColCompName"
        '
        'ColPsCancel
        '
        Me.ColPsCancel.Caption = "PsCancel"
        Me.ColPsCancel.FieldName = "PsCancel"
        Me.ColPsCancel.Name = "ColPsCancel"
        '
        'ColCancelNote
        '
        Me.ColCancelNote.Caption = "CancelNote"
        Me.ColCancelNote.FieldName = "CancelNote"
        Me.ColCancelNote.Name = "ColCancelNote"
        '
        'ColidJobMt
        '
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
        Me.PanelControl1.Controls.Add(Me.GroupBox4)
        Me.PanelControl1.Controls.Add(Me.GroupBox1)
        Me.PanelControl1.Controls.Add(Me.GroupBox2)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1184, 128)
        Me.PanelControl1.TabIndex = 723
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.txtCusName)
        Me.GroupBox4.Controls.Add(Me.chkComp)
        Me.GroupBox4.Controls.Add(Me.cmbGroupComp)
        Me.GroupBox4.Controls.Add(Me.ChkCus)
        Me.GroupBox4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(574, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(317, 109)
        Me.GroupBox4.TabIndex = 608
        Me.GroupBox4.TabStop = False
        '
        'txtCusName
        '
        Me.txtCusName.Enabled = False
        Me.txtCusName.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCusName.Location = New System.Drawing.Point(107, 44)
        Me.txtCusName.Name = "txtCusName"
        Me.txtCusName.Size = New System.Drawing.Size(196, 22)
        Me.txtCusName.TabIndex = 966
        '
        'chkComp
        '
        Me.chkComp.AutoSize = True
        Me.chkComp.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.chkComp.Location = New System.Drawing.Point(13, 20)
        Me.chkComp.Name = "chkComp"
        Me.chkComp.Size = New System.Drawing.Size(57, 18)
        Me.chkComp.TabIndex = 965
        Me.chkComp.Text = "บริษัท"
        Me.chkComp.UseVisualStyleBackColor = True
        '
        'cmbGroupComp
        '
        Me.cmbGroupComp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGroupComp.Enabled = False
        Me.cmbGroupComp.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmbGroupComp.FormattingEnabled = True
        Me.cmbGroupComp.Location = New System.Drawing.Point(107, 18)
        Me.cmbGroupComp.Name = "cmbGroupComp"
        Me.cmbGroupComp.Size = New System.Drawing.Size(196, 22)
        Me.cmbGroupComp.TabIndex = 964
        '
        'ChkCus
        '
        Me.ChkCus.AutoSize = True
        Me.ChkCus.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ChkCus.Location = New System.Drawing.Point(13, 46)
        Me.ChkCus.Name = "ChkCus"
        Me.ChkCus.Size = New System.Drawing.Size(53, 18)
        Me.ChkCus.TabIndex = 412
        Me.ChkCus.Text = "ลูกค้า"
        Me.ChkCus.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.rdbDateTs)
        Me.GroupBox1.Controls.Add(Me.rdbDateSale)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(140, 109)
        Me.GroupBox1.TabIndex = 600
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ประเภทข้อมูลวันที่"
        '
        'rdbDateTs
        '
        Me.rdbDateTs.AutoSize = True
        Me.rdbDateTs.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rdbDateTs.Location = New System.Drawing.Point(23, 53)
        Me.rdbDateTs.Name = "rdbDateTs"
        Me.rdbDateTs.Size = New System.Drawing.Size(98, 18)
        Me.rdbDateTs.TabIndex = 601
        Me.rdbDateTs.Text = "วันที่ทำรายการ"
        Me.rdbDateTs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdbDateTs.UseVisualStyleBackColor = True
        '
        'rdbDateSale
        '
        Me.rdbDateSale.AutoSize = True
        Me.rdbDateSale.Checked = True
        Me.rdbDateSale.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rdbDateSale.Location = New System.Drawing.Point(23, 25)
        Me.rdbDateSale.Name = "rdbDateSale"
        Me.rdbDateSale.Size = New System.Drawing.Size(67, 18)
        Me.rdbDateSale.TabIndex = 600
        Me.rdbDateSale.TabStop = True
        Me.rdbDateSale.Text = "วันที่ขาย"
        Me.rdbDateSale.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.dtpMonthNow)
        Me.GroupBox2.Controls.Add(Me.dtpMonthE)
        Me.GroupBox2.Controls.Add(Me.dtpMonthS)
        Me.GroupBox2.Controls.Add(Me.rdbMonthNow)
        Me.GroupBox2.Controls.Add(Me.dtpSaleE)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.dtpYear)
        Me.GroupBox2.Controls.Add(Me.rdbYear)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.rdbMonth)
        Me.GroupBox2.Controls.Add(Me.rdbDate)
        Me.GroupBox2.Controls.Add(Me.dtpSaleS)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(158, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(410, 109)
        Me.GroupBox2.TabIndex = 606
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ช่วงวันที่"
        '
        'dtpMonthNow
        '
        Me.dtpMonthNow.Checked = False
        Me.dtpMonthNow.CustomFormat = "MMMM /yyyy"
        Me.dtpMonthNow.Enabled = False
        Me.dtpMonthNow.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpMonthNow.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpMonthNow.Location = New System.Drawing.Point(82, 77)
        Me.dtpMonthNow.Name = "dtpMonthNow"
        Me.dtpMonthNow.Size = New System.Drawing.Size(147, 22)
        Me.dtpMonthNow.TabIndex = 650
        '
        'dtpMonthE
        '
        Me.dtpMonthE.Checked = False
        Me.dtpMonthE.CustomFormat = "MMMM /yyyy"
        Me.dtpMonthE.Enabled = False
        Me.dtpMonthE.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpMonthE.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpMonthE.Location = New System.Drawing.Point(260, 49)
        Me.dtpMonthE.Name = "dtpMonthE"
        Me.dtpMonthE.Size = New System.Drawing.Size(144, 22)
        Me.dtpMonthE.TabIndex = 649
        '
        'dtpMonthS
        '
        Me.dtpMonthS.Checked = False
        Me.dtpMonthS.CustomFormat = "MMMM /yyyy"
        Me.dtpMonthS.Enabled = False
        Me.dtpMonthS.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpMonthS.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpMonthS.Location = New System.Drawing.Point(82, 48)
        Me.dtpMonthS.Name = "dtpMonthS"
        Me.dtpMonthS.Size = New System.Drawing.Size(147, 22)
        Me.dtpMonthS.TabIndex = 648
        '
        'rdbMonthNow
        '
        Me.rdbMonthNow.AutoSize = True
        Me.rdbMonthNow.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rdbMonthNow.Location = New System.Drawing.Point(12, 80)
        Me.rdbMonthNow.Name = "rdbMonthNow"
        Me.rdbMonthNow.Size = New System.Drawing.Size(50, 18)
        Me.rdbMonthNow.TabIndex = 628
        Me.rdbMonthNow.Text = "เดือน"
        Me.rdbMonthNow.UseVisualStyleBackColor = True
        '
        'dtpSaleE
        '
        Me.dtpSaleE.CustomFormat = "ddMMMMyyyy"
        Me.dtpSaleE.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpSaleE.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpSaleE.Location = New System.Drawing.Point(260, 20)
        Me.dtpSaleE.MinDate = New Date(1757, 1, 1, 0, 0, 0, 0)
        Me.dtpSaleE.Name = "dtpSaleE"
        Me.dtpSaleE.Size = New System.Drawing.Size(144, 22)
        Me.dtpSaleE.TabIndex = 607
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(235, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 14)
        Me.Label1.TabIndex = 624
        Me.Label1.Text = "ถึง"
        '
        'dtpYear
        '
        Me.dtpYear.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpYear.CausesValidation = False
        Me.dtpYear.CustomFormat = "yyyy"
        Me.dtpYear.Enabled = False
        Me.dtpYear.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpYear.Location = New System.Drawing.Point(297, 76)
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
        Me.rdbYear.Location = New System.Drawing.Point(259, 79)
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
        Me.Label4.Location = New System.Drawing.Point(235, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(20, 14)
        Me.Label4.TabIndex = 605
        Me.Label4.Text = "ถึง"
        '
        'rdbMonth
        '
        Me.rdbMonth.AutoSize = True
        Me.rdbMonth.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rdbMonth.Location = New System.Drawing.Point(12, 52)
        Me.rdbMonth.Name = "rdbMonth"
        Me.rdbMonth.Size = New System.Drawing.Size(70, 18)
        Me.rdbMonth.TabIndex = 604
        Me.rdbMonth.Text = "ช่วงเดือน"
        Me.rdbMonth.UseVisualStyleBackColor = True
        '
        'rdbDate
        '
        Me.rdbDate.AutoSize = True
        Me.rdbDate.Checked = True
        Me.rdbDate.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rdbDate.Location = New System.Drawing.Point(12, 25)
        Me.rdbDate.Name = "rdbDate"
        Me.rdbDate.Size = New System.Drawing.Size(47, 18)
        Me.rdbDate.TabIndex = 603
        Me.rdbDate.TabStop = True
        Me.rdbDate.Text = "วันที่"
        Me.rdbDate.UseVisualStyleBackColor = True
        '
        'dtpSaleS
        '
        Me.dtpSaleS.CustomFormat = "ddMMMMyyyy"
        Me.dtpSaleS.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpSaleS.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpSaleS.Location = New System.Drawing.Point(82, 20)
        Me.dtpSaleS.MinDate = New Date(1757, 1, 1, 0, 0, 0, 0)
        Me.dtpSaleS.Name = "dtpSaleS"
        Me.dtpSaleS.Size = New System.Drawing.Size(147, 22)
        Me.dtpSaleS.TabIndex = 601
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 128)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1184, 35)
        Me.Panel1.TabIndex = 724
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.txtCountDt)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.txtTotalNet)
        Me.Panel3.Controls.Add(Me.txtCount)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(464, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(720, 35)
        Me.Panel3.TabIndex = 600
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(185, 10)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 16)
        Me.Label8.TabIndex = 602
        Me.Label8.Text = "รายการ"
        '
        'txtCountDt
        '
        Me.txtCountDt.BackColor = System.Drawing.Color.Black
        Me.txtCountDt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCountDt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCountDt.ForeColor = System.Drawing.Color.Lime
        Me.txtCountDt.Location = New System.Drawing.Point(99, 6)
        Me.txtCountDt.Name = "txtCountDt"
        Me.txtCountDt.ReadOnly = True
        Me.txtCountDt.Size = New System.Drawing.Size(86, 24)
        Me.txtCountDt.TabIndex = 601
        Me.txtCountDt.Text = "0"
        Me.txtCountDt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(6, 10)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 16)
        Me.Label9.TabIndex = 600
        Me.Label9.Text = "รายการสินค้า"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(415, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 16)
        Me.Label3.TabIndex = 599
        Me.Label3.Text = "รายการ"
        '
        'txtTotalNet
        '
        Me.txtTotalNet.BackColor = System.Drawing.Color.Black
        Me.txtTotalNet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalNet.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTotalNet.ForeColor = System.Drawing.Color.Lime
        Me.txtTotalNet.Location = New System.Drawing.Point(558, 6)
        Me.txtTotalNet.Name = "txtTotalNet"
        Me.txtTotalNet.ReadOnly = True
        Me.txtTotalNet.Size = New System.Drawing.Size(159, 24)
        Me.txtTotalNet.TabIndex = 579
        Me.txtTotalNet.Text = "0"
        Me.txtTotalNet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCount
        '
        Me.txtCount.BackColor = System.Drawing.Color.Black
        Me.txtCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCount.ForeColor = System.Drawing.Color.Lime
        Me.txtCount.Location = New System.Drawing.Point(321, 6)
        Me.txtCount.Name = "txtCount"
        Me.txtCount.ReadOnly = True
        Me.txtCount.Size = New System.Drawing.Size(88, 24)
        Me.txtCount.TabIndex = 598
        Me.txtCount.Text = "0"
        Me.txtCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(468, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 16)
        Me.Label2.TabIndex = 142
        Me.Label2.Text = "| รวมเป็นเงิน"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(239, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 16)
        Me.Label5.TabIndex = 597
        Me.Label5.Text = "| จำนวนบิล"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnSFindAll)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(99, 35)
        Me.Panel2.TabIndex = 588
        '
        'btnSFindAll
        '
        Me.btnSFindAll.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSFindAll.Appearance.Options.UseFont = True
        Me.btnSFindAll.Image = CType(resources.GetObject("btnSFindAll.Image"), System.Drawing.Image)
        Me.btnSFindAll.Location = New System.Drawing.Point(1, 3)
        Me.btnSFindAll.Name = "btnSFindAll"
        Me.btnSFindAll.Size = New System.Drawing.Size(97, 30)
        Me.btnSFindAll.TabIndex = 0
        Me.btnSFindAll.Text = "Refresh"
        '
        'FrmSlSaleDataSH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 551)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmSlSaleDataSH"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ข้อมูลการขายโสหุ้ย"
        CType(Me.GVSaleDt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVSaleMt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptShow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptDoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptCancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdbDateTs As RadioButton
    Friend WithEvents rdbDateSale As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dtpMonthNow As DateTimePicker
    Friend WithEvents dtpMonthE As DateTimePicker
    Friend WithEvents dtpMonthS As DateTimePicker
    Friend WithEvents rdbMonthNow As RadioButton
    Friend WithEvents dtpSaleE As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpYear As DateTimePicker
    Friend WithEvents rdbYear As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents rdbMonth As RadioButton
    Friend WithEvents rdbDate As RadioButton
    Friend WithEvents dtpSaleS As DateTimePicker
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents txtCountDt As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTotalNet As TextBox
    Friend WithEvents txtCount As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnSFindAll As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVSaleDt As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colidSaleDt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colidProduct As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colidLot As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colidWh As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColPdCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColLotNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColProductName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColAmount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColUnit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColWareHouseName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDiscount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDiscountBath As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColExp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDocCode_PO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GVSaleMt As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColNum As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColEdit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDoc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColidSale As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDocRef1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDateSale1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDatePay1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColCusName1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColTotalNet1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDocCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDocRefAcc1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColPsTs1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDateTs1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColTimeTs1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColNote1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rptDoc As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents ColidComp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColidPsCancel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColCompName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColPsCancel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColCancel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rptCancel As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents ColCancelNote As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColView As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rptEdit As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents rptShow As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txtCusName As TextBox
    Friend WithEvents chkComp As CheckBox
    Friend WithEvents cmbGroupComp As ComboBox
    Friend WithEvents ChkCus As CheckBox
    Friend WithEvents ColidJobMt As DevExpress.XtraGrid.Columns.GridColumn
End Class
