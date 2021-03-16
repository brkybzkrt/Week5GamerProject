using System;
using System.Collections.Generic;
using System.Text;

namespace Week5GamerProject
{
    class GamerManager : IGamerService
    {
        public void GamerGoster(List<Gamer> GamerList)
        {
            if (GamerList.Count==0)
            {
                Console.WriteLine("Liste de Kayıtlı Oyuncu bulunmamaktadır.");
            }
            else
            {
                foreach (var gamer in GamerList)
                {
                    Console.WriteLine("Oyuncu Bilgileri = " + gamer.Ad + " " + gamer.Soyad + " " + gamer.DoğumYil + " " + gamer.TcNo);
                }
            }
          
        }

        public void Guncelle(Gamer oldgamer, Gamer newGamer)
        {
            Gamer tutucuGamer = new Gamer();
            tutucuGamer.Ad = oldgamer.Ad;
            //---------------------------

            oldgamer.Ad = newGamer.Ad;
            oldgamer.Soyad = newGamer.Soyad;
            oldgamer.DoğumYil = newGamer.DoğumYil;
            oldgamer.TcNo = newGamer.TcNo;

            Console.WriteLine(tutucuGamer.Ad+" "+newGamer.Ad +" olarak güncellendi.");
        }

       

        public void KayitYap(Gamer gamer, List<Gamer> list)
        {

            
                list.Add(gamer);
                Console.WriteLine(gamer.Ad + " " + gamer.Soyad + " " + gamer.DoğumYil + " " + gamer.TcNo + " listeye eklendi");
            
           
            
            

        }

        public void Sil(Gamer gamer, List<Gamer> list)
        {
            if (list.Contains(gamer))
            {
                list.Remove(gamer);
            }
        }



        public void KampanyaliVeKampanyasiz(Gamer gamer,IKampanya kampanyaTuru)// indirim türlerine göre satın alma işlemi.
        {

             kampanyaTuru.SatinAl(gamer);

        }

       
    }
    

}
