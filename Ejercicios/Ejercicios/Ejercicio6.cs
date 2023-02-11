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
    public partial class Ejercicio6 : Form
    {
        public Ejercicio6()
        {
            InitializeComponent();
        }

        private void EjecutarButton_Click(object sender, EventArgs e)
        {
            //Vectores
            int[] vector1 = new int[5];

            vector1[0] = 20;
            vector1[1] = 30;
            vector1[2] = 40;
            vector1[3] = 50;
            vector1[4] = 60;

            //Formas de Poder Crear un Vector
            int[] vector2 = new int[5] {10,20,30,40,50};
            int[] vector3 = new int[] { 10, 20, 30, 40, 50 };
            int[] vector4 = { 10, 20, 30, 40, 50 };

            //Vector con Dias de Semana
            string[] vector5 = { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo" };

            for (int i = 0; i < vector5.Length; i++)
            {
                ListBox.Items.Add(vector5[i]); //Items es para poder pasarle valores a nustros listbox
            }

            foreach (string item in vector5)//var permite capturar el tipo de Item
            {
                ComboBox.Items.Add(item);
            }
        }
    }
}
