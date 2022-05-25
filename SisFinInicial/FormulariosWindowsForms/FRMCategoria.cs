using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FormulariosWindowsForms
{
    public partial class FRMCategoria : Form
    {
        private Categoria categoria = new Categoria();
        private List<Categoria> lstCategoria = new List<Categoria>();
        private BindingSource bsCategoria;

        private bool Insercao = false;
        private bool Edicao = false;
        
        public FRMCategoria()
        {
            InitializeComponent();
            lstCategoria = categoria.GeraCategorias();
            
        }

        private void preencheCampos()
        {
            txtNome.Text = dgCategoria.Rows[dgCategoria.CurrentRow.Index].Cells[1].Value.ToString();
            txtDescricao.Text = dgCategoria.Rows[dgCategoria.CurrentRow.Index].Cells[2].Value.ToString();

            if (Convert.ToInt16(dgCategoria.Rows[dgCategoria.CurrentRow.Index].Cells[3].Value.ToString()) == 1)
                rdReceita.Checked = true;
            else
                rdDespesa.Checked = true;

            if (Convert.ToInt16(dgCategoria.Rows[dgCategoria.CurrentRow.Index].Cells[4].Value.ToString()) == 1)
                chkStatus.Checked = true;
            else
                chkStatus.Checked = false;
        }

        public void LimparCampos ()
        {
            txtNome.Clear();
            txtDescricao.Clear();
            rdDespesa.Checked = false;
            rdReceita.Checked = false;
            chkStatus.Checked = false;

        }

        private void carregaGridCategoria()
        {
            bsCategoria = new BindingSource();
            bsCategoria.DataSource = lstCategoria;
            //dgCategoria.Rows.Clear();
            dgCategoria.DataSource = bsCategoria;
            dgCategoria.Refresh();
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
                dgCategoria.Rows.RemoveAt(dgCategoria.CurrentRow.Index);
            }
            btnNovo.Focus();
        }

        

        private void salvarClick(object sender, EventArgs e)
        {
            if (Insercao)
            {
                var nome = txtNome.Text.Trim();
                var descr = txtDescricao.Text.Trim();
                var tipo = rdReceita.Checked ? 1 : 2;
                var status = chkStatus.Checked ? 1 : 0;
                categoria.AddList(3, nome, descr, tipo, status);
            }

            if (Edicao)
            {
                Categoria ct = lstCategoria.Find(item => item.Nome == txtNome.Text.Trim());
                if (ct != null)
                {
                    ct.Descricao = txtDescricao.Text.Trim();
                    ct.Tipo = rdReceita.Checked ? 1 : 2;
                    ct.Status = chkStatus.Checked ? 1 : 0;
                }
            }

            carregaGridCategoria();

            MessageBox.Show("Registro gravado com sucesso!", "Aviso do sistema",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            btnNovo.Enabled = true;
            btnNovo.Focus();
            txtNome.Enabled = true;
            GRPCategoria.Enabled = false;
            btnAlterar.Enabled = true;
            btnCancelar.Visible = false;
            btnSalvar.Visible = false;
            btnExcluir.Visible = true;
            dgCategoria.Enabled = true; //novo

            Insercao = false;
            Edicao = false;

        }

        private void dgCategoria_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgCategoria.RowCount > 0)
            {
                txtNome.Text = dgCategoria.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtDescricao.Text = dgCategoria.Rows[e.RowIndex].Cells[2].Value.ToString();

                if (Convert.ToInt16(dgCategoria.Rows[e.RowIndex].Cells[3].Value.ToString()) == 1)
                    rdReceita.Checked = true;
                else
                    rdDespesa.Checked = true;

                if (Convert.ToInt16(dgCategoria.Rows[e.RowIndex].Cells[4].Value.ToString()) == 1)
                    chkStatus.Checked = true;
                else
                    chkStatus.Checked = false;
            }
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
            btnNovo.Focus();
            GRPCategoria.Enabled = false;
            btnAlterar.Enabled = true;
            btnCancelar.Visible = false;
            btnSalvar.Visible = false;
            btnExcluir.Visible = true;
            dgCategoria.Enabled = true; //novo
            Insercao = false;
            Edicao = false;
            preencheCampos();
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

        private void dgCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
