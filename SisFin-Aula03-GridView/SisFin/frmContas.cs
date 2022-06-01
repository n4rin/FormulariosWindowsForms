﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisFin
{
    public partial class frmContas : Form
    {
        private int id;
        private string nome;
        private string descricao;
        private int categoria;
        private int status;

        private List<Conta> _lstConta = new List<Conta>();
        private List<Categoria> _lstCategoria = new List<Categoria>();

        private Conta conta = new Conta();
        private BindingSource bsConta = new BindingSource();

        public frmContas()
        {
            InitializeComponent();
            _lstConta = Conta.GeraContas();
            _lstCategoria = (new Categoria()).GeraCategorias();
        }

        private void frmContas_Load(object sender, EventArgs e)
        {
            txtNome.Enabled = false;
            txtDesc.Enabled = false;
            chkBoxStatus.Checked = true;

            dgContas.ColumnCount = 5;
            dgContas.AutoGenerateColumns = false;
            dgContas.Columns[0].Width = 50;
            dgContas.Columns[0].HeaderText = "ID";
            dgContas.Columns[0].DataPropertyName = "Id";
            dgContas.Columns[0].Visible = false;
            dgContas.Columns[1].Width = 200;
            dgContas.Columns[1].HeaderText = "NOME";
            dgContas.Columns[1].DataPropertyName = "Nome";
            dgContas.Columns[2].Width = 200;
            dgContas.Columns[2].HeaderText = "DESCRIÇÃO";
            dgContas.Columns[2].DataPropertyName = "Descricao";
            dgContas.Columns[3].Width = 50;
            dgContas.Columns[3].HeaderText = "TIPO";
            dgContas.Columns[3].DataPropertyName = "Tipo";
            dgContas.Columns[4].Width = 50;
            dgContas.Columns[4].HeaderText = "STATUS";
            dgContas.Columns[4].DataPropertyName = "Status";

            dgContas.AllowUserToAddRows = false;
            dgContas.AllowUserToDeleteRows = false;
            dgContas.MultiSelect = false;
            dgContas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            carregaGridContas();
        }

        private void carregaGridContas()
        {
            bsConta = new BindingSource();
            bsConta.DataSource = _lstConta;
            //dgContas.Rows.Clear();
            dgContas.DataSource = bsConta;
            dgContas.Refresh();
        }
    }
}
