using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SisFin
{
    public partial class frmCategoria : Form
    {
        private bool Insercao = false;
        private bool Edicao = false;
        // NOVO ====================
        private Categoria categoria = new Categoria(); 
        private List<Categoria> lstCategoria = new List<Categoria>();
        private BindingSource bsCategoria;
        //==========================
        public frmCategoria()
        {
            InitializeComponent();
            lstCategoria = categoria.GeraCategorias();
        }

        private void limparCampos()
        {
            txtNome.Clear();
            txtDescricao.Clear();
            rdDespesa.Checked = false;
            rdReceita.Checked = false;
            chkStatus.Checked = false;
        }

        // NOVO ====================
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

        // NOVO ====================
        private void carregaGridCategoria()
        {
            bsCategoria = new BindingSource();
            bsCategoria.DataSource = lstCategoria;
            //dgCategoria.Rows.Clear();
            dgCategoria.DataSource = bsCategoria;
            dgCategoria.Refresh();
        }
        // =================================           
        private void novoRegistro(object sender, EventArgs e)
        {
            grpCategoria.Enabled = true;
            limparCampos();
            txtNome.Focus();
            btnAlterar.Enabled = false;
            btnCancelar.Visible = true;
            btnSalvar.Visible = true;
            btnExcluir.Visible = false;
            btnNovo.Enabled = false;
            dgCategoria.Enabled = false; //novo
            Insercao = true;
            Edicao = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnNovo.Enabled = true;
            btnNovo.Focus();
            grpCategoria.Enabled = false;
            btnAlterar.Enabled = true;
            btnCancelar.Visible = false;
            btnSalvar.Visible = false;
            btnExcluir.Visible = true;
            dgCategoria.Enabled = true; //novo
            Insercao = false;
            Edicao = false;
            preencheCampos();
        }

        private void alteraRegistro(object sender, EventArgs e)
        {
            btnNovo.Enabled = false;
            btnAlterar.Enabled = false;
            grpCategoria.Enabled = true;
            txtNome.Enabled = false;
            txtDescricao.Focus();
            btnSalvar.Visible = true;
            btnCancelar.Visible = true;
            btnExcluir.Visible = false;
            dgCategoria.Enabled=false; //novo
            Edicao = true;
            Insercao = false;
        }

        private void frmCategoria_Load(object sender, EventArgs e)
        {
            // NOVO ====================
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

            carregaGridCategoria(); 
            //================================
        }

        private void salvarRegistro(object sender, EventArgs e)
        {

            // DESAFIO
            /*
             * Se for uma alteração, procurar o elemento na lista e atualizá-lo.
             * Se for uma inclusão, simplesmente adicionar um novo elmento na lista.
             * IMPORTANTE!!!
             * Após atualizar a lista deverá ser atualizado o GRIDVIEW
             */

            if (Insercao)
            {
                var nome = txtNome.Text.Trim();
                var descr = txtDescricao.Text.Trim();
                var tipo = rdReceita.Checked ? 1 : 2;
                var status = chkStatus.Checked ? 1 : 0;
                categoria.AddToList(3,nome,descr,tipo,status);
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
            grpCategoria.Enabled = false;
            btnAlterar.Enabled = true;
            btnCancelar.Visible = false;
            btnSalvar.Visible = false;
            btnExcluir.Visible = true;
            dgCategoria.Enabled = true; //novo
             
            Insercao = false;
            Edicao = false;
          
        }

        // NOVO ====================
        private void dgCategoria_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgCategoria.RowCount > 0)
            {
                txtNome.Text = dgCategoria.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtDescricao.Text = dgCategoria.Rows[e.RowIndex].Cells[2].Value.ToString();

                if (Convert.ToInt16(dgCategoria.Rows[e.RowIndex].Cells[3].Value.ToString())==1)
                    rdReceita.Checked = true;
                else
                    rdDespesa.Checked = true;

                if (Convert.ToInt16(dgCategoria.Rows[e.RowIndex].Cells[4].Value.ToString())==1)
                    chkStatus.Checked = true;
                else
                    chkStatus.Checked = false;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult resp;
            resp = MessageBox.Show("Confirma exclusão?", "Aviso do sisema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resp == DialogResult.Yes)
            {
                MessageBox.Show("Registro excluido com sucesso!", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        //==================================

        private void fecharForm(object sender, FormClosingEventArgs e)
        {
            if (Edicao || Insercao)
            {
                e.Cancel = true;
                MessageBox.Show("Rimani qui!","Aviso do sistema!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void grpCategoria_Enter(object sender, EventArgs e)
        {

        }
    }
}
