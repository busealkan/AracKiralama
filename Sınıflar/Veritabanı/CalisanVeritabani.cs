using AracKiralama.Sınıflar.Varliklar;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AracKiralama.Sınıflar.Veritabanı
{
    class CalisanVeritabani : TemelVeritabani
    {
        public override void Ekle(object obj)
        {
            throw new NotImplementedException();
        }

        public override int EkleVeIdDon(object obj)
        {
            throw new NotImplementedException();
        }

        public override void Guncelle(object obj)
        {
            Calisan cls = (Calisan)obj;
            Baglan();
            string sorgu = "update tbl_Calisan set Parola='" + cls.Parola + "' , IsSifreOlustur = 0 "+
                " where ( Email = '" + cls.Email + "' or KAdi = '" + cls.KAdi + "' ) ";
            komut = new SqlCommand(sorgu, baglanti);
            komut.CommandType = CommandType.Text;
            komut.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Dispose(); 
        }

        public override DataTable Listele(object obj)
        {
            Calisan cls = (Calisan) obj;
            Baglan();
            string sorgu = "select * from View_Calisan where ( Email = '" + cls.Email+"' or KAdi = '"+cls.KAdi+"' ) "+
                            " and ( Parola = '"+cls.Parola+ "' or ( SifremiUnuttum = '" + cls.Parola + "' and IsSifreOlustur = 1 ) ) and Durumu ='A'";
            komut = new SqlCommand(sorgu,baglanti);
            komut.CommandType = CommandType.Text;
            komut.ExecuteNonQuery();
            adaptor = new SqlDataAdapter(komut);
            tablo = new DataTable();
            adaptor.Fill(tablo);
            baglanti.Close();
            baglanti.Dispose();
            return tablo;
        }

        public override DataTable Listele()
        {
            throw new NotImplementedException();
        }

        public override void Sil(object obj)
        {
            throw new NotImplementedException();
        }

        internal bool CalisanVarmi(Calisan cls)
        {           
            bool varmi = false;
            Baglan();
            komut = new SqlCommand("select count(*) from tbl_Calisan where Email = @Email OR KAdi = @KAdi ",baglanti);
            komut.CommandType = CommandType.Text;
            komut.Parameters.AddWithValue("@Email",cls.Email);
            komut.Parameters.AddWithValue("@KAdi", cls.KAdi);
            int adet = int.Parse( komut.ExecuteScalar().ToString());
            baglanti.Close();
            baglanti.Dispose();

            if (adet>0)
            {
                varmi = true;
            }

            return varmi;
        }

        internal string SifremiUnuttum(Calisan cls)
        {
            Baglan();
            komut = new SqlCommand("usp_SifremiUnuttum",baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@Parola",cls.Parola);
            komut.Parameters.AddWithValue("@Email",cls.Email);
            komut.Parameters.AddWithValue("@KAdi",cls.KAdi);

            SqlParameter prm_Email = new SqlParameter("@VarEmail", SqlDbType.NVarChar,200);
            prm_Email.Direction = ParameterDirection.Output;
            komut.Parameters.Add(prm_Email);

            komut.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Dispose();
            return prm_Email.Value.ToString();

        }
    }
}
