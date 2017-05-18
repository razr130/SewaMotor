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
        Me.homeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.katalogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
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
        Me.cbHariKerja = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbSesi = New System.Windows.Forms.ComboBox()
        Me.menuStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=.\SQLEXPRESS;Initial Catalog=SewaMotor;Integrated Security=True"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'homeToolStripMenuItem
        '
        Me.homeToolStripMenuItem.Name = "homeToolStripMenuItem"
        Me.homeToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.homeToolStripMenuItem.Text = "Home"
        '
        'katalogToolStripMenuItem
        '
        Me.katalogToolStripMenuItem.Name = "katalogToolStripMenuItem"
        Me.katalogToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.katalogToolStripMenuItem.Text = "Katalog"
        '
        'toolStripMenuItem1
        '
        Me.toolStripMenuItem1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.toolStripMenuItem1.Name = "toolStripMenuItem1"
        Me.toolStripMenuItem1.Size = New System.Drawing.Size(49, 20)
        Me.toolStripMenuItem1.Text = "Login"
        '
        'menuStrip1
        '
        Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.homeToolStripMenuItem, Me.katalogToolStripMenuItem, Me.toolStripMenuItem1})
        Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip1.Name = "menuStrip1"
        Me.menuStrip1.Size = New System.Drawing.Size(370, 24)
        Me.menuStrip1.TabIndex = 16
        Me.menuStrip1.Text = "menuStrip1"
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
        Me.radioKaryawan.Size = New System.Drawing.Size(72, 17)
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
        Me.radioAdmin.Size = New System.Drawing.Size(54, 17)
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
        Me.label3.Size = New System.Drawing.Size(80, 13)
        Me.label3.TabIndex = 13
        Me.label3.Text = "Nama Lengkap"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(20, 163)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(39, 13)
        Me.label4.TabIndex = 14
        Me.label4.Text = "Alamat"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(20, 22)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(35, 13)
        Me.label1.TabIndex = 0
        Me.label1.Text = "E-mail"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(20, 189)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(39, 13)
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
        Me.label2.Size = New System.Drawing.Size(53, 13)
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
        Me.btnBatal.Location = New System.Drawing.Point(239, 277)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(75, 23)
        Me.btnBatal.TabIndex = 9
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(158, 277)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(75, 23)
        Me.btnSimpan.TabIndex = 8
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
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
        Me.groupBox1.Location = New System.Drawing.Point(12, 27)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(348, 311)
        Me.groupBox1.TabIndex = 17
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Edit Karyawan"
        '
        'cbHariKerja
        '
        Me.cbHariKerja.FormattingEnabled = True
        Me.cbHariKerja.Items.AddRange(New Object() {"Senin", "Selasa", "Rabu", "Kamis", "Jumat", "Sabtu", "Minggu"})
        Me.cbHariKerja.Location = New System.Drawing.Point(119, 212)
        Me.cbHariKerja.Name = "cbHariKerja"
        Me.cbHariKerja.Size = New System.Drawing.Size(121, 21)
        Me.cbHariKerja.TabIndex = 28
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 242)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(25, 13)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "sesi"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(20, 216)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Hari Kerja"
        '
        'cbSesi
        '
        Me.cbSesi.FormattingEnabled = True
        Me.cbSesi.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.cbSesi.Location = New System.Drawing.Point(119, 239)
        Me.cbSesi.Name = "cbSesi"
        Me.cbSesi.Size = New System.Drawing.Size(35, 21)
        Me.cbSesi.TabIndex = 27
        '
        'FormEditKaryawan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(370, 350)
        Me.Controls.Add(Me.menuStrip1)
        Me.Controls.Add(Me.groupBox1)
        Me.Name = "FormEditKaryawan"
        Me.Text = "FormEditKaryawan"
        Me.menuStrip1.ResumeLayout(False)
        Me.menuStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SqlConnection1 As SqlClient.SqlConnection
    Private WithEvents homeToolStripMenuItem As ToolStripMenuItem
    Private WithEvents katalogToolStripMenuItem As ToolStripMenuItem
    Private WithEvents toolStripMenuItem1 As ToolStripMenuItem
    Private WithEvents menuStrip1 As MenuStrip
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
End Class
