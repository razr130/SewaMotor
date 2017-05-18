Public Class FormListOrder

    Dim order As New Tabel("Pesan")

    '/////LOAD/////
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
    End Sub
    Private Sub FormListOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    '/////DGV/////
    Private Sub dgvKaryawan_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOrder.CellContentClick

    End Sub

    '/////BUTTON/////
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click

    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

    End Sub

    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged

    End Sub


End Class