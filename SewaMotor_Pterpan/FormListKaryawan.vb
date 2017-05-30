Public Class FormListKaryawan
    Private karyawan As New Tabel("Karyawan")
    Private idKaryawan As Integer

    '/////LOAD/////
    Public Sub New()
        InitializeComponent()
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
        dgvKaryawan.Columns.Add("Role", "Role")
        For baris As Integer = 0 To dgvKaryawan.Rows.Count - 1
            dgvKaryawan.Columns(6).DisplayIndex = 7
            dgvKaryawan.Columns(7).DisplayIndex = 6
            If dgvKaryawan.Rows(baris).Cells(6).Value = 1 Then
                dgvKaryawan.Rows(baris).Cells(7).Value = "Super Admin"
            ElseIf dgvKaryawan.Rows(baris).Cells(6).Value = 2 Then
                dgvKaryawan.Rows(baris).Cells(7).Value = "Admin"
            Else
                dgvKaryawan.Rows(baris).Cells(7).Value = "Karyawan"
            End If
            dgvKaryawan.Columns(6).Visible = False
        Next


        dgvKaryawan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        dgvKaryawan.Columns(0).HeaderText = "ID Karyawan"
        dgvKaryawan.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvKaryawan.Columns(1).HeaderText = "Nama"
        dgvKaryawan.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvKaryawan.Columns(2).HeaderText = "Alamat"
        dgvKaryawan.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvKaryawan.Columns(3).HeaderText = "Nomor Telepon"
        dgvKaryawan.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvKaryawan.Columns(4).HeaderText = "Email"
        dgvKaryawan.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvKaryawan.Columns(5).HeaderText = "Password"
        dgvKaryawan.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvKaryawan.Columns(6).HeaderText = "Role"
        dgvKaryawan.Columns(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub

    '/////BUTTON/////
    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        Edit()
        Me.Close()
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
                karyawan.getBS.Filter = "namaKaryawan Like '" & txtCari.Text & "%'"
            End If
        End If
    End Sub
    Private Sub Add()
        FormTambahKaryawan.Show()
        Me.Close()
    End Sub
    Private Sub Edit()
        idKaryawan = dgvKaryawan.Item(0, dgvKaryawan.CurrentRow.Index).Value
        Dim editkaryawan As New FormEditKaryawan(idKaryawan)
        editkaryawan.Show()
        dgvKaryawan.DataSource = karyawan.getBS()
    End Sub
    Private Sub Delete()
        idKaryawan = dgvKaryawan.Item(0, dgvKaryawan.CurrentRow.Index).Value
        Dim namakaryawan As String = dgvKaryawan.Item(1, dgvKaryawan.CurrentRow.Index).Value
        Dim result As Integer = MessageBox.Show("Apakah anda yakin ingin menghapus karyawan " & namakaryawan & "?", "Peringatan", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then

        ElseIf result = DialogResult.Yes Then
            Try
                karyawan.isiDataTable("DELETE FROM karyawan WHERE id_karyawan=" & idKaryawan, "karyawan " & namakaryawan & " berhasil dihapus!")
                MessageBox.Show("Data karyawan " & namakaryawan & "berhasil dihapus!", "Informasi", MessageBoxButtons.OK)
            Catch ex As Exception
                MessageBox.Show("Karyawan tidak dapat dihapus!")
            End Try
            Me.Close()
            Dim kar As New FormListKaryawan
            kar.Show()
        End If
    End Sub

    Private Sub homeToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub LaporanPenyewaanToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim laporan As New FormFilterLaporan()
        laporan.Show()
    End Sub

    Private Sub LaporanStatusMotorToolStripMenuItem_Click(sender As Object, e As EventArgs)
        FormLaporanStatusMotor.Show()
        Me.Close()
    End Sub

    Private Sub LaporanKeterlambatanMotorToolStripMenuItem_Click(sender As Object, e As EventArgs)
        FormLaporanTerlambatKembali.Show()
        Me.Close()
    End Sub

    Private Sub FormListKaryawan_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        FormHomepage.Show()
    End Sub
End Class