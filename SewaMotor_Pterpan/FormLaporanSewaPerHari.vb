Public Class FormLaporanSewaPerHari
    Dim paraTanggalSewa As New Microsoft.Reporting.WinForms.ReportParameter
    Dim paraTotalHarga As New Microsoft.Reporting.WinForms.ReportParameter
    Dim totalbayar As String

    Public Sub New(ByVal tglSewa As Date)

        ' This call is required by the designer.
        InitializeComponent()
        Dim ambilHarga = New Tabel("ViewNotaPeminjaman", "SELECT SUM(DateDiff(day,tgl_sewa,tgl_kembali)*harga) as total_bayar FROM ViewNotaPeminjaman WHERE tgl_sewa ='" & tglSewa.ToString("yyyy/MM/dd") & "'")
        totalbayar = ambilHarga.getBS.Current("total_bayar")
        paraTanggalSewa = New Microsoft.Reporting.WinForms.ReportParameter("paraTanggalSewa", tglSewa)
        paraTotalHarga = New Microsoft.Reporting.WinForms.ReportParameter("paraSubTotal", Convert.ToInt32(totalbayar))
    End Sub

    Private Sub FormLaporanSewaPerHari_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'InvoiceSewaDataSet.ViewNotaPeminjaman' table. You can move, or remove it, as needed.
        Me.ViewNotaPeminjamanTableAdapter.Fill(Me.InvoiceSewaDataSet.ViewNotaPeminjaman)
        ReportViewer1.LocalReport.SetParameters(paraTanggalSewa)
        ReportViewer1.LocalReport.SetParameters(paraTotalHarga)
        Me.ReportViewer1.RefreshReport()
    End Sub


End Class