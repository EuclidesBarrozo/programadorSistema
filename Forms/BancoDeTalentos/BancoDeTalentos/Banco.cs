using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;

namespace BancoDeTalentos
{
    class Banco
    {
        //atributo
        private static SQLiteConnection conexao;
        
        //métod ConexaoBanco
        private static SQLiteConnection ConexaoBanco()
        {
            //Criar um conexao do tipo SQLiteConnect
            //linkado ao arquivo banco.db
            conexao = new SQLiteConnection("Data Source = ..\\..\\..\\banco\\banco.db");
            //abrindo a conexão
            conexao.Open();
            //retorna para o arquivo que o chamou a conexao
            return conexao;
        }

        public static DataTable ObterTodosUsuarios()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    cmd.CommandText = "Select * FROM t_usuarios";
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

        //método consulta que recebe uma string com o comando sql
        //e retornar uma tabela de dados
        public static DataTable consulta(string sql)
        {
            //adaptador de dados inciado com null
            SQLiteDataAdapter da = null;
            //objeto da classe DataTable (tabela de dados) 
            DataTable dt = new DataTable();
            //tentar realizar os conmandos dentro do try
            try
            {
                //Cria um escopo que ao final de sua execução libera
                //recursos automaticamente através do método Dispose()
                //cria um objeto do tipo comando
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    //preencher o comando com a string sql
                    cmd.CommandText = sql;
                    //criar um SQLiteDataAdapter usando o comando e a conexão
                    //e salva em da
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
    }
}
