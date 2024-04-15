using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoDeTalentos
{
    public partial class Form1 : Form
    {
        //Cria objeto dt da classe DataTable
        //Esse objeto servirá para armazenar as informações
        //que virão do banco de dados
        DataTable dt = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string usuario = tbxUsuario.Text;
            string senha   = tbxSenha.Text;
            if(usuario == "" || senha == "")
            {
                MessageBox.Show("Usuario e ou senha inválido");
                tbxUsuario.Focus();
                return;
            }
            //comando sql para selecionar todas as colunas da tabela usuario
            //onde o usuario e a senha forem iguais as digitadas
            //na tela de login
            string sql = "SELECT * FROM t_usuarios WHERE usuario = '" 
                + usuario + "' AND senha = '" + senha +"'";
            //IDA - chama o método consulta passando a string sql
            //como parâmetro, esse é um método static que
            //pertence a classe Banco
            //VOLTA - retorna a tabela de dados do banco de dados
            //e salva no dt
            dt = Banco.consulta(sql);
            //Conta quantas linhas tem da tabela de dados
            //e verifica se tem uma linha
            if(dt.Rows.Count == 1)
            {
                //Cria um objeto do tipo Dashboard (form) e 
                //passar o usuário como parâmetro
                //dt - tabela de dados
                //Rows[0] - primeira linha
                //ItemArray[1] - segundo (item/coluna) da linha
                Dashboard d = new Dashboard(dt.Rows[0].ItemArray[1].ToString());
                //dt.Rows[0].Field<string>("usuario");
                d.Show();
            }
        }

        

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
