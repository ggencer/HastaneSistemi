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
    public partial class FormHastaRandevu : Form
    {
        public string tc { get; set; }
        int randevuid;
        int hastaID;
        int doktorID;
        string saat;
        public FormHastaRandevu(string tc)
        {
            InitializeComponent();
            // Giriş yapan hastanın TC numarasi forma taşınıyor
            this.tc = tc;
        }
        SqlLayer sqllayer = new SqlLayer();
        //DateTime saat = new DateTime();
        private void FormHastaRandevu_Load(object sender, EventArgs e)
        {
            label_tc.Text = tc.ToString();            
            SqlCommand cmd = sqllayer.Sqlbaglanti().CreateCommand();
            cmd.CommandText = "SELECT hasta_id, hasta_ad, hasta_soyad FROM[hasta] WHERE hasta_tc = @tc";

            cmd.Parameters.AddWithValue("@tc", tc);            
            sqllayer.Sqlbaglanti();
            cmd.ExecuteNonQuery();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                label_ad.Text = reader["hasta_ad"].ToString();
                label_soyad.Text = reader["hasta_soyad"].ToString();
                hastaID = Convert.ToInt32(reader["hasta_id"]);
            }
            
            reader.Close();
            sqllayer.SqlBaglantiKapat();

            //Mevcut randevularini göster
            randevuGoster();

            buttonRenk();
           

            label_tc.Text = tc.ToString();
            cmd.CommandText = "";
            cmd.CommandText = "SELECT doktor_id, doktor_uzmanlik FROM [doktor]";

            
            sqllayer.Sqlbaglanti();
            cmd.ExecuteNonQuery();            
            reader = cmd.ExecuteReader();
            listBox_bolum.Items.Clear();
            while (reader.Read())
            {
                listBox_bolum.Items.Add(reader["doktor_uzmanlik"].ToString());
                
            }

            reader.Close();
            sqllayer.SqlBaglantiKapat();

        }

        public void buttonRenk()
        {
            button_900.BackColor = Color.LightGray;
            button_930.BackColor = Color.LightGray;
            button_1000.BackColor = Color.LightGray;
            button_1030.BackColor = Color.LightGray;
            button_1100.BackColor = Color.LightGray;
            button1130.BackColor = Color.LightGray;
            button1300.BackColor = Color.LightGray;
            button1330.BackColor = Color.LightGray;
            button_1400.BackColor = Color.LightGray;
            button_1430.BackColor = Color.LightGray;
            button_1500.BackColor = Color.LightGray;
            button_1530.BackColor = Color.LightGray;
            button_1600.BackColor = Color.LightGray;
            button_1630.BackColor = Color.LightGray;
            button_1700.BackColor = Color.LightGray;
        }

        private void button_randevuSil_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = sqllayer.Sqlbaglanti().CreateCommand();
            cmd.CommandText = "DELETE FROM randevu WHERE randevu_id = @randevuid";
            cmd.Parameters.AddWithValue("randevuid", randevuid);
            //SqlCommand command = new SqlCommand("SELECT randevu WHERE randevu_id = '" + randevuid + "'");
            sqllayer.Sqlbaglanti();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Kayit silindi..");
            sqllayer.SqlBaglantiKapat();
            randevuGoster();
        }

        private void button_randevuEkle_Click(object sender, EventArgs e)
        {
            DateTime dt = new DateTime();
            dt = Convert.ToDateTime(dateTimePicker1.Text);
            SqlCommand cmd = sqllayer.Sqlbaglanti().CreateCommand();
            cmd.CommandText = "INSERT INTO [randevu] (randevu_hasta_id,randevu_tarihi,randevu_saati ,randevu_doktor_id) VALUES (@randevu_hasta_id,@randevu_tarihi,@randevu_saati ,@randevu_doktor_id )";
            cmd.Parameters.AddWithValue("randevu_hasta_id",hastaID);
            cmd.Parameters.AddWithValue("randevu_tarihi", dt);
            cmd.Parameters.AddWithValue("randevu_saati",saat);
            cmd.Parameters.AddWithValue("randevu_doktor_id",doktorID);
            sqllayer.Sqlbaglanti();
            cmd.ExecuteNonQuery();
            randevuGoster();
            sqllayer.SqlBaglantiKapat();
            MessageBox.Show("Randevu Kaydedildi..");


        }

        private void button_900_Click(object sender, EventArgs e)
        {
            buttonRenk();
            saat = "9:00";
            

            if (button_900.BackColor == Color.LightGray)
            {
                button_900.BackColor = Color.Green;
            }else if (button_900.BackColor == Color.Green)
            {
                button_900.BackColor = Color.LightGray;
            }
        }

        private void dataGridView_hastaRandevu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            randevuid = Convert.ToInt32( dataGridView_hastaRandevu.Rows[e.RowIndex].Cells["randevu_id"].FormattedValue.ToString());
            
        }

        public object randevuGoster()
        {
            SqlDataAdapter dataadapter = new SqlDataAdapter("SELECT randevu_id, hasta_tc , hasta_ad, hasta_soyad,[randevu_tarihi], [randevu_saati], [doktor_ad], [doktor_soyad], [doktor_uzmanlik] FROM[hasta] JOIN randevu on randevu_hasta_id = hasta_id JOIN[doktor] on randevu_doktor_id = doktor_id WHERE hasta_tc = @tc", sqllayer.connectionString);
            dataadapter.SelectCommand.Parameters.AddWithValue("@tc", tc);

            DataTable dt = new DataTable();

            sqllayer.Sqlbaglanti();
            dataadapter.Fill(dt);
            sqllayer.SqlBaglantiKapat();
            dataGridView_hastaRandevu.AutoGenerateColumns = true;
            return dataGridView_hastaRandevu.DataSource = dt;
            
        }

        private void listBox_bolum_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = sqllayer.Sqlbaglanti().CreateCommand();

            cmd.CommandText = "SELECT doktor_id, doktor_ad, doktor_soyad FROM [doktor] WHERE doktor_uzmanlik = @uzmanlik";

            string uzmanlik = listBox_bolum.SelectedItem.ToString();
            
            cmd.Parameters.AddWithValue("@uzmanlik", uzmanlik);
            sqllayer.Sqlbaglanti();
            cmd.ExecuteNonQuery();            
            SqlDataReader reader = cmd.ExecuteReader();
            listBox_doktorAdSoyad.Items.Clear();
            
            while (reader.Read())
            {
                listBox_doktorAdSoyad.Items.Add(reader["doktor_ad"].ToString() + " " + reader["doktor_soyad"].ToString());
                doktorID = Convert.ToInt32(reader["doktor_id"]);
            }

            reader.Close();
            sqllayer.SqlBaglantiKapat();
           
            
        }

        private void button_930_Click(object sender, EventArgs e)
        {
            buttonRenk();
            saat = "9:30";
           
            if (button_930.BackColor == Color.LightGray)
            {
                button_930.BackColor = Color.Green;
            }
            else if (button_930.BackColor == Color.Green)
            {
                button_930.BackColor = Color.LightGray;
            }
        }

        private void button_1000_Click(object sender, EventArgs e)
        {
            buttonRenk();
            saat = "10:00";
         
            if (button_1000.BackColor == Color.LightGray)
            {
                button_1000.BackColor = Color.Green;
            }
            else if (button_1000.BackColor == Color.Green)
            {
                button_1000.BackColor = Color.LightGray;
            }
        }

        private void button_1030_Click(object sender, EventArgs e)
        {
            buttonRenk();
            saat = "10:30";

            if (button_1030.BackColor == Color.LightGray)
            {
                button_1030.BackColor = Color.Green;
            }
            else if (button_1030.BackColor == Color.Green)
            {
                button_1030.BackColor = Color.LightGray;
            }
        }

        private void button_1100_Click(object sender, EventArgs e)
        {
            buttonRenk();
            saat = "11:00";

            if (button_1100.BackColor == Color.LightGray)
            {
                button_1100.BackColor = Color.Green;
            }
            else if (button_1100.BackColor == Color.Green)
            {
                button_1100.BackColor = Color.LightGray;
            }
        }

        private void button1130_Click(object sender, EventArgs e)
        {
            buttonRenk();
            saat = "11:30";

            if (button1130.BackColor == Color.LightGray)
            {
                button1130.BackColor = Color.Green;
            }
            else if (button1130.BackColor == Color.Green)
            {
                button1130.BackColor = Color.LightGray;
            }
        }

        private void button1300_Click(object sender, EventArgs e)
        {
            buttonRenk();
            saat = "13:00";

            if (button1300.BackColor == Color.LightGray)
            {
                button1300.BackColor = Color.Green;
            }
            else if (button1300.BackColor == Color.Green)
            {
                button1300.BackColor = Color.LightGray;
            }
        }

        private void button1330_Click(object sender, EventArgs e)
        {
            buttonRenk();
            saat = "13:30";

            if (button1330.BackColor == Color.LightGray)
            {
                button1330.BackColor = Color.Green;
            }
            else if (button1330.BackColor == Color.Green)
            {
                button1330.BackColor = Color.LightGray;
            }
        }

        private void button_1400_Click(object sender, EventArgs e)
        {
            buttonRenk();
            saat = "14:00";

            if (button_1400.BackColor == Color.LightGray)
            {
                button_1400.BackColor = Color.Green;
            }
            else if (button_1400.BackColor == Color.Green)
            {
                button_1400.BackColor = Color.LightGray;
            }
        }

        private void button_1430_Click(object sender, EventArgs e)
        {
            buttonRenk();
            saat = "14:30";

            if (button_1430.BackColor == Color.LightGray)
            {
                button_1430.BackColor = Color.Green;
            }
            else if (button_1430.BackColor == Color.Green)
            {
                button_1430.BackColor = Color.LightGray;
            }
        }

        private void button_1500_Click(object sender, EventArgs e)
        {
            buttonRenk();
            saat = "15:00";

            if (button_1500.BackColor == Color.LightGray)
            {
                button_1500.BackColor = Color.Green;
            }
            else if (button_1500.BackColor == Color.Green)
            {
                button_1500.BackColor = Color.LightGray;
            }
        }

        private void button_1530_Click(object sender, EventArgs e)
        {
            buttonRenk();
            saat = "15:30";

            if (button_1530.BackColor == Color.LightGray)
            {
                button_1530.BackColor = Color.Green;
            }
            else if (button_1530.BackColor == Color.Green)
            {
                button_1530.BackColor = Color.LightGray;
            }
        }

        private void button_1600_Click(object sender, EventArgs e)
        {
            buttonRenk();
            saat = "16:00";

            if (button_1600.BackColor == Color.LightGray)
            {
                button_1600.BackColor = Color.Green;
            }
            else if (button_1600.BackColor == Color.Green)
            {
                button_1600.BackColor = Color.LightGray;
            }
        }

        private void button_1630_Click(object sender, EventArgs e)
        {
            buttonRenk();
            saat = "16:30";

            if (button_1630.BackColor == Color.LightGray)
            {
                button_1630.BackColor = Color.Green;
            }
            else if (button_1630.BackColor == Color.Green)
            {
                button_1630.BackColor = Color.LightGray;
            }
        }

        private void button_1700_Click(object sender, EventArgs e)
        {
            buttonRenk();
            saat = "17:00";

            if (button_1700.BackColor == Color.LightGray)
            {
                button_1700.BackColor = Color.Green;
            }
            else if (button_1700.BackColor == Color.Green)
            {
                button_1700.BackColor = Color.LightGray;
            }
        }
    }
}
