using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcular_Area
{
    class Lados
    {
        public void Datos()
        {
            // Aqui vamos a Instanciar la clase operacion

            Operacion ope = new Operacion();
            ope.Area();

            // Aqui va a estar el menu de bienvenida

            Console.WriteLine("Bienvenido al menu del las areas");
            Console.WriteLine("Calcular el area de un triangulo");
            Console.WriteLine("Ingresa los datos necesarios:");
            Console.WriteLine("Base:");
            double Base = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Altura:");
            double Altura = Convert.ToDouble(Console.ReadLine());
            double Entre = 2;


            double triangulo = ope.Area(Base, Altura, Entre);


            Console.WriteLine("El area del triangulo es:" + triangulo);
            Console.ReadKey();


            // Aqui vamos a abrir el metodo del cuadrado

            Console.WriteLine("Calcular area del cuadrado");
            Console.WriteLine("Ingresa los datos necesarios");
            Console.WriteLine("Lado:");
            double Lado1 = Convert.ToDouble(Console.ReadLine());

            double cuadrado = ope.Area(Lado1);

            Console.WriteLine("El area del cuadrado es:" + cuadrado);
            Console.ReadKey();

            // Aqui vamos a abrir el metodo del rectangulo

            Console.WriteLine("Calcular area del rectangulo");
            Console.WriteLine("Ingresa los datos necesarios");
            Console.WriteLine("Base:");
            double Lb = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Altura:");
            double Altu = Convert.ToDouble(Console.ReadLine());

            double rectangulo = ope.Area(Lb, Altu);
            Console.WriteLine("El area del rectangulo es :" + rectangulo);
            Console.ReadKey();


        }
    }
}
