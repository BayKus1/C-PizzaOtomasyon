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
    public partial class AdminIslemYap : Form
    {
        public AdminIslemYap()
        {
            InitializeComponent();
        }
        AdminGiris admingrs = new AdminGiris();
        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Hide();
            admingrs.Show();
        }

        private void AdminIslemYap_Load(object sender, EventArgs e)
        {
            refreshPage();
            SqlCommand commandList = new SqlCommand("Select * from tutar", SqlVariables.connection);
            kasaLbl.Text = commandList.ExecuteScalar().ToString() + " TL ";
            commandList.ExecuteNonQuery();

        }

        public void refreshPage()
        {

            SqlCommand commandList = new SqlCommand("Select * from tutar", SqlVariables.connection);

            SqlVariables.CheckConnection(SqlVariables.connection); // bağlantıyı kontrol etmesi için fonksiyona gönderiyoruz

            SqlDataAdapter da = new SqlDataAdapter(commandList);
            DataTable dt = new DataTable();
            da.Fill(dt);

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
