using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMC_maskedtextboxes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnIMC_Click(object sender, EventArgs e)
        {
            double altura = 0, peso = 0, imc = 0;

            altura = double.Parse(mskAltura.Text);
            peso = double.Parse(mskPeso.Text);

            imc = peso / Math.Pow(altura, 2);
            lblResultado.Text = imc.ToString();

            if (imc < 20)
            {
               /* pictureBox.Image = imageList.Images[1];*/
                MessageBox.Show("Você está abaixo do peso");
            }
            else if (20 <= imc & imc < 25)
            {
               /* pictureBox.Image = imageList.Images[2];*/
                MessageBox.Show("Está no peso ideal!");
            }
            else
            {
                /*pictureBox.Image = imageList.Images[0];*/
                MessageBox.Show("Você está acima do peso!");
            }
        }
    }
}
