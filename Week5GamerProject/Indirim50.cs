using System;
using System.Collections.Generic;
using System.Text;

namespace Week5GamerProject
{
    class Indirim50 : IKampanya
    {
        public void SatinAl(Gamer gamer)
        {
            Console.WriteLine("Sayın " + gamer.Ad + " %50 indirimle satın alma işleminiz gerçekleşmiştir.");
        }
    }
}
