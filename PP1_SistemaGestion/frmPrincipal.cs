using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PP1_SistemaGestion
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void acerdaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAcercaDe ventana = new frmAcercaDe();
            ventana.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nuevoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNuevoCliente ventana = new frmNuevoCliente();
            ventana.Show();
        }

        private void consultarListaDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaClientes ventana = new frmListaClientes();
            ventana.Show();
        }
    }
}
