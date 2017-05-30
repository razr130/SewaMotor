Public Class FormLaporanStatusMotor
    Private Sub FormLaporanStatusMotor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SewaMotorDataSource.Motor' table. You can move, or remove it, as needed.
        Me.MotorTableAdapter.Fill(Me.SewaMotorDataSource.Motor)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub logOutToolStripMenuItem_Click(sender As Object, e As EventArgs) 
        FormLogin.Show()
        Me.Close()
    End Sub
End Class