using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace Grand_Uludağ_Otel
{
    public partial class FrmOnay : Form
    {
        public FrmOnay()
        {
            InitializeComponent();
           
        }

        Random rastgele = new Random();
        public void FrmOnay_Load(object sender, EventArgs e)
        {
         
        }                
        int sayi = 4561;       
        public void BtnKod_Click(object sender, EventArgs e)
        {
            sayi = rastgele.Next(1000, 5000);
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            var mail = new MailMessage();
            mail.From = new MailAddress("*****@gmail.com");
            mail.To.Add("*******");
            mail.Subject = "ONAY KODU";
            mail.IsBodyHtml = true;
            string htmlBody;
            htmlBody = sayi.ToString();
            mail.Body = htmlBody;
            SmtpServer.Port = 587;
            SmtpServer.UseDefaultCredentials = false;
            SmtpServer.Credentials = new System.Net.NetworkCredential("Gönderen mail adresi", "Şifre");
            SmtpServer.EnableSsl = true;
            SmtpServer.Timeout = int.MaxValue;
            SmtpServer.Send(mail);
            

        }
        
        public void BtnOnay_Click(object sender, EventArgs e)
        {

            if (TxtOnay.Text == sayi.ToString())
            {
                FrmSifreGuncelle fr = new FrmSifreGuncelle();
                fr.Show();
            }

            else
            {
                MessageBox.Show("Hatalı giriş...");
            }

        }

      
    }
}
