using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication43
{
    public class hóvirág : versenyző
    {
        public hóvirág(int sorszám) : base(sorszám)
        {
        }

        public void legyökerez()
        {
            távolság = 0;
        }
    }
}