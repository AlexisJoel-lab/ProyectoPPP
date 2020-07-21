Imports System.Data.SqlClient
Imports System.Configuration

Public Class CD_Conexion

    'Public Shared cnn As String = (ConfigurationManager.ConnectionStrings("DefaultConnection").ConnectionString)
    'Private Conexion As New SqlConnection(cnn)

    Private Conexion As SqlConnection = New SqlConnection("Server=ALEXIS-PC\SQLEXPRESS;DataBase=DBVENTAS;Integrated Security=true")

    Public Function AbrirConexion() As SqlConnection
        If Conexion.State = ConnectionState.Closed Then
            Conexion.Open()
        End If
        Return Conexion
    End Function

    Public Function CerrarConexion() As SqlConnection
        If Conexion.State = ConnectionState.Open Then
            Conexion.Close()
        End If
        Return Conexion
    End Function
End Class
