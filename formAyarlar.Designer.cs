
namespace AracKiralama
{
    partial class formAyarlar
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
            this.button5 = new System.Windows.Forms.Button();
            this.button_Calisan = new System.Windows.Forms.Button();
            this.button_Musteriler = new System.Windows.Forms.Button();
            this.button_Fiyatlar = new System.Windows.Forms.Button();
            this.button_Cikis = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_Formlar = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button_Calisan);
            this.groupBox1.Controls.Add(this.button_Musteriler);
            this.groupBox1.Controls.Add(this.button_Fiyatlar);
            this.groupBox1.Controls.Add(this.button_Cikis);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(994, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İşlemler";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(702, 26);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(174, 55);
            this.button5.TabIndex = 1;
            this.button5.Text = "button2";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button_Calisan
            // 
            this.button_Calisan.Location = new System.Drawing.Point(507, 26);
            this.button_Calisan.Name = "button_Calisan";
            this.button_Calisan.Size = new System.Drawing.Size(174, 55);
            this.button_Calisan.TabIndex = 1;
            this.button_Calisan.Text = "Çalışanlar";
            this.button_Calisan.UseVisualStyleBackColor = true;
            this.button_Calisan.Click += new System.EventHandler(this.button_Calisan_Click);
            // 
            // button_Musteriler
            // 
            this.button_Musteriler.Location = new System.Drawing.Point(313, 26);
            this.button_Musteriler.Name = "button_Musteriler";
            this.button_Musteriler.Size = new System.Drawing.Size(174, 55);
            this.button_Musteriler.TabIndex = 1;
            this.button_Musteriler.Text = "Müşteriler";
            this.button_Musteriler.UseVisualStyleBackColor = true;
            this.button_Musteriler.Click += new System.EventHandler(this.button_Musteriler_Click);
            // 
            // button_Fiyatlar
            // 
            this.button_Fiyatlar.Location = new System.Drawing.Point(124, 27);
            this.button_Fiyatlar.Name = "button_Fiyatlar";
            this.button_Fiyatlar.Size = new System.Drawing.Size(174, 55);
            this.button_Fiyatlar.TabIndex = 1;
            this.button_Fiyatlar.Text = "Fiyatlar";
            this.button_Fiyatlar.UseVisualStyleBackColor = true;
            this.button_Fiyatlar.Click += new System.EventHandler(this.button_Fiyatlar_Click);
            // 
            // button_Cikis
            // 
            this.button_Cikis.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_Cikis.FlatAppearance.BorderSize = 0;
            this.button_Cikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Cikis.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Cikis.Location = new System.Drawing.Point(939, 24);
            this.button_Cikis.Name = "button_Cikis";
            this.button_Cikis.Size = new System.Drawing.Size(52, 73);
            this.button_Cikis.TabIndex = 0;
            this.button_Cikis.Text = "X";
            this.button_Cikis.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_Cikis.UseVisualStyleBackColor = true;
            this.button_Cikis.Click += new System.EventHandler(this.button_Cikis_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 718);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(994, 73);
            this.panel1.TabIndex = 1;
            // 
            // panel_Formlar
            // 
            this.panel_Formlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Formlar.Location = new System.Drawing.Point(0, 100);
            this.panel_Formlar.Name = "panel_Formlar";
            this.panel_Formlar.Size = new System.Drawing.Size(994, 618);
            this.panel_Formlar.TabIndex = 2;
            // 
            // formAyarlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 791);
            this.Controls.Add(this.panel_Formlar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formAyarlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formAyarlar";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button_Calisan;
        private System.Windows.Forms.Button button_Musteriler;
        private System.Windows.Forms.Button button_Fiyatlar;
        private System.Windows.Forms.Button button_Cikis;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_Formlar;
    }
}