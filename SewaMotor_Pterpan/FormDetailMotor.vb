Public Class FormDetailMotor
    Private idmotor As Integer
    Dim edit As New Tabel("Motor")
    Public Sub New(id As Integer)



        InitializeComponent()
        idmotor = id


    End Sub

    Private Sub bind()

        txtKode.DataBindings.Clear()
        txtMerek.DataBindings.Clear()
        txtStatus.DataBindings.Clear()
        txtPlat.DataBindings.Clear()


        txtKode.DataBindings.Add("Text", edit.getBS(), "jenis")
        txtMerek.DataBindings.Add("Text", edit.getBS(), "harga")
        txtStatus.DataBindings.Add("Text", edit.getBS(), "merek")
        txtPlat.DataBindings.Add("Text", edit.getBS(), "no_mesin")

    End Sub
End Class