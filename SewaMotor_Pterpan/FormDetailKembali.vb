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
        'Me.Height = 691

        Dim denda As New FormDenda(noorder, gdvKembali.Item(5, gdvKembali.CurrentRow.Index).Value, gdvKembali.Item(1, gdvKembali.CurrentRow.Index).Value)
        denda.Show()

        pesan.getBS.Filter = "no_order=" & noorder

        txtHargaSewa.Text = pesan.getBS.Current("total_harga").ToString


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