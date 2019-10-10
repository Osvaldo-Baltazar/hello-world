using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    // Clase hija 
   public class Enfermera: Persona
    {
        private int id;
        private string area;


        public int Id { get; set; }

        public string Area { get; set; }
    }
}
