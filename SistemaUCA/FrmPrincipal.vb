Public Class FrmPrincipal
    Sub mostrarHora()
        LblHora.Text = DateTime.Now.ToString("hh:mm:ss")
    End Sub

    Private Sub TmrAux_Tick(sender As Object, e As EventArgs) Handles TmrAux.Tick
        mostrarHora()
    End Sub

    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TmrAux.Enabled = True
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        MsgBox("Registro guardado correctamente", MsgBoxStyle.Information, "Sistema UCA")
        BtnLimpiar.PerformClick()
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        TxtNombre.Clear()
        TxtApellido.Clear()
        TxtVisita.Clear()
        TxtNombre.Focus()
    End Sub
End Class