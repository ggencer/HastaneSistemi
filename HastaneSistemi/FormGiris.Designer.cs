namespace HastaneSistemi
{
    partial class FormGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGiris));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_new_hasta = new System.Windows.Forms.Button();
            this.button_hasta_giris = new System.Windows.Forms.Button();
            this.textBox_hasta_sifre = new System.Windows.Forms.TextBox();
            this.textBox_hasta_tc = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_new_kullanici = new System.Windows.Forms.Button();
            this.button_kullanici_giris = new System.Windows.Forms.Button();
            this.textBox_kullanici_sifre = new System.Windows.Forms.TextBox();
            this.textBox_kullanici_tc = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button_new_dr = new System.Windows.Forms.Button();
            this.button_dr_giris = new System.Windows.Forms.Button();
            this.textBox_doktor_sifre = new System.Windows.Forms.TextBox();
            this.textBox_doktor_tc = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.button_new_hasta);
            this.groupBox1.Controls.Add(this.button_hasta_giris);
            this.groupBox1.Controls.Add(this.textBox_hasta_sifre);
            this.groupBox1.Controls.Add(this.textBox_hasta_tc);
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 406);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Randevu Al";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Şifre :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "TC No :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // button_new_hasta
            // 
            this.button_new_hasta.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_new_hasta.Location = new System.Drawing.Point(34, 352);
            this.button_new_hasta.Name = "button_new_hasta";
            this.button_new_hasta.Size = new System.Drawing.Size(200, 37);
            this.button_new_hasta.TabIndex = 4;
            this.button_new_hasta.Text = "Yeni Hesap Oluştur";
            this.button_new_hasta.UseVisualStyleBackColor = false;
            this.button_new_hasta.Click += new System.EventHandler(this.button_new_hasta_Click);
            // 
            // button_hasta_giris
            // 
            this.button_hasta_giris.BackColor = System.Drawing.SystemColors.Highlight;
            this.button_hasta_giris.Location = new System.Drawing.Point(77, 301);
            this.button_hasta_giris.Name = "button_hasta_giris";
            this.button_hasta_giris.Size = new System.Drawing.Size(107, 33);
            this.button_hasta_giris.TabIndex = 3;
            this.button_hasta_giris.Text = "Hasta Giris";
            this.button_hasta_giris.UseVisualStyleBackColor = false;
            this.button_hasta_giris.Click += new System.EventHandler(this.button_hasta_giris_Click);
            // 
            // textBox_hasta_sifre
            // 
            this.textBox_hasta_sifre.Location = new System.Drawing.Point(31, 275);
            this.textBox_hasta_sifre.Name = "textBox_hasta_sifre";
            this.textBox_hasta_sifre.PasswordChar = '*';
            this.textBox_hasta_sifre.Size = new System.Drawing.Size(203, 20);
            this.textBox_hasta_sifre.TabIndex = 2;
            // 
            // textBox_hasta_tc
            // 
            this.textBox_hasta_tc.Location = new System.Drawing.Point(31, 220);
            this.textBox_hasta_tc.Name = "textBox_hasta_tc";
            this.textBox_hasta_tc.Size = new System.Drawing.Size(203, 20);
            this.textBox_hasta_tc.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.button_new_kullanici);
            this.groupBox2.Controls.Add(this.button_kullanici_giris);
            this.groupBox2.Controls.Add(this.textBox_kullanici_sifre);
            this.groupBox2.Controls.Add(this.textBox_kullanici_tc);
            this.groupBox2.Location = new System.Drawing.Point(279, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(261, 406);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kayit Kabul";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Şifre :";
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = null;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(27, 29);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(203, 157);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "TC No :";
            // 
            // button_new_kullanici
            // 
            this.button_new_kullanici.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_new_kullanici.Location = new System.Drawing.Point(34, 352);
            this.button_new_kullanici.Name = "button_new_kullanici";
            this.button_new_kullanici.Size = new System.Drawing.Size(200, 37);
            this.button_new_kullanici.TabIndex = 8;
            this.button_new_kullanici.Text = "Yeni Hesap Oluştur";
            this.button_new_kullanici.UseVisualStyleBackColor = false;
            this.button_new_kullanici.Click += new System.EventHandler(this.button_new_kullanici_Click);
            // 
            // button_kullanici_giris
            // 
            this.button_kullanici_giris.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_kullanici_giris.Location = new System.Drawing.Point(80, 301);
            this.button_kullanici_giris.Name = "button_kullanici_giris";
            this.button_kullanici_giris.Size = new System.Drawing.Size(107, 33);
            this.button_kullanici_giris.TabIndex = 7;
            this.button_kullanici_giris.Text = "Kayit Kabul Giriş";
            this.button_kullanici_giris.UseVisualStyleBackColor = false;
            this.button_kullanici_giris.Click += new System.EventHandler(this.button_kullanici_giris_Click);
            // 
            // textBox_kullanici_sifre
            // 
            this.textBox_kullanici_sifre.Location = new System.Drawing.Point(27, 275);
            this.textBox_kullanici_sifre.Name = "textBox_kullanici_sifre";
            this.textBox_kullanici_sifre.PasswordChar = '*';
            this.textBox_kullanici_sifre.Size = new System.Drawing.Size(203, 20);
            this.textBox_kullanici_sifre.TabIndex = 6;
            // 
            // textBox_kullanici_tc
            // 
            this.textBox_kullanici_tc.Location = new System.Drawing.Point(27, 220);
            this.textBox_kullanici_tc.Name = "textBox_kullanici_tc";
            this.textBox_kullanici_tc.Size = new System.Drawing.Size(203, 20);
            this.textBox_kullanici_tc.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.pictureBox3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.button_new_dr);
            this.groupBox3.Controls.Add(this.button_dr_giris);
            this.groupBox3.Controls.Add(this.textBox_doktor_sifre);
            this.groupBox3.Controls.Add(this.textBox_doktor_tc);
            this.groupBox3.Location = new System.Drawing.Point(546, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(250, 406);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Doktor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Şifre :";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(26, 29);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(203, 157);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "TC No :";
            // 
            // button_new_dr
            // 
            this.button_new_dr.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_new_dr.Location = new System.Drawing.Point(26, 352);
            this.button_new_dr.Name = "button_new_dr";
            this.button_new_dr.Size = new System.Drawing.Size(200, 37);
            this.button_new_dr.TabIndex = 12;
            this.button_new_dr.Text = "Yeni Hesap Oluştur";
            this.button_new_dr.UseVisualStyleBackColor = false;
            this.button_new_dr.Click += new System.EventHandler(this.button_new_dr_Click);
            // 
            // button_dr_giris
            // 
            this.button_dr_giris.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_dr_giris.Location = new System.Drawing.Point(72, 301);
            this.button_dr_giris.Name = "button_dr_giris";
            this.button_dr_giris.Size = new System.Drawing.Size(107, 33);
            this.button_dr_giris.TabIndex = 11;
            this.button_dr_giris.Text = "Doktor Giriş";
            this.button_dr_giris.UseVisualStyleBackColor = false;
            this.button_dr_giris.Click += new System.EventHandler(this.button_dr_giris_Click);
            // 
            // textBox_doktor_sifre
            // 
            this.textBox_doktor_sifre.Location = new System.Drawing.Point(26, 275);
            this.textBox_doktor_sifre.Name = "textBox_doktor_sifre";
            this.textBox_doktor_sifre.PasswordChar = '*';
            this.textBox_doktor_sifre.Size = new System.Drawing.Size(203, 20);
            this.textBox_doktor_sifre.TabIndex = 10;
            // 
            // textBox_doktor_tc
            // 
            this.textBox_doktor_tc.Location = new System.Drawing.Point(26, 220);
            this.textBox_doktor_tc.Name = "textBox_doktor_tc";
            this.textBox_doktor_tc.Size = new System.Drawing.Size(203, 20);
            this.textBox_doktor_tc.TabIndex = 9;
            // 
            // FormGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(806, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hastane Bilgi Sistemi";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_new_hasta;
        private System.Windows.Forms.Button button_hasta_giris;
        private System.Windows.Forms.TextBox textBox_hasta_sifre;
        private System.Windows.Forms.TextBox textBox_hasta_tc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_new_kullanici;
        private System.Windows.Forms.Button button_kullanici_giris;
        private System.Windows.Forms.TextBox textBox_kullanici_sifre;
        private System.Windows.Forms.TextBox textBox_kullanici_tc;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button_new_dr;
        private System.Windows.Forms.Button button_dr_giris;
        private System.Windows.Forms.TextBox textBox_doktor_sifre;
        private System.Windows.Forms.TextBox textBox_doktor_tc;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
    }
}

