using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore
{
    class KampanyaManager
    {
        public void KampanyaOlustur(Kampanya kampanya)
        {
            Console.WriteLine(kampanya.KampanyaAdi+ " Oluşturulmuştur");
        }

        public void KampanyaGuncelle()
        {
            Console.WriteLine("Kampanya Güncellendi");
        }

        public void KampanyaSil()
        {
            Console.WriteLine("Kampanya Silindi");
        }

    }
}
