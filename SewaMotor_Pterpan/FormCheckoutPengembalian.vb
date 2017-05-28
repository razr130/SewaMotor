﻿Public Class FormCheckoutPengembalian
    Dim no_order As Integer
    Dim paraNoOrder As Microsoft.Reporting.WinForms.ReportParameter
    Dim paraNamaPel As Microsoft.Reporting.WinForms.ReportParameter
    Dim paraNoKTP As Microsoft.Reporting.WinForms.ReportParameter
    Dim paraNamaKar As Microsoft.Reporting.WinForms.ReportParameter
    Dim paraTotalBayar As Microsoft.Reporting.WinForms.ReportParameter
    Dim paraTotalDenda As Microsoft.Reporting.WinForms.ReportParameter
    Dim paraIdMotor As Microsoft.Reporting.WinForms.ReportParameter
    Dim headerParams As Microsoft.Reporting.WinForms.ReportParameter()

    Private Sub FormCheckoutPengembalian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DendaDataSource.ViewDenda' table. You can move, or remove it, as needed.
        Me.ViewDendaTableAdapter.Fill(Me.DendaDataSource.ViewDenda)
        'TODO: This line of code loads data into the 'InvoiceSewaDataSet.ViewNotaPeminjaman' table. You can move, or remove it, as needed.
        Me.ViewNotaPeminjamanTableAdapter.Fill(Me.InvoiceSewaDataSet.ViewNotaPeminjaman)
        For Each para As Microsoft.Reporting.WinForms.ReportParameter In headerParams
            ReportViewer1.LocalReport.SetParameters(para)
        Next

        ReportViewer1.RefreshReport()
    End Sub

    Public Sub New(ByVal no_order As Integer, ByVal nama_pel As String, ByVal noKTP As String, ByVal nama_kar As String, ByVal totalBayar As Integer, ByVal totalDenda As Integer, ByVal idMotor As Integer)

        ' This call is required by the designer.
        InitializeComponent()
        Me.no_order = no_order
        ' Add any initialization after the InitializeComponent() call.
        paraNoOrder = New Microsoft.Reporting.WinForms.ReportParameter("paraNomorOrder", no_order)
        paraNamaPel = New Microsoft.Reporting.WinForms.ReportParameter("paraNamaPelanggan", nama_pel)
        paraNoKTP = New Microsoft.Reporting.WinForms.ReportParameter("paraNomorKTP", noKTP)
        paraNamaKar = New Microsoft.Reporting.WinForms.ReportParameter("paraNamaKaryawan", nama_kar)
        paraTotalBayar = New Microsoft.Reporting.WinForms.ReportParameter("paraTotalBayar", totalBayar)
        paraTotalDenda = New Microsoft.Reporting.WinForms.ReportParameter("paraTotalDenda", totalDenda)
        paraIdMotor = New Microsoft.Reporting.WinForms.ReportParameter("paraIdMotor", idMotor)
        headerParams = {paraNoOrder, paraNamaPel, paraNoKTP, paraNamaKar, paraTotalBayar, paraTotalDenda, paraIdMotor}
    End Sub

    Private Sub homeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles homeToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class