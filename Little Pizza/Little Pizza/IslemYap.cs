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
    public partial class IslemYap : Form
    {
        public IslemYap()
        {
            InitializeComponent();
        }
        int sayacvp = 0;
        int sayacpp = 0;
        int sayaclp = 0;
        int sayackp = 0;
        int sayacbp = 0;
        int sayacfanta = 0;
        int sayackola = 0;
        int sayacmeyve = 0;
        int fiyat = 0;
        private void vpArttirBtn_Click(object sender, EventArgs e)
        {
            sayacvp++;
            fiyat += 40;
            vpLbl.Text = sayacvp.ToString();
            fiyatLbl.Text = fiyat.ToString() + " TL ";
        }

        private void vpAzaltBtn_Click(object sender, EventArgs e)
        {
            if (sayacvp!=0)
            {
                sayacvp--;
                fiyat -= 40;
                vpLbl.Text = sayacvp.ToString();
                fiyatLbl.Text = fiyat.ToString() + " TL ";
            }
        }

        private void ppBtnArttir_Click(object sender, EventArgs e)
        {
            sayacpp++;
            fiyat += 55;
            ppLbl.Text = sayacpp.ToString();
            fiyatLbl.Text = fiyat.ToString() + " TL ";
        }

        private void ppAzaltBtn_Click(object sender, EventArgs e)
        {
            if (sayacpp != 0)
            {
                sayacpp--;
                fiyat -= 55;
                ppLbl.Text = sayacpp.ToString();
                fiyatLbl.Text = fiyat.ToString() + " TL ";
            }
        }

        private void lpArttirBtn_Click(object sender, EventArgs e)
        {
            sayaclp++;
            fiyat += 45;
            lpLbl.Text = sayaclp.ToString();
            fiyatLbl.Text = fiyat.ToString() + " TL ";
        }

        private void lpAzaltBtn_Click(object sender, EventArgs e)
        {
            if (sayaclp != 0)
            {
                sayaclp--;
                fiyat -= 45;
                lpLbl.Text = sayaclp.ToString();
                fiyatLbl.Text = fiyat.ToString() + " TL ";
            }
        }

        private void kpArttirBtn_Click(object sender, EventArgs e)
        {
            sayackp++;
            fiyat += 50;
            kpLbl.Text = sayackp.ToString();
            fiyatLbl.Text = fiyat.ToString() + " TL ";
        }

        private void kpAzaltBtn_Click(object sender, EventArgs e)
        {      
            if (sayackp != 0)
            {
                sayackp--;
                fiyat -= 50;
                kpLbl.Text = sayackp.ToString();
                fiyatLbl.Text = fiyat.ToString() + " TL ";
            }
        }

        private void bpArttirBtn_Click(object sender, EventArgs e)
        {
            sayacbp++;
            fiyat += 55;
            bpLbl.Text = sayacbp.ToString();
            fiyatLbl.Text = fiyat.ToString() + " TL ";
        }

        private void bpAzaltBtn_Click(object sender, EventArgs e)
        {
            if (sayacbp != 0)
            {
                sayacbp--;
                fiyat -= 55;
                bpLbl.Text = sayacbp.ToString();
                fiyatLbl.Text = fiyat.ToString() + " TL ";
            }
        }

        private void fantaArttirBtn_Click(object sender, EventArgs e)
        {
            sayacfanta++;
            fiyat += 8;
            fantaLbl.Text = sayacfanta.ToString();
            fiyatLbl.Text = fiyat.ToString() + " TL ";
        }

        private void fantaAzaltBtn_Click(object sender, EventArgs e)
        {         
            if (sayacfanta != 0)
            {
                sayacfanta--;
                fiyat -= 8;
                fantaLbl.Text = sayacfanta.ToString();
                fiyatLbl.Text = fiyat.ToString() + " TL ";
            }
        }

        private void kolaArttirBtn_Click(object sender, EventArgs e)
        {
            sayackola++;
            fiyat += 10;
            kolaLbl.Text = sayackola.ToString();
            fiyatLbl.Text = fiyat.ToString() + " TL ";
        }

        private void kolaAzaltBtn_Click(object sender, EventArgs e)
        {
            if (sayackola != 0)
            {
                sayackola--;
                fiyat -= 10;
                kolaLbl.Text = sayackola.ToString();
                fiyatLbl.Text = fiyat.ToString() + " TL ";
            }
        }

        private void meyveArttirBtn_Click(object sender, EventArgs e)
        {
            sayacmeyve++;
            fiyat += 9;
            meyveLbl.Text = sayacmeyve.ToString();
            fiyatLbl.Text = fiyat.ToString() + " TL ";
        }

        private void meyveAzaltBtn_Click(object sender, EventArgs e)
        {
            if (sayacmeyve != 0)
            {
                sayacmeyve--;
                fiyat -= 9;
                meyveLbl.Text = sayacmeyve.ToString();
                fiyatLbl.Text = fiyat.ToString() + " TL ";
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            UyeGiris uyeGiris = new UyeGiris();
            this.Hide();
            uyeGiris.Show();
        }

        private void onayBtn_Click(object sender, EventArgs e)
        {

            refreshPage();
            

            int bellek;
            SqlCommand ekle = new SqlCommand("Select * from tutar ",SqlVariables.connection);
            bellek = Convert.ToInt32(ekle.ExecuteScalar());
            ekle.CommandText = "Update tutar set Tutar= '" + (fiyat + bellek).ToString() + "'";  
            ekle.ExecuteNonQuery();


            MessageBox.Show("Siparişiniz alınmıştır.");
             sayacvp = 0;
             sayacpp = 0;
             sayaclp = 0;
             sayackp = 0;
             sayacbp = 0;
             sayacfanta = 0;
             sayackola = 0;
             sayacmeyve = 0;
             fiyat = 0;
            vpLbl.Text = sayacvp.ToString();
            ppLbl.Text = sayacpp.ToString();
            lpLbl.Text = sayaclp.ToString();
            kpLbl.Text = sayackp.ToString();
            bpLbl.Text = sayacbp.ToString();
            fantaLbl.Text = sayacfanta.ToString();
            kolaLbl.Text = sayackola.ToString();
            meyveLbl.Text = sayacmeyve.ToString();
            fiyatLbl.Text = "0 TL";
        }
        public void refreshPage()
        {

            SqlCommand commandList = new SqlCommand("Select * from tutar", SqlVariables.connection);

            SqlVariables.CheckConnection(SqlVariables.connection); // bağlantıyı kontrol etmesi için fonksiyona gönderiyoruz

            SqlDataAdapter da = new SqlDataAdapter(commandList);
            DataTable dt = new DataTable();
            da.Fill(dt);

        }
    }
}
