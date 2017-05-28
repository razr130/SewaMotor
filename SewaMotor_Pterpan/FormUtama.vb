Public Class FormUtama
    '/////CONFIG/////
    Public namaAkun As String
    Public motor As New Tabel("Motor")
    Public idmotor As Integer


    Private _username As String
    Public Property username() As String
        Get
            Return _username
        End Get
        Set(ByVal value As String)
            _username = value
        End Set
    End Property
    Private _role As Integer
    Public Property role() As Integer
        Get
            Return _role
        End Get
        Set(ByVal value As Integer)
            _role = value
        End Set
    End Property

    '/////LOAD/////
    Public Sub New()
        InitializeComponent()
        'Me.namaAkun = namaAkun
    End Sub
    Private Sub FormUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblHalo.Text = "Halo, " & GlobalVariables.UserName

        If GlobalVariables.Role > 0 Then
            btnTambah.Visible = True
            btnUbah.Visible = True
            btnDelete.Visible = True

            btnPengembalian.Visible = True
            ReportToolStripMenuItem.Visible = True

        End If
        If GlobalVariables.Role > 0 And GlobalVariables.Role < 3 Then
            btnTambah.Visible = True
            btnUbah.Visible = True
            btnDelete.Visible = True

            btnPengembalian.Visible = True
            ReportToolStripMenuItem.Visible = True
            ToolsToolStripMenuItem.Visible = True
        End If


        dgvMotor.DataSource = motor.getBS()

        If dgvMotor.Columns.Count > 0 Then
            dgvMotor.Columns(0).Visible = False
            dgvMotor.Columns(3).Visible = False
            dgvMotor.Columns(4).Visible = False
        End If
        Me.dgvMotor.Columns(7).DefaultCellStyle.Format = "c"

        dgvMotor.Columns.Add("Status", "Status")

        For baris As Integer = 0 To dgvMotor.Rows.Count - 1
            dgvMotor.Columns(5).DisplayIndex = 8
            dgvMotor.Columns(8).DisplayIndex = 5
            If dgvMotor.Rows(baris).Cells(5).Value = 0 Then
                dgvMotor.Rows(baris).Cells(8).Value = "Tersedia"
            Else
                dgvMotor.Rows(baris).Cells(8).Value = "Tidak tersedia"
            End If
            dgvMotor.Columns(5).Visible = False
        Next

    End Sub

    '/////BUTON/////
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim panggil As New FormTambahMotor()
        panggil.Show()
        Me.Close()
    End Sub
    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        idmotor = dgvMotor.Item(0, dgvMotor.CurrentRow.Index).Value
        Dim edit As New FormEditMotor(idmotor)
        edit.Show()
        Me.Close()
    End Sub
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgvMotor.Item(5, dgvMotor.CurrentRow.Index).Value = 0 Then
            idmotor = dgvMotor.Item(0, dgvMotor.CurrentRow.Index).Value
            motor.isiDataTable("DELETE FROM Motor WHERE id_motor=" & idmotor, "Berhasil Delete")
            Dim utama As New FormUtama
            utama.Show()
            Me.Close()
        Else
            MsgBox("Motor sedang dipinjam")
        End If

    End Sub
    Private Sub btnPengembalian_Click(sender As Object, e As EventArgs) Handles btnPengembalian.Click
        Dim kembali As New FormKembali
        kembali.Show()
        Me.Close()
    End Sub
    Private Sub btnDenda_Click(sender As Object, e As EventArgs)

    End Sub

    '/////TEXTBOX/////
    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        If txtCari.Text.Length <= 20 Then
            If txtCari.Text = "" Then
                motor.getBS.Filter = ""
                dgvMotor.DataSource = motor.getBS()
            Else
                motor.getBS.Filter = "merek LIKE '" & txtCari.Text & "%'"
                'motor.getBS().Position = brs
            End If
        End If
        For baris As Integer = 0 To dgvMotor.Rows.Count - 1
            dgvMotor.Columns(5).DisplayIndex = 8
            dgvMotor.Columns(8).DisplayIndex = 5
            If dgvMotor.Rows(baris).Cells(5).Value = 0 Then
                dgvMotor.Rows(baris).Cells(8).Value = "Tersedia"
            Else
                dgvMotor.Rows(baris).Cells(8).Value = "Tidak tersedia"
            End If
            dgvMotor.Columns(5).Visible = False
        Next
    End Sub

    '/////DGV/////
    Private Sub dgvMotor_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvMotor.CellMouseDoubleClick
        idmotor = dgvMotor.Item(0, dgvMotor.CurrentRow.Index).Value
        Dim edit As New FormDetailMotor(idmotor, username)
        edit.Show()
        Me.Close()
    End Sub

    '/////TOOLTIP/////
    Private Sub ListPelangganToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListPelangganToolStripMenuItem.Click
        Dim list As New FormListPelanggan()
        list.Show()

    End Sub
    Private Sub ListKaryawanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListKaryawanToolStripMenuItem.Click
        Dim list As New FormListKaryawan(role, namaAkun)
        list.Show()
    End Sub
    Private Sub ListOrderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListOrderToolStripMenuItem.Click
        Dim list As New FormListOrder()
        list.Show()
    End Sub
    Private Sub LaporanPenyewaanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanPenyewaanToolStripMenuItem.Click
        Dim laporan As New FormFilterLaporan()
        laporan.Show()

    End Sub
    Private Sub LaporanStatusMotorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanStatusMotorToolStripMenuItem.Click
        Dim laporan As New FormLaporanStatusMotor
        laporan.Show()

    End Sub
    Private Sub LaporanKeterlambatanMotorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanKeterlambatanMotorToolStripMenuItem.Click
        Dim Laporan As New FormLaporanTerlambatKembali
        Laporan.Show()

    End Sub
    Private Sub logOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles logOutToolStripMenuItem.Click
        FormLogin.Show()
        Me.Close()
    End Sub

    Private Sub ListDendaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListDendaToolStripMenuItem.Click
        FormListDenda.Show()
        Me.Close()
    End Sub
End Class