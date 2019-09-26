using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecargas
{
    class Program
    {
        static void Main(string[] args)
        {

            // Vamos a intanciar la clase de operacion
            Operacion OP = new Operacion();

            OP.Suma();

            // Declaracion de las variables 
            var Resp1 = OP.Suma(2, 3);
            var Resp2 = OP.Suma(20);
            var Resp3 = OP.Suma();

            //Mandamos imprimir resultado

            Console.WriteLine("El resultado 1 es igual a:" + Resp1);
            Console.WriteLine("El resultado 2 es igual a:" + Resp2);
            Console.WriteLine("El resultado 3 es igual a:" + Resp3);

            Console.ReadKey();

            //Llamamos a la clase de valores
            Valores d = new Valores();
            d.Obtener_Datos();
        }
    }
}
