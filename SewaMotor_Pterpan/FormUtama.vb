Public Class FormUtama
    Private namaAkun As String
    Public motor As New Tabel("Motor")
    Public idmotor As Integer



    Private _username As String
    Public Property username() As String
        Get
            Return _username
        End Get
        Set(ByVal value As String)
            _username = value
        End Set
    End Property
    Private _role As Integer
    Public Property role() As Integer
        Get
            Return _role
        End Get
        Set(ByVal value As Integer)
            _role = value
        End Set
    End Property
    Public Sub New()
        InitializeComponent()

        'Me.namaAkun = namaAkun

    End Sub

    Private Sub FormUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblHalo.Text = "Log in sebagai :  " & username
        If role > 0 Then
            btnTambah.Visible = True
            btnUbah.Visible = True
            btnDelete.Visible = True
            btnList.Visible = True
            btnPengembalian.Visible = True

        End If

        dgvMotor.DataSource = motor.getBS()

        If dgvMotor.Columns.Count > 0 Then

            dgvMotor.Columns(0).Visible = False
            dgvMotor.Columns(3).Visible = False
            dgvMotor.Columns(4).Visible = False


        End If




    End Sub

    Private Sub logOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles logOutToolStripMenuItem.Click
        FormLogin.Show()
        Me.Close()
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim panggil As New FormTambahMotor()
        panggil.Show()

    End Sub



    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        idmotor = dgvMotor.Item(0, dgvMotor.CurrentRow.Index).Value
        Dim edit As New FormEditMotor(idmotor)
        edit.Show()

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        idmotor = dgvMotor.Item(0, dgvMotor.CurrentRow.Index).Value
        motor.isiDataTable("DELETE FROM Motor WHERE id_motor=" & idmotor, "Berhasil Delete")
    End Sub



    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        If txtCari.Text.Length <= 20 Then
            If txtCari.Text = "" Then
                motor.getBS.Filter = ""
                dgvMotor.DataSource = motor.getBS()
            Else

                motor.getBS.Filter = "merek LIKE '" & txtCari.Text & "%'"
                'motor.getBS().Position = brs




            End If
        End If

    End Sub



    Private Sub dgvMotor_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvMotor.CellMouseDoubleClick
        idmotor = dgvMotor.Item(0, dgvMotor.CurrentRow.Index).Value
        Dim edit As New FormDetailMotor(idmotor, username)
        edit.Show()

    End Sub

    Private Sub btnList_Click(sender As Object, e As EventArgs) Handles btnList.Click
        Dim list As New FormListPelanggan()
        list.ShowDialog()
        Me.Close()

    End Sub

    Private Sub ListPelangganToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListPelangganToolStripMenuItem.Click
        Dim list As New FormListPelanggan()
        list.ShowDialog()
        Me.Close()
    End Sub

    Private Sub ListKaryawanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListKaryawanToolStripMenuItem.Click
        Dim list As New FormListKaryawan(role, namaAkun)
        list.Show()
    End Sub
    Private Sub ListOrderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListOrderToolStripMenuItem.Click
        Dim list As New FormListOrder()
        list.Show()
    End Sub

    Private Sub btnPengembalian_Click(sender As Object, e As EventArgs) Handles btnPengembalian.Click
        Dim kembali As New FormKembali
        kembali.Show()
        Me.Close()
    End Sub

    Private Sub LaporanPenyewaanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanPenyewaanToolStripMenuItem.Click
        Dim laporan As New FormLaporan
        laporan.Show()
        Me.Close()


    End Sub
End Class