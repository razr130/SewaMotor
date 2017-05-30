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
    Dim value As Integer
    Dim merek As String
    Private membergak As Boolean = False

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
        'If GlobalVariables.Role > 0 Then
        '    btnSewa.Enabled = False
        'End If

        value = Integer.Parse(txthiddenharga.Text)
        txthiddenharga.Text = FormatCurrency(value)
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
        harga = value
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
        Else
            txtHarga.Text = "0"
        End If
        hargaall = Integer.Parse(txtHarga.Text)
        txtHarga.Text = FormatCurrency(hargaall)
    End Sub

    Private Sub cbWaktu_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbWaktu.SelectedIndexChanged, cbJaminan.SelectedIndexChanged
        harga = value
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
            Dim haha As Integer
            haha = Integer.Parse(txtHarga.Text)
            txtHarga.Text = FormatCurrency(haha)
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
        FormUtama.Show()
        Me.Close()
    End Sub

    Private Sub btnMember_Click(sender As Object, e As EventArgs) Handles btnMember.Click
        Dim pelanggan As New FormListPelanggan
        Dim ada As Integer
        pelanggan.ShowDialog()
        'MsgBox(pelanggan.idPelanggan.ToString)
        ada = customer.getBS.Find("id", pelanggan.idPelanggan)
        customer.getBS.Position = ada
        txtCustomer.Text = customer.getBS.Current("namaPelanggan")
        txtKTP.Text = customer.getBS.Current("no_ktp")
        txtTelp.Text = customer.getBS.Current("notelp")
        membergak = True
        lblDiskon.Visible = True
        If membergak = True Then
            'MsgBox(hargaall.ToString)
            hargaall = hargaall - (hargaall / 10)
            MsgBox("Sebagai member, anda mendapatkan diskon sebesar 10%, harga menjadi : Rp " & hargaall.ToString)
            txtHarga.Text = FormatCurrency(hargaall)
        End If
    End Sub

    Private Sub btnSewa_Click(sender As Object, e As EventArgs) Handles btnSewa.Click
        Dim result As Integer = MessageBox.Show("Apakah anda yakin ingin memesan motor merek " & txtMerek.Text & " untuk tanggal " & dtsewa.Value.Date.Day.ToString() & " ?", "Konfirmasi", MessageBoxButtons.YesNo)
        merek = txtMerek.Text
        If result = DialogResult.Yes Then
            tanggal = DateTime.Now


            Dim ada, adaorder, adakaryawan As Integer

            ada = customer.getBS.Find("namaPelanggan", txtCustomer.Text)
            If ada >= 0 Then
                customer.getBS.Position = ada
                id = customer.getBS.Current("id")
                pesan.getBS.Filter = "id=" & id

                adaorder = pesan.getBS.Find("tgl_order", tanggal.Date.ToString("yyyy-MM-dd"))

                If adaorder < 0 Then


                    If cbWaktu.SelectedItem = "Hari" Then
                        tglkembali = dtsewa.Value.AddDays(Integer.Parse(txtWaktu.Text))
                    ElseIf cbWaktu.SelectedItem = "Minggu" Then
                        tglkembali = dtsewa.Value.AddDays(Integer.Parse(txtWaktu.Text) * 7)
                    ElseIf cbWaktu.SelectedItem = "Bulan" Then
                        tglkembali = dtsewa.Value.AddDays(Integer.Parse(txtWaktu.Text) * 30)
                    ElseIf cbWaktu.SelectedItem = "Tahun" Then
                        tglkembali = dtsewa.Value.AddDays(Integer.Parse(txtWaktu.Text) * 365)
                    End If

                    adakaryawan = karyawan.getBS.Find("email", GlobalVariables.UserName)
                    karyawan.getBS.Position = adakaryawan
                    id_karyawan = karyawan.getBS.Current("id_karyawan")

                    pesan.isiDataTable("INSERT INTO Pesan(id,id_karyawan,tgl_order,total_denda,total_harga,jaminan,status) VALUES(" & id & "," & id_karyawan & ",'" & tanggal.ToString("yyyy-MM-dd") & "'," & 0 & "," & hargaall & ",'" & cbJaminan.Text & "','Belum dikembalikan')", "Berhasil pesan")

                    detail.isiDataTable("INSERT INTO Oder_Detail(no_order,id_motor,tgl_sewa,tgl_kembali,jumlah_sewa) VALUES((SELECT no_order from Pesan where id = " & id & " AND tgl_order ='" & tanggal.Date.ToString("yyyy-MM-dd") & "')," & idmotor & ",'" & dtsewa.Value.Date.ToString("yyyy-MM-dd") & "','" & tglkembali.Date.ToString("yyyy-MM-dd") & "'," & 1 & ")", "Berhasil tambah")
                    edit.isiDataTable("UPDATE Motor SET status=" & 1 & " WHERE id_motor=" & idmotor, "")

                    MsgBox("Motor merek " & merek & " telah berhasil disewa")
                Else

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

                    MsgBox("Motor merek " & merek & " telah berhasil disewa")

                End If
            Else
                If cbWaktu.SelectedItem = "Hari" Then
                    tglkembali = dtsewa.Value.AddDays(Integer.Parse(txtWaktu.Text))
                ElseIf cbWaktu.SelectedItem = "Minggu" Then
                    tglkembali = dtsewa.Value.AddDays(Integer.Parse(txtWaktu.Text) * 7)
                ElseIf cbWaktu.SelectedItem = "Bulan" Then
                    tglkembali = dtsewa.Value.AddDays(Integer.Parse(txtWaktu.Text) * 30)
                ElseIf cbWaktu.SelectedItem = "Tahun" Then
                    tglkembali = dtsewa.Value.AddDays(Integer.Parse(txtWaktu.Text) * 365)
                End If
                adakaryawan = karyawan.getBS.Find("email", GlobalVariables.UserName)
                karyawan.getBS.Position = adakaryawan
                id_karyawan = karyawan.getBS.Current("id_karyawan")

                customer.isiDataTable("INSERT INTO Pelanggan(namaPelanggan,notelp,no_ktp) VALUES('" & txtCustomer.Text & "','" & txtTelp.Text & "','" & txtKTP.Text & "')", "")


                pesan.isiDataTable("INSERT INTO Pesan(id,id_karyawan,tgl_order,total_denda,total_harga,jaminan,status) VALUES((SELECT id from Pelanggan WHERE namaPelanggan='" & txtCustomer.Text & "')," & id_karyawan & ",'" & tanggal.ToString("yyyy-MM-dd") & "'," & 0 & "," & hargaall & ",'" & cbJaminan.Text & "','Belum dikembalikan')", "Berhasil pesan")


                detail.isiDataTable("INSERT INTO Oder_Detail(no_order,id_motor,tgl_sewa,tgl_kembali,jumlah_sewa) VALUES((SELECT no_order from Pesan where id =(SELECT id FROM Pelanggan WHERE namaPelanggan='" & txtCustomer.Text & "') AND tgl_order ='" & tanggal.Date.ToString("yyyy-MM-dd") & "')," & idmotor & ",'" & dtsewa.Value.Date.ToString("yyyy-MM-dd") & "','" & tglkembali.Date.ToString("yyyy-MM-dd") & "'," & 1 & ")", "Berhasil tambah")
                edit.isiDataTable("UPDATE Motor SET status=" & 1 & " WHERE id_motor=" & idmotor, "")

                MsgBox("Motor merek " & merek & " telah berhasil disewa")
            End If

        ElseIf result = DialogResult.No Then



            End If

        FormUtama.Show()
        Me.Close()
    End Sub

    Private Sub homeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles homeToolStripMenuItem.Click
        FormUtama.Show()
        Me.Close()
    End Sub

    Private Sub logOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles logOutToolStripMenuItem.Click
        FormLogin.Show()
        Me.Close()
    End Sub

    Private Sub txtWaktu_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtWaktu.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub


End Class