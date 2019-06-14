using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using System.Data;

namespace DAL {
    public class DAL_KhachHang:DBConnect {
        public DataTable Load1(string sql) {
            return Load(sql);
        }
        public void Insert(KhachHang mon) {
            string sql = "insert into KhachHang values ('" + mon.MaKH + "', '" + mon.TenKH + "', '" + mon.DienThoai + "','"+mon.DiaChi+"')";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Update(dt);
            dt.AcceptChanges();
        }
        public void Update(KhachHang mon) {
            string sql = "update KhachHang set TenKH = '" + mon.TenKH + "', DienTHoai = '" + mon.DienThoai + "', DiaChi = '"+mon.DiaChi+"' where MaKH = '" + mon.MaKH + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Update(dt);
            dt.AcceptChanges();
        }
        public void Delete(KhachHang mon) {
            string sql = "delete from KhachHang where MaKH = '" + mon.MaKH + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Update(dt);
            dt.AcceptChanges();
        }
    }
}
