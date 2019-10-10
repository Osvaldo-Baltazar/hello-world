using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    // Esta va a ser la super clase
   public class Persona
    {
        // Estos son los atributos que todos tienen en comun 
        private string nombre;
        private string fecha_de_nacimiento;
        private string correo;

        public string Nombre { get; set; }

        public string   Fecha_de_nacimiento { get; set; }

        public string Correo { get; set; }
    }
}
