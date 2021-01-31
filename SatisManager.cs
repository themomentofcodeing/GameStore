using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore
{
    class SatisManager
    {
        Satis _satis = null;
        public SatisManager()
        {
            _satis = new Satis()
            {
                MusteriId = 0,
                OyunId = 0,
                KampanyaId = 1
            };

            //_satis.MusteriId = 0;
            //_satis.OyunId = 0;
            //_satis.KampanyaId = 1;

        }

        public void SatisYap(Musteri musteri, Oyun oyun, Satis satis)
        {
            _satis = satis;
            _satis.SatisId = satis.SatisId;
            _satis.MusteriId = musteri.MusteriId;
            _satis.OyunId = oyun.OyunId;
            
        }

        public void SatisListesi()
        {
            Console.WriteLine(_satis.SatisId + " numaralı satış " + _satis.MusteriId + " id li müşteriye " + _satis.KampanyaId + " satış kampanyası ile satılmıştır. " + " Satılan oyun id si: " + _satis.OyunId + ", satış adeti: " + _satis.SatisAdedi + " ve satış fiyatı: " + _satis.SatisFiyati);
        }

    }
}
