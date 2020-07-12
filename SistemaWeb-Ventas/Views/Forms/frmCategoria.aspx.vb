Imports CapaEntidad
Imports CapaNegocio
Public Class frmCategoria
    Inherits System.Web.UI.Page

    Private objetoCE_Categoria As CE_Categoria = New CE_Categoria()
    Private objetoCN_Categoria As CN_Categoria = New CN_Categoria()
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Try
            objetoCE_Categoria.DESCRIPCION = txtCategoria.Text
            objetoCN_Categoria.N_InsertarCategoria(objetoCE_Categoria)
            MsgBox("Se guardó correctamente")

        Catch ex As Exception
            MsgBox("No se pudo guardar los datos por: " & ex.Message)
        End Try
    End Sub

    Protected Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        txtCategoria.Text = ""
        txtCategoria.Focus()
    End Sub
End Class