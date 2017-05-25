Imports System.Drawing
Imports System.Drawing.Printing

Public Class FormLaporanSewaMotor
    Dim jenisLaporan As Integer
    Dim paraMonth As Microsoft.Reporting.WinForms.ReportParameter
    Dim paraYear As Microsoft.Reporting.WinForms.ReportParameter
    Dim HeaderParams As Microsoft.Reporting.WinForms.ReportParameter()

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Public Sub New(ByVal month As Integer, ByVal year As Integer)

        ' This call is required by the designer.
        InitializeComponent()
        paraMonth = New Microsoft.Reporting.WinForms.ReportParameter("FilterMonth", month)
        paraYear = New Microsoft.Reporting.WinForms.ReportParameter("FilterYear", year)
        HeaderParams = {paraMonth, paraYear}
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub FormLaporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SewaMotorDataSource.Oder_Detail' table. You can move, or remove it, as needed.
        Me.Oder_DetailTableAdapter.Fill(Me.SewaMotorDataSource.Oder_Detail)
        For Each para As Microsoft.Reporting.WinForms.ReportParameter In HeaderParams
            ReportViewer1.LocalReport.SetParameters(para)
        Next
        Me.ReportViewer1.RefreshReport()


    End Sub

End Class