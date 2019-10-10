using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    // Clase hija de persona y tiene otras clases hija
   public class Medico:Persona
    {
        // vamos a encapsular
        private int id;
        private string especialidad;

        public int Id { get; set; }
        public string Especialidad { get; set; }
    }
}
