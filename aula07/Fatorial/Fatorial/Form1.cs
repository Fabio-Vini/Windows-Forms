using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fatorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double valor = double.Parse(txtValor.Text);
            double fatorial = valor;

            for (double i = valor - 1; i >= 1; i--)
            {
                fatorial = fatorial * i;

                MessageBox.Show("O fatorial é: " + fatorial);
            }
        }
    }
}
