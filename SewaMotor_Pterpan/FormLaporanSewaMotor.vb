﻿Public Class FormLaporanSewaMotor
    Dim jenisLaporan As Integer

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
    End Sub


    Private Sub FormLaporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetSewaMotor2.Pesan' table. You can move, or remove it, as needed.
        Me.PesanTableAdapter.Fill(Me.DataSetSewaMotor2.Pesan)
        'TODO: This line of code loads data into the 'DataSetSewaMotor2.Oder_Detail' table. You can move, or remove it, as needed.
        Me.Oder_DetailTableAdapter.Fill(Me.DataSetSewaMotor2.Oder_Detail)
        'TODO: This line of code loads data into the 'DataSetSewaMotor2.Motor' table. You can move, or remove it, as needed.
        Me.MotorTableAdapter.Fill(Me.DataSetSewaMotor2.Motor)
        'TODO: This line of code loads data into the 'SewaMotorDataSet.Order' table. You can move, or remove it, as needed.
        Me.ReportViewer1.RefreshReport()

    End Sub


End Class