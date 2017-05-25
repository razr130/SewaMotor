Public Class FormLaporanTerlambatKembali
    Private Sub FormLaporanTerlambatKembali_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MotorTerlambatDataSet.ViewTerlambatKembali' table. You can move, or remove it, as needed.
        Me.ViewTerlambatKembaliTableAdapter.Fill(Me.MotorTerlambatDataSet.ViewTerlambatKembali)
        Me.ReportViewer1.Refresh()
    End Sub
End Class