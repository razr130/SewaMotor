Public Class FormCheckout
    Dim no_order As Integer
    Dim paraNoOrder As Microsoft.Reporting.WinForms.ReportParameter
    Dim paraNamaPel As Microsoft.Reporting.WinForms.ReportParameter
    Dim paraNoKTP As Microsoft.Reporting.WinForms.ReportParameter
    Dim headerParams As Microsoft.Reporting.WinForms.ReportParameter()

    Public Sub New(ByVal no_order As Integer, ByVal nama_pel As String, ByVal noKTP As String)

        ' This call is required by the designer.
        InitializeComponent()
        Me.no_order = no_order
        ' Add any initialization after the InitializeComponent() call.
        paraNoOrder = New Microsoft.Reporting.WinForms.ReportParameter("paraNomorOrder", no_order)
        paraNamaPel = New Microsoft.Reporting.WinForms.ReportParameter("paraNamaPelanggan", nama_pel)
        paraNoKTP = New Microsoft.Reporting.WinForms.ReportParameter("paraNomorKTP", noKTP)
        headerParams = {paraNoOrder, paraNamaPel, paraNoKTP}
    End Sub


    Private Sub FormCheckout_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        'TODO: This line of code loads data into the 'InvoiceSewaDataSource.ViewNotaPeminjaman' table. You can move, or remove it, as needed.
        Me.ViewNotaPeminjamanTableAdapter.Fill(Me.InvoiceSewaDataSet.ViewNotaPeminjaman)
        For Each para As Microsoft.Reporting.WinForms.ReportParameter In headerParams
            ReportViewer1.LocalReport.SetParameters(para)
        Next
        ReportViewer1.RefreshReport()
    End Sub
End Class