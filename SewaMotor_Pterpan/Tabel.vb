Imports System.Data.SqlClient
Imports System.IO
Imports System.Text
Imports System.Data
Imports System.Configuration
Imports System.Security.Cryptography


Public Class Tabel
    Private conn As SqlConnection
    Private dt As New DataTable()
    Private bs As New BindingSource()
    Private namaTabel As String

    Public Function getBS() As BindingSource
        Return Me.bs
    End Function
    Public Function getDT() As DataTable
        Return Me.dt
    End Function

    '/////CONSTRUCTOR/////
    Public Sub New(namaTabel As String)
        Me.namaTabel = namaTabel
        conn = New SqlConnection(My.Settings.StrConn)
        isiDataTable()
    End Sub
    Public Sub New(namaTabel As String, strSql As String)
        Me.namaTabel = namaTabel
        conn = New SqlConnection(My.Settings.StrConn)
        isiDataTable(strSql, "lel")
    End Sub


    Public Sub isiDataTable(strSql As String, pesan As String)
        Me.conn.Open()
        Dim cmd As New SqlCommand(strSql, Me.conn)
        MsgBox(strSql)
        Dim da As New SqlDataAdapter()
        da.SelectCommand = cmd

        If Me.dt Is Nothing Then
            da.Fill(Me.dt)
            MsgBox(pesan)
        Else
            Me.dt.Clear()
            da.Fill(Me.dt)
            MsgBox(pesan)
        End If
        Me.conn.Close()
        'isiDataTable()
        Me.bs.DataSource = dt
    End Sub

    Private Sub isiDataTable()
        Me.conn.Open()
        Dim cmd As New SqlCommand("SELECT * FROM " & Me.namaTabel, Me.conn)
        Dim da As New SqlDataAdapter()
        da.SelectCommand = cmd
        If Me.dt Is Nothing Then
            da.Fill(Me.dt)
        Else
            Me.dt.Clear()
            da.Fill(Me.dt)
        End If
        Me.conn.Close()
        Me.bs.DataSource = dt
    End Sub
    'Public Function eksekusiSQL(strSql As String) As Boolean
    '    Dim berubah As Integer = 0
    '    Me.conn.Open()
    '    Dim cmd As New SqlCommand(strSql, Me.conn)
    '    Try
    '        berubah = cmd.ExecuteNonQuery()
    '    Catch ex As Exception
    '        MessageBox.Show("Ada Kesalahan : " + ex.Message)
    '    End Try
    '    Me.conn.Close()
    '    isiDataTable()
    '    Return berubah > 0
    'End Function


End Class
