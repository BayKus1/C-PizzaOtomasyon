using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using Little_Pizza.SqlClass;
using System.Data.SqlClient;

namespace Little_Pizza
{
    public partial class KAUnut : Form
    {
        
        public KAUnut()
        {
            InitializeComponent();
        }

        

        private void btnOnay_Click(object sender, EventArgs e)
        {
            SqlVariables.CheckConnection(SqlVariables.connection);
            SqlCommand update = new SqlCommand("Select * from pizza where AdSoyad=@xAdSoyad and " +
                    "Yas=@xYas", SqlVariables.connection);

            update.Parameters.AddWithValue("@xAdSoyad", adSoyadText.Text);
            update.Parameters.AddWithValue("@xYas", yasText.Text);

            SqlDataAdapter da = new SqlDataAdapter(update);
            DataTable dt = new DataTable();
            da.Fill(dt);

            
                if (adSoyadText.Text == "")
                {
                    MessageBox.Show("Lütfen adınızı ve soyadınızı giriniz.");
                }
                else if (yasText.Text == "")
                {
                    MessageBox.Show("Lütfen yaşınızı giriniz.");
                }
                else if (kAdiText.Text == "")
                {
                    MessageBox.Show("Lütfen kullanıcı adınızı giriniz.");
                }
                else if (kAdiTekText.Text == "")
                {
                    MessageBox.Show("Lütfen kullanıcı adınızın tekrarını giriniz.");
                }
                else
                {
                    if (dt.Rows.Count > 0)
                    {
                        if (kAdiText.Text == kAdiTekText.Text)
                        {
                        update.CommandText = "Update pizza set KAdi= '" + kAdiText.Text + "' where AdSoyad=@xAdSoyad and " +
                        "Yas=@xYas";
                        update.ExecuteNonQuery();
                        MessageBox.Show("Kullanıcı adınız başarıyla güncellendi.");
                        }
                        else
                        {
                        MessageBox.Show("Kullanıcı adları aynı girilmedi");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bu ad ve soyadda girdiğiniz yaş değerinde birisi bulunamadı.");
                    }
                }            
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Hide();
            UyeGiris uyeGiris = new UyeGiris();
            uyeGiris.Show();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
