using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication43
{
    public class lábas : versenyző
    {
        public int lábak;
        public lábas(int sorszám,int lábak): base(sorszám)
        {
            this.lábak = lábak;
        }
    }
    
}