using AracKiralama.Sınıflar.Varliklar;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracKiralama.Sınıflar.Veritabanı
{
    class MarkaVeritabani : TemelVeritabani
    {
        public override void Ekle(object obj)
        {
            Marka mrk = (Marka)obj;
            Baglan();
            string sorgu = "insert into tbl_Marka values('" + mrk.Adi + "','" + mrk.Durumu + "')";
            komut = new SqlCommand(sorgu,baglanti);
            komut.CommandType = CommandType.Text;
            komut.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Dispose();
        }

        public override int EkleVeIdDon(object obj)
        {
            throw new NotImplementedException();
        }

        public override void Guncelle(object obj)
        {
            Marka mrk = (Marka)obj;
            Baglan();
            string sorgu = "update tbl_Marka set Adi ='"+mrk.Adi+"', Durumu = '"+mrk.Durumu+"' where Id = "+mrk.Id;
            komut = new SqlCommand(sorgu, baglanti);
            komut.CommandType = CommandType.Text;
            komut.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Dispose();
        }

        public override DataTable Listele(object obj)
        {
            Marka mrk = (Marka) obj;
            Baglan();
            string sorgu = "select * from tbl_Marka where Adi like '%" + mrk.Adi + "%'";

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
            Baglan();
            komut = new SqlCommand("select * from tbl_Marka",baglanti);
            komut.CommandType = CommandType.Text;
            komut.ExecuteNonQuery();
            adaptor = new SqlDataAdapter(komut);
            tablo = new DataTable();
            adaptor.Fill(tablo);
            baglanti.Close();
            baglanti.Dispose();
            return tablo;
        }

        public override void Sil(object obj)
        {
            Marka mrk =(Marka) obj;
            Baglan();

            komut = new SqlCommand(" delete tbl_Marka where Id = "+mrk.Id ,baglanti);
            komut.CommandType = CommandType.Text;
            komut.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Dispose();
        }
    }
}
