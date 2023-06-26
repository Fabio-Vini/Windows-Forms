using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalarioHorista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double qtd_trab = 0, vlr_hora = 0, result = 0;
            string selecione;
            
            selecione = cb_selecione.SelectedItem.ToString();

            qtd_trab = double.Parse(mskTextBox1.Text);
            vlr_hora = double.Parse(mskTextBox2.Text);

            if (selecione == "Horista")
            {
                result = qtd_trab * vlr_hora;
                MessageBox.Show("Resultado: R$" + result);
            }
            else if(selecione == "Professor")
            {
                result = (qtd_trab * vlr_hora) * 1.25;
                MessageBox.Show("Resultado: R$" + result);
            }
        }

        private void cb_selecione_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
