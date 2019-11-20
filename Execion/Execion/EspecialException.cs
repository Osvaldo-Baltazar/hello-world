using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execion
{
   public class EspecialException: ApplicationException
    {
        public  EspecialException()
        {

        }
        public  EspecialException(string arg):base(arg)
        {

        }
    }
}
