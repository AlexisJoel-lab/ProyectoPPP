Imports System.Data.SqlClient
Imports CapaDatos

Public Class SiteMaster
    Inherits MasterPage

    Private cnn As CD_Conexion = New CD_Conexion()
    Private leer As SqlDataReader
    Private tabla As DataTable = New DataTable()
    Private cmd As SqlCommand = New SqlCommand()

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

    End Sub

    Protected Sub mostrarMenu()

    End Sub

End Class