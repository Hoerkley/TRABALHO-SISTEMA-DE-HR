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
    public partial class frmBeneficioHoraExtra : Form
    {
        public frmBeneficioHoraExtra()
        {
            InitializeComponent();
        }

        private void frmBeneficioHoraExtra_Load(object sender, EventArgs e)
        {
            rbDiasUteisNao.Checked = true;
            rbDomingosFeriadosNao.Checked = true;
        }

        private void rbDomingosFeriadosSim_CheckedChanged(object sender, EventArgs e)
        {
            panelDomngosFeriados.Visible = true;
        }

        private void rbDiasUteisSim_CheckedChanged(object sender, EventArgs e)
        {
            panelDiasUteis.Visible = true;
        }

        private void rbDiasUteisNao_CheckedChanged(object sender, EventArgs e)
        {
            panelDiasUteis.Visible = false;
        }

        private void rbDomingosFeriadosNao_CheckedChanged(object sender, EventArgs e)
        {
            panelDomngosFeriados.Visible = false;
        }

        public void btnCalcular_Click(object sender, EventArgs e)
        {
           if(string.IsNullOrEmpty(txtSalarioHoraExtra.Text))
            {
                MessageBox.Show("Informe seu salário base por favor!!!", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSalarioHoraExtra.Focus();
                return;
            }

            try
            {
                var salario = double.Parse(txtSalarioHoraExtra.Text);                         
                double valorHora = salario / 220;

                if (rbDomingosFeriadosSim.Checked == true)
                {
                    if(rbDiasUteisSim.Checked == true)
                    {
                        var horasDomingosFeriados = double.Parse(txtHoraDomingosFeriados.Text);
                        var horasDiasUteis = double.Parse(txtHoraDiasUteis.Text);

                        var valorHoraExtra100 = valorHora * 2;
                        var valorTotal100 = valorHoraExtra100 * horasDomingosFeriados;

                        var valorHora50 = valorHora * 0.5;
                        var valorTotal50 = valorHora50 * horasDiasUteis;

                        var horaExtra = valorTotal100 + valorHora50;

                        lblResultado.Text = horaExtra.ToString("C");
                        panelResutado.Visible = true;
                    }
                    else
                    {
                        var horasDomingosFeriados = double.Parse(txtHoraDomingosFeriados.Text);

                        var valorHoraExtra100 = valorHora * 2;
                        var valorTotal100 = valorHoraExtra100 * horasDomingosFeriados;

                        lblResultado.Text = valorTotal100.ToString("C");
                        panelResutado.Visible = true;
                    }
                    
                }
                else
                {
                    var horasDiasUteis = double.Parse(txtHoraDiasUteis.Text);
                    var valorHora50 = valorHora * 0.5;
                    var valorTotal50 = valorHora50 * horasDiasUteis;

                    lblResultado.Text = valorTotal50.ToString("C");
                    panelResutado.Visible = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Informe um valor valido por favor!!!, ex: 3500", "erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtSalarioHoraExtra_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnCalcular_Click(sender, e);
            }
        }

        private void txtHoraDomingosFeriados_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCalcular_Click(sender, e);
            }
        }

        private void txtHoraDiasUteis_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCalcular_Click(sender, e);
            }
        }
    }
}
