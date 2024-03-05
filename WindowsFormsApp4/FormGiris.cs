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
    public partial class FormGiris : Form
    {
        public FormGiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-CP28GOV\\SQLEXPRESS; Initial Catalog = personel_veri_tabani; Integrated Security = True; Encrypt=False");

        private void btnGiris_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From Tbl_Yonetici where KullanciAd=@p1 and Sifre=@p2", baglanti);
            komut.Parameters.AddWithValue("@p1", textBox1.Text);
            komut.Parameters.AddWithValue("@p2", textBox2.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmAnaForm frm  = new FrmAnaForm();
                frm.Show();
                this.Hide();    

            }
            else
            {
                MessageBox.Show("Kullanıcı Adı ya da Şifre Hatalı !!");
            }
            baglanti.Close();
        }
    }
}
