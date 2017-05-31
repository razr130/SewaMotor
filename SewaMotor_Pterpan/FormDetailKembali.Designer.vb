<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormDetailKembali
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDetailKembali))
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
        Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.logOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.gdvKembali, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.menuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gdvKembali
        '
        Me.gdvKembali.AllowUserToAddRows = False
        Me.gdvKembali.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gdvKembali.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.gdvKembali.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gdvKembali.Location = New System.Drawing.Point(14, 128)
        Me.gdvKembali.Name = "gdvKembali"
        Me.gdvKembali.ReadOnly = True
        Me.gdvKembali.Size = New System.Drawing.Size(434, 148)
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
        Me.txtNamaCustomer.Location = New System.Drawing.Point(84, 67)
        Me.txtNamaCustomer.Name = "txtNamaCustomer"
        Me.txtNamaCustomer.Size = New System.Drawing.Size(115, 20)
        Me.txtNamaCustomer.TabIndex = 6
        '
        'txtNamaKaryawan
        '
        Me.txtNamaKaryawan.Enabled = False
        Me.txtNamaKaryawan.Location = New System.Drawing.Point(227, 67)
        Me.txtNamaKaryawan.Name = "txtNamaKaryawan"
        Me.txtNamaKaryawan.Size = New System.Drawing.Size(115, 20)
        Me.txtNamaKaryawan.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Demi", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 15)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "No. Order : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Demi", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(82, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 15)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Nama Pelanggan : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Demi", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(224, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Nama Karyawan : "
        '
        'txtHargaSewa
        '
        Me.txtHargaSewa.Enabled = False
        Me.txtHargaSewa.Location = New System.Drawing.Point(103, 326)
        Me.txtHargaSewa.Name = "txtHargaSewa"
        Me.txtHargaSewa.Size = New System.Drawing.Size(121, 20)
        Me.txtHargaSewa.TabIndex = 8
        Me.txtHargaSewa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Franklin Gothic Demi", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(13, 328)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(86, 15)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Harga Sewa     : "
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnSimpan.Enabled = False
        Me.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSimpan.Font = New System.Drawing.Font("Franklin Gothic Demi", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSimpan.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSimpan.Location = New System.Drawing.Point(117, 362)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(118, 23)
        Me.btnSimpan.TabIndex = 10
        Me.btnSimpan.Text = "Kembalikan Motor"
        Me.btnSimpan.UseVisualStyleBackColor = False
        '
        'btnSelesai
        '
        Me.btnSelesai.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnSelesai.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSelesai.Font = New System.Drawing.Font("Franklin Gothic Demi", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelesai.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSelesai.Location = New System.Drawing.Point(241, 362)
        Me.btnSelesai.Name = "btnSelesai"
        Me.btnSelesai.Size = New System.Drawing.Size(75, 23)
        Me.btnSelesai.TabIndex = 10
        Me.btnSelesai.Text = "Batal"
        Me.btnSelesai.UseVisualStyleBackColor = False
        '
        'menuStrip1
        '
        Me.menuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.logOutToolStripMenuItem})
        Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip1.Name = "menuStrip1"
        Me.menuStrip1.Size = New System.Drawing.Size(456, 24)
        Me.menuStrip1.TabIndex = 11
        Me.menuStrip1.Text = "menuStrip1"
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Franklin Gothic Demi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(169, 21)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Motor yang dipinjam : "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Franklin Gothic Demi", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 283)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(297, 15)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "* Lakukan double click pada motor yang ingin diberi denda"
        '
        'FormDetailKembali
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(456, 402)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.menuStrip1)
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
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormDetailKembali"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormDetailKembali"
        CType(Me.gdvKembali, System.ComponentModel.ISupportInitialize).EndInit()
        Me.menuStrip1.ResumeLayout(False)
        Me.menuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
    Private WithEvents menuStrip1 As MenuStrip
    Private WithEvents logOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
