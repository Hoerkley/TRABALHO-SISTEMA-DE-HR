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
            var documentosAz = listaDocumentos.OrderBy(x => x.Name).ToList();

            cmbIdentificacao.Items.Clear();
            cmbIdentificacao.DataSource = documentosAz;
            cmbIdentificacao.DisplayMember = "Name";
            cmbIdentificacao.ValueMember = "Id";
        }
    }
}
