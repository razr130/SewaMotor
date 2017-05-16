
Imports System.Data.SqlClient
Public Class FormLogin
    Private user As New Tabel("Pelanggan")

    Private Sub lnkRegis_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkRegis.LinkClicked
        FormRegis.ShowDialog()
    End Sub

    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        If txtUsername.Text = "" And txtPassword.Text = "" Then
            MsgBox("masih kosong")
            Return
            txtUsername.Focus()
        End If

        user.getBS.Filter = "email='" & txtUsername.Text & "'"
        Dim ada As Integer
            ada = user.getBS.Find("password", txtPassword.Text)
            If ada >= 0 Then
                MessageBox.Show("Selamat datang di... tunggu, apa nama perusahaan ini ?")

                Me.Visible = False
                Dim nama As New FormUtama(txtUsername.Text)
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

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUsername.Text = ""
        txtPassword.Text = ""
    End Sub

    Private Sub loginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles loginToolStripMenuItem.Click
        FormLogInKaryawan.Show()
        Me.Close()
    End Sub
End Class