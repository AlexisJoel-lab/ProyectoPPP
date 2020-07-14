Public Class CE_Categoria

#Region "CAMPOS"
    Private _ID_CATEGORIA As Integer
    Private _CODIGO As String
    Private _DESCRIPCION As String
    Private _ELIM_LOGICO As Integer
    Private _FECHA_INS As DateTime
    Private _FECHA_UPD As DateTime
    Private _FECHA_DEL As DateTime
#End Region

#Region "PROPIEDADES"
    Public Property ID_CATEGORIA As Integer
        Get
            Return _ID_CATEGORIA
        End Get
        Set(value As Integer)
            _ID_CATEGORIA = value
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

    Public Property DESCRIPCION As String
        Get
            Return _DESCRIPCION
        End Get
        Set(value As String)
            _DESCRIPCION = value
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
    Public Sub New(ID_CATEGORIA As Integer, CODIGO As String, DESCRIPCION As String, ELIM_LOGICO As Integer,
                   FECHA_INS As Date, FECHA_UPD As Date, FECHA_DEL As Date)
        _ID_CATEGORIA = ID_CATEGORIA
        _CODIGO = CODIGO
        _DESCRIPCION = DESCRIPCION
        _ELIM_LOGICO = ELIM_LOGICO
        _FECHA_INS = FECHA_INS
        _FECHA_UPD = FECHA_UPD
        _FECHA_DEL = FECHA_DEL
    End Sub
End Class
