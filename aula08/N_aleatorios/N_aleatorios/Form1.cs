using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N_aleatorios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random aleatorio = new Random();

            int inicio = 1, final = 100, resultado = 0;
            int limite = int.Parse(txtQtd.Text);

            for (int i = 0; i <= limite - 1; i++)
            {
                resultado = aleatorio.Next(inicio, final);

                lstNumeros.Items.Add(resultado);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtQtd.Text = "";
            txtQtd.Focus();
            lstNumeros.Items.Clear();
        }
    }
}
