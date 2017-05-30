Public Class FormEditMotor
    Private idmotor As Integer
    Dim edit As New Tabel("Motor")
    Private status As Integer
    Private harga As Integer

    Public Sub New(id As Integer)



        InitializeComponent()
        idmotor = id


    End Sub
    Private Sub bind()

        cbJenis.DataBindings.Clear()
        txtHarga.DataBindings.Clear()
        txtMerk.DataBindings.Clear()
        txtNoMesin.DataBindings.Clear()
        txtNoRangka.DataBindings.Clear()
        txtPlat.DataBindings.Clear()
        txtSembunyiStatus.DataBindings.Clear()

        cbJenis.DataBindings.Add("Text", edit.getBS(), "jenis")
        txtHarga.DataBindings.Add("Text", edit.getBS(), "harga")
        txtMerk.DataBindings.Add("Text", edit.getBS(), "merek")
        txtNoMesin.DataBindings.Add("Text", edit.getBS(), "no_mesin")
        txtNoRangka.DataBindings.Add("Text", edit.getBS(), "no_rangka")
        txtSembunyiStatus.DataBindings.Add("Text", edit.getBS(), "status")
        txtPlat.DataBindings.Add("Text", edit.getBS(), "plat")

        If txtSembunyiStatus.Text = 0 Then
            cbStatus.SelectedItem = "Tersedia"
        Else
            cbStatus.SelectedItem = "Tidak Tersedia"
        End If

    End Sub
    Private Sub FormEditMotor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim brs = edit.getBS().Find("id_motor", idmotor)
        If brs < 0 Then

            txtHarga.Text = ""
            txtMerk.Text = ""
            txtNoMesin.Text = ""
            txtNoRangka.Text = ""
            txtPlat.Text = ""

        Else
            edit.getBS().Position = brs
            bind()

        End If
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If cbStatus.Text = "Tersedia" Then
            status = 0
        Else
            status = 1
        End If
        edit.isiDataTable("UPDATE Motor SET jenis='" & cbJenis.Text & "', harga='" & txtHarga.Text & "', merek='" & txtMerk.Text & "', no_mesin='" & txtNoMesin.Text & "', no_rangka='" & txtNoRangka.Text & "',status=" & status & ",plat='" & txtPlat.Text & "' WHERE id_motor=" & idmotor, "Berhasil diupdate")
        'txtJenis.Text = ""
        txtHarga.Text = ""
        txtMerk.Text = ""
        txtNoMesin.Text = ""
        txtNoRangka.Text = ""
        txtPlat.Text = ""
        'txtStatus.Text = ""
        Dim utama As New FormUtama
        utama.dgvMotor.DataSource = Nothing
        utama.dgvMotor.DataSource = utama.motor.getBS
        utama.Show()
        Me.Close()
    End Sub

    Private Sub btnBatal2_Click(sender As Object, e As EventArgs) Handles btnBatal2.Click
        FormUtama.Show()
        Me.Close()
    End Sub

    Private Sub txtHarga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHarga.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class