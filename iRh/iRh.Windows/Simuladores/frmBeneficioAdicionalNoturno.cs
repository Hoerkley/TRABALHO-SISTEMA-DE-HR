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
    public partial class frmBeneficioAdicionalNoturno : Form
    {
        public frmBeneficioAdicionalNoturno()
        {
            InitializeComponent();
        }

        private void btnCalcularAdicionalNoturno_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtSalarioAdicionalNoturno.Text))
            {

                MessageBox.Show("Informe seu salário base por favor!!!", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSalarioAdicionalNoturno.Focus();
                return;
            }
            if(string.IsNullOrEmpty(txtHorasTrabalhadas.Text))
            {

                MessageBox.Show("Informe as horaspor favor!!!", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHorasTrabalhadas.Focus();
                return;
            }

            try
            {
                var salario = double.Parse(txtSalarioAdicionalNoturno.Text);
                var horas = double.Parse(txtHorasTrabalhadas.Text);
                var desconto = AdicionalNoturno.Calcula(salario, horas);

                lblResultadoAdicionalNoturno.Text = desconto.ToString("C");
                panelResultado.Visible = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Informe um valor valido por favor!!!, ex: 3500", "erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

       
    }
}
