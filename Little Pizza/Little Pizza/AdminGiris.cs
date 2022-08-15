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
    public partial class AdminGiris : Form
    {
        public AdminGiris()
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
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Kullanıcı adı bölümünü lütfen doldurunuz");
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Şifre bölümünü lütfen doldurunuz");
            }
            else
            {
                SqlCommand uyeCommand = new SqlCommand("Select * from pizzaAdmin where KAdi=@xkadi and Sifre=@xsifre"
                    , SqlVariables.connection);

                SqlVariables.CheckConnection(SqlVariables.connection);
                uyeCommand.Parameters.AddWithValue("@xkadi", textBox1.Text);
                uyeCommand.Parameters.AddWithValue("@xsifre", textBox2.Text);
                SqlDataAdapter da = new SqlDataAdapter(uyeCommand);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Giriş Başarılı");
                    this.Hide();
                    AdminIslemYap islem = new AdminIslemYap();
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
