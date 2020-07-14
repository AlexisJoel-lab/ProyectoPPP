Imports System.Data.SqlClient
Imports CapaDatos
Imports CapaEntidad
Imports CapaNegocio

Public Class Login1
    Inherits System.Web.UI.Page

    Dim objetoCN_Usuario As New CN_Usuario()
    Dim objetoCE_Active As CE_ActiveUser = New CE_ActiveUser()

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
    Protected Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            Dim validLogin = objetoCN_Usuario.Login(txtUser.Text, txtPass.Text)
            If validLogin = True Then
                Session("USUARIO") = validLogin
                Response.Redirect("Default.aspx")
                limpiar()
            Else
                MsgBox("Usuario o contraseña incorrectos." + vbNewLine + "Por favor intente de nuevo.")
                limpiar()
            End If
        Catch ex As Exception
            MsgBox("Error: " + ex.Message)
        End Try
    End Sub
    Private Sub limpiar()
        txtUser.Text = ""
        txtPass.Text = ""
        txtUser.Focus()
    End Sub
End Class