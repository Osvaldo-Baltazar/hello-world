using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversiones_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Vamos a declarar las variables
            int Total_centavos;
            int Pesos = 0;
            int Centavos = 0;

            // Vamos a intanciar la clase operaciones
            Operaciones Ope = new Operaciones();

            Console.WriteLine("Bienvenido al menu del conversiones");
            Console.WriteLine("Introduce la cantidad de centavos");
            Total_centavos = Convert.ToInt32(Console.ReadLine());

            Ope.Convertir( Total_centavos, out  Pesos, out Centavos);

            // Aqui se va a imprimir los resultados de las conversiones que hagamos

            Console.WriteLine("Los pesos de la conversion seran:" + Pesos);
            Console.WriteLine("Los centavos de la conversion seran:" + Centavos);
            Console.ReadKey();



            
                

        }
    }
}
