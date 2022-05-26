namespace HastaneSistemi
{
    partial class FormKulYeniHesap
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
            this.button_kulKaydet = new System.Windows.Forms.Button();
            this.textBox_kul_sifre = new System.Windows.Forms.TextBox();
            this.textBox_kul_soyad = new System.Windows.Forms.TextBox();
            this.textBox_kul_ad = new System.Windows.Forms.TextBox();
            this.textBox_kul_tc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_kulSifre2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_kulKaydet
            // 
            this.button_kulKaydet.Location = new System.Drawing.Point(306, 169);
            this.button_kulKaydet.Name = "button_kulKaydet";
            this.button_kulKaydet.Size = new System.Drawing.Size(113, 23);
            this.button_kulKaydet.TabIndex = 6;
            this.button_kulKaydet.Text = "Kaydet";
            this.button_kulKaydet.UseVisualStyleBackColor = true;
            this.button_kulKaydet.Click += new System.EventHandler(this.button_kulKaydet_Click);
            // 
            // textBox_kul_sifre
            // 
            this.textBox_kul_sifre.Location = new System.Drawing.Point(117, 134);
            this.textBox_kul_sifre.Name = "textBox_kul_sifre";
            this.textBox_kul_sifre.Size = new System.Drawing.Size(137, 20);
            this.textBox_kul_sifre.TabIndex = 4;
            // 
            // textBox_kul_soyad
            // 
            this.textBox_kul_soyad.Location = new System.Drawing.Point(117, 101);
            this.textBox_kul_soyad.Name = "textBox_kul_soyad";
            this.textBox_kul_soyad.Size = new System.Drawing.Size(302, 20);
            this.textBox_kul_soyad.TabIndex = 3;
            // 
            // textBox_kul_ad
            // 
            this.textBox_kul_ad.Location = new System.Drawing.Point(117, 68);
            this.textBox_kul_ad.Name = "textBox_kul_ad";
            this.textBox_kul_ad.Size = new System.Drawing.Size(302, 20);
            this.textBox_kul_ad.TabIndex = 2;
            // 
            // textBox_kul_tc
            // 
            this.textBox_kul_tc.Location = new System.Drawing.Point(117, 35);
            this.textBox_kul_tc.Name = "textBox_kul_tc";
            this.textBox_kul_tc.Size = new System.Drawing.Size(302, 20);
            this.textBox_kul_tc.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Şifre Tekrar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "TC No:";
            // 
            // textBox_kulSifre2
            // 
            this.textBox_kulSifre2.Location = new System.Drawing.Point(117, 169);
            this.textBox_kulSifre2.Name = "textBox_kulSifre2";
            this.textBox_kulSifre2.Size = new System.Drawing.Size(137, 20);
            this.textBox_kulSifre2.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Şifre:";
            // 
            // FormKulYeniHesap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(465, 240);
            this.Controls.Add(this.button_kulKaydet);
            this.Controls.Add(this.textBox_kulSifre2);
            this.Controls.Add(this.textBox_kul_sifre);
            this.Controls.Add(this.textBox_kul_soyad);
            this.Controls.Add(this.textBox_kul_ad);
            this.Controls.Add(this.textBox_kul_tc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormKulYeniHesap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kayit Kabul Yeni Hesap Oluştur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_kulKaydet;
        private System.Windows.Forms.TextBox textBox_kul_sifre;
        private System.Windows.Forms.TextBox textBox_kul_soyad;
        private System.Windows.Forms.TextBox textBox_kul_ad;
        private System.Windows.Forms.TextBox textBox_kul_tc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_kulSifre2;
        private System.Windows.Forms.Label label4;
    }
}