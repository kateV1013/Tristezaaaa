using _1234.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1234
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void vectoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmVectores().Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
          this.Close();
        }

        private void x2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmMatriz2X2().Show();
        }

        private void x3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmMatriz3X3cs().Show();
        }

        private void edadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Edades().Show();
        }

        private void cadenaTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CadenaTexto().Show();
        }
    }
}
