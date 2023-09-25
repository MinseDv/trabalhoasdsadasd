Public Class frmlogin

    Private Sub Btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btncancelar.Click
        Me.Close()
    End Sub

    Private Sub btnentrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnentrar.Click
        If Txtsenha.Text = "123456" Then
        Else
            msgBox("Senha Invalida!!!", vbCritical, "Erro")
            Txtnome = ""
            Txtsenha = ""
            Txtsenha.Focus()
        End If
    End Sub



End Class