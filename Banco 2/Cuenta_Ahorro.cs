using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_2
{
    // La clase madre es cuenta y la clase hija es cuenta ahorro
   public class Cuenta_Ahorro:Cuenta
    {
        // Creamos atributos y los encapsulamos
        public DateTime Vigencia{ get; set; }

        public double IngresoPorMes()
        {
            return 0;
        }
    }
}
