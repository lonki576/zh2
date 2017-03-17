using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication43
{
    class verseny
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            csiga zsigacsiga = new csiga(1);
            nyúl Csacskanyúl = new nyúl(2, 4);
            medve Trémedve = new medve(3, 4);
            hóvirág hóvirág = new hóvirág(4);
            róka para = new róka(5, 4);
            szöcske Másnapos = new szöcske(6, 6);
            bolha bolha = new bolha(7);

            for (int j = 0; j < 10; j++)
            {
                for (int i = 0; i < 10; i++)
                {
                    Másnapos.másnapléptek(r.NextDouble());
                    if (r.NextDouble() < 0.1)
                    {
                        Trémedve.üvöltés();
                    }
                    if (i % 2 == 1)
                    {
                        para.bizalmatlan();
                    }
                    else

                    if (zsigacsiga.léphet_e == true)
                    {
                        zsigacsiga.távolság += 1;

                    }
                    else
                        zsigacsiga.léphet_e = false;
                    
                        Csacskanyúl.távolság += 1.0*Math.Pow(Csacskanyúl.gyorsuláss, 1.5);
                  
                    hóvirág.legyökerez();
                    Trémedve.távolság += 1;
                    bolha.távolság = Trémedve.távolság;




                }
                Console.WriteLine("1  távolság:" + zsigacsiga.távolság+"átlagsebesség:"+zsigacsiga.távolság/10);
                Console.WriteLine("2  távolság:" + Csacskanyúl.távolság+ "átlagsebesség:" + Csacskanyúl.távolság / 10+"lábsebesség:"+ (Csacskanyúl.távolság / 10)/Csacskanyúl.lábak);
                Console.WriteLine("3  távolság:" + Trémedve.távolság + "átlagsebesség:" + Trémedve.távolság / 10 + "lábsebesség:" + (Trémedve.távolság / 10) / Trémedve.lábak);
                Console.WriteLine("4  távolság:" + hóvirág.távolság + "átlagsebesség:" + hóvirág.távolság / 10);
                Console.WriteLine("5  távolság:" + para.távolság + "átlagsebesség:" + para.távolság / 10 + "lábsebesség:" + (para.távolság / 10) / para.lábak);
                Console.WriteLine("6  távolság:" + Másnapos.távolság + "átlagsebesség:" + Másnapos.távolság / 10 + "lábsebesség:" + (Másnapos.távolság / 10) / Másnapos.lábak);
                Console.WriteLine("7  távolság:" + bolha.távolság + "átlagsebesség:" + bolha.távolság / 10);
                Console.ReadKey();
                Console.Clear();
            }
            Console.WriteLine("végeredmény");
            Console.WriteLine("1  távolság: " + zsigacsiga.távolság + " átlagsebesség: " + zsigacsiga.távolság / 10);
            Console.WriteLine("2  távolság: " + Csacskanyúl.távolság + " átlagsebesség: " + Csacskanyúl.távolság / 10 + "lábsebesség:" + (Csacskanyúl.távolság / 10) / Csacskanyúl.lábak);
            Console.WriteLine("3  távolság: " + Trémedve.távolság + " átlagsebesség: " + Trémedve.távolság / 10 + "lábsebesség:" + (Trémedve.távolság / 10) / Trémedve.lábak);
            Console.WriteLine("4  távolság: " + hóvirág.távolság + " átlagsebesség: " + hóvirág.távolság / 10);
            Console.WriteLine("5  távolság: " + para.távolság + " átlagsebesség:" + para.távolság / 10 + "lábsebesség:" + (para.távolság / 10) / para.lábak);
            Console.WriteLine("6  távolság: " + Másnapos.távolság + " átlagsebesség: " + Másnapos.távolság / 10 + "lábsebesség:" + (Másnapos.távolság / 10) / Másnapos.lábak);
            Console.WriteLine("7  távolság: " + bolha.távolság + " átlagsebesség: " + bolha.távolság / 10);
            Console.ReadKey();


        }
    }
}
