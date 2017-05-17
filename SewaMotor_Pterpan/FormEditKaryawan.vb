Public Class FormEditKaryawan
    Private edit As New Tabel("Karyawan")
    Private idKaryawan As Integer
    Private roleUser As Integer


    Public Sub New(ByVal idKaryawan As Integer)
        ' This call is required by the designer.
        InitializeComponent()
        Me.idKaryawan = idKaryawan
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub FormEditKaryawan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim brs = edit.getBS().Find("id_karyawan", idKaryawan)

        If brs < 0 Then
            txtNama.Text = ""
            txtPass.Text = ""
            txtEmail.Text = ""
            txtNoTelp.Text = ""
            txtAlamat.Text = ""
            txtRole.Text = ""
        Else
            edit.getBS().Position = brs
            bind()
        End If
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txtEmail.Text = "" Or txtPass.Text = "" Or txtNama.Text = "" Or txtAlamat.Text = "" Or txtNoTelp.Text = "" Or (radioKaryawan.Checked = False And radioAdmin.Checked = False) Or (radioKaryawan.Checked = True And radioAdmin.Checked = True) Then
            MsgBox("Harap Diisi Semua")
        Else
            edit.isiDataTable("UPDATE INTO Karyawan SET
                                email='" & txtEmail.Text & "',
                                password'" & txtPass.Text & "',
                                nama'" & txtNama.Text & "',
                                '" & txtNoTelp.Text & "',
                                '" & txtAlamat.Text & "',
                                '" & Role() & "'",
                           "Data Karyawan berhasil ditambah")
            Dim back As New FormListKaryawan()
            back.Show()
            Me.Close()
        End If
    End Sub
    Private Sub unBind()
        txtEmail.DataBindings.Clear()
        txtPass.DataBindings.Clear()
        txtNama.DataBindings.Clear()
        txtAlamat.DataBindings.Clear()
        txtNoTelp.DataBindings.Clear()
        txtRole.DataBindings.Clear()
    End Sub

    Private Sub bind()
        unBind()
        txtEmail.DataBindings.Add("text", edit.getBS(), "email")
        txtPass.DataBindings.Add("text", edit.getBS(), "password")
        txtNama.DataBindings.Add("text", edit.getBS(), "nama")
        txtAlamat.DataBindings.Add("text", edit.getBS(), "alamat")
        txtNoTelp.DataBindings.Add("text", edit.getBS(), "no_telp")
        txtRole.DataBindings.Add("text", edit.getBS(), "role")
        If txtRole.Text = "2" Then
            radioAdmin.Checked = True
            radioKaryawan.Checked = False
        ElseIf txtRole.Text = "3" Then
            radioAdmin.Checked = True
            radioKaryawan.Checked = True

        End If

    End Sub


    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Me.Close()
        Dim back As New FormListKaryawan()
        back.ShowDialog()

    End Sub

    Private Function Role()
        Dim x As Integer
        If radioAdmin.Checked Then
            x = 2
        ElseIf radioKaryawan.Checked Then
            x = 3
        End If
        Return x
    End Function

    Private Sub getRole(ByVal x As Integer)
        If x = 2 Then
            radioAdmin.Checked = True
            radioKaryawan.Checked = False
        ElseIf x = 3 Then
            radioAdmin.Checked = False
            radioKaryawan.Checked = True
        End If
    End Sub
End Class