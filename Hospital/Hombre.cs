using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    // Clase hija
   public class Hombre:Persona
    {
        // Lo mismo jaja
         private string enfermedad;
        private string estado;

        public string Enfermedad { get; set; }
        public string Estado { get; set; }
    }
}
