using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;


namespace DAL {
    public class DAL_Thuoc:DBConnect {
        public DataTable Load1(string sql) {
            return Load(sql);
        }
        public void Insert(Thuoc sv) {
            string sql = "insert into Thuoc values ('" + sv.MaT + "', '" + sv.TenT + "', '" + sv.MaLoaiT + "','"+sv.MaNCC+"','"+sv.Congdung+"','"+sv.SoLuong+"','"+sv.HSD+"','"+sv.NoiSX+"')";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Update(dt);
            dt.AcceptChanges();
        }

        public void Update(Thuoc sv) {
            string sql = "update Thuoc set TenT = '" + sv.TenT + "', MaLoaiT = '" + sv.MaLoaiT + "',MaNCC ='"+sv.MaNCC+"',Congdung ='"+sv.SoLuong+"', HSD ='"+sv.HSD+"', NoiSX ='"+sv.NoiSX+"' where MaT = '" + sv.MaT + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Update(dt);
            dt.AcceptChanges();
        }
        public void Delete(Thuoc sv) {
            string sql = "delete from Thuoc where MaT = '" + sv.MaT + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Update(dt);
            dt.AcceptChanges();
        }
    }
}
