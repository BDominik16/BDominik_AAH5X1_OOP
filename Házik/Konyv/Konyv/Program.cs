using System;

namespace Konyv
{
    class Program
    {
        static void Main(string[] args)
        {
            Konyv konyv = new Konyv("Egri Csillagok", "Gárdonyi", 1901, 5);
            
            Console.WriteLine(konyv.ToString());
            Console.ReadKey();
        }
    }
}
