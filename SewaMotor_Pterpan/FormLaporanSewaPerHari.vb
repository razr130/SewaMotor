Public Class FormLaporanSewaPerHari
    Dim paraTanggalSewa As New Microsoft.Reporting.WinForms.ReportParameter
    Dim paraTotalHarga As New Microsoft.Reporting.WinForms.ReportParameter
    Dim paraTotalDenda As New Microsoft.Reporting.WinForms.ReportParameter
    Dim totalbayar As Integer

    Public Sub New(ByVal tglSewa As Date)
        'MsgBox(tglSewa)
        Dim titip As String = tglSewa.ToString("yyyy/MM/dd")
        ' This call is required by the designer.
        InitializeComponent()
        Dim ambilHarga = New Tabel("ViewNotaPeminjaman", "SELECT SUM(DateDiff(day,tgl_sewa,tgl_kembali)*harga) as total_bayar 
                                    FROM ViewNotaPeminjaman WHERE tgl_sewa ='" & titip & "'")
        Dim ambilDenda = New Tabel("ViewDenda", "SELECT SUM(harga*jumlah) as total_denda FROM ViewLaporanDenda WHERE tgl_pengembalian = '" & titip & "'")
        totalbayar = ambilHarga.getBS.Current("total_bayar")
        Dim totalDenda As Integer = ambilDenda.getBS.Current("total_denda")
        paraTanggalSewa = New Microsoft.Reporting.WinForms.ReportParameter("paraTanggalSewa", titip)
        paraTotalHarga = New Microsoft.Reporting.WinForms.ReportParameter("paraPendapatanSewa", Convert.ToInt32(totalbayar))
        paraTotalDenda = New Microsoft.Reporting.WinForms.ReportParameter("paraPendapatanDenda", Convert.ToInt32(totalDenda))
    End Sub

    Private Sub FormLaporanSewaPerHari_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ViewLaporanDendaDataSource.ViewLaporanDenda' table. You can move, or remove it, as needed.
        Me.ViewLaporanDendaTableAdapter.Fill(Me.ViewLaporanDendaDataSource.ViewLaporanDenda)
        'TODO: This line of code loads data into the 'InvoiceSewaDataSet.ViewNotaPeminjaman' table. You can move, or remove it, as needed.
        Me.ViewNotaPeminjamanTableAdapter.Fill(Me.InvoiceSewaDataSet.ViewNotaPeminjaman)
        ReportViewer1.LocalReport.SetParameters(paraTanggalSewa)
        ReportViewer1.LocalReport.SetParameters(paraTotalHarga)
        ReportViewer1.LocalReport.SetParameters(paraTotalDenda)
        Me.ReportViewer1.RefreshReport()
    End Sub


End Class