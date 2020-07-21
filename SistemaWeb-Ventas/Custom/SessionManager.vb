Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Web.SessionState
Imports CapaEntidad

Public Class SessionManager

#Region "VARIABLES"
    Private _currentSession As HttpSessionState
#End Region

    Public Sub New(ByVal session As HttpSessionState)
        Me._currentSession = session
    End Sub

#Region "MÉTODOS"
    Private ReadOnly Property CurrentSession As HttpSessionState
        Get
            Return Me._currentSession
        End Get
    End Property

    Public Property UserSessionId As String
        Set(ByVal value As String)
            CurrentSession("UserSessionId") = value
        End Set
        Get
            Return CStr(CurrentSession("UserSessionId"))
        End Get
    End Property

    Public Property UserSessionUsuario As CE_Usuario
        Set(ByVal value As CE_Usuario)
            CurrentSession("UserSessionUsuario") = value
        End Set
        Get
            Return CType(CurrentSession("UserSessionUsuario"), CE_Usuario)
        End Get
    End Property
#End Region
End Class
