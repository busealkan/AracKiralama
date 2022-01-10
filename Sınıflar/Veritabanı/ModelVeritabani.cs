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
    
    class ModelVeritabani : TemelVeritabani
    {
        string sorgu = "";
        public override void Ekle(object obj)
        {
            Model mdl = (Model)obj;
            Baglan();
            sorgu = "";
            sorgu = "insert into tbl_Model (Adı,Durum,MarkaId) " +
                    " values ('" + mdl.Adi + "','" + mdl.Durumu + "'," + mdl.MarkaId + ")";
            komut = new SqlCommand(sorgu,baglanti);
            komut.CommandType = CommandType.Text;
            komut.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Dispose();
        }

        public override int EkleVeIdDon(object obj)
        {
            //

            Model mdl = (Model)obj;
            Baglan();
            sorgu = "";
            
            komut = new SqlCommand("usp_ModelEkle", baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@Adi",mdl.Adi);
            komut.Parameters.AddWithValue("@Durum",mdl.Durumu);
            komut.Parameters.AddWithValue("@MarkaId",mdl.MarkaId);

            SqlParameter prm_Id = new SqlParameter("@Id", SqlDbType.Int);
            prm_Id.Direction = ParameterDirection.Output;
            komut.Parameters.Add(prm_Id);

            komut.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Dispose();
            // mdl.Id = int.Parse(prm_Id.Value.ToString());
            return int.Parse(prm_Id.Value.ToString());
        }

        public override void Guncelle(object obj)
        {
            Model mdl = (Model)obj;
            Baglan();
            sorgu = "";
            sorgu = "update tbl_Model "+
                    "set MarkaId = " + mdl.MarkaId + " , Durum = '" + mdl.Durumu + "' , Adı = '" + mdl.Adi
                    + "' where Id = " + mdl.Id;

            komut = new SqlCommand(sorgu,baglanti);
            komut.CommandType = CommandType.Text;
            komut.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Dispose();

        }

        public override DataTable Listele(object obj)
        {
            Model mdl = (Model)obj;
            Baglan();

            if (mdl.Adi !="")
            {
                sorgu = "select * from tbl_Model where MarkaId= " + mdl.MarkaId +" and Adı like '%"+mdl.Adi+"%'";
            }
            else
            {
                sorgu = "select * from tbl_Model where MarkaId= " + mdl.MarkaId;
            }


            komut = new SqlCommand(sorgu,baglanti);
            komut.CommandType = CommandType.Text;
            komut.ExecuteNonQuery();

            tablo = new DataTable();
            adaptor = new SqlDataAdapter(komut);
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
            Model mdl = (Model)obj;
            Baglan();
            sorgu = "";
            sorgu = "delete tbl_Model where Id = " + mdl.Id;
            komut = new SqlCommand(sorgu,baglanti);
            komut.CommandType = CommandType.Text;
            komut.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Dispose();
        }
    }
}
