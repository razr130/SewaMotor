Public Class FormLaporanSewaMotor
    Dim jenisLaporan As Integer

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
    End Sub


    Private Sub FormLaporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SewaMotorDataSource.Oder_Detail' table. You can move, or remove it, as needed.
        Me.Oder_DetailTableAdapter.Fill(Me.SewaMotorDataSource.Oder_Detail)

        Me.ReportViewer1.RefreshReport()

    End Sub


End Class