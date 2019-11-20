using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoData1
{
   public class Tarea
    {
        public string User { get; set; }
        public string Name { get; set; }
        // description para la descripcion de la tarea
        public string Description { get; set; }
        
        //date se usara con un datetime por que sera para una fecha
        public string Date { get; set; }
        //el status se usara para el estatus de la tarea
        public string Status { get; set; }
        //para la hora de la tarea
        public string Hour { get; set; }
        //para el update del status
        public int IndexRow { get; set; }
    }
}
