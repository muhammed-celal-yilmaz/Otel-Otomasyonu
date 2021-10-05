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
    public partial class FrmGelirGider : Form
    {
        public FrmGelirGider()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-HAQLQTAL\\TEW_SQLEXPRESS;Initial Catalog=GrandUludag;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            // Personel
            int personel;
            personel = Convert.ToInt16(textBox1.Text);
            LblPersonelMaas.Text = (personel * 3500).ToString();

            int sonuc;
            sonuc = Convert.ToInt32(LblKasaToplam.Text) - (Convert.ToInt32(LblPersonelMaas.Text) + Convert.ToInt32(LblAlinanUrunler.Text) + Convert.ToInt32(LblFaturalar.Text));
            LblSonuc.Text = sonuc.ToString();
        }

        private void FrmGelirGider_Load(object sender, EventArgs e)
        {
            // Kasadaki Tutar
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select sum(Ucret) as toplam from MusteriEkle", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                LblKasaToplam.Text = oku["toplam"].ToString();
            }
            baglanti.Close();

            // Alınan Ürünler
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select sum(Gida+İcecek+Cerezler) as toplam1 from Stoklar", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                LblAlinanUrunler.Text = oku2["toplam1"].ToString();
               
            }
            baglanti.Close();

            // Elektrik
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("Select sum(Elektrik+Su+İnternet) as toplam2 from Faturalar", baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                LblFaturalar.Text = oku3["toplam2"].ToString();

            }
            baglanti.Close();

        }


    }
}
