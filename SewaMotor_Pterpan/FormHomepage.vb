Public Class FormHomepage


    Private Sub ListPelangganToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListPelangganToolStripMenuItem.Click
        FormListPelanggan.Show()
        Me.Close()
    End Sub

    Private Sub ListKaryawanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListKaryawanToolStripMenuItem.Click
        FormListKaryawan.Show()
        Me.Close()
    End Sub

    Private Sub ListOrderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListOrderToolStripMenuItem.Click
        FormListOrder.Show()
        Me.Close()
    End Sub

    Private Sub ListDendaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListDendaToolStripMenuItem.Click
        FormListDenda.Show()
        Me.Close()
    End Sub

    Private Sub ListMotorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListMotorToolStripMenuItem.Click
        FormUtama.Show()
        Me.Close()
    End Sub

    Private Sub PengembalianToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PengembalianToolStripMenuItem.Click
        FormKembali.Show()
        Me.Close()
    End Sub
End Class