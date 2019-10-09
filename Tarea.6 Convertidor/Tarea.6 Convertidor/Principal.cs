using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea._6_Convertidor
{
   public class Principal
    {
        // Aqui vamos a hacer la bienvenida de nuestro programa y 
        // El menu para que el usuario pueda escoger la conversion necesaria

        public void Bienvenida()
        {
            Console.WriteLine("Bienvenido al menu de conversiones");
            Menu();
        }

        public void Menu()
            // Aqui se muestra el menu
        {
            Console.WriteLine("Elige la opcion deseada:");
            Console.WriteLine("1. De centimetros a Metros");
            Console.WriteLine("2. De Metros a Pulgadas");
            Console.WriteLine("3. De litros a Mililitros");
            Console.WriteLine("4. Salir ");

            int Eleccion = Convert.ToInt32(Console.ReadLine());
            Operacion ope = new Operacion();

            // Aqui vamos a agregar un swich para que el usuario elija que opcion quiere
            // 
            switch(Eleccion)
            {
                case 1:
                    Console.WriteLine("Centimetros:");
                    double Centi = Convert.ToDouble(Console.ReadLine());
                    double Conv = ope.Conversiones(Centi, 0, 0);
                    Console.WriteLine(" El resultado en metros es: "+Conv);
                    break;

                case 2:
                    Console.WriteLine("Metros:");
                    double Metros = Convert.ToDouble(Console.ReadLine());
                    double Conv2 = ope.Conversiones(Metros, 0 );
                    Console.WriteLine(" El resultado en pulgadas es: " + Conv2);
                    break;

                case 3:
                    Console.WriteLine("Litros:");
                    double Mililitros = Convert.ToDouble(Console.ReadLine());
                    double Conv3 = ope.Conversiones(Mililitros);
                    Console.WriteLine(" El resultado en mililitros : " + Conv3);
                    break;

                case 4:
                    
                    break;

            }

        }

    }
}
