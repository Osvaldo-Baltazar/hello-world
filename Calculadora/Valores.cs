using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
   public  class Valores
    {
        //Vamos a instanciar y a encapsular los objetos 
        private double valor_A;
        private double valor_B;
        private string operacion;
        private double resultado;


        public double Valor_A
            {
            get{return valor_A;}
            set{valor_A=value;}
}

        public double Valor_B
            {
            get{return valor_B;}
            set{valor_B=value;}

}

        public string Operacion
            {
            get{return operacion;}
            set{operacion=value;}
}
        public double Resultado
            {
            get{return resultado;}
            set{resultado=value;}

}


    }


}
