using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecarga_Multiplicacion
{
    class Operacion
    {

        // Aqui se escriben los 3 metodos para hacer la sobrecarga
        public double Multiplicar(double a, double b)
        {
            return a * b;
        }

        public double Multiplicar(double a)
        {
            return a;
        }

        public double Multiplicar()
        {
            return 0;
        }
    }
}

