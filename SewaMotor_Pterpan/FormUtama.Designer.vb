<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUtama
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
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUbah = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.dgvMotor = New System.Windows.Forms.DataGridView()
        Me.lblHalo = New System.Windows.Forms.Label()
        Me.btnList = New System.Windows.Forms.Button()
        Me.ListOrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuStrip1.SuspendLayout()
        CType(Me.dgvMotor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'menuStrip1
        '
        Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.homeToolStripMenuItem, Me.katalogToolStripMenuItem, Me.logOutToolStripMenuItem, Me.ToolsToolStripMenuItem})
        Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip1.Name = "menuStrip1"
        Me.menuStrip1.Size = New System.Drawing.Size(575, 24)
        Me.menuStrip1.TabIndex = 3
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
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.ToolsToolStripMenuItem.Text = "Tools"
        '
        'ListPelangganToolStripMenuItem
        '
        Me.ListPelangganToolStripMenuItem.Name = "ListPelangganToolStripMenuItem"
        Me.ListPelangganToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ListPelangganToolStripMenuItem.Text = "List Pelanggan"
        '
        'ListKaryawanToolStripMenuItem
        '
        Me.ListKaryawanToolStripMenuItem.Name = "ListKaryawanToolStripMenuItem"
        Me.ListKaryawanToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ListKaryawanToolStripMenuItem.Text = "List Karyawan"
        '
        'txtCari
        '
        Me.txtCari.Location = New System.Drawing.Point(96, 100)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(462, 20)
        Me.txtCari.TabIndex = 12
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(23, 103)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(67, 13)
        Me.label1.TabIndex = 11
        Me.label1.Text = "Cari Merek : "
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(177, 379)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 8
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        Me.btnDelete.Visible = False
        '
        'btnUbah
        '
        Me.btnUbah.Location = New System.Drawing.Point(96, 379)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(75, 23)
        Me.btnUbah.TabIndex = 9
        Me.btnUbah.Text = "Ubah"
        Me.btnUbah.UseVisualStyleBackColor = True
        Me.btnUbah.Visible = False
        '
        'btnTambah
        '
        Me.btnTambah.Location = New System.Drawing.Point(15, 379)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(75, 23)
        Me.btnTambah.TabIndex = 10
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = True
        Me.btnTambah.Visible = False
        '
        'dgvMotor
        '
        Me.dgvMotor.AllowUserToAddRows = False
        Me.dgvMotor.AllowUserToDeleteRows = False
        Me.dgvMotor.AllowUserToOrderColumns = True
        Me.dgvMotor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMotor.Location = New System.Drawing.Point(15, 137)
        Me.dgvMotor.Name = "dgvMotor"
        Me.dgvMotor.ReadOnly = True
        Me.dgvMotor.Size = New System.Drawing.Size(543, 227)
        Me.dgvMotor.TabIndex = 6
        '
        'lblHalo
        '
        Me.lblHalo.AutoSize = True
        Me.lblHalo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHalo.Location = New System.Drawing.Point(53, 44)
        Me.lblHalo.Name = "lblHalo"
        Me.lblHalo.Size = New System.Drawing.Size(59, 24)
        Me.lblHalo.TabIndex = 13
        Me.lblHalo.Text = "Halo, "
        '
        'btnList
        '
        Me.btnList.Location = New System.Drawing.Point(258, 379)
        Me.btnList.Name = "btnList"
        Me.btnList.Size = New System.Drawing.Size(103, 23)
        Me.btnList.TabIndex = 8
        Me.btnList.Text = "List Pelanggan"
        Me.btnList.UseVisualStyleBackColor = True
        Me.btnList.Visible = False
        '
        'ListOrderToolStripMenuItem
        '
        Me.ListOrderToolStripMenuItem.Name = "ListOrderToolStripMenuItem"
        Me.ListOrderToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ListOrderToolStripMenuItem.Text = "List Order"
        '
        'FormUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(575, 422)
        Me.Controls.Add(Me.lblHalo)
        Me.Controls.Add(Me.txtCari)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.btnList)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUbah)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.dgvMotor)
        Me.Controls.Add(Me.menuStrip1)
        Me.Name = "FormUtama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormUtama"
        Me.menuStrip1.ResumeLayout(False)
        Me.menuStrip1.PerformLayout()
        CType(Me.dgvMotor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents menuStrip1 As MenuStrip
    Private WithEvents homeToolStripMenuItem As ToolStripMenuItem
    Private WithEvents katalogToolStripMenuItem As ToolStripMenuItem
    Private WithEvents logOutToolStripMenuItem As ToolStripMenuItem
    Private WithEvents txtCari As TextBox
    Private WithEvents label1 As Label
    Private WithEvents btnDelete As Button
    Private WithEvents btnUbah As Button
    Private WithEvents btnTambah As Button
    Private WithEvents dgvMotor As DataGridView
    Friend WithEvents lblHalo As Label
    Private WithEvents btnList As Button
    Friend WithEvents ToolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListPelangganToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListKaryawanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListOrderToolStripMenuItem As ToolStripMenuItem
End Class
