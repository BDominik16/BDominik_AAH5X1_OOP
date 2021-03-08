using System;

namespace gyakorlás_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Szemely szemely = new Szemely();
            Console.WriteLine("Kérem a nevet, súlyt, magasságot");
            szemely.Nev=Console.ReadLine();
            szemely.Suly = Convert.ToInt32(Console.ReadLine());
            szemely.Magassag =Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(szemely.ToString());
            Console.ReadKey();
        }
    }
}
