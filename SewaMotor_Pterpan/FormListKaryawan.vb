﻿Public Class FormListKaryawan
    Private karyawan As New Tabel("Karyawan")
    Private idKaryawan As Integer
    Private role As Integer



    '/////LOAD/////
    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(ByVal roleKaryawan As Integer)

        ' This call is required by the designer.
        InitializeComponent()
        Me.role = roleKaryawan
        ' Add any initialization after the InitializeComponent() call.

    End Sub


    Private Sub FormListKaryawan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvKaryawan.DataSource = karyawan.getBS()
        If dgvKaryawan.Columns.Count > 0 Then
            'jika Super admin yg login maka all visible,
            If karyawan.getBS.Current("role") = 1 Then 'SuperAdm00n
                dgvKaryawan.Columns(4).Visible = False
            ElseIf karyawan.getBS.Current("role") = 2 Then 'Adm00n
                dgvKaryawan.Columns(4).Visible = False
            ElseIf karyawan.getBS.Current("role") = 3 Then 'Karyaw00n
                dgvKaryawan.Columns(4).Visible = False
                dgvKaryawan.Columns(5).Visible = False
            End If
        End If
    End Sub

    '/////BUTTON/////
    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        Edit()
    End Sub
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Delete()
    End Sub
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Add()
    End Sub

    '/////TextBox/////
    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        Find()
    End Sub

    '/////DGV/////
    Private Sub dgvKaryawan_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvKaryawan.CellContentClick
        idKaryawan = dgvKaryawan.Item(0, dgvKaryawan.CurrentRow.Index).Value
    End Sub
    Private Sub dgvKaryawan_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvKaryawan.CellContentDoubleClick
        Edit()
    End Sub
    Private Sub dgvKaryawan_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvKaryawan.KeyDown
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
                karyawan.getBS.Filter = ""
                dgvKaryawan.DataSource = karyawan.getBS()
            Else
                karyawan.getBS.Filter = "nama Like '" & txtCari.Text & "%'"
            End If
        End If

    End Sub
    Private Sub Add()
        Dim addkaryawan As New FormTambahKaryawan()
        addkaryawan.ShowDialog()
        InitializeComponent()
        dgvKaryawan.DataSource = karyawan.getBS()
        Me.Close()
    End Sub
    Private Sub Edit()
        idKaryawan = dgvKaryawan.Item(0, dgvKaryawan.CurrentRow.Index).Value
        'Dim editkaryawan As New FormEditKaryawan(idKaryawan)
        'editkaryawan.ShowDialog()
        dgvKaryawan.DataSource = karyawan.getBS()
    End Sub
    Private Sub Delete()
        idKaryawan = dgvKaryawan.Item(0, dgvKaryawan.CurrentRow.Index).Value
        Dim namakaryawan As String = dgvKaryawan.Item(2, dgvKaryawan.CurrentRow.Index).Value
        Dim result As Integer = MessageBox.Show("Apakah anda yakin ingin menghapus karyawan " & namakaryawan, "Peringatan", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            Return
        ElseIf result = DialogResult.Yes Then
            karyawan.isiDataTable("DELETE FROM karyawan WHERE id=" & idKaryawan, "karyawan " & namakaryawan & " berhasil dihapus!")
        End If
    End Sub


End Class