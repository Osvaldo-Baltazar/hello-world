using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    // Clase hija
   public class Fisioteraupeuta:Persona
    {
        // Vamos a encapsular
        private int id;
        private string area;
        private string consultorio;

        public int Id { get; set; }
        public string Area { get; set; }
        public string Consultorio { get; set; }
    }
}
