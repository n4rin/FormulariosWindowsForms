using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAval3
{
    public partial class frmMovimento : Form
    {
        static List<ContaBancaria> _listConta = new List<ContaBancaria>();
        private ContaBancaria _contaAtual = null;
        private int operacao = 0;


        public frmMovimento()
        {
            InitializeComponent();
            this.Size = new Size(685, 255);
            _listConta = ContaBancaria.geraContas();
        }
        private void frmMovimento_Load(object sender, EventArgs e)
        {
            txtLimite.Enabled = false;
            txtSaldo.Enabled = false;
            rdEspecial.Enabled = false;
            rdComum.Enabled = false;
        }

        private void gpbMovimento_Enter(object sender, EventArgs e)
        {

        }

        private void nrConta_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnSair_Click(object sender, MouseEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void nrConta_Enter(object sender, EventArgs e)
        {
        }

        private void txtConta_Leave(object sender, EventArgs e)
        {
            bool contaEncontrada = false;
            foreach (ContaBancaria conta in _listConta)
            {
                if (conta.CodigoConta.Equals(txtConta.Text.Trim()))
                {
                    if (conta.Tipo == 0)
                    {
                        rdComum.Checked = true;
                    }
                    else
                    {
                        rdEspecial.Checked = true;
                    }
                    txtLimite.Text = Convert.ToString(conta.Limite);
                    txtSaldo.Text = Convert.ToString(conta.Saldo);
                    contaEncontrada = true;
                }
            }
            if (!contaEncontrada)
            {
                MessageBox.Show("Número de conta inválida !");
                txtLimite.Text = "";
                txtSaldo.Text = "";
                rdComum.Checked = false;
                rdEspecial.Checked = false;
            }

        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            btnDepositar.Enabled = false;
            btnSacar.Enabled = false;
            btnSair.Enabled = false;
            this.Size = new Size(685, 365);
        }

        private void dtMovimento_Leave(object sender, EventArgs e)
        {
            if ((dtMovimento.Value.DayOfWeek == DayOfWeek.Sunday) ||
                (dtMovimento.Value.DayOfWeek == DayOfWeek.Saturday))
            {
                MessageBox.Show("Data Inválida!");
                dtMovimento.Focus();
            }
        }

        private void txtValor_Leave(object sender, EventArgs e)
        {
            if (Convert.ToDouble(txtValor.Text) <= 0)
            {
                MessageBox.Show("Valor Inválido !", "O valor não pode ser negativo ou nulo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtValor.Focus();
            }
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            btnDepositar.Enabled = false;
            btnSacar.Enabled = false;
            btnSair.Enabled = false;
            this.Size = new Size(685, 365);
            operacao = 1;
        }

        private void btnLancar_Click(object sender, EventArgs e)
        {
            if (operacao == 0)
            {
                foreach (ContaBancaria conta in _listConta)
                {
                    if (conta.CodigoConta.Equals(txtConta.Text.Trim()))
                    {
                        if (conta.Tipo == 0)
                        {
                            rdComum.Checked = true;
                        }
                        else
                        {
                            rdEspecial.Checked = true;
                        }
                        conta.Saldo += Convert.ToDouble(txtValor.Text);
                        txtLimite.Text = Convert.ToString(conta.Limite);
                        txtSaldo.Text = Convert.ToString(conta.Saldo);
                    }
                }
            }
            else
            {
                foreach (ContaBancaria conta in _listConta)
                {
                    if (conta.CodigoConta.Equals(txtConta.Text.Trim()))
                    {
                        if (conta.Tipo == 0)
                        {
                            // tentei de tudo que é jeito :(
                            rdComum.Checked = true;
                            double valorSacar = Convert.ToDouble(txtValor.Text);
                            double valorTotal = Convert.ToDouble(txtSaldo.Text);
                            if (valorSacar < valorTotal)
                            {
                                valorSacar -= valorTotal;
                                valorTotal = 0;
                                txtSaldo.Text = "0";

                                conta.Limite -= valorSacar;
                                txtLimite.Text = Convert.ToString(conta.Limite);
                            } else
                            {
                                MessageBox.Show("O valor a ser sacado é inválido", "Valor Inválido !",  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            rdEspecial.Checked = true;
                            conta.Saldo -= Convert.ToDouble(txtValor.Text);
                            txtLimite.Text = Convert.ToString(conta.Limite);
                            txtSaldo.Text = Convert.ToString(conta.Saldo);
                        }
                        
                    }
                }
            }
            btnDepositar.Enabled = true;
            btnSacar.Enabled = true;
            btnSair.Enabled = true;
        }
    }
}
