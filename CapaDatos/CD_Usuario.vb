Imports CapaEntidad
Imports System.Data.SqlClient

Public Class CD_Usuario

    Private cnn As CD_Conexion = New CD_Conexion()
    Private au As CE_ActiveUser = New CE_ActiveUser()
    Private prm As SqlParameter = New SqlParameter()
    'Inherits DbConnection
    Public Function Login(user As String, pass As String) As Boolean
        Using connection = cnn.AbrirConexion()
            Using cmd = New SqlCommand()
                cmd.Connection = connection
                cmd.CommandText = "sp_UsuarioValidar"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@USUARIO", user)
                cmd.Parameters.AddWithValue("@CONTRASEÑA", pass)
                'prm = cmd.Parameters.Add("@USUARIO", SqlDbType.VarChar, 100)
                'prm.Direction = ParameterDirection.Input
                'prm.Value = user

                'prm = cmd.Parameters.Add("@CONTRASEÑA", SqlDbType.VarChar, 100)
                'prm.Direction = ParameterDirection.Input
                'prm.Value = pass

                cmd.CommandType = CommandType.Text

                'Dim reader = cmd.ExecuteNonQuery
                Dim reader = cmd.ExecuteReader()
                If reader.HasRows Then
                    While reader.Read() 'Obtenemos los datos de la columna y asignamos a los campos de usuario activo en cache'
                        au.ID_USUARIO = reader.GetInt32(0)
                        au.CODIGO = reader.GetString(1)
                        au.FK_ID_ROL = reader.GetString(2)
                        au.USUARIO = reader.GetString(3)
                        au.CONTRASEÑA = reader.GetString(4)
                        au.NOMBRE = reader.GetString(5)
                        au.APE_PATERNO = reader.GetString(6)
                        au.APE_MATERNO = reader.GetString(7)
                        'au.DNI = reader.GetString(8)
                        'au.FECHA_NAC = reader.GetDateTime(9)
                        'au.GENERO = reader.GetString(10)
                        'au.EMAIL = reader.GetString(11)
                        'au.DIRECCION = reader.GetString(12)
                        'au.DEPARTAMENTO = reader.GetString(13)
                        'au.PROVINCIA = reader.GetString(14)
                        'au.DISTRITO = reader.GetString(15)
                        'au.TELEFONO = reader.GetString(16)
                        'au.FOTO = reader.GetByte(17)
                        'au.ESTADO = reader.GetString(18)
                        'au.FECHA_INS = reader.GetDateTime(19)
                        'au.FECHA_UPD = reader.GetDateTime(20)
                        'au.FECHA_DEL = reader.GetDateTime(21)
                    End While
                    'If reader = 1 Then
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
