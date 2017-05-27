Imports System.Data
Imports System.Data.SqlClient
Public Class FormDenda
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
    Private idsementara As Integer
    Private id As Integer
    Private iddetail As Integer
    Public hargatotal As Integer
    Public hargatotal2 As Integer
    Public hargatotal3 As Integer
    Public hargatotal4 As Integer
    Public hargadendafinal As Integer
    Public hargatotalfinal As Integer
    Public harga1 As Integer
    Public price As Integer
    Public jumlah As Integer
    Public jumlah2 As Integer
    Dim dr As SqlDataReader



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

    Public Sub New(noorder As Integer, tgl As System.DateTime, nodetail As Integer, harga As Integer)

        ' This call is required by the designer.
        idsementara = noorder
        date1 = tgl
        iddetail = nodetail
        price = harga
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub FormDenda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MsgBox(date1.Date.ToString("yyyy-MM-dd"))
        kembali.getBS.Filter = "no_order=" & GlobalVariables.NoNota
        binddetail()
    End Sub

    Private Sub cbDenda_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbDenda.SelectedIndexChanged
        If cbDenda.SelectedItem = "Terlambat" Then

            date2 = tanggal
            terlambat = date2.Subtract(date1)
            terlambat2 = Math.Floor(terlambat.TotalDays)
            If terlambat2 < 0 Then
                txtJumlahDenda.Text = "0"
            Else
                'MsgBox(terlambat2.ToString)
                txtJumlahDenda.Text = terlambat2
            End If
        ElseIf cbDenda.SelectedItem = "Tidak ada denda" Then
            txtJumlahDenda.Text = "0"
            txtJumlahDenda.Enabled = False
        Else
            txtJumlahDenda.Text = ""
        End If
    End Sub

    Private Sub btnOK_Click_1(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim ada, adadenda As Integer
        Dim kembali As New FormDetailKembali
        ada = denda.getBS.Find("nama_denda", cbDenda.SelectedItem)
        If ada >= 0 Then
            denda.getBS.Position = ada
            denda.getBS.Filter = "nama_denda='" & cbDenda.SelectedItem & "'"
            harga1 = denda.getBS.Current("Harga")
            id = denda.getBS.Current("id_denda")
        Else
        End If
        jenis_denda.getBS.Filter = "id_denda=" & id
        adadenda = jenis_denda.getBS.Find("no_detail", iddetail)
        jumlah = jenis_denda.getBS.Current("jumlah")
        MsgBox(jumlah.ToString)
        If adadenda >= 0 Then
            jumlah2 = jumlah + Integer.Parse(txtJumlahDenda.Text)
            denda.isiDataTable("UPDATE jenis_denda SET jumlah=" & jumlah2 & " WHERE id_denda=" & id & " AND no_detail=" & iddetail, "Informasi denda ditambah")

        Else
            denda.isiDataTable("INSERT INTO jenis_denda(no_detail,id_denda,jumlah) VALUES(" & iddetail & "," & id & "," & txtJumlahDenda.Text & ")", "Informasi denda ditambah")

        End If
        hargatotal = harga1 * Integer.Parse(txtJumlahDenda.Text)
        hargatotal2 = hargatotal + price

        detail.isiDataTable("UPDATE Oder_Detail SET tgl_pengembalian='" & tanggal.Date.ToString("yyyy-MM-dd") & "' WHERE no_detalil=" & iddetail, "")
        pesan.getBS.Filter = "no_order=" & idsementara
        If pesan.getBS.Current("total_denda") = 0 Then

            pesan.isiDataTable("UPDATE Pesan SET total_denda=" & hargatotal & ", total_harga=" & hargatotal2 & " WHERE no_order=" & idsementara, "")
        Else

            hargatotal3 = pesan.getBS.Current("total_denda")
            hargadendafinal = hargatotal3 + hargatotal
            hargatotalfinal = price + hargatotal

            pesan.isiDataTable("UPDATE Pesan SET total_denda=" & hargadendafinal & ", total_harga=" & hargatotalfinal & " WHERE no_order=" & idsementara, "")

        End If

        FormDetailKembali.Show()
        Me.Close()



    End Sub
End Class