using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea1
{
    public partial class Tarea1 : Form
    {
        public Tarea1()
        {
            InitializeComponent();
        }

        private void EjecutarButton_Click(object sender, EventArgs e)
        {
            //variables
            decimal numero1 = 0;

            numero1 = Convert.ToDecimal(NumeroTextBox.Text);

            MessageBox.Show(Convert.ToString(Calcular1(numero1)));
        }

        //Funcion para Par e Impar
        private decimal Calcular1(decimal n1)
        {
            decimal resultado = 0;

            if (resultado % 2 == 0) 
            {
                MessageBox.Show("El Numero que Ingreso es Par");
            }
            else
            {
                MessageBox.Show("El Numero que Ingreso es Impar");
            }
            return resultado;
        }
    }
}
