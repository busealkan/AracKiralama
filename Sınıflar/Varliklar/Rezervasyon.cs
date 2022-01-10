using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracKiralama.Sınıflar.Varliklar
{
    class Rezervasyon
    {
        public int Id;
        public int CalisanId;
        public int MusteriId;
        public int AracId;
        public char Sinifi;
        public int Gun;
        public decimal Fiyat;
        public DateTime AlmaTarihi;
        public DateTime TeslimTarihi;
        public char Durumu;
        public DateTime OlusturmaTarihi;
        public DateTime GuncellemeTarihi;
    }
}
