<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDetailMotor
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
        Me.dateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.label9 = New System.Windows.Forms.Label()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.label7 = New System.Windows.Forms.Label()
        Me.comboBox1 = New System.Windows.Forms.ComboBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.textBox5 = New System.Windows.Forms.TextBox()
        Me.linkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.textBox4 = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.txtPlat = New System.Windows.Forms.TextBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.txtMerek = New System.Windows.Forms.TextBox()
        Me.button5 = New System.Windows.Forms.Button()
        Me.button4 = New System.Windows.Forms.Button()
        Me.button3 = New System.Windows.Forms.Button()
        Me.button2 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.txtKode = New System.Windows.Forms.TextBox()
        Me.katalogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.homeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.loginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.label2 = New System.Windows.Forms.Label()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.menuStrip1.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dateTimePicker1
        '
        Me.dateTimePicker1.Location = New System.Drawing.Point(247, 57)
        Me.dateTimePicker1.Name = "dateTimePicker1"
        Me.dateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.dateTimePicker1.TabIndex = 27
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Location = New System.Drawing.Point(367, 33)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(80, 13)
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
        Me.label7.Location = New System.Drawing.Point(12, 113)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(37, 13)
        Me.label7.TabIndex = 22
        Me.label7.Text = "Status"
        '
        'comboBox1
        '
        Me.comboBox1.FormattingEnabled = True
        Me.comboBox1.Items.AddRange(New Object() {"Hari", "Minggu", "Bulan", "Tahun"})
        Me.comboBox1.Location = New System.Drawing.Point(370, 107)
        Me.comboBox1.Name = "comboBox1"
        Me.comboBox1.Size = New System.Drawing.Size(77, 21)
        Me.comboBox1.TabIndex = 21
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(12, 33)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(32, 13)
        Me.label1.TabIndex = 1
        Me.label1.Text = "Kode"
        '
        'textBox5
        '
        Me.textBox5.Location = New System.Drawing.Point(329, 107)
        Me.textBox5.Name = "textBox5"
        Me.textBox5.Size = New System.Drawing.Size(35, 20)
        Me.textBox5.TabIndex = 20
        '
        'linkLabel1
        '
        Me.linkLabel1.AutoSize = True
        Me.linkLabel1.Location = New System.Drawing.Point(15, 251)
        Me.linkLabel1.Name = "linkLabel1"
        Me.linkLabel1.Size = New System.Drawing.Size(58, 13)
        Me.linkLabel1.TabIndex = 10
        Me.linkLabel1.TabStop = True
        Me.linkLabel1.Text = "<< kembali"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(340, 87)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(107, 13)
        Me.label6.TabIndex = 19
        Me.label6.Text = "Jangka Waktu Sewa"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(12, 60)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(31, 13)
        Me.label3.TabIndex = 11
        Me.label3.Text = "Merk"
        '
        'textBox4
        '
        Me.textBox4.Location = New System.Drawing.Point(347, 144)
        Me.textBox4.Name = "textBox4"
        Me.textBox4.Size = New System.Drawing.Size(100, 20)
        Me.textBox4.TabIndex = 18
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(12, 87)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(25, 13)
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
        Me.label5.Location = New System.Drawing.Point(289, 147)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(36, 13)
        Me.label5.TabIndex = 13
        Me.label5.Text = "Harga"
        '
        'txtMerek
        '
        Me.txtMerek.Location = New System.Drawing.Point(70, 57)
        Me.txtMerek.Name = "txtMerek"
        Me.txtMerek.Size = New System.Drawing.Size(146, 20)
        Me.txtMerek.TabIndex = 16
        '
        'button5
        '
        Me.button5.Location = New System.Drawing.Point(158, 150)
        Me.button5.Name = "button5"
        Me.button5.Size = New System.Drawing.Size(32, 26)
        Me.button5.TabIndex = 14
        Me.button5.Text = ">|"
        Me.button5.UseVisualStyleBackColor = True
        '
        'button4
        '
        Me.button4.Location = New System.Drawing.Point(120, 150)
        Me.button4.Name = "button4"
        Me.button4.Size = New System.Drawing.Size(32, 26)
        Me.button4.TabIndex = 14
        Me.button4.Text = ">"
        Me.button4.UseVisualStyleBackColor = True
        '
        'button3
        '
        Me.button3.Location = New System.Drawing.Point(82, 150)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(32, 26)
        Me.button3.TabIndex = 14
        Me.button3.Text = "<"
        Me.button3.UseVisualStyleBackColor = True
        '
        'button2
        '
        Me.button2.Location = New System.Drawing.Point(44, 150)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(32, 26)
        Me.button2.TabIndex = 14
        Me.button2.Text = "|<"
        Me.button2.UseVisualStyleBackColor = True
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(169, 222)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(154, 23)
        Me.button1.TabIndex = 14
        Me.button1.Text = "Sewa Sekarang"
        Me.button1.UseVisualStyleBackColor = True
        '
        'txtKode
        '
        Me.txtKode.Location = New System.Drawing.Point(70, 30)
        Me.txtKode.Name = "txtKode"
        Me.txtKode.Size = New System.Drawing.Size(146, 20)
        Me.txtKode.TabIndex = 15
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
        Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.homeToolStripMenuItem, Me.katalogToolStripMenuItem, Me.loginToolStripMenuItem})
        Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip1.Name = "menuStrip1"
        Me.menuStrip1.Size = New System.Drawing.Size(488, 24)
        Me.menuStrip1.TabIndex = 24
        Me.menuStrip1.Text = "menuStrip1"
        '
        'loginToolStripMenuItem
        '
        Me.loginToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.loginToolStripMenuItem.Name = "loginToolStripMenuItem"
        Me.loginToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.loginToolStripMenuItem.Text = "Logout"
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
        Me.groupBox1.Controls.Add(Me.dateTimePicker1)
        Me.groupBox1.Controls.Add(Me.label9)
        Me.groupBox1.Controls.Add(Me.txtStatus)
        Me.groupBox1.Controls.Add(Me.label7)
        Me.groupBox1.Controls.Add(Me.comboBox1)
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Controls.Add(Me.textBox5)
        Me.groupBox1.Controls.Add(Me.linkLabel1)
        Me.groupBox1.Controls.Add(Me.label6)
        Me.groupBox1.Controls.Add(Me.label3)
        Me.groupBox1.Controls.Add(Me.textBox4)
        Me.groupBox1.Controls.Add(Me.label4)
        Me.groupBox1.Controls.Add(Me.txtPlat)
        Me.groupBox1.Controls.Add(Me.label5)
        Me.groupBox1.Controls.Add(Me.txtMerek)
        Me.groupBox1.Controls.Add(Me.button5)
        Me.groupBox1.Controls.Add(Me.button4)
        Me.groupBox1.Controls.Add(Me.button3)
        Me.groupBox1.Controls.Add(Me.button2)
        Me.groupBox1.Controls.Add(Me.button1)
        Me.groupBox1.Controls.Add(Me.txtKode)
        Me.groupBox1.Location = New System.Drawing.Point(12, 36)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(461, 286)
        Me.groupBox1.TabIndex = 25
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Detail Motor"
        '
        'FormDetailMotor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(488, 342)
        Me.Controls.Add(Me.menuStrip1)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.groupBox1)
        Me.Name = "FormDetailMotor"
        Me.Text = "FormDetailMotor"
        Me.menuStrip1.ResumeLayout(False)
        Me.menuStrip1.PerformLayout()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents dateTimePicker1 As DateTimePicker
    Private WithEvents label9 As Label
    Private WithEvents txtStatus As TextBox
    Private WithEvents label7 As Label
    Private WithEvents comboBox1 As ComboBox
    Private WithEvents label1 As Label
    Private WithEvents textBox5 As TextBox
    Private WithEvents linkLabel1 As LinkLabel
    Private WithEvents label6 As Label
    Private WithEvents label3 As Label
    Private WithEvents textBox4 As TextBox
    Private WithEvents label4 As Label
    Private WithEvents txtPlat As TextBox
    Private WithEvents label5 As Label
    Private WithEvents txtMerek As TextBox
    Private WithEvents button5 As Button
    Private WithEvents button4 As Button
    Private WithEvents button3 As Button
    Private WithEvents button2 As Button
    Private WithEvents button1 As Button
    Private WithEvents txtKode As TextBox
    Private WithEvents katalogToolStripMenuItem As ToolStripMenuItem
    Private WithEvents homeToolStripMenuItem As ToolStripMenuItem
    Private WithEvents menuStrip1 As MenuStrip
    Private WithEvents loginToolStripMenuItem As ToolStripMenuItem
    Private WithEvents label2 As Label
    Private WithEvents groupBox1 As GroupBox
End Class
