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
    public partial class FrmGrafikler : Form
    {

        public FrmGrafikler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-CP28GOV\\SQLEXPRESS; Initial Catalog = personel_veri_tabani; Integrated Security = True; Encrypt=False");

        private void chart1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutg1 = new SqlCommand("select PerSehir,count(*) from Table_1 group by PerSehir",baglanti);
            SqlDataReader dr1 = komutg1.ExecuteReader();
            while (dr1.Read())
            {
                chart1.Series["Sehirler"].Points.AddXY(dr1[0], dr1[1]);
            }
            baglanti.Close();

        }

        private void chart2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutg2 = new SqlCommand("select PerMeslek ,avg(PerMaas) from Table_1 group by PerMeslek",baglanti);
            SqlDataReader dr2 = komutg2.ExecuteReader();
            while (dr2.Read())
            {
                chart2.Series["Maaslar"].Points.AddXY(dr2[0], dr2[1]);  
            }
            baglanti.Close();
        }
    }
}
