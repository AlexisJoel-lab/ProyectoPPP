Imports System.Data.SqlClient
Imports CapaDatos
Imports CapaEntidad

Public Class SiteMaster
    Inherits MasterPage

    Private cnn As CD_Conexion = New CD_Conexion()
    Private leer As SqlDataReader
    Private tabla As DataTable = New DataTable()
    Private cmd As SqlCommand = New SqlCommand()

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            If Session("UserSessionUsuario") IsNot Nothing Then
                Dim objCE_Usuario As CE_Usuario = CType(Session("UserSessionUsuario"), CE_Usuario)
                lblUserName.Text = objCE_Usuario.USUARIO
                lblUserName2.Text = objCE_Usuario.USUARIO
            End If
        End If
    End Sub

    Protected Sub mostrarMenu()

    End Sub

End Class