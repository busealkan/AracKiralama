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
    class AracVeritabani : TemelVeritabani
    {
        public override void Ekle(object obj)
        {



            throw new NotImplementedException();
        }

        public override int EkleVeIdDon(object obj)
        {
            Arac arc = (Arac)obj;
            Baglan();
            komut = new SqlCommand("usp_AracEkle", baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@Adi", arc.Adi);
            komut.Parameters.AddWithValue("@Durum", arc.Durum);
            komut.Parameters.AddWithValue("@Km", arc.Km);
            komut.Parameters.AddWithValue("@Modeli", arc.Modeli);
            komut.Parameters.AddWithValue("@Plaka", arc.Plaka);
            komut.Parameters.AddWithValue("@Renk", arc.Renk);
            komut.Parameters.AddWithValue("@Sınıf", arc.Sınıf);
            komut.Parameters.AddWithValue("@Turu", arc.Turu);
            komut.Parameters.AddWithValue("@Ucret", arc.Ucret);
            komut.Parameters.AddWithValue("@Vites", arc.Vites);
            komut.Parameters.AddWithValue("@Yakıt", arc.Yakit);
            komut.Parameters.AddWithValue("@Yıl", arc.Yıl);


            SqlParameter prm_Id = new SqlParameter("@Id",SqlDbType.Int);
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
            Arac arc = (Arac)obj;
            Baglan();
            tablo = new DataTable();
            adaptor = new SqlDataAdapter("select * from tbl_Arac where Durum='A' and Modeli = "+arc.Modeli, baglanti);
            adaptor.Fill(tablo);
            baglanti.Close();
            baglanti.Dispose();
            return tablo;
        }

        public override DataTable Listele()
        {
            Baglan();
            tablo = new DataTable();
            adaptor = new SqlDataAdapter("select * from tbl_Arac where Durum='A'",baglanti);
            adaptor.Fill(tablo);
            baglanti.Close();
            baglanti.Dispose();
            return tablo;
        }

        public override void Sil(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
