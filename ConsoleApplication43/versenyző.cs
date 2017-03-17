using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication43
{
    public class versenyző
    {
        protected int sorszám;
      
        public double távolság;

        public versenyző(int sorszám)
            {
            this.sorszám = sorszám;

            távolság = 0;
            }
    }
}