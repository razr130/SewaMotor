Public Class FormUtama
    Private namaAkun As String
    Private motor As New Tabel("Motor")
    Public idmotor As Integer
    Public Sub New(ByVal namaakun As String)
        InitializeComponent()

        Me.namaAkun = namaakun

    End Sub
    Private Sub FormUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblHalo.Text = "Log in sebagai :  " & namaAkun
        If namaAkun = "admin" Then
            btnTambah.Visible = True
            btnUbah.Visible = True
            btnDelete.Visible = True

        End If

        dgvMotor.DataSource = motor.getBS()

        If dgvMotor.Columns.Count > 0 Then

            dgvMotor.Columns(0).Visible = False
            dgvMotor.Columns(3).Visible = False
            dgvMotor.Columns(4).Visible = False


        End If

        'While dgvMotor.RowCount > 0
        '    Do
        '        If dgvMotor.Item(5, dgvMotor.CurrentRow.Index).Value = 0 Then
        '            dgvMotor.Item(5, dgvMotor.CurrentRow.Index).Value = "Tersedia"
        '        Else
        '            dgvMotor.Item(5, dgvMotor.CurrentRow.Index).Value = "Tidak Tersedia"
        '        End If
        '    Loop


        'End While


    End Sub

    Private Sub logOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles logOutToolStripMenuItem.Click

        Me.Close()
        FormLogin.ShowDialog()

    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        FormTambahMotor.ShowDialog()

    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        MsgBox("kontol")
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        idmotor = dgvMotor.Item(0, dgvMotor.CurrentRow.Index).Value
        Dim edit As New FormEditMotor(idmotor)
        edit.ShowDialog()

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

    Private Sub dgvMotor_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMotor.CellContentClick

    End Sub

    Private Sub dgvMotor_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvMotor.CellMouseDoubleClick
        idmotor = dgvMotor.Item(0, dgvMotor.CurrentRow.Index).Value
        Dim edit As New FormDetailMotor(idmotor)
        edit.ShowDialog()
    End Sub
End Class