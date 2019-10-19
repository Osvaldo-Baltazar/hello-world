using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList
{
    class Program
    {
        static void Main(string[] args)
        {
            // Para que funcione el programa 
            Principal principal = new Principal();
            principal.Bienvenida();
            Console.ReadKey();
        }
    }
}
