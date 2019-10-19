using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList
{
   public class Tarea
    {
        // Agrgrando atributos que utilizaremos en el reoo_todolist
        public string Nombre { get; set; }
        public string Tareas { get; set; }
        public string Horario { get; set; }
        public DateTime Fecha { get; set; }
        public string Estatus { get; set; }
    }
}
