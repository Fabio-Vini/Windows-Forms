using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desconto_INSS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double salario_bruto = 0,
                   salario_liquido = 0,
                   desconto_inss = 0,
                   qtd_trab = 0, 
                   vlr_hora = 0,
                   result = 0;

            salario_bruto = double.Parse(mskTextBox1.Text);

            string selecione;

            selecione = cb_selecione.SelectedItem.ToString();
            qtd_trab = double.Parse(mskTextBox2.Text);
            vlr_hora = double.Parse(mskTextBox3.Text);

            if (selecione == "Horista")
            {
                result = qtd_trab * vlr_hora;
                MessageBox.Show("Salário horista: R$" + result);
            }
            else if (selecione == "Professor")
            {
                result = (qtd_trab * vlr_hora) * 1.25;
                MessageBox.Show("Salário professor: R$" + result);
            }

            ////////////////////////////////////////////////////

            if (salario_bruto <= 1045)
            {
                desconto_inss = salario_bruto * 0.075;
                salario_liquido = salario_bruto - desconto_inss;

                MessageBox.Show("Salário: R$" + salario_bruto + "\nValor descontado: R$" + desconto_inss + "\nSalário líquido: R$" + salario_liquido);
            }
            else if (salario_bruto <= 2089.60)
            {
                desconto_inss = salario_bruto * 0.09;
                salario_liquido = salario_bruto - desconto_inss;

                MessageBox.Show("Salário: R$" + salario_bruto + "\nValor descontado: R$" + desconto_inss + "\nSalário líquido: R$" + salario_liquido);
            }
            else if (salario_bruto <= 3134.40)
            {
                desconto_inss = salario_bruto * 0.12;
                salario_liquido = salario_bruto - desconto_inss;

                MessageBox.Show("Salário: R$" + salario_bruto + "\nValor descontado: R$" + desconto_inss + "\nSalário líquido: R$" + salario_liquido);
            }
            else if (salario_bruto <= 6101.06)
            {
                desconto_inss = salario_bruto * 0.14;
                salario_liquido = salario_bruto - desconto_inss;

                MessageBox.Show("Salário: R$" + salario_bruto + "\nValor descontado: R$" + desconto_inss + "\nSalário líquido: R$" + salario_liquido);
            }
        }
    }
}
