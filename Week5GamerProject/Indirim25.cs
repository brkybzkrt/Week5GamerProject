using System;
using System.Collections.Generic;
using System.Text;

namespace Week5GamerProject
{
    class Indirim25 : IKampanya
    {
        public void SatinAl(Gamer gamer)
        {
            Console.WriteLine("Sayın "+ gamer.Ad+" %25 indirimle satın alma işleminiz gerçekleşmiştir.");
        }
    }
}
