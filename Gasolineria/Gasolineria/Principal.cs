using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gasolineria
{
    public class Principal:Operacion
    {

        public void Bienvenido()
        {
            Console.WriteLine("==BIENVENIDO==");

            Menu();
        }
        public void Menu()
        {
           
            Console.WriteLine("\n1-.Agregar empleados\n2-.Mostrar lista de empleados\n3-.Detalles del empleado");

            switch (Console.ReadLine())
            {
                case "1":
                    AgregarEmpleados();
                    break;
                case "2":
                    MostrarListaEmpleados();
                    break;
                case "3":
                    DetallesAlumnos();
                    break;
            }
            Bienvenido();
        }
    }
}
