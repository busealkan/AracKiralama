namespace AracKiralama
{
    partial class formLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formLogin));
            this.txt_KAdiEamil = new System.Windows.Forms.TextBox();
            this.txt_Parola = new System.Windows.Forms.TextBox();
            this.button_Giris = new System.Windows.Forms.Button();
            this.linkLabel_SifremiUnuttum = new System.Windows.Forms.LinkLabel();
            this.label_Message = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label_Cikis = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkBox_BeniHatirla = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_KAdiEamil
            // 
            this.txt_KAdiEamil.Location = new System.Drawing.Point(160, 139);
            this.txt_KAdiEamil.Name = "txt_KAdiEamil";
            this.txt_KAdiEamil.Size = new System.Drawing.Size(200, 28);
            this.txt_KAdiEamil.TabIndex = 1;
            this.txt_KAdiEamil.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_KAdiEamil.TextChanged += new System.EventHandler(this.txt_KAdiEamil_TextChanged);
            // 
            // txt_Parola
            // 
            this.txt_Parola.Location = new System.Drawing.Point(160, 193);
            this.txt_Parola.Name = "txt_Parola";
            this.txt_Parola.Size = new System.Drawing.Size(200, 28);
            this.txt_Parola.TabIndex = 2;
            this.txt_Parola.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_Giris
            // 
            this.button_Giris.BackColor = System.Drawing.Color.DimGray;
            this.button_Giris.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_Giris.FlatAppearance.BorderSize = 0;
            this.button_Giris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Giris.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Giris.ForeColor = System.Drawing.Color.White;
            this.button_Giris.Location = new System.Drawing.Point(160, 271);
            this.button_Giris.Name = "button_Giris";
            this.button_Giris.Size = new System.Drawing.Size(179, 33);
            this.button_Giris.TabIndex = 4;
            this.button_Giris.Text = "Giriş";
            this.button_Giris.UseVisualStyleBackColor = false;
            this.button_Giris.Click += new System.EventHandler(this.button_Giris_Click);
            // 
            // linkLabel_SifremiUnuttum
            // 
            this.linkLabel_SifremiUnuttum.AutoSize = true;
            this.linkLabel_SifremiUnuttum.Location = new System.Drawing.Point(178, 324);
            this.linkLabel_SifremiUnuttum.Name = "linkLabel_SifremiUnuttum";
            this.linkLabel_SifremiUnuttum.Size = new System.Drawing.Size(144, 21);
            this.linkLabel_SifremiUnuttum.TabIndex = 6;
            this.linkLabel_SifremiUnuttum.TabStop = true;
            this.linkLabel_SifremiUnuttum.Text = "Şifremi Unutum ?";
            this.linkLabel_SifremiUnuttum.Click += new System.EventHandler(this.linkLabel_SifremiUnuttum_Click);
            // 
            // label_Message
            // 
            this.label_Message.AutoSize = true;
            this.label_Message.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_Message.ForeColor = System.Drawing.Color.Red;
            this.label_Message.Location = new System.Drawing.Point(12, 326);
            this.label_Message.Name = "label_Message";
            this.label_Message.Size = new System.Drawing.Size(134, 19);
            this.label_Message.TabIndex = 99;
            this.label_Message.Text = "label_Message";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(124, 142);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(124, 196);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // label_Cikis
            // 
            this.label_Cikis.AutoSize = true;
            this.label_Cikis.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_Cikis.ForeColor = System.Drawing.Color.White;
            this.label_Cikis.Location = new System.Drawing.Point(434, 4);
            this.label_Cikis.Name = "label_Cikis";
            this.label_Cikis.Size = new System.Drawing.Size(34, 34);
            this.label_Cikis.TabIndex = 5;
            this.label_Cikis.Text = "X";
            this.label_Cikis.Click += new System.EventHandler(this.label_Cikis_Click);
            this.label_Cikis.MouseLeave += new System.EventHandler(this.label_Cikis_MouseLeave);
            this.label_Cikis.MouseHover += new System.EventHandler(this.label_Cikis_MouseHover);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(139, 9);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(212, 121);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(140, 169);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 1);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(140, 223);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 1);
            this.panel2.TabIndex = 10;
            // 
            // checkBox_BeniHatirla
            // 
            this.checkBox_BeniHatirla.AutoSize = true;
            this.checkBox_BeniHatirla.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox_BeniHatirla.ForeColor = System.Drawing.Color.White;
            this.checkBox_BeniHatirla.Location = new System.Drawing.Point(186, 238);
            this.checkBox_BeniHatirla.Name = "checkBox_BeniHatirla";
            this.checkBox_BeniHatirla.Size = new System.Drawing.Size(137, 23);
            this.checkBox_BeniHatirla.TabIndex = 3;
            this.checkBox_BeniHatirla.Text = "Beni Hatırla ?";
            this.checkBox_BeniHatirla.UseVisualStyleBackColor = true;
            // 
            // formLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(472, 367);
            this.Controls.Add(this.checkBox_BeniHatirla);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label_Cikis);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_Message);
            this.Controls.Add(this.linkLabel_SifremiUnuttum);
            this.Controls.Add(this.button_Giris);
            this.Controls.Add(this.txt_Parola);
            this.Controls.Add(this.txt_KAdiEamil);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Araç Kiralama Girişi";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_KAdiEamil;
        private System.Windows.Forms.TextBox txt_Parola;
        private System.Windows.Forms.Button button_Giris;
        private System.Windows.Forms.LinkLabel linkLabel_SifremiUnuttum;
        private System.Windows.Forms.Label label_Message;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label_Cikis;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox checkBox_BeniHatirla;
    }
}