Imports System.Data.SqlClient
Imports CapaEntidad

Public Class CD_Categoria
    Private cnn As CD_Conexion = New CD_Conexion()
    Private leer As SqlDataReader
    Private tabla As DataTable = New DataTable()
    Private cmd As SqlCommand = New SqlCommand()

    Public Function D_MostrarCategoria() As DataTable
        cmd.Connection = cnn.AbrirConexion()
        cmd.CommandText = "sp_CategoriaMostrar"
        cmd.CommandType = CommandType.StoredProcedure
        leer = cmd.ExecuteReader()
        tabla.Load(leer)
        cnn.CerrarConexion()
        Return tabla
    End Function

    Public Sub D_InsertarCategoria(enti As CE_Categoria)
        cmd.Connection = cnn.AbrirConexion()
        cmd.CommandText = "sp_CategoriaInsertar"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@DESCRIPCION", enti.DESCRIPCION)
        cmd.ExecuteNonQuery()
        cmd.Parameters.Clear()
        cnn.CerrarConexion()
    End Sub

    Public Sub D_EditarCategoria(enti As CE_Categoria)
        cmd.Connection = cnn.AbrirConexion()
        cmd.CommandText = "sp_CategoriaEditar"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@DESCRIPCION", enti.DESCRIPCION)
        cmd.Parameters.AddWithValue("@ID_CATEGORIA", enti.ID_CATEGORIA)
        cmd.ExecuteNonQuery()
        cmd.Parameters.Clear()
        cnn.CerrarConexion()
    End Sub

    Public Sub D_EliminarCategoria(enti As CE_Categoria)
        cmd.Connection = cnn.AbrirConexion()
        cmd.CommandText = "sp_CategoriaEliminar"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@ID_CATEGORIA", enti.ID_CATEGORIA)
        cmd.ExecuteNonQuery()
        cmd.Parameters.Clear()
        cnn.CerrarConexion()
    End Sub
End Class
