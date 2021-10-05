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
    public partial class FrmSifreGuncelle : Form
    {
        public FrmSifreGuncelle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-HAQLQTAL\TEW_SQLEXPRESS;Initial Catalog=GrandUludag;Integrated Security=True");
        
        private void FrmSifreGuncelle_Load(object sender, EventArgs e)
        {

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Şifre başarıyla güncellendi...");
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update AdminGiris set Kullanici='" + TxtKullaniciAdi.Text + "',Sifre='" + TxtSifre.Text +  "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            
           
        }

       
    }
}
