using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_piramides
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int n_bloques = Convert.ToInt32(txbBloques.Text);
            int i = 1, interior, area = 0;
            int alturas = 1, sobrante = 0;

            while (n_bloques > 0)
            {
                if (i == 1)
                {
                    n_bloques -= 1;
                }
                else
                {

                    interior = (i - 2) * (i - 2);
                    area = i * i;

                    if (n_bloques - area >= 0)
                    {
                        alturas++;
                        // para la maxima altura posible de la piramide
                        n_bloques -= (area - interior);
                        // para la minima altura posible de la piramide construıda (numero de niveles) en la que se hayan utilizado todos los bloques de piedra PROGRAMAme --> piramide rellena
                        // n_bloques -= (area + interior)
                    }
                    else if (n_bloques - (area - interior) >= 0)
                    {
                        alturas++;
                        n_bloques -= (area - interior);
                    }
                    else
                    {
                        sobrante = n_bloques;
                        n_bloques = 0;
                    }
                }
                i += 2;
            }

            lbl_niveles.Text = alturas.ToString();
            lbl_sobrante.Text = sobrante.ToString();

        }
    }
}
