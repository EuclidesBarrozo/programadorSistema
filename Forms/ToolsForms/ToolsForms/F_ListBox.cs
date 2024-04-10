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
    public partial class F_ListBox : Form
    {
        List<string> cursos = new List<string>();

        public F_ListBox()
        {
            InitializeComponent();
            cursos.Add("HTML");
            cursos.Add("CSS");
            cursos.Add("JAVASCRIPT");
            cursos.Add("PHP");

            lbxCursos.DataSource = cursos;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(tbxCurso.Text == "") 
            {
                MessageBox.Show("Digite um curso");
                tbxCurso.Focus();
            }
            else
            {
                cursos.Add(tbxCurso.Text);
                tbxCurso.Clear();
                tbxCurso.Focus();
                lbxCursos.DataSource = null;
                lbxCursos.DataSource = cursos;
            }
        }

        private void lbxCursos_Load(object sender, EventArgs e)
        {

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            cursos.RemoveAt(lbxCursos.SelectedIndex);
            lbxCursos.DataSource = null;
            lbxCursos.DataSource = cursos;
        }

        private void btnObter_Click(object sender, EventArgs e)
        {
            tbxCurso.Text = cursos[lbxCursos.SelectedIndex];
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            cursos.Clear();
            lbxCursos.DataSource = cursos;
        }
    }
}
