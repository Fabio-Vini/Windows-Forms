using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Termo_n
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double soma = 0, valor = 0;
            int n = int.Parse(valorX.Text);

            for (double x = 1; x <= n; x++)
            {
                valor = x / (x + 1);
                listBox1.Items.Add(x + "º. " + valor);
                soma += valor;

                lblSoma.Text = soma.ToString();
            }
        }
    }
}
