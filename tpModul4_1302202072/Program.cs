using System;


namespace tpModul4_1302202072 
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            HaloGeneric halo = new HaloGeneric();
            halo.SapaUser<String>("razqy");
            
            DataGeneric<String> NIM = new DataGeneric<string>("1302202072");
            NIM.printData();
            
        }
    }
}
