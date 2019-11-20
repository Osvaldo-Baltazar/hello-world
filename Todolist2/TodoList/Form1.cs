using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TodoData1
{
    public partial class FrmMain : Form
    {
        //Vamos a llamra y crar las clase y listas qie se ocupa y estas son globales para poder ocuparlas
        Tarea tar = new Tarea();
        List<Tarea> lista = new List<Tarea>();
        FrmData tarea = new FrmData();
        public FrmMain()
        {
            // para iniciar
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Txt_Menu.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          

            switch (Convert.ToInt32(textBox11.Text))
            {

                case 1:
                    //LLamamos la segunda forma


                    FrmData captura = new FrmData();



                    for (int r = 0; r < 5; r++)

                    {
                       


                        if (tarea.ShowDialog() == DialogResult.OK)
                        {
                            Tarea tare = new Tarea();
                            captura.Focus();
                            
                            //Para ingresar los datos y se guarden en el datagrid
                            DgvData.Rows.Add();
                            DgvData.Rows[r].Cells[0].Value = tarea.txt_Nombre.Text;
                            tare.Usuario = tarea.txt_Nombre.Text;
                            DgvData.Rows[r].Cells[1].Value = tarea.txt_Usuario.Text;
                            tare.Datos = tarea.txt_Usuario.Text;
                            DgvData.Rows[r].Cells[2].Value = tarea.txt_NombreTa.Text;
                            tare.Nombre = tarea.txt_NombreTa.Text;
                            DgvData.Rows[r].Cells[3].Value = tarea.txt_Detalles.Text;
                            tare.Detalles = tarea.txt_Detalles.Text;
                            DgvData.Rows[r].Cells[4].Value = tarea.txt_hora.Text;
                            tare.Hora = tarea.txt_hora.Text;
                            DgvData.Rows[r].Cells[5].Value = tarea.txt_Estatus.Text;
                            tare.Estatus = tarea.txt_Estatus.Text;
                            lista.Add(tare);

                            //Esto es para limpiar

                            tarea.txt_Nombre.Text = "";
                            tarea.txt_Usuario.Text = "";
                            tarea.txt_NombreTa.Text = "";
                            tarea.txt_Detalles.Text = "";
                            tarea.txt_hora.Text = "";
                            tarea.txt_Estatus.Text = "";
                        }
                    }
                    break;
                case 2:
                   //Para llamar la ultima forma

                    FrmDataPrint data = new FrmDataPrint();
                    data.Focus();
                    data.Show(this);
               // Con este foreach se podra crear lineas
                    foreach (Tarea tar in lista)
                    {
                        data.TxtDataprint1.Text += tar.Usuario +" " + Environment.NewLine
                           + tar.Nombre + " " + Environment.NewLine
                           +tar.Datos + " "+ Environment.NewLine
                           + tar.Hora + " " + Environment.NewLine
                            + tar.Detalles + " " + Environment.NewLine
                           + tar.Estatus + " " + Environment.NewLine
                           + "========" + Environment.NewLine;

                    }
                    break;
                default:
                    MessageBox.Show("Incorrecto, Vuelve a intertar validar");
                    break;

            }
        }

       

        private void BtnMenu_Click(object sender, EventArgs e)
        {
           // Lo que sigue del menu

            Txt_Menu.Text = "1. Crear tarea\r\n2. Detalles de tareas";
            Txt_Menu.Show();
        }




        private void BtnEnd_Click(object sender, EventArgs e)
        {

            // Este es para cerrar
            Close();
        }
        private void DgvData_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // Lo presione por accidente
        }




        private void DgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Este es el evento que se guardRA EN EL DE CAMBIAR ESTTUS

            tar.Index = e.RowIndex;
            DataGridViewRow row = DgvData.Rows[tar.Index];
            txt_CambiarEs.Text = row.Cells[5].Value.ToString();
        }





        private void BrnUpdate_Click(object sender, EventArgs e)
        {
           
            // Aqui se cambia el estatus

            DataGridViewRow datarow = DgvData.Rows[tar.Index];
            datarow.Cells[5].Value = txt_CambiarEs.Text;
        }
    }
}
