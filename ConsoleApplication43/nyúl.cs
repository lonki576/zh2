using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication43
{
    public class nyúl : lábas
    {
        public nyúl(int sorszám, int lábak) : base(sorszám, lábak)
        {
        }
        public double gyorsuláss = 0;
        public void gyorsulás()
        {
            gyorsuláss+=1;
        }
    }
}