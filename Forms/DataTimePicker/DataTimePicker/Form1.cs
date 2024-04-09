using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataTimePicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnObterData_Click(object sender, EventArgs e)
        {
            tbxData.Text = dtpData.Text;
            tbxDia.Text = dtpData.Value.Day.ToString();
            tbxMes.Text = dtpData.Value.Month.ToString();
            tbxAno.Text = dtpData.Value.Year.ToString();
        }

        private void btnAlterarData_Click(object sender, EventArgs e)
        {
            int d, m, a;

            d = Convert.ToInt32(tbxDia.Text);
            m = Convert.ToInt32(tbxMes.Text);
            a = Convert.ToInt32(tbxAno.Text);

            DateTime dt = new DateTime(a, m, d);

            dtpData.Text = dt.ToString();
        }
    }
}
