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
    public partial class Ejercicio8 : Form
    {
        public Ejercicio8()
        {
            InitializeComponent();
        }

        private void EjecutarButton_Click(object sender, EventArgs e)
        {
            RecorrerUnoaUno(1, 100);
        }

        private void RecorrerUnoaUno(int valorInicial, int valorFinal)
        {
            ListBox.Items.Add(valorInicial);

            if (valorInicial < valorFinal)
            {
                RecorrerUnoaUno(valorInicial + 1, valorFinal);
            }
            //Una Funcion Recursiva es aquella que es llamada sobre si misma.
        }
    }
}
