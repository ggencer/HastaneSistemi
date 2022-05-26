using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneSistemi
{
    public partial class FormHastaYeniHesap : Form
    {
        public FormHastaYeniHesap()
        {
            InitializeComponent();
        }

        private void button_HastaKaydet_Click(object sender, EventArgs e)
        {
            string tc = textBox_hasta_tc.Text;
            string sifre = textBox_hasta_sifre.Text;
            string ad = textBox_hasta_ad.Text;
            string soyad = textBox_hasta_soyad.Text;           
            DateTime dt = new DateTime();
            dt = Convert.ToDateTime(dateTimePicker_yeniHasta.Text);
            string tel = textBox_hasta_tel.Text;
            string adres = textBox_hasta_adres.Text;
            SqlLayer sqllayer = new SqlLayer();

            SqlCommand cmd = sqllayer.Sqlbaglanti().CreateCommand();
            cmd.CommandText = "INSERT INTO hasta (hasta_tc, hasta_ad, hasta_soyad, hasta_dob, hasta_tel, hasta_adres, hasta_sifre) VALUES (@tc, @ad, @soyad, @dob, @tel, @adres, @sifre)";

            cmd.Parameters.AddWithValue("@tc", tc);
            cmd.Parameters.AddWithValue("@ad", ad);
            cmd.Parameters.AddWithValue("@soyad", soyad);
            cmd.Parameters.AddWithValue("@dob", dt);// Tarih
            cmd.Parameters.AddWithValue("@tel", tel);
            cmd.Parameters.AddWithValue("@adres", adres);
            cmd.Parameters.AddWithValue("@sifre", sifre);
            bool kayitTamam = false;
            if (textBox_hasta_sifre.Text == textBox_hastaSifre2.Text)
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
                textBox_hasta_tc.Clear();
                textBox_hasta_sifre.Clear();
                textBox_hasta_ad.Clear();
                textBox_hasta_soyad.Clear();
                textBox_hasta_tel.Clear();
                textBox_hasta_adres.Clear();
                textBox_hastaSifre2.Clear();
            }


        }
    }
}
