Imports System.Data.SqlClient
Imports System.Configuration

Public Class CD_Conexion
    Public Shared cnn As String = (ConfigurationManager.ConnectionStrings("DefaultConnection").ConnectionString)
    Private Conexion As New SqlConnection(cnn)

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
