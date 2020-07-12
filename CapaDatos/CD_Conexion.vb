Imports System.Data.SqlClient
Public Class CD_Conexion
    Private Conexion As SqlConnection = New SqlConnection("Server=DESKTOP-77HMJDO\SQLEXPRESS;DataBase=DBVENTAS;Integrated Security=true")

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
