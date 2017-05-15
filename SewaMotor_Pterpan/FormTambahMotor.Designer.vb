<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTambahMotor
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
        Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.homeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.katalogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.loginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnBatal2 = New System.Windows.Forms.Button()
        Me.label1 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.txtPlat = New System.Windows.Forms.TextBox()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.txtNoRangka = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.txtNoMesin = New System.Windows.Forms.TextBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.txtMerk = New System.Windows.Forms.TextBox()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.txtJenis = New System.Windows.Forms.TextBox()
        Me.menuStrip1.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'menuStrip1
        '
        Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.homeToolStripMenuItem, Me.katalogToolStripMenuItem, Me.loginToolStripMenuItem})
        Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip1.Name = "menuStrip1"
        Me.menuStrip1.Size = New System.Drawing.Size(295, 24)
        Me.menuStrip1.TabIndex = 25
        Me.menuStrip1.Text = "menuStrip1"
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
        'loginToolStripMenuItem
        '
        Me.loginToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.loginToolStripMenuItem.Name = "loginToolStripMenuItem"
        Me.loginToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.loginToolStripMenuItem.Text = "Logout"
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.btnBatal2)
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Controls.Add(Me.label3)
        Me.groupBox1.Controls.Add(Me.txtHarga)
        Me.groupBox1.Controls.Add(Me.txtPlat)
        Me.groupBox1.Controls.Add(Me.txtStatus)
        Me.groupBox1.Controls.Add(Me.txtNoRangka)
        Me.groupBox1.Controls.Add(Me.Label2)
        Me.groupBox1.Controls.Add(Me.label7)
        Me.groupBox1.Controls.Add(Me.label4)
        Me.groupBox1.Controls.Add(Me.label6)
        Me.groupBox1.Controls.Add(Me.txtNoMesin)
        Me.groupBox1.Controls.Add(Me.label5)
        Me.groupBox1.Controls.Add(Me.txtMerk)
        Me.groupBox1.Controls.Add(Me.btnSimpan)
        Me.groupBox1.Controls.Add(Me.txtJenis)
        Me.groupBox1.Location = New System.Drawing.Point(24, 48)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(237, 298)
        Me.groupBox1.TabIndex = 26
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Tambah Motor"
        '
        'btnBatal2
        '
        Me.btnBatal2.Location = New System.Drawing.Point(124, 244)
        Me.btnBatal2.Name = "btnBatal2"
        Me.btnBatal2.Size = New System.Drawing.Size(75, 23)
        Me.btnBatal2.TabIndex = 19
        Me.btnBatal2.Text = "Batal"
        Me.btnBatal2.UseVisualStyleBackColor = True
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(13, 28)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(31, 13)
        Me.label1.TabIndex = 1
        Me.label1.Text = "Jenis"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(13, 55)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(31, 13)
        Me.label3.TabIndex = 11
        Me.label3.Text = "Merk"
        '
        'txtHarga
        '
        Me.txtHarga.Location = New System.Drawing.Point(71, 197)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.Size = New System.Drawing.Size(100, 20)
        Me.txtHarga.TabIndex = 18
        '
        'txtPlat
        '
        Me.txtPlat.Location = New System.Drawing.Point(71, 166)
        Me.txtPlat.Name = "txtPlat"
        Me.txtPlat.Size = New System.Drawing.Size(100, 20)
        Me.txtPlat.TabIndex = 18
        '
        'txtStatus
        '
        Me.txtStatus.Location = New System.Drawing.Point(71, 135)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Size = New System.Drawing.Size(100, 20)
        Me.txtStatus.TabIndex = 18
        '
        'txtNoRangka
        '
        Me.txtNoRangka.Location = New System.Drawing.Point(71, 107)
        Me.txtNoRangka.Name = "txtNoRangka"
        Me.txtNoRangka.Size = New System.Drawing.Size(100, 20)
        Me.txtNoRangka.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 201)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Harga"
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(12, 169)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(28, 13)
        Me.label7.TabIndex = 13
        Me.label7.Text = "Plat "
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(13, 83)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(52, 13)
        Me.label4.TabIndex = 12
        Me.label4.Text = "No Mesin"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(13, 138)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(37, 13)
        Me.label6.TabIndex = 13
        Me.label6.Text = "Status"
        '
        'txtNoMesin
        '
        Me.txtNoMesin.Location = New System.Drawing.Point(71, 80)
        Me.txtNoMesin.Name = "txtNoMesin"
        Me.txtNoMesin.Size = New System.Drawing.Size(100, 20)
        Me.txtNoMesin.TabIndex = 17
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(13, 110)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(56, 13)
        Me.label5.TabIndex = 13
        Me.label5.Text = "No Ranka"
        '
        'txtMerk
        '
        Me.txtMerk.Location = New System.Drawing.Point(71, 52)
        Me.txtMerk.Name = "txtMerk"
        Me.txtMerk.Size = New System.Drawing.Size(100, 20)
        Me.txtMerk.TabIndex = 16
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(33, 244)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(75, 23)
        Me.btnSimpan.TabIndex = 14
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'txtJenis
        '
        Me.txtJenis.Location = New System.Drawing.Point(71, 25)
        Me.txtJenis.Name = "txtJenis"
        Me.txtJenis.Size = New System.Drawing.Size(100, 20)
        Me.txtJenis.TabIndex = 15
        '
        'FormTambahMotor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(295, 358)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.menuStrip1)
        Me.Name = "FormTambahMotor"
        Me.Text = "FormTambahMotor"
        Me.menuStrip1.ResumeLayout(False)
        Me.menuStrip1.PerformLayout()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents menuStrip1 As MenuStrip
    Private WithEvents homeToolStripMenuItem As ToolStripMenuItem
    Private WithEvents katalogToolStripMenuItem As ToolStripMenuItem
    Private WithEvents loginToolStripMenuItem As ToolStripMenuItem
    Private WithEvents groupBox1 As GroupBox
    Private WithEvents btnBatal2 As Button
    Private WithEvents label1 As Label
    Private WithEvents label3 As Label
    Private WithEvents txtHarga As TextBox
    Private WithEvents txtPlat As TextBox
    Private WithEvents txtStatus As TextBox
    Private WithEvents txtNoRangka As TextBox
    Private WithEvents Label2 As Label
    Private WithEvents label7 As Label
    Private WithEvents label4 As Label
    Private WithEvents label6 As Label
    Private WithEvents txtNoMesin As TextBox
    Private WithEvents label5 As Label
    Private WithEvents txtMerk As TextBox
    Private WithEvents btnSimpan As Button
    Private WithEvents txtJenis As TextBox
End Class
