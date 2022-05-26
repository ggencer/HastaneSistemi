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
    public partial class FormDrYeni : Form
    {
        public FormDrYeni()
        {
            InitializeComponent();
        }

        private void button_drKaydet_Click(object sender, EventArgs e)
        {
            string tc = textBox_dr_tc.Text;
            string sifre = textBox_dr_sifre.Text;
            string ad = textBox_dr_ad.Text;
            string soyad = textBox_dr_soyad.Text;            
            string unvan = textBox_dr_uzmanlik.Text;
            SqlLayer sqllayer = new SqlLayer();

            SqlCommand cmd = sqllayer.Sqlbaglanti().CreateCommand();
            cmd.CommandText = "INSERT INTO doktor (doktor_tc, doktor_ad, doktor_soyad, doktor_uzmanlik, doktor_sifre) VALUES (@tc, @ad, @soyad, @unvan, @sifre)";

            cmd.Parameters.AddWithValue("@tc", tc);
            cmd.Parameters.AddWithValue("@ad", ad);
            cmd.Parameters.AddWithValue("@soyad", soyad);            
            cmd.Parameters.AddWithValue("@unvan", unvan);            
            cmd.Parameters.AddWithValue("@sifre", sifre);
            bool kayitTamam = false;
            if (textBox_dr_sifre.Text == textBox_drSifre2.Text)
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
                textBox_dr_tc.Clear();
                textBox_dr_sifre.Clear();
                textBox_dr_ad.Clear();
                textBox_dr_soyad.Clear();
                textBox_dr_uzmanlik.Clear();
                textBox_drSifre2.Clear();
            }

        }
    }
}
