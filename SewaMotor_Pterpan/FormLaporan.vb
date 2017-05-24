Public Class FormLaporan



    Private Sub FormLaporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SewaMotorDataSet.Order' table. You can move, or remove it, as needed.
        Me.OrderTableAdapter.Fill(Me.SewaMotorDataSet.Pesan)

        Me.ReportViewer1.RefreshReport()
    End Sub


End Class