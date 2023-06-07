using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iRh.Windows.Simuladores
{
    public partial class frmBeneficioPis : Form
    {
        public frmBeneficioPis()
        {
            InitializeComponent();
        }

        private void txtSalario_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if(string.IsNullOrEmpty(txtSalario.Text))
                {
                    MessageBox.Show("Informe as horaspor favor!!!", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSalario.Focus();
                    return;
                }

                try
                {
                    double porcentagem1 = 0.075; double primeiroValor = 1100;
                    double porcentagem2 = 0.09;  double segundoValor = 2100;
                    double porcentagem3 = 0.1;   double terceirovalor = 3200;
                    double porcentagem4 = 0.11;  double quartoValor = 4300;

                    var salario = double.Parse(txtSalario.Text);
                    double pis = 0;
                    if (salario <= primeiroValor)
                    {
                        pis = salario * porcentagem1;
                    }
                    else if(salario <= segundoValor)
                    {
                        pis = salario * porcentagem2;
                    }
                    else if(salario <= terceirovalor)
                    {
                        pis = salario * porcentagem3;
                    }
                    else if(salario <= quartoValor)
                    {
                        pis = salario * porcentagem4;
                    }
                    else
                    {
                        pis = 474.07;
                    }

                    lblResultado.Text = pis.ToString("C");
                    panelResultado.Visible = true;
                    
                }
                catch (Exception)
                {
                    MessageBox.Show("Informe um valor valido por favor!!!, ex: 3500", "erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
