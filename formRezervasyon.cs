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
    public partial class formRezervasyon : Form
    {
        public formRezervasyon()
        {
            InitializeComponent();
            Load += FormRezervasyon_Load;
            // Load += 2 defa TAB basarsanız otomatik oluşuyor
        }

        private void FormRezervasyon_Load(object sender, EventArgs e)
        {
            FiyatVeritabani fytVt = new FiyatVeritabani();

            comboBox_Sinifi.DisplayMember = "Sinifi";
            comboBox_Sinifi.ValueMember = "Id";
            comboBox_Sinifi.DataSource = fytVt.Listele();
            KiralanacakAraclar();
        }

        private void button_Ara_Click(object sender, EventArgs e)
        {
            AracVeritabani arcVt = new AracVeritabani();

            //dataGridView_AracListesi.DataSource = arcVt.Listele();

            AramaKriterlerineGoreAraclariListele();

        }

        private void dataGridView_AracListesi_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Rezervasyon rz = new Rezervasyon();
            rz.AracId = int.Parse(dataGridView_AracListesi.Rows[0].Cells["Id"].Value.ToString());
            rz.CalisanId = Login.Id;
            rz.OlusturmaTarihi = DateTime.Now;
            rz.Sinifi = char.Parse(dataGridView_AracListesi.Rows[0].Cells["Sınıf"].Value.ToString());
            rz.TeslimTarihi = dateTimePicker_TeslimTarihi.Value;
            rz.AlmaTarihi = dateTimePicker_AlisTarihi.Value;
            rz.Gun = Math.Abs( dateTimePicker_AlisTarihi.Value.Day - dateTimePicker_TeslimTarihi.Value.Day);
            rz.Durumu = 'R';
            FiyatVeritabani fyVt = new FiyatVeritabani();
            try
            {
                // Fiyat kiralama tarihlere göre dinamik bir şekilde belirlendi
                rz.Fiyat = fyVt.FiyatGetir(rz.Sinifi, rz.Gun);

                RezervasyonVeritabani rzVt = new RezervasyonVeritabani();
                label_Message.Text = rzVt.EkleVeIdDon(rz).ToString();
                AramaKriterlerineGoreAraclariListele();
                KiralanacakAraclar();
            }
            catch (Exception hata )
            {

                label_Message.Text = "Hata : " + hata.Message.ToString();
            }


        }

        private void KiralanacakAraclar()
        {
            RezervasyonVeritabani rzVT = new RezervasyonVeritabani();
            dataGridView_Rezervasyonlar.DataSource = rzVT.Listele();
        }

        private void AramaKriterlerineGoreAraclariListele()
        {
            RezervasyonVeritabani rzrVt = new RezervasyonVeritabani();
            Arac arc = new Arac();
            if (comboBox_Sinifi.SelectedValue.ToString() == "" || comboBox_Sinifi.SelectedValue.ToString() == "Seçiniz")
            {
                arc.Sınıf = ' ';
            }
            else
            {
                arc.Sınıf = Char.Parse(comboBox_Sinifi.SelectedValue.ToString());
            }

            if(comboBox_Turu.Text == "Seçiniz" || comboBox_Turu.Text == "" )
            {
                arc.Turu = "Hepsi";
            }
            else
            {
                arc.Turu = comboBox_Turu.Text;
            }


            if (comboBox_Vites.Text == "Seçiniz" || comboBox_Vites.Text == "")
            {
                arc.Vites = "Hepsi";
            }
            else
            {
                arc.Vites = comboBox_Vites.Text;
            }


            if (comboBox_Yakit.Text == "Seçiniz" || comboBox_Yakit.Text == "")
            {
                arc.Yakit = "Hepsi";
            }
            else
            {
                arc.Yakit = comboBox_Yakit.Text;
            }
            string temp = "";
            if (int.Parse( textBox_MaxModelYil.Text) < int.Parse( textBox_MinModelYil.Text))
            {
                temp = textBox_MaxModelYil.Text;
                textBox_MaxModelYil.Text = textBox_MinModelYil.Text;
                textBox_MinModelYil.Text = temp;
            }

            dataGridView_AracListesi.DataSource = rzrVt.MusaitAraclariGetir(dateTimePicker_AlisTarihi.Value.ToString("yyyy-MM-dd"), dateTimePicker_TeslimTarihi.Value.ToString("yyyy-MM-dd"), arc, textBox_MinModelYil.Text, textBox_MaxModelYil.Text);
        }

        private void button_SatisaGit_Click(object sender, EventArgs e)
        {
            formSatis frm = new formSatis();
            frm.ShowDialog();
          //  this.Close();
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
    }
}
