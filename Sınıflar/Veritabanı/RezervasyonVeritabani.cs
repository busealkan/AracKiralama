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
    class RezervasyonVeritabani : TemelVeritabani
    {
        public override void Ekle(object obj)
        {
            throw new NotImplementedException();
        }

        public override int EkleVeIdDon(object obj)
        {
            Rezervasyon rz = (Rezervasyon)obj;
            Baglan();

            komut = new SqlCommand("usp_RezervasyonEkle",baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@AlmaTarihi", rz.AlmaTarihi.ToString("yyyy-MM-dd"));
            komut.Parameters.AddWithValue("@TeslimTarihi", rz.TeslimTarihi.ToString("yyyy-MM-dd"));
            komut.Parameters.AddWithValue("@Gun", rz.Gun);
            komut.Parameters.AddWithValue("@Sinifi", rz.Sinifi);
            komut.Parameters.AddWithValue("@AracId", rz.AracId);
            komut.Parameters.AddWithValue("@CalisanId", rz.CalisanId);
            komut.Parameters.AddWithValue("@Fiyat", rz.Fiyat);
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
            Rezervasyon rzv = (Rezervasyon)obj;
            Baglan();
            komut = new SqlCommand("update tbl_Rezervasyon set Durum ='S' ,GuncellemeTarihi = Getdate(), MusteriId = @MusteriId "
                                    + " where Durum ='R'", baglanti);
            komut.CommandType = CommandType.Text;
            komut.Parameters.AddWithValue("@MusteriId",rzv.MusteriId);
            komut.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Dispose();
        }

        public override DataTable Listele(object obj)
        {
            throw new NotImplementedException();
        }

        public override DataTable Listele()
        {
            Baglan();
            tablo = new DataTable();
            adaptor = new System.Data.SqlClient.SqlDataAdapter("select * from V_Rezervasyondakiler ", baglanti);
            adaptor.Fill(tablo);
            baglanti.Close();
            baglanti.Dispose();
            return tablo;
        }

        public override void Sil(object obj)
        {
            Rezervasyon rzv = (Rezervasyon)obj;
            Baglan();
            komut = new SqlCommand(" update tbl_Rezervasyon set Durum = 'I' , GuncellemeTarihi = GETDATE() where Id = @Id ", baglanti);
            komut.CommandType = CommandType.Text;
            komut.Parameters.AddWithValue("@Id",rzv.Id);
            komut.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Dispose();
        }
        public DataTable MusaitAraclariGetir(string AlisTarihi, string TeslimTarihi,Arac arc,string MinYil,string MaxYil)
        {
            tablo = new DataTable();
            Baglan();
            string sorgu = ""; ;
            sorgu = "select * from tbl_Arac ar where ar.Id not in ( select ar.Id from tbl_Arac ar inner join tbl_Rezervasyon rz on ar.Id = rz.AracId where ( (rz.AlmaTarihi >='" + AlisTarihi + "' and rz.AlmaTarihi <= '"+ TeslimTarihi + "') OR (rz.TeslimTarihi >=  '" + AlisTarihi + "'  and rz.TeslimTarihi <= '" + TeslimTarihi+"' )) and rz.Durum in ('R','S')  ) "
               +" and  ar.Durum ='A' " + " and ar.Yıl >= '"+MinYil+ "' and ar.Yıl <= '"+MaxYil+ "' " ;
            //if (arc.Sınıf !=' ')
            //{
            //    sorgu += " and ar.Sınıf = '" + arc.Sınıf+"' ";
            //}
            if (arc.Turu !="Hepsi")
            {
                sorgu += " and ar.Turu = '" + arc.Turu + "' ";
            }
            if (arc.Vites != "Hepsi")
            {
                sorgu += " and ar.Vites = '" + arc.Vites + "' ";
            }
            if (arc.Yakit != "Hepsi")
            {
                sorgu += " and ar.Yakit = '" + arc.Yakit + "' ";
            }
           

            adaptor = new System.Data.SqlClient.SqlDataAdapter(sorgu, baglanti);
            adaptor.Fill(tablo);
            baglanti.Close();
            baglanti.Dispose();

            return tablo;
        }

        internal object Listele(DateTime baslangic, DateTime bitis, char durum)
        {

            /*
                create proc usp_RezervasyonBilgileri
                @Baslangic datetime,
                @Bitis datetime,
                @Durum char(1)
             */
            Baglan();

            komut = new SqlCommand("usp_RezervasyonBilgileri", baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@Baslangic", baslangic);
            komut.Parameters.AddWithValue("@Bitis", bitis);
            komut.Parameters.AddWithValue("@Durum", durum);
            komut.ExecuteNonQuery();
            tablo = new DataTable();
            adaptor = new System.Data.SqlClient.SqlDataAdapter(komut);
            adaptor.Fill(tablo);
            baglanti.Close();
            baglanti.Dispose();
            return tablo;
        }
    }
}
