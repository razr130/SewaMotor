﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormListPelanggan))
        Me.groupDaftarPelanggan = New System.Windows.Forms.GroupBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.label1 = New System.Windows.Forms.Label()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUbah = New System.Windows.Forms.Button()
        Me.dgvPelanggan = New System.Windows.Forms.DataGridView()
        Me.SewaMotorDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SewaMotorDataSet = New SewaMotor_Pterpan.SewaMotorDataSet()
        Me.label2 = New System.Windows.Forms.Label()
        Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.homeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.groupDaftarPelanggan.SuspendLayout()
        CType(Me.dgvPelanggan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SewaMotorDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SewaMotorDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.menuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'groupDaftarPelanggan
        '
        Me.groupDaftarPelanggan.Controls.Add(Me.btnClose)
        Me.groupDaftarPelanggan.Controls.Add(Me.label1)
        Me.groupDaftarPelanggan.Controls.Add(Me.txtCari)
        Me.groupDaftarPelanggan.Controls.Add(Me.btnDelete)
        Me.groupDaftarPelanggan.Controls.Add(Me.btnTambah)
        Me.groupDaftarPelanggan.Controls.Add(Me.btnUbah)
        Me.groupDaftarPelanggan.Controls.Add(Me.dgvPelanggan)
        Me.groupDaftarPelanggan.Font = New System.Drawing.Font("Franklin Gothic Demi", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupDaftarPelanggan.Location = New System.Drawing.Point(12, 37)
        Me.groupDaftarPelanggan.Name = "groupDaftarPelanggan"
        Me.groupDaftarPelanggan.Size = New System.Drawing.Size(684, 351)
        Me.groupDaftarPelanggan.TabIndex = 28
        Me.groupDaftarPelanggan.TabStop = False
        Me.groupDaftarPelanggan.Text = "Daftar Pelanggan"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnClose.Location = New System.Drawing.Point(597, 322)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 30
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Franklin Gothic Demi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(235, 28)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(128, 21)
        Me.label1.TabIndex = 19
        Me.label1.Text = "Cari Pelanggan: "
        '
        'txtCari
        '
        Me.txtCari.Location = New System.Drawing.Point(366, 29)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(306, 21)
        Me.txtCari.TabIndex = 14
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnDelete.Location = New System.Drawing.Point(180, 322)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 17
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnUbah
        '
        Me.btnUbah.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnUbah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUbah.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnUbah.Location = New System.Drawing.Point(99, 322)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(75, 23)
        Me.btnUbah.TabIndex = 18
        Me.btnUbah.Text = "Ubah"
        Me.btnUbah.UseVisualStyleBackColor = False
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
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(266, 100)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(0, 13)
        Me.label2.TabIndex = 26
        '
        'menuStrip1
        '
        Me.menuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.homeToolStripMenuItem})
        Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip1.Name = "menuStrip1"
        Me.menuStrip1.Size = New System.Drawing.Size(707, 24)
        Me.menuStrip1.TabIndex = 29
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
        'btnTambah
        '
        Me.btnTambah.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTambah.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnTambah.Location = New System.Drawing.Point(18, 322)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(75, 23)
        Me.btnTambah.TabIndex = 18
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = False
        '
        'FormListPelanggan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(707, 405)
        Me.Controls.Add(Me.menuStrip1)
        Me.Controls.Add(Me.groupDaftarPelanggan)
        Me.Controls.Add(Me.label2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormListPelanggan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
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
    Private WithEvents label2 As Label
    Friend WithEvents dgvPelanggan As DataGridView
    Private WithEvents btnDelete As Button
    Private WithEvents btnUbah As Button
    Friend WithEvents SewaMotorDataSetBindingSource As BindingSource
    Friend WithEvents SewaMotorDataSet As SewaMotorDataSet
    Friend WithEvents txtCari As TextBox
    Private WithEvents label1 As Label
    Private WithEvents menuStrip1 As MenuStrip
    Private WithEvents homeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnClose As Button
    Private WithEvents btnTambah As Button
End Class
