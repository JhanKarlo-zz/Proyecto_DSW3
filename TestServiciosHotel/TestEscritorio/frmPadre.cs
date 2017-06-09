using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestEscritorio
{
    public partial class frmPadre : Form
    {
        public frmPadre()
        {
            InitializeComponent();
        }

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReserva frmReservaR = new frmReserva();

            frmReservaR.MdiParent = this;

            frmReservaR.Show();
        }
    }
}
