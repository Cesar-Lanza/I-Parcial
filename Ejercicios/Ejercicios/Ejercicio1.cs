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
    public partial class Ejercicio1 : Form
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CalcularButton1_Click(object sender, EventArgs e)
        {
            //variables
            decimal numero1 = 0;
            decimal numero2 = 0;

            numero1 = Convert.ToDecimal(Numero1TextBox1.Text);
            numero2 = Convert.ToDecimal(Numero2TextBox1.Text);

            decimal suma = numero1 + numero2;

            //MessageBox.Show("La Suma es: " +suma);

            //MostrarMensaje();

            MessageBox.Show(Convert.ToString(Calcular(numero1, numero2)));
        }

        //Procedimiento
        private void MostrarMensaje()
        {
            MessageBox.Show("Hola");
        }

        //Funcion
        private decimal Calcular(decimal n1, decimal n2)
        {
            return n1 + n2;
        }
    }
}
