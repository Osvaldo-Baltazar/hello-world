using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_2
{
   public class Cuenta
    {
        //Creación de Atributos Principales
        public int Numero_Cuenta { get; set; }

        public string Titular { get; set; }

        public decimal Saldo { get; set; }

        public double Interes { get; set; }

        // Aqui esta metodos 
        public bool Ingreso()
        {
            return false;

        }
        // Este es el metodo de interes por mes que se llamara en un switch en repobank
        public double Interesxmes(double interes)
        {
            var iTotal = Interes * .16;
            return iTotal;

        }
        // Este metodo se mandara a llamar para consultar el saldo en un switch
        public void ConsultarSaldo(Cuenta cuenta)
        {

            Console.WriteLine("Su saldo Actual es de  $" + cuenta.Saldo);
        }
        public void Tranferir( Cuenta cuenta)
        {
            Console.WriteLine("¿A que cuenta desea trasferir?");
            Console.ReadLine();
        }
    }
}
