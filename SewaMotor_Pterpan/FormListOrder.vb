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
        Edit()
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

    End Sub
    Public Sub Add()

    End Sub
    Public Sub Edit()
        '//Pick Row ID
        idOrder = dgvOrder.Item(0, dgvOrder.CurrentRow.Index).Value

        '//LOAD EDITFORM
    End Sub
    Public Sub Delete()

    End Sub

    Private Sub dgvOrder_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOrder.CellContentDoubleClick
        Edit()
    End Sub
End Class