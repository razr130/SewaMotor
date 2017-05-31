<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormListOrderDetail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormListOrderDetail))
        Me.groupDaftarPelanggan = New System.Windows.Forms.GroupBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblCari = New System.Windows.Forms.Label()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.btnUbah = New System.Windows.Forms.Button()
        Me.dgvOrder = New System.Windows.Forms.DataGridView()
        Me.SewaMotorDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SewaMotorDataSet = New SewaMotor_Pterpan.SewaMotorDataSet()
        Me.label2 = New System.Windows.Forms.Label()
        Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.groupDaftarPelanggan.SuspendLayout()
        CType(Me.dgvOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SewaMotorDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SewaMotorDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'groupDaftarPelanggan
        '
        Me.groupDaftarPelanggan.Controls.Add(Me.btnClose)
        Me.groupDaftarPelanggan.Controls.Add(Me.lblCari)
        Me.groupDaftarPelanggan.Controls.Add(Me.txtCari)
        Me.groupDaftarPelanggan.Controls.Add(Me.btnUbah)
        Me.groupDaftarPelanggan.Controls.Add(Me.dgvOrder)
        Me.groupDaftarPelanggan.Font = New System.Drawing.Font("Franklin Gothic Demi", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupDaftarPelanggan.Location = New System.Drawing.Point(5, 38)
        Me.groupDaftarPelanggan.Name = "groupDaftarPelanggan"
        Me.groupDaftarPelanggan.Size = New System.Drawing.Size(483, 351)
        Me.groupDaftarPelanggan.TabIndex = 37
        Me.groupDaftarPelanggan.TabStop = False
        Me.groupDaftarPelanggan.Text = "List Order Detail"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnClose.Location = New System.Drawing.Point(390, 322)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 21
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'lblCari
        '
        Me.lblCari.AutoSize = True
        Me.lblCari.Location = New System.Drawing.Point(182, 28)
        Me.lblCari.Name = "lblCari"
        Me.lblCari.Size = New System.Drawing.Size(63, 15)
        Me.lblCari.TabIndex = 19
        Me.lblCari.Text = "Cari Order: "
        '
        'txtCari
        '
        Me.txtCari.Location = New System.Drawing.Point(250, 26)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(215, 20)
        Me.txtCari.TabIndex = 14
        '
        'btnUbah
        '
        Me.btnUbah.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnUbah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUbah.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnUbah.Location = New System.Drawing.Point(13, 322)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(75, 23)
        Me.btnUbah.TabIndex = 18
        Me.btnUbah.Text = "Ubah"
        Me.btnUbah.UseVisualStyleBackColor = False
        '
        'dgvOrder
        '
        Me.dgvOrder.AllowUserToAddRows = False
        Me.dgvOrder.AllowUserToDeleteRows = False
        Me.dgvOrder.AllowUserToOrderColumns = True
        Me.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOrder.Location = New System.Drawing.Point(11, 55)
        Me.dgvOrder.Name = "dgvOrder"
        Me.dgvOrder.ReadOnly = True
        Me.dgvOrder.Size = New System.Drawing.Size(454, 261)
        Me.dgvOrder.TabIndex = 15
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
        Me.label2.Location = New System.Drawing.Point(259, 111)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(0, 13)
        Me.label2.TabIndex = 35
        '
        'menuStrip1
        '
        Me.menuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip1.Name = "menuStrip1"
        Me.menuStrip1.Size = New System.Drawing.Size(505, 24)
        Me.menuStrip1.TabIndex = 38
        Me.menuStrip1.Text = "menuStrip1"
        '
        'FormListOrderDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(505, 395)
        Me.Controls.Add(Me.menuStrip1)
        Me.Controls.Add(Me.groupDaftarPelanggan)
        Me.Controls.Add(Me.label2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormListOrderDetail"
        Me.Text = "FormListOrderDetail"
        Me.groupDaftarPelanggan.ResumeLayout(False)
        Me.groupDaftarPelanggan.PerformLayout()
        CType(Me.dgvOrder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SewaMotorDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SewaMotorDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents groupDaftarPelanggan As GroupBox
    Friend WithEvents btnClose As Button
    Private WithEvents lblCari As Label
    Friend WithEvents txtCari As TextBox
    Private WithEvents btnUbah As Button
    Friend WithEvents dgvOrder As DataGridView
    Friend WithEvents SewaMotorDataSetBindingSource As BindingSource
    Friend WithEvents SewaMotorDataSet As SewaMotorDataSet
    Private WithEvents label2 As Label
    Private WithEvents menuStrip1 As MenuStrip
End Class
