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
    public partial class Ejercicio4 : Form
    {
        public Ejercicio4()
        {
            InitializeComponent();
        }

        private void EjecutarButton1_Click(object sender, EventArgs e)
        {
            DateTime fecha = dateTimePicker1.Value;

            //DiaTextBox1.Text = fecha.Day.ToString();
            //MesTextBox2.Text = fecha.Month.ToString();
            //AñoTextBox3.Text = fecha.Year.ToString();
            //SemanaTextBox4.Text = fecha.DayOfWeek.ToString();

            DiaTextBox1.Text = fecha.ToString("M");
            MesTextBox2.Text = fecha.ToString("MMMM");
            AñoTextBox3.Text = fecha.ToString("yyyy");
            SemanaTextBox4.Text = fecha.ToString("dddd");

            //Creamos una Variable para Dias Cita.
            int numeroDias = Convert.ToInt32(CitaTextBox5.Text);
            DateTime fechaActual = DateTime.Now;//DateTime.Now accedemos a nuestra fecha actual.
            Cita1TextBox1.Text = fechaActual.AddDays(numeroDias).ToShortDateString();//AddDays es para agregar dias.

            //Creamos una variable para Restar Dias.
            int restaDia = Convert.ToInt32(RestarTextBox6.Text);
            NuevaFechaTextBox2.Text = fecha.AddDays(-restaDia).ToShortDateString();

            MessageBox.Show("La Edad de la Persona es: " + DevolverEdad(fecha));
        }

        private int DevolverEdad(DateTime fechaNacimiento)
        {
            int edad = 0;

            if (fechaNacimiento >= DateTime.Now)
            {
                return 0;
            }
            else
            {
                edad = DateTime.Now.Year - fechaNacimiento.Year;
                if (fechaNacimiento.Month > DateTime.Now.Month) 
                {
                    --edad;
                }
            }
            return edad;

        }
    }
}
