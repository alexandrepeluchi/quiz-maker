Imports MySql.Data.MySqlClient

Public Class Form1
    Private conexao As New MySqlConnection
    Private objBD As New DB
    Private instrucao As String

    Private Sub CriaTabelaMateria()
        Try
            objBD.AbrirConexao(conexao)
            Try
                instrucao = "CREATE TABLE IF NOT EXISTS Materia(CodMateria INTEGER AUTO_INCREMENT PRIMARY KEY, " +
                            "NomeMateria VARCHAR(40))"
                objBD.ExecutaSQL(conexao, instrucao)
            Catch ex As Exception
                MessageBox.Show("Erro no SQL")
            End Try
            objBD.FecharConexao(conexao)
        Catch ex As Exception
            MessageBox.Show("Erro na Conexão")
        End Try
    End Sub

    Private Sub CriaTabelaQuestao()
        Try
            objBD.AbrirConexao(conexao)
            Try
                instrucao = "CREATE TABLE IF NOT EXISTS Questao(CodQuestao INTEGER AUTO_INCREMENT PRIMARY KEY, " +
                            "CodMateria INTEGER, Enunciado VARCHAR(500), Alternativa1 VARCHAR(100), Alternativa2 VARCHAR(100), Alternativa3 VARCHAR(100), Alternativa4 VARCHAR(100))"
                objBD.ExecutaSQL(conexao, instrucao)
            Catch ex As Exception
                MessageBox.Show("Erro no SQL")
            End Try
            objBD.FecharConexao(conexao)
        Catch ex As Exception
            MessageBox.Show("Erro na Conexão")
        End Try
    End Sub

    Private Sub CriaTabelaImagem()
        Try
            objBD.AbrirConexao(conexao)
            Try
                instrucao = "CREATE TABLE IF NOT EXISTS Imagem(CodQuestao INTEGER AUTO_INCREMENT PRIMARY KEY, " +
                            "CaminhoImagem VARCHAR(100))"
                objBD.ExecutaSQL(conexao, instrucao)
            Catch ex As Exception
                MessageBox.Show("Erro no SQL")
            End Try
            objBD.FecharConexao(conexao)
        Catch ex As Exception
            MessageBox.Show("Erro na Conexão")
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CriaTabelaMateria()
        CriaTabelaQuestao()
        CriaTabelaImagem()
    End Sub
End Class
