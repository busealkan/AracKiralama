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
    public partial class formModel : Form
    {
        public formModel()
        {
            InitializeComponent();
            Load += FormModel_Load;
        }

        private void FormModel_Load(object sender, EventArgs e)
        {
            Temizle();
        }

        public void MarkaListele()
        {
            Marka mrk = new Marka();
            MarkaVeritabani mrkVt = new MarkaVeritabani();
            comboBox_AraMarka.ValueMember = "Id";
            comboBox_AraMarka.DisplayMember= "Adi";
            comboBox_AraMarka.DataSource = mrkVt.Listele();

            comboBox_Markasi.DisplayMember = "Adi";
            comboBox_Markasi.ValueMember = "Id";
            comboBox_Markasi.DataSource = comboBox_AraMarka.DataSource;

        }

        private void comboBox_AraMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            ModelListele();
        }

        private void ModelListele()
        {
            Model mdl = new Model();
            mdl.MarkaId = int.Parse(comboBox_AraMarka.SelectedValue.ToString());
            mdl.Adi = textBox_AraModelAdi.Text;
            ModelVeritabani mdlVt = new ModelVeritabani();
            dataGridView_Model.DataSource = mdlVt.Listele(mdl);
        }

        private void button_MarkaEkle_Click(object sender, EventArgs e)
        {
            formMarka frMarka = new formMarka(this);
            frMarka.ShowDialog();
        }

        private void textBox_AraModelAdi_TextChanged(object sender, EventArgs e)
        {
            ModelListele();
        }

        private void dataGridView_Model_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                textBox_ModelAdi.Text = dataGridView_Model.SelectedRows[0].Cells["Adı"].Value.ToString();
                textBox_ModelId.Text = dataGridView_Model.SelectedRows[0].Cells["Id"].Value.ToString();
                // trim() -> fonksiyone öndeki ve arkasındaki boşlukları siler ! .. String'e ait bir fonksiyon özelliğidir. !;
                char durum = char.Parse(dataGridView_Model.SelectedRows[0].Cells["Durum"].Value.ToString().Trim());
                // Char(10) veritabanında ?
                // 1 karakter girdiğimiz geriye 9 karakter boşluk bırakır !
                // yani -> P -> 'P          '

                if (durum == 'A')
                {
                    comboBox_Durumu.Text = "A-Aktif";
                }
                else if (durum == 'P')
                {
                    comboBox_Durumu.Text = "P-Pasif";
                }
            }
            catch (Exception hata)
            {

                label_Message.Text = "Hata : (formModel / RowHeaderMouseClick) : " + hata.Message;
            }



        }

        private void button_Guncelle_Click(object sender, EventArgs e)
        {
            try
            {
                Model mdl = new Model();
                mdl.Id = Convert.ToInt32(textBox_ModelId.Text);

                mdl.Adi = textBox_ModelAdi.Text;
                if (comboBox_Durumu.Text == "A-Aktif")
                {
                    mdl.Durumu = 'A';
                }
                else if (comboBox_Durumu.Text == "P-Pasif")
                {
                    mdl.Durumu = 'P';
                }
                mdl.MarkaId = int.Parse(comboBox_Markasi.SelectedValue.ToString());

                ModelVeritabani mdlVt = new ModelVeritabani();

                mdlVt.Guncelle(mdl);

                ModelListele();
                label_Message.Text = "Güncelleme işlemi başarılı";

            }
            catch (Exception hata)
            {

                label_Message.Text = "Hata: (Guncelle) : " + hata.Message.ToString();
            }


        }

        private void button_Sil_Click(object sender, EventArgs e)
        {
            try
            {
                Model mdl = new Model();
                mdl.Id = Convert.ToInt32(textBox_ModelId.Text);

                ModelVeritabani mdlVt = new ModelVeritabani();
                mdlVt.Sil(mdl);
                ModelListele();
                label_Message.Text = "Silme İşlemi Başarılı";
            }
            catch (Exception hata)
            {

                label_Message.Text = "Hata: (Sil) : " + hata.Message.ToString();
            }

        }

        private void button_Ekle_Click(object sender, EventArgs e)
        {
            try
            {
                Model mdl = new Model();
              //  mdl.Id = Convert.ToInt32(textBox_ModelId.Text);

                mdl.Adi = textBox_ModelAdi.Text;
                if (comboBox_Durumu.Text == "A-Aktif")
                {
                    mdl.Durumu = 'A';
                }
                else if (comboBox_Durumu.Text == "P-Pasif")
                {
                    mdl.Durumu = 'P';
                }
                mdl.MarkaId = int.Parse(comboBox_Markasi.SelectedValue.ToString());

                ModelVeritabani mdlVt = new ModelVeritabani();
                textBox_ModelId.Text = mdlVt.EkleVeIdDon(mdl).ToString();
                ModelListele();
                label_Message.Text = "Ekleme İşlemi Başarılı. Id: "+textBox_ModelId.Text;
            }
            catch (Exception hata )
            {

                label_Message.Text = "Hata: (Ekle) : " + hata.Message.ToString();
            }
        }

        private void button_Temizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void Temizle()
        {
            textBox_AraModelAdi.Text = "";
            textBox_ModelAdi.Text = "";
            textBox_ModelId.Text = "";
            comboBox_Durumu.Text = "";
            label_Message.Text = "";
            label_Message.ForeColor = Color.Red;
            button_Sil.Enabled = false;
            button_Guncelle.Enabled = false;

            MarkaListele();
        }

        private void textBox_ModelId_TextChanged(object sender, EventArgs e)
        {
            if (textBox_ModelId.Text !="0"  && textBox_ModelId.Text !="")
            {
                button_Guncelle.Enabled = true;
                button_Sil.Enabled = true;
            }
            else
            {
                button_Guncelle.Enabled = false;
                button_Sil.Enabled = false;
            }
        }
    }
}
