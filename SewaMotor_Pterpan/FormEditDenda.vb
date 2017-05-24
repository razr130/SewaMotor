Public Class FormEditDenda
    Private denda As New Tabel("Denda")
    Private iddenda As Integer

    Public Sub New(id As Integer)

        iddenda = id
        InitializeComponent()



    End Sub
    Private Sub bind()

        txtHarga.DataBindings.Clear()
        txtNama.DataBindings.Clear()


        txtNama.DataBindings.Add("Text", denda.getBS(), "nama_denda")
        txtHarga.DataBindings.Add("Text", denda.getBS(), "harga")

    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        denda.isiDataTable("UPDATE Denda SET nama_denda='" & txtNama.Text & "', harga=" & txtHarga.Text & "WHERE id_denda=" & iddenda, "Berhasil diupdate")
        txtNama.Text = ""
        txtHarga.Text = ""

        Dim utama As New FormListDenda
        utama.dgvDenda.DataSource = Nothing
        utama.dgvDenda.DataSource = utama.denda.getBS
        FormListDenda.Show()
        Me.Close()
    End Sub

    Private Sub FormEditDenda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim brs = denda.getBS().Find("id_denda", iddenda)
        If brs < 0 Then
            txtNama.Text = ""
            txtHarga.Text = ""

        Else
            denda.getBS().Position = brs
            bind()

        End If
    End Sub
End Class