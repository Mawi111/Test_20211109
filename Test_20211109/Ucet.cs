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
        float stav;
        const int Maxvklad = 200000;
        int mnozstvi;
        float Limitplatby;
        float Limitvyber;
        
       
        public Ucet(string Jmeno, float stav) 
        {
            Jmeno = jmeno;
            stav = stav;
        }
        public int Vlozit(int mnozstvi)
        {
            if (stav + mnozstvi > Maxvklad)
            {
                stav = Maxvklad;
                return Maxvklad;
            }
            else
            {
                stav += mnozstvi;
                return mnozstvi;
            }
        }
        public void Vybrat(int mnozstvi)
        {
            if(stav - mnozstvi < 0)
            {
                if (mnozstvi > Limitvyber)
                    stav += Limitplatby;
            }
            else 
            {
                stav += Limitvyber;
            }

        }
    }
}
