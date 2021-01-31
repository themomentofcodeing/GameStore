using System;

namespace GameStore
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri { MusteriId = 1, Ad = "emine", Soyad = "çelik", TcNo = "313186666442" };
            Musteri musteri2 = new Musteri { MusteriId = 2, Ad = "fatmanur", Soyad = "çelik", TcNo = "313186666442" };
            Musteri musteri3 = new Musteri { MusteriId = 3, Ad = "hatice", Soyad = "çelik", TcNo = "313186666442" };
            Musteri musteri4 = new Musteri { MusteriId = 4, Ad = "nazan", Soyad = "kıran", TcNo = "313186666442" };
            Musteri musteri5 = new Musteri { MusteriId = 5, Ad = "hasan", Soyad = "özkan", TcNo = "313186666442" };

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);
            musteriManager.Add(musteri3);
            musteriManager.Add(musteri4);
            musteriManager.Add(musteri5);

            musteriManager.Delete(musteri4);
            musteriManager.Delete(musteri5);

            musteriManager.Update(musteri4);
            musteriManager.Update(musteri5);

            Console.WriteLine("********************************");

            Kampanya kampanya = new Kampanya { KampanyaId = 1, KampanyaAdi = "Yeni Yıl Kampanyası" };

            KampanyaManager kampanyaManager = new KampanyaManager();
            kampanyaManager.KampanyaOlustur(kampanya);

            Console.WriteLine("********************************");

            Oyun oyun = new Oyun
            {
                OyunId = 3,
                OyunAdi = "GTA"
            };

            OyunManager oyunManager = new OyunManager();
            oyunManager.OyunEkle(oyun);

            Console.WriteLine("********************************");

            Satis satis = new Satis()
            {
                SatisId = 4,
                SatisAdedi = 15,
                SatisFiyati = 200,
                KampanyaId=1
            };

            SatisManager satisManager = new SatisManager();
            satisManager.SatisYap(musteri3, oyun,satis);

            satisManager.SatisListesi();

            
            Console.ReadLine();
        }
    }
}
