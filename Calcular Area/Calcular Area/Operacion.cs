using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcular_Area
{
   public class Operacion
    {

        public double Area(double Lado_Base,double Lado_Altura, double Lc=2 )
        {
            double T = (Lado_Base * Lado_Altura) / Lc;
            return T;

        }

        public double Area(double Lado_Base,double Lado_Altura)
        {
            double RE = Lado_Base * Lado_Altura;
            return RE;

      
        }


        public double Area(double Lado)
        {
            double Cu = Lado * Lado;
            return Cu;
        }

        public int Area()
        {
            return 0;
        }
    }
}
