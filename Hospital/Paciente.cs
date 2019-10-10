using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    // Esta es lqa clase hija
   public class Paciente: Persona
    {
        // Vamos a encapsular estos atributos
        private int id;
        private string tipo_paciente;

        public int Id { get; set; }

        public string Tipo_Paciente { get; set; }
    }
}
