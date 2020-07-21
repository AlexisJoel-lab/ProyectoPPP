
Imports System.Data
Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Web.Security
Public Class Login
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Me.Page.User.Identity.IsAuthenticated Then
            Response.Redirect(FormsAuthentication.DefaultUrl)
        End If
    End Sub
    Protected Sub ValidateUser(sender As Object, e As EventArgs)
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()
        Dim userId As Integer = 0
        Dim constr As String = ConfigurationManager.ConnectionStrings("DefaultConnection").ConnectionString
        Using con As New SqlConnection(constr)
            Using cmd As New SqlCommand("Validate_User")
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@Username", username)
                cmd.Parameters.AddWithValue("@Password", password)
                cmd.Connection = con
                con.Open()
                userId = Convert.ToInt32(cmd.ExecuteScalar())
                con.Close()
            End Using
            Select Case userId
                Case -1
                    dvMessage.Visible = True
                    lblMessage.Text = "El usuario y / o contraseña es incorrecto."
                    Exit Select
                Case -2
                    dvMessage.Visible = True
                    lblMessage.Text = "La cuenta no ha sido activada."
                    Exit Select
                Case Else
                    If Not String.IsNullOrEmpty(Request.QueryString("ReturnUrl")) Then
                        FormsAuthentication.SetAuthCookie(username, chkRememberMe.Checked)
                        Response.Redirect(Request.QueryString("ReturnUrl"))
                    Else
                        FormsAuthentication.RedirectFromLoginPage(username, chkRememberMe.Checked)
                    End If
                    Exit Select
            End Select
        End Using
    End Sub
End Class
