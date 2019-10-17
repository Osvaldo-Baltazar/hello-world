using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_2
{
    public class Datos_Cuenta:Cuenta
    {
        public List<Pensiones> Cu_Pensiones()
        {
            // Aqui esta la lista de la clase pensiones  y se muestran los datos que tiene
            List<Pensiones> pensiones = new List<Pensiones>();
            pensiones.Add(new Pensiones { Numero_Cuenta = 12345, Saldo = 12.35M, Vencimiento = Convert.ToDateTime("11/05/2021"), Titular = "Juan Carlos Perez", Interes = 2.21, N_Cuenta_Origen = 12322, Cotizacion = 25 });
            pensiones.Add(new Pensiones { Numero_Cuenta = 12765, Saldo = 12.35M, Vencimiento = Convert.ToDateTime("14/03/2020"), Titular = "Juan  Perez", Interes = 2.21, N_Cuenta_Origen = 12323, Cotizacion = 25 });
            pensiones.Add(new Pensiones { Numero_Cuenta = 12876, Saldo = 12.35M, Vencimiento = Convert.ToDateTime("13/06/2023"), Titular = "Pedro Perez", Interes = 2.21, N_Cuenta_Origen = 12321, Cotizacion = 25 });
            pensiones.Add(new Pensiones { Numero_Cuenta = 12865, Saldo = 12.35M, Vencimiento = Convert.ToDateTime("13/02/2020"), Titular = "Pepe Perez", Interes = 2.21, N_Cuenta_Origen = 12365, Cotizacion = 25 });
            pensiones.Add(new Pensiones { Numero_Cuenta = 12475, Saldo = 12.35M, Vencimiento = Convert.ToDateTime("15/08/2022"), Titular = "Anotnio Torres", Interes = 2.21, N_Cuenta_Origen = 14322, Cotizacion = 25 });
            return pensiones;

        }
        public List<Cuenta_Ahorro> cuenta_ahorros()
        {
            List<Cuenta_Ahorro> cuenta_Ahorros = new List<Cuenta_Ahorro>();
            // Aqui esta la lista de la clase cuenta de ahorro
            cuenta_Ahorros.Add(new Cuenta_Ahorro { Numero_Cuenta = 11, Saldo = 2344343212.35M, Vigencia = Convert.ToDateTime("11/05/2021"), Titular = "Kris Jenner", Interes = 2.21  });
            cuenta_Ahorros.Add(new Cuenta_Ahorro { Numero_Cuenta = 12, Saldo = 4234353454353412.35M, Vigencia = Convert.ToDateTime("14/03/2020"), Titular = "Khloe Kardashian", Interes = 2.215 });
            cuenta_Ahorros.Add(new Cuenta_Ahorro { Numero_Cuenta = 13, Saldo = 2535453535353535312.35M, Vigencia = Convert.ToDateTime("13/06/2023"), Titular = "Kendall Jenner", Interes = 2.21 });
            cuenta_Ahorros.Add(new Cuenta_Ahorro { Numero_Cuenta = 14, Saldo = 3453535567657612.35M, Vigencia = Convert.ToDateTime("13/02/2020"), Titular = "Kylie Jenner", Interes = 2.21 });
            cuenta_Ahorros.Add(new Cuenta_Ahorro { Numero_Cuenta = 15, Saldo = 53253464565657562.35M, Vigencia = Convert.ToDateTime("15/08/2022"), Titular = "Kim Kardashian West", Interes = 2.213});

            return cuenta_Ahorros;

        }
        public List<Cuenta_Corriente> cuenta_corrientes()
        {

            List<Cuenta_Corriente> cuenta_Corrientes = new List<Cuenta_Corriente>();
            // Aqui esta la lista de la cuenta corriente
            cuenta_Corrientes.Add(new Cuenta_Corriente{ Numero_Cuenta = 19210465, Saldo = 170012123.00M,  Titular = "Osvaldo Baltazar", Interes = 1.21  });
            cuenta_Corrientes.Add(new Cuenta_Corriente { Numero_Cuenta = 123456, Saldo = 192232.35M,  Titular = "Christian Tarin", Interes = 2.21 });
            cuenta_Corrientes.Add(new Cuenta_Corriente { Numero_Cuenta = 98765, Saldo = 129922.35M,  Titular = "Stephanie De Anda", Interes = 2.21 });
            cuenta_Corrientes.Add(new Cuenta_Corriente { Numero_Cuenta = 192104, Saldo = 781.35M,  Titular = "Felix Enrique", Interes = 2.21 });
            cuenta_Corrientes.Add(new Cuenta_Corriente { Numero_Cuenta = 192105, Saldo = 887342.35M,  Titular = "Miguel Corrales", Interes = 2.21 });
            // Retorna el valor de la lista
            return cuenta_Corrientes;
        }
    }
}
