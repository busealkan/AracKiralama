using AracKiralama.Sınıflar.Varliklar;
using AracKiralama.Sınıflar.Veritabanı;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracKiralama
{
    public partial class formArac : Form
    {

        string fotografAdi = "";
        string path = "";
        public formArac()
        {
            InitializeComponent();
            
            Load += FormArac_Load;
        }

        private void FormArac_Load(object sender, EventArgs e)
        {
            MarkaListele();
        }

        public void MarkaListele()
        {
            MarkaVeritabani mrkVt = new MarkaVeritabani();
            comboBox_Markasi.DisplayMember = "Adi";
            comboBox_Markasi.ValueMember = "Id";
            comboBox_Markasi.DataSource = mrkVt.Listele();

            ModelListele();

        }

        private void label_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ModelListele()
        {
            Model mdl = new Model();
            mdl.MarkaId = int.Parse(comboBox_Markasi.SelectedValue.ToString());
            ModelVeritabani mdlVt = new ModelVeritabani();
            comboBox_Modeli.DisplayMember = "Adı";
            comboBox_Modeli.ValueMember = "Id";
            comboBox_Modeli.DataSource = mdlVt.Listele(mdl);
        }

        private void comboBox_Markasi_SelectedIndexChanged(object sender, EventArgs e)
        {
            ModelListele();
        }

        private void button_MarkaEkle_Click(object sender, EventArgs e)
        {
            // this -Z bulunduğun nesne. Bu sayfa için formArac
            formMarka frmMarka = new formMarka(this);
            frmMarka.ShowDialog();
        }

        private void button_ModelEkle_Click(object sender, EventArgs e)
        {
            formModel frmModel = new formModel();
            frmModel.ShowDialog();
        }

        private void button_AracEkle_Click(object sender, EventArgs e)
        {
            try
            {

                Arac arc = new Arac();
                arc.Adi = textBox_Adi.Text;
                arc.Durum = 'A';
                arc.Km = textBox_Km.Text;
                arc.Modeli = int.Parse(comboBox_Modeli.SelectedValue.ToString());
                arc.Sınıf = char.Parse(comboBox_Sınıfı.Text.ToString().Trim());
                arc.Turu = comboBox_Turu.Text.ToString();
                arc.Ucret = decimal.Parse(textBox_Ucret.Text);
                arc.Vites = comboBox_Vites.Text.ToString();
                arc.Yakit = comboBox_Yakiti.Text.ToString();
                arc.Yıl = textBox_Yil.Text;
                arc.Plaka = textBox_Plaka.Text;
                arc.Renk = textBox_Renk.Text;

                AracVeritabani arcVt = new AracVeritabani();
                arc.Id = arcVt.EkleVeIdDon(arc);
                label_Message.Text = "Ekleme İşlemi Başarılı : Arac Id : "+arc.Id;
            }
            catch (Exception hata)
            {

                label_Message.Text = "Hata: (Ekle) : " + hata.Message.ToString();
            }


        }


        private void comboBox_Modeli_SelectedIndexChanged(object sender, EventArgs e)
        {
            Arac arc = new Arac();
            AracVeritabani arcVt = new AracVeritabani();
            try
            {
                arc.Modeli = int.Parse(comboBox_Modeli.SelectedValue.ToString());
                dataGridView_Araclar.DataSource = arcVt.Listele(arc);
            }
            catch (Exception hata)
            {

                label_Message.Text = "Hata : " + hata.Message.ToString();
            }


        }

        private void dataGridView_Araclar_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            label_AracId.Text = dataGridView_Araclar.Rows[0].Cells["Id"].Value.ToString();
        }

        private void button_FotografSec_Click(object sender, EventArgs e)
        {
            string defaultPath = "";
            try
            {
                defaultPath = Registry.CurrentUser.GetValue("Yolu").ToString();
            }
            catch (Exception hata)
            {

                defaultPath = @"C:\";
                label_Message.Text = hata.Message.ToString();
            }


            using (OpenFileDialog fotografSec = new OpenFileDialog())
            {
                fotografSec.Title = "Fotoğraf Seçimi";
                fotografSec.Filter = "Fotograf Türleri (*.gif; *.jpg; *.jpeg; *.png; *bmp) | *.gif;*.jpg;*.jpeg;*.png;*bmp";
                fotografSec.InitialDirectory = defaultPath;
                DialogResult pencere = fotografSec.ShowDialog();
                if (pencere == DialogResult.OK)
                {

                    //"D:\tuncay pc yedek\Üniversite Ders Notları\C#\2020-2021\Güz\Dersler\12.Hafta\AracKiralama\Sınıflar\Varliklar\Fiyat.cs"
                    string yol = fotografSec.FileName.ToString().Substring(0, fotografSec.FileName.ToString().LastIndexOf("\\"));
                    Registry.CurrentUser.SetValue("Yolu", yol);
                    pictureBox_AracFotograf.Image = Image.FromFile(fotografSec.FileName);

                    fotografAdi = Path.GetFileName(fotografSec.FileName);

                }
            }
        }

        private void button_FEkle_Click(object sender, EventArgs e)
        {
            path = "";
            path = @"..\..\Fotograflar\" + comboBox_Markasi.Text;
            Random rnd = new Random();


            if (File.Exists(path))
            {
                path += @"\" + comboBox_Modeli.Text;
                if (!File.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
            }
            else
            {
                path += @"\" + comboBox_Modeli.Text;
                Directory.CreateDirectory(path);
            }

            fotografAdi = fotografAdi.Split('.')[0] + rnd.Next(999999) + ".jpeg"; ;
            path = path + "\\" + fotografAdi;
            pictureBox_AracFotograf.Image.Save(path, ImageFormat.Jpeg);

            FotografıKayıtEt();
        }

        private void FotografıKayıtEt()
        {
            Fotograflar ftg = new Fotograflar();
            FotograflarVeritabani ftgVt = new FotograflarVeritabani();
            ftg.Adi = fotografAdi;
            ftg.Durumu = 'A';
            ftg.Tur = 'A';
            ftg.Yolu = path;
            ftg.TurId = int.Parse(label_AracId.Text);

            try
            {
                label_FotografSiraNumarasi.Text =  ftgVt.EkleVeIdDon(ftg).ToString();
                label_Message.Text = "Fotograf Ekleme Başarılı";
                label_ToplamFotograf.Text = (int.Parse(label_ToplamFotograf.Text) + 1).ToString();
            }
            catch (Exception hata)
            {

                label_Message.Text = "Hata: " + hata.Message.ToString();
            }
        }

        private void label_AracId_TextChanged(object sender, EventArgs e)
        {
            Fotograflar ftg = new Fotograflar();
            FotograflarVeritabani ftgVt = new FotograflarVeritabani();


            if (label_AracId.Text !="0")
            {
                groupBox_FotografIslemleri.Visible = true;
                ftg.Tur = 'A';
                ftg.TurId = int.Parse(label_AracId.Text);
                label_ToplamFotograf.Text =  ftgVt.ToplamFotograf(ftg).ToString();
            }
            else
            {
                groupBox_FotografIslemleri.Visible = false;
            }
        }

        private void label_ToplamFotograf_TextChanged(object sender, EventArgs e)
        {
            int fotgrafSayisi = 1;
            if (label_FotografSiraNumarasi.Text !="0")
            {
                fotgrafSayisi = int.Parse(label_FotografSiraNumarasi.Text);
            }

            FotografGetir(fotgrafSayisi);
        }

        private void FotografGetir(int SiraNo)
        {
            Fotograflar ftg = new Fotograflar();
            FotograflarVeritabani ftgVt = new FotograflarVeritabani();
            if (label_ToplamFotograf.Text != "0" )
            {
                ftg.SiraNumarasi = (short)SiraNo;
                ftg.Tur = 'A';
                ftg.TurId = int.Parse(label_AracId.Text);
                label_FotografSiraNumarasi.Text = SiraNo.ToString();
                path = "";
                path = ftgVt.FotografGetir(ftg);
                pictureBox_AracFotograf.Image = Image.FromFile(path);
            }
        }

        private void button_BirSonrakiFotograf_Click(object sender, EventArgs e)
        {
            FotografGetir(int.Parse(label_FotografSiraNumarasi.Text)+1);
        }

        private void button_BirOncekiFotograf_Click(object sender, EventArgs e)
        {
            FotografGetir(int.Parse(label_FotografSiraNumarasi.Text) - 1);
        }

        private void label_FotografSiraNumarasi_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(label_FotografSiraNumarasi.Text) >1 )
            {
                button_BirOncekiFotograf.Visible = true;
            }
            else
            {
                button_BirOncekiFotograf.Visible = false;
            }

            if (int.Parse(label_FotografSiraNumarasi.Text) < int.Parse(label_ToplamFotograf.Text))
            {
                button_BirSonrakiFotograf.Visible = true;
            }
            else
            {
                button_BirSonrakiFotograf.Visible = false;
            }

        }
    }
}
