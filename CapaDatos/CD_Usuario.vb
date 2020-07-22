Imports CapaEntidad
Imports System.Data.SqlClient

Public Class CD_Usuario

    Private cnn As CD_Conexion = New CD_Conexion()
    Private us As CE_Usuario = New CE_Usuario()
    Private dr As SqlDataReader
    Private prm As SqlParameter = New SqlParameter()

    Public Function Login(user As String, pass As String) As CE_Usuario
        Using connection = cnn.AbrirConexion()
            Using cmd = New SqlCommand()
                cmd.Connection = connection
                cmd.CommandText = "sp_UsuarioValidar"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@USUARIO", user)
                cmd.Parameters.AddWithValue("@CONTRASENIA", pass)
                dr = cmd.ExecuteReader()
                If dr.HasRows Then
                    While dr.Read() 'Obtenemos los datos de la columna y asignamos a los campos de usuario activo en cache'
                        us.ID_USUARIO = Convert.ToInt32(dr("ID_USUARIO").ToString())
                        'us.CODIGO = dr.GetString(1)
                        'us.FK_ID_ROL = dr.GetString(2)
                        us.USUARIO = dr("USUARIO").ToString()
                        us.CONTRASENIA = dr("CONTRASENIA").ToString()
                        'au.NOMBRE = reader.GetString(5)
                        'au.APE_PATERNO = reader.GetString(6)
                        'au.APE_MATERNO = reader.GetString(7)
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
                    dr.Dispose()
                    Return us
                Else
                    Return us
                End If
            End Using
        End Using
    End Function
End Class
