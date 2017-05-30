Public Class FormHomepage


    Private Sub ListPelangganToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListPelangganToolStripMenuItem.Click
        FormListPelanggan.Show()
    End Sub

    Private Sub ListKaryawanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListKaryawanToolStripMenuItem.Click
        FormListKaryawan.Show()
    End Sub

    Private Sub ListOrderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListOrderToolStripMenuItem.Click
        FormListOrder.Show()
    End Sub

    Private Sub ListDendaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListDendaToolStripMenuItem.Click
        FormListDenda.Show()
    End Sub

    Private Sub ListMotorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListMotorToolStripMenuItem.Click
        FormUtama.Show()
    End Sub

    Private Sub PengembalianToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PengembalianToolStripMenuItem.Click
        FormKembali.Show()
    End Sub

    Private Sub logOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles logOutToolStripMenuItem.Click
        GlobalVariables.UserName = ""
        FormLogInKaryawan.Show()
        Me.Close()
    End Sub

    Private Sub PerHariToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PerHariToolStripMenuItem.Click
        FormLaporanSewaPerHari.Show()
    End Sub
End Class