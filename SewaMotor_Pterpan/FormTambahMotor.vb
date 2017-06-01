Public Class FormTambahMotor
    Private tambah As New Tabel("Motor")

    Public Sub New()

        ' This call is required by the designer.

        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub btnBatal2_Click(sender As Object, e As EventArgs) Handles btnBatal2.Click
        Me.Close()

    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click

        If txtMerk.Text = "" And txtNoMesin.Text = "" And txtNoRangka.Text = "" And txtPlat.Text = "" Then
            MsgBox("Semua masih kosong")
        ElseIf txtNoMesin.Text = "" Then
            MsgBox("No Mesin masih kosong")
        ElseIf txtNoRangka.Text = "" Then
            MsgBox("No Rangka masih kosong")
        ElseIf txtPlat.Text = "" Then
            MsgBox("Plat masih kosong")
        ElseIf txtMerk.Text = "" Then
            MsgBox("Merek masih kosong")
        Else
            tambah.isiDataTable("INSERT INTO Motor VALUES('" & cbJenis.Text & "','" & txtMerk.Text & "','" & txtNoMesin.Text & "','" & txtNoRangka.Text & "','" & 0 & "','" & txtPlat.Text & "','" & txtHarga.Text & "')", "Data motor berhasil ditambah")

            txtNoMesin.Clear()
            txtNoRangka.Clear()

            txtPlat.Clear()

            Dim panggil As New FormUtama()
            panggil.Show()

            Me.Close()
        End If



    End Sub

    Private Sub FormTambahMotor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class