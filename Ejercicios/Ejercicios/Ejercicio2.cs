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
    public partial class Ejercicio2 : Form
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void CalcularButton1_Click(object sender, EventArgs e)
        {
            if (Numero1TextBox1.Text == "")
            {
                errorProvider1.SetError(Numero1TextBox1, "Ingrese un Valor");
                return;
            }
            errorProvider1.Clear();//Sirve para poder limpiar el error.

            if (Numero2TextBox1.Text == string.Empty)//string.Empty significa que no puede quedar cadena vacia.
            {
                errorProvider1.SetError(Numero2TextBox1, "Ingrese un Valor");
                return;
            }
            errorProvider1.Clear();

            if (OperacionesComboBox1.Text == string.Empty)
            {
                errorProvider1.SetError(OperacionesComboBox1, "Seleccione una Operacion");
                return;
            }
            errorProvider1.Clear();

            decimal num1 = Convert.ToDecimal(Numero1TextBox1.Text);
            decimal num2 = Convert.ToDecimal(Numero2TextBox1.Text);
            ResultadoLabel.Text = Calcular(num1, num2).ToString();
        }

        private decimal Calcular(decimal n1, decimal n2)
        {
            string operacion = OperacionesComboBox1.Text;
            decimal resultado = 0;

            if (operacion == "Suma")
            {
                resultado = n1 + n2;
            }
            else if (operacion == "Resta")
            {
                resultado = n1 - n2;
            }
            else if (operacion == "Multiplicacion")
            {
                resultado = n1 * n2;
            }
            else if (operacion == "Division")
            {
                if (n2 == 0)
                    resultado = 0;
                else
                    resultado = n1 / n2;
            }
            return resultado;
        }
    }
}
