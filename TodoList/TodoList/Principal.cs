using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList
    // Herencia
{
    class Principal:Repo_TodoList
    {
        // Aqui vamos a crear el menu bienvenida y el metodo men

        public void Bienvenida()
        {
            Console.WriteLine("Bienvenido a la lista  de tareas");
            Menu();
            Console.ReadLine();

        }

        public void Menu()
            // Aqui es el menu para que el usuario ingrese la opcion
        {
            Console.WriteLine("Elige la opcion que quieres:");
            Console.WriteLine("1.- Crear lista");
            Console.WriteLine("2.- Ver detalles de la tarea");
            Console.WriteLine("3.- Agregar estatus");
                           

            switch(Console.ReadLine()) 
                // Mandamos a llamar a la clase repo_list con herencia y que tengamos los metodos
                
                {
                case "1":
                    
                    Crear_Lista();
                    break;

                    case "2":
                    
                    Detalles();
                    break;

                    case "3":
                    
                    Agregar_Estatus();
                    break;

                   
                    
                }
            Menu();
          

        }

    }
}
