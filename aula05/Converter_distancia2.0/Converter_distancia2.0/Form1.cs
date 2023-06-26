using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Converter_distancia2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            double valor = 0, 
                   km = 0, 
                   ml = 0, 
                   p = 0;
            
            valor = double.Parse(txtValor.Text);

            km = valor / 1000;
            ml = valor / 1609;
            p = valor * 3.281;

            lblKm.Text = km.ToString();
            lblM.Text = ml.ToString();
            lblP.Text = p.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtValor.Focus();
            txtValor.Text = "";
            lblKm.Text = "";
            lblM.Text = "";
            lblP.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
