using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea._6_Convertidor
{
   public class Operacion
    {

        // Aqui etan una sobrecarga de metodos para hacer las conversiones que 
        // El usuario elija y cada metodo debe tener parametros diferenctes
        public double Conversiones(double Metros, double Centimetros, double C )
        {
            double Total = Metros / 100;
            return Total;
        }

        public double Conversiones(double Metros, double Pulgadas)
        {
            double Total = Metros * 39.37;
            return Total;
        }

        public double Conversiones(double Litros)
        {
            double Total = Litros * 1000;
            return Total;

        }

    }
}
