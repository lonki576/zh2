using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication43
{
    public class róka : lábas
    {
        public róka(int sorszám, int lábak) : base(sorszám, lábak)
        {
        }

        public void bizalmatlan()
        {
            távolság += 2;
        }
    }
}