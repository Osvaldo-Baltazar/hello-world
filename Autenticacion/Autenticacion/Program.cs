using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Autenticacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Registro registro = new Registro();
            Usuario usuario = new Usuario();
            usuario.Nombre = "Osvaldo Baltazar Martinez";
            usuario.Username = "Osvaldo1800";
            usuario.Password = "180100";
            registro.RegistrarUsuario(usuario, "archivo.txt");

            
            Login login = new Login();
            login.Bienvenido();
            login.Ingresar_Datos();

            Console.ReadKey();



            
        }

       


            


        


    }
}
