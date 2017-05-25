Public Class FormFilterLaporan
    Dim month As Integer
    Dim year As Integer
    Dim tipeLaporan As String

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
    End Sub
    Public Sub New(ByVal tipeLaporan As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub FormFilterLaporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For itemYear = Today.Year To 2000 Step -1
            cbYear.Items.Add(itemYear.ToString)
        Next

        cbYear.SelectedValue = Today.Year.ToString
        cbYear.SelectedText = Today.Year.ToString
        cbYear.SelectedItem = Today.Year.ToString

        cbMonth.SelectedIndex = Today.Month - 1

    End Sub

    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        year = Convert.ToInt32(cbYear.SelectedItem)
        month = cbYear.SelectedIndex + 1
        Dim laporan As New FormLaporanSewaMotor(month, year)
        laporan.Show()
        Me.Close()
    End Sub


End Class