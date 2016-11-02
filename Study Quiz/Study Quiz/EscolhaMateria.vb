Public Class EscolhaMateria
    Dim pergunta As Perguntas

    Private Sub btnVoltar_Click(sender As Object, e As EventArgs) Handles btnVoltar.Click
        Inicio.Show()
        Me.Close()
    End Sub

    Private Sub btnAC_Click(sender As Object, e As EventArgs) Handles btnAC.Click
        Dim resultado
        resultado = MessageBox.Show("Iniciar Quiz apartir da matéria, Arquitetura de Computadores?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (resultado = vbYes) Then
            abrirFechar()
            pergunta.SelecionaMateria(1)
        End If

    End Sub

    Private Sub abrirFechar()
        Perguntas.Show()
        Me.Hide()
    End Sub
End Class