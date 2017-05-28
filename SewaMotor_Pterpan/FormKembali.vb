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

    Private Sub txtNoNota_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNoNota.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class