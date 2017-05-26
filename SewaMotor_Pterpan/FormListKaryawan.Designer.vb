<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormListKaryawan
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
        Me.groupDaftarPelanggan = New System.Windows.Forms.GroupBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.lblCari = New System.Windows.Forms.Label()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUbah = New System.Windows.Forms.Button()
        Me.dgvKaryawan = New System.Windows.Forms.DataGridView()
        Me.SewaMotorDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SewaMotorDataSet = New SewaMotor_Pterpan.SewaMotorDataSet()
        Me.label2 = New System.Windows.Forms.Label()
        Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.homeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.katalogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.logOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListPelangganToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListKaryawanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListOrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanPenyewaanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanStatusMotorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanKeterlambatanMotorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.groupDaftarPelanggan.SuspendLayout()
        CType(Me.dgvKaryawan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SewaMotorDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SewaMotorDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.menuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'groupDaftarPelanggan
        '
        Me.groupDaftarPelanggan.Controls.Add(Me.btnClose)
        Me.groupDaftarPelanggan.Controls.Add(Me.btnTambah)
        Me.groupDaftarPelanggan.Controls.Add(Me.lblCari)
        Me.groupDaftarPelanggan.Controls.Add(Me.txtCari)
        Me.groupDaftarPelanggan.Controls.Add(Me.btnDelete)
        Me.groupDaftarPelanggan.Controls.Add(Me.btnUbah)
        Me.groupDaftarPelanggan.Controls.Add(Me.dgvKaryawan)
        Me.groupDaftarPelanggan.Font = New System.Drawing.Font("Franklin Gothic Demi", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupDaftarPelanggan.Location = New System.Drawing.Point(12, 38)
        Me.groupDaftarPelanggan.Name = "groupDaftarPelanggan"
        Me.groupDaftarPelanggan.Size = New System.Drawing.Size(568, 361)
        Me.groupDaftarPelanggan.TabIndex = 31
        Me.groupDaftarPelanggan.TabStop = False
        Me.groupDaftarPelanggan.Text = "Daftar Karyawan"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnClose.Location = New System.Drawing.Point(481, 326)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 21
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnTambah
        '
        Me.btnTambah.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTambah.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnTambah.Location = New System.Drawing.Point(11, 326)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(75, 23)
        Me.btnTambah.TabIndex = 20
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = False
        '
        'lblCari
        '
        Me.lblCari.AutoSize = True
        Me.lblCari.Location = New System.Drawing.Point(159, 30)
        Me.lblCari.Name = "lblCari"
        Me.lblCari.Size = New System.Drawing.Size(84, 15)
        Me.lblCari.TabIndex = 19
        Me.lblCari.Text = "Cari Karyawan: "
        '
        'txtCari
        '
        Me.txtCari.Location = New System.Drawing.Point(250, 27)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(306, 20)
        Me.txtCari.TabIndex = 14
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnDelete.Location = New System.Drawing.Point(179, 326)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 17
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnUbah
        '
        Me.btnUbah.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnUbah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUbah.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnUbah.Location = New System.Drawing.Point(98, 326)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(75, 23)
        Me.btnUbah.TabIndex = 18
        Me.btnUbah.Text = "Ubah"
        Me.btnUbah.UseVisualStyleBackColor = False
        '
        'dgvKaryawan
        '
        Me.dgvKaryawan.AllowUserToAddRows = False
        Me.dgvKaryawan.AllowUserToDeleteRows = False
        Me.dgvKaryawan.AllowUserToOrderColumns = True
        Me.dgvKaryawan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvKaryawan.Location = New System.Drawing.Point(11, 55)
        Me.dgvKaryawan.Name = "dgvKaryawan"
        Me.dgvKaryawan.ReadOnly = True
        Me.dgvKaryawan.Size = New System.Drawing.Size(545, 261)
        Me.dgvKaryawan.TabIndex = 15
        '
        'SewaMotorDataSetBindingSource
        '
        Me.SewaMotorDataSetBindingSource.DataSource = Me.SewaMotorDataSet
        Me.SewaMotorDataSetBindingSource.Position = 0
        '
        'SewaMotorDataSet
        '
        Me.SewaMotorDataSet.DataSetName = "SewaMotorDataSet"
        Me.SewaMotorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(266, 100)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(0, 13)
        Me.label2.TabIndex = 29
        '
        'menuStrip1
        '
        Me.menuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.homeToolStripMenuItem, Me.katalogToolStripMenuItem, Me.logOutToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.ReportToolStripMenuItem})
        Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip1.Name = "menuStrip1"
        Me.menuStrip1.Size = New System.Drawing.Size(588, 24)
        Me.menuStrip1.TabIndex = 32
        Me.menuStrip1.Text = "menuStrip1"
        '
        'homeToolStripMenuItem
        '
        Me.homeToolStripMenuItem.Font = New System.Drawing.Font("Franklin Gothic Demi", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.homeToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.homeToolStripMenuItem.Name = "homeToolStripMenuItem"
        Me.homeToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.homeToolStripMenuItem.Text = "Home"
        '
        'katalogToolStripMenuItem
        '
        Me.katalogToolStripMenuItem.Font = New System.Drawing.Font("Franklin Gothic Demi", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.katalogToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.katalogToolStripMenuItem.Name = "katalogToolStripMenuItem"
        Me.katalogToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.katalogToolStripMenuItem.Text = "Katalog"
        '
        'logOutToolStripMenuItem
        '
        Me.logOutToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.logOutToolStripMenuItem.Font = New System.Drawing.Font("Franklin Gothic Demi", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logOutToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem"
        Me.logOutToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.logOutToolStripMenuItem.Text = "Logout"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListPelangganToolStripMenuItem, Me.ListKaryawanToolStripMenuItem, Me.ListOrderToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Font = New System.Drawing.Font("Franklin Gothic Demi", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.ToolsToolStripMenuItem.Text = "Tools"
        '
        'ListPelangganToolStripMenuItem
        '
        Me.ListPelangganToolStripMenuItem.Name = "ListPelangganToolStripMenuItem"
        Me.ListPelangganToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.ListPelangganToolStripMenuItem.Text = "List Pelanggan"
        '
        'ListKaryawanToolStripMenuItem
        '
        Me.ListKaryawanToolStripMenuItem.Name = "ListKaryawanToolStripMenuItem"
        Me.ListKaryawanToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.ListKaryawanToolStripMenuItem.Text = "List Karyawan"
        '
        'ListOrderToolStripMenuItem
        '
        Me.ListOrderToolStripMenuItem.Name = "ListOrderToolStripMenuItem"
        Me.ListOrderToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.ListOrderToolStripMenuItem.Text = "List Order"
        '
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LaporanPenyewaanToolStripMenuItem, Me.LaporanStatusMotorToolStripMenuItem, Me.LaporanKeterlambatanMotorToolStripMenuItem})
        Me.ReportToolStripMenuItem.Font = New System.Drawing.Font("Franklin Gothic Demi", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReportToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.ReportToolStripMenuItem.Text = "Report"
        '
        'LaporanPenyewaanToolStripMenuItem
        '
        Me.LaporanPenyewaanToolStripMenuItem.Name = "LaporanPenyewaanToolStripMenuItem"
        Me.LaporanPenyewaanToolStripMenuItem.Size = New System.Drawing.Size(235, 22)
        Me.LaporanPenyewaanToolStripMenuItem.Text = "Laporan Penyewaan"
        '
        'LaporanStatusMotorToolStripMenuItem
        '
        Me.LaporanStatusMotorToolStripMenuItem.Name = "LaporanStatusMotorToolStripMenuItem"
        Me.LaporanStatusMotorToolStripMenuItem.Size = New System.Drawing.Size(235, 22)
        Me.LaporanStatusMotorToolStripMenuItem.Text = "Laporan Status Motor"
        '
        'LaporanKeterlambatanMotorToolStripMenuItem
        '
        Me.LaporanKeterlambatanMotorToolStripMenuItem.Name = "LaporanKeterlambatanMotorToolStripMenuItem"
        Me.LaporanKeterlambatanMotorToolStripMenuItem.Size = New System.Drawing.Size(235, 22)
        Me.LaporanKeterlambatanMotorToolStripMenuItem.Text = "Laporan Keterlambatan Motor"
        '
        'FormListKaryawan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(588, 411)
        Me.Controls.Add(Me.menuStrip1)
        Me.Controls.Add(Me.groupDaftarPelanggan)
        Me.Controls.Add(Me.label2)
        Me.Name = "FormListKaryawan"
        Me.Text = "FormListKaryawan"
        Me.groupDaftarPelanggan.ResumeLayout(False)
        Me.groupDaftarPelanggan.PerformLayout()
        CType(Me.dgvKaryawan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SewaMotorDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SewaMotorDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.menuStrip1.ResumeLayout(False)
        Me.menuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents groupDaftarPelanggan As GroupBox
    Private WithEvents lblCari As Label
    Friend WithEvents txtCari As TextBox
    Private WithEvents btnDelete As Button
    Private WithEvents btnUbah As Button
    Friend WithEvents dgvKaryawan As DataGridView
    Friend WithEvents SewaMotorDataSetBindingSource As BindingSource
    Friend WithEvents SewaMotorDataSet As SewaMotorDataSet
    Private WithEvents label2 As Label
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnClose As Button
    Private WithEvents menuStrip1 As MenuStrip
    Private WithEvents homeToolStripMenuItem As ToolStripMenuItem
    Private WithEvents katalogToolStripMenuItem As ToolStripMenuItem
    Private WithEvents logOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListPelangganToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListKaryawanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListOrderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanPenyewaanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanStatusMotorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanKeterlambatanMotorToolStripMenuItem As ToolStripMenuItem
End Class
