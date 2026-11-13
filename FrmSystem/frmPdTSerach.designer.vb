<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPdTSerach
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.txt_Sname = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.DGV_PdT = New System.Windows.Forms.DataGridView
        Me.chkpp = New System.Windows.Forms.CheckBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btn_add = New System.Windows.Forms.Button
        Me.colPdt = New System.Windows.Forms.DataGridViewImageColumn
        Me.colSel2 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.colPdTname = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colPdTnameEN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colPP = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colidPdT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colidSeedType = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colidSeedKind = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colPlantTypeName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colidtype = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colstPPNot = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.DGV_PdT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_Sname
        '
        Me.txt_Sname.Location = New System.Drawing.Point(165, 12)
        Me.txt_Sname.Name = "txt_Sname"
        Me.txt_Sname.Size = New System.Drawing.Size(138, 20)
        Me.txt_Sname.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(102, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ค้นหาสินค้า"
        '
        'DGV_PdT
        '
        Me.DGV_PdT.AllowUserToAddRows = False
        Me.DGV_PdT.AllowUserToResizeColumns = False
        Me.DGV_PdT.AllowUserToResizeRows = False
        Me.DGV_PdT.BackgroundColor = System.Drawing.Color.Lavender
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_PdT.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_PdT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_PdT.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colPdt, Me.colSel2, Me.colPdTname, Me.colPdTnameEN, Me.colPP, Me.colidPdT, Me.colidSeedType, Me.colidSeedKind, Me.colPlantTypeName, Me.colidtype, Me.colstPPNot})
        Me.DGV_PdT.Location = New System.Drawing.Point(-1, 90)
        Me.DGV_PdT.Name = "DGV_PdT"
        Me.DGV_PdT.RowHeadersVisible = False
        Me.DGV_PdT.Size = New System.Drawing.Size(452, 312)
        Me.DGV_PdT.TabIndex = 5
        '
        'chkpp
        '
        Me.chkpp.AutoSize = True
        Me.chkpp.Location = New System.Drawing.Point(105, 13)
        Me.chkpp.Name = "chkpp"
        Me.chkpp.Size = New System.Drawing.Size(167, 17)
        Me.chkpp.TabIndex = 6
        Me.chkpp.Text = "แสดงรายการที่ยังไม่ได้กำหนด"
        Me.chkpp.UseVisualStyleBackColor = True
        Me.chkpp.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(285, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "สินค้าทั้งหมด "
        Me.Label2.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel1.Controls.Add(Me.btn_add)
        Me.Panel1.Controls.Add(Me.chkpp)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(-1, 50)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(452, 40)
        Me.Panel1.TabIndex = 8
        '
        'btn_add
        '
        Me.btn_add.AutoSize = True
        Me.btn_add.BackColor = System.Drawing.Color.DimGray
        Me.btn_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_add.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_add.ForeColor = System.Drawing.Color.White
        Me.btn_add.Image = Global.SAM.My.Resources.Resources.Add28
        Me.btn_add.Location = New System.Drawing.Point(3, 0)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(96, 40)
        Me.btn_add.TabIndex = 418
        Me.btn_add.Text = "ตกลง"
        Me.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_add.UseVisualStyleBackColor = False
        Me.btn_add.Visible = False
        '
        'colPdt
        '
        Me.colPdt.HeaderText = "เลือก"
        Me.colPdt.Name = "colPdt"
        Me.colPdt.Width = 80
        '
        'colSel2
        '
        Me.colSel2.DataPropertyName = "chkPdT"
        Me.colSel2.HeaderText = "เลือก"
        Me.colSel2.Name = "colSel2"
        Me.colSel2.Visible = False
        '
        'colPdTname
        '
        Me.colPdTname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colPdTname.DataPropertyName = "PdTradeName"
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro
        Me.colPdTname.DefaultCellStyle = DataGridViewCellStyle2
        Me.colPdTname.HeaderText = "ชื่อสินค้า"
        Me.colPdTname.Name = "colPdTname"
        Me.colPdTname.ReadOnly = True
        Me.colPdTname.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colPdTname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colPdTnameEN
        '
        Me.colPdTnameEN.DataPropertyName = "PdTradeNameEN"
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Gainsboro
        Me.colPdTnameEN.DefaultCellStyle = DataGridViewCellStyle3
        Me.colPdTnameEN.HeaderText = "ชื่อสินค้าEN"
        Me.colPdTnameEN.Name = "colPdTnameEN"
        Me.colPdTnameEN.ReadOnly = True
        Me.colPdTnameEN.Visible = False
        '
        'colPP
        '
        Me.colPP.DataPropertyName = "PP"
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Gainsboro
        Me.colPP.DefaultCellStyle = DataGridViewCellStyle4
        Me.colPP.HeaderText = "เลขที่เอกสาร พพ."
        Me.colPP.Name = "colPP"
        Me.colPP.ReadOnly = True
        Me.colPP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colPP.Visible = False
        '
        'colidPdT
        '
        Me.colidPdT.DataPropertyName = "idPdT"
        Me.colidPdT.HeaderText = "idPdT"
        Me.colidPdT.Name = "colidPdT"
        Me.colidPdT.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colidPdT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colidPdT.Visible = False
        '
        'colidSeedType
        '
        Me.colidSeedType.DataPropertyName = "idSeedType"
        Me.colidSeedType.HeaderText = "idPlant"
        Me.colidSeedType.Name = "colidSeedType"
        Me.colidSeedType.ReadOnly = True
        Me.colidSeedType.Visible = False
        '
        'colidSeedKind
        '
        Me.colidSeedKind.DataPropertyName = "idSeedKind"
        Me.colidSeedKind.HeaderText = "idSeedKind"
        Me.colidSeedKind.Name = "colidSeedKind"
        Me.colidSeedKind.Visible = False
        '
        'colPlantTypeName
        '
        Me.colPlantTypeName.DataPropertyName = "PlantTypeName"
        Me.colPlantTypeName.HeaderText = "PlantTypeName"
        Me.colPlantTypeName.Name = "colPlantTypeName"
        Me.colPlantTypeName.ReadOnly = True
        Me.colPlantTypeName.Visible = False
        '
        'colidtype
        '
        Me.colidtype.DataPropertyName = "idType"
        Me.colidtype.HeaderText = "idtype"
        Me.colidtype.Name = "colidtype"
        Me.colidtype.ReadOnly = True
        Me.colidtype.Visible = False
        '
        'colstPPNot
        '
        Me.colstPPNot.DataPropertyName = "stPPNot"
        Me.colstPPNot.HeaderText = "stPPNot"
        Me.colstPPNot.Name = "colstPPNot"
        Me.colstPPNot.ReadOnly = True
        Me.colstPPNot.Visible = False
        '
        'frmPdTSerach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(451, 402)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DGV_PdT)
        Me.Controls.Add(Me.txt_Sname)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "frmPdTSerach"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ค้นหาสินค้า"
        CType(Me.DGV_PdT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_Sname As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DGV_PdT As System.Windows.Forms.DataGridView
    Friend WithEvents idSeedKind As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chkpp As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn_add As System.Windows.Forms.Button
    Friend WithEvents colPdt As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents colSel2 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents colPdTname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPdTnameEN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colidPdT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colidSeedType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colidSeedKind As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPlantTypeName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colidtype As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colstPPNot As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
