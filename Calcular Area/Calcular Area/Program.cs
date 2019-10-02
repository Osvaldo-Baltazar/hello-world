using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcular_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            // Aqui vamos a llamar a la clase para luego poderinstanciarla

            Lados lados = new Lados();
            lados.Datos();
            Console.ReadKey();
        }
    }
}
