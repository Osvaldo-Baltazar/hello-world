using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;


namespace Autenticacion
{
    public class Registro
    {
        // Metodos

        public void RegistrarUsuario(Usuario u, string path)
        {
            string data = u.Nombre + "," + u.Username + "," + u.Password;
            var datos = ObtenerLineas(path);
            if (datos != null)
            {
                datos.Add(data);
                File.WriteAllLines(path, datos);
            }
            else
            {

                File.WriteAllText(path, data);
            }
        }
        // Lista
        public List<string> ObtenerLineas(string ruta)
        {
            string[] data = null;
            //Esto es ara saber si existe el archivo
            if (File.Exists(ruta))
            {
                data = File.ReadAllLines(ruta);
            }
            //es el codigo que va a marcar error si es que el archivo no esta disponible
            else
            {
                Console.WriteLine("Este archivo no esta disponible o no existe");
                return null;
            }
            

            List<string> datos = new List<string>();

            foreach (var item in data)
            {
                datos.Add(item);
            }

            return datos;
        }



    }
}
