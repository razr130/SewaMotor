
Imports System.Data.SqlClient
Public Class FormLogin
    Private user As New Tabel("Pelanggan")

    Private Sub lnkRegis_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkRegis.LinkClicked
        FormRegis.ShowDialog()
    End Sub

    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        user.getBS.Filter = "email='" & txtUsername.Text & "'"
        Dim ada As Integer
        ada = user.getBS.Find("password", txtPassword.Text)
        If ada >= 0 Then
            MessageBox.Show("Selamat datang di... tunggu, apa nama perusahaan ini ?")

            Me.Visible = False
            Dim nama As New FormUtama(txtUsername.Text)
            nama.ShowDialog()
            Me.Visible = True
            txtUsername.Text = ""
            txtPassword.Text = ""
            Me.Close()
        Else
            MessageBox.Show("Access Denied")
        End If
        SendKeys.Send("{ENTER}")
    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class