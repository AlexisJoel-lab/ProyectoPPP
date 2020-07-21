Imports CapaDatos
Imports CapaEntidad

Public Class CN_Rol
    Private objetoCD As New CD_Rol()

    Public Function N_MostrarRol() As DataTable
        Dim tabla As DataTable = New DataTable()
        tabla = objetoCD.D_MostrarRol
        Return tabla
    End Function
    Public Sub N_InsertarRol(enti As CE_Rol)
        objetoCD.D_InsertarRol(enti)
    End Sub

    Public Sub N_EditarRol(enti As CE_Rol)
        objetoCD.D_EditarRol(enti)
    End Sub

    Public Sub N_EliminarRol(enti As CE_Rol)
        objetoCD.D_EliminarRol(enti)
    End Sub
End Class
