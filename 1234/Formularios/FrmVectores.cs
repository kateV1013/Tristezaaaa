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
    public partial class FrmVectores : Form
    {
        public static int[] numeros = new int[10];
        public static int contador = 0;
        public FrmVectores()
        {
            InitializeComponent();
        }

        private void tbNumeros_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            if (!int.TryParse(tbNumeros.Text, out int num))
            { 
                MessageBox.Show("Si no sabe escribir numeros, mejor dediquese a otra cosa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }
            if (contador >= numeros.Length)
            {
                MessageBox.Show("Ya lleno el vector", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            numeros[contador++] = num;
            for (int i = 0; i < contador -1; i++)
            {
                for (int j = i + 1; j < contador; j++)
                {
                    if (numeros[i] < numeros[j])
                    {
                        int aux = numeros[i];
                        numeros[i] = numeros[j];
                        numeros[j] = aux;
                    }
                }

            }
            int suma = 0;
            for (int i = 0; i < contador; i++)
            {
                suma += numeros[i];
            }
            double promedio = (double)suma / contador;
            lblPromedio.Text = promedio.ToString();

            String datos = "";
            for (int i = 0; i <= 3; i++)
            {
                datos += numeros[i] + (i == contador - 1 ? "" : ", ");
            }
            lblNum.Text = datos;
            if (pgbPromedio.Maximum != numeros.Length)
            {
                pgbPromedio.Maximum = numeros.Length;
            }
            pgbPromedio.Value = contador;
            tbNumeros.Clear();
            tbNumeros.Focus();
            e.SuppressKeyPress = true;
        }
    }
}
