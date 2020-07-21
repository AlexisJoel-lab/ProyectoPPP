Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Services
Imports System.Web.SessionState
Imports CapaEntidad
Imports System.IO
Public Class BasePage
    Inherits System.Web.UI.Page

    Public _sessionManager As SessionManager
    Protected Property SessionManager() As SessionManager
        Get
            Return _sessionManager
        End Get
        Set(value As SessionManager)
            _sessionManager = value
        End Set

    End Property

    Protected Overrides Sub OnPreInit(e As EventArgs)
        MyBase.OnPreInit(e)
        'Session("KEYSTORE") = "0"
        Me._sessionManager = New SessionManager(Session)

    End Sub

    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)
        'If HttpContext.Current.Session("UserSessionUsuario") = Nothing Then
        '    Response.Redirect("~/Views/Account/Login.aspx")

        'Else
        '    Dim permisos = Session("Permisos") As Permiso
        '        If permisos IsNot Nothing Then

        '        Dim pageName As String = Path.GetFileName(Request.Path)
        '        Dim hasMenuPermission = permisos.PMenu.Where(Function(m) m.Url = pageName).Count() > 0
        '        Dim hasSubMenuPermission = permisos.PMenu.Where(Function(m) m.SubMenu.Count > 0).Select(m >= m.SubMenu).Count() > 0
        '        If (Not hasSubMenuPermission AndAlso Not hasMenuPermission) Then
        '            Response.Redirect("BadRequest.aspx")
        '        End If
        '    End If
        'End If
    End Sub

    Protected Overrides Sub OnInit(e As EventArgs)
        MyBase.OnInit(e)
        If HttpContext.Current.Session IsNot Nothing Then
            If Session.IsNewSession Then
                Try
                    Dim cookie As String = Request.Headers("Cookie")
                    If cookie IsNot Nothing AndAlso cookie.IndexOf("ASP.NET_SessionId") >= 0 Then
                        Response.Redirect("~/Login.aspx")
                    End If
                Catch ex As Exception
                    Response.Redirect("~/Login.aspx")
                End Try
            End If
        End If
    End Sub
End Class
