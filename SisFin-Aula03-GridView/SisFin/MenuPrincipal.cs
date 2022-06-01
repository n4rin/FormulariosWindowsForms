﻿using System;
using System.Windows.Forms;

namespace SisFin
{
    public partial class MenuPrincipal : Form
    {
        private int childFormNumber = 0;
        private static frmCategoria fCategoria;
        private static frmContas fContas;

        public MenuPrincipal()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Janela " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Arquivos de texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Arquivos de texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resp;

            resp = MessageBox.Show("Tem certeza que deseja sair?",
                "Aviso do sistema",
                MessageBoxButtons.YesNo);

            if (resp == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void subMenuCategoria_Click(object sender, EventArgs e)
        {
            if (fCategoria == null)
            {
                fCategoria = new frmCategoria();
                fCategoria.FormClosed += new FormClosedEventHandler(fCategoria_Closed);
            }
            else
            {
                fCategoria.Activate();
            }

            fCategoria.MdiParent = this;
            fCategoria.Show();
        }

        void fCategoria_Closed(object sender, FormClosedEventArgs e)
        {
            fCategoria = null;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("RA:201268 - Aline B. Soares\nRA:201239 - Guilherme G. Nallin", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void editMenu_Click(object sender, EventArgs e)
        {

        }

        private void subMenuConta_Click(object sender, EventArgs e)
        {
            if (fContas == null)
            {
                fContas = new frmContas();
                fContas.FormClosed += new FormClosedEventHandler(fContas_Closed);
            }
            else
            {
                fContas.Activate();
            }

            fContas.MdiParent = this;
            fContas.Show();
        }

        void fContas_Closed(object sender, FormClosedEventArgs e)
        {
            fContas = null;
        }
    }
}