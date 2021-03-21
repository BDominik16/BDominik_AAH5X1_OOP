using System;
using System.Collections.Generic;
using System.Text;

namespace Hazi_alapok
{
    class Alkalmazott 
    {
        string nev;
        int fizetes;

        public Alkalmazott(string nev, int fizetes)
        {
            this.nev = nev;
            this.fizetes = fizetes;
        }

        public Alkalmazott(string nev) : this(nev,250000)
        {
        }

        public string Nev { get => nev; set => nev = value; }
        public int Fizetes { get => fizetes; set => fizetes = value; }


        public void Novel(int szam)
        {
            this.fizetes += szam;
        }

        public override string ToString()
        {
            return $"{this.nev}, {Fizetes}";
        }

        public bool Hataron_belul(int also, int felso)
        {
           return ((this.fizetes>=also) && (this.fizetes<=felso)) ?   true :  false;
        }
       
        public double Adokulcs()
        {
            return Fizetes * 0.16;
        }

        public bool Nagyobbe(Alkalmazott elso)
        {
            if(this.fizetes> elso.Fizetes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
