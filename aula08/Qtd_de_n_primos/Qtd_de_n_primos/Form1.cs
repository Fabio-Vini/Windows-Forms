using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qtd_de_n_primos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = 2;
            int Nprimos = int.Parse(txtQtd.Text);

            if (num < 2)
            {
                MessageBox.Show("Sem solucões...");
            }

            for(int i = 2; i <= Math.Sqrt(num); i++)
            {
                if(num % i == 0)
                {
                    MessageBox.Show("Sem solucões...");
                }
            }
            return true;
        }
    }
}
