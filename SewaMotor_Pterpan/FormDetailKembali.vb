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
    Private hargatotal As Integer
    Private hargatotal2 As Integer
    Private harga1 As Integer
    Private id As Integer
    Dim dr As SqlDataReader

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

        Dim kon As New SqlConnection(My.Settings.StrConn)
        kon.Open()
        Dim qry As String
        qry = "SELECT nama_denda FROM Denda"
        Dim cmd As New SqlCommand(qry, kon)
        dr = cmd.ExecuteReader
        cbDenda.Items.Clear()
        Do While dr.Read
            cbDenda.Items.Add(dr.Item("nama_denda"))
        Loop


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

        If cbDenda.SelectedItem = "Terlambat" Then
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


    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim ada As Integer
        ada = denda.getBS.Find("nama_denda", cbDenda.SelectedItem)
        MsgBox(ada.ToString)
        MsgBox(cbDenda.SelectedItem)
        If ada >= 0 Then
            denda.getBS.Position = ada
            'denda.getBS.Filter = "nama_denda='" & cbDenda.SelectedItem & "'"
            harga1 = denda.getBS.Current("Harga")
            id = denda.getBS.Current("id_denda")
            MsgBox(id.ToString)
            'denda.getBS.RemoveFilter()
            'denda.getBS.Position = Nothing
        Else

        End If
        denda.isiDataTable("INSERT INTO jenis_denda(no_detail,id_denda,jumlah) VALUES(" & gdvKembali.Item(1, gdvKembali.CurrentRow.Index).Value & "," & id & "," & txtJumlahDenda.Text & ")", "Informasi denda ditambah")
        'binddetail()
        hargatotal = harga1 * Integer.Parse(txtJumlahDenda.Text)
        hargatotal2 = hargatotal + Integer.Parse(txtHargaSewa.Text)
        txtTotalAll.Text = hargatotal2.ToString

    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        pesan.isiDataTable("UPDATE Pesan SET total_denda=" & hargatotal & ", total_harga=" & hargatotal2 & " WHERE no_order=" & noorder, "")
        detail.isiDataTable("UPDATE Oder_Detail SET tgl_pengembalian='" & tanggal.Date.ToString("yyyy-MM-dd") & "' WHERE no_detalil=" & gdvKembali.Item(1, gdvKembali.CurrentRow.Index).Value, "")
        motor.getBS.Filter = "merek='" & gdvKembali.Item(2, gdvKembali.CurrentRow.Index).Value & "'"
        Dim idmotor As Integer
        idmotor = motor.getBS.Current("id_motor")
        motor.isiDataTable("UPDATE Motor SET status=" & 0 & " WHERE id_motor=" & idmotor, "")
    End Sub


End Class