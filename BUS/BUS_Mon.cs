using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;

namespace BUS {
    public class BUS_Mon {
        DAL_KhachHang mon = new DAL_KhachHang();
        public void Insert(KhachHang monhoc) {
            mon.Insert(monhoc);
        }
        public void Update(KhachHang monhoc) {
            mon.Update(monhoc);
        }
        public void Delete(KhachHang monhoc) {
            mon.Delete(monhoc);
        }
        public DataTable Load2(string sql) {
            return mon.Load1(sql);
        }
    }
}
