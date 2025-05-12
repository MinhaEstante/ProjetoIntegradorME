using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using static ProjetoIntegradorME.User;

using static ProjetoIntegradorME.JsonBia;


namespace ProjetoIntegradorME
{
    public partial class mdiMenu : Form
    {
        private int childFormNumber = 0;



        public mdiMenu()
        {
            InitializeComponent();
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
            this.Close();
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

        /*
        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        */

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



        private void toolStripSair_Click(object sender, EventArgs e)
        {
            //sair

            DialogResult sair = MessageBox.Show("Deseja sair?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sair == DialogResult.Yes)
            {
                this.Close();
                this.Dispose();
            }
        }

        private void toolStripLidos_Click(object sender, EventArgs e)
        {
            //abrir o formulário de lidos

            frmLidos formsLidos = new frmLidos();
            formsLidos.ShowDialog();
        }

        private void toolStripLendo_Click(object sender, EventArgs e)
        {
            //abrir o formulário lendo

            frmLendo fromsLendo = new frmLendo();
            fromsLendo.ShowDialog();
        }

        private void toolStripProxLeituras_Click(object sender, EventArgs e)
        {
            //abrir o formulário das próximas leituras

            frmProxLeituras formsProxLtras = new frmProxLeituras();
            formsProxLtras.ShowDialog();

        }

        private void toolStripUsuario_Click(object sender, EventArgs e)
        {
            //abrir o formulário perfil do usuário

            frmUsuario formsUsuario = new frmUsuario();
            formsUsuario.ShowDialog();

        }

        private void toolStripSobre_Click(object sender, EventArgs e)
        {

        }

        private void mdiMenu_Load(object sender, EventArgs e)
        {
            statusStrip.Items.Add("Usuário: " + Global.usuario);
            statusStrip.Items.Add(" | ");
            statusStrip.Items.Add("Data atual: " + DateTime.Now);

            
        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
