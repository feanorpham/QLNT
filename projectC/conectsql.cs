using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Runtime.Remoting.Contexts;

namespace projectC
{
    internal class conectsql
    {
        string conect = @"Data Source=FEANOR;Initial Catalog=projectD;Integrated Security=True";
        public DataTable ExecuteQuery(string sql)
        {
            SqlConnection sqlConnection = new SqlConnection(conect);
            sqlConnection.Open();
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, sqlConnection);
            adapter.Fill(data);
            sqlConnection.Close();
            return data;
        }
        public int ExcuteNoQuery(string sql)
        {
            int record = 0;
            SqlConnection sqlConnection = new SqlConnection(conect);
            sqlConnection.Open();
            DataTable data = new DataTable();
            SqlCommand cmd = new SqlCommand(sql, sqlConnection);
            record = cmd.ExecuteNonQuery();
            sqlConnection.Close();
            return record;
        }
    }
}
