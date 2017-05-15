<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogin
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
        Me.loginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.label1 = New System.Windows.Forms.Label()
        Me.lnkRegis = New System.Windows.Forms.LinkLabel()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.btnLogIn = New System.Windows.Forms.Button()
        Me.menuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'menuStrip1
        '
        Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.homeToolStripMenuItem, Me.katalogToolStripMenuItem, Me.loginToolStripMenuItem})
        Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip1.Name = "menuStrip1"
        Me.menuStrip1.Size = New System.Drawing.Size(467, 24)
        Me.menuStrip1.TabIndex = 9
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
        'loginToolStripMenuItem
        '
        Me.loginToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.loginToolStripMenuItem.Name = "loginToolStripMenuItem"
        Me.loginToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.loginToolStripMenuItem.Text = "Login"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(194, 137)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(101, 13)
        Me.label1.TabIndex = 16
        Me.label1.Text = "Belum punya akun?"
        '
        'lnkRegis
        '
        Me.lnkRegis.AutoSize = True
        Me.lnkRegis.Location = New System.Drawing.Point(292, 137)
        Me.lnkRegis.Name = "lnkRegis"
        Me.lnkRegis.Size = New System.Drawing.Size(88, 13)
        Me.lnkRegis.TabIndex = 13
        Me.lnkRegis.TabStop = True
        Me.lnkRegis.Text = "Daftar Sekarang!"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(66, 105)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(53, 13)
        Me.lblPassword.TabIndex = 15
        Me.lblPassword.Text = "Password"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(66, 79)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(35, 13)
        Me.lblUsername.TabIndex = 14
        Me.lblUsername.Text = "E-mail"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(129, 102)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtPassword.Size = New System.Drawing.Size(143, 20)
        Me.txtPassword.TabIndex = 11
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(129, 76)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(143, 20)
        Me.txtUsername.TabIndex = 10
        '
        'btnLogIn
        '
        Me.btnLogIn.Location = New System.Drawing.Point(278, 76)
        Me.btnLogIn.Name = "btnLogIn"
        Me.btnLogIn.Size = New System.Drawing.Size(101, 46)
        Me.btnLogIn.TabIndex = 12
        Me.btnLogIn.Text = "Login"
        Me.btnLogIn.UseVisualStyleBackColor = True
        '
        'FormLogin
        '
        Me.AcceptButton = Me.btnLogIn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(467, 201)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.lnkRegis)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.btnLogIn)
        Me.Controls.Add(Me.menuStrip1)
        Me.Name = "FormLogin"
        Me.Text = "FormLogin"
        Me.menuStrip1.ResumeLayout(False)
        Me.menuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents menuStrip1 As MenuStrip
    Private WithEvents homeToolStripMenuItem As ToolStripMenuItem
    Private WithEvents katalogToolStripMenuItem As ToolStripMenuItem
    Private WithEvents loginToolStripMenuItem As ToolStripMenuItem
    Private WithEvents label1 As Label
    Private WithEvents lnkRegis As LinkLabel
    Private WithEvents lblPassword As Label
    Private WithEvents lblUsername As Label
    Private WithEvents txtPassword As TextBox
    Private WithEvents txtUsername As TextBox
    Private WithEvents btnLogIn As Button
End Class
