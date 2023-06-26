using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Criptografia_termo_fibonacci
{
    public partial class Form1 : Form
    {
        string msgCripto, msgDescripto, cripto, descripto;
        int aux;

        private int Fibo(int n)
        {
            return (n == 1 || n ==2)?1:Fibo(n-1)+Fibo(n-2);
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            cripto = " ";
            msgCripto = txtMsg.Text;
            txtMsg.Text = string.Empty;

            for (int i = 0; i < msgCripto.Length; ++i)
            {
                aux = (int)msgCripto[i] + Fibo(i + 1);
                cripto += (char)aux;

                txtCripto.Text = cripto;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            descripto = " ";
            msgDescripto = txtMsg2.Text;
            txtMsg2.Text = string.Empty;

            for (int i = 0; i < msgDescripto.Length; ++i)
            {
                aux = msgDescripto[i] - Fibo(i + 1);
                descripto += (char)aux;

                txtDescr.Text = descripto;
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            txtCripto.Clear();
            txtDescr.Clear();
        }
    }
}
