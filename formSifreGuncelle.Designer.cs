
namespace AracKiralama
{
    partial class formSifreGuncelle
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
            this.pictureBox_Logo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_KAdiEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Sifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_SifreTekrarı = new System.Windows.Forms.TextBox();
            this.button_SifreGuncelle = new System.Windows.Forms.Button();
            this.label_Message = new System.Windows.Forms.Label();
            this.button_Cikis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_Logo
            // 
            this.pictureBox_Logo.Location = new System.Drawing.Point(216, 41);
            this.pictureBox_Logo.Name = "pictureBox_Logo";
            this.pictureBox_Logo.Size = new System.Drawing.Size(224, 169);
            this.pictureBox_Logo.TabIndex = 0;
            this.pictureBox_Logo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(31, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Adı / Email";
            // 
            // textBox_KAdiEmail
            // 
            this.textBox_KAdiEmail.Location = new System.Drawing.Point(216, 239);
            this.textBox_KAdiEmail.Name = "textBox_KAdiEmail";
            this.textBox_KAdiEmail.ReadOnly = true;
            this.textBox_KAdiEmail.Size = new System.Drawing.Size(224, 28);
            this.textBox_KAdiEmail.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(138, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifreniz ";
            // 
            // textBox_Sifre
            // 
            this.textBox_Sifre.Location = new System.Drawing.Point(216, 297);
            this.textBox_Sifre.Name = "textBox_Sifre";
            this.textBox_Sifre.Size = new System.Drawing.Size(224, 28);
            this.textBox_Sifre.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(98, 351);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Şifre Tekrarı";
            // 
            // textBox_SifreTekrarı
            // 
            this.textBox_SifreTekrarı.Location = new System.Drawing.Point(216, 351);
            this.textBox_SifreTekrarı.Name = "textBox_SifreTekrarı";
            this.textBox_SifreTekrarı.Size = new System.Drawing.Size(224, 28);
            this.textBox_SifreTekrarı.TabIndex = 2;
            // 
            // button_SifreGuncelle
            // 
            this.button_SifreGuncelle.FlatAppearance.BorderSize = 0;
            this.button_SifreGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_SifreGuncelle.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_SifreGuncelle.ForeColor = System.Drawing.Color.White;
            this.button_SifreGuncelle.Location = new System.Drawing.Point(216, 421);
            this.button_SifreGuncelle.Name = "button_SifreGuncelle";
            this.button_SifreGuncelle.Size = new System.Drawing.Size(224, 35);
            this.button_SifreGuncelle.TabIndex = 3;
            this.button_SifreGuncelle.Text = "Şifre Güncelle";
            this.button_SifreGuncelle.UseVisualStyleBackColor = true;
            this.button_SifreGuncelle.Click += new System.EventHandler(this.button_SifreGuncelle_Click);
            // 
            // label_Message
            // 
            this.label_Message.AutoSize = true;
            this.label_Message.ForeColor = System.Drawing.Color.Red;
            this.label_Message.Location = new System.Drawing.Point(13, 516);
            this.label_Message.Name = "label_Message";
            this.label_Message.Size = new System.Drawing.Size(136, 21);
            this.label_Message.TabIndex = 4;
            this.label_Message.Text = "label_Message";
            // 
            // button_Cikis
            // 
            this.button_Cikis.FlatAppearance.BorderSize = 0;
            this.button_Cikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Cikis.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Cikis.ForeColor = System.Drawing.Color.White;
            this.button_Cikis.Location = new System.Drawing.Point(516, 12);
            this.button_Cikis.Name = "button_Cikis";
            this.button_Cikis.Size = new System.Drawing.Size(54, 44);
            this.button_Cikis.TabIndex = 5;
            this.button_Cikis.Text = "X";
            this.button_Cikis.UseVisualStyleBackColor = true;
            this.button_Cikis.Click += new System.EventHandler(this.button_Cikis_Click);
            // 
            // formSifreGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(582, 575);
            this.Controls.Add(this.button_Cikis);
            this.Controls.Add(this.label_Message);
            this.Controls.Add(this.button_SifreGuncelle);
            this.Controls.Add(this.textBox_SifreTekrarı);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Sifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_KAdiEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox_Logo);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "formSifreGuncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formSifreGuncelle";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Logo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_KAdiEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Sifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_SifreTekrarı;
        private System.Windows.Forms.Button button_SifreGuncelle;
        private System.Windows.Forms.Label label_Message;
        private System.Windows.Forms.Button button_Cikis;
    }
}