Public Class FormEditKaryawan
    Private simpan As New Tabel("Karyawan")
    Private Sub FormEditKaryawan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txtEmail.Text = "" Or txtPass.Text = "" Or txtNama.Text = "" Or txtAlamat.Text = "" Or txtNoTelp.Text = "" Or (radioKaryawan.Checked = False And radioAdmin.Checked = False) Or (radioKaryawan.Checked = True And radioAdmin.Checked = True) Then
            MsgBox("Harap Diisi Semua")
        Else
            simpan.isiDataTable("UPDATE INTO Karyawan SET
                                email='" & txtEmail.Text & "',
                                password'" & txtPass.Text & "',
                                nama'" & txtNama.Text & "',
                                '" & txtNoTelp.Text & "',
                                '" & txtAlamat.Text & "',
                                '" & Role() & "'",
                           "Data Karyawan berhasil ditambah")
            Dim back As New FormListKaryawan()
            back.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click

    End Sub
End Class