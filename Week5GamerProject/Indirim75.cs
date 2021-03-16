using System;
using System.Collections.Generic;
using System.Text;

namespace Week5GamerProject
{
    class Indirim75 : IKampanya
    {
        

        public void SatinAl(Gamer gamer)
        {
            Console.WriteLine("Sayın " + gamer.Ad + " %75 indirimle satın alma işleminiz gerçekleşmiştir.");
        }
    }
}
