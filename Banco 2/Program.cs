using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Se manda a llamar a la clase en donde esta todo
            RepoBank r = new RepoBank();
            r.Principal();

            Console.ReadKey();
        }
    }
}
