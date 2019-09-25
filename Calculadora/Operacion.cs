using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Operacion
    {

        // Vamos a llamar al metodo de suma
        public double Sumar(Valores suma)
            {
              
            double resultado= suma.Valor_A+suma.Valor_B;
            Console.WriteLine("El resultado es {0}",resultado);
            Console.ReadKey();
            Console.Clear();
            return resultado;

            }
        public double Restar(Valores restar)

            {
            double resultado=restar.Valor_A-restar.Valor_B;
            Console.WriteLine("El rsultado es {0}",resultado);
            Console.ReadKey();
            Console.Clear();
            return resultado;

            }
        public double Dividir(Valores dividir)

            {
            double resultado=dividir.Valor_A/dividir.Valor_B;
            Console.WriteLine("El rsultado es {0}",resultado);
            Console.ReadKey();
            Console.Clear();
            return resultado;

            }
        public double Multiplicar(Valores multiplicar)

            {
            double resultado=multiplicar.Valor_A*multiplicar.Valor_B;
            Console.WriteLine("El rsultado es {0}",resultado);
            Console.ReadKey();
            Console.Clear();
            return resultado;

        }
        


        
    }
}
