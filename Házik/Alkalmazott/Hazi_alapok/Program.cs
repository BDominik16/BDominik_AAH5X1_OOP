using System;
using System.Linq;
using System.Collections.Generic;

namespace Hazi_alapok
{
    class Program
    {
        static void Main(string[] args)
        {
            Alkalmazott[] alkalmazott = new Alkalmazott[5];
            //Array.Resize(ref alkalmazott, alkalmazott.Length + 2);

            Ellenorzott(alkalmazott);
            Max(alkalmazott);
            Console.WriteLine($"Az átlagfizetés: {alkalmazott.ToList().Average(c => c.Fizetes)}");
            Console.WriteLine($"Az adó értéke: {alkalmazott.ToList().Sum(c => c.Adokulcs())}");


            int counter=0;
            for (int i = 0; i < alkalmazott.Length; i++)
            {
                if(alkalmazott[i].Hataron_belul(20000,200000))
                {
                    counter++;
                }
            }
            Console.WriteLine($"{counter} embernek benne van az intervallumba a fizetése");
            Console.ReadKey();
        }

        private static void Max(Alkalmazott[] alkalmazott)
        {
            int max = alkalmazott[0].Fizetes;
            string name = "";
            for (int i = 0; i < alkalmazott.Length; i++)
            {
                if (alkalmazott[i].Fizetes > max)
                {
                    max = alkalmazott[i].Fizetes;
                    name = alkalmazott[i].Nev;
                }
            }
            Console.WriteLine($"{max}, {name}");

        }

        private static void Ellenorzott(Alkalmazott[] alkalmazott)
        {
            for (int i = 0; i < alkalmazott.Length; i++)
            {
                string s = Console.ReadLine();
                int szam;
                bool ok;
                do
                {
                    ok = Int32.TryParse(Console.ReadLine(), out szam);
                    if (ok)
                    {
                        alkalmazott[i] = new Alkalmazott(s, szam);
                    }
                } while (!ok);


            }
        }
    }
}
