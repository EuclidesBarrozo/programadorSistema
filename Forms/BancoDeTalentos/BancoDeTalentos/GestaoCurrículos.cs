using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoDeTalentos
{
    public partial class GestaoCurrículos : Form
    {
        Curriculo c = new Curriculo();

        public GestaoCurrículos()
        {
            InitializeComponent();
        }

        private void GestaoCurrículos_Load(object sender, EventArgs e)
        {
            dgvCurriculos.DataSource = Banco.ObterTodosCurriculos();
            dgvCurriculos.Columns[0].Width = 50;
        }

        //Evento é acionado quando clicado 2X na célula
        private void dgvCurriculos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //sender traz o objeto que está associado ao evento
            DataGridView dgv = (DataGridView)sender;
            //SelectedRows (linhas selecionadas), count (contar)
            int contlinhas = dgv.SelectedRows.Count;
            //verifica se foi selecionado alguma linha
            if (contlinhas > 0) {
                DataTable dt = new DataTable();

                //string vid = dgv.SelectedRows[0].Cells[0].Value.ToString();
                //insere o valor do id no atributo id da classe curriculo
                c.id = Convert.ToInt32(dgv.SelectedRows[0].Cells["id"].Value);
                //passa a informação do datagriedview para o formulário
                tbxNome.Text = dgv.SelectedRows[0].Cells["nome"].Value.ToString();
                tbxTelefone.Text = dgv.SelectedRows[0].Cells["telefone"].Value.ToString();
                dtpDataNascimento.Text = dgv.SelectedRows[0].Cells["data de nascimento"].Value.ToString();
                cbxEscolaridade.Text = dgv.SelectedRows[0].Cells["escolaridade"].Value.ToString();
                tbxProfissao1.Text = dgv.SelectedRows[0].Cells["profissão 1"].Value.ToString();
                tbxProfissao2.Text = dgv.SelectedRows[0].Cells["profissão 2"].Value.ToString();
                tbxCurso1.Text = dgv.SelectedRows[0].Cells["curso 1"].Value.ToString();
                tbxCurso2.Text = dgv.SelectedRows[0].Cells["curso 2"].Value.ToString();

                // dt = Banco.ObterDadosCurriculo(vid);
                /*
                tbxNome.Text = dt.Rows[0].Field<string>("nome").ToString();
                tbxTelefone.Text = dt.Rows[0].Field<string>("telefone").ToString();
                dtpDataNascimento.Text = dt.Rows[0].Field<string>("dataNascimento").ToString();
                cbxEscolaridade.Text = dt.Rows[0].Field<string>("escolaridade").ToString();
                tbxProfissao1.Text = dt.Rows[0].Field<string>("profissao1").ToString();
                tbxProfissao2.Text = dt.Rows[0].Field<string>("profissao2").ToString();
                tbxCurso1.Text = dt.Rows[0].Field<string>("curso1").ToString();
                tbxCurso2.Text = dt.Rows[0].Field<string>("curso2").ToString();
                */
            }
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            c.nome              = tbxNome.Text;
            c.telefone          = tbxTelefone.Text;
            c.dataNascimento    = dtpDataNascimento.Text;
            c.escolaridade      = cbxEscolaridade.Text;
            c.profissao1        = tbxProfissao1.Text;
            c.profissao2        = tbxProfissao2.Text;
            c.curso1            = tbxCurso1.Text;
            c.curso2            = tbxCurso2.Text;
            Banco.AlterarCurriculo(c);
            dgvCurriculos.DataSource = Banco.ObterTodosCurriculos();

        }

        private void dgvCurriculos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
