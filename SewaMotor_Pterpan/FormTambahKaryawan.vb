Public Class FormTambahKaryawan
    Private tambah As New Tabel("Karyawan")

    '/////LOAD/////
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub FormTambahKaryawan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    '/////BUTTON/////
    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click

        Me.Close()
    End Sub
    Private Sub btnDaftar_Click(sender As Object, e As EventArgs) Handles btnDaftar.Click
        If txtEmail.Text = "" Or txtPass.Text = "" Or txtNama.Text = "" Or txtAlamat.Text = "" Or txtNoTelp.Text = "" Or (radioKaryawan.Checked = False And radioAdmin.Checked = False) Or (radioKaryawan.Checked = True And radioAdmin.Checked = True) Then
            MsgBox("Harap Diisi Semua")
        Else
            tambah.isiDataTable("INSERT INTO Karyawan(namaKaryawan,alamat,no_telp,email,password,role) VALUES(
                                '" & txtEmail.Text & "',
                                '" & txtAlamat.Text & "',
                                '" & txtNoTelp.Text & "',
                                '" & txtEmail.Text & "',
                                '" & txtPass.Text & "',
                                '" & Role() & "')",
                           "Data Karyawan berhasil ditambah")
            Me.Close()
            Dim listkar As New FormListKaryawan()
            listkar.Show()
        End If

    End Sub

    '/////FUNCTION/////
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