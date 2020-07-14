Imports System.Data.SqlClient
Imports System.Configuration

Public Class CD_Conexion
<<<<<<< HEAD
    Public Shared cnn As String = (ConfigurationManager.ConnectionStrings("DefaultConnection").ConnectionString)
    Private Conexion As New SqlConnection(cnn)
=======
    Private Conexion As SqlConnection = New SqlConnection("Server=DESKTOP-77HMJDO\SQLEXPRESS;DataBase=DBVENTAS;Integrated Security=true")
>>>>>>> 82df7d6d269a162e60ef4ce5eea69cf68a208ff7

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
