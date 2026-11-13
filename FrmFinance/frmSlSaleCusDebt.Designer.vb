<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSlSaleCusDebt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSlSaleCusDebt))
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GVDebt = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColidCus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColCusName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColCodeBill = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDateBill = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColidSale = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDocRef = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDateSale = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColPM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDatePay = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColTotalNet = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColstPay = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColPsSale = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemButtonEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtTotalNet = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblPsSale = New System.Windows.Forms.Label()
        Me.btnPsSale = New System.Windows.Forms.Button()
        Me.ChkPsSale = New System.Windows.Forms.CheckBox()
        Me.lblCus = New System.Windows.Forms.Label()
        Me.btnCustomer = New System.Windows.Forms.Button()
        Me.ChkCus = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.cmbGroupComp = New System.Windows.Forms.ComboBox()
        Me.dtpSaleS = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel5.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVDebt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.GridControl1)
        Me.Panel5.Controls.Add(Me.PanelControl3)
        Me.Panel5.Controls.Add(Me.PanelControl1)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(884, 562)
        Me.Panel5.TabIndex = 609
        '
        'GridControl1
        '
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GridControl1.Location = New System.Drawing.Point(0, 119)
        Me.GridControl1.MainView = Me.GVDebt
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemButtonEdit3})
        Me.GridControl1.Size = New System.Drawing.Size(884, 443)
        Me.GridControl1.TabIndex = 4
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVDebt})
        '
        'GVDebt
        '
        Me.GVDebt.Appearance.FocusedCell.BackColor = System.Drawing.Color.PowderBlue
        Me.GVDebt.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVDebt.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GVDebt.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GVDebt.Appearance.FooterPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GVDebt.Appearance.FooterPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GVDebt.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVDebt.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVDebt.Appearance.FooterPanel.Options.UseFont = True
        Me.GVDebt.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GVDebt.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GVDebt.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVDebt.Appearance.GroupRow.BackColor = System.Drawing.Color.PapayaWhip
        Me.GVDebt.Appearance.GroupRow.BackColor2 = System.Drawing.Color.Wheat
        Me.GVDebt.Appearance.GroupRow.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.GVDebt.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GVDebt.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVDebt.Appearance.GroupRow.Options.UseFont = True
        Me.GVDebt.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVDebt.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.GVDebt.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVDebt.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVDebt.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVDebt.Appearance.HorzLine.BackColor = System.Drawing.Color.Silver
        Me.GVDebt.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVDebt.Appearance.VertLine.BackColor = System.Drawing.Color.Silver
        Me.GVDebt.Appearance.VertLine.Options.UseBackColor = True
        Me.GVDebt.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColidCus, Me.ColCusName, Me.ColCodeBill, Me.ColDateBill, Me.ColidSale, Me.ColDocRef, Me.ColDateSale, Me.ColPM, Me.ColDatePay, Me.ColTotalNet, Me.ColstPay, Me.ColPsSale})
        Me.GVDebt.GridControl = Me.GridControl1
        Me.GVDebt.GroupCount = 1
        Me.GVDebt.GroupFormat = "[#image]{1} {2}"
        Me.GVDebt.GroupRowHeight = 26
        Me.GVDebt.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalNet", Nothing, "(ยอดรวม = {0:N2})")})
        Me.GVDebt.Name = "GVDebt"
        Me.GVDebt.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect
        Me.GVDebt.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GVDebt.OptionsView.ShowGroupPanel = False
        Me.GVDebt.OptionsView.ShowIndicator = False
        Me.GVDebt.RowHeight = 22
        Me.GVDebt.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.ColCusName, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'ColidCus
        '
        Me.ColidCus.Caption = "idCus"
        Me.ColidCus.FieldName = "idCus"
        Me.ColidCus.Name = "ColidCus"
        '
        'ColCusName
        '
        Me.ColCusName.AppearanceCell.BackColor = System.Drawing.Color.Gainsboro
        Me.ColCusName.AppearanceCell.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ColCusName.AppearanceCell.Options.UseBackColor = True
        Me.ColCusName.AppearanceCell.Options.UseFont = True
        Me.ColCusName.AppearanceCell.Options.UseTextOptions = True
        Me.ColCusName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.ColCusName.AppearanceHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ColCusName.AppearanceHeader.Options.UseFont = True
        Me.ColCusName.Caption = "ชื่อลูกค้า"
        Me.ColCusName.FieldName = "CusName"
        Me.ColCusName.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right
        Me.ColCusName.Name = "ColCusName"
        Me.ColCusName.OptionsColumn.AllowEdit = False
        Me.ColCusName.OptionsColumn.ReadOnly = True
        Me.ColCusName.Visible = True
        Me.ColCusName.VisibleIndex = 1
        Me.ColCusName.Width = 280
        '
        'ColCodeBill
        '
        Me.ColCodeBill.AppearanceCell.BackColor = System.Drawing.Color.Gainsboro
        Me.ColCodeBill.AppearanceCell.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ColCodeBill.AppearanceCell.Options.UseBackColor = True
        Me.ColCodeBill.AppearanceCell.Options.UseFont = True
        Me.ColCodeBill.AppearanceCell.Options.UseTextOptions = True
        Me.ColCodeBill.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColCodeBill.AppearanceHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ColCodeBill.AppearanceHeader.Options.UseFont = True
        Me.ColCodeBill.Caption = "เลขที่ใบวางบิล"
        Me.ColCodeBill.FieldName = "CodeBill"
        Me.ColCodeBill.Name = "ColCodeBill"
        Me.ColCodeBill.OptionsColumn.AllowEdit = False
        Me.ColCodeBill.OptionsColumn.ReadOnly = True
        Me.ColCodeBill.Visible = True
        Me.ColCodeBill.VisibleIndex = 0
        Me.ColCodeBill.Width = 110
        '
        'ColDateBill
        '
        Me.ColDateBill.AppearanceCell.BackColor = System.Drawing.Color.Gainsboro
        Me.ColDateBill.AppearanceCell.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ColDateBill.AppearanceCell.Options.UseBackColor = True
        Me.ColDateBill.AppearanceCell.Options.UseFont = True
        Me.ColDateBill.AppearanceCell.Options.UseTextOptions = True
        Me.ColDateBill.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDateBill.AppearanceHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ColDateBill.AppearanceHeader.Options.UseFont = True
        Me.ColDateBill.Caption = "วันที่ใบวางบิล"
        Me.ColDateBill.FieldName = "DateBill"
        Me.ColDateBill.Name = "ColDateBill"
        Me.ColDateBill.OptionsColumn.AllowEdit = False
        Me.ColDateBill.OptionsColumn.ReadOnly = True
        Me.ColDateBill.Visible = True
        Me.ColDateBill.VisibleIndex = 1
        Me.ColDateBill.Width = 108
        '
        'ColidSale
        '
        Me.ColidSale.AppearanceCell.BackColor = System.Drawing.Color.Gainsboro
        Me.ColidSale.AppearanceCell.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ColidSale.AppearanceCell.Options.UseBackColor = True
        Me.ColidSale.AppearanceCell.Options.UseFont = True
        Me.ColidSale.AppearanceCell.Options.UseTextOptions = True
        Me.ColidSale.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColidSale.AppearanceHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ColidSale.AppearanceHeader.Options.UseFont = True
        Me.ColidSale.Caption = "idSale"
        Me.ColidSale.FieldName = "idSale"
        Me.ColidSale.Name = "ColidSale"
        Me.ColidSale.OptionsColumn.AllowEdit = False
        Me.ColidSale.OptionsColumn.ReadOnly = True
        Me.ColidSale.Width = 137
        '
        'ColDocRef
        '
        Me.ColDocRef.AppearanceCell.BackColor = System.Drawing.Color.Gainsboro
        Me.ColDocRef.AppearanceCell.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ColDocRef.AppearanceCell.Options.UseBackColor = True
        Me.ColDocRef.AppearanceCell.Options.UseFont = True
        Me.ColDocRef.AppearanceCell.Options.UseTextOptions = True
        Me.ColDocRef.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDocRef.AppearanceHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ColDocRef.AppearanceHeader.Options.UseFont = True
        Me.ColDocRef.Caption = "เลขที่บิลขาย"
        Me.ColDocRef.FieldName = "DocRef"
        Me.ColDocRef.Name = "ColDocRef"
        Me.ColDocRef.OptionsColumn.AllowEdit = False
        Me.ColDocRef.OptionsColumn.ReadOnly = True
        Me.ColDocRef.Visible = True
        Me.ColDocRef.VisibleIndex = 2
        Me.ColDocRef.Width = 111
        '
        'ColDateSale
        '
        Me.ColDateSale.AppearanceCell.BackColor = System.Drawing.Color.Gainsboro
        Me.ColDateSale.AppearanceCell.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ColDateSale.AppearanceCell.Options.UseBackColor = True
        Me.ColDateSale.AppearanceCell.Options.UseFont = True
        Me.ColDateSale.AppearanceCell.Options.UseTextOptions = True
        Me.ColDateSale.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDateSale.Caption = "วันที่ขาย"
        Me.ColDateSale.FieldName = "DateSaleD"
        Me.ColDateSale.Name = "ColDateSale"
        Me.ColDateSale.OptionsColumn.AllowEdit = False
        Me.ColDateSale.OptionsColumn.ReadOnly = True
        Me.ColDateSale.Visible = True
        Me.ColDateSale.VisibleIndex = 3
        Me.ColDateSale.Width = 112
        '
        'ColPM
        '
        Me.ColPM.AppearanceCell.BackColor = System.Drawing.Color.Gainsboro
        Me.ColPM.AppearanceCell.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ColPM.AppearanceCell.Options.UseBackColor = True
        Me.ColPM.AppearanceCell.Options.UseFont = True
        Me.ColPM.AppearanceCell.Options.UseTextOptions = True
        Me.ColPM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColPM.Caption = "เครดิต"
        Me.ColPM.FieldName = "PaymentTerms"
        Me.ColPM.Name = "ColPM"
        Me.ColPM.OptionsColumn.AllowEdit = False
        Me.ColPM.OptionsColumn.ReadOnly = True
        Me.ColPM.Visible = True
        Me.ColPM.VisibleIndex = 4
        Me.ColPM.Width = 153
        '
        'ColDatePay
        '
        Me.ColDatePay.AppearanceCell.BackColor = System.Drawing.Color.Gainsboro
        Me.ColDatePay.AppearanceCell.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ColDatePay.AppearanceCell.Options.UseBackColor = True
        Me.ColDatePay.AppearanceCell.Options.UseFont = True
        Me.ColDatePay.AppearanceCell.Options.UseTextOptions = True
        Me.ColDatePay.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDatePay.Caption = "ครบกำหนดชำระ"
        Me.ColDatePay.FieldName = "DatePay"
        Me.ColDatePay.Name = "ColDatePay"
        Me.ColDatePay.OptionsColumn.AllowEdit = False
        Me.ColDatePay.OptionsColumn.ReadOnly = True
        Me.ColDatePay.Visible = True
        Me.ColDatePay.VisibleIndex = 5
        Me.ColDatePay.Width = 127
        '
        'ColTotalNet
        '
        Me.ColTotalNet.AppearanceCell.BackColor = System.Drawing.Color.MistyRose
        Me.ColTotalNet.AppearanceCell.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ColTotalNet.AppearanceCell.Options.UseBackColor = True
        Me.ColTotalNet.AppearanceCell.Options.UseFont = True
        Me.ColTotalNet.AppearanceCell.Options.UseTextOptions = True
        Me.ColTotalNet.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ColTotalNet.Caption = "จำนวนเงิน (บาท)"
        Me.ColTotalNet.DisplayFormat.FormatString = "N2"
        Me.ColTotalNet.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColTotalNet.FieldName = "TotalNet"
        Me.ColTotalNet.Name = "ColTotalNet"
        Me.ColTotalNet.OptionsColumn.AllowEdit = False
        Me.ColTotalNet.OptionsColumn.ReadOnly = True
        Me.ColTotalNet.Visible = True
        Me.ColTotalNet.VisibleIndex = 6
        Me.ColTotalNet.Width = 156
        '
        'ColstPay
        '
        Me.ColstPay.Caption = "stPay"
        Me.ColstPay.FieldName = "stpay"
        Me.ColstPay.Name = "ColstPay"
        '
        'ColPsSale
        '
        Me.ColPsSale.Caption = "PsSale"
        Me.ColPsSale.FieldName = "PsSale"
        Me.ColPsSale.Name = "ColPsSale"
        '
        'RepositoryItemButtonEdit3
        '
        Me.RepositoryItemButtonEdit3.AutoHeight = False
        Me.RepositoryItemButtonEdit3.Name = "RepositoryItemButtonEdit3"
        Me.RepositoryItemButtonEdit3.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'PanelControl3
        '
        Me.PanelControl3.Appearance.BackColor = System.Drawing.Color.LightSteelBlue
        Me.PanelControl3.Appearance.BackColor2 = System.Drawing.Color.CornflowerBlue
        Me.PanelControl3.Appearance.Options.UseBackColor = True
        Me.PanelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl3.Controls.Add(Me.Panel3)
        Me.PanelControl3.Controls.Add(Me.btnShow)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl3.Location = New System.Drawing.Point(0, 89)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(884, 30)
        Me.PanelControl3.TabIndex = 727
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.txtTotalNet)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(611, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(273, 30)
        Me.Panel3.TabIndex = 582
        '
        'txtTotalNet
        '
        Me.txtTotalNet.BackColor = System.Drawing.Color.Black
        Me.txtTotalNet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalNet.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTotalNet.ForeColor = System.Drawing.Color.Lime
        Me.txtTotalNet.Location = New System.Drawing.Point(87, 1)
        Me.txtTotalNet.Name = "txtTotalNet"
        Me.txtTotalNet.ReadOnly = True
        Me.txtTotalNet.Size = New System.Drawing.Size(175, 27)
        Me.txtTotalNet.TabIndex = 579
        Me.txtTotalNet.Text = "0"
        Me.txtTotalNet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(4, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 17)
        Me.Label2.TabIndex = 142
        Me.Label2.Text = "รวมยอดหนี้"
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
        Me.btnShow.Size = New System.Drawing.Size(115, 30)
        Me.btnShow.TabIndex = 3
        Me.btnShow.Tag = ""
        Me.btnShow.Text = " Refresh"
        Me.btnShow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnShow.UseVisualStyleBackColor = False
        '
        'PanelControl1
        '
        Me.PanelControl1.Appearance.BackColor = System.Drawing.Color.Lavender
        Me.PanelControl1.Appearance.BackColor2 = System.Drawing.Color.LightSteelBlue
        Me.PanelControl1.Appearance.Options.UseBackColor = True
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.GroupBox2)
        Me.PanelControl1.Controls.Add(Me.GroupBox1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(884, 89)
        Me.PanelControl1.TabIndex = 726
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.lblPsSale)
        Me.GroupBox2.Controls.Add(Me.btnPsSale)
        Me.GroupBox2.Controls.Add(Me.ChkPsSale)
        Me.GroupBox2.Controls.Add(Me.lblCus)
        Me.GroupBox2.Controls.Add(Me.btnCustomer)
        Me.GroupBox2.Controls.Add(Me.ChkCus)
        Me.GroupBox2.Location = New System.Drawing.Point(374, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(359, 77)
        Me.GroupBox2.TabIndex = 614
        Me.GroupBox2.TabStop = False
        '
        'lblPsSale
        '
        Me.lblPsSale.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblPsSale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPsSale.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblPsSale.Location = New System.Drawing.Point(110, 16)
        Me.lblPsSale.Name = "lblPsSale"
        Me.lblPsSale.Size = New System.Drawing.Size(210, 20)
        Me.lblPsSale.TabIndex = 608
        Me.lblPsSale.Tag = "0"
        '
        'btnPsSale
        '
        Me.btnPsSale.BackColor = System.Drawing.Color.DimGray
        Me.btnPsSale.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPsSale.Enabled = False
        Me.btnPsSale.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.7!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnPsSale.ForeColor = System.Drawing.Color.White
        Me.btnPsSale.Image = CType(resources.GetObject("btnPsSale.Image"), System.Drawing.Image)
        Me.btnPsSale.Location = New System.Drawing.Point(323, 14)
        Me.btnPsSale.Name = "btnPsSale"
        Me.btnPsSale.Size = New System.Drawing.Size(28, 25)
        Me.btnPsSale.TabIndex = 607
        Me.btnPsSale.Tag = "Add"
        Me.btnPsSale.UseVisualStyleBackColor = False
        '
        'ChkPsSale
        '
        Me.ChkPsSale.AutoSize = True
        Me.ChkPsSale.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ChkPsSale.Location = New System.Drawing.Point(9, 16)
        Me.ChkPsSale.Name = "ChkPsSale"
        Me.ChkPsSale.Size = New System.Drawing.Size(97, 20)
        Me.ChkPsSale.TabIndex = 606
        Me.ChkPsSale.Text = "เจ้าหน้าที่ขาย"
        Me.ChkPsSale.UseVisualStyleBackColor = True
        '
        'lblCus
        '
        Me.lblCus.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblCus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblCus.Location = New System.Drawing.Point(110, 44)
        Me.lblCus.Name = "lblCus"
        Me.lblCus.Size = New System.Drawing.Size(210, 20)
        Me.lblCus.TabIndex = 605
        Me.lblCus.Tag = "0"
        '
        'btnCustomer
        '
        Me.btnCustomer.BackColor = System.Drawing.Color.DimGray
        Me.btnCustomer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCustomer.Enabled = False
        Me.btnCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.7!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnCustomer.ForeColor = System.Drawing.Color.White
        Me.btnCustomer.Image = CType(resources.GetObject("btnCustomer.Image"), System.Drawing.Image)
        Me.btnCustomer.Location = New System.Drawing.Point(323, 42)
        Me.btnCustomer.Name = "btnCustomer"
        Me.btnCustomer.Size = New System.Drawing.Size(28, 25)
        Me.btnCustomer.TabIndex = 2
        Me.btnCustomer.Tag = "Add"
        Me.btnCustomer.UseVisualStyleBackColor = False
        '
        'ChkCus
        '
        Me.ChkCus.AutoSize = True
        Me.ChkCus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ChkCus.Location = New System.Drawing.Point(9, 44)
        Me.ChkCus.Name = "ChkCus"
        Me.ChkCus.Size = New System.Drawing.Size(55, 20)
        Me.ChkCus.TabIndex = 1
        Me.ChkCus.Text = "ลูกค้า"
        Me.ChkCus.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.cmbGroupComp)
        Me.GroupBox1.Controls.Add(Me.dtpSaleS)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(356, 77)
        Me.GroupBox1.TabIndex = 613
        Me.GroupBox1.TabStop = False
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(26, 20)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(60, 13)
        Me.Label23.TabIndex = 772
        Me.Label23.Text = "ข้อมูลบริษัท"
        '
        'cmbGroupComp
        '
        Me.cmbGroupComp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGroupComp.FormattingEnabled = True
        Me.cmbGroupComp.Location = New System.Drawing.Point(92, 17)
        Me.cmbGroupComp.Name = "cmbGroupComp"
        Me.cmbGroupComp.Size = New System.Drawing.Size(251, 21)
        Me.cmbGroupComp.TabIndex = 773
        '
        'dtpSaleS
        '
        Me.dtpSaleS.CustomFormat = "dMMMMyyyy"
        Me.dtpSaleS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpSaleS.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpSaleS.Location = New System.Drawing.Point(92, 44)
        Me.dtpSaleS.MinDate = New Date(1757, 1, 1, 0, 0, 0, 0)
        Me.dtpSaleS.Name = "dtpSaleS"
        Me.dtpSaleS.Size = New System.Drawing.Size(141, 20)
        Me.dtpSaleS.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 16)
        Me.Label1.TabIndex = 603
        Me.Label1.Text = "ข้อมูล ณ วันที่"
        '
        'frmSlSaleCusDebt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(884, 562)
        Me.Controls.Add(Me.Panel5)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSlSaleCusDebt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ข้อมูลลูกหนี้"
        Me.Panel5.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVDebt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents dtpSaleS As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents txtTotalNet As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVDebt As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColidCus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColCusName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColCodeBill As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDateBill As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColidSale As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDocRef As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDateSale As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColPM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDatePay As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColTotalNet As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColstPay As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemButtonEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents ChkCus As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblCus As System.Windows.Forms.Label
    Friend WithEvents btnCustomer As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblPsSale As System.Windows.Forms.Label
    Friend WithEvents btnPsSale As System.Windows.Forms.Button
    Friend WithEvents ChkPsSale As System.Windows.Forms.CheckBox
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents cmbGroupComp As System.Windows.Forms.ComboBox
    Friend WithEvents ColPsSale As DevExpress.XtraGrid.Columns.GridColumn
End Class
