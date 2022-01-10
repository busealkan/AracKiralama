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
    class FotograflarVeritabani : TemelVeritabani
    {
        public override void Ekle(object obj)
        {
            throw new NotImplementedException();
        }

        public override int EkleVeIdDon(object obj)
        {
            Fotograflar  ftg = (Fotograflar)obj;
            Baglan();
            komut = new SqlCommand("usp_FotografEkle", baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@Adi", ftg.Adi);
            komut.Parameters.AddWithValue("@Durumu", ftg.Durumu);
            komut.Parameters.AddWithValue("@Tur", ftg.Tur);
            komut.Parameters.AddWithValue("@TurId", ftg.TurId);
            komut.Parameters.AddWithValue("@Yolu", ftg.Yolu);

            SqlParameter prm_Id = new SqlParameter("@SiraNumarasi", SqlDbType.SmallInt);
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
            throw new NotImplementedException();
        }

        public override void Sil(object obj)
        {
            throw new NotImplementedException();
        }

        internal int ToplamFotograf(Fotograflar ftg)
        {
            Baglan();
            komut = new SqlCommand(" select count(*) from tbl_Fotograflar where Tur= @Tur and TurId = @TurId and Durumu ='A' ", baglanti);
            komut.CommandType = CommandType.Text;
            komut.Parameters.AddWithValue("@Tur",ftg.Tur);
            komut.Parameters.AddWithValue("@TurId",ftg.TurId);
            int adet =  int.Parse( komut.ExecuteScalar().ToString());
            baglanti.Close();
            baglanti.Dispose();
            return adet;
        }

        internal string FotografGetir(Fotograflar ftg)
        {
            Baglan();
            komut = new SqlCommand(" select top 1 yolu from tbl_Fotograflar where Tur= @Tur and TurId = @TurId and Durumu ='A' and SiraNumarasi =@SiraNumarasi ", baglanti);
            komut.CommandType = CommandType.Text;
            komut.Parameters.AddWithValue("@Tur", ftg.Tur);
            komut.Parameters.AddWithValue("@TurId", ftg.TurId);
            komut.Parameters.AddWithValue("@SiraNumarasi", ftg.SiraNumarasi);
            string yolu = komut.ExecuteScalar().ToString();
            baglanti.Close();
            baglanti.Dispose();
            return yolu;
        }
    }
}
