using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Divisores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = int.Parse(txtNumero.Text);
            int qtdDivisores = 0;

            for(int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    qtdDivisores++;
                    System.Windows.Forms.MessageBox.Show("Estes são os divisores: " + i);
                }
            }
            lblDivisores.Text = "O número " + num + " possui " + qtdDivisores + " divisores.";

            if (qtdDivisores == 2)
            {
                lblPrimo.Text = "O número " + num + " é primo.";
            }
            else
            {
                lblPrimo.Text = "O número " + num + " não é primo.";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtNumero.Clear();
            txtNumero.Focus();
            lblDivisores.Text = "";
            lblPrimo.Text = "";
        }
    }
}
