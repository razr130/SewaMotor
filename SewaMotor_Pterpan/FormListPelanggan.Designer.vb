<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormListPelanggan
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
        Me.components = New System.ComponentModel.Container()
        Me.groupDaftarPelanggan = New System.Windows.Forms.GroupBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUbah = New System.Windows.Forms.Button()
        Me.dgvPelanggan = New System.Windows.Forms.DataGridView()
        Me.SewaMotorDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SewaMotorDataSet = New SewaMotor_Pterpan.SewaMotorDataSet()
        Me.loginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.homeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.katalogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.label2 = New System.Windows.Forms.Label()
        Me.groupDaftarPelanggan.SuspendLayout()
        CType(Me.dgvPelanggan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SewaMotorDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SewaMotorDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.menuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'groupDaftarPelanggan
        '
        Me.groupDaftarPelanggan.Controls.Add(Me.label1)
        Me.groupDaftarPelanggan.Controls.Add(Me.txtCari)
        Me.groupDaftarPelanggan.Controls.Add(Me.btnDelete)
        Me.groupDaftarPelanggan.Controls.Add(Me.btnUbah)
        Me.groupDaftarPelanggan.Controls.Add(Me.dgvPelanggan)
        Me.groupDaftarPelanggan.Location = New System.Drawing.Point(12, 27)
        Me.groupDaftarPelanggan.Name = "groupDaftarPelanggan"
        Me.groupDaftarPelanggan.Size = New System.Drawing.Size(684, 351)
        Me.groupDaftarPelanggan.TabIndex = 28
        Me.groupDaftarPelanggan.TabStop = False
        Me.groupDaftarPelanggan.Text = "Daftar Pelanggan"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(275, 32)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(85, 13)
        Me.label1.TabIndex = 19
        Me.label1.Text = "Cari Pelanggan: "
        '
        'txtCari
        '
        Me.txtCari.Location = New System.Drawing.Point(366, 29)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(306, 20)
        Me.txtCari.TabIndex = 14
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(92, 322)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 17
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUbah
        '
        Me.btnUbah.Location = New System.Drawing.Point(11, 322)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(75, 23)
        Me.btnUbah.TabIndex = 18
        Me.btnUbah.Text = "Ubah"
        Me.btnUbah.UseVisualStyleBackColor = True
        '
        'dgvPelanggan
        '
        Me.dgvPelanggan.AllowUserToAddRows = False
        Me.dgvPelanggan.AllowUserToDeleteRows = False
        Me.dgvPelanggan.AllowUserToOrderColumns = True
        Me.dgvPelanggan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPelanggan.Location = New System.Drawing.Point(11, 55)
        Me.dgvPelanggan.Name = "dgvPelanggan"
        Me.dgvPelanggan.ReadOnly = True
        Me.dgvPelanggan.Size = New System.Drawing.Size(661, 261)
        Me.dgvPelanggan.TabIndex = 15
        '
        'SewaMotorDataSetBindingSource
        '
        Me.SewaMotorDataSetBindingSource.DataSource = Me.SewaMotorDataSet
        Me.SewaMotorDataSetBindingSource.Position = 0
        '
        'SewaMotorDataSet
        '
        Me.SewaMotorDataSet.DataSetName = "SewaMotorDataSet"
        Me.SewaMotorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.menuStrip1.Size = New System.Drawing.Size(707, 24)
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
        'FormListPelanggan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(707, 405)
        Me.Controls.Add(Me.groupDaftarPelanggan)
        Me.Controls.Add(Me.menuStrip1)
        Me.Controls.Add(Me.label2)
        Me.Name = "FormListPelanggan"
        Me.Text = "FormDaftarPelanggan"
        Me.groupDaftarPelanggan.ResumeLayout(False)
        Me.groupDaftarPelanggan.PerformLayout()
        CType(Me.dgvPelanggan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SewaMotorDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SewaMotorDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.menuStrip1.ResumeLayout(False)
        Me.menuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents groupDaftarPelanggan As GroupBox
    Private WithEvents loginToolStripMenuItem As ToolStripMenuItem
    Private WithEvents menuStrip1 As MenuStrip
    Private WithEvents homeToolStripMenuItem As ToolStripMenuItem
    Private WithEvents katalogToolStripMenuItem As ToolStripMenuItem
    Private WithEvents label2 As Label
    Friend WithEvents dgvPelanggan As DataGridView
    Private WithEvents btnDelete As Button
    Private WithEvents btnUbah As Button
    Friend WithEvents SewaMotorDataSetBindingSource As BindingSource
    Friend WithEvents SewaMotorDataSet As SewaMotorDataSet
    Friend WithEvents txtCari As TextBox
    Private WithEvents label1 As Label
End Class
