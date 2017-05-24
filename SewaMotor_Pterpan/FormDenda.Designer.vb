<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDenda
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
        Me.cbDenda = New System.Windows.Forms.ComboBox()
        Me.txtTglPengembalian = New System.Windows.Forms.TextBox()
        Me.txtJumlahDenda = New System.Windows.Forms.TextBox()
        Me.txtTglKembali = New System.Windows.Forms.TextBox()
        Me.txtMerekMotor = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbDenda
        '
        Me.cbDenda.FormattingEnabled = True
        Me.cbDenda.Location = New System.Drawing.Point(64, 28)
        Me.cbDenda.Name = "cbDenda"
        Me.cbDenda.Size = New System.Drawing.Size(121, 21)
        Me.cbDenda.TabIndex = 21
        '
        'txtTglPengembalian
        '
        Me.txtTglPengembalian.Enabled = False
        Me.txtTglPengembalian.Location = New System.Drawing.Point(31, 151)
        Me.txtTglPengembalian.Name = "txtTglPengembalian"
        Me.txtTglPengembalian.Size = New System.Drawing.Size(124, 20)
        Me.txtTglPengembalian.TabIndex = 17
        '
        'txtJumlahDenda
        '
        Me.txtJumlahDenda.Location = New System.Drawing.Point(134, 55)
        Me.txtJumlahDenda.Name = "txtJumlahDenda"
        Me.txtJumlahDenda.Size = New System.Drawing.Size(32, 20)
        Me.txtJumlahDenda.TabIndex = 18
        '
        'txtTglKembali
        '
        Me.txtTglKembali.Enabled = False
        Me.txtTglKembali.Location = New System.Drawing.Point(31, 98)
        Me.txtTglKembali.Name = "txtTglKembali"
        Me.txtTglKembali.Size = New System.Drawing.Size(124, 20)
        Me.txtTglKembali.TabIndex = 19
        '
        'txtMerekMotor
        '
        Me.txtMerekMotor.Enabled = False
        Me.txtMerekMotor.Location = New System.Drawing.Point(31, 42)
        Me.txtMerekMotor.Name = "txtMerekMotor"
        Me.txtMerekMotor.Size = New System.Drawing.Size(100, 20)
        Me.txtMerekMotor.TabIndex = 20
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(28, 135)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Tgl Dikembalikan : "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Tgl Kembali : "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(25, 59)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Jumlah (buah / hari) : "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Denda : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Merek : "
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbDenda)
        Me.GroupBox1.Controls.Add(Me.btnOK)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtJumlahDenda)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Location = New System.Drawing.Point(31, 193)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 165)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Denda"
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(28, 102)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(138, 34)
        Me.btnOK.TabIndex = 10
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'FormDenda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(254, 370)
        Me.Controls.Add(Me.txtTglPengembalian)
        Me.Controls.Add(Me.txtTglKembali)
        Me.Controls.Add(Me.txtMerekMotor)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormDenda"
        Me.Text = "FormDenda"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbDenda As ComboBox
    Friend WithEvents txtTglPengembalian As TextBox
    Friend WithEvents txtJumlahDenda As TextBox
    Friend WithEvents txtTglKembali As TextBox
    Friend WithEvents txtMerekMotor As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnOK As Button
End Class
