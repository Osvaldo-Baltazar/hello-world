using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gasolineria
{
   public class Operacion
    {
        List<Empleado> empleados = new List<Empleado>();

        public void AgregarEmpleados()
        {
            Empleado E = new Empleado();

            E.Id = empleados.Count+1;
            Console.WriteLine("ID:"+E.Id);
            Console.WriteLine("Ingresa nombre:");
            E.Nombre = Console.ReadLine();
            Console.WriteLine("Ingresa Area:");
            E.Area = Console.ReadLine();
            Console.WriteLine("Ingresa Ocupación:");
            E.Ocupacion = Console.ReadLine();
            empleados.Add(E);
            Console.Clear();

            

        }
        public void DetallesAlumnos()
        {
            Empleado E = new Empleado();
            string Nombre = ObtenerNombre();
            foreach (Empleado Em in empleados)
            {
                if (Em.Nombre==Nombre)
                {
                    Console.WriteLine("ID:"+Em.Id+"\n"+"Ocupación:"+Em.Ocupacion+"\n"+"Area:"+Em.Area);
                }
                else
                {
                    Console.WriteLine("No existe el empleado");

                }

            }
            Console.ReadKey();
            Console.Clear();
        }
        public void MostrarListaEmpleados()
        {

            foreach(Empleado Em in empleados)
            {
                Console.WriteLine("Id:"+Em.Id+" "+"Nombre:"+" "+Em.Nombre);
            }
            Console.ReadKey();
            Console.Clear();

        }
        public string ObtenerNombre()
        {
            Empleado empleado = new Empleado();
            Console.WriteLine("¿Cual es el nombre del empleado?");
            empleado.Nombre = Console.ReadLine();

            return empleado.Nombre;

        }
    }
}
