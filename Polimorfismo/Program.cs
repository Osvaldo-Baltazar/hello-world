using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Figura f; // Aqui esta llamando a la clase madre y que tiene herencias
            f = new Figura(); // Vamos a llamar a la clase
            f.Saludar();// Que seimprima el resultado 

            f = new Cuadrado();// Igual que en la primera
            f.Saludar();
            f.Area();

            f = new Triangulo();
            f.Area();

            Console.ReadKey();
        }
    }
}
