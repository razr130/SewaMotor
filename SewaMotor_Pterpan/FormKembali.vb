Public Class FormKembali
    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Dim detail As New FormDetailKembali
        detail.noorder = txtNoNota.Text
        detail.Show()
        Me.Close()

    End Sub

    Private Sub FormKembali_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class