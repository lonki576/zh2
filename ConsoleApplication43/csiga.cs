using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication43
{
    public class csiga : versenyző
    {
        public csiga(int sorszám) : base(sorszám)
        {
        }
        public bool léphet_e = true;

        public void ijedség()
        {
            léphet_e=false;
        }
    }
}