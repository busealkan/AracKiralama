using AracKiralama.Sınıflar.Varliklar;
using AracKiralama.Sınıflar.Veritabanı;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracKiralama
{
    public partial class formSatis : Form
    {
        public formSatis()
        {
            InitializeComponent();
            Load += FormSatis_Load;
            
        }

        private void FormSatis_Load(object sender, EventArgs e)
        {
            Temizle();
            button_SatisYap.Enabled = false;
            KiralanacakAraclar();
        }

        private void KiralanacakAraclar()
        {
            RezervasyonVeritabani rzVT = new RezervasyonVeritabani();
            dataGridView_Rezervasyonlar.DataSource = rzVT.Listele();
            if (dataGridView_Rezervasyonlar.Rows.Count>0)
            {
                label_ToplamFiyat.Text = ToplamFiyat().ToString();
            }
            label_ToplamArac.Text = dataGridView_Rezervasyonlar.Rows.Count.ToString();
        }

        private decimal ToplamFiyat()
        {
            decimal toplamFiyat = 0;
            for (int i = 0; i < dataGridView_Rezervasyonlar.Rows.Count-1; i++)
            {
                toplamFiyat+= decimal.Parse(dataGridView_Rezervasyonlar.Rows[i].Cells["Fiyat"].Value.ToString());
            }

            return toplamFiyat;
        }

        private void textBox_AraTcknOrEmail_MouseHover(object sender, EventArgs e)
        {
            if (textBox_AraTcknOrEmail.Text == "TCKN veya Email Giriniz")
            {
                textBox_AraTcknOrEmail.Text = "";
            }
           
        }

        private void textBox_AraTcknOrEmail_MouseLeave(object sender, EventArgs e)
        {
            if (textBox_AraTcknOrEmail.Text=="")
            {
                textBox_AraTcknOrEmail.Text = "TCKN veya Email Giriniz";
            }
        }


        private void textBox_AraTcknOrEmail_TextChanged(object sender, EventArgs e)
        {
            Musteri mstr = new Musteri();
            MusteriVeritabani msVt = new MusteriVeritabani();

            if (textBox_AraTcknOrEmail.Text != "" && textBox_AraTcknOrEmail.Text != "TCKN veya Email Giriniz")
            {
                mstr.Email = textBox_AraTcknOrEmail.Text;
                mstr.TCKN = textBox_AraTcknOrEmail.Text;

                DataTable tablo = new DataTable();

                tablo = msVt.MusteriGetir(mstr.TCKN, mstr.Email);
                if (tablo.Rows.Count>0)
                {
                    textBox_Adi.Text = tablo.Rows[0]["Adi"].ToString();
                    textBox_Email.Text = tablo.Rows[0]["Email"].ToString();
                    textBox_Tckn.Text = tablo.Rows[0]["TCKN"].ToString();
                    label_MusteriId.Text = tablo.Rows[0]["Id"].ToString();
                    textBox_Soyadi.Text = tablo.Rows[0]["Soyadi"].ToString();
                    richTextBox_Adres.Text = tablo.Rows[0]["Adres"].ToString();
                    textBox_Telefon.Text = tablo.Rows[0]["Telefon"].ToString();
                }
                else
                {
                    Temizle();
                }

            }
        }

        private void label_MusteriId_TextChanged(object sender, EventArgs e)
        {
            if (label_MusteriId.Text =="0" || label_MusteriId.Text == "")
            {
                button_SatisYap.Enabled = false;
            }
            else
            {
                button_SatisYap.Enabled = true;
            }
        }

        private void button_Temizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void Temizle()
        {
          //  label_ToplamFiyat.Text = "0";
         //   label_ToplamArac.Text = "0";
            label_MusteriId.Text = "";
           // textBox_AraTcknOrEmail.Text = "";
            textBox_Adi.Text = "";
            textBox_Email.Text = "";
            textBox_Tckn.Text = "";
            textBox_Soyadi.Text = "";
            richTextBox_Adres.Text = "";
            textBox_Telefon.Text = "";
            label_Message.Text = "";
        }

        private void button_Cikar_Click(object sender, EventArgs e)
        {
            RezervasyonVeritabani rzVt = new RezervasyonVeritabani();
            Rezervasyon rzv = new Rezervasyon();
            try
            {
                if (dataGridView_Rezervasyonlar.SelectedRows.Count > 0)
                {
                    rzv.Id = int.Parse(dataGridView_Rezervasyonlar.SelectedRows[0].Cells["RezervasyonId"].Value.ToString());
                    rzVt.Sil(rzv);
                    label_Message.Text = "Silme İşlemi Başarıl"; ;
                    KiralanacakAraclar();
                }
            }
            catch (Exception hata)
            {

                label_Message.Text = "Hata : " + hata.Message.ToString();
            }


        }

        private void button_SatisYap_Click(object sender, EventArgs e)
        {
            RezervasyonVeritabani rzVt = new RezervasyonVeritabani();
            Rezervasyon rzv = new Rezervasyon();
            try
            {
                rzv.MusteriId = int.Parse(label_MusteriId.Text);
                rzVt.Guncelle(rzv);
                label_Message.Text = "İşlem Başarılı";
                KiralanacakAraclar();
            }
            catch (Exception hata)
            {

                label_Message.Text = "Hata : " + hata.Message.ToString();
            }


        }
    }
}
