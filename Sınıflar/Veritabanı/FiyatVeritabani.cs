using AracKiralama.Sınıflar.Varliklar;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracKiralama.Sınıflar.Veritabanı
{
    class FiyatVeritabani : TemelVeritabani
    {
        public override void Ekle(object obj)
        {
            throw new NotImplementedException();
        }

        public override int EkleVeIdDon(object obj)
        {
            Fiyat fyt = (Fiyat)obj;
            Baglan();
            komut = new SqlCommand("usp_FiyatEkle", baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@Aciklama", fyt.Aciklama);
            komut.Parameters.AddWithValue("@AylikFiyat", fyt.AylikFiyat);
            komut.Parameters.AddWithValue("@Durumu", fyt.Durumu);
            komut.Parameters.AddWithValue("@GunlukFiyat", fyt.GunlukFiyat);
            komut.Parameters.AddWithValue("@HaftalikFiyat", fyt.HaftalikkFiyat);
            komut.Parameters.AddWithValue("@Sinifi", fyt.Sinifi);

            SqlParameter prm_Id = new SqlParameter("@Id", SqlDbType.Int);
            prm_Id.Direction = ParameterDirection.Output;
            komut.Parameters.Add(prm_Id);

            komut.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Dispose();
            return int.Parse(prm_Id.Value.ToString());
        }

        public override void Guncelle(object obj)
        {
            throw new NotImplementedException();
        }

        public override DataTable Listele(object obj)
        {
            throw new NotImplementedException();
        }

        public override DataTable Listele()
        {
            Baglan();
            tablo = new DataTable();
            string sorgu = "select *  from tbl_fiyat Where Durumu ='A'";
            adaptor = new SqlDataAdapter(sorgu,baglanti);
            adaptor.Fill(tablo);
            baglanti.Close();
            baglanti.Dispose();
            return tablo;
        }

        internal decimal FiyatGetir(char sinifi, int gun)
        {
            decimal Fiyat = 0;
            string sorgu = "";
            if (gun<7)
            {
                sorgu = "select GunlukFiyat as Fiyat from tbl_Fiyat  where Sinifi = '" + sinifi + "' and Durumu ='A'";
            }
            else if (gun<30)
            {
                sorgu = "select HaftalıkFiyat as Fiyat  from tbl_Fiyat  where Sinifi = '" + sinifi + "' and Durumu ='A'";
            }
            else
            { 
                sorgu = "select AylıkFiyat as Fiyat  from tbl_Fiyat  where Sinifi = '" + sinifi + "' and Durumu ='A'";
            }
            Baglan();
            komut = new SqlCommand(sorgu,baglanti);
            komut.CommandType = CommandType.Text;

            Fiyat = Decimal.Parse(komut.ExecuteScalar().ToString());
            
            baglanti.Close();
            baglanti.Dispose();
            return Fiyat * gun;
        }

        public  DataTable HepsiListele()
        {
            Baglan();
            tablo = new DataTable();
            string sorgu = "select *  from tbl_fiyat ";
            adaptor = new SqlDataAdapter(sorgu, baglanti);
            adaptor.Fill(tablo);
            baglanti.Close();
            baglanti.Dispose();
            return tablo;
        }

        public override void Sil(object obj)
        {
            Fiyat fyt = (Fiyat)obj;
            Baglan();
            string sorgu = "delete tbl_Fiyat where Id =" + fyt.Id;
            komut = new SqlCommand(sorgu,baglanti);
            komut.CommandType = CommandType.Text;
            komut.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Dispose();
        }
    }
}
