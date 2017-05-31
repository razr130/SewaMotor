Public Class FormEditOrderDetail
    Dim edit As New Tabel("Oder_Detail")
    Dim viewOrder As New Tabel("ViewOrder")
    Dim nomorDetail As Integer
    Public tanggalkembali As System.DateTime
    Public idmotorawal As Integer
    Dim motor As New Tabel("Motor")


    Public Sub bind()

        txtIdMotor.Clear()
        dtTglSewa.DataBindings.Clear()

        txtIdMotor.DataBindings.Add("Text", edit.getBS(), "id_motor")
        dtTglSewa.DataBindings.Add("Value", edit.getBS(), "tgl_sewa")

    End Sub

    Private Sub FormEditOrderDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim brs = edit.getBS().Find("no_detalil", nomorDetail)
        If brs < 0 Then
            Return
        Else
            edit.getBS().Position = brs
            bind()
        End If

        idmotorawal = txtIdMotor.Text
    End Sub
    Public Sub New(ByVal noDetail As Integer)

        ' This call is required by the designer.
        InitializeComponent()
        Me.nomorDetail = noDetail
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If cbWaktu.SelectedItem = "Hari" Then
            tanggalkembali = dtTglSewa.Value.AddDays(Integer.Parse(txtJumlah.Text))
        ElseIf cbWaktu.SelectedItem = "Minggu" Then
            tanggalkembali = dtTglSewa.Value.AddDays(Integer.Parse(txtJumlah.Text) * 7)
        ElseIf cbWaktu.SelectedItem = "Bulan" Then
            tanggalkembali = dtTglSewa.Value.AddDays(Integer.Parse(txtJumlah.Text) * 30)
        ElseIf cbWaktu.SelectedItem = "Tahun" Then
            tanggalkembali = dtTglSewa.Value.AddDays(Integer.Parse(txtJumlah.Text) * 365)
        End If
        edit.isiDataTable("UPDATE Oder_Detail SET
                            id_motor='" & txtIdMotor.Text & "'
                            tgl_sewa='" & dtTglSewa.Value & "'
                            tgl_kembali='" & tanggalkembali.Date.ToString("yyyy-MM-dd") & "'
                            WHERE no_detalil='" & nomorDetail & "'", "")
        motor.isiDataTable("UPDATE Motor SET status=0 WHERE id_motor=" & idmotorawal, "")
        motor.isiDataTable("UPDATE Motor SET status=1 WHERE id_motor=" & txtIdMotor.Text, "")
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        FormListOrderDetail.Show()
        Me.Close()
    End Sub

    Private Sub btnPilih_Click(sender As Object, e As EventArgs) Handles btnPilih.Click
        Dim motor As New FormListMotorUntukEditOrderDetail
        motor.ShowDialog()
        txtIdMotor.Text = motor.idmotor
    End Sub
End Class