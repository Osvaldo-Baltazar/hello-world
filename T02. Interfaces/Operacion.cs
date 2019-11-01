using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T02.Interfaces
{
    public class Operacion : Valores ,IDivision_Multiplicacion, ISuma_Resta
    {
        // Aqui con ayuda de las interfaces y la herencia creamos lo metodos 
        public void Dividir()
        {
            double res;
           Console.WriteLine("Dividir:");
            Console.WriteLine("Ingrese el numero que quiere dividir:");
            Numero_1 =Convert.ToDouble( Console.ReadLine());
            Console.WriteLine("Ingrese el divisor");
            Numero_2 = Convert.ToDouble(Console.ReadLine());

            res = Numero_1 / Numero_2;
            

            Console.WriteLine("El resultado es: " + res);
          


        }

        public void Mutiplicar()
        {

            double res;
            Console.WriteLine("Multiplicar:");
            Console.WriteLine("Ingrese el primer numero:");
            Numero_1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el otro numero");
            Numero_2 = Convert.ToDouble(Console.ReadLine());

            res = Numero_1 * Numero_2;


            Console.WriteLine("El resultado es: " + res);

        }

        public void Resta()
        {
            double res;
            Console.WriteLine("Restar:");
            Console.WriteLine("Ingrese el primer numero:");
            Numero_1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            Numero_2 = Convert.ToDouble(Console.ReadLine());

            res = Numero_1 - Numero_2;


            Console.WriteLine("El resultado es: " + res);

        }

        public void Suma()
        {
            double res;
            Console.WriteLine("Sumar:");
            Console.WriteLine("Ingrese el primer numero:");
            Numero_1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            Numero_2 = Convert.ToDouble(Console.ReadLine());

            res = Numero_1 + Numero_2;


            Console.WriteLine("El resultado es: " + res);

        }
    }
}
