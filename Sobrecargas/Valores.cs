using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecargas
{
    class Valores
    {

        public void Obtener_Datos()
        {
            // Este sera el menu
            Console.WriteLine("Este sera el menu principal, bienvenido");
            Console.WriteLine("Ingrese 2 datos");
            Console.WriteLine("Dato1");

            double cool = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Dato2");
            double cool2 = Convert.ToDouble(Console.ReadLine());

            // Instanciaremos la clase operacion 
            Operacion OP = new Operacion();
            OP.Suma();

            // La operacion de los metodos 
            double Res = OP.Suma(cool, cool2);

            //Se manda imprimir el resultado
            Console.WriteLine("El resultado es" + Res);
            Console.ReadKey();
        }
    }
}

