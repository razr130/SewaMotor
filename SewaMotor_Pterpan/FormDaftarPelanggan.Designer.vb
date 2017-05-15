<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormDaftarPelanggan
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
        Me.groupDaftarPelanggan = New System.Windows.Forms.GroupBox()
        Me.linkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.loginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.homeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.katalogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnTambahPelanggan = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUbah = New System.Windows.Forms.Button()
        Me.groupDaftarPelanggan.SuspendLayout()
        Me.menuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'groupDaftarPelanggan
        '
        Me.groupDaftarPelanggan.Controls.Add(Me.btnDelete)
        Me.groupDaftarPelanggan.Controls.Add(Me.btnUbah)
        Me.groupDaftarPelanggan.Controls.Add(Me.btnTambahPelanggan)
        Me.groupDaftarPelanggan.Controls.Add(Me.DataGridView1)
        Me.groupDaftarPelanggan.Location = New System.Drawing.Point(12, 27)
        Me.groupDaftarPelanggan.Name = "groupDaftarPelanggan"
        Me.groupDaftarPelanggan.Size = New System.Drawing.Size(379, 293)
        Me.groupDaftarPelanggan.TabIndex = 28
        Me.groupDaftarPelanggan.TabStop = False
        Me.groupDaftarPelanggan.Text = "Daftar Pelanggan"
        '
        'linkLabel1
        '
        Me.linkLabel1.AutoSize = True
        Me.linkLabel1.Location = New System.Drawing.Point(60, 336)
        Me.linkLabel1.Name = "linkLabel1"
        Me.linkLabel1.Size = New System.Drawing.Size(58, 13)
        Me.linkLabel1.TabIndex = 10
        Me.linkLabel1.TabStop = True
        Me.linkLabel1.Text = "<< kembali"
        '
        'loginToolStripMenuItem
        '
        Me.loginToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.loginToolStripMenuItem.Name = "loginToolStripMenuItem"
        Me.loginToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.loginToolStripMenuItem.Text = "Logout"
        '
        'menuStrip1
        '
        Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.homeToolStripMenuItem, Me.katalogToolStripMenuItem, Me.loginToolStripMenuItem})
        Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip1.Name = "menuStrip1"
        Me.menuStrip1.Size = New System.Drawing.Size(536, 24)
        Me.menuStrip1.TabIndex = 27
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
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(266, 100)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(0, 13)
        Me.label2.TabIndex = 26
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(11, 19)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(351, 150)
        Me.DataGridView1.TabIndex = 15
        '
        'btnTambahPelanggan
        '
        Me.btnTambahPelanggan.Location = New System.Drawing.Point(11, 175)
        Me.btnTambahPelanggan.Name = "btnTambahPelanggan"
        Me.btnTambahPelanggan.Size = New System.Drawing.Size(75, 23)
        Me.btnTambahPelanggan.TabIndex = 16
        Me.btnTambahPelanggan.Text = "Tambah"
        Me.btnTambahPelanggan.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(173, 175)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 17
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        Me.btnDelete.Visible = False
        '
        'btnUbah
        '
        Me.btnUbah.Location = New System.Drawing.Point(92, 175)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(75, 23)
        Me.btnUbah.TabIndex = 18
        Me.btnUbah.Text = "Ubah"
        Me.btnUbah.UseVisualStyleBackColor = True
        Me.btnUbah.Visible = False
        '
        'FormDaftarPelanggan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(536, 429)
        Me.Controls.Add(Me.groupDaftarPelanggan)
        Me.Controls.Add(Me.linkLabel1)
        Me.Controls.Add(Me.menuStrip1)
        Me.Controls.Add(Me.label2)
        Me.Name = "FormDaftarPelanggan"
        Me.Text = "FormDaftarPelanggan"
        Me.groupDaftarPelanggan.ResumeLayout(False)
        Me.menuStrip1.ResumeLayout(False)
        Me.menuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents groupDaftarPelanggan As GroupBox
    Private WithEvents linkLabel1 As LinkLabel
    Private WithEvents loginToolStripMenuItem As ToolStripMenuItem
    Private WithEvents menuStrip1 As MenuStrip
    Private WithEvents homeToolStripMenuItem As ToolStripMenuItem
    Private WithEvents katalogToolStripMenuItem As ToolStripMenuItem
    Private WithEvents label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnTambahPelanggan As Button
    Private WithEvents btnDelete As Button
    Private WithEvents btnUbah As Button
End Class
