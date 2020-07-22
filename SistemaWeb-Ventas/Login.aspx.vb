Imports System.Data.SqlClient
Imports CapaDatos
Imports CapaEntidad
Imports CapaNegocio

Public Class Login1
    Inherits BasePage
    'Inherits System.Web.UI.Page

    Dim objetoCN_Usuario As CN_Usuario = New CN_Usuario()
    Dim objetoCE_Active As CE_ActiveUser = New CE_ActiveUser()

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'If Me.Page.User.Identity.IsAuthenticated Then
        '    Response.Redirect(FormsAuthentication.DefaultUrl)
        'End If

        If Not Page.IsPostBack Then
            Session("UserSession") = Nothing
        End If
    End Sub

    Protected Sub LoginUser_Authenticate(ByVal sender As Object, ByVal e As AuthenticateEventArgs)
        'Dim auth As Boolean = Membership.ValidateUser(LoginUser.UserName, LoginUser.Password)

        'If auth Then
        Dim objE_Usuario As CE_Usuario = objetoCN_Usuario.Login(LoginUser.UserName, LoginUser.Password)

            If objE_Usuario IsNot Nothing Then
                Dim SessionManager As SessionManager = New SessionManager(Session)
                SessionManager.UserSessionUsuario = objE_Usuario
                FormsAuthentication.RedirectFromLoginPage(LoginUser.UserName, False)
            Else
                Response.Write("<script>alert('USUARIO INCORRECTO.')</script>")
            End If
        'End If
    End Sub
End Class