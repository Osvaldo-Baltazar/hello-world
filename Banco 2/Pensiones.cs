using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_2
{
    // Es la clase madre y hija
   public class Pensiones:Cuenta
    {
        // Estamos dando los atributos y encapsulando
        public DateTime Vencimiento { get; set; }
        public int Cotizacion { get; set; }
        public int N_Cuenta_Origen { get; set; }
    }
}
