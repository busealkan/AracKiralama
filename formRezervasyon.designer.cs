namespace AracKiralama
{
    partial class formRezervasyon
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_MaxModelYil = new System.Windows.Forms.TextBox();
            this.textBox_MinModelYil = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView_AracListesi = new System.Windows.Forms.DataGridView();
            this.button_Ara = new System.Windows.Forms.Button();
            this.dateTimePicker_TeslimTarihi = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_AlisTarihi = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Sınıfı = new System.Windows.Forms.Label();
            this.comboBox_Yakit = new System.Windows.Forms.ComboBox();
            this.comboBox_Vites = new System.Windows.Forms.ComboBox();
            this.comboBox_Turu = new System.Windows.Forms.ComboBox();
            this.comboBox_Sinifi = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label_Message = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView_Rezervasyonlar = new System.Windows.Forms.DataGridView();
            this.button_HepsiniTemizle = new System.Windows.Forms.Button();
            this.button_Cikar = new System.Windows.Forms.Button();
            this.button_SatisaGit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AracListesi)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Rezervasyonlar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 493);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.groupBox2.Controls.Add(this.textBox_MaxModelYil);
            this.groupBox2.Controls.Add(this.textBox_MinModelYil);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.button_Ara);
            this.groupBox2.Controls.Add(this.dateTimePicker_TeslimTarihi);
            this.groupBox2.Controls.Add(this.dateTimePicker_AlisTarihi);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.Sınıfı);
            this.groupBox2.Controls.Add(this.comboBox_Yakit);
            this.groupBox2.Controls.Add(this.comboBox_Vites);
            this.groupBox2.Controls.Add(this.comboBox_Turu);
            this.groupBox2.Controls.Add(this.comboBox_Sinifi);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(900, 493);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Araç Bilgileri";
            // 
            // textBox_MaxModelYil
            // 
            this.textBox_MaxModelYil.Location = new System.Drawing.Point(788, 49);
            this.textBox_MaxModelYil.Name = "textBox_MaxModelYil";
            this.textBox_MaxModelYil.Size = new System.Drawing.Size(57, 28);
            this.textBox_MaxModelYil.TabIndex = 6;
            this.textBox_MaxModelYil.Text = "2021";
            // 
            // textBox_MinModelYil
            // 
            this.textBox_MinModelYil.Location = new System.Drawing.Point(690, 49);
            this.textBox_MinModelYil.Name = "textBox_MinModelYil";
            this.textBox_MinModelYil.Size = new System.Drawing.Size(57, 28);
            this.textBox_MinModelYil.TabIndex = 6;
            this.textBox_MinModelYil.Text = "1900";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView_AracListesi);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(3, 208);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(894, 282);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müsait Olan Araçlar";
            // 
            // dataGridView_AracListesi
            // 
            this.dataGridView_AracListesi.BackgroundColor = System.Drawing.Color.MediumTurquoise;
            this.dataGridView_AracListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_AracListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_AracListesi.GridColor = System.Drawing.Color.White;
            this.dataGridView_AracListesi.Location = new System.Drawing.Point(3, 24);
            this.dataGridView_AracListesi.Name = "dataGridView_AracListesi";
            this.dataGridView_AracListesi.RowHeadersWidth = 51;
            this.dataGridView_AracListesi.RowTemplate.Height = 24;
            this.dataGridView_AracListesi.Size = new System.Drawing.Size(888, 255);
            this.dataGridView_AracListesi.TabIndex = 1;
            this.dataGridView_AracListesi.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_AracListesi_RowHeaderMouseDoubleClick);
            // 
            // button_Ara
            // 
            this.button_Ara.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button_Ara.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.button_Ara.FlatAppearance.BorderSize = 2;
            this.button_Ara.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Ara.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Ara.ForeColor = System.Drawing.Color.White;
            this.button_Ara.Location = new System.Drawing.Point(644, 122);
            this.button_Ara.Name = "button_Ara";
            this.button_Ara.Size = new System.Drawing.Size(208, 58);
            this.button_Ara.TabIndex = 4;
            this.button_Ara.Text = "Ara";
            this.button_Ara.UseVisualStyleBackColor = false;
            this.button_Ara.Click += new System.EventHandler(this.button_Ara_Click);
            // 
            // dateTimePicker_TeslimTarihi
            // 
            this.dateTimePicker_TeslimTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_TeslimTarihi.Location = new System.Drawing.Point(427, 154);
            this.dateTimePicker_TeslimTarihi.Name = "dateTimePicker_TeslimTarihi";
            this.dateTimePicker_TeslimTarihi.Size = new System.Drawing.Size(176, 28);
            this.dateTimePicker_TeslimTarihi.TabIndex = 3;
            this.dateTimePicker_TeslimTarihi.Value = new System.DateTime(2020, 11, 15, 0, 50, 29, 0);
            // 
            // dateTimePicker_AlisTarihi
            // 
            this.dateTimePicker_AlisTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_AlisTarihi.Location = new System.Drawing.Point(125, 154);
            this.dateTimePicker_AlisTarihi.Name = "dateTimePicker_AlisTarihi";
            this.dateTimePicker_AlisTarihi.Size = new System.Drawing.Size(176, 28);
            this.dateTimePicker_AlisTarihi.TabIndex = 3;
            this.dateTimePicker_AlisTarihi.Value = new System.DateTime(2020, 11, 15, 0, 50, 29, 0);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(311, 161);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 19);
            this.label13.TabIndex = 1;
            this.label13.Text = "Teslim Tarihi";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Transparent;
            this.label14.Location = new System.Drawing.Point(22, 161);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 19);
            this.label14.TabIndex = 1;
            this.label14.Text = "Alış Tarihi";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(355, 63);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 19);
            this.label12.TabIndex = 1;
            this.label12.Text = "Yakıt";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(355, 113);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 19);
            this.label10.TabIndex = 1;
            this.label10.Text = "Vites";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(21, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 19);
            this.label7.TabIndex = 1;
            this.label7.Text = "Türü";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(760, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 19);
            this.label9.TabIndex = 1;
            this.label9.Text = "/";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(640, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 19);
            this.label8.TabIndex = 1;
            this.label8.Text = "Yıl";
            // 
            // Sınıfı
            // 
            this.Sınıfı.AutoSize = true;
            this.Sınıfı.ForeColor = System.Drawing.Color.Transparent;
            this.Sınıfı.Location = new System.Drawing.Point(21, 58);
            this.Sınıfı.Name = "Sınıfı";
            this.Sınıfı.Size = new System.Drawing.Size(45, 19);
            this.Sınıfı.TabIndex = 1;
            this.Sınıfı.Text = "Sınıfı";
            // 
            // comboBox_Yakit
            // 
            this.comboBox_Yakit.FormattingEnabled = true;
            this.comboBox_Yakit.Items.AddRange(new object[] {
            "Hepsi",
            "Benzin",
            "Dizel",
            "Hibrit",
            "Benzin + LPG",
            "Elektirk"});
            this.comboBox_Yakit.Location = new System.Drawing.Point(427, 52);
            this.comboBox_Yakit.Name = "comboBox_Yakit";
            this.comboBox_Yakit.Size = new System.Drawing.Size(176, 27);
            this.comboBox_Yakit.TabIndex = 0;
            this.comboBox_Yakit.Text = "Seçiniz";
            // 
            // comboBox_Vites
            // 
            this.comboBox_Vites.FormattingEnabled = true;
            this.comboBox_Vites.Items.AddRange(new object[] {
            "Hepsi",
            "Manuel",
            "Otomatik",
            "Yarı Otomatik"});
            this.comboBox_Vites.Location = new System.Drawing.Point(427, 109);
            this.comboBox_Vites.Name = "comboBox_Vites";
            this.comboBox_Vites.Size = new System.Drawing.Size(176, 27);
            this.comboBox_Vites.TabIndex = 0;
            this.comboBox_Vites.Text = "Seçiniz";
            // 
            // comboBox_Turu
            // 
            this.comboBox_Turu.FormattingEnabled = true;
            this.comboBox_Turu.Items.AddRange(new object[] {
            "Hepsi",
            "HB",
            "Sedan",
            "SUV",
            "Jeep"});
            this.comboBox_Turu.Location = new System.Drawing.Point(125, 101);
            this.comboBox_Turu.Name = "comboBox_Turu";
            this.comboBox_Turu.Size = new System.Drawing.Size(176, 27);
            this.comboBox_Turu.TabIndex = 0;
            this.comboBox_Turu.Text = "Seçiniz";
            // 
            // comboBox_Sinifi
            // 
            this.comboBox_Sinifi.FormattingEnabled = true;
            this.comboBox_Sinifi.Location = new System.Drawing.Point(125, 51);
            this.comboBox_Sinifi.Name = "comboBox_Sinifi";
            this.comboBox_Sinifi.Size = new System.Drawing.Size(176, 27);
            this.comboBox_Sinifi.TabIndex = 0;
            this.comboBox_Sinifi.Text = "Seçiniz";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel3.Controls.Add(this.label_Message);
            this.panel3.Controls.Add(this.groupBox3);
            this.panel3.Controls.Add(this.button_HepsiniTemizle);
            this.panel3.Controls.Add(this.button_Cikar);
            this.panel3.Controls.Add(this.button_SatisaGit);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel3.Location = new System.Drawing.Point(0, 493);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(900, 297);
            this.panel3.TabIndex = 1;
            // 
            // label_Message
            // 
            this.label_Message.AutoSize = true;
            this.label_Message.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_Message.ForeColor = System.Drawing.Color.DarkRed;
            this.label_Message.Location = new System.Drawing.Point(12, 263);
            this.label_Message.Name = "label_Message";
            this.label_Message.Size = new System.Drawing.Size(134, 19);
            this.label_Message.TabIndex = 5;
            this.label_Message.Text = "label_Message";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panel4);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(900, 238);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kiralanacak Araçlar";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel4.Controls.Add(this.dataGridView_Rezervasyonlar);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 24);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(894, 211);
            this.panel4.TabIndex = 1;
            // 
            // dataGridView_Rezervasyonlar
            // 
            this.dataGridView_Rezervasyonlar.BackgroundColor = System.Drawing.Color.MediumTurquoise;
            this.dataGridView_Rezervasyonlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Rezervasyonlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Rezervasyonlar.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_Rezervasyonlar.Name = "dataGridView_Rezervasyonlar";
            this.dataGridView_Rezervasyonlar.RowHeadersWidth = 51;
            this.dataGridView_Rezervasyonlar.RowTemplate.Height = 24;
            this.dataGridView_Rezervasyonlar.Size = new System.Drawing.Size(894, 211);
            this.dataGridView_Rezervasyonlar.TabIndex = 1;
            // 
            // button_HepsiniTemizle
            // 
            this.button_HepsiniTemizle.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button_HepsiniTemizle.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.button_HepsiniTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_HepsiniTemizle.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_HepsiniTemizle.ForeColor = System.Drawing.Color.White;
            this.button_HepsiniTemizle.Location = new System.Drawing.Point(493, 244);
            this.button_HepsiniTemizle.Name = "button_HepsiniTemizle";
            this.button_HepsiniTemizle.Size = new System.Drawing.Size(124, 38);
            this.button_HepsiniTemizle.TabIndex = 1;
            this.button_HepsiniTemizle.Text = "Temizle";
            this.button_HepsiniTemizle.UseVisualStyleBackColor = false;
            // 
            // button_Cikar
            // 
            this.button_Cikar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button_Cikar.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.button_Cikar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Cikar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Cikar.ForeColor = System.Drawing.Color.White;
            this.button_Cikar.Location = new System.Drawing.Point(623, 244);
            this.button_Cikar.Name = "button_Cikar";
            this.button_Cikar.Size = new System.Drawing.Size(124, 38);
            this.button_Cikar.TabIndex = 1;
            this.button_Cikar.Text = "Çıkar";
            this.button_Cikar.UseVisualStyleBackColor = false;
            this.button_Cikar.Click += new System.EventHandler(this.button_Cikar_Click);
            // 
            // button_SatisaGit
            // 
            this.button_SatisaGit.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button_SatisaGit.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.button_SatisaGit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_SatisaGit.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_SatisaGit.ForeColor = System.Drawing.Color.White;
            this.button_SatisaGit.Location = new System.Drawing.Point(769, 244);
            this.button_SatisaGit.Name = "button_SatisaGit";
            this.button_SatisaGit.Size = new System.Drawing.Size(124, 38);
            this.button_SatisaGit.TabIndex = 1;
            this.button_SatisaGit.Text = "Satışa Git";
            this.button_SatisaGit.UseVisualStyleBackColor = false;
            this.button_SatisaGit.Click += new System.EventHandler(this.button_SatisaGit_Click);
            // 
            // formRezervasyon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 790);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formRezervasyon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Araç Rezervasyon Yönetimi";
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AracListesi)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Rezervasyonlar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_Ara;
        private System.Windows.Forms.DateTimePicker dateTimePicker_TeslimTarihi;
        private System.Windows.Forms.DateTimePicker dateTimePicker_AlisTarihi;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Sınıfı;
        private System.Windows.Forms.ComboBox comboBox_Yakit;
        private System.Windows.Forms.ComboBox comboBox_Vites;
        private System.Windows.Forms.ComboBox comboBox_Turu;
        private System.Windows.Forms.ComboBox comboBox_Sinifi;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button_HepsiniTemizle;
        private System.Windows.Forms.Button button_Cikar;
        private System.Windows.Forms.Button button_SatisaGit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView_AracListesi;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label_Message;
        private System.Windows.Forms.TextBox textBox_MaxModelYil;
        private System.Windows.Forms.TextBox textBox_MinModelYil;
        private System.Windows.Forms.DataGridView dataGridView_Rezervasyonlar;
    }
}