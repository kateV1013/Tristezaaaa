using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1234.Formularios
{
    public partial class FrmMatriz3X3cs : Form
    {
        public FrmMatriz3X3cs()
        {
            InitializeComponent();
        }
        int[,] matriz = new int[3, 3];
        int fila = 0, columna = 0;
        private void tbNum_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            if (!int.TryParse(tbNum.Text, out int num))
            {
                MessageBox.Show("Si no sabe escribir numeros, mejor dediquese a otra cosa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }
            matriz[fila, columna] = num;
            tbNum.Clear();
            lblMatriz.Text = Mostrar();
            columna++;
            if (columna == 3)
            {
                columna = 0;
                fila++;
            }
            if (fila == 3)
            {
                MessageBox.Show("Matriz llena", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbNum.Enabled = false;
            }
            tbNum.Focus();
            e.SuppressKeyPress = true;
        }
        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Matriz 3x3");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    sb.Append($"{matriz[i, j], 4}");
                }
                sb.AppendLine();
            }
            return sb.ToString();
        }
    }
}
