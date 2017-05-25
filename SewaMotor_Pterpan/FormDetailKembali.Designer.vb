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
        Me.txtHargaSewa = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnSelesai = New System.Windows.Forms.Button()
        Me.menuStrip1.SuspendLayout()
        CType(Me.gdvKembali, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label10.Location = New System.Drawing.Point(18, 354)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(131, 13)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Harga Sewa Seluruhnya : "
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(127, 392)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(75, 23)
        Me.btnSimpan.TabIndex = 10
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'btnSelesai
        '
        Me.btnSelesai.Location = New System.Drawing.Point(208, 392)
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
        Me.ClientSize = New System.Drawing.Size(456, 428)
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
        Me.Controls.Add(Me.menuStrip1)
        Me.Name = "FormDetailKembali"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FormDetailKembali"
        Me.menuStrip1.ResumeLayout(False)
        Me.menuStrip1.PerformLayout()
        CType(Me.gdvKembali, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents txtHargaSewa As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnSelesai As Button
End Class
