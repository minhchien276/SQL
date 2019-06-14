using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class BUS_Sinhvien {
        DAL_Thuoc sv = new DAL_Thuoc();
        public void Insert(Thuoc sv1) {
            sv.Insert(sv1);
        }
        public void Update(Thuoc sv1) {
            sv.Update(sv1);
        }
        public void Delete(Thuoc sv1) {
            sv.Delete(sv1);
        }
        public DataTable Load2(string sql) {
            return sv.Load1(sql);
        }
    } 
}
