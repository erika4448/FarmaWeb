Public Class PagMaestra
    Inherits System.Web.UI.Page
    Public Enum EnmEstado
        Activo = 1
        Inactivo = 2
        Todos = 0
    End Enum

    Public Sub LlenarListaDesplegable(ByVal parCombo As DropDownList, ByVal parTabla As Data.DataTable, ByVal parNomValue As String, ByVal parNomText As String)
        parCombo.DataSource = parTabla
        parCombo.DataValueField = parNomValue
        parCombo.DataTextField = parNomText
        parCombo.DataBind()
        parCombo.Items.Add(New ListItem("Seleccione", 0))
        parCombo.SelectedValue = 0
    End Sub
    Public Sub MostrarMensaje(ByVal parStrKey As String, ByVal parStrMensaje As String)
        parStrMensaje = Replace(parStrMensaje, "'", "")
        parStrMensaje = Replace(parStrMensaje, vbCrLf, " - ")
        ScriptManager.RegisterStartupScript(Me.Page, Me.GetType(), parStrKey, String.Format("alert('{0}');", parStrMensaje), True)
    End Sub
End Class