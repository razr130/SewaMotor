Public Class FormTambahMotor
    Private tambah As New Tabel("Motor")


    Private Sub btnBatal2_Click(sender As Object, e As EventArgs) Handles btnBatal2.Click
        Me.Close()

    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        tambah.isiDataTable("INSERT INTO Motor VALUES('" & txtJenis.Text & "','" & txtMerk.Text & "','" & txtNoMesin.Text & "','" & txtNoRangka.Text & "','" & txtStatus.Text & "','" & txtPlat.Text & "','" & txtHarga.Text & "')", "Data motor berhasil ditambah")
        txtJenis.Clear()
        txtNoMesin.Clear()
        txtNoRangka.Clear()
        txtStatus.Clear()
        txtPlat.Clear()


        Me.Close()

    End Sub

    Private Sub FormTambahMotor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class