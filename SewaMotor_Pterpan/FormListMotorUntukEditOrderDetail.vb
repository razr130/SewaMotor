Public Class FormListMotorUntukEditOrderDetail
    Private motor As New Tabel("Motor")
    Public idmotor As Integer

    Private Sub FormListMotorUntukEditOrderDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvMotor.DataSource = motor.getBS()
    End Sub

    Private Sub dgvMotor_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles dgvMotor.MouseDoubleClick
        idmotor = dgvMotor.Item(0, dgvMotor.CurrentRow.Index).Value
        Me.Close()
    End Sub
End Class