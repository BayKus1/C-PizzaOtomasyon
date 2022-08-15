using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Little_Pizza.SqlClass
{
    public class SqlVariables
    {
        public static SqlConnection connection = new SqlConnection("Data Source=DESKTOP-AELSSKL\\SQLEXPRESS01;Initial Catalog=pizzaOtomasyon;Integrated Security=True");

        public static void CheckConnection(SqlConnection tempConnection)
        {
            if (tempConnection.State == ConnectionState.Closed)
            {
                tempConnection.Open();
            }
            
        }
    }
}
