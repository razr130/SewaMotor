Public Class FormLaporanSewaPerHari
    Dim paraTanggalSewa As New Microsoft.Reporting.WinForms.ReportParameter
    Dim paraTotalHarga As New Microsoft.Reporting.WinForms.ReportParameter

    Public Sub New(ByVal tglSewa As Date)

        ' This call is required by the designer.
        InitializeComponent()


        paraTanggalSewa = New Microsoft.Reporting.WinForms.ReportParameter("paraTanggalSewa", tglSewa)
        paraTotalHarga = New Microsoft.Reporting.WinForms.ReportParameter("paraSubTotal", 11)
    End Sub

    Private Sub FormLaporanSewaPerHari_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'InvoiceSewaDataSet.ViewNotaPeminjaman' table. You can move, or remove it, as needed.
        Me.ViewNotaPeminjamanTableAdapter.Fill(Me.InvoiceSewaDataSet.ViewNotaPeminjaman)
        ReportViewer1.LocalReport.SetParameters(paraTanggalSewa)
        ReportViewer1.LocalReport.SetParameters(paraTotalHarga)
        Me.ReportViewer1.RefreshReport()
    End Sub


End Class