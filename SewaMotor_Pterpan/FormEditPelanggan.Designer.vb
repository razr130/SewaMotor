﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormEditPelanggan
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
        Me.label1 = New System.Windows.Forms.Label()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.DtTglLahir = New System.Windows.Forms.DateTimePicker()
        Me.label5 = New System.Windows.Forms.Label()
        Me.txtNoKTP = New System.Windows.Forms.TextBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtNoTelp = New System.Windows.Forms.TextBox()
        Me.label7 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.toolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.katalogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.homeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtIdPelanggan = New System.Windows.Forms.TextBox()
        Me.groupBox2.SuspendLayout()
        Me.menuStrip1.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=.\SQLEXPRESS;Initial Catalog=SewaMotor;Integrated Security=True"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(20, 47)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(35, 13)
        Me.label1.TabIndex = 0
        Me.label1.Text = "E-mail"
        '
        'btnBatal
        '
        Me.btnBatal.Location = New System.Drawing.Point(275, 271)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(75, 23)
        Me.btnBatal.TabIndex = 9
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(115, 44)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(100, 20)
        Me.txtEmail.TabIndex = 4
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(20, 73)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(53, 13)
        Me.label2.TabIndex = 1
        Me.label2.Text = "Password"
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(194, 271)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(75, 23)
        Me.btnSimpan.TabIndex = 8
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'txtAlamat
        '
        Me.txtAlamat.Location = New System.Drawing.Point(116, 101)
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(136, 20)
        Me.txtAlamat.TabIndex = 12
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(17, 27)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(80, 13)
        Me.label3.TabIndex = 2
        Me.label3.Text = "Nama Lengkap"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(17, 101)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(39, 13)
        Me.label4.TabIndex = 3
        Me.label4.Text = "Alamat"
        '
        'DtTglLahir
        '
        Me.DtTglLahir.Location = New System.Drawing.Point(116, 72)
        Me.DtTglLahir.Name = "DtTglLahir"
        Me.DtTglLahir.Size = New System.Drawing.Size(195, 20)
        Me.DtTglLahir.TabIndex = 10
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(17, 130)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(39, 13)
        Me.label5.TabIndex = 3
        Me.label5.Text = "no.telp"
        '
        'txtNoKTP
        '
        Me.txtNoKTP.Location = New System.Drawing.Point(116, 47)
        Me.txtNoKTP.Name = "txtNoKTP"
        Me.txtNoKTP.Size = New System.Drawing.Size(195, 20)
        Me.txtNoKTP.TabIndex = 7
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(116, 24)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(195, 20)
        Me.txtNama.TabIndex = 6
        '
        'txtNoTelp
        '
        Me.txtNoTelp.Location = New System.Drawing.Point(116, 127)
        Me.txtNoTelp.Name = "txtNoTelp"
        Me.txtNoTelp.Size = New System.Drawing.Size(136, 20)
        Me.txtNoTelp.TabIndex = 7
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(17, 50)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(43, 13)
        Me.label7.TabIndex = 3
        Me.label7.Text = "no.KTP"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(17, 78)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(48, 13)
        Me.label6.TabIndex = 3
        Me.label6.Text = "Tgl Lahir"
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.txtAlamat)
        Me.groupBox2.Controls.Add(Me.label3)
        Me.groupBox2.Controls.Add(Me.label4)
        Me.groupBox2.Controls.Add(Me.DtTglLahir)
        Me.groupBox2.Controls.Add(Me.label5)
        Me.groupBox2.Controls.Add(Me.txtNoKTP)
        Me.groupBox2.Controls.Add(Me.txtNama)
        Me.groupBox2.Controls.Add(Me.txtNoTelp)
        Me.groupBox2.Controls.Add(Me.label7)
        Me.groupBox2.Controls.Add(Me.label6)
        Me.groupBox2.Location = New System.Drawing.Point(17, 100)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(331, 165)
        Me.groupBox2.TabIndex = 11
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "Data Diri"
        '
        'toolStripMenuItem1
        '
        Me.toolStripMenuItem1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.toolStripMenuItem1.Name = "toolStripMenuItem1"
        Me.toolStripMenuItem1.Size = New System.Drawing.Size(49, 20)
        Me.toolStripMenuItem1.Text = "Login"
        '
        'katalogToolStripMenuItem
        '
        Me.katalogToolStripMenuItem.Name = "katalogToolStripMenuItem"
        Me.katalogToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.katalogToolStripMenuItem.Text = "Katalog"
        '
        'homeToolStripMenuItem
        '
        Me.homeToolStripMenuItem.Name = "homeToolStripMenuItem"
        Me.homeToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.homeToolStripMenuItem.Text = "Home"
        '
        'menuStrip1
        '
        Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.homeToolStripMenuItem, Me.katalogToolStripMenuItem, Me.toolStripMenuItem1})
        Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip1.Name = "menuStrip1"
        Me.menuStrip1.Size = New System.Drawing.Size(378, 24)
        Me.menuStrip1.TabIndex = 14
        Me.menuStrip1.Text = "menuStrip1"
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(115, 70)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtPass.Size = New System.Drawing.Size(100, 20)
        Me.txtPass.TabIndex = 5
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.Label8)
        Me.groupBox1.Controls.Add(Me.groupBox2)
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Controls.Add(Me.btnBatal)
        Me.groupBox1.Controls.Add(Me.txtIdPelanggan)
        Me.groupBox1.Controls.Add(Me.txtEmail)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Controls.Add(Me.btnSimpan)
        Me.groupBox1.Controls.Add(Me.txtPass)
        Me.groupBox1.Location = New System.Drawing.Point(12, 27)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(357, 308)
        Me.groupBox1.TabIndex = 15
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Edit Pelanggan"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(20, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(18, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "ID"
        '
        'txtIdPelanggan
        '
        Me.txtIdPelanggan.Location = New System.Drawing.Point(115, 19)
        Me.txtIdPelanggan.Name = "txtIdPelanggan"
        Me.txtIdPelanggan.ReadOnly = True
        Me.txtIdPelanggan.Size = New System.Drawing.Size(100, 20)
        Me.txtIdPelanggan.TabIndex = 4
        '
        'FormEditPelanggan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(378, 351)
        Me.Controls.Add(Me.menuStrip1)
        Me.Controls.Add(Me.groupBox1)
        Me.Name = "FormEditPelanggan"
        Me.Text = "FormEditPelanggan"
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        Me.menuStrip1.ResumeLayout(False)
        Me.menuStrip1.PerformLayout()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SqlConnection1 As SqlClient.SqlConnection
    Private WithEvents label1 As Label
    Private WithEvents btnBatal As Button
    Private WithEvents txtEmail As TextBox
    Private WithEvents label2 As Label
    Private WithEvents btnSimpan As Button
    Private WithEvents txtAlamat As TextBox
    Private WithEvents label3 As Label
    Private WithEvents label4 As Label
    Private WithEvents DtTglLahir As DateTimePicker
    Private WithEvents label5 As Label
    Private WithEvents txtNoKTP As TextBox
    Private WithEvents txtNama As TextBox
    Private WithEvents txtNoTelp As TextBox
    Private WithEvents label7 As Label
    Private WithEvents label6 As Label
    Private WithEvents groupBox2 As GroupBox
    Private WithEvents toolStripMenuItem1 As ToolStripMenuItem
    Private WithEvents katalogToolStripMenuItem As ToolStripMenuItem
    Private WithEvents homeToolStripMenuItem As ToolStripMenuItem
    Private WithEvents menuStrip1 As MenuStrip
    Private WithEvents txtPass As TextBox
    Private WithEvents groupBox1 As GroupBox
    Private WithEvents Label8 As Label
    Private WithEvents txtIdPelanggan As TextBox
End Class