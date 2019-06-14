using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DBConnect {
        protected SqlConnection con = new SqlConnection(@"Data Source=KIMNGAN\NGAN;Initial Catalog=QuanLyDiem;Integrated Security=True");
        public DataTable Load(string sql) {
            DataTable dt = new DataTable();
            SqlCommand comSelect = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = comSelect;
            da.Fill(dt);
            dt.AcceptChanges();
            return dt;
        }
    }
}
