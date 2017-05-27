<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormEditKaryawan
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
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.radioKaryawan = New System.Windows.Forms.RadioButton()
        Me.radioAdmin = New System.Windows.Forms.RadioButton()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtNoTelp = New System.Windows.Forms.TextBox()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbSesi = New System.Windows.Forms.ComboBox()
        Me.cbHariKerja = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.homeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.logOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListPelangganToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListKaryawanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListOrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanPenyewaanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanStatusMotorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox2.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        Me.menuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=.\SQLEXPRESS;Initial Catalog=SewaMotor;Integrated Security=True"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.radioKaryawan)
        Me.GroupBox2.Controls.Add(Me.radioAdmin)
        Me.GroupBox2.Location = New System.Drawing.Point(162, 71)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(152, 43)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Account"
        '
        'radioKaryawan
        '
        Me.radioKaryawan.AutoSize = True
        Me.radioKaryawan.Location = New System.Drawing.Point(72, 19)
        Me.radioKaryawan.Name = "radioKaryawan"
        Me.radioKaryawan.Size = New System.Drawing.Size(73, 19)
        Me.radioKaryawan.TabIndex = 1
        Me.radioKaryawan.TabStop = True
        Me.radioKaryawan.Text = "Karyawan"
        Me.radioKaryawan.UseVisualStyleBackColor = True
        '
        'radioAdmin
        '
        Me.radioAdmin.AutoSize = True
        Me.radioAdmin.Location = New System.Drawing.Point(12, 19)
        Me.radioAdmin.Name = "radioAdmin"
        Me.radioAdmin.Size = New System.Drawing.Size(56, 19)
        Me.radioAdmin.TabIndex = 0
        Me.radioAdmin.TabStop = True
        Me.radioAdmin.Text = "Admin"
        Me.radioAdmin.UseVisualStyleBackColor = True
        '
        'txtAlamat
        '
        Me.txtAlamat.Location = New System.Drawing.Point(119, 160)
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(195, 20)
        Me.txtAlamat.TabIndex = 22
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(20, 137)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(80, 15)
        Me.label3.TabIndex = 13
        Me.label3.Text = "Nama Lengkap"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(20, 163)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(42, 15)
        Me.label4.TabIndex = 14
        Me.label4.Text = "Alamat"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(20, 22)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(37, 15)
        Me.label1.TabIndex = 0
        Me.label1.Text = "E-mail"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(20, 189)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(41, 15)
        Me.label5.TabIndex = 15
        Me.label5.Text = "no.telp"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(115, 19)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(199, 20)
        Me.txtEmail.TabIndex = 4
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(115, 45)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtPass.Size = New System.Drawing.Size(199, 20)
        Me.txtPass.TabIndex = 5
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(20, 48)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(54, 15)
        Me.label2.TabIndex = 1
        Me.label2.Text = "Password"
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(119, 134)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(195, 20)
        Me.txtNama.TabIndex = 18
        '
        'txtNoTelp
        '
        Me.txtNoTelp.Location = New System.Drawing.Point(119, 186)
        Me.txtNoTelp.Name = "txtNoTelp"
        Me.txtNoTelp.Size = New System.Drawing.Size(195, 20)
        Me.txtNoTelp.TabIndex = 20
        '
        'btnBatal
        '
        Me.btnBatal.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBatal.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnBatal.Location = New System.Drawing.Point(239, 277)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(75, 23)
        Me.btnBatal.TabIndex = 9
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = False
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSimpan.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSimpan.Location = New System.Drawing.Point(158, 277)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(75, 23)
        Me.btnSimpan.TabIndex = 8
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = False
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.cbSesi)
        Me.groupBox1.Controls.Add(Me.GroupBox2)
        Me.groupBox1.Controls.Add(Me.cbHariKerja)
        Me.groupBox1.Controls.Add(Me.Label7)
        Me.groupBox1.Controls.Add(Me.txtAlamat)
        Me.groupBox1.Controls.Add(Me.Label6)
        Me.groupBox1.Controls.Add(Me.label3)
        Me.groupBox1.Controls.Add(Me.label4)
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Controls.Add(Me.label5)
        Me.groupBox1.Controls.Add(Me.txtEmail)
        Me.groupBox1.Controls.Add(Me.txtPass)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Controls.Add(Me.txtNama)
        Me.groupBox1.Controls.Add(Me.txtNoTelp)
        Me.groupBox1.Controls.Add(Me.btnBatal)
        Me.groupBox1.Controls.Add(Me.btnSimpan)
        Me.groupBox1.Font = New System.Drawing.Font("Franklin Gothic Demi", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox1.Location = New System.Drawing.Point(12, 31)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(348, 311)
        Me.groupBox1.TabIndex = 17
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Edit Karyawan"
        '
        'cbSesi
        '
        Me.cbSesi.FormattingEnabled = True
        Me.cbSesi.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.cbSesi.Location = New System.Drawing.Point(119, 239)
        Me.cbSesi.Name = "cbSesi"
        Me.cbSesi.Size = New System.Drawing.Size(35, 23)
        Me.cbSesi.TabIndex = 27
        '
        'cbHariKerja
        '
        Me.cbHariKerja.FormattingEnabled = True
        Me.cbHariKerja.Items.AddRange(New Object() {"Senin", "Selasa", "Rabu", "Kamis", "Jumat", "Sabtu", "Minggu"})
        Me.cbHariKerja.Location = New System.Drawing.Point(119, 212)
        Me.cbHariKerja.Name = "cbHariKerja"
        Me.cbHariKerja.Size = New System.Drawing.Size(121, 23)
        Me.cbHariKerja.TabIndex = 28
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(20, 216)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 15)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Hari Kerja"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 242)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(26, 15)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "sesi"
        '
        'menuStrip1
        '
        Me.menuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.homeToolStripMenuItem, Me.logOutToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.ReportToolStripMenuItem})
        Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip1.Name = "menuStrip1"
        Me.menuStrip1.Size = New System.Drawing.Size(370, 24)
        Me.menuStrip1.TabIndex = 18
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
        Me.ReportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LaporanPenyewaanToolStripMenuItem, Me.LaporanStatusMotorToolStripMenuItem})
        Me.ReportToolStripMenuItem.Font = New System.Drawing.Font("Franklin Gothic Demi", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReportToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.ReportToolStripMenuItem.Text = "Report"
        '
        'LaporanPenyewaanToolStripMenuItem
        '
        Me.LaporanPenyewaanToolStripMenuItem.Name = "LaporanPenyewaanToolStripMenuItem"
        Me.LaporanPenyewaanToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.LaporanPenyewaanToolStripMenuItem.Text = "Laporan Penyewaan"
        '
        'LaporanStatusMotorToolStripMenuItem
        '
        Me.LaporanStatusMotorToolStripMenuItem.Name = "LaporanStatusMotorToolStripMenuItem"
        Me.LaporanStatusMotorToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.LaporanStatusMotorToolStripMenuItem.Text = "Laporan Status Motor"
        '
        'FormEditKaryawan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(370, 350)
        Me.Controls.Add(Me.menuStrip1)
        Me.Controls.Add(Me.groupBox1)
        Me.Name = "FormEditKaryawan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormEditKaryawan"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.menuStrip1.ResumeLayout(False)
        Me.menuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SqlConnection1 As SqlClient.SqlConnection
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents radioKaryawan As RadioButton
    Friend WithEvents radioAdmin As RadioButton
    Private WithEvents txtAlamat As TextBox
    Private WithEvents label3 As Label
    Private WithEvents label4 As Label
    Private WithEvents label1 As Label
    Private WithEvents label5 As Label
    Private WithEvents txtEmail As TextBox
    Private WithEvents txtPass As TextBox
    Private WithEvents label2 As Label
    Private WithEvents txtNama As TextBox
    Private WithEvents txtNoTelp As TextBox
    Private WithEvents btnBatal As Button
    Private WithEvents btnSimpan As Button
    Private WithEvents groupBox1 As GroupBox
    Friend WithEvents cbSesi As ComboBox
    Friend WithEvents cbHariKerja As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Private WithEvents menuStrip1 As MenuStrip
    Private WithEvents homeToolStripMenuItem As ToolStripMenuItem
    Private WithEvents logOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListPelangganToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListKaryawanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListOrderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanPenyewaanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanStatusMotorToolStripMenuItem As ToolStripMenuItem
End Class
