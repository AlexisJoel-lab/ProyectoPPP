Imports CapaDatos
Imports CapaEntidad
Public Class CN_Usuario
    Private objetoCD As New CD_Usuario()

    Public Function Login(user As String, pass As String) As CE_Usuario
        Return objetoCD.Login(user, pass)
    End Function

    'Public Function N_MostrarUser(ByVal cadenaConexion As String, ByVal entidad As CapaEntidad.CE_Usuario) As DataTable
    '    Return objetoCD.D_MostrarUsuario(cadenaConexion, entidad)
    'End Function
End Class
