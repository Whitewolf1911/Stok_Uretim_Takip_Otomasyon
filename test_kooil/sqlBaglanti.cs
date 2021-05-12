using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace test_kooil
{
    class sqlBaglanti
    {
        public SqlConnection baglanti() {

            SqlConnection baglan = new SqlConnection(@"Data Source=WHITEWOLF\SQLEXPRESS;Initial Catalog=DB_kooil_test;Integrated Security=True");
            baglan.Open();
            return baglan;
            
        }

    }
}
