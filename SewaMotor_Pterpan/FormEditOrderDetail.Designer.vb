<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEditOrderDetail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormEditOrderDetail))
        Me.dtTglSewa = New System.Windows.Forms.DateTimePicker()
        Me.label9 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.txtIdMotor = New System.Windows.Forms.TextBox()
        Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.label2 = New System.Windows.Forms.Label()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.txtJumlah = New System.Windows.Forms.TextBox()
        Me.cbWaktu = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnPilih = New System.Windows.Forms.Button()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtTglSewa
        '
        Me.dtTglSewa.Location = New System.Drawing.Point(14, 91)
        Me.dtTglSewa.Name = "dtTglSewa"
        Me.dtTglSewa.Size = New System.Drawing.Size(200, 20)
        Me.dtTglSewa.TabIndex = 27
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Location = New System.Drawing.Point(12, 69)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(82, 15)
        Me.label9.TabIndex = 26
        Me.label9.Text = "Tanggal Pinjam"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(11, 40)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(49, 15)
        Me.label3.TabIndex = 11
        Me.label3.Text = "ID Motor"
        '
        'txtIdMotor
        '
        Me.txtIdMotor.Location = New System.Drawing.Point(69, 37)
        Me.txtIdMotor.Name = "txtIdMotor"
        Me.txtIdMotor.Size = New System.Drawing.Size(59, 20)
        Me.txtIdMotor.TabIndex = 16
        '
        'menuStrip1
        '
        Me.menuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip1.Name = "menuStrip1"
        Me.menuStrip1.Size = New System.Drawing.Size(283, 24)
        Me.menuStrip1.TabIndex = 29
        Me.menuStrip1.Text = "menuStrip1"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(266, 166)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(0, 13)
        Me.label2.TabIndex = 27
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSimpan.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSimpan.Location = New System.Drawing.Point(17, 169)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(96, 29)
        Me.btnSimpan.TabIndex = 14
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = False
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.cbWaktu)
        Me.groupBox1.Controls.Add(Me.dtTglSewa)
        Me.groupBox1.Controls.Add(Me.Label1)
        Me.groupBox1.Controls.Add(Me.label9)
        Me.groupBox1.Controls.Add(Me.label3)
        Me.groupBox1.Controls.Add(Me.txtJumlah)
        Me.groupBox1.Controls.Add(Me.txtIdMotor)
        Me.groupBox1.Controls.Add(Me.btnPilih)
        Me.groupBox1.Controls.Add(Me.btnBatal)
        Me.groupBox1.Controls.Add(Me.btnSimpan)
        Me.groupBox1.Font = New System.Drawing.Font("Franklin Gothic Demi", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox1.Location = New System.Drawing.Point(12, 36)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(254, 217)
        Me.groupBox1.TabIndex = 28
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Detail Order"
        '
        'btnBatal
        '
        Me.btnBatal.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBatal.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnBatal.Location = New System.Drawing.Point(119, 169)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(96, 29)
        Me.btnBatal.TabIndex = 14
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = False
        '
        'txtJumlah
        '
        Me.txtJumlah.Location = New System.Drawing.Point(84, 124)
        Me.txtJumlah.Name = "txtJumlah"
        Me.txtJumlah.Size = New System.Drawing.Size(33, 20)
        Me.txtJumlah.TabIndex = 16
        '
        'cbWaktu
        '
        Me.cbWaktu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbWaktu.FormattingEnabled = True
        Me.cbWaktu.Items.AddRange(New Object() {"Hari", "Bulan", "Tahun"})
        Me.cbWaktu.Location = New System.Drawing.Point(122, 123)
        Me.cbWaktu.Name = "cbWaktu"
        Me.cbWaktu.Size = New System.Drawing.Size(93, 23)
        Me.cbWaktu.TabIndex = 28
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 124)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 15)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Lama Pinjam"
        '
        'btnPilih
        '
        Me.btnPilih.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnPilih.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPilih.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnPilih.Location = New System.Drawing.Point(134, 33)
        Me.btnPilih.Name = "btnPilih"
        Me.btnPilih.Size = New System.Drawing.Size(96, 29)
        Me.btnPilih.TabIndex = 14
        Me.btnPilih.Text = "Pilih Motor"
        Me.btnPilih.UseVisualStyleBackColor = False
        '
        'FormEditOrderDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(283, 270)
        Me.Controls.Add(Me.menuStrip1)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.groupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormEditOrderDetail"
        Me.Text = "FormEditOrderDetail"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents dtTglSewa As DateTimePicker
    Private WithEvents label9 As Label
    Private WithEvents label3 As Label
    Private WithEvents txtIdMotor As TextBox
    Private WithEvents menuStrip1 As MenuStrip
    Private WithEvents label2 As Label
    Private WithEvents btnSimpan As Button
    Private WithEvents groupBox1 As GroupBox
    Private WithEvents btnBatal As Button
    Friend WithEvents cbWaktu As ComboBox
    Private WithEvents Label1 As Label
    Private WithEvents txtJumlah As TextBox
    Private WithEvents btnPilih As Button
End Class
