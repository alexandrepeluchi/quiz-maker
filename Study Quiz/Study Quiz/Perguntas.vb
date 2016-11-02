Imports MySql.Data.MySqlClient

Public Class Perguntas
    Private conexao As New MySqlConnection
    Private objBD As New DB
    Private instrucao As String
    Private cod As Integer
    Private enunciado As String
    Private materia As Integer

    Private Sub DescobreQuestao()
        Dim armazena
        Try
            objBD.AbrirConexao(conexao)
            Try
                'MessageBox.Show(materia)
                instrucao = "SELECT Enunciado FROM Questao WHERE CodMateria = '" + +"'"
                armazena = objBD.ExecutaSelect(conexao, instrucao)
                armazena.Read()
                Label1.Text = armazena("Enunciado").ToString()
            Catch ex As Exception
                MessageBox.Show("Erro no SQL")
            End Try
            objBD.FecharConexao(conexao)
        Catch ex As Exception
            MessageBox.Show("Erro na Conexão")
        End Try
    End Sub

    Private Sub Perguntas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        DescobreQuestao()
    End Sub
End Class