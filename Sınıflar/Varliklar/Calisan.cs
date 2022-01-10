using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracKiralama.Sınıflar.Varliklar
{
    class Calisan
    {
        private int id;
        private string adi;
        private string soyadi;
        private char durumu;
        private DateTime baslamaTarihi;
        private DateTime guncellemeTarihi;
        private string email;
        private string kAdi;
        private string parola;

        public int Id { get => id; set => id = value; }
        public string Adi { get => adi; set => adi = value; }
        public string Soyadi { get => soyadi; set => soyadi = value; }
        public char Durumu { get => durumu; set => durumu = value; }
        public DateTime BaslamaTarihi { get => baslamaTarihi; set => baslamaTarihi = value; }
        public DateTime GuncellemeTarihi { get => guncellemeTarihi; set => guncellemeTarihi = value; }
        public string Email { get => email; set => email = value; }
        public string KAdi { get => kAdi; set => kAdi = value; }
        public string Parola { get => parola; set => parola = value; }
    }
}
