Public Class FormDetailMotor
    Private idmotor As Integer
    Dim edit As New Tabel("Motor")
    Dim pesan As New Tabel("Pesan")
    Dim detail As New Tabel("Oder_Detail")
    Dim customer As New Tabel("Pelanggan")
    Dim karyawan As New Tabel("Karyawan")
    Public harga As Integer
    Private nama As String
    Private sesi As Integer
    Private hari As String
    Public id As Integer
    Public id_karyawan As Integer
    Public tanggal As System.DateTime
    Public hargaall As Integer
    Public hargacurrent As Integer
    Public idorder As Integer
    Public tglkembali As System.DateTime

    Public iddetail As Integer


    Public Sub New(id As Integer, username As String)



        InitializeComponent()
        idmotor = id
        nama = username


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

        txtKode.Enabled = False
        txtMerek.Enabled = False
        txtStatus.Enabled = False
        txtPlat.Enabled = False
        txthiddenharga.Enabled = False

        If txtStatus.Text = "0" Then
            txtStatus.Text = "Tersedia"
        Else
            txtStatus.Text = "Tidak tersedia"
        End If
        If txtStatus.Text = "Tidak tersedia" Then
            btnSewa.Enabled = False
        Else
            btnSewa.Enabled = True
        End If

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
        hargaall = Integer.Parse(txtHarga.Text)
    End Sub

    Private Sub cbWaktu_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbWaktu.SelectedIndexChanged, cbJaminan.SelectedIndexChanged
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

    Private Sub linkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkLabel1.LinkClicked

        Me.Close()
    End Sub

    Private Sub btnSewa_Click(sender As Object, e As EventArgs) Handles btnSewa.Click
        Dim result As Integer = MessageBox.Show("Apakah anda yakin ingin memesan motor merek " & txtMerek.Text & " untuk tanggal " & dtsewa.Value.Date.Day.ToString() & " ?", "Konfirmasi", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            tanggal = DateTime.Now
            If tanggal.DayOfWeek = 1 Then
                hari = "Senin"
            ElseIf tanggal.DayOfWeek = 2 Then
                hari = "Selasa"
            ElseIf tanggal.DayOfWeek = 3 Then
                hari = "Rabu"
            ElseIf tanggal.DayOfWeek = 4 Then
                hari = "Kamis"
            ElseIf tanggal.DayOfWeek = 5 Then
                hari = "Jumat"
            ElseIf tanggal.DayOfWeek = 6 Then
                hari = "Sabtu"
            ElseIf tanggal.DayOfWeek = 7 Then
                hari = "Minggu"
            End If

            If tanggal.Hour >= 7 And tanggal.Hour < 11 Then
                sesi = 1
            ElseIf tanggal.Hour >= 11 And tanggal.Hour < 15 Then
                sesi = 2
            ElseIf tanggal.Hour >= 15 And tanggal.Hour < 19 Then
                sesi = 3
            ElseIf tanggal.Hour >= 19 And tanggal.Hour < 22 Then
                sesi = 4
            End If

            Dim ada, adaorder, adakaryawanhari, adakaryawansesi As Integer
            ada = customer.getBS.Find("email", nama)
            adakaryawanhari = karyawan.getBS.Find("hari_kerja", hari)
            adakaryawansesi = karyawan.getBS.Find("sesi_kerja", sesi)
            customer.getBS.Filter = "email='" & nama & "'"
            karyawan.getBS.Filter = "hari_kerja='" & hari & "' AND sesi_kerja=" & sesi
            If adakaryawanhari >= 0 Then
                If adakaryawansesi >= 0 Then
                    If ada >= 0 Then
                        id = customer.getBS.Current("id")
                        pesan.getBS.Filter = "id=" & id
                        'MsgBox(tanggal.Date.ToString("yyyy-MM-dd"))
                        adaorder = pesan.getBS.Find("tgl_order", tanggal.Date.ToString("yyyy-MM-dd"))
                        MsgBox("Index adaorder : " & adaorder.ToString)
                        If adaorder < 0 Then
                            MsgBox("bikin baru")

                            id_karyawan = karyawan.getBS.Current("id_karyawan")
                            pesan.isiDataTable("INSERT INTO Pesan(id,id_karyawan,tgl_order,total_denda,total_harga,jaminan) VALUES(" & id & "," & id_karyawan & ",'" & tanggal.Date.ToString("yyyy-MM-dd") & "'," & 0 & "," & hargaall & ",'" & cbJaminan.Text & "')", "Berhasil pesan")

                            If cbWaktu.SelectedItem = "Hari" Then
                                tglkembali = dtsewa.Value.AddDays(Integer.Parse(txtWaktu.Text))
                            ElseIf cbWaktu.SelectedItem = "Minggu" Then
                                tglkembali = dtsewa.Value.AddDays(Integer.Parse(txtWaktu.Text) * 7)
                            ElseIf cbWaktu.SelectedItem = "Bulan" Then
                                tglkembali = dtsewa.Value.AddDays(Integer.Parse(txtWaktu.Text) * 30)
                            ElseIf cbWaktu.SelectedItem = "Tahun" Then
                                tglkembali = dtsewa.Value.AddDays(Integer.Parse(txtWaktu.Text) * 365)
                            End If

                            detail.isiDataTable("INSERT INTO Oder_Detail(no_order,id_motor,tgl_sewa,tgl_kembali,jumlah_sewa) VALUES((SELECT no_order from pesan where id = " & id & " AND tgl_order ='" & tanggal.Date.ToString("yyyy-MM-dd") & "')," & idmotor & ",'" & dtsewa.Value.Date.ToString("yyyy-MM-dd") & "','" & tglkembali.Date.ToString("yyyy-MM-dd") & "'," & 1 & ")", "Berhasil tambah")
                            edit.isiDataTable("UPDATE Motor SET status=" & 1 & " WHERE id_motor=" & idmotor, "")


                        Else
                            MsgBox("nambah baru")
                            idorder = pesan.getBS.Current("no_order")
                            If cbWaktu.SelectedItem = "Hari" Then
                                tglkembali = dtsewa.Value.AddDays(Integer.Parse(txtWaktu.Text))
                            ElseIf cbWaktu.SelectedItem = "Minggu" Then
                                tglkembali = dtsewa.Value.AddDays(Integer.Parse(txtWaktu.Text) * 7)
                            ElseIf cbWaktu.SelectedItem = "Bulan" Then
                                tglkembali = dtsewa.Value.AddDays(Integer.Parse(txtWaktu.Text) * 30)
                            ElseIf cbWaktu.SelectedItem = "Tahun" Then
                                tglkembali = dtsewa.Value.AddDays(Integer.Parse(txtWaktu.Text) * 365)
                            End If

                            pesan.getBS.Filter = "id=" & id & " AND tgl_order='" & tanggal.Date.ToString("yyyy-MM-dd") & "'"
                            hargacurrent = pesan.getBS.Current("total_harga")
                            hargaall = hargaall + hargacurrent
                            detail.isiDataTable("INSERT INTO Oder_Detail(no_order,id_motor,tgl_sewa,tgl_kembali,jumlah_sewa) VALUES((SELECT no_order from pesan where id = " & id & " AND tgl_order ='" & tanggal.Date.ToString("yyyy-MM-dd") & "')," & idmotor & ",'" & dtsewa.Value.Date.ToString("yyyy-MM-dd") & "','" & tglkembali.Date.ToString("yyyy-MM-dd") & "'," & 1 & ")", "Berhasil tambah")
                            pesan.isiDataTable("UPDATE Pesan SET total_harga=" & hargaall & " WHERE id=" & id & " AND tgl_order='" & tanggal.Date.ToString("yyyy-MM-dd") & "'", "")
                            edit.isiDataTable("UPDATE Motor SET status=" & 1 & " WHERE id_motor=" & idmotor, "")



                        End If

                    End If
                Else
                    MsgBox("Tidak ada karyawan yang bekerja sesi ini")
                End If

            Else
                MsgBox("Tidak ada karyawan yang bekerja hari ini")
            End If
        ElseIf result = DialogResult.No Then



        End If
        Me.Close()
    End Sub


End Class