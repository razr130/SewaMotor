Public Class FormDetailKembali
    Private kembali As New Tabel("ViewOrder")
    Private denda As New Tabel("Denda")
    Private pesan As New Tabel("Pesan")
    Private jenis_denda As New Tabel("jenis_denda")
    Private detail As New Tabel("Oder_Detail")
    Private tanggal As System.DateTime
    Private titip As String
    Private terlambat As System.TimeSpan
    Private terlambat2 As Integer
    Private date1 As System.DateTime
    Private date2 As System.DateTime
    Private hargatotal As Integer
    Private harga1 As Integer
    Private id As Integer

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
        txtNamaKaryawan.DataBindings.Add("Text", kembali.getBS(), "nama_kar")
        txtNamaCustomer.DataBindings.Add("Text", kembali.getBS(), "nama")

    End Sub

    Private Sub binddetail()




        tanggal = DateTime.Now
        txtMerekMotor.DataBindings.Clear()
        txtTglKembali.DataBindings.Clear()
        txtTglPengembalian.DataBindings.Clear()

        txtMerekMotor.DataBindings.Add("Text", kembali.getBS(), "merek")
        txtTglKembali.DataBindings.Add("Text", kembali.getBS(), "tgl_kembali")

        titip = txtTglKembali.Text
        txtTglKembali.Text = titip.Substring(0, 10)
        txtTglPengembalian.Text = tanggal.Date.ToString("dd/MM/yyyy")
        cbDenda.DataSource = denda.getDT
        cbDenda.DisplayMember = "nama_denda"
        cbDenda.ValueMember = "id_denda"


    End Sub

    Private Sub FormDetailKembali_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        kembali.getBS.Filter = "no_order=" & noorder
        gdvKembali.DataSource = kembali.getBS()
        bind()

        If gdvKembali.Columns.Count > 0 Then

            gdvKembali.Columns(0).Visible = False
            gdvKembali.Columns(6).Visible = False
            gdvKembali.Columns(7).Visible = False


        End If

    End Sub

    Private Sub gdvKembali_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles gdvKembali.CellMouseDoubleClick
        Me.Height = 691

        binddetail()

        pesan.getBS.Filter = "no_order=" & noorder

        txtHargaSewa.Text = pesan.getBS.Current("total_harga").ToString


    End Sub

    Private Sub cbDenda_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbDenda.SelectionChangeCommitted
        If CType(cbDenda.SelectedItem, DataRowView).Item("nama_denda") = "Terlambat" Then
            date1 = gdvKembali.Item(5, gdvKembali.CurrentRow.Index).Value
            date2 = tanggal
            terlambat = date2.Subtract(date1)
            terlambat2 = Math.Floor(terlambat.TotalDays)
            If terlambat2 < 0 Then
                txtJumlahDenda.Text = "0"
            Else
                txtJumlahDenda.Text = terlambat2
            End If

        Else
            txtJumlahDenda.Text = ""
        End If

        'denda.getBS.Filter = String.Empty
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        denda.getBS.Filter = "nama_denda='" & DirectCast(cbDenda.SelectedItem, DataRowView).Item("nama_denda") & "'"
        harga1 = denda.getBS.Current("Harga")
        denda.isiDataTable("INSERT INTO jenis_denda(no_detail,id_denda,jumlah) VALUES(" & gdvKembali.Item(1, gdvKembali.CurrentRow.Index).Value & ",(SELECT id_denda FROM Denda WHERE nama_denda = '" & DirectCast(cbDenda.SelectedItem, DataRowView).Item("nama_denda") & "')," & txtJumlahDenda.Text & ")", "Informasi denda ditambah")
        'binddetail()
        hargatotal = harga1 * Integer.Parse(txtJumlahDenda.Text)
        hargatotal = hargatotal + Integer.Parse(txtHargaSewa.Text)
        txtTotalAll.Text = hargatotal.ToString

    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click

    End Sub


End Class