using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecarga_Multiplicacion
{
    class Program
    {
        static void Main(string[] args)
        {

            //Aqui se instancia la clase operacion
            Operacion OP = new Operacion();

            OP.Multiplicar();

            //Declaracion de variables 
            var Resp1 = OP.Multiplicar(2, 3);
            var Resp2 = OP.Multiplicar(5);
            var Resp3 = OP.Multiplicar();

            //Mandamos imprimir resultado

            Console.WriteLine("El resultado 1 es igual a:" + Resp1);
            Console.WriteLine("El resultado 2 es igual a:" + Resp2);
            Console.WriteLine("El resultado 3 es igual a:" + Resp3);

            Console.ReadKey();
            //Llamamos a la clase datos y la instanciamos
            Datos d = new Datos();
            d.Obtener_Datos();
        }
    }
}
