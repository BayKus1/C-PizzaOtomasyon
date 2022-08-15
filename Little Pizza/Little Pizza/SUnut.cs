using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Little_Pizza.SqlClass;
using System.Data.SqlClient;

namespace Little_Pizza
{
    public partial class SUnut : Form
    {
        UyeGiris uyeGiris = new UyeGiris();
        public SUnut()
        {
            InitializeComponent();
        }

        private void GeriBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            uyeGiris.Show();
        }

        private void CikisBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void KaydetBtn_Click(object sender, EventArgs e)
        {
            SqlVariables.CheckConnection(SqlVariables.connection);
            SqlCommand sqlCommand = new SqlCommand("Select * from pizza where AdSoyad=@pAdSoyad and KAdi=@pKAdi"
                , SqlVariables.connection);

            

            sqlCommand.Parameters.AddWithValue("@pAdSoyad", AdSoyadText.Text);
            sqlCommand.Parameters.AddWithValue("@pKAdi", KAdiText.Text);

            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                if (SifreTekrarText.Text==SifreText.Text)
                {
                    String hashedPassword = SHA256Converter.ComputeSha256Hash(SifreText.Text);
                    sqlCommand.CommandText="Update pizza set Sifre='" +hashedPassword+ "' where AdSoyad=@pAdSoyad and KAdi=@pKAdi";
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Şifre Başarıyla Güncellendi");
                    AdSoyadText.Clear();
                    KAdiText.Clear();
                    SifreText.Clear();
                    SifreTekrarText.Clear();
                }
                else
                {
                    MessageBox.Show("Girdiğiniz şifreler aynı değil. Lütfen tekrar giriniz");
                }
                
            }
            else
            {
                MessageBox.Show("Böyle bir ad soyad veya kullanıcı adı yok.");
            }

        }
    }
}
