<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDebtorData
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
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDebtorData))
        Me.GVLog = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColNum2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColidCus2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDateBF2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColAmount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColPsTs = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDateTs = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCData = New DevExpress.XtraGrid.GridControl()
        Me.GvShowData = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColidCus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColNum = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColCusName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColAdd = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rbeditDebt = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.ColAmtDebt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDateBF = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColstActive = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lblSumDebt = New System.Windows.Forms.Label()
        Me.txtCusName = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btnSFindAll = New System.Windows.Forms.Button()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbGroupComp = New System.Windows.Forms.ComboBox()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        CType(Me.GVLog, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GvShowData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rbeditDebt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GVLog
        '
        Me.GVLog.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColNum2, Me.ColidCus2, Me.ColDateBF2, Me.ColAmount, Me.ColPsTs, Me.ColDateTs})
        Me.GVLog.GridControl = Me.GCData
        Me.GVLog.Name = "GVLog"
        Me.GVLog.OptionsView.ShowGroupPanel = False
        Me.GVLog.OptionsView.ShowIndicator = False
        '
        'ColNum2
        '
        Me.ColNum2.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColNum2.AppearanceCell.Options.UseBackColor = True
        Me.ColNum2.AppearanceCell.Options.UseTextOptions = True
        Me.ColNum2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColNum2.AppearanceHeader.Options.UseTextOptions = True
        Me.ColNum2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColNum2.Caption = "ลำดับ"
        Me.ColNum2.FieldName = "Num"
        Me.ColNum2.MaxWidth = 60
        Me.ColNum2.MinWidth = 50
        Me.ColNum2.Name = "ColNum2"
        Me.ColNum2.OptionsColumn.AllowEdit = False
        Me.ColNum2.OptionsColumn.ReadOnly = True
        Me.ColNum2.Width = 60
        '
        'ColidCus2
        '
        Me.ColidCus2.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColidCus2.AppearanceCell.Options.UseBackColor = True
        Me.ColidCus2.AppearanceHeader.Options.UseTextOptions = True
        Me.ColidCus2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColidCus2.Caption = "idCus"
        Me.ColidCus2.FieldName = "idCus"
        Me.ColidCus2.Name = "ColidCus2"
        Me.ColidCus2.OptionsColumn.AllowEdit = False
        Me.ColidCus2.OptionsColumn.ReadOnly = True
        '
        'ColDateBF2
        '
        Me.ColDateBF2.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColDateBF2.AppearanceCell.Options.UseBackColor = True
        Me.ColDateBF2.AppearanceCell.Options.UseTextOptions = True
        Me.ColDateBF2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDateBF2.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDateBF2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDateBF2.Caption = "วันที่ยกยอด"
        Me.ColDateBF2.FieldName = "DateBF"
        Me.ColDateBF2.MaxWidth = 150
        Me.ColDateBF2.MinWidth = 150
        Me.ColDateBF2.Name = "ColDateBF2"
        Me.ColDateBF2.OptionsColumn.AllowEdit = False
        Me.ColDateBF2.OptionsColumn.ReadOnly = True
        Me.ColDateBF2.Visible = True
        Me.ColDateBF2.VisibleIndex = 0
        Me.ColDateBF2.Width = 150
        '
        'ColAmount
        '
        Me.ColAmount.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ColAmount.AppearanceCell.Options.UseBackColor = True
        Me.ColAmount.AppearanceCell.Options.UseTextOptions = True
        Me.ColAmount.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ColAmount.AppearanceHeader.Options.UseTextOptions = True
        Me.ColAmount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColAmount.Caption = "ยอดยกมา"
        Me.ColAmount.DisplayFormat.FormatString = "#,##0.00##"
        Me.ColAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.ColAmount.FieldName = "AmountTs"
        Me.ColAmount.Name = "ColAmount"
        Me.ColAmount.OptionsColumn.AllowEdit = False
        Me.ColAmount.OptionsColumn.ReadOnly = True
        Me.ColAmount.Visible = True
        Me.ColAmount.VisibleIndex = 1
        '
        'ColPsTs
        '
        Me.ColPsTs.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColPsTs.AppearanceCell.Options.UseBackColor = True
        Me.ColPsTs.AppearanceHeader.Options.UseTextOptions = True
        Me.ColPsTs.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColPsTs.Caption = "ผู้ทำรายการ"
        Me.ColPsTs.FieldName = "PsTs"
        Me.ColPsTs.MaxWidth = 190
        Me.ColPsTs.MinWidth = 170
        Me.ColPsTs.Name = "ColPsTs"
        Me.ColPsTs.OptionsColumn.AllowEdit = False
        Me.ColPsTs.OptionsColumn.ReadOnly = True
        Me.ColPsTs.Visible = True
        Me.ColPsTs.VisibleIndex = 2
        Me.ColPsTs.Width = 170
        '
        'ColDateTs
        '
        Me.ColDateTs.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColDateTs.AppearanceCell.Options.UseBackColor = True
        Me.ColDateTs.AppearanceCell.Options.UseTextOptions = True
        Me.ColDateTs.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDateTs.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDateTs.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDateTs.Caption = "วันที่ทำรายการ"
        Me.ColDateTs.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss"
        Me.ColDateTs.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.ColDateTs.FieldName = "DateTs"
        Me.ColDateTs.MaxWidth = 170
        Me.ColDateTs.MinWidth = 150
        Me.ColDateTs.Name = "ColDateTs"
        Me.ColDateTs.OptionsColumn.AllowEdit = False
        Me.ColDateTs.OptionsColumn.ReadOnly = True
        Me.ColDateTs.Visible = True
        Me.ColDateTs.VisibleIndex = 3
        Me.ColDateTs.Width = 150
        '
        'GCData
        '
        Me.GCData.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode1.LevelTemplate = Me.GVLog
        GridLevelNode1.RelationName = "Level1"
        Me.GCData.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.GCData.Location = New System.Drawing.Point(0, 76)
        Me.GCData.MainView = Me.GvShowData
        Me.GCData.Name = "GCData"
        Me.GCData.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rbeditDebt})
        Me.GCData.Size = New System.Drawing.Size(884, 475)
        Me.GCData.TabIndex = 603
        Me.GCData.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GvShowData, Me.GVLog})
        '
        'GvShowData
        '
        Me.GvShowData.ColumnPanelRowHeight = 34
        Me.GvShowData.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColidCus, Me.ColNum, Me.ColCusName, Me.ColAdd, Me.ColAmtDebt, Me.ColDateBF, Me.ColstActive})
        Me.GvShowData.GridControl = Me.GCData
        Me.GvShowData.Name = "GvShowData"
        Me.GvShowData.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GvShowData.OptionsView.ShowGroupPanel = False
        Me.GvShowData.OptionsView.ShowIndicator = False
        '
        'ColidCus
        '
        Me.ColidCus.Caption = "idCus"
        Me.ColidCus.FieldName = "idCus"
        Me.ColidCus.Name = "ColidCus"
        '
        'ColNum
        '
        Me.ColNum.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColNum.AppearanceCell.Options.UseBackColor = True
        Me.ColNum.AppearanceCell.Options.UseTextOptions = True
        Me.ColNum.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColNum.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColNum.AppearanceHeader.Options.UseFont = True
        Me.ColNum.AppearanceHeader.Options.UseTextOptions = True
        Me.ColNum.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColNum.Caption = "ลำดับ"
        Me.ColNum.FieldName = "Num"
        Me.ColNum.MaxWidth = 60
        Me.ColNum.MinWidth = 50
        Me.ColNum.Name = "ColNum"
        Me.ColNum.OptionsColumn.AllowEdit = False
        Me.ColNum.OptionsColumn.ReadOnly = True
        Me.ColNum.Visible = True
        Me.ColNum.VisibleIndex = 0
        Me.ColNum.Width = 50
        '
        'ColCusName
        '
        Me.ColCusName.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColCusName.AppearanceCell.Options.UseBackColor = True
        Me.ColCusName.AppearanceCell.Options.UseTextOptions = True
        Me.ColCusName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.ColCusName.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColCusName.AppearanceHeader.Options.UseFont = True
        Me.ColCusName.AppearanceHeader.Options.UseTextOptions = True
        Me.ColCusName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColCusName.Caption = "ชื่อลูกค้า"
        Me.ColCusName.FieldName = "CusName_"
        Me.ColCusName.Name = "ColCusName"
        Me.ColCusName.OptionsColumn.AllowEdit = False
        Me.ColCusName.OptionsColumn.ReadOnly = True
        Me.ColCusName.Visible = True
        Me.ColCusName.VisibleIndex = 2
        Me.ColCusName.Width = 426
        '
        'ColAdd
        '
        Me.ColAdd.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColAdd.AppearanceHeader.Options.UseFont = True
        Me.ColAdd.AppearanceHeader.Options.UseTextOptions = True
        Me.ColAdd.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColAdd.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColAdd.Caption = "ยกยอดหนี้"
        Me.ColAdd.ColumnEdit = Me.rbeditDebt
        Me.ColAdd.MaxWidth = 55
        Me.ColAdd.MinWidth = 55
        Me.ColAdd.Name = "ColAdd"
        Me.ColAdd.Visible = True
        Me.ColAdd.VisibleIndex = 1
        Me.ColAdd.Width = 55
        '
        'rbeditDebt
        '
        Me.rbeditDebt.AutoHeight = False
        Me.rbeditDebt.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Global.SAM.My.Resources.Resources.bended_arrow_icon, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.rbeditDebt.Name = "rbeditDebt"
        Me.rbeditDebt.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'ColAmtDebt
        '
        Me.ColAmtDebt.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ColAmtDebt.AppearanceCell.Options.UseBackColor = True
        Me.ColAmtDebt.AppearanceCell.Options.UseTextOptions = True
        Me.ColAmtDebt.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ColAmtDebt.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColAmtDebt.AppearanceHeader.Options.UseFont = True
        Me.ColAmtDebt.AppearanceHeader.Options.UseTextOptions = True
        Me.ColAmtDebt.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColAmtDebt.Caption = "ยอดหนี้คงเหลือ"
        Me.ColAmtDebt.DisplayFormat.FormatString = "#,##0.00##"
        Me.ColAmtDebt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.ColAmtDebt.FieldName = "DebtBalance"
        Me.ColAmtDebt.MinWidth = 130
        Me.ColAmtDebt.Name = "ColAmtDebt"
        Me.ColAmtDebt.OptionsColumn.AllowEdit = False
        Me.ColAmtDebt.OptionsColumn.ReadOnly = True
        Me.ColAmtDebt.Visible = True
        Me.ColAmtDebt.VisibleIndex = 3
        Me.ColAmtDebt.Width = 193
        '
        'ColDateBF
        '
        Me.ColDateBF.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColDateBF.AppearanceCell.Options.UseBackColor = True
        Me.ColDateBF.AppearanceCell.Options.UseTextOptions = True
        Me.ColDateBF.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDateBF.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ColDateBF.AppearanceHeader.Options.UseFont = True
        Me.ColDateBF.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDateBF.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDateBF.Caption = "วันที่ยกยอด"
        Me.ColDateBF.FieldName = "DateBF"
        Me.ColDateBF.MinWidth = 80
        Me.ColDateBF.Name = "ColDateBF"
        Me.ColDateBF.OptionsColumn.AllowEdit = False
        Me.ColDateBF.OptionsColumn.ReadOnly = True
        Me.ColDateBF.Width = 80
        '
        'ColstActive
        '
        Me.ColstActive.Caption = "stActive"
        Me.ColstActive.FieldName = "stActive"
        Me.ColstActive.Name = "ColstActive"
        '
        'lblSumDebt
        '
        Me.lblSumDebt.BackColor = System.Drawing.Color.Transparent
        Me.lblSumDebt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblSumDebt.ForeColor = System.Drawing.Color.Red
        Me.lblSumDebt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblSumDebt.Location = New System.Drawing.Point(7, 11)
        Me.lblSumDebt.Name = "lblSumDebt"
        Me.lblSumDebt.Size = New System.Drawing.Size(287, 25)
        Me.lblSumDebt.TabIndex = 655
        Me.lblSumDebt.Text = "ยอดหนี้รวม : "
        Me.lblSumDebt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCusName
        '
        Me.txtCusName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtCusName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtCusName.Location = New System.Drawing.Point(395, 14)
        Me.txtCusName.MaxLength = 11
        Me.txtCusName.Name = "txtCusName"
        Me.txtCusName.Size = New System.Drawing.Size(158, 20)
        Me.txtCusName.TabIndex = 2
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(317, 15)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(75, 16)
        Me.Label24.TabIndex = 577
        Me.Label24.Text = "ค้นหาลูกค้า :"
        '
        'lblCount
        '
        Me.lblCount.BackColor = System.Drawing.Color.Transparent
        Me.lblCount.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblCount.Font = New System.Drawing.Font("JasmineUPC", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblCount.ForeColor = System.Drawing.Color.White
        Me.lblCount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblCount.Location = New System.Drawing.Point(696, 0)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(188, 30)
        Me.lblCount.TabIndex = 583
        Me.lblCount.Text = "       จำนวนลูกค้า 0 ราย"
        Me.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("JasmineUPC", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.Location = New System.Drawing.Point(154, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(204, 23)
        Me.Label3.TabIndex = 582
        Me.Label3.Text = ": ลูกค้าที่มีสถานะไม่ Active"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.LightPink
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Location = New System.Drawing.Point(123, 5)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(28, 20)
        Me.Panel6.TabIndex = 581
        '
        'btnSFindAll
        '
        Me.btnSFindAll.BackColor = System.Drawing.Color.DimGray
        Me.btnSFindAll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSFindAll.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnSFindAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnSFindAll.ForeColor = System.Drawing.Color.White
        Me.btnSFindAll.Image = Global.SAM.My.Resources.Resources.refresh_24x24
        Me.btnSFindAll.Location = New System.Drawing.Point(0, 0)
        Me.btnSFindAll.Name = "btnSFindAll"
        Me.btnSFindAll.Size = New System.Drawing.Size(115, 30)
        Me.btnSFindAll.TabIndex = 580
        Me.btnSFindAll.Tag = ""
        Me.btnSFindAll.Text = "  Refresh"
        Me.btnSFindAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSFindAll.UseVisualStyleBackColor = False
        '
        'PanelControl1
        '
        Me.PanelControl1.Appearance.BackColor = System.Drawing.Color.Lavender
        Me.PanelControl1.Appearance.BackColor2 = System.Drawing.Color.LightSteelBlue
        Me.PanelControl1.Appearance.Options.UseBackColor = True
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.Panel1)
        Me.PanelControl1.Controls.Add(Me.Label2)
        Me.PanelControl1.Controls.Add(Me.cmbGroupComp)
        Me.PanelControl1.Controls.Add(Me.txtCusName)
        Me.PanelControl1.Controls.Add(Me.Label24)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(884, 46)
        Me.PanelControl1.TabIndex = 726
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.lblSumDebt)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(585, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(299, 46)
        Me.Panel1.TabIndex = 778
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 16)
        Me.Label2.TabIndex = 777
        Me.Label2.Text = "ข้อมูลบริษัท"
        '
        'cmbGroupComp
        '
        Me.cmbGroupComp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGroupComp.FormattingEnabled = True
        Me.cmbGroupComp.Location = New System.Drawing.Point(87, 13)
        Me.cmbGroupComp.Name = "cmbGroupComp"
        Me.cmbGroupComp.Size = New System.Drawing.Size(209, 21)
        Me.cmbGroupComp.TabIndex = 776
        '
        'PanelControl3
        '
        Me.PanelControl3.Appearance.BackColor = System.Drawing.Color.LightSteelBlue
        Me.PanelControl3.Appearance.BackColor2 = System.Drawing.Color.CornflowerBlue
        Me.PanelControl3.Appearance.Options.UseBackColor = True
        Me.PanelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl3.Controls.Add(Me.Label3)
        Me.PanelControl3.Controls.Add(Me.Panel6)
        Me.PanelControl3.Controls.Add(Me.lblCount)
        Me.PanelControl3.Controls.Add(Me.btnSFindAll)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl3.Location = New System.Drawing.Point(0, 46)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(884, 30)
        Me.PanelControl3.TabIndex = 727
        '
        'frmDebtorData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 551)
        Me.Controls.Add(Me.GCData)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDebtorData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ข้อมูลยอดหนี้ยกมา"
        CType(Me.GVLog, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GvShowData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rbeditDebt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSFindAll As System.Windows.Forms.Button
    Friend WithEvents GCData As DevExpress.XtraGrid.GridControl
    Friend WithEvents GvShowData As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColidCus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColNum As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColCusName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColAmtDebt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtCusName As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents ColAdd As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rbeditDebt As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents ColstActive As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents lblCount As System.Windows.Forms.Label
    Friend WithEvents ColDateBF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GVLog As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColNum2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColidCus2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDateBF2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColAmount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColPsTs As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDateTs As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblSumDebt As System.Windows.Forms.Label
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbGroupComp As System.Windows.Forms.ComboBox
End Class
