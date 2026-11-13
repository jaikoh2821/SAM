<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmWaitCrateBillSH
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmWaitCrateBillSH))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.GVWaitCrateBillDt = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColNum = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColInvName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColAmountWait = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColUnitName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColNote = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ClidJobMt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCWaitCrateBill = New DevExpress.XtraGrid.GridControl()
        Me.GVWaitCrateBillMt = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rptBtnCrateBill = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.clCompCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.clDocCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColidJobMt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColidComp = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCount = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnShowdata = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtJobNo = New DevExpress.XtraEditors.TextEdit()
        Me.cbJobNo = New DevExpress.XtraEditors.CheckEdit()
        Me.txtFarmer = New DevExpress.XtraEditors.TextEdit()
        Me.cbFarmer = New DevExpress.XtraEditors.CheckEdit()
        Me.chkComp = New DevExpress.XtraEditors.CheckEdit()
        Me.cmbGroupComp = New System.Windows.Forms.ComboBox()
        Me.txtDocCode = New DevExpress.XtraEditors.TextEdit()
        Me.chkDocCode = New DevExpress.XtraEditors.CheckEdit()
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
        CType(Me.GVWaitCrateBillDt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCWaitCrateBill, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVWaitCrateBillMt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptBtnCrateBill, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.txtJobNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbJobNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFarmer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbFarmer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkComp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDocCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkDocCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDateOrder.SuspendLayout()
        Me.SuspendLayout()
        '
        'GVWaitCrateBillDt
        '
        Me.GVWaitCrateBillDt.Appearance.FocusedCell.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GVWaitCrateBillDt.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVWaitCrateBillDt.Appearance.FocusedRow.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GVWaitCrateBillDt.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVWaitCrateBillDt.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVWaitCrateBillDt.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVWaitCrateBillDt.ColumnPanelRowHeight = 25
        Me.GVWaitCrateBillDt.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColNum, Me.ColInvName, Me.ColAmountWait, Me.ColUnitName, Me.ColPrice, Me.ColNote, Me.ClidJobMt})
        Me.GVWaitCrateBillDt.GridControl = Me.GCWaitCrateBill
        Me.GVWaitCrateBillDt.Name = "GVWaitCrateBillDt"
        Me.GVWaitCrateBillDt.OptionsView.ShowGroupPanel = False
        Me.GVWaitCrateBillDt.RowHeight = 22
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
        Me.ColNum.MaxWidth = 55
        Me.ColNum.MinWidth = 55
        Me.ColNum.Name = "ColNum"
        Me.ColNum.OptionsColumn.AllowEdit = False
        Me.ColNum.OptionsColumn.ReadOnly = True
        Me.ColNum.Visible = True
        Me.ColNum.VisibleIndex = 0
        Me.ColNum.Width = 55
        '
        'ColInvName
        '
        Me.ColInvName.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColInvName.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColInvName.AppearanceCell.Options.UseBackColor = True
        Me.ColInvName.AppearanceCell.Options.UseFont = True
        Me.ColInvName.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColInvName.AppearanceHeader.Options.UseFont = True
        Me.ColInvName.Caption = "รายการโสหุ้ย"
        Me.ColInvName.FieldName = "InvName"
        Me.ColInvName.MinWidth = 120
        Me.ColInvName.Name = "ColInvName"
        Me.ColInvName.OptionsColumn.AllowEdit = False
        Me.ColInvName.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.ColInvName.Visible = True
        Me.ColInvName.VisibleIndex = 1
        Me.ColInvName.Width = 893
        '
        'ColAmountWait
        '
        Me.ColAmountWait.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ColAmountWait.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColAmountWait.AppearanceCell.Options.UseBackColor = True
        Me.ColAmountWait.AppearanceCell.Options.UseFont = True
        Me.ColAmountWait.AppearanceCell.Options.UseTextOptions = True
        Me.ColAmountWait.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ColAmountWait.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColAmountWait.AppearanceHeader.Options.UseFont = True
        Me.ColAmountWait.Caption = "จำนวนเบิก"
        Me.ColAmountWait.DisplayFormat.FormatString = "#,##0.00####"
        Me.ColAmountWait.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.ColAmountWait.FieldName = "shAmount"
        Me.ColAmountWait.Name = "ColAmountWait"
        Me.ColAmountWait.OptionsColumn.AllowEdit = False
        Me.ColAmountWait.OptionsColumn.FixedWidth = True
        Me.ColAmountWait.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.ColAmountWait.Visible = True
        Me.ColAmountWait.VisibleIndex = 2
        Me.ColAmountWait.Width = 151
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
        Me.ColUnitName.Caption = "หน่วย"
        Me.ColUnitName.FieldName = "UnitName"
        Me.ColUnitName.Name = "ColUnitName"
        Me.ColUnitName.OptionsColumn.AllowEdit = False
        Me.ColUnitName.OptionsColumn.FixedWidth = True
        Me.ColUnitName.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.ColUnitName.Visible = True
        Me.ColUnitName.VisibleIndex = 3
        Me.ColUnitName.Width = 109
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
        Me.ColPrice.Caption = "ราคา"
        Me.ColPrice.DisplayFormat.FormatString = "#,##0.00####"
        Me.ColPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.ColPrice.FieldName = "shPrice"
        Me.ColPrice.Name = "ColPrice"
        Me.ColPrice.OptionsColumn.AllowEdit = False
        Me.ColPrice.OptionsColumn.ReadOnly = True
        Me.ColPrice.Visible = True
        Me.ColPrice.VisibleIndex = 4
        Me.ColPrice.Width = 182
        '
        'ColNote
        '
        Me.ColNote.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColNote.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ColNote.AppearanceCell.Options.UseBackColor = True
        Me.ColNote.AppearanceCell.Options.UseFont = True
        Me.ColNote.AppearanceCell.Options.UseTextOptions = True
        Me.ColNote.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ColNote.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColNote.AppearanceHeader.Options.UseFont = True
        Me.ColNote.Caption = "รวมเป็นเงิน"
        Me.ColNote.DisplayFormat.FormatString = "#,##0.00####"
        Me.ColNote.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.ColNote.FieldName = "TotalDt"
        Me.ColNote.Name = "ColNote"
        Me.ColNote.OptionsColumn.AllowEdit = False
        Me.ColNote.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.ColNote.Visible = True
        Me.ColNote.VisibleIndex = 5
        Me.ColNote.Width = 242
        '
        'ClidJobMt
        '
        Me.ClidJobMt.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ClidJobMt.AppearanceCell.Options.UseFont = True
        Me.ClidJobMt.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ClidJobMt.AppearanceHeader.Options.UseFont = True
        Me.ClidJobMt.Caption = "idJobMt"
        Me.ClidJobMt.FieldName = "idJobMt"
        Me.ClidJobMt.Name = "ClidJobMt"
        Me.ClidJobMt.OptionsColumn.AllowEdit = False
        Me.ClidJobMt.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
        Me.ClidJobMt.Width = 74
        '
        'GCWaitCrateBill
        '
        Me.GCWaitCrateBill.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode1.LevelTemplate = Me.GVWaitCrateBillDt
        GridLevelNode1.RelationName = "detailRec"
        Me.GCWaitCrateBill.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.GCWaitCrateBill.Location = New System.Drawing.Point(0, 147)
        Me.GCWaitCrateBill.MainView = Me.GVWaitCrateBillMt
        Me.GCWaitCrateBill.Name = "GCWaitCrateBill"
        Me.GCWaitCrateBill.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rptBtnCrateBill})
        Me.GCWaitCrateBill.Size = New System.Drawing.Size(1184, 404)
        Me.GCWaitCrateBill.TabIndex = 216
        Me.GCWaitCrateBill.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVWaitCrateBillMt, Me.GVWaitCrateBillDt})
        '
        'GVWaitCrateBillMt
        '
        Me.GVWaitCrateBillMt.Appearance.FocusedCell.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GVWaitCrateBillMt.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVWaitCrateBillMt.Appearance.FocusedRow.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GVWaitCrateBillMt.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVWaitCrateBillMt.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVWaitCrateBillMt.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVWaitCrateBillMt.Appearance.HideSelectionRow.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GVWaitCrateBillMt.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVWaitCrateBillMt.Appearance.SelectedRow.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GVWaitCrateBillMt.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVWaitCrateBillMt.ColumnPanelRowHeight = 35
        Me.GVWaitCrateBillMt.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSel, Me.clCompCode, Me.clDocCode, Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.ColidJobMt, Me.ColidComp})
        Me.GVWaitCrateBillMt.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GVWaitCrateBillMt.GridControl = Me.GCWaitCrateBill
        Me.GVWaitCrateBillMt.Name = "GVWaitCrateBillMt"
        Me.GVWaitCrateBillMt.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GVWaitCrateBillMt.OptionsView.ShowGroupPanel = False
        Me.GVWaitCrateBillMt.RowHeight = 22
        '
        'colSel
        '
        Me.colSel.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.colSel.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.colSel.AppearanceCell.Options.UseBackColor = True
        Me.colSel.AppearanceCell.Options.UseFont = True
        Me.colSel.AppearanceCell.Options.UseTextOptions = True
        Me.colSel.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colSel.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.colSel.AppearanceHeader.Options.UseFont = True
        Me.colSel.AppearanceHeader.Options.UseTextOptions = True
        Me.colSel.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSel.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colSel.Caption = "สร้างบิลขาย"
        Me.colSel.ColumnEdit = Me.rptBtnCrateBill
        Me.colSel.MaxWidth = 50
        Me.colSel.MinWidth = 50
        Me.colSel.Name = "colSel"
        Me.colSel.Visible = True
        Me.colSel.VisibleIndex = 0
        Me.colSel.Width = 50
        '
        'rptBtnCrateBill
        '
        Me.rptBtnCrateBill.AutoHeight = False
        Me.rptBtnCrateBill.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("rptBtnCrateBill.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.rptBtnCrateBill.Name = "rptBtnCrateBill"
        Me.rptBtnCrateBill.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'clCompCode
        '
        Me.clCompCode.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.clCompCode.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.clCompCode.AppearanceCell.Options.UseBackColor = True
        Me.clCompCode.AppearanceCell.Options.UseFont = True
        Me.clCompCode.AppearanceCell.Options.UseTextOptions = True
        Me.clCompCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.clCompCode.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.clCompCode.AppearanceHeader.Options.UseFont = True
        Me.clCompCode.AppearanceHeader.Options.UseTextOptions = True
        Me.clCompCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.clCompCode.Caption = "บริษัท"
        Me.clCompCode.FieldName = "CompCode"
        Me.clCompCode.MaxWidth = 55
        Me.clCompCode.MinWidth = 55
        Me.clCompCode.Name = "clCompCode"
        Me.clCompCode.OptionsColumn.AllowEdit = False
        Me.clCompCode.OptionsColumn.FixedWidth = True
        Me.clCompCode.OptionsColumn.ReadOnly = True
        Me.clCompCode.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.clCompCode.Visible = True
        Me.clCompCode.VisibleIndex = 1
        Me.clCompCode.Width = 50
        '
        'clDocCode
        '
        Me.clDocCode.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.clDocCode.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.clDocCode.AppearanceCell.Options.UseBackColor = True
        Me.clDocCode.AppearanceCell.Options.UseFont = True
        Me.clDocCode.AppearanceCell.Options.UseTextOptions = True
        Me.clDocCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.clDocCode.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.clDocCode.AppearanceHeader.Options.UseFont = True
        Me.clDocCode.AppearanceHeader.Options.UseTextOptions = True
        Me.clDocCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.clDocCode.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.clDocCode.Caption = "เลขที่เอกสารเบิกโสหุ้ย"
        Me.clDocCode.FieldName = "RecCode"
        Me.clDocCode.MaxWidth = 87
        Me.clDocCode.MinWidth = 87
        Me.clDocCode.Name = "clDocCode"
        Me.clDocCode.OptionsColumn.AllowEdit = False
        Me.clDocCode.OptionsColumn.FixedWidth = True
        Me.clDocCode.OptionsColumn.ReadOnly = True
        Me.clDocCode.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.clDocCode.Visible = True
        Me.clDocCode.VisibleIndex = 3
        Me.clDocCode.Width = 65
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GridColumn1.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.GridColumn1.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn1.AppearanceCell.Options.UseFont = True
        Me.GridColumn1.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GridColumn1.AppearanceHeader.Options.UseFont = True
        Me.GridColumn1.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.Caption = "วันที่เบิกโสหุ้ย"
        Me.GridColumn1.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.GridColumn1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn1.FieldName = "RecDate"
        Me.GridColumn1.MaxWidth = 85
        Me.GridColumn1.MinWidth = 85
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 2
        Me.GridColumn1.Width = 85
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GridColumn2.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.GridColumn2.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn2.AppearanceCell.Options.UseFont = True
        Me.GridColumn2.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GridColumn2.AppearanceHeader.Options.UseFont = True
        Me.GridColumn2.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.Caption = "Job No."
        Me.GridColumn2.FieldName = "JobNo"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.OptionsColumn.ReadOnly = True
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 5
        Me.GridColumn2.Width = 156
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GridColumn3.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.GridColumn3.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn3.AppearanceCell.Options.UseFont = True
        Me.GridColumn3.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GridColumn3.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GridColumn3.AppearanceHeader.Options.UseFont = True
        Me.GridColumn3.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn3.Caption = "เกษตรกร"
        Me.GridColumn3.FieldName = "PartnerName"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.OptionsColumn.ReadOnly = True
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 4
        Me.GridColumn3.Width = 316
        '
        'GridColumn4
        '
        Me.GridColumn4.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GridColumn4.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.GridColumn4.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn4.AppearanceCell.Options.UseFont = True
        Me.GridColumn4.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GridColumn4.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GridColumn4.AppearanceHeader.Options.UseFont = True
        Me.GridColumn4.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn4.Caption = "รหัสพันธุ์"
        Me.GridColumn4.FieldName = "StrainCode"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.AllowEdit = False
        Me.GridColumn4.OptionsColumn.ReadOnly = True
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 6
        Me.GridColumn4.Width = 156
        '
        'GridColumn5
        '
        Me.GridColumn5.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GridColumn5.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.GridColumn5.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn5.AppearanceCell.Options.UseFont = True
        Me.GridColumn5.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GridColumn5.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GridColumn5.AppearanceHeader.Options.UseFont = True
        Me.GridColumn5.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn5.Caption = "พืช"
        Me.GridColumn5.FieldName = "Seed"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.AllowEdit = False
        Me.GridColumn5.OptionsColumn.ReadOnly = True
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 7
        Me.GridColumn5.Width = 214
        '
        'GridColumn6
        '
        Me.GridColumn6.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GridColumn6.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.GridColumn6.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn6.AppearanceCell.Options.UseFont = True
        Me.GridColumn6.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn6.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GridColumn6.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GridColumn6.AppearanceHeader.Options.UseFont = True
        Me.GridColumn6.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn6.Caption = "หมายเหตุ"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.AllowEdit = False
        Me.GridColumn6.OptionsColumn.ReadOnly = True
        Me.GridColumn6.Width = 141
        '
        'GridColumn7
        '
        Me.GridColumn7.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GridColumn7.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.GridColumn7.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn7.AppearanceCell.Options.UseFont = True
        Me.GridColumn7.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn7.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GridColumn7.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GridColumn7.AppearanceHeader.Options.UseFont = True
        Me.GridColumn7.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn7.Caption = "ผู้ทำรายการ"
        Me.GridColumn7.FieldName = "PsTs"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsColumn.AllowEdit = False
        Me.GridColumn7.OptionsColumn.ReadOnly = True
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 8
        Me.GridColumn7.Width = 183
        '
        'GridColumn8
        '
        Me.GridColumn8.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GridColumn8.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.GridColumn8.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn8.AppearanceCell.Options.UseFont = True
        Me.GridColumn8.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn8.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn8.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GridColumn8.AppearanceHeader.Options.UseFont = True
        Me.GridColumn8.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn8.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn8.Caption = "รวมเป็นเงิน"
        Me.GridColumn8.DisplayFormat.FormatString = "#,##0.00####"
        Me.GridColumn8.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.GridColumn8.FieldName = "TotalMt"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsColumn.AllowEdit = False
        Me.GridColumn8.OptionsColumn.ReadOnly = True
        Me.GridColumn8.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalMt", "SUM={0:0.##}")})
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 9
        Me.GridColumn8.Width = 191
        '
        'ColidJobMt
        '
        Me.ColidJobMt.Caption = "idJobMt"
        Me.ColidJobMt.FieldName = "idJobMt"
        Me.ColidJobMt.Name = "ColidJobMt"
        '
        'ColidComp
        '
        Me.ColidComp.Caption = "idComp"
        Me.ColidComp.FieldName = "idComp"
        Me.ColidComp.Name = "ColidComp"
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.LabelControl9.Appearance.BackColor2 = System.Drawing.SystemColors.ActiveCaption
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl9.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.LabelControl9.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl9.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelControl9.Location = New System.Drawing.Point(0, 122)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.LabelControl9.Size = New System.Drawing.Size(1184, 25)
        Me.LabelControl9.TabIndex = 217
        Me.LabelControl9.Text = "รายการเบิกโสหุ้ย รอสร้างใบแจ้งหนี้/ใบวางบิล"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.btnShowdata)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 91)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1184, 31)
        Me.Panel1.TabIndex = 215
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.txtCount)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(914, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(270, 31)
        Me.Panel3.TabIndex = 601
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(207, 8)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 16)
        Me.Label8.TabIndex = 602
        Me.Label8.Text = "รายการ"
        '
        'txtCount
        '
        Me.txtCount.BackColor = System.Drawing.Color.Black
        Me.txtCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCount.ForeColor = System.Drawing.Color.Lime
        Me.txtCount.Location = New System.Drawing.Point(121, 4)
        Me.txtCount.Name = "txtCount"
        Me.txtCount.ReadOnly = True
        Me.txtCount.Size = New System.Drawing.Size(86, 24)
        Me.txtCount.TabIndex = 601
        Me.txtCount.Text = "0"
        Me.txtCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(6, 8)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(109, 16)
        Me.Label9.TabIndex = 600
        Me.Label9.Text = "จำนวนรายการรอ"
        '
        'btnShowdata
        '
        Me.btnShowdata.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowdata.Appearance.Options.UseFont = True
        Me.btnShowdata.Image = CType(resources.GetObject("btnShowdata.Image"), System.Drawing.Image)
        Me.btnShowdata.Location = New System.Drawing.Point(5, 2)
        Me.btnShowdata.Name = "btnShowdata"
        Me.btnShowdata.Size = New System.Drawing.Size(105, 27)
        Me.btnShowdata.TabIndex = 0
        Me.btnShowdata.Text = "Refresh"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel2.Controls.Add(Me.GroupBox2)
        Me.Panel2.Controls.Add(Me.gbDateOrder)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1184, 91)
        Me.Panel2.TabIndex = 214
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtJobNo)
        Me.GroupBox2.Controls.Add(Me.cbJobNo)
        Me.GroupBox2.Controls.Add(Me.txtFarmer)
        Me.GroupBox2.Controls.Add(Me.cbFarmer)
        Me.GroupBox2.Controls.Add(Me.chkComp)
        Me.GroupBox2.Controls.Add(Me.cmbGroupComp)
        Me.GroupBox2.Controls.Add(Me.txtDocCode)
        Me.GroupBox2.Controls.Add(Me.chkDocCode)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(441, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(731, 79)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ค้นหาตาม"
        '
        'txtJobNo
        '
        Me.txtJobNo.Enabled = False
        Me.txtJobNo.Location = New System.Drawing.Point(417, 48)
        Me.txtJobNo.Name = "txtJobNo"
        Me.txtJobNo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJobNo.Properties.Appearance.Options.UseFont = True
        Me.txtJobNo.Size = New System.Drawing.Size(208, 20)
        Me.txtJobNo.TabIndex = 201
        '
        'cbJobNo
        '
        Me.cbJobNo.Location = New System.Drawing.Point(344, 47)
        Me.cbJobNo.Name = "cbJobNo"
        Me.cbJobNo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbJobNo.Properties.Appearance.Options.UseFont = True
        Me.cbJobNo.Properties.Caption = "Job No."
        Me.cbJobNo.Size = New System.Drawing.Size(67, 19)
        Me.cbJobNo.TabIndex = 202
        '
        'txtFarmer
        '
        Me.txtFarmer.Enabled = False
        Me.txtFarmer.Location = New System.Drawing.Point(417, 22)
        Me.txtFarmer.Name = "txtFarmer"
        Me.txtFarmer.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFarmer.Properties.Appearance.Options.UseFont = True
        Me.txtFarmer.Size = New System.Drawing.Size(208, 20)
        Me.txtFarmer.TabIndex = 199
        '
        'cbFarmer
        '
        Me.cbFarmer.Location = New System.Drawing.Point(344, 21)
        Me.cbFarmer.Name = "cbFarmer"
        Me.cbFarmer.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFarmer.Properties.Appearance.Options.UseFont = True
        Me.cbFarmer.Properties.Caption = "เกษตรกร"
        Me.cbFarmer.Size = New System.Drawing.Size(67, 19)
        Me.cbFarmer.TabIndex = 200
        '
        'chkComp
        '
        Me.chkComp.Location = New System.Drawing.Point(20, 21)
        Me.chkComp.Name = "chkComp"
        Me.chkComp.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkComp.Properties.Appearance.Options.UseFont = True
        Me.chkComp.Properties.Caption = "บริษัท"
        Me.chkComp.Size = New System.Drawing.Size(57, 19)
        Me.chkComp.TabIndex = 197
        '
        'cmbGroupComp
        '
        Me.cmbGroupComp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGroupComp.Enabled = False
        Me.cmbGroupComp.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmbGroupComp.FormattingEnabled = True
        Me.cmbGroupComp.Location = New System.Drawing.Point(106, 20)
        Me.cmbGroupComp.Name = "cmbGroupComp"
        Me.cmbGroupComp.Size = New System.Drawing.Size(208, 22)
        Me.cmbGroupComp.TabIndex = 5
        '
        'txtDocCode
        '
        Me.txtDocCode.Enabled = False
        Me.txtDocCode.Location = New System.Drawing.Point(106, 49)
        Me.txtDocCode.Name = "txtDocCode"
        Me.txtDocCode.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDocCode.Properties.Appearance.Options.UseFont = True
        Me.txtDocCode.Size = New System.Drawing.Size(208, 20)
        Me.txtDocCode.TabIndex = 182
        '
        'chkDocCode
        '
        Me.chkDocCode.Location = New System.Drawing.Point(20, 48)
        Me.chkDocCode.Name = "chkDocCode"
        Me.chkDocCode.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDocCode.Properties.Appearance.Options.UseFont = True
        Me.chkDocCode.Properties.Caption = "เลขที่เอกสาร"
        Me.chkDocCode.Size = New System.Drawing.Size(84, 19)
        Me.chkDocCode.TabIndex = 198
        '
        'gbDateOrder
        '
        Me.gbDateOrder.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
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
        Me.gbDateOrder.Location = New System.Drawing.Point(12, 3)
        Me.gbDateOrder.Name = "gbDateOrder"
        Me.gbDateOrder.Size = New System.Drawing.Size(424, 82)
        Me.gbDateOrder.TabIndex = 0
        Me.gbDateOrder.TabStop = False
        Me.gbDateOrder.Text = "วันที่เบิกโสหุ้ย"
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
        'FrmWaitCrateBillSH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 551)
        Me.Controls.Add(Me.GCWaitCrateBill)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmWaitCrateBillSH"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "สร้างใบแจ้งหนี้/ใบวางบิล สินค้าโสหุ้ย"
        CType(Me.GVWaitCrateBillDt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCWaitCrateBill, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVWaitCrateBillMt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptBtnCrateBill, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.txtJobNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbJobNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFarmer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbFarmer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkComp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDocCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkDocCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDateOrder.ResumeLayout(False)
        Me.gbDateOrder.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GCWaitCrateBill As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVWaitCrateBillDt As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColNum As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColInvName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColAmountWait As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColUnitName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColNote As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ClidJobMt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GVWaitCrateBillMt As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rptBtnCrateBill As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents clCompCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clDocCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnShowdata As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents chkComp As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cmbGroupComp As ComboBox
    Friend WithEvents txtDocCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents chkDocCode As DevExpress.XtraEditors.CheckEdit
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
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtJobNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cbJobNo As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtFarmer As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cbFarmer As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ColidJobMt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColidComp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents txtCount As TextBox
    Friend WithEvents Label9 As Label
End Class
