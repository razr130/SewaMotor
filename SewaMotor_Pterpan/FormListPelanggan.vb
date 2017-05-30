Public Class FormListPelanggan
    Private pelanggan As New Tabel("Pelanggan")
    Public idPelanggan As Integer


    '/////LOAD/////
    Public Sub New()
        InitializeComponent()
    End Sub
    Private Sub FormDaftarPelanggan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvPelanggan.DataSource = pelanggan.getBS()
        If dgvPelanggan.Columns.Count > 0 Then
            dgvPelanggan.Columns(6).Visible = False
        End If

        dgvPelanggan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        dgvPelanggan.Columns(0).HeaderText = "Id Pelanggan"
        dgvPelanggan.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvPelanggan.Columns(1).HeaderText = "Nama Pelanggan"
        dgvPelanggan.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvPelanggan.Columns(2).HeaderText = "Tanggal Lahir"
        dgvPelanggan.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvPelanggan.Columns(3).HeaderText = "Alamat"
        dgvPelanggan.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvPelanggan.Columns(4).HeaderText = "No.Telp"
        dgvPelanggan.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvPelanggan.Columns(5).HeaderText = "Email"
        dgvPelanggan.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvPelanggan.Columns(6).HeaderText = "No.KTP"
        dgvPelanggan.Columns(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

    End Sub

    '/////BUTTON/////
    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        Edit()
    End Sub
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Delete()
    End Sub

    '/////TextBox/////
    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        Find()
    End Sub

    '/////DGV/////
    Private Sub dgvPelanggan_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPelanggan.CellContentClick
        idPelanggan = dgvPelanggan.Item(0, dgvPelanggan.CurrentRow.Index).Value
    End Sub

    Private Sub dgvPelanggan_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvPelanggan.KeyDown
        If e.KeyCode = Keys.Enter Then
            Edit()
        ElseIf e.KeyCode = Keys.Delete Then
            Delete()
        End If
    End Sub

    '/////FUNCTION/////
    Private Sub Find()
        If txtCari.Text.Length <= 20 Then
            If txtCari.Text = "" Then
                pelanggan.getBS.Filter = ""
                dgvPelanggan.DataSource = pelanggan.getBS()
            Else
                pelanggan.getBS.Filter = "nama Like '" & txtCari.Text & "%'"
            End If
        End If

    End Sub
    Private Sub Edit()
        idPelanggan = dgvPelanggan.Item(0, dgvPelanggan.CurrentRow.Index).Value
        Dim editPelanggan As New FormEditPelanggan(idPelanggan)
        editPelanggan.ShowDialog()
    End Sub
    Private Sub Delete()
        idPelanggan = dgvPelanggan.Item(0, dgvPelanggan.CurrentRow.Index).Value
        Dim namaPelanggan As String = dgvPelanggan.Item(2, dgvPelanggan.CurrentRow.Index).Value
        Dim result As Integer = MessageBox.Show("Apakah anda yakin ingin menghapus pelanggan " & namaPelanggan, "Peringatan", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            Return
        ElseIf result = DialogResult.Yes Then
            pelanggan.isiDataTable("DELETE FROM pelanggan WHERE id=" & idPelanggan, "Pelanggan " & namaPelanggan & " berhasil dihapus!")
        End If
    End Sub

    Private Sub homeToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub katalogToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub dgvPelanggan_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvPelanggan.CellMouseDoubleClick
        idPelanggan = dgvPelanggan.Item(0, dgvPelanggan.CurrentRow.Index).Value
        Me.Close()
    End Sub
End Class