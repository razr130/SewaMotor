Public Class FormEditOrderDetail
    Dim edit As New Tabel("Oder_Detail")
    Dim viewOrder As New Tabel("ViewOrder")
    Dim nomorDetail As Integer


    Public Sub bind()
        txtNoOrder.Clear()
        txtIDPel.Clear()
        txtKode.Clear()
        txtIdMotor.Clear()
        dtTglSewa.DataBindings.Clear()
        dtTglKembali.DataBindings.Clear()


        txtNoOrder.DataBindings.Add("Text", viewOrder.getBS(), "no_order")
        txtIDPel.DataBindings.Add("Text", viewOrder.getBS(), "nama")
        txtKode.DataBindings.Add("Text", edit.getBS(), "no_detalil")
        txtIdMotor.DataBindings.Add("Text", edit.getBS(), "id_motor")
        dtTglSewa.DataBindings.Add("Text", edit.getBS(), "tgl_sewa")
        dtTglKembali.DataBindings.Add("Text", edit.getBS(), "tgl_kembali")
    End Sub

    Private Sub FormEditOrderDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim brs = edit.getBS().Find("no_detalil", nomorDetail)
        If brs < 0 Then
            Return
        Else
            edit.getBS().Position = brs
            bind()
        End If
    End Sub
    Public Sub New(ByVal noDetail As Integer)

        ' This call is required by the designer.
        InitializeComponent()
        Me.nomorDetail = noDetail
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        edit.isiDataTable("UPDATE Oder_Detail SET
                            id_motor='" & txtIdMotor.Text & "'
                            tgl_sewa='" & dtTglSewa.Value & "'
                            tgl_kembali='" & dtTglKembali.Value & "'
                            WHERE no_detalil='" & nomorDetail & "'", "")
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Me.Close()
    End Sub

End Class