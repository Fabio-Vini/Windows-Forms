using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        List<double> numeros = new List<double>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num;
            if (double.TryParse(textBox1.Text, out num))
            {
                numeros.Add(num);
                listBox1.Items.Add(num);
                textBox1.Clear();
                textBox1.Focus();
            }
            else
            {
                MessageBox.Show("Insira um número válido.");
                textBox1.Clear();
                textBox1.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (numeros.Count > 0)
            {
                double maior = numeros[0];
                double menor = numeros[0];
                double soma = 0;

                foreach (double num in numeros)
                {
                    if (num > maior)
                    {
                        maior = num;
                    }

                    if (num < menor)
                    {
                        menor = num;
                    }

                    soma += num;
                }

                double media = soma / numeros.Count;

                MessageBox.Show("Maior número: " + maior.ToString() + "\nMenor número: " + menor.ToString() + "\nMédia: " + media.ToString());
            }
            else
            {
                MessageBox.Show("A lista está vazia.");
            }
        }
    }
}
