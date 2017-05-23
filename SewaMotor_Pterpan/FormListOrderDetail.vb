Public Class FormListOrderDetail
    'Dim order As New Tabel("ViewOrder")
    Dim no_order As Integer
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New(ByVal no_order As Integer)
        Me.no_order = no_order
        ' This call is required by the designer.

        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub


    Private Sub FormListOrderDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim order As New Tabel("ViewOrder", "SELECT * FROM ViewOrder WHERE no_order='" & no_order & "'")
        dgvOrder.DataSource = order.getBS()
        'order.getBS.Filter = "no_order='" & no_order & "'"
    End Sub

    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub dgvOrder_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOrder.CellContentDoubleClick

    End Sub
End Class