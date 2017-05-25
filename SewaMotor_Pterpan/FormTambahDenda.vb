Public Class FormTambahDenda
    Private denda As New Tabel("Denda")
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        denda.isiDataTable("INSERT INTO Denda VALUES('" & txtNama.Text & "'," & txtHarga.Text & ")", "")
        FormListDenda.Show()
        Me.Close()
    End Sub
End Class