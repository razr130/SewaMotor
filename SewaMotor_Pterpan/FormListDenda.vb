Public Class FormListDenda
    Public denda As New Tabel("Denda")
    Public id As Integer

    Private Sub FormListDenda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvDenda.DataSource = denda.getBS()
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        FormTambahDenda.Show()
        Me.Close()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        id = dgvDenda.Item(0, dgvDenda.CurrentRow.Index).Value
        Dim edit As New FormEditDenda(id)
        edit.Show()
        Me.Close()

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        id = dgvDenda.Item(0, dgvDenda.CurrentRow.Index).Value
        denda.isiDataTable("DELETE FROM Denda WHERE id_denda=" & id, "Berhasil Delete")
    End Sub
End Class