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

    Public Sub New(noorder As Integer, tgl As System.DateTime, nodetail As Integer)

        ' This call is required by the designer.
        idsementara = noorder
        date1 = tgl
        iddetail = nodetail
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub FormDenda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox(date1.Date.ToString("yyyy-MM-dd"))
        kembali.getBS.Filter = "no_order=" & idsementara
        binddetail()
    End Sub

    Private Sub cbDenda_SelectionChangeCommitted(sender As Object, e As EventArgs)

        If cbDenda.SelectedItem = "Terlambat" Then

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

    Private Sub btnOK_Click(sender As Object, e As EventArgs)
        Dim ada As Integer
        ada = denda.getBS.Find("nama_denda", cbDenda.SelectedItem)
        MsgBox(ada.ToString)
        MsgBox(cbDenda.SelectedItem)
        If ada >= 0 Then
            denda.getBS.Position = ada
            'denda.getBS.Filter = "nama_denda='" & cbDenda.SelectedItem & "'"
            'harga1 = denda.getBS.Current("Harga")
            id = denda.getBS.Current("id_denda")
            MsgBox(id.ToString)
            'denda.getBS.RemoveFilter()
            'denda.getBS.Position = Nothing
        Else

        End If
        denda.isiDataTable("INSERT INTO jenis_denda(no_detail,id_denda,jumlah) VALUES(" & iddetail & "," & id & "," & txtJumlahDenda.Text & ")", "Informasi denda ditambah")
        'binddetail()
        'hargatotal = harga1 * Integer.Parse(txtJumlahDenda.Text)
        'hargatotal2 = hargatotal + Integer.Parse(txtHargaSewa.Text)
        'txtTotalAll.Text = hargatotal2.ToString

    End Sub
End Class