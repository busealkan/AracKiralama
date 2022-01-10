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
    public partial class formFiyat : Form
    {
        public formFiyat()
        {
            InitializeComponent();
            Load += FormFiyat_Load;
        }

        private void FormFiyat_Load(object sender, EventArgs e)
        {
            Temizle();
          //  FiyatListele();
        }


        private void button_Cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Ekle_Click(object sender, EventArgs e)
        {
            Fiyat fyt = new Fiyat();
            FiyatVeritabani fytVt = new FiyatVeritabani();

            try
            {

                fyt.Aciklama = richTextBox_Aciklama.Text;
                fyt.AylikFiyat = decimal.Parse(textBox_AFiyat.Text);
                fyt.GunlukFiyat = decimal.Parse(textBox_GFiyat.Text);
                fyt.HaftalikkFiyat = decimal.Parse(textBox_HFiyat.Text);
                if (comboBox_Durumu.Text == "A-Aktif")
                {
                    fyt.Durumu = 'A';
                }
                else
                {
                    fyt.Durumu = 'F';
                }
                fyt.Sinifi = Char.Parse(textBox_Sinifi.Text);
            }
            catch (Exception hata)
            {

                label_Message.Text = "Hata: " + hata.Message.ToString();
            }

            try
            {

                label_Id.Text = fytVt.EkleVeIdDon(fyt).ToString();
                label_Message.Text = "Id : " + label_Id.Text + " Ekleme işlemi başarılı";
                FiyatListele();
            }
            catch (Exception hata)
            {


                label_Message.Text = "Hata: " + hata.Message.ToString();
            }



        }

        private void checkBox_HepsiGetir_CheckedChanged(object sender, EventArgs e)
        {
            FiyatListele();
        }

        private void FiyatListele()
        {
            FiyatVeritabani fytVt = new FiyatVeritabani();
            if (checkBox_HepsiGetir.Checked == true)
            {

                dataGridView_Fiyatlar.DataSource = fytVt.HepsiListele();
            }
            else
            {

                dataGridView_Fiyatlar.DataSource = fytVt.Listele();
            }
        }

        private void button_Sil_Click(object sender, EventArgs e)
        {
            FiyatVeritabani fytVt = new FiyatVeritabani();
            Fiyat fyt = new Fiyat();
            fyt.Id = int.Parse( label_Id.Text);
            fytVt.Sil(fyt);
            FiyatListele();
        }

        private void button_Temizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void Temizle()
        {
            label_Id.Text = "0";
            label_Id.Visible = false;
            textBox_AFiyat.Text = "0";
            textBox_GFiyat.Text = "0";
            textBox_HFiyat.Text = "0";
            textBox_Sinifi.Text = "";
            richTextBox_Aciklama.Text = "";
            comboBox_Durumu.Text = "Seçiniz";
            checkBox_HepsiGetir.Checked = false;
        }
    }
}
