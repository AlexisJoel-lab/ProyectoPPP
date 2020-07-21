Imports CapaEntidad
Imports CapaNegocio
Public Class frmMarca
    Inherits System.Web.UI.Page
    Private objetoCE_Marca As CE_Marca = New CE_Marca()
    Private objetoCN_Marca As CN_Marca = New CN_Marca()

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Try
            objetoCE_Marca.DESCRIPCION = txtMarca.Text
            objetoCN_Marca.N_InsertarMarca(objetoCE_Marca)
            MsgBox("Se guardó correctamente")

        Catch ex As Exception
            MsgBox("No se pudo guardar los datos por: " & ex.Message)
        End Try
    End Sub

    Protected Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        txtMarca.Text = ""
        txtMarca.Focus()
    End Sub
End Class