using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkLabel_ListBox
{
    public partial class Form1 : Form
    {
        List<string> cursos = new List<string>();

        public Form1()
        {
            InitializeComponent();
            cursos.Add("HTML");
            cursos.Add("CSS");
            cursos.Add("JAVASCRIPT");
            cursos.Add("PHP");

            lbxCursos.DataSource = cursos;
        }

        private void llGoogle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.google.com");
        }

        private void llCalculadora_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if(tbxCurso.Text == "")
            {
                MessageBox.Show("Digitar um curso");
                tbxCurso.Focus();
            }
            else
            {
                //Adicioner o texto da caixa de texto na lista cursos
                cursos.Add(tbxCurso.Text);
                //Limpar a caixa de texto
                tbxCurso.Clear();
                //posicionar o cursor na caixa de texto
                tbxCurso.Focus();
                //Limpar o listbox
                lbxCursos.DataSource = null;
                //preencher o listbox com a lista cursos atualizada
                lbxCursos.DataSource = cursos;
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            //Remove da lista cursos o curso selecionado no listbox
            //com base no índice
            cursos.RemoveAt(lbxCursos.SelectedIndex);
            //Limpar o listbox
            lbxCursos.DataSource = null;
            //preencher o listbox com a lista cursos atualizada
            lbxCursos.DataSource = cursos;
        }

        private void btnObter_Click(object sender, EventArgs e)
        {
            //preenche o textbox com o valor da lista que está na 
            //posição do item selecionado no listbox
            tbxCurso.Text = cursos[lbxCursos.SelectedIndex];
        }
    }
}
