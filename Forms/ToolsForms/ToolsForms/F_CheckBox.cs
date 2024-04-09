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
    public partial class F_CheckBox : Form
    {
        public F_CheckBox()
        {
            InitializeComponent();
        }

        private void btnLinguagensMarcadas_Click(object sender, EventArgs e)
        {
            String txt = "";
            if(cbCSharp.Checked)
            {
                txt += cbCSharp.Text + ", ";
            }
            if (cbSQL.Checked)
            {
                txt += cbSQL.Text + ", ";
            }
            if (cbC.Checked)
            {
                txt += cbC.Text + ", ";
            }
            if (cbPython.Checked)
            {
                txt += cbPython.Text + ", ";
            }
            if(txt.Length == 0)
            {
                txt = "Selecionar Curso";
            }
            else
            {
                int t = txt.Length;
                txt = txt.Remove(t - 2, 2);
            }
            
            MessageBox.Show(txt);
        }

        private void cbHTML_CheckedChanged(object sender, EventArgs e)
        {
            if(cbHTML.Checked)
            {
                MessageBox.Show("HTML Marcado");
            }
        }
    }
}
