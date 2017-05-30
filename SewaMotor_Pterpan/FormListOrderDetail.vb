Public Class FormListOrderDetail
    Dim orderDetail As New Tabel("Oder_Detail")
    Dim no_order As Integer
    Dim no_detail As Integer
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New(ByVal no_order As Integer)
        Me.no_order = no_order
        ' This call is required by the designer.

        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub


    Private Sub FormListOrderDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim order As New Tabel("ViewOrder", "SELECT * FROM ViewOrder WHERE no_order='" & no_order & "'")
        dgvOrder.DataSource = order.getBS()
        'order.getBS.Filter = "no_order='" & no_order & "'"




        dgvOrder.Columns(0).HeaderText = "No.Order"
        dgvOrder.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvOrder.Columns(1).HeaderText = "No.Detail"
        dgvOrder.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvOrder.Columns(2).HeaderText = "Merek"
        dgvOrder.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvOrder.Columns(3).HeaderText = "Nomor Polisi"
        dgvOrder.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvOrder.Columns(4).HeaderText = "Tanggal Sewa"
        dgvOrder.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvOrder.Columns(5).HeaderText = "Tanggal Kembali"
        dgvOrder.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvOrder.Columns(6).HeaderText = "Id Motor"
        dgvOrder.Columns(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvOrder.Columns(7).HeaderText = "Nama Pelanggan"
        dgvOrder.Columns(7).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvOrder.Columns(8).HeaderText = "Nama Karyawan"
        dgvOrder.Columns(8).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        dgvOrder.Columns(1).Visible = False
        dgvOrder.Columns(6).Visible = False
    End Sub

    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        filter()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub dgvOrder_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOrder.CellContentDoubleClick
        edit()
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        edit()
    End Sub

    Public Sub edit()
        no_detail = dgvOrder.Item(0, dgvOrder.CurrentRow.Index).Value
        Dim editForm As New FormEditOrderDetail(no_detail)
        editForm.Show()
        Me.Close()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        no_detail = dgvOrder.Item(0, dgvOrder.CurrentRow.Index).Value
        Dim result As Integer = MessageBox.Show("Apakah anda yakin ingin menghapus?", "Peringatan", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            Return
        ElseIf result = DialogResult.Yes Then
            orderDetail.isiDataTable("DELETE FROM Oder_Detail WHERE no_detalil=" & no_detail, "berhasil dihapus!")
        End If
        dgvOrder.Refresh()
    End Sub

    Public Sub filter()
        If txtCari.Text.Length <= 20 Then
            If txtCari.Text = "" Then
                orderDetail.getBS.Filter = ""
                dgvOrder.DataSource = orderDetail.getBS()
            Else
                orderDetail.getBS.Filter = "no_detalil = '" & txtCari.Text & "%'"
            End If
        End If

    End Sub


End Class