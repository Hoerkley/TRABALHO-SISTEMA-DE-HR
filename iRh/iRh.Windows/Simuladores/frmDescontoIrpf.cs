using iRh.Windows.Core;
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
    public partial class frmDescontoIrpf : Form
    {
        public frmDescontoIrpf()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtSalarioIrrf.Text))
            {

                MessageBox.Show("Informe seu salário base por favor!!!", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSalarioIrrf.Focus();
                return;
            }

            try
            {
                const double descontoSimplificado = 528.00;
                var salarioLiquido =  double.Parse(txtSalarioIrrf.Text);
                var salario = salarioLiquido - descontoSimplificado - Inss.Calcula(salarioLiquido);
                var desconto = Irrf.Calcula(salario);

                if(desconto <= 0)
                {
                    lblResultado.Text = desconto.ToString("Você está isento do imposto de renda");
                    panel1.Visible = true;
                }
                else
                {
                    lblResultado.Text = desconto.ToString("C");
                    panel1.Visible = true;
                }
                
            }

            catch (Exception)
            {
                MessageBox.Show("Informe um valor valido por favor!!!, ex: 3500", "erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void txtSalarioIrrf_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnCalcular_Click(sender, e);
            }
        }
    }
}
