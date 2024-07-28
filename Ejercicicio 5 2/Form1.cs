using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicicio_5_2
{
    public partial class Form1 : Form
    {
        BicolaP pila = new BicolaP();
        BicolaC cola = new BicolaC();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string numero = txtNumero.Text;
                int n = numero.Length;
                if (n != 0)
                {
                    if (pila.capicua(n, numero, cola, pila))
                    {
                        txtRspt.Text = "El numero es capicua";
                        txtNumero.Clear();
                        txtNumero.Focus();

                    }
                    else
                    {
                        txtRspt.Text = "El numero no es capicua";
                        txtNumero.Clear();
                        txtNumero.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Por favor introduca un caracter valido", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNumero.Clear();
                    txtNumero.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Hubo un error", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNumero.Clear();
                txtNumero.Focus();
            }
        }
    }
}
