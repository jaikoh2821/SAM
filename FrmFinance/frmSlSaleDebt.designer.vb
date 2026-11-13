<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSlSaleDebt
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
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSlSaleDebt))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtTotalNet = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.lblCusName = New System.Windows.Forms.Label()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.lblCompName = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDocRef = New System.Windows.Forms.TextBox()
        Me.ChkDocRef = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.gc2 = New DevExpress.XtraGrid.GridControl()
        Me.gv2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColidSale = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColNum = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColChk = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rptChkEdit = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.ColDelete = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rptbtnView = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.ColDocRef = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDateSaleD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColCusName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColPayment = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColPsSale = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColTotalNet = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDebt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColNote = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Panel3.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.gc2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptChkEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptbtnView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.txtTotalNet)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(823, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(261, 34)
        Me.Panel3.TabIndex = 582
        '
        'txtTotalNet
        '
        Me.txtTotalNet.BackColor = System.Drawing.Color.Black
        Me.txtTotalNet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalNet.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTotalNet.ForeColor = System.Drawing.Color.Lime
        Me.txtTotalNet.Location = New System.Drawing.Point(93, 3)
        Me.txtTotalNet.Name = "txtTotalNet"
        Me.txtTotalNet.ReadOnly = True
        Me.txtTotalNet.Size = New System.Drawing.Size(158, 27)
        Me.txtTotalNet.TabIndex = 579
        Me.txtTotalNet.Text = "0"
        Me.txtTotalNet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(9, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 17)
        Me.Label2.TabIndex = 142
        Me.Label2.Text = "รวมเป็นเงิน"
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.Color.DimGray
        Me.btnOK.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOK.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnOK.ForeColor = System.Drawing.Color.White
        Me.btnOK.Image = Global.SAM.My.Resources.Resources.trainingCheckStateIcon
        Me.btnOK.Location = New System.Drawing.Point(115, 0)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(103, 34)
        Me.btnOK.TabIndex = 581
        Me.btnOK.Tag = "Save"
        Me.btnOK.Text = " ตกลง"
        Me.btnOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnOK.UseVisualStyleBackColor = False
        Me.btnOK.Visible = False
        '
        'btnShow
        '
        Me.btnShow.BackColor = System.Drawing.Color.DimGray
        Me.btnShow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnShow.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnShow.ForeColor = System.Drawing.Color.White
        Me.btnShow.Image = Global.SAM.My.Resources.Resources.refresh_24x24
        Me.btnShow.Location = New System.Drawing.Point(0, 0)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(115, 34)
        Me.btnShow.TabIndex = 580
        Me.btnShow.Tag = ""
        Me.btnShow.Text = " Refresh"
        Me.btnShow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnShow.UseVisualStyleBackColor = False
        '
        'lblCusName
        '
        Me.lblCusName.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCusName.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblCusName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCusName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblCusName.Location = New System.Drawing.Point(83, 13)
        Me.lblCusName.Name = "lblCusName"
        Me.lblCusName.Size = New System.Drawing.Size(305, 55)
        Me.lblCusName.TabIndex = 602
        Me.lblCusName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PanelControl1
        '
        Me.PanelControl1.Appearance.BackColor = System.Drawing.Color.Lavender
        Me.PanelControl1.Appearance.BackColor2 = System.Drawing.Color.LightSteelBlue
        Me.PanelControl1.Appearance.Options.UseBackColor = True
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.PanelControl2)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1084, 78)
        Me.PanelControl1.TabIndex = 726
        '
        'PanelControl2
        '
        Me.PanelControl2.Appearance.BackColor = System.Drawing.Color.Lavender
        Me.PanelControl2.Appearance.BackColor2 = System.Drawing.Color.LightSteelBlue
        Me.PanelControl2.Appearance.Options.UseBackColor = True
        Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl2.Controls.Add(Me.lblCompName)
        Me.PanelControl2.Controls.Add(Me.Label1)
        Me.PanelControl2.Controls.Add(Me.lblCusName)
        Me.PanelControl2.Controls.Add(Me.txtDocRef)
        Me.PanelControl2.Controls.Add(Me.ChkDocRef)
        Me.PanelControl2.Controls.Add(Me.Label4)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl2.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(1084, 78)
        Me.PanelControl2.TabIndex = 727
        '
        'lblCompName
        '
        Me.lblCompName.BackColor = System.Drawing.Color.Gainsboro
        Me.lblCompName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCompName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblCompName.Location = New System.Drawing.Point(501, 13)
        Me.lblCompName.Name = "lblCompName"
        Me.lblCompName.Size = New System.Drawing.Size(237, 24)
        Me.lblCompName.TabIndex = 789
        Me.lblCompName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(429, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 16)
        Me.Label1.TabIndex = 788
        Me.Label1.Text = "ข้อมูลบริษัท :"
        '
        'txtDocRef
        '
        Me.txtDocRef.Enabled = False
        Me.txtDocRef.Location = New System.Drawing.Point(501, 46)
        Me.txtDocRef.Name = "txtDocRef"
        Me.txtDocRef.Size = New System.Drawing.Size(237, 20)
        Me.txtDocRef.TabIndex = 608
        '
        'ChkDocRef
        '
        Me.ChkDocRef.AutoSize = True
        Me.ChkDocRef.BackColor = System.Drawing.Color.Transparent
        Me.ChkDocRef.Location = New System.Drawing.Point(421, 47)
        Me.ChkDocRef.Name = "ChkDocRef"
        Me.ChkDocRef.Size = New System.Drawing.Size(77, 17)
        Me.ChkDocRef.TabIndex = 607
        Me.ChkDocRef.Text = "เลขที่อ้างอิง"
        Me.ChkDocRef.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(36, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "ลูกค้า"
        '
        'PanelControl3
        '
        Me.PanelControl3.Appearance.BackColor = System.Drawing.Color.LightSteelBlue
        Me.PanelControl3.Appearance.BackColor2 = System.Drawing.Color.CornflowerBlue
        Me.PanelControl3.Appearance.Options.UseBackColor = True
        Me.PanelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl3.Controls.Add(Me.btnOK)
        Me.PanelControl3.Controls.Add(Me.Panel3)
        Me.PanelControl3.Controls.Add(Me.btnShow)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl3.Location = New System.Drawing.Point(0, 78)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(1084, 34)
        Me.PanelControl3.TabIndex = 728
        '
        'gc2
        '
        Me.gc2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gc2.Location = New System.Drawing.Point(0, 112)
        Me.gc2.MainView = Me.gv2
        Me.gc2.Name = "gc2"
        Me.gc2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rptbtnView, Me.rptChkEdit})
        Me.gc2.Size = New System.Drawing.Size(1084, 430)
        Me.gc2.TabIndex = 730
        Me.gc2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gv2})
        '
        'gv2
        '
        Me.gv2.Appearance.FocusedCell.BackColor = System.Drawing.Color.PeachPuff
        Me.gv2.Appearance.FocusedCell.Options.UseBackColor = True
        Me.gv2.Appearance.FocusedRow.BackColor = System.Drawing.Color.AntiqueWhite
        Me.gv2.Appearance.FocusedRow.Options.UseBackColor = True
        Me.gv2.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.gv2.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gv2.Appearance.Row.Options.UseTextOptions = True
        Me.gv2.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gv2.ColumnPanelRowHeight = 36
        Me.gv2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColidSale, Me.ColNum, Me.ColChk, Me.ColDelete, Me.ColDocRef, Me.ColDateSaleD, Me.ColCusName, Me.ColPayment, Me.ColPsSale, Me.ColTotalNet, Me.ColDebt, Me.ColNote})
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
        'ColChk
        '
        Me.ColChk.Caption = "เลือก"
        Me.ColChk.ColumnEdit = Me.rptChkEdit
        Me.ColChk.FieldName = "ChkKey"
        Me.ColChk.MaxWidth = 40
        Me.ColChk.MinWidth = 40
        Me.ColChk.Name = "ColChk"
        Me.ColChk.Visible = True
        Me.ColChk.VisibleIndex = 1
        Me.ColChk.Width = 40
        '
        'rptChkEdit
        '
        Me.rptChkEdit.AutoHeight = False
        Me.rptChkEdit.Name = "rptChkEdit"
        '
        'ColDelete
        '
        Me.ColDelete.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColDelete.AppearanceCell.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ColDelete.AppearanceCell.Options.UseBackColor = True
        Me.ColDelete.AppearanceCell.Options.UseForeColor = True
        Me.ColDelete.AppearanceCell.Options.UseTextOptions = True
        Me.ColDelete.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDelete.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDelete.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDelete.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColDelete.Caption = "ข้อมูลบิลขาย"
        Me.ColDelete.ColumnEdit = Me.rptbtnView
        Me.ColDelete.MaxWidth = 55
        Me.ColDelete.MinWidth = 55
        Me.ColDelete.Name = "ColDelete"
        Me.ColDelete.Visible = True
        Me.ColDelete.VisibleIndex = 2
        Me.ColDelete.Width = 55
        '
        'rptbtnView
        '
        Me.rptbtnView.AutoHeight = False
        Me.rptbtnView.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Global.SAM.My.Resources.Resources.Open_16x16, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.rptbtnView.Name = "rptbtnView"
        Me.rptbtnView.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'ColDocRef
        '
        Me.ColDocRef.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColDocRef.AppearanceCell.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ColDocRef.AppearanceCell.Options.UseBackColor = True
        Me.ColDocRef.AppearanceCell.Options.UseForeColor = True
        Me.ColDocRef.AppearanceCell.Options.UseTextOptions = True
        Me.ColDocRef.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDocRef.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDocRef.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDocRef.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColDocRef.Caption = "เลขที่อ้างอิง"
        Me.ColDocRef.FieldName = "DocRef"
        Me.ColDocRef.MaxWidth = 100
        Me.ColDocRef.MinWidth = 100
        Me.ColDocRef.Name = "ColDocRef"
        Me.ColDocRef.OptionsColumn.AllowEdit = False
        Me.ColDocRef.OptionsColumn.ReadOnly = True
        Me.ColDocRef.Visible = True
        Me.ColDocRef.VisibleIndex = 3
        Me.ColDocRef.Width = 100
        '
        'ColDateSaleD
        '
        Me.ColDateSaleD.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColDateSaleD.AppearanceCell.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ColDateSaleD.AppearanceCell.Options.UseBackColor = True
        Me.ColDateSaleD.AppearanceCell.Options.UseForeColor = True
        Me.ColDateSaleD.AppearanceCell.Options.UseTextOptions = True
        Me.ColDateSaleD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDateSaleD.Caption = "วันที่ขาย"
        Me.ColDateSaleD.FieldName = "DateSaleD"
        Me.ColDateSaleD.MaxWidth = 100
        Me.ColDateSaleD.MinWidth = 100
        Me.ColDateSaleD.Name = "ColDateSaleD"
        Me.ColDateSaleD.OptionsColumn.AllowEdit = False
        Me.ColDateSaleD.OptionsColumn.ReadOnly = True
        Me.ColDateSaleD.Visible = True
        Me.ColDateSaleD.VisibleIndex = 4
        Me.ColDateSaleD.Width = 100
        '
        'ColCusName
        '
        Me.ColCusName.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColCusName.AppearanceCell.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ColCusName.AppearanceCell.Options.UseBackColor = True
        Me.ColCusName.AppearanceCell.Options.UseForeColor = True
        Me.ColCusName.Caption = "ลูกค้า"
        Me.ColCusName.FieldName = "CusName"
        Me.ColCusName.MinWidth = 200
        Me.ColCusName.Name = "ColCusName"
        Me.ColCusName.OptionsColumn.AllowEdit = False
        Me.ColCusName.OptionsColumn.ReadOnly = True
        Me.ColCusName.Width = 200
        '
        'ColPayment
        '
        Me.ColPayment.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColPayment.AppearanceCell.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ColPayment.AppearanceCell.Options.UseBackColor = True
        Me.ColPayment.AppearanceCell.Options.UseForeColor = True
        Me.ColPayment.AppearanceCell.Options.UseTextOptions = True
        Me.ColPayment.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColPayment.Caption = "เงื่อนไขการชำระเงิน"
        Me.ColPayment.FieldName = "PaymentTerms"
        Me.ColPayment.MinWidth = 150
        Me.ColPayment.Name = "ColPayment"
        Me.ColPayment.OptionsColumn.AllowEdit = False
        Me.ColPayment.OptionsColumn.ReadOnly = True
        Me.ColPayment.Visible = True
        Me.ColPayment.VisibleIndex = 5
        Me.ColPayment.Width = 155
        '
        'ColPsSale
        '
        Me.ColPsSale.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColPsSale.AppearanceCell.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ColPsSale.AppearanceCell.Options.UseBackColor = True
        Me.ColPsSale.AppearanceCell.Options.UseForeColor = True
        Me.ColPsSale.AppearanceCell.Options.UseTextOptions = True
        Me.ColPsSale.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.ColPsSale.Caption = "เจ้าหน้าที่ขาย"
        Me.ColPsSale.FieldName = "PsSale"
        Me.ColPsSale.MinWidth = 150
        Me.ColPsSale.Name = "ColPsSale"
        Me.ColPsSale.OptionsColumn.AllowEdit = False
        Me.ColPsSale.OptionsColumn.ReadOnly = True
        Me.ColPsSale.Visible = True
        Me.ColPsSale.VisibleIndex = 6
        Me.ColPsSale.Width = 155
        '
        'ColTotalNet
        '
        Me.ColTotalNet.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ColTotalNet.AppearanceCell.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ColTotalNet.AppearanceCell.Options.UseBackColor = True
        Me.ColTotalNet.AppearanceCell.Options.UseForeColor = True
        Me.ColTotalNet.AppearanceCell.Options.UseTextOptions = True
        Me.ColTotalNet.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ColTotalNet.Caption = "มูลค่ารวม"
        Me.ColTotalNet.DisplayFormat.FormatString = "N2"
        Me.ColTotalNet.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColTotalNet.FieldName = "TotalNet"
        Me.ColTotalNet.MinWidth = 120
        Me.ColTotalNet.Name = "ColTotalNet"
        Me.ColTotalNet.OptionsColumn.AllowEdit = False
        Me.ColTotalNet.OptionsColumn.ReadOnly = True
        Me.ColTotalNet.Visible = True
        Me.ColTotalNet.VisibleIndex = 7
        Me.ColTotalNet.Width = 120
        '
        'ColDebt
        '
        Me.ColDebt.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ColDebt.AppearanceCell.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ColDebt.AppearanceCell.Options.UseBackColor = True
        Me.ColDebt.AppearanceCell.Options.UseForeColor = True
        Me.ColDebt.AppearanceCell.Options.UseTextOptions = True
        Me.ColDebt.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ColDebt.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDebt.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDebt.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ColDebt.Caption = "ยอดค้างจ่าย"
        Me.ColDebt.DisplayFormat.FormatString = "N2"
        Me.ColDebt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColDebt.FieldName = "AmtDebt"
        Me.ColDebt.MinWidth = 120
        Me.ColDebt.Name = "ColDebt"
        Me.ColDebt.OptionsColumn.AllowEdit = False
        Me.ColDebt.OptionsColumn.ReadOnly = True
        Me.ColDebt.Visible = True
        Me.ColDebt.VisibleIndex = 8
        Me.ColDebt.Width = 128
        '
        'ColNote
        '
        Me.ColNote.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ColNote.AppearanceCell.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ColNote.AppearanceCell.Options.UseBackColor = True
        Me.ColNote.AppearanceCell.Options.UseForeColor = True
        Me.ColNote.AppearanceCell.Options.UseTextOptions = True
        Me.ColNote.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.ColNote.Caption = "คำอธิบายกรายการ"
        Me.ColNote.FieldName = "Note"
        Me.ColNote.MinWidth = 120
        Me.ColNote.Name = "ColNote"
        Me.ColNote.OptionsColumn.AllowEdit = False
        Me.ColNote.OptionsColumn.ReadOnly = True
        Me.ColNote.Visible = True
        Me.ColNote.VisibleIndex = 9
        Me.ColNote.Width = 406
        '
        'frmSlSaleDebt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(1084, 542)
        Me.Controls.Add(Me.gc2)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSlSaleDebt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ข้อมูลรายการค้างชำระ"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.gc2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptChkEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptbtnView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents txtTotalNet As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents lblCusName As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ChkDocRef As System.Windows.Forms.CheckBox
    Friend WithEvents txtDocRef As System.Windows.Forms.TextBox
    Friend WithEvents gc2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents gv2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColidSale As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColNum As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColChk As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rptChkEdit As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents ColDelete As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rptbtnView As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents ColDocRef As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDateSaleD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColCusName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColPayment As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColPsSale As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColTotalNet As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDebt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColNote As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblCompName As System.Windows.Forms.Label
End Class
