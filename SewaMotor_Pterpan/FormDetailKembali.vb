Imports System.Data
Imports System.Data.SqlClient
Public Class FormDetailKembali
    Private kembali As New Tabel("ViewOrder")
    Private denda As New Tabel("Denda")
    Private pesan As New Tabel("Pesan")
    Private jenis_denda As New Tabel("jenis_denda")
    Private detail As New Tabel("Oder_Detail")
    Private motor As New Tabel("Motor")
    Private tanggal As System.DateTime
    Private titip As String
    Private terlambat As System.TimeSpan
    Private terlambat2 As Integer
    Private date1 As System.DateTime
    Private date2 As System.DateTime
    Public hargatotal As Integer
    Public hargatotal2 As Integer
    Public harga1 As Integer
    Private id As Integer
    Dim dr As SqlDataReader

    Private jumlahbaris As Integer
    Private nodetail As Integer
    Private adadendagak As Integer = 0

    Private _noorder As Integer
    Public Property noorder() As Integer
        Get
            Return _noorder
        End Get
        Set(ByVal value As Integer)
            _noorder = value
        End Set
    End Property
    Private Sub bind()

        txtNoOrder.DataBindings.Clear()
        txtNamaCustomer.DataBindings.Clear()
        txtNamaKaryawan.DataBindings.Clear()



        txtNoOrder.DataBindings.Add("Text", kembali.getBS(), "no_order")
        txtNamaKaryawan.DataBindings.Add("Text", kembali.getBS(), "namaKaryawan")
        txtNamaCustomer.DataBindings.Add("Text", kembali.getBS(), "namaPelanggan")

    End Sub



    Private Sub FormDetailKembali_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MsgBox(GlobalVariables.NoNota.ToString)
        kembali.getBS.Filter = "no_order=" & GlobalVariables.NoNota
        gdvKembali.DataSource = kembali.getBS()
        bind()

        If gdvKembali.Columns.Count > 0 Then

            gdvKembali.Columns(0).Visible = False
            gdvKembali.Columns(6).Visible = False
            gdvKembali.Columns(7).Visible = False
            gdvKembali.Columns(8).Visible = False


        End If
        pesan.getBS.Filter = "no_order=" & GlobalVariables.NoNota
        txtHargaSewa.Text = pesan.getBS.Current("total_harga").ToString

        harga1 = Integer.Parse(txtHargaSewa.Text)
        txtHargaSewa.Text = FormatCurrency(harga1)
        jumlahbaris = gdvKembali.RowCount

        gdvKembali.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        gdvKembali.Columns(1).HeaderText = "No.Detail"
        gdvKembali.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        gdvKembali.Columns(2).HeaderText = "Merek"
        gdvKembali.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        gdvKembali.Columns(3).HeaderText = "Plat"
        gdvKembali.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        gdvKembali.Columns(4).HeaderText = "Tanggal Sewa"
        gdvKembali.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        gdvKembali.Columns(5).HeaderText = "Tanggal Kembali"
        gdvKembali.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        For baris As Integer = 0 To gdvKembali.Rows.Count - 1
            nodetail = gdvKembali.Rows(baris).Cells(1).Value
            Dim ada As Integer
            ada = jenis_denda.getBS.Find("no_detail", nodetail)
            If ada >= 0 Then
                adadendagak += 1
            End If
        Next
        If adadendagak = jumlahbaris Then
            btnSimpan.Enabled = True
        End If
    End Sub

    Private Sub gdvKembali_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles gdvKembali.CellMouseDoubleClick
        'Me.Height = 691

        Dim denda As New FormDenda(gdvKembali.Item(5, gdvKembali.CurrentRow.Index).Value, gdvKembali.Item(1, gdvKembali.CurrentRow.Index).Value, harga1)
        denda.Show()
        Me.Close()



    End Sub



    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click

        If btnSimpan.Enabled = False Then
            MsgBox("Masih ada motor yang belum diberi informasi denda")
        Else
            For baris As Integer = 0 To gdvKembali.Rows.Count - 1
                motor.isiDataTable("UPDATE Motor SET status=" & 0 & " WHERE id_motor=" & gdvKembali.Item(8, gdvKembali.CurrentRow.Index).Value, "")


            Next
            pesan.isiDataTable("UPDATE Pesan SET status='Sudah dikembalikan' WHERE no_order=" & GlobalVariables.NoNota, "")
            MsgBox("Semua motor telah dikembalikan")
            Dim infoPelanggan = New Tabel("ViewNotaPeminjaman", "SELECT  * FROM ViewNotaPeminjaman WHERE no_order='" & GlobalVariables.NoNota & "'")
            Dim namaPel = infoPelanggan.getBS.Current("namaPelanggan")
            Dim noKTP = infoPelanggan.getBS.Current("no_ktp")
            Dim namaKar = infoPelanggan.getBS.Current("namaKaryawan")
            Dim totalBayar As Integer = infoPelanggan.getBS.Current("total_harga")
            Dim totalDenda As Integer = infoPelanggan.getBS.Current("total_denda")
            Dim idMotor As Integer = infoPelanggan.getBS.Current("id_motor")
            Dim notaKembali As New FormCheckoutPengembalian(GlobalVariables.NoNota, namaPel, noKTP, namaKar, totalBayar, totalDenda, idMotor)
            notaKembali.ShowDialog()
            FormUtama.Show()
            Me.Close()
        End If





    End Sub

    Private Sub ListPelangganToolStripMenuItem_Click(sender As Object, e As EventArgs)
        FormListPelanggan.Show()
        Me.Close()
    End Sub

    Private Sub ListKaryawanToolStripMenuItem_Click(sender As Object, e As EventArgs)
        FormListKaryawan.Show()
        Me.Close()
    End Sub

    Private Sub ListOrderToolStripMenuItem_Click(sender As Object, e As EventArgs)
        FormListOrder.Show()
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

    Private Sub btnSelesai_Click(sender As Object, e As EventArgs) Handles btnSelesai.Click
        FormKembali.Show()
        Me.Close()

    End Sub


End Class