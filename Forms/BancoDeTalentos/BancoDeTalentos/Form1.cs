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
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string usuario = tbxUsuario.Text;
            string senha   = tbxSenha.Text;
            Usuario u1 = new Usuario();

            if(usuario == u1.getUsuario() && senha == u1.getSenha()) 
            {
                Dashboard d1 = new Dashboard(usuario);
                d1.ShowDialog();
            }
            else
            {
                lblMensagem.Text = "Usuário ou Senha incorreto";
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
