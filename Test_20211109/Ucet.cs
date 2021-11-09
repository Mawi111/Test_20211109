using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_20211109
{
    class Ucet
    {
        string jmeno;
        float Stav;
        const int Maxvklad = 200000;
        int mnozstvi;
        float Limitplatby;
        float Limitvyber;
       
        public Ucet(string Jmeno, float stav) 
        {
            Jmeno = jmeno;
            Stav = stav;
        }
        public int Vlozit(int mnozstvi)
        {
            if (Stav + mnozstvi > Maxvklad)
            {
                Stav = Maxvklad;
                return Maxvklad;
            }
            else
            {
                Stav += mnozstvi;
                return mnozstvi;
            }
        }
        public void Vybrat(int mnozstvi)
        {
            if(Stav - mnozstvi < 0)
            {
                if (mnozstvi > Limitvyber)
                    Stav += Limitplatby;
            }
            else 
            {
                Stav += Limitvyber;
            }

        }
    }
}
