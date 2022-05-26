using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HastaneSistemi
{
    public partial class FormKulYeniHesap : Form
    {
        public FormKulYeniHesap()
        {
            InitializeComponent();
        }

        private void button_kulKaydet_Click(object sender, EventArgs e)
        {
            string tc = textBox_kul_tc.Text;
            string sifre = textBox_kul_sifre.Text;
            string ad = textBox_kul_ad.Text;
            string soyad = textBox_kul_soyad.Text;
           
            SqlLayer sqllayer = new SqlLayer();

            SqlCommand cmd = sqllayer.Sqlbaglanti().CreateCommand();
            cmd.CommandText = "INSERT INTO kullanici (kullanici_tc, kullanici_ad, kullanici_soyad, kullanici_sifre) VALUES (@tc, @ad, @soyad, @sifre)";

            cmd.Parameters.AddWithValue("@tc", tc);
            cmd.Parameters.AddWithValue("@ad", ad);
            cmd.Parameters.AddWithValue("@soyad", soyad); 
            cmd.Parameters.AddWithValue("@sifre", sifre);
            bool kayitTamam = false;
            if (textBox_kul_sifre.Text == textBox_kulSifre2.Text)
            {
                sqllayer.Sqlbaglanti();
                cmd.ExecuteNonQuery();

                sqllayer.SqlBaglantiKapat();
                MessageBox.Show("Yeni Hesabınız Oluşturuldu.");
                kayitTamam = true;
            }
            else
            {
                MessageBox.Show("Girmiş olduğnuz şifre aynı değil");
                kayitTamam = false;
            }
            if (kayitTamam == true)
            {
                textBox_kul_tc.Clear();
                textBox_kul_sifre.Clear();
                textBox_kul_ad.Clear();
                textBox_kul_soyad.Clear();
                textBox_kulSifre2.Clear();
            }

        }
    }
}
