using System;

namespace Conversiones
{
   public class Operacion
    {
    
        

            
             public void Convertir(int Total_Centavos,out int Pesos, out int Centavos)
        {
            Pesos = Total_Centavos / 100;
            Centavos = Total_Centavos % 100;
        }
        
            
        
        
    }
}