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
    public partial class FormGiris : Form
    {
        public FormGiris()
        {
            InitializeComponent();
           
        }
        SqlLayer sqllayer = new SqlLayer();
        
        private void button_kullanici_giris_Click(object sender, EventArgs e)
        {   string tc = textBox_kullanici_tc.Text;
            string sifre = textBox_kullanici_sifre.Text;           
            
            SqlCommand cmd = sqllayer.Sqlbaglanti().CreateCommand();
            cmd.CommandText = "SELECT kullanici_tc FROM[kullanici] WHERE kullanici_tc = @tc AND kullanici_sifre = @sifre";
           
            cmd.Parameters.AddWithValue("@tc", tc);
            cmd.Parameters.AddWithValue("@sifre", sifre);
            sqllayer.Sqlbaglanti();
            cmd.ExecuteNonQuery();
            var result = cmd.ExecuteScalar();
            sqllayer.SqlBaglantiKapat();
            if (result != null)
            {
              
                    //Hasta Kayit Ekranını Göster
                    Hide();
                    FormHastaKabul hastaKabul = new FormHastaKabul();
                    hastaKabul.ShowDialog();
                    Show();
                              
            }
            else
            {
                //Giriş Yapılamadı!!
                MessageBox.Show("Giriş Yapılamadı...!!");

            }



        }

        private void button_hasta_giris_Click(object sender, EventArgs e)
        {
            string tc = textBox_hasta_tc.Text;
            string sifre = textBox_hasta_sifre.Text;

            SqlCommand cmd = sqllayer.Sqlbaglanti().CreateCommand();
            cmd.CommandText = "SELECT hasta_tc FROM[hasta] WHERE hasta_tc = @tc AND hasta_sifre = @sifre";

            cmd.Parameters.AddWithValue("@tc", tc);
            cmd.Parameters.AddWithValue("@sifre", sifre);
            sqllayer.Sqlbaglanti();
            cmd.ExecuteNonQuery();
            var result = cmd.ExecuteScalar();
            sqllayer.SqlBaglantiKapat();
            if (result != null)
            {

                //Hasta Rendebu Ekranını Göster
                Hide();
                FormHastaRandevu hastaRandevu= new FormHastaRandevu(tc);
                hastaRandevu.ShowDialog();
                Show();

            }
            else
            {
                //Giriş Yapılamadı!!
                MessageBox.Show("Giriş Yapılamadı...!!");

            }


        }

        private void button_dr_giris_Click(object sender, EventArgs e)
        {
            string tc = textBox_doktor_tc.Text;
            string sifre = textBox_doktor_sifre.Text;

            SqlCommand cmd = sqllayer.Sqlbaglanti().CreateCommand();
            cmd.CommandText = "SELECT doktor_tc FROM[doktor] WHERE doktor_tc = @tc AND doktor_sifre = @sifre";

            cmd.Parameters.AddWithValue("@tc", tc);
            cmd.Parameters.AddWithValue("@sifre", sifre);
            sqllayer.Sqlbaglanti();
            cmd.ExecuteNonQuery();
            var result = cmd.ExecuteScalar();
            sqllayer.SqlBaglantiKapat();
            if (result != null)
            {

                //Doktor Ekranını Göster
                Hide();
                FormDoktorEkrani doktorEkrani = new FormDoktorEkrani(tc);
                doktorEkrani.ShowDialog();
                Show();

            }
            else
            {
                //Giriş Yapılamadı!!
                MessageBox.Show("Giriş Yapılamadı...!!");

            }


        }

        private void button_new_hasta_Click(object sender, EventArgs e)
        {
            Hide();
            FormHastaYeniHesap hastaYeniHesap = new FormHastaYeniHesap();
            hastaYeniHesap.ShowDialog();
            Show();
        }

        private void button_new_dr_Click(object sender, EventArgs e)
        {
            Hide();
            FormDrYeni drYeniHesap = new FormDrYeni();
            drYeniHesap.ShowDialog();
            Show();
        }

        private void button_new_kullanici_Click(object sender, EventArgs e)
        {
            Hide();
            FormKulYeniHesap kullaniciYeniHesap = new FormKulYeniHesap();
            kullaniciYeniHesap.ShowDialog();
            Show();
        }
    }
}
