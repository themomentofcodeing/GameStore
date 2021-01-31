using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore
{
    class MusteriManager
    {
        
        public void Add(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " " + musteri.Soyad + " Müşteri Sistemine Eklenmiştir");
        }

        public void Update(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " " + musteri.Soyad + " Müşteri Güncellemesi Tamamlandı");
        }

        public void Delete(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " " + musteri.Soyad + " Müşteri Sistemden Silinmiştir");
        }
    }
}
