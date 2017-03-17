using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication43
{
    public class szöcske : lábas
    {
        public szöcske(int sorszám, int lábak) : base(sorszám, lábak)
        {
        }

        public void másnapléptek(double faktorális)
        {
            if (faktorális <= (1 / 3))
                távolság-= 1;
            else
                if (faktorális <= (2 / 3))
                    távolság+=2;



        }
    }
}