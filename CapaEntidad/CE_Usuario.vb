Public Class CE_Usuario
#Region "CAMPOS"
    Private _ID_USUARIO As Integer
    Private _CODIGO As String
    Private _FK_ID_ROL As String
    Private _USUARIO As String
    Private _CONTRASEÑA As String
    Private _NOMBRE As String
    Private _APE_PATERNO As String
    Private _APE_MATERNO As String
    Private _DNI As String
    Private _FECHA_NAC As Date
    Private _GENERO As String
    Private _EMAIL As String
    Private _DIRECCION As String
    Private _DEPARTAMENTO As String
    Private _PROVINCIA As String
    Private _DISTRITO As String
    Private _TELEFONO As String
    Private _FOTO As Byte
    Private _ESTADO As String
    Private _ELIM_LOGICO As Integer
    Private _FECHA_INS As DateTime
    Private _FECHA_UPD As DateTime
    Private _FECHA_DEL As DateTime
#End Region
#Region "PROPIEDADES"
    Public Property ID_USUARIO As Integer
        Get
            Return _ID_USUARIO
        End Get
        Set(value As Integer)
            _ID_USUARIO = value
        End Set
    End Property

    Public Property FK_ID_ROL As String
        Get
            Return _FK_ID_ROL
        End Get
        Set(value As String)
            _FK_ID_ROL = value
        End Set
    End Property

    Public Property CODIGO As String
        Get
            Return _CODIGO
        End Get
        Set(value As String)
            _CODIGO = value
        End Set
    End Property

    Public Property USUARIO As String
        Get
            Return _USUARIO
        End Get
        Set(value As String)
            _USUARIO = value
        End Set
    End Property

    Public Property CONTRASEÑA As String
        Get
            Return _CONTRASEÑA
        End Get
        Set(value As String)
            _CONTRASEÑA = value
        End Set
    End Property

    Public Property NOMBRE As String
        Get
            Return _NOMBRE
        End Get
        Set(value As String)
            _NOMBRE = value
        End Set
    End Property

    Public Property APE_PATERNO As String
        Get
            Return _APE_PATERNO
        End Get
        Set(value As String)
            _APE_PATERNO = value
        End Set
    End Property

    Public Property APE_MATERNO As String
        Get
            Return _APE_MATERNO
        End Get
        Set(value As String)
            _APE_MATERNO = value
        End Set
    End Property

    Public Property DNI As String
        Get
            Return _DNI
        End Get
        Set(value As String)
            _DNI = value
        End Set
    End Property

    Public Property FECHA_NAC As Date
        Get
            Return _FECHA_NAC
        End Get
        Set(value As Date)
            _FECHA_NAC = value
        End Set
    End Property

    Public Property GENERO As String
        Get
            Return _GENERO
        End Get
        Set(value As String)
            _GENERO = value
        End Set
    End Property

    Public Property EMAIL As String
        Get
            Return _EMAIL
        End Get
        Set(value As String)
            _EMAIL = value
        End Set
    End Property

    Public Property DIRECCION As String
        Get
            Return _DIRECCION
        End Get
        Set(value As String)
            _DIRECCION = value
        End Set
    End Property

    Public Property DEPARTAMENTO As String
        Get
            Return _DEPARTAMENTO
        End Get
        Set(value As String)
            _DEPARTAMENTO = value
        End Set
    End Property

    Public Property PROVINCIA As String
        Get
            Return _PROVINCIA
        End Get
        Set(value As String)
            _PROVINCIA = value
        End Set
    End Property

    Public Property DISTRITO As String
        Get
            Return _DISTRITO
        End Get
        Set(value As String)
            _DISTRITO = value
        End Set
    End Property

    Public Property TELEFONO As String
        Get
            Return _TELEFONO
        End Get
        Set(value As String)
            _TELEFONO = value
        End Set
    End Property

    Public Property FOTO As Byte
        Get
            Return _FOTO
        End Get
        Set(value As Byte)
            _FOTO = value
        End Set
    End Property

    Public Property ESTADO As String
        Get
            Return _ESTADO
        End Get
        Set(value As String)
            _ESTADO = value
        End Set
    End Property

    Public Property ELIM_LOGICO As Integer
        Get
            Return _ELIM_LOGICO
        End Get
        Set(value As Integer)
            _ELIM_LOGICO = value
        End Set
    End Property

    Public Property FECHA_INS As Date
        Get
            Return _FECHA_INS
        End Get
        Set(value As Date)
            _FECHA_INS = value
        End Set
    End Property

    Public Property FECHA_UPD As Date
        Get
            Return _FECHA_UPD
        End Get
        Set(value As Date)
            _FECHA_UPD = value
        End Set
    End Property

    Public Property FECHA_DEL As Date
        Get
            Return _FECHA_DEL
        End Get
        Set(value As Date)
            _FECHA_DEL = value
        End Set
    End Property
#End Region
    Public Sub New()
    End Sub

    Public Sub New(ID_USUARIO As Integer, CODIGO As String, FK_ID_ROL As String, USUARIO As String, CONTRASEÑA As String,
                   NOMBRE As String, APE_PATERNO As String, APE_MATERNO As String, DNI As String,
                   FECHA_NAC As Date, GENERO As String, EMAIL As String, DIRECCION As String,
                   DEPARTAMENTO As String, PROVINCIA As String, DISTRITO As String, TELEFONO As String,
                   FOTO As Byte, ESTADO As String, ELIM_LOGICO As Integer, FECHA_INS As Date, FECHA_UPD As Date,
                   FECHA_DEL As Date)
        _ID_USUARIO = ID_USUARIO
        _CODIGO = CODIGO
        _FK_ID_ROL = FK_ID_ROL
        _USUARIO = USUARIO
        _CONTRASEÑA = CONTRASEÑA
        _NOMBRE = NOMBRE
        _APE_PATERNO = APE_PATERNO
        _APE_MATERNO = APE_MATERNO
        _DNI = DNI
        _FECHA_NAC = FECHA_NAC
        _GENERO = GENERO
        _EMAIL = EMAIL
        _DIRECCION = DIRECCION
        _DEPARTAMENTO = DEPARTAMENTO
        _PROVINCIA = PROVINCIA
        _DISTRITO = DISTRITO
        _TELEFONO = TELEFONO
        _FOTO = FOTO
        _ESTADO = ESTADO
        _ELIM_LOGICO = ELIM_LOGICO
        _FECHA_INS = FECHA_INS
        _FECHA_UPD = FECHA_UPD
        _FECHA_DEL = FECHA_DEL
    End Sub
End Class
