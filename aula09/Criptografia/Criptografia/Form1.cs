using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Criptografia
{
    public partial class Form1 : Form
    {
        string msgCripto, msgDescripto, cripto, descripto;
        int aux;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cripto = " ";
            msgCripto = txtMsg.Text;
            txtMsg.Text = string.Empty;

            for (int i = 0; i < msgCripto.Length; ++i)
            {
                aux = (int)msgCripto[i] + 5;
                cripto += (char)aux;

                txtCripto.Text = cripto;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            descripto = " ";
            msgDescripto = txtMsg2.Text;
            txtMsg2.Text = string.Empty;

            for (int i = 0; i < msgDescripto.Length; ++i)
            {
                aux = (int)msgDescripto[i] - 5;
                descripto += (char)aux;

                txtDescr.Text = descripto;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtCripto.Clear();
            txtDescr.Clear();
        }
    }
}
