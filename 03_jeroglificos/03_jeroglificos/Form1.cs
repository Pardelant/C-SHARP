using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_jeroglificos
{
    public partial class Form1 : Form
    {
        int[] numerico = { 1, 10, 100, 1000, 10000, 100000, 1000000 };
        char[] letras = { 'T', 'G', 'C', 'F', 'D', 'R', 'H' };
        String notacion;
        int numero;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            numero = Convert.ToInt32(txbNumero.Text);
            lblMostrar.Text = "";

            while (numero != 0)
            {
                for (int i = 6; i > 0; i--)
                {
                    if (numero < numerico[i] && numero >= numerico[i - 1])
                    {
                        int cociente = numero / numerico[i - 1];
                        while (cociente > 0)
                        {
                            numero -= numerico[i - 1];
                            lblMostrar.Text += letras[i - 1];
                            cociente--;

                        }
                    }
                }
            }
        }
    }
}
