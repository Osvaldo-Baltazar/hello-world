using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            /// Aqui vamos a llamar a cada clase para asi poder imprimir cada atributo
            /// 
            Paciente pac= new Paciente();
            // Aqui la herencia es lo que comparte cada una de la clase y la todos tienen en comun es nombre y fecha de nacimiento pero no todo las puse
            // y correo
            pac.Nombre = "Kylie Jenner";
            pac.Fecha_de_nacimiento = "18 de enero del 2019";
            pac.Correo = "Kyliecosmetics@paseme.com";
            pac.Tipo_Paciente="Multimillonaria";

            // Aqui se va a imprimir 
            Console.WriteLine("Nombre del paciente: "+pac.Nombre);
            Console.WriteLine("Fecha de nacimiento del paciente: "+pac.Fecha_de_nacimiento);
            Console.WriteLine("Correo del paciente: "+pac.Correo);
            Console.WriteLine("Tipo de paciente:"+pac.Tipo_Paciente);
            Console.WriteLine();
            Console.WriteLine();


            Enfermera enfermera = new Enfermera();

            enfermera.Id = 1234;
            enfermera.Area = "Terapia intensiva";
            enfermera.Nombre="Black China";

            Console.WriteLine("Id de la enfermera: "+ enfermera.Id);
            Console.WriteLine("Nombre: "+enfermera.Nombre);
            Console.WriteLine("Area: "+enfermera.Area);
            Console.WriteLine();
            Console.WriteLine();

            Medico medico=new Medico();

            medico.Id=12345;
            medico.Nombre="Osvi";
            medico.Especialidad="Odontologia";

            Console.WriteLine("Datos del medico: ");
            Console.WriteLine("Id: "+medico.Id);
            Console.WriteLine("Nombre: "+medico.Nombre);
            Console.WriteLine("Especialidad: "+medico.Especialidad);
            Console.WriteLine();
            Console.WriteLine();

            Medico_familiar medico_Familiar=new Medico_familiar();
            medico_Familiar.Id=54321;
            medico_Familiar.Nombre="Khloe Kardashian";
            medico_Familiar.Especialidad="Ponerte bien bueno con el ejercicio";
            medico_Familiar.Correo="Medicofamiliar2019@hotmail.com";
            medico_Familiar.Fecha_de_nacimiento="21 de Enero";


            Console.WriteLine("Datos del medico familiar");
            Console.WriteLine("Id: "+medico_Familiar.Id);
            Console.WriteLine("Nombre: "+medico_Familiar.Nombre);
            Console.WriteLine("Especialidad: "+medico_Familiar.Especialidad);
            Console.WriteLine("Correo: "+medico_Familiar.Correo);
            Console.WriteLine("Fecha de nacimiento: "+medico_Familiar.Fecha_de_nacimiento);

            Console.WriteLine();
            Console.WriteLine();

            Cirujano cirujano=new Cirujano();
            cirujano.Id=434232;
            cirujano.Nombre="Osvaldo Uriel Baltazar ";
            cirujano.Especialidad="Cirujia plastica";
            cirujano.Area="Quirurjica";
            cirujano.Correo="Cirujano_de_las_Kardashians@gmail.com";

            Console.WriteLine("Datos del cirujano: ");
            Console.WriteLine("Id: "+cirujano.Id);
            Console.WriteLine("Nombre: "+cirujano.Nombre);
            Console.WriteLine("Espeialidad: "+cirujano.Especialidad);
            Console.WriteLine("Area: "+cirujano.Area);
            Console.WriteLine("Correo: "+cirujano.Correo);
            Console.WriteLine();
            Console.WriteLine();

            Fisioteraupeuta fisioteraupeuta=new Fisioteraupeuta();
            fisioteraupeuta.Id=234332;
            fisioteraupeuta.Nombre="Jay";
            fisioteraupeuta.Consultorio="15-B";
            fisioteraupeuta.Area="Piso 19";
            fisioteraupeuta.Correo="FIsio@hotmail.com";


            Console.WriteLine("Datos del fisioterapeuta:");
            Console.WriteLine("Id: "+fisioteraupeuta.Id);
            Console.WriteLine("Nombre: "+fisioteraupeuta.Nombre);
            Console.WriteLine("Consultorio: "+fisioteraupeuta.Consultorio);
            Console.WriteLine("Area: "+fisioteraupeuta.Area);
            Console.WriteLine();
            Console.WriteLine();

            Hombre hombre=new Hombre();
            hombre.Nombre="Bruce Jenner(Caitlyn Jenner)";
            hombre.Estado="Estable";
            hombre.Enfermedad="Un poco de BOTOX";
            hombre.Fecha_de_nacimiento="Ni idea";

            Console.WriteLine("Datos del hombre;");
            Console.WriteLine("Nombre: "+hombre.Nombre);
            Console.WriteLine("Estado: "+hombre.Estado);
            Console.WriteLine("Enfermedad: "+hombre.Enfermedad);
            Console.WriteLine("Fecha de nacimiento "+hombre.Fecha_de_nacimiento);
            Console.WriteLine();
            Console.WriteLine();


            Mujer mujer=new Mujer();
            mujer.Nombre="Kim Kardashian";
            mujer.Estado="Fashionista";
            mujer.Enfermedad="Ponerse mas pompi";
            mujer.Fecha_de_nacimiento="Ni idea";

            Console.WriteLine("Datos del hombre;");
            Console.WriteLine("Nombre: "+mujer.Nombre);
            Console.WriteLine("Estado: "+mujer.Estado);
            Console.WriteLine("Enfermedad: "+mujer.Enfermedad);
            Console.WriteLine("Fecha de nacimiento "+mujer.Fecha_de_nacimiento);

            Console.ReadKey();

            


               



            

        }
    }
}
