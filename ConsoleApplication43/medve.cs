using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication43
{
    public class medve : lábas
    {
        public medve(int sorszám, int lábak) : base(sorszám, lábak)
        {
        }

        public void üvöltés()
        {
            Console.WriteLine("medve üvöltöt");
        }
        
    }
}