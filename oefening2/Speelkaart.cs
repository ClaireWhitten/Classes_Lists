using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefening2
{
    enum Kleur {Schoppen, Haarten, Klaveren, Ruiten};
    class Speelkaart
    {
        private int getal;

        public int Getal
        {
            get { return getal; }
            set { 
                if(value >= 1 && value <= 13)
                getal = value; 
                }
        }

        private Kleur kleur;

        public Kleur Kleur
        {
            get { return kleur; }
            set {
                kleur = value; 
                }
        }

        

    }
}
