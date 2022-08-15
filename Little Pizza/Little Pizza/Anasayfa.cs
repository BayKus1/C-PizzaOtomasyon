using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Little_Pizza
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            UyeGiris giris = new UyeGiris();
            giris.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminGiris giris2 = new AdminGiris();
            giris2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            KayitOl kayıt = new KayitOl();
            kayıt.Show();
        }

    }
}
