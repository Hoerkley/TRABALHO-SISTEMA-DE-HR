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
            CarrgarEstados();
            CarregarDocuentos();
        }

        private void CarrgarEstados()
        {
            var estado = new Estados();
            var listaEstados = estado.ObterTodosEstados();
            var estadosAz = listaEstados.OrderBy(x => x.Sigla).ToList();

            cmbEstados.Items.Clear();
            cmbEstados.DataSource = estadosAz;
            cmbEstados.DisplayMember = "Nome";
            cmbEstados.ValueMember = "Sigla";
        }

        private void CarregarDocuentos()
        {
            var documento = new Documentos();
            var listaDocumentos = documento.ObterDocumentos();
            var documentosAz = listaDocumentos.OrderBy(x => x.Nome).ToList();

            cmbIdentificacao.Items.Clear();
            cmbIdentificacao.DataSource = documentosAz;
            cmbIdentificacao.DisplayMember = "Nome";
            cmbIdentificacao.ValueMember = "Id";
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            var cepDigitado = txtCep.Text;
            var endereco = new Endereco();
            if (txtCep.Text.Length < 9)
            {
                txtCep.Clear();
                MessageBox.Show("Por favor informe um CEP valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCep.Focus();
                return;
            }

            endereco = endereco.ObterCep(cepDigitado);
            if (endereco.Erro == true)
            {
                txtCep.Clear();
                MessageBox.Show("Por favor informe um CEP valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCep.Focus();
                return; ;
            }
           
            txtBairro.Text = endereco.Bairro;
            txtCep.Text = endereco.Cep;
            txtCidade.Text = endereco.Localidade;
            txtDdd.Text = endereco.Ddd;
            txtLogradouro.Text = endereco.Logradouro;
            cmbEstados.SelectedValue = endereco.Uf;

           if(txtBairro.Text != "")
            {
                txtBairro.ReadOnly = true;
                txtBairro.Enabled = false;
                txtDdd.ReadOnly = true;
                txtDdd.Enabled = false;
                cmbEstados.Enabled = false;
                txtCidade.ReadOnly = true;
                txtCidade.Enabled = false;
                txtLogradouro.ReadOnly = true;
                txtLogradouro.Enabled = false ;

            }
           else 
           {
                txtDdd.ReadOnly = true;
                txtDdd.Enabled = false;
                cmbEstados.Enabled = false;
                txtCidade.ReadOnly = true;
                txtCidade.Enabled = false;
            }
        
            
        }

        private void lblWhatsapp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://api.whatsapp.com/send?phone=" + txtDdd + txtTelefone.Text + "&text=Ol%C3%A1%2C%20como%20posso%20te%20ajudar%3F");
        }
    }
}


