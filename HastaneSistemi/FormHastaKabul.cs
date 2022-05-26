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
    public partial class FormHastaKabul : Form
    {
        public FormHastaKabul()
        {
            InitializeComponent();
        }
        SqlLayer sqllayer = new SqlLayer();

        private void button_yeniHesap_Click(object sender, EventArgs e)
        {
            FormHastaYeniHesap hastaYeniHesap = new FormHastaYeniHesap();
            hastaYeniHesap.ShowDialog();
            Show();
        }

        private void button_hastaTcSorgula_Click(object sender, EventArgs e)
        {
            string tc = textBox_hasta_tc.Text;
            SqlCommand cmd = sqllayer.Sqlbaglanti().CreateCommand();
            
            cmd.CommandText = "SELECT * FROM [hasta] WHERE hasta_tc = @tc";
            cmd.Parameters.AddWithValue("@tc", tc);
            sqllayer.Sqlbaglanti();
            cmd.ExecuteNonQuery();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                textBox_hasta_ad.Text = reader["hasta_ad"].ToString();
                textBox_hasta_soyad.Text = reader["hasta_soyad"].ToString();
                dateTimePicker_yeniHasta.Value = Convert.ToDateTime(reader["hasta_dob"].ToString());                
                textBox_hasta_tel.Text = reader["hasta_tel"].ToString();
                textBox_hasta_adres.Text = reader["hasta_adres"].ToString();
                textBox_hasta_sifre.Text = reader["hasta_sifre"].ToString();

            }

            reader.Close();
            sqllayer.SqlBaglantiKapat();
        }

        private void button_HastaGüncelle_Click(object sender, EventArgs e)
        {
            string tc = textBox_hasta_tc.Text;
            SqlCommand cmd = sqllayer.Sqlbaglanti().CreateCommand();
           
            cmd.CommandText = "UPDATE [hasta] SET hasta_ad = @hasta_ad, hasta_soyad = @hasta_soyad, hasta_dob = @hasta_dob, hasta_tel = @hasta_tel, hasta_adres = @hasta_adres, hasta_sifre = @hasta_sifre WHERE hasta_tc = @tc";
            cmd.Parameters.AddWithValue("@tc", tc);
            cmd.Parameters.AddWithValue("@hasta_ad", textBox_hasta_ad.Text);
            cmd.Parameters.AddWithValue("@hasta_soyad", textBox_hasta_soyad.Text);
            DateTime dt = new DateTime();
            dt = Convert.ToDateTime(dateTimePicker_yeniHasta.Text);
            cmd.Parameters.AddWithValue("@hasta_dob",dt);
            cmd.Parameters.AddWithValue("@hasta_tel", textBox_hasta_tel.Text);
            cmd.Parameters.AddWithValue("@hasta_adres", textBox_hasta_adres.Text);
            cmd.Parameters.AddWithValue("@hasta_sifre", textBox_hasta_sifre.Text);
            
            sqllayer.Sqlbaglanti();
            cmd.ExecuteNonQuery();          
            sqllayer.SqlBaglantiKapat();
            MessageBox.Show("Kayıt Güncellendi...");
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                FormHastaRandevu hastaRandevugoster = new FormHastaRandevu(textBox_hasta_tc.Text);
                hastaRandevugoster.ShowDialog();
                Show();
           
        }

        private void button_temizle_Click(object sender, EventArgs e)
        {
            textBox_hasta_tc.Clear();
            textBox_hasta_ad.Clear();
            textBox_hasta_soyad.Clear();
            textBox_hasta_tel.Clear();
            textBox_hasta_sifre.Clear();
            textBox_hasta_adres.Clear();
            dateTimePicker_yeniHasta.Value = DateTime.Now.Date;
        }
    }
}
