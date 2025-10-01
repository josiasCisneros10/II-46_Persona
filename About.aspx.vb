Public Class About
    Inherits Page
    Public persona As New Persona()

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

    End Sub

    Protected Sub btn_guardar_click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        persona.Nombre = txt_nombre.Text
        persona.Apellido = txt_apellido.Text
        lbl_mensaje.Text = persona.Nombre + " " + persona.Apellido
    End Sub
End Class
