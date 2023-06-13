﻿using iRh.Windows.Core;
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

        private void CarrgarEstados()
        {
            var estado = new Estados();
            var listaEstados = estado.ObterTodosEstados();

            cmbEstados.Items.Clear();
            cmbEstados.DataSource = listaEstados;
            cmbEstados.DisplayMember = "Sigla";
            cmbEstados.ValueMember = "Id";
        }
    }
}
