namespace AracKiralama
{
    partial class formMusteri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMusteri));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Guncelle = new System.Windows.Forms.Button();
            this.imageList1_ButonResimler = new System.Windows.Forms.ImageList(this.components);
            this.button_Ekle = new System.Windows.Forms.Button();
            this.richTextBox_Adres = new System.Windows.Forms.RichTextBox();
            this.textBox_TCKN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Telefon = new System.Windows.Forms.TextBox();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Soyadi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Adi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox_AramaKriteri = new System.Windows.Forms.ComboBox();
            this.textBox_SecileneGoreAra = new System.Windows.Forms.TextBox();
            this.dataGridView_Musteriler = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label_Message = new System.Windows.Forms.Label();
            this.button_Temizle = new System.Windows.Forms.Button();
            this.button_Sil = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Musteriler)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_Guncelle);
            this.groupBox1.Controls.Add(this.button_Ekle);
            this.groupBox1.Controls.Add(this.richTextBox_Adres);
            this.groupBox1.Controls.Add(this.textBox_TCKN);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox_Telefon);
            this.groupBox1.Controls.Add(this.textBox_Email);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox_Soyadi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox_Adi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_Id);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 579);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Bilgileri";
            // 
            // button_Guncelle
            // 
            this.button_Guncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Guncelle.ImageIndex = 1;
            this.button_Guncelle.ImageList = this.imageList1_ButonResimler;
            this.button_Guncelle.Location = new System.Drawing.Point(254, 482);
            this.button_Guncelle.Name = "button_Guncelle";
            this.button_Guncelle.Size = new System.Drawing.Size(127, 40);
            this.button_Guncelle.TabIndex = 3;
            this.button_Guncelle.Text = "Güncelle";
            this.button_Guncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Guncelle.UseVisualStyleBackColor = true;
            this.button_Guncelle.Click += new System.EventHandler(this.button_Guncelle_Click);
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
            // button_Ekle
            // 
            this.button_Ekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Ekle.ImageIndex = 0;
            this.button_Ekle.ImageList = this.imageList1_ButonResimler;
            this.button_Ekle.Location = new System.Drawing.Point(121, 482);
            this.button_Ekle.Name = "button_Ekle";
            this.button_Ekle.Size = new System.Drawing.Size(127, 40);
            this.button_Ekle.TabIndex = 3;
            this.button_Ekle.Text = "Ekle";
            this.button_Ekle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Ekle.UseVisualStyleBackColor = true;
            this.button_Ekle.Click += new System.EventHandler(this.button_Ekle_Click);
            // 
            // richTextBox_Adres
            // 
            this.richTextBox_Adres.Location = new System.Drawing.Point(121, 318);
            this.richTextBox_Adres.Name = "richTextBox_Adres";
            this.richTextBox_Adres.Size = new System.Drawing.Size(260, 130);
            this.richTextBox_Adres.TabIndex = 2;
            this.richTextBox_Adres.Text = "";
            // 
            // textBox_TCKN
            // 
            this.textBox_TCKN.Location = new System.Drawing.Point(121, 275);
            this.textBox_TCKN.Name = "textBox_TCKN";
            this.textBox_TCKN.Size = new System.Drawing.Size(260, 28);
            this.textBox_TCKN.TabIndex = 1;
            this.textBox_TCKN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "TCKN";
            // 
            // textBox_Telefon
            // 
            this.textBox_Telefon.Location = new System.Drawing.Point(121, 231);
            this.textBox_Telefon.Name = "textBox_Telefon";
            this.textBox_Telefon.Size = new System.Drawing.Size(260, 28);
            this.textBox_Telefon.TabIndex = 1;
            this.textBox_Telefon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_Email
            // 
            this.textBox_Email.Location = new System.Drawing.Point(121, 186);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(260, 28);
            this.textBox_Email.TabIndex = 1;
            this.textBox_Email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "Telefon";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 367);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Adres";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Email";
            // 
            // textBox_Soyadi
            // 
            this.textBox_Soyadi.Location = new System.Drawing.Point(121, 133);
            this.textBox_Soyadi.Name = "textBox_Soyadi";
            this.textBox_Soyadi.Size = new System.Drawing.Size(260, 28);
            this.textBox_Soyadi.TabIndex = 1;
            this.textBox_Soyadi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Soyadi";
            // 
            // textBox_Adi
            // 
            this.textBox_Adi.Location = new System.Drawing.Point(121, 80);
            this.textBox_Adi.Name = "textBox_Adi";
            this.textBox_Adi.Size = new System.Drawing.Size(260, 28);
            this.textBox_Adi.TabIndex = 1;
            this.textBox_Adi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Adi";
            // 
            // textBox_Id
            // 
            this.textBox_Id.Location = new System.Drawing.Point(121, 27);
            this.textBox_Id.Name = "textBox_Id";
            this.textBox_Id.ReadOnly = true;
            this.textBox_Id.Size = new System.Drawing.Size(260, 28);
            this.textBox_Id.TabIndex = 1;
            this.textBox_Id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_Id.TextChanged += new System.EventHandler(this.textBox_Id_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox_AramaKriteri);
            this.groupBox2.Controls.Add(this.textBox_SecileneGoreAra);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(421, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(581, 66);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Arama Bilgileri";
            // 
            // comboBox_AramaKriteri
            // 
            this.comboBox_AramaKriteri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_AramaKriteri.FormattingEnabled = true;
            this.comboBox_AramaKriteri.Items.AddRange(new object[] {
            "Adina Göre Ara",
            "Soyadina Göre Ara",
            "Emailine Göre Ara",
            "TCKN\'ye Göre Ara"});
            this.comboBox_AramaKriteri.Location = new System.Drawing.Point(29, 26);
            this.comboBox_AramaKriteri.Name = "comboBox_AramaKriteri";
            this.comboBox_AramaKriteri.Size = new System.Drawing.Size(257, 29);
            this.comboBox_AramaKriteri.TabIndex = 2;
            this.comboBox_AramaKriteri.Text = "Arama Kriteri Seçiniz";
            // 
            // textBox_SecileneGoreAra
            // 
            this.textBox_SecileneGoreAra.Location = new System.Drawing.Point(306, 27);
            this.textBox_SecileneGoreAra.Name = "textBox_SecileneGoreAra";
            this.textBox_SecileneGoreAra.Size = new System.Drawing.Size(244, 28);
            this.textBox_SecileneGoreAra.TabIndex = 1;
            this.textBox_SecileneGoreAra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_SecileneGoreAra.TextChanged += new System.EventHandler(this.textBox_SecileneGoreAra_TextChanged);
            // 
            // dataGridView_Musteriler
            // 
            this.dataGridView_Musteriler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Musteriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Musteriler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Musteriler.Location = new System.Drawing.Point(421, 66);
            this.dataGridView_Musteriler.Name = "dataGridView_Musteriler";
            this.dataGridView_Musteriler.RowHeadersWidth = 51;
            this.dataGridView_Musteriler.RowTemplate.Height = 24;
            this.dataGridView_Musteriler.Size = new System.Drawing.Size(581, 513);
            this.dataGridView_Musteriler.TabIndex = 4;
            this.dataGridView_Musteriler.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_Musteriler_RowHeaderMouseClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label_Message);
            this.groupBox3.Controls.Add(this.button_Temizle);
            this.groupBox3.Controls.Add(this.button_Sil);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(421, 480);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(581, 99);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "İşlemler";
            // 
            // label_Message
            // 
            this.label_Message.AutoSize = true;
            this.label_Message.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_Message.ForeColor = System.Drawing.Color.Red;
            this.label_Message.Location = new System.Drawing.Point(6, 69);
            this.label_Message.Name = "label_Message";
            this.label_Message.Size = new System.Drawing.Size(157, 23);
            this.label_Message.TabIndex = 4;
            this.label_Message.Text = "label_Message";
            // 
            // button_Temizle
            // 
            this.button_Temizle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Temizle.ImageIndex = 2;
            this.button_Temizle.ImageList = this.imageList1_ButonResimler;
            this.button_Temizle.Location = new System.Drawing.Point(168, 27);
            this.button_Temizle.Name = "button_Temizle";
            this.button_Temizle.Size = new System.Drawing.Size(118, 40);
            this.button_Temizle.TabIndex = 3;
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
            this.button_Sil.Location = new System.Drawing.Point(306, 28);
            this.button_Sil.Name = "button_Sil";
            this.button_Sil.Size = new System.Drawing.Size(104, 40);
            this.button_Sil.TabIndex = 3;
            this.button_Sil.Text = "Sil";
            this.button_Sil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Sil.UseVisualStyleBackColor = true;
            this.button_Sil.Click += new System.EventHandler(this.button_Sil_Click);
            // 
            // formMusteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 579);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dataGridView_Musteriler);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formMusteri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Yönetim Paneli";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Musteriler)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox richTextBox_Adres;
        private System.Windows.Forms.TextBox textBox_TCKN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Soyadi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Adi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView_Musteriler;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button_Guncelle;
        private System.Windows.Forms.ImageList imageList1_ButonResimler;
        private System.Windows.Forms.Button button_Ekle;
        private System.Windows.Forms.ComboBox comboBox_AramaKriteri;
        private System.Windows.Forms.TextBox textBox_SecileneGoreAra;
        private System.Windows.Forms.Label label_Message;
        private System.Windows.Forms.Button button_Temizle;
        private System.Windows.Forms.Button button_Sil;
        private System.Windows.Forms.TextBox textBox_Telefon;
        private System.Windows.Forms.Label label7;
    }
}