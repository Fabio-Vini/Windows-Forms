using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro
{
    public partial class Form1 : Form
    {
        int QtdM = 0, QtdF = 0;
        string nome, sexo;
        float salario = 0, total = 0;

        private void button2_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtNome.Focus();
            mskSalario.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtNome.Focus();
            mskSalario.Text = "";
            lstFunc.Items.Clear();
            lstSalario.Items.Clear();
            lstSexo.Items.Clear();

            lblHomem.Text = string.Empty;
            lblMulher.Text = string.Empty;
            lblSalario.Text = string.Empty;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            nome  = txtNome.Text;
            sexo = cbSexo.Text;

            
            salario = float.Parse(mskSalario.Text);

            lstFunc.Items.Add(nome);
            lstSexo.Items.Add(sexo);
            lstSalario.Items.Add(salario);

            total = total + salario;

            if(sexo == "Masculino")
            {
                QtdM++;
            }
            else if(sexo == "Feminino")
            {
                QtdF++;
            }
            else
            {
                MessageBox.Show("Nenhum sexo cadastrado!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Número de homens: "+QtdM);
            MessageBox.Show("Número de mulheres: "+QtdF);
            MessageBox.Show("Salário Total: "+total);

            lblHomem.Text = QtdM.ToString();
            lblMulher.Text = QtdF.ToString();
            lblSalario.Text = total.ToString();
        }
    }
}
