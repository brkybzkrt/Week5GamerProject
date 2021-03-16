using System;
using System.Collections.Generic;

namespace Week5GamerProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Gamer> GamerListesi = new List<Gamer>();// Gamerlarımızı bu liste de tutacağız. veri tabanı görevi görecek birnevi.

            GamerManager gamerManager = new GamerManager();// Aksiyonları yönetmek için instance ürettik.


            Gamer gamer1 = new Gamer();
            gamer1.Ad = "Okan";
            gamer1.Soyad = "Yıldız";
            gamer1.TcNo = "3456789010";
            gamer1.DoğumYil = "1995";

            
            
            
            gamerManager.KayitYap(gamer1, GamerListesi);

            gamerManager.GamerGoster(GamerListesi);

            Console.WriteLine("*******************************");
            gamerManager.Guncelle(gamer1,new Gamer {Ad="Berkay",Soyad="Bozkurt",TcNo="34567522300",DoğumYil="1998" });//Bilgiler Güncellendi.

            gamerManager.GamerGoster(GamerListesi);

            gamerManager.Sil(gamer1,GamerListesi);

            gamerManager.GamerGoster(GamerListesi);

            Console.WriteLine("********************************");

            Gamer gamer3 = new Gamer();
            gamer3.Ad = "Ahmet";
            gamer3.Soyad = "Bozkurt";
            gamer3.TcNo = "4567890909";
            gamer3.DoğumYil = "2000";
            gamerManager.KayitYap(gamer3, GamerListesi);

            gamerManager.KampanyaliVeKampanyasiz(gamer3, new Indirim50());

            

        }
    }
}
