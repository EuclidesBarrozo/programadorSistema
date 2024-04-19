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
    public partial class GestaoCurrículos : Form
    {
        public GestaoCurrículos()
        {
            InitializeComponent();
        }

        private void GestaoCurrículos_Load(object sender, EventArgs e)
        {
            dgvCurriculos.DataSource = Banco.ObterTodosCurriculos();
        }
    }
}
