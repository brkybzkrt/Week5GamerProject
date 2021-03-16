using System;
using System.Collections.Generic;
using System.Text;

namespace Week5GamerProject
{
    class Indirimsiz : IKampanya
    {
        public void SatinAl(Gamer gamer)
        {
            Console.WriteLine("Sayın " + gamer.Ad + "Kampanyasız satış işleminiz gerçekleştirildi.");
        }
    }
}
