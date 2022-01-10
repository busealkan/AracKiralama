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
    public partial class formAnaSayfa : Form
    {
   
        public formAnaSayfa()
        {
            InitializeComponent();
            Load += FormAnaSayfa_Load;
        }

        private void FormAnaSayfa_Load(object sender, EventArgs e)
        {
            label_AdiVeSoyadi.Text = Login.Adi + " " + Login.Soyadi;
            label_Id.Text = Login.Id.ToString();
            label_Email.Text = Login.Email;
            label_KAdi.Text = Login.KAdi;
            YetkiKontrolu();

        }

        private void YetkiKontrolu()
        {
            if (Login.Yetkisi == 2 || Login.Yetkisi ==3)
            {
                pictureBox_AracEkle.Enabled = true;
                label_AracEkleme.Enabled = true;
                if (Login.Yetkisi==3)
                {
                    pictureBox_Ayrarlar.Visible = true;
                    label_Ayarlar.Visible = true;
                }
                else
                {
                    pictureBox_Ayrarlar.Visible = false;
                    label_Ayarlar.Visible = false;
                }
            }
            else
            {
                pictureBox_AracEkle.Enabled = false;
                label_AracEkleme.Enabled = false;
            }
         
        }

        private void label_Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox_AracEkle_Click(object sender, EventArgs e)
        {
            formArac frmArac = new formArac();
            frmArac.ShowDialog();
        }

        private void label_Cikis_MouseHover(object sender, EventArgs e)
        {
            label_Cikis.ForeColor = Color.Red;

        }

        private void label_Cikis_MouseLeave(object sender, EventArgs e)
        {
            label_Cikis.ForeColor = Color.White;
        }

        private void pictureBox_YonetimPaneli_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox_MusteriEkle_Click(object sender, EventArgs e)
        {
            formMusteri frmMusteri = new formMusteri();
            frmMusteri.ShowDialog();
        }

        private void pictureBox_Ayrarlar_Click(object sender, EventArgs e)
        {
            formAyarlar frmAyar = new formAyarlar();
            frmAyar.ShowDialog();
        }

        private void pictureBox_Rezervasyon_Click(object sender, EventArgs e)
        {
            formRezervasyon frmRzvr = new formRezervasyon();
            frmRzvr.ShowDialog();
        }

        private void button_Ara_Click(object sender, EventArgs e)
        {
            char durum;
            if (comboBox_Durum.Text == "R - Rezervasyonlar")
            {
                durum = 'R';
            }
            else if (comboBox_Durum.Text == "S - Kiralanan Araçlar")
            {
                durum = 'S';
            }
            else if (comboBox_Durum.Text == "I - İptal Edilen")
            {
                durum = 'S';
            }
            else
            {
                durum = '0';
            }

            RezervasyonVeritabani vt = new RezervasyonVeritabani();
            try
            {
                dataGridView_Rezervasyonlar.DataSource = vt.Listele(dateTimePicker_Baslangic.Value, dateTimePicker_Bitis.Value, durum);
            }
            catch (Exception hata)
            {

                
            }


        }

        private void pictureBox_KendiniGuncelle_Click(object sender, EventArgs e)
        {
            formMusteri frm = new formMusteri(Login.Id);
            frm.ShowDialog();
        }
    }
}
