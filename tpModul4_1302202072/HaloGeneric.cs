using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpModul4_1302202072
{
    public class HaloGeneric
    {
        
        public void SapaUser<T>(T value)
        {
            Console.WriteLine("Halo User {0}",value);
        }
    }
}
