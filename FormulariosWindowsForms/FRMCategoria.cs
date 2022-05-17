using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormulariosWindowsForms
{
    public partial class FRMCategoria : Form
    {
        private bool Insercao = false;
        private bool Edicao = false;
        private FRMCategoria fCategoria;
        
        public FRMCategoria()
        {
            InitializeComponent();
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
            txtDescricao.Enabled = true;
            btnAlterar.Enabled = true;
            btnCancelar.Visible = false;
            btnNovo.Enabled = true;
            btnExcluir.Visible = true;
            btnSalvar.Visible = false;
            GRPCategoria.Enabled = false;
            btnNovo.Focus();
            Insercao = false;
            Edicao = false;

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
