Public Class FormLogInKaryawan
    Private karyawan As New Tabel("Karyawan")
    Public role As Integer
    Private Sub FormLogInKaryawan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUsername.Focus()
    End Sub

    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        If txtUsername.Text = "" And txtPassword.Text = "" Then
            MsgBox("masih kosong")
            Return
            txtUsername.Focus()
        End If

        karyawan.getBS.Filter = "email='" & txtUsername.Text & "'"
        Dim ada As Integer
        ada = karyawan.getBS.Find("password", txtPassword.Text)
        If ada >= 0 Then
            MessageBox.Show("Selamat datang :D")

            Me.Visible = False
            role = karyawan.getBS.Current("role")
            Dim nama As New FormUtama()
            nama.username = txtUsername.Text
            GlobalVariables.UserName = txtUsername.Text
            nama.role = role
            GlobalVariables.Role = role
            FormHomepage.Show()
            Me.Visible = True
            txtUsername.Text = ""
            txtPassword.Text = ""
            Me.Close()
        Else
            MessageBox.Show("Access Denied")
            txtPassword.Clear()
            txtUsername.Clear()
            txtUsername.Focus()
            Return
        End If



        GlobalVariables.isMember = "NO"
        SendKeys.Send("{ENTER}")

    End Sub

    Private Sub ListKaryawanToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub loginToolStripMenuItem_Click(sender As Object, e As EventArgs)
        FormLogin.Show()
        Me.Close()
    End Sub
End Class