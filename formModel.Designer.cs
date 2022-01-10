namespace AracKiralama
{
    partial class formModel
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
            this.button_MarkaEkle = new System.Windows.Forms.Button();
            this.dataGridView_Model = new System.Windows.Forms.DataGridView();
            this.textBox_AraModelAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_AraMarka = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_Message = new System.Windows.Forms.Label();
            this.button_Ekle = new System.Windows.Forms.Button();
            this.button_Sil = new System.Windows.Forms.Button();
            this.button_Guncelle = new System.Windows.Forms.Button();
            this.button_Temizle = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_Markasi = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_ModelAdi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_Durumu = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_ModelId = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Model)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_MarkaEkle);
            this.panel1.Controls.Add(this.dataGridView_Model);
            this.panel1.Controls.Add(this.textBox_AraModelAdi);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBox_AraMarka);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 297);
            this.panel1.TabIndex = 0;
            // 
            // button_MarkaEkle
            // 
            this.button_MarkaEkle.FlatAppearance.BorderSize = 0;
            this.button_MarkaEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_MarkaEkle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_MarkaEkle.Location = new System.Drawing.Point(340, 16);
            this.button_MarkaEkle.Name = "button_MarkaEkle";
            this.button_MarkaEkle.Size = new System.Drawing.Size(32, 29);
            this.button_MarkaEkle.TabIndex = 5;
            this.button_MarkaEkle.Text = "+";
            this.button_MarkaEkle.UseVisualStyleBackColor = true;
            this.button_MarkaEkle.Click += new System.EventHandler(this.button_MarkaEkle_Click);
            // 
            // dataGridView_Model
            // 
            this.dataGridView_Model.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Model.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Model.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView_Model.Location = new System.Drawing.Point(0, 51);
            this.dataGridView_Model.Name = "dataGridView_Model";
            this.dataGridView_Model.RowHeadersWidth = 51;
            this.dataGridView_Model.RowTemplate.Height = 24;
            this.dataGridView_Model.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Model.Size = new System.Drawing.Size(782, 246);
            this.dataGridView_Model.TabIndex = 4;
            this.dataGridView_Model.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_Model_RowHeaderMouseClick);
            // 
            // textBox_AraModelAdi
            // 
            this.textBox_AraModelAdi.Location = new System.Drawing.Point(510, 16);
            this.textBox_AraModelAdi.Name = "textBox_AraModelAdi";
            this.textBox_AraModelAdi.Size = new System.Drawing.Size(225, 28);
            this.textBox_AraModelAdi.TabIndex = 3;
            this.textBox_AraModelAdi.TextChanged += new System.EventHandler(this.textBox_AraModelAdi_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(400, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Modeli Adi";
            // 
            // comboBox_AraMarka
            // 
            this.comboBox_AraMarka.FormattingEnabled = true;
            this.comboBox_AraMarka.Location = new System.Drawing.Point(135, 16);
            this.comboBox_AraMarka.Name = "comboBox_AraMarka";
            this.comboBox_AraMarka.Size = new System.Drawing.Size(201, 29);
            this.comboBox_AraMarka.TabIndex = 1;
            this.comboBox_AraMarka.SelectedIndexChanged += new System.EventHandler(this.comboBox_AraMarka_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Markası";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label_Message);
            this.panel2.Controls.Add(this.button_Ekle);
            this.panel2.Controls.Add(this.button_Sil);
            this.panel2.Controls.Add(this.button_Guncelle);
            this.panel2.Controls.Add(this.button_Temizle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 474);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(782, 125);
            this.panel2.TabIndex = 1;
            // 
            // label_Message
            // 
            this.label_Message.AutoSize = true;
            this.label_Message.Location = new System.Drawing.Point(23, 80);
            this.label_Message.Name = "label_Message";
            this.label_Message.Size = new System.Drawing.Size(136, 21);
            this.label_Message.TabIndex = 1;
            this.label_Message.Text = "label_Message";
            // 
            // button_Ekle
            // 
            this.button_Ekle.Location = new System.Drawing.Point(510, 18);
            this.button_Ekle.Name = "button_Ekle";
            this.button_Ekle.Size = new System.Drawing.Size(98, 39);
            this.button_Ekle.TabIndex = 0;
            this.button_Ekle.Text = "Ekle";
            this.button_Ekle.UseVisualStyleBackColor = true;
            this.button_Ekle.Click += new System.EventHandler(this.button_Ekle_Click);
            // 
            // button_Sil
            // 
            this.button_Sil.Location = new System.Drawing.Point(392, 18);
            this.button_Sil.Name = "button_Sil";
            this.button_Sil.Size = new System.Drawing.Size(98, 39);
            this.button_Sil.TabIndex = 0;
            this.button_Sil.Text = "Sil";
            this.button_Sil.UseVisualStyleBackColor = true;
            this.button_Sil.Click += new System.EventHandler(this.button_Sil_Click);
            // 
            // button_Guncelle
            // 
            this.button_Guncelle.Location = new System.Drawing.Point(279, 18);
            this.button_Guncelle.Name = "button_Guncelle";
            this.button_Guncelle.Size = new System.Drawing.Size(98, 39);
            this.button_Guncelle.TabIndex = 0;
            this.button_Guncelle.Text = "Güncelle";
            this.button_Guncelle.UseVisualStyleBackColor = true;
            this.button_Guncelle.Click += new System.EventHandler(this.button_Guncelle_Click);
            // 
            // button_Temizle
            // 
            this.button_Temizle.Location = new System.Drawing.Point(164, 18);
            this.button_Temizle.Name = "button_Temizle";
            this.button_Temizle.Size = new System.Drawing.Size(98, 39);
            this.button_Temizle.TabIndex = 0;
            this.button_Temizle.Text = "Temizle";
            this.button_Temizle.UseVisualStyleBackColor = true;
            this.button_Temizle.Click += new System.EventHandler(this.button_Temizle_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Markası";
            // 
            // comboBox_Markasi
            // 
            this.comboBox_Markasi.FormattingEnabled = true;
            this.comboBox_Markasi.Location = new System.Drawing.Point(146, 330);
            this.comboBox_Markasi.Name = "comboBox_Markasi";
            this.comboBox_Markasi.Size = new System.Drawing.Size(211, 29);
            this.comboBox_Markasi.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(400, 335);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Modeli Adi";
            // 
            // textBox_ModelAdi
            // 
            this.textBox_ModelAdi.Location = new System.Drawing.Point(510, 333);
            this.textBox_ModelAdi.Name = "textBox_ModelAdi";
            this.textBox_ModelAdi.Size = new System.Drawing.Size(211, 28);
            this.textBox_ModelAdi.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 411);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Durumu";
            // 
            // comboBox_Durumu
            // 
            this.comboBox_Durumu.FormattingEnabled = true;
            this.comboBox_Durumu.Items.AddRange(new object[] {
            "A-Aktif",
            "P-Pasif"});
            this.comboBox_Durumu.Location = new System.Drawing.Point(146, 408);
            this.comboBox_Durumu.Name = "comboBox_Durumu";
            this.comboBox_Durumu.Size = new System.Drawing.Size(211, 29);
            this.comboBox_Durumu.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(418, 413);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 21);
            this.label7.TabIndex = 2;
            this.label7.Text = "Model Id";
            // 
            // textBox_ModelId
            // 
            this.textBox_ModelId.Location = new System.Drawing.Point(510, 411);
            this.textBox_ModelId.Name = "textBox_ModelId";
            this.textBox_ModelId.ReadOnly = true;
            this.textBox_ModelId.Size = new System.Drawing.Size(211, 28);
            this.textBox_ModelId.TabIndex = 3;
            this.textBox_ModelId.TextChanged += new System.EventHandler(this.textBox_ModelId_TextChanged);
            // 
            // formModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 599);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox_ModelId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox_Durumu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox_Markasi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_ModelAdi);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formModel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Model Yönetim Paneli";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Model)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView_Model;
        private System.Windows.Forms.TextBox textBox_AraModelAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_AraMarka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_MarkaEkle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_Message;
        private System.Windows.Forms.Button button_Ekle;
        private System.Windows.Forms.Button button_Sil;
        private System.Windows.Forms.Button button_Guncelle;
        private System.Windows.Forms.Button button_Temizle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_Markasi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_ModelAdi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_Durumu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_ModelId;
    }
}