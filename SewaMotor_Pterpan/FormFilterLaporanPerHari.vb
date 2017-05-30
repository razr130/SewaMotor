Public Class FormFilterLaporanPerHari
    Dim tgl_sewa As Date
    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        MsgBox(tgl_sewa)
        Dim laporan As New FormLaporanSewaPerHari(tgl_sewa)
        Me.Close()
        laporan.Show()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles dtFilterTglSewa.ValueChanged
        tgl_sewa = dtFilterTglSewa.Value.ToShortDateString

    End Sub
End Class