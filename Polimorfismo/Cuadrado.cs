using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
   public class Cuadrado:Figura
    {
        public override void Saludar()
        {
            
            Console.WriteLine("Esto es un cuadrado");
        }

        public override double Area(double LadoA, double LadoB)
        {
            double area = LadoA * LadoB;
            return area;
        }
    }

    }

