
namespace WinFormsAval3
{
    partial class frmMovimento
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtConta = new System.Windows.Forms.TextBox();
            this.btnDepositar = new System.Windows.Forms.Button();
            this.btnSacar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.rdComum = new System.Windows.Forms.RadioButton();
            this.rdEspecial = new System.Windows.Forms.RadioButton();
            this.txtLimite = new System.Windows.Forms.TextBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gpbMovimento = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnLancar = new System.Windows.Forms.Button();
            this.dtMovimento = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gpbMovimento.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtConta
            // 
            this.txtConta.Location = new System.Drawing.Point(16, 50);
            this.txtConta.MaxLength = 10;
            this.txtConta.Name = "txtConta";
            this.txtConta.Size = new System.Drawing.Size(127, 23);
            this.txtConta.TabIndex = 0;
            this.txtConta.Enter += new System.EventHandler(this.nrConta_Enter);
            this.txtConta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nrConta_KeyPress);
            this.txtConta.Leave += new System.EventHandler(this.txtConta_Leave);
            // 
            // btnDepositar
            // 
            this.btnDepositar.BackColor = System.Drawing.Color.Lime;
            this.btnDepositar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDepositar.Location = new System.Drawing.Point(13, 118);
            this.btnDepositar.Name = "btnDepositar";
            this.btnDepositar.Size = new System.Drawing.Size(176, 81);
            this.btnDepositar.TabIndex = 3;
            this.btnDepositar.Text = "Depositar";
            this.btnDepositar.UseVisualStyleBackColor = false;
            this.btnDepositar.Click += new System.EventHandler(this.btnDepositar_Click);
            // 
            // btnSacar
            // 
            this.btnSacar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSacar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSacar.Location = new System.Drawing.Point(202, 118);
            this.btnSacar.Name = "btnSacar";
            this.btnSacar.Size = new System.Drawing.Size(184, 81);
            this.btnSacar.TabIndex = 4;
            this.btnSacar.Text = "Sacar";
            this.btnSacar.UseVisualStyleBackColor = false;
            this.btnSacar.Click += new System.EventHandler(this.btnSacar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSair.Location = new System.Drawing.Point(463, 118);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(188, 81);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnSair_Click);
            // 
            // rdComum
            // 
            this.rdComum.AutoSize = true;
            this.rdComum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdComum.Location = new System.Drawing.Point(164, 29);
            this.rdComum.Name = "rdComum";
            this.rdComum.Size = new System.Drawing.Size(129, 25);
            this.rdComum.TabIndex = 6;
            this.rdComum.TabStop = true;
            this.rdComum.Text = "Conta Comum";
            this.rdComum.UseVisualStyleBackColor = true;
            // 
            // rdEspecial
            // 
            this.rdEspecial.AutoSize = true;
            this.rdEspecial.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdEspecial.Location = new System.Drawing.Point(164, 50);
            this.rdEspecial.Name = "rdEspecial";
            this.rdEspecial.Size = new System.Drawing.Size(128, 25);
            this.rdEspecial.TabIndex = 7;
            this.rdEspecial.TabStop = true;
            this.rdEspecial.Text = "Conta Especial";
            this.rdEspecial.UseVisualStyleBackColor = true;
            // 
            // txtLimite
            // 
            this.txtLimite.Location = new System.Drawing.Point(316, 51);
            this.txtLimite.Name = "txtLimite";
            this.txtLimite.Size = new System.Drawing.Size(142, 23);
            this.txtLimite.TabIndex = 8;
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(478, 52);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(141, 23);
            this.txtSaldo.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(19, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nr. Conta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(316, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "Limite";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(478, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "Saldo";
            // 
            // gpbMovimento
            // 
            this.gpbMovimento.Controls.Add(this.label5);
            this.gpbMovimento.Controls.Add(this.label4);
            this.gpbMovimento.Controls.Add(this.txtValor);
            this.gpbMovimento.Controls.Add(this.btnLancar);
            this.gpbMovimento.Controls.Add(this.dtMovimento);
            this.gpbMovimento.Location = new System.Drawing.Point(13, 222);
            this.gpbMovimento.Name = "gpbMovimento";
            this.gpbMovimento.Size = new System.Drawing.Size(638, 105);
            this.gpbMovimento.TabIndex = 13;
            this.gpbMovimento.TabStop = false;
            this.gpbMovimento.Text = "Movimento";
            this.gpbMovimento.Enter += new System.EventHandler(this.gpbMovimento_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(146, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Valor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(146, 60);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(156, 23);
            this.txtValor.TabIndex = 1;
            // 
            // btnLancar
            // 
            this.btnLancar.Location = new System.Drawing.Point(317, 49);
            this.btnLancar.Name = "btnLancar";
            this.btnLancar.Size = new System.Drawing.Size(188, 43);
            this.btnLancar.TabIndex = 2;
            this.btnLancar.Text = "Lançar";
            this.btnLancar.UseVisualStyleBackColor = true;
            this.btnLancar.Click += new System.EventHandler(this.btnLancar_Click);
            // 
            // dtMovimento
            // 
            this.dtMovimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtMovimento.Location = new System.Drawing.Point(14, 60);
            this.dtMovimento.Name = "dtMovimento";
            this.dtMovimento.Size = new System.Drawing.Size(112, 23);
            this.dtMovimento.TabIndex = 0;
            this.dtMovimento.Leave += new System.EventHandler(this.dtMovimento_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtConta);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rdComum);
            this.groupBox1.Controls.Add(this.txtSaldo);
            this.groupBox1.Controls.Add(this.rdEspecial);
            this.groupBox1.Controls.Add(this.txtLimite);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(639, 100);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // frmMovimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 344);
            this.Controls.Add(this.btnSacar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gpbMovimento);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnDepositar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMovimento";
            this.Text = "Movimento de Contas";
            this.Load += new System.EventHandler(this.frmMovimento_Load);
            this.gpbMovimento.ResumeLayout(false);
            this.gpbMovimento.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtConta;
        private System.Windows.Forms.Button btnDepositar;
        private System.Windows.Forms.Button btnSacar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.RadioButton rdComum;
        private System.Windows.Forms.RadioButton rdEspecial;
        private System.Windows.Forms.TextBox txtLimite;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gpbMovimento;
        private System.Windows.Forms.DateTimePicker dtMovimento;
        private System.Windows.Forms.Button btnLancar;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

