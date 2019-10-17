using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_2
{
    // Aqui se v mira que la clase cuenta es la clase madre de esta
   public class RepoBank:Cuenta
    {
        Datos_Cuenta ad;
        public RepoBank()
        {
            ad = new Datos_Cuenta();
        }
        // Aqui estamos creando el menu principal de lo del codigo o la bienvenida
        internal void Principal()
        {
            Console.WriteLine("Bienvenidos al Bancomeme");
            Menu();
            Console.ReadLine();
        }
          // Aqui va a estar el menu de las opciones
        private void Menu()
        {
            Console.WriteLine("Ingrese a la Opcion que desea realizar");
            Console.WriteLine("1.- Cuenta Ahorro");
            Console.WriteLine("2.- Pensiones");
            Console.WriteLine("3.- Cuenta Corriente");
            switch (Console.ReadLine())
            {
                // Aqui esta el swhich para  que el usuario eliga la opcion que quiere de lo que quiere hacer
                case "1":
                    Console.WriteLine("Bienvenido a Cuenta Ahorro");
                    Cuenta_de_Ahorro();
                    break;
                case "2":
                    Console.WriteLine("Bienvenido a Pensiones");
                    GetDataPension();

                    break;

                case "3":
                    Console.WriteLine("Bienvenido a Cuenta Corriente");
                    cuenta_corriente();
                    break;

                default:
                    break;
            }
        }
        // Aqui esta el metodo para que en la cuenta corriente se ingrese el valor y se muestre ahi y
        // se llama al metodo get data que va a ser el valor que va a recibir los valores y retornarlos

        private void GetDataCurrent()
        {
            int number = GetData();

        }


        // Lo mismo que el en GetDataCurrent 
        private void GetDataPension()
        {
            int number = GetData();
            var lista = ad.Cu_Pensiones();
            Pensiones pensiones = new Pensiones();

            foreach (var cuenta in lista)
            {
                if (number == cuenta.Numero_Cuenta)
                {
                    pensiones = cuenta;
                }
                //Console.WriteLine(item.Headline);
            }

            Console.WriteLine("Bienvenido " + pensiones.Titular);

            MenuUsuario(pensiones);
        }
        // Ya que el usuario ingreso su numero de cuenta aparecera este menu y va a estar igual que en las diferentes cuentas
        private void MenuUsuario(Cuenta pensiones)
        {
            Console.Clear();
            Console.WriteLine("Bienvenido a tu Cuenta :" + pensiones.Titular);
            Console.WriteLine("1.- Consultar Saldo");
            Console.WriteLine("2.- Transferir ");
            Console.WriteLine("Interes por mes");
            Console.WriteLine("Ingreso");
            Console.WriteLine("Elije una Opcion");
            decimal pe= pensiones.Saldo;

            switch (Console.ReadLine())
            {
                // Aqui este switch es para hacer las operaciones que quiere que realize el el programa y aqui elige el usuario
                case "1":
                    pensiones.ConsultarSaldo(pensiones);
                    break;
                case "2":
                    pensiones.Tranferir(pensiones);


                    break;
                case "3":
                 decimal peT=pensiones.Interesxmes( pe);
                    

                    break;
                case "4":

                    break;

                default:
                    break;
            }

        }

        private void GetDataSave()
        {
            int number = GetData();
        }
        // Este metodo es para que ingrese el numero de cuenta y manda el valor a el metodo de cuenta que eligio
        private int GetData()
        {
            Console.WriteLine("Ingrese Su Numero de Cuenta");
            string respuesta = Console.ReadLine();
            return Convert.ToInt32(respuesta);
        }

        private void cuenta_corriente()
        {
            // Aqui esta la  lista de la cuenta corriente en donde esta todos los datos 

            int number = GetData();
            var lista = ad.cuenta_corrientes();
            Cuenta_Corriente cuenta_Corriente = new Cuenta_Corriente();

            foreach (var cuenta in lista)
            {
                if (number == cuenta.Numero_Cuenta)
                {
                    cuenta_Corriente = cuenta;
                }
                //Console.WriteLine(item.Headline);
            }

            Console.WriteLine("Bienvenido " + cuenta_Corriente.Titular);

            MenuUsuario(cuenta_Corriente);
        }

        private void Cuenta_de_Ahorro()
        {
            // Aqui esta la  lista de la cuenta cuenta ahorro y estan todos los datos
            int number = GetData();
            var lista = ad.cuenta_ahorros();
            Cuenta_Ahorro cuenta_Ahorro = new Cuenta_Ahorro();

            foreach (var cuenta in lista)
            {
                if (number == cuenta.Numero_Cuenta)
                {
                    cuenta_Ahorro = cuenta;
                }
                //Console.WriteLine(item.Headline);
            }
            // Se imprime la bienvenida al la cuenta del usuario
            Console.WriteLine("Bienvenido " + cuenta_Ahorro.Titular);

            MenuUsuario(cuenta_Ahorro);


        }

    }
}
