using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
   public class Figura
    {
       

        public virtual void Saludar ()
        {
            // Con elementos en clases bases que son sobre escrito en una clase 
            Console.WriteLine("Esta figura geometrica");
        }

        public virtual double Area(double LadoA, double Lado_B)
        {
            Console.WriteLine("Ingrese Lado 1: ");
            Console.WriteLine("Ingrese Lado 2: ");
            double area = LadoA * LadoA;
            return area;

        }

        internal void Area()
        {
         

        }
    }
}
