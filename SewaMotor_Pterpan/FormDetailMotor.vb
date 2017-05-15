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


        txtKode.DataBindings.Add("Text", edit.getBS(), "id_motor")
        txtMerek.DataBindings.Add("Text", edit.getBS(), "merek")
        txtStatus.DataBindings.Add("Text", edit.getBS(), "status")
        txtPlat.DataBindings.Add("Text", edit.getBS(), "plat")

    End Sub

    Private Sub FormDetailMotor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim brs = edit.getBS().Find("id_motor", idmotor)
        If brs < 0 Then
            txtKode.Text = ""
            txtMerek.Text = ""
            txtPlat.Text = ""
            txtStatus.Text = ""

        Else
            edit.getBS().Position = brs
            bind()

        End If
        If txtStatus.Text = "0" Then
            txtStatus.Text = "Tersedia"
        Else
            txtStatus.Text = "Tidak tersedia"
        End If
    End Sub
End Class