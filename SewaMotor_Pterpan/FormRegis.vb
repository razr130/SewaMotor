Imports System.Data.SqlClient

Public Class FormRegis
    Private regisuser As New Tabel("Pelanggan")
    Private Sub btnDaftar_Click(sender As Object, e As EventArgs) Handles btnDaftar.Click
        regisuser.isiDataTable("INSERT INTO Pelanggan(namaPelanggan,ttl,alamat,notelp,email,password,no_ktp) VALUES ('" & txtNama.Text & "','" & DtTglLahir.Text & "','" & txtAlamat.Text & "','" & txtNoTelp.Text & "','" & txtEmail.Text & "','" & txtPass.Text & "','" & txtNoKTP.Text & "')", "Berhasil regis!")

        txtEmail.Clear()
        txtPass.Clear()
        txtNama.Clear()
        txtNoTelp.Clear()
        txtAlamat.Clear()
        DtTglLahir.Value = Date.Today
        txtNoKTP.Clear()
        Me.Close()
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        txtEmail.Clear()
        txtPass.Clear()
        txtNama.Clear()
        txtNoTelp.Clear()
        txtAlamat.Clear()
        DtTglLahir.Value = Date.Today
        txtNoKTP.Clear()
        Me.Close()

    End Sub
End Class
