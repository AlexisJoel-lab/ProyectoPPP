Imports CapaEntidad
Imports System.Data.SqlClient

Public Class CD_Usuario
    Private cnn As SqlConnection = New SqlConnection()
    Private au As CE_ActiveUser = New CE_ActiveUser()
    Private prm As SqlParameter = New SqlParameter()

    Public Function Login(user As String, pass As String) As Boolean
        Using connection = cnn
            connection.Open()
            Using cmd = New SqlCommand()
                cmd.Connection = connection
                cmd.CommandText = "sp_UsuarioMostrar"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@user", user)
                cmd.Parameters.AddWithValue("@pass", pass)
                cmd.CommandType = CommandType.Text
                Dim reader = cmd.ExecuteReader()
                If reader.HasRows Then
                    While reader.Read() 'Obtenemos los datos de la columna y asignamos a los campos de usuario activo en cache'
                        au.ID_USUARIO = reader.GetInt32(0)
                        au.FK_ID_ROL = reader.GetInt32(1)
                        au.ID_USUARIO = reader.GetString(2)
                        au.NOMBRE = reader.GetString(3)
                        au.CONTRASEÑA = reader.GetString(4)
                        au.APE_PATERNO = reader.GetString(5)
                        au.APE_MATERNO = reader.GetString(6)
                        au.EMAIL = reader.GetString(7)
                    End While
                    reader.Dispose()
                    Return True
                Else
                    Return False
                End If
            End Using
        End Using
    End Function



    'Public Function D_MostrarUsuario(ByVal cadenaConexion As String, ByVal entidad As CE_Usuario) As DataTable
    '    Try
    '        conexion.ConnectionString = cadenaConexion
    '        comando.Connection = conexion
    '        comando.CommandText = "SelUsuario"
    '        comando.CommandType = CommandType.StoredProcedure

    '        prm = comando.Parameters.Add("@USUARIO", SqlDbType.VarChar, 100)
    '        prm.Direction = ParameterDirection.Input
    '        prm.Value = entidad.USUARIO

    '        prm = comando.Parameters.Add("@CONTRASEÑA", SqlDbType.VarBinary)
    '        prm.Direction = ParameterDirection.Input
    '        prm.Value = entidad.CONTRASEÑA

    '        'Dim da As SqlDataAdapter(comando)
    '        'Dim ds As DataSet
    '        'conexion.Open()
    '        'da.fill(ds, "Usuario")
    '        'conexion.Close()
    '        'Return ds.Tables("Usuario")
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '        Return Nothing
    '    End Try
    'End Function
End Class
