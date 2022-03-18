using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpModul4_1302202072
{
    internal class DataGeneric<T>
    {
        private T data;

        public DataGeneric(T value)
        {
            this.data = value;
        }

        public void printData()
        {
            Console.WriteLine("Data yang tersimpan adalah: {0}", this.data);
        }

    }
}
