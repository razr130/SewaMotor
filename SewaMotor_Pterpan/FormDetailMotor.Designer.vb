<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormDetailMotor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDetailMotor))
        Me.dtsewa = New System.Windows.Forms.DateTimePicker()
        Me.label9 = New System.Windows.Forms.Label()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.label7 = New System.Windows.Forms.Label()
        Me.cbWaktu = New System.Windows.Forms.ComboBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.txtWaktu = New System.Windows.Forms.TextBox()
        Me.linkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.txtPlat = New System.Windows.Forms.TextBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.txtMerek = New System.Windows.Forms.TextBox()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrev = New System.Windows.Forms.Button()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.btnSewa = New System.Windows.Forms.Button()
        Me.txtKode = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCustomer = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txthiddenharga = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbJaminan = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnMember = New System.Windows.Forms.Button()
        Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.homeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.logOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblDiskon = New System.Windows.Forms.Label()
        Me.groupBox1.SuspendLayout()
        Me.menuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtsewa
        '
        Me.dtsewa.Enabled = False
        Me.dtsewa.Location = New System.Drawing.Point(247, 57)
        Me.dtsewa.Name = "dtsewa"
        Me.dtsewa.Size = New System.Drawing.Size(200, 20)
        Me.dtsewa.TabIndex = 27
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Location = New System.Drawing.Point(367, 33)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(82, 15)
        Me.label9.TabIndex = 26
        Me.label9.Text = "Tanggal Pinjam"
        '
        'txtStatus
        '
        Me.txtStatus.Location = New System.Drawing.Point(70, 113)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Size = New System.Drawing.Size(146, 20)
        Me.txtStatus.TabIndex = 23
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(12, 116)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(38, 15)
        Me.label7.TabIndex = 22
        Me.label7.Text = "Status"
        '
        'cbWaktu
        '
        Me.cbWaktu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbWaktu.FormattingEnabled = True
        Me.cbWaktu.Items.AddRange(New Object() {"Hari", "Minggu", "Bulan", "Tahun"})
        Me.cbWaktu.Location = New System.Drawing.Point(370, 107)
        Me.cbWaktu.Name = "cbWaktu"
        Me.cbWaktu.Size = New System.Drawing.Size(77, 23)
        Me.cbWaktu.TabIndex = 21
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(12, 33)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(32, 15)
        Me.label1.TabIndex = 1
        Me.label1.Text = "Kode"
        '
        'txtWaktu
        '
        Me.txtWaktu.Location = New System.Drawing.Point(329, 107)
        Me.txtWaktu.Name = "txtWaktu"
        Me.txtWaktu.Size = New System.Drawing.Size(35, 20)
        Me.txtWaktu.TabIndex = 20
        '
        'linkLabel1
        '
        Me.linkLabel1.AutoSize = True
        Me.linkLabel1.Location = New System.Drawing.Point(17, 281)
        Me.linkLabel1.Name = "linkLabel1"
        Me.linkLabel1.Size = New System.Drawing.Size(61, 15)
        Me.linkLabel1.TabIndex = 10
        Me.linkLabel1.TabStop = True
        Me.linkLabel1.Text = "<< kembali"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(340, 87)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(105, 15)
        Me.label6.TabIndex = 19
        Me.label6.Text = "Jangka Waktu Sewa"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(12, 60)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(32, 15)
        Me.label3.TabIndex = 11
        Me.label3.Text = "Merk"
        '
        'txtHarga
        '
        Me.txtHarga.Enabled = False
        Me.txtHarga.Location = New System.Drawing.Point(347, 228)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.Size = New System.Drawing.Size(102, 20)
        Me.txtHarga.TabIndex = 18
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(12, 87)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(27, 15)
        Me.label4.TabIndex = 12
        Me.label4.Text = "Plat"
        '
        'txtPlat
        '
        Me.txtPlat.Location = New System.Drawing.Point(70, 84)
        Me.txtPlat.Name = "txtPlat"
        Me.txtPlat.Size = New System.Drawing.Size(146, 20)
        Me.txtPlat.TabIndex = 17
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(278, 141)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(47, 15)
        Me.label5.TabIndex = 13
        Me.label5.Text = "Jaminan"
        '
        'txtMerek
        '
        Me.txtMerek.Location = New System.Drawing.Point(70, 57)
        Me.txtMerek.Name = "txtMerek"
        Me.txtMerek.Size = New System.Drawing.Size(146, 20)
        Me.txtMerek.TabIndex = 16
        '
        'btnLast
        '
        Me.btnLast.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLast.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnLast.Location = New System.Drawing.Point(164, 180)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(32, 26)
        Me.btnLast.TabIndex = 14
        Me.btnLast.Text = ">|"
        Me.btnLast.UseVisualStyleBackColor = False
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnNext.Location = New System.Drawing.Point(126, 180)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(32, 26)
        Me.btnNext.TabIndex = 14
        Me.btnNext.Text = ">"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'btnPrev
        '
        Me.btnPrev.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrev.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnPrev.Location = New System.Drawing.Point(88, 180)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(32, 26)
        Me.btnPrev.TabIndex = 14
        Me.btnPrev.Text = "<"
        Me.btnPrev.UseVisualStyleBackColor = False
        '
        'btnFirst
        '
        Me.btnFirst.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFirst.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnFirst.Location = New System.Drawing.Point(50, 180)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(32, 26)
        Me.btnFirst.TabIndex = 14
        Me.btnFirst.Text = "|<"
        Me.btnFirst.UseVisualStyleBackColor = False
        '
        'btnSewa
        '
        Me.btnSewa.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnSewa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSewa.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSewa.Location = New System.Drawing.Point(164, 272)
        Me.btnSewa.Name = "btnSewa"
        Me.btnSewa.Size = New System.Drawing.Size(154, 29)
        Me.btnSewa.TabIndex = 14
        Me.btnSewa.Text = "Sewa Sekarang"
        Me.btnSewa.UseVisualStyleBackColor = False
        '
        'txtKode
        '
        Me.txtKode.Location = New System.Drawing.Point(70, 30)
        Me.txtKode.Name = "txtKode"
        Me.txtKode.Size = New System.Drawing.Size(146, 20)
        Me.txtKode.TabIndex = 15
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(266, 109)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(0, 13)
        Me.label2.TabIndex = 23
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.lblDiskon)
        Me.groupBox1.Controls.Add(Me.txtCustomer)
        Me.groupBox1.Controls.Add(Me.Label11)
        Me.groupBox1.Controls.Add(Me.txthiddenharga)
        Me.groupBox1.Controls.Add(Me.dtsewa)
        Me.groupBox1.Controls.Add(Me.label9)
        Me.groupBox1.Controls.Add(Me.txtStatus)
        Me.groupBox1.Controls.Add(Me.Label8)
        Me.groupBox1.Controls.Add(Me.label7)
        Me.groupBox1.Controls.Add(Me.cbJaminan)
        Me.groupBox1.Controls.Add(Me.cbWaktu)
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Controls.Add(Me.txtWaktu)
        Me.groupBox1.Controls.Add(Me.linkLabel1)
        Me.groupBox1.Controls.Add(Me.label6)
        Me.groupBox1.Controls.Add(Me.label3)
        Me.groupBox1.Controls.Add(Me.txtHarga)
        Me.groupBox1.Controls.Add(Me.label4)
        Me.groupBox1.Controls.Add(Me.txtPlat)
        Me.groupBox1.Controls.Add(Me.Label10)
        Me.groupBox1.Controls.Add(Me.label5)
        Me.groupBox1.Controls.Add(Me.txtMerek)
        Me.groupBox1.Controls.Add(Me.btnMember)
        Me.groupBox1.Controls.Add(Me.btnLast)
        Me.groupBox1.Controls.Add(Me.btnNext)
        Me.groupBox1.Controls.Add(Me.btnPrev)
        Me.groupBox1.Controls.Add(Me.btnFirst)
        Me.groupBox1.Controls.Add(Me.btnSewa)
        Me.groupBox1.Controls.Add(Me.txtKode)
        Me.groupBox1.Font = New System.Drawing.Font("Franklin Gothic Demi", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox1.Location = New System.Drawing.Point(12, 36)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(461, 319)
        Me.groupBox1.TabIndex = 25
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Detail Motor"
        '
        'txtCustomer
        '
        Me.txtCustomer.Location = New System.Drawing.Point(347, 167)
        Me.txtCustomer.Name = "txtCustomer"
        Me.txtCustomer.Size = New System.Drawing.Size(102, 20)
        Me.txtCustomer.TabIndex = 30
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(256, 169)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(91, 15)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "Nama Customer  "
        '
        'txthiddenharga
        '
        Me.txthiddenharga.Location = New System.Drawing.Point(70, 144)
        Me.txthiddenharga.Name = "txthiddenharga"
        Me.txthiddenharga.Size = New System.Drawing.Size(146, 20)
        Me.txthiddenharga.TabIndex = 28
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(14, 146)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 15)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Harga"
        '
        'cbJaminan
        '
        Me.cbJaminan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbJaminan.FormattingEnabled = True
        Me.cbJaminan.Items.AddRange(New Object() {"KTP", "KTM", "SIM"})
        Me.cbJaminan.Location = New System.Drawing.Point(370, 138)
        Me.cbJaminan.Name = "cbJaminan"
        Me.cbJaminan.Size = New System.Drawing.Size(77, 23)
        Me.cbJaminan.TabIndex = 21
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(278, 231)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 15)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Total Harga"
        '
        'btnMember
        '
        Me.btnMember.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMember.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnMember.Location = New System.Drawing.Point(358, 195)
        Me.btnMember.Name = "btnMember"
        Me.btnMember.Size = New System.Drawing.Size(87, 26)
        Me.btnMember.TabIndex = 14
        Me.btnMember.Text = "Pilih Member"
        Me.btnMember.UseVisualStyleBackColor = False
        '
        'menuStrip1
        '
        Me.menuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.homeToolStripMenuItem, Me.logOutToolStripMenuItem})
        Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip1.Name = "menuStrip1"
        Me.menuStrip1.Size = New System.Drawing.Size(488, 24)
        Me.menuStrip1.TabIndex = 26
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
        'lblDiskon
        '
        Me.lblDiskon.AutoSize = True
        Me.lblDiskon.Location = New System.Drawing.Point(345, 251)
        Me.lblDiskon.Name = "lblDiskon"
        Me.lblDiskon.Size = New System.Drawing.Size(69, 15)
        Me.lblDiskon.TabIndex = 31
        Me.lblDiskon.Text = "*Diskon 10%"
        Me.lblDiskon.Visible = False
        '
        'FormDetailMotor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(488, 367)
        Me.Controls.Add(Me.menuStrip1)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.groupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormDetailMotor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormDetailMotor"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.menuStrip1.ResumeLayout(False)
        Me.menuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents dtsewa As DateTimePicker
    Private WithEvents label9 As Label
    Private WithEvents txtStatus As TextBox
    Private WithEvents label7 As Label
    Private WithEvents cbWaktu As ComboBox
    Private WithEvents label1 As Label
    Private WithEvents txtWaktu As TextBox
    Private WithEvents linkLabel1 As LinkLabel
    Private WithEvents label6 As Label
    Private WithEvents label3 As Label
    Private WithEvents txtHarga As TextBox
    Private WithEvents label4 As Label
    Private WithEvents txtPlat As TextBox
    Private WithEvents label5 As Label
    Private WithEvents txtMerek As TextBox
    Private WithEvents btnLast As Button
    Private WithEvents btnNext As Button
    Private WithEvents btnPrev As Button
    Private WithEvents btnFirst As Button
    Private WithEvents btnSewa As Button
    Private WithEvents txtKode As TextBox
    Private WithEvents label2 As Label
    Private WithEvents groupBox1 As GroupBox
    Friend WithEvents txthiddenharga As TextBox
    Private WithEvents Label8 As Label
    Private WithEvents menuStrip1 As MenuStrip
    Private WithEvents homeToolStripMenuItem As ToolStripMenuItem
    Private WithEvents logOutToolStripMenuItem As ToolStripMenuItem
    Private WithEvents cbJaminan As ComboBox
    Private WithEvents Label10 As Label
    Friend WithEvents txtCustomer As TextBox
    Friend WithEvents Label11 As Label
    Private WithEvents btnMember As Button
    Friend WithEvents lblDiskon As Label
End Class
