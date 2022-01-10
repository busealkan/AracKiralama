namespace AracKiralama
{
    partial class formSatis
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_MusteriId = new System.Windows.Forms.Label();
            this.richTextBox_Adres = new System.Windows.Forms.RichTextBox();
            this.button_MusteriEkle = new System.Windows.Forms.Button();
            this.textBox_Tckn = new System.Windows.Forms.TextBox();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Telefon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Soyadi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Adi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_AraTcknOrEmail = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_Message = new System.Windows.Forms.Label();
            this.label_ToplamFiyat = new System.Windows.Forms.Label();
            this.label_ToplamArac = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button_Cikar = new System.Windows.Forms.Button();
            this.button_SatisYap = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView_Rezervasyonlar = new System.Windows.Forms.DataGridView();
            this.button_Temizle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Rezervasyonlar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.groupBox1.Controls.Add(this.label_MusteriId);
            this.groupBox1.Controls.Add(this.richTextBox_Adres);
            this.groupBox1.Controls.Add(this.button_MusteriEkle);
            this.groupBox1.Controls.Add(this.textBox_Tckn);
            this.groupBox1.Controls.Add(this.textBox_Email);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox_Telefon);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox_Soyadi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_Adi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_AraTcknOrEmail);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(671, 302);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Bilgileri";
            // 
            // label_MusteriId
            // 
            this.label_MusteriId.AutoSize = true;
            this.label_MusteriId.Location = new System.Drawing.Point(47, 34);
            this.label_MusteriId.Name = "label_MusteriId";
            this.label_MusteriId.Size = new System.Drawing.Size(25, 19);
            this.label_MusteriId.TabIndex = 5;
            this.label_MusteriId.Text = "Id";
            this.label_MusteriId.TextChanged += new System.EventHandler(this.label_MusteriId_TextChanged);
            // 
            // richTextBox_Adres
            // 
            this.richTextBox_Adres.Enabled = false;
            this.richTextBox_Adres.Location = new System.Drawing.Point(423, 191);
            this.richTextBox_Adres.Name = "richTextBox_Adres";
            this.richTextBox_Adres.ReadOnly = true;
            this.richTextBox_Adres.Size = new System.Drawing.Size(200, 99);
            this.richTextBox_Adres.TabIndex = 7;
            this.richTextBox_Adres.Text = "";
            // 
            // button_MusteriEkle
            // 
            this.button_MusteriEkle.FlatAppearance.BorderSize = 0;
            this.button_MusteriEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_MusteriEkle.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_MusteriEkle.Location = new System.Drawing.Point(629, 15);
            this.button_MusteriEkle.Name = "button_MusteriEkle";
            this.button_MusteriEkle.Size = new System.Drawing.Size(29, 44);
            this.button_MusteriEkle.TabIndex = 1;
            this.button_MusteriEkle.Text = "+";
            this.button_MusteriEkle.UseVisualStyleBackColor = true;
            // 
            // textBox_Tckn
            // 
            this.textBox_Tckn.Enabled = false;
            this.textBox_Tckn.Location = new System.Drawing.Point(104, 187);
            this.textBox_Tckn.Name = "textBox_Tckn";
            this.textBox_Tckn.ReadOnly = true;
            this.textBox_Tckn.Size = new System.Drawing.Size(200, 28);
            this.textBox_Tckn.TabIndex = 6;
            // 
            // textBox_Email
            // 
            this.textBox_Email.Enabled = false;
            this.textBox_Email.Location = new System.Drawing.Point(423, 136);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.ReadOnly = true;
            this.textBox_Email.Size = new System.Drawing.Size(200, 28);
            this.textBox_Email.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(345, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 19);
            this.label6.TabIndex = 1;
            this.label6.Text = "Adres";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(27, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "TCKN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(347, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Email";
            // 
            // textBox_Telefon
            // 
            this.textBox_Telefon.Enabled = false;
            this.textBox_Telefon.Location = new System.Drawing.Point(423, 84);
            this.textBox_Telefon.Name = "textBox_Telefon";
            this.textBox_Telefon.ReadOnly = true;
            this.textBox_Telefon.Size = new System.Drawing.Size(200, 28);
            this.textBox_Telefon.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(339, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Telefon";
            // 
            // textBox_Soyadi
            // 
            this.textBox_Soyadi.Enabled = false;
            this.textBox_Soyadi.Location = new System.Drawing.Point(104, 130);
            this.textBox_Soyadi.Name = "textBox_Soyadi";
            this.textBox_Soyadi.ReadOnly = true;
            this.textBox_Soyadi.Size = new System.Drawing.Size(200, 28);
            this.textBox_Soyadi.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(21, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyadi";
            // 
            // textBox_Adi
            // 
            this.textBox_Adi.Enabled = false;
            this.textBox_Adi.Location = new System.Drawing.Point(104, 86);
            this.textBox_Adi.Name = "textBox_Adi";
            this.textBox_Adi.ReadOnly = true;
            this.textBox_Adi.Size = new System.Drawing.Size(200, 28);
            this.textBox_Adi.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(35, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adi";
            // 
            // textBox_AraTcknOrEmail
            // 
            this.textBox_AraTcknOrEmail.Location = new System.Drawing.Point(104, 25);
            this.textBox_AraTcknOrEmail.Name = "textBox_AraTcknOrEmail";
            this.textBox_AraTcknOrEmail.Size = new System.Drawing.Size(519, 28);
            this.textBox_AraTcknOrEmail.TabIndex = 0;
            this.textBox_AraTcknOrEmail.Text = "TCKN veya Email Giriniz";
            this.textBox_AraTcknOrEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_AraTcknOrEmail.TextChanged += new System.EventHandler(this.textBox_AraTcknOrEmail_TextChanged);
            this.textBox_AraTcknOrEmail.MouseLeave += new System.EventHandler(this.textBox_AraTcknOrEmail_MouseLeave);
            this.textBox_AraTcknOrEmail.MouseHover += new System.EventHandler(this.textBox_AraTcknOrEmail_MouseHover);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.label_Message);
            this.panel1.Controls.Add(this.label_ToplamFiyat);
            this.panel1.Controls.Add(this.label_ToplamArac);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.button_Temizle);
            this.panel1.Controls.Add(this.button_Cikar);
            this.panel1.Controls.Add(this.button_SatisYap);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 521);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(671, 88);
            this.panel1.TabIndex = 2;
            // 
            // label_Message
            // 
            this.label_Message.AutoSize = true;
            this.label_Message.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_Message.ForeColor = System.Drawing.Color.DarkRed;
            this.label_Message.Location = new System.Drawing.Point(12, 58);
            this.label_Message.Name = "label_Message";
            this.label_Message.Size = new System.Drawing.Size(134, 19);
            this.label_Message.TabIndex = 4;
            this.label_Message.Text = "label_Message";
            // 
            // label_ToplamFiyat
            // 
            this.label_ToplamFiyat.AutoSize = true;
            this.label_ToplamFiyat.Location = new System.Drawing.Point(145, 6);
            this.label_ToplamFiyat.Name = "label_ToplamFiyat";
            this.label_ToplamFiyat.Size = new System.Drawing.Size(159, 21);
            this.label_ToplamFiyat.TabIndex = 3;
            this.label_ToplamFiyat.Text = "label_ToplamFiyat";
            // 
            // label_ToplamArac
            // 
            this.label_ToplamArac.AutoSize = true;
            this.label_ToplamArac.Location = new System.Drawing.Point(145, 35);
            this.label_ToplamArac.Name = "label_ToplamArac";
            this.label_ToplamArac.Size = new System.Drawing.Size(162, 21);
            this.label_ToplamArac.TabIndex = 2;
            this.label_ToplamArac.Text = "label_ToplamArac";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 21);
            this.label8.TabIndex = 2;
            this.label8.Text = "Toplam Araç :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 21);
            this.label7.TabIndex = 1;
            this.label7.Text = "Toplam Fiyat : ";
            // 
            // button_Cikar
            // 
            this.button_Cikar.FlatAppearance.BorderSize = 0;
            this.button_Cikar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Cikar.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Cikar.ForeColor = System.Drawing.Color.White;
            this.button_Cikar.Location = new System.Drawing.Point(433, 12);
            this.button_Cikar.Name = "button_Cikar";
            this.button_Cikar.Size = new System.Drawing.Size(92, 50);
            this.button_Cikar.TabIndex = 9;
            this.button_Cikar.Text = "Çıkar";
            this.button_Cikar.UseVisualStyleBackColor = true;
            this.button_Cikar.Click += new System.EventHandler(this.button_Cikar_Click);
            // 
            // button_SatisYap
            // 
            this.button_SatisYap.FlatAppearance.BorderSize = 0;
            this.button_SatisYap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_SatisYap.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_SatisYap.ForeColor = System.Drawing.Color.White;
            this.button_SatisYap.Location = new System.Drawing.Point(530, 12);
            this.button_SatisYap.Name = "button_SatisYap";
            this.button_SatisYap.Size = new System.Drawing.Size(128, 50);
            this.button_SatisYap.TabIndex = 8;
            this.button_SatisYap.Text = "Satış Yap";
            this.button_SatisYap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_SatisYap.UseVisualStyleBackColor = true;
            this.button_SatisYap.Click += new System.EventHandler(this.button_SatisYap_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView_Rezervasyonlar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 302);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(671, 219);
            this.panel2.TabIndex = 3;
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
            this.dataGridView_Rezervasyonlar.Size = new System.Drawing.Size(671, 219);
            this.dataGridView_Rezervasyonlar.TabIndex = 0;
            // 
            // button_Temizle
            // 
            this.button_Temizle.FlatAppearance.BorderSize = 0;
            this.button_Temizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Temizle.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Temizle.ForeColor = System.Drawing.Color.White;
            this.button_Temizle.Location = new System.Drawing.Point(321, 12);
            this.button_Temizle.Name = "button_Temizle";
            this.button_Temizle.Size = new System.Drawing.Size(114, 50);
            this.button_Temizle.TabIndex = 9;
            this.button_Temizle.Text = "Temizle";
            this.button_Temizle.UseVisualStyleBackColor = true;
            this.button_Temizle.Click += new System.EventHandler(this.button_Temizle_Click);
            // 
            // formSatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 609);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formSatis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satış Tablosu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Rezervasyonlar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_MusteriId;
        private System.Windows.Forms.RichTextBox richTextBox_Adres;
        private System.Windows.Forms.Button button_MusteriEkle;
        private System.Windows.Forms.TextBox textBox_Tckn;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Telefon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Soyadi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Adi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_AraTcknOrEmail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView_Rezervasyonlar;
        private System.Windows.Forms.Button button_SatisYap;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_ToplamFiyat;
        private System.Windows.Forms.Label label_ToplamArac;
        private System.Windows.Forms.Button button_Cikar;
        private System.Windows.Forms.Label label_Message;
        private System.Windows.Forms.Button button_Temizle;
    }
}