using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracKiralama.Sınıflar.Varliklar
{
    class Musteri
    {
        private int id;
        private string adi;
        private string soyadi;
        private string telefon;
        private string email;
        private string tCKN;
        private string adres;

        public int Id { get => id; set => id = value; }
        public string Adi { get => adi; set => adi = value; }
        public string Soyadi { get => soyadi; set => soyadi = value; }
        public string Telefon { get => telefon; set => telefon = value; }
        public string Email { get => email; set => email = value; }
        public string TCKN { get => tCKN; set => tCKN = value; }
        public string Adres { get => adres; set => adres = value; }
    }
}
