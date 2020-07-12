Imports CapaEntidad
Imports CapaDatos

Public Class CN_Categoria
    Private objetoCD_Categoria As New CD_Categoria()

    Public Function N_MostrarCategoria() As DataTable
        Dim tabla As DataTable = New DataTable()
        tabla = objetoCD_Categoria.D_MostrarCategoria
        Return tabla
    End Function

    Public Sub N_InsertarCategoria(enti As CE_Categoria)
        objetoCD_Categoria.D_InsertarCategoria(enti)
    End Sub

    Public Sub N_EditarCategoria(enti As CE_Categoria)
        objetoCD_Categoria.D_EditarCategoria(enti)
    End Sub

    Public Sub N_EliminarCategoria(enti As CE_Categoria)
        objetoCD_Categoria.D_EliminarCategoria(enti)
    End Sub
End Class
