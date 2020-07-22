Imports CapaEntidad
Imports CapaDatos
Imports CapaNegocio
Imports System.Data.SqlClient

Public Class frmCliente
    Inherits System.Web.UI.Page

    Private objetoCN As CN_Cliente = New CN_Cliente()
    Private objetoCE As CE_Cliente = New CE_Cliente()


    Dim idClientes As String = Nothing

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cargarTabla()
    End Sub

    Protected Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            objetoCE.NOMBRE = txtNombre.Text
            objetoCE.APE_PATERNO = txtApePaterno.Text
            objetoCE.APE_MATERNO = txtApeMaterno.Text
            objetoCE.DNI = txtDNI.Text
            If rbtMales.Checked = True Then
                objetoCE.GENERO = "M"
            ElseIf rbtFemale.Checked = True Then
                objetoCE.GENERO = "F"
            End If
            objetoCE.TELEFONO = txtTelefono.Text
            objetoCE.DIRECCION = txtDireccion.Text
            objetoCE.EMAIL = txtEmail.Text
            objetoCE.ESTADO = cbEstado.SelectedValue
            objetoCN.N_InsertarCli(objetoCE)
            MsgBox("Se guardó correctamente")

            limpiarControles()
            cargarTabla()
        Catch ex As Exception
            MsgBox("No se pudo guardar los datos por: " & ex.Message)
        End Try
    End Sub

    'Protected Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
    '    limiarControles()
    'End Sub

    Private Sub limpiarControles()
        txtNombre.Text = ""
        txtApePaterno.Text = ""
        txtApeMaterno.Text = ""
        txtDNI.Text = ""
        rbtMales.Checked = False
        rbtFemale.Checked = False
        txtTelefono.Text = ""
        txtDireccion.Text = ""
        txtEmail.Text = ""
        cbEstado.SelectedIndex = 0
        txtNombre.Focus()
    End Sub
    Private Sub cargarTabla()
        tblCliente.DataSource = objetoCN.N_MostrarCli()
        tblCliente.DataBind()
    End Sub

    Protected Sub tblCliente_RowDeleting(sender As Object, e As GridViewDeleteEventArgs) Handles tblCliente.RowDeleting
        Try
            Dim rpt As Byte
            rpt = MsgBox("¿Estás seguro de eliminar este registro?", vbYesNo, "Eliminar")
            If rpt = vbYes Then
                objetoCE.ID_CLIENTE = Convert.ToInt32(tblCliente.SelectedRow.Cells("ID_CLIENTE").ToString())
                objetoCN.N_EliminarCli(objetoCE)
                MsgBox("Eliminado correctamente")
                cargarTabla()
            End If
        Catch ex As Exception
            MsgBox("Seleccione una fila por favor: " + ex.Message)
        End Try
    End Sub

    Protected Sub tblCliente_RowEditing(sender As Object, e As GridViewEditEventArgs) Handles tblCliente.RowEditing
        Try
            txtNombre.Text = tblCliente.SelectedRow.Cells("Nombre").ToString()
            txtApePaterno.Text = tblCliente.SelectedRow.Cells("APE_PATERNO").ToString()
            txtApeMaterno.Text = tblCliente.SelectedRow.Cells("APE_MATERNO").ToString()
            txtDNI.Text = tblCliente.SelectedRow.Cells("DNI").ToString()
            If objetoCE.GENERO = 1 Then
                rbtMales.Checked = True
            ElseIf objetoCE.GENERO = 0 Then
                rbtFemale.Checked = True
            End If
            txtTelefono.Text = tblCliente.SelectedRow.Cells("TELEFONO").ToString()
            txtDireccion.Text = tblCliente.SelectedRow.Cells("DIRECCION").ToString()
            txtEmail.Text = tblCliente.SelectedRow.Cells("EMAIL").ToString()
            cbEstado.SelectedIndex = tblCliente.SelectedRow.Cells("ESTADO").ToString()
            idClientes = tblCliente.SelectedRow.Cells("ID_CLIENTE").ToString()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


End Class