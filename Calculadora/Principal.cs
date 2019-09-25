using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Principal
    {
        public void Bienvenido_menu()
            {
            Console.WriteLine("Bienvenido al menu de esta calculadora");
         }
        
        public void Salir()
            {
            Environment.Exit(0);
         }

        public void Menu_Calculadora()
            {
            Console.WriteLine("Escribe el nombre de la operacion que realizaras");
            Console.WriteLine("SUMA");
            Console.WriteLine("RESTA");
            Console.WriteLine("DIVISION");
            Console.WriteLine("MULTIPLICACION");
            Console.WriteLine("SALIR");
            int OP= Convert.ToInt32(Console.ReadLine());
            
            Operacion Me=new Operacion();
            if
                {

                double P=0;

                // Vamos a crear el switch para la operacion
                switch(OP)
                    {

                    case 1:
                        Valores Resultado_S =new Valores();
                        Console.WriteLine("Ingrese los dos valores");
                        Console.WriteLine("Ingresa el Valor A");
                        Resultado_S.Valor_A=Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Ingresa el Valor B");
                        Resultado_S.Valor_B=Convert.ToDouble(Console.ReadLine());

                        P=Me.Sumar(Resultado_S);
                        Console.Clear();

                        break;


                        case 2:
                        Valores Resultado_R =new Valores();
                        Console.WriteLine("Ingrese los dos valores");
                        Console.WriteLine("Ingresa el Valor A");
                        Resultado_R.Valor_A=Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Ingresa el Valor B");
                        Resultado_R.Valor_B=Convert.ToDouble(Console.ReadLine());

                        P=Me.Resta(Resultado_R);
                        Console.Clear();

                        break;

                        case 3:
                        Valores Resultado_M =new Valores();
                        Console.WriteLine("Ingrese los dos valores");
                        Console.WriteLine("Ingresa el Valor A");
                        Resultado_M.Valor_A=Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Ingresa el Valor B");
                        Resultado_M.Valor_B=Convert.ToDouble(Console.ReadLine());

                        P=Me.Multiplicar(Resultado_M);
                        Console.Clear();

                        break;

                        case 4:
                        Valores Resultado_D =new Valores();
                        Console.WriteLine("Ingrese los dos valores");
                        Console.WriteLine("Ingresa el Valor A");
                        Resultado_D.Valor_A=Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Ingresa el Valor B");
                        Resultado_D.Valor_B=Convert.ToDouble(Console.ReadLine());

                        P=Me.Dividir(Resultado_D);
                        Console.Clear();

                        break;

                        case 5:
                        Console.WriteLine("Salir");
                        Salir();

                        break;
                        default:
                        Console.WriteLine("Incorrecto");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                        }


                }
            }
    }
        }
