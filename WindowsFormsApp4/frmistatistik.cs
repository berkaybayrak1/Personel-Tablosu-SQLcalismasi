using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp4
{
    public partial class frmistatistik : Form
    {
        public frmistatistik()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-CP28GOV\\SQLEXPRESS; Initial Catalog = personel_veri_tabani; Integrated Security = True; Encrypt=False");

        // Toplam Personel sayısı
        private void frmistatistik_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("SELECT count(*) From Table_1 ", baglanti);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                label2.Text = dr1[0].ToString();
            }

            baglanti.Close();

            // EVLİ PERSONEL SAYISI

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("SELECT count(*) From Table_1 where PerDurum=1",baglanti);
            SqlDataReader d2 = komut2.ExecuteReader();
            while (d2.Read()) 
            {
                label4.Text = d2[0].ToString();
            }
            baglanti.Close();
            
            // BEKAR PERSONEL SAYISI
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("SELECT count(*) From Table_1 where PerDurum=0", baglanti);
            SqlDataReader d3 = komut3.ExecuteReader();
            while (d3.Read())
            {
                label6.Text = d3[0].ToString();
            }
            baglanti.Close();


            //TOPLAM ŞEHİR SAYISI
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("SELECT count(distinct(PerSehir))from Table_1",baglanti);
            SqlDataReader d4 = komut4.ExecuteReader();
            while (d4.Read())
            {
                label12.Text = d4[0].ToString();
            }
            baglanti.Close() ;  
        
        
        
        
        
        // TOPLAM MAAŞ
            baglanti.Open() ;
            SqlCommand komut5 = new SqlCommand("SELECT SUM(PerMaas) FROM Table_1", baglanti);
            SqlDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read()) 
            {
                label10.Text = dr5[0].ToString();
            }
            baglanti.Close();

            //ortalama maaş
            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("SELECT AVG(PerMaas) FROM Table_1", baglanti);
            SqlDataReader d6 = komut6.ExecuteReader();
            while (d6.Read())
            {
                label11.Text = d6[0].ToString();    
            }
        
        
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
