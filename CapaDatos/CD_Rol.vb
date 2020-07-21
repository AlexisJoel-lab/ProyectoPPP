Imports System.Data.SqlClient
Imports CapaEntidad

Public Class CD_Rol
    Private cnn As CD_Conexion = New CD_Conexion()
    Private leer As SqlDataReader
    Private tabla As DataTable = New DataTable()
    Private cmd As SqlCommand = New SqlCommand()

    Public Function D_MostrarRol() As DataTable
        cmd.Connection = cnn.AbrirConexion()
        cmd.CommandText = "sp_RolMostrar"
        cmd.CommandType = CommandType.StoredProcedure
        leer = cmd.ExecuteReader()
        tabla.Load(leer)
        cnn.CerrarConexion()
        Return tabla
    End Function

    Public Sub D_InsertarRol(enti As CE_Rol)
        cmd.Connection = cnn.AbrirConexion()
        cmd.CommandText = "sp_RolInsertar"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@DESCRIPCION", enti.DESCRIPCION)
        cmd.ExecuteNonQuery()
        cmd.Parameters.Clear()
        cnn.CerrarConexion()
    End Sub
    Public Sub D_EditarRol(enti As CE_Rol)
        cmd.Connection = cnn.AbrirConexion()
        cmd.CommandText = "sp_RolEditar"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@DESCRIPCION", enti.DESCRIPCION)
        cmd.Parameters.AddWithValue("@ID_ROL", enti.ID_ROL)
        cmd.ExecuteNonQuery()
        cmd.Parameters.Clear()
        cnn.CerrarConexion()
    End Sub
    Public Sub D_EliminarRol(enti As CE_Rol)
        cmd.Connection = cnn.AbrirConexion()
        cmd.CommandText = "sp_RolEliminar"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@ID_ROL", enti.ID_ROL)
        cmd.ExecuteNonQuery()
        cmd.Parameters.Clear()
        cnn.CerrarConexion()
    End Sub
End Class
