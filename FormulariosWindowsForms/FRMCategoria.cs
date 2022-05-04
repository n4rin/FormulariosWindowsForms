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

        }

        private void subMenuCategoria(object sender, EventArgs e)
        {
            if (fCategoria == null)
            {
                fCategoria = new FRMCategoria();
                fCategoria.FormClosed += new FormClosedEventHandler(fCategoria_Closed);
            
            } else

            {
                fCategoria.Activate();
            }

            fCategoria.MdiParent = this;
            fCategoria.Show();
        }

        public void fCategoria_Closed(object sender, FormClosedEventArgs e)
        {
           fCategoria = null;
        }

        private void salvarClick(object sender, EventArgs e)
        {
            MessageBox.Show("Registro gravado com sucesso!", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnNovo.Enabled = false;
            txtDescricao.Enabled = true;
            btnAlterar.Enabled = false;
            btnCancelar.Visible = true;
            btnNovo.Enabled = true;
        }

       
    }
}
