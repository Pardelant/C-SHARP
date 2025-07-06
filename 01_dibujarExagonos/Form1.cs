using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_dibujarExagonos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pintarHexagono(object sender, EventArgs e)
        {
            String cadenaAnhadir = "";
            // parte superior
            // K = lblNumero ejemplo con numero = 3 siempre el numero de iteraciones va a ser el numero dado +=4
            // "0" = lblCaracter ejemplo con 0
            char caracter = Convert.ToChar(tbxCaracter.Text);
            int numero = Convert.ToInt32(txbNumero.Text);

            for (int i = 1; i <= numero; i++)
            {
                cadenaAnhadir = "";
                cadenaAnhadir = cadenaAnhadir.PadRight(numero - i, ' ') + cadenaAnhadir.PadRight(numero + (i - 1) * 2, caracter);
                lbxExagono.Items.Add(cadenaAnhadir);
            }

            for (int i = numero; i > 0; i--)
            {
                cadenaAnhadir = "";
                cadenaAnhadir = cadenaAnhadir.PadRight(numero - i, ' ') + cadenaAnhadir.PadRight(numero + (i - 1) * 2, caracter);
                lbxExagono.Items.Add(cadenaAnhadir);
            }
        }
    }
}
