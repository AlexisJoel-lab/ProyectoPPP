Public Class CE_ActiveUser
#Region "CAMPOS"
    Private _ID_USUARIO As Integer
    Private _FK_ID_ROL As Integer
    Private _USUARIO As String
    Private _CONTRASEÑA As String
    Private _NOMBRE As String
    Private _APE_PATERNO As String
    Private _APE_MATERNO As String
    Private _EMAIL As String
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

    Public Property FK_ID_ROL As Integer
        Get
            Return _FK_ID_ROL
        End Get
        Set(value As Integer)
            _FK_ID_ROL = value
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

    Public Property EMAIL As String
        Get
            Return _EMAIL
        End Get
        Set(value As String)
            _EMAIL = value
        End Set
    End Property
#End Region
    Public Sub New()
    End Sub

    Public Sub New(ID_USUARIO As Integer, FK_ID_ROL As Integer, USUARIO As String, CONTRASEÑA As String,
                   NOMBRE As String, APE_PATERNO As String, APE_MATERNO As String, EMAIL As String)
        _ID_USUARIO = ID_USUARIO
        _FK_ID_ROL = FK_ID_ROL
        _USUARIO = USUARIO
        _CONTRASEÑA = CONTRASEÑA
        _NOMBRE = NOMBRE
        _APE_PATERNO = APE_PATERNO
        _APE_MATERNO = APE_MATERNO
        _EMAIL = EMAIL
    End Sub
End Class
