using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T02.Interfaces
{
   public class Principal
    {
        // Llamamos a la clase operacion para que en en menu puedan  ponerse los metodos 
        Operacion operacion = new Operacion();

        // Aqui esta en metodo de bienvenida y llamamos al metodo menu que hara todo lo demas
        public void Bienvenido()
        {
            Console.WriteLine("Bienvenido al menu de esta calculadora chida");

            Menu();
            Console.ReadKey();

        }

        public void Menu()
        {
            // Las opciones que el usuario eligira
            Console.WriteLine("Elige la opcion deseada");
            Console.WriteLine("1.- Sumar");
            Console.WriteLine("2.- Restar");
            Console.WriteLine("3.- Multiplicar");
            Console.WriteLine("4.- Dividir");
            Console.WriteLine("5.- Salir del programa");

            switch(Console.ReadLine())
            {
                case "1":
                    operacion.Suma();

                    break;
                case "2":
                    operacion.Resta();

                    break;
                case "3":
                    operacion.Mutiplicar();

                    break;
                case "4":

                    operacion.Dividir();
                    break;
                case "5":

                    Environment.Exit(0);
                    break;

            }
            // Para volver al menu 
            Menu();

        }

    }
}
