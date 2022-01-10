namespace AracKiralama
{
    partial class formMarka
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
            this.dataGridView_Markalar = new System.Windows.Forms.DataGridView();
            this.textBox_Ara = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_MarkaAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_Durumu = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_Message = new System.Windows.Forms.Label();
            this.button_Ekle = new System.Windows.Forms.Button();
            this.button_Sil = new System.Windows.Forms.Button();
            this.button_Temizle = new System.Windows.Forms.Button();
            this.button_Guncelle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_MarkaId = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Markalar)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView_Markalar);
            this.panel1.Controls.Add(this.textBox_Ara);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(614, 307);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView_Markalar
            // 
            this.dataGridView_Markalar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Markalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Markalar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Markalar.Location = new System.Drawing.Point(0, 28);
            this.dataGridView_Markalar.Name = "dataGridView_Markalar";
            this.dataGridView_Markalar.RowHeadersWidth = 51;
            this.dataGridView_Markalar.RowTemplate.Height = 24;
            this.dataGridView_Markalar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Markalar.Size = new System.Drawing.Size(614, 279);
            this.dataGridView_Markalar.TabIndex = 1;
            this.dataGridView_Markalar.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_Markalar_RowHeaderMouseClick);
            // 
            // textBox_Ara
            // 
            this.textBox_Ara.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_Ara.Location = new System.Drawing.Point(0, 0);
            this.textBox_Ara.Name = "textBox_Ara";
            this.textBox_Ara.Size = new System.Drawing.Size(614, 28);
            this.textBox_Ara.TabIndex = 0;
            this.textBox_Ara.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_Ara.TextChanged += new System.EventHandler(this.textBox_Ara_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 377);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Marka Adı";
            // 
            // textBox_MarkaAdi
            // 
            this.textBox_MarkaAdi.Location = new System.Drawing.Point(225, 374);
            this.textBox_MarkaAdi.Name = "textBox_MarkaAdi";
            this.textBox_MarkaAdi.Size = new System.Drawing.Size(271, 28);
            this.textBox_MarkaAdi.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 428);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Durumu";
            // 
            // comboBox_Durumu
            // 
            this.comboBox_Durumu.FormattingEnabled = true;
            this.comboBox_Durumu.Items.AddRange(new object[] {
            "A-Aktif",
            "P-Pasif"});
            this.comboBox_Durumu.Location = new System.Drawing.Point(225, 428);
            this.comboBox_Durumu.Name = "comboBox_Durumu";
            this.comboBox_Durumu.Size = new System.Drawing.Size(271, 29);
            this.comboBox_Durumu.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label_Message);
            this.panel2.Controls.Add(this.button_Ekle);
            this.panel2.Controls.Add(this.button_Sil);
            this.panel2.Controls.Add(this.button_Temizle);
            this.panel2.Controls.Add(this.button_Guncelle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 477);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(614, 124);
            this.panel2.TabIndex = 4;
            // 
            // label_Message
            // 
            this.label_Message.AutoSize = true;
            this.label_Message.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_Message.ForeColor = System.Drawing.Color.Red;
            this.label_Message.Location = new System.Drawing.Point(12, 77);
            this.label_Message.Name = "label_Message";
            this.label_Message.Size = new System.Drawing.Size(134, 19);
            this.label_Message.TabIndex = 1;
            this.label_Message.Text = "label_Message";
            // 
            // button_Ekle
            // 
            this.button_Ekle.Location = new System.Drawing.Point(420, 18);
            this.button_Ekle.Name = "button_Ekle";
            this.button_Ekle.Size = new System.Drawing.Size(100, 36);
            this.button_Ekle.TabIndex = 0;
            this.button_Ekle.Text = "Ekle";
            this.button_Ekle.UseVisualStyleBackColor = true;
            this.button_Ekle.Click += new System.EventHandler(this.button_Ekle_Click);
            // 
            // button_Sil
            // 
            this.button_Sil.Location = new System.Drawing.Point(314, 18);
            this.button_Sil.Name = "button_Sil";
            this.button_Sil.Size = new System.Drawing.Size(100, 36);
            this.button_Sil.TabIndex = 0;
            this.button_Sil.Text = "Sil";
            this.button_Sil.UseVisualStyleBackColor = true;
            this.button_Sil.Click += new System.EventHandler(this.button_Sil_Click);
            // 
            // button_Temizle
            // 
            this.button_Temizle.Location = new System.Drawing.Point(102, 18);
            this.button_Temizle.Name = "button_Temizle";
            this.button_Temizle.Size = new System.Drawing.Size(100, 36);
            this.button_Temizle.TabIndex = 0;
            this.button_Temizle.Text = "Temizle";
            this.button_Temizle.UseVisualStyleBackColor = true;
            this.button_Temizle.Click += new System.EventHandler(this.button_Temizle_Click);
            // 
            // button_Guncelle
            // 
            this.button_Guncelle.Location = new System.Drawing.Point(208, 18);
            this.button_Guncelle.Name = "button_Guncelle";
            this.button_Guncelle.Size = new System.Drawing.Size(100, 36);
            this.button_Guncelle.TabIndex = 0;
            this.button_Guncelle.Text = "Güncelle";
            this.button_Guncelle.UseVisualStyleBackColor = true;
            this.button_Guncelle.Click += new System.EventHandler(this.button_Guncelle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Marka Id";
            // 
            // textBox_MarkaId
            // 
            this.textBox_MarkaId.Location = new System.Drawing.Point(225, 326);
            this.textBox_MarkaId.Name = "textBox_MarkaId";
            this.textBox_MarkaId.ReadOnly = true;
            this.textBox_MarkaId.Size = new System.Drawing.Size(271, 28);
            this.textBox_MarkaId.TabIndex = 2;
            this.textBox_MarkaId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_MarkaId.TextChanged += new System.EventHandler(this.textBox_MarkaId_TextChanged);
            // 
            // formMarka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 601);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.comboBox_Durumu);
            this.Controls.Add(this.textBox_MarkaId);
            this.Controls.Add(this.textBox_MarkaAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formMarka";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marka Yönetim Sayfası";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formMarka_FormClosed);
            this.Load += new System.EventHandler(this.formMarka_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Markalar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView_Markalar;
        private System.Windows.Forms.TextBox textBox_Ara;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_MarkaAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_Durumu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_Message;
        private System.Windows.Forms.Button button_Ekle;
        private System.Windows.Forms.Button button_Sil;
        private System.Windows.Forms.Button button_Temizle;
        private System.Windows.Forms.Button button_Guncelle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_MarkaId;
    }
}