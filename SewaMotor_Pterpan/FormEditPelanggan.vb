Public Class FormEditPelanggan
    Private idPelanggan As Integer
    Dim edit As New Tabel("Pelanggan")

    Public Sub New(ByVal idPelanggan As Integer)
        ' This call is required by the designer.
        InitializeComponent()
        Me.idPelanggan = idPelanggan
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub FormEditPelanggan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim brs = edit.getBS().Find("id", idPelanggan)
        If brs < 0 Then
            txtIdPelanggan.Text = ""
            txtEmail.Text = ""
            txtPass.Text = ""
            txtNama.Text = ""
            txtNoKTP.Text = ""
            DtTglLahir.Text = ""
            txtAlamat.Text = ""
            txtNoTelp.Text = ""
        Else
            edit.getBS().Position = brs
            bind()
        End If


    End Sub

    Private Sub unBind()
        txtIdPelanggan.DataBindings.Clear()
        txtEmail.DataBindings.Clear()
        txtPass.DataBindings.Clear()
        txtNama.DataBindings.Clear()
        txtNoKTP.DataBindings.Clear()
        DtTglLahir.DataBindings.Clear()
        txtAlamat.DataBindings.Clear()
        txtNoTelp.DataBindings.Clear()
    End Sub

    Private Sub bind()
        unBind()

        txtIdPelanggan.DataBindings.Add("text", edit.getBS(), "id")
        txtEmail.DataBindings.Add("text", edit.getBS(), "email")
        txtPass.DataBindings.Add("text", edit.getBS(), "password")
        txtNama.DataBindings.Add("text", edit.getBS(), "namaPelanggan")
        txtNoKTP.DataBindings.Add("text", edit.getBS(), "no_ktp")
        DtTglLahir.DataBindings.Add("text", edit.getBS(), "ttl")
        txtAlamat.DataBindings.Add("text", edit.getBS(), "alamat")
        txtNoTelp.DataBindings.Add("text", edit.getBS(), "notelp")
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        edit.isiDataTable("UPDATE Pelanggan SET 
                            email='" & txtEmail.Text & "', 
                            password='" & txtPass.Text & "', 
                            namaPelanggan='" & txtNama.Text & "', 
                            no_ktp='" & txtNoKTP.Text & "', 
                            ttl='" & DtTglLahir.Value.ToString("yyyy/MM/dd") & "',
                            alamat='" & txtAlamat.Text & "',
                            notelp='" & txtNoTelp.Text & "' 
                            WHERE id=" & idPelanggan, "Data Berhasil di Update!")
        Me.Close()
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Me.Close()
    End Sub

    Private Sub groupBox1_Enter(sender As Object, e As EventArgs) Handles groupBox1.Enter

    End Sub
End Class