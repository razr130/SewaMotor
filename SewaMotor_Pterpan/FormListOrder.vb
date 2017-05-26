﻿Public Class FormListOrder

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
    End Sub

    '/////DGV/////
    Private Sub dgvOrder_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOrder.CellContentClick
        idOrder = dgvOrder.Item(0, dgvOrder.CurrentRow.Index).Value
    End Sub

    '/////BUTTON/////
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Add()
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        idOrder = dgvOrder.Item(0, dgvOrder.CurrentRow.Index).Value
        Detail()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Delete()
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
                order.getBS.Filter = "no_order = '" & txtCari.Text & "%'"
            End If
        End If
    End Sub
    Public Sub Add()

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

    Private Sub dgvOrder_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOrder.CellContentDoubleClick
        Detail()
    End Sub
End Class