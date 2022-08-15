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
    public partial class UyeGiris : Form
    {
        Anasayfa anasayfa = new Anasayfa();
        KayitOl kayitOl = new KayitOl();
        IslemYap islem = new IslemYap();

        public UyeGiris()
        {
            InitializeComponent();
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
            if (textBox1.Text=="")
            {
                MessageBox.Show("Lütfen Kullanıcı adını giriniz");
            }
            else if (textBox2.Text=="")
            {
                MessageBox.Show("Lütfen Şifrenizi giriniz");
            }
            else
            {
                SqlCommand uyeCommand = new SqlCommand("Select * from pizza where KAdi=@xkadi and Sifre=@xsifre"
                    ,SqlVariables.connection);

                SqlVariables.CheckConnection(SqlVariables.connection);
                String hashedPassword = SHA256Converter.ComputeSha256Hash(textBox2.Text);
                uyeCommand.Parameters.AddWithValue("@xkadi", textBox1.Text);
                uyeCommand.Parameters.AddWithValue("@xsifre", hashedPassword);
                SqlDataAdapter da = new SqlDataAdapter(uyeCommand);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count>0)
                {
                    MessageBox.Show("Giriş Başarılı");
                    this.Hide();
                    islem.Show();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SUnut sifreunut = new SUnut();
            sifreunut.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            KAUnut kullaniciunut = new KAUnut();
            kullaniciunut.Show();
        }

        
    }
}
