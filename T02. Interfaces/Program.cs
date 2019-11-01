using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T02.Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lamamos a la clase principal que es en donde esta todo
            Principal principal = new Principal();
            principal.Bienvenido();
            Console.ReadKey();
        }
    }
}
