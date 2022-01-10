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
    public partial class formAyarlar : Form
    {
        public formAyarlar()
        {
            InitializeComponent();
        }

        private void button_Fiyatlar_Click(object sender, EventArgs e)
        {
            formFiyat frmFiyat = new formFiyat();
            GosterForm(frmFiyat);
        }

        private void GosterForm(Form frm)
        {
            panel_Formlar.Controls.Clear();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            panel_Formlar.Controls.Add(frm);
            frm.Show();
        }

        private void button_Musteriler_Click(object sender, EventArgs e)
        {
            formMusteri frmMusteri = new formMusteri();
            GosterForm(frmMusteri);

        }

        private void button_Cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Calisan_Click(object sender, EventArgs e)
        {

        }
    }
}
