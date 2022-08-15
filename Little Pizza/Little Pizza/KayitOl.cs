using Little_Pizza.SqlClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Little_Pizza
{
    public partial class KayitOl : Form
    {
        Anasayfa anasayfa = new Anasayfa();
        public KayitOl()
        {
            InitializeComponent();
        }
        private void KayıtOl_Load(object sender, EventArgs e)
        {
            
            refreshPage();
            /*
            
            SqlDataAdapter da = new SqlDataAdapter(commandList);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
             
             */
        }
        public void refreshPage()
        {

            SqlCommand commandList = new SqlCommand("Select * from pizza", SqlVariables.connection);

            SqlVariables.CheckConnection(SqlVariables.connection); // bağlantıyı kontrol etmesi için fonksiyona gönderiyoruz

            SqlDataAdapter da = new SqlDataAdapter(commandList);
            DataTable dt = new DataTable();
            da.Fill(dt);
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            anasayfa.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (AdSoyadText.Text == "")
            {
                MessageBox.Show("Ad Soyad bölümünü lütfen doldurunuz");
            }
            else if (YasText.Text == "")
            {
                MessageBox.Show("Yaş bölümünü lütfen doldurunuz");
            }
            else if (KAdiText.Text == "")
            {
                MessageBox.Show("Kullanıcı adı bölümünü lütfen doldurunuz");
            }
            else if (SifreText.Text == "")
            {
                MessageBox.Show("Şifre bölümünü lütfen doldurunuz");
            }
            else if (SifreTekrarText.Text == "")
            {
                MessageBox.Show("Şifre tekrar bölümünü lütfen doldurunuz");
            }
            else if (AdresText.Text == "")
            {
                MessageBox.Show("Adres bölümünü lütfen doldurunuz");
            }
            else if (ErkekRdBtn.Checked!=true && KadınRdBtn.Checked!=true)
            {
                MessageBox.Show("Lütfen cinsiyetinizi belirtiniz");
            }
            else if(SifreText.Text!=SifreTekrarText.Text)
            {
                MessageBox.Show("Girdiğiniz şifreler aynı değil\nLütfen kontrol edin");
            }
            else 
            {

                SqlCommand ekle = new SqlCommand("Insert into pizza " +
                    "(AdSoyad,Yas,Cinsiyet,KAdi,Sifre,Adres) values(@xadsoyad,@xYas,@xcinsiyet,@xkadi,@xsifre,@xadres)",
                    SqlVariables.connection);

                SqlVariables.CheckConnection(SqlVariables.connection);


                ekle.Parameters.AddWithValue("@xadsoyad", AdSoyadText.Text);
                ekle.Parameters.AddWithValue("@xYas", YasText.Text);

                if (ErkekRdBtn.Checked==true)
                {
                    
                    ekle.Parameters.AddWithValue("@xcinsiyet", "Erkek");
                }
                else if (KadınRdBtn.Checked == true)
                {
                    
                    ekle.Parameters.AddWithValue("@xcinsiyet", "Kadın");
                }

                ekle.Parameters.AddWithValue("@xkadi", KAdiText.Text);

                if (SifreText.Text==SifreTekrarText.Text)
                {
                    String hashedPassword = SHA256Converter.ComputeSha256Hash(SifreText.Text);
                    ekle.Parameters.AddWithValue("@xsifre", hashedPassword);
                }

                ekle.Parameters.AddWithValue("@xadres", AdresText.Text);
                ekle.ExecuteNonQuery();
                refreshPage();

                MessageBox.Show("Kaydınız başarıyla tamamlanmıştır.");
                SqlVariables.connection.Close();
                this.Hide();
                anasayfa.Show();
            }
        }

        
    }
}
