using System;
using System.Collections.Generic;
using System.Text;

namespace gyakorlás_1
{
    class Szemely
    {
        string nev;
        int suly;
        double magassag;

        public string Nev { get => nev; set => nev = value; }
        public int Suly { get => suly; set => suly = value; }
        public double Magassag { get => magassag; set => magassag = value; }

        public double tti()
        {
            return suly / (magassag * magassag);
        }
        public string jellemzo()
        {
            double seged=this.tti();
            if (seged < 18.5)
            {
                return "Sovány";
            }
            else if (seged > 25)
            {
                return "Kövér";
            }
            else return "Normál";
        }


        public override string ToString()
        {
            return $" Név :  {this.nev}, Súly: {this.suly}, Magasság: {this.magassag}, Tti alkat: {this.tti():n4},{this.jellemzo()}";
        }
        




    }
}
