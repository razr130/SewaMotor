<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.homeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.katalogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.logOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListPelangganToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListKaryawanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListOrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.gdvKembali = New System.Windows.Forms.DataGridView()
        Me.txtNoOrder = New System.Windows.Forms.TextBox()
        Me.txtNamaCustomer = New System.Windows.Forms.TextBox()
        Me.txtNamaKaryawan = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMerekMotor = New System.Windows.Forms.TextBox()
        Me.txtTglKembali = New System.Windows.Forms.TextBox()
        Me.txtTglPengembalian = New System.Windows.Forms.TextBox()
        Me.cbDenda = New System.Windows.Forms.ComboBox()
        Me.txtJumlahDenda = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtTotalAll = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtHargaSewa = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnSelesai = New System.Windows.Forms.Button()
        Me.menuStrip1.SuspendLayout()
        CType(Me.gdvKembali, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'menuStrip1
        '
        Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.homeToolStripMenuItem, Me.katalogToolStripMenuItem, Me.logOutToolStripMenuItem, Me.ToolsToolStripMenuItem})
        Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip1.Name = "menuStrip1"
        Me.menuStrip1.Size = New System.Drawing.Size(456, 24)
        Me.menuStrip1.TabIndex = 4
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
        'logOutToolStripMenuItem
        '
        Me.logOutToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem"
        Me.logOutToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.logOutToolStripMenuItem.Text = "Logout"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListPelangganToolStripMenuItem, Me.ListKaryawanToolStripMenuItem, Me.ListOrderToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.ToolsToolStripMenuItem.Text = "Tools"
        '
        'ListPelangganToolStripMenuItem
        '
        Me.ListPelangganToolStripMenuItem.Name = "ListPelangganToolStripMenuItem"
        Me.ListPelangganToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.ListPelangganToolStripMenuItem.Text = "List Pelanggan"
        '
        'ListKaryawanToolStripMenuItem
        '
        Me.ListKaryawanToolStripMenuItem.Name = "ListKaryawanToolStripMenuItem"
        Me.ListKaryawanToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.ListKaryawanToolStripMenuItem.Text = "List Karyawan"
        '
        'ListOrderToolStripMenuItem
        '
        Me.ListOrderToolStripMenuItem.Name = "ListOrderToolStripMenuItem"
        Me.ListOrderToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.ListOrderToolStripMenuItem.Text = "List Order"
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
        Me.Label1.Location = New System.Drawing.Point(11, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "No. Order : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Nama Pelanggan : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(154, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Nama Karyawan : "
        '
        'txtMerekMotor
        '
        Me.txtMerekMotor.Enabled = False
        Me.txtMerekMotor.Location = New System.Drawing.Point(12, 362)
        Me.txtMerekMotor.Name = "txtMerekMotor"
        Me.txtMerekMotor.Size = New System.Drawing.Size(100, 20)
        Me.txtMerekMotor.TabIndex = 8
        '
        'txtTglKembali
        '
        Me.txtTglKembali.Enabled = False
        Me.txtTglKembali.Location = New System.Drawing.Point(148, 362)
        Me.txtTglKembali.Name = "txtTglKembali"
        Me.txtTglKembali.Size = New System.Drawing.Size(124, 20)
        Me.txtTglKembali.TabIndex = 8
        '
        'txtTglPengembalian
        '
        Me.txtTglPengembalian.Enabled = False
        Me.txtTglPengembalian.Location = New System.Drawing.Point(306, 362)
        Me.txtTglPengembalian.Name = "txtTglPengembalian"
        Me.txtTglPengembalian.Size = New System.Drawing.Size(124, 20)
        Me.txtTglPengembalian.TabIndex = 8
        '
        'cbDenda
        '
        Me.cbDenda.FormattingEnabled = True
        Me.cbDenda.Location = New System.Drawing.Point(66, 430)
        Me.cbDenda.Name = "cbDenda"
        Me.cbDenda.Size = New System.Drawing.Size(121, 21)
        Me.cbDenda.TabIndex = 9
        '
        'txtJumlahDenda
        '
        Me.txtJumlahDenda.Location = New System.Drawing.Point(303, 430)
        Me.txtJumlahDenda.Name = "txtJumlahDenda"
        Me.txtJumlahDenda.Size = New System.Drawing.Size(32, 20)
        Me.txtJumlahDenda.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 346)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Merek : "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(145, 346)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Tgl Kembali : "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(303, 346)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Tgl Dikembalikan : "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(21, 434)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Denda : "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(194, 434)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Jumlah (buah / hari) : "
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(134, 79)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 10
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnOK)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 397)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(349, 128)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Denda"
        '
        'txtTotalAll
        '
        Me.txtTotalAll.Enabled = False
        Me.txtTotalAll.Location = New System.Drawing.Point(143, 577)
        Me.txtTotalAll.Name = "txtTotalAll"
        Me.txtTotalAll.Size = New System.Drawing.Size(121, 20)
        Me.txtTotalAll.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 580)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(128, 13)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Total Harga Seluruhnya : "
        '
        'txtHargaSewa
        '
        Me.txtHargaSewa.Enabled = False
        Me.txtHargaSewa.Location = New System.Drawing.Point(143, 543)
        Me.txtHargaSewa.Name = "txtHargaSewa"
        Me.txtHargaSewa.Size = New System.Drawing.Size(121, 20)
        Me.txtHargaSewa.TabIndex = 8
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(10, 546)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(131, 13)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Harga Sewa Seluruhnya : "
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(157, 617)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(75, 23)
        Me.btnSimpan.TabIndex = 10
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'btnSelesai
        '
        Me.btnSelesai.Location = New System.Drawing.Point(238, 617)
        Me.btnSelesai.Name = "btnSelesai"
        Me.btnSelesai.Size = New System.Drawing.Size(75, 23)
        Me.btnSelesai.TabIndex = 10
        Me.btnSelesai.Text = "Selesai"
        Me.btnSelesai.UseVisualStyleBackColor = True
        '
        'FormDetailKembali
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(456, 341)
        Me.Controls.Add(Me.btnSelesai)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.cbDenda)
        Me.Controls.Add(Me.txtTglPengembalian)
        Me.Controls.Add(Me.txtJumlahDenda)
        Me.Controls.Add(Me.txtTglKembali)
        Me.Controls.Add(Me.txtHargaSewa)
        Me.Controls.Add(Me.txtTotalAll)
        Me.Controls.Add(Me.txtMerekMotor)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNamaKaryawan)
        Me.Controls.Add(Me.txtNamaCustomer)
        Me.Controls.Add(Me.txtNoOrder)
        Me.Controls.Add(Me.gdvKembali)
        Me.Controls.Add(Me.menuStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormDetailKembali"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FormDetailKembali"
        Me.menuStrip1.ResumeLayout(False)
        Me.menuStrip1.PerformLayout()
        CType(Me.gdvKembali, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents menuStrip1 As MenuStrip
    Private WithEvents homeToolStripMenuItem As ToolStripMenuItem
    Private WithEvents katalogToolStripMenuItem As ToolStripMenuItem
    Private WithEvents logOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListPelangganToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListKaryawanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListOrderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents gdvKembali As DataGridView
    Friend WithEvents txtNoOrder As TextBox
    Friend WithEvents txtNamaCustomer As TextBox
    Friend WithEvents txtNamaKaryawan As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtMerekMotor As TextBox
    Friend WithEvents txtTglKembali As TextBox
    Friend WithEvents txtTglPengembalian As TextBox
    Friend WithEvents cbDenda As ComboBox
    Friend WithEvents txtJumlahDenda As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnOK As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtTotalAll As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtHargaSewa As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnSelesai As Button
End Class
