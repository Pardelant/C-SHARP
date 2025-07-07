using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_houstonVerificacion
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        int bloques1, bloques2;
        int longi1, longi2;
        String[] vector1;
        int cantidadN;
        long resultadoVectorial;
        String[] vector2;
        int[] vector1_ints, vector2_ints;
        private void button1_Click(object sender, EventArgs e)
        {

            bloques1 = Convert.ToInt32(txbBloque1.Text);
            bloques2 = Convert.ToInt32(txbBloque2.Text);
            vector1 = txbVector1.Text.Split(' ');

            vector2 = txbVector2.Text.Split(' ');

            for (int i = 0, j = 0; j < bloques1; i += 2, j++)
            {
                longi1 += cantidadN = Convert.ToInt32(vector1[i]);
            }

            for (int i = 0, j = 0; j < bloques2; i += 2, j++)
            {
                longi2 += cantidadN = Convert.ToInt32(vector2[i]);
            }

            if (longi1 == longi2)
            {
                vector1_ints = new int[longi1];
                vector2_ints = new int[longi2];

                for (int i = 0, j = 0; i < vector1.Length; i += 2)
                {
                    for (int k = 0; k < Convert.ToInt32(vector1[i]); k++, j++)
                    {
                        vector1_ints[j] = Convert.ToInt32(vector1[i + 1]);
                    }
                }

                for (int i = 0,j = 0; i < vector2.Length; i += 2)
                {
                    for (int k = 0; k < Convert.ToInt32(vector2[i]); k++, j++)
                    {
                        vector2_ints[j] = Convert.ToInt32(vector2[i + 1]);
                    }
                }

                for (int i = 0; i < longi1; i++)
                {
                    lblMostrarVector1.Text += vector1_ints[i].ToString();
                }

                for (int i = 0; i < longi1; i++)
                {
                    lblMostrarVector2.Text += vector2_ints[i].ToString();
                }


                for (int i = 0; i < vector1_ints.Length; i++)
                {
                    resultadoVectorial += vector1_ints[i] * vector2_ints[i];
                }

                lblRes.Text = resultadoVectorial.ToString();
            }
            else
            {
                lblRes.Text = "Disinta longitud";
            }
        }
    }
}
