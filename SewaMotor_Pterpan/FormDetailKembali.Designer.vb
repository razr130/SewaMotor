﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDetailKembali
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
        Me.gdvKembali = New System.Windows.Forms.DataGridView()
        Me.txtNoOrder = New System.Windows.Forms.TextBox()
        Me.txtNamaCustomer = New System.Windows.Forms.TextBox()
        Me.txtNamaKaryawan = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtHargaSewa = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnSelesai = New System.Windows.Forms.Button()
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
        CType(Me.gdvKembali, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.menuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gdvKembali
        '
        Me.gdvKembali.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gdvKembali.Location = New System.Drawing.Point(12, 161)
        Me.gdvKembali.Name = "gdvKembali"
        Me.gdvKembali.Size = New System.Drawing.Size(434, 171)
        Me.gdvKembali.TabIndex = 5
        '
        'txtNoOrder
        '
        Me.txtNoOrder.Enabled = False
        Me.txtNoOrder.Location = New System.Drawing.Point(13, 65)
        Me.txtNoOrder.Name = "txtNoOrder"
        Me.txtNoOrder.Size = New System.Drawing.Size(39, 20)
        Me.txtNoOrder.TabIndex = 6
        '
        'txtNamaCustomer
        '
        Me.txtNamaCustomer.Enabled = False
        Me.txtNamaCustomer.Location = New System.Drawing.Point(14, 123)
        Me.txtNamaCustomer.Name = "txtNamaCustomer"
        Me.txtNamaCustomer.Size = New System.Drawing.Size(115, 20)
        Me.txtNamaCustomer.TabIndex = 6
        '
        'txtNamaKaryawan
        '
        Me.txtNamaKaryawan.Enabled = False
        Me.txtNamaKaryawan.Location = New System.Drawing.Point(157, 123)
        Me.txtNamaKaryawan.Name = "txtNamaKaryawan"
        Me.txtNamaKaryawan.Size = New System.Drawing.Size(115, 20)
        Me.txtNamaKaryawan.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Demi", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 15)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "No. Order : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Demi", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 15)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Nama Pelanggan : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Demi", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(154, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Nama Karyawan : "
        '
        'txtHargaSewa
        '
        Me.txtHargaSewa.Enabled = False
        Me.txtHargaSewa.Location = New System.Drawing.Point(151, 351)
        Me.txtHargaSewa.Name = "txtHargaSewa"
        Me.txtHargaSewa.Size = New System.Drawing.Size(121, 20)
        Me.txtHargaSewa.TabIndex = 8
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Franklin Gothic Demi", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(18, 354)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(131, 15)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Harga Sewa Seluruhnya : "
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSimpan.Font = New System.Drawing.Font("Franklin Gothic Demi", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSimpan.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSimpan.Location = New System.Drawing.Point(127, 392)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(75, 23)
        Me.btnSimpan.TabIndex = 10
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = False
        '
        'btnSelesai
        '
        Me.btnSelesai.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnSelesai.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSelesai.Font = New System.Drawing.Font("Franklin Gothic Demi", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelesai.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSelesai.Location = New System.Drawing.Point(208, 392)
        Me.btnSelesai.Name = "btnSelesai"
        Me.btnSelesai.Size = New System.Drawing.Size(75, 23)
        Me.btnSelesai.TabIndex = 10
        Me.btnSelesai.Text = "Selesai"
        Me.btnSelesai.UseVisualStyleBackColor = False
        '
        'menuStrip1
        '
        Me.menuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.homeToolStripMenuItem, Me.katalogToolStripMenuItem, Me.logOutToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.ReportToolStripMenuItem})
        Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip1.Name = "menuStrip1"
        Me.menuStrip1.Size = New System.Drawing.Size(456, 24)
        Me.menuStrip1.TabIndex = 11
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
        'FormDetailKembali
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(456, 428)
        Me.Controls.Add(Me.menuStrip1)
        Me.Controls.Add(Me.btnSelesai)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.txtHargaSewa)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNamaKaryawan)
        Me.Controls.Add(Me.txtNamaCustomer)
        Me.Controls.Add(Me.txtNoOrder)
        Me.Controls.Add(Me.gdvKembali)
        Me.Name = "FormDetailKembali"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FormDetailKembali"
        CType(Me.gdvKembali, System.ComponentModel.ISupportInitialize).EndInit()
        Me.menuStrip1.ResumeLayout(False)
        Me.menuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gdvKembali As DataGridView
    Friend WithEvents txtNoOrder As TextBox
    Friend WithEvents txtNamaCustomer As TextBox
    Friend WithEvents txtNamaKaryawan As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtHargaSewa As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnSelesai As Button
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
