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
    public partial class FormDoktorEkrani : Form
    {
        public string tc { get; set; }
        int doktorID;
        public FormDoktorEkrani(string tc)
        {
            InitializeComponent();
            this.tc = tc;
        }
        SqlLayer sqllayer = new SqlLayer();
        private void FormDoktorEkrani_Load(object sender, EventArgs e)
        {
            label_tc.Text = tc.ToString();
            SqlCommand cmd = sqllayer.Sqlbaglanti().CreateCommand();
            cmd.CommandText = "SELECT doktor_id, doktor_ad, doktor_soyad FROM[doktor] WHERE doktor_tc = @tc";

            cmd.Parameters.AddWithValue("@tc", tc);
            sqllayer.Sqlbaglanti();
            cmd.ExecuteNonQuery();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                label_ad.Text = reader["doktor_ad"].ToString();
                label_soyad.Text = reader["doktor_soyad"].ToString();
                doktorID = Convert.ToInt32(reader["doktor_id"]);
            }

            reader.Close();
            sqllayer.SqlBaglantiKapat();
        }

        private void button_hastaTcSorgula_Click(object sender, EventArgs e)
        {
            if (textBox_hasta_tc.Text == "")
            {
                MessageBox.Show("TC Numarasi giriniz!");
                
            }
            else
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
                    textBox_hasta_not.Text = reader["hasta_doktor_notlar"].ToString();

                }

                reader.Close();
                sqllayer.SqlBaglantiKapat();
            }
        }

        private void button_NotlariKaydet_Click(object sender, EventArgs e)
        {
            
            SqlCommand cmd = sqllayer.Sqlbaglanti().CreateCommand();

            cmd.CommandText = "UPDATE [hasta] SET hasta_ad = @hasta_ad, hasta_soyad = @hasta_soyad, hasta_dob = @hasta_dob, hasta_tel = @hasta_tel, hasta_doktor_notlar = @hasta_doktor_notlar WHERE hasta_tc = @tc";
            cmd.Parameters.AddWithValue("@tc", textBox_hasta_tc.Text);
            cmd.Parameters.AddWithValue("@hasta_ad", textBox_hasta_ad.Text);
            cmd.Parameters.AddWithValue("@hasta_soyad", textBox_hasta_soyad.Text);
            DateTime dt = new DateTime();
            dt = Convert.ToDateTime(dateTimePicker_yeniHasta.Text);
            cmd.Parameters.AddWithValue("@hasta_dob", dt);
            cmd.Parameters.AddWithValue("@hasta_tel", textBox_hasta_tel.Text);
            cmd.Parameters.AddWithValue("@hasta_doktor_notlar", textBox_hasta_not.Text);
            

            sqllayer.Sqlbaglanti();
            cmd.ExecuteNonQuery();
            sqllayer.SqlBaglantiKapat();
            MessageBox.Show("Kayıt Güncellendi...");
        }

        private void button_temizle_Click(object sender, EventArgs e)
        {
            textBox_hasta_tc.Clear();
            textBox_hasta_ad.Clear();
            textBox_hasta_soyad.Clear();
            textBox_hasta_tel.Clear();
            textBox_hasta_not.Clear();
            dateTimePicker_yeniHasta.Value = DateTime.Now.Date;
        }
    }
}
