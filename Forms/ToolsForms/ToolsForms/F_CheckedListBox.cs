using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToolsForms
{
    public partial class F_CheckedListBox : Form
    {
        public F_CheckedListBox()
        {
            InitializeComponent();
        }

        private void btnMostrarSlecionados_Click(object sender, EventArgs e)
        {
            string txt = "";

            foreach (string s in clbCursos.CheckedItems) 
            {
                txt += s + ", ";
            }
            MessageBox.Show(txt);
        }

        private void btnLimparLista_Click(object sender, EventArgs e)
        {
            clbCursos.Items.Clear();
        }

        private void btnAdicionarCurso_Click(object sender, EventArgs e)
        {
            if(tbxAdicionarCurso.Text != "")
            {
                clbCursos.Items.Add(tbxAdicionarCurso.Text, false);
                tbxAdicionarCurso.Clear();
                tbxAdicionarCurso.Focus();
            }
            
        }
    }
}
