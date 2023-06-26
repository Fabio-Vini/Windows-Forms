using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maior_numero
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double a = 0, b = 0, c = 0;

            a = double.Parse(txtA.Text);
            b = double.Parse(txtB.Text);
            c = double.Parse(txtC.Text);

            if (a > b & a > c)
            {
                lblResult.Text = ("1º valor: " + a.ToString());
            }
            else if(b > a & b > c)
            {
                lblResult.Text = ("2º valor: " + b.ToString());
            }
            else if (c > a & c > b)
            {
                lblResult.Text = ("3º valor: " + c.ToString());
            }
            else if(a == b & a == c)
            {
                lblResult.Text = ("Há três valores iguais!");
            }
            else if(a == b)
            {
                lblResult.Text = ("1º e 2º");
            }
            else if (a == c)
            {
                lblResult.Text = ("1º e 3º");
            }
            else if(b == c)
            {
                lblResult.Text = ("2º e 3º");
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtA.Focus();
            txtA.Text = "";
            txtB.Text = "";
            txtC.Text = "";
            lblResult.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
