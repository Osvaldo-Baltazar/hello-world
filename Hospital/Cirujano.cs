using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    // La otra clase hija de medico
   public class Cirujano:Medico
    {
       // Igual encapsular y los demas atributos estan en la clase hija medico que le heredara sus atributos
        private string area;
        public string Area { get; set; }
    }
}
