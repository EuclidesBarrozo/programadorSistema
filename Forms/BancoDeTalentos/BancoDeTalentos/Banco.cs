using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace BancoDeTalentos
{
    class Banco
    {
        //atributo
        private static SQLiteConnection conexao;
        
        //método ConexaoBanco retorna uma conexão da classe SQLiteConnection
        private static SQLiteConnection ConexaoBanco()
        {
            //Criar um conexao do tipo SQLiteConnect
            //linkado ao arquivo banco.db
            conexao = new SQLiteConnection("Data Source = ..\\..\\..\\banco\\bancoDeTalentos.db");
            //abrindo a conexão utilizando o método Open()
            conexao.Open();
            //retorna para o arquivo/método que chamou a conexao
            return conexao;
        }

        public static DataTable ObterTodosCurriculos()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    //dataNascimento as data de nascimento (alias)
                    //para mudar o título da coluna no DataGridView
                    cmd.CommandText = "Select id, nome, telefone, " +
                        "dataNascimento as 'data de nascimento', " +
                        "escolaridade, profissao1 as 'profissão 1', " +
                        "profissao1 as 'profissão 2', curso1 as 'curso 1', " +
                        "curso2 as 'curso 2' FROM t_curriculos";
                    da =  new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
                    da.Fill(dt);
                    ConexaoBanco().Close();
                    return dt;
                }
            }catch (Exception ex)
            {
                ConexaoBanco().Close();
                throw ex;
            }
        }

        public static DataTable ObterDadosCurriculo(string id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    cmd.CommandText = "Select * FROM t_curriculos WHERE id = " + id;
                    da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
                    da.Fill(dt);
                    ConexaoBanco().Close();
                    return dt;
                }
            }
            catch (Exception ex)
            {
                ConexaoBanco().Close();
                throw ex;
            }
        }

        //método consulta que recebe uma string com o comando sql
        //e retornar uma tabela de dados(DataTable)
        public static DataTable consulta(string sql)
        {
            //adaptador de dados inciado com null (formato do SQL)
            SQLiteDataAdapter da = null;
            //objeto da classe DataTable (tabela de dados - formato do C#) 
            DataTable dt = new DataTable();
            //tentar realizar os conmandos dentro do try
            try
            {
                //Cria um escopo que ao final de sua execução libera
                //recursos automaticamente através do método Dispose()
                //cria um objeto do tipo comando
                //ConexaoBanco().CreateCommand() = conexao.CreateCommand()
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    //preencher o comando com a string sql
                    cmd.CommandText = sql;
                    //criar um SQLiteDataAdapter usando o comando e a conexão
                    //faz a pesquisa no banco de dados e salva em da
                    da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
                    //converte de DataAdapter para DataTable e preenche o dt
                    da.Fill(dt);
                    //fecha a conexão
                    ConexaoBanco().Close();
                    //retorna o DataTable dt
                    return dt;
                }
            }
            catch (Exception ex)
            {
                ConexaoBanco().Close();
                //se acontecer algum erro no try exibe a exceção
                throw ex;
            }
        }

        //Funções do Form Currículo
        
        public static void inserirCurriculo(Curriculo c)
        {
            //verificar se já tem um currículo com esse nome
            if (existeNome(c))
            {
                MessageBox.Show("Nome já cadastrado.");
                return;
            }
            try
            {
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    //preencher o comando com a string sql para inserção
                    cmd.CommandText = "INSERT INTO t_curriculos " +
                        "(nome, telefone, dataNascimento, escolaridade, " +
                        "profissao1, profissao2, curso1, curso2) " +
                        "VALUES (@nome, @telefone, @dataNascimento, " +
                        "@escolaridade, @profissao1, @profissao2, @curso1, @curso2)";
                    cmd.Parameters.AddWithValue("@nome", c.nome);
                    cmd.Parameters.AddWithValue("@telefone", c.telefone);
                    cmd.Parameters.AddWithValue("@dataNascimento", c.dataNascimento);
                    cmd.Parameters.AddWithValue("@escolaridade", c.escolaridade);
                    cmd.Parameters.AddWithValue("@profissao1", c.profissao1);
                    cmd.Parameters.AddWithValue("@profissao2", c.profissao2);
                    cmd.Parameters.AddWithValue("@curso1", c.curso1);
                    cmd.Parameters.AddWithValue("@curso2", c.curso2);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Novo currículo salvo!");
                    ConexaoBanco().Close();  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar currículo.");
                ConexaoBanco().Close();
                throw ex;
            }
        }

        public static void AlterarCurriculo(Curriculo c)
        {
            try
            {
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    //preencher o comando com a string sql para inserção
                    cmd.CommandText = "UPDATE t_curriculos SET " +
                        "nome = @nome, telefone = @telefone, dataNascimento = @dataNascimento, " +
                        "escolaridade = @escolaridade, profissao1 = @profissao1, profissao2 = @profissao2, " +
                        "curso1 = @curso1, curso2 = @curso2 WHERE id = @id";
                    cmd.Parameters.AddWithValue("@id", c.id);
                    cmd.Parameters.AddWithValue("@nome", c.nome);
                    cmd.Parameters.AddWithValue("@telefone", c.telefone);
                    cmd.Parameters.AddWithValue("@dataNascimento", c.dataNascimento);
                    cmd.Parameters.AddWithValue("@escolaridade", c.escolaridade);
                    cmd.Parameters.AddWithValue("@profissao1", c.profissao1);
                    cmd.Parameters.AddWithValue("@profissao2", c.profissao2);
                    cmd.Parameters.AddWithValue("@curso1", c.curso1);
                    cmd.Parameters.AddWithValue("@curso2", c.curso2);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Currículo Atualizado!");
                    ConexaoBanco().Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar currículo.");
                ConexaoBanco().Close();
                throw ex;
            }
        }

        //Fim das funções Form Currículo

        //ROTINAS GERAIS
        private static bool existeNome(Curriculo c)
        {
            DataTable dt = null;
            bool res = false;
            string sql = "SELECT nome FROM t_curriculos WHERE nome = '" + 
                c.nome + "'";
            dt = Banco.consulta(sql);
            if (dt.Rows.Count > 0)
            {
                res = true;
            }
            return res;
        }


    }
}
