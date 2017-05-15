Public Class FormDetailMotor
    Private idmotor As Integer
    Dim edit As New Tabel("Motor")
    Public harga As Integer
    Public Sub New(id As Integer)



        InitializeComponent()
        idmotor = id


    End Sub

    Private Sub bind()

        txtKode.DataBindings.Clear()
        txtMerek.DataBindings.Clear()
        txtStatus.DataBindings.Clear()
        txtPlat.DataBindings.Clear()
        txthiddenharga.DataBindings.Clear()



        txtKode.DataBindings.Add("Text", edit.getBS(), "jenis")
        txtMerek.DataBindings.Add("Text", edit.getBS(), "merek")
        txtStatus.DataBindings.Add("Text", edit.getBS(), "status")
        txtPlat.DataBindings.Add("Text", edit.getBS(), "plat")
        txthiddenharga.DataBindings.Add("Text", edit.getBS(), "harga")



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

        If cbWaktu.Items.Count > 0 Then
            cbWaktu.SelectedIndex = 0
        End If
    End Sub

    Private Sub textBox5_TextChanged(sender As Object, e As EventArgs) Handles txtWaktu.TextChanged
        harga = Integer.Parse(txthiddenharga.Text)
        If txtWaktu.Text.Length > 0 Then
            If cbWaktu.SelectedItem = "Hari" Then
                txtHarga.Text = harga * Integer.Parse(txtWaktu.Text)
            ElseIf cbWaktu.SelectedItem = "Minggu" Then
                txtHarga.Text = harga * Integer.Parse(txtWaktu.Text) * 7
            ElseIf cbWaktu.SelectedItem = "Bulan" Then
                txtHarga.Text = harga * Integer.Parse(txtWaktu.Text) * 30
            ElseIf cbWaktu.SelectedItem = "Tahun" Then
                txtHarga.Text = harga * Integer.Parse(txtWaktu.Text) * 365
            End If
        End If

    End Sub

    Private Sub cbWaktu_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbWaktu.SelectedIndexChanged
        harga = Integer.Parse(txthiddenharga.Text)
        If txtWaktu.Text.Length > 0 Then
            If cbWaktu.SelectedItem = "Hari" Then
                txtHarga.Text = harga * Integer.Parse(txtWaktu.Text)
            ElseIf cbWaktu.SelectedItem = "Minggu" Then
                txtHarga.Text = harga * Integer.Parse(txtWaktu.Text) * 7
            ElseIf cbWaktu.SelectedItem = "Bulan" Then
                txtHarga.Text = harga * Integer.Parse(txtWaktu.Text) * 30
            ElseIf cbWaktu.SelectedItem = "Tahun" Then
                txtHarga.Text = harga * Integer.Parse(txtWaktu.Text) * 365
            End If
        End If
    End Sub

    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        edit.getBS().MoveFirst()
        bind()

    End Sub

    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        edit.getBS().MovePrevious()
        bind()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        edit.getBS().MoveNext()
        bind()
    End Sub

    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        edit.getBS().MoveLast()
        bind()
    End Sub
End Class