
namespace AracKiralama
{
    partial class formFiyat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formFiyat));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button_Cikis = new System.Windows.Forms.Button();
            this.dataGridView_Fiyatlar = new System.Windows.Forms.DataGridView();
            this.imageList1_ButonResimler = new System.Windows.Forms.ImageList(this.components);
            this.label_Message = new System.Windows.Forms.Label();
            this.button_Temizle = new System.Windows.Forms.Button();
            this.button_Sil = new System.Windows.Forms.Button();
            this.button_Guncelle = new System.Windows.Forms.Button();
            this.button_Ekle = new System.Windows.Forms.Button();
            this.label_Id = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Sinifi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_GFiyat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_HFiyat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_AFiyat = new System.Windows.Forms.TextBox();
            this.comboBox_Durumu = new System.Windows.Forms.ComboBox();
            this.richTextBox_Aciklama = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBox_HepsiGetir = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Fiyatlar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBox_Aciklama);
            this.groupBox1.Controls.Add(this.comboBox_Durumu);
            this.groupBox1.Controls.Add(this.textBox_AFiyat);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox_HFiyat);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox_GFiyat);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox_Sinifi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label_Id);
            this.groupBox1.Controls.Add(this.button_Guncelle);
            this.groupBox1.Controls.Add(this.button_Ekle);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(315, 591);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fiyat Bilgileri";

            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox_HepsiGetir);
            this.groupBox2.Controls.Add(this.button_Cikis);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(315, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(685, 87);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Arama";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label_Message);
            this.groupBox3.Controls.Add(this.button_Temizle);
            this.groupBox3.Controls.Add(this.button_Sil);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(315, 503);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(685, 88);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "İşlemler";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView_Fiyatlar);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(315, 87);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(685, 416);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sonuç";
            // 
            // button_Cikis
            // 
            this.button_Cikis.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_Cikis.FlatAppearance.BorderSize = 0;
            this.button_Cikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Cikis.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Cikis.Location = new System.Drawing.Point(606, 25);
            this.button_Cikis.Name = "button_Cikis";
            this.button_Cikis.Size = new System.Drawing.Size(75, 58);
            this.button_Cikis.TabIndex = 0;
            this.button_Cikis.Text = "X";
            this.button_Cikis.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_Cikis.UseVisualStyleBackColor = true;
            this.button_Cikis.Click += new System.EventHandler(this.button_Cikis_Click);
            // 
            // dataGridView_Fiyatlar
            // 
            this.dataGridView_Fiyatlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Fiyatlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Fiyatlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Fiyatlar.Location = new System.Drawing.Point(4, 25);
            this.dataGridView_Fiyatlar.Name = "dataGridView_Fiyatlar";
            this.dataGridView_Fiyatlar.RowHeadersWidth = 51;
            this.dataGridView_Fiyatlar.RowTemplate.Height = 24;
            this.dataGridView_Fiyatlar.Size = new System.Drawing.Size(677, 387);
            this.dataGridView_Fiyatlar.TabIndex = 0;
            // 
            // imageList1_ButonResimler
            // 
            this.imageList1_ButonResimler.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1_ButonResimler.ImageStream")));
            this.imageList1_ButonResimler.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1_ButonResimler.Images.SetKeyName(0, "CustomerAddBlue.png");
            this.imageList1_ButonResimler.Images.SetKeyName(1, "CustomerUpdate.png");
            this.imageList1_ButonResimler.Images.SetKeyName(2, "cleanBlue.jpg");
            this.imageList1_ButonResimler.Images.SetKeyName(3, "deleteRed.jpg");
            // 
            // label_Message
            // 
            this.label_Message.AutoSize = true;
            this.label_Message.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_Message.ForeColor = System.Drawing.Color.Red;
            this.label_Message.Location = new System.Drawing.Point(7, 63);
            this.label_Message.Name = "label_Message";
            this.label_Message.Size = new System.Drawing.Size(157, 23);
            this.label_Message.TabIndex = 7;
            this.label_Message.Text = "label_Message";
            // 
            // button_Temizle
            // 
            this.button_Temizle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Temizle.ImageIndex = 2;
            this.button_Temizle.ImageList = this.imageList1_ButonResimler;
            this.button_Temizle.Location = new System.Drawing.Point(218, 22);
            this.button_Temizle.Name = "button_Temizle";
            this.button_Temizle.Size = new System.Drawing.Size(118, 44);
            this.button_Temizle.TabIndex = 5;
            this.button_Temizle.Text = "Temizle";
            this.button_Temizle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Temizle.UseVisualStyleBackColor = true;
            this.button_Temizle.Click += new System.EventHandler(this.button_Temizle_Click);
            // 
            // button_Sil
            // 
            this.button_Sil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Sil.ImageIndex = 3;
            this.button_Sil.ImageList = this.imageList1_ButonResimler;
            this.button_Sil.Location = new System.Drawing.Point(359, 22);
            this.button_Sil.Name = "button_Sil";
            this.button_Sil.Size = new System.Drawing.Size(104, 44);
            this.button_Sil.TabIndex = 6;
            this.button_Sil.Text = "Sil";
            this.button_Sil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Sil.UseVisualStyleBackColor = true;
            this.button_Sil.Click += new System.EventHandler(this.button_Sil_Click);
            // 
            // button_Guncelle
            // 
            this.button_Guncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Guncelle.ImageIndex = 1;
            this.button_Guncelle.ImageList = this.imageList1_ButonResimler;
            this.button_Guncelle.Location = new System.Drawing.Point(157, 523);
            this.button_Guncelle.Name = "button_Guncelle";
            this.button_Guncelle.Size = new System.Drawing.Size(127, 46);
            this.button_Guncelle.TabIndex = 4;
            this.button_Guncelle.Text = "Güncelle";
            this.button_Guncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Guncelle.UseVisualStyleBackColor = true;
            // 
            // button_Ekle
            // 
            this.button_Ekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Ekle.ImageIndex = 0;
            this.button_Ekle.ImageList = this.imageList1_ButonResimler;
            this.button_Ekle.Location = new System.Drawing.Point(25, 523);
            this.button_Ekle.Name = "button_Ekle";
            this.button_Ekle.Size = new System.Drawing.Size(127, 46);
            this.button_Ekle.TabIndex = 5;
            this.button_Ekle.Text = "Ekle";
            this.button_Ekle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Ekle.UseVisualStyleBackColor = true;
            this.button_Ekle.Click += new System.EventHandler(this.button_Ekle_Click);
            // 
            // label_Id
            // 
            this.label_Id.AutoSize = true;
            this.label_Id.Location = new System.Drawing.Point(172, 25);
            this.label_Id.Name = "label_Id";
            this.label_Id.Size = new System.Drawing.Size(77, 21);
            this.label_Id.TabIndex = 6;
            this.label_Id.Text = "label_Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Sınıfı";
            // 
            // textBox_Sinifi
            // 
            this.textBox_Sinifi.Location = new System.Drawing.Point(121, 64);
            this.textBox_Sinifi.Name = "textBox_Sinifi";
            this.textBox_Sinifi.Size = new System.Drawing.Size(167, 28);
            this.textBox_Sinifi.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Günlük Fiyatı";
            // 
            // textBox_GFiyat
            // 
            this.textBox_GFiyat.Location = new System.Drawing.Point(121, 113);
            this.textBox_GFiyat.Name = "textBox_GFiyat";
            this.textBox_GFiyat.Size = new System.Drawing.Size(167, 28);
            this.textBox_GFiyat.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Hafalık Fiyatı";
            // 
            // textBox_HFiyat
            // 
            this.textBox_HFiyat.Location = new System.Drawing.Point(121, 170);
            this.textBox_HFiyat.Name = "textBox_HFiyat";
            this.textBox_HFiyat.Size = new System.Drawing.Size(167, 28);
            this.textBox_HFiyat.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Aylık Fiyatı";
            // 
            // textBox_AFiyat
            // 
            this.textBox_AFiyat.Location = new System.Drawing.Point(121, 219);
            this.textBox_AFiyat.Name = "textBox_AFiyat";
            this.textBox_AFiyat.Size = new System.Drawing.Size(167, 28);
            this.textBox_AFiyat.TabIndex = 8;
            // 
            // comboBox_Durumu
            // 
            this.comboBox_Durumu.FormattingEnabled = true;
            this.comboBox_Durumu.Items.AddRange(new object[] {
            "A-Aktif",
            "P-Pasif"});
            this.comboBox_Durumu.Location = new System.Drawing.Point(121, 276);
            this.comboBox_Durumu.Name = "comboBox_Durumu";
            this.comboBox_Durumu.Size = new System.Drawing.Size(167, 29);
            this.comboBox_Durumu.TabIndex = 9;
            this.comboBox_Durumu.Text = "Seçiniz";
            // 
            // richTextBox_Aciklama
            // 
            this.richTextBox_Aciklama.Location = new System.Drawing.Point(121, 329);
            this.richTextBox_Aciklama.Name = "richTextBox_Aciklama";
            this.richTextBox_Aciklama.Size = new System.Drawing.Size(167, 142);
            this.richTextBox_Aciklama.TabIndex = 10;
            this.richTextBox_Aciklama.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 21);
            this.label6.TabIndex = 7;
            this.label6.Text = "Durumu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 332);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 21);
            this.label7.TabIndex = 7;
            this.label7.Text = "Açıklama";
            // 
            // checkBox_HepsiGetir
            // 
            this.checkBox_HepsiGetir.AutoSize = true;
            this.checkBox_HepsiGetir.Location = new System.Drawing.Point(42, 45);
            this.checkBox_HepsiGetir.Name = "checkBox_HepsiGetir";
            this.checkBox_HepsiGetir.Size = new System.Drawing.Size(151, 25);
            this.checkBox_HepsiGetir.TabIndex = 1;
            this.checkBox_HepsiGetir.Text = "Hepsini Getir ?";
            this.checkBox_HepsiGetir.UseVisualStyleBackColor = true;
            this.checkBox_HepsiGetir.CheckedChanged += new System.EventHandler(this.checkBox_HepsiGetir_CheckedChanged);
            // 
            // formFiyat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 591);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "formFiyat";
            this.Text = "formFiyat";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Fiyatlar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button_Cikis;
        private System.Windows.Forms.DataGridView dataGridView_Fiyatlar;
        private System.Windows.Forms.ImageList imageList1_ButonResimler;
        private System.Windows.Forms.Label label_Message;
        private System.Windows.Forms.Button button_Temizle;
        private System.Windows.Forms.Button button_Sil;
        private System.Windows.Forms.Button button_Guncelle;
        private System.Windows.Forms.Button button_Ekle;
        private System.Windows.Forms.RichTextBox richTextBox_Aciklama;
        private System.Windows.Forms.ComboBox comboBox_Durumu;
        private System.Windows.Forms.TextBox textBox_AFiyat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_HFiyat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_GFiyat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Sinifi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_Id;
        private System.Windows.Forms.CheckBox checkBox_HepsiGetir;
    }
}