using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
   public class Triangulo:Figura
    {
        public override double Area(double LadoA, double LadoB)
        {
            double area = LadoA * LadoA / 2;
            return area;
        }
    }
}
