using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Errores
{
    class Program
    {
        static void Main(string[] args)
        {
            // Vamos a crear uba lista y unos objetos para luego pedir 
            var estudiante = new List<Estudiante>();

            var agregar = true;

            while(agregar)
            {              

                try
                {
                    // Vamos a llamar a la clase para pedir lo que ocupemos
                    var E = new Estudiante();
                    int Ma = E.Matricula;

                    Console.WriteLine("Ingrese Matricula:");
                    
                    // Este es para que cuando el usuario no ingrese lo que sea un numero en este ejemplo mande el aviso en el console
                    //Write line y le diga que ingrese el numero
                     int.TryParse(Console.ReadLine(), out Ma);
                    if (Ma == 0)
                    {
                    //(Aqui muestra el mensaje
                     Console.WriteLine("Ingrese un numero");
                    Console.WriteLine("Ingrese de nuevo la matricula");
                    int.TryParse(Console.ReadLine(), out Ma);

                     }

                    Console.WriteLine("Ingrese Nombre:");
                    E.Nombre = Console.ReadLine();
                    Console.WriteLine("Ingrese Carrera:");
                    E.Carrera = Console.ReadLine();
                    Console.WriteLine("Ingrese Semestre:");
                    E.Semestre = Convert.ToInt32(Console.ReadLine());
                    //Aqui va a ser un tipo de break´point y es como el primero que hicimos para mostrar que no ingreso bien lo que se le pidio
                    //int matricula;
                    //bool result;

                    //result = int.TryParse(Console.ReadLine(), out matricula);

                    //if (result == false) ;
                    //{
                      //  Console.WriteLine("ingrese un numero");
                        //continue;
                    //}



                    Console.WriteLine("¿Quiere agregar otro usuario V/N");
                    if (Console.ReadLine() == "N")
                    {
                        agregar = false;
                    }


                }
                // Cuando nos equivoquemos va a aparecer este mensaje 
                catch(Exception ex)
                {
                    Console.WriteLine("Intenta nuevamente");
                }


            }
            
            Console.ReadKey();

            // CONCLUSION: Esto de excepciones es algo muy util por que si el usuario se equivoca manda el error y si esta facil para  hacerlo 
            // Ademas ue es buena opcion utilizar las excepciones para asi controlar los errores que podamos tener al crear nuetros codigos
            // Y eso nos ayuda ya que puede ocurrir algun error inesperado al momento de ejecutar el programa y el usuario no haga lo que se pide
            // 

        }
    }
}
