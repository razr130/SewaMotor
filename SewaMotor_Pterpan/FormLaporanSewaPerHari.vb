Public Class FormLaporanSewaPerHari
    Private Sub FormLaporanSewaPerHari_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'InvoiceSewaDataSet.ViewNotaPeminjaman' table. You can move, or remove it, as needed.
        Me.ViewNotaPeminjamanTableAdapter.Fill(Me.InvoiceSewaDataSet.ViewNotaPeminjaman)
        Me.ReportViewer1.RefreshReport()

    End Sub
End Class