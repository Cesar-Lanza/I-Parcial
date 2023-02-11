using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios
{
    public partial class Ejercicio3 : Form
    {
        public Ejercicio3()
        {
            InitializeComponent();
        }

        private void EjecutarButton1_Click(object sender, EventArgs e)
        {
            string cadena = CadenaTextBox1.Text;

            LongitudTextBox1.Text = Convert.ToString(cadena.Length);
            PrimerTextBox3.Text = cadena.Substring(0, 1);
            UltimoTextBox4.Text = cadena.Substring(cadena.Length - 1, 1);
            MayusculaTextBox5.Text = cadena.ToUpper();//ToUpper para Mayuscula.
            MinusculaTextBox6.Text = cadena.ToLower();//ToLower para Minuscula.
            ReemplazarTextBox7.Text = cadena.Replace("a", "2");//Replace es para Reemplazar.
        }
    }
}
