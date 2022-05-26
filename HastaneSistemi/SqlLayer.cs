using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace HastaneSistemi
{
    public class SqlLayer
    {
       public string connectionString = "Data Source=localhost;Initial Catalog=hbs_db;Integrated Security=True";
        

        public SqlConnection Sqlbaglanti()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
                return conn;
            }
            conn.Open();
            return conn;
        }
      
        public SqlConnection SqlBaglantiKapat()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
                return conn;
            }
            conn.Close();
            return conn;
        }
    }
}
