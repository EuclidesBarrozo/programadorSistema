using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cbxSQL_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCursosEscolhidos_Click(object sender, EventArgs e)
        {
            string txt = "";

            if (cbxCSharp.Checked) 
            {
                txt += cbxCSharp.Text + ", ";
            }
            if (cbxSQL.Checked)
            {
                txt += cbxSQL.Text + ", ";
            }
            if (cbxC.Checked)
            {
                txt += cbxC.Text + ", ";
            }
            if (cbxPython.Checked)
            {
                txt += cbxPython.Text + ", ";
            }
            if(txt.Length > 0) 
            {
                txt = txt.Remove(txt.Length - 2, 2);
            }
            else
            {
                txt = "Selecione um curso";
            }
            MessageBox.Show(txt);
        }

        private void cbxHTML_CheckedChanged(object sender, EventArgs e)
        {
            if(cbxHTML.Checked) 
            {
                MessageBox.Show(cbxHTML.Text);
            }
            

        }

        private void btnMostrarSelecionados_Click(object sender, EventArgs e)
        {
            string txt = "";
            
            foreach(string curso in clbCursos.CheckedItems)
            {
                txt += curso + ", ";
            }
            MessageBox.Show(txt);

        }

        private void btnLimparLista_Click(object sender, EventArgs e)
        {
            clbCursos.Items.Clear();
        }

        private void btnAdicionarCurso_Click(object sender, EventArgs e)
        {
            if(txtCurso.Text != "")
            {
                clbCursos.Items.Add(txtCurso.Text, false);
                txtCurso.Clear();
                txtCurso.Focus();
            }
        }
    }
}
