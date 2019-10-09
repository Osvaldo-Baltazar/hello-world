using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea._6_Convertidor
{
    class Program
    {
        static void Main(string[] args)
        {
            // Aqui mandamos a llamar a la clase principal
            // Para que se muestre el menu
            Principal Prin = new Principal();
            Prin.Bienvenida();
            Console.ReadKey();
        }
    }
}
