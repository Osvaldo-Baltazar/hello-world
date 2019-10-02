using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversiones_2
{
   public class Operaciones
    {
        public void Convertir(int Total_Centavos,out int Pesos, out int Centavos)
        {
            Pesos = Total_Centavos / 100;
            Centavos = Total_Centavos % 100;
        }
    }
}
