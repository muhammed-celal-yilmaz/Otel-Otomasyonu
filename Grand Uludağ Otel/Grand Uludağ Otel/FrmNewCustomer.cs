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
    public partial class FrmNewCustomer : Form
    {
        public FrmNewCustomer()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-HAQLQTAL\\TEW_SQLEXPRESS;Initial Catalog=GrandUludag;Integrated Security=True");
       

        private void BtnOda301_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "301";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda301 (Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda302_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "302";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda302 (Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();

        }

        private void BtnOda303_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "303";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda303 (Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();

        }

        private void BtnOda304_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "304";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda304 (Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();

        }

        private void BtnOda305_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "305";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda305 (Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();

        }

        private void BtnOda306_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "306";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda306 (Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();

        }

        private void BtnOda307_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "307";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda307 (Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();

        }

        private void BtnOda308_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "308";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda308 (Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();

        }

        private void BtnOda309_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "309";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda309 (Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();

        }

        private void BtnBosOda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yeşil renk,boş odaları gösterir.");
        }

        private void BtnDoluOda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kırmızı renk,dolu odaları gösterir.");

        }

        private void DtpCikisTarihi_ValueChanged(object sender, EventArgs e)
        {

            int fiyat;
            DateTime KucukTarih = Convert.ToDateTime(DtpGirisTarihi.Text);
            DateTime BuyukTarih = Convert.ToDateTime(DtpCikisTarihi.Text);

            TimeSpan Sonuc;
            Sonuc = BuyukTarih - KucukTarih;

            label11.Text = Sonuc.TotalDays.ToString();
            fiyat = Convert.ToInt32(label11.Text) *1000 ;
            TxtUcret.Text = fiyat.ToString();



        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand komut =  new SqlCommand("insert into MusteriEkle (Adi,Soyadi,Cinsiyet,Telefon,Mail,TC,OdaNo,Ucret,GirisTarihi,CikisTarihi) values('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "','" + comboBox1.Text + "','"+MskTxtTelefon.Text+"','"+TxtMail.Text+"','"+TxtKimlikNo.Text+"','"+TxtOdaNo.Text+"','"+TxtUcret.Text+"','"+DtpGirisTarihi.Value.ToString("yyyy-MM-dd")+"','"+DtpCikisTarihi.Value.ToString("yyyy-MM-dd")+"')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Müşteri Kaydı Yapıldı...");

        }
        
       private void groupBox2_Enter(object sender,EventArgs e)
        {

        }

      
        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void FrmNewCustomer_Load(object sender, EventArgs e)
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
                BtnOda301.Enabled = false;

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
                BtnOda302.Enabled = false;
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
                BtnOda303.Enabled = false;
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
                BtnOda304.Enabled = false;
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
                BtnOda305.Enabled = false;
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
                BtnOda306.Enabled = false;
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
                BtnOda307.Enabled = false;
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
                BtnOda308.Enabled = false;
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
                BtnOda309.Enabled = false;
            }
        }
    }

  }

// Data Source=LAPTOP-HAQLQTAL\TEW_SQLEXPRESS;Initial Catalog=GrandUludag;Integrated Security=True