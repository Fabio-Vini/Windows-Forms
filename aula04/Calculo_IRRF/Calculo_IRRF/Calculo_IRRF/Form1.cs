using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculo_IRRF
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
                   desconto_inss = 0, 
                   salario_liquido = 0, 
                   subtracao = 0, 
                   percentual = 0, 
                   deducao = 0;

            salario_bruto = double.Parse(mskSalario.Text);

            if (salario_bruto <= 1045)
            {
                desconto_inss = salario_bruto * 0.075;
                salario_liquido = salario_bruto - desconto_inss;
            }
            else if (salario_bruto <= 2089.60)
            {
                desconto_inss = salario_bruto * 0.09;
                salario_liquido = salario_bruto - desconto_inss;    
            }
            else if (salario_bruto <= 3134.40)
            {
                desconto_inss = salario_bruto * 0.12;
                salario_liquido = salario_bruto - desconto_inss;
            }
            else if (salario_bruto <= 6101.06)
            {
                desconto_inss = salario_bruto * 0.14;
                salario_liquido = salario_bruto - desconto_inss;
            }


            if (salario_bruto < 1903.99)
            {
                MessageBox.Show("Você está isento do IRRF");
            }
            else if (salario_bruto >= 1903.99 & salario_bruto <= 2826.65)
            {
                subtracao = salario_bruto - desconto_inss;
                percentual = subtracao * 0.075;
                deducao = 142.80 - percentual;
                salario_liquido = salario_bruto - (deducao + desconto_inss);

                MessageBox.Show("Salário: R$" +salario_bruto+ "\nDesconto INSS: R$" +desconto_inss+ "\nDesconto IRRF: R$" +deducao+ "\nSalário líquido: R$" +salario_liquido);
            }
            else if (salario_bruto >= 2826.66 & salario_bruto <= 3751.05)
            {
                subtracao = salario_bruto - desconto_inss;
                percentual = subtracao * 0.15;
                deducao = (354.80 - percentual);
                salario_liquido = salario_bruto - (deducao + desconto_inss);

                MessageBox.Show("Salário: R$" + salario_bruto + "\nDesconto INSS: R$" + desconto_inss + "\nDesconto IRRF: R$" + deducao + "\nSalário líquido: R$" + salario_liquido);
            }
            else if (salario_bruto >= 3751.06 & salario_bruto <= 4664.68 )
            {
                subtracao = salario_bruto - desconto_inss;
                percentual = subtracao * 0.225;
                deducao = 636.13 - percentual;
                salario_liquido = salario_bruto - (deducao + desconto_inss);

                MessageBox.Show("Salário: R$" + salario_bruto + "\nDesconto INSS: R$" + desconto_inss + "\nDesconto IRRF: R$" + deducao + "\nSalário líquido: R$" + salario_liquido);
            }
            else if (salario_bruto > 4664.68)
            {
                subtracao = salario_bruto - desconto_inss;
                percentual = subtracao * 0.275;
                deducao = percentual - 869.3;
                salario_liquido = salario_bruto - (deducao + desconto_inss);

                MessageBox.Show("Salário: R$" + salario_bruto + "\nDesconto INSS: R$" + desconto_inss + "\nDesconto IRRF: R$" + deducao + "\nSalário líquido: R$" + salario_liquido);
            }
        }
    }
}
