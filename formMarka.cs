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
    public partial class formMarka : Form
    {

        formArac frmArac = null;
        formModel frmModel = null;
        public formMarka()
        {
            InitializeComponent();
        }

        public formMarka( formArac gelenForm)
        {
            frmArac = gelenForm;
            InitializeComponent();
        }
        public formMarka(formModel gelenForm)
        {
            frmModel = gelenForm;
            InitializeComponent();
        }

        private void formMarka_Load(object sender, EventArgs e)
        {
            ///Ctrl + .  -> Hızlı çözümleri getirir
            Temizle();
        }

        private void MarkaListele()
        {
            Marka mrk = new Marka();
            mrk.Adi = textBox_Ara.Text;

            MarkaVeritabani mrkVt = new MarkaVeritabani();
            dataGridView_Markalar.DataSource = mrkVt.Listele(mrk);
        }

        private void textBox_Ara_TextChanged(object sender, EventArgs e)
        {
            MarkaListele();
        }

        private void button_Ekle_Click(object sender, EventArgs e)
        {
            //try yazdıktan sonra 2 defa tab basarsanız otomatik oluşturur!
            try
            {
                Marka mrk = new Marka();
                mrk.Adi = textBox_MarkaAdi.Text;
                if (comboBox_Durumu.SelectedItem.ToString() == "A-Aktif")
                {
                    mrk.Durumu = 'A';
                }
                else
                {
                    mrk.Durumu = 'P';
                }

                MarkaVeritabani mrkVt = new MarkaVeritabani();
                mrkVt.Ekle(mrk);
                Temizle();
               
                label_Message.Text = "Kayıt Ekleme Başarılı!";
            }
            catch (Exception hata)
            {

                label_Message.Text = "Hata : " + hata.Message.ToString();
            }
            
        }

        private void button_Temizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void Temizle()
        {
            textBox_Ara.Text = "";
            textBox_MarkaAdi.Text = "";
            comboBox_Durumu.Text = "";
            label_Message.Text = "";
            textBox_MarkaId.Text = "0";
            MarkaListele();
        }

        private void dataGridView_Markalar_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            for (int i = 0; i < dataGridView_Markalar.SelectedRows.Count; i++)
            {
                textBox_MarkaId.Text = dataGridView_Markalar.SelectedRows[i].Cells["Id"].Value.ToString();
                textBox_MarkaAdi.Text = dataGridView_Markalar.SelectedRows[i].Cells["Adi"].Value.ToString();
                if (dataGridView_Markalar.SelectedRows[i].Cells["Durumu"].Value.ToString()=="A")
                {
                    comboBox_Durumu.Text = "A-Pasif";
                }
                else if (dataGridView_Markalar.SelectedRows[i].Cells["Durumu"].Value.ToString() == "P")
                {
                    comboBox_Durumu.Text = "P-Pasif";
                }
            }
        }

        private void button_Sil_Click(object sender, EventArgs e)
        {
            try
            {
                Marka mrk = new Marka();
                mrk.Id = Convert.ToInt32(textBox_MarkaId.Text);

                MarkaVeritabani mrkVt = new MarkaVeritabani();
                mrkVt.Sil(mrk);
                Temizle();
                label_Message.Text = "Silme işlemi başarılı ";
            }
            catch (Exception hata)
            {

                label_Message.Text = "Hata: " + hata.Message;
            }

        }

        private void button_Guncelle_Click(object sender, EventArgs e)
        {

            try
            {
                Marka mrk = new Marka();
                mrk.Id = Convert.ToInt32(textBox_MarkaId.Text);
                mrk.Adi = textBox_MarkaAdi.Text;
                if (comboBox_Durumu.SelectedItem.ToString() == "A-Aktif")
                {
                    mrk.Durumu = 'A';
                }
                else
                {
                    mrk.Durumu = 'P';
                }

                MarkaVeritabani mrkVt = new MarkaVeritabani();
                mrkVt.Guncelle(mrk);
                Temizle();
                label_Message.Text = "Günceleme işlemi başarılı ";
            }
            catch (Exception hata)
            {

                label_Message.Text = "Hata: " + hata.Message;
            }
        }

        private void textBox_MarkaId_TextChanged(object sender, EventArgs e)
        {
            if (textBox_MarkaId.Text == "0")
            {
                button_Sil.Enabled = false;
                button_Guncelle.Enabled = false;
            }
            else
            {
                button_Guncelle.Enabled = true;
                button_Sil.Enabled = true;
            }
        }

        private void formMarka_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (frmArac !=null)
            {
                frmArac.MarkaListele();
            }
            if (frmModel !=null)
            {
                frmModel.MarkaListele();
            }
      
        }
    }
}
