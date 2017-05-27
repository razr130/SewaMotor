Public Class FormKembali

    Private order As New Tabel("Pesan")
    Public nonota As Integer
    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        If isExist() Then

            Dim detail As New FormDetailKembali
            detail.noorder = txtNoNota.Text
            nonota = Integer.Parse(txtNoNota.Text)
            'MsgBox(nonota.ToString)
            GlobalVariables.NoNota = nonota
            detail.Show()
            Me.Close()
        Else
            MsgBox("Order Tidak Ada")
            Return
        End If

    End Sub

    Public Function isExist()
        'MsgBox(order.getBS.Find("no_order", txtNoNota.Text))
        If order.getBS.Find("no_order", txtNoNota.Text) >= 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        FormUtama.Show()
        Me.Close()
    End Sub
End Class