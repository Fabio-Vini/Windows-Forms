using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Converter_comboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            double valor = 0,
                   convert = 0;

            string selecione;

            valor = double.Parse(txtValor.Text);

            selecione = cbSelecione.SelectedItem.ToString();

            if (selecione == "Quilômetros")
            {
                convert = valor / 1000;
                MessageBox.Show("Em quilômetros: " + convert);
            }
            else if (selecione == "Milhas")
            {
                convert = valor / 1609;
                MessageBox.Show("Em Milhas: " + convert);
            }
            else if (selecione == "Pés")
            {
                convert = valor * 3.281;
                MessageBox.Show("Em Pés: " + convert);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtValor.Text = "";
            txtValor.Focus();
        }
    }
}
