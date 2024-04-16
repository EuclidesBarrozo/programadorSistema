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
    public partial class CadastrarCurriculo : Form
    {
        public CadastrarCurriculo()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Curriculo curriculo         = new Curriculo();
            curriculo.nome              = tbxNome.Text;
            curriculo.telefone          = tbxTelefone.Text;
            curriculo.dataNascimento    = dtpDataNascimento.Text;
            curriculo.escolaridade      = cbxEscolaridade.Text;
            curriculo.profissao1        = tbxProfissao1.Text;
            curriculo.profissao2        = tbxProfissao2.Text;
            curriculo.curso1            = tbxCurso1.Text;
            curriculo.curso2            = tbxCurso2.Text;

            Banco.inserirCurriculo(curriculo);
        }
    }
}
