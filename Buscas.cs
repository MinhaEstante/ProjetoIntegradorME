using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoIntegradorME
{
    public partial class Buscas : UserControl
    {
        public Buscas()
        {
            InitializeComponent();
        }

        private void Buscas_Load(object sender, EventArgs e)
        {
            //infoBox.Text = "Please enter a book address or search for a book.";
            txtInfoBox.Text = "Insira  ";
        }
    }
}
