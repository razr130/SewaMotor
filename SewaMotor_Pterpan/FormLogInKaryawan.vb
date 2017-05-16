Public Class FormLogInKaryawan
    Private karyawan As New Tabel("Karyawan")
    Public role As Integer
    Private Sub FormLogInKaryawan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
            MessageBox.Show("Selamat datang di... tunggu, apa nama perusahaan ini ?")

            Me.Visible = False
            role = karyawan.getBS.Current("role")
            Dim nama As New FormUtama(txtUsername.Text, role)
            nama.Show()
            Me.Visible = True
            txtUsername.Text = ""
            txtPassword.Text = ""
            Me.Close()
        Else
            MessageBox.Show("Access Denied")
            txtPassword.Clear()
            txtUsername.Clear()
            Return
        End If




        SendKeys.Send("{ENTER}")

    End Sub
End Class