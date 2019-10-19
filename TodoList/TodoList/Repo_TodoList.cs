using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList
{
    class Repo_TodoList
    {
        // Aqui vamos a crear la lista global para que se pueda ver en los demas metodos

            List<Tarea> tareas=new List<Tarea>();
        Principal principal;
        public void Crear_Lista()
        {
            // Esto es el metodo deagregar lista y se guardara en la lista
            Tarea tarea=new Tarea();
            Console.WriteLine("Nombre del usuario: ");
            tarea.Nombre=Console.ReadLine();
            Console.WriteLine("Nombre de la tarea a realizar: ");
            tarea.Tareas=Console.ReadLine();
            Console.WriteLine("Fecha a realizar: (EScriba como el ejemplo= 11/12/19 ");
            tarea.Fecha=Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Horario a realizar;");
            tarea.Horario=Console.ReadLine();
            Console.WriteLine("Estatus: ");
            
           tareas.Add(tarea);
            Console.Clear();
            

        }
 
        public void Ver_Lista()
        {
            principal=new Principal();
            foreach(Tarea tare in tareas)
                {
                Console.WriteLine(tare.Tareas);
                }
            Console.ReadKey();
            Console.Clear();

        }
        // Aqui vamos a ver los detalles de la lista como el nombre y eso 
        public void Detalles()
        {
            principal=new Principal();
            Tarea tarea=new Tarea();
            DateTime datos = Datos_O();

            var Lista1= tareas;
           
            foreach(var Tare1 in Lista1)
                {
                if (datos==Tare1.Fecha)
                    {
                    Console.WriteLine("La hora:\n"+Tare1.Horario+"\n"+"La fecha:\n"+Tare1.Fecha+"\n"+"Nombre:\n" +Tare1.Nombre+"\n"+"Actividad: \n"+Tare1.Tareas);
                    }
                }
            Console.ReadKey();
            Console.Clear();
             
        }
        // Metodo
        public void Agregar_Estatus()
        {
            principal=new Principal();
            Tarea tares =new Tarea();
            DateTime datos= Datos_O();
             var Lista1= tareas;


            // Esto es para agregar el estatus

            foreach(var Tare1 in Lista1)
                {
                if (datos==Tare1.Fecha)
                    {
                    Console.WriteLine("Estatus:");
                    Tare1.Estatus=Console.ReadLine();
                    Console.WriteLine("El estatus es:"+Tare1.Estatus);
                    }
                }
            Console.ReadKey();
            Console.Clear();



        }
        // Aqui se ingresara la fecha de la actividad para que llenemos el estatus de la actividad

        public DateTime Datos_O()
            {
            Console.WriteLine("Infrese la fecha de la actividad");
            DateTime date= Convert.ToDateTime(Console.ReadLine());
            return(date);

            }
    }
}
