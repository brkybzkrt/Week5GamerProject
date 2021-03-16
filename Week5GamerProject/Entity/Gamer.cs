using System;
using System.Collections.Generic;
using System.Text;
using Week5GamerProject.Abstracts;

namespace Week5GamerProject
{
    public class Gamer:IGamer
    {
        public string TcNo { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }

        public string DoğumYil { get; set; }
    }
}
