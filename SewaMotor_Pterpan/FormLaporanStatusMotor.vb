Public Class FormLaporanStatusMotor
    Private Sub FormLaporanStatusMotor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MotorTerlambatDataSet.ViewTerlambatKembali' table. You can move, or remove it, as needed.
        Me.ViewTerlambatKembaliTableAdapter.Fill(Me.MotorTerlambatDataSet.ViewTerlambatKembali)
        'TODO: This line of code loads data into the 'DataSetSewaMotor2.Motor' table. You can move, or remove it, as needed.
        Me.MotorTableAdapter.Fill(Me.DataSetSewaMotor2.Motor)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class