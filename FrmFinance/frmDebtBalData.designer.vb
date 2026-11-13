<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDebtBalData
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
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDebtBalData))
        Me.GVLog = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColNum2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColidCus2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDateBF2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColAmount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColPsTs = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDateTs = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCData = New DevExpress.XtraGrid.GridControl()
        Me.GvShowData = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColidSale = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColNum = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDateSale = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDocRef = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDatePay = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColTotalNet = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColTotalPay = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColBal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rbeditDebt = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.btnCus = New DevExpress.XtraEditors.SimpleButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblCus = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbGroupComp = New System.Windows.Forms.ComboBox()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.btnPdf = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDebtBalRpt = New DevExpress.XtraEditors.SimpleButton()
        Me.btnRefresh = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtTotalNet = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.GVLog, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GvShowData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rbeditDebt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        Me.Panel3.SuspendLayout()
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
        Me.GCData.Location = New System.Drawing.Point(0, 72)
        Me.GCData.MainView = Me.GvShowData
        Me.GCData.Name = "GCData"
        Me.GCData.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rbeditDebt})
        Me.GCData.Size = New System.Drawing.Size(884, 479)
        Me.GCData.TabIndex = 739
        Me.GCData.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GvShowData, Me.GVLog})
        '
        'GvShowData
        '
        Me.GvShowData.Appearance.FocusedCell.BackColor = System.Drawing.Color.Azure
        Me.GvShowData.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GvShowData.Appearance.FocusedRow.BackColor = System.Drawing.Color.Azure
        Me.GvShowData.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GvShowData.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Azure
        Me.GvShowData.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GvShowData.Appearance.SelectedRow.BackColor = System.Drawing.Color.Azure
        Me.GvShowData.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GvShowData.ColumnPanelRowHeight = 34
        Me.GvShowData.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColidSale, Me.ColNum, Me.ColDateSale, Me.ColDocRef, Me.ColDatePay, Me.ColTotalNet, Me.ColTotalPay, Me.ColBal})
        Me.GvShowData.GridControl = Me.GCData
        Me.GvShowData.Name = "GvShowData"
        Me.GvShowData.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GvShowData.OptionsView.ShowGroupPanel = False
        Me.GvShowData.OptionsView.ShowIndicator = False
        '
        'ColidSale
        '
        Me.ColidSale.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColidSale.AppearanceCell.Options.UseFont = True
        Me.ColidSale.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColidSale.AppearanceHeader.Options.UseFont = True
        Me.ColidSale.Caption = "idsale"
        Me.ColidSale.FieldName = "idSale"
        Me.ColidSale.Name = "ColidSale"
        '
        'ColNum
        '
        Me.ColNum.AppearanceCell.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ColNum.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColNum.AppearanceCell.Options.UseBackColor = True
        Me.ColNum.AppearanceCell.Options.UseFont = True
        Me.ColNum.AppearanceCell.Options.UseTextOptions = True
        Me.ColNum.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColNum.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColNum.AppearanceHeader.Options.UseFont = True
        Me.ColNum.AppearanceHeader.Options.UseTextOptions = True
        Me.ColNum.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColNum.Caption = "ลำดับ"
        Me.ColNum.FieldName = "Num"
        Me.ColNum.MaxWidth = 50
        Me.ColNum.MinWidth = 50
        Me.ColNum.Name = "ColNum"
        Me.ColNum.OptionsColumn.AllowEdit = False
        Me.ColNum.OptionsColumn.ReadOnly = True
        Me.ColNum.Visible = True
        Me.ColNum.VisibleIndex = 0
        Me.ColNum.Width = 50
        '
        'ColDateSale
        '
        Me.ColDateSale.AppearanceCell.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ColDateSale.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColDateSale.AppearanceCell.Options.UseBackColor = True
        Me.ColDateSale.AppearanceCell.Options.UseFont = True
        Me.ColDateSale.AppearanceCell.Options.UseTextOptions = True
        Me.ColDateSale.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDateSale.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColDateSale.AppearanceHeader.Options.UseFont = True
        Me.ColDateSale.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDateSale.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDateSale.Caption = "วันที่"
        Me.ColDateSale.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.ColDateSale.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.ColDateSale.FieldName = "DateSaleD"
        Me.ColDateSale.MinWidth = 120
        Me.ColDateSale.Name = "ColDateSale"
        Me.ColDateSale.OptionsColumn.AllowEdit = False
        Me.ColDateSale.OptionsColumn.ReadOnly = True
        Me.ColDateSale.Visible = True
        Me.ColDateSale.VisibleIndex = 1
        Me.ColDateSale.Width = 120
        '
        'ColDocRef
        '
        Me.ColDocRef.AppearanceCell.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ColDocRef.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColDocRef.AppearanceCell.Options.UseBackColor = True
        Me.ColDocRef.AppearanceCell.Options.UseFont = True
        Me.ColDocRef.AppearanceCell.Options.UseTextOptions = True
        Me.ColDocRef.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDocRef.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColDocRef.AppearanceHeader.Options.UseFont = True
        Me.ColDocRef.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDocRef.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDocRef.Caption = "เลขที่เอกสาร"
        Me.ColDocRef.FieldName = "DocRef"
        Me.ColDocRef.MinWidth = 150
        Me.ColDocRef.Name = "ColDocRef"
        Me.ColDocRef.OptionsColumn.AllowEdit = False
        Me.ColDocRef.OptionsColumn.ReadOnly = True
        Me.ColDocRef.Visible = True
        Me.ColDocRef.VisibleIndex = 2
        Me.ColDocRef.Width = 150
        '
        'ColDatePay
        '
        Me.ColDatePay.AppearanceCell.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ColDatePay.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColDatePay.AppearanceCell.Options.UseBackColor = True
        Me.ColDatePay.AppearanceCell.Options.UseFont = True
        Me.ColDatePay.AppearanceCell.Options.UseTextOptions = True
        Me.ColDatePay.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDatePay.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColDatePay.AppearanceHeader.Options.UseFont = True
        Me.ColDatePay.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDatePay.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDatePay.Caption = "ครบกำหนดชำระ"
        Me.ColDatePay.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.ColDatePay.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.ColDatePay.FieldName = "DatePay"
        Me.ColDatePay.MinWidth = 150
        Me.ColDatePay.Name = "ColDatePay"
        Me.ColDatePay.OptionsColumn.AllowEdit = False
        Me.ColDatePay.OptionsColumn.ReadOnly = True
        Me.ColDatePay.Visible = True
        Me.ColDatePay.VisibleIndex = 3
        Me.ColDatePay.Width = 150
        '
        'ColTotalNet
        '
        Me.ColTotalNet.AppearanceCell.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ColTotalNet.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColTotalNet.AppearanceCell.Options.UseBackColor = True
        Me.ColTotalNet.AppearanceCell.Options.UseFont = True
        Me.ColTotalNet.AppearanceCell.Options.UseTextOptions = True
        Me.ColTotalNet.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ColTotalNet.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColTotalNet.AppearanceHeader.Options.UseFont = True
        Me.ColTotalNet.AppearanceHeader.Options.UseTextOptions = True
        Me.ColTotalNet.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColTotalNet.Caption = "จำนวนเงิน"
        Me.ColTotalNet.DisplayFormat.FormatString = "N2"
        Me.ColTotalNet.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColTotalNet.FieldName = "TotalNet"
        Me.ColTotalNet.MinWidth = 120
        Me.ColTotalNet.Name = "ColTotalNet"
        Me.ColTotalNet.OptionsColumn.AllowEdit = False
        Me.ColTotalNet.OptionsColumn.ReadOnly = True
        Me.ColTotalNet.Visible = True
        Me.ColTotalNet.VisibleIndex = 4
        Me.ColTotalNet.Width = 150
        '
        'ColTotalPay
        '
        Me.ColTotalPay.AppearanceCell.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ColTotalPay.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColTotalPay.AppearanceCell.Options.UseBackColor = True
        Me.ColTotalPay.AppearanceCell.Options.UseFont = True
        Me.ColTotalPay.AppearanceCell.Options.UseTextOptions = True
        Me.ColTotalPay.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ColTotalPay.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColTotalPay.AppearanceHeader.Options.UseFont = True
        Me.ColTotalPay.AppearanceHeader.Options.UseTextOptions = True
        Me.ColTotalPay.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColTotalPay.Caption = "ชำระแล้ว"
        Me.ColTotalPay.DisplayFormat.FormatString = "N2"
        Me.ColTotalPay.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColTotalPay.FieldName = "TotalPay"
        Me.ColTotalPay.MinWidth = 120
        Me.ColTotalPay.Name = "ColTotalPay"
        Me.ColTotalPay.OptionsColumn.AllowEdit = False
        Me.ColTotalPay.OptionsColumn.ReadOnly = True
        Me.ColTotalPay.Visible = True
        Me.ColTotalPay.VisibleIndex = 5
        Me.ColTotalPay.Width = 150
        '
        'ColBal
        '
        Me.ColBal.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ColBal.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColBal.AppearanceCell.Options.UseBackColor = True
        Me.ColBal.AppearanceCell.Options.UseFont = True
        Me.ColBal.AppearanceCell.Options.UseTextOptions = True
        Me.ColBal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ColBal.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColBal.AppearanceHeader.Options.UseFont = True
        Me.ColBal.AppearanceHeader.Options.UseTextOptions = True
        Me.ColBal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColBal.Caption = "คงเหลือ"
        Me.ColBal.DisplayFormat.FormatString = "N2"
        Me.ColBal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColBal.FieldName = "Bal"
        Me.ColBal.MinWidth = 120
        Me.ColBal.Name = "ColBal"
        Me.ColBal.OptionsColumn.AllowEdit = False
        Me.ColBal.OptionsColumn.ReadOnly = True
        Me.ColBal.Visible = True
        Me.ColBal.VisibleIndex = 6
        Me.ColBal.Width = 150
        '
        'rbeditDebt
        '
        Me.rbeditDebt.AutoHeight = False
        Me.rbeditDebt.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Global.SAM.My.Resources.Resources.bended_arrow_icon, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject3, "", Nothing, Nothing, True)})
        Me.rbeditDebt.Name = "rbeditDebt"
        Me.rbeditDebt.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'PanelControl1
        '
        Me.PanelControl1.Appearance.BackColor = System.Drawing.Color.Lavender
        Me.PanelControl1.Appearance.BackColor2 = System.Drawing.Color.LightSteelBlue
        Me.PanelControl1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.PanelControl1.Appearance.Options.UseBackColor = True
        Me.PanelControl1.Appearance.Options.UseFont = True
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.btnCus)
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.lblCus)
        Me.PanelControl1.Controls.Add(Me.Label2)
        Me.PanelControl1.Controls.Add(Me.cmbGroupComp)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(884, 38)
        Me.PanelControl1.TabIndex = 737
        '
        'btnCus
        '
        Me.btnCus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCus.Image = CType(resources.GetObject("btnCus.Image"), System.Drawing.Image)
        Me.btnCus.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnCus.Location = New System.Drawing.Point(778, 8)
        Me.btnCus.Name = "btnCus"
        Me.btnCus.Size = New System.Drawing.Size(25, 22)
        Me.btnCus.TabIndex = 737
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(328, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 14)
        Me.Label1.TabIndex = 773
        Me.Label1.Text = "ลูกค้า"
        '
        'lblCus
        '
        Me.lblCus.BackColor = System.Drawing.Color.Gainsboro
        Me.lblCus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCus.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCus.Location = New System.Drawing.Point(371, 8)
        Me.lblCus.Name = "lblCus"
        Me.lblCus.Size = New System.Drawing.Size(404, 22)
        Me.lblCus.TabIndex = 738
        Me.lblCus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(31, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 14)
        Me.Label2.TabIndex = 769
        Me.Label2.Text = "ข้อมูลบริษัท"
        '
        'cmbGroupComp
        '
        Me.cmbGroupComp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGroupComp.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbGroupComp.FormattingEnabled = True
        Me.cmbGroupComp.Location = New System.Drawing.Point(106, 8)
        Me.cmbGroupComp.Name = "cmbGroupComp"
        Me.cmbGroupComp.Size = New System.Drawing.Size(199, 22)
        Me.cmbGroupComp.TabIndex = 768
        '
        'PanelControl3
        '
        Me.PanelControl3.Appearance.BackColor = System.Drawing.Color.LightSteelBlue
        Me.PanelControl3.Appearance.BackColor2 = System.Drawing.Color.CornflowerBlue
        Me.PanelControl3.Appearance.Options.UseBackColor = True
        Me.PanelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl3.Controls.Add(Me.btnPdf)
        Me.PanelControl3.Controls.Add(Me.btnDebtBalRpt)
        Me.PanelControl3.Controls.Add(Me.btnRefresh)
        Me.PanelControl3.Controls.Add(Me.Panel3)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl3.Location = New System.Drawing.Point(0, 38)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(884, 34)
        Me.PanelControl3.TabIndex = 738
        '
        'btnPdf
        '
        Me.btnPdf.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPdf.Appearance.Options.UseFont = True
        Me.btnPdf.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPdf.Enabled = False
        Me.btnPdf.Image = CType(resources.GetObject("btnPdf.Image"), System.Drawing.Image)
        Me.btnPdf.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnPdf.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnPdf.Location = New System.Drawing.Point(318, 2)
        Me.btnPdf.Name = "btnPdf"
        Me.btnPdf.Size = New System.Drawing.Size(123, 30)
        Me.btnPdf.TabIndex = 587
        Me.btnPdf.Text = "Export PDF"
        '
        'btnDebtBalRpt
        '
        Me.btnDebtBalRpt.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDebtBalRpt.Appearance.Options.UseFont = True
        Me.btnDebtBalRpt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDebtBalRpt.Enabled = False
        Me.btnDebtBalRpt.Image = CType(resources.GetObject("btnDebtBalRpt.Image"), System.Drawing.Image)
        Me.btnDebtBalRpt.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnDebtBalRpt.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnDebtBalRpt.Location = New System.Drawing.Point(114, 2)
        Me.btnDebtBalRpt.Name = "btnDebtBalRpt"
        Me.btnDebtBalRpt.Size = New System.Drawing.Size(204, 30)
        Me.btnDebtBalRpt.TabIndex = 586
        Me.btnDebtBalRpt.Text = "หนังสือแจ้งยอดหนี้คงเหลือ"
        '
        'btnRefresh
        '
        Me.btnRefresh.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Appearance.Options.UseFont = True
        Me.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), System.Drawing.Image)
        Me.btnRefresh.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnRefresh.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnRefresh.Location = New System.Drawing.Point(2, 2)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(111, 30)
        Me.btnRefresh.TabIndex = 585
        Me.btnRefresh.Text = "แสดงข้อมูล"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.txtTotalNet)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(623, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(261, 34)
        Me.Panel3.TabIndex = 583
        '
        'txtTotalNet
        '
        Me.txtTotalNet.BackColor = System.Drawing.Color.Black
        Me.txtTotalNet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalNet.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTotalNet.ForeColor = System.Drawing.Color.Lime
        Me.txtTotalNet.Location = New System.Drawing.Point(92, 3)
        Me.txtTotalNet.Name = "txtTotalNet"
        Me.txtTotalNet.ReadOnly = True
        Me.txtTotalNet.Size = New System.Drawing.Size(158, 27)
        Me.txtTotalNet.TabIndex = 579
        Me.txtTotalNet.Text = "0"
        Me.txtTotalNet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 17)
        Me.Label3.TabIndex = 142
        Me.Label3.Text = "รวมเป็นเงิน"
        '
        'frmDebtBalData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 551)
        Me.Controls.Add(Me.GCData)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDebtBalData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ข้อมูลยอดหนี้คงเหลือ"
        CType(Me.GVLog, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GvShowData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rbeditDebt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCus As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblCus As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbGroupComp As System.Windows.Forms.ComboBox
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents txtTotalNet As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GCData As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVLog As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColNum2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColidCus2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDateBF2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColAmount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColPsTs As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDateTs As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GvShowData As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColidSale As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColNum As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDateSale As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDocRef As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDatePay As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColTotalNet As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColTotalPay As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColBal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rbeditDebt As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents btnDebtBalRpt As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnPdf As DevExpress.XtraEditors.SimpleButton
End Class
