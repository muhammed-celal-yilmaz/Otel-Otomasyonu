using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Grand_Uludağ_Otel
{
    public partial class FrmOdalar : Form
    {
        public FrmOdalar()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-HAQLQTAL\\TEW_SQLEXPRESS;Initial Catalog=GrandUludag;Integrated Security=True");

        private void FrmOdalar_Load(object sender, EventArgs e)
        {
            //************************************************ 301

            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select * from Oda301", baglanti);
            SqlDataReader oku1 = komut1.ExecuteReader();

            while (oku1.Read())
            {
                BtnOda301.Text = oku1["Adi"].ToString() + " " + oku1["Soyadi"].ToString();

            }
            baglanti.Close();
            if (BtnOda301.Text != "301")
            {
                BtnOda301.BackColor = Color.Red;
            }
            //************************************************ 302
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select * from Oda302", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();

            while (oku2.Read())
            {
                BtnOda302.Text = oku2["Adi"].ToString() + " " + oku2["Soyadi"].ToString();

            }
            baglanti.Close();
            if (BtnOda302.Text != "302")
            {
                BtnOda302.BackColor = Color.Red;
            }
            //************************************************ 303
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select * from Oda303", baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader();

            while (oku3.Read())
            {
                BtnOda303.Text = oku3["Adi"].ToString() + " " + oku3["Soyadi"].ToString();

            }
            baglanti.Close();
            if (BtnOda303.Text != "303")
            {
                BtnOda303.BackColor = Color.Red;
            }
            //************************************************ 304
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select * from Oda304", baglanti);
            SqlDataReader oku4 = komut4.ExecuteReader();

            while (oku4.Read())
            {
                BtnOda304.Text = oku4["Adi"].ToString() + " " + oku4["Soyadi"].ToString();

            }
            baglanti.Close();
            if (BtnOda304.Text != "304")
            {
                BtnOda304.BackColor = Color.Red;
            }
            //************************************************ 305
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("select * from Oda305", baglanti);
            SqlDataReader oku5 = komut5.ExecuteReader();

            while (oku5.Read())
            {
                BtnOda305.Text = oku5["Adi"].ToString() + " " + oku5["Soyadi"].ToString();

            }
            baglanti.Close();
            if (BtnOda305.Text != "305")
            {
                BtnOda305.BackColor = Color.Red;
            }
            //************************************************ 306
            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("select * from Oda306", baglanti);
            SqlDataReader oku6 = komut6.ExecuteReader();

            while (oku6.Read())
            {
                BtnOda306.Text = oku6["Adi"].ToString() + " " + oku6["Soyadi"].ToString();

            }
            baglanti.Close();
            if (BtnOda306.Text != "306")
            {
                BtnOda306.BackColor = Color.Red;
            }
            //************************************************ 307
            baglanti.Open();
            SqlCommand komut7 = new SqlCommand("select * from Oda307", baglanti);
            SqlDataReader oku7 = komut7.ExecuteReader();

            while (oku7.Read())
            {
                BtnOda307.Text = oku7["Adi"].ToString() + " " + oku7["Soyadi"].ToString();

            }
            baglanti.Close();
            if (BtnOda307.Text != "307")
            {
                BtnOda307.BackColor = Color.Red;
            }
            //************************************************ 308
            baglanti.Open();
            SqlCommand komut8 = new SqlCommand("select * from Oda308", baglanti);
            SqlDataReader oku8 = komut8.ExecuteReader();

            while (oku8.Read())
            {
                BtnOda308.Text = oku8["Adi"].ToString() + " " + oku8["Soyadi"].ToString();

            }
            baglanti.Close();
            if (BtnOda308.Text != "308")
            {
                BtnOda308.BackColor = Color.Red;
            }
            //************************************************ 309
            baglanti.Open();
            SqlCommand komut9 = new SqlCommand("select * from Oda309", baglanti);
            SqlDataReader oku9 = komut9.ExecuteReader();

            while (oku9.Read())
            {
                BtnOda309.Text = oku9["Adi"].ToString() + " " + oku9["Soyadi"].ToString();

            }
            baglanti.Close();
            if (BtnOda309.Text != "309")
            {
                BtnOda309.BackColor = Color.Red;
            }
        }
    }
}
