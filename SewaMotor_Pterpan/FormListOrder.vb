Public Class FormListOrder

    Dim order As New Tabel("Pesan")
    Dim idOrder As Integer

    '/////LOAD/////
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
    End Sub
    Private Sub FormListOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvOrder.DataSource = order.getBS()

        dgvOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        dgvOrder.Columns(0).HeaderText = "No.Order"
        dgvOrder.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvOrder.Columns(1).HeaderText = "Id Pelanggan"
        dgvOrder.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvOrder.Columns(2).HeaderText = "Id Karyawan"
        dgvOrder.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvOrder.Columns(3).HeaderText = "Tanggal Order"
        dgvOrder.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvOrder.Columns(4).HeaderText = "Total Denda"
        dgvOrder.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvOrder.Columns(5).HeaderText = "Total Harga"
        dgvOrder.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvOrder.Columns(6).HeaderText = "Jaminan"
        dgvOrder.Columns(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        Me.dgvOrder.Columns(4).DefaultCellStyle.Format = "c"
        Me.dgvOrder.Columns(5).DefaultCellStyle.Format = "c"
        'dgvOrder.Columns(4).CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleRight
        'dgvOrder.Columns(5).CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleRight

    End Sub

    '/////DGV/////
    Private Sub dgvOrder_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOrder.CellContentClick
        idOrder = dgvOrder.Item(0, dgvOrder.CurrentRow.Index).Value
    End Sub
    Private Sub dgvOrder_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOrder.CellContentDoubleClick
        Detail()
    End Sub

    '/////BUTTON/////
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnCetakNota.Click
        Print()
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        idOrder = dgvOrder.Item(0, dgvOrder.CurrentRow.Index).Value
        GlobalVariables.NoNota = idOrder
        Detail()
    End Sub



    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        Find()
    End Sub
    '/////FUNCTION/////
    Public Sub Find()
        If txtCari.Text.Length <= 20 Then
            If txtCari.Text = "" Then
                order.getBS.Filter = ""
                dgvOrder.DataSource = order.getBS()
            Else
                order.getBS.Filter = "no_order = " & txtCari.Text
            End If
        End If
    End Sub
    Public Sub Print()
        '//Pick ROW ID
        idOrder = dgvOrder.Item(0, dgvOrder.CurrentRow.Index).Value
        Dim infoPelanggan = New Tabel("ViewNotaPeminjaman", "SELECT  * FROM ViewNotaPeminjaman WHERE no_order='" & idOrder & "'")
        Dim namaPel = infoPelanggan.getBS.Current("namaPelanggan")
        Dim noKTP = infoPelanggan.getBS.Current("no_ktp")
        Dim namaKar = infoPelanggan.getBS.Current("namaKaryawan")
        Dim totalBayar = infoPelanggan.getBS.Current("total_harga")
        Dim totalDenda = infoPelanggan.getBS.Current("total_denda")

        '//LOAD INVOICE

        Dim invoice As New FormCheckout(idOrder, namaPel, noKTP, namaKar, totalBayar, totalDenda)
        'Dim invoice As New FormCheckoutPengembalian(idOrder, namaPel, noKTP)
        invoice.ShowDialog()

    End Sub
    Public Sub Detail()
        '//Pick Row ID

        idOrder = dgvOrder.Item(0, dgvOrder.CurrentRow.Index).Value

        '//LOAD EDITFORM
        Dim detailOrder As New FormListOrderDetail(idOrder)
        detailOrder.ShowDialog()

    End Sub
    Public Sub Delete()
        idOrder = dgvOrder.Item(0, dgvOrder.CurrentRow.Index).Value
        Dim result As Integer = MessageBox.Show("Apakah anda yakin ingin menghapus?", "Peringatan", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            Return
        ElseIf result = DialogResult.Yes Then
            order.isiDataTable("DELETE FROM Pesan WHERE no_order=" & idOrder, "berhasil dihapus!")
        End If
        dgvOrder.Refresh()
    End Sub

    Private Sub homeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles homeToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class