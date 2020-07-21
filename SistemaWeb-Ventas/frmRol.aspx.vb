Imports CapaEntidad
Imports CapaNegocio
Imports System.Web.Services

Public Class frmRol
    Inherits System.Web.UI.Page

    Private objN_Rol As CN_Rol = New CN_Rol
    Private objetoCE As CE_Rol = New CE_Rol()

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cargarTabla()
    End Sub
    Private Sub cargarTabla()
        tblRol.DataSource = objN_Rol.N_MostrarRol()
        tblRol.DataBind()
    End Sub

    Protected Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            objetoCE.DESCRIPCION = txtDescripcion.Text
            objN_Rol.N_InsertarRol(objetoCE)
            MsgBox("Se guardó correctamente")

            'limiarControles()

        Catch ex As Exception
            MsgBox("No se pudo guardar los datos por: " & ex.Message)
        End Try
    End Sub

    Protected Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Try
            'If tblRol.SelectedRow.c > 0 Then
            '    txtDescripcion.Text = tblRol.CurrentRow.Cells("Nombre").Value.ToString()
            '    idEmpleados = DgvEmpleado.CurrentRow.Cells("Codigo").Value.ToString()

            '    FrmEmpleados.ShowDialog()

            '    'Evento CellContentClick
            '    For i As Int32 = 0 To Me.filas_sel.Count - 1
            '        Me.seleccionarFila(Me.filas_sel(i))
            '    Next
            '    If e.ColumnIndex = 2 Then
            '        Me.filas_sel.Add(e.RowIndex)
            '    End If
            'Else
            '    MsgBox("Seleccione una fila por favor")
            'End If
        Catch ex As Exception
            MsgBox("Error: " + ex.Message)
        End Try
    End Sub

    'Variable visible para toda la clase
    Dim filas_sel As New List(Of Integer)
    'Método para seleccionar una fila
    'Private Sub seleccionarFila(ByVal indice As Int32)
    '    Me.tblRol.Rows(indice).Selected = True
    'End Sub

    Protected Sub tblRol_RowDataBound(sender As Object, e As GridViewRowEventArgs) Handles tblRol.RowDataBound
        If e.Row.RowType = DataControlRowType.DataRow Then
            e.Row.Attributes.Add("OnClick", "" & Page.ClientScript.GetPostBackClientHyperlink(Me.tblRol, "Select$" + e.Row.RowIndex.ToString) & ";")
        End If
    End Sub

    Protected Sub btnElimiar_Click(sender As Object, e As EventArgs) Handles btnElimiar.Click
        Try
            For i As Integer = 0 To tblRol.Rows.Count = 1
                Dim codigo As Label
                codigo = tblRol.Rows(i).FindControl("ckbElegir")
            Next
        Catch ex As Exception
            MsgBox("Error: " + ex.Message)
        End Try
    End Sub
End Class