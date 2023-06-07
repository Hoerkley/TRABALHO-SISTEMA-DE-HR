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
    public partial class frmBeneficioSeguroDesemprego : Form
    {
        public frmBeneficioSeguroDesemprego()
        {
            InitializeComponent();
        }

        private void txtMesesEmpregado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(txtMesesEmpregado.Text))
                {
                    MessageBox.Show("Informe as horaspor favor!!!", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMesesEmpregado.Focus();
                    return;
                }
                try
                {
                    double primeiraSolicitacao = 12; double cincoParcelas = 24;
                    double segundaSolicitacao = 9; double quatroParcelas = 11;
                    double terciraSolicitacao = 6; double tresPareclas = 23;
                    var mesesTrabalhados = double.Parse(txtMesesEmpregado.Text);

                    if (chkJustaCausa.Checked == true)
                    {
                        if (chkRendaPropria.Checked == false)
                        {
                            if (chkBeneficio.Checked == true)
                            {
                                panelSolicitacao.Visible = true;

                                if(rbSolicitacao1.Checked == true)
                                {
                                    if(mesesTrabalhados >= primeiraSolicitacao)
                                    {
                                        if(mesesTrabalhados >= primeiraSolicitacao & mesesTrabalhados > cincoParcelas)
                                        {
                                            lblResultado.Text = "Tem direito a 5 parcelas do benefício";
                                        }
                                        else
                                        {
                                            lblResultado.Text = "Tem direito a 4 parcelas do benefício";
                                        }
                                    }
                                    else
                                    {
                                        lblResultado.Text = "Não tem direito ao seguro desemprengo!!";
                                        panelResultado.Visible = true;
                                    }
                                }
                                
                                else if(rbSolicitacao2.Checked == true)
                                {
                                    if(mesesTrabalhados >= segundaSolicitacao)
                                    {
                                        if(mesesTrabalhados > segundaSolicitacao & mesesTrabalhados > tresPareclas)
                                        {
                                            lblResultado.Text = "Tem direito a 5 parcelas do benefício";
                                        }
                                        else if(mesesTrabalhados > primeiraSolicitacao & mesesTrabalhados > quatroParcelas)
                                        {
                                            lblResultado.Text = "Tem direito a 4 parcelas do benefício";
                                        }
                                        else
                                        {
                                            lblResultado.Text = "Tem direito a 3 parcelas do benefício";
                                        }
                                    }
                                    else
                                    {
                                        lblResultado.Text = "Não tem direito ao seguro desemprengo!!";
                                        panelResultado.Visible = true;
                                    }
                                }

                                else if(rbSolicitacao3.Visible == true)
                                {
                                    if(mesesTrabalhados >= terciraSolicitacao)
                                    {
                                        if(mesesTrabalhados >= cincoParcelas)
                                        {
                                            lblResultado.Text = "Tem direito a 5 parcelas do benefício";
                                        }
                                    }
                                    else
                                    {
                                        lblResultado.Text = "Não tem direito ao seguro desemprengo!!";
                                        panelResultado.Visible = true;
                                    }
                                }
                                else
                                {
                                    lblResultado.Text = "Não tem direito ao seguro desemprengo!!";
                                    panelResultado.Visible = true;
                                }
                            }
                            else
                            {
                                lblResultado.Text = "Não tem direito ao seguro desemprengo!!";
                                panelResultado.Visible = true;
                            }
                        }
                        else
                        {
                            lblResultado.Text = "Não tem direito ao seguro desemprengo!!";
                            panelResultado.Visible = true;
                        }
                    }
                    else
                    {
                        lblResultado.Text = "Não tem direito ao seguro desemprengo!!";
                        panelResultado.Visible = true;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Informe um valor valido por favor!!!, ex: 3500", "erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
