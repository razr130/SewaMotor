Public Class FormEditMotor
    Private idmotor As Integer
    Dim edit As New Tabel("Motor")
    Public Sub New(id As Integer)



        InitializeComponent()
        idmotor = id


    End Sub
    Private Sub bind()

        txtJenis.DataBindings.Clear()
        txtHarga.DataBindings.Clear()
        txtMerk.DataBindings.Clear()
        txtNoMesin.DataBindings.Clear()
        txtNoRangka.DataBindings.Clear()
        txtPlat.DataBindings.Clear()
        txtStatus.DataBindings.Clear()

        txtJenis.DataBindings.Add("Text", edit.getBS(), "jenis")
        txtHarga.DataBindings.Add("Text", edit.getBS(), "harga")
        txtMerk.DataBindings.Add("Text", edit.getBS(), "merek")
        txtNoMesin.DataBindings.Add("Text", edit.getBS(), "no_mesin")
        txtNoRangka.DataBindings.Add("Text", edit.getBS(), "no_rangka")
        txtStatus.DataBindings.Add("Text", edit.getBS(), "status")
        txtPlat.DataBindings.Add("Text", edit.getBS(), "plat")
    End Sub
    Private Sub FormEditMotor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim brs = edit.getBS().Find("id_motor", idmotor)
        If brs < 0 Then
            txtJenis.Text = ""
            txtHarga.Text = ""
            txtMerk.Text = ""
            txtNoMesin.Text = ""
            txtNoRangka.Text = ""
            txtPlat.Text = ""
            txtStatus.Text = ""
        Else
            edit.getBS().Position = brs
            bind()

        End If
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        edit.isiDataTable("UPDATE Motor SET jenis='" & txtJenis.Text & "', harga='" & txtHarga.Text & "', merek='" & txtMerk.Text & "', no_mesin='" & txtNoMesin.Text & "', no_rangka='" & txtNoRangka.Text & "', plat='" & txtPlat.Text & "' WHERE id_motor=" & idmotor, "Berhasil diupdate")
        txtJenis.Text = ""
        txtHarga.Text = ""
        txtMerk.Text = ""
        txtNoMesin.Text = ""
        txtNoRangka.Text = ""
        txtPlat.Text = ""
        txtStatus.Text = ""
    End Sub

    Private Sub btnBatal2_Click(sender As Object, e As EventArgs) Handles btnBatal2.Click
        Me.Close()
    End Sub
End Class