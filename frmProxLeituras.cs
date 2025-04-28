using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoIntegradorME
{
    public partial class frmProxLeituras : Form
    {
        public frmProxLeituras()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            //voltar para o menu principal

            this.Close();
            this.Dispose();
        }
    }
}
