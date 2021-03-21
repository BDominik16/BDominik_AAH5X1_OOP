using System;
using System.Collections.Generic;
using System.Text;

namespace Konyv
{
    class Konyv
    {
        string cim;
        string szerzo;
        int meg_ev;
        double ar;

        public Konyv(string cim, string szerzo) : this(cim, szerzo, DateTime.Now.Year,2500)
        {
        }

        public Konyv(string cim, string szerzo, int meg_ev, double ar)
        {
            this.cim = cim;
            this.szerzo = szerzo;
            this.meg_ev = meg_ev;
            this.ar = ar;
        }

        public string Cim { get => cim; set => cim = value; }
        public string Szerzo { get => szerzo; set => szerzo = value; }
        public int Meg_ev { get => meg_ev; set => meg_ev = value; }
        public double Ar { get => ar; set => ar = value; }

        public void novel(double noveli)
        {
            noveli = noveli / 100;

            this.ar +=this.ar *noveli;
        }

        public override string ToString()
        {
            return $"{this.cim}, {this.szerzo}, {this.meg_ev}, {this.ar}";
        }
    }
}
