using System;
using System.Collections.Generic;
using System.Text;

namespace Week5GamerProject
{
    public interface IGamerService
    {
        void KayitYap(Gamer gamer, List<Gamer> list);

        void Sil(Gamer gamer, List<Gamer> list);

        void Guncelle( Gamer gamer, Gamer newGamer);

        void GamerGoster(List<Gamer> list);

        
    }
}
