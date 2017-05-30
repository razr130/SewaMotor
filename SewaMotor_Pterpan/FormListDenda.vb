Public Class FormListDenda
    Public denda As New Tabel("Denda")
    Public id As Integer

    Private Sub FormListDenda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvDenda.DataSource = denda.getBS()

        dgvDenda.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        dgvDenda.Columns(0).HeaderText = "Id Denda"
        dgvDenda.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvDenda.Columns(1).HeaderText = "Nama"
        dgvDenda.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvDenda.Columns(2).HeaderText = "Harga"
        dgvDenda.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvDenda.Columns(2).CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleRight
        'dgvDenda.Columns(3).HeaderText = "Nomor Telepon"
        'dgvDenda.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft
        'dgvDenda.Columns(4).HeaderText = "Email"
        'dgvDenda.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft
        'dgvDenda.Columns(5).HeaderText = "Password"
        'dgvDenda.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft
        'dgvDenda.Columns(6).HeaderText = "Role"
        'dgvDenda.Columns(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

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
        Dim denda2 As New FormListDenda
        denda2.Show()
        Me.Close()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub FormListDenda_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        FormHomepage.Show()

    End Sub
End Class