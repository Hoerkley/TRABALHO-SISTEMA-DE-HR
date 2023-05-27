using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iRh.Windows.Cadastros
{
    public partial class frmFuncionarios : Form
    {
        public frmFuncionarios()
        {
            InitializeComponent();
        }

        private void frmFuncionarios_Load(object sender, EventArgs e)
        {
            rbTemFilhosNao.Checked = true;         
        }

        private void rbTemFilhosSim_CheckedChanged(object sender, EventArgs e)
        {
            panelExibeDadosFilhos.Visible = true;
        }

        private void rbTemFilhosNao_CheckedChanged(object sender, EventArgs e)
        {
            panelExibeDadosFilhos.Visible = false;
        }      

        private void txtFilhoDataNascimento_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                try
                {
                    var dataNascimento = DateTime.Parse(txtFilhoDataNascimento.Text);
                    var anoAtual = DateTime.Now.Year;
                    lblIdade.Text = (anoAtual - dataNascimento.Year).ToString();
                    lblIdade.Visible = true;
                }
               
                catch(Exception ex)
                {
                    MessageBox.Show("A data de nascimento parece estra errada!!, detalhamento: " + ex.Message + MessageBoxIcon.Error);
                }
            }
        }
        private string comprimentador(int opcaoSelecionada)
        {
            switch(opcaoSelecionada)
            {
                case 1: return "presado, senhor";
                case 2: return "preseada, senhora";

                default:
                    return "presades, senhores";
            }           
        }
    }
}
