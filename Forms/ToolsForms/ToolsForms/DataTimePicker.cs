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
    public partial class DataTimePicker : Form
    {
        public DataTimePicker()
        {
            InitializeComponent();
        }

        private void btnObterData_Click(object sender, EventArgs e)
        {
            tbxData.Text = dtpData.Text; 
            tbxDia.Text  = dtpData.Value.Day.ToString();
            tbxMes.Text  = dtpData.Value.Month.ToString();
            tbxAno.Text  = dtpData.Value.Year.ToString();
        }

        private void btnSetarData_Click(object sender, EventArgs e)
        {
            int d, m, a;
            d = Convert.ToInt32(tbxDia.Text);
            m = Convert.ToInt32(tbxMes.Text);
            a = Convert.ToInt32(tbxAno.Text);

            DateTime dt = new DateTime(a, m, d);

            dtpData.Value = dt;
        }
    }
}
