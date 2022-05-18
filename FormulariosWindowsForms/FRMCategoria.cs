using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;

namespace FormulariosWindowsForms
{
    public partial class FRMCategoria : Form
    {
        private Categoria categoria = new Categoria();
        private List<Categoria> lstCategoria = new List<Categoria>();
        private BindingSource bsCategoria;


        private bool Insercao = false;
        private bool Edicao = false;
        private FRMCategoria fCategoria;
        
        public FRMCategoria()
        {
            InitializeComponent();
            lstCategoria = categoria.GeraCategorias();
        }

        public void LimparCampos ()
        {
            txtNome.Clear();
            txtDescricao.Clear();
            rdDespesa.Checked = false;
            rdReceita.Checked = false;
            chkStatus.Checked = false;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FRMCategoria_Load(object sender, EventArgs e)
        {
            dgCategoria.ColumnCount = 5;
            dgCategoria.AutoGenerateColumns = false;
            dgCategoria.Columns[0].Width = 50;
            dgCategoria.Columns[0].HeaderText = "ID";
            dgCategoria.Columns[0].DataPropertyName = "Id";
            dgCategoria.Columns[0].Visible = false;
            dgCategoria.Columns[1].Width = 200;
            dgCategoria.Columns[1].HeaderText = "NOME";
            dgCategoria.Columns[1].DataPropertyName = "Nome";
            dgCategoria.Columns[2].Width = 400;
            dgCategoria.Columns[2].HeaderText = "DESCRIÇÃO";
            dgCategoria.Columns[2].DataPropertyName = "Descricao";
            dgCategoria.Columns[3].Width = 50;
            dgCategoria.Columns[3].HeaderText = "TIPO";
            dgCategoria.Columns[3].DataPropertyName = "Tipo";
            dgCategoria.Columns[4].Width = 50;
            dgCategoria.Columns[4].HeaderText = "STATUS";
            dgCategoria.Columns[4].DataPropertyName = "Status";

            dgCategoria.AllowUserToAddRows = false;
            dgCategoria.AllowUserToDeleteRows = false;
            dgCategoria.MultiSelect = false;
            dgCategoria.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


            txtNome.Text = "Combustivel";
            txtDescricao.Text = "Consumo de combustivel";
            rdDespesa.Checked = true;
            chkStatus.Checked = true;
        }

        public void carregaGridCategoria()
        {
            bsCategoria = new BindingSource();
            bsCategoria.DataSource = lstCategoria;
            dgCategoria.DataSource = bsCategoria;
            dgCategoria.Refresh();
        }

        private void novoRegistro(object sender, EventArgs e)
        {
            GRPCategoria.Enabled = true;
            LimparCampos();
            txtNome.Focus();
            btnAlterar.Enabled = false;
            btnCancelar.Visible = true;
            btnSalvar.Visible = true;
            btnExcluir.Visible = false;
            btnNovo.Enabled = false;
            Insercao = true;
            Edicao = false;
            chkStatus.Checked = true;
        }

        private void btnExcluirClick(object sender, EventArgs e)
        {
            DialogResult myDialog = MessageBox.Show("Confirmar Exclusão ?", "Aviso do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (myDialog == DialogResult.Yes)
            {
                MessageBox.Show("Registro excluído com sucesso", "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            btnNovo.Focus();
        }

        public void fCategoria_Closed(object sender, FormClosedEventArgs e)
        {
           fCategoria = null;
        }

        private void salvarClick(object sender, EventArgs e)
        {
            MessageBox.Show("Registro gravado com sucesso!", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnNovo.Enabled = true; 
            btnNovo.Focus();
            txtNome.Enabled = true;
            txtDescricao.Enabled = true;
            btnAlterar.Enabled = true;
            btnCancelar.Visible = false;
            btnExcluir.Visible = true;
            btnSalvar.Visible = false;
            GRPCategoria.Enabled = false;
            dgCategoria.Enabled = true;
            Insercao = false;
            Edicao = false;


            if (Insercao)
            {

            }

            if (Edicao)
            {
                Categoria ct = lstCategoria.Find(item => item.Nome == txtNome.Text.Trim());
                if(ct != null)
                {
                    ct.Descricao = txtDescricao.Text.Trim();
                    ct.Tipo = rdReceita.Checked ? 1 : 2;
                    ct.Status = chkStatus.Checked ? 1 : 0;
                }
            }
            carregaGridCategoria();

            MessageBox.Show("Registro gravado com sucesso !", "Aviso do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void fechandoForm(object sender, FormClosingEventArgs e)
        {
            if (Edicao || Insercao)
            {
                e.Cancel = true;
                MessageBox.Show("Continue aqui", "Aviso do sistema !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cancelarCat(object sender, EventArgs e)
        {
            btnNovo.Enabled = true;
            btnAlterar.Enabled = true;
            btnSalvar.Visible = false;
            btnCancelar.Visible = false;
            btnExcluir.Visible = true;
            GRPCategoria.Enabled = false;
            btnNovo.Focus();

            // solução individual, pois a solução do pdf não funcionava
            Edicao = false;
            Insercao = false;
        }

        private void btnAlterarClick(object sender, EventArgs e)
        {
            btnNovo.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Visible = false;
            btnSalvar.Visible = true;
            btnCancelar.Visible = true;
            GRPCategoria.Enabled = true;
            txtNome.Focus();
            Insercao = false;
            Edicao = true;
        }
    }
}
