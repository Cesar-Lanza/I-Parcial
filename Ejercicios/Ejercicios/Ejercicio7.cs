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
    public partial class Ejercicio7 : Form
    {
        public Ejercicio7()
        {
            InitializeComponent();
        }

        private void EjecutarButton_Click(object sender, EventArgs e)
        {
            ListBox.Items.Clear();
            //Matriz en los corchetes se agrega una coma
            //tambien se agrega una llave despues del tamaño para saber que esa llave es la que engloba
            // y la siguiente llave es la que llevara los valores de la matriz

            //Matriz.
            int[,] matriz1 = new int[2, 3] { { 5, 6, 4 }, { 9, 7, 3 } };

            //Llenar Matriz
            Random aleatorio = new Random();//Random es para llenar numeros aleatorios
            int[,] matriz2 = new int[4, 6];

            for (int fila = 0; fila < matriz2.GetLength(0); fila++)
            {
                for (int col = 0; col < matriz2.GetLength(1); col++)
                {
                    matriz2[fila, col] = aleatorio.Next(0, 1000);// de 0 a 1000 son los numeros que va a agregar aleatoriamente.
                }
            }

            //Mostrar Matriz en el Listbox
            for (int fila = 0; fila < matriz2.GetLength(0); fila++)
            {
                for (int col = 0; col < matriz2.GetLength(1); col++)
                {
                    ListBox.Items.Add("La Posicion: [ " + fila + ", " + col + " ] = " + matriz2[fila,col]);
                }
            }
        }
    }
}
