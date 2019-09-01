using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taller_punto4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Lblcalif1_Click(object sender, EventArgs e)
        {

        }

        private void Btncalcular_Click(object sender, EventArgs e)
        {
            string nota1 = txtcalif1.Text;
            string nota2 = txtcalif2.Text;
            string nota3 = txtcalif3.Text;
            string promedio = lblresultado.Text;

            float calificacion1 = float.Parse(nota1);
            float calificaion2 = float.Parse(nota2);
            float calificacion3 = float.Parse(nota3);
            float resultado = (calificacion1 + calificaion2 + calificacion3) / 3;

            lblresultado.Text = resultado.ToString();
        }
    }
}
