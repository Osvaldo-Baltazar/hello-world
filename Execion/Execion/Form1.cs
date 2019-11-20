using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Execion
{
    public partial class Form1 : Form
    {
        Alumno alumno = new Alumno();
        public Form1()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            /*int texto = Convert.ToInt32(Caja1.Text);
            MessageBox.Show(Convert.ToString(texto));
            Caja1.Text = "";*/
        }
        private void B1_Click(object sender, EventArgs e)
        {
          
            if (txt_Matricula.Text == "")
            {
                errorProvider1.SetError(txt_Matricula, "No ha ingresado matricula");

            }
            if (txt_Nombre.Text == "")
            {
                errorProvider1.SetError(txt_Nombre, "No ha ingresado matricula");

            }

            if (txt_Semestre.Text == "")
            {
                errorProvider1.SetError(txt_Semestre, "No ha ingresado matricula");

            }
            if (txt_Carrera.Text == "")
            {
                errorProvider1.SetError(txt_Carrera, "No ha ingresado matricula");

            }

            if (txt_Telefono.Text == "")
            {
                errorProvider1.SetError(txt_Telefono, "No ha ingresado matricula");

            }

            try
            {
                Alumno alumno = new Alumno();
                alumno.Matricula = Convert.ToInt32( txt_Matricula.Text);
                alumno.Nombre = txt_Nombre.Text;
                alumno.Smestre = Convert.ToInt32(txt_Semestre.Text);
                alumno.Carrera = txt_Carrera.Text;
                alumno.Telefono = Convert.ToInt32(txt_Telefono.Text);

            }

            finally
            {

            }
            try
            {
                throw new EspecialException
                    ("Se crea exitosamente");
            }
            catch(FormatException ex)
            {
                MessageBox.Show("Error al registrar esto");
            }

            catch(EspecialException expex)
            {
                MessageBox.Show(expex.Message);
            }

            finally
            {
                errorProvider1.Clear();
            }


        }

        private void txt_Calificacion_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                int cal = Convert.ToInt32(txt_Calificacion.Text);
                if (cal < 1 || cal > 10) ;
                MessageBox.Show("Ingrese las calificaciones del 1 AL 10","ERROR");

            }

            catch(Exception EX)
            {
                MessageBox.Show("Introdusca los numeros correctos","ERROR",MessageBoxButtons.YesNo, MessageBoxIcon.Error);


            }
        }
    }
}
