Public Class FormKembali

    Private order As New Tabel("Pesan")
    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        If isExist() Then
            Dim detail As New FormDetailKembali
            detail.noorder = txtNoNota.Text
            detail.Show()
            Me.Close()
        Else
            MsgBox("Order Tidak Ada")
            Return
        End If
    End Sub

    Public Function isExist()
        MsgBox(order.getBS.Find("no_order", txtNoNota.Text))
        If order.getBS.Find("no_order", txtNoNota.Text) >= 0 Then
            Return True
        Else
            Return False
        End If
    End Function
End Class