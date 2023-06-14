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
    public partial class frmBeneficioFerias : Form
    {
        public frmBeneficioFerias()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSalario.Text))
            {
                MessageBox.Show("Informe as horaspor favor!!!", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSalario.Focus();
                return;
            }

            try
            {
                var salario = double.Parse(txtSalario.Text);
                double divisor = 3;
                var inss = Inss.Calcula(salario);
                var irrf = Irrf.Calcula(salario);

                var tercoFerias = salario / divisor;
                var total = salario + tercoFerias;
                var totalReceber = total - inss - irrf;
                var ferias = totalReceber - salario;

                lblResultado.Text = ferias.ToString("C");
                panelResultado.Visible = true;

            }
            catch (Exception)
            {
                MessageBox.Show("Informe um valor valido por favor!!!, ex: 3500", "erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void txtSalario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCalcular_Click(sender, e);
            }
        }
    }
}
