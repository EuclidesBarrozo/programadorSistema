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
    public partial class Dashboard : Form
    {
        public Dashboard(string usuario)
        {
            InitializeComponent();
            lblMensagem.Text = "Bem-vindo " + usuario;

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void currículoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarCurriculo c = new CadastrarCurriculo();
            c.ShowDialog();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
